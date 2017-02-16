Option Explicit On
Imports System.Runtime.InteropServices
Public Module modMemory

    Public forceEND As Boolean
    Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As AccessFlags, _
                                                            ByVal bInheritHandle As Integer, _
                                                            ByVal dwProcessId As Integer) As IntPtr
    Private Enum AccessFlags As UInteger
        PROCESS_ALL = &H1F0FFF
        PROCESS_TERMINATE = &H1
        PROCESS_CREATETHREAD = &H2
        PROCESS_VMOPERATION = &H8
        PROCESS_VMREAD = &H10
        PROCESS_VMWRITE = &H20
        PROCESS_DUPHANDLE = &H40
        PROCESS_SETINFORMATION = &H200
        PROCESS_QUERYINFORMATION = &H400
        PROCESS_SYNCHRONIZE = &H100000
    End Enum
    Private Declare Function ReadProcessMemory Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemoryB Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemoryL Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemoryD Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Double, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As IntPtr) As Boolean
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr
    Private Declare Sub GetSystemInfo Lib "kernel32.dll" (ByRef lpSystemInfo As SYSTEM_INFO)
    Private Const PROCESS_VM_READ As Integer = (&H10)
    Private Const PROCESS_VM_WRITE As Integer = (&H20)
    Private Const PROCESS_VM_OPERATION As Integer = (&H8)
    Private Const PROCESS_QUERY_INFORMATION As Integer = (&H400)
    Private Const PROCESS_READ_WRITE_QUERY As Integer = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION
    Private Const MEM_PRIVATE As UInt32 = &H20000
    Private Const MEM_COMMIT As UInt32 = &H1000

    <StructLayout(LayoutKind.Sequential)> Private Structure SYSTEM_INFO
        Public dwOemId As UInt32
        Public dwPageSize As UInt32
        Public lpMinimumApplicationAddress As UInt32
        Public lpMaximumApplicationAddress As UInt32
        Public dwActiveProcessorMask As UInt32
        Public dwNumberOfProcessors As UInt32
        Public dwProcessorType As UInt32
        Public dwAllocationGranularity As UInt32
        Public dwProcessorLevel As UInt32
        Public dwProcessorRevision As UInt32
    End Structure

    <StructLayout(LayoutKind.Sequential)> Private Structure MEMORY_BASIC_INFORMATION
        Public BaseAddress As IntPtr
        Public AllocationBase As IntPtr
        Public AllocationProtect As UInteger
        Public RegionSize As IntPtr
        Public State As UInteger
        Public Protect As UInteger
        Public Type As UInteger
    End Structure

    Private Enum MemoryAllocationType As UInt32
        MEM_IMAGE = &H1000000
        MEM_MAPPED = &H40000
        MEM_PRIVATE = &H20000
    End Enum

    Private Enum MemoryAllocationState As UInt32
        Commit = &H1000
        Reserve = &H2000
        Decommit = &H4000
        Release = &H8000
        Reset = &H80000
        Physical = &H400000
        TopDown = &H100000
        WriteWatch = &H200000
        LargePages = &H20000000
    End Enum

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Sub GetClassName(ByVal hWnd As System.IntPtr, _
   ByVal lpClassName As System.Text.StringBuilder, ByVal nMaxCount As Integer)

    End Sub

    Private Declare Function VirtualQueryEx Lib "kernel32" Alias "VirtualQueryEx" (ByVal hProcess As IntPtr, _
                                                                                  ByVal lpAddress As UInt32, _
                                                                                  ByRef lpBuffer As MEMORY_BASIC_INFORMATION, _
                                                                                  ByVal dwLength As Integer) As Integer

    Public LastProcessID As Integer
    Public LastProcessBASE As Integer
    Public LastProcessMSIZE As Integer
    Public LastProcessABASE As Integer

    Private Function IntPtrToLong(ByVal ptr As IntPtr) As Long
        Dim res As Long
        res = ptr
        IntPtrToLong = res
    End Function
    Private Function GetRegionSize2(ByVal targetProcessHandle As IntPtr, ByVal MatchBase As IntPtr) As IntPtr
        Dim ThreadsTurn As Integer = 0
        Dim SysInfo As New SYSTEM_INFO
        Dim mbi As New MEMORY_BASIC_INFORMATION
        Dim MemInfoSize As Integer
        GetSystemInfo(SysInfo)
        Dim StartBlock As UInt32 = SysInfo.lpMinimumApplicationAddress
        Dim EndBlock As UInt32 = SysInfo.lpMaximumApplicationAddress
        Dim CurBlock As UInt32 = StartBlock
        Dim res As Integer
        Dim resf As IntPtr
        Dim resa As IntPtr
        MemInfoSize = Marshal.SizeOf(mbi)
        Do While CurBlock < EndBlock
            mbi.RegionSize = 0
            res = VirtualQueryEx(targetProcessHandle, CurBlock, mbi, MemInfoSize)
            If res = 0 Then
                GetRegionSize2 = 0
                Exit Function
            ElseIf res = MemInfoSize Then
                If mbi.BaseAddress = MatchBase Then

                    resf = mbi.RegionSize
                    resa = mbi.AllocationBase
                End If
            End If
            CurBlock = CInt(mbi.BaseAddress) + CInt(mbi.RegionSize)
        Loop
        LastProcessABASE = resa
        GetRegionSize2 = resf
    End Function

    Public Function GetWindowClass(ByVal hwnd As Long) As String
        Dim sClassName As New System.Text.StringBuilder("", 256)
        Call GetClassName(hwnd, sClassName, 256)
        Return sClassName.ToString
    End Function

    Public Function GetRegionSize(ByVal pid As Integer, ByVal MatchBase As IntPtr) As IntPtr
        Dim res As Long
        Dim TibiaHandle As IntPtr
        Try
            TibiaHandle = OpenProcess(PROCESS_READ_WRITE_QUERY, 0, pid)
            res = GetRegionSize2(TibiaHandle, MatchBase)
            CloseHandle(TibiaHandle)
            GetRegionSize = res
            Exit Function
        Catch ex As Exception
            GetRegionSize = 0
        End Try
    End Function

    Public Function Memory_ReadLong(ByVal pid As Integer, ByVal AddressWinXP As Integer, Optional ByVal modBase As Long = -1, Optional ByVal DirectMode As Boolean = False) As Integer
        Dim RBuff As Long
        Dim GoodAddress As Integer
        Dim TibiaHandle As IntPtr
        If modBase = -1 Then
            modBase = LastProcessBASE
        End If
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            If DirectMode = True Then
                GoodAddress = AddressWinXP
            Else
                GoodAddress = AddressWinXP + modBase - &H400000
            End If
            ReadProcessMemory(TibiaHandle, GoodAddress, RBuff, 4, 0)
            CloseHandle(TibiaHandle)
            Memory_ReadLong = RBuff
            Exit Function
        Catch ex As Exception
            Memory_ReadLong = -1
        End Try
    End Function


    Public Function readMemoryStringVBNET(ByVal pid As Integer, ByVal AddressWinXP As Integer, _
                                          Optional ByVal modBase As Long = -1, Optional ByVal DirectMode As Boolean = True,
                                          Optional ByVal maxread As Integer = 255) As String
        Dim b As Byte
        Dim strString As String
        Dim posM As Integer
        Dim i As Integer
        strString = ""
        posM = 0
        i = 0
        Do
            If i = maxread Then
                readMemoryStringVBNET = strString
                Exit Function
            End If
            b = Memory_ReadByte(pid, AddressWinXP + posM, modBase, DirectMode)
            posM = posM + 1
            i = i + 1
            If b <> 0 Then
                strString = strString & Chr(b)
            End If
        Loop Until b = &H0
        readMemoryStringVBNET = strString
    End Function

    Public Function Memory_ReadByte(ByVal pid As Integer, ByVal AddressWinXP As Integer, Optional ByVal modBase As Long = -1, Optional ByVal DirectMode As Boolean = False) As Byte
        Dim RBuff As Byte
        Dim GoodAddress As Long
        Dim TibiaHandle As IntPtr
        If modBase = -1 Then
            modBase = LastProcessBASE
        End If
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            If DirectMode = True Then
                GoodAddress = AddressWinXP
            Else
                GoodAddress = AddressWinXP + modBase - &H400000
            End If
            ReadProcessMemoryB(TibiaHandle, GoodAddress, RBuff, 1, 0)
            CloseHandle(TibiaHandle)
            Memory_ReadByte = RBuff
            Exit Function
        Catch ex As Exception
            Memory_ReadByte = &HFF
        End Try
    End Function
    Public Function GetTibiaWindowOpen() As Boolean
        If GetForegroundWindow = GetTibiaHwnd() Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetMainModuleBaseAddress(ByRef expectedName As String, Optional ByRef expectedClass As String = "") As Integer
        Dim TempBaseAddress As Integer
        Dim ubproc As Long
        Dim hwnd As Long
        Dim currentclass As String
        Try
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)
            ubproc = UBound(proc)
            If ubproc < 0 Then
                GetMainModuleBaseAddress = 0
                Exit Function
            End If
            If expectedClass = "" Then
                TempBaseAddress = proc(0).MainModule.BaseAddress
                LastProcessBASE = TempBaseAddress
                GetMainModuleBaseAddress = TempBaseAddress
                Exit Function
            Else
                For i As Integer = 0 To ubproc
                    hwnd = proc(i).MainWindowHandle
                    currentclass = GetWindowClass(hwnd)
                    If currentclass = expectedClass Then
                        TempBaseAddress = proc(i).MainModule.BaseAddress
                        LastProcessBASE = TempBaseAddress
                        GetMainModuleBaseAddress = TempBaseAddress
                        Exit Function
                    End If
                Next
                ' Not found
                GetMainModuleBaseAddress = 0
                Exit Function
            End If
        Catch ex As Exception
            GetMainModuleBaseAddress = 0
        End Try
    End Function

    Public Function GetMainModuleRegionSize(ByRef expectedName As String, Optional ByRef expectedClass As String = "", Optional ByVal SkipFirstModuleBytes As Integer = 0) As IntPtr
        Dim ubproc As Long
        Dim hwnd As Long
        Dim currentclass As String
        Dim matchbase As IntPtr
        Dim skipthis As IntPtr
        Dim resSize As IntPtr
        skipthis = SkipFirstModuleBytes
        Try
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)
            ubproc = UBound(proc)
            If ubproc < 0 Then
                GetMainModuleRegionSize = 0
                Exit Function
            End If
            If expectedClass = "" Then ' read first process that have our expected name
                matchbase = CInt(proc(0).MainModule.BaseAddress) + CInt(skipthis)
                resSize = GetRegionSize(proc(0).Id, matchbase)
                LastProcessMSIZE = resSize
                GetMainModuleRegionSize = resSize
                Exit Function
            Else
                For i As Integer = 0 To ubproc
                    hwnd = proc(i).MainWindowHandle
                    currentclass = GetWindowClass(hwnd)
                    If currentclass = expectedClass Then ' read first process that have our expected name and expected class
                        matchbase = CInt(proc(i).MainModule.BaseAddress) + CInt(skipthis)
                        resSize = GetRegionSize(proc(i).Id, matchbase)
                        LastProcessMSIZE = resSize
                        GetMainModuleRegionSize = resSize
                        Exit Function
                    End If
                Next
                ' Not found
                GetMainModuleRegionSize = 0
                Exit Function
            End If
        Catch ex As Exception
            GetMainModuleRegionSize = 0
        End Try
    End Function


    Public Function GetPid(ByRef expectedName As String, Optional ByRef expectedClass As String = "") As Integer
        Dim pid As Integer
        Dim ubproc As Long
        Dim hwnd As Long
        Dim currentclass As String
        Try
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)
            ubproc = UBound(proc)
            If ubproc < 0 Then
                GetPid = -1
                Exit Function
            End If
            If expectedClass = "" Then
                pid = proc(0).Id
                LastProcessID = pid
                GetPid = pid
                Exit Function
            Else
                For i As Integer = 0 To ubproc
                    hwnd = proc(i).MainWindowHandle
                    currentclass = GetWindowClass(hwnd)
                    If currentclass = expectedClass Then
                        pid = proc(i).Id
                        LastProcessID = pid
                        GetPid = pid
                        Exit Function
                    End If
                Next
                GetPid = -1
                Exit Function
            End If
        Catch ex As Exception
            GetPid = -1
        End Try
    End Function

    Public Function GetMainHWND(ByRef expectedName As String, ByRef expectedPID As Integer) As Integer
        Dim ubproc As Long
        Dim hwnd As Long
        Dim currentclass As String
        Try
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)
            ubproc = UBound(proc)
            If ubproc < 0 Then
                GetMainHWND = -1
                Exit Function
            End If

            For i As Integer = 0 To ubproc
                hwnd = proc(i).MainWindowHandle
                currentclass = GetWindowClass(hwnd)
                If proc(i).Id = expectedPID Then
                    GetMainHWND = hwnd
                    Exit Function
                End If
            Next
            GetMainHWND = -1
            Exit Function

        Catch ex As Exception
            GetMainHWND = -1
        End Try
    End Function

    Public Function GetTibiaProcessHandle() As Long
        Try
            Dim Processlist() As Process
            Dim processName As String = "Tibia"
            Processlist = Process.GetProcessesByName(processName)
            GetTibiaProcessHandle = Processlist(0).Handle.ToInt32
        Catch ex As Exception
            GetTibiaProcessHandle = 0
        End Try
    End Function

    Public Function GetTibiaHwnd() As Long
        Try
            Dim Processlist() As Process
            Dim processName As String = "Tibia"
            Processlist = Process.GetProcessesByName(processName)
            Return Processlist(0).MainWindowHandle
        Catch ex As Exception
            GetTibiaHwnd = 0
        End Try
    End Function

    Public Function MaxValue(ByVal Value1 As Long, ByVal Value2 As Long) As Long
        If Value1 >= Value2 Then
            MaxValue = Value1
        Else
            MaxValue = Value2
        End If
    End Function

    Public Function GoodHex(ByVal b As Byte) As String
        Dim res As String
        res = Hex(b)
        If Len(res) = 1 Then
            GoodHex = "0" & res 'add a zero if VB conversion only return 1 character
        Else
            GoodHex = res
        End If
    End Function

    Public Sub UpdateOpenCharsIdInfo(ByRef expectedName As String, Optional ByRef expectedClass As String = "")
        Dim ubproc As Long
        Dim hwnd As IntPtr
        Dim currentclass As String
        Dim strChar As String
        Dim idInfo As TypeCharIdInfo
        Dim i As Integer
        dictCharIdInfo.Clear()
        Try
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)
            ubproc = UBound(proc)
            If ubproc < 0 Then

                Exit Sub
            End If
            For i = 0 To ubproc

                hwnd = proc(i).MainWindowHandle
                currentclass = GetWindowClass(hwnd)


                idInfo.pid = proc(i).Id
                idInfo.mainHandle = hwnd
                strChar = ReadCurrentCharName(idInfo.pid, adrSelectedCharName)
                'Debug.Print("PID " & CStr(proc(i).Id) & " HWND " & CStr(hwnd) & " STRCHAR " & strChar)
                If Not (strChar = "") Then
                    dictCharIdInfo(strChar) = idInfo
                End If

            Next i
            ' nothing else found
            Exit Sub

        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
End Module

Option Explicit On

Imports System.Runtime.InteropServices

Module modTibia11Functions
    Private Const fastMode As Boolean = True

    Private Const WM_MOUSEMOVE = &H200
    Private Const WM_LBUTTONDOWN = &H201     'Button down
    Private Const WM_LBUTTONUP = &H202       'Button up
    Private Const WM_LBUTTONDBLCLK = &H203   'Double-click
    Private Const WM_RBUTTONDOWN = &H204     'Button down
    Private Const WM_RBUTTONUP = &H205       'Button up
    Private Const WM_RBUTTONDBLCLK = &H206   'Double-click

    Private Structure POINTAPI 'Type to hold coordinates
        Public x As Integer
        Public y As Integer
    End Structure

    Private Const MAPVK_VK_TO_VSC As Integer = &H0
    Private Const MAPVK_VSC_TO_VK As Integer = &H1
    Private Const MAPVK_VK_TO_CHAR As Integer = &H2
    Private Const MAPVK_VSC_TO_VK_EX As Integer = &H3
    Private Const MAPVK_VK_TO_VSC_EX As Integer = &H4

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Private Const SWP_NOMOVE As Short = &H2
    Private Const SWP_NOSIZE As Short = 1
    Private Const SWP_NOZORDER As Short = &H4

    Private Const SWP_SHOWWINDOW As Short = &H40
  

    Public emptyKeyboardState() As Byte

    Public myKeysConverter As KeysConverter = New KeysConverter()

    Private Declare Sub GetCursorPos Lib "user32" (lpPoint As POINTAPI)

    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, _
                                                     ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, _
                                                     ByVal cy As Integer, ByVal wFlags As Integer) As Integer


    Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As AccessFlags, _
                                                        ByVal bInheritHandle As Integer, _
                                                        ByVal dwProcessId As Integer) As IntPtr

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function SetKeyboardState(ByVal lpKeyState() As Byte) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Public Function GetWindowThreadProcessId(ByVal hwnd As IntPtr, _
                          ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Public Function AttachThreadInput(ByVal idAttach As System.UInt32, ByVal idAttachTo As System.UInt32, ByVal fAttach As Boolean) As Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Public Function GetCurrentThreadId() As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="VkKeyScanEx", CharSet:=CharSet.Unicode)>
    Public Function GetKeyCode(
                   ByVal c As Char,
                   Optional ByVal KeyboardLayout As UIntPtr = Nothing
     ) As Short
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function MapVirtualKey(ByVal uCode As Integer, ByVal nMapType As Integer) As Integer
    End Function

    <DllImport("user32.dll", ExactSpelling:=True)>
    Public Function GetKeyboardState(ByVal keyStates() As Byte) As Boolean
    End Function

    Private Declare Function PostMessage Lib "user32.dll" Alias "PostMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr

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
    'Private Declare Function ReadProcessMemoryI Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Private Declare Function ReadProcessMemoryB Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer


    Private Declare Function WriteProcessMemory Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Byte, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer


    Private Declare Function WriteProcessMemoryI Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer


    'Private Declare Function ReadProcessMemoryL Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Long, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer

    Private Const PROCESS_VM_READ As Integer = (&H10)
    Private Const PROCESS_VM_WRITE As Integer = (&H20)
    Private Const PROCESS_VM_OPERATION As Integer = (&H8)
    Private Const PROCESS_QUERY_INFORMATION As Integer = (&H400)
    Private Const PROCESS_READ_WRITE_QUERY As Integer = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION
    Private Const MEM_PRIVATE As UInt32 = &H20000
    Private Const MEM_COMMIT As UInt32 = &H1000
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As IntPtr) As Boolean
    Public moduleDictionary As Dictionary(Of String, Long) = New Dictionary(Of String, Long)

    Public Const CTE_NOT_CONNECTED As Integer = 0
    Public Const CTE_LOGIN_CHAR_SELECTION As Integer = 1
    Public Const CTE_CONNECTING As Integer = 2
    Public Const CTE_GAME_CONNECTED As Integer = 3
    Public Structure TibiaServerEntry
        Public id As Integer
        Public name As String
        Public url As String
        Public port As Integer
        Public name_adr As Integer
        Public url_adr As Integer
    End Structure
    Public Structure TibiaSkillEntry
        Public id As Integer
        Public name As String
        Public current_skill As Integer
        Public base_skill As Integer
        Public percent_to_go As Byte
    End Structure
    Public Structure TibiaCharListEntry
        Public id As Integer
        Public name As String
        Public server As String
        Public entry_address As Integer
        Public name_address As Integer
        Public raw_bytes() As Byte
    End Structure



    Public Sub QMemory_ReadNBytes(ByVal pid As Integer, ByVal finalAddress As Integer, ByRef RBuff() As Byte)
        Dim usize As Integer
        Dim TibiaHandle As IntPtr
        Try
            usize = RBuff.Length - 1
            If (usize < 1) Then
                Exit Sub
            End If
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            ReadProcessMemoryB(TibiaHandle, finalAddress, RBuff(0), usize, 0)
            CloseHandle(TibiaHandle)
            Exit Sub
        Catch ex As Exception
            Debug.Print("Error at QMemory_ReadNBytes:" & ex.ToString())
        End Try
    End Sub

    Public Function QMemory_Read4Bytes(ByVal pid As Integer, ByVal finalAddress As Integer) As Integer
        Dim RBuff(3) As Byte
        Dim TibiaHandle As IntPtr
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            ReadProcessMemoryB(TibiaHandle, finalAddress, RBuff(0), 4, 0)
            CloseHandle(TibiaHandle)
            QMemory_Read4Bytes = BitConverter.ToInt32(RBuff, 0)
            Exit Function
        Catch ex As Exception
            QMemory_Read4Bytes = -1
        End Try
    End Function

    Public Function QMemory_Write4Bytes(ByVal pid As Integer, ByVal finalAddress As Integer, ByVal newValue As Integer) As Integer
        Dim TibiaHandle As IntPtr
        Dim res As Integer
        Dim lpNumberOfBytesWritten As Integer = 0
        Try
            TibiaHandle = OpenProcess(AccessFlags.PROCESS_ALL, 0, pid)
            res = WriteProcessMemoryI(TibiaHandle, finalAddress, newValue, 4, lpNumberOfBytesWritten)
            If (res = 1) Then
                CloseHandle(TibiaHandle)
                Return 0
            Else
                CloseHandle(TibiaHandle)
                Return -1
            End If
            Exit Function
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function QMemory_Write1Byte(ByVal pid As Integer, ByVal finalAddress As Integer, ByVal newValue As Byte) As Integer
        Dim TibiaHandle As IntPtr
        Dim res As Integer
        Dim lpNumberOfBytesWritten As Integer = 0
        Try
            TibiaHandle = OpenProcess(AccessFlags.PROCESS_ALL, 0, pid)
            res = WriteProcessMemory(TibiaHandle, finalAddress, newValue, 1, lpNumberOfBytesWritten)
            If (res = 1) Then
                CloseHandle(TibiaHandle)
                Return 0
            Else
                CloseHandle(TibiaHandle)
                Return -1
            End If
            Exit Function
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function QMemory_Read8Bytes(ByVal pid As Integer, ByVal finalAddress As Integer) As Double
        Dim RBuff(7) As Byte
        Dim TibiaHandle As IntPtr
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            ReadProcessMemoryB(TibiaHandle, finalAddress, RBuff(0), 8, 0)
            CloseHandle(TibiaHandle)
            QMemory_Read8Bytes = BitConverter.ToInt64(RBuff, 0)
            Exit Function
        Catch ex As Exception
            QMemory_Read8Bytes = -1
        End Try
    End Function



    Public Function QMemory_Read2Bytes(ByVal pid As Integer, ByVal finalAddress As Integer) As Integer
        Dim RBuff(1) As Byte
        Dim TibiaHandle As IntPtr
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            ReadProcessMemoryB(TibiaHandle, finalAddress, RBuff(0), 2, 0)
            CloseHandle(TibiaHandle)
            QMemory_Read2Bytes = BitConverter.ToInt16(RBuff, 0)
            Exit Function
        Catch ex As Exception
            QMemory_Read2Bytes = -1
        End Try
    End Function

    Public Function QMemory_Read1Byte(ByVal pid As Integer, ByVal finalAddress As Integer) As Byte
        Dim RBuff As Byte
        Dim TibiaHandle As IntPtr
        Try
            TibiaHandle = OpenProcess(PROCESS_VM_READ, 0, pid)
            ReadProcessMemoryB(TibiaHandle, finalAddress, RBuff, 1, 0)
            CloseHandle(TibiaHandle)
            QMemory_Read1Byte = RBuff
            Exit Function
        Catch ex As Exception
            QMemory_Read1Byte = &HFF
        End Try
    End Function

    Public Function QMemory_WriteBytes(ByVal pid As Integer, ByVal finalAddress As Integer, ByRef RBuff() As Byte) As Integer
        Dim TibiaHandle As IntPtr
        Dim usize As Integer
        Dim lpNumberOfBytesWritten As Integer = 0
        Dim res As Integer
        Try
            usize = RBuff.Length

            TibiaHandle = OpenProcess(AccessFlags.PROCESS_ALL, 0, pid)
            If (TibiaHandle = -1) Then
                Return -2
                Exit Function
            End If
            res = WriteProcessMemory(TibiaHandle, finalAddress, RBuff(0), usize, lpNumberOfBytesWritten)
            If Not (res = 1) Then
                CloseHandle(TibiaHandle)
                Return -3
                Exit Function
            End If
            CloseHandle(TibiaHandle)
            Return 0
            Exit Function
        Catch ex As Exception
            Debug.Print("QMemory_Write1Byte error!")
            Return -1
        End Try
    End Function

    Public Function ModifyQString(ByVal pid As Integer, ByVal address As Integer, ByRef newText As String) As Integer
        Dim msg_size As Integer
        Dim msg_offset As Integer
        Dim new_size As Integer
        Dim msg_start As Integer
        Dim res As Integer
        Dim allbytes() As Byte
        new_size = Len(newText)
        msg_offset = QMemory_Read4Bytes(pid, address + 12)
        msg_size = QMemory_Read4Bytes(pid, address + 4)
        If (new_size > msg_size) Then
            Return -1
            Exit Function
        End If
        msg_start = address + msg_offset
        allbytes = New Byte((new_size * 2) - 1) {}
        For i As Integer = 0 To new_size - 1
            allbytes(i * 2) = Asc(Mid(newText, i + 1, 1))
            allbytes(1 + (i * 2)) = &H0
        Next i
        If new_size > 0 Then
            res = QMemory_WriteBytes(pid, msg_start, allbytes)
        Else
            res = 0
        End If

        If (res = 0) Then
            res = QMemory_Write4Bytes(pid, address + 4, new_size)
            Return res
        End If
        Return res
    End Function

    Public Function QMemory_ReadString(ByVal pid As Integer, ByVal address As Integer, Optional maxSize As Integer = 2048) As String
        Dim msg_size As Long
        Dim msg_offset As Long
        Dim msg_start As Long
        Dim msg_lastc As Long
        Dim b As Byte
        Dim res As String = ""
        msg_size = QMemory_Read4Bytes(pid, address + 4)
        msg_offset = QMemory_Read4Bytes(pid, address + 12)
        msg_start = address + msg_offset
        If msg_size > maxSize Then
            msg_size = maxSize
        End If
        msg_lastc = msg_size - 1
        If msg_lastc < 0 Then
            Return ""
            Exit Function
        End If
        For i As Integer = 0 To msg_lastc
            b = QMemory_Read1Byte(pid, msg_start + (i * 2))
            res = res & Chr(CInt(b))
        Next i
        Return res
    End Function
    Public Function ReadChatTab(ByVal pid As Integer, ByVal address As Integer)
        Dim tab_maxsize_atthismoment As Integer
        Dim tab_current_size As Integer
        Dim tab_adr_MessageList As Integer
        Dim tab_adr_channel_name As Integer
        Dim tab_adr_channel_name2 As Integer
        Dim tab_channel_name As String
        tab_adr_channel_name = QMemory_Read4Bytes(pid, address + &H10)
        Debug.Print("Channel name info at " & Hex(tab_adr_channel_name))
        tab_adr_channel_name2 = QMemory_Read4Bytes(pid, tab_adr_channel_name + &H10)
        tab_channel_name = QMemory_ReadString(pid, tab_adr_channel_name2)
        Debug.Print("Channel name = " & tab_channel_name) ' Returns empty string for Local Chat, Server Log and NPCs
        tab_adr_MessageList = QMemory_Read4Bytes(pid, address + &H18)
        tab_maxsize_atthismoment = QMemory_Read4Bytes(pid, address + &H1C)
        tab_current_size = QMemory_Read4Bytes(pid, address + &H24)
        If tab_current_size = 0 Then
            Return ""
        End If
        If tab_adr_MessageList = 0 Then
            Return ""
        End If
        Return ReadChatMessageList(pid, tab_adr_MessageList, tab_current_size)
    End Function

    Public Function ReadChatMessageList(ByVal pid As Integer, ByVal address As Integer, msgCount As Integer) As String
        Dim res As String = ""
        Dim adrLine As Long
        Dim currLine As String
        If msgCount > 10000 Then
            Return ""
            Exit Function
        End If
        For i = 0 To msgCount
            adrLine = QMemory_Read4Bytes(pid, address + (i * 4))
            If adrLine = 0 Then
                Exit For
            End If
            currLine = ReadChatLine(pid, adrLine)
            If (currLine = "") Then
                Exit For
            End If
            If (i = 0) Then
                res = currLine
            Else
                res = res & vbCrLf & currLine
            End If

        Next i
        Debug.Print(res)
        Return res
    End Function
    Public Function ReadChatLine(ByVal pid As Integer, ByVal address As Integer) As String
        Dim msg_type As Long
        Dim adrtimestamp As Long
        Dim adrqmessage As Long
        Dim adrqsource As Long
        Dim raw_timestamp As Double
        Dim dt_timestamp As DateTime = Nothing
        Dim msg_time As String
        Dim msg_message As String
        Dim msg_source As String
        Dim msg_level As Integer
        Dim msg_full As String
        msg_type = QMemory_Read4Bytes(pid, address)
        adrtimestamp = QMemory_Read4Bytes(pid, address + 4)
        If (adrtimestamp = 0) Then
            Debug.Print("ERROR: Trying to a read corrupted chat line (err1)")
            Return ""
        End If
        raw_timestamp = QMemory_Read8Bytes(pid, adrtimestamp + 8)
        dt_timestamp = GetDateTimeFromTibiaTimeStamp(raw_timestamp)
        If (dt_timestamp = Nothing) Then
            Debug.Print("ERROR: Trying to a read corrupted chat line (err2)")
            Return ""
        End If
        msg_time = dt_timestamp.ToString("HH:mm")
        adrqmessage = QMemory_Read4Bytes(pid, address + 8)
        msg_message = QMemory_ReadString(pid, adrqmessage)
        adrqsource = QMemory_Read4Bytes(pid, address + 16)
        msg_source = QMemory_ReadString(pid, adrqsource)
        If (msg_type = 0) Then
            msg_level = 0
            msg_full = msg_time & " " & msg_message
        Else
            msg_level = QMemory_Read2Bytes(pid, address + 20)
            If (msg_level = 0) Then
                msg_full = msg_time & " " & msg_source & ": " & msg_message
            Else
                msg_full = msg_time & " " & msg_source & " [" & CStr(msg_level) & "]: " & msg_message
            End If
        End If
        ' Debug.Print("Message type: " & CStr(msg_type))
        'Debug.Print("Timestamp adr: " & CStr(Hex(adrtimestamp + 8)))
        'Debug.Print("Message timestamp: " & CStr(raw_timestamp))
        'Debug.Print("Message time: " & msg_time)
        'Debug.Print("Message message: " & msg_message)
        'Debug.Print("Message source: " & msg_source)
        'Debug.Print("Message level: " & CStr(msg_level))
        'Debug.Print("Message full: " & msg_full)
        Return msg_full
    End Function


    Public Function GetDateTimeFromTibiaTimeStamp(ByVal tibiaTimestamp As Double) As DateTime

        Dim nDateTime As System.DateTime
        Dim nDateTime2 As System.DateTime
        If tibiaTimestamp = 0 Then
            Return Nothing
        End If
        Try
            nDateTime = New System.DateTime(tibiaTimestamp * 10000)
            nDateTime2 = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
            nDateTime = nDateTime.AddTicks(nDateTime2.Ticks)
        Catch ex As Exception
            Debug.Print("GetDateTimeFromTibiaTimeStamp FAILED: " + ex.ToString)
            Return Nothing
        End Try
        Return nDateTime
    End Function


    ' Obtain memory bases and region sizes of all modules in a running proccess.
    ' By Blackd (blackdtools.com)
    ' Tibia 11 : expectedName="client" expectedClass="Qt5QWindowOwnDCIcon"
    Public Sub GetAllBaseAddressesAndRegionSizes(ByRef expectedName As String, ByRef expectedClass As String)
        Dim procmodule_name As String
        Dim procmodule_base As Long
        Dim procmodule_size As Long
        Dim ubproc As Long
        Dim hwnd As Long
        Dim currentPID As Integer
        Dim currentClass As String
        Dim allModules As System.Diagnostics.ProcessModuleCollection
        Try
            ' moduleDictionary = New Dictionary(Of String, Long)
            moduleDictionary.Clear()
            Dim proc() As Process
            proc = System.Diagnostics.Process.GetProcessesByName(expectedName)

            ubproc = UBound(proc)
            If ubproc < 0 Then
                Debug.Print("Error: Can't find anything with class=" & expectedName)
                Exit Sub
            End If
            For i As Integer = 0 To ubproc
                hwnd = proc(i).MainWindowHandle
                currentClass = GetWindowClass(hwnd)
                ' Debug.Print(CStr(proc(GetWindowClassi).Id) & " = " & CStr(hwnd))
                If currentClass = expectedClass Then
                    currentPID = proc(i).Id

                    allModules = proc(i).Modules
                    'Debug.Print("Found " + CStr(allModules.Count) + " process modules:")

                    For Each procmodule As ProcessModule In allModules
                        ' Get procmodule_name - Static: always same names.
                        procmodule_name = procmodule.ModuleName
                        ' Get procmodule_base - Dynamic: bases will change each new run of the executable!
                        procmodule_base = procmodule.BaseAddress
                        ' Get procmodule_size - Static: always same size. Usefull to search things in modules (for autoupdaters)
                        procmodule_size = procmodule.ModuleMemorySize '
                        'Debug.Print(procmodule_name & " = " & Hex(procmodule_base) & " (size = " & Hex(procmodule_size) & ")")

                        moduleDictionary.Add(procmodule_name & CStr(currentPID), procmodule_base)

                        If (procmodule_name = "Qt5Core.dll") Then
                            LastProcessBASE = procmodule_base
                        End If
                        ' Debug.Print(procmodule_name & " (size = " & Hex(procmodule_size) & ")")
                        ' TODO: Add/update in a dictionary object so we can later
                        ' translate complex address paths that start in such places.
                    Next procmodule


                End If
            Next
            Exit Sub
        Catch ex As Exception
            Debug.Print("Error: Unexpected error - " & ex.ToString())
        End Try
    End Sub


    Public Function ReadSelectedChatTab(pid As Integer, adrChatStruct As AddressPath, Optional removeMarks As Boolean = True) As String
        Dim baseAdr As String
        Dim selectedChannel_struct As Integer
        Dim selectedChannel_index As Integer
        Dim res As String
        baseAdr = ReadCurrentAddress(pid, adrChatStruct, -1, True)
        selectedChannel_struct = QMemory_Read4Bytes(pid, baseAdr + &H64)
        selectedChannel_index = QMemory_Read4Bytes(pid, baseAdr + &HA8)
        Debug.Print("Reading channel tab #" & CStr(selectedChannel_index) & " at " & Hex(selectedChannel_struct))
        res = ReadChatTab(pid, selectedChannel_struct)
        If removeMarks = True Then
            res = Replace(res, "{", "")
            res = Replace(res, "}", "")
        End If
        Return res
    End Function

    Public Function ReadCurrentCharName(ByRef pid As Integer, ByRef adrSelectedCharName As AddressPath) As String
        Dim auxAdr As Integer
        Dim strRes As String
        auxAdr = ReadCurrentAddress(pid, adrSelectedCharName, -1, True)
        strRes = QMemory_ReadString(pid, auxAdr)
        Return strRes
    End Function



    Public Function arrayToString(arr As Byte()) As String
        Dim isize As Integer
        Dim res As String = "Array ="
        Try
            isize = UBound(arr)
            For i As Integer = 0 To isize - 1
                res = res & " " & GoodHex(arr(i))
            Next i
            Return res
            Exit Function
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function arrayToString2(arr As Byte()) As String
        Dim isize As Integer
        Dim res As String = "Array ="
        Try
            isize = UBound(arr)
            For i As Integer = 0 To isize - 1 Step 4
                res = res & " " & GoodHex(arr(i + 3)) & GoodHex(arr(i + 1)) & GoodHex(arr(i + 1)) & GoodHex(arr(i))
            Next i
            Return res
            Exit Function
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub fillCollectionDictionary(ByRef pid As Integer, ByVal adrCurrentItem As Integer, ByVal adrSTARTER_ITEM As Integer,
                                         ByRef dict As SortedDictionary(Of Integer, Byte()),
                                         ByRef totalItems As Integer, ByVal currentDepth As Integer,
                                         ByRef maxDepth As Integer, ByRef bytesPerElement As Integer,
                                               Optional ByRef maxValidKeyID As Integer = -1)
        Try
            Dim id As Integer

            id = QMemory_Read4Bytes(pid, adrCurrentItem + &H10)
            If (maxValidKeyID > -1) Then
                If (id > maxValidKeyID) Then
                    Exit Sub
                End If
            End If
            If (dict.ContainsKey(id) = False) Then
                Dim tmp(bytesPerElement) As Byte
                tmp = New Byte(bytesPerElement) {}
                QMemory_ReadNBytes(pid, adrCurrentItem, tmp)
                dict.Add(id, tmp)
                Debug.Print("Key #" & CStr(id) & " found at " & Hex(adrCurrentItem))
            End If
            If (currentDepth < maxDepth) Then
                Dim p0, p1, p2 As Integer
                p0 = QMemory_Read4Bytes(pid, adrCurrentItem)
                p1 = QMemory_Read4Bytes(pid, adrCurrentItem + 4)
                p2 = QMemory_Read4Bytes(pid, adrCurrentItem + 8)
                If (Not (p0 = adrSTARTER_ITEM)) Then
                    fillCollectionDictionary(pid, p0, adrSTARTER_ITEM, dict, totalItems, currentDepth + 1, maxDepth, bytesPerElement, maxValidKeyID)
                End If
                If (Not (p1 = adrSTARTER_ITEM)) Then
                    fillCollectionDictionary(pid, p1, adrSTARTER_ITEM, dict, totalItems, currentDepth + 1, maxDepth, bytesPerElement, maxValidKeyID)
                End If
                If (Not (p2 = adrSTARTER_ITEM)) Then
                    fillCollectionDictionary(pid, p2, adrSTARTER_ITEM, dict, totalItems, currentDepth + 1, maxDepth, bytesPerElement, maxValidKeyID)
                End If
            End If
        Catch Ex As Exception
            Debug.Print("Something failed: " + Ex.ToString)
        End Try
    End Sub

    Public Function ReadTibia11Collection(pid As Integer, adrPath As AddressPath,
                                          ByRef bytesPerElement As Integer,
                                          Optional ByVal directAddress As Integer = -1,
                                          Optional ByVal customDepth As Integer = -1,
                                          Optional ByVal maxValidKeyID As Integer = -1) As SortedDictionary(Of Integer, Byte())
        Dim adrCOLLECTION_START As Integer
        Dim totalItems As Integer
        Dim adrSTARTER_ITEM As Integer
        Dim dict As SortedDictionary(Of Integer, Byte())
        Dim maxDepth As Integer
        Dim p0, p1, p2 As Integer
        dict = New SortedDictionary(Of Integer, Byte())
        If (directAddress > -1) Then
            adrCOLLECTION_START = directAddress
        Else
            adrCOLLECTION_START = ReadCurrentAddress(pid, adrPath, -1, False)
        End If
        If (customDepth > -1) Then
            maxDepth = customDepth
        Else
            totalItems = QMemory_Read4Bytes(pid, adrCOLLECTION_START + 4)
            If (totalItems = 0) Then
                Return dict
                Exit Function
            End If
            maxDepth = Math.Round(Math.Sqrt(totalItems))
        End If
        adrSTARTER_ITEM = QMemory_Read4Bytes(pid, adrCOLLECTION_START)
        Dim tmp(bytesPerElement) As Byte
        tmp = New Byte(bytesPerElement) {}

        p0 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM)
        p1 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM + 4)
        p2 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM + 8)
        fillCollectionDictionary(pid, p0, adrSTARTER_ITEM, dict, totalItems, 0, maxDepth, bytesPerElement, maxValidKeyID)
        fillCollectionDictionary(pid, p1, adrSTARTER_ITEM, dict, totalItems, 0, maxDepth, bytesPerElement, maxValidKeyID)
        fillCollectionDictionary(pid, p2, adrSTARTER_ITEM, dict, totalItems, 0, maxDepth, bytesPerElement, maxValidKeyID)
        Return dict
    End Function

    Public Function ReadTibia11ServerList(pid As Integer, adrPath As AddressPath) As TibiaServerEntry()
        Dim tmpRes As SortedDictionary(Of Integer, Byte())
        Dim resSize As Integer
        Dim tmpElement As TibiaServerEntry
        Dim i As Integer
        tmpRes = ReadTibia11Collection(pid, adrPath, 36)
        resSize = tmpRes.Count
        If (resSize = 0) Then
            Return Nothing
            Exit Function
        End If
        Dim res() As TibiaServerEntry
        res = New TibiaServerEntry(resSize - 1) {}
        i = 0
        For Each Item As KeyValuePair(Of Integer, Byte()) In tmpRes

            tmpElement = New TibiaServerEntry()
            tmpElement.id = Item.Key

            tmpElement.name_adr = BitConverter.ToInt32(Item.Value, &H18)
            tmpElement.url_adr = BitConverter.ToInt32(Item.Value, &H1C)
            tmpElement.name = QMemory_ReadString(pid, tmpElement.name_adr)
            tmpElement.url = QMemory_ReadString(pid, tmpElement.url_adr)
            tmpElement.port = BitConverter.ToInt32(Item.Value, &H20)
            res(i) = tmpElement
            i = i + 1
        Next
        Return res
    End Function

    Public Function ReadTibia11SkillList(pid As Integer, adrPath As AddressPath) As TibiaSkillEntry()
        Dim tmpRes As SortedDictionary(Of Integer, Byte())
        Dim resSize As Integer
        Dim tmpElement As TibiaSkillEntry
        Dim i As Integer
        Dim strName As String
        tmpRes = ReadTibia11Collection(pid, adrPath, 25)
        resSize = tmpRes.Count
        If (resSize = 0) Then
            Return Nothing
            Exit Function
        End If
        Dim res() As TibiaSkillEntry
        res = New TibiaSkillEntry(resSize - 1) {}
        i = 0
        For Each Item As KeyValuePair(Of Integer, Byte()) In tmpRes
            tmpElement = New TibiaSkillEntry()
            tmpElement.id = Item.Key
            tmpElement.current_skill = BitConverter.ToInt16(Item.Value, &H14)
            tmpElement.base_skill = BitConverter.ToInt16(Item.Value, &H16)
            tmpElement.percent_to_go = 100 - Item.Value(&H18)
            Select Case (Item.Key)
                Case 4
                    strName = "Magic level"
                Case 10
                    strName = "Shielding"
                Case 11
                    strName = "Distance Fighting"
                Case 12
                    strName = "Axe Fighting"
                Case 13
                    strName = "Sword Fighting"
                Case 14
                    strName = "Club Fighting"
                Case 15
                    strName = "Fist Fighting"
                Case 16
                    strName = "Fishing"
                Case 21
                    strName = "Critical Hit.Chance"
                Case 22
                    strName = "Critical Hit.Extra Damage"
                Case 23
                    strName = "Hit Points Leech.Chance"
                Case 24
                    strName = "Hit Points Leech.Amount"
                Case 25
                    strName = "Mana Leech.Chance"
                Case 26
                    strName = "Mana Leech.Amount"
                Case Else
                    strName = "Unknown skill! (#" & CStr(Item.Key) & ")"
            End Select
            tmpElement.name = strName
            res(i) = tmpElement
            i = i + 1
        Next
        Return res
    End Function


    Public Function ReadTibia11CharList(pid As Integer, adrPath As AddressPath) As TibiaCharListEntry()
        Dim tmpElement As TibiaCharListEntry
        Dim adrCOLLECTION_START As Integer
        Dim adrCharList As Integer
        Dim adrType As Integer
        Dim adrCharListStart As Integer
        Dim resSize As Integer
        Dim bytesPerElement As Integer
        Dim lastI As Integer
        Dim tmpAdr As Integer
        adrCOLLECTION_START = ReadCurrentAddress(pid, adrPath, -1, False)
        adrCharList = QMemory_Read4Bytes(pid, adrCOLLECTION_START + 8)
        Debug.Print("Charlist at " & Hex(adrCharList))
        adrType = QMemory_Read4Bytes(pid, adrCharList)
        If (adrType = -1) Then
            Return Nothing
            Exit Function
        End If
        If (adrType > 1) Then
            Debug.Print("Charlist by reference")
            adrCharList = QMemory_Read4Bytes(pid, adrType)
        End If
        resSize = QMemory_Read4Bytes(pid, adrCharList + &HC)
        adrCharListStart = adrCharList + &H10
        If (resSize = 0) Then
            Return Nothing
            Exit Function
        End If
        bytesPerElement = resSize * 4
        Dim tmp(bytesPerElement) As Byte
        tmp = New Byte(bytesPerElement) {}
        QMemory_ReadNBytes(pid, adrCharListStart, tmp)

        Dim res() As TibiaCharListEntry
        Dim tamStruct As Integer = 60
        Dim resStruct() As Byte
        res = New TibiaCharListEntry(resSize - 1) {}
        lastI = resSize - 1
        For i As Integer = 0 To resSize - 1
            tmpElement = New TibiaCharListEntry()
            tmpElement.id = i



            tmpElement.entry_address = BitConverter.ToInt32(tmp, 4 * i)

            resStruct = New Byte(tamStruct) {}
            QMemory_ReadNBytes(pid, tmpElement.entry_address, resStruct)
            tmpElement.raw_bytes = resStruct



            tmpAdr = QMemory_Read4Bytes(pid, tmpElement.entry_address + &H10)
            tmpElement.name_address = tmpAdr
            tmpElement.name = QMemory_ReadString(pid, tmpAdr)
            tmpAdr = QMemory_Read4Bytes(pid, tmpElement.entry_address + &H14)
            tmpElement.server = QMemory_ReadString(pid, tmpAdr)

            res(i) = tmpElement
        Next
        Return res
    End Function


    Public Sub ReadTibia11CharListAUX(pid As Integer, ByVal adr As Integer)
        Dim adrNext0 As Integer
        Dim adrNext1 As Integer
        Dim blnStop As Boolean = False
        Dim i As Integer = 0
        Dim adrFrom As Integer
        adrNext1 = adr
        adrFrom = adr
        Do
            adrNext0 = QMemory_Read4Bytes(pid, adrNext1 + &H1C)
            If (adrNext0 > 40000) Then
                adrNext1 = QMemory_Read4Bytes(pid, adrNext0 + &HC)
                If (adrNext1 < 40000) Then
                    blnStop = True
                Else
                    adrFrom = adrNext1
                End If
            Else
                blnStop = True
            End If
            If i > 25 Then
                blnStop = True
            End If
            Debug.Print("" & Hex(adrFrom) & " > #" & CStr(i) + ": " & Hex(adrNext0) & " " & Hex(adrNext1))
        Loop Until blnStop
    End Sub




    Public Function MoveExternalAppWindow(ByVal hwnd As Integer, _
                      ByVal x As Integer, ByVal y As Integer) As Integer
        Dim res As Integer
        res = SetWindowPos(hwnd, 0, x, y, 0, 0, SWP_NOSIZE)
        Debug.Print("Resultado de ResizeExternalApp=" & CStr(res))
        Return res
    End Function

    Public Function reverseHex(ByVal originalHex As String) As String
        Dim stringLast As Integer = (originalHex.Length / 8) - 1
        Dim res As String = ""
        Dim tmp1 As String
        Dim tmp2 As String
        Dim tmp3 As String
        Dim tmp4 As String
        For i As Integer = 0 To stringLast
            tmp1 = Mid(originalHex, 1 + (i * 4), 2)
            tmp2 = Mid(originalHex, 3 + (i * 4), 2)
            tmp3 = Mid(originalHex, 5 + (i * 4), 2)
            tmp4 = Mid(originalHex, 7 + (i * 4), 2)
            res = res & tmp4 & tmp3 & tmp2 & tmp1


        Next i
        Return res
    End Function

 

    Public Sub MyKeyUp(hwnd As IntPtr, vk_key As Integer)

        '  (MapVirtualKey(vk_key, MAPVK_VSC_TO_VK)) * 0x10000 + 0xC0000000 + 1);
        SendMessage(hwnd, WM_KEYUP, vk_key, (MapVirtualKey(vk_key, MAPVK_VSC_TO_VK)) * &H10000 + &HC0000000 + 1)
    End Sub

    Public Sub MyKeyDown(hwnd As IntPtr, vk_key As Integer)
        '  (MapVirtualKey(vk_key, MAPVK_VSC_TO_VK)) * 0x10000 + 1);
        SendMessage(hwnd, WM_KEYDOWN, vk_key, (MapVirtualKey(vk_key, MAPVK_VSC_TO_VK)) * &H10000 + 1)
    End Sub

    Public Sub SendKeysToTibia11_altMethod(ByVal handleRef As IntPtr, ByVal Key As Integer, ByVal Key2 As Integer)
        If handleRef = IntPtr.Zero Then
            Exit Sub
        End If
        MyKeyDown(handleRef, Key)
        MyKeyDown(handleRef, Key2)
        MyKeyUp(handleRef, Key2)
        MyKeyUp(handleRef, Key)
    End Sub

    Public Sub DoRandomDirectionChange(ByVal handleRef As IntPtr, ByRef charName As String, ByVal currentDirection As Integer, ByRef timerID As String, ByRef recastMS As Long)
        Dim choosenOption As Integer = 0
        Dim a As Long
        Dim b As Long
        Dim i As Integer
        Dim nextT As Long
        '  If allowActions = False Then
        'Exit Sub
        ' End If
        If CheckNextPossibleRecastTime(charName, timerID) >= Now.Ticks Then
            Exit Sub
        End If
        SetNextPossibleRecastTime(charName, timerID, recastMS)
        dictCharNextPossibleANTIAFK(charName) = 1
        a = CLng(SafeInteger(SafeCheck_StringValue(charName & "_" & "numericAntiAFKMinimum", "0")))
        b = CLng(SafeInteger(SafeCheck_StringValue(charName & "_" & "numericAntiAFKMaximum", "0")))
        nextT = GetRandom(a * 10000000L, b * 10000000L)
        dictCharNextPossibleANTIAFK(charName) = Now.Ticks + nextT
        If (debugMode) Then
            Debug.Print(getNiceTimestamp() & "DoRandomDirectionChange")
            ' allowActions = True
            Exit Sub
        End If
        i = 0
        Do
            choosenOption = GetRandom(0, 3)
            i = i + 1
            If i > 10 Then
                choosenOption = currentDirection + 1
                If currentDirection = 4 Then
                    currentDirection = 1
                End If
            End If
        Loop Until Not (choosenOption = currentDirection)
        ' Debug.Print("char was looking " & CStr(currentDirection) & " and now it will look " & CStr(choosenOption))
        Select Case choosenOption
            Case 0
                SendKeysToTibia11_altMethod(handleRef, Keys.RControlKey, Keys.Up)
            Case 1
                SendKeysToTibia11_altMethod(handleRef, Keys.RControlKey, Keys.Right)
            Case 2
                SendKeysToTibia11_altMethod(handleRef, Keys.RControlKey, Keys.Down)
            Case 3
                SendKeysToTibia11_altMethod(handleRef, Keys.RControlKey, Keys.Left)
        End Select
        'allowActions = True
    End Sub

    Public Sub SendKeysToTibia11(ByVal handleRef As IntPtr, ByVal Key As Integer, _
                                 Optional ControlPressed As Boolean = False)
        If handleRef = IntPtr.Zero Then
            Exit Sub
        End If
        Dim thrID As Integer
        Dim kbBackup(255) As Byte
        Dim kb(255) As Byte
        Dim currentT As Integer = 0
        Dim res As Boolean
        Dim lParam_Key As Integer = 0

        thrID = GetWindowThreadProcessId(handleRef, IntPtr.Zero)
        GetKeyboardState(kbBackup) ' Backup current keyboard state
        ' Build our virtual keyboard state

        '  Buffer.BlockCopy(emptyKeyboardState, 0, kb, 0, 256)
        currentT = GetCurrentThreadId()
        res = AttachThreadInput(currentT, thrID, True)
        If (ControlPressed) Then
            kb(Keys.LControlKey) = kb(Keys.LControlKey) Or &H80
        End If
        res = SetKeyboardState(kb)

        lParam_Key = MapVirtualKey(Key, 0)
        SendMessage(handleRef, WM_KEYDOWN, Key, lParam_Key)
        SendMessage(handleRef, WM_KEYUP, Key, lParam_Key)

        res = SetKeyboardState(kbBackup) ' Restore previous keyboard state
        res = AttachThreadInput(currentT, thrID, False)
        'For i As Integer = 0 To 255
        '    If Not (kbBackup(i) = 0) Then
        '        Debug.Print(CStr(i) & "=" & CStr(kbBackup(i)))
        '    End If
        'Next i

    End Sub

    Public Function SendStringToTibia11(ByRef charName As String, ByVal pid As Integer, ByVal handleRef As IntPtr, ByVal str As String, ByRef timerID As String, ByRef recastMS As Long) As Boolean
        Dim previousTEXT As String
        Dim adrQstring As Integer
        Dim adrPos As Integer
        Dim previousPOS As Integer
        Dim currentText As String
        Dim currentPos As Integer
        Dim timeLimit As Long
        Dim timeLimit2 As Long
        Dim retryDone As Boolean = False
        ' If allowActions = False Then
        'SendStringToTibia11 = False
        '  Exit Function
        '  End If
        If CheckNextPossibleRecastTime(charName, timerID) > Now.Ticks Then
            SendStringToTibia11 = False
            Exit Function
        End If
        If str = "" Then
            Debug.Print("can't cast empty string")
            SendStringToTibia11 = False
            Exit Function
        End If
        If dictDoingTextAction.ContainsKey(charName) Then
            Debug.Print("Already casting text. Must wait")
            SendStringToTibia11 = False
            Exit Function
        Else
            dictDoingTextAction.Add(charName, True)
        End If
        ' allowActions = False
        'dictCharNextPossibleRecastTime(charName) = Now.Ticks + GetRandom(minRecast, maxRecast)
        SetNextPossibleRecastTime(charName, timerID, recastMS)
        If (debugMode) Then
            Debug.Print(getNiceTimestamp() & "SendStringToTibia11: " + str)
            '  allowActions = True
            dictDoingTextAction.Remove(charName)
            SendStringToTibia11 = True
            Exit Function
        End If
        adrQstring = ReadCurrentAddress(pid, adrSpeakCurrentSendTxt, -1)
        If (adrQstring = -1) Then
            '  Debug.Print("chat is off!")
            SendKeysToTibia11(handleRef, Keys.Enter) ' ENTER
            timeLimit = Date.Now.Ticks + 500000L ' 50ms
            Do
                Application.DoEvents()
                adrQstring = ReadCurrentAddress(pid, adrSpeakCurrentSendTxt, -1)
                If Date.Now.Ticks > timeLimit Then
                    dictDoingTextAction.Remove(charName)
                    SendStringToTibia11 = False
                    Exit Function
                End If
            Loop Until (Not (adrQstring = -1))
            '  Debug.Print("chat is on!")
       
        End If


        adrPos = ReadCurrentAddress(pid, adrSpeakCursorPosition, -1, False)
        If (adrPos = -1) Then
            Debug.Print("error at SendStringToTibia11")
            '     allowActions = True
            dictDoingTextAction.Remove(charName)
            SendStringToTibia11 = False
            Exit Function
        End If
        previousTEXT = QMemory_ReadString(pid, adrQstring)
        previousPOS = QMemory_Read4Bytes(pid, adrPos)
        ' Debug.Print("text length= " & CStr(Len(previousTEXT)) & " previous cursor pos = " & CStr(previousPOS))
        QMemory_Write4Bytes(pid, adrPos, 0)
        ModifyQString(pid, adrQstring, "")
        Clipboard.Clear()
        Clipboard.SetText(str) ' copy to clipboard
        ' Application.DoEvents()
        ' send cheat
        SendKeysToTibia11(handleRef, Keys.V, True) ' control+V = paste in Tibia chat




        timeLimit = Date.Now.Ticks + 500000L ' 50ms

        Do
            Application.DoEvents()
            currentText = "?????"

            adrQstring = ReadCurrentAddress(pid, adrSpeakCurrentSendTxt, -1)
            If Not (adrQstring = -1) Then
                currentText = QMemory_ReadString(pid, adrQstring)
            End If

            If Date.Now.Ticks > timeLimit Then
                'Debug.Print("timeout at (1)")
                '  allowActions = True
                dictDoingTextAction.Remove(charName)
                SendStringToTibia11 = False
                Exit Function
            End If
            ' Debug.Print("current txt= " & currentText)
        Loop Until (currentText = str)

        SendKeysToTibia11(handleRef, Keys.Enter) ' ENTER
        If (fastMode = True) Then ' STOP NOW! (DON'T REWRITE PREVIOUS TEXT)
            dictDoingTextAction.Remove(charName)
            SendStringToTibia11 = True
            Exit Function
        End If
        ' wait for clean chat
        timeLimit = Date.Now.Ticks + 500000L ' 50ms
        timeLimit2 = Date.Now.Ticks + 1000000L ' 100ms
        Do

            Application.DoEvents()
            currentText = "x"
            currentPos = 1

            adrQstring = ReadCurrentAddress(pid, adrSpeakCurrentSendTxt, -1)
            If Not (adrQstring = -1) Then
                currentText = QMemory_ReadString(pid, adrQstring)
            End If
            adrPos = ReadCurrentAddress(pid, adrSpeakCursorPosition, -1, False)
            If Not (adrPos = -1) Then
                currentPos = QMemory_Read4Bytes(pid, adrPos)
            End If
            If Date.Now.Ticks > timeLimit Then
                If currentText = str Then
                    If retryDone = False Then
                        retryDone = True
                        SendKeysToTibia11(handleRef, Keys.Enter) ' ENTER
                    End If
                End If
            End If
            If Date.Now.Ticks > timeLimit2 Then
                Debug.Print("timeout at (2)")
                Debug.Print("current text=" & currentText & " currentPos= " & currentPos)
                dictDoingTextAction.Remove(charName)
                SendStringToTibia11 = True
                Exit Function
            End If
        Loop Until (currentText = "") And (currentPos = 0)


        Clipboard.Clear()
        If Not (previousTEXT = "") Then
            Clipboard.SetText(previousTEXT) ' previousTEXT
            Application.DoEvents()
            SendKeysToTibia11(handleRef, Keys.V, True)
        End If

        timeLimit = Date.Now.Ticks + 500000L ' 50ms
        Do
            Application.DoEvents()
            currentText = "?????"

            adrQstring = ReadCurrentAddress(pid, adrSpeakCurrentSendTxt, -1)
            If Not (adrQstring = -1) Then
                currentText = QMemory_ReadString(pid, adrQstring)
            End If
            If Date.Now.Ticks > timeLimit Then
                Debug.Print("timeout at (3)")
                dictDoingTextAction(charName) = False
                SendStringToTibia11 = True
                Exit Function
            End If
            ' Debug.Print("current txt= " & currentText)
        Loop Until (currentText = previousTEXT)
        'Threading.Thread.Sleep(300)
        '' restore previous cursor position
        'adrPos = ReadCurrentAddress(pid, adrSpeakCursorPosition, -1, False)
        'If (adrPos = -1) Then
        '    Debug.Print("error at SendStringToTibia11")
        '    Exit Sub
        'End If
        'QMemory_Write4Bytes(pid, adrPos, previousPOS)
        'previousPOS = QMemory_Read4Bytes(pid, adrPos)
        'Debug.Print("restored cursor pos to " & CStr(previousPOS))

        '  allowActions = True
        dictDoingTextAction.Remove(charName)

        SendStringToTibia11 = True

    End Function

    Public Function CheckNextPossibleRecastTime(ByRef charName As String, ByRef timerID As String) As Long
        Dim combined As String
        combined = timerID & "_" & charName
        If dictCharNextPossibleRecastTime.ContainsKey(combined) = False Then
            CheckNextPossibleRecastTime = 0
        Else
            CheckNextPossibleRecastTime = dictCharNextPossibleRecastTime(combined)
        End If
    End Function

    Public Sub SetNextPossibleRecastTime(ByRef charName As String, ByRef timerID As String, ByRef recastMS As Long)
        Dim combined As String
        Dim minRecast As Long
        Dim maxRecast As Long
        Dim waitAbit As Long
        minRecast = recastMS
        maxRecast = CLng((CLng(recastMS) * 110L) / 100L)
        minRecast = minRecast * 10000L
        maxRecast = maxRecast * 10000L
        combined = timerID & "_" & charName
        waitAbit = Now.Ticks + GetRandom(minRecast, maxRecast)
        dictCharNextPossibleRecastTime(combined) = waitAbit
        'waitAbit = waitAbit + 500000L ' +50 ms

        '' ensure related timers won't cast too soon. Ensure they have at least 500 ms remaining.
        'Select Case timerID
        '    Case "hp0"
        '        dictCharNextPossibleRecastTime("hp1" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp1"), waitAbit)
        '        dictCharNextPossibleRecastTime("hp2" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp2"), waitAbit)
        '    Case "hp1"
        '        dictCharNextPossibleRecastTime("hp0" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp0"), waitAbit)
        '        dictCharNextPossibleRecastTime("hp2" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp2"), waitAbit)
        '    Case "hp2"
        '        dictCharNextPossibleRecastTime("hp0" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp0"), waitAbit)
        '        dictCharNextPossibleRecastTime("hp1" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "hp1"), waitAbit)
        '    Case "mana0"
        '        dictCharNextPossibleRecastTime("mana1" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana1"), waitAbit)
        '        dictCharNextPossibleRecastTime("mana2" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana2"), waitAbit)
        '    Case "mana1"
        '        dictCharNextPossibleRecastTime("mana0" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana0"), waitAbit)
        '        dictCharNextPossibleRecastTime("mana2" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana2"), waitAbit)
        '    Case "mana2"
        '        dictCharNextPossibleRecastTime("mana0" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana0"), waitAbit)
        '        dictCharNextPossibleRecastTime("mana1" & "_" & charName) = _
        '            Math.Max(CheckNextPossibleRecastTime(charName, "mana1"), waitAbit)
        'End Select

    End Sub

    Public Function CheckNextPossibleEat(ByRef charName As String) As Long
        If dictCharNextPossibleEatTime.ContainsKey(charName) = False Then
            CheckNextPossibleEat = 0
        Else
            CheckNextPossibleEat = dictCharNextPossibleEatTime(charName)
        End If
    End Function

    Public Function CheckNextPossibleANTIAFK(ByRef charName As String) As Long
        If dictCharNextPossibleANTIAFK.ContainsKey(charName) = False Then
            CheckNextPossibleANTIAFK = 0
        Else
            CheckNextPossibleANTIAFK = dictCharNextPossibleANTIAFK(charName)
        End If
    End Function

    Public Sub TrainMana(ByVal handleRef As IntPtr, ByRef charName As String, ByRef keyCombination As String, ByVal maxMana As Integer, ByRef timerID As String, recastMS As Long)
        Dim res As Boolean
        Dim newVal As Integer
        ' If allowActions = False Then
        'Exit Sub
        '  End If
        res = SendHotkeyToTibia11(handleRef, charName, keyCombination, timerID, recastMS)
        If res Then
            newVal = getRandomNearMaxMana(maxMana)
            dictNearMaxManaForChar(charName) = newVal
        End If
    End Sub

    Public Sub EatFood(ByVal handleRef As IntPtr, ByRef charName As String, ByRef keyCombination As String, ByRef timerID As String, ByRef recastMS As Long)
        Dim res As Boolean
        Dim a As Long
        Dim b As Long
        Dim nextT As Long
        ' If allowActions = False Then
        'Exit Sub
        '  End If
        res = SendHotkeyToTibia11(handleRef, charName, keyCombination, timerID, recastMS)
        If res Then
            a = CLng(SafeInteger(SafeCheck_StringValue(charName & "_" & "numericAutoEatMinimum", "0")))
            b = CLng(SafeInteger(SafeCheck_StringValue(charName & "_" & "numericAutoEatMaximum", "0")))
            nextT = GetRandom(a * 10000000L, b * 10000000L)
            'Debug.Print("eat ok. Next in " & nextT)
            dictCharNextPossibleEatTime(charName) = Now.Ticks + nextT
        End If
    End Sub

    Public Function getNiceTimestamp() As String
        Dim res As String
        Dim dnow As Date
        dnow = Date.Now
        res = "[" & Trim$(dnow.ToString("MM/dd/yyyy hh:mm:ss.fff tt")) + "] "
        getNiceTimestamp = res
    End Function

    Public Function SendHotkeyToTibia11(ByVal handleRef As IntPtr, ByRef charName As String, ByRef keyCombination As String, ByRef timerID As String, ByRef recastMS As Long) As Boolean
        'If allowActions = False Then
        'SendHotkeyToTibia11 = False
        ' Exit Function
        '  End If
        If CheckNextPossibleRecastTime(charName, timerID) < Now.Ticks Then
            SetNextPossibleRecastTime(charName, timerID, recastMS)
            If (debugMode) Then
                Debug.Print(getNiceTimestamp() & "SendHotkeyToTibia11: " + keyCombination)
                '  allowActions = True
                SendHotkeyToTibia11 = True
                Exit Function
            End If
            Select Case keyCombination
                Case "F1"
                    SendKeysToTibia11(handleRef, Keys.F1)
                Case "F2"
                    SendKeysToTibia11(handleRef, Keys.F2)
                Case "F3"
                    SendKeysToTibia11(handleRef, Keys.F3)
                Case "F4"
                    SendKeysToTibia11(handleRef, Keys.F4)
                Case "F5"
                    SendKeysToTibia11(handleRef, Keys.F5)
                Case "F6"
                    SendKeysToTibia11(handleRef, Keys.F6)
                Case "F7"
                    SendKeysToTibia11(handleRef, Keys.F7)
                Case "F8"
                    SendKeysToTibia11(handleRef, Keys.F8)
                Case "F9"
                    SendKeysToTibia11(handleRef, Keys.F9)
                Case "F10"
                    SendKeysToTibia11(handleRef, Keys.F10)
                Case "F11"
                    SendKeysToTibia11(handleRef, Keys.F11)
                Case "F12"
                    SendKeysToTibia11(handleRef, Keys.F12)
                Case "Ctrl+F1"
                    SendKeysToTibia11(handleRef, Keys.F1, True)
                Case "Ctrl+F2"
                    SendKeysToTibia11(handleRef, Keys.F2, True)
                Case "Ctrl+F3"
                    SendKeysToTibia11(handleRef, Keys.F3, True)
                Case "Ctrl+F4"
                    SendKeysToTibia11(handleRef, Keys.F4, True)
                Case "Ctrl+F5"
                    SendKeysToTibia11(handleRef, Keys.F5, True)
                Case "Ctrl+F6"
                    SendKeysToTibia11(handleRef, Keys.F6, True)
                Case "Ctrl+F7"
                    SendKeysToTibia11(handleRef, Keys.F7, True)
                Case "Ctrl+F8"
                    SendKeysToTibia11(handleRef, Keys.F8, True)
                Case "Ctrl+F9"
                    SendKeysToTibia11(handleRef, Keys.F9, True)
                Case "Ctrl+F10"
                    SendKeysToTibia11(handleRef, Keys.F10, True)
                Case "Ctrl+F11"
                    SendKeysToTibia11(handleRef, Keys.F11, True)
                Case "Ctrl+F12"
                    SendKeysToTibia11(handleRef, Keys.F12, True)
                Case Else
                    SendHotkeyToTibia11 = False
                    Exit Function
            End Select
            '   allowActions = True
            SendHotkeyToTibia11 = True
        Else
            ' allowActions = True
            SendHotkeyToTibia11 = False
        End If
    End Function

    Public Function getRandomNearMaxMana(ByVal maxMana As Integer) As Integer
        Dim less As Integer
        less = GetRandom(1, 10)
        getRandomNearMaxMana = (maxMana - less)
    End Function

    Public Function whatIsNearMaxManaForChar(ByRef charName As String, ByVal maxMana As Integer) As Integer
        Dim newVal As Integer
        If dictNearMaxManaForChar.ContainsKey(charName) = False Then
            newVal = getRandomNearMaxMana(maxMana)
            dictNearMaxManaForChar(charName) = newVal
            whatIsNearMaxManaForChar = newVal
        Else
            whatIsNearMaxManaForChar = dictNearMaxManaForChar(charName)
        End If
    End Function

    Public Function checkIfRunemakerWaitedEnough(ByRef charName As String) As Boolean
        If dictRunemakerRequiredWait.ContainsKey(charName) = True Then
            If Now.Ticks < dictRunemakerRequiredWait(charName) Then
                checkIfRunemakerWaitedEnough = False
                Exit Function
            End If
        End If
        checkIfRunemakerWaitedEnough = True
    End Function

    Public Sub CloseTibiaByPID(ByVal pid As Integer)
        Dim aProcess() As System.Diagnostics.Process
        Dim ub As Integer
        Dim i As Integer
        Try
            aProcess = System.Diagnostics.Process.GetProcessesByName(tibiaMainName)
            ub = UBound(aProcess)
            For i = 0 To ub
                If aProcess(i).Id = pid Then
                    aProcess(i).Kill()
                    Exit Sub
                End If
            Next i
        Catch ex As Exception
            Debug.Print("WARNING AT CloseTibiaByPID: " & ex.Message)
        End Try

    End Sub

    Public Sub ReadPlayerStatus(ByVal pid As Integer, ByRef adrStatus_CountAndListStart As AddressPath, _
                                ByRef dictPlayerStatus As Dictionary(Of String, Boolean))
        Dim adrNow As Integer
        Dim statusCount As Integer
        Dim i As Integer
        Dim adrItem As Integer
        Dim item As String
        dictPlayerStatus.Clear()
        adrNow = ReadCurrentAddress(pid, adrStatus_CountAndListStart, -1, False)
        If adrNow = -1 Then
            Debug.Print("Address ERROR at ReadPlayerStatus")
            Exit Sub
        End If
        statusCount = QMemory_Read4Bytes(pid, adrNow)
        ' Debug.Print("Status count=" & CStr(statusCount))
        For i = 1 To statusCount
            adrItem = QMemory_Read4Bytes(pid, adrNow + (i * 4))
            adrItem = adrItem + &HC
            adrItem = QMemory_Read4Bytes(pid, adrItem)
            item = QMemory_ReadString(pid, adrItem)
            ' Debug.Print("Item=" & item)
            dictPlayerStatus.Add(item, True)
        Next i
    End Sub

    Private Function LoWord(ByVal lDWord As Integer) As Integer
        If lDWord And &H8000& Then
            LoWord = lDWord Or &HFFFF0000
        Else
            LoWord = lDWord And &HFFFF&
        End If
    End Function

    Private Function MAKELPARAM(ByVal wLow As Integer, ByVal wHigh As Integer) As Integer
        MAKELPARAM = LoWord(wLow) Or (&H10000 * LoWord(wHigh))
    End Function


    ' untested
    Public Sub SendClickToTibia11(ByVal tibiaHandle As IntPtr, ByVal x As Integer, ByVal y As Integer)
        Dim coordinates As Integer
        Dim res As Integer
        Dim currentPosition As POINTAPI
        GetCursorPos(currentPosition)
        coordinates = MAKELPARAM(x, y)

        res = SendMessage(tibiaHandle, WM_MOUSEMOVE, 0&, coordinates)
        res = SendMessage(tibiaHandle, WM_LBUTTONDOWN, 1&, coordinates)
        res = SendMessage(tibiaHandle, WM_MOUSEMOVE, 1&, coordinates)
        res = SendMessage(tibiaHandle, WM_LBUTTONUP, 0&, coordinates)
        coordinates = MAKELPARAM(currentPosition.x, currentPosition.y)
        res = SendMessage(tibiaHandle, WM_LBUTTONUP, 0&, coordinates)
    End Sub



End Module

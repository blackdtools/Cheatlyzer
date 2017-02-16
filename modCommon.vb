Option Explicit On
Imports System.Environment
Imports System
Imports System.IO
Public Module modCommon
#Const CMP_debugMode = False
#If CMP_debugMode = True Then
    Public Const debugMode = True
#Else
    Public Const debugMode = false
#End If

    Public Structure TypeCharIdInfo
        Dim pid As Integer
        Dim mainHandle As IntPtr
    End Structure
    'Public allowActions As Boolean = True
    Public settingsVersion As Long = 0
    Public frmCharSetupUNIQUE As New frmCharSetup
    Public Const myFormsBorderSize As Integer = 3
    ' Public Const minRecast As Long = 20000000L
    ' Public Const maxRecast As Long = 23000000L
    Public myFormsBorderColor As Color = Color.FromArgb(51, 51, 51)
    Public myFormsDANGERColor As Color = Color.FromArgb(255, 0, 0)
    Public myFormsDEATHColor As Color = Color.FromArgb(153, 0, 0)
    Public dictCharForms As New Dictionary(Of String, frmChar)
    Public dictCharIdInfo As New Dictionary(Of String, TypeCharIdInfo)
    Public dictCharNextPossibleEatTime As New Dictionary(Of String, Long)
    Public dictCharNextPossibleANTIAFK As New Dictionary(Of String, Long)
    Public dictDoingTextAction As New Dictionary(Of String, Boolean)
    Public dictCharSetup As New Dictionary(Of String, String)
    Public dictCharNextPossibleRecastTime As New Dictionary(Of String, Long)
    Public dictCharNextPossibleSound As New Dictionary(Of String, Long)
    Public dictRunemakerRequiredWait As New Dictionary(Of String, Long)
    Public dictNearMaxManaForChar As New Dictionary(Of String, Integer)
    Public dictFriendHP As New Dictionary(Of String, Integer)
    Public TibiaSettingsPath As String
    Public AddressFile As String
    Public TibiaConfigPath As String
    Public currentTotalFriends As Integer
    Public currentFriend() As String
    Public tibiatitle As String
    Public className As String
    Public tibiaMainName As String
    Public className_updater As String
    Public tibiaMainName_updater As String
    Public tibiatitle_updater As String
    Public adrXPos As AddressPath
    Public adrYPos As AddressPath
    Public adrZPos As AddressPath
    Public adrMyHP As AddressPath
    Public adrMyMaxHP As AddressPath
    Public adrCapacity As AddressPath
    Public adrMaxCapacity As AddressPath
    Public adrExperience As AddressPath
    Public adrLevel As AddressPath
    Public adrMyMana As AddressPath
    Public adrMyMaxMana As AddressPath
    Public adrMySoul As AddressPath
    Public adrChatLog_tabStruct As AddressPath
    Public adrGameConnected As AddressPath
    Public adrSelectedCharIndex As AddressPath
    Public tibia_popup_title As AddressPath
    Public adrServerList_CollectionStart As AddressPath
    Public adrSelectedItem_height As AddressPath
    Public adrSelectedCharName As AddressPath
    Public adrSpeakCurrentSendTxt As AddressPath
    Public adrSpeakCursorPosition As AddressPath
    Public adrBattlelist_CollectionStart As AddressPath
    Public adrStatus_CountAndListStart As AddressPath



    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer


    Public Sub handleSpecialFormDragMODE_MouseUp(ByRef currentForm As Form, ByRef dragStatus As Boolean, _
                                                  ByRef mouseX As Integer, ByRef mouseY As Integer)
        dragStatus = False
    End Sub
    Public Sub handleSpecialFormDragMODE_MouseDown(ByRef currentForm As Form, ByRef dragStatus As Boolean, _
                                                  ByRef mouseX As Integer, ByRef mouseY As Integer)
        dragStatus = True
        mouseX = Windows.Forms.Cursor.Position.X - currentForm.Left
        mouseY = Windows.Forms.Cursor.Position.Y - currentForm.Top
    End Sub
    Public Sub handleSpecialFormDragMODE_MouseMove(ByRef currentForm As Form, ByRef dragStatus As Boolean, _
                                                  ByRef mouseX As Integer, ByRef mouseY As Integer)
        If dragStatus Then
            currentForm.Top = Windows.Forms.Cursor.Position.Y - mouseY
            currentForm.Left = Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Public Function getMyCurrentAppPath() As String
        Dim rutaTotal As String = ""
        Dim appData As String
        Dim specificFolder As String
        Try
            appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

            specificFolder = Path.Combine(appData, My.Application.Info.AssemblyName)
            If (Directory.Exists(specificFolder)) = False Then
                Directory.CreateDirectory(specificFolder)
            End If
            rutaTotal = specificFolder
        Catch ex As Exception
            Debug.Print("Error at getCurrentAppPath(): " & ex.Message)
            rutaTotal = ""
        End Try
        getMyCurrentAppPath = rutaTotal
    End Function

    Public Function MyFileExist(ByRef strDir As String) As Boolean
        If (File.Exists(strDir)) = False Then
            MyFileExist = False
        Else
            MyFileExist = True
        End If
    End Function

    Public Function SafeCheck_StringValue(ByRef str As String, ByRef defaultVal As String) As String
        If dictCharSetup.ContainsKey(str) = True Then
            SafeCheck_StringValue = dictCharSetup(str)
        Else
            SafeCheck_StringValue = defaultVal
        End If
    End Function
    Public Function SafeCheck_DecimalValue(ByRef str As String, ByRef defaultVal As Decimal) As Decimal
        If dictCharSetup.ContainsKey(str) = True Then
            SafeCheck_DecimalValue = CDec(dictCharSetup(str))
        Else
            SafeCheck_DecimalValue = defaultVal
        End If
    End Function

    Public Function SafeCheck_CheckStateValue(ByRef str As String, ByRef defaultVal As CheckState) As CheckState
        Dim strV As String
        If dictCharSetup.ContainsKey(str) = True Then
            strV = dictCharSetup(str)
            If strV = "1" Then
                SafeCheck_CheckStateValue = CheckState.Checked
            Else
                SafeCheck_CheckStateValue = CheckState.Unchecked
            End If
        Else
            SafeCheck_CheckStateValue = defaultVal
        End If
    End Function
    Public Function SafeInteger(ByRef str As String, Optional ByVal defaultVal As Integer = 0) As Integer
        If IsNumeric(str) = False Then
            SafeInteger = defaultVal
        Else
            SafeInteger = CInt(str)
        End If
    End Function
    Public Function getMinValueIndex(ByRef arr() As Integer, Optional ByVal excludeValue As Integer = 0, Optional ByVal shouldBeMoreThanThis As Integer = Integer.MinValue) As Integer
        Dim minV As Integer = Integer.MaxValue
        Dim minI As Integer = -1
        For i As Integer = 0 To UBound(arr)
            If arr(i) > shouldBeMoreThanThis Then
                If Not (excludeValue = arr(i)) Then
                    If (arr(i) < minV) Then
                        minI = i
                        minV = arr(i)
                    End If
                End If
            End If
        Next i
        getMinValueIndex = minI
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Sub PlayTheSound(ByRef charName As String)
        If dictCharNextPossibleSound.ContainsKey(charName) = True Then
            If dictCharNextPossibleSound(charName) > Now.Ticks Then
                Exit Sub
            End If
        End If
        dictCharNextPossibleSound(charName) = Now.Ticks + 40000000 ' 4 seconds
        My.Computer.Audio.Play(My.Resources.Alarm, AudioPlayMode.Background)
    End Sub

    Public Function GetSortedIndex(ByVal reqIndex As Integer, ByRef arr() As Integer) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim arrIndex() As Integer
        Dim arrEasy() As Integer
        Dim arrUsed() As Boolean
        Dim lastItem As Integer
        lastItem = UBound(arr)
        ReDim arrIndex(lastItem)
        ReDim arrEasy(lastItem)
        ReDim arrUsed(lastItem)
        For i = 0 To lastItem
            arrIndex(i) = i
            arrEasy(i) = arr(i)
            arrUsed(i) = False
        Next i
        System.Array.Sort(Of Integer)(arrEasy)
        For i = 0 To lastItem
            For j = 0 To lastItem
                If arr(i) = arrEasy(j) And arrUsed(j) = False Then
                    arrIndex(i) = j
                    arrUsed(j) = True
                    Exit For
                End If
            Next j
        Next i
        'For i = 0 To lastItem
        '    Debug.Print("#" & CStr(i) & " is array element #" & CStr(arrIndex(i)))
        'Next i
        GetSortedIndex = arrIndex(reqIndex)
    End Function
End Module

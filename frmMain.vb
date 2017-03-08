Option Explicit On
Imports System
Imports System.IO
Imports System.Text
Public Class frmMain
    Dim dragStatus As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public currentCharCount As Integer = 0
    Public pausedAll As Boolean = False
    Public currentSettingsVersion As Integer = 128
    Public highestConfig As String = "config1111.ini"
    Public timerActive As Boolean = False

    Public Sub ReadSettings()
        Dim sec As String
        Dim iniReader As cIniArray
        Dim timerMS As String
        Dim basePath1 As String = ""
        iniReader = New cIniArray()

        basePath1 = getMyCurrentAppPath()
        TibiaSettingsPath = "" & basePath1 & "\settings.ini"

        If File.Exists(TibiaSettingsPath) = False Then
            MsgBox("Unable to find " & TibiaSettingsPath, vbOKOnly + vbCritical, "Critical Error")
            Application.Exit()
        End If
        sec = "Global"
        AddressFile = iniReader.IniGet(TibiaSettingsPath, sec, "AddressFile")
        If Not (AddressFile = highestConfig) Then
            If MsgBox("You are loading an old address config (" & AddressFile & ")" & vbCrLf & "Do you want to load the newest one instead? (" & highestConfig & ")", vbYesNo, "Warning") = vbYes Then
                AddressFile = highestConfig
                iniReader.IniWrite(TibiaSettingsPath, sec, "AddressFile", AddressFile)
            End If
        End If
        timerMS = iniReader.IniGet(TibiaSettingsPath, sec, "timerMS")
        TibiaConfigPath = getMyCurrentAppPath() & "\" & AddressFile
        If IsNumeric(timerMS) Then
            Me.tmrMain.Interval = CInt(timerMS)
        End If
        currentTotalFriends = CInt(iniReader.IniGet(TibiaSettingsPath, sec, "totalFriends", "0"))
        ReDim currentFriend(0)
        If currentTotalFriends > 0 Then
            ReDim currentFriend(currentTotalFriends - 1)
            For i = 0 To currentTotalFriends - 1
                currentFriend(i) = iniReader.IniGet(TibiaSettingsPath, sec, "friend" & CStr(i))
            Next i
        End If
        settingsVersion = CInt(iniReader.IniGet(TibiaSettingsPath, sec, "settingsVersion", "100"))
    End Sub

    Public Sub LoadTibiaAddresses()
        Dim sec As String
        Dim iniReader As cIniArray
        iniReader = New cIniArray()
        If (MyFileExist(TibiaConfigPath) = False) Then
            MsgBox("Unable to read " & TibiaConfigPath, vbOKOnly + vbCritical, "Critical Error")
            Application.Exit()
        End If


        sec = "Memory"
        tibiatitle = iniReader.IniGet(TibiaConfigPath, sec, "tibiatitle")
        className = iniReader.IniGet(TibiaConfigPath, sec, "tibiaclassname")
        tibiaMainName = iniReader.IniGet(TibiaConfigPath, sec, "tibiamainname")
        className_updater = iniReader.IniGet(TibiaConfigPath, sec, "tibiaclassname_updater")
        tibiaMainName_updater = iniReader.IniGet(TibiaConfigPath, sec, "tibiamainname_updater")
        tibiatitle_updater = iniReader.IniGet(TibiaConfigPath, sec, "tibiatitle_updater")
        adrXPos = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrXPos")
        adrYPos = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrYPos")
        adrZPos = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrZPos")
        adrMyHP = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMyHP")
        adrMyMaxHP = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMyMaxHP")
        adrCapacity = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrCapacity")
        adrMaxCapacity = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMaxCapacity")
        adrExperience = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrExperience")
        adrLevel = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrLevel")
        adrMyMana = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMyMana")
        adrMyMaxMana = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMyMaxMana")
        adrMySoul = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrMySoul")
        adrChatLog_tabStruct = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrChatLog_tabStruct")
        adrGameConnected = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrGameConnected")
        adrSelectedCharIndex = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrSelectedCharIndex")
        tibia_popup_title = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "tibia_popup_title")
        adrServerList_CollectionStart = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrServerList_CollectionStart")
        adrSelectedItem_height = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrSelectedItem_height")
        adrSelectedCharName = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrSelectedCharName")

        adrSpeakCurrentSendTxt = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrSpeakCurrentSendTxt")
        adrSpeakCursorPosition = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrSpeakCursorPosition")
        adrBattlelist_CollectionStart = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrBattlelist_CollectionStart")

        adrStatus_CountAndListStart = iniReader.IniGetADDRESSPATH(TibiaConfigPath, sec, "adrStatus_CountAndListStart")

    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pausedAll = True
        closeAllOtherForms()
    End Sub
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        'lblTitle.BackColor = myFormsBorderColor
        'lblAuxIcon.BackColor = myFormsBorderColor
        'lblLeftDeco.BackColor = myFormsBorderColor
        'lblRightDeco.BackColor = myFormsBorderColor
        'lblBottomDeco.BackColor = myFormsBorderColor
        'picIcon.BackColor = myFormsBorderColor
        Dim expectedDefault As String
        Dim expectedDefault_content As String
        Dim forceOverwrite As Boolean = False
        expectedDefault = getMyCurrentAppPath() & "\settings.ini"
        If File.Exists(expectedDefault) = False Then
            expectedDefault_content = My.Resources.settings
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        ReadSettings()
        If settingsVersion < currentSettingsVersion Then
            forceOverwrite = True
        End If
        expectedDefault = getMyCurrentAppPath() & "\_default.cfg"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources._default
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1101.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1101
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1102.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1102
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1103.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1103
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1104.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1104
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1110.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1110
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        expectedDefault = getMyCurrentAppPath() & "\config1111.ini"
        If forceOverwrite Or (File.Exists(expectedDefault) = False) Then
            expectedDefault_content = My.Resources.config1111
            My.Computer.FileSystem.WriteAllText(expectedDefault, expectedDefault_content, False, System.Text.ASCIIEncoding.ASCII)
        End If
        Me.TopMost = True
        LoadTibiaAddresses()
        ReDim emptyKeyboardState(255)
        For i = 0 To 255
            emptyKeyboardState(i) = &H0
        Next i

        For i = 0 To 7
            ffx8(i) = &HFF
        Next i

        tmrMain.Enabled = True
        frmGlobalSettings.cmdClose.Focus()
    End Sub

  
    'Private Sub frmMain_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    ControlPaint.DrawBorder(Me.CreateGraphics, Me.ClientRectangle, _
    '                              myFormsBorderColor, myFormsBorderSize, ButtonBorderStyle.Solid, _
    '                              myFormsBorderColor, myFormsBorderSize, ButtonBorderStyle.Solid, _
    '                              myFormsBorderColor, myFormsBorderSize, ButtonBorderStyle.Solid, _
    '                              myFormsBorderColor, myFormsBorderSize, ButtonBorderStyle.Solid)
    'End Sub



    Private Sub frmMain_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTitle_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTitle_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub
 
    Private Sub lblCurrentStatusSTATIC_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatusSTATIC.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblCurrentStatusSTATIC_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatusSTATIC.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblCurrentStatusSTATIC_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatusSTATIC.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub


    Private Sub lblCurrentStatus_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatus.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblCurrentStatus_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatus.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblCurrentStatus_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblCurrentStatus.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub
    Private Sub picIcon_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picIcon.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub picIcon_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picIcon.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub picIcon_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picIcon.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub


    Private Sub lblAuxIcon_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblAuxIcon.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblAuxIcon_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblAuxIcon.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblAuxIcon_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblAuxIcon.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub




  

    Private Sub cmdCloseApp_Click(sender As System.Object, e As System.EventArgs) Handles cmdCloseApp.Click
        Me.Close()
    End Sub

 




  

    Private Sub lblTitle_Click(sender As System.Object, e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub closeAllOtherForms(Optional ByVal closeAll = True)
        Dim keyStr As String
        For Each keyStr In dictCharForms.Keys
            If (IsNothing(dictCharForms(keyStr)) = False) Then
                ' Debug.Print("Closing " & dictCharForms(keyStr).lblTitle.Text)
                dictCharForms(keyStr).SaveSettings()
                dictCharForms(keyStr).Close()
            End If
        Next keyStr
        dictCharForms.Clear()
        If closeAll Then
            frmCharSetupUNIQUE.Close()
            frmGlobalSettings.Close()
        End If
        currentCharCount = 0
    End Sub

    Private Sub CharLogin(ByRef strCharName As String)
        ' Debug.Print("Char login: " & strCharName)
        If (dictCharForms.ContainsKey(strCharName) = False) Then
            dictCharForms(strCharName) = New frmChar()
            dictCharForms(strCharName).lblTitle.Text = strCharName
            dictCharForms(strCharName).Show()
            dictCharForms(strCharName).myCharName = strCharName
            frmCharSetupUNIQUE.LoadConfigAtNewCharPopup(strCharName)
        End If
    End Sub

    Private Sub CharLogout(ByRef strCharName As String)

        dictCharForms(strCharName).Close()
        dictCharForms.Remove(strCharName)
        '  Debug.Print("Char logout: " & strCharName)
    End Sub

    Private Sub UpdateOpenedChars(Optional ByVal forceLabelUpdate As Boolean = False)
        Dim charName As String
        Dim countOpen As Long = 0
        Dim charsToRemove() As String
        Dim lastRemovedIndex As Integer = -1
        Dim i As Integer
        ReDim charsToRemove(0)
        UpdateOpenCharsIdInfo(tibiaMainName, className)
        For Each charName In dictCharIdInfo.Keys
            countOpen = countOpen + 1
            If dictCharForms.ContainsKey(charName) = False Then
                CharLogin(charName)
                dictCharForms(charName).UpdateHPmanaBars()
            End If
            dictCharForms(charName).pid = dictCharIdInfo(charName).pid
            dictCharForms(charName).mainHandle = dictCharIdInfo(charName).mainHandle
            dictCharForms(charName).myCharName = charName
        Next charName
        For Each charName In dictCharForms.Keys
            If dictCharIdInfo.ContainsKey(charName) = False Then
                lastRemovedIndex = lastRemovedIndex + 1
                ReDim Preserve charsToRemove(lastRemovedIndex)
                charsToRemove(lastRemovedIndex) = charName
            End If
        Next charName
        For i = 0 To lastRemovedIndex
            CharLogout(charsToRemove(i))
        Next i
        If Not (countOpen = currentCharCount) Or forceLabelUpdate Then
            currentCharCount = countOpen
            If countOpen = 0 Then
                lblCurrentStatus.Text = "No chars detected. First login your chars using Tibia 11 client"
                lblCurrentStatus.ForeColor = Color.White
            ElseIf countOpen = 1 Then
                lblCurrentStatus.Text = "READY (1 char detected)"
                lblCurrentStatus.ForeColor = Color.GreenYellow
            Else
                lblCurrentStatus.Text = "READY (" & CStr(countOpen) & " chars detected)"
                lblCurrentStatus.ForeColor = Color.GreenYellow
            End If
        End If
    End Sub


    Private Sub cmdPauseResume_Click(sender As System.Object, e As System.EventArgs) Handles cmdPauseResume.Click
        pauseResumeClick()
    End Sub

    Private Sub cmdSettings_Click(sender As System.Object, e As System.EventArgs) Handles cmdSettings.Click
        openGlobalSettings()
    End Sub

 

    Private Sub lblLeftDeco_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblLeftDeco.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblLeftDeco_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblLeftDeco.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblLeftDeco_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblLeftDeco.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblRightDeco_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRightDeco.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblRightDeco_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRightDeco.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblRightDeco_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRightDeco.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblBottomDeco_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblBottomDeco.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblBottomDeco_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblBottomDeco.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblBottomDeco_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblBottomDeco.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub cmdMinimizeToTray_Click(sender As System.Object, e As System.EventArgs) Handles cmdMinimizeToTray.Click

        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmdReopenAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdReopenAll.Click
        reopenAllChars()
        'CharLogin("Blackd")
    End Sub

    Private Sub mClose_Click(sender As System.Object, e As System.EventArgs) Handles mClose.Click
        Me.Close()
    End Sub

    Private Sub mShowMainMenu_Click(sender As System.Object, e As System.EventArgs) Handles mShowMainMenu.Click

        Me.Show()
        cmdMinimizeToTray.Focus()
    End Sub


    Private Sub btnTray_Click(sender As System.Object, e As System.EventArgs) Handles btnTray.Click
        Me.Hide()
    End Sub
    Public Sub reopenAllChars()
        Dim keyStr As String
        For Each keyStr In dictCharForms.Keys
            If (IsNothing(dictCharForms(keyStr)) = False) Then
                dictCharForms(keyStr).Show()
            End If
        Next keyStr
    End Sub
    Public Sub hideAllChars()
        Dim keyStr As String
        For Each keyStr In dictCharForms.Keys
            If (IsNothing(dictCharForms(keyStr)) = False) Then
                dictCharForms(keyStr).Hide()
            End If
        Next keyStr
    End Sub

    Private Sub mShowAll_Click(sender As System.Object, e As System.EventArgs) Handles mShowAll.Click
        reopenAllChars()
    End Sub

    Private Sub mHideAll_Click(sender As System.Object, e As System.EventArgs) Handles mHideAll.Click
        hideAllChars()
    End Sub

    Private Sub mPauseResume_Click(sender As System.Object, e As System.EventArgs) Handles mPauseResume.Click
        pauseResumeClick()
    End Sub
    Public Sub forcePause()
        pausedAll = True
        cmdPauseResume.Text = "Resume all cheats"
        mPauseResume.Text = "Resume all cheats"
        closeAllOtherForms(False)
        lblCurrentStatus.Text = "ALL SYSTEMS PAUSED"
        lblCurrentStatus.ForeColor = Color.FromArgb(255, 115, 115)
    End Sub
    Public Sub forceResume()
        pausedAll = False
        timerActive = False
        cmdPauseResume.Text = "Pause all cheats"
        mPauseResume.Text = "Pause all cheats"
        UpdateOpenedChars(True)
    End Sub
    Public Sub pauseResumeClick()
        If (pausedAll = False) Then
   forcePause
        Else
       forceResume
        End If
    End Sub

    Private Sub mGlobal_Click(sender As System.Object, e As System.EventArgs) Handles mGlobal.Click
        openGlobalSettings()
    End Sub
    Public Sub openGlobalSettings()
        Dim strFriends As String = ""
        For i As Integer = 0 To currentTotalFriends - 1
            If i = 0 Then
                strFriends = currentFriend(i)
            Else
                strFriends = strFriends & vbCrLf & currentFriend(i)
            End If
        Next i
        frmGlobalSettings.Show()
        frmGlobalSettings.txtConfigName.Text = AddressFile
        frmGlobalSettings.txtTimer.Text = CStr(tmrMain.Interval)
        frmGlobalSettings.txtFriends.Text = strFriends
        frmGlobalSettings.cmdClose.Focus()
    End Sub

    ' Main loop
    Private Sub tmrMain_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMain.Tick
        If pausedAll Then
            Exit Sub
        End If
        If (timerActive) Then
            Debug.Print("Overload")
            Exit Sub
        End If
        timerActive = True
        UpdateOpenedChars()
        Dim charName As String
        Dim charNameD As String
        Dim hpVal(2) As Integer
        Dim hpAction(2) As String
        Dim manaVal(2) As Integer
        Dim manaAction(2) As String
        Dim recastHP(2) As Long
        Dim recastMana(2) As Long
        Dim hpPercent As Integer
        Dim hp As Integer
        Dim mana As Integer
        Dim manaPercent As Integer
        Dim maxHp As Integer
        Dim maxMana As Integer
        Dim hpManaCheked As CheckState
        Dim autoEatChecked As CheckState
        Dim manaTrainChecked As CheckState
        Dim antiafkChecked As CheckState
        Dim runemakerChecked As CheckState
        Dim lightChecked As CheckState
        Dim friendsChecked As CheckState
        Dim runeAlarmChecked As CheckState
        Dim eatAction As String
        Dim nextPosEat As Long
        Dim nextPosANTIAFK As Long
        Dim reqMana As Integer
        Dim manaTrainAction As String
        Dim dictBattleList As New Dictionary(Of Integer, Integer)
        Dim dictPlayerStatus As New Dictionary(Of String, Boolean)
        Dim pid As Integer
        Dim charCID As Integer
        Dim currentDirection As Integer
        Dim soul As Integer
        Dim reqRune_Mana As Integer
        Dim reqRune_Soul As Integer
        Dim upToSeconds As Integer
        Dim runemakerSpell As String
        Dim noSoulOption As String
        Dim reqFriendMinHP As Integer
        Dim reqFriendMyMinMana As Integer
        Dim reqFriendMyMinHP As Integer
        Dim keepLoop As Boolean
        Dim nowTicks As Long
        Dim sioRecast As Long
        Dim trainRecast As Long
        Dim priority0 As Integer
        Dim priority1 As Integer
        Dim priority2 As Integer
        Dim arrPriorityOptions(2) As Integer
        Dim almostMaxMana As Integer
        Dim newVal As Integer

        Dim chkMagicShieldChecked As CheckState
        Dim chkInvisibilityChecked As CheckState

        Dim chkCureChecked(2) As CheckState
        Dim chkAutoMagicShieldChecked As CheckState
        Dim chkAutoInvisibilityChecked As CheckState
        Dim reqManaInvisibility As Integer
        Dim txtInvisibilitySpell As String
        Dim reqManaMagicShield As Integer
        Dim txtMagicShieldSpell As String
        Dim reqManaCure(2) As Integer
        Dim txtCureSpell(2) As String
        Dim txtCureHint(2) As String
        Dim recastMagicShield As Long
        Dim recastInvisibility As Long
        Dim myx As Integer
        Dim myy As Integer
        Dim myz As Integer
        Try

            For Each charName In dictCharForms.Keys
                If (IsNothing(dictCharForms(charName)) = False) Then
                    dictCharForms(charName).UpdateHPmanaBars()
                    keepLoop = True
                    ' allowActions = True
                    nowTicks = Now.Ticks
                    If dictCharForms(charName).myHp > 0 Then
                        hp = dictCharForms(charName).myHp
                        mana = dictCharForms(charName).myMana
                        maxHp = dictCharForms(charName).myMaxHp
                        maxMana = dictCharForms(charName).myMaxMana
                        soul = dictCharForms(charName).mySoul
                        hpPercent = (hp * 100) \ maxHp
                        manaPercent = (mana * 100) \ maxMana

                        'If debugMode Then
                        '    hp = 500
                        '    mana = 500
                        '    maxHp = 1000
                        '    maxMana = 1000
                        '    soul = 100
                        '    hpPercent = (hp * 100) \ maxHp
                        '    manaPercent = (mana * 100) \ maxMana
                        'End If


                        pid = dictCharForms(charName).pid

                        charNameD = charName & "_"

                        lightChecked = SafeCheck_CheckStateValue(charNameD & "chkFullLight", CheckState.Unchecked)
                        friendsChecked = SafeCheck_CheckStateValue(charNameD & "chkExuraSio", CheckState.Unchecked)
                        antiafkChecked = SafeCheck_CheckStateValue(charNameD & "checkAntiAFKEnabled", CheckState.Unchecked)

                        chkMagicShieldChecked = SafeCheck_CheckStateValue(charNameD & "chkMagicShield", CheckState.Unchecked)
                        chkInvisibilityChecked = SafeCheck_CheckStateValue(charNameD & "chkInvisibility", CheckState.Unchecked)
                        chkCureChecked(0) = SafeCheck_CheckStateValue(charNameD & "chkCure0", CheckState.Unchecked)
                        chkCureChecked(1) = SafeCheck_CheckStateValue(charNameD & "chkCure1", CheckState.Unchecked)
                        chkCureChecked(2) = SafeCheck_CheckStateValue(charNameD & "chkCure2", CheckState.Unchecked)

                        chkAutoMagicShieldChecked = SafeCheck_CheckStateValue(charNameD & "chkAutoMagicShield", CheckState.Unchecked)
                        chkAutoInvisibilityChecked = SafeCheck_CheckStateValue(charNameD & "chkAutoInvisibility", CheckState.Unchecked)

                        If (antiafkChecked = CheckState.Checked) Or _
                           (lightChecked = CheckState.Checked) Or _
                           (friendsChecked = CheckState.Checked) Or _
                           (chkAutoInvisibilityChecked = CheckState.Checked) _
                            Then
                            ' requires reading battlelist
                            charCID = GetCharCID(pid, adrBattlelist_CollectionStart)
                            ReadTibia11CollectionMIN(pid, adrBattlelist_CollectionStart, dictBattleList)
                        End If
                        If (chkAutoMagicShieldChecked = CheckState.Checked) Or _
                           (chkCureChecked(0) = CheckState.Checked) Or _
                           (chkCureChecked(1) = CheckState.Checked) Or _
                           (chkCureChecked(2) = CheckState.Checked) _
                            Then
                            ' requires reading current player status 
                            ReadPlayerStatus(pid, adrStatus_CountAndListStart, dictPlayerStatus)
                        End If
                        If lightChecked = CheckState.Checked Then
                            SetFullLight(pid, dictBattleList(charCID))
                        End If
                        ' hp mana
                        hpManaCheked = SafeCheck_CheckStateValue(charNameD & "checkHealerEnabled", CheckState.Unchecked)
                        If hpManaCheked = CheckState.Checked Then
                            hpVal(0) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValHP0", "00"))
                            hpVal(1) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValHP1", "00"))
                            hpVal(2) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValHP2", "00"))
                            hpAction(0) = SafeCheck_StringValue(charNameD & "cmbKeyHP0", "--")
                            hpAction(1) = SafeCheck_StringValue(charNameD & "cmbKeyHP1", "--")
                            hpAction(2) = SafeCheck_StringValue(charNameD & "cmbKeyHP2", "--")
                            recastHP(0) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastHP0", "2000")))
                            recastHP(1) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastHP1", "2000")))
                            recastHP(2) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastHP2", "2000")))
                            arrPriorityOptions(0) = hpVal(0)
                            arrPriorityOptions(1) = hpVal(1)
                            arrPriorityOptions(2) = hpVal(2)
                            priority0 = GetSortedIndex(0, arrPriorityOptions)
                            priority1 = GetSortedIndex(1, arrPriorityOptions)
                            priority2 = GetSortedIndex(2, arrPriorityOptions)
                            If (hpPercent < hpVal(priority0)) And (Not (hpAction(priority0) = "--")) Then
                                If ((CheckNextPossibleRecastTime(charName, "hp" & CStr(priority0)) <= nowTicks)) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, hpAction(priority0), "hp" & CStr(priority0), recastHP(priority0))
                                End If
                            ElseIf (hpPercent < hpVal(priority1)) And (Not (hpAction(priority1) = "--")) Then
                                If (CheckNextPossibleRecastTime(charName, "hp" & CStr(priority1)) <= nowTicks) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, hpAction(priority1), "hp" & CStr(priority1), recastHP(priority1))
                                End If
                            ElseIf (hpPercent < hpVal(priority2)) And (Not (hpAction(priority2) = "--")) Then
                                If (CheckNextPossibleRecastTime(charName, "hp" & CStr(priority2)) <= nowTicks) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, hpAction(priority2), "hp" & CStr(priority2), recastHP(priority2))
                                End If
                            End If
                            'minValueIndex = getMinValueIndex(hpVal, 0, hpPercent)
                            'If minValueIndex > -1 Then
                            '    If Not (hpAction(minValueIndex) = "--") Then
                            '        SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, hpAction(minValueIndex))
                            '    End If
                            'End If
                            manaVal(0) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValMana0", "00"))
                            manaVal(1) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValMana1", "00"))
                            manaVal(2) = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValMana2", "00"))
                            manaAction(0) = SafeCheck_StringValue(charNameD & "cmbKeyMana0", "--")
                            manaAction(1) = SafeCheck_StringValue(charNameD & "cmbKeyMana1", "--")
                            manaAction(2) = SafeCheck_StringValue(charNameD & "cmbKeyMana2", "--")
                            recastMana(0) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastMana0", "2000")))
                            recastMana(1) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastMana1", "2000")))
                            recastMana(2) = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastMana2", "2000")))
                            arrPriorityOptions(0) = manaVal(0)
                            arrPriorityOptions(1) = manaVal(1)
                            arrPriorityOptions(2) = manaVal(2)
                            priority0 = GetSortedIndex(0, arrPriorityOptions)
                            priority1 = GetSortedIndex(1, arrPriorityOptions)
                            priority2 = GetSortedIndex(2, arrPriorityOptions)
                            If (manaPercent < manaVal(priority0)) And (Not (manaAction(priority0) = "--")) Then
                                If (CheckNextPossibleRecastTime(charName, "mana" & CStr(priority0)) <= nowTicks) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, manaAction(priority0), "mana" & CStr(priority0), recastMana(priority0))
                                End If
                            ElseIf (manaPercent < manaVal(priority1)) And (Not (manaAction(priority1) = "--")) Then
                                If (CheckNextPossibleRecastTime(charName, "mana" & CStr(priority1)) <= nowTicks) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, manaAction(priority1), "mana" & CStr(priority1), recastMana(priority1))
                                End If
                            ElseIf (manaPercent < manaVal(priority2)) And (Not (manaAction(priority2) = "--")) Then
                                If (CheckNextPossibleRecastTime(charName, "mana" & CStr(priority2)) <= nowTicks) Then
                                    SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, manaAction(priority2), "mana" & CStr(priority2), recastMana(priority2))
                                End If
                            End If
                            'minValueIndex = getMinValueIndex(manaVal, 0, manaPercent)
                            'If minValueIndex > -1 Then
                            '    If Not (manaAction(minValueIndex) = "--") Then
                            '        SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, manaAction(minValueIndex))
                            '    End If
                            'End If
                        End If
                        ' page 2
                        autoEatChecked = SafeCheck_CheckStateValue(charNameD & "checkAutoEatEnabled", CheckState.Unchecked)

                        trainRecast = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastManaTrain", "2000")))
                        If autoEatChecked = CheckState.Checked Then
                            nextPosEat = CheckNextPossibleEat(charName)
                            If nextPosEat < Now.Ticks Then
                                eatAction = SafeCheck_StringValue(charNameD & "cmbKeyFood", "--")
                                If Not (eatAction = "--") Then
                                    EatFood(dictCharForms(charName).mainHandle, charName, eatAction, "eat", 0)
                                End If
                            End If

                        End If
                        manaTrainChecked = SafeCheck_CheckStateValue(charNameD & "checkManaTrainEnabled", CheckState.Unchecked)
                        If manaTrainChecked = CheckState.Checked Then
                            almostMaxMana = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValManaTrainNearMax", "95"))
                            almostMaxMana = (almostMaxMana * maxMana) / 100
                            reqMana = whatIsNearMaxManaForChar(charName, almostMaxMana)
                            If (reqMana > almostMaxMana) Or (reqMana < almostMaxMana - 10) Then
                                newVal = getRandomNearMaxMana(almostMaxMana)
                                dictNearMaxManaForChar(charName) = newVal
                                reqMana = newVal
                            End If
                            manaTrainAction = SafeCheck_StringValue(charNameD & "cmbKeyManaTrain", "--")
                            If mana >= reqMana Then
                                If Not (manaTrainAction = "--") Then
                                    TrainMana(dictCharForms(charName).mainHandle, charName, manaTrainAction, almostMaxMana, "train", trainRecast)
                                End If
                            End If
                        End If

                        If antiafkChecked = CheckState.Checked Then
                            currentDirection = GetBattlelistEntry_info(pid, dictBattleList(charCID), &H5C, 1)
                            nextPosANTIAFK = CheckNextPossibleANTIAFK(charName)
                            If nextPosANTIAFK < Now.Ticks Then
                                DoRandomDirectionChange(dictCharForms(charName).mainHandle, charName, currentDirection, "afk", 0)
                            End If
                        End If
                        ' page 4
                        If keepLoop Then
                            If friendsChecked = CheckState.Checked Then
                                sioRecast = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericRecastExuraSIO", "2000")))
                                reqFriendMinHP = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValHPFriend", "0"))
                                reqFriendMyMinMana = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValManaForFriend", "0"))
                                reqFriendMyMinHP = SafeInteger(SafeCheck_StringValue(charNameD & "cmbValHPForFriend", "0"))
                                UpdateMyXYZfromBattlelist(pid, dictBattleList, charCID, myx, myy, myz)
                                If (manaPercent > reqFriendMyMinMana) And (hpPercent > reqFriendMyMinHP) Then
                                    RefreshDictionaryOfFriendHPs(pid, dictBattleList, myx, myy, myz)
                                    For Each possibleName As String In dictFriendHP.Keys
                                        For i As Integer = 0 To currentTotalFriends - 1
                                            If keepLoop Then
                                                If LCase(possibleName) = LCase(currentFriend(i)) Then
                                                    If dictFriendHP(possibleName) < reqFriendMinHP Then
                                                        SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, "exura sio """ & possibleName, "sio", sioRecast)
                                                        keepLoop = False
                                                    End If
                                                End If
                                            End If
                                        Next i
                                        If keepLoop = False Then
                                            Exit For
                                        End If
                                    Next possibleName
                                End If
                            End If
                        End If

                        ' new page
                        reqManaMagicShield = SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellManaMagicShield", "50"))
                        txtMagicShieldSpell = SafeCheck_StringValue(charNameD & "txtMagicShieldSpell", "440")
                        reqManaInvisibility = SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellManaInvisibility", "440"))
                        txtInvisibilitySpell = SafeCheck_StringValue(charNameD & "txtInvisibilitySpell", "440")
                        reqManaCure(0) = SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellManaCure0", "30"))
                        reqManaCure(1) = SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellManaCure1", "30"))
                        reqManaCure(2) = SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellManaCure2", "30"))
                        txtCureHint(0) = SafeCheck_StringValue(charNameD & "txtCureHint0", "You are poisoned")
                        txtCureHint(1) = SafeCheck_StringValue(charNameD & "txtCureHint1", "You are burning")
                        txtCureHint(2) = SafeCheck_StringValue(charNameD & "txtCureHint2", "You are electrified")
                        ' txtCureSpell(0) = SafeCheck_StringValue(charNameD & "txtCureSpell0", "You are poisoned")
                        ' txtCureSpell(1) = SafeCheck_StringValue(charNameD & "txtCureSpell1", "You are burning")
                        ' txtCureSpell(2) = SafeCheck_StringValue(charNameD & "txtCureSpell2", "You are electrified")
                        txtCureSpell(0) = SafeCheck_StringValue(charNameD & "cmbKeyCure0", "")
                        txtCureSpell(1) = SafeCheck_StringValue(charNameD & "cmbKeyCure1", "")
                        txtCureSpell(2) = SafeCheck_StringValue(charNameD & "cmbKeyCure2", "")
                        recastMagicShield = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellSecondsMagicShield", "190"))) * 1000L
                        recastInvisibility = CLng(SafeInteger(SafeCheck_StringValue(charNameD & "numericAutoSpellSecondsInvisibility", "190"))) * 1000L
                        If chkAutoMagicShieldChecked = CheckState.Checked Then
                            If mana >= reqManaMagicShield Then
                                If dictPlayerStatus.ContainsKey("You are protected by a magic shield") = False Then
                                    SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, txtMagicShieldSpell, "sh1", 2000)
                                End If
                            End If
                        End If
                        If chkMagicShieldChecked = CheckState.Checked Then ' by timer
                            If mana >= reqManaMagicShield Then
                                SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, txtMagicShieldSpell, "sh2", recastMagicShield)
                            End If
                        End If
                        If chkAutoInvisibilityChecked = CheckState.Checked Then
                            If charIsInvisible(pid, charName, dictBattleList(charCID)) = False Then
                                If mana >= reqManaInvisibility Then
                                    If Not (txtInvisibilitySpell = "") Then
                                        SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, txtInvisibilitySpell, "in1", 2000)
                                    End If
                                End If
                            End If
                        End If
                        If chkInvisibilityChecked = CheckState.Checked Then ' by timer
                            If mana >= reqManaInvisibility Then
                                SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, txtInvisibilitySpell, "in1", recastInvisibility)
                            End If
                        End If
                        For i = 0 To 2
                            If chkCureChecked(i) = CheckState.Checked Then
                                If mana >= reqManaCure(i) Then
                                    If dictPlayerStatus.ContainsKey(txtCureHint(i)) = True Then
                                        If Not (txtCureSpell(i) = "") Then
                                            ' SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, txtCureSpell(i), "cu" & CStr(i), 6000)
                                            SendHotkeyToTibia11(dictCharForms(charName).mainHandle, charName, txtCureSpell(i), "cu" & CStr(i), 6000)
                                        End If
                                    End If
                                End If
                            End If
                        Next i
                        ' page 3
                        runemakerChecked = SafeCheck_CheckStateValue(charNameD & "checkRunemakerEnabled", CheckState.Unchecked)
                        runeAlarmChecked = SafeCheck_CheckStateValue(charNameD & "checkPlayAlarm", CheckState.Unchecked)
                        If runemakerChecked = CheckState.Checked Then
                            reqRune_Mana = SafeInteger(SafeCheck_StringValue(charNameD & "numericRunemakerManaCost", "0"))
                            reqRune_Soul = SafeInteger(SafeCheck_StringValue(charNameD & "numericRunemakerSoulCost", "0"))
                            upToSeconds = SafeInteger(SafeCheck_StringValue(charNameD & "numericRunemakerMaxDelay", "20"))
                            runemakerSpell = SafeCheck_StringValue(charNameD & "textRunemakerSpell", "")
                            If (mana >= reqRune_Mana) Then
                                If (soul > reqRune_Soul) Then
                                    If checkIfRunemakerWaitedEnough(charName) Then
                                        If runeAlarmChecked = CheckState.Checked Then
                                            PlayTheSound(charName)
                                        End If
                                        If Not (runemakerSpell = "") Then
                                            If SendStringToTibia11(charName, pid, dictCharForms(charName).mainHandle, runemakerSpell, "rune", 500) Then
                                                dictRunemakerRequiredWait(charName) = Now.Ticks + (CLng(upToSeconds) * 10000000L)
                                            End If
                                        End If
                                    End If
                                Else
                                    ' cmbNoSoulOptions
                                    noSoulOption = SafeCheck_StringValue(charNameD & "cmbValMana0", "")
                                    Select Case noSoulOption
                                        Case "Quit Tibia"
                                            ' TODO: close Tibia
                                            CloseTibiaByPID(pid) ' this should be the last action in this loop!!
                                        Case "Sound Alarm"
                                            PlayTheSound(charName)
                                        Case Else ' mana train
                                            ' do nothing
                                    End Select
                                End If

                            End If
                        End If
                    End If
                End If

            Next charName
        Catch exc As Exception
            timerActive = False
            forcePause()
            If MsgBox("Critical error happened. All cheats have been paused to avoid a crash. Please send screenshot to daniel@blackdtools.com" & vbCrLf & _
                   "Version=" & Application.ProductVersion & vbCrLf & _
                   "Error description=" & exc.Message & vbCrLf & vbCrLf & _
                   "Resume cheats? Yes= RESUME , No= Keep paused", vbYesNo, "Critical error happened. Ready to resume?") = vbYes Then

                forceResume()
            End If
        End Try
        timerActive = False
    End Sub
End Class

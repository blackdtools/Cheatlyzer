Option Explicit On
Imports System
Imports System.IO
Imports System.Text


Public Class frmCharSetup
    Dim dragStatus As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public currentCharName As String = ""
    Public ignoreChanges As Boolean = False

    Private Sub frmCharSetup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        tabHealing.BackColor = DefaultBackColor
        tabAutoEat.BackColor = DefaultBackColor
        tabRunemaker.BackColor = DefaultBackColor
        tabAutoSpells.BackColor = DefaultBackColor
        tabMore.BackColor = DefaultBackColor

        'lblTitle.BackColor = myFormsBorderColor
        'lblAuxIcon.BackColor = myFormsBorderColor
        'lblLeftDeco.BackColor = myFormsBorderColor
        'lblRightDeco.BackColor = myFormsBorderColor
        'lblBottomDeco.BackColor = myFormsBorderColor
        'picIcon.BackColor = myFormsBorderColor
        Me.Location = New Point(0, 23)
        Me.TopMost = True
        FillOptions()
    End Sub
    Private Sub FillOptions()
        Dim myComboType As String
        ignoreChanges = True
        For Each tp As TabPage In Me.Tabs.TabPages
            'Debug.Print("page=" & tp.Name)
            For Each grp As GroupBox In tp.Controls().OfType(Of GroupBox)()
                'Debug.Print("group=" & grp.Name)
                For Each cmb As ComboBox In grp.Controls().OfType(Of ComboBox)()
                    ' Debug.Print(cmb.Name)
                    myComboType = Mid(cmb.Name, 1, 6)
                    Select Case myComboType
                        Case "cmbVal"
                            With cmb
                                .Items.Add("100")
                                .Items.Add("95")
                                .Items.Add("90")
                                .Items.Add("85")
                                .Items.Add("80")
                                .Items.Add("75")
                                .Items.Add("70")
                                .Items.Add("65")
                                .Items.Add("60")
                                .Items.Add("55")
                                .Items.Add("50")
                                .Items.Add("45")
                                .Items.Add("40")
                                .Items.Add("35")
                                .Items.Add("30")
                                .Items.Add("25")
                                .Items.Add("20")
                                .Items.Add("15")
                                .Items.Add("10")
                                .Items.Add("05")
                                .Items.Add("00")
                                .SelectedIndex = 20
                            End With
                        Case "cmbKey"
                            With cmb
                                .Items.Add("F1")
                                .Items.Add("F2")
                                .Items.Add("F3")
                                .Items.Add("F4")
                                .Items.Add("F5")
                                .Items.Add("F6")
                                .Items.Add("F7")
                                .Items.Add("F8")
                                .Items.Add("F9")
                                .Items.Add("F10")
                                .Items.Add("F11")
                                .Items.Add("F12")
                                .Items.Add("Ctrl+F1")
                                .Items.Add("Ctrl+F2")
                                .Items.Add("Ctrl+F3")
                                .Items.Add("Ctrl+F4")
                                .Items.Add("Ctrl+F5")
                                .Items.Add("Ctrl+F6")
                                .Items.Add("Ctrl+F7")
                                .Items.Add("Ctrl+F8")
                                .Items.Add("Ctrl+F9")
                                .Items.Add("Ctrl+F10")
                                .Items.Add("Ctrl+F11")
                                .Items.Add("Ctrl+F12")
                                .Items.Add("--")
                                .SelectedIndex = 24
                            End With
                    End Select
                Next cmb
            Next grp
        Next tp
        ignoreChanges = False
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

    Private Sub frmCharSetup_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmCharSetup_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub


    Private Sub frmCharSetup_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs)
        SaveCurrentConfig()
    End Sub

    Public Sub SaveCurrentConfig()
        If Not (currentCharName = "") Then
            SaveConfigInMemory()
            SaveConfigAt(getMyCurrentAppPath() & "\" & currentCharName & ".cfg")
        End If
    End Sub

    Public Sub LoadCurrentConfig()
        LoadConfigFrom(getMyCurrentAppPath() & "\" & currentCharName & ".cfg", True, currentCharName)
    End Sub
    Private Sub addLineToString(ByRef line As String, ByRef all As String)
        If all = "" Then
            all = line
        Else
            all = all & vbCrLf & line
        End If
    End Sub

    Public Sub LoadConfigAtNewCharPopup(ByRef pCharname As String)
        If pCharname = currentCharName Then
            LoadConfigFrom(getMyCurrentAppPath() & "\" & pCharname & ".cfg", True, pCharname)
        Else
            LoadConfigFrom(getMyCurrentAppPath() & "\" & pCharname & ".cfg", False, pCharname)
        End If
    End Sub
    Public Sub LoadConfigFrom(ByRef fullPath As String, ByVal updateControls As Boolean, ByRef pCharName As String, Optional ByVal isDefaultConfig As Boolean = False)
        Dim lineParts() As String
        Dim textLines() As String
        Dim currentLine As String
        Dim safeCheckCMBstring As String = ""
        Dim safeCheckCHKval As String
        Dim safeChecknum As Decimal
        Dim myComboType As String
        If isDefaultConfig = False Then
            LoadConfigFrom(getMyCurrentAppPath() & "\_default.cfg", updateControls, pCharName, True)
        End If
        ignoreChanges = True
        If File.Exists(fullPath) = False Then
            If isDefaultConfig = False Then
                LoadConfigFrom(getMyCurrentAppPath() & "\_default.cfg", updateControls, pCharName, True)
            Else
                MsgBox("Unable to load a default config!" & vbCrLf & "Missing file:" & vbCrLf & getMyCurrentAppPath() & "\_default.cfg", vbOKOnly + vbCritical, "Critical error")
                End
            End If
            Exit Sub
        End If
        Dim readText As String = File.ReadAllText(fullPath)
        textLines = Split(readText, vbCrLf)
        For i = 0 To UBound(textLines)
            currentLine = Trim(textLines(i))
            If Not (currentLine = "") Then
                lineParts = Split(textLines(i), "=")
                dictCharSetup(pCharName & "_" & lineParts(0)) = lineParts(1)
            End If
        Next i
        If updateControls Then
            Dim line As String
            For Each tp As TabPage In Me.Tabs.TabPages
                'Debug.Print("page=" & tp.Name)
                For Each grp As GroupBox In tp.Controls().OfType(Of GroupBox)()
                    'Debug.Print("group=" & grp.Name)
                    For Each cmb As ComboBox In grp.Controls().OfType(Of ComboBox)()
                        myComboType = Mid(cmb.Name, 1, 6)
                        Select Case myComboType
                            Case "cmbVal"
                                safeCheckCMBstring = SafeCheck_StringValue(pCharName & "_" & cmb.Name, "00")
                            Case "cmbKey"
                                safeCheckCMBstring = SafeCheck_StringValue(pCharName & "_" & cmb.Name, "--")
                            Case Else
                                safeCheckCMBstring = SafeCheck_StringValue(pCharName & "_" & cmb.Name, "")
                        End Select
                        cmb.Text = safeCheckCMBstring
                    Next cmb
                    For Each chk As CheckBox In grp.Controls().OfType(Of CheckBox)()
                        Select Case chk.CheckState
                            Case CheckState.Checked
                                line = chk.Name & "=1"
                            Case Else
                                line = chk.Name & "=0"
                        End Select
                        safeCheckCHKval = SafeCheck_CheckStateValue(pCharName & "_" & chk.Name, CheckState.Unchecked)
                        chk.CheckState = safeCheckCHKval
                    Next chk
                    For Each num As NumericUpDown In grp.Controls().OfType(Of NumericUpDown)()
                        line = num.Name & "=" & num.Text
                        safeChecknum = SafeCheck_DecimalValue(pCharName & "_" & num.Name, 0)
                        num.Value = safeChecknum
                    Next num
                    For Each txt As TextBox In grp.Controls().OfType(Of TextBox)()
                        safeCheckCMBstring = SafeCheck_StringValue(pCharName & "_" & txt.Name, "")
                        txt.Text = safeCheckCMBstring
                    Next txt
                Next grp
            Next tp
        End If
        ignoreChanges = False
        ' Debug.Print("Loaded " & fullPath & " for char " & pCharName)
    End Sub

    Public Sub SaveConfigInMemory()
        If ignoreChanges Then
            Exit Sub
        End If
        If currentCharName = "" Then
            Exit Sub
        End If
        ignoreChanges = True
        For Each tp As TabPage In Me.Tabs.TabPages
            'Debug.Print("page=" & tp.Name)
            For Each grp As GroupBox In tp.Controls().OfType(Of GroupBox)()
                'Debug.Print("group=" & grp.Name)
                For Each cmb As ComboBox In grp.Controls().OfType(Of ComboBox)()
                    dictCharSetup(currentCharName & "_" & cmb.Name) = cmb.Text
                Next cmb
                For Each chk As CheckBox In grp.Controls().OfType(Of CheckBox)()
                    Select Case chk.CheckState
                        Case CheckState.Checked
                            dictCharSetup(currentCharName & "_" & chk.Name) = "1"
                        Case Else
                            dictCharSetup(currentCharName & "_" & chk.Name) = "0"
                    End Select
                Next chk
                For Each num As NumericUpDown In grp.Controls().OfType(Of NumericUpDown)()
                    dictCharSetup(currentCharName & "_" & num.Name) = CStr(num.Value)
                Next num
                For Each txt As TextBox In grp.Controls().OfType(Of TextBox)()
                    dictCharSetup(currentCharName & "_" & txt.Name) = txt.Text
                Next txt
            Next grp
        Next tp
        ignoreChanges = False
    End Sub
    Public Sub SaveConfigAt(ByRef fullPath As String)
        Dim line As String
        Dim configString As String = ""

        For Each tp As TabPage In Me.Tabs.TabPages
            'Debug.Print("page=" & tp.Name)
            For Each grp As GroupBox In tp.Controls().OfType(Of GroupBox)()
                'Debug.Print("group=" & grp.Name)
                For Each cmb As ComboBox In grp.Controls().OfType(Of ComboBox)()
                    line = cmb.Name & "=" & cmb.Text
                    addLineToString(line, configString)
                Next cmb
                For Each chk As CheckBox In grp.Controls().OfType(Of CheckBox)()
                    Select Case chk.CheckState
                        Case CheckState.Checked
                            line = chk.Name & "=1"
                        Case Else
                            line = chk.Name & "=0"
                    End Select

                    addLineToString(line, configString)
                Next chk
                For Each num As NumericUpDown In grp.Controls().OfType(Of NumericUpDown)()
                    line = num.Name & "=" & CStr(num.Value)
                    addLineToString(line, configString)
                Next num
                For Each txt As TextBox In grp.Controls().OfType(Of TextBox)()
                    line = txt.Name & "=" & txt.Text
                    addLineToString(line, configString)
                Next txt
            Next grp
        Next tp
        Try
            My.Computer.FileSystem.WriteAllText(fullPath, configString, False)
        Catch e As Exception
            MsgBox("Critical error when trying to save config at " & vbCrLf & configString & "Current config=" & configString & vbCrLf & "Highest config=" & frmMain.highestConfig, vbOKOnly + vbCritical, "Critical error")
            End
        End Try
        'Debug.Print("Saved " & fullPath & " for char " & currentCharName)
    End Sub

    Public Sub SaveMemorySettingsToHardisk_ForChar(ByRef pCharName As String)
        If pCharName = currentCharName Then
            SaveCurrentConfig()
        Else
            Dim key As String
            Dim parts() As String
            Dim configString As String = ""
            Dim line As String
            Dim fullPath As String
            For Each key In dictCharSetup.Keys
                parts = Split(key, "_")
                If parts(0) = pCharName Then
                    line = parts(1) & "=" & dictCharSetup(key)
                    addLineToString(line, configString)
                End If
            Next key
            fullPath = getMyCurrentAppPath() & "\" & pCharName & ".cfg"
            My.Computer.FileSystem.WriteAllText(fullPath, configString, False, System.Text.ASCIIEncoding.ASCII)
            '  Debug.Print("Saved MEMORY of char " & pCharName)
        End If
    End Sub
  
    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        SaveCurrentConfig()
        Me.Hide()
    End Sub

    Private Sub cmdLoadFrom_Click(sender As System.Object, e As System.EventArgs) Handles cmdLoadFrom.Click
        Dim loadFileDialog1 As New OpenFileDialog()
        loadFileDialog1.Filter = "Config file|*.cfg"
        loadFileDialog1.Title = "Load config from..."
        loadFileDialog1.InitialDirectory = getMyCurrentAppPath()
        loadFileDialog1.FileName = currentCharName & ".cfg"
        If loadFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not (loadFileDialog1.FileName = "") Then
                LoadConfigFrom(loadFileDialog1.FileName, True, currentCharName)
            End If
        End If
    End Sub

    Private Sub cmdSaveAs_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveAs.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Config file|*.cfg"
        saveFileDialog1.Title = "Save config as..."
        saveFileDialog1.InitialDirectory = getMyCurrentAppPath()
        saveFileDialog1.FileName = currentCharName & ".cfg"
        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not (saveFileDialog1.FileName = "") Then
                SaveConfigAt(saveFileDialog1.FileName)
            End If
        End If
    End Sub

    Public Sub SwitchChar(ByRef pCharName As String)
        lblLoading.Size = New Size(440, 262)
        lblLoading.Visible = True
        Me.lblTitle.Text = "Setup - Loading..."
        Application.DoEvents()
        If Not (currentCharName = pCharName) Then
            If Not (currentCharName = "") Then
                SaveCurrentConfig()
            End If
        End If
        currentCharName = pCharName
        Me.lblTitle.Text = "Setup - " & currentCharName
        LoadCurrentConfig()
        lblLoading.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        SaveCurrentConfig()
        Me.Hide()
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


    Private Sub cmbValHP0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValHP0.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValHP1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValHP1.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValHP2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValHP2.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValMana0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValMana0.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValMana1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValMana1.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValMana2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValMana2.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyHP0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyHP0.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyHP1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyHP1.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyHP2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyHP2.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyMana0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyMana0.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyMana1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyMana1.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyMana2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyMana2.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkHealerEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkHealerEnabled.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyFood_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyFood.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoEatMinimum_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoEatMinimum.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoEatMaximum_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoEatMaximum.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkAutoEatEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkAutoEatEnabled.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyManaTrain_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyManaTrain.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkManaTrainEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkManaTrainEnabled.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAntiAFKMinimum_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAntiAFKMinimum.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAntiAFKMaximum_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAntiAFKMaximum.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkAntiAFKEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkAntiAFKEnabled.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkRunemakerEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkRunemakerEnabled.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub checkPlayAlarm_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkPlayAlarm.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub textRunemakerSpell_TextChanged(sender As System.Object, e As System.EventArgs) Handles textRunemakerSpell.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRunemakerManaCost_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRunemakerManaCost.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRunemakerSoulCost_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRunemakerSoulCost.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbNoSoulOptions_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNoSoulOptions.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkFullLight_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFullLight.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkExuraSio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkExuraSio.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValHPFriend_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValHPFriend.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbValManaForFriend_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValManaForFriend.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

   
    Private Sub numericRunemakerMaxDelay_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRunemakerMaxDelay.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub btnLoadSpell_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadSpell.Click
        SpellMenu.Show(btnLoadSpell, New System.Drawing.Point(1, 1))
    End Sub

    Private Sub LoadRune(ByVal SpellWords, ByVal Mana, ByVal Soul)
        textRunemakerSpell.Text = SpellWords
        numericRunemakerManaCost.Value = Mana
        numericRunemakerSoulCost.Value = Soul
        SaveConfigInMemory()
    End Sub

    Private Sub AvalancheToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AvalancheToolStripMenuItem.Click
        LoadRune("adori mas frigo", 530, 3)
    End Sub

    Private Sub ExplosionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExplosionToolStripMenuItem.Click
        LoadRune("adevo mas hur", 570, 4)
    End Sub

    Private Sub ExplosionToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExplosionToolStripMenuItem1.Click
        LoadRune("adevo mas hur", 570, 4)
    End Sub

    Private Sub FireballToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FireballToolStripMenuItem.Click
        LoadRune("adori flam", 460, 3)
    End Sub

    Private Sub GreatFireballToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreatFireballToolStripMenuItem.Click
        LoadRune("adori mas flam", 530, 3)
    End Sub

    Private Sub HeavyMagicMissileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HeavyMagicMissileToolStripMenuItem.Click
        LoadRune("adori vis", 350, 2)
    End Sub

    Private Sub HeavyMagicMissileToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HeavyMagicMissileToolStripMenuItem1.Click
        LoadRune("adori vis", 350, 2)
    End Sub

    Private Sub HolyMissileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HolyMissileToolStripMenuItem.Click
        LoadRune("adori san", 300, 3)
    End Sub

    Private Sub IcicleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IcicleToolStripMenuItem.Click
        LoadRune("adori frigo", 460, 3)
    End Sub

    Private Sub LightMagicMissileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LightMagicMissileToolStripMenuItem.Click
        LoadRune("adori min vis", 120, 1)
    End Sub

    Private Sub LightMagicMissileToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LightMagicMissileToolStripMenuItem1.Click
        LoadRune("adori min vis", 120, 1)
    End Sub

    Private Sub SoulfireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SoulfireToolStripMenuItem.Click
        LoadRune("adevo res flam", 420, 3)
    End Sub

    Private Sub SoulfireToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SoulfireToolStripMenuItem1.Click
        LoadRune("adevo res flam", 420, 3)
    End Sub

    Private Sub StalagmiteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles StalagmiteToolStripMenuItem1.Click
        LoadRune("adori tera", 350, 2)
    End Sub

    Private Sub StalagmiteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StalagmiteToolStripMenuItem.Click
        LoadRune("adori tera", 350, 2)
    End Sub

    Private Sub StoneShowerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StoneShowerToolStripMenuItem.Click
        LoadRune("adori mas tera", 430, 3)
    End Sub

    Private Sub SuddenDeathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuddenDeathToolStripMenuItem.Click
        LoadRune("adori gran mort", 985, 5)
    End Sub

    Private Sub ThunderstormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ThunderstormToolStripMenuItem.Click
        LoadRune("adori mas vis", 430, 3)
    End Sub

    Private Sub FireFieldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FireFieldToolStripMenuItem.Click
        LoadRune("adevo grav flam", 240, 1)
    End Sub

    Private Sub FireFieldToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        LoadRune("adevo grav flam", 240, 1)
    End Sub

    Private Sub EnergyFieldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnergyFieldToolStripMenuItem.Click
        LoadRune("adevo grav vis", 320, 2)
    End Sub

    Private Sub EnergyFieldToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EnergyFieldToolStripMenuItem1.Click
        LoadRune("adevo grav vis", 320, 2)
    End Sub

    Private Sub EnergyBombToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnergyBombToolStripMenuItem.Click
        LoadRune("adevo mas vis", 880, 5)
    End Sub

    Private Sub EnergyWallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnergyWallToolStripMenuItem.Click
        LoadRune("adevo mas grav vis", 1000, 5)
    End Sub

    Private Sub EnergyWallToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EnergyWallToolStripMenuItem1.Click
        LoadRune("adevo mas grav vis", 1000, 5)
    End Sub

    Private Sub FireBombToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FireBombToolStripMenuItem.Click
        LoadRune("adevo mas flam", 600, 4)
    End Sub

    Private Sub FireBombToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FireBombToolStripMenuItem1.Click
        LoadRune("adevo mas flam", 600, 4)
    End Sub

    Private Sub FireFieldToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles FireFieldToolStripMenuItem1.Click
        LoadRune("adevo grav flam", 240, 1)
    End Sub

    Private Sub FireWallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FireWallToolStripMenuItem.Click
        LoadRune("adevo mas grav flam", 780, 4)
    End Sub

    Private Sub FireWallToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FireWallToolStripMenuItem1.Click
        LoadRune("adevo mas grav flam", 780, 4)
    End Sub

    Private Sub PoisonBombToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PoisonBombToolStripMenuItem.Click
        LoadRune("adevo mas pox", 520, 2)
    End Sub

    Private Sub PoisonFieldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PoisonFieldToolStripMenuItem.Click
        LoadRune("adevo grav pox", 200, 1)
    End Sub

    Private Sub PoisonFieldToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PoisonFieldToolStripMenuItem1.Click
        LoadRune("adevo grav pox", 200, 1)
    End Sub

    Private Sub PoisonWallToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PoisonWallToolStripMenuItem1.Click
        LoadRune("adevo mas grav pox", 640, 3)
    End Sub

    Private Sub PoisonWallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PoisonWallToolStripMenuItem.Click
        LoadRune("adevo mas grav pox", 640, 3)
    End Sub

    Private Sub CurePoisonRuneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CurePoisonRuneToolStripMenuItem.Click
        LoadRune("adana pox", 200, 1)
    End Sub

    Private Sub IntenseHealingRuneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IntenseHealingRuneToolStripMenuItem.Click
        LoadRune("adura gran", 120, 2)
    End Sub

    Private Sub UltimateHealingRuneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UltimateHealingRuneToolStripMenuItem.Click
        LoadRune("adura vita", 400, 3)
    End Sub

    Private Sub AnimateDeadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnimateDeadToolStripMenuItem.Click
        LoadRune("adana mort", 600, 5)
    End Sub

    Private Sub AnimateDeadToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AnimateDeadToolStripMenuItem1.Click
        LoadRune("adana mort", 600, 5)
    End Sub

    Private Sub ConvinceCreatureToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConvinceCreatureToolStripMenuItem.Click
        LoadRune("adeta sio", 200, 3)
    End Sub

    Private Sub ChameleonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChameleonToolStripMenuItem.Click
        LoadRune("adevo ina", 600, 2)
    End Sub

    Private Sub DesintergrateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DesintergrateToolStripMenuItem.Click
        LoadRune("adito tera", 200, 3)
    End Sub

    Private Sub DesintergrateToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DesintergrateToolStripMenuItem1.Click
        LoadRune("adito tera", 200, 3)
    End Sub

    Private Sub DesintergrateToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles DesintergrateToolStripMenuItem2.Click
        LoadRune("adito tera", 200, 3)
    End Sub

    Private Sub DestroyFieldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DestroyFieldToolStripMenuItem.Click
        LoadRune("adito grav", 120, 2)
    End Sub

    Private Sub DestroyFieldToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DestroyFieldToolStripMenuItem1.Click
        LoadRune("adito grav", 120, 2)
    End Sub

    Private Sub DestroyFieldToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles DestroyFieldToolStripMenuItem2.Click
        LoadRune("adito grav", 120, 2)
    End Sub

    Private Sub MagicWallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MagicWallToolStripMenuItem.Click
        LoadRune("adevo grav tera", 750, 5)
    End Sub

    Private Sub ParalyzeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParalyzeToolStripMenuItem.Click
        LoadRune("adana ani", 1400, 3)
    End Sub

    Private Sub WildGrowthToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WildGrowthToolStripMenuItem.Click
        LoadRune("adevo grav vita", 600, 5)
    End Sub

    Private Sub ConjureArrowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjureArrowToolStripMenuItem.Click
        LoadRune("exevo con", 100, 1)
    End Sub

    Private Sub ConjureBoltToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjureBoltToolStripMenuItem.Click
        LoadRune("exevo con mort", 140, 2)
    End Sub

    Private Sub ConjureExplosiveArrowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjureExplosiveArrowToolStripMenuItem.Click
        LoadRune("exevo con flam", 290, 3)
    End Sub

    Private Sub ConjurePiercingBoltToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjurePiercingBoltToolStripMenuItem.Click
        LoadRune("exevo con grav", 180, 3)
    End Sub

    Private Sub ConjurePoisonedArrowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjurePoisonedArrowToolStripMenuItem.Click
        LoadRune("exevo con pox", 130, 2)
    End Sub

    Private Sub ConjurePowerBoltToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjurePowerBoltToolStripMenuItem.Click
        LoadRune("exevo con vis", 700, 4)
    End Sub

    Private Sub ConjureSniperArrowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConjureSniperArrowToolStripMenuItem.Click
        LoadRune("exevo con hur", 160, 3)
    End Sub

    Private Sub EnchantSpearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnchantSpearToolStripMenuItem.Click
        LoadRune("exeta con", 350, 3)
    End Sub

    Private Sub FoodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FoodToolStripMenuItem.Click
        LoadRune("exevo pan", 120, 1)
    End Sub

    Private Sub EnchantStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnchantStaffToolStripMenuItem.Click
        LoadRune("exeta vis", 80, 0)
    End Sub

    Private Sub numericRecastHP0_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastHP0.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastHP1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastHP1.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastHP2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastHP2.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastMana0_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastMana0.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastMana1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastMana1.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastMana2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastMana2.ValueChanged
        SaveConfigInMemory()
    End Sub

  
    Private Sub cmbValManaTrainNearMax_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbValManaTrainNearMax.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastManaTrain_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastManaTrain.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericRecastExuraSIO_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericRecastExuraSIO.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkMagicShield_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMagicShield.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkInvisibility_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkInvisibility.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkCure0_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCure0.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkCure1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCure1.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkCure2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCure2.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtMagicShieldSpell_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMagicShieldSpell.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtInvisibilitySpell_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInvisibilitySpell.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureSpell0_TextChanged(sender As System.Object, e As System.EventArgs)
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureSpell1_TextChanged(sender As System.Object, e As System.EventArgs)
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureSpell2_TextChanged(sender As System.Object, e As System.EventArgs)
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellSecondsMagicShield_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellSecondsMagicShield.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellSecondsInvisibility_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellSecondsInvisibility.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkAutoMagicShield_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoMagicShield.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub chkAutoInvisibility_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoInvisibility.CheckedChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureHint0_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCureHint0.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureHint1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCureHint1.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub txtCureHint2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCureHint2.TextChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellManaMagicShield_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellManaMagicShield.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellManaInvisibility_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellManaInvisibility.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellManaCure0_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellManaCure0.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellManaCure1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellManaCure1.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub numericAutoSpellManaCure2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles numericAutoSpellManaCure2.ValueChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyCure0_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyCure0.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyCure1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyCure1.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub

    Private Sub cmbKeyCure2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKeyCure2.SelectedIndexChanged
        SaveConfigInMemory()
    End Sub
End Class
Option Explicit On
Public Class frmChar
    Dim dragStatus As Boolean = False
    Dim mouseX As Integer = 0
    Dim mouseY As Integer = 0
    Public pid As Integer = -1
    Public mainHandle As IntPtr = 0
    Public cheatsEnabled As Boolean = False
    Public myHp As Integer = 0
    Public myMana As Integer = 0
    Public myMaxHp As Integer = 0
    Public myMaxMana As Integer = 0
    Public mySoul As Integer = 0
    Public myCharName As String = ""

    Private Sub frmChar_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveSettings()
    End Sub
    Private Sub frmChar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'lblTitle.BackColor = myFormsBorderColor
        'lblAuxIcon.BackColor = myFormsBorderColor
        'lblLeftDeco.BackColor = myFormsBorderColor
        'lblRightDeco.BackColor = myFormsBorderColor
        'lblBottomDeco.BackColor = myFormsBorderColor
        'picIcon.BackColor = myFormsBorderColor
        Me.TopMost = True

    End Sub

    Private Sub cmdSettings_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetupChar.Click
   
        If frmCharSetupUNIQUE.IsDisposed = True Then
            Debug.Print("Warning at cmdSettings_Click: frmCharSetupUNIQUE.IsDisposed = true ")
            frmCharSetupUNIQUE = New frmCharSetup
        End If
        frmCharSetupUNIQUE.Show()
        frmCharSetupUNIQUE.SwitchChar(myCharName)

        ' UpdateHPmanaBarsDebug()
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

 

    Private Sub lblTitle_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTitle_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmChar_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmChar_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmChar_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgHP_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgHP.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgHP_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgHP.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgHP_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgHP.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgMana_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgMana.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgMana_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgMana.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub pgMana_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pgMana.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblHP_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblHP.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblHP_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblHP.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblHP_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblHP.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblMana_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMana.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblMana_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMana.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblMana_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMana.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Public Sub UpdateHPmanaBarsDebug()
    
        myMaxHp = 185
        myMaxMana = 90

        myHp = GetRandom(50, 185)
        Threading.Thread.Sleep(100)
        myMana = GetRandom(2, 90)

        Me.lblTitle.BackColor = myFormsBorderColor
        Me.picIcon.BackColor = myFormsBorderColor
        Me.lblAuxIcon.BackColor = myFormsBorderColor
        Me.lblLeftDeco.BackColor = myFormsBorderColor
        Me.lblRightDeco.BackColor = myFormsBorderColor

        If Not (myMaxHp = pgHP.Maximum) Then
            pgHP.Value = 0
            pgHP.Maximum = myMaxHp
        End If
        pgHP.Value = myHp
        If Not (myMaxMana = pgMana.Maximum) Then
            pgMana.Value = 0
            pgMana.Maximum = myMaxMana
        End If
        pgMana.Value = myMana
        lblHP.Text = CStr(myHp)
        lblMana.Text = CStr(myMana)
    End Sub

    Public Sub UpdateHPmanaBars()

        Dim previousHP As Integer
        previousHP = myHp

        myHp = ReadCurrentAddress2BYTES(pid, adrMyHP, 0)
        myMana = ReadCurrentAddress2BYTES(pid, adrMyMana, 0)
        myMaxHp = ReadCurrentAddress2BYTES(pid, adrMyMaxHP, 0)
        myMaxMana = ReadCurrentAddress2BYTES(pid, adrMyMaxMana, 0)
        mySoul = ReadCurrentAddress2BYTES(pid, adrMySoul, 0)
        If (myHp = 0) Then
            Me.lblTitle.BackColor = myFormsDEATHColor
            Me.picIcon.BackColor = myFormsDEATHColor
            Me.lblAuxIcon.BackColor = myFormsDEATHColor
            Me.lblLeftDeco.BackColor = myFormsDEATHColor
            Me.lblRightDeco.BackColor = myFormsDEATHColor
            Me.lblBottomDeco.BackColor = myFormsDEATHColor
        ElseIf (previousHP > myHp) Then
            Me.lblTitle.BackColor = myFormsDANGERColor
            Me.picIcon.BackColor = myFormsDANGERColor
            Me.lblAuxIcon.BackColor = myFormsDANGERColor
            Me.lblLeftDeco.BackColor = myFormsDANGERColor
            Me.lblRightDeco.BackColor = myFormsDANGERColor
            Me.lblBottomDeco.BackColor = myFormsDANGERColor
        Else
            Me.lblTitle.BackColor = myFormsBorderColor
            Me.picIcon.BackColor = myFormsBorderColor
            Me.lblAuxIcon.BackColor = myFormsBorderColor
            Me.lblLeftDeco.BackColor = myFormsBorderColor
            Me.lblRightDeco.BackColor = myFormsBorderColor
            Me.lblBottomDeco.BackColor = myFormsBorderColor
        End If
        If Not (myMaxHp = pgHP.Maximum) Then
            pgHP.Value = 0
            pgHP.Maximum = myMaxHp
        End If
        pgHP.Value = myHp
        If Not (myMaxMana = pgMana.Maximum) Then
            pgMana.Value = 0
            pgMana.Maximum = myMaxMana
        End If
        pgMana.Value = myMana
        lblHP.Text = CStr(myHp)
        lblMana.Text = CStr(myMana)
    End Sub

    Public Sub SaveSettings()
        'Debug.Print("saving settings for " & myCharName)
        frmCharSetupUNIQUE.SaveMemorySettingsToHardisk_ForChar(myCharName)
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


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

End Class
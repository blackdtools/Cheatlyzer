Public Class frmGlobalSettings

    Dim dragStatus As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer


    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        applyAndClose()
    End Sub
    Private Sub applyAndClose()
        Dim strAll As String
        Dim saveTo As String
        Dim friends() As String
        Dim totalFriends As Integer = 0
        Dim friendName As String
        strAll = "[Global]" & vbCrLf & _
        "AddressFile=" & Me.txtConfigName.Text & vbCrLf & _
        "timerMS=" & Me.txtTimer.Text
        friends = Split(txtFriends.Text, vbCrLf)
        For i = 0 To UBound(friends)
            friendName = Trim$(friends(i))
            If Not (friendName = "") Then
                strAll = strAll & vbCrLf & "friend" & CStr(i) & "=" & friendName
                totalFriends = totalFriends + 1
            End If
        Next i

        ReDim currentFriend(0)
        currentTotalFriends = totalFriends
        If currentTotalFriends > 0 Then
            totalFriends = 0
            ReDim currentFriend(currentTotalFriends - 1)
            For i = 0 To UBound(friends)
                friendName = Trim$(friends(i))
                If Not (friendName = "") Then
                    currentFriend(totalFriends) = friendName
                    totalFriends = totalFriends + 1
                End If
            Next i
        End If

        strAll = strAll & vbCrLf & "totalFriends=" & totalFriends
        saveTo = getMyCurrentAppPath() & "\settings.ini"
        My.Computer.FileSystem.WriteAllText(saveTo, strAll, False, System.Text.ASCIIEncoding.ASCII)
        Me.Hide()
        frmMain.LoadTibiaAddresses()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        applyAndClose()
    End Sub

   
  
    Private Sub txtTimer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTimer.Validating
        If IsNumeric(txtTimer.Text) = False Then
            e.Cancel = True
            txtTimer.Text = "100"
        End If
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

    Private Sub frmGlobalSettings_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub

 

    Private Sub frmGlobalSettings_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmGlobalSettings_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub frmGlobalSettings_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

 
 

    Private Sub lblMemory_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMemory.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblMemory_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMemory.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblMemory_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblMemory.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTimer_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTimer.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTimer_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTimer.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblTimer_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTimer.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblFriendTitle_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblFriendTitle.MouseDown
        handleSpecialFormDragMODE_MouseDown(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblFriendTitle_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblFriendTitle.MouseMove
        handleSpecialFormDragMODE_MouseMove(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub lblFriendTitle_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblFriendTitle.MouseUp
        handleSpecialFormDragMODE_MouseUp(Me, dragStatus, mouseX, mouseY)
    End Sub

    Private Sub txtFriends_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFriends.TextChanged

    End Sub
End Class
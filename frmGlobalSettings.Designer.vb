<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGlobalSettings
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlobalSettings))
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.txtConfigName = New System.Windows.Forms.TextBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuxIcon = New System.Windows.Forms.Label()
        Me.lblLeftDeco = New System.Windows.Forms.Label()
        Me.lblRightDeco = New System.Windows.Forms.Label()
        Me.lblBottomDeco = New System.Windows.Forms.Label()
        Me.txtFriends = New System.Windows.Forms.TextBox()
        Me.lblFriendTitle = New System.Windows.Forms.Label()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMemory
        '
        Me.lblMemory.BackColor = System.Drawing.Color.Transparent
        Me.lblMemory.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemory.ForeColor = System.Drawing.Color.White
        Me.lblMemory.Location = New System.Drawing.Point(12, 28)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(124, 19)
        Me.lblMemory.TabIndex = 8
        Me.lblMemory.Text = "Memory addresses"
        Me.lblMemory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtConfigName
        '
        Me.txtConfigName.Location = New System.Drawing.Point(12, 50)
        Me.txtConfigName.Name = "txtConfigName"
        Me.txtConfigName.Size = New System.Drawing.Size(124, 20)
        Me.txtConfigName.TabIndex = 9
        Me.txtConfigName.Text = "config1101.ini"
        Me.txtConfigName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(145, 28)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(124, 19)
        Me.lblTimer.TabIndex = 10
        Me.lblTimer.Text = "Timer interval (ms)"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(145, 50)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(124, 20)
        Me.txtTimer.TabIndex = 11
        Me.txtTimer.Text = "100"
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.DimGray
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdClose.FlatAppearance.BorderSize = 2
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(145, 262)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(124, 28)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Apply and Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(262, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 19)
        Me.btnClose.TabIndex = 19
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.picIcon.Image = Global.Cheatlyzer.My.Resources.Resources.miniIcon
        Me.picIcon.Location = New System.Drawing.Point(3, 3)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(16, 16)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 17
        Me.picIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 23)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Global Settings"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAuxIcon
        '
        Me.lblAuxIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAuxIcon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxIcon.ForeColor = System.Drawing.Color.White
        Me.lblAuxIcon.Location = New System.Drawing.Point(0, 0)
        Me.lblAuxIcon.Name = "lblAuxIcon"
        Me.lblAuxIcon.Size = New System.Drawing.Size(29, 23)
        Me.lblAuxIcon.TabIndex = 18
        Me.lblAuxIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLeftDeco
        '
        Me.lblLeftDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLeftDeco.CausesValidation = False
        Me.lblLeftDeco.Location = New System.Drawing.Point(0, 0)
        Me.lblLeftDeco.Name = "lblLeftDeco"
        Me.lblLeftDeco.Size = New System.Drawing.Size(3, 302)
        Me.lblLeftDeco.TabIndex = 20
        '
        'lblRightDeco
        '
        Me.lblRightDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRightDeco.CausesValidation = False
        Me.lblRightDeco.Location = New System.Drawing.Point(280, 0)
        Me.lblRightDeco.Name = "lblRightDeco"
        Me.lblRightDeco.Size = New System.Drawing.Size(3, 302)
        Me.lblRightDeco.TabIndex = 21
        '
        'lblBottomDeco
        '
        Me.lblBottomDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBottomDeco.CausesValidation = False
        Me.lblBottomDeco.Location = New System.Drawing.Point(0, 299)
        Me.lblBottomDeco.Name = "lblBottomDeco"
        Me.lblBottomDeco.Size = New System.Drawing.Size(285, 3)
        Me.lblBottomDeco.TabIndex = 22
        '
        'txtFriends
        '
        Me.txtFriends.Location = New System.Drawing.Point(12, 107)
        Me.txtFriends.Multiline = True
        Me.txtFriends.Name = "txtFriends"
        Me.txtFriends.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFriends.Size = New System.Drawing.Size(257, 149)
        Me.txtFriends.TabIndex = 23
        '
        'lblFriendTitle
        '
        Me.lblFriendTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFriendTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriendTitle.ForeColor = System.Drawing.Color.White
        Me.lblFriendTitle.Location = New System.Drawing.Point(12, 73)
        Me.lblFriendTitle.Name = "lblFriendTitle"
        Me.lblFriendTitle.Size = New System.Drawing.Size(257, 36)
        Me.lblFriendTitle.TabIndex = 24
        Me.lblFriendTitle.Text = "Friend list (for healing with exura sio)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please enter one per line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblFriendTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmGlobalSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cheatlyzer.My.Resources.Resources.tibia_back
        Me.ClientSize = New System.Drawing.Size(283, 302)
        Me.Controls.Add(Me.lblFriendTitle)
        Me.Controls.Add(Me.txtFriends)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAuxIcon)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.txtConfigName)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblBottomDeco)
        Me.Controls.Add(Me.lblRightDeco)
        Me.Controls.Add(Me.lblLeftDeco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGlobalSettings"
        Me.Text = "Global Settings"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents txtConfigName As System.Windows.Forms.TextBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents txtTimer As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAuxIcon As System.Windows.Forms.Label
    Friend WithEvents lblLeftDeco As System.Windows.Forms.Label
    Friend WithEvents lblRightDeco As System.Windows.Forms.Label
    Friend WithEvents lblBottomDeco As System.Windows.Forms.Label
    Friend WithEvents txtFriends As System.Windows.Forms.TextBox
    Friend WithEvents lblFriendTitle As System.Windows.Forms.Label
End Class

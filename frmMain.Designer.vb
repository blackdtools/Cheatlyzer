<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdCloseApp = New System.Windows.Forms.Button()
        Me.lblCurrentStatus = New System.Windows.Forms.Label()
        Me.cmdMinimizeToTray = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.cmdPauseResume = New System.Windows.Forms.Button()
        Me.lblCurrentStatusSTATIC = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblAuxIcon = New System.Windows.Forms.Label()
        Me.cmdReopenAll = New System.Windows.Forms.Button()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblLeftDeco = New System.Windows.Forms.Label()
        Me.lblRightDeco = New System.Windows.Forms.Label()
        Me.lblBottomDeco = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnTray = New System.Windows.Forms.Button()
        Me.mMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mShowMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mPauseResume = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mGlobal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mHideAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyHandle = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCloseApp
        '
        Me.cmdCloseApp.BackColor = System.Drawing.Color.DimGray
        Me.cmdCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdCloseApp.FlatAppearance.BorderSize = 2
        Me.cmdCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCloseApp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseApp.ForeColor = System.Drawing.Color.White
        Me.cmdCloseApp.Location = New System.Drawing.Point(11, 247)
        Me.cmdCloseApp.Name = "cmdCloseApp"
        Me.cmdCloseApp.Size = New System.Drawing.Size(152, 28)
        Me.cmdCloseApp.TabIndex = 0
        Me.cmdCloseApp.Text = "Close app"
        Me.cmdCloseApp.UseVisualStyleBackColor = False
        '
        'lblCurrentStatus
        '
        Me.lblCurrentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStatus.ForeColor = System.Drawing.Color.White
        Me.lblCurrentStatus.Location = New System.Drawing.Point(12, 50)
        Me.lblCurrentStatus.Name = "lblCurrentStatus"
        Me.lblCurrentStatus.Size = New System.Drawing.Size(155, 58)
        Me.lblCurrentStatus.TabIndex = 1
        Me.lblCurrentStatus.Text = "No chars detected. First login your chars using Tibia 11 client"
        Me.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdMinimizeToTray
        '
        Me.cmdMinimizeToTray.BackColor = System.Drawing.Color.DimGray
        Me.cmdMinimizeToTray.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdMinimizeToTray.FlatAppearance.BorderSize = 2
        Me.cmdMinimizeToTray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdMinimizeToTray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMinimizeToTray.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimizeToTray.ForeColor = System.Drawing.Color.White
        Me.cmdMinimizeToTray.Location = New System.Drawing.Point(11, 213)
        Me.cmdMinimizeToTray.Name = "cmdMinimizeToTray"
        Me.cmdMinimizeToTray.Size = New System.Drawing.Size(152, 28)
        Me.cmdMinimizeToTray.TabIndex = 2
        Me.cmdMinimizeToTray.Text = "Minimize to tray icon"
        Me.cmdMinimizeToTray.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 23)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Cheatlyzer 1.27"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSettings
        '
        Me.cmdSettings.BackColor = System.Drawing.Color.DimGray
        Me.cmdSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdSettings.FlatAppearance.BorderSize = 2
        Me.cmdSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSettings.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.ForeColor = System.Drawing.Color.White
        Me.cmdSettings.Location = New System.Drawing.Point(11, 179)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(152, 28)
        Me.cmdSettings.TabIndex = 5
        Me.cmdSettings.Text = "Global settings"
        Me.cmdSettings.UseVisualStyleBackColor = False
        '
        'cmdPauseResume
        '
        Me.cmdPauseResume.BackColor = System.Drawing.Color.DimGray
        Me.cmdPauseResume.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdPauseResume.FlatAppearance.BorderSize = 2
        Me.cmdPauseResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdPauseResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPauseResume.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPauseResume.ForeColor = System.Drawing.Color.White
        Me.cmdPauseResume.Location = New System.Drawing.Point(11, 111)
        Me.cmdPauseResume.Name = "cmdPauseResume"
        Me.cmdPauseResume.Size = New System.Drawing.Size(152, 28)
        Me.cmdPauseResume.TabIndex = 6
        Me.cmdPauseResume.Text = "Pause all cheats"
        Me.cmdPauseResume.UseVisualStyleBackColor = False
        '
        'lblCurrentStatusSTATIC
        '
        Me.lblCurrentStatusSTATIC.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStatusSTATIC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStatusSTATIC.ForeColor = System.Drawing.Color.White
        Me.lblCurrentStatusSTATIC.Location = New System.Drawing.Point(12, 31)
        Me.lblCurrentStatusSTATIC.Name = "lblCurrentStatusSTATIC"
        Me.lblCurrentStatusSTATIC.Size = New System.Drawing.Size(155, 19)
        Me.lblCurrentStatusSTATIC.TabIndex = 7
        Me.lblCurrentStatusSTATIC.Text = "Current status:"
        Me.lblCurrentStatusSTATIC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.picIcon.Image = Global.Cheatlyzer.My.Resources.Resources.miniIcon
        Me.picIcon.Location = New System.Drawing.Point(3, 3)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(16, 16)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 8
        Me.picIcon.TabStop = False
        '
        'lblAuxIcon
        '
        Me.lblAuxIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAuxIcon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxIcon.ForeColor = System.Drawing.Color.White
        Me.lblAuxIcon.Location = New System.Drawing.Point(0, 0)
        Me.lblAuxIcon.Name = "lblAuxIcon"
        Me.lblAuxIcon.Size = New System.Drawing.Size(29, 23)
        Me.lblAuxIcon.TabIndex = 9
        Me.lblAuxIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdReopenAll
        '
        Me.cmdReopenAll.BackColor = System.Drawing.Color.DimGray
        Me.cmdReopenAll.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdReopenAll.FlatAppearance.BorderSize = 2
        Me.cmdReopenAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdReopenAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdReopenAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReopenAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReopenAll.ForeColor = System.Drawing.Color.White
        Me.cmdReopenAll.Location = New System.Drawing.Point(11, 145)
        Me.cmdReopenAll.Name = "cmdReopenAll"
        Me.cmdReopenAll.Size = New System.Drawing.Size(152, 28)
        Me.cmdReopenAll.TabIndex = 10
        Me.cmdReopenAll.Text = "Reopen all char menus"
        Me.cmdReopenAll.UseVisualStyleBackColor = False
        '
        'tmrMain
        '
        '
        'lblLeftDeco
        '
        Me.lblLeftDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLeftDeco.CausesValidation = False
        Me.lblLeftDeco.Location = New System.Drawing.Point(0, 0)
        Me.lblLeftDeco.Name = "lblLeftDeco"
        Me.lblLeftDeco.Size = New System.Drawing.Size(3, 290)
        Me.lblLeftDeco.TabIndex = 11
        '
        'lblRightDeco
        '
        Me.lblRightDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRightDeco.CausesValidation = False
        Me.lblRightDeco.Location = New System.Drawing.Point(173, 0)
        Me.lblRightDeco.Name = "lblRightDeco"
        Me.lblRightDeco.Size = New System.Drawing.Size(3, 290)
        Me.lblRightDeco.TabIndex = 12
        '
        'lblBottomDeco
        '
        Me.lblBottomDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBottomDeco.CausesValidation = False
        Me.lblBottomDeco.Location = New System.Drawing.Point(0, 287)
        Me.lblBottomDeco.Name = "lblBottomDeco"
        Me.lblBottomDeco.Size = New System.Drawing.Size(176, 3)
        Me.lblBottomDeco.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(155, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 19)
        Me.btnClose.TabIndex = 14
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnTray
        '
        Me.btnTray.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTray.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTray.ForeColor = System.Drawing.Color.White
        Me.btnTray.Location = New System.Drawing.Point(135, 2)
        Me.btnTray.Name = "btnTray"
        Me.btnTray.Size = New System.Drawing.Size(19, 19)
        Me.btnTray.TabIndex = 15
        Me.btnTray.TabStop = False
        Me.btnTray.Text = "_"
        Me.btnTray.UseVisualStyleBackColor = False
        '
        'mMenu
        '
        Me.mMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mShowMainMenu, Me.ToolStripSeparator2, Me.mPauseResume, Me.ToolStripSeparator1, Me.mGlobal, Me.ToolStripSeparator4, Me.mHideAll, Me.mShowAll, Me.ToolStripSeparator3, Me.mClose})
        Me.mMenu.Name = "ContextMenuStrip1"
        Me.mMenu.Size = New System.Drawing.Size(195, 160)
        '
        'mShowMainMenu
        '
        Me.mShowMainMenu.Name = "mShowMainMenu"
        Me.mShowMainMenu.Size = New System.Drawing.Size(194, 22)
        Me.mShowMainMenu.Text = "Show main menu"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'mPauseResume
        '
        Me.mPauseResume.Name = "mPauseResume"
        Me.mPauseResume.Size = New System.Drawing.Size(194, 22)
        Me.mPauseResume.Text = "Pause all cheats"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'mGlobal
        '
        Me.mGlobal.Name = "mGlobal"
        Me.mGlobal.Size = New System.Drawing.Size(194, 22)
        Me.mGlobal.Text = "Globlal Settings"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(191, 6)
        '
        'mHideAll
        '
        Me.mHideAll.Name = "mHideAll"
        Me.mHideAll.Size = New System.Drawing.Size(194, 22)
        Me.mHideAll.Text = "Hide all char windows"
        '
        'mShowAll
        '
        Me.mShowAll.Name = "mShowAll"
        Me.mShowAll.Size = New System.Drawing.Size(194, 22)
        Me.mShowAll.Text = "Show all char windows"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(191, 6)
        '
        'mClose
        '
        Me.mClose.Name = "mClose"
        Me.mClose.Size = New System.Drawing.Size(194, 22)
        Me.mClose.Text = "Close Cheatalyzer"
        '
        'notifyHandle
        '
        Me.notifyHandle.ContextMenuStrip = Me.mMenu
        Me.notifyHandle.Icon = CType(resources.GetObject("notifyHandle.Icon"), System.Drawing.Icon)
        Me.notifyHandle.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(176, 290)
        Me.Controls.Add(Me.btnTray)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmdReopenAll)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblCurrentStatus)
        Me.Controls.Add(Me.lblCurrentStatusSTATIC)
        Me.Controls.Add(Me.cmdPauseResume)
        Me.Controls.Add(Me.cmdSettings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdMinimizeToTray)
        Me.Controls.Add(Me.cmdCloseApp)
        Me.Controls.Add(Me.lblAuxIcon)
        Me.Controls.Add(Me.lblLeftDeco)
        Me.Controls.Add(Me.lblRightDeco)
        Me.Controls.Add(Me.lblBottomDeco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheatlyzer 1.27"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCloseApp As System.Windows.Forms.Button
    Friend WithEvents lblCurrentStatus As System.Windows.Forms.Label
    Friend WithEvents cmdMinimizeToTray As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
    Friend WithEvents cmdPauseResume As System.Windows.Forms.Button
    Friend WithEvents lblCurrentStatusSTATIC As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblAuxIcon As System.Windows.Forms.Label
    Friend WithEvents cmdReopenAll As System.Windows.Forms.Button
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents lblLeftDeco As System.Windows.Forms.Label
    Friend WithEvents lblRightDeco As System.Windows.Forms.Label
    Friend WithEvents lblBottomDeco As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnTray As System.Windows.Forms.Button
    Friend WithEvents mMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mShowMainMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mHideAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mShowAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents notifyHandle As System.Windows.Forms.NotifyIcon
    Friend WithEvents mPauseResume As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mGlobal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

End Class

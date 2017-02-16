<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChar
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
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuxIcon = New System.Windows.Forms.Label()
        Me.cmdSetupChar = New System.Windows.Forms.Button()
        Me.tmrChar = New System.Windows.Forms.Timer(Me.components)
        Me.lblLeftDeco = New System.Windows.Forms.Label()
        Me.lblRightDeco = New System.Windows.Forms.Label()
        Me.lblBottomDeco = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pgMana = New Cheatlyzer.ProgressBarEx()
        Me.pgHP = New Cheatlyzer.ProgressBarEx()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHP
        '
        Me.lblHP.BackColor = System.Drawing.Color.Transparent
        Me.lblHP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP.ForeColor = System.Drawing.Color.White
        Me.lblHP.Location = New System.Drawing.Point(103, 26)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(42, 13)
        Me.lblHP.TabIndex = 8
        Me.lblHP.Text = "?"
        Me.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMana
        '
        Me.lblMana.BackColor = System.Drawing.Color.Transparent
        Me.lblMana.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMana.ForeColor = System.Drawing.Color.White
        Me.lblMana.Location = New System.Drawing.Point(103, 41)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(42, 13)
        Me.lblMana.TabIndex = 9
        Me.lblMana.Text = "?"
        Me.lblMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.picIcon.Image = Global.Cheatlyzer.My.Resources.Resources.miniIcon
        Me.picIcon.Location = New System.Drawing.Point(3, 3)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(16, 16)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 11
        Me.picIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(317, 23)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Char Name"
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
        Me.lblAuxIcon.TabIndex = 12
        Me.lblAuxIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSetupChar
        '
        Me.cmdSetupChar.BackColor = System.Drawing.Color.DimGray
        Me.cmdSetupChar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdSetupChar.FlatAppearance.BorderSize = 2
        Me.cmdSetupChar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdSetupChar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdSetupChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetupChar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetupChar.ForeColor = System.Drawing.Color.White
        Me.cmdSetupChar.Location = New System.Drawing.Point(142, 26)
        Me.cmdSetupChar.Name = "cmdSetupChar"
        Me.cmdSetupChar.Size = New System.Drawing.Size(55, 28)
        Me.cmdSetupChar.TabIndex = 13
        Me.cmdSetupChar.Text = "Setup"
        Me.cmdSetupChar.UseVisualStyleBackColor = False
        '
        'lblLeftDeco
        '
        Me.lblLeftDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLeftDeco.CausesValidation = False
        Me.lblLeftDeco.Location = New System.Drawing.Point(0, 0)
        Me.lblLeftDeco.Name = "lblLeftDeco"
        Me.lblLeftDeco.Size = New System.Drawing.Size(3, 61)
        Me.lblLeftDeco.TabIndex = 16
        '
        'lblRightDeco
        '
        Me.lblRightDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRightDeco.CausesValidation = False
        Me.lblRightDeco.Location = New System.Drawing.Point(199, 0)
        Me.lblRightDeco.Name = "lblRightDeco"
        Me.lblRightDeco.Size = New System.Drawing.Size(3, 61)
        Me.lblRightDeco.TabIndex = 17
        '
        'lblBottomDeco
        '
        Me.lblBottomDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBottomDeco.CausesValidation = False
        Me.lblBottomDeco.Location = New System.Drawing.Point(0, 58)
        Me.lblBottomDeco.Name = "lblBottomDeco"
        Me.lblBottomDeco.Size = New System.Drawing.Size(202, 3)
        Me.lblBottomDeco.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(180, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 19)
        Me.btnClose.TabIndex = 19
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pgMana
        '
        Me.pgMana.BackColor = System.Drawing.Color.Transparent
        Me.pgMana.BackgroundColor = System.Drawing.Color.Black
        Me.pgMana.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgMana.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgMana.ForeColor = System.Drawing.Color.White
        Me.pgMana.GradiantColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgMana.GradiantPosition = Cheatlyzer.ProgressBarEx.GradiantArea.Bottom
        Me.pgMana.Image = Nothing
        Me.pgMana.Location = New System.Drawing.Point(6, 41)
        Me.pgMana.Name = "pgMana"
        Me.pgMana.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.pgMana.ShowText = True
        Me.pgMana.Size = New System.Drawing.Size(94, 13)
        Me.pgMana.Value = 50
        '
        'pgHP
        '
        Me.pgHP.BackColor = System.Drawing.Color.Transparent
        Me.pgHP.BackgroundColor = System.Drawing.Color.Black
        Me.pgHP.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgHP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgHP.ForeColor = System.Drawing.Color.White
        Me.pgHP.GradiantColor = System.Drawing.Color.Maroon
        Me.pgHP.GradiantPosition = Cheatlyzer.ProgressBarEx.GradiantArea.Bottom
        Me.pgHP.Image = Nothing
        Me.pgHP.Location = New System.Drawing.Point(6, 26)
        Me.pgHP.Name = "pgHP"
        Me.pgHP.ProgressColor = System.Drawing.Color.LightCoral
        Me.pgHP.ShowText = True
        Me.pgHP.Size = New System.Drawing.Size(94, 13)
        Me.pgHP.Value = 50
        '
        'frmChar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cheatlyzer.My.Resources.Resources.tibia_back
        Me.ClientSize = New System.Drawing.Size(202, 61)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmdSetupChar)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAuxIcon)
        Me.Controls.Add(Me.lblMana)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.pgMana)
        Me.Controls.Add(Me.pgHP)
        Me.Controls.Add(Me.lblLeftDeco)
        Me.Controls.Add(Me.lblRightDeco)
        Me.Controls.Add(Me.lblBottomDeco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(402, 61)
        Me.MinimumSize = New System.Drawing.Size(202, 61)
        Me.Name = "frmChar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "frmChar"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgHP As Cheatlyzer.ProgressBarEx
    Friend WithEvents pgMana As Cheatlyzer.ProgressBarEx
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblMana As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAuxIcon As System.Windows.Forms.Label
    Friend WithEvents cmdSetupChar As System.Windows.Forms.Button
    Public WithEvents tmrChar As System.Windows.Forms.Timer
    Friend WithEvents lblLeftDeco As System.Windows.Forms.Label
    Friend WithEvents lblRightDeco As System.Windows.Forms.Label
    Friend WithEvents lblBottomDeco As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

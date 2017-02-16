<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharSetup))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.tabHealing = New System.Windows.Forms.TabPage()
        Me.grpHPMana = New System.Windows.Forms.GroupBox()
        Me.numericRecastMana2 = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.numericRecastMana1 = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.numericRecastMana0 = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.numericRecastHP2 = New System.Windows.Forms.NumericUpDown()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.numericRecastHP1 = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.numericRecastHP0 = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.checkHealerEnabled = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbValHP2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbValHP1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbValHP0 = New System.Windows.Forms.ComboBox()
        Me.cmbValMana2 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyHP2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbKeyMana2 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyHP1 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyMana0 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyHP0 = New System.Windows.Forms.ComboBox()
        Me.cmbValMana1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbKeyMana1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbValMana0 = New System.Windows.Forms.ComboBox()
        Me.tabAutoEat = New System.Windows.Forms.TabPage()
        Me.grpAntiAFK = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.numericAntiAFKMaximum = New System.Windows.Forms.NumericUpDown()
        Me.numericAntiAFKMinimum = New System.Windows.Forms.NumericUpDown()
        Me.checkAntiAFKEnabled = New System.Windows.Forms.CheckBox()
        Me.groupManaTrain = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numericRecastManaTrain = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbValManaTrainNearMax = New System.Windows.Forms.ComboBox()
        Me.checkManaTrainEnabled = New System.Windows.Forms.CheckBox()
        Me.cmbKeyManaTrain = New System.Windows.Forms.ComboBox()
        Me.groupEat = New System.Windows.Forms.GroupBox()
        Me.cmbKeyFood = New System.Windows.Forms.ComboBox()
        Me.checkAutoEatEnabled = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numericAutoEatMaximum = New System.Windows.Forms.NumericUpDown()
        Me.numericAutoEatMinimum = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabRunemaker = New System.Windows.Forms.TabPage()
        Me.grpRunemaker = New System.Windows.Forms.GroupBox()
        Me.lblS = New System.Windows.Forms.Label()
        Me.numericRunemakerMaxDelay = New System.Windows.Forms.NumericUpDown()
        Me.lblChances = New System.Windows.Forms.Label()
        Me.textRunemakerSpell = New System.Windows.Forms.TextBox()
        Me.btnLoadSpell = New System.Windows.Forms.Button()
        Me.checkPlayAlarm = New System.Windows.Forms.CheckBox()
        Me.cmbNoSoulOptions = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblSoulCost = New System.Windows.Forms.Label()
        Me.lblManaCost = New System.Windows.Forms.Label()
        Me.numericRunemakerSoulCost = New System.Windows.Forms.NumericUpDown()
        Me.numericRunemakerManaCost = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.checkRunemakerEnabled = New System.Windows.Forms.CheckBox()
        Me.tabAutoSpells = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtInvisibilitySpell = New System.Windows.Forms.TextBox()
        Me.numericAutoSpellSecondsInvisibility = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoInvisibility = New System.Windows.Forms.CheckBox()
        Me.numericAutoSpellManaInvisibility = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.chkInvisibility = New System.Windows.Forms.CheckBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCureHint2 = New System.Windows.Forms.TextBox()
        Me.txtCureHint1 = New System.Windows.Forms.TextBox()
        Me.txtCureHint0 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.numericAutoSpellManaCure2 = New System.Windows.Forms.NumericUpDown()
        Me.chkCure2 = New System.Windows.Forms.CheckBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.numericAutoSpellManaCure1 = New System.Windows.Forms.NumericUpDown()
        Me.chkCure1 = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.numericAutoSpellManaCure0 = New System.Windows.Forms.NumericUpDown()
        Me.chkCure0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMagicShieldSpell = New System.Windows.Forms.TextBox()
        Me.numericAutoSpellSecondsMagicShield = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoMagicShield = New System.Windows.Forms.CheckBox()
        Me.numericAutoSpellManaMagicShield = New System.Windows.Forms.NumericUpDown()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.chkMagicShield = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tabMore = New System.Windows.Forms.TabPage()
        Me.grpHealFriends = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.numericRecastExuraSIO = New System.Windows.Forms.NumericUpDown()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbValHPForFriend = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbValManaForFriend = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmbValHPFriend = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkExuraSio = New System.Windows.Forms.CheckBox()
        Me.chkFullLight = New System.Windows.Forms.CheckBox()
        Me.cmdSaveAs = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SpellMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvalancheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplosionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeavyMagicMissileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IcicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightMagicMissileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoulfireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StalagmiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoneShowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorcererToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplosionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireballToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreatFireballToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeavyMagicMissileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightMagicMissileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoulfireToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StalagmiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuddenDeathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThunderstormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaladinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolyMissileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyWallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireBombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireWallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoisonBombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoisonFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoisonWallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorcererToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyBombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyFieldToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyWallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireBombToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireFieldToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireWallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoisonFieldToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoisonWallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurePoisonRuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntenseHealingRuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltimateHealingRuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimateDeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvinceCreatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorcererToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimateDeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChameleonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesintergrateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestroyFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParalyzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WildGrowthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorcererToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesintergrateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestroyFieldToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagicWallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaladinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesintergrateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestroyFieldToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmmunitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjureArrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjureBoltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjureExplosiveArrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjurePiercingBoltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjurePoisonedArrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjurePowerBoltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjureSniperArrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnchantSpearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplySpellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruidToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorcererToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnchantStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAuxIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblLeftDeco = New System.Windows.Forms.Label()
        Me.lblRightDeco = New System.Windows.Forms.Label()
        Me.lblBottomDeco = New System.Windows.Forms.Label()
        Me.cmdLoadFrom = New System.Windows.Forms.Button()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.cmbKeyCure0 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyCure1 = New System.Windows.Forms.ComboBox()
        Me.cmbKeyCure2 = New System.Windows.Forms.ComboBox()
        Me.Tabs.SuspendLayout()
        Me.tabHealing.SuspendLayout()
        Me.grpHPMana.SuspendLayout()
        CType(Me.numericRecastMana2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRecastMana1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRecastMana0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRecastHP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRecastHP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRecastHP0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAutoEat.SuspendLayout()
        Me.grpAntiAFK.SuspendLayout()
        CType(Me.numericAntiAFKMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAntiAFKMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupManaTrain.SuspendLayout()
        CType(Me.numericRecastManaTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupEat.SuspendLayout()
        CType(Me.numericAutoEatMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAutoEatMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRunemaker.SuspendLayout()
        Me.grpRunemaker.SuspendLayout()
        CType(Me.numericRunemakerMaxDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRunemakerSoulCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericRunemakerManaCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAutoSpells.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numericAutoSpellSecondsInvisibility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAutoSpellManaInvisibility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numericAutoSpellManaCure2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAutoSpellManaCure1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAutoSpellManaCure0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numericAutoSpellSecondsMagicShield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAutoSpellManaMagicShield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMore.SuspendLayout()
        Me.grpHealFriends.SuspendLayout()
        CType(Me.numericRecastExuraSIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpellMenu.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.tabHealing)
        Me.Tabs.Controls.Add(Me.tabAutoEat)
        Me.Tabs.Controls.Add(Me.tabRunemaker)
        Me.Tabs.Controls.Add(Me.tabAutoSpells)
        Me.Tabs.Controls.Add(Me.tabMore)
        Me.Tabs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.Location = New System.Drawing.Point(12, 35)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(435, 249)
        Me.Tabs.TabIndex = 9
        '
        'tabHealing
        '
        Me.tabHealing.BackColor = System.Drawing.Color.Transparent
        Me.tabHealing.Controls.Add(Me.grpHPMana)
        Me.tabHealing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabHealing.Location = New System.Drawing.Point(4, 23)
        Me.tabHealing.Name = "tabHealing"
        Me.tabHealing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHealing.Size = New System.Drawing.Size(427, 222)
        Me.tabHealing.TabIndex = 0
        Me.tabHealing.Text = "Health and Mana"
        '
        'grpHPMana
        '
        Me.grpHPMana.Controls.Add(Me.numericRecastMana2)
        Me.grpHPMana.Controls.Add(Me.Label32)
        Me.grpHPMana.Controls.Add(Me.numericRecastMana1)
        Me.grpHPMana.Controls.Add(Me.Label31)
        Me.grpHPMana.Controls.Add(Me.numericRecastMana0)
        Me.grpHPMana.Controls.Add(Me.Label30)
        Me.grpHPMana.Controls.Add(Me.numericRecastHP2)
        Me.grpHPMana.Controls.Add(Me.Label29)
        Me.grpHPMana.Controls.Add(Me.numericRecastHP1)
        Me.grpHPMana.Controls.Add(Me.Label28)
        Me.grpHPMana.Controls.Add(Me.numericRecastHP0)
        Me.grpHPMana.Controls.Add(Me.Label23)
        Me.grpHPMana.Controls.Add(Me.checkHealerEnabled)
        Me.grpHPMana.Controls.Add(Me.Label9)
        Me.grpHPMana.Controls.Add(Me.Label10)
        Me.grpHPMana.Controls.Add(Me.Label8)
        Me.grpHPMana.Controls.Add(Me.Label7)
        Me.grpHPMana.Controls.Add(Me.Label11)
        Me.grpHPMana.Controls.Add(Me.cmbValHP2)
        Me.grpHPMana.Controls.Add(Me.Label12)
        Me.grpHPMana.Controls.Add(Me.cmbValHP1)
        Me.grpHPMana.Controls.Add(Me.Label6)
        Me.grpHPMana.Controls.Add(Me.cmbValHP0)
        Me.grpHPMana.Controls.Add(Me.cmbValMana2)
        Me.grpHPMana.Controls.Add(Me.cmbKeyHP2)
        Me.grpHPMana.Controls.Add(Me.Label5)
        Me.grpHPMana.Controls.Add(Me.Label3)
        Me.grpHPMana.Controls.Add(Me.cmbKeyMana2)
        Me.grpHPMana.Controls.Add(Me.cmbKeyHP1)
        Me.grpHPMana.Controls.Add(Me.cmbKeyMana0)
        Me.grpHPMana.Controls.Add(Me.cmbKeyHP0)
        Me.grpHPMana.Controls.Add(Me.cmbValMana1)
        Me.grpHPMana.Controls.Add(Me.Label2)
        Me.grpHPMana.Controls.Add(Me.cmbKeyMana1)
        Me.grpHPMana.Controls.Add(Me.Label1)
        Me.grpHPMana.Controls.Add(Me.Label4)
        Me.grpHPMana.Controls.Add(Me.cmbValMana0)
        Me.grpHPMana.Location = New System.Drawing.Point(17, 7)
        Me.grpHPMana.Name = "grpHPMana"
        Me.grpHPMana.Size = New System.Drawing.Size(394, 222)
        Me.grpHPMana.TabIndex = 6
        Me.grpHPMana.TabStop = False
        Me.grpHPMana.Text = "Healing and Mana Recharge"
        '
        'numericRecastMana2
        '
        Me.numericRecastMana2.Location = New System.Drawing.Point(339, 160)
        Me.numericRecastMana2.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastMana2.Name = "numericRecastMana2"
        Me.numericRecastMana2.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastMana2.TabIndex = 33
        Me.numericRecastMana2.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(295, 161)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 14)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Recast:"
        '
        'numericRecastMana1
        '
        Me.numericRecastMana1.Location = New System.Drawing.Point(339, 132)
        Me.numericRecastMana1.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastMana1.Name = "numericRecastMana1"
        Me.numericRecastMana1.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastMana1.TabIndex = 31
        Me.numericRecastMana1.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(295, 133)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 14)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "Recast:"
        '
        'numericRecastMana0
        '
        Me.numericRecastMana0.Location = New System.Drawing.Point(339, 104)
        Me.numericRecastMana0.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastMana0.Name = "numericRecastMana0"
        Me.numericRecastMana0.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastMana0.TabIndex = 29
        Me.numericRecastMana0.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(295, 105)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 14)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Recast:"
        '
        'numericRecastHP2
        '
        Me.numericRecastHP2.Location = New System.Drawing.Point(339, 76)
        Me.numericRecastHP2.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastHP2.Name = "numericRecastHP2"
        Me.numericRecastHP2.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastHP2.TabIndex = 27
        Me.numericRecastHP2.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(295, 77)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 14)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Recast:"
        '
        'numericRecastHP1
        '
        Me.numericRecastHP1.Location = New System.Drawing.Point(339, 48)
        Me.numericRecastHP1.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastHP1.Name = "numericRecastHP1"
        Me.numericRecastHP1.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastHP1.TabIndex = 25
        Me.numericRecastHP1.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(295, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(44, 14)
        Me.Label28.TabIndex = 24
        Me.Label28.Text = "Recast:"
        '
        'numericRecastHP0
        '
        Me.numericRecastHP0.Location = New System.Drawing.Point(339, 20)
        Me.numericRecastHP0.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastHP0.Name = "numericRecastHP0"
        Me.numericRecastHP0.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastHP0.TabIndex = 23
        Me.numericRecastHP0.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(295, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 14)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Recast:"
        '
        'checkHealerEnabled
        '
        Me.checkHealerEnabled.AutoSize = True
        Me.checkHealerEnabled.Location = New System.Drawing.Point(9, 184)
        Me.checkHealerEnabled.Name = "checkHealerEnabled"
        Me.checkHealerEnabled.Size = New System.Drawing.Size(353, 18)
        Me.checkHealerEnabled.TabIndex = 21
        Me.checkHealerEnabled.Text = "Enable this feature (Settings at this page will be ignored if left blank)"
        Me.checkHealerEnabled.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Press key:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(156, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Press key:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Press key:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(157, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Press key:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(156, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 14)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Press key:"
        '
        'cmbValHP2
        '
        Me.cmbValHP2.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValHP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValHP2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValHP2.ForeColor = System.Drawing.Color.Black
        Me.cmbValHP2.FormattingEnabled = True
        Me.cmbValHP2.Location = New System.Drawing.Point(104, 74)
        Me.cmbValHP2.Name = "cmbValHP2"
        Me.cmbValHP2.Size = New System.Drawing.Size(46, 22)
        Me.cmbValHP2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Press key:"
        '
        'cmbValHP1
        '
        Me.cmbValHP1.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValHP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValHP1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValHP1.ForeColor = System.Drawing.Color.Black
        Me.cmbValHP1.FormattingEnabled = True
        Me.cmbValHP1.Location = New System.Drawing.Point(104, 46)
        Me.cmbValHP1.Name = "cmbValHP1"
        Me.cmbValHP1.Size = New System.Drawing.Size(46, 22)
        Me.cmbValHP1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "If mana is below:"
        '
        'cmbValHP0
        '
        Me.cmbValHP0.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValHP0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValHP0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValHP0.ForeColor = System.Drawing.Color.Black
        Me.cmbValHP0.FormattingEnabled = True
        Me.cmbValHP0.Location = New System.Drawing.Point(104, 18)
        Me.cmbValHP0.Name = "cmbValHP0"
        Me.cmbValHP0.Size = New System.Drawing.Size(46, 22)
        Me.cmbValHP0.TabIndex = 9
        '
        'cmbValMana2
        '
        Me.cmbValMana2.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValMana2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValMana2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValMana2.ForeColor = System.Drawing.Color.Black
        Me.cmbValMana2.FormattingEnabled = True
        Me.cmbValMana2.Location = New System.Drawing.Point(104, 158)
        Me.cmbValMana2.Name = "cmbValMana2"
        Me.cmbValMana2.Size = New System.Drawing.Size(46, 22)
        Me.cmbValMana2.TabIndex = 17
        '
        'cmbKeyHP2
        '
        Me.cmbKeyHP2.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyHP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyHP2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyHP2.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyHP2.FormattingEnabled = True
        Me.cmbKeyHP2.Location = New System.Drawing.Point(221, 74)
        Me.cmbKeyHP2.Name = "cmbKeyHP2"
        Me.cmbKeyHP2.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyHP2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "If mana is below:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "If health is below: "
        '
        'cmbKeyMana2
        '
        Me.cmbKeyMana2.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyMana2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyMana2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyMana2.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyMana2.FormattingEnabled = True
        Me.cmbKeyMana2.Location = New System.Drawing.Point(220, 158)
        Me.cmbKeyMana2.Name = "cmbKeyMana2"
        Me.cmbKeyMana2.Size = New System.Drawing.Size(69, 22)
        Me.cmbKeyMana2.TabIndex = 17
        '
        'cmbKeyHP1
        '
        Me.cmbKeyHP1.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyHP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyHP1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyHP1.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyHP1.FormattingEnabled = True
        Me.cmbKeyHP1.Location = New System.Drawing.Point(221, 46)
        Me.cmbKeyHP1.Name = "cmbKeyHP1"
        Me.cmbKeyHP1.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyHP1.TabIndex = 5
        '
        'cmbKeyMana0
        '
        Me.cmbKeyMana0.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyMana0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyMana0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyMana0.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyMana0.FormattingEnabled = True
        Me.cmbKeyMana0.Location = New System.Drawing.Point(220, 102)
        Me.cmbKeyMana0.Name = "cmbKeyMana0"
        Me.cmbKeyMana0.Size = New System.Drawing.Size(69, 22)
        Me.cmbKeyMana0.TabIndex = 13
        '
        'cmbKeyHP0
        '
        Me.cmbKeyHP0.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyHP0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyHP0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyHP0.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyHP0.FormattingEnabled = True
        Me.cmbKeyHP0.Location = New System.Drawing.Point(221, 18)
        Me.cmbKeyHP0.Name = "cmbKeyHP0"
        Me.cmbKeyHP0.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyHP0.TabIndex = 4
        '
        'cmbValMana1
        '
        Me.cmbValMana1.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValMana1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValMana1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValMana1.ForeColor = System.Drawing.Color.Black
        Me.cmbValMana1.FormattingEnabled = True
        Me.cmbValMana1.Location = New System.Drawing.Point(104, 128)
        Me.cmbValMana1.Name = "cmbValMana1"
        Me.cmbValMana1.Size = New System.Drawing.Size(46, 22)
        Me.cmbValMana1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "If health is below: "
        '
        'cmbKeyMana1
        '
        Me.cmbKeyMana1.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyMana1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyMana1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyMana1.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyMana1.FormattingEnabled = True
        Me.cmbKeyMana1.Location = New System.Drawing.Point(220, 130)
        Me.cmbKeyMana1.Name = "cmbKeyMana1"
        Me.cmbKeyMana1.Size = New System.Drawing.Size(69, 22)
        Me.cmbKeyMana1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "If health is below: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "If mana is below:"
        '
        'cmbValMana0
        '
        Me.cmbValMana0.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValMana0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValMana0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValMana0.ForeColor = System.Drawing.Color.Black
        Me.cmbValMana0.FormattingEnabled = True
        Me.cmbValMana0.Location = New System.Drawing.Point(104, 102)
        Me.cmbValMana0.Name = "cmbValMana0"
        Me.cmbValMana0.Size = New System.Drawing.Size(46, 22)
        Me.cmbValMana0.TabIndex = 15
        '
        'tabAutoEat
        '
        Me.tabAutoEat.BackColor = System.Drawing.Color.Transparent
        Me.tabAutoEat.Controls.Add(Me.grpAntiAFK)
        Me.tabAutoEat.Controls.Add(Me.groupManaTrain)
        Me.tabAutoEat.Controls.Add(Me.groupEat)
        Me.tabAutoEat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabAutoEat.Location = New System.Drawing.Point(4, 23)
        Me.tabAutoEat.Name = "tabAutoEat"
        Me.tabAutoEat.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAutoEat.Size = New System.Drawing.Size(427, 222)
        Me.tabAutoEat.TabIndex = 1
        Me.tabAutoEat.Text = "Auto Eat/Mana Train/Anti-AFK"
        '
        'grpAntiAFK
        '
        Me.grpAntiAFK.Controls.Add(Me.Label18)
        Me.grpAntiAFK.Controls.Add(Me.Label19)
        Me.grpAntiAFK.Controls.Add(Me.numericAntiAFKMaximum)
        Me.grpAntiAFK.Controls.Add(Me.numericAntiAFKMinimum)
        Me.grpAntiAFK.Controls.Add(Me.checkAntiAFKEnabled)
        Me.grpAntiAFK.Location = New System.Drawing.Point(17, 158)
        Me.grpAntiAFK.Name = "grpAntiAFK"
        Me.grpAntiAFK.Size = New System.Drawing.Size(394, 57)
        Me.grpAntiAFK.TabIndex = 10
        Me.grpAntiAFK.TabStop = False
        Me.grpAntiAFK.Text = "Anti-AFK"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(272, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 14)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "seconds."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(202, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 14)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "to"
        '
        'numericAntiAFKMaximum
        '
        Me.numericAntiAFKMaximum.Location = New System.Drawing.Point(224, 20)
        Me.numericAntiAFKMaximum.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericAntiAFKMaximum.Name = "numericAntiAFKMaximum"
        Me.numericAntiAFKMaximum.Size = New System.Drawing.Size(42, 20)
        Me.numericAntiAFKMaximum.TabIndex = 24
        Me.numericAntiAFKMaximum.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'numericAntiAFKMinimum
        '
        Me.numericAntiAFKMinimum.Location = New System.Drawing.Point(153, 20)
        Me.numericAntiAFKMinimum.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.numericAntiAFKMinimum.Name = "numericAntiAFKMinimum"
        Me.numericAntiAFKMinimum.Size = New System.Drawing.Size(43, 20)
        Me.numericAntiAFKMinimum.TabIndex = 23
        Me.numericAntiAFKMinimum.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'checkAntiAFKEnabled
        '
        Me.checkAntiAFKEnabled.AutoSize = True
        Me.checkAntiAFKEnabled.Location = New System.Drawing.Point(9, 21)
        Me.checkAntiAFKEnabled.Name = "checkAntiAFKEnabled"
        Me.checkAntiAFKEnabled.Size = New System.Drawing.Size(138, 18)
        Me.checkAntiAFKEnabled.TabIndex = 0
        Me.checkAntiAFKEnabled.Text = "Change direction every"
        Me.checkAntiAFKEnabled.UseVisualStyleBackColor = True
        '
        'groupManaTrain
        '
        Me.groupManaTrain.Controls.Add(Me.Label17)
        Me.groupManaTrain.Controls.Add(Me.numericRecastManaTrain)
        Me.groupManaTrain.Controls.Add(Me.Label13)
        Me.groupManaTrain.Controls.Add(Me.Label33)
        Me.groupManaTrain.Controls.Add(Me.cmbValManaTrainNearMax)
        Me.groupManaTrain.Controls.Add(Me.checkManaTrainEnabled)
        Me.groupManaTrain.Controls.Add(Me.cmbKeyManaTrain)
        Me.groupManaTrain.Location = New System.Drawing.Point(17, 64)
        Me.groupManaTrain.Name = "groupManaTrain"
        Me.groupManaTrain.Size = New System.Drawing.Size(394, 86)
        Me.groupManaTrain.TabIndex = 6
        Me.groupManaTrain.TabStop = False
        Me.groupManaTrain.Text = "Mana Train"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(332, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 14)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "ms"
        '
        'numericRecastManaTrain
        '
        Me.numericRecastManaTrain.Location = New System.Drawing.Point(277, 47)
        Me.numericRecastManaTrain.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastManaTrain.Name = "numericRecastManaTrain"
        Me.numericRecastManaTrain.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastManaTrain.TabIndex = 25
        Me.numericRecastManaTrain.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(233, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 14)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Recast:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(23, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(118, 14)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Hotkey to waste mana:"
        '
        'cmbValManaTrainNearMax
        '
        Me.cmbValManaTrainNearMax.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValManaTrainNearMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValManaTrainNearMax.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValManaTrainNearMax.ForeColor = System.Drawing.Color.Black
        Me.cmbValManaTrainNearMax.FormattingEnabled = True
        Me.cmbValManaTrainNearMax.Location = New System.Drawing.Point(260, 18)
        Me.cmbValManaTrainNearMax.Name = "cmbValManaTrainNearMax"
        Me.cmbValManaTrainNearMax.Size = New System.Drawing.Size(46, 22)
        Me.cmbValManaTrainNearMax.TabIndex = 17
        '
        'checkManaTrainEnabled
        '
        Me.checkManaTrainEnabled.AutoSize = True
        Me.checkManaTrainEnabled.Location = New System.Drawing.Point(6, 22)
        Me.checkManaTrainEnabled.Name = "checkManaTrainEnabled"
        Me.checkManaTrainEnabled.Size = New System.Drawing.Size(248, 18)
        Me.checkManaTrainEnabled.TabIndex = 16
        Me.checkManaTrainEnabled.Text = "Waste mana when your %mana is MORE than"
        Me.checkManaTrainEnabled.UseVisualStyleBackColor = True
        '
        'cmbKeyManaTrain
        '
        Me.cmbKeyManaTrain.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyManaTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyManaTrain.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyManaTrain.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyManaTrain.FormattingEnabled = True
        Me.cmbKeyManaTrain.Location = New System.Drawing.Point(150, 46)
        Me.cmbKeyManaTrain.Name = "cmbKeyManaTrain"
        Me.cmbKeyManaTrain.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyManaTrain.TabIndex = 15
        '
        'groupEat
        '
        Me.groupEat.Controls.Add(Me.cmbKeyFood)
        Me.groupEat.Controls.Add(Me.checkAutoEatEnabled)
        Me.groupEat.Controls.Add(Me.Label16)
        Me.groupEat.Controls.Add(Me.Label15)
        Me.groupEat.Controls.Add(Me.numericAutoEatMaximum)
        Me.groupEat.Controls.Add(Me.numericAutoEatMinimum)
        Me.groupEat.Controls.Add(Me.Label14)
        Me.groupEat.Location = New System.Drawing.Point(17, 7)
        Me.groupEat.Name = "groupEat"
        Me.groupEat.Size = New System.Drawing.Size(394, 51)
        Me.groupEat.TabIndex = 4
        Me.groupEat.TabStop = False
        Me.groupEat.Text = "Auto-Eat"
        '
        'cmbKeyFood
        '
        Me.cmbKeyFood.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyFood.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyFood.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyFood.FormattingEnabled = True
        Me.cmbKeyFood.Location = New System.Drawing.Point(99, 17)
        Me.cmbKeyFood.Name = "cmbKeyFood"
        Me.cmbKeyFood.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyFood.TabIndex = 16
        '
        'checkAutoEatEnabled
        '
        Me.checkAutoEatEnabled.AutoSize = True
        Me.checkAutoEatEnabled.Location = New System.Drawing.Point(6, 20)
        Me.checkAutoEatEnabled.Name = "checkAutoEatEnabled"
        Me.checkAutoEatEnabled.Size = New System.Drawing.Size(90, 18)
        Me.checkAutoEatEnabled.TabIndex = 22
        Me.checkAutoEatEnabled.Text = "Eat food with"
        Me.checkAutoEatEnabled.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(332, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 14)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "seconds."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(262, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 14)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "to"
        '
        'numericAutoEatMaximum
        '
        Me.numericAutoEatMaximum.Location = New System.Drawing.Point(284, 18)
        Me.numericAutoEatMaximum.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericAutoEatMaximum.Name = "numericAutoEatMaximum"
        Me.numericAutoEatMaximum.Size = New System.Drawing.Size(42, 20)
        Me.numericAutoEatMaximum.TabIndex = 19
        Me.numericAutoEatMaximum.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'numericAutoEatMinimum
        '
        Me.numericAutoEatMinimum.Location = New System.Drawing.Point(213, 18)
        Me.numericAutoEatMinimum.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.numericAutoEatMinimum.Name = "numericAutoEatMinimum"
        Me.numericAutoEatMinimum.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoEatMinimum.TabIndex = 18
        Me.numericAutoEatMinimum.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(172, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 14)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Every"
        '
        'tabRunemaker
        '
        Me.tabRunemaker.BackColor = System.Drawing.Color.Transparent
        Me.tabRunemaker.Controls.Add(Me.grpRunemaker)
        Me.tabRunemaker.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabRunemaker.Location = New System.Drawing.Point(4, 23)
        Me.tabRunemaker.Name = "tabRunemaker"
        Me.tabRunemaker.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRunemaker.Size = New System.Drawing.Size(427, 222)
        Me.tabRunemaker.TabIndex = 3
        Me.tabRunemaker.Text = "Runemaker"
        '
        'grpRunemaker
        '
        Me.grpRunemaker.Controls.Add(Me.lblS)
        Me.grpRunemaker.Controls.Add(Me.numericRunemakerMaxDelay)
        Me.grpRunemaker.Controls.Add(Me.lblChances)
        Me.grpRunemaker.Controls.Add(Me.textRunemakerSpell)
        Me.grpRunemaker.Controls.Add(Me.btnLoadSpell)
        Me.grpRunemaker.Controls.Add(Me.checkPlayAlarm)
        Me.grpRunemaker.Controls.Add(Me.cmbNoSoulOptions)
        Me.grpRunemaker.Controls.Add(Me.Label24)
        Me.grpRunemaker.Controls.Add(Me.lblSoulCost)
        Me.grpRunemaker.Controls.Add(Me.lblManaCost)
        Me.grpRunemaker.Controls.Add(Me.numericRunemakerSoulCost)
        Me.grpRunemaker.Controls.Add(Me.numericRunemakerManaCost)
        Me.grpRunemaker.Controls.Add(Me.Label21)
        Me.grpRunemaker.Controls.Add(Me.checkRunemakerEnabled)
        Me.grpRunemaker.Location = New System.Drawing.Point(17, 7)
        Me.grpRunemaker.Name = "grpRunemaker"
        Me.grpRunemaker.Size = New System.Drawing.Size(394, 208)
        Me.grpRunemaker.TabIndex = 8
        Me.grpRunemaker.TabStop = False
        Me.grpRunemaker.Text = "Runemaker"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Location = New System.Drawing.Point(302, 129)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(49, 14)
        Me.lblS.TabIndex = 35
        Me.lblS.Text = "seconds"
        '
        'numericRunemakerMaxDelay
        '
        Me.numericRunemakerMaxDelay.Location = New System.Drawing.Point(253, 126)
        Me.numericRunemakerMaxDelay.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.numericRunemakerMaxDelay.Name = "numericRunemakerMaxDelay"
        Me.numericRunemakerMaxDelay.Size = New System.Drawing.Size(43, 20)
        Me.numericRunemakerMaxDelay.TabIndex = 34
        Me.numericRunemakerMaxDelay.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lblChances
        '
        Me.lblChances.AutoSize = True
        Me.lblChances.Location = New System.Drawing.Point(6, 129)
        Me.lblChances.Name = "lblChances"
        Me.lblChances.Size = New System.Drawing.Size(241, 14)
        Me.lblChances.TabIndex = 33
        Me.lblChances.Text = "Before casting spell, do a random wait up to to..."
        '
        'textRunemakerSpell
        '
        Me.textRunemakerSpell.BackColor = System.Drawing.Color.White
        Me.textRunemakerSpell.ForeColor = System.Drawing.Color.Black
        Me.textRunemakerSpell.Location = New System.Drawing.Point(88, 48)
        Me.textRunemakerSpell.Name = "textRunemakerSpell"
        Me.textRunemakerSpell.Size = New System.Drawing.Size(100, 20)
        Me.textRunemakerSpell.TabIndex = 32
        '
        'btnLoadSpell
        '
        Me.btnLoadSpell.Location = New System.Drawing.Point(194, 45)
        Me.btnLoadSpell.Name = "btnLoadSpell"
        Me.btnLoadSpell.Size = New System.Drawing.Size(84, 23)
        Me.btnLoadSpell.TabIndex = 31
        Me.btnLoadSpell.Text = "Select Spell"
        Me.btnLoadSpell.UseVisualStyleBackColor = True
        '
        'checkPlayAlarm
        '
        Me.checkPlayAlarm.AutoSize = True
        Me.checkPlayAlarm.Location = New System.Drawing.Point(9, 156)
        Me.checkPlayAlarm.Name = "checkPlayAlarm"
        Me.checkPlayAlarm.Size = New System.Drawing.Size(306, 18)
        Me.checkPlayAlarm.TabIndex = 30
        Me.checkPlayAlarm.Text = "At same time, play a sound at the moment of the spell cast"
        Me.checkPlayAlarm.UseVisualStyleBackColor = True
        '
        'cmbNoSoulOptions
        '
        Me.cmbNoSoulOptions.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbNoSoulOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoSoulOptions.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbNoSoulOptions.ForeColor = System.Drawing.Color.Black
        Me.cmbNoSoulOptions.FormattingEnabled = True
        Me.cmbNoSoulOptions.Items.AddRange(New Object() {"Quit Tibia", "Mana train", "Sound alarm"})
        Me.cmbNoSoulOptions.Location = New System.Drawing.Point(88, 180)
        Me.cmbNoSoulOptions.Name = "cmbNoSoulOptions"
        Me.cmbNoSoulOptions.Size = New System.Drawing.Size(100, 22)
        Me.cmbNoSoulOptions.TabIndex = 29
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 183)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 14)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "When no soul:"
        '
        'lblSoulCost
        '
        Me.lblSoulCost.AutoSize = True
        Me.lblSoulCost.Location = New System.Drawing.Point(6, 104)
        Me.lblSoulCost.Name = "lblSoulCost"
        Me.lblSoulCost.Size = New System.Drawing.Size(55, 14)
        Me.lblSoulCost.TabIndex = 27
        Me.lblSoulCost.Text = "Soul cost:"
        '
        'lblManaCost
        '
        Me.lblManaCost.AutoSize = True
        Me.lblManaCost.Location = New System.Drawing.Point(6, 78)
        Me.lblManaCost.Name = "lblManaCost"
        Me.lblManaCost.Size = New System.Drawing.Size(60, 14)
        Me.lblManaCost.TabIndex = 26
        Me.lblManaCost.Text = "Mana cost:"
        '
        'numericRunemakerSoulCost
        '
        Me.numericRunemakerSoulCost.Location = New System.Drawing.Point(93, 102)
        Me.numericRunemakerSoulCost.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericRunemakerSoulCost.Name = "numericRunemakerSoulCost"
        Me.numericRunemakerSoulCost.Size = New System.Drawing.Size(43, 20)
        Me.numericRunemakerSoulCost.TabIndex = 25
        '
        'numericRunemakerManaCost
        '
        Me.numericRunemakerManaCost.Location = New System.Drawing.Point(93, 76)
        Me.numericRunemakerManaCost.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericRunemakerManaCost.Name = "numericRunemakerManaCost"
        Me.numericRunemakerManaCost.Size = New System.Drawing.Size(43, 20)
        Me.numericRunemakerManaCost.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Cast spell with:"
        '
        'checkRunemakerEnabled
        '
        Me.checkRunemakerEnabled.AutoSize = True
        Me.checkRunemakerEnabled.Location = New System.Drawing.Point(9, 19)
        Me.checkRunemakerEnabled.Name = "checkRunemakerEnabled"
        Me.checkRunemakerEnabled.Size = New System.Drawing.Size(162, 18)
        Me.checkRunemakerEnabled.TabIndex = 1
        Me.checkRunemakerEnabled.Text = "Enable this page of features"
        Me.checkRunemakerEnabled.UseVisualStyleBackColor = True
        '
        'tabAutoSpells
        '
        Me.tabAutoSpells.Controls.Add(Me.GroupBox2)
        Me.tabAutoSpells.Controls.Add(Me.GroupBox3)
        Me.tabAutoSpells.Controls.Add(Me.GroupBox1)
        Me.tabAutoSpells.Location = New System.Drawing.Point(4, 23)
        Me.tabAutoSpells.Name = "tabAutoSpells"
        Me.tabAutoSpells.Size = New System.Drawing.Size(427, 222)
        Me.tabAutoSpells.TabIndex = 5
        Me.tabAutoSpells.Text = "Auto Spells"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtInvisibilitySpell)
        Me.GroupBox2.Controls.Add(Me.numericAutoSpellSecondsInvisibility)
        Me.GroupBox2.Controls.Add(Me.chkAutoInvisibility)
        Me.GroupBox2.Controls.Add(Me.numericAutoSpellManaInvisibility)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.chkInvisibility)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 49)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invisibility"
        '
        'txtInvisibilitySpell
        '
        Me.txtInvisibilitySpell.Location = New System.Drawing.Point(27, 17)
        Me.txtInvisibilitySpell.Name = "txtInvisibilitySpell"
        Me.txtInvisibilitySpell.Size = New System.Drawing.Size(67, 20)
        Me.txtInvisibilitySpell.TabIndex = 32
        Me.txtInvisibilitySpell.Text = "utana vid"
        '
        'numericAutoSpellSecondsInvisibility
        '
        Me.numericAutoSpellSecondsInvisibility.Location = New System.Drawing.Point(101, 17)
        Me.numericAutoSpellSecondsInvisibility.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numericAutoSpellSecondsInvisibility.Name = "numericAutoSpellSecondsInvisibility"
        Me.numericAutoSpellSecondsInvisibility.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellSecondsInvisibility.TabIndex = 18
        Me.numericAutoSpellSecondsInvisibility.Value = New Decimal(New Integer() {190, 0, 0, 0})
        '
        'chkAutoInvisibility
        '
        Me.chkAutoInvisibility.AutoSize = True
        Me.chkAutoInvisibility.Location = New System.Drawing.Point(173, 20)
        Me.chkAutoInvisibility.Name = "chkAutoInvisibility"
        Me.chkAutoInvisibility.Size = New System.Drawing.Size(115, 18)
        Me.chkAutoInvisibility.TabIndex = 30
        Me.chkAutoInvisibility.Text = "Cast when visible."
        Me.chkAutoInvisibility.UseVisualStyleBackColor = True
        '
        'numericAutoSpellManaInvisibility
        '
        Me.numericAutoSpellManaInvisibility.Location = New System.Drawing.Point(343, 18)
        Me.numericAutoSpellManaInvisibility.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericAutoSpellManaInvisibility.Name = "numericAutoSpellManaInvisibility"
        Me.numericAutoSpellManaInvisibility.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellManaInvisibility.TabIndex = 27
        Me.numericAutoSpellManaInvisibility.Value = New Decimal(New Integer() {440, 0, 0, 0})
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(304, 21)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 14)
        Me.Label36.TabIndex = 28
        Me.Label36.Text = "Mana:"
        '
        'chkInvisibility
        '
        Me.chkInvisibility.AutoSize = True
        Me.chkInvisibility.Location = New System.Drawing.Point(6, 20)
        Me.chkInvisibility.Name = "chkInvisibility"
        Me.chkInvisibility.Size = New System.Drawing.Size(15, 14)
        Me.chkInvisibility.TabIndex = 22
        Me.chkInvisibility.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(145, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(16, 14)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "s."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbKeyCure2)
        Me.GroupBox3.Controls.Add(Me.cmbKeyCure1)
        Me.GroupBox3.Controls.Add(Me.cmbKeyCure0)
        Me.GroupBox3.Controls.Add(Me.txtCureHint2)
        Me.GroupBox3.Controls.Add(Me.txtCureHint1)
        Me.GroupBox3.Controls.Add(Me.txtCureHint0)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.numericAutoSpellManaCure2)
        Me.GroupBox3.Controls.Add(Me.chkCure2)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.numericAutoSpellManaCure1)
        Me.GroupBox3.Controls.Add(Me.chkCure1)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.numericAutoSpellManaCure0)
        Me.GroupBox3.Controls.Add(Me.chkCure0)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 88)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cure problems inmediately"
        '
        'txtCureHint2
        '
        Me.txtCureHint2.Location = New System.Drawing.Point(176, 63)
        Me.txtCureHint2.Name = "txtCureHint2"
        Me.txtCureHint2.Size = New System.Drawing.Size(122, 20)
        Me.txtCureHint2.TabIndex = 47
        Me.txtCureHint2.Text = "You are electrified"
        '
        'txtCureHint1
        '
        Me.txtCureHint1.Location = New System.Drawing.Point(176, 40)
        Me.txtCureHint1.Name = "txtCureHint1"
        Me.txtCureHint1.Size = New System.Drawing.Size(122, 20)
        Me.txtCureHint1.TabIndex = 46
        Me.txtCureHint1.Text = "You are burning"
        '
        'txtCureHint0
        '
        Me.txtCureHint0.Location = New System.Drawing.Point(176, 17)
        Me.txtCureHint0.Name = "txtCureHint0"
        Me.txtCureHint0.Size = New System.Drawing.Size(122, 20)
        Me.txtCureHint0.TabIndex = 45
        Me.txtCureHint0.Text = "You are poisoned"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(98, 66)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 14)
        Me.Label40.TabIndex = 41
        Me.Label40.Text = "if status hint="
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(304, 67)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(36, 14)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "Mana:"
        '
        'numericAutoSpellManaCure2
        '
        Me.numericAutoSpellManaCure2.Location = New System.Drawing.Point(343, 63)
        Me.numericAutoSpellManaCure2.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericAutoSpellManaCure2.Name = "numericAutoSpellManaCure2"
        Me.numericAutoSpellManaCure2.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellManaCure2.TabIndex = 39
        Me.numericAutoSpellManaCure2.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'chkCure2
        '
        Me.chkCure2.AutoSize = True
        Me.chkCure2.Location = New System.Drawing.Point(6, 66)
        Me.chkCure2.Name = "chkCure2"
        Me.chkCure2.Size = New System.Drawing.Size(15, 14)
        Me.chkCure2.TabIndex = 38
        Me.chkCure2.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(98, 43)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 14)
        Me.Label38.TabIndex = 36
        Me.Label38.Text = "if status hint="
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(304, 44)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(36, 14)
        Me.Label39.TabIndex = 35
        Me.Label39.Text = "Mana:"
        '
        'numericAutoSpellManaCure1
        '
        Me.numericAutoSpellManaCure1.Location = New System.Drawing.Point(343, 42)
        Me.numericAutoSpellManaCure1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericAutoSpellManaCure1.Name = "numericAutoSpellManaCure1"
        Me.numericAutoSpellManaCure1.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellManaCure1.TabIndex = 34
        Me.numericAutoSpellManaCure1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'chkCure1
        '
        Me.chkCure1.AutoSize = True
        Me.chkCure1.Location = New System.Drawing.Point(6, 43)
        Me.chkCure1.Name = "chkCure1"
        Me.chkCure1.Size = New System.Drawing.Size(15, 14)
        Me.chkCure1.TabIndex = 33
        Me.chkCure1.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(98, 20)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(72, 14)
        Me.Label44.TabIndex = 31
        Me.Label44.Text = "if status hint="
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(304, 21)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(36, 14)
        Me.Label43.TabIndex = 30
        Me.Label43.Text = "Mana:"
        '
        'numericAutoSpellManaCure0
        '
        Me.numericAutoSpellManaCure0.Location = New System.Drawing.Point(343, 19)
        Me.numericAutoSpellManaCure0.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericAutoSpellManaCure0.Name = "numericAutoSpellManaCure0"
        Me.numericAutoSpellManaCure0.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellManaCure0.TabIndex = 29
        Me.numericAutoSpellManaCure0.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'chkCure0
        '
        Me.chkCure0.AutoSize = True
        Me.chkCure0.Location = New System.Drawing.Point(6, 20)
        Me.chkCure0.Name = "chkCure0"
        Me.chkCure0.Size = New System.Drawing.Size(15, 14)
        Me.chkCure0.TabIndex = 22
        Me.chkCure0.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMagicShieldSpell)
        Me.GroupBox1.Controls.Add(Me.numericAutoSpellSecondsMagicShield)
        Me.GroupBox1.Controls.Add(Me.chkAutoMagicShield)
        Me.GroupBox1.Controls.Add(Me.numericAutoSpellManaMagicShield)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.chkMagicShield)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Magic shield"
        '
        'txtMagicShieldSpell
        '
        Me.txtMagicShieldSpell.Location = New System.Drawing.Point(28, 17)
        Me.txtMagicShieldSpell.Name = "txtMagicShieldSpell"
        Me.txtMagicShieldSpell.Size = New System.Drawing.Size(67, 20)
        Me.txtMagicShieldSpell.TabIndex = 31
        Me.txtMagicShieldSpell.Text = "utamo vita"
        '
        'numericAutoSpellSecondsMagicShield
        '
        Me.numericAutoSpellSecondsMagicShield.Location = New System.Drawing.Point(101, 17)
        Me.numericAutoSpellSecondsMagicShield.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numericAutoSpellSecondsMagicShield.Name = "numericAutoSpellSecondsMagicShield"
        Me.numericAutoSpellSecondsMagicShield.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellSecondsMagicShield.TabIndex = 18
        Me.numericAutoSpellSecondsMagicShield.Value = New Decimal(New Integer() {190, 0, 0, 0})
        '
        'chkAutoMagicShield
        '
        Me.chkAutoMagicShield.AutoSize = True
        Me.chkAutoMagicShield.Location = New System.Drawing.Point(173, 20)
        Me.chkAutoMagicShield.Name = "chkAutoMagicShield"
        Me.chkAutoMagicShield.Size = New System.Drawing.Size(128, 18)
        Me.chkAutoMagicShield.TabIndex = 30
        Me.chkAutoMagicShield.Text = "Cast when no shield."
        Me.chkAutoMagicShield.UseVisualStyleBackColor = True
        '
        'numericAutoSpellManaMagicShield
        '
        Me.numericAutoSpellManaMagicShield.Location = New System.Drawing.Point(343, 18)
        Me.numericAutoSpellManaMagicShield.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numericAutoSpellManaMagicShield.Name = "numericAutoSpellManaMagicShield"
        Me.numericAutoSpellManaMagicShield.Size = New System.Drawing.Size(43, 20)
        Me.numericAutoSpellManaMagicShield.TabIndex = 27
        Me.numericAutoSpellManaMagicShield.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(304, 21)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(36, 14)
        Me.Label41.TabIndex = 28
        Me.Label41.Text = "Mana:"
        '
        'chkMagicShield
        '
        Me.chkMagicShield.AutoSize = True
        Me.chkMagicShield.Location = New System.Drawing.Point(6, 20)
        Me.chkMagicShield.Name = "chkMagicShield"
        Me.chkMagicShield.Size = New System.Drawing.Size(15, 14)
        Me.chkMagicShield.TabIndex = 22
        Me.chkMagicShield.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(145, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 14)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "s."
        '
        'tabMore
        '
        Me.tabMore.BackColor = System.Drawing.Color.Transparent
        Me.tabMore.Controls.Add(Me.grpHealFriends)
        Me.tabMore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabMore.Location = New System.Drawing.Point(4, 23)
        Me.tabMore.Name = "tabMore"
        Me.tabMore.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMore.Size = New System.Drawing.Size(427, 222)
        Me.tabMore.TabIndex = 4
        Me.tabMore.Text = "More"
        '
        'grpHealFriends
        '
        Me.grpHealFriends.Controls.Add(Me.Label20)
        Me.grpHealFriends.Controls.Add(Me.numericRecastExuraSIO)
        Me.grpHealFriends.Controls.Add(Me.Label34)
        Me.grpHealFriends.Controls.Add(Me.cmbValHPForFriend)
        Me.grpHealFriends.Controls.Add(Me.Label22)
        Me.grpHealFriends.Controls.Add(Me.cmbValManaForFriend)
        Me.grpHealFriends.Controls.Add(Me.Label26)
        Me.grpHealFriends.Controls.Add(Me.cmbValHPFriend)
        Me.grpHealFriends.Controls.Add(Me.Label25)
        Me.grpHealFriends.Controls.Add(Me.chkExuraSio)
        Me.grpHealFriends.Controls.Add(Me.chkFullLight)
        Me.grpHealFriends.Location = New System.Drawing.Point(17, 7)
        Me.grpHealFriends.Name = "grpHealFriends"
        Me.grpHealFriends.Size = New System.Drawing.Size(394, 208)
        Me.grpHealFriends.TabIndex = 9
        Me.grpHealFriends.TabStop = False
        Me.grpHealFriends.Text = "More options"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(310, 169)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 14)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "ms"
        '
        'numericRecastExuraSIO
        '
        Me.numericRecastExuraSIO.Location = New System.Drawing.Point(255, 167)
        Me.numericRecastExuraSIO.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numericRecastExuraSIO.Name = "numericRecastExuraSIO"
        Me.numericRecastExuraSIO.Size = New System.Drawing.Size(49, 20)
        Me.numericRecastExuraSIO.TabIndex = 38
        Me.numericRecastExuraSIO.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(211, 168)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(44, 14)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Recast:"
        '
        'cmbValHPForFriend
        '
        Me.cmbValHPForFriend.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValHPForFriend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValHPForFriend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValHPForFriend.ForeColor = System.Drawing.Color.Black
        Me.cmbValHPForFriend.FormattingEnabled = True
        Me.cmbValHPForFriend.Location = New System.Drawing.Point(255, 119)
        Me.cmbValHPForFriend.Name = "cmbValHPForFriend"
        Me.cmbValHPForFriend.Size = New System.Drawing.Size(46, 22)
        Me.cmbValHPForFriend.TabIndex = 36
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(40, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 14)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "only if my %hp is above this amount:"
        '
        'cmbValManaForFriend
        '
        Me.cmbValManaForFriend.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValManaForFriend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValManaForFriend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValManaForFriend.ForeColor = System.Drawing.Color.Black
        Me.cmbValManaForFriend.FormattingEnabled = True
        Me.cmbValManaForFriend.Location = New System.Drawing.Point(255, 92)
        Me.cmbValManaForFriend.Name = "cmbValManaForFriend"
        Me.cmbValManaForFriend.Size = New System.Drawing.Size(46, 22)
        Me.cmbValManaForFriend.TabIndex = 34
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(40, 95)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(197, 14)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "only if my %mana is above this amount:"
        '
        'cmbValHPFriend
        '
        Me.cmbValHPFriend.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbValHPFriend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValHPFriend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbValHPFriend.ForeColor = System.Drawing.Color.Black
        Me.cmbValHPFriend.FormattingEnabled = True
        Me.cmbValHPFriend.Location = New System.Drawing.Point(255, 65)
        Me.cmbValHPFriend.Name = "cmbValHPFriend"
        Me.cmbValHPFriend.Size = New System.Drawing.Size(46, 22)
        Me.cmbValHPFriend.TabIndex = 32
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(40, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(219, 14)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "only if friend %health is below this percent: "
        '
        'chkExuraSio
        '
        Me.chkExuraSio.AutoSize = True
        Me.chkExuraSio.Location = New System.Drawing.Point(9, 41)
        Me.chkExuraSio.Name = "chkExuraSio"
        Me.chkExuraSio.Size = New System.Drawing.Size(318, 18)
        Me.chkExuraSio.TabIndex = 30
        Me.chkExuraSio.Text = "Exura Sio friends (you should define them at global settings!)"
        Me.chkExuraSio.UseVisualStyleBackColor = True
        '
        'chkFullLight
        '
        Me.chkFullLight.AutoSize = True
        Me.chkFullLight.Location = New System.Drawing.Point(9, 19)
        Me.chkFullLight.Name = "chkFullLight"
        Me.chkFullLight.Size = New System.Drawing.Size(64, 18)
        Me.chkFullLight.TabIndex = 1
        Me.chkFullLight.Text = "Full light"
        Me.chkFullLight.UseVisualStyleBackColor = True
        '
        'cmdSaveAs
        '
        Me.cmdSaveAs.BackColor = System.Drawing.Color.DimGray
        Me.cmdSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdSaveAs.FlatAppearance.BorderSize = 2
        Me.cmdSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveAs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveAs.ForeColor = System.Drawing.Color.White
        Me.cmdSaveAs.Location = New System.Drawing.Point(16, 291)
        Me.cmdSaveAs.Name = "cmdSaveAs"
        Me.cmdSaveAs.Size = New System.Drawing.Size(52, 28)
        Me.cmdSaveAs.TabIndex = 18
        Me.cmdSaveAs.Text = "Save"
        Me.cmdSaveAs.UseVisualStyleBackColor = False
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
        Me.cmdClose.Location = New System.Drawing.Point(355, 291)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 28)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'SpellMenu
        '
        Me.SpellMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunesToolStripMenuItem, Me.AmmunitionToolStripMenuItem, Me.SupplySpellsToolStripMenuItem})
        Me.SpellMenu.Name = "SpellMenu"
        Me.SpellMenu.Size = New System.Drawing.Size(144, 70)
        '
        'RunesToolStripMenuItem
        '
        Me.RunesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttackToolStripMenuItem, Me.FieldToolStripMenuItem, Me.HealingToolStripMenuItem, Me.SummonToolStripMenuItem, Me.SupportToolStripMenuItem})
        Me.RunesToolStripMenuItem.Name = "RunesToolStripMenuItem"
        Me.RunesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RunesToolStripMenuItem.Text = "Runes"
        '
        'AttackToolStripMenuItem
        '
        Me.AttackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidToolStripMenuItem, Me.SorcererToolStripMenuItem, Me.PaladinToolStripMenuItem})
        Me.AttackToolStripMenuItem.Name = "AttackToolStripMenuItem"
        Me.AttackToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AttackToolStripMenuItem.Text = "Attack"
        '
        'DruidToolStripMenuItem
        '
        Me.DruidToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvalancheToolStripMenuItem, Me.ExplosionToolStripMenuItem, Me.HeavyMagicMissileToolStripMenuItem, Me.IcicleToolStripMenuItem, Me.LightMagicMissileToolStripMenuItem, Me.SoulfireToolStripMenuItem, Me.StalagmiteToolStripMenuItem, Me.StoneShowerToolStripMenuItem})
        Me.DruidToolStripMenuItem.Name = "DruidToolStripMenuItem"
        Me.DruidToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DruidToolStripMenuItem.Text = "Druid"
        '
        'AvalancheToolStripMenuItem
        '
        Me.AvalancheToolStripMenuItem.Name = "AvalancheToolStripMenuItem"
        Me.AvalancheToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AvalancheToolStripMenuItem.Text = "Avalanche"
        '
        'ExplosionToolStripMenuItem
        '
        Me.ExplosionToolStripMenuItem.Name = "ExplosionToolStripMenuItem"
        Me.ExplosionToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExplosionToolStripMenuItem.Text = "Explosion"
        '
        'HeavyMagicMissileToolStripMenuItem
        '
        Me.HeavyMagicMissileToolStripMenuItem.Name = "HeavyMagicMissileToolStripMenuItem"
        Me.HeavyMagicMissileToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.HeavyMagicMissileToolStripMenuItem.Text = "Heavy Magic Missile"
        '
        'IcicleToolStripMenuItem
        '
        Me.IcicleToolStripMenuItem.Name = "IcicleToolStripMenuItem"
        Me.IcicleToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.IcicleToolStripMenuItem.Text = "Icicle"
        '
        'LightMagicMissileToolStripMenuItem
        '
        Me.LightMagicMissileToolStripMenuItem.Name = "LightMagicMissileToolStripMenuItem"
        Me.LightMagicMissileToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LightMagicMissileToolStripMenuItem.Text = "Light Magic Missile"
        '
        'SoulfireToolStripMenuItem
        '
        Me.SoulfireToolStripMenuItem.Name = "SoulfireToolStripMenuItem"
        Me.SoulfireToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SoulfireToolStripMenuItem.Text = "Soulfire"
        '
        'StalagmiteToolStripMenuItem
        '
        Me.StalagmiteToolStripMenuItem.Name = "StalagmiteToolStripMenuItem"
        Me.StalagmiteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.StalagmiteToolStripMenuItem.Text = "Stalagmite"
        '
        'StoneShowerToolStripMenuItem
        '
        Me.StoneShowerToolStripMenuItem.Name = "StoneShowerToolStripMenuItem"
        Me.StoneShowerToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.StoneShowerToolStripMenuItem.Text = "Stone Shower"
        '
        'SorcererToolStripMenuItem
        '
        Me.SorcererToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplosionToolStripMenuItem1, Me.FireballToolStripMenuItem, Me.GreatFireballToolStripMenuItem, Me.HeavyMagicMissileToolStripMenuItem1, Me.LightMagicMissileToolStripMenuItem1, Me.SoulfireToolStripMenuItem1, Me.StalagmiteToolStripMenuItem1, Me.SuddenDeathToolStripMenuItem, Me.ThunderstormToolStripMenuItem})
        Me.SorcererToolStripMenuItem.Name = "SorcererToolStripMenuItem"
        Me.SorcererToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SorcererToolStripMenuItem.Text = "Sorcerer"
        '
        'ExplosionToolStripMenuItem1
        '
        Me.ExplosionToolStripMenuItem1.Name = "ExplosionToolStripMenuItem1"
        Me.ExplosionToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ExplosionToolStripMenuItem1.Text = "Explosion"
        '
        'FireballToolStripMenuItem
        '
        Me.FireballToolStripMenuItem.Name = "FireballToolStripMenuItem"
        Me.FireballToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FireballToolStripMenuItem.Text = "Fireball"
        '
        'GreatFireballToolStripMenuItem
        '
        Me.GreatFireballToolStripMenuItem.Name = "GreatFireballToolStripMenuItem"
        Me.GreatFireballToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.GreatFireballToolStripMenuItem.Text = "Great Fireball"
        '
        'HeavyMagicMissileToolStripMenuItem1
        '
        Me.HeavyMagicMissileToolStripMenuItem1.Name = "HeavyMagicMissileToolStripMenuItem1"
        Me.HeavyMagicMissileToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.HeavyMagicMissileToolStripMenuItem1.Text = "Heavy Magic Missile"
        '
        'LightMagicMissileToolStripMenuItem1
        '
        Me.LightMagicMissileToolStripMenuItem1.Name = "LightMagicMissileToolStripMenuItem1"
        Me.LightMagicMissileToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.LightMagicMissileToolStripMenuItem1.Text = "Light Magic Missile"
        '
        'SoulfireToolStripMenuItem1
        '
        Me.SoulfireToolStripMenuItem1.Name = "SoulfireToolStripMenuItem1"
        Me.SoulfireToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.SoulfireToolStripMenuItem1.Text = "Soulfire"
        '
        'StalagmiteToolStripMenuItem1
        '
        Me.StalagmiteToolStripMenuItem1.Name = "StalagmiteToolStripMenuItem1"
        Me.StalagmiteToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.StalagmiteToolStripMenuItem1.Text = "Stalagmite"
        '
        'SuddenDeathToolStripMenuItem
        '
        Me.SuddenDeathToolStripMenuItem.Name = "SuddenDeathToolStripMenuItem"
        Me.SuddenDeathToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SuddenDeathToolStripMenuItem.Text = "Sudden Death"
        '
        'ThunderstormToolStripMenuItem
        '
        Me.ThunderstormToolStripMenuItem.Name = "ThunderstormToolStripMenuItem"
        Me.ThunderstormToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ThunderstormToolStripMenuItem.Text = "Thunderstorm"
        '
        'PaladinToolStripMenuItem
        '
        Me.PaladinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolyMissileToolStripMenuItem})
        Me.PaladinToolStripMenuItem.Name = "PaladinToolStripMenuItem"
        Me.PaladinToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.PaladinToolStripMenuItem.Text = "Paladin"
        '
        'HolyMissileToolStripMenuItem
        '
        Me.HolyMissileToolStripMenuItem.Name = "HolyMissileToolStripMenuItem"
        Me.HolyMissileToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.HolyMissileToolStripMenuItem.Text = "Holy Missile"
        '
        'FieldToolStripMenuItem
        '
        Me.FieldToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidToolStripMenuItem1, Me.SorcererToolStripMenuItem1})
        Me.FieldToolStripMenuItem.Name = "FieldToolStripMenuItem"
        Me.FieldToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FieldToolStripMenuItem.Text = "Field"
        '
        'DruidToolStripMenuItem1
        '
        Me.DruidToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnergyFieldToolStripMenuItem, Me.EnergyWallToolStripMenuItem, Me.FireBombToolStripMenuItem, Me.FireFieldToolStripMenuItem, Me.FireWallToolStripMenuItem, Me.PoisonBombToolStripMenuItem, Me.PoisonFieldToolStripMenuItem, Me.PoisonWallToolStripMenuItem})
        Me.DruidToolStripMenuItem1.Name = "DruidToolStripMenuItem1"
        Me.DruidToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.DruidToolStripMenuItem1.Text = "Druid"
        '
        'EnergyFieldToolStripMenuItem
        '
        Me.EnergyFieldToolStripMenuItem.Name = "EnergyFieldToolStripMenuItem"
        Me.EnergyFieldToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EnergyFieldToolStripMenuItem.Text = "Energy Field"
        '
        'EnergyWallToolStripMenuItem
        '
        Me.EnergyWallToolStripMenuItem.Name = "EnergyWallToolStripMenuItem"
        Me.EnergyWallToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EnergyWallToolStripMenuItem.Text = "Energy Wall"
        '
        'FireBombToolStripMenuItem
        '
        Me.FireBombToolStripMenuItem.Name = "FireBombToolStripMenuItem"
        Me.FireBombToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FireBombToolStripMenuItem.Text = "Fire Bomb"
        '
        'FireFieldToolStripMenuItem
        '
        Me.FireFieldToolStripMenuItem.Name = "FireFieldToolStripMenuItem"
        Me.FireFieldToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FireFieldToolStripMenuItem.Text = "Fire Field"
        '
        'FireWallToolStripMenuItem
        '
        Me.FireWallToolStripMenuItem.Name = "FireWallToolStripMenuItem"
        Me.FireWallToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FireWallToolStripMenuItem.Text = "Fire Wall"
        '
        'PoisonBombToolStripMenuItem
        '
        Me.PoisonBombToolStripMenuItem.Name = "PoisonBombToolStripMenuItem"
        Me.PoisonBombToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PoisonBombToolStripMenuItem.Text = "Poison Bomb"
        '
        'PoisonFieldToolStripMenuItem
        '
        Me.PoisonFieldToolStripMenuItem.Name = "PoisonFieldToolStripMenuItem"
        Me.PoisonFieldToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PoisonFieldToolStripMenuItem.Text = "Poison Field"
        '
        'PoisonWallToolStripMenuItem
        '
        Me.PoisonWallToolStripMenuItem.Name = "PoisonWallToolStripMenuItem"
        Me.PoisonWallToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PoisonWallToolStripMenuItem.Text = "Poison Wall"
        '
        'SorcererToolStripMenuItem1
        '
        Me.SorcererToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnergyBombToolStripMenuItem, Me.EnergyFieldToolStripMenuItem1, Me.EnergyWallToolStripMenuItem1, Me.FireBombToolStripMenuItem1, Me.FireFieldToolStripMenuItem1, Me.FireWallToolStripMenuItem1, Me.PoisonFieldToolStripMenuItem1, Me.PoisonWallToolStripMenuItem1})
        Me.SorcererToolStripMenuItem1.Name = "SorcererToolStripMenuItem1"
        Me.SorcererToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.SorcererToolStripMenuItem1.Text = "Sorcerer"
        '
        'EnergyBombToolStripMenuItem
        '
        Me.EnergyBombToolStripMenuItem.Name = "EnergyBombToolStripMenuItem"
        Me.EnergyBombToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EnergyBombToolStripMenuItem.Text = "Energy Bomb"
        '
        'EnergyFieldToolStripMenuItem1
        '
        Me.EnergyFieldToolStripMenuItem1.Name = "EnergyFieldToolStripMenuItem1"
        Me.EnergyFieldToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.EnergyFieldToolStripMenuItem1.Text = "Energy Field"
        '
        'EnergyWallToolStripMenuItem1
        '
        Me.EnergyWallToolStripMenuItem1.Name = "EnergyWallToolStripMenuItem1"
        Me.EnergyWallToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.EnergyWallToolStripMenuItem1.Text = "Energy Wall"
        '
        'FireBombToolStripMenuItem1
        '
        Me.FireBombToolStripMenuItem1.Name = "FireBombToolStripMenuItem1"
        Me.FireBombToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FireBombToolStripMenuItem1.Text = "Fire Bomb"
        '
        'FireFieldToolStripMenuItem1
        '
        Me.FireFieldToolStripMenuItem1.Name = "FireFieldToolStripMenuItem1"
        Me.FireFieldToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FireFieldToolStripMenuItem1.Text = "Fire Field"
        '
        'FireWallToolStripMenuItem1
        '
        Me.FireWallToolStripMenuItem1.Name = "FireWallToolStripMenuItem1"
        Me.FireWallToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FireWallToolStripMenuItem1.Text = "Fire Wall"
        '
        'PoisonFieldToolStripMenuItem1
        '
        Me.PoisonFieldToolStripMenuItem1.Name = "PoisonFieldToolStripMenuItem1"
        Me.PoisonFieldToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.PoisonFieldToolStripMenuItem1.Text = "Poison Field"
        '
        'PoisonWallToolStripMenuItem1
        '
        Me.PoisonWallToolStripMenuItem1.Name = "PoisonWallToolStripMenuItem1"
        Me.PoisonWallToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.PoisonWallToolStripMenuItem1.Text = "Poison Wall"
        '
        'HealingToolStripMenuItem
        '
        Me.HealingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidsToolStripMenuItem})
        Me.HealingToolStripMenuItem.Name = "HealingToolStripMenuItem"
        Me.HealingToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.HealingToolStripMenuItem.Text = "Healing"
        '
        'DruidsToolStripMenuItem
        '
        Me.DruidsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurePoisonRuneToolStripMenuItem, Me.IntenseHealingRuneToolStripMenuItem, Me.UltimateHealingRuneToolStripMenuItem})
        Me.DruidsToolStripMenuItem.Name = "DruidsToolStripMenuItem"
        Me.DruidsToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.DruidsToolStripMenuItem.Text = "Druid"
        '
        'CurePoisonRuneToolStripMenuItem
        '
        Me.CurePoisonRuneToolStripMenuItem.Name = "CurePoisonRuneToolStripMenuItem"
        Me.CurePoisonRuneToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CurePoisonRuneToolStripMenuItem.Text = "Cure Poison Rune"
        '
        'IntenseHealingRuneToolStripMenuItem
        '
        Me.IntenseHealingRuneToolStripMenuItem.Name = "IntenseHealingRuneToolStripMenuItem"
        Me.IntenseHealingRuneToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.IntenseHealingRuneToolStripMenuItem.Text = "Intense Healing Rune"
        '
        'UltimateHealingRuneToolStripMenuItem
        '
        Me.UltimateHealingRuneToolStripMenuItem.Name = "UltimateHealingRuneToolStripMenuItem"
        Me.UltimateHealingRuneToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.UltimateHealingRuneToolStripMenuItem.Text = "Ultimate Healing Rune"
        '
        'SummonToolStripMenuItem
        '
        Me.SummonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidsToolStripMenuItem1, Me.SorcererToolStripMenuItem2})
        Me.SummonToolStripMenuItem.Name = "SummonToolStripMenuItem"
        Me.SummonToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SummonToolStripMenuItem.Text = "Summon"
        '
        'DruidsToolStripMenuItem1
        '
        Me.DruidsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimateDeadToolStripMenuItem, Me.ConvinceCreatureToolStripMenuItem})
        Me.DruidsToolStripMenuItem1.Name = "DruidsToolStripMenuItem1"
        Me.DruidsToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.DruidsToolStripMenuItem1.Text = "Druid"
        '
        'AnimateDeadToolStripMenuItem
        '
        Me.AnimateDeadToolStripMenuItem.Name = "AnimateDeadToolStripMenuItem"
        Me.AnimateDeadToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AnimateDeadToolStripMenuItem.Text = "Animate Dead"
        '
        'ConvinceCreatureToolStripMenuItem
        '
        Me.ConvinceCreatureToolStripMenuItem.Name = "ConvinceCreatureToolStripMenuItem"
        Me.ConvinceCreatureToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConvinceCreatureToolStripMenuItem.Text = "Convince Creature"
        '
        'SorcererToolStripMenuItem2
        '
        Me.SorcererToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimateDeadToolStripMenuItem1})
        Me.SorcererToolStripMenuItem2.Name = "SorcererToolStripMenuItem2"
        Me.SorcererToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.SorcererToolStripMenuItem2.Text = "Sorcerer"
        '
        'AnimateDeadToolStripMenuItem1
        '
        Me.AnimateDeadToolStripMenuItem1.Name = "AnimateDeadToolStripMenuItem1"
        Me.AnimateDeadToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.AnimateDeadToolStripMenuItem1.Text = "Animate Dead"
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidToolStripMenuItem2, Me.SorcererToolStripMenuItem3, Me.PaladinToolStripMenuItem1})
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'DruidToolStripMenuItem2
        '
        Me.DruidToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChameleonToolStripMenuItem, Me.DesintergrateToolStripMenuItem, Me.DestroyFieldToolStripMenuItem, Me.ParalyzeToolStripMenuItem, Me.WildGrowthToolStripMenuItem})
        Me.DruidToolStripMenuItem2.Name = "DruidToolStripMenuItem2"
        Me.DruidToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.DruidToolStripMenuItem2.Text = "Druid"
        '
        'ChameleonToolStripMenuItem
        '
        Me.ChameleonToolStripMenuItem.Name = "ChameleonToolStripMenuItem"
        Me.ChameleonToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ChameleonToolStripMenuItem.Text = "Chameleon"
        '
        'DesintergrateToolStripMenuItem
        '
        Me.DesintergrateToolStripMenuItem.Name = "DesintergrateToolStripMenuItem"
        Me.DesintergrateToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DesintergrateToolStripMenuItem.Text = "Desintergrate"
        '
        'DestroyFieldToolStripMenuItem
        '
        Me.DestroyFieldToolStripMenuItem.Name = "DestroyFieldToolStripMenuItem"
        Me.DestroyFieldToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DestroyFieldToolStripMenuItem.Text = "Destroy Field"
        '
        'ParalyzeToolStripMenuItem
        '
        Me.ParalyzeToolStripMenuItem.Name = "ParalyzeToolStripMenuItem"
        Me.ParalyzeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ParalyzeToolStripMenuItem.Text = "Paralyze"
        '
        'WildGrowthToolStripMenuItem
        '
        Me.WildGrowthToolStripMenuItem.Name = "WildGrowthToolStripMenuItem"
        Me.WildGrowthToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.WildGrowthToolStripMenuItem.Text = "Wild Growth"
        '
        'SorcererToolStripMenuItem3
        '
        Me.SorcererToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesintergrateToolStripMenuItem1, Me.DestroyFieldToolStripMenuItem1, Me.MagicWallToolStripMenuItem})
        Me.SorcererToolStripMenuItem3.Name = "SorcererToolStripMenuItem3"
        Me.SorcererToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.SorcererToolStripMenuItem3.Text = "Sorcerer"
        '
        'DesintergrateToolStripMenuItem1
        '
        Me.DesintergrateToolStripMenuItem1.Name = "DesintergrateToolStripMenuItem1"
        Me.DesintergrateToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.DesintergrateToolStripMenuItem1.Text = "Desintergrate"
        '
        'DestroyFieldToolStripMenuItem1
        '
        Me.DestroyFieldToolStripMenuItem1.Name = "DestroyFieldToolStripMenuItem1"
        Me.DestroyFieldToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.DestroyFieldToolStripMenuItem1.Text = "Destroy Field"
        '
        'MagicWallToolStripMenuItem
        '
        Me.MagicWallToolStripMenuItem.Name = "MagicWallToolStripMenuItem"
        Me.MagicWallToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MagicWallToolStripMenuItem.Text = "Magic Wall"
        '
        'PaladinToolStripMenuItem1
        '
        Me.PaladinToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesintergrateToolStripMenuItem2, Me.DestroyFieldToolStripMenuItem2})
        Me.PaladinToolStripMenuItem1.Name = "PaladinToolStripMenuItem1"
        Me.PaladinToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.PaladinToolStripMenuItem1.Text = "Paladin"
        '
        'DesintergrateToolStripMenuItem2
        '
        Me.DesintergrateToolStripMenuItem2.Name = "DesintergrateToolStripMenuItem2"
        Me.DesintergrateToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.DesintergrateToolStripMenuItem2.Text = "Desintergrate"
        '
        'DestroyFieldToolStripMenuItem2
        '
        Me.DestroyFieldToolStripMenuItem2.Name = "DestroyFieldToolStripMenuItem2"
        Me.DestroyFieldToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.DestroyFieldToolStripMenuItem2.Text = "Destroy Field"
        '
        'AmmunitionToolStripMenuItem
        '
        Me.AmmunitionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConjureArrowToolStripMenuItem, Me.ConjureBoltToolStripMenuItem, Me.ConjureExplosiveArrowToolStripMenuItem, Me.ConjurePiercingBoltToolStripMenuItem, Me.ConjurePoisonedArrowToolStripMenuItem, Me.ConjurePowerBoltToolStripMenuItem, Me.ConjureSniperArrowToolStripMenuItem, Me.EnchantSpearToolStripMenuItem})
        Me.AmmunitionToolStripMenuItem.Name = "AmmunitionToolStripMenuItem"
        Me.AmmunitionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AmmunitionToolStripMenuItem.Text = "Ammunition"
        '
        'ConjureArrowToolStripMenuItem
        '
        Me.ConjureArrowToolStripMenuItem.Name = "ConjureArrowToolStripMenuItem"
        Me.ConjureArrowToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjureArrowToolStripMenuItem.Text = "Conjure Arrow"
        '
        'ConjureBoltToolStripMenuItem
        '
        Me.ConjureBoltToolStripMenuItem.Name = "ConjureBoltToolStripMenuItem"
        Me.ConjureBoltToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjureBoltToolStripMenuItem.Text = "Conjure Bolt"
        '
        'ConjureExplosiveArrowToolStripMenuItem
        '
        Me.ConjureExplosiveArrowToolStripMenuItem.Name = "ConjureExplosiveArrowToolStripMenuItem"
        Me.ConjureExplosiveArrowToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjureExplosiveArrowToolStripMenuItem.Text = "Conjure Explosive Arrow"
        '
        'ConjurePiercingBoltToolStripMenuItem
        '
        Me.ConjurePiercingBoltToolStripMenuItem.Name = "ConjurePiercingBoltToolStripMenuItem"
        Me.ConjurePiercingBoltToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjurePiercingBoltToolStripMenuItem.Text = "Conjure Piercing Bolt"
        '
        'ConjurePoisonedArrowToolStripMenuItem
        '
        Me.ConjurePoisonedArrowToolStripMenuItem.Name = "ConjurePoisonedArrowToolStripMenuItem"
        Me.ConjurePoisonedArrowToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjurePoisonedArrowToolStripMenuItem.Text = "Conjure Poisoned Arrow"
        '
        'ConjurePowerBoltToolStripMenuItem
        '
        Me.ConjurePowerBoltToolStripMenuItem.Name = "ConjurePowerBoltToolStripMenuItem"
        Me.ConjurePowerBoltToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjurePowerBoltToolStripMenuItem.Text = "Conjure Power Bolt"
        '
        'ConjureSniperArrowToolStripMenuItem
        '
        Me.ConjureSniperArrowToolStripMenuItem.Name = "ConjureSniperArrowToolStripMenuItem"
        Me.ConjureSniperArrowToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConjureSniperArrowToolStripMenuItem.Text = "Conjure Sniper Arrow"
        '
        'EnchantSpearToolStripMenuItem
        '
        Me.EnchantSpearToolStripMenuItem.Name = "EnchantSpearToolStripMenuItem"
        Me.EnchantSpearToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EnchantSpearToolStripMenuItem.Text = "Enchant Spear"
        '
        'SupplySpellsToolStripMenuItem
        '
        Me.SupplySpellsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DruidToolStripMenuItem3, Me.SorcererToolStripMenuItem4})
        Me.SupplySpellsToolStripMenuItem.Name = "SupplySpellsToolStripMenuItem"
        Me.SupplySpellsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SupplySpellsToolStripMenuItem.Text = "Supply Spells"
        '
        'DruidToolStripMenuItem3
        '
        Me.DruidToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FoodToolStripMenuItem})
        Me.DruidToolStripMenuItem3.Name = "DruidToolStripMenuItem3"
        Me.DruidToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.DruidToolStripMenuItem3.Text = "Druid"
        '
        'FoodToolStripMenuItem
        '
        Me.FoodToolStripMenuItem.Name = "FoodToolStripMenuItem"
        Me.FoodToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.FoodToolStripMenuItem.Text = "Food"
        '
        'SorcererToolStripMenuItem4
        '
        Me.SorcererToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnchantStaffToolStripMenuItem})
        Me.SorcererToolStripMenuItem4.Name = "SorcererToolStripMenuItem4"
        Me.SorcererToolStripMenuItem4.Size = New System.Drawing.Size(117, 22)
        Me.SorcererToolStripMenuItem4.Text = "Sorcerer"
        '
        'EnchantStaffToolStripMenuItem
        '
        Me.EnchantStaffToolStripMenuItem.Name = "EnchantStaffToolStripMenuItem"
        Me.EnchantStaffToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EnchantStaffToolStripMenuItem.Text = "Enchant Staff"
        '
        'lblAuxIcon
        '
        Me.lblAuxIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAuxIcon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuxIcon.ForeColor = System.Drawing.Color.White
        Me.lblAuxIcon.Location = New System.Drawing.Point(0, 0)
        Me.lblAuxIcon.Name = "lblAuxIcon"
        Me.lblAuxIcon.Size = New System.Drawing.Size(29, 23)
        Me.lblAuxIcon.TabIndex = 17
        Me.lblAuxIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 23)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Setup - Loading..."
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLeftDeco
        '
        Me.lblLeftDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLeftDeco.CausesValidation = False
        Me.lblLeftDeco.Location = New System.Drawing.Point(0, 0)
        Me.lblLeftDeco.Name = "lblLeftDeco"
        Me.lblLeftDeco.Size = New System.Drawing.Size(3, 331)
        Me.lblLeftDeco.TabIndex = 21
        '
        'lblRightDeco
        '
        Me.lblRightDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRightDeco.CausesValidation = False
        Me.lblRightDeco.Location = New System.Drawing.Point(456, 0)
        Me.lblRightDeco.Name = "lblRightDeco"
        Me.lblRightDeco.Size = New System.Drawing.Size(3, 331)
        Me.lblRightDeco.TabIndex = 22
        '
        'lblBottomDeco
        '
        Me.lblBottomDeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBottomDeco.CausesValidation = False
        Me.lblBottomDeco.Location = New System.Drawing.Point(0, 328)
        Me.lblBottomDeco.Name = "lblBottomDeco"
        Me.lblBottomDeco.Size = New System.Drawing.Size(459, 3)
        Me.lblBottomDeco.TabIndex = 23
        '
        'cmdLoadFrom
        '
        Me.cmdLoadFrom.BackColor = System.Drawing.Color.DimGray
        Me.cmdLoadFrom.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.cmdLoadFrom.FlatAppearance.BorderSize = 2
        Me.cmdLoadFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdLoadFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.cmdLoadFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoadFrom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadFrom.ForeColor = System.Drawing.Color.White
        Me.cmdLoadFrom.Location = New System.Drawing.Point(74, 291)
        Me.cmdLoadFrom.Name = "cmdLoadFrom"
        Me.cmdLoadFrom.Size = New System.Drawing.Size(54, 28)
        Me.cmdLoadFrom.TabIndex = 24
        Me.cmdLoadFrom.Text = "Load"
        Me.cmdLoadFrom.UseVisualStyleBackColor = False
        '
        'lblLoading
        '
        Me.lblLoading.Location = New System.Drawing.Point(10, 26)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(58, 18)
        Me.lblLoading.TabIndex = 25
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoading.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(438, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 19)
        Me.btnClose.TabIndex = 26
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(137, 291)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(212, 31)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Important note: Configs are automatically loaded/saved as <charname>.cfg"
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.picIcon.Image = Global.Cheatlyzer.My.Resources.Resources.miniIcon
        Me.picIcon.Location = New System.Drawing.Point(3, 3)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(16, 16)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 16
        Me.picIcon.TabStop = False
        '
        'cmbKeyCure0
        '
        Me.cmbKeyCure0.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyCure0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyCure0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyCure0.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyCure0.FormattingEnabled = True
        Me.cmbKeyCure0.Location = New System.Drawing.Point(27, 16)
        Me.cmbKeyCure0.Name = "cmbKeyCure0"
        Me.cmbKeyCure0.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyCure0.TabIndex = 48
        '
        'cmbKeyCure1
        '
        Me.cmbKeyCure1.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyCure1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyCure1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyCure1.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyCure1.FormattingEnabled = True
        Me.cmbKeyCure1.Location = New System.Drawing.Point(27, 39)
        Me.cmbKeyCure1.Name = "cmbKeyCure1"
        Me.cmbKeyCure1.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyCure1.TabIndex = 49
        '
        'cmbKeyCure2
        '
        Me.cmbKeyCure2.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbKeyCure2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyCure2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbKeyCure2.ForeColor = System.Drawing.Color.Black
        Me.cmbKeyCure2.FormattingEnabled = True
        Me.cmbKeyCure2.Location = New System.Drawing.Point(27, 62)
        Me.cmbKeyCure2.Name = "cmbKeyCure2"
        Me.cmbKeyCure2.Size = New System.Drawing.Size(68, 22)
        Me.cmbKeyCure2.TabIndex = 50
        '
        'frmCharSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 331)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.cmdLoadFrom)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSaveAs)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAuxIcon)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.lblLeftDeco)
        Me.Controls.Add(Me.lblBottomDeco)
        Me.Controls.Add(Me.lblRightDeco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCharSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Setup"
        Me.Tabs.ResumeLayout(False)
        Me.tabHealing.ResumeLayout(False)
        Me.grpHPMana.ResumeLayout(False)
        Me.grpHPMana.PerformLayout()
        CType(Me.numericRecastMana2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRecastMana1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRecastMana0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRecastHP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRecastHP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRecastHP0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAutoEat.ResumeLayout(False)
        Me.grpAntiAFK.ResumeLayout(False)
        Me.grpAntiAFK.PerformLayout()
        CType(Me.numericAntiAFKMaximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAntiAFKMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupManaTrain.ResumeLayout(False)
        Me.groupManaTrain.PerformLayout()
        CType(Me.numericRecastManaTrain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupEat.ResumeLayout(False)
        Me.groupEat.PerformLayout()
        CType(Me.numericAutoEatMaximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAutoEatMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRunemaker.ResumeLayout(False)
        Me.grpRunemaker.ResumeLayout(False)
        Me.grpRunemaker.PerformLayout()
        CType(Me.numericRunemakerMaxDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRunemakerSoulCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericRunemakerManaCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAutoSpells.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numericAutoSpellSecondsInvisibility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAutoSpellManaInvisibility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numericAutoSpellManaCure2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAutoSpellManaCure1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAutoSpellManaCure0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numericAutoSpellSecondsMagicShield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAutoSpellManaMagicShield, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMore.ResumeLayout(False)
        Me.grpHealFriends.ResumeLayout(False)
        Me.grpHealFriends.PerformLayout()
        CType(Me.numericRecastExuraSIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpellMenu.ResumeLayout(False)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents tabHealing As System.Windows.Forms.TabPage
    Friend WithEvents grpHPMana As System.Windows.Forms.GroupBox
    Friend WithEvents checkHealerEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbValHP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbValHP1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbValHP0 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValMana2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyHP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKeyMana2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyHP1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyMana0 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyHP0 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValMana1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbKeyMana1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbValMana0 As System.Windows.Forms.ComboBox
    Friend WithEvents tabAutoEat As System.Windows.Forms.TabPage
    Friend WithEvents grpAntiAFK As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents numericAntiAFKMaximum As System.Windows.Forms.NumericUpDown
    Friend WithEvents numericAntiAFKMinimum As System.Windows.Forms.NumericUpDown
    Friend WithEvents checkAntiAFKEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents groupManaTrain As System.Windows.Forms.GroupBox
    Friend WithEvents checkManaTrainEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents cmbKeyManaTrain As System.Windows.Forms.ComboBox
    Friend WithEvents groupEat As System.Windows.Forms.GroupBox
    Friend WithEvents checkAutoEatEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents numericAutoEatMaximum As System.Windows.Forms.NumericUpDown
    Friend WithEvents numericAutoEatMinimum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbKeyFood As System.Windows.Forms.ComboBox
    Friend WithEvents tabRunemaker As System.Windows.Forms.TabPage
    Friend WithEvents grpRunemaker As System.Windows.Forms.GroupBox
    Friend WithEvents textRunemakerSpell As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadSpell As System.Windows.Forms.Button
    Friend WithEvents checkPlayAlarm As System.Windows.Forms.CheckBox
    Friend WithEvents cmbNoSoulOptions As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblSoulCost As System.Windows.Forms.Label
    Friend WithEvents lblManaCost As System.Windows.Forms.Label
    Friend WithEvents numericRunemakerSoulCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents numericRunemakerManaCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents checkRunemakerEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents tabMore As System.Windows.Forms.TabPage
    Friend WithEvents cmdSaveAs As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents SpellMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvalancheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplosionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeavyMagicMissileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightMagicMissileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoulfireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StalagmiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StoneShowerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorcererToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplosionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireballToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreatFireballToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeavyMagicMissileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightMagicMissileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoulfireToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StalagmiteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuddenDeathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThunderstormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaladinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolyMissileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyFieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyWallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireBombToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireFieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireWallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoisonBombToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoisonFieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoisonWallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorcererToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyBombToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyFieldToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyWallToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireBombToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireFieldToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FireWallToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoisonFieldToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoisonWallToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HealingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurePoisonRuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntenseHealingRuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltimateHealingRuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimateDeadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvinceCreatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorcererToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimateDeadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChameleonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesintergrateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestroyFieldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParalyzeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WildGrowthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorcererToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesintergrateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestroyFieldToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagicWallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaladinToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesintergrateToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestroyFieldToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmmunitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjureArrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjureBoltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjureExplosiveArrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjurePiercingBoltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjurePoisonedArrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjurePowerBoltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjureSniperArrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnchantSpearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplySpellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruidToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorcererToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnchantStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAuxIcon As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblLeftDeco As System.Windows.Forms.Label
    Friend WithEvents lblRightDeco As System.Windows.Forms.Label
    Friend WithEvents lblBottomDeco As System.Windows.Forms.Label
    Friend WithEvents cmdLoadFrom As System.Windows.Forms.Button
    Friend WithEvents grpHealFriends As System.Windows.Forms.GroupBox
    Friend WithEvents chkExuraSio As System.Windows.Forms.CheckBox
    Friend WithEvents chkFullLight As System.Windows.Forms.CheckBox
    Friend WithEvents cmbValManaForFriend As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbValHPFriend As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents numericRunemakerMaxDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblChances As System.Windows.Forms.Label
    Friend WithEvents cmbValHPForFriend As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents numericRecastMana2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents numericRecastMana1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents numericRecastMana0 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents numericRecastHP2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents numericRecastHP1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents numericRecastHP0 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents numericRecastManaTrain As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbValManaTrainNearMax As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents numericRecastExuraSIO As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents tabAutoSpells As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvisibilitySpell As System.Windows.Forms.TextBox
    Friend WithEvents numericAutoSpellSecondsInvisibility As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAutoInvisibility As System.Windows.Forms.CheckBox
    Friend WithEvents numericAutoSpellManaInvisibility As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents chkInvisibility As System.Windows.Forms.CheckBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCureHint2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCureHint1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCureHint0 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents numericAutoSpellManaCure2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkCure2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents numericAutoSpellManaCure1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkCure1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents numericAutoSpellManaCure0 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkCure0 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMagicShieldSpell As System.Windows.Forms.TextBox
    Friend WithEvents numericAutoSpellSecondsMagicShield As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAutoMagicShield As System.Windows.Forms.CheckBox
    Friend WithEvents numericAutoSpellManaMagicShield As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents chkMagicShield As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbKeyCure2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyCure1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyCure0 As System.Windows.Forms.ComboBox
End Class

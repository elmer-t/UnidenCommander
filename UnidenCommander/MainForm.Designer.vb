<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtCommand = New System.Windows.Forms.TextBox
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblScannerInfo = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Port = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblPort = New System.Windows.Forms.ToolStripStatusLabel
        Me.BaudRate = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSpeed = New System.Windows.Forms.ToolStripStatusLabel
        Me.ScannerInfo = New System.Windows.Forms.ToolStripStatusLabel
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.scannerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChannelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorderlessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.firstRunTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabScanner = New System.Windows.Forms.TabPage
        Me.btnRotarySelect = New UnidenCommander.Controls.PushButton
        Me.btnStep6_25k = New UnidenCommander.Controls.PushButton
        Me.btn3 = New UnidenCommander.Controls.PushButton
        Me.Display1 = New UnidenCommander.Display
        Me.btnStep50k = New UnidenCommander.Controls.PushButton
        Me.btnMute = New UnidenCommander.Controls.PushButton
        Me.btnStep25k = New UnidenCommander.Controls.PushButton
        Me.btn2 = New UnidenCommander.Controls.PushButton
        Me.btn4 = New UnidenCommander.Controls.PushButton
        Me.btnScan = New UnidenCommander.Controls.PushButton
        Me.btnStep10k = New UnidenCommander.Controls.PushButton
        Me.btnStep12_5k = New UnidenCommander.Controls.PushButton
        Me.btnManual = New UnidenCommander.Controls.PushButton
        Me.btn5 = New UnidenCommander.Controls.PushButton
        Me.btnTransfer = New UnidenCommander.Controls.PushButton
        Me.btn6 = New UnidenCommander.Controls.PushButton
        Me.btnAir = New UnidenCommander.Controls.PushButton
        Me.btnStep100k = New UnidenCommander.Controls.PushButton
        Me.btnPriority = New UnidenCommander.Controls.PushButton
        Me.btnStep5k = New UnidenCommander.Controls.PushButton
        Me.btnATT = New UnidenCommander.Controls.PushButton
        Me.btn1 = New UnidenCommander.Controls.PushButton
        Me.btn7 = New UnidenCommander.Controls.PushButton
        Me.btnSrch = New UnidenCommander.Controls.PushButton
        Me.btnStep7_5k = New UnidenCommander.Controls.PushButton
        Me.btnLockOut = New UnidenCommander.Controls.PushButton
        Me.btn8 = New UnidenCommander.Controls.PushButton
        Me.btnRotaryUp = New UnidenCommander.Controls.PushButton
        Me.btnRvrs = New UnidenCommander.Controls.PushButton
        Me.btnModeAM = New UnidenCommander.Controls.PushButton
        Me.btnModeAuto = New UnidenCommander.Controls.PushButton
        Me.btnMenu = New UnidenCommander.Controls.PushButton
        Me.btnStepAuto = New UnidenCommander.Controls.PushButton
        Me.btnEnter = New UnidenCommander.Controls.PushButton
        Me.btn9 = New UnidenCommander.Controls.PushButton
        Me.btnRotaryDown = New UnidenCommander.Controls.PushButton
        Me.btnLimit = New UnidenCommander.Controls.PushButton
        Me.btnModeFM = New UnidenCommander.Controls.PushButton
        Me.btnModeWFM = New UnidenCommander.Controls.PushButton
        Me.btnHold = New UnidenCommander.Controls.PushButton
        Me.btn0 = New UnidenCommander.Controls.PushButton
        Me.btnPeriod = New UnidenCommander.Controls.PushButton
        Me.btnCommand = New UnidenCommander.Controls.PushButton
        Me.btnRsm = New UnidenCommander.Controls.PushButton
        Me.btnModeNFM = New UnidenCommander.Controls.PushButton
        Me.tabBanks = New System.Windows.Forms.TabPage
        Me.gridBanks = New System.Windows.Forms.DataGridView
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScanBank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SearchBank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnWriteBanks = New UnidenCommander.Controls.PushButton
        Me.btnReadBanks = New UnidenCommander.Controls.PushButton
        Me.tabLog = New System.Windows.Forms.TabPage
        Me.gridReceptionLog = New System.Windows.Forms.DataGridView
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Frequency = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Channel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChannelName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Band = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.statusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabScanner.SuspendLayout()
        Me.tabBanks.SuspendLayout()
        CType(Me.gridBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLog.SuspendLayout()
        CType(Me.gridReceptionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.BackColor = System.Drawing.Color.DarkOrange
        Me.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommand.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(333, 162)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(46, 22)
        Me.txtCommand.TabIndex = 89
        Me.txtCommand.Visible = False
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem, Me.toolStripMenuItem2, Me.settingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Enabled = False
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Enabled = False
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(132, 6)
        '
        'settingsToolStripMenuItem
        '
        Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
        Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.settingsToolStripMenuItem.Text = "Settings..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.aboutToolStripMenuItem.Text = "About..."
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 13)
        Me.lblStatus.Text = "lblStatus"
        Me.lblStatus.ToolTipText = "Show the connection status"
        '
        'lblScannerInfo
        '
        Me.lblScannerInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScannerInfo.Name = "lblScannerInfo"
        Me.lblScannerInfo.Size = New System.Drawing.Size(41, 13)
        Me.lblScannerInfo.Text = "lblInfo"
        Me.lblScannerInfo.ToolTipText = "Scanner type"
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Port, Me.lblPort, Me.BaudRate, Me.lblSpeed, Me.ScannerInfo, Me.lblScannerInfo, Me.Status, Me.lblStatus})
        Me.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.statusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(556, 18)
        Me.statusStrip1.SizingGrip = False
        Me.statusStrip1.TabIndex = 49
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Port
        '
        Me.Port.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(31, 13)
        Me.Port.Text = "Port:"
        '
        'lblPort
        '
        Me.lblPort.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.lblPort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(42, 13)
        Me.lblPort.Text = "lblPort"
        Me.lblPort.ToolTipText = "Connection port"
        '
        'BaudRate
        '
        Me.BaudRate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaudRate.Name = "BaudRate"
        Me.BaudRate.Size = New System.Drawing.Size(60, 13)
        Me.BaudRate.Text = "Baud rate:"
        '
        'lblSpeed
        '
        Me.lblSpeed.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblSpeed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(52, 13)
        Me.lblSpeed.Text = "lblSpeed"
        Me.lblSpeed.ToolTipText = "Connection speed"
        '
        'ScannerInfo
        '
        Me.ScannerInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScannerInfo.Name = "ScannerInfo"
        Me.ScannerInfo.Size = New System.Drawing.Size(51, 13)
        Me.ScannerInfo.Text = "Scanner:"
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(42, 13)
        Me.Status.Text = "Status:"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.menuStrip1.TabIndex = 48
        Me.menuStrip1.Text = "menuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.scannerInfoToolStripMenuItem, Me.ChannelsToolStripMenuItem, Me.ToolStripMenuItem3, Me.NormalToolStripMenuItem, Me.BorderlessToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'scannerInfoToolStripMenuItem
        '
        Me.scannerInfoToolStripMenuItem.Name = "scannerInfoToolStripMenuItem"
        Me.scannerInfoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.scannerInfoToolStripMenuItem.Text = "Scanner info..."
        '
        'ChannelsToolStripMenuItem
        '
        Me.ChannelsToolStripMenuItem.Name = "ChannelsToolStripMenuItem"
        Me.ChannelsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ChannelsToolStripMenuItem.Text = "Channel programming..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(201, 6)
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Checked = True
        Me.NormalToolStripMenuItem.CheckOnClick = True
        Me.NormalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'BorderlessToolStripMenuItem
        '
        Me.BorderlessToolStripMenuItem.CheckOnClick = True
        Me.BorderlessToolStripMenuItem.Name = "BorderlessToolStripMenuItem"
        Me.BorderlessToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.BorderlessToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.BorderlessToolStripMenuItem.Text = "Borderless"
        '
        'firstRunTimer
        '
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = Global.UnidenCommander.My.Resources.Images.logo_small
        Me.pictureBox1.Location = New System.Drawing.Point(452, 159)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(38, 26)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 95
        Me.pictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabScanner)
        Me.TabControl1.Controls.Add(Me.tabBanks)
        Me.TabControl1.Controls.Add(Me.tabLog)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 244)
        Me.TabControl1.TabIndex = 98
        '
        'tabScanner
        '
        Me.tabScanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabScanner.Controls.Add(Me.btnRotarySelect)
        Me.tabScanner.Controls.Add(Me.btnStep6_25k)
        Me.tabScanner.Controls.Add(Me.btn3)
        Me.tabScanner.Controls.Add(Me.Display1)
        Me.tabScanner.Controls.Add(Me.btnStep50k)
        Me.tabScanner.Controls.Add(Me.btnMute)
        Me.tabScanner.Controls.Add(Me.btnStep25k)
        Me.tabScanner.Controls.Add(Me.pictureBox1)
        Me.tabScanner.Controls.Add(Me.btn2)
        Me.tabScanner.Controls.Add(Me.btn4)
        Me.tabScanner.Controls.Add(Me.btnScan)
        Me.tabScanner.Controls.Add(Me.btnStep10k)
        Me.tabScanner.Controls.Add(Me.btnStep12_5k)
        Me.tabScanner.Controls.Add(Me.btnManual)
        Me.tabScanner.Controls.Add(Me.btn5)
        Me.tabScanner.Controls.Add(Me.btnTransfer)
        Me.tabScanner.Controls.Add(Me.btn6)
        Me.tabScanner.Controls.Add(Me.btnAir)
        Me.tabScanner.Controls.Add(Me.btnStep100k)
        Me.tabScanner.Controls.Add(Me.btnPriority)
        Me.tabScanner.Controls.Add(Me.btnStep5k)
        Me.tabScanner.Controls.Add(Me.btnATT)
        Me.tabScanner.Controls.Add(Me.btn1)
        Me.tabScanner.Controls.Add(Me.btn7)
        Me.tabScanner.Controls.Add(Me.btnSrch)
        Me.tabScanner.Controls.Add(Me.btnStep7_5k)
        Me.tabScanner.Controls.Add(Me.btnLockOut)
        Me.tabScanner.Controls.Add(Me.btn8)
        Me.tabScanner.Controls.Add(Me.btnRotaryUp)
        Me.tabScanner.Controls.Add(Me.btnRvrs)
        Me.tabScanner.Controls.Add(Me.btnModeAM)
        Me.tabScanner.Controls.Add(Me.btnModeAuto)
        Me.tabScanner.Controls.Add(Me.btnMenu)
        Me.tabScanner.Controls.Add(Me.btnStepAuto)
        Me.tabScanner.Controls.Add(Me.btnEnter)
        Me.tabScanner.Controls.Add(Me.btn9)
        Me.tabScanner.Controls.Add(Me.btnRotaryDown)
        Me.tabScanner.Controls.Add(Me.btnLimit)
        Me.tabScanner.Controls.Add(Me.btnModeFM)
        Me.tabScanner.Controls.Add(Me.btnModeWFM)
        Me.tabScanner.Controls.Add(Me.btnHold)
        Me.tabScanner.Controls.Add(Me.txtCommand)
        Me.tabScanner.Controls.Add(Me.btn0)
        Me.tabScanner.Controls.Add(Me.btnPeriod)
        Me.tabScanner.Controls.Add(Me.btnCommand)
        Me.tabScanner.Controls.Add(Me.btnRsm)
        Me.tabScanner.Controls.Add(Me.btnModeNFM)
        Me.tabScanner.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabScanner.Location = New System.Drawing.Point(4, 22)
        Me.tabScanner.Name = "tabScanner"
        Me.tabScanner.Padding = New System.Windows.Forms.Padding(3)
        Me.tabScanner.Size = New System.Drawing.Size(548, 218)
        Me.tabScanner.TabIndex = 0
        Me.tabScanner.Text = "Display"
        '
        'btnRotarySelect
        '
        Me.btnRotarySelect.BackgroundImage = CType(resources.GetObject("btnRotarySelect.BackgroundImage"), System.Drawing.Image)
        Me.btnRotarySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotarySelect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotarySelect.ForeColor = System.Drawing.Color.Black
        Me.btnRotarySelect.Location = New System.Drawing.Point(129, 187)
        Me.btnRotarySelect.Name = "btnRotarySelect"
        Me.btnRotarySelect.Size = New System.Drawing.Size(142, 23)
        Me.btnRotarySelect.TabIndex = 74
        Me.btnRotarySelect.Text = "SELECT"
        Me.btnRotarySelect.UseVisualStyleBackColor = True
        '
        'btnStep6_25k
        '
        Me.btnStep6_25k.BackgroundImage = CType(resources.GetObject("btnStep6_25k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep6_25k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep6_25k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep6_25k.ForeColor = System.Drawing.Color.Black
        Me.btnStep6_25k.Location = New System.Drawing.Point(129, 137)
        Me.btnStep6_25k.Name = "btnStep6_25k"
        Me.btnStep6_25k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep6_25k.TabIndex = 97
        Me.btnStep6_25k.Text = "6.25K"
        Me.btnStep6_25k.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(495, 6)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(46, 27)
        Me.btn3.TabIndex = 60
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'Display1
        '
        Me.Display1.BackColor = System.Drawing.Color.DarkOrange
        Me.Display1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display1.Location = New System.Drawing.Point(82, 36)
        Me.Display1.Margin = New System.Windows.Forms.Padding(4)
        Me.Display1.MinimumSize = New System.Drawing.Size(236, 94)
        Me.Display1.Name = "Display1"
        Me.Display1.Size = New System.Drawing.Size(236, 94)
        Me.Display1.TabIndex = 96
        '
        'btnStep50k
        '
        Me.btnStep50k.BackgroundImage = CType(resources.GetObject("btnStep50k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep50k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep50k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep50k.ForeColor = System.Drawing.Color.Black
        Me.btnStep50k.Location = New System.Drawing.Point(129, 162)
        Me.btnStep50k.Name = "btnStep50k"
        Me.btnStep50k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep50k.TabIndex = 84
        Me.btnStep50k.Text = "50K"
        Me.btnStep50k.UseVisualStyleBackColor = True
        '
        'btnMute
        '
        Me.btnMute.BackgroundImage = CType(resources.GetObject("btnMute.BackgroundImage"), System.Drawing.Image)
        Me.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMute.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMute.ForeColor = System.Drawing.Color.Black
        Me.btnMute.Location = New System.Drawing.Point(6, 183)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.Size = New System.Drawing.Size(70, 27)
        Me.btnMute.TabIndex = 80
        Me.btnMute.Text = "MUTE"
        Me.btnMute.UseVisualStyleBackColor = True
        '
        'btnStep25k
        '
        Me.btnStep25k.BackgroundImage = CType(resources.GetObject("btnStep25k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep25k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep25k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep25k.ForeColor = System.Drawing.Color.Black
        Me.btnStep25k.Location = New System.Drawing.Point(81, 162)
        Me.btnStep25k.Name = "btnStep25k"
        Me.btnStep25k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep25k.TabIndex = 83
        Me.btnStep25k.Text = "25K"
        Me.btnStep25k.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(448, 6)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(46, 27)
        Me.btn2.TabIndex = 59
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(401, 37)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(46, 27)
        Me.btn4.TabIndex = 61
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.BackgroundImage = CType(resources.GetObject("btnScan.BackgroundImage"), System.Drawing.Image)
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.Color.Black
        Me.btnScan.Location = New System.Drawing.Point(6, 7)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(70, 27)
        Me.btnScan.TabIndex = 50
        Me.btnScan.Text = "SCAN"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnStep10k
        '
        Me.btnStep10k.BackgroundImage = CType(resources.GetObject("btnStep10k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep10k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep10k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep10k.ForeColor = System.Drawing.Color.Black
        Me.btnStep10k.Location = New System.Drawing.Point(225, 137)
        Me.btnStep10k.Name = "btnStep10k"
        Me.btnStep10k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep10k.TabIndex = 85
        Me.btnStep10k.Text = "10K"
        Me.btnStep10k.UseVisualStyleBackColor = True
        '
        'btnStep12_5k
        '
        Me.btnStep12_5k.BackgroundImage = CType(resources.GetObject("btnStep12_5k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep12_5k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep12_5k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep12_5k.ForeColor = System.Drawing.Color.Black
        Me.btnStep12_5k.Location = New System.Drawing.Point(273, 137)
        Me.btnStep12_5k.Name = "btnStep12_5k"
        Me.btnStep12_5k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep12_5k.TabIndex = 82
        Me.btnStep12_5k.Text = "12.5K"
        Me.btnStep12_5k.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.BackgroundImage = CType(resources.GetObject("btnManual.BackgroundImage"), System.Drawing.Image)
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.Color.Black
        Me.btnManual.Location = New System.Drawing.Point(325, 99)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(70, 27)
        Me.btnManual.TabIndex = 94
        Me.btnManual.Text = "MANUAL"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Black
        Me.btn5.Location = New System.Drawing.Point(448, 37)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(46, 27)
        Me.btn5.TabIndex = 62
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.BackgroundImage = CType(resources.GetObject("btnTransfer.BackgroundImage"), System.Drawing.Image)
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.Color.Black
        Me.btnTransfer.Location = New System.Drawing.Point(495, 136)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(46, 23)
        Me.btnTransfer.TabIndex = 72
        Me.btnTransfer.Text = "TRN"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Black
        Me.btn6.Location = New System.Drawing.Point(495, 37)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(46, 27)
        Me.btn6.TabIndex = 63
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnAir
        '
        Me.btnAir.BackgroundImage = CType(resources.GetObject("btnAir.BackgroundImage"), System.Drawing.Image)
        Me.btnAir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAir.ForeColor = System.Drawing.Color.Black
        Me.btnAir.Location = New System.Drawing.Point(6, 38)
        Me.btnAir.Name = "btnAir"
        Me.btnAir.Size = New System.Drawing.Size(70, 27)
        Me.btnAir.TabIndex = 51
        Me.btnAir.Text = "AIR"
        Me.btnAir.UseVisualStyleBackColor = True
        '
        'btnStep100k
        '
        Me.btnStep100k.BackgroundImage = CType(resources.GetObject("btnStep100k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep100k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep100k.ForeColor = System.Drawing.Color.Black
        Me.btnStep100k.Location = New System.Drawing.Point(177, 162)
        Me.btnStep100k.Name = "btnStep100k"
        Me.btnStep100k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep100k.TabIndex = 86
        Me.btnStep100k.Text = "100K"
        Me.btnStep100k.UseVisualStyleBackColor = True
        '
        'btnPriority
        '
        Me.btnPriority.BackgroundImage = CType(resources.GetObject("btnPriority.BackgroundImage"), System.Drawing.Image)
        Me.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPriority.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriority.ForeColor = System.Drawing.Color.Black
        Me.btnPriority.Location = New System.Drawing.Point(448, 136)
        Me.btnPriority.Name = "btnPriority"
        Me.btnPriority.Size = New System.Drawing.Size(46, 23)
        Me.btnPriority.TabIndex = 71
        Me.btnPriority.Text = "PRI"
        Me.btnPriority.UseVisualStyleBackColor = True
        '
        'btnStep5k
        '
        Me.btnStep5k.BackgroundImage = CType(resources.GetObject("btnStep5k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep5k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep5k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep5k.ForeColor = System.Drawing.Color.Black
        Me.btnStep5k.Location = New System.Drawing.Point(81, 137)
        Me.btnStep5k.Name = "btnStep5k"
        Me.btnStep5k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep5k.TabIndex = 81
        Me.btnStep5k.Text = "5K"
        Me.btnStep5k.UseVisualStyleBackColor = True
        '
        'btnATT
        '
        Me.btnATT.BackgroundImage = CType(resources.GetObject("btnATT.BackgroundImage"), System.Drawing.Image)
        Me.btnATT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnATT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnATT.ForeColor = System.Drawing.Color.Black
        Me.btnATT.Location = New System.Drawing.Point(495, 161)
        Me.btnATT.Name = "btnATT"
        Me.btnATT.Size = New System.Drawing.Size(46, 23)
        Me.btnATT.TabIndex = 93
        Me.btnATT.Text = "ATT"
        Me.btnATT.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(401, 6)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(46, 27)
        Me.btn1.TabIndex = 58
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Black
        Me.btn7.Location = New System.Drawing.Point(401, 68)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(46, 27)
        Me.btn7.TabIndex = 64
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnSrch
        '
        Me.btnSrch.BackgroundImage = CType(resources.GetObject("btnSrch.BackgroundImage"), System.Drawing.Image)
        Me.btnSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrch.ForeColor = System.Drawing.Color.Black
        Me.btnSrch.Location = New System.Drawing.Point(6, 69)
        Me.btnSrch.Name = "btnSrch"
        Me.btnSrch.Size = New System.Drawing.Size(70, 27)
        Me.btnSrch.TabIndex = 52
        Me.btnSrch.Text = "SEARCH"
        Me.btnSrch.UseVisualStyleBackColor = True
        '
        'btnStep7_5k
        '
        Me.btnStep7_5k.BackgroundImage = CType(resources.GetObject("btnStep7_5k.BackgroundImage"), System.Drawing.Image)
        Me.btnStep7_5k.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep7_5k.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep7_5k.ForeColor = System.Drawing.Color.Black
        Me.btnStep7_5k.Location = New System.Drawing.Point(177, 137)
        Me.btnStep7_5k.Name = "btnStep7_5k"
        Me.btnStep7_5k.Size = New System.Drawing.Size(46, 23)
        Me.btnStep7_5k.TabIndex = 87
        Me.btnStep7_5k.Text = "7.5K"
        Me.btnStep7_5k.UseVisualStyleBackColor = True
        '
        'btnLockOut
        '
        Me.btnLockOut.BackgroundImage = CType(resources.GetObject("btnLockOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLockOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLockOut.ForeColor = System.Drawing.Color.Black
        Me.btnLockOut.Location = New System.Drawing.Point(401, 136)
        Me.btnLockOut.Name = "btnLockOut"
        Me.btnLockOut.Size = New System.Drawing.Size(46, 23)
        Me.btnLockOut.TabIndex = 70
        Me.btnLockOut.Text = "L/O"
        Me.btnLockOut.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Black
        Me.btn8.Location = New System.Drawing.Point(448, 68)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(46, 27)
        Me.btn8.TabIndex = 65
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btnRotaryUp
        '
        Me.btnRotaryUp.BackgroundImage = CType(resources.GetObject("btnRotaryUp.BackgroundImage"), System.Drawing.Image)
        Me.btnRotaryUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotaryUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotaryUp.ForeColor = System.Drawing.Color.Black
        Me.btnRotaryUp.Location = New System.Drawing.Point(273, 187)
        Me.btnRotaryUp.Name = "btnRotaryUp"
        Me.btnRotaryUp.Size = New System.Drawing.Size(46, 23)
        Me.btnRotaryUp.TabIndex = 92
        Me.btnRotaryUp.Text = "+"
        Me.btnRotaryUp.UseVisualStyleBackColor = True
        '
        'btnRvrs
        '
        Me.btnRvrs.BackgroundImage = CType(resources.GetObject("btnRvrs.BackgroundImage"), System.Drawing.Image)
        Me.btnRvrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRvrs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRvrs.ForeColor = System.Drawing.Color.Black
        Me.btnRvrs.Location = New System.Drawing.Point(401, 161)
        Me.btnRvrs.Name = "btnRvrs"
        Me.btnRvrs.Size = New System.Drawing.Size(46, 23)
        Me.btnRvrs.TabIndex = 57
        Me.btnRvrs.Text = "RVS"
        Me.btnRvrs.UseVisualStyleBackColor = True
        '
        'btnModeAM
        '
        Me.btnModeAM.BackColor = System.Drawing.Color.Transparent
        Me.btnModeAM.BackgroundImage = CType(resources.GetObject("btnModeAM.BackgroundImage"), System.Drawing.Image)
        Me.btnModeAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModeAM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModeAM.ForeColor = System.Drawing.Color.Black
        Me.btnModeAM.Location = New System.Drawing.Point(81, 7)
        Me.btnModeAM.Name = "btnModeAM"
        Me.btnModeAM.Size = New System.Drawing.Size(46, 23)
        Me.btnModeAM.TabIndex = 75
        Me.btnModeAM.Text = "AM"
        Me.btnModeAM.UseVisualStyleBackColor = False
        '
        'btnModeAuto
        '
        Me.btnModeAuto.BackgroundImage = CType(resources.GetObject("btnModeAuto.BackgroundImage"), System.Drawing.Image)
        Me.btnModeAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModeAuto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModeAuto.ForeColor = System.Drawing.Color.Black
        Me.btnModeAuto.Location = New System.Drawing.Point(273, 7)
        Me.btnModeAuto.Name = "btnModeAuto"
        Me.btnModeAuto.Size = New System.Drawing.Size(46, 23)
        Me.btnModeAuto.TabIndex = 79
        Me.btnModeAuto.Text = "AUTO"
        Me.btnModeAuto.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(6, 100)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(70, 27)
        Me.btnMenu.TabIndex = 53
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnStepAuto
        '
        Me.btnStepAuto.BackgroundImage = CType(resources.GetObject("btnStepAuto.BackgroundImage"), System.Drawing.Image)
        Me.btnStepAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStepAuto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStepAuto.ForeColor = System.Drawing.Color.Black
        Me.btnStepAuto.Location = New System.Drawing.Point(225, 162)
        Me.btnStepAuto.Name = "btnStepAuto"
        Me.btnStepAuto.Size = New System.Drawing.Size(94, 23)
        Me.btnStepAuto.TabIndex = 88
        Me.btnStepAuto.Text = "AUTO"
        Me.btnStepAuto.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Black
        Me.btnEnter.Location = New System.Drawing.Point(495, 99)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(46, 27)
        Me.btnEnter.TabIndex = 69
        Me.btnEnter.Text = "E"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.BackgroundImage = CType(resources.GetObject("btn9.BackgroundImage"), System.Drawing.Image)
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Black
        Me.btn9.Location = New System.Drawing.Point(495, 68)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(46, 27)
        Me.btn9.TabIndex = 66
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnRotaryDown
        '
        Me.btnRotaryDown.BackgroundImage = CType(resources.GetObject("btnRotaryDown.BackgroundImage"), System.Drawing.Image)
        Me.btnRotaryDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotaryDown.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotaryDown.ForeColor = System.Drawing.Color.Black
        Me.btnRotaryDown.Location = New System.Drawing.Point(81, 187)
        Me.btnRotaryDown.Name = "btnRotaryDown"
        Me.btnRotaryDown.Size = New System.Drawing.Size(46, 23)
        Me.btnRotaryDown.TabIndex = 91
        Me.btnRotaryDown.Text = "-"
        Me.btnRotaryDown.UseVisualStyleBackColor = True
        '
        'btnLimit
        '
        Me.btnLimit.BackgroundImage = CType(resources.GetObject("btnLimit.BackgroundImage"), System.Drawing.Image)
        Me.btnLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimit.ForeColor = System.Drawing.Color.Black
        Me.btnLimit.Location = New System.Drawing.Point(325, 68)
        Me.btnLimit.Name = "btnLimit"
        Me.btnLimit.Size = New System.Drawing.Size(70, 27)
        Me.btnLimit.TabIndex = 56
        Me.btnLimit.Text = "LIMIT"
        Me.btnLimit.UseVisualStyleBackColor = True
        '
        'btnModeFM
        '
        Me.btnModeFM.BackgroundImage = CType(resources.GetObject("btnModeFM.BackgroundImage"), System.Drawing.Image)
        Me.btnModeFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModeFM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModeFM.ForeColor = System.Drawing.Color.Black
        Me.btnModeFM.Location = New System.Drawing.Point(129, 7)
        Me.btnModeFM.Name = "btnModeFM"
        Me.btnModeFM.Size = New System.Drawing.Size(46, 23)
        Me.btnModeFM.TabIndex = 76
        Me.btnModeFM.Text = "FM"
        Me.btnModeFM.UseVisualStyleBackColor = True
        '
        'btnModeWFM
        '
        Me.btnModeWFM.BackgroundImage = CType(resources.GetObject("btnModeWFM.BackgroundImage"), System.Drawing.Image)
        Me.btnModeWFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModeWFM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModeWFM.ForeColor = System.Drawing.Color.Black
        Me.btnModeWFM.Location = New System.Drawing.Point(225, 7)
        Me.btnModeWFM.Name = "btnModeWFM"
        Me.btnModeWFM.Size = New System.Drawing.Size(46, 23)
        Me.btnModeWFM.TabIndex = 78
        Me.btnModeWFM.Text = "WFM"
        Me.btnModeWFM.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.BackgroundImage = CType(resources.GetObject("btnHold.BackgroundImage"), System.Drawing.Image)
        Me.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHold.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.ForeColor = System.Drawing.Color.Black
        Me.btnHold.Location = New System.Drawing.Point(325, 6)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(70, 27)
        Me.btnHold.TabIndex = 54
        Me.btnHold.Text = "HOLD"
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackgroundImage = CType(resources.GetObject("btn0.BackgroundImage"), System.Drawing.Image)
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.Black
        Me.btn0.Location = New System.Drawing.Point(448, 99)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(46, 27)
        Me.btn0.TabIndex = 68
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnPeriod
        '
        Me.btnPeriod.BackgroundImage = CType(resources.GetObject("btnPeriod.BackgroundImage"), System.Drawing.Image)
        Me.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeriod.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod.Location = New System.Drawing.Point(401, 99)
        Me.btnPeriod.Name = "btnPeriod"
        Me.btnPeriod.Size = New System.Drawing.Size(46, 27)
        Me.btnPeriod.TabIndex = 67
        Me.btnPeriod.Text = "."
        Me.btnPeriod.UseVisualStyleBackColor = True
        '
        'btnCommand
        '
        Me.btnCommand.BackgroundImage = CType(resources.GetObject("btnCommand.BackgroundImage"), System.Drawing.Image)
        Me.btnCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommand.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommand.ForeColor = System.Drawing.Color.Black
        Me.btnCommand.Location = New System.Drawing.Point(333, 186)
        Me.btnCommand.Name = "btnCommand"
        Me.btnCommand.Size = New System.Drawing.Size(46, 23)
        Me.btnCommand.TabIndex = 90
        Me.btnCommand.Text = "CMD"
        Me.btnCommand.UseVisualStyleBackColor = True
        Me.btnCommand.Visible = False
        '
        'btnRsm
        '
        Me.btnRsm.BackgroundImage = CType(resources.GetObject("btnRsm.BackgroundImage"), System.Drawing.Image)
        Me.btnRsm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRsm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRsm.ForeColor = System.Drawing.Color.Black
        Me.btnRsm.Location = New System.Drawing.Point(325, 37)
        Me.btnRsm.Name = "btnRsm"
        Me.btnRsm.Size = New System.Drawing.Size(70, 27)
        Me.btnRsm.TabIndex = 55
        Me.btnRsm.Text = "RESUME"
        Me.btnRsm.UseVisualStyleBackColor = True
        '
        'btnModeNFM
        '
        Me.btnModeNFM.BackgroundImage = CType(resources.GetObject("btnModeNFM.BackgroundImage"), System.Drawing.Image)
        Me.btnModeNFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModeNFM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModeNFM.ForeColor = System.Drawing.Color.Black
        Me.btnModeNFM.Location = New System.Drawing.Point(177, 7)
        Me.btnModeNFM.Name = "btnModeNFM"
        Me.btnModeNFM.Size = New System.Drawing.Size(46, 23)
        Me.btnModeNFM.TabIndex = 77
        Me.btnModeNFM.Text = "NFM"
        Me.btnModeNFM.UseVisualStyleBackColor = True
        '
        'tabBanks
        '
        Me.tabBanks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabBanks.Controls.Add(Me.gridBanks)
        Me.tabBanks.Controls.Add(Me.btnWriteBanks)
        Me.tabBanks.Controls.Add(Me.btnReadBanks)
        Me.tabBanks.Location = New System.Drawing.Point(4, 22)
        Me.tabBanks.Name = "tabBanks"
        Me.tabBanks.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBanks.Size = New System.Drawing.Size(548, 218)
        Me.tabBanks.TabIndex = 2
        Me.tabBanks.Text = "Banks"
        '
        'gridBanks
        '
        Me.gridBanks.AllowUserToAddRows = False
        Me.gridBanks.AllowUserToDeleteRows = False
        Me.gridBanks.AllowUserToResizeRows = False
        Me.gridBanks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBanks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.ScanBank, Me.SearchBank})
        Me.gridBanks.Dock = System.Windows.Forms.DockStyle.Left
        Me.gridBanks.Location = New System.Drawing.Point(3, 3)
        Me.gridBanks.Name = "gridBanks"
        Me.gridBanks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridBanks.Size = New System.Drawing.Size(437, 212)
        Me.gridBanks.TabIndex = 84
        '
        'Number
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Number.DefaultCellStyle = DataGridViewCellStyle1
        Me.Number.FillWeight = 15.0!
        Me.Number.HeaderText = "#"
        Me.Number.MaxInputLength = 2
        Me.Number.Name = "Number"
        Me.Number.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ScanBank
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanBank.DefaultCellStyle = DataGridViewCellStyle2
        Me.ScanBank.FillWeight = 98.83249!
        Me.ScanBank.HeaderText = "Scan banks"
        Me.ScanBank.MaxInputLength = 16
        Me.ScanBank.Name = "ScanBank"
        '
        'SearchBank
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBank.DefaultCellStyle = DataGridViewCellStyle3
        Me.SearchBank.FillWeight = 98.83249!
        Me.SearchBank.HeaderText = "Search ranges"
        Me.SearchBank.MaxInputLength = 16
        Me.SearchBank.Name = "SearchBank"
        '
        'btnWriteBanks
        '
        Me.btnWriteBanks.BackgroundImage = CType(resources.GetObject("btnWriteBanks.BackgroundImage"), System.Drawing.Image)
        Me.btnWriteBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWriteBanks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteBanks.ForeColor = System.Drawing.Color.Black
        Me.btnWriteBanks.Location = New System.Drawing.Point(446, 189)
        Me.btnWriteBanks.Name = "btnWriteBanks"
        Me.btnWriteBanks.Size = New System.Drawing.Size(90, 23)
        Me.btnWriteBanks.TabIndex = 83
        Me.btnWriteBanks.Text = "Write banks"
        Me.btnWriteBanks.UseVisualStyleBackColor = True
        '
        'btnReadBanks
        '
        Me.btnReadBanks.BackgroundImage = CType(resources.GetObject("btnReadBanks.BackgroundImage"), System.Drawing.Image)
        Me.btnReadBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadBanks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadBanks.ForeColor = System.Drawing.Color.Black
        Me.btnReadBanks.Location = New System.Drawing.Point(446, 160)
        Me.btnReadBanks.Name = "btnReadBanks"
        Me.btnReadBanks.Size = New System.Drawing.Size(90, 23)
        Me.btnReadBanks.TabIndex = 82
        Me.btnReadBanks.Text = "Read banks"
        Me.btnReadBanks.UseVisualStyleBackColor = True
        '
        'tabLog
        '
        Me.tabLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabLog.Controls.Add(Me.gridReceptionLog)
        Me.tabLog.Location = New System.Drawing.Point(4, 22)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(548, 218)
        Me.tabLog.TabIndex = 1
        Me.tabLog.Text = "Log"
        '
        'gridReceptionLog
        '
        Me.gridReceptionLog.AllowUserToAddRows = False
        Me.gridReceptionLog.AllowUserToDeleteRows = False
        Me.gridReceptionLog.AllowUserToOrderColumns = True
        Me.gridReceptionLog.AllowUserToResizeRows = False
        Me.gridReceptionLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridReceptionLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridReceptionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridReceptionLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Frequency, Me.Channel, Me.ChannelName, Me.Band})
        Me.gridReceptionLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridReceptionLog.Enabled = False
        Me.gridReceptionLog.Location = New System.Drawing.Point(3, 3)
        Me.gridReceptionLog.Name = "gridReceptionLog"
        Me.gridReceptionLog.ReadOnly = True
        Me.gridReceptionLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridReceptionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridReceptionLog.Size = New System.Drawing.Size(542, 212)
        Me.gridReceptionLog.TabIndex = 0
        '
        'Time
        '
        Me.Time.FillWeight = 80.0!
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        '
        'Frequency
        '
        Me.Frequency.HeaderText = "Freq"
        Me.Frequency.Name = "Frequency"
        Me.Frequency.ReadOnly = True
        '
        'Channel
        '
        Me.Channel.FillWeight = 30.0!
        Me.Channel.HeaderText = "Chn#"
        Me.Channel.Name = "Channel"
        Me.Channel.ReadOnly = True
        '
        'ChannelName
        '
        Me.ChannelName.HeaderText = "Channel"
        Me.ChannelName.Name = "ChannelName"
        Me.ChannelName.ReadOnly = True
        '
        'Band
        '
        Me.Band.HeaderText = "Band"
        Me.Band.Name = "Band"
        Me.Band.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(556, 286)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabScanner.ResumeLayout(False)
        Me.tabScanner.PerformLayout()
        Me.tabBanks.ResumeLayout(False)
        CType(Me.gridBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLog.ResumeLayout(False)
        CType(Me.gridReceptionLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnManual As UnidenCommander.Controls.PushButton
    Private WithEvents btnATT As UnidenCommander.Controls.PushButton
    Private WithEvents btnRotaryUp As UnidenCommander.Controls.PushButton
    Private WithEvents btnRotaryDown As UnidenCommander.Controls.PushButton
    Private WithEvents btnCommand As UnidenCommander.Controls.PushButton
    Private WithEvents txtCommand As System.Windows.Forms.TextBox
    Private WithEvents btnStepAuto As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep7_5k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep100k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep10k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep50k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep25k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep12_5k As UnidenCommander.Controls.PushButton
    Private WithEvents btnStep5k As UnidenCommander.Controls.PushButton
    Private WithEvents btnMute As UnidenCommander.Controls.PushButton
    Private WithEvents btnModeAuto As UnidenCommander.Controls.PushButton
    Private WithEvents btnModeWFM As UnidenCommander.Controls.PushButton
    Private WithEvents btnModeNFM As UnidenCommander.Controls.PushButton
    Private WithEvents btnModeFM As UnidenCommander.Controls.PushButton
    Private WithEvents btnModeAM As UnidenCommander.Controls.PushButton
    Private WithEvents btnRotarySelect As UnidenCommander.Controls.PushButton
    Private WithEvents btnTransfer As UnidenCommander.Controls.PushButton
    Private WithEvents btnPriority As UnidenCommander.Controls.PushButton
    Private WithEvents btnLockOut As UnidenCommander.Controls.PushButton
    Private WithEvents btnEnter As UnidenCommander.Controls.PushButton
    Private WithEvents btn0 As UnidenCommander.Controls.PushButton
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnPeriod As UnidenCommander.Controls.PushButton
    Private WithEvents btn9 As UnidenCommander.Controls.PushButton
    Private WithEvents btn8 As UnidenCommander.Controls.PushButton
    Private WithEvents btn7 As UnidenCommander.Controls.PushButton
    Private WithEvents btn6 As UnidenCommander.Controls.PushButton
    Private WithEvents btn4 As UnidenCommander.Controls.PushButton
    Private WithEvents btn3 As UnidenCommander.Controls.PushButton
    Private WithEvents btn2 As UnidenCommander.Controls.PushButton
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btn5 As UnidenCommander.Controls.PushButton
    Private WithEvents btn1 As UnidenCommander.Controls.PushButton
    Private WithEvents btnRvrs As UnidenCommander.Controls.PushButton
    Private WithEvents btnLimit As UnidenCommander.Controls.PushButton
    Private WithEvents btnRsm As UnidenCommander.Controls.PushButton
    Private WithEvents btnHold As UnidenCommander.Controls.PushButton
    Private WithEvents btnMenu As UnidenCommander.Controls.PushButton
    Private WithEvents btnSrch As UnidenCommander.Controls.PushButton
    Private WithEvents btnAir As UnidenCommander.Controls.PushButton
    Private WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents btnScan As UnidenCommander.Controls.PushButton
    Private WithEvents lblScannerInfo As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents lblPort As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents lblSpeed As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Display1 As UnidenCommander.Display
    Friend WithEvents Port As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BaudRate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ScannerInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents firstRunTimer As System.Windows.Forms.Timer
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorderlessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnStep6_25k As UnidenCommander.Controls.PushButton
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabScanner As System.Windows.Forms.TabPage
    Friend WithEvents tabLog As System.Windows.Forms.TabPage
    Friend WithEvents gridReceptionLog As System.Windows.Forms.DataGridView
    Friend WithEvents Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Frequency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Channel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChannelName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Band As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabBanks As System.Windows.Forms.TabPage
    Private WithEvents btnWriteBanks As UnidenCommander.Controls.PushButton
    Private WithEvents btnReadBanks As UnidenCommander.Controls.PushButton
    Friend WithEvents gridBanks As System.Windows.Forms.DataGridView
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScanBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents scannerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChannelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator

End Class

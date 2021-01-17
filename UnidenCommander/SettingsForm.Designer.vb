<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.TimeoutTextbox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lstSpeeds = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.lstPorts = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.TimeoutTrackBar = New System.Windows.Forms.TrackBar
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.chkSaveCommunicationsLog = New System.Windows.Forms.CheckBox
        Me.chkSaveTraceLog = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSelectLogTracePath = New System.Windows.Forms.Button
        Me.txtLogTracePath = New System.Windows.Forms.TextBox
        Me.btnSelectLogSerialCommandsPath = New System.Windows.Forms.Button
        Me.txtLogSerialCommandsPath = New System.Windows.Forms.TextBox
        Me.btnSelectLogReceptionPath = New System.Windows.Forms.Button
        Me.txtLogReceptionPath = New System.Windows.Forms.TextBox
        Me.chkReceptionLogging = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkAnimateButtons = New System.Windows.Forms.CheckBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.groupBox1.SuspendLayout()
        CType(Me.TimeoutTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.TimeoutTextbox)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.lstSpeeds)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.lstPorts)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.TimeoutTrackBar)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(354, 126)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Connection"
        '
        'TimeoutTextbox
        '
        Me.TimeoutTextbox.Location = New System.Drawing.Point(291, 78)
        Me.TimeoutTextbox.Name = "TimeoutTextbox"
        Me.TimeoutTextbox.ReadOnly = True
        Me.TimeoutTextbox.Size = New System.Drawing.Size(27, 20)
        Me.TimeoutTextbox.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "sec"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time-out"
        '
        'lstSpeeds
        '
        Me.lstSpeeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.Location = New System.Drawing.Point(71, 48)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(274, 21)
        Me.lstSpeeds.TabIndex = 7
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Speed"
        '
        'lstPorts
        '
        Me.lstPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.Location = New System.Drawing.Point(71, 21)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(274, 21)
        Me.lstPorts.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Port"
        '
        'TimeoutTrackBar
        '
        Me.TimeoutTrackBar.Location = New System.Drawing.Point(71, 75)
        Me.TimeoutTrackBar.Maximum = 15
        Me.TimeoutTrackBar.Minimum = 1
        Me.TimeoutTrackBar.Name = "TimeoutTrackBar"
        Me.TimeoutTrackBar.Size = New System.Drawing.Size(214, 45)
        Me.TimeoutTrackBar.TabIndex = 29
        Me.TimeoutTrackBar.TickFrequency = 2
        Me.TimeoutTrackBar.Value = 5
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(210, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(291, 332)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkSaveCommunicationsLog
        '
        Me.chkSaveCommunicationsLog.AutoSize = True
        Me.chkSaveCommunicationsLog.Location = New System.Drawing.Point(11, 42)
        Me.chkSaveCommunicationsLog.Name = "chkSaveCommunicationsLog"
        Me.chkSaveCommunicationsLog.Size = New System.Drawing.Size(143, 17)
        Me.chkSaveCommunicationsLog.TabIndex = 26
        Me.chkSaveCommunicationsLog.Text = "Serial commands logging"
        Me.chkSaveCommunicationsLog.UseVisualStyleBackColor = True
        '
        'chkSaveTraceLog
        '
        Me.chkSaveTraceLog.AutoSize = True
        Me.chkSaveTraceLog.Location = New System.Drawing.Point(11, 65)
        Me.chkSaveTraceLog.Name = "chkSaveTraceLog"
        Me.chkSaveTraceLog.Size = New System.Drawing.Size(102, 17)
        Me.chkSaveTraceLog.TabIndex = 27
        Me.chkSaveTraceLog.Text = "Debug logging *"
        Me.chkSaveTraceLog.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnSelectLogTracePath)
        Me.GroupBox2.Controls.Add(Me.txtLogTracePath)
        Me.GroupBox2.Controls.Add(Me.btnSelectLogSerialCommandsPath)
        Me.GroupBox2.Controls.Add(Me.txtLogSerialCommandsPath)
        Me.GroupBox2.Controls.Add(Me.btnSelectLogReceptionPath)
        Me.GroupBox2.Controls.Add(Me.txtLogReceptionPath)
        Me.GroupBox2.Controls.Add(Me.chkReceptionLogging)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkSaveCommunicationsLog)
        Me.GroupBox2.Controls.Add(Me.chkSaveTraceLog)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 126)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logging"
        '
        'btnSelectLogTracePath
        '
        Me.btnSelectLogTracePath.Location = New System.Drawing.Point(317, 62)
        Me.btnSelectLogTracePath.Name = "btnSelectLogTracePath"
        Me.btnSelectLogTracePath.Size = New System.Drawing.Size(28, 20)
        Me.btnSelectLogTracePath.TabIndex = 35
        Me.btnSelectLogTracePath.Text = "..."
        Me.btnSelectLogTracePath.UseVisualStyleBackColor = True
        '
        'txtLogTracePath
        '
        Me.txtLogTracePath.Location = New System.Drawing.Point(184, 63)
        Me.txtLogTracePath.Name = "txtLogTracePath"
        Me.txtLogTracePath.Size = New System.Drawing.Size(127, 20)
        Me.txtLogTracePath.TabIndex = 34
        '
        'btnSelectLogSerialCommandsPath
        '
        Me.btnSelectLogSerialCommandsPath.Location = New System.Drawing.Point(317, 39)
        Me.btnSelectLogSerialCommandsPath.Name = "btnSelectLogSerialCommandsPath"
        Me.btnSelectLogSerialCommandsPath.Size = New System.Drawing.Size(28, 20)
        Me.btnSelectLogSerialCommandsPath.TabIndex = 33
        Me.btnSelectLogSerialCommandsPath.Text = "..."
        Me.btnSelectLogSerialCommandsPath.UseVisualStyleBackColor = True
        '
        'txtLogSerialCommandsPath
        '
        Me.txtLogSerialCommandsPath.Location = New System.Drawing.Point(184, 40)
        Me.txtLogSerialCommandsPath.Name = "txtLogSerialCommandsPath"
        Me.txtLogSerialCommandsPath.Size = New System.Drawing.Size(127, 20)
        Me.txtLogSerialCommandsPath.TabIndex = 32
        '
        'btnSelectLogReceptionPath
        '
        Me.btnSelectLogReceptionPath.Enabled = False
        Me.btnSelectLogReceptionPath.Location = New System.Drawing.Point(317, 16)
        Me.btnSelectLogReceptionPath.Name = "btnSelectLogReceptionPath"
        Me.btnSelectLogReceptionPath.Size = New System.Drawing.Size(28, 20)
        Me.btnSelectLogReceptionPath.TabIndex = 31
        Me.btnSelectLogReceptionPath.Text = "..."
        Me.btnSelectLogReceptionPath.UseVisualStyleBackColor = True
        '
        'txtLogReceptionPath
        '
        Me.txtLogReceptionPath.Enabled = False
        Me.txtLogReceptionPath.Location = New System.Drawing.Point(184, 17)
        Me.txtLogReceptionPath.Name = "txtLogReceptionPath"
        Me.txtLogReceptionPath.ReadOnly = True
        Me.txtLogReceptionPath.Size = New System.Drawing.Size(127, 20)
        Me.txtLogReceptionPath.TabIndex = 30
        '
        'chkReceptionLogging
        '
        Me.chkReceptionLogging.AutoSize = True
        Me.chkReceptionLogging.Enabled = False
        Me.chkReceptionLogging.Location = New System.Drawing.Point(11, 19)
        Me.chkReceptionLogging.Name = "chkReceptionLogging"
        Me.chkReceptionLogging.Size = New System.Drawing.Size(112, 17)
        Me.chkReceptionLogging.TabIndex = 29
        Me.chkReceptionLogging.Text = "Reception logging"
        Me.chkReceptionLogging.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 33)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Use with care, log files can grow up to 5MB per minute and degrade performance co" & _
            "nsiderably! * Restart required for debug logging."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.chkAnimateButtons)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 47)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User interface"
        '
        'chkAnimateButtons
        '
        Me.chkAnimateButtons.AutoSize = True
        Me.chkAnimateButtons.Location = New System.Drawing.Point(9, 19)
        Me.chkAnimateButtons.Name = "chkAnimateButtons"
        Me.chkAnimateButtons.Size = New System.Drawing.Size(102, 17)
        Me.chkAnimateButtons.TabIndex = 30
        Me.chkAnimateButtons.Text = "Animate buttons"
        Me.chkAnimateButtons.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(380, 369)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.TimeoutTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lstSpeeds As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents lstPorts As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkSaveCommunicationsLog As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveTraceLog As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimeoutTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimeoutTextbox As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAnimateButtons As System.Windows.Forms.CheckBox
    Friend WithEvents chkReceptionLogging As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectLogTracePath As System.Windows.Forms.Button
    Friend WithEvents txtLogTracePath As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectLogSerialCommandsPath As System.Windows.Forms.Button
    Friend WithEvents txtLogSerialCommandsPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectLogReceptionPath As System.Windows.Forms.Button
    Friend WithEvents txtLogReceptionPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.labelDescription = New System.Windows.Forms.Label
        Me.linkWebsite = New System.Windows.Forms.LinkLabel
        Me.labelCopyright = New System.Windows.Forms.Label
        Me.labelVersion = New System.Windows.Forms.Label
        Me.labelProductName = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.pictureBox2 = New System.Windows.Forms.PictureBox
        Me.picVersionCheckStatus = New System.Windows.Forms.PictureBox
        Me.lblVersionCheckStatus = New System.Windows.Forms.Label
        Me.VersionCheckTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVersionCheckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelDescription
        '
        Me.labelDescription.AutoEllipsis = True
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Location = New System.Drawing.Point(12, 122)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(60, 13)
        Me.labelDescription.TabIndex = 18
        Me.labelDescription.Text = "Description"
        '
        'linkWebsite
        '
        Me.linkWebsite.AutoSize = True
        Me.linkWebsite.Location = New System.Drawing.Point(130, 78)
        Me.linkWebsite.Name = "linkWebsite"
        Me.linkWebsite.Size = New System.Drawing.Size(113, 13)
        Me.linkWebsite.TabIndex = 16
        Me.linkWebsite.TabStop = True
        Me.linkWebsite.Text = "http://dx.torensma.net"
        '
        'labelCopyright
        '
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.Location = New System.Drawing.Point(12, 103)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(51, 13)
        Me.labelCopyright.TabIndex = 14
        Me.labelCopyright.Text = "Copyright"
        '
        'labelVersion
        '
        Me.labelVersion.AutoSize = True
        Me.labelVersion.Location = New System.Drawing.Point(129, 36)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(42, 13)
        Me.labelVersion.TabIndex = 13
        Me.labelVersion.Text = "Version"
        '
        'labelProductName
        '
        Me.labelProductName.AutoEllipsis = True
        Me.labelProductName.AutoSize = True
        Me.labelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelProductName.Location = New System.Drawing.Point(129, 12)
        Me.labelProductName.Name = "labelProductName"
        Me.labelProductName.Size = New System.Drawing.Size(140, 24)
        Me.labelProductName.TabIndex = 12
        Me.labelProductName.Text = "Product name"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(355, 161)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.UnidenCommander.My.Resources.Images.logo_large
        Me.pictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(111, 79)
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'picVersionCheckStatus
        '
        Me.picVersionCheckStatus.Image = Global.UnidenCommander.My.Resources.Images.warning_16x16
        Me.picVersionCheckStatus.Location = New System.Drawing.Point(12, 163)
        Me.picVersionCheckStatus.Name = "picVersionCheckStatus"
        Me.picVersionCheckStatus.Size = New System.Drawing.Size(16, 16)
        Me.picVersionCheckStatus.TabIndex = 19
        Me.picVersionCheckStatus.TabStop = False
        '
        'lblVersionCheckStatus
        '
        Me.lblVersionCheckStatus.AutoSize = True
        Me.lblVersionCheckStatus.Location = New System.Drawing.Point(34, 166)
        Me.lblVersionCheckStatus.Name = "lblVersionCheckStatus"
        Me.lblVersionCheckStatus.Size = New System.Drawing.Size(98, 13)
        Me.lblVersionCheckStatus.TabIndex = 20
        Me.lblVersionCheckStatus.Text = "Checking version..."
        '
        'VersionCheckTimer
        '
        Me.VersionCheckTimer.Interval = 250
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 196)
        Me.Controls.Add(Me.lblVersionCheckStatus)
        Me.Controls.Add(Me.picVersionCheckStatus)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.linkWebsite)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.labelProductName)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutForm"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVersionCheckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Private WithEvents labelDescription As System.Windows.Forms.Label
	Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
	Private WithEvents linkWebsite As System.Windows.Forms.LinkLabel
    Private WithEvents labelCopyright As System.Windows.Forms.Label
	Private WithEvents labelVersion As System.Windows.Forms.Label
	Private WithEvents labelProductName As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents picVersionCheckStatus As System.Windows.Forms.PictureBox
    Private WithEvents lblVersionCheckStatus As System.Windows.Forms.Label
    Friend WithEvents VersionCheckTimer As System.Windows.Forms.Timer

End Class

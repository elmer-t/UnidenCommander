<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtLine1 = New System.Windows.Forms.Label
        Me.txtLine2 = New System.Windows.Forms.Label
        Me.txtLine3 = New System.Windows.Forms.Label
        Me.txtLine4 = New System.Windows.Forms.Label
        Me.txtCenter = New System.Windows.Forms.Label
        Me.txtAttuanted = New System.Windows.Forms.Label
        Me.txtMuted = New System.Windows.Forms.Label
        Me.txtStepSize = New System.Windows.Forms.Label
        Me.txtPriority = New System.Windows.Forms.Label
        Me.txtLockedOut = New System.Windows.Forms.Label
        Me.S_Meter1 = New UnidenCommander.S_Meter
        Me.SuspendLayout()
        '
        'txtLine1
        '
        Me.txtLine1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine1.AutoSize = True
        Me.txtLine1.BackColor = System.Drawing.Color.Transparent
        Me.txtLine1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine1.Location = New System.Drawing.Point(3, 4)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.Size = New System.Drawing.Size(44, 17)
        Me.txtLine1.TabIndex = 12
        Me.txtLine1.Text = "Mode"
        '
        'txtLine2
        '
        Me.txtLine2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine2.AutoSize = True
        Me.txtLine2.BackColor = System.Drawing.Color.Transparent
        Me.txtLine2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine2.Location = New System.Drawing.Point(3, 26)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.Size = New System.Drawing.Size(107, 17)
        Me.txtLine2.TabIndex = 14
        Me.txtLine2.Text = "25.0000  AM"
        '
        'txtLine3
        '
        Me.txtLine3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine3.AutoSize = True
        Me.txtLine3.BackColor = System.Drawing.Color.Transparent
        Me.txtLine3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine3.Location = New System.Drawing.Point(3, 48)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.Size = New System.Drawing.Size(98, 17)
        Me.txtLine3.TabIndex = 16
        Me.txtLine3.Text = "Welcome to"
        '
        'txtLine4
        '
        Me.txtLine4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine4.AutoSize = True
        Me.txtLine4.BackColor = System.Drawing.Color.Transparent
        Me.txtLine4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine4.Location = New System.Drawing.Point(3, 70)
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.Size = New System.Drawing.Size(143, 17)
        Me.txtLine4.TabIndex = 17
        Me.txtLine4.Text = "UnidenCommander"
        '
        'txtCenter
        '
        Me.txtCenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCenter.AutoSize = True
        Me.txtCenter.BackColor = System.Drawing.Color.Transparent
        Me.txtCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.txtCenter.Location = New System.Drawing.Point(166, 73)
        Me.txtCenter.Name = "txtCenter"
        Me.txtCenter.Size = New System.Drawing.Size(68, 13)
        Me.txtCenter.TabIndex = 18
        Me.txtCenter.Text = "|------+------|"
        Me.txtCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAttuanted
        '
        Me.txtAttuanted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAttuanted.AutoSize = True
        Me.txtAttuanted.BackColor = System.Drawing.Color.Transparent
        Me.txtAttuanted.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttuanted.ForeColor = System.Drawing.Color.Orange
        Me.txtAttuanted.Location = New System.Drawing.Point(170, 19)
        Me.txtAttuanted.Name = "txtAttuanted"
        Me.txtAttuanted.Size = New System.Drawing.Size(28, 14)
        Me.txtAttuanted.TabIndex = 19
        Me.txtAttuanted.Text = "ATT"
        '
        'txtMuted
        '
        Me.txtMuted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMuted.AutoSize = True
        Me.txtMuted.BackColor = System.Drawing.Color.Transparent
        Me.txtMuted.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuted.ForeColor = System.Drawing.Color.Orange
        Me.txtMuted.Location = New System.Drawing.Point(170, 33)
        Me.txtMuted.Name = "txtMuted"
        Me.txtMuted.Size = New System.Drawing.Size(35, 14)
        Me.txtMuted.TabIndex = 20
        Me.txtMuted.Text = "MUTE"
        '
        'txtStepSize
        '
        Me.txtStepSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStepSize.AutoSize = True
        Me.txtStepSize.BackColor = System.Drawing.Color.Transparent
        Me.txtStepSize.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStepSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStepSize.Location = New System.Drawing.Point(170, 5)
        Me.txtStepSize.Name = "txtStepSize"
        Me.txtStepSize.Size = New System.Drawing.Size(35, 14)
        Me.txtStepSize.TabIndex = 21
        Me.txtStepSize.Text = "STEP"
        '
        'txtPriority
        '
        Me.txtPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPriority.AutoSize = True
        Me.txtPriority.BackColor = System.Drawing.Color.Transparent
        Me.txtPriority.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriority.ForeColor = System.Drawing.Color.Orange
        Me.txtPriority.Location = New System.Drawing.Point(205, 33)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(28, 14)
        Me.txtPriority.TabIndex = 23
        Me.txtPriority.Text = "PRI"
        Me.txtPriority.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLockedOut
        '
        Me.txtLockedOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLockedOut.AutoSize = True
        Me.txtLockedOut.BackColor = System.Drawing.Color.Transparent
        Me.txtLockedOut.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLockedOut.ForeColor = System.Drawing.Color.Orange
        Me.txtLockedOut.Location = New System.Drawing.Point(205, 19)
        Me.txtLockedOut.Name = "txtLockedOut"
        Me.txtLockedOut.Size = New System.Drawing.Size(28, 14)
        Me.txtLockedOut.TabIndex = 22
        Me.txtLockedOut.Text = "L/O"
        Me.txtLockedOut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'S_Meter1
        '
        Me.S_Meter1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_Meter1.BackColor = System.Drawing.Color.Transparent
        Me.S_Meter1.Location = New System.Drawing.Point(170, 48)
        Me.S_Meter1.Margin = New System.Windows.Forms.Padding(4)
        Me.S_Meter1.Maximum = 210
        Me.S_Meter1.Minimum = 56
        Me.S_Meter1.Name = "S_Meter1"
        Me.S_Meter1.Size = New System.Drawing.Size(60, 20)
        Me.S_Meter1.TabIndex = 11
        Me.S_Meter1.Value = 50
        '
        'Display
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.txtLockedOut)
        Me.Controls.Add(Me.txtStepSize)
        Me.Controls.Add(Me.txtMuted)
        Me.Controls.Add(Me.txtAttuanted)
        Me.Controls.Add(Me.txtCenter)
        Me.Controls.Add(Me.S_Meter1)
        Me.Controls.Add(Me.txtLine4)
        Me.Controls.Add(Me.txtLine3)
        Me.Controls.Add(Me.txtLine2)
        Me.Controls.Add(Me.txtLine1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(235, 94)
        Me.Name = "Display"
        Me.Size = New System.Drawing.Size(235, 94)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S_Meter1 As UnidenCommander.S_Meter
    Friend WithEvents txtLine1 As System.Windows.Forms.Label
    Friend WithEvents txtLine2 As System.Windows.Forms.Label
    Friend WithEvents txtLine3 As System.Windows.Forms.Label
    Friend WithEvents txtLine4 As System.Windows.Forms.Label
    Friend WithEvents txtCenter As System.Windows.Forms.Label
    Friend WithEvents txtAttuanted As System.Windows.Forms.Label
    Friend WithEvents txtMuted As System.Windows.Forms.Label
    Friend WithEvents txtStepSize As System.Windows.Forms.Label
    Friend WithEvents txtPriority As System.Windows.Forms.Label
    Friend WithEvents txtLockedOut As System.Windows.Forms.Label

End Class

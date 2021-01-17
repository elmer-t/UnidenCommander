<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Meter
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
        Me.S1 = New System.Windows.Forms.Panel
        Me.S2 = New System.Windows.Forms.Panel
        Me.S3 = New System.Windows.Forms.Panel
        Me.S4 = New System.Windows.Forms.Panel
        Me.S5 = New System.Windows.Forms.Panel
        Me.S6 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.DimGray
        Me.S1.Location = New System.Drawing.Point(1, 13)
        Me.S1.Margin = New System.Windows.Forms.Padding(1)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(8, 6)
        Me.S1.TabIndex = 0
        Me.S1.Tag = "1"
        '
        'S2
        '
        Me.S2.BackColor = System.Drawing.Color.DimGray
        Me.S2.Location = New System.Drawing.Point(11, 11)
        Me.S2.Margin = New System.Windows.Forms.Padding(1)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(8, 8)
        Me.S2.TabIndex = 1
        Me.S2.Tag = "2"
        '
        'S3
        '
        Me.S3.BackColor = System.Drawing.Color.DimGray
        Me.S3.Location = New System.Drawing.Point(21, 9)
        Me.S3.Margin = New System.Windows.Forms.Padding(1)
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(8, 10)
        Me.S3.TabIndex = 1
        Me.S3.Tag = "3"
        '
        'S4
        '
        Me.S4.BackColor = System.Drawing.Color.DimGray
        Me.S4.Location = New System.Drawing.Point(31, 7)
        Me.S4.Margin = New System.Windows.Forms.Padding(1)
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(8, 12)
        Me.S4.TabIndex = 1
        Me.S4.Tag = "4"
        '
        'S5
        '
        Me.S5.BackColor = System.Drawing.Color.DimGray
        Me.S5.Location = New System.Drawing.Point(41, 5)
        Me.S5.Margin = New System.Windows.Forms.Padding(1)
        Me.S5.Name = "S5"
        Me.S5.Size = New System.Drawing.Size(8, 14)
        Me.S5.TabIndex = 1
        Me.S5.Tag = "5"
        '
        'S6
        '
        Me.S6.BackColor = System.Drawing.Color.DimGray
        Me.S6.Location = New System.Drawing.Point(51, 3)
        Me.S6.Margin = New System.Windows.Forms.Padding(1)
        Me.S6.Name = "S6"
        Me.S6.Size = New System.Drawing.Size(8, 16)
        Me.S6.TabIndex = 1
        Me.S6.Tag = "6"
        '
        'S_Meter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.S6)
        Me.Controls.Add(Me.S5)
        Me.Controls.Add(Me.S4)
        Me.Controls.Add(Me.S3)
        Me.Controls.Add(Me.S2)
        Me.Controls.Add(Me.S1)
        Me.Name = "S_Meter"
        Me.Size = New System.Drawing.Size(60, 20)
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents S1 As System.Windows.Forms.Panel
	Friend WithEvents S2 As System.Windows.Forms.Panel
	Friend WithEvents S3 As System.Windows.Forms.Panel
	Friend WithEvents S4 As System.Windows.Forms.Panel
	Friend WithEvents S5 As System.Windows.Forms.Panel
	Friend WithEvents S6 As System.Windows.Forms.Panel

End Class

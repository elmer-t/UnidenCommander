<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BandScope
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
		Me.lblLowerBound = New System.Windows.Forms.Label
		Me.lblUpperBound = New System.Windows.Forms.Label
		Me.Graph = New System.Windows.Forms.Panel
		Me.lblStepSize = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'lblLowerBound
		'
		Me.lblLowerBound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblLowerBound.AutoSize = True
		Me.lblLowerBound.BackColor = System.Drawing.Color.Transparent
		Me.lblLowerBound.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLowerBound.Location = New System.Drawing.Point(8, 104)
		Me.lblLowerBound.Name = "lblLowerBound"
		Me.lblLowerBound.Size = New System.Drawing.Size(39, 9)
		Me.lblLowerBound.TabIndex = 0
		Me.lblLowerBound.Text = "0192.7500"
		'
		'lblUpperBound
		'
		Me.lblUpperBound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblUpperBound.AutoSize = True
		Me.lblUpperBound.BackColor = System.Drawing.Color.Transparent
		Me.lblUpperBound.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUpperBound.Location = New System.Drawing.Point(273, 104)
		Me.lblUpperBound.Name = "lblUpperBound"
		Me.lblUpperBound.Size = New System.Drawing.Size(39, 9)
		Me.lblUpperBound.TabIndex = 1
		Me.lblUpperBound.Text = "0198.0000"
		Me.lblUpperBound.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Graph
		'
		Me.Graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Graph.BackColor = System.Drawing.Color.SandyBrown
		Me.Graph.Location = New System.Drawing.Point(9, 9)
		Me.Graph.Name = "Graph"
		Me.Graph.Size = New System.Drawing.Size(303, 88)
		Me.Graph.TabIndex = 2
		'
		'lblStepSize
		'
		Me.lblStepSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblStepSize.AutoSize = True
		Me.lblStepSize.BackColor = System.Drawing.Color.Transparent
		Me.lblStepSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStepSize.Location = New System.Drawing.Point(151, 104)
		Me.lblStepSize.Name = "lblStepSize"
		Me.lblStepSize.Size = New System.Drawing.Size(19, 9)
		Me.lblStepSize.TabIndex = 3
		Me.lblStepSize.Text = "12.5"
		Me.lblStepSize.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'BandScope
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkOrange
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.lblStepSize)
		Me.Controls.Add(Me.Graph)
		Me.Controls.Add(Me.lblUpperBound)
		Me.Controls.Add(Me.lblLowerBound)
		Me.Name = "BandScope"
		Me.Padding = New System.Windows.Forms.Padding(5, 5, 5, 20)
		Me.Size = New System.Drawing.Size(320, 120)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblLowerBound As System.Windows.Forms.Label
	Friend WithEvents lblUpperBound As System.Windows.Forms.Label
	Friend WithEvents Graph As System.Windows.Forms.Panel
	Friend WithEvents lblStepSize As System.Windows.Forms.Label

End Class

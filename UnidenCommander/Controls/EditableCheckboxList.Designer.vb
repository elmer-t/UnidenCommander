
Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class EditableCheckboxList
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
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(3, 6)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.Location = New System.Drawing.Point(24, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(123, 20)
            Me.TextBox1.TabIndex = 1
            Me.TextBox1.Text = "Checkbox1"
            '
            'EditableCheckboxList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.CheckBox1)
            Me.Name = "EditableCheckboxList"
            Me.Size = New System.Drawing.Size(150, 100)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

    End Class

End Namespace

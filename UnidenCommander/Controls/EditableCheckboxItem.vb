
Namespace Controls

    <Serializable()> _
    Public Class EditableCheckboxItem

        Public Text As String
        Public Checked As Boolean

        Public Sub New(ByVal text As String, Optional ByVal checked As Boolean = False)
            Me.Text = text
            Me.Checked = checked
        End Sub

    End Class

End Namespace


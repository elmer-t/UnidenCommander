
Namespace Controls

    Public Class PushButton
        Inherits Button

        Private state As Boolean

        Public Sub SetState(ByVal state As Boolean)

            If InvokeRequired Then
                Dim del As New SubDelegate(AddressOf SetState)
                Invoke(del, New Object() {state})
            End If

            Me.state = state
            Invalidate()

        End Sub

        Private Sub PushButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

            If state Then
                Me.ForeColor = Color.White
            Else
                Me.ForeColor = Color.Black
            End If

            'Dim f As Font

            'If State Then
            '    f = New Font(SystemFonts.DialogFont.FontFamily, Me.Font.Size, FontStyle.Underline)
            'Else
            '    f = New Font(SystemFonts.DialogFont.FontFamily, Me.Font.Size, FontStyle.Regular)
            'End If

            'Me.Font = f

        End Sub

        Private Delegate Sub SubDelegate(ByVal s As Boolean)

    End Class

End Namespace


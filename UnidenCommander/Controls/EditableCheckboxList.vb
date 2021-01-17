
Imports System.Collections

Namespace Controls

    <Serializable()> _
    Public Class EditableCheckboxList

        Private _items As New ObjectModel.Collection(Of EditableCheckboxItem)


        Public Property Items() As ObjectModel.Collection(Of EditableCheckboxItem)
            Get
                Return _items
            End Get
            Set(ByVal value As ObjectModel.Collection(Of EditableCheckboxItem))
                _items = value
            End Set
        End Property

        'Private Sub EditableCheckboxList_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout

        '    CreateChildControls()

        'End Sub

        'Private Sub EditableCheckboxList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '    CreateChildControls()

        'End Sub

        Private Sub CreateChildControls()

            Me.Controls.Clear()

            Dim c As CheckBox
            Dim t As TextBox
            Dim top, left As Integer

            top = Me.Padding.Top
            left = Me.Padding.Left

            For Each item As EditableCheckboxItem In Me.Items

                c = New CheckBox
                c.Checked = item.Checked
                c.Text = ""
                c.Location = New System.Drawing.Point(top, left)
                Me.Controls.Add(c)

                t = New TextBox
                t.Text = item.Text
                t.Location = New System.Drawing.Point(top, left + c.Width)
                t.Anchor = DirectCast(AnchorStyles.Left + AnchorStyles.Right, AnchorStyles)
                Me.Controls.Add(t)

                top = top + c.Height

            Next

        End Sub

    End Class

End Namespace


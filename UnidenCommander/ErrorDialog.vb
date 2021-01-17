Imports System.Windows.Forms

Public Class ErrorDialog

    Private _title As String
    Private _message As String
    Private _exception As Exception

    Public WriteOnly Property Title() As String
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Public WriteOnly Property Message() As String
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public WriteOnly Property Exception() As Exception
        Set(ByVal value As Exception)
            _exception = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ErrorDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = String.Format("{0} v.{1}", Application.ProductName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())

        If _exception Is Nothing Then
            Me.lblExceptionMessage.Text = _title
            Me.txtExceptionDetails.Text = _message
        Else

            Dim sb As New System.Text.StringBuilder
            Dim ex As Exception = _exception

            While Not ex Is Nothing
                sb.Append(ex.ToString)
                sb.AppendLine()
                sb.Append(" --- Inner exception --- ")
                sb.AppendLine()
                ex = ex.InnerException
            End While

            Me.lblExceptionMessage.Text = _exception.Message
            Me.txtExceptionDetails.Text = sb.ToString

        End If

    End Sub

End Class

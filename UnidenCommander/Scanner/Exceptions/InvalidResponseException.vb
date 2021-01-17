
Namespace Scanner.Exceptions

    Public Class InvalidResponseException
        Inherits Exception

        Public Command As String
        Public ExpectedResponse As String
        Public ActualResponse As String

        Public Sub New(ByVal command As String, ByVal expectedResponse As String, ByVal actualResponse As String)
            Me.Command = command
            Me.ExpectedResponse = expectedResponse
            Me.ActualResponse = actualResponse
        End Sub

        Public Overrides ReadOnly Property Message() As String
            Get
                If ExpectedResponse = Nothing Then ExpectedResponse = "NOTHING"
                If ActualResponse = Nothing Then ActualResponse = "NOTHING"
                Return String.Format("Invalid response to '{0}', expected '{1}' but got '{2}'", Command, ExpectedResponse, ActualResponse)
            End Get
        End Property

    End Class

End Namespace


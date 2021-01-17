
Namespace Exceptions

    ''' <summary>
    ''' Exceptions is thrown when a command is used which is not supported by the currently connected scanner.
    ''' </summary>
    Public Class CommandNotSupportedException
        Inherits Exception

        Public Overrides ReadOnly Property Message() As String
            Get
                Return "Command not supported by the currently connected scanner."
            End Get
        End Property

    End Class

End Namespace


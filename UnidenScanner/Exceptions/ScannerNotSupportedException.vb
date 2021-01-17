
Namespace Exceptions

    Public Class ScannerNotSupportedException
        Inherits Exception

        Public Model As String

        Public Sub New(ByVal model As String)
            Me.Model = model
        End Sub

    End Class

End Namespace

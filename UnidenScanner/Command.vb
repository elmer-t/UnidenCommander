

Public Structure Command

    Public Command As String
    Public Response As String
    Public ResponseHandlerDelegate As [Delegate]
    Public IsLastInQueue As Boolean

    Public Sub New(ByVal cmd As String, Optional ByVal isLast As Boolean = False)
        Me.Command = cmd
        Me.IsLastInQueue = isLast
    End Sub

    Public Sub New(ByVal cmd As String, ByVal handler As [Delegate], Optional ByVal isLast As Boolean = False)
        Me.Command = cmd
        Me.ResponseHandlerDelegate = handler
        Me.IsLastInQueue = isLast
    End Sub

    Public Sub New(ByVal cmd As String, ByVal response As String, ByVal handler As [Delegate], Optional ByVal isLast As Boolean = False)
        Me.Command = cmd
        Me.Response = response
        Me.ResponseHandlerDelegate = handler
        Me.IsLastInQueue = isLast
    End Sub

End Structure




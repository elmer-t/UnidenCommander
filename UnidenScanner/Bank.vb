
Public Class Bank

    Public ScanBankTag As String
    Public SearchRangeTag As String
    Public ReadOnly Property Number() As Integer
        Get
            ' Return A=1, B=2, ... J=10
            If Me.Character = Nothing Then Return Nothing
            Return Convert.ToInt32(Me.Character) - 64
        End Get
    End Property
    Public Character As Char

    Public Sub New(ByVal character As Char)
        Me.Character = character
    End Sub

    Public Sub New(ByVal character As Char, ByVal scanBankTag As String, ByVal searchRangeTag As String)
        Me.Character = character
        Me.ScanBankTag = scanBankTag
        Me.SearchRangeTag = searchRangeTag
    End Sub

End Class



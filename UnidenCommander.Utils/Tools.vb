Public Class Tools

	Public Shared Function GetEnumValueByName(ByVal enumType As System.Type, ByVal name As String) As Integer

		For Each item As Integer In [Enum].GetValues(enumType)
            If name = ([Enum].GetName(enumType, item)) Then Return item
        Next

		Return Nothing

	End Function

    Public Shared Function IIf(Of T)(ByVal Expression As Boolean, ByVal TruePart As Object, ByVal FalsePart As Object) As T
        If Expression Then
            Return CType(TruePart, T)
        Else
            Return CType(FalsePart, T)
        End If
    End Function

End Class

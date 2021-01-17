
Public Class S_Meter

	Private _maximum As Integer = 100
	Private _minimum As Integer = 0
    Private _value As Integer = 50
	Private _numberOfBars As Integer = 6

    Public OnColor As System.Drawing.Color = Color.Black
    Public OffColor As System.Drawing.Color = System.Drawing.Color.Orange

	Public Property Maximum() As Integer
		Get
			Return _maximum
		End Get
		Set(ByVal value As Integer)
			_maximum = value
		End Set
	End Property

	Public Property Minimum() As Integer
		Get
			Return _minimum
		End Get
		Set(ByVal value As Integer)
			_minimum = value
		End Set
	End Property

	Public Property Value() As Integer
		Get
			Return _value
		End Get
		Set(ByVal value As Integer)
			_value = value
			If InvokeRequired Then
				Dim del As New InvalidateDelegate(AddressOf Invalidate)
				Invoke(del, New Object() {True})
			Else
				Me.Invalidate(True)
			End If
			'Me.Refresh()
		End Set
	End Property

	Private Sub S_Meter_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

		'If InvokeRequired Then
		'	Dim del As New S_Meter_PaintDelegate(AddressOf S_Meter_Paint)
		'	Invoke(del, New Object() {sender, e})
		'End If

        If Me.Minimum >= Me.Maximum Then
            Throw New ApplicationException("MinValue cannot be greater or equal to MaxValue.")
        End If

		Dim bars As Integer
		bars = Convert.ToInt32((Me.Value - Me.Minimum) * _numberOfBars / (Me.Maximum - Me.Minimum))

		'Select Case Me.Value
		'	Case Is < 56
		'		bars = 0
		'	Case 56 To 60
		'		bars = 1
		'	Case 61 To 80
		'		bars = 2
		'	Case 81 To 95
		'		bars = 3
		'	Case 96 To 125
		'		bars = 4
		'	Case 126 To 140
		'		bars = 5
		'	Case Is > 140
		'		bars = 6
		'End Select

		For Each c As Control In Me.Controls
			If c.GetType.Name = "Panel" Then
				If Convert.ToInt32(c.Tag) <= bars Then
					c.BackColor = OnColor
				Else
					c.BackColor = OffColor
				End If
			End If
		Next

	End Sub

	'Private Delegate Sub S_Meter_PaintDelegate(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
	Private Delegate Sub InvalidateDelegate(ByVal invalidateChildren As Boolean)

End Class

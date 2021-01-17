
Imports UnidenCommander.Utils

Public Class Display

    Private _mode As New Scanner.ScannerMode("NO MODE", "Mode not set")
    Private _channel As Integer = 0
    Private _modulation As Scanner.Modulations = Scanner.Modulations.NA
    Private _frequency As Integer = 0
    Private _signalStrength As Integer
    Private _muted As Scanner.ScannerBoolean
    Private _attenuated As Scanner.ScannerBoolean
    Private _stepSize As Scanner.StepSizes

    Private _line1, _line2, _line3, _line4 As String
    Private _lockedout, _priority As Boolean
    Private UpdateRequired As Boolean

    Public WriteOnly Property Mode() As Scanner.ScannerMode
        Set(ByVal value As Scanner.ScannerMode)
            _mode = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Channel() As Nullable(Of Integer)
        Set(ByVal value As Nullable(Of Integer))
            If value.HasValue Then
                _channel = value.Value
            Else
                _channel = 0
            End If
            UpdateRequired = True
        End Set
    End Property

    Public WriteOnly Property Modulation() As Scanner.Modulations
        Set(ByVal value As Scanner.Modulations)
            _modulation = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Frequency() As Integer
        Set(ByVal value As Integer)
            _frequency = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Line1() As String
        Set(ByVal value As String)
            _line1 = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Line2() As String
        Set(ByVal value As String)
            _line2 = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Line3() As String
        Set(ByVal value As String)
            _line3 = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Line4() As String
        Set(ByVal value As String)
            _line4 = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property LockOut() As Boolean
        Set(ByVal value As Boolean)
            _lockedout = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property SignalStrength() As Integer
        Set(ByVal value As Integer)
            _signalStrength = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Muted() As Scanner.ScannerBoolean
        Set(ByVal value As Scanner.ScannerBoolean)
            _muted = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Attenuated() As Scanner.ScannerBoolean
        Set(ByVal value As Scanner.ScannerBoolean)
            _attenuated = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Priority() As Boolean
        Set(ByVal value As Boolean)
            _priority = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property StepSize() As Scanner.StepSizes
        Set(ByVal value As Scanner.StepSizes)
            _stepSize = value
            UpdateRequired = True
        End Set
    End Property
    Public WriteOnly Property Direction() As Scanner.ScanDirections
        Set(ByVal value As Scanner.ScanDirections)
            Throw New NotImplementedException
        End Set
    End Property
    Public Sub SetWindowVoltage(ByVal value As Integer)
        Logger.Trace(Me, String.Format("WindowVoltage(InvokeRequired={0}, Value={1})", InvokeRequired, value.ToString))

        If InvokeRequired Then
            Dim del As New SetWindowVoltageDelegate(AddressOf SetWindowVoltage)
            Invoke(del, New Object() {value})
        End If

        ' |---+---|
        Dim max As Integer = 120
        Dim min As Integer = 80
        Dim dashes As Integer = 13
        Dim wi As Integer = Convert.ToInt32((value - min) * dashes / (max - min))

        If wi < 1 Then wi = 1
        If wi > dashes Then wi = dashes

        Dim result As String
        result = "|"
        For i As Integer = 1 To dashes
            If i = wi Then
                result += "+"
            Else
                result += "-"
            End If
        Next
        result += "|"

        Me.txtCenter.Text = result

    End Sub

    'Public WriteOnly Property Lines() As String()
    '	Set(ByVal value As String())
    '		Logger.Trace(Me, "Lines")

    '		If value.Length = 4 Then

    '			Me.txtLine1.Text = value(0)
    '			Me.txtLine2.Text = value(1)
    '			Me.txtLine3.Text = value(2)
    '			Me.txtLine4.Text = value(3)

    '		Else

    '			Me.txtLine1.Text = "Error:"
    '			Me.txtLine2.Text = "Inconsistent"
    '			Me.txtLine3.Text = "no. of lines"
    '			Me.txtLine4.Text = ""

    '		End If

    '	End Set
    'End Property

    Public Sub Reset()
        Logger.Trace(Me, "Reset")

        'clear all data
        Me.txtLine1.Text = String.Empty
        Me.txtLine2.Text = String.Empty
        Me.txtLine3.Text = "Welcome to"
        Me.txtLine4.Text = "UnidenCommander"

        Me.SignalStrength = 0
        Me.SetWindowVoltage(100)

        Me.txtMuted.ForeColor = Color.Orange
        Me.txtAttuanted.ForeColor = Color.Orange
        Me.txtLockedOut.ForeColor = Color.Orange
        Me.txtPriority.ForeColor = Color.Orange

    End Sub

    Public Sub RefreshDisplay()

        If Not UpdateRequired Then Exit Sub

        If InvokeRequired Then
            Dim del As New SubDelegate(AddressOf RefreshDisplay)
            Invoke(del)
        End If

        Logger.Trace(Me, String.Format("RefreshDisplay(InvokeRequired={0})", InvokeRequired.ToString))

        SetLine1()
        SetLine2()
        SetLine3()
        SetLine4()

        Me.S_Meter1.Value = _signalStrength
        Me.txtMuted.ForeColor = Tools.IIf(Of Color)(_muted = Scanner.ScannerBoolean.On, Color.Black, Color.Orange)
        Me.txtAttuanted.ForeColor = Tools.IIf(Of Color)(_attenuated = Scanner.ScannerBoolean.On, Color.Black, Color.Orange)
        Me.txtLockedOut.ForeColor = Tools.IIf(Of Color)(_lockedout, Color.Black, Color.Orange)
        Me.txtPriority.ForeColor = Tools.IIf(Of Color)(_priority, Color.Black, Color.Orange)

        Me.txtStepSize.Text = _stepSize.ToString.Substring(4).Replace("_", ".") ' remove "Step" from name

        UpdateRequired = False

    End Sub

	''' <summary>
	''' Sets the first line in the display.
	''' </summary>
	Private Sub SetLine1()

		If InvokeRequired Then
			Dim del As New SubDelegate(AddressOf SetLine1)
			Invoke(del)
		End If

		Dim md As String = _mode.ShortName
		Dim ch As String = _channel.ToString("D3")

		'If String.IsNullOrEmpty(md) Then md = "EMPTY MODE"
		If String.IsNullOrEmpty(ch) Then ch = "---"

		' limit mode length to 12 chars
		If md.Length >= 12 Then md = md.Substring(0, 12)

		Me.txtLine1.Text = String.Format("{0} C{1}", md.PadRight(12, " "c), ch)

	End Sub

	''' <summary>
	''' Sets the second line in the display.
	''' </summary>
	Private Sub SetLine2()

		If InvokeRequired Then
			Dim del As New SubDelegate(AddressOf SetLine2)
			Invoke(del)
		End If

		Me.txtLine2.Text = String.Format("{0}{1}", (_frequency / 10000).ToString("F4").PadLeft(9, " "c), _modulation.ToString.PadLeft(4, " "c))

	End Sub

	Private Sub SetLine3()

		If InvokeRequired Then
			Dim del As New SubDelegate(AddressOf SetLine3)
			Invoke(del)
		End If

		Me.txtLine3.Text = _line3

	End Sub

	Private Sub SetLine4()

		If InvokeRequired Then
			Dim del As New SubDelegate(AddressOf SetLine4)
			Invoke(del)
		End If

		Me.txtLine4.Text = _line4

	End Sub

	Private Delegate Sub SubDelegate()
	Private Delegate Sub SetWindowVoltageDelegate(ByVal value As Integer)

End Class

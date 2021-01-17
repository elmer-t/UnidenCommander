
Imports System.Text.RegularExpressions

Namespace Scanner.Models

	Public Class BaseScannerModel

		Protected Connection As Connection
		Public CommandSet As CommandSets.ICommandSet
		Public CommandQueue As New Collections.Generic.Queue(Of Command)

		' scanner info variables
		Public Version As String = String.Empty
		Public KeyPad As New KeyPads.GenericKeyPad
		Public ConnectionPort As String
		Public ConnectionSpeed As Integer

		' scanner state variables
		Public IsConnected As Boolean = False

		' events
		Public Event CommandTimeoutEvent(ByVal e As EventArgs)
		Public Event DataReceived(ByVal data As Command)
		Public Event PropertyChanged(ByVal prop As Properties)
		Public Event LastCommandExecuted(ByVal e As EventArgs)

        Public Sub New(ByVal model As ScannerModels)

            Me.Connection = New Connection
            Me.SetModel(model)

        End Sub

		Public Sub Connect()

			Try

				AddHandler Me.Connection.ConnectionTimeout, AddressOf OnConnectionTimeout
				AddHandler Me.Connection.DataReceived, AddressOf Me.OnDataReceived

				Me.Connection.Initialize() ' hook up events etc
				Me.Connection.Port = Me.ConnectionPort
				Me.Connection.Speed = Me.ConnectionSpeed

                If Me.Connection.Open() Then Me.IsConnected = True

			Catch ex As Exception
				Throw
			End Try

		End Sub

		Public Sub Disconnect()
			Logger.Trace(Me, "Disconnect")

			' Remove event handlers
			RemoveHandler Me.Connection.DataReceived, AddressOf Me.OnDataReceived

			' Close connection to scanner
			If Me.Connection IsNot Nothing Then Me.Connection.Close()

			' Reset variables
			Me.CommandQueue.Clear()

			' Set status variable
			Me.IsConnected = False

		End Sub

		Public Sub ExecuteCommand(ByVal cmd As Command)
			Me.Connection.SendCommand(cmd)
		End Sub

		Private Sub OnDataReceived(ByVal cmd As Command)
            Logger.Trace(Me, String.Format("OnDataReceived(Name={0}, Response={1}, IsLast={2})", cmd.Command, cmd.Response, cmd.IsLastInQueue))

            Try

                If Not cmd.ResponseHandlerDelegate Is Nothing Then
                    cmd.ResponseHandlerDelegate.Method.Invoke(CommandSet, New Object() {cmd.Response})
                End If

                If cmd.IsLastInQueue Then RaiseEvent LastCommandExecuted(Nothing)
                RaiseEvent DataReceived(cmd)

            Catch ex As System.Reflection.TargetInvocationException

                If ex.InnerException.GetType Is GetType(Exceptions.InvalidResponseException) Then
                    Throw ex.InnerException
                Else
                    Throw
                End If

            Catch ex As Exception
                Throw
            End Try

        End Sub

		Private Sub OnConnectionTimeout(ByVal e As EventArgs)
			Me.IsConnected = False
			RaiseEvent CommandTimeoutEvent(e)
		End Sub

#Region " Scanner state properties "

        ' +-----------------------------------------------+
        '   Private properties
        ' +-----------------------------------------------+
        Private _Attenuated As ScannerBoolean
        Private _Channel As Integer
        Private _Frequency As Integer
        Private _Line1 As String
        Private _Line2 As String
        Private _Line3 As String
        Private _Line4 As String
        Private _Mode As Scanner.ScannerMode
        Private _Model As Scanner.ScannerModels
        Private _Modulation As Scanner.Modulations
        Private _Muted As ScannerBoolean
        Private _PriorityScan As Boolean
        Private _Banks As New Dictionary(Of Char, Bank)
        Private _ScanDirection As Scanner.ScanDirections
        'Private _SearchBanks As New Dictionary(Of Char, Bank)
        Private _SquelchOpen As Boolean
        Private _SignalStrength As Integer
        Private _StepSize As StepSizes
        Private _SystemInformation As SystemInformation
        Private _WindowVoltage As Integer

        ' +-----------------------------------------------+
        '   Write properties
        ' +-----------------------------------------------+
        Protected Friend Sub SetAttenuated(ByVal value As ScannerBoolean) ' Implements IScannerModel.SetAttenuated
            _Attenuated = value
            RaiseEvent PropertyChanged(Properties.Attenuated)
        End Sub
        Protected Friend Sub SetChannel(ByVal value As Integer) ' Implements IScannerModel.SetChannel
            _Channel = value
            RaiseEvent PropertyChanged(Properties.Channel)
        End Sub
        Protected Friend Sub SetFrequency(ByVal value As Integer) ' Implements IScannerModel.SetFrequency
            _Frequency = value
            RaiseEvent PropertyChanged(Properties.Frequency)
        End Sub
        Protected Friend Sub SetLCDLine1(ByVal value As String) ' Implements IScannerModel.SetLCDLine1
            _Line1 = value
            RaiseEvent PropertyChanged(Properties.Line1)
        End Sub
        Protected Friend Sub SetLCDLine2(ByVal value As String) ' Implements IScannerModel.SetLCDLine2
            _Line2 = value
            RaiseEvent PropertyChanged(Properties.Line2)
        End Sub
        Protected Friend Sub SetLCDLine3(ByVal value As String) ' Implements IScannerModel.SetLCDLine3
            _Line3 = value
            RaiseEvent PropertyChanged(Properties.Line3)
        End Sub
        Protected Friend Sub SetLCDLine4(ByVal value As String) ' Implements IScannerModel.SetLCDLine4
            _Line4 = value
            RaiseEvent PropertyChanged(Properties.Line4)
        End Sub
        Protected Friend Sub SetMode(ByVal value As Scanner.ScannerMode) ' Implements IScannerModel.SetMode
            _Mode = value
            RaiseEvent PropertyChanged(Properties.Mode)
        End Sub
        Protected Friend Sub SetModel(ByVal value As Scanner.ScannerModels) ' Implements IScannerModel.SetModel
            _Model = value

            Select Case Me.Model
                Case ScannerModels.BC780
                    Me.KeyPad = New KeyPads.BC780KeyPad
                    Me.CommandSet = New CommandSets.BC780CommandSet

                Case ScannerModels.BC785
                    Me.KeyPad = New KeyPads.BC785KeyPad
                    Me.CommandSet = New CommandSets.BC785CommandSet

                Case ScannerModels.Generic
                    Me.KeyPad = New KeyPads.GenericKeyPad
                    Me.CommandSet = New CommandSets.GenericCommandSet

                Case Else
                    Throw New Scanner.Exceptions.ScannerNotSupportedException(Me.Model.ToString)

            End Select

            Me.CommandSet.ScannerReference = Me

            RaiseEvent PropertyChanged(Properties.Model)
        End Sub
        Protected Friend Sub SetModulation(ByVal value As Scanner.Modulations)  ' Implements IScannerModel.SetModulation
            _Modulation = value
            RaiseEvent PropertyChanged(Properties.Modulation)
        End Sub
        Protected Friend Sub SetMuted(ByVal value As ScannerBoolean) ' Implements IScannerModel.SetMuted
            _Muted = value
            RaiseEvent PropertyChanged(Properties.Muted)
        End Sub
        Protected Friend Sub SetPriorityScan(ByVal value As Boolean) ' Implements IScannerModel.SetPriorityScan
            _PriorityScan = value
            RaiseEvent PropertyChanged(Properties.PriorityScan)
        End Sub
        Protected Friend Sub SetBank(ByVal bank As Char, ByVal value As Bank)    ' Implements IScannerModel.SetScanBanks
            _Banks(bank) = value
            RaiseEvent PropertyChanged(Properties.Banks)
        End Sub
        Protected Friend Sub SetScanDirection(ByVal value As Scanner.ScanDirections) ' Implements IScannerModel.SetScanDirection
            _ScanDirection = value
            RaiseEvent PropertyChanged(Properties.ScanDirection)
        End Sub
        'Protected Friend Sub SetSearchBank(ByVal bank As Char, ByVal value As Bank) ' Implements IScannerModel.SetSearchBanks
        '    _SearchBanks(bank) = value
        '    RaiseEvent PropertyChanged(Properties.SearchBanks)
        'End Sub
        Protected Friend Sub SetSignalStrength(ByVal value As Integer)  ' Implements IScannerModel.SetSignalStrength
            _SignalStrength = value
            RaiseEvent PropertyChanged(Properties.SignalStrength)
        End Sub
        Protected Friend Sub SetSquelchOpen(ByVal value As Boolean) ' Implements IScannerModel.SetSquelchOpen
            _SquelchOpen = value
            RaiseEvent PropertyChanged(Properties.SquelchOpen)
        End Sub
        Protected Friend Sub SetStepSize(ByVal value As StepSizes)  ' Implements IScannerModel.SetStepSize
            _StepSize = value
            RaiseEvent PropertyChanged(Properties.StepSize)
        End Sub
        Protected Friend Sub SetSystemInformation(ByVal value As SystemInformation) ' Implements IScannerModel.SetSystemInformation
            _SystemInformation = value
            RaiseEvent PropertyChanged(Properties.SystemInformation)
        End Sub
        Protected Friend Sub SetWindowVoltage(ByVal value As Integer)
            _WindowVoltage = value
            RaiseEvent PropertyChanged(Properties.WindowVoltage)
        End Sub

        ' +-----------------------------------------------+
        '   Read properties
        ' +-----------------------------------------------+
        Public ReadOnly Property Attenuated() As ScannerBoolean 'Implements IScannerModel.Attenuated
            Get
                Return _Attenuated
            End Get
        End Property
        Public ReadOnly Property Channel() As Integer ' Implements IScannerModel.Channel
            Get
                Return _Channel
            End Get
        End Property
        Public ReadOnly Property Frequency() As Integer ' Implements IScannerModel.Frequency
            Get
                Return _Frequency
            End Get
        End Property
        Public ReadOnly Property Line1() As String ' Implements IScannerModel.LCDLine1
            Get
                Return _Line1
            End Get
        End Property
        Public ReadOnly Property Line2() As String ' Implements IScannerModel.LCDLine2
            Get
                Return _Line2
            End Get
        End Property
        Public ReadOnly Property Line3() As String ' Implements IScannerModel.LCDLine3
            Get
                Return _Line3
            End Get
        End Property
        Public ReadOnly Property Line4() As String ' Implements IScannerModel.LCDLine4
            Get
                Return _Line4
            End Get
        End Property
        Public ReadOnly Property Mode() As ScannerMode  ' Implements IScannerModel.Mode
            Get
                Return _Mode
            End Get
        End Property
        Public ReadOnly Property Model() As ScannerModels ' Implements IScannerModel.Model
            Get
                Return _Model
            End Get
        End Property
        Public ReadOnly Property Modulation() As Modulations ' Implements IScannerModel.Modulation
            Get
                Return _Modulation
            End Get
        End Property
        Public ReadOnly Property Muted() As ScannerBoolean ' Implements IScannerModel.Muted
            Get
                Return _Muted
            End Get
        End Property
        Public ReadOnly Property PriorityScan() As Boolean ' Implements IScannerModel.PriorityScan
            Get
                Return _PriorityScan
            End Get
        End Property
        Public ReadOnly Property Banks() As Dictionary(Of Char, Bank) ' Implements IScannerModel.ScanBanks
            Get
                Return _Banks
            End Get
        End Property
        Public ReadOnly Property ScanDirection() As ScanDirections ' Implements IScannerModel.ScanDirection
            Get
                Return _ScanDirection
            End Get
        End Property
        'Public ReadOnly Property SearchBanks() As Dictionary(Of Char, Bank) ' Implements IScannerModel.SearchBanks
        '    Get
        '        Return _SearchBanks
        '    End Get
        'End Property
        Public ReadOnly Property SignalStrength() As Integer ' Implements IScannerModel.SignalStrength
            Get
                Return _SignalStrength
            End Get
        End Property
        Public ReadOnly Property SquelchOpen() As Boolean ' Implements IScannerModel.SquelchOpen
            Get
                Return _SquelchOpen
            End Get
        End Property
        Public ReadOnly Property StepSize() As StepSizes ' Implements IScannerModel.StepSize
            Get
                Return _StepSize
            End Get
        End Property
        Public ReadOnly Property SystemInformation() As SystemInformation ' Implements IScannerModel.SystemInformation
            Get
                Return _SystemInformation
            End Get
        End Property
        Public ReadOnly Property WindowVoltage() As Integer
            Get
                Return _WindowVoltage
            End Get
        End Property

#End Region

	End Class

End Namespace

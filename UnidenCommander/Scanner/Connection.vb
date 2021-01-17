
Imports System.IO.Ports
Imports System.Threading

Namespace Scanner

	Public Class Connection

		Public Port As String
		Public Speed As Integer

		Protected Serial As SerialPort = New SerialPort
		Protected CommandTimeoutTimer As System.Threading.Timer	' time-out timer
		Protected ExecutedCommands As Collections.Generic.Queue(Of Command)

		Friend Buffer As String
		Friend Response As String

		Public Event SerialCommandExecuting(ByVal command As String)
		Public Event DataReceived(ByVal data As Command)
		Public Event ConnectionTimeout(ByVal e As EventArgs)

		Public Sub New()
		End Sub

		Public Sub New(ByVal port As String, ByVal speed As Integer)
			Logger.Trace(Me, "New")

			Me.Port = port
			Me.Speed = speed

		End Sub

		Public Sub Initialize()
			Logger.Trace(Me, "Initialize")

			' Reset params
			Buffer = String.Empty
			Response = String.Empty
			ExecutedCommands = New Collections.Generic.Queue(Of Command)

			' Set time-out timer
			CommandTimeoutTimer = New System.Threading.Timer( _
			 New TimerCallback(AddressOf CommandTimeoutCallback), _
			 Nothing, _
			 My.Settings.ConnectionTimeout, _
			 Timeout.Infinite _
			)

			'execution = New ParameterizedThreadStart(AddressOf ThreadStartMethod)

		End Sub

		Public Function Open() As Boolean
			Logger.Trace(Me, "Open")

			If (String.IsNullOrEmpty(Port)) Then
				Throw New ArgumentNullException("Port")
			End If
			If (Speed <= 0) Then
				Throw New ArgumentOutOfRangeException("Speed", Speed, "Not a valid serial port baud rate.")
			End If

			Try

				AddHandler Me.Serial.DataReceived, AddressOf SerialPort_DataReceived

				Serial.PortName = Port
				Serial.StopBits = System.IO.Ports.StopBits.One
				Serial.Parity = System.IO.Ports.Parity.None
				Serial.BaudRate = Speed
				
				Serial.Open()

				Return True

			Catch
				Throw
			End Try

		End Function

		Public Function Close() As Boolean
			Logger.Trace(Me, "Close")

			If Serial IsNot Nothing Then

				RemoveHandler Me.Serial.DataReceived, AddressOf SerialPort_DataReceived
				CommandTimeoutTimer.Change(Timeout.Infinite, Timeout.Infinite)

				Me.Buffer = String.Empty

                If Me.Serial.IsOpen Then
                    Me.Serial.DiscardInBuffer()
                    Me.Serial.DiscardOutBuffer()
                End If

				Me.Serial.Close()

				Return True

			End If

			Return False

		End Function

		Public ReadOnly Property IsOpen() As Boolean
			Get
				Return Serial.IsOpen
			End Get
		End Property

		''' <summary>
		''' Sends the command. A newline char is padded to the end.
		''' </summary>
		''' <param name="command">The command.</param>
		Public Sub SendCommand(ByVal command As Command)
            Logger.Trace(Me, String.Format("SendCommand(Name={0}, IsLast={1})", command.Command, command.IsLastInQueue))

            If Serial.IsOpen Then

                ' Reset timeout timer
                CommandTimeoutTimer.Change(My.Settings.ConnectionTimeout, Timeout.Infinite)

                Me.ExecutedCommands.Enqueue(command)
                Serial.Write(command.Command & Convert.ToChar(13))

            End If

		End Sub

		Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
			Logger.Trace(Me, "SerialPort_DataReceived")

			' Reset timeout timer
			CommandTimeoutTimer.Change(Timeout.Infinite, Timeout.Infinite)

			' Buffer string data
			Buffer += Serial.ReadExisting()
			ProcessBuffer(Buffer)

		End Sub

		Private Sub ProcessBuffer(ByVal buffer As String)
			Logger.Trace(Me, String.Format("ProcessBuffer(Buffer={0})", buffer.Replace(Convert.ToChar(13), "\n")))

			' Look in the string for useful information
			' then remove the useful data from the buffer
			While buffer.IndexOf(Convert.ToChar(13)) > -1

				Response = buffer.Substring(0, buffer.IndexOf(Convert.ToChar(13)))
				Me.Buffer = buffer.Substring(buffer.IndexOf(Convert.ToChar(13)) + 1)
				buffer = Me.Buffer

				Dim cmd As Command = ExecutedCommands.Dequeue
				cmd.Response = Response
				RaiseEvent DataReceived(cmd)

			End While

		End Sub

		''' <summary>
		''' Callback method when command times out
		''' </summary>
		''' <param name="state"></param>
		''' <remarks></remarks>
		Private Sub CommandTimeoutCallback(ByVal state As Object)

			' Stop time-out timer
			Me.CommandTimeoutTimer.Change(Timeout.Infinite, Timeout.Infinite)

			' Close connection
			If Not Me.Serial Is Nothing Then Me.Serial.Close()

			' Bubble event to all who listen
			RaiseEvent ConnectionTimeout(New EventArgs)

		End Sub

	End Class

End Namespace

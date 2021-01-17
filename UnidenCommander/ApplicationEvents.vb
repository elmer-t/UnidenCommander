
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Imports UnidenCommander.Utils

Namespace My

	' The following events are available for MyApplication:
	' 
	' Startup: Raised when the application starts, before the startup form is created.
	' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	' UnhandledException: Raised if the application encounters an unhandled exception.
	' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	Partial Friend Class MyApplication

        Dim stream As FileStream
        Dim listener As TextWriterTraceListener

        Public Sub ApplicationStartup() Handles Me.Startup

            ' Enable visual styles if OS supports them
            If VisualStyles.VisualStyleInformation.IsSupportedByOS = False _
                OrElse VisualStyles.VisualStyleInformation.IsEnabledByUser = False Then

                My.Application.EnableVisualStyles = False
            End If

            ' Reset log file
            If System.IO.File.Exists(My.Settings.LogSerialCommandsPath) Then
                System.IO.File.Delete(My.Settings.LogSerialCommandsPath)
            End If

            ' Reset trace file
            If System.IO.File.Exists(My.Settings.LogTracePath) Then
                System.IO.File.Delete(My.Settings.LogTracePath)
            End If

            If My.Settings.LogTrace Then
                Try
                    stream = New FileStream(My.Settings.LogTracePath, FileMode.OpenOrCreate)
                    listener = New TextWriterTraceListener(stream)
                    Trace.Listeners.Add(listener)
                Catch ex As DirectoryNotFoundException
                    MessageBox.Show("Cannot find path to store debug log. Please go to the settings screen and adjust your settings. Debug logging will be turned off.", "Path not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    My.Settings.LogTrace = False
                End Try
            End If

            ' Set shared settings
            Logger.LogSerialCommands = My.Settings.LogSerialCommands
            Logger.LogSerialCommandsPath = My.Settings.LogSerialCommandsPath

            ' Log settings
            Logger.Trace(Me, "Version=" & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
            Logger.Trace(Me, "ConnectionTimeout=" & My.Settings.ConnectionTimeout)
            Logger.Trace(Me, "FirstLoadWaitTime=" & My.Settings.FirstLoadWaitTime)
            Logger.Trace(Me, "LogCommunications=" & My.Settings.LogSerialCommands)
            Logger.Trace(Me, "LogCommunicationsFilename=" & My.Settings.LogSerialCommandsPath)
            Logger.Trace(Me, "Port=" & My.Settings.Port)
            Logger.Trace(Me, "Speed=" & My.Settings.Speed)
            Logger.Trace(Me, "SaveTrace=" & My.Settings.LogTrace)
            Logger.Trace(Me, "TraceLogFilename=" & My.Settings.LogTracePath)

            Logger.Trace(Me, Nothing)

        End Sub

        Public Sub ApplicationShutdown() Handles Me.Shutdown

            Try

                Trace.Listeners.Remove(listener)
                Trace.Flush()
                Logger.FlushTraceBuffer()
                stream.Close()

                Logger.FlushLogBuffer()

            Catch ex As Exception
            End Try

        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            If e.Exception.GetType Is GetType(UnidenCommander.Scanner.Exceptions.InvalidResponseException) Then
                MessageBox.Show("Received invalid response from the scanner, the command will be ignored. Original message: " & e.Exception.Message, "Invalid response", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim d As New ErrorDialog
                d.Exception = e.Exception
                d.ShowDialog()

            End If

        End Sub

    End Class

End Namespace


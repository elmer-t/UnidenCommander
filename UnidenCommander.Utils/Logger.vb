
Imports System.IO
Imports System.Xml

Public Class Logger


    ' todo: buffer to cache log lines
    '       flush function to empty buffer to disk

    Public Shared LogSerialCommandsPath As String
    Public Shared LogSerialCommands As Boolean

    Private Const TimeFormatString As String = "yyyy-MM-dd HH:mm:ss.fff"

    Private Shared LogBuffer As New System.Collections.Queue(100)
    Private Shared TraceBuffer As New System.Collections.Queue(100)
    Private Const MaxBufferSize As Integer = 100
    Private Const UseBuffer As Boolean = True

    ''' <summary>
    ''' Saves message to trace (debug) log.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="message">The message.</param>
    Public Shared Sub Trace(ByVal sender As Object, ByVal message As String)

        If Not sender Is Nothing Then

            If message Is Nothing Then message = "[MESSAGE=NOTHING]"

            Dim t As Type = sender.GetType
            Dim line As String = String.Format("{0} {1}.{2}.{3}", System.DateTime.Now.ToString(TimeFormatString), t.Namespace, t.Name, message)

            If UseBuffer Then

                TraceBuffer.Enqueue(line)

                If TraceBuffer.Count >= MaxBufferSize Then
                    FlushTraceBuffer()
                End If

            Else
                System.Diagnostics.Trace.WriteLine(line)
            End If

        End If

    End Sub

    Public Shared Sub FlushTraceBuffer()

        While TraceBuffer.Count > 0
            System.Diagnostics.Trace.WriteLine(TraceBuffer.Dequeue)
        End While

    End Sub

    Public Shared Sub FlushLogBuffer()

        ' Create or open file
        Using fs As FileStream = New FileStream(LogSerialCommandsPath, FileMode.OpenOrCreate, FileAccess.Write)

            Using writer As StreamWriter = New StreamWriter(fs)

                While LogBuffer.Count > 0

                    ' Write line, including timestamp
                    writer.BaseStream.Seek(0, SeekOrigin.End) ' set pointer to end of file
                    writer.WriteLine(LogBuffer.Dequeue)

                End While

                writer.Flush()

            End Using

        End Using

    End Sub

    ''' <summary>
    ''' Saves message to serial communications log.
    ''' </summary>
    ''' <param name="Message">The message.</param>
    Public Shared Sub Log(ByVal Message As String)

        Try

            If LogSerialCommands = False Then Exit Sub

            LogBuffer.Enqueue(String.Format("{0} {1}", System.DateTime.Now.ToString(TimeFormatString), Message))

            If UseBuffer Then

                If LogBuffer.Count >= MaxBufferSize Then
                    FlushLogBuffer()
                End If

            Else
                FlushLogBuffer()
            End If

        Catch ex As DirectoryNotFoundException

            Throw

        End Try

    End Sub

    'Public Shared Sub SaveReception(ByVal scanner As UnidenCommander.Scanner.Models.BaseScannerModel)

    '    Try

    '        If My.Settings.LogReceptions = False Then Exit Sub

    '        ' Create or open file
    '        Using fs As FileStream = New FileStream(My.Settings.LogReceptionsPath, FileMode.OpenOrCreate, FileAccess.Write)

    '            Using writer As StreamWriter = New StreamWriter(fs)

    '                ' Write line, including timestamp
    '                writer.BaseStream.Seek(0, SeekOrigin.End) ' set pointer to end of file
    '                writer.WriteLine( _
    '                    "{0}\t{1}\t{2}\t{3}\t{4}\t{5} {6}".Replace("\t", Convert.ToChar(9)), _
    '                    System.DateTime.Now.ToString(TimeFormatString), _
    '                    scanner.Frequency.ToString, _
    '                    scanner.Channel.ToString, _
    '                    scanner.Modulation.ToString, _
    '                    scanner.SignalStrength.ToString, _
    '                    scanner.Line3, scanner.Line4 _
    '                )
    '                writer.Flush()

    '            End Using

    '        End Using

    '    Catch ex As DirectoryNotFoundException

    '        MessageBox.Show( _
    '            "Cannot find path to reception log file. " & _
    '            "Please go to the settings screen and adjust your settings. " & _
    '            "Logging will be turned off.", _
    '            "Path not found", _
    '            MessageBoxButtons.OK, _
    '            MessageBoxIcon.Warning _
    '        )
    '        My.Settings.LogSerialCommands = False

    '    End Try

    'End Sub

    'Private Shared receptions As XmlDocument

    'Public Shared Sub SaveReception(ByVal scanner As UnidenCommander.Scanner.Models.BaseScannerModel)

    '    Dim rootNode, node As XmlElement

    '    If receptions Is Nothing Then

    '        ' Create document
    '        receptions = New XmlDocument
    '        Dim decl As XmlDeclaration = receptions.CreateXmlDeclaration("1.0", Nothing, Nothing)

    '        ' Create root element
    '        rootNode = receptions.CreateElement("UnidenCommander")
    '        receptions.InsertBefore(decl, receptions.DocumentElement)
    '        receptions.AppendChild(rootNode)

    '        node = receptions.CreateElement("Receptions")
    '        rootNode.AppendChild(node)

    '    End If

    '    Dim current As XmlElement = receptions.CreateElement("Reception")

    '    node = receptions.CreateElement("Date")
    '    node.InnerText = Date.Now.ToString
    '    current.AppendChild(node)

    '    node = receptions.CreateElement("Frequency")
    '    node.InnerText = scanner.Frequency.ToString
    '    current.AppendChild(node)

    '    receptions.Save(My.Settings.LogReceptionsPath)

    'End Sub

End Class

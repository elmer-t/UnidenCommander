
'Imports System.Text.RegularExpressions

'Namespace Scanner.CommandSets

'    <Obsolete("Use Scanner.Commands. classes from now on", True)> _
'    Public Class ScannerCommandSet780
'        Inherits CommandSetGeneric

'        Public Sub New(ByVal connection As Connection)
'            MyBase.New(connection)
'        End Sub

'        ' todo: override base methods that are specific to the BC780

'        Protected Overrides Sub FillScannerModes()
'            MyBase.FillScannerModes()

'            ScannerModes(0) = "Scanning"
'            ScannerModes(1) = "Manual"
'            ScannerModes(2) = "Limit Search"
'            ScannerModes(3) = "Limit Search Hold"
'            ScannerModes(4) = "Service Search"
'            ScannerModes(5) = "Unknown"
'            ScannerModes(6) = "Motorola Trunk Frequency Program"
'            ScannerModes(7) = "Unknown"
'            ScannerModes(8) = "Rotary Tune Frequency"
'            ScannerModes(9) = "Motorola ID Search"
'            ScannerModes(10) = "Motorola ID Search Hold"
'            ScannerModes(11) = "Motorola ID Scan"
'            ScannerModes(12) = "Motorola ID Manual"
'            ScannerModes(13) = "EDACS srch" ' "EDACS ID Search"
'            ScannerModes(14) = "EDACS hold" '"EDACS ID Hold"
'            ScannerModes(15) = "EDACS scan" '"EDACS ID Scan"
'            ScannerModes(16) = "EDACS man" '"EDACS ID Manual"
'            ScannerModes(17) = "LTR Search"
'            ScannerModes(18) = "LTR Hold"
'            ScannerModes(19) = "LTR Scan"
'            ScannerModes(20) = "LTR Manual"
'            ScannerModes(21) = "Unknown"

'        End Sub

'        Public Overrides Function Channel() As Nullable(Of Integer)
'            'cn.ExecuteCommand("LCD CHN")
'            ' response = CHN [123]
'            Dim response As String = cn.Response
'            response = Regex.Match(response, "\[\s*(\d{3})\s*\]").Groups(1).Value

'            If String.IsNullOrEmpty(response) Then
'                Return Nothing
'            Else
'                Dim ch As Integer
'                If Integer.TryParse(response, ch) Then
'                    Return ch
'                Else
'                    Return Nothing
'                End If
'            End If

'        End Function

'        Public Overrides Function LCDLines() As String()

'            Dim response(1) As String

'            'cn.ExecuteCommand("LCD LINE 1")
'            response(0) = GetLine(cn.Response)

'            'cn.ExecuteCommand("LCD LINE 2")
'            response(1) = GetLine(cn.Response)

'            Return response

'        End Function

'    End Class

'End Namespace


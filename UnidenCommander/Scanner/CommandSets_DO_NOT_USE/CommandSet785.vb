
'Imports System.Text.RegularExpressions

'Namespace Scanner.CommandSets

'    <Obsolete("Use Scanner.Commands. classes from now on", True)> _
'    Public Class ScannerCommandSet785
'        Inherits CommandSetGeneric

'        Public Sub New(ByVal connection As Connection)
'            MyBase.New(connection)
'        End Sub

'        ' todo: override base methods that are specific to the BC785

'        Protected Overrides Sub FillScannerModes()
'            MyBase.FillScannerModes()

'            ScannerModes(0) = "Scanning"
'            ScannerModes(1) = "Manual"
'            ScannerModes(2) = "Limit Search"
'            ScannerModes(3) = "Limit Search Hold"
'            ScannerModes(4) = "Air Search"
'            ScannerModes(5) = "Air Search Hold"
'            ScannerModes(6) = "Motorola Trunk Frequency Program"
'            ScannerModes(7) = "Unknown"
'            ScannerModes(8) = "Unknown"
'            ScannerModes(9) = "Unknown"
'            ScannerModes(10) = "Unknown"
'            ScannerModes(11) = "Unknown"
'            ScannerModes(12) = "Unknown"
'            ScannerModes(13) = "Unknown"
'            ScannerModes(14) = "Unknown"
'            ScannerModes(15) = "Unknown"
'            ScannerModes(16) = "Unknown"
'            ScannerModes(17) = "Unknown"
'            ScannerModes(18) = "Unknown"
'            ScannerModes(19) = "Unknown"
'            ScannerModes(20) = "Unknown"
'            ScannerModes(21) = "Unknown"

'        End Sub

'        Public Overrides Function Channel() As Nullable(Of Integer)
'            'cn.ExecuteCommand("LCD1")
'            Dim response As String = cn.Response ' LCD1 [SCAN  + C412 ][    ]
'            response = Regex.Match(response, "C\s*(\d{3})\s*\]").Groups(1).Value

'            ' get 3 digits between 'C' and ']'
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

'            Dim response(3) As String

'            'cn.ExecuteCommand("LCD1")
'            response(0) = GetLine(cn.Response)

'            'cn.ExecuteCommand("LCD2")
'            response(1) = GetLine(cn.Response)

'            'cn.ExecuteCommand("LCD3")
'            response(2) = GetLine(cn.Response)

'            'cn.ExecuteCommand("LCD4")
'            response(3) = GetLine(cn.Response)

'            Return response

'        End Function

'    End Class

'End Namespace


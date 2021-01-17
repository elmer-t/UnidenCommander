
'Imports System.Text.RegularExpressions

'Namespace Scanner.CommandSets

'    <Obsolete("Use Scanner.Commands. classes from now on", True)> _
'    Public Class CommandSetGeneric

'        Public ScannerModes As New Dictionary(Of Integer, String)
'        Protected cn As Connection

'        Public Sub New(ByVal connection As Connection)
'            If connection Is Nothing Then
'                Throw New ArgumentNullException("connection")
'            End If
'            cn = connection
'            FillScannerModes()
'        End Sub

'        Protected Overridable Sub FillScannerModes()
'            ScannerModes.Add(0, "Scanning")
'            ScannerModes.Add(1, "Manual")
'            ScannerModes.Add(2, "Limit Search")
'            ScannerModes.Add(3, "Limit Search Hold")
'            ScannerModes.Add(4, "Inconclusive")
'            ScannerModes.Add(5, "Inconclusive")
'            ScannerModes.Add(6, "Motorola Trunk Frequency Program")
'            ScannerModes.Add(7, "Inconclusive")
'            ScannerModes.Add(8, "Inconclusive")
'            ScannerModes.Add(9, "Inconclusive")
'            ScannerModes.Add(10, "Inconclusive")
'            ScannerModes.Add(11, "Inconclusive")
'            ScannerModes.Add(12, "Inconclusive")
'            ScannerModes.Add(13, "Inconclusive")
'            ScannerModes.Add(14, "Inconclusive")
'            ScannerModes.Add(15, "Inconclusive")
'            ScannerModes.Add(16, "Inconclusive")
'            ScannerModes.Add(17, "Inconclusive")
'            ScannerModes.Add(18, "Inconclusive")
'            ScannerModes.Add(19, "Inconclusive")
'            ScannerModes.Add(20, "Inconclusive")
'            ScannerModes.Add(21, "Inconclusive")
'            ScannerModes.Add(22, "Menu")
'        End Sub

'        Public Overridable Function ActivityIDWindow(ByVal bank As String, Optional ByVal state As ScannerBoolean = Nothing) As String
'            'cn.ExecuteCommand("AW")
'            Return cn.Response
'        End Function

'        Public Overridable Function AllClear() As String
'            'cn.ExecuteCommand("AC")
'            Return cn.Response
'        End Function

'        Public Overridable Function Attenuator(Optional ByVal state As ScannerBoolean = Nothing) As String
'            'cn.ExecuteCommand("AT" & Convert.ToChar(state))
'            Return cn.Response
'        End Function
'        Public Overridable Function AutoLight(Optional ByVal state As ScannerBoolean = Nothing) As String
'            Return "AL"
'        End Function
'        Public Overridable Function AutoRecording(Optional ByVal state As ScannerBoolean = Nothing) As String
'            Return "AR"
'        End Function
'        Public Overridable Function BatteryLife() As String
'            Return "BL"
'        End Function
'        Public Overridable Function BatteryMonitorReporting() As String
'            Return "BM"
'        End Function
'        Public Overridable Function BatterySave() As String
'            Return "BS"
'        End Function
'        Public Overridable Function BeepAlert() As String
'            Return "BA"
'        End Function
'        Public Overridable Function BeepSet() As String
'            Return "BP"
'        End Function
'        Public Overridable Function BitStatus() As String
'            Return "BT"
'        End Function
'        Public Overridable Function Channel() As Nullable(Of Integer)
'            Return Nothing
'        End Function
'        Public Overridable Function CTCSSCondition() As String
'            Return "CC"
'        End Function
'        Public Overridable Function CTCSSDetection() As String
'            Return "CD"
'        End Function
'        Public Overridable Function CTCSSSet() As String
'            Return "CS"
'        End Function
'        Public Overridable Function CTCSSTone() As String
'            Return "CT"
'        End Function
'        Public Overridable Function ChooseBanks() As String
'            Return "CB"
'        End Function
'        Public Overridable Function ConfirmBaseSpaceOffset() As String
'            Return "BC"
'        End Function
'        Public Overridable Function DataSkip() As String
'            Return "DS"
'        End Function
'        Public Overridable Function Delay() As String
'            Return "DL"
'        End Function
'        Public Overridable Function DigitalModulation() As String
'            Return "DM"
'        End Function
'        Public Overridable Function DigitalVoice() As String
'            Return "DV"
'        End Function
'        Public Overridable Function EDACSIDRangeMode() As String
'            Return "RG"
'        End Function
'        Public Overridable Function EDACS_AFS() As String
'            Return "AF"
'        End Function
'        Public Overridable Function EmergencyAlert() As String
'            Return "EA"
'        End Function
'        Public Overridable Function EnterLock() As String
'            Return "EL"
'        End Function
'        Public Overridable Function FIPSWeatherSearchCode() As String
'            Return "FP"
'        End Function
'        Public Overridable Function FleetMapProgram() As String
'            Return "FB"
'        End Function
'        Public Overridable Function FrequencyIdentificationMode() As String
'            Return "FI"
'        End Function
'        Public Overridable Function HighwayAlert() As String
'            Return "HA"
'        End Function
'        Public Overridable Function HighwayAlertSignalReceived() As String
'            Return "HP"
'        End Function
'        Public Overridable Function HighwayScanMode() As String
'            Return "HW"
'        End Function
'        Public Overridable Function ICALL() As String
'            Return "IR"
'        End Function
'        Public Overridable Function IDChannel() As String
'            Return "IC"
'        End Function
'        Public Overridable Function IDLockoutMemory() As String
'            Return "IL"
'        End Function
'        Public Overridable Function IDScanlists() As String
'            Return "IS"
'        End Function
'        Public Overridable Function KEY(ByVal keyCode As String) As String
'            'cn.ExecuteCommand("KEY" & keyCode)
'            Return cn.Response
'        End Function
'        Public Overridable Function LCDLines() As String()
'            Dim response(1) As String
'            response(0) = String.Empty
'            response(1) = String.Empty
'            Return response
'        End Function
'        Public Overridable Function LCDCommands(ByVal cmd As String) As String
'            'cn.ExecuteCommand("LCD " & cmd)
'            Return cn.Response
'        End Function
'        Public Overridable Function LCDMask() As String
'            Return "LM"
'        End Function
'        Public Overridable Function Light() As String
'            Return "LT"
'        End Function
'        Public Overridable Function LockOut() As String
'            Return "LO"
'        End Function
'        Public Overridable Function LowerLimit() As String
'            Return "LL"
'        End Function
'        Public Overridable Function Manual() As String
'            Return "MA"
'        End Function
'        Public Overridable Function Mode() As String

'            'cn.ExecuteCommand("MD")
'            Dim response As String = cn.Response

'            If Not String.IsNullOrEmpty(response) Then
'                Dim index As Integer
'                ' remove MD from MDxx
'                response = response.Substring(2)
'                If Integer.TryParse(response, index) Then
'                    If index >= 0 AndAlso index < ScannerModes.Count Then
'                        response = ScannerModes(index)
'                    Else
'                        Throw New UnidenCommander.Scanner.Exceptions.UnknownScannerModelException
'                    End If
'                End If
'            End If

'            Return response

'        End Function
'        Public Overridable Function Mute(ByVal state As UnidenCommander.Scanner.ScannerBoolean) As String
'            'cn.ExecuteCommand("MU" & Convert.ToChar(state))
'            Return cn.Response
'        End Function
'        Public Overridable Function P25Card() As String
'            Return "AP"
'        End Function
'        Public Overridable Function PriorityChannel() As String
'            Return "PC"
'        End Function
'        Public Overridable Function PriorityID() As String
'            Return "PI"
'        End Function
'        Public Overridable Function PriorityNotify() As String
'            Return "RI"
'        End Function
'        Public Overridable Function PriorityScan() As String
'            Return "PR"
'        End Function
'        Public Overridable Function ProgramMemory() As String
'            Return "PM"
'        End Function
'        Public Overridable Function RadioFrequencyTune() As String
'            Return "RF"
'        End Function
'        Public Overridable Function ReceiverModulation(Optional ByVal mode As UnidenCommander.Scanner.Modulations = UnidenCommander.Scanner.Modulations.NA) As String
'            Dim cmd As String
'            Dim response As String

'            If mode = UnidenCommander.Scanner.Modulations.NA Then
'                cmd = "RM"
'            Else
'                cmd = "RM " + mode.ToString
'            End If
'            'cn.ExecuteCommand(cmd)
'            response = cn.Response

'            If response.IndexOf(" ") > -1 Then response = response.Substring(response.IndexOf(" "))
'            Return response

'        End Function
'        Public Overridable Function ScanBanks() As String
'            Return "SB"
'        End Function
'        Public Overridable Function SearchSkip() As String
'            Return "SS"
'        End Function
'        Public Overridable Function ServiceScanMode() As String
'            Return "SV"
'        End Function
'        Public Overridable Function SignalStrength() As SignalStrength
'            'cn.ExecuteCommand("SG")
'            Dim response As String = cn.Response
'            ' response looks like Sxx Fyyyyyyyy
'            ' xx = signal strength = 0-255
'            ' yyyyyyyy = frequency (8 digits)
'            Dim sg As SignalStrength

'            If response.IndexOf(" ") > -1 Then
'                sg.Strength = Convert.ToInt32(response.Split(" "c)(0).Substring(1))
'                sg.Frequency = Convert.ToInt32(response.Split(" "c)(1).Substring(1))
'            End If

'            Return sg

'        End Function
'        Public Overridable Function SlashData() As String
'            Return "TD"
'        End Function
'        Public Overridable Function SquelchNotify() As String
'            Return "QU"
'        End Function
'        Public Overridable Function SquelchStatus() As String
'            Return "SQ"
'        End Function
'        Public Overridable Function StepSize(ByVal size As UnidenCommander.Scanner.FrequencySteps) As String
'            Dim s As String = size.ToString.Substring(4).Replace("_"c, "."c)
'            'cn.ExecuteCommand("ST " & s)
'            Return cn.Response
'        End Function
'        Public Overridable Function SystemInformation() As SystemInformation
'            'cn.ExecuteCommand("SI")

'            Dim tmp As String = cn.Response
'            Dim info As New SystemInformation

'            ' test string for diffirent models
'            'tmp = "SI BC780D,000,123"
'            'tmp = "SI Model: SH345XS(BC785XLT),000,107"

'            If Not String.IsNullOrEmpty(tmp) Then

'                Dim m As Match
'                m = Regex.Match(tmp, "((\(|BC)(.+))(,|\))(.+),(.+)$")

'                If m.Success Then
'                    info.ModelName = m.Groups(1).Value.Trim(New Char() {"("c, ")"c})
'                    info.ESNNumber = m.Groups(5).Value
'                    info.RemoteCommandVersion = m.Groups(6).Value
'                End If

'            End If

'            Return info

'        End Function

'        Public Overridable Function ReadAlphaTag(ByVal type As UnidenCommander.Scanner.AlphaTagType, ByVal bankOrChannel As String) As String
'            'cn.ExecuteCommand(String.Format("TA {0} {1}", Convert.ToChar(type), bankOrChannel))
'            Return cn.Response.Substring(7)
'        End Function
'        'Public Overridable Function ReadAlphaTagChannel(ByVal channel As Integer) As String
'        '	cn.ExecuteCommand(String.Format("TA C {0}", channel.ToString("D3")))
'        '	Return cn.Response.Substring(7)
'        'End Function
'        'Public Overridable Function ReadAlphaTagSearchRange(ByVal range As String) As String
'        '	cn.ExecuteCommand(String.Format("TA S {0}", range))
'        '	Return cn.Response.Substring(7)
'        'End Function

'        Public Overridable Function WriteAlphaTag(ByVal type As UnidenCommander.Scanner.AlphaTagType, ByVal bankOrChannel As String, ByVal tag As String) As String
'            'cn.ExecuteCommand(String.Format("TA {0} {1} {2}", Convert.ToChar(type), bankOrChannel, tag))
'            Return cn.Response
'        End Function
'        'Public Overridable Function WriteAlphaTagChannel(ByVal channel As Integer, ByVal tag As String) As String
'        '	cn.ExecuteCommand(String.Format("TA C {0} {1}", channel.ToString("D3"), tag))
'        '	Return cn.Response
'        'End Function
'        'Public Overridable Function WriteAlphaTagSearchRange(ByVal range As String, ByVal tag As String) As String
'        '	cn.ExecuteCommand(String.Format("TA S {0} {1}", range, tag))
'        '	Return cn.Response
'        'End Function

'        Public Overridable Function TalkGroupID() As String
'            Return "TG"
'        End Function
'        Public Overridable Function TrunkIDMonitor() As String
'            Return "ID"
'        End Function
'        Public Overridable Function TrunkType() As String
'            Return "TR"
'        End Function
'        Public Overridable Function TrunkingBankMode() As String
'            Return "TB"
'        End Function
'        Public Overridable Function TrunkingControlChannelMode() As String
'            Return "TC"
'        End Function
'        Public Overridable Function USState() As String
'            Return "US"
'        End Function
'        Public Overridable Function UpperLimit() As String
'            Return "LU"
'        End Function
'        Public Overridable Function Version() As String
'            Return "VR"
'        End Function
'        Public Overridable Function WarningLight() As String
'            Return "WL"
'        End Function
'        Public Overridable Function WarningLightDimmer() As String
'            Return "WD"
'        End Function
'        Public Overridable Function WarningMuteCondition() As String
'            Return "WM"
'        End Function
'        Public Overridable Function WeatherAlert() As String
'            Return "WA"
'        End Function
'        Public Overridable Function WindowVoltage() As Integer
'            'cn.ExecuteCommand("WI")
'            Dim response As String = cn.Response
'            If response.IndexOf(" ") > -1 Then
'                Return Convert.ToInt32(response.Substring(1, response.IndexOf(" ")))
'            End If
'            Return 100 ' center tuning
'        End Function
'        Public Overridable Function LC() As String
'            Return "LC"
'        End Function
'        Public Overridable Function VS() As String
'            Return "VS"
'        End Function

'        Public Function Command(ByVal cmd As String) As String
'            'cn.ExecuteCommand(cmd)
'            Return cn.Response
'        End Function


'        Protected Shared Function GetLine(ByVal rawLine As String) As String
'            If (String.IsNullOrEmpty(rawLine)) Then
'                Return String.Empty
'            End If
'            If (rawLine.Length < 6 + 16) Then
'                Return String.Empty
'            End If
'            Return rawLine.Substring(6, 16)
'        End Function

'    End Class

'End Namespace

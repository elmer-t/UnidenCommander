
Imports System.Text.RegularExpressions

Namespace Scanner.CommandSets

    ''' <summary>
    ''' Represents the abstract base command set class. Contains basic routines and properties.
    ''' </summary>
    Public MustInherit Class BaseCommandSet
        Implements ICommandSet

        Private _scannerReference As Scanner.Models.BaseScannerModel
        Protected _scannerModes As New Dictionary(Of Integer, ScannerMode)

        ''' <summary>
        ''' Gets or sets the reference to the parent scanner object.
        ''' </summary>
        ''' <value>The scanner reference.</value>
        Public Property ScannerReference() As Scanner.Models.BaseScannerModel Implements ICommandSet.ScannerReference
            Get
                Return _scannerReference
            End Get
            Set(ByVal value As Scanner.Models.BaseScannerModel)
                _scannerReference = value
            End Set
        End Property

        ''' <summary>
        ''' Generic callback handler delegate for asyncronis scanner responses.
        ''' </summary>
        Public Delegate Sub CallbackHandlerDelegate(ByVal response As String)

#Region " Commands "

        Public Overridable ReadOnly Property ActivityIDWindow() As Command Implements ICommandSet.ActivityIDWindow
            Get
                Return New Command("AW")
            End Get
        End Property
        Public Overridable ReadOnly Property AllClear() As Command Implements ICommandSet.AllClear
            Get
                Return New Command("AC")
            End Get
        End Property
        Public Overridable ReadOnly Property Attenuator(Optional ByVal state As ScannerBoolean = Nothing) As Scanner.Command Implements ICommandSet.Attenuator
            Get
                If state = Nothing Then
                    Return New Command("AT", New CallbackHandlerDelegate(AddressOf AttentuatorCallbackHandler))
                Else
                    Return New Command("AT" & Convert.ToChar(state))
                End If
            End Get
        End Property
        Public Overridable ReadOnly Property AutoLight() As Command Implements ICommandSet.AutoLight
            Get
                Return New Command("AL")
            End Get
        End Property
        Public Overridable ReadOnly Property AutoRecording() As Command Implements ICommandSet.AutoRecording
            Get
                Return New Command("AR")
            End Get
        End Property
        Public Overridable ReadOnly Property BatteryLife() As Command Implements ICommandSet.BatteryLife
            Get
                Return New Command("BL")
            End Get
        End Property
        Public Overridable ReadOnly Property BatteryMonitorReporting() As Command Implements ICommandSet.BatteryMonitorReporting
            Get
                Return New Command("BM")
            End Get
        End Property
        Public Overridable ReadOnly Property BatterySave() As Command Implements ICommandSet.BatterySave
            Get
                Return New Command("BS")
            End Get
        End Property
        Public Overridable ReadOnly Property BeepAlert() As Command Implements ICommandSet.BeepAlert
            Get
                Return New Command("BA")
            End Get
        End Property
        Public Overridable ReadOnly Property BeepSet() As Command Implements ICommandSet.BeepSet
            Get
                Return New Command("BP")
            End Get
        End Property
        Public Overridable ReadOnly Property BitStatus() As Command Implements ICommandSet.BitStatus
            Get
                Return New Command("BT")
            End Get
        End Property
        Public Overridable ReadOnly Property CTCSSCondition() As Command Implements ICommandSet.CTCSSCondition
            Get
                Return New Command("CC")
            End Get
        End Property
        Public Overridable ReadOnly Property CTCSSDetection() As Command Implements ICommandSet.CTCSSDetection
            Get
                Return New Command("CD")
            End Get
        End Property
        Public Overridable ReadOnly Property CTCSSSet() As Command Implements ICommandSet.CTCSSSet
            Get
                Return New Command("CS")
            End Get
        End Property
        Public Overridable ReadOnly Property CTCSSTone() As Command Implements ICommandSet.CTCSSTone
            Get
                Return New Command("CT")
            End Get
        End Property
        Public Overridable ReadOnly Property ChooseBanks() As Command Implements ICommandSet.ChooseBanks
            Get
                Return New Command("CB")
            End Get
        End Property
        Public Overridable ReadOnly Property ConfirmBaseSpaceOffset() As Command Implements ICommandSet.ConfirmBaseSpaceOffset
            Get
                Return New Command("BC")
            End Get
        End Property
        Public Overridable ReadOnly Property DataSkip() As Command Implements ICommandSet.DataSkip
            Get
                Return New Command("DS")
            End Get
        End Property
        Public Overridable ReadOnly Property Delay() As Command Implements ICommandSet.Delay
            Get
                Return New Command("DL")
            End Get
        End Property
        Public Overridable ReadOnly Property DigitalModulation() As Command Implements ICommandSet.DigitalModulation
            Get
                Return New Command("DM")
            End Get
        End Property
        Public Overridable ReadOnly Property DigitalVoice() As Command Implements ICommandSet.DigitalVoice
            Get
                Return New Command("DV")
            End Get
        End Property
        Public Overridable ReadOnly Property EDACSIDRangeMode() As Command Implements ICommandSet.EDACSIDRangeMode
            Get
                Return New Command("RG")
            End Get
        End Property
        Public Overridable ReadOnly Property EDACS_AFS() As Command Implements ICommandSet.EDACS_AFS
            Get
                Return New Command("AF")
            End Get
        End Property
        Public Overridable ReadOnly Property EmergencyAlert() As Command Implements ICommandSet.EmergencyAlert
            Get
                Return New Command("EA")
            End Get
        End Property
        Public Overridable ReadOnly Property EnterLock() As Command Implements ICommandSet.EnterLock
            Get
                Return New Command("EL")
            End Get
        End Property
        Public Overridable ReadOnly Property FIPSWeatherSearchCode() As Command Implements ICommandSet.FIPSWeatherSearchCode
            Get
                Return New Command("FP")
            End Get
        End Property
        Public Overridable ReadOnly Property FleetMapProgram() As Command Implements ICommandSet.FleetMapProgram
            Get
                Return New Command("FB")
            End Get
        End Property
        Public Overridable ReadOnly Property FrequencyIdentificationMode() As Command Implements ICommandSet.FrequencyIdentificationMode
            Get
                Return New Command("FI")
            End Get
        End Property
        Public Overridable ReadOnly Property HighwayAlert() As Command Implements ICommandSet.HighwayAlert
            Get
                Return New Command("HA")
            End Get
        End Property
        Public Overridable ReadOnly Property HighwayAlertSignalReceived() As Command Implements ICommandSet.HighwayAlertSignalReceived
            Get
                Return New Command("HP")
            End Get
        End Property
        Public Overridable ReadOnly Property HighwayScanMode() As Command Implements ICommandSet.HighwayScanMode
            Get
                Return New Command("HW")
            End Get
        End Property
        Public Overridable ReadOnly Property ICALL() As Command Implements ICommandSet.ICALL
            Get
                Return New Command("IR")
            End Get
        End Property
        Public Overridable ReadOnly Property IDChannel() As Command Implements ICommandSet.IDChannel
            Get
                Return New Command("IC")
            End Get
        End Property
        Public Overridable ReadOnly Property IDLockoutMemory() As Command Implements ICommandSet.IDLockoutMemory
            Get
                Return New Command("IL")
            End Get
        End Property
        Public Overridable ReadOnly Property IDScanlists() As Command Implements ICommandSet.IDScanlists
            Get
                Return New Command("IS")
            End Get
        End Property
        Public Overridable ReadOnly Property KEYpadcommands() As Command Implements ICommandSet.KEYpadcommands
            Get
                Return New Command("KEY")
            End Get
        End Property
        Public Overridable ReadOnly Property LCDCommands() As Command Implements ICommandSet.LCDCommands
            Get
                Return New Command("LCD")
            End Get
        End Property
        Public Overridable ReadOnly Property LCDLine1() As Command Implements ICommandSet.LCDLine1
            Get
                Throw New Scanner.Exceptions.CommandNotSupportedException
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property LCDLine2() As Command Implements ICommandSet.LCDLine2
            Get
                Throw New Scanner.Exceptions.CommandNotSupportedException
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property LCDLine3() As Command Implements ICommandSet.LCDLine3
            Get
                Throw New Scanner.Exceptions.CommandNotSupportedException
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property LCDLine4() As Command Implements ICommandSet.LCDLine4
            Get
                Throw New Scanner.Exceptions.CommandNotSupportedException
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property LCDMask() As Command Implements ICommandSet.LCDMask
            Get
                Return New Command("LM")
            End Get
        End Property
        Public Overridable ReadOnly Property Light() As Command Implements ICommandSet.Light
            Get
                Return New Command("LT")
            End Get
        End Property
        Public Overridable ReadOnly Property LockOut() As Command Implements ICommandSet.LockOut
            Get
                Return New Command("LO")
            End Get
        End Property
        Public Overridable ReadOnly Property LowerLimit() As Command Implements ICommandSet.LowerLimit
            Get
                Return New Command("LL")
            End Get
        End Property
        Public Overridable ReadOnly Property Manual() As Command Implements ICommandSet.Manual
            Get
                Return New Command("MA")
            End Get
        End Property
        Public Overridable ReadOnly Property Mode() As Command Implements ICommandSet.Mode
            Get
                Return New Command("MD", New CallbackHandlerDelegate(AddressOf ModeCallbackHandler))
            End Get
        End Property
        Public Overridable ReadOnly Property Muting(Optional ByVal state As ScannerBoolean = Nothing) As Command Implements ICommandSet.Muting
            Get
                If state = Nothing Then
                    Return New Command("MU", New CallbackHandlerDelegate(AddressOf MutingCallbackHandler))
                Else
                    Return New Command("MU" & Convert.ToChar(state))
                End If
            End Get
        End Property
        Public Overridable ReadOnly Property P25Card() As Command Implements ICommandSet.P25Card
            Get
                Return New Command("AP")
            End Get
        End Property
        Public Overridable ReadOnly Property PriorityChannel() As Command Implements ICommandSet.PriorityChannel
            Get
                Return New Command("PC")
            End Get
        End Property
        Public Overridable ReadOnly Property PriorityID() As Command Implements ICommandSet.PriorityID
            Get
                Return New Command("PI")
            End Get
        End Property
        Public Overridable ReadOnly Property PriorityNotify() As Command Implements ICommandSet.PriorityNotify
            Get
                Return New Command("RI")
            End Get
        End Property
        Public Overridable ReadOnly Property PriorityScan() As Command Implements ICommandSet.PriorityScan
            Get
                Return New Command("PR")
            End Get
        End Property
        Public Overridable ReadOnly Property ProgramMemory() As Command Implements ICommandSet.ProgramMemory
            Get
                Return New Command("PM")
            End Get
        End Property
        Public Overridable ReadOnly Property RadioFrequencyTune() As Command Implements ICommandSet.RadioFrequencyTune
            Get
                Return New Command("RF")
            End Get
        End Property
        Public Overridable ReadOnly Property ReceiverModulation(Optional ByVal m As Scanner.Modulations = Nothing) As Command Implements ICommandSet.ReceiverModulation
            Get
                If m = Nothing Then
                    Return New Command("RM", New CallbackHandlerDelegate(AddressOf ModulationCallbackHandler))
                Else
                    Return New Command("RM " & m.ToString)
                End If
            End Get
        End Property
        Public Overridable ReadOnly Property ScanBanks() As Command Implements ICommandSet.ScanBanks
            Get
                Return New Command("SB")
            End Get
        End Property
        Public Overridable ReadOnly Property SearchSkip() As Command Implements ICommandSet.SearchSkip
            Get
                Return New Command("SS")
            End Get
        End Property
        Public Overridable ReadOnly Property ServiceScanMode() As Command Implements ICommandSet.ServiceScanMode
            Get
                Return New Command("SV")
            End Get
        End Property
        Public Overridable ReadOnly Property SignalStrength() As Command Implements ICommandSet.SignalStrength
            Get
                Return New Command("SG", New CallbackHandlerDelegate(AddressOf SignalStrengthCallbackHandler))
            End Get
        End Property
        Public Overridable ReadOnly Property SlashData() As Command Implements ICommandSet.SlashData
            Get
                Return New Command("TD")
            End Get
        End Property
        Public Overridable ReadOnly Property SquelchNotify() As Command Implements ICommandSet.SquelchNotify
            Get
                Return New Command("QU")
            End Get
        End Property
        Public Overridable ReadOnly Property SquelchStatus() As Command Implements ICommandSet.SquelchStatus
            Get
                Return New Command("SQ", New CallbackHandlerDelegate(AddressOf SquelchStatusCallbackHandler))
            End Get
        End Property
        Public Overridable ReadOnly Property StepSize(Optional ByVal size As Scanner.StepSizes = Nothing) As Command Implements ICommandSet.StepSize
            Get
                If size = Nothing Then Return New Command("ST", New CallbackHandlerDelegate(AddressOf StepSizeCallbackHandler))

                ' This work for BC780,BC785 and BC250. BC895 and PRO2052 require different format.
                Return New Command("ST " & size.ToString.Substring(4).Replace("_"c, "."c))

            End Get
        End Property
        Public Overridable ReadOnly Property SystemInformation() As Command Implements ICommandSet.SystemInformation
            Get
                Return New Command("SI", New CallbackHandlerDelegate(AddressOf SystemInformationCallbackHandler))
            End Get
        End Property
        Public Overridable ReadOnly Property ReadAlphaTags(ByVal type As AlphaTagType, ByVal bankOrChannel As String) As Command Implements ICommandSet.ReadAlphaTags
            Get
                Return New Command(String.Format("TA {0} {1}", Convert.ToChar(type), bankOrChannel), New CallbackHandlerDelegate(AddressOf AlphaTagCallbackHandler))
            End Get
        End Property
        Public Overridable ReadOnly Property WriteAlphaTags(ByVal type As AlphaTagType, ByVal bankOrChannel As String, ByVal tag As String) As Command Implements ICommandSet.WriteAlphaTags
            Get
                Return New Command(String.Format("TA {0} {1} {2}", Convert.ToChar(type), bankOrChannel, tag))
            End Get
        End Property
        Public Overridable ReadOnly Property TalkGroupID() As Command Implements ICommandSet.TalkGroupID
            Get
                Return New Command("TG")
            End Get
        End Property
        Public Overridable ReadOnly Property TrunkIDMonitor() As Command Implements ICommandSet.TrunkIDMonitor
            Get
                Return New Command("ID")
            End Get
        End Property
        Public Overridable ReadOnly Property TrunkType() As Command Implements ICommandSet.TrunkType
            Get
                Return New Command("TR")
            End Get
        End Property
        Public Overridable ReadOnly Property TrunkingBankMode() As Command Implements ICommandSet.TrunkingBankMode
            Get
                Return New Command("TB")
            End Get
        End Property
        Public Overridable ReadOnly Property TrunkingControlChannelMode() As Command Implements ICommandSet.TrunkingControlChannelMode
            Get
                Return New Command("TC")
            End Get
        End Property
        Public Overridable ReadOnly Property USState() As Command Implements ICommandSet.USState
            Get
                Return New Command("US")
            End Get
        End Property
        Public Overridable ReadOnly Property UpperLimit() As Command Implements ICommandSet.UpperLimit
            Get
                Return New Command("LU")
            End Get
        End Property
        Public Overridable ReadOnly Property Version() As Command Implements ICommandSet.Version
            Get
                Return New Command("VR")
            End Get
        End Property
        Public Overridable ReadOnly Property WarningLight() As Command Implements ICommandSet.WarningLight
            Get
                Return New Command("WL")
            End Get
        End Property
        Public Overridable ReadOnly Property WarningLightDimmer() As Command Implements ICommandSet.WarningLightDimmer
            Get
                Return New Command("WD")
            End Get
        End Property
        Public Overridable ReadOnly Property WarningMuteCondition() As Command Implements ICommandSet.WarningMuteCondition
            Get
                Return New Command("WM")
            End Get
        End Property
        Public Overridable ReadOnly Property WeatherAlert() As Command Implements ICommandSet.WeatherAlert
            Get
                Return New Command("WA")
            End Get
        End Property
        Public Overridable ReadOnly Property WindowVoltage() As Command Implements ICommandSet.WindowVoltage
            Get
                Return New Command("WI", New CallbackHandlerDelegate(AddressOf WindowVoltageCallbackHandler))
            End Get
        End Property

#End Region

#Region " Command response handlers "

        Protected Sub AttenuatorCallbackHandler(ByVal response As String)

            ' example: ATF (off) ATN (on)

            If Not String.IsNullOrEmpty(response) AndAlso response <> "NG" Then

                Dim att As String = response.Substring(2, 1)
                If att = "F" Then ScannerReference.SetAttenuated(ScannerBoolean.Off)
                If att = "N" Then ScannerReference.SetAttenuated(ScannerBoolean.On)

            End If

        End Sub

        Protected Sub MutingCallbackHandler(ByVal response As String)

            ' example: MUF, MUA, MUN (off, auto, on)
            If Not String.IsNullOrEmpty(response) AndAlso response <> "NG" Then

                If response.Length = 3 Then
                    Dim mute As String = response.Substring(2, 1)
                    If mute = "F" Then ScannerReference.SetMuted(ScannerBoolean.Off)
                    If mute = "N" Then ScannerReference.SetMuted(ScannerBoolean.On)
                    If mute = "A" Then ScannerReference.SetMuted(ScannerBoolean.Auto)
                Else
                    Throw New Exceptions.InvalidResponseException("MU", "MUx", response)
                End If

            End If

        End Sub

        Protected Sub SquelchStatusCallbackHandler(ByVal response As String)

            ' example: +, - (open, closed)
            If Not String.IsNullOrEmpty(response) AndAlso response <> "NG" Then

                If response = "+" Then ScannerReference.SetSquelchOpen(True)
                If response = "-" Then ScannerReference.SetSquelchOpen(False)

            End If

        End Sub

        Protected Sub Line1CallbackHandler(ByVal response As String)

            Dim chn As String = Regex.Match(response, "C\s*(\d{3})\s*\]").Groups(1).Value

            If Not String.IsNullOrEmpty(chn) Then
                Dim ch As Integer
                If Integer.TryParse(chn, ch) Then
                    ScannerReference.SetChannel(ch)
                End If
            End If

            Dim dir As String = Regex.Match(response, "\[(.+)\s*([+-])(.+)\]").Groups(2).Value
            If Not String.IsNullOrEmpty(chn) Then
                If dir = "+" Then ScannerReference.SetScanDirection(ScanDirections.Up) Else ScannerReference.SetScanDirection(ScanDirections.Down)
            End If

        End Sub
        Protected Sub Line2CallbackHandler(ByVal response As String)

            Throw New NotImplementedException

            ' example: LCD2 [SCAN            ][    ]
            ' example: LCD2 [ 156.8500  FM   ][    ]

        End Sub
        Protected Sub Line3CallbackHandler(ByVal response As String)

            ' example: LCD3 [BANK  -2-45----0][    ]
            ' example: LCD3 [17 Interschip   ][    ]
            Dim txt As String = Regex.Match(response, "\[(.+?)\]").Groups(1).Value
            If Not String.IsNullOrEmpty(txt) Then
                ScannerReference.SetLCDLine3(txt)
            End If

        End Sub
        Protected Sub Line4CallbackHandler(ByVal response As String)

            ' example: LCD4 [                ][    ]
            ' example: LCD4 [Hulpdiensten    ][    ]
            Dim txt As String = Regex.Match(response, "\[(.+?)\]").Groups(1).Value
            If Not String.IsNullOrEmpty(txt) Then
                ScannerReference.SetLCDLine4(txt)
            End If


        End Sub
        Protected Sub ModeCallbackHandler(ByVal response As String)

            ' example: MDxx (xx = mode number)
            Dim index As Integer
            Dim m As String = response.Substring(2)
            If Integer.TryParse(m, index) Then
                Try
                    ScannerReference.SetMode(ScannerModes(index))
                Catch ex As Exception
                End Try
            End If

        End Sub
        Protected Sub ModulationCallbackHandler(ByVal response As String)

            ' example: RM AM
            If response.IndexOf(" ") > -1 Then
                Dim md As String = response.Substring(response.IndexOf(" ")).Trim
                ScannerReference.SetModulation(CType(Tools.GetEnumValueByName(GetType(Scanner.Modulations), md), Scanner.Modulations))
            End If

        End Sub
        Protected Sub SignalStrengthCallbackHandler(ByVal response As String)

            ' example: Sxx Fyyyyyyyy
            If response.IndexOf(" ") > -1 Then
                Dim val As Integer
                Dim tmp As String() = response.Split(" "c)
                If Integer.TryParse(tmp(0).Substring(1), val) Then
                    ScannerReference.SetSignalStrength(val)
                Else
                    Throw New Exceptions.InvalidResponseException("SG", "number", tmp(0))
                End If
                If Integer.TryParse(tmp(1).Substring(1), val) Then
                    ScannerReference.SetFrequency(val)
                Else
                    Throw New Exceptions.InvalidResponseException("SG", "number", tmp(1))
                End If
            End If

        End Sub
        Protected Sub StepSizeCallbackHandler(ByVal response As String)

            ' example: ST 12.5K
            If Not String.IsNullOrEmpty(response) AndAlso response <> "NG" Then
                If response.IndexOf(" ") > -1 Then
                    ScannerReference.SetStepSize(CType( _
                     Tools.GetEnumValueByName(GetType(StepSizes), "Step" & response.Split(" "c)(1).Replace(".", "_")),  _
                     StepSizes) _
                    )
                End If
            End If

        End Sub
        Protected Sub WindowVoltageCallbackHandler(ByVal response As String)

            ' example: W107 F08680875
            If Not String.IsNullOrEmpty(response) AndAlso response <> "NG" Then
                Dim str As String = Regex.Match(response, "^[W](.+?)[ ]").Groups(1).Value
                Dim val As Integer
                If Integer.TryParse(str, val) Then
                    ScannerReference.SetWindowVoltage(val)
                Else
                    Throw New Exceptions.InvalidResponseException("WI", "number", str)
                End If
            End If

        End Sub
        Protected Sub AttentuatorCallbackHandler(ByVal response As String)

            ' example: ATN (true-on) / ATF (false-off) / ATA (auto)
            If response.Length = 3 Then
                Dim state As ScannerBoolean = CType(Convert.ToInt32(response.ToCharArray(2, 1)(0)), ScannerBoolean)
                ScannerReference.SetAttenuated(state)
            End If

        End Sub

        Protected Friend Sub SystemInformationCallbackHandler(ByVal response As String) Implements ICommandSet.SystemInformationCallbackHandler

            ' test string for different models
            ' example: SI BC780D,000,123
            ' example: SI Model: SH345XS(BC785XLT),000,107

            Dim info As New SystemInformation

            If Not String.IsNullOrEmpty(response) Then

                Dim m As Match
                m = Regex.Match(response, "((\(|BC)(.+))(,|\))(.+),(.+)$")

                If m.Success Then

                    info.ModelName = m.Groups(1).Value.Trim(New Char() {"("c, ")"c})
                    info.ESNNumber = m.Groups(5).Value
                    info.RemoteCommandVersion = m.Groups(6).Value

                    For Each item As Integer In [Enum].GetValues(GetType(ScannerModels))
                        If info.ModelName.IndexOf([Enum].GetName(GetType(ScannerModels), item)) > -1 Then
                            ScannerReference.SetModel(CType(item, ScannerModels))
                        End If
                    Next

                    ScannerReference.SetSystemInformation(info)

                End If

            End If

        End Sub

        Protected Friend Sub AlphaTagCallbackHandler(ByVal response As String) Implements ICommandSet.AlphaTagCallbackHandler

            ' example: TA B B My alphatag -> scan bank tag
            ' example: TA S B My alphatag -> search range tag
            ' example: TA C B My alphatag -> channel tag
            If Not String.IsNullOrEmpty(response) Then

                Dim type As AlphaTagType = DirectCast(Convert.ToInt32(response.ToCharArray(3, 1)(0)), AlphaTagType)
                Dim chn As Char = response.ToCharArray(5, 1)(0) ' B
                Dim tag As String = response.Substring(7) ' anything beyond B

                'Get stored bank, from scanner, not from commandset!
                Dim storedBank As Bank
                If ScannerReference.Banks.ContainsKey(chn) Then
                    storedBank = ScannerReference.Banks(chn)
                Else
                    ' Create bank if it does not exist
                    storedBank = New Bank(chn)
                    ScannerReference.Banks(chn) = storedBank
                End If

                ' Update bank object
                Select Case type
                    Case AlphaTagType.ScanBank
                        storedBank.ScanBankTag = tag
                    Case AlphaTagType.SearchRange
                        storedBank.SearchRangeTag = tag
                End Select

                ' Put bank object back in scanner
                ScannerReference.SetBank(chn, storedBank)

            End If

        End Sub

#End Region

        Public MustOverride ReadOnly Property ScreenRefreshCommands() As List(Of Command) Implements ICommandSet.ScreenRefreshCommands
        Public MustOverride ReadOnly Property ScannerModes() As Dictionary(Of Integer, ScannerMode)

        Protected Shared Function GetLCDLine(ByVal rawLine As String) As String
            If (String.IsNullOrEmpty(rawLine)) Then
                Return String.Empty
            End If
            If (rawLine.Length < 6 + 16) Then
                Return String.Empty
            End If
            Return rawLine.Substring(6, 16)
        End Function

    End Class

End Namespace

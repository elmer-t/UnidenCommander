Namespace CommandSets

    Public Interface ICommandSet

#Region " Properties "

        Property ScannerReference() As Scanner.Models.BaseScannerModel
        ReadOnly Property ScreenRefreshCommands() As List(Of Command)

        ReadOnly Property ActivityIDWindow() As Command
        ReadOnly Property AllClear() As Command
        ReadOnly Property Attenuator(Optional ByVal state As ScannerBoolean = Nothing) As Scanner.Command
        ReadOnly Property AutoLight() As Command
        ReadOnly Property AutoRecording() As Command
        ReadOnly Property BatteryLife() As Command
        ReadOnly Property BatteryMonitorReporting() As Command
        ReadOnly Property BatterySave() As Command
        ReadOnly Property BeepAlert() As Command
        ReadOnly Property BeepSet() As Command
        ReadOnly Property BitStatus() As Command
        ReadOnly Property CTCSSCondition() As Command
        ReadOnly Property CTCSSDetection() As Command
        ReadOnly Property CTCSSSet() As Command
        ReadOnly Property CTCSSTone() As Command
        ReadOnly Property ChooseBanks() As Command
        ReadOnly Property ConfirmBaseSpaceOffset() As Command
        ReadOnly Property DataSkip() As Command
        ReadOnly Property Delay() As Command
        ReadOnly Property DigitalModulation() As Command
        ReadOnly Property DigitalVoice() As Command
        ReadOnly Property EDACSIDRangeMode() As Command
        ReadOnly Property EDACS_AFS() As Command
        ReadOnly Property EmergencyAlert() As Command
        ReadOnly Property EnterLock() As Command
        ReadOnly Property FIPSWeatherSearchCode() As Command
        ReadOnly Property FleetMapProgram() As Command
        ReadOnly Property FrequencyIdentificationMode() As Command
        ReadOnly Property HighwayAlert() As Command
        ReadOnly Property HighwayAlertSignalReceived() As Command
        ReadOnly Property HighwayScanMode() As Command
        ReadOnly Property ICALL() As Command
        ReadOnly Property IDChannel() As Command
        ReadOnly Property IDLockoutMemory() As Command
        ReadOnly Property IDScanlists() As Command
        ReadOnly Property KEYpadcommands() As Command
        ReadOnly Property LCDCommands() As Command
        ReadOnly Property LCDLine1() As Command
        ReadOnly Property LCDLine2() As Command
        ReadOnly Property LCDLine3() As Command
        ReadOnly Property LCDLine4() As Command
        ReadOnly Property LCDMask() As Command
        ReadOnly Property Light() As Command
        ReadOnly Property LockOut() As Command
        ReadOnly Property LowerLimit() As Command
        ReadOnly Property Manual() As Command
        ReadOnly Property Mode() As Command
        ReadOnly Property Muting(Optional ByVal state As ScannerBoolean = Nothing) As Command
        ReadOnly Property P25Card() As Command
        ReadOnly Property PriorityChannel() As Command
        ReadOnly Property PriorityID() As Command
        ReadOnly Property PriorityNotify() As Command
        ReadOnly Property PriorityScan() As Command
        ReadOnly Property ProgramMemory() As Command
        ReadOnly Property RadioFrequencyTune() As Command
        ReadOnly Property ReceiverModulation(Optional ByVal m As Scanner.Modulations = Nothing) As Command
        ReadOnly Property ScanBanks() As Command ' command for both scan and search banks
        ReadOnly Property SearchSkip() As Command
        ReadOnly Property ServiceScanMode() As Command
        ReadOnly Property SignalStrength() As Command
        ReadOnly Property SlashData() As Command
        ReadOnly Property SquelchNotify() As Command
        ReadOnly Property SquelchStatus() As Command
        ReadOnly Property StepSize(Optional ByVal s As Scanner.StepSizes = Nothing) As Command
        ReadOnly Property SystemInformation() As Command
        ReadOnly Property ReadAlphaTags(ByVal type As AlphaTagType, ByVal bankOrChannel As String) As Command
        ReadOnly Property WriteAlphaTags(ByVal type As AlphaTagType, ByVal bankOrChannel As String, ByVal tag As String) As Command
        ReadOnly Property TalkGroupID() As Command
        ReadOnly Property TrunkIDMonitor() As Command
        ReadOnly Property TrunkType() As Command
        ReadOnly Property TrunkingBankMode() As Command
        ReadOnly Property TrunkingControlChannelMode() As Command
        ReadOnly Property USState() As Command
        ReadOnly Property UpperLimit() As Command
        ReadOnly Property Version() As Command
        ReadOnly Property WarningLight() As Command
        ReadOnly Property WarningLightDimmer() As Command
        ReadOnly Property WarningMuteCondition() As Command
        ReadOnly Property WeatherAlert() As Command
        ReadOnly Property WindowVoltage() As Command

#End Region

#Region " Methods "

        Sub SystemInformationCallbackHandler(ByVal response As String)
        Sub AlphaTagCallbackHandler(ByVal response As String)

#End Region

    End Interface

End Namespace

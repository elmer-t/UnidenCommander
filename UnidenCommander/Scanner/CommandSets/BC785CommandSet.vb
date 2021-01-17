Namespace Scanner.CommandSets

    Public Class BC785CommandSet
        Inherits GenericCommandSet
        Implements ICommandSet

		Public Sub New()

			ScannerModes(0) = New ScannerMode("SCAN", "Conventional scanning")
			ScannerModes(1) = New ScannerMode("MAN", "Manual")
			ScannerModes(2) = New ScannerMode("SRCH", "Limit Search")
			ScannerModes(3) = New ScannerMode("SRCH HOLD", "Limit Search Hold")
			ScannerModes(4) = New ScannerMode("AIR", "Air Search")
			ScannerModes(5) = New ScannerMode("AIR HOLD", "Air Search Hold")
			ScannerModes(6) = New ScannerMode("TRUNC", "Motorola Trunk Frequency Program")
			ScannerModes(7) = New ScannerMode("? (7)", "Unknown")
			ScannerModes(8) = New ScannerMode("? (8)", "Unknown")
			ScannerModes(9) = New ScannerMode("? (9)", "Unknown")
			ScannerModes(10) = New ScannerMode("? (10)", "Unknown")
			ScannerModes(11) = New ScannerMode("? (11)", "Unknown")
			ScannerModes(12) = New ScannerMode("? (12)", "Unknown")
			ScannerModes(13) = New ScannerMode("? (13)", "Unknown")
			ScannerModes(14) = New ScannerMode("? (14)", "Unknown")
			ScannerModes(15) = New ScannerMode("? (15)", "Unknown")
			ScannerModes(16) = New ScannerMode("? (16)", "Unknown")
			ScannerModes(17) = New ScannerMode("? (17)", "Unknown")
			ScannerModes(18) = New ScannerMode("? (18)", "Unknown")
			ScannerModes(19) = New ScannerMode("? (19)", "Unknown")
			ScannerModes(20) = New ScannerMode("? (20)", "Unknown")
			ScannerModes(21) = New ScannerMode("? (21)", "Unknown")

		End Sub

		Public Overrides ReadOnly Property ScreenRefreshCommands() As List(Of Command)
			Get

				Dim cmd As New List(Of Command)
				Dim BC785Commands As CommandSets.BC785CommandSet = New CommandSets.BC785CommandSet

                cmd.Add(BC785Commands.LCDLine1)
				'cmd.Add(CmdLine2)
                cmd.Add(BC785Commands.LCDLine3)
                cmd.Add(BC785Commands.LCDLine4)
                cmd.Add(BC785Commands.SignalStrength)
                cmd.Add(BC785Commands.ReceiverModulation)
                cmd.Add(BC785Commands.Attenuator)
                cmd.Add(BC785Commands.Muting)
                cmd.Add(BC785Commands.Mode)
                cmd.Add(BC785Commands.StepSize)
                cmd.Add(BC785Commands.WindowVoltage)
                cmd.Add(BC785Commands.SquelchStatus)

				Return cmd

			End Get
		End Property

		Public Overrides ReadOnly Property ScannerModes() As Dictionary(Of Integer, ScannerMode)
			Get
				Return _scannerModes
			End Get
		End Property

        Public Overrides ReadOnly Property LCDLine1() As Command
            Get
                Return New Command("LCD1", New CallbackHandlerDelegate(AddressOf Line1CallbackHandler))
            End Get
        End Property
        Public Overrides ReadOnly Property LCDLine2() As Command
            Get
                Return New Command("LCD2", New CallbackHandlerDelegate(AddressOf Line2CallbackHandler))
            End Get
        End Property
        Public Overrides ReadOnly Property LCDLine3() As Command
            Get
                Return New Command("LCD3", New CallbackHandlerDelegate(AddressOf Line3CallbackHandler))
            End Get
        End Property
        Public Overrides ReadOnly Property LCDLine4() As Command
            Get
                Return New Command("LCD4", New CallbackHandlerDelegate(AddressOf Line4CallbackHandler))
            End Get
        End Property

	End Class

End Namespace


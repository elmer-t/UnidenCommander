Namespace Scanner.CommandSets

    Public Class BC780CommandSet
        Inherits GenericCommandSet
        Implements ICommandSet

		Public Sub New()

			ScannerModes(0) = New ScannerMode("SCAN", "Conventional scanning")
			ScannerModes(1) = New ScannerMode("MAN", "Manual")
			ScannerModes(2) = New ScannerMode("SRCH", "Limit Search")
			ScannerModes(3) = New ScannerMode("SRCH HOLD", "Limit Search Hold")
			ScannerModes(4) = New ScannerMode("WEATHER", "Weather Search")
			ScannerModes(5) = New ScannerMode("WEATHER HOLD", "Weather Search Hold")
			ScannerModes(6) = New ScannerMode("TRUNC", "Motorola Trunk Frequency Program")
			ScannerModes(7) = New ScannerMode("? (7)", "Unknown")
			ScannerModes(8) = New ScannerMode("TUNE", "Rotary Tune Frequency")
			ScannerModes(9) = New ScannerMode("MOT SRCH", "Motorola ID Search")
			ScannerModes(10) = New ScannerMode("MOT SRCH H", "Motorola ID Search Hold")
			ScannerModes(11) = New ScannerMode("MOT SCAN", "Motorola ID Scan")
			ScannerModes(12) = New ScannerMode("MOT MAN", "Motorola ID Manual")
			ScannerModes(13) = New ScannerMode("EDACS SRCH", "EDACS ID Search")
			ScannerModes(14) = New ScannerMode("EDACS HOLD", "EDACS ID Hold")
			ScannerModes(15) = New ScannerMode("EDACS SCAN", "EDACS ID Scan")
			ScannerModes(16) = New ScannerMode("EDACS MAN", "EDACS ID Manual")
			ScannerModes(17) = New ScannerMode("LTR SRCH", "LTR Search")
			ScannerModes(18) = New ScannerMode("LTR HOLD", "LTR Hold")
			ScannerModes(19) = New ScannerMode("LTR SCAN", "LTR Scan")
			ScannerModes(20) = New ScannerMode("LTR MAN", "LTR Manual")
			ScannerModes(21) = New ScannerMode("? (21)", "Unknown")

		End Sub

        ''' <summary>
        ''' Gets the screen refresh commands.
        ''' </summary>
        ''' <value>The screen refresh commands.</value>
        Public Overrides ReadOnly Property ScreenRefreshCommands() As List(Of Command)
            Get

                Dim cmd As New List(Of Command)
                Dim BC780Commands As CommandSets.BC780CommandSet = New CommandSets.BC780CommandSet

                cmd.Add(BC780Commands.LCDLine1)
                cmd.Add(BC780Commands.LCDLine2)
                cmd.Add(BC780Commands.SignalStrength)
                cmd.Add(BC780Commands.ReceiverModulation)
                cmd.Add(BC780Commands.Attenuator)
                cmd.Add(BC780Commands.Muting)
                cmd.Add(BC780Commands.StepSize)
                cmd.Add(BC780Commands.WindowVoltage)
                cmd.Add(BC780Commands.Mode)
                cmd.Add(BC780Commands.SquelchStatus)

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
                Return New Command("LCD LINE 1", New CallbackHandlerDelegate(AddressOf Line1CallbackHandler))
            End Get
        End Property
        Public Overrides ReadOnly Property LCDLine2() As Command
            Get
                Return New Command("LCD LINE 2", New CallbackHandlerDelegate(AddressOf Line2CallbackHandler))
            End Get
        End Property

	End Class

End Namespace


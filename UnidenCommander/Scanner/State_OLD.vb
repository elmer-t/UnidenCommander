
Namespace Scanner

	Public Class State_OLD

		Public Model As ScannerModels = ScannerModels.Unknown
		Public ModelName As String = String.Empty
		Public Version As String = String.Empty
		Public Mode As String

		Public IsMuted As Boolean = False
		Public IsAttenuated As Boolean = False

		'  check if scanner is present
		'IsConnected = True
		'IsConnected = (SendCommand("VR") <> String.Empty)

		' get mute state from scanner
		'isMuted = (MuteState() = "MUN")

		' get ATT state from scanner
		'isAttenuated = (AttenuatorState() = "ATN")

	End Class


End Namespace

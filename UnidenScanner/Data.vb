
Public Class SystemInformation
    Public ModelName As String
    Public ESNNumber As String
    Public RemoteCommandVersion As String
    Public Sub New()
        Me.ModelName = "Unknown"
        Me.ESNNumber = "Unknown"
        Me.RemoteCommandVersion = "Unknown"
    End Sub
End Class

Public Structure SignalStrength
    Public Strength As Integer
    Public Frequency As Integer
End Structure

Public Enum ScannerBoolean
    [On] = 78
    [Off] = 70
    [Auto] = 65
End Enum

Public Enum Modulations
    AM = 1
    FM = 2
    NFM = 3
    WFM = 4
    AUTO = 5
    NA = 6 ' Not available
End Enum

Public Enum StepSizes
    Step5K
    Step6_25K
    Step12_5K
    Step25K
    Step50K
    Step10K
    Step100K
    Step7_5K
    'Step8_33K
    StepAUTO
End Enum

Public Enum ScannerModels
    Generic
    'BC245
    'BC250
    BC780
    BC785
    'BC895
    'BCT8
    'PRO2052
    Unknown
End Enum

Public Enum ScanDirections
    Up
    Down
End Enum

''' <summary>
''' Types of object to alpha tag. Values match ASCII code of code to send to scanner
''' </summary>
Public Enum AlphaTagType
    ''' <summary>
    ''' Conventional bank alpha tag (A-J). Command=B.
    ''' </summary>
    ScanBank = 66
    ''' <summary>
    ''' Conventional channel alpha tag (3-digits). Command=C.
    ''' </summary>
    Channel = 67
    ''' <summary>
    ''' Talkgroup alpha tag. Command=I.
    ''' </summary>
    TalkGroup = 73
    ''' <summary>
    ''' Scanlist alpha tag (A1-J0). Command=L.
    ''' </summary>
    ScanList = 76
    ''' <summary>
    ''' Search range alpha tag. Command=S.
    ''' </summary>
    SearchRange = 83
End Enum

Public Enum Properties
    Attenuated
    Channel
    Frequency
    Line1
    Line2
    Line3
    Line4
    LockOut
    Mode
    Model
    Modulation
    Muted
    PriorityChannel
    PriorityScan
    Banks
    ScanDirection
    SearchBanks
    SignalStrength
    SquelchOpen
    StepSize
    SystemInformation
    WindowVoltage
End Enum

Public Class ScannerMode
    Public ShortName As String
    Public LongName As String
    Public Sub New(ByVal shortName As String, ByVal longName As String)
        Me.ShortName = shortName
        Me.LongName = longName
    End Sub
End Class

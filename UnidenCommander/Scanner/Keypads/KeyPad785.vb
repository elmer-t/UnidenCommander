
Namespace Scanner.KeyPads

    Public Class BC785KeyPad
		Inherits KeyPads.GenericKeyPad

        Public Overrides ReadOnly Property ATTENUATOR() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overrides ReadOnly Property SERVICE_SEARCH() As String
            Get
                Return "10" ' AIR button
            End Get
        End Property
        Public Overrides ReadOnly Property HOLD() As String
            Get
                Return "07"
            End Get
        End Property
        Public Overrides ReadOnly Property LIMIT() As String
            Get
                Return "08"
            End Get
        End Property
        Public Overrides ReadOnly Property MANUAL() As String
            Get
                Return "07"
            End Get
        End Property
        Public Overrides ReadOnly Property MENU() As String
            Get
                Return "11"
            End Get
        End Property
        Public Overrides ReadOnly Property MUTE() As String
            Get
                Return "12H"
            End Get
        End Property
        Public Overrides ReadOnly Property PERIOD() As String
            Get
                Return "03"
            End Get
        End Property
        Public Overrides ReadOnly Property RELEASE_REMOTE_CONTROL() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overrides ReadOnly Property ROTARY_DOWN() As String
            Get
                Return "16"
            End Get
        End Property
        Public Overrides ReadOnly Property ROTARY_PUSH() As String
            Get
                Return "14"
            End Get
        End Property
        Public Overrides ReadOnly Property ROTARY_UP() As String
            Get
                Return "15"
            End Get
        End Property
        Public Overrides ReadOnly Property RSM() As String
            Get
                Return "00"
            End Get
        End Property
        Public Overrides ReadOnly Property SEARCH_MENU() As String
            Get
                Return "09H"
            End Get
        End Property
        Public Overrides ReadOnly Property TRANSFER() As String
            Get
                Return "12"
            End Get
        End Property
        Public Overrides ReadOnly Property SCAN() As String
            Get
                Return "01"
            End Get
        End Property

    End Class

End Namespace


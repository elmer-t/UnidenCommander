
Namespace KeyPads

    Public Class GenericKeyPad

        Public Const NOT_SUPPORTED As String = "99"

        Public Overridable ReadOnly Property NO_0() As String
            Get
                Return "02 0"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_1() As String
            Get
                Return "02 1"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_2() As String
            Get
                Return "02 2"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_3() As String
            Get
                Return "02 3"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_4() As String
            Get
                Return "02 4"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_5() As String
            Get
                Return "02 5"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_6() As String
            Get
                Return "02 6"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_7() As String
            Get
                Return "02 7"
            End Get
        End Property
        Public Overridable ReadOnly Property NO_8() As String
            Get
                Return "02 8"
            End Get
        End Property

        Public Overridable ReadOnly Property NO_9() As String
            Get
                Return "02 9"
            End Get
        End Property

        Public Overridable ReadOnly Property ENTER() As String
            Get
                Return "04"
            End Get
        End Property
        Public Overridable ReadOnly Property PRIORITY() As String
            Get
                Return "05"
            End Get
        End Property
        Public Overridable ReadOnly Property LOCKOUT() As String
            Get
                Return "06"
            End Get
        End Property
        Public Overridable ReadOnly Property SEARCH() As String
            Get
                Return "09"
            End Get
        End Property
        Public Overridable ReadOnly Property TRUNK() As String
            Get
                Return "13"
            End Get
        End Property

        Public Overridable ReadOnly Property ATTENUATOR() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property SERVICE_SEARCH() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property HOLD() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property LIMIT() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property MANUAL() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property MENU() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property MUTE() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property PERIOD() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property RELEASE_REMOTE_CONTROL() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property ROTARY_DOWN() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property ROTARY_PUSH() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property ROTARY_UP() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property RSM() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property SEARCH_MENU() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property TRANSFER() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property SCAN() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property REVERSE() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property
        Public Overridable ReadOnly Property [SELECT]() As String
            Get
                Return NOT_SUPPORTED
            End Get
        End Property

    End Class

End Namespace


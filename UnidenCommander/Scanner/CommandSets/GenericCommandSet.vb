
Imports System.Text.RegularExpressions

Namespace Scanner.CommandSets

    ''' <summary>
    ''' Represents a generic command set, containing only commands that work on *all* supported models.
    ''' </summary>
    Public Class GenericCommandSet
        Inherits BaseCommandSet
        Implements ICommandSet

        ''' <summary>
        ''' Gets the scanner modes.
        ''' </summary>
        ''' <value>The scanner modes.</value>
        Public Overrides ReadOnly Property ScannerModes() As Dictionary(Of Integer, ScannerMode)
            Get
                Return _scannerModes
            End Get
        End Property

        ''' <summary>
        ''' Gets the screen refresh commands.
        ''' </summary>
        ''' <value>The screen refresh commands.</value>
        Public Overrides ReadOnly Property ScreenRefreshCommands() As System.Collections.Generic.List(Of Command)
            Get
                Return New System.Collections.Generic.List(Of Command)
            End Get
        End Property

    End Class

End Namespace


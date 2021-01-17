
Imports UnidenCommander.Utils
Imports UnidenCommander.Scanner

Public Class MainForm

    Private queueBusy As Boolean
	Private scnr As Scanner.Models.BaseScannerModel
    Private squelchState As Boolean
    Private autoRefreshDisplay As Boolean = True

    Private Delegate Sub SubDelegate()
    Private Delegate Sub DataReceivedDelegate(ByVal command As Command)
	Private Delegate Sub ResponseReceived_Delegate(ByVal response As String)
	Private Delegate Sub SetButtonState_Delegate(ByVal enabled As Boolean)

	Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Logger.Trace(Me, "Load")

            ' Window title
            Me.Text = String.Format("{0} v.{1}", Application.ProductName, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())

            Me.InitializeScreen()

#If DEBUG Then
            Me.txtCommand.Visible = True
            Me.btnCommand.Visible = True
#End If

        Catch ex As Exception
            DisplayException(ex)
        End Try

		' wait before connection to scanner; allows form to finish loading
		firstRunTimer.Interval = My.Settings.FirstLoadWaitTime
		firstRunTimer.Start()

	End Sub

	Private Sub firstRunTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstRunTimer.Tick

		Logger.Trace(Me, "firstRunTimer_Tick")

		firstRunTimer.Stop()
		InitializeScanner()

	End Sub

	Private Sub InitializeScanner()

        Try

            Logger.Trace(Me, "InitializeScanner")

            Me.lblStatus.Text = "Connecting..."


            If scnr Is Nothing Then scnr = New Scanner.Models.BaseScannerModel(ScannerModels.Generic)
            scnr.ConnectionPort = My.Settings.Port
            scnr.ConnectionSpeed = My.Settings.Speed
            scnr.ConnectionTimeout = My.Settings.ConnectionTimeout

            RemoveEventHandlers()
            AddEventHandlers()

            scnr.Connect()
            scnr.CommandQueue.Enqueue(scnr.CommandSet.SystemInformation)

            ' Start display refresh loop
            FireQueuedCommands()

            ' enable all buttons and menus
            SetButtonState(True)
            DisconnectToolStripMenuItem.Enabled = True

        Catch ex As Exception
            Me.lblStatus.Text = "Connection error"
            DisplayException(ex)
        End Try

	End Sub

	Private Sub AddEventHandlers()
		Logger.Trace(Me, "AddEventHandlers")
		AddHandler scnr.CommandTimeoutEvent, AddressOf ConnectionTimeoutEventHandler
		AddHandler scnr.PropertyChanged, AddressOf ScannerPropertyChanged
		AddHandler scnr.DataReceived, AddressOf ScannerDataReceived
		AddHandler scnr.LastCommandExecuted, AddressOf QueueEmptyEventHandler
	End Sub

	Private Sub RemoveEventHandlers()
		Logger.Trace(Me, "RemoveEventHandlers")
		RemoveHandler scnr.LastCommandExecuted, AddressOf QueueEmptyEventHandler
		RemoveHandler scnr.DataReceived, AddressOf ScannerDataReceived
		RemoveHandler scnr.PropertyChanged, AddressOf ScannerPropertyChanged
		RemoveHandler scnr.CommandTimeoutEvent, AddressOf ConnectionTimeoutEventHandler
	End Sub

	Private Sub InitializeScreen()

		Logger.Trace(Me, "InitializeScreen")

		' status labels
		Me.lblPort.Text = My.Settings.Port
		Me.lblSpeed.Text = My.Settings.Speed.ToString
        Me.lblScannerInfo.Text = "None"
		Me.lblStatus.Text = "OK"

		' reset scanner screen
		Me.Display1.Reset()

		' disable all buttons
		SetButtonState(False)
        Me.ConnectToolStripMenuItem.Enabled = False
        Me.DisconnectToolStripMenuItem.Enabled = False

	End Sub

	Private Sub ScannerState2Screen()

        If InvokeRequired Then
            Dim del As New SubDelegate(AddressOf ScannerState2Screen)
            Invoke(del)
        End If

        Logger.Trace(Me, "ScannerState2Screen")

		If Not Me.scnr Is Nothing AndAlso Not scnr.SystemInformation Is Nothing Then

			Me.lblScannerInfo.Text = Me.scnr.SystemInformation.ModelName
			Me.lblStatus.Text = "OK"

		End If

	End Sub

	Private Sub ConnectionTimeoutEventHandler(ByVal e As EventArgs)

		Logger.Trace(Me, "ConnectionTimeoutEventHandler")

		Me.lblStatus.Text = "Time-out error"
        Me.ConnectToolStripMenuItem.Enabled = True
        Me.DisconnectToolStripMenuItem.Enabled = False

		MessageBox.Show( _
		   "The scanner did not respond in a timely fashion." & Environment.NewLine & "Please make sure your scanner is connected properly and check your settings.", _
		   "Time-out", _
		   MessageBoxButtons.OK, _
		   MessageBoxIcon.Exclamation _
		)

	End Sub

    Private Sub DisplayException(ByVal ex As Exception)

        Logger.Trace(Me, "DisplayException")

        Dim msg As String = ex.Message

#If DEBUG Then
        msg = ex.ToString
#End If

        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub scannerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scannerInfoToolStripMenuItem.Click

        Logger.Trace(Me, "scannerInfoToolStripMenuItem_Click")

        Try

            If Me.scnr.IsConnected AndAlso scnr.SystemInformation IsNot Nothing Then

                MessageBox.Show( _
                 String.Format("Model: {0}\rESN no.: {1}\rVersion: {2}", scnr.SystemInformation.ModelName, scnr.SystemInformation.ESNNumber, scnr.SystemInformation.RemoteCommandVersion).Replace("\r", Environment.NewLine), _
                 "Scanner information", _
                 MessageBoxButtons.OK, _
                 MessageBoxIcon.Information _
                )

            Else
                MessageBox.Show("No scanner was found. Make sure your scanner is connected properly and check your settings.", "No scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            DisplayException(ex)
        End Try

    End Sub

	Private Sub PressKey(ByVal keyCode As String)

		Logger.Trace(Me, String.Format("PressKey({0})", keyCode))

		If Me.scnr.IsConnected Then
			If keyCode <> UnidenCommander.Scanner.KeyPads.GenericKeyPad.NOT_SUPPORTED Then
				'lblStatus.Text = scnr.Commands.KEY(keyCode)
				scnr.CommandQueue.Enqueue(New Command("KEY" & keyCode))
			Else
				MessageBox.Show("This command is not supported by your scanner, or your scanner was not recognised correctly.", "Unsupported command", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If
		Else
			MessageBox.Show("No scanner was found. Make sure your scanner is connected properly and check your settings.", "No scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If

	End Sub

#Region " Keypad events "

	Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
		PressKey(Me.scnr.KeyPad.SCAN)
	End Sub

	Private Sub btnHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHold.Click
		PressKey(Me.scnr.KeyPad.HOLD)
	End Sub

	Private Sub btnAir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAir.Click
		PressKey(Me.scnr.KeyPad.SERVICE_SEARCH)
	End Sub

	Private Sub btnSrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrch.Click
		PressKey(Me.scnr.KeyPad.SEARCH)
	End Sub

	Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
		PressKey(Me.scnr.KeyPad.MENU)
	End Sub

	Private Sub btnMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMute.Click

		If Me.scnr.Muted = ScannerBoolean.On Then
            scnr.CommandQueue.Enqueue(scnr.CommandSet.Muting(ScannerBoolean.Auto))
		Else
            scnr.CommandQueue.Enqueue(scnr.CommandSet.Muting(ScannerBoolean.On))
		End If

	End Sub

	Private Sub btnRsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRsm.Click
		PressKey(Me.scnr.KeyPad.RSM)
	End Sub

	Private Sub btnLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimit.Click
		PressKey(Me.scnr.KeyPad.LIMIT)
	End Sub

	Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
		PressKey(Me.scnr.KeyPad.MANUAL)
	End Sub

	Private Sub btnLockOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockOut.Click
		PressKey(Me.scnr.KeyPad.LOCKOUT)
	End Sub

	Private Sub btnPriority_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPriority.Click
		PressKey(Me.scnr.KeyPad.PRIORITY)
	End Sub

	Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
		PressKey(Me.scnr.KeyPad.TRANSFER)
	End Sub

	Private Sub btnATT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnATT.Click

		If scnr.Attenuated = ScannerBoolean.On Then
            scnr.CommandQueue.Enqueue(scnr.CommandSet.Attenuator(ScannerBoolean.Off))
		Else
            scnr.CommandQueue.Enqueue(scnr.CommandSet.Attenuator(ScannerBoolean.On))
		End If

	End Sub

	Private Sub btnRvrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRvrs.Click
		PressKey(Me.scnr.KeyPad.REVERSE)
	End Sub

	Private Sub btnModeAM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeAM.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.ReceiverModulation(Modulations.AM))
	End Sub

	Private Sub btnModeFM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeFM.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.ReceiverModulation(Modulations.FM))
	End Sub

	Private Sub btnModeNFM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeNFM.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.ReceiverModulation(Modulations.NFM))
	End Sub

	Private Sub btnModeWFM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeWFM.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.ReceiverModulation(Modulations.WFM))
	End Sub

	Private Sub btnModeAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeAuto.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.ReceiverModulation(Modulations.AUTO))
	End Sub

	Private Sub btnRotaryDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotaryDown.Click
		PressKey(Me.scnr.KeyPad.ROTARY_DOWN)
	End Sub

	Private Sub btnRotarySelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotarySelect.Click
		Select Case Me.scnr.Model
			Case ScannerModels.BC780
				PressKey(Me.scnr.KeyPad.SELECT)
			Case ScannerModels.BC785
				PressKey(Me.scnr.KeyPad.ROTARY_PUSH)
		End Select
	End Sub

	Private Sub btnRotaryUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotaryUp.Click
		PressKey(Me.scnr.KeyPad.ROTARY_UP)
	End Sub

	Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
		PressKey(Me.scnr.KeyPad.NO_1)
	End Sub

	Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
		PressKey(Me.scnr.KeyPad.NO_2)
	End Sub

	Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
		PressKey(Me.scnr.KeyPad.NO_3)
	End Sub

	Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
		PressKey(Me.scnr.KeyPad.NO_4)
	End Sub

	Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
		PressKey(Me.scnr.KeyPad.NO_5)
	End Sub

	Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
		PressKey(Me.scnr.KeyPad.NO_6)
	End Sub

	Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
		PressKey(Me.scnr.KeyPad.NO_7)
	End Sub

	Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
		PressKey(Me.scnr.KeyPad.NO_8)
	End Sub

	Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
		PressKey(Me.scnr.KeyPad.NO_9)
	End Sub

	Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
		PressKey(Me.scnr.KeyPad.NO_0)
	End Sub

	Private Sub btnPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriod.Click
		PressKey(Me.scnr.KeyPad.PERIOD)
	End Sub

	Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
		PressKey(Me.scnr.KeyPad.ENTER)
	End Sub

	Private Sub btnStep5k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep5k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step5K))
	End Sub

	Private Sub btnStep6_25k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep6_25k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step6_25K))
	End Sub

	Private Sub btnStep12_5k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep12_5k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step12_5K))
	End Sub

	Private Sub btnStep25k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep25k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step25K))
	End Sub

	Private Sub btnStep50k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep50k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step50K))
    End Sub

	Private Sub btnStep10k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep10k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step10K))
	End Sub

	Private Sub btnStep100k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep100k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step100K))
	End Sub

	Private Sub btnStep7_5k_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep7_5k.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.Step7_5K))
	End Sub

	Private Sub btnStepAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepAuto.Click
        scnr.CommandQueue.Enqueue(scnr.CommandSet.StepSize(StepSizes.StepAUTO))
	End Sub

	'Private Sub btnCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommand.Click
	'       lblStatus.Text = scnr.Commands.Command(txtCommand.Text)
	'End Sub

#End Region

	Private Sub SetButtonState(ByVal enabled As Boolean)
		Logger.Trace(Me, String.Format("SetButtonState(InvokeRequired={0})", InvokeRequired))

		If InvokeRequired Then
			Dim del As New SetButtonState_Delegate(AddressOf SetButtonState)
			Invoke(del, New Object() {enabled})
		End If

		For Each c As Control In Me.Controls

            If c.GetType Is GetType(UnidenCommander.Controls.PushButton) Then
                c.Enabled = enabled
                DirectCast(c, UnidenCommander.Controls.PushButton).SetState(False)
            End If

		Next

	End Sub

    ''' <summary>
    ''' This gets called if the queue was empty and UC has to wait for new commands.
    ''' The QueueEmptyEventHandler is called to fire new command, if any.
    ''' </summary>
    ''' <param name="state">The state.</param>
    Private Sub EmptyQueueWaitTimerCallbackHandler(ByVal state As Object)

        ' The state object is the Timer object, destroy it.
        Dim t As System.Threading.Timer = CType(state, System.Threading.Timer)
        t.Dispose()

        QueueEmptyEventHandler(Nothing)

    End Sub

    Private Sub QueueEmptyEventHandler(ByVal e As EventArgs)
        Logger.Trace(Me, "QueueEmptyEventHandler")

        If Me.scnr.IsConnected AndAlso queueBusy = False Then

            FillScreenRefreshCommands()

            ' If the queue is empty, can happen if AutoRefreshDisplay = false,
            ' then wait a while before trying to fire queued commands.
            If scnr.CommandQueue.Count = 0 Then

                Dim t As New System.Threading.Timer(AddressOf EmptyQueueWaitTimerCallbackHandler)
                t.Change(My.Settings.EmptyQueueWaitTime, 0)

            End If

            FireQueuedCommands()

        End If

    End Sub

	Private Sub FireQueuedCommands()
		Logger.Trace(Me, "FireQueuedCommands")

        queueBusy = True

        While scnr.CommandQueue.Count > 0

            ' Mark last command as IsLast=True
            If scnr.CommandQueue.Count = 1 Then
                Dim cmd As Command = scnr.CommandQueue.Dequeue
                cmd.IsLastInQueue = True
                scnr.CommandQueue.Enqueue(cmd)
            End If

            scnr.ExecuteCommand(scnr.CommandQueue.Dequeue)

        End While

		queueBusy = False

	End Sub

	Private Sub ScannerPropertyChanged(ByVal prop As Properties)
		Logger.Trace(Me, String.Format("ScannerPropertyChanged({0})", prop.ToString))

		Select Case prop
			Case Properties.Attenuated
				Me.Display1.Attenuated = scnr.Attenuated

			Case Properties.Muted
				Me.Display1.Muted = scnr.Muted

			Case Properties.SquelchOpen
                ' If squelch state has changed, then log changes
                If squelchState = Not scnr.SquelchOpen Then

                    If scnr.SquelchOpen = True Then
                        ' Remember state of scanner when squelch goes open

                    Else
                        ' Squelch closed, now log the reception

                    End If

                    'Logger.SaveReception(scnr)

                End If
                squelchState = scnr.SquelchOpen

			Case Properties.Channel
				Me.Display1.Channel = scnr.Channel

			Case Properties.Modulation
				Me.Display1.Modulation = scnr.Modulation

                If My.Settings.AnimateButtons Then
                    Me.btnModeAM.SetState(scnr.Modulation = Modulations.AM)
                    Me.btnModeFM.SetState(scnr.Modulation = Modulations.FM)
                    Me.btnModeNFM.SetState(scnr.Modulation = Modulations.NFM)
                    Me.btnModeWFM.SetState(scnr.Modulation = Modulations.WFM)
                End If

            Case Properties.Frequency
                Me.Display1.Frequency = scnr.Frequency

            Case Properties.Mode
                Me.Display1.Mode = scnr.Mode

            Case Properties.Line1
                Me.Display1.Line1 = scnr.Line1

            Case Properties.Line2
                Me.Display1.Line2 = scnr.Line2

            Case Properties.Line3
                Me.Display1.Line3 = scnr.Line3

            Case Properties.Line4
                Me.Display1.Line4 = scnr.Line4

            Case Properties.LockOut
                Me.Display1.LockOut = scnr.LockOut

            Case Properties.PriorityChannel
                Me.Display1.Priority = scnr.PriorityChannel

            Case Properties.Banks
                Me.BanksToScreen()

            Case Properties.SignalStrength
                Me.Display1.SignalStrength = scnr.SignalStrength

            Case Properties.StepSize
                Me.Display1.StepSize = scnr.StepSize

                If My.Settings.AnimateButtons Then
                    Me.btnStep5k.SetState(scnr.StepSize = StepSizes.Step5K)
                    Me.btnStep6_25k.SetState(scnr.StepSize = StepSizes.Step6_25K)
                    Me.btnStep7_5k.SetState(scnr.StepSize = StepSizes.Step7_5K)
                    Me.btnStep10k.SetState(scnr.StepSize = StepSizes.Step10K)
                    Me.btnStep12_5k.SetState(scnr.StepSize = StepSizes.Step12_5K)
                    Me.btnStep25k.SetState(scnr.StepSize = StepSizes.Step25K)
                    Me.btnStep50k.SetState(scnr.StepSize = StepSizes.Step50K)
                    Me.btnStep100k.SetState(scnr.StepSize = StepSizes.Step100K)
                End If
                
            Case Properties.Model

            Case Properties.SystemInformation
                ScannerState2Screen()

            Case Properties.WindowVoltage
                Me.Display1.SetWindowVoltage(scnr.WindowVoltage)

            Case Else
                'MessageBox.Show(String.Format("Property {0} has changed.", name))
        End Select

        Me.Display1.RefreshDisplay()

    End Sub

    Private Sub FillScreenRefreshCommands()
        Logger.Trace(Me, "FillScreenRefreshCommands")

        If Me.autoRefreshDisplay Then

            ' Fill with screen refresh commands
            For Each cmd As Command In scnr.CommandSet.ScreenRefreshCommands
                scnr.CommandQueue.Enqueue(cmd)
            Next

        End If

    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnReadBanks control. 
    ''' Reads scan banks and search range alpha tags from scanner.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub btnReadBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadBanks.Click
        Logger.Trace(Me, "btnReadBanks_Click")

        For i As Integer = Convert.ToInt32("A"c) To Convert.ToInt32("J"c)

            scnr.CommandQueue.Enqueue( _
                scnr.CommandSet.ReadAlphaTags(AlphaTagType.ScanBank, Convert.ToChar(i)) _
            )

            scnr.CommandQueue.Enqueue( _
                scnr.CommandSet.ReadAlphaTags(AlphaTagType.SearchRange, Convert.ToChar(i)) _
            )

        Next


    End Sub

    Private Sub btnWriteBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteBanks.Click
        Logger.Trace(Me, "btnWriteBanks_Click")

        For Each b As Bank In scnr.Banks.Values

            scnr.CommandQueue.Enqueue( _
               scnr.CommandSet.WriteAlphaTags(AlphaTagType.ScanBank, b.Character, b.ScanBankTag) _
            )

            scnr.CommandQueue.Enqueue( _
                scnr.CommandSet.WriteAlphaTags(AlphaTagType.SearchRange, b.Character, b.SearchRangeTag) _
            )

        Next

    End Sub

    Private Sub BanksToScreen()
        Logger.Trace(Me, "BanksToScreen")

        If InvokeRequired Then
            Dim del As New SubDelegate(AddressOf BanksToScreen)
            Invoke(del)
        End If

        Try

            gridBanks.SuspendLayout()
            'gridBanks.Rows.Clear()

            Dim i As Integer

            ' Add bank tags to datagrid
            For Each item As System.Collections.Generic.KeyValuePair(Of Char, Bank) In scnr.Banks

                If gridBanks.RowCount <= i Then gridBanks.Rows.Add()
                gridBanks.Rows(i).Cells("Number").Value = item.Value.Number.ToString
                gridBanks.Rows(i).Cells("ScanBank").Value = item.Value.ScanBankTag
                gridBanks.Rows(i).Cells("SearchBank").Value = item.Value.SearchRangeTag

                i += 1

            Next

            gridBanks.ResumeLayout()

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub ScannerDataReceived(ByVal cmd As Command)

        If InvokeRequired Then
            Dim del As New DataReceivedDelegate(AddressOf ScannerDataReceived)
            Invoke(del, New Object() {cmd})
            Exit Sub
        End If

        Logger.Log(String.Format("{0} -> {1}", cmd.Command.PadRight(6), cmd.Response))

    End Sub

#Region " Menu events "

    Private Sub BorderlessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorderlessToolStripMenuItem.Click
        Logger.Trace(Me, "BorderlessToolStripMenuItem_Click")

        ' set border style
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        ' (re)set menu items
        Me.BorderlessToolStripMenuItem.Checked = True
        Me.NormalToolStripMenuItem.Checked = False

    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Logger.Trace(Me, "NormalToolStripMenuItem_Click")

        ' set border style
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable

        ' (re)set menu items
        Me.BorderlessToolStripMenuItem.Checked = False
        Me.NormalToolStripMenuItem.Checked = True

    End Sub

    Private Sub DisplayOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Logger.Trace(Me, "DisplayOnlyToolStripMenuItem_Click")

        ' set border style
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Width = Me.Display1.Width
        Me.Height = Me.Display1.Height

        ' (re)set menu items
        Me.BorderlessToolStripMenuItem.Checked = False
        Me.NormalToolStripMenuItem.Checked = False

    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        Logger.Trace(Me, "DisconnectToolStripMenuItem_Click")

        Me.scnr.Disconnect()
        Me.RemoveEventHandlers()
        Me.InitializeScreen()
        Me.ConnectToolStripMenuItem.Enabled = True

    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        Logger.Trace(Me, "DisconnectToolStripMenuItem_Click")

        If scnr.IsConnected Then
            Me.RemoveEventHandlers()
            Me.scnr.Disconnect()
        End If

        Me.InitializeScreen()
        Me.InitializeScanner()

    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
        Logger.Trace(Me, "aboutToolStripMenuItem_Click")
        Dim f As New AboutForm
        f.ShowDialog()
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Logger.Trace(Me, "exitToolStripMenuItem_Click")

        Me.RemoveEventHandlers()
        Me.scnr.Disconnect()
        Application.Exit()

    End Sub

    Private Sub settingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsToolStripMenuItem.Click
        Logger.Trace(Me, "settingsToolStripMenuItem_Click")

        RemoveEventHandlers()

        Dim f As New SettingsForm
        f.ShowDialog()

        ' Always close and re-open connection
        ' Re-opening only when settings have changed made app unresponsive
        Me.scnr.Disconnect()

        Me.InitializeScreen()
        Me.InitializeScanner()

    End Sub

#End Region

    Private Sub btnCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommand.Click

        Dim x As New InvalidExpressionException
        Throw New ApplicationException("Test exception", x)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim f As Font
        For Each c As Control In Me.Controls

            If c.GetType.Name = "Button" Then
                f = New Font(SystemFonts.DialogFont.FontFamily, c.Font.Size, c.Font.Style)
                c.Font = f
            End If

        Next

    End Sub

    Private Sub ChannelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChannelsToolStripMenuItem.Click

        MessageBox.Show("Comming soon...", "Channels", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub gridBanks_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridBanks.CellEndEdit

        ' Alpha tag was edited, now put it back into scanner object scnr

        ' Get bank character (A...J)
        Dim chr As Char = Convert.ToChar(e.RowIndex + 65)

        ' Get stored bank from scanner object
        Dim storedBank As Bank = scnr.Banks(chr)

        ' Update tag(s) in bank
        storedBank.ScanBankTag = gridBanks.Rows(e.RowIndex).Cells("ScanBank").Value.ToString
        storedBank.SearchRangeTag = gridBanks.Rows(e.RowIndex).Cells("SearchBank").Value.ToString

        ' Put bank back into scanner object
        scnr.Banks(chr) = storedBank

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.autoRefreshDisplay = TabControl1.SelectedIndex = 0
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveEventHandlers()
        'Me.scnr.Disconnect()
    End Sub

    Private Sub gridReceptionLog_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridReceptionLog.CellContentClick
        MessageBox.Show( _
            "This feature is planned for one of the next versions. Please go to Help -> About to check if you have the latest version or visit dx.torensma.net.", _
            "Comming soon", MessageBoxButtons.OK, MessageBoxIcon.Information _
        )
    End Sub

End Class

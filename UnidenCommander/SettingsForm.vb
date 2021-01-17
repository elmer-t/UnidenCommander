Public Class SettingsForm

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

		Try

            ' Connection
			My.Settings.Port = Convert.ToString(Me.lstPorts.SelectedItem)
			My.Settings.Speed = Convert.ToInt32(Me.lstSpeeds.SelectedItem)
            My.Settings.ConnectionTimeout = TimeoutTrackBar.Value * 1000

            ' User interface
            My.Settings.AnimateButtons = Me.chkAnimateButtons.Checked

            ' Logging
            My.Settings.LogReceptions = chkReceptionLogging.Checked
            My.Settings.LogTrace = chkSaveTraceLog.Checked
            My.Settings.LogSerialCommands = chkSaveCommunicationsLog.Checked
            ' Logging paths
            My.Settings.LogReceptionsPath = txtLogReceptionPath.Text
            My.Settings.LogSerialCommandsPath = txtLogSerialCommandsPath.Text
            My.Settings.LogTracePath = txtLogTracePath.Text

            My.Settings.Save()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetRadioButtonTag(ByVal grp As GroupBox) As Object

        For Each item As Control In grp.Controls

            If item.GetType().Name = "RadioButton" Then
                If CType(item, RadioButton).Checked Then
                    Return item.Tag
                End If
            End If

        Next

        Return Nothing

    End Function

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Connection
        Me.lstSpeeds.Items.Add("2400")
        Me.lstSpeeds.Items.Add("4800")
        Me.lstSpeeds.Items.Add("9600")
        Me.lstSpeeds.Items.Add("19200")

        For Each item As String In System.IO.Ports.SerialPort.GetPortNames
            Me.lstPorts.Items.Add(item)
        Next

        Me.lstSpeeds.SelectedItem = My.Settings.Speed.ToString()
        Me.lstPorts.SelectedItem = My.Settings.Port

        Me.TimeoutTrackBar.Value = Convert.ToInt32(My.Settings.ConnectionTimeout / 1000)
        Me.TimeoutTextbox.Text = TimeoutTrackBar.Value.ToString

        ' User interface
        Me.chkAnimateButtons.Checked = My.Settings.AnimateButtons

        ' Logging
        Me.chkReceptionLogging.Checked = My.Settings.LogReceptions
        Me.chkSaveCommunicationsLog.Checked = My.Settings.LogSerialCommands
        Me.chkSaveTraceLog.Checked = My.Settings.LogTrace
        Me.txtLogReceptionPath.Text = My.Settings.LogReceptionsPath
        Me.txtLogSerialCommandsPath.Text = My.Settings.LogSerialCommandsPath
        Me.txtLogTracePath.Text = My.Settings.LogTracePath

    End Sub

	Private Sub TimeoutTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeoutTrackBar.Scroll
		Me.TimeoutTextbox.Text = Me.TimeoutTrackBar.Value.ToString
	End Sub

    
    
    Private Function SelectFileLocation(ByVal selectedPath As String) As String

        Dim f As New SaveFileDialog

        f.AddExtension = True
        f.AutoUpgradeEnabled = True
        f.DefaultExt = "txt"
        f.FileName = selectedPath
        f.RestoreDirectory = True

        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return f.FileName
        Else
            Return selectedPath
        End If

    End Function

    Private Sub btnSelectLogReceptionPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectLogReceptionPath.Click
        txtLogReceptionPath.Text = SelectFileLocation(txtLogReceptionPath.Text)
    End Sub

    Private Sub btnSelectLogSerialCommandsPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectLogSerialCommandsPath.Click
        txtLogSerialCommandsPath.Text = SelectFileLocation(txtLogSerialCommandsPath.Text)
    End Sub

    Private Sub btnSelectLogTracePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectLogTracePath.Click
        txtLogTracePath.Text = SelectFileLocation(txtLogTracePath.Text)
    End Sub

End Class

Imports System.Xml

Public NotInheritable Class AboutForm

    Private Sub AboutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the title of the form.
        Dim ApplicationTitle As String

        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.labelProductName.Text = My.Application.Info.ProductName
        Me.labelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.labelCopyright.Text = String.Format("{0} - {1}.", My.Application.Info.Copyright, My.Application.Info.CompanyName)
        Me.labelDescription.Text = My.Application.Info.Description

        Me.VersionCheckTimer.Enabled = True
        Me.VersionCheckTimer.Start()

    End Sub

    Private Sub CheckVersion()

        Try

            ' Get version XML
            Dim reader As New XmlTextReader(My.Settings.VersionCheckUrl)
            Dim doc As New XmlDocument
            doc.Load(reader)

            ' Get version string
            Dim nd As XmlNode = doc.SelectSingleNode("//unidencommander/versions/stable/current")
            Dim latestVersion As New System.Version( _
                Convert.ToInt32(nd.Attributes("major").Value), _
                Convert.ToInt32(nd.Attributes("minor").Value), _
                Convert.ToInt32(nd.Attributes("build").Value), _
                Convert.ToInt32(nd.Attributes("revision").Value) _
            )

            If latestVersion <= My.Application.Info.Version Then
                Me.picVersionCheckStatus.Image = Global.UnidenCommander.My.Resources.Images.complete_16x16
                Me.lblVersionCheckStatus.Text = String.Format("UnidenCommander is up to date ({0})", latestVersion.ToString)

            ElseIf latestVersion > My.Application.Info.Version Then
                Me.picVersionCheckStatus.Image = Global.UnidenCommander.My.Resources.Images.warning_16x16
                Me.lblVersionCheckStatus.Text = String.Format("A newer verion of UnidenCommander is available ({0})", latestVersion.ToString)

            End If

        Catch ex As Exception

            Me.picVersionCheckStatus.Image = Global.UnidenCommander.My.Resources.Images.warning_16x16
            Me.lblVersionCheckStatus.Text = "Version check failed"

        End Try

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Private Sub VersionCheckTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VersionCheckTimer.Tick

        Me.VersionCheckTimer.Enabled = False
        Me.VersionCheckTimer.Stop()

        Me.CheckVersion()

    End Sub

    Private Sub lblVersionCheckStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVersionCheckStatus.Click

    End Sub
    Private Sub picVersionCheckStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picVersionCheckStatus.Click

    End Sub
End Class

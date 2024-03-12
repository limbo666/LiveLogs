Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports LiveLogs.SoundModule


Public Class frmConditionalOptions

    Dim EasterEggCounter As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Keyword1 = txtInfo.Text
        Keyword2 = txtWarning.Text
        Keyword3 = txtError.Text
        Keyword4 = txtCritical.Text
        Keyword5 = txtFatal.Text
        Keyword6 = txtCustom.Text

        LaunchKeyword = txtIntegration.Text
        LaunchPath = txtTargetPath.Text
        PopUpKeyword = txtPopup.Text
        SoundKeyword = txtSound.Text

        RegSaveSetting("Settings", "Keyword1", Keyword1)
        RegSaveSetting("Settings", "Keyword2", Keyword2)
        RegSaveSetting("Settings", "Keyword3", Keyword3)
        RegSaveSetting("Settings", "Keyword4", Keyword4)
        RegSaveSetting("Settings", "Keyword5", Keyword5)
        RegSaveSetting("Settings", "Keyword6", Keyword6)

        RegSaveSetting("Settings", "LaunchKeyword", LaunchKeyword)
        RegSaveSetting("Settings", "LaunchPath", LaunchPath)
        RegSaveSetting("Settings", "PopUpKeyword", PopUpKeyword)
        RegSaveSetting("Settings", "SoundKeyword", SoundKeyword)

        Me.Close()
    End Sub

    Private Sub frmConditionalOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = form1.Top + (form1.Height - Height) / 2
        Left = form1.Left + (form1.Width - Width) / 2
        txtInfo.Text = Keyword1
        txtWarning.Text = Keyword2
        txtError.Text = Keyword3
        txtCritical.Text = Keyword4
        txtFatal.Text = Keyword5
        txtCustom.Text = Keyword6
        txtIntegration.Text = LaunchKeyword
        txtTargetPath.Text = LaunchPath
        txtPopup.Text = PopUpKeyword
        txtSound.Text = SoundKeyword

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set initial directory to the path in txtTargetPath if it's not empty, otherwise set it to the desktop path
        If Not String.IsNullOrEmpty(txtTargetPath.Text) AndAlso File.Exists(txtTargetPath.Text) Then
            openFileDialog.InitialDirectory = Path.GetDirectoryName(txtTargetPath.Text)
        Else
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        End If

        ' Filter for exe, vbs, bat, and com files
        openFileDialog.Filter = "Executable Files (*.exe;*.vbs;*.bat;*.com)|*.exe;*.vbs;*.bat;*.com"

        ' Display the OpenFileDialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the selected file path to the textbox
            txtTargetPath.Text = openFileDialog.FileName
        End If
    End Sub


    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ExecuteExternalProgram(txtTargetPath.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopSound()
        PlaySoundFromResourcesAsync("NotificationSound3")
    End Sub



    Private Sub txtPopup_DoubleClick(sender As Object, e As EventArgs) Handles txtPopup.DoubleClick
        EasterEggCounter += 1
        tmrEasterEgg.Enabled = True
        If EasterEggCounter = 7 Then
            EasterEggCounter = 0
            tmrEasterEgg.Enabled = False
            txtPopup.Text = "Bizzare"
            txtSound.Text = "Weird"
            txtIntegration.Text = "Strange"
            EasterEggsRevealed = True
            StopSound()
            PlaySoundFromResourcesAsync("NotificationSound4")
        End If
    End Sub



    Private Sub txtSound_DoubleClick(sender As Object, e As EventArgs) Handles txtSound.DoubleClick
        EasterEggCounter += 4
        tmrEasterEgg.Enabled = True
        If EasterEggCounter = 7 Then
            EasterEggCounter = 0
            tmrEasterEgg.Enabled = False
            txtPopup.Text = "Bizzare"
            txtSound.Text = "Weird"
            txtIntegration.Text = "Strange"
            EasterEggsRevealed = True
            StopSound()
            PlaySoundFromResourcesAsync("NotificationSound4")
        End If
    End Sub



    Private Sub txtIntegration_DoubleClick(sender As Object, e As EventArgs) Handles txtIntegration.DoubleClick
        EasterEggCounter += 2
        tmrEasterEgg.Enabled = True
        If EasterEggCounter = 7 Then
            EasterEggCounter = 0
            tmrEasterEgg.Enabled = False
            txtPopup.Text = "Bizzare"
            txtSound.Text = "Weird"
            txtIntegration.Text = "Strange"
            EasterEggsRevealed = True
            StopSound()
            PlaySoundFromResourcesAsync("NotificationSound4")
        End If
    End Sub

    Private Sub tmrEasterEgg_Tick(sender As Object, e As EventArgs) Handles tmrEasterEgg.Tick
        tmrEasterEgg.Enabled = False
        EasterEggCounter = 0

    End Sub

    Private Sub txtPopup_TextChanged(sender As Object, e As EventArgs) Handles txtPopup.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmPopup.Show()


    End Sub

    Private Sub txtIntegration_TextChanged(sender As Object, e As EventArgs) Handles txtIntegration.TextChanged

    End Sub
End Class
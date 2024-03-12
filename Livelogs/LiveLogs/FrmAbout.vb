Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = form1.Top + ((form1.Height - Me.Height) / 2)
        Me.Left = form1.Left + ((form1.Width - Me.Width) / 2)

        Dim fullVersion As String = Application.ProductVersion
        Dim versionOnly As String
        If fullVersion.IndexOf("+") > -1 Then
            versionOnly = fullVersion.Split("+"c)(0) ' Extract the version part before the "+"
        Else
            versionOnly = fullVersion
        End If


        '   Console.WriteLine("Version without extra characters: " & versionOnly)

        Label1.Text = Application.ProductName
        Label2.Text = versionOnly
        '   InputBox("getit",, versionOnly)
        Label3.Text = Application.CompanyName
        If EasterEggsRevealed = True = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            EasterEggsRevealed = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
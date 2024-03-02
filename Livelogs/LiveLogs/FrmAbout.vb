Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = form1.Top + ((form1.Height - Me.Height) / 2)
        Me.Left = form1.Left + ((form1.Width - Me.Width) / 2)

        Label1.Text = Application.ProductName
        Label2.Text = Application.ProductVersion
        Label3.Text = Application.CompanyName
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
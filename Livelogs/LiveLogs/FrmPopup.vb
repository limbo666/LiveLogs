Public Class FrmPopup
    Private Sub FrmPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = PopUpKeyword




        If form1.WindowState = vbNormal Then
            Me.Top = form1.Top + ((form1.Height - Me.Height) / 2)
            Me.Left = form1.Left + form1.Width
        End If



    End Sub

    Private Sub lblLine_Click(sender As Object, e As EventArgs) Handles lblLine.Click
        Try
            Clipboard.SetText(lblLine.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class
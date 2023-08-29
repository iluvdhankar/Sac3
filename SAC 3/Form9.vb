Public Class frmAboutpage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAboutinfo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblAbouttitle.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackAbout.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub
End Class
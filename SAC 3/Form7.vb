Public Class frmOtherpage
    Private Sub PicBoxotherHome_Click(sender As Object, e As EventArgs) Handles PicBoxotherHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnBackOther_Click(sender As Object, e As EventArgs) Handles btnBackOther.Click
        Me.Hide()
        frmCategorypage.Show()
    End Sub

    Private Sub PicBoxdetailsOther_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsOther.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class
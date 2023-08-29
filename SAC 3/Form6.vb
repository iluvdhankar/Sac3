Public Class frmTabletpage
    Private Sub PicBoxtabletHome_Click(sender As Object, e As EventArgs) Handles PicBoxtabletHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnBackTablet_Click(sender As Object, e As EventArgs) Handles btnBackTablet.Click
        Me.Hide()
        frmCategorypage.Show()
    End Sub

    Private Sub PicBoxdetailsTablet_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsTablet.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class
Public Class frmHomepage
    'Changes from main page to About Us page'
    Private Sub PicBoxAbout_Click(sender As Object, e As EventArgs) Handles PicBoxAbout.Click
        Me.Hide()
        frmAboutpage.Show()
    End Sub

    'Switches from homepage to category page'
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Me.Hide()
        frmCategorypage.Show()
    End Sub

    Private Sub PicBoxdetailsHome_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsHome.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class

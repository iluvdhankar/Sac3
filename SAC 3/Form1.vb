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

    Private Sub btnbuyphone2_Click(sender As Object, e As EventArgs) Handles btnbuyphone2.Click
        Globals.finalorderdata += "Samsung Galaxy Z Fold5" & vbCrLf
        Globals.finalprice += 1400
    End Sub

    Private Sub btnbuyother1_Click(sender As Object, e As EventArgs) Handles btnbuyother1.Click
        Globals.finalorderdata += "Samsung Galaxy Watch 6" & vbCrLf
        Globals.finalprice += 500
    End Sub

    Private Sub btnbuyphone3_Click(sender As Object, e As EventArgs) Handles btnbuyphone3.Click
        Globals.finalorderdata += "Samsung Galaxy Z Flip5" & vbCrLf
        Globals.finalprice += 1200
    End Sub

    Private Sub btnbuytablet1_Click(sender As Object, e As EventArgs) Handles btnbuytablet1.Click
        Globals.finalorderdata += "Samsung Galaxy Tab S9 Ultra" & vbCrLf
        Globals.finalprice += 1345
    End Sub
End Class

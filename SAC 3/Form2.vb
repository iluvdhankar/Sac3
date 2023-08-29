Public Class frmCategorypage

    Private Sub btnLaptops_Click(sender As Object, e As EventArgs) Handles btnLaptops.Click
        Me.Hide()
        frmLaptoppage.Show()
    End Sub

    Private Sub PicBoxAbout_Click(sender As Object, e As EventArgs) Handles PicBoxcategoryHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnPhone_Click(sender As Object, e As EventArgs) Handles btnPhone.Click
        Me.Hide()
        frmPhonepage.Show()
    End Sub

    Private Sub btnTablet_Click(sender As Object, e As EventArgs) Handles btnTablet.Click
        Me.Hide()
        frmTabletpage.Show()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Me.Hide()
        frmOtherpage.Show()
    End Sub

    Private Sub PicBoxdetailsCategory_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsCategory.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class
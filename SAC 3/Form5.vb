Public Class frmPhonepage

    Private Sub frmPhonepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PicBoxphoneCategory_Click(sender As Object, e As EventArgs) Handles PicBoxphoneHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnBackPhone_Click(sender As Object, e As EventArgs) Handles btnBackPhone.Click
        Me.Hide()
        frmCategorypage.Show()
    End Sub

    Private Sub PicBoxdetailsPhone_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsPhone.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class
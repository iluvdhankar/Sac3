Public Class frmLaptoppage
    Private Sub frmLaptoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PicBoxHome_Click(sender As Object, e As EventArgs) Handles PicBoxlaptopHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnBackLaptop_Click(sender As Object, e As EventArgs) Handles btnBackLaptop.Click
        Me.Hide()
        frmCategorypage.Show()
    End Sub

    Private Sub PicBoxdetailsLaptop_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsLaptop.Click
        Me.Hide()
        frmDetailspage.Show()
    End Sub
End Class
Imports System.IO

Public Class frmDetailspage
    Private Sub PicBoxdetailsHome_Click(sender As Object, e As EventArgs) Handles PicBoxdetailsHome.Click
        Me.Hide()
        frmHomepage.Show()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        WriteDataToFile(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, txtEmail.Text)

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtEmail.Text = "" 'Reset the fields
        txtAddress.Text = ""
        Globals.finalorderdata = ""
        Globals.finalprice = 0
    End Sub

    Public Sub WriteDataToFile(firstName As String, lastName As String, phone As String, email As String, amountOrdered As String)
        'Write data to a txt file, you can change this to an acdb
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim folderPath As String = Path.Combine(appDataPath, "GadgetWorld")

        ' Create the folder if it doesn't exist
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim filePath As String = Path.Combine(folderPath, "data.txt")

        ' Append data to the file
        Using writer As New StreamWriter(filePath, True)
            Dim data As String = $"{firstName},{lastName},{phone},{email},{amountOrdered}"
            writer.WriteLine(data)
        End Using
    End Sub

    Private Sub frmDetailspage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOrderSummary.Text = Globals.finalorderdata + Environment.NewLine + Environment.NewLine + "TOTAL: $" + Globals.finalprice.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim folderPath As String = Path.Combine(appDataPath, "GadgetWorld")
        Dim filePath As String = Path.Combine(folderPath, "data.txt")

        If File.Exists(filePath) Then
            File.WriteAllText(filePath, String.Empty)
        End If
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim folderPath As String = Path.Combine(appDataPath, "GadgetWorld")
        Dim filePath As String = Path.Combine(folderPath, "data.txt")

        If File.Exists(filePath) Then
            Dim allData As String = File.ReadAllText(filePath)
            If Not String.IsNullOrEmpty(allData) Then
                MessageBox.Show(allData, "All Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("File not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
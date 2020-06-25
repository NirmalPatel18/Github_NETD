Public Class frmName
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show(txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

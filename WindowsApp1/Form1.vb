
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        MessageBox.Show(EH_ServiceTargetReports35.ChangePropertyBasedOnValue.ChangeColor(Convert.ToSingle(TextBox1.Text), "#A23341"))

    End Sub
End Class

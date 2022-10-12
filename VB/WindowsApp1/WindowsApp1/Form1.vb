Public Class Form1
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub buybutton_Click(sender As Object, e As EventArgs) Handles buybutton.Click
        Dim amount As Decimal
        Decimal.TryParse(costtextbox.Text, amount)
        nametextbox.Clear()
        cctextbox.Clear()
        exptextbox.Clear()
        ziptextbox.Clear()
        costtextbox.Clear()
        Dim fee As Decimal
        fee = amount * 0.03
        feetextBox1.Text = fee.ToString("C2")


    End Sub

End Class

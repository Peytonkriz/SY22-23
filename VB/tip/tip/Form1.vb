Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tip As Decimal
        Dim percent As Decimal
        Dim GrandTotal As Decimal
        Dim tax As Decimal
        Decimal.TryParse(TextBox1.Text, tip)
        percent = tip * 0.15
        GrandTotal = tip * 1.2
        tax = tip * 0.05
        Label1.Text = percent.ToString("N2")
        Label2.Text = GrandTotal.ToString("N2")
        Label3.Text = tax.ToString("N2")



    End Sub
End Class

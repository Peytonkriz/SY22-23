Public Class Form1
    Private Sub ConvertButton1_Click(sender As Object, e As EventArgs) Handles ConvertButton1.Click
        Dim dollars As Decimal
        Dim pesos As Decimal
        Dim koruna As Decimal
        Dim canadiandollar As Decimal
        Dim yen As Decimal
        Dim pound As Decimal
        Decimal.TryParse(usTextBox5.Text, dollars)
        pesos = dollars * 20
        pound = dollars * 19
        yen = dollars * 137
        koruna = dollars * 25
        canadiandollar = dollars * 1.3
        mexTextBox1.Text = pesos.ToString("N2")
        czechTextBox2.Text = koruna.ToString("N2")
        canTextBox4.Text = canadiandollar.ToString("N2")
        japanTextBox6.Text = yen.ToString("N2")
        egyptTextBox3.Text = pound.ToString("N2")



    End Sub
End Class

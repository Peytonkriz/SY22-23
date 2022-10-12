Public Class F


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displayPictureBox.Image = sunsPictureBox2.Image
        Winslabel.Text = "64"
        Losslabel.Text = "18"
        AvgPointslabel.Text = "114"
    End Sub



    Private Sub Netsbutton_Click(sender As Object, e As EventArgs) Handles Netsbutton.Click
        displayPictureBox.Image = netsPictureBox1.Image
        Winslabel.Text = "44"
        Losslabel.Text = "38"
        AvgPointslabel.Text = "112"
    End Sub
End Class

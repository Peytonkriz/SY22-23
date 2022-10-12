Public Class Form3
    Private Sub fortButton1_Click(sender As Object, e As EventArgs) Handles fortButton1.Click
        Integer.TryParse(fortTextBox1.Text, fort)


    End Sub

    Private Sub nbaButton2_Click(sender As Object, e As EventArgs) Handles nbaButton2.Click
        Integer.TryParse(nbaTextBox2.Text, nba)
    End Sub

    Private Sub fallButton3_Click(sender As Object, e As EventArgs) Handles fallButton3.Click
        Integer.TryParse(fallTextBox3.Text, fall)
    End Sub
End Class
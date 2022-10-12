Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.ShowDialog()

    End Sub

    Private Sub wowcButton1_Click(sender As Object, e As EventArgs) Handles wowcButton1.Click
        Integer.TryParse(wowcTextBox1.Text, wowc)
    End Sub

    Private Sub raftButton2_Click(sender As Object, e As EventArgs) Handles raftButton2.Click
        Integer.TryParse(TextBoxraft.Text, raft)
    End Sub
End Class
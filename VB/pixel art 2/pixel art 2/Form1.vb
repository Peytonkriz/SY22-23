Public Class Form1
    Dim drawcolor As Color
    Sub clear()
        For index = 1 To 100
            Controls("picturebox" & index).BackColor = Color.White
        Next
    End Sub
    Sub fill(c As Color)
        For index = 1 To 100
            Controls("picturebox" & index).BackColor = Color.Red
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 1 To 100
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.None
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For index = 1 To 100
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.FixedSingle
        Next
    End Sub

    Private Sub PictureBox91_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox99.MouseMove, PictureBox98.MouseMove, PictureBox97.MouseMove, PictureBox96.MouseMove, PictureBox95.MouseMove, PictureBox94.MouseMove, PictureBox93.MouseMove, PictureBox92.MouseMove, PictureBox91.MouseMove, PictureBox90.MouseMove, PictureBox9.MouseMove, PictureBox89.MouseMove, PictureBox88.MouseMove, PictureBox87.MouseMove, PictureBox86.MouseMove, PictureBox85.MouseMove, PictureBox84.MouseMove, PictureBox83.MouseMove, PictureBox82.MouseMove, PictureBox81.MouseMove, PictureBox80.MouseMove, PictureBox8.MouseMove, PictureBox79.MouseMove, PictureBox78.MouseMove, PictureBox77.MouseMove, PictureBox76.MouseMove, PictureBox75.MouseMove, PictureBox74.MouseMove, PictureBox73.MouseMove, PictureBox72.MouseMove, PictureBox71.MouseMove, PictureBox70.MouseMove, PictureBox7.MouseMove, PictureBox69.MouseMove, PictureBox68.MouseMove, PictureBox67.MouseMove, PictureBox66.MouseMove, PictureBox65.MouseMove, PictureBox64.MouseMove, PictureBox63.MouseMove, PictureBox62.MouseMove, PictureBox61.MouseMove, PictureBox60.MouseMove, PictureBox6.MouseMove, PictureBox59.MouseMove, PictureBox58.MouseMove, PictureBox57.MouseMove, PictureBox56.MouseMove, PictureBox55.MouseMove, PictureBox54.MouseMove, PictureBox53.MouseMove, PictureBox52.MouseMove, PictureBox51.MouseMove, PictureBox50.MouseMove, PictureBox5.MouseMove, PictureBox49.MouseMove, PictureBox48.MouseMove, PictureBox47.MouseMove, PictureBox46.MouseMove, PictureBox45.MouseMove, PictureBox44.MouseMove, PictureBox43.MouseMove, PictureBox42.MouseMove, PictureBox41.MouseMove, PictureBox40.MouseMove, PictureBox4.MouseMove, PictureBox39.MouseMove, PictureBox38.MouseMove, PictureBox37.MouseMove, PictureBox36.MouseMove, PictureBox35.MouseMove, PictureBox34.MouseMove, PictureBox33.MouseMove, PictureBox32.MouseMove, PictureBox31.MouseMove, PictureBox30.MouseMove, PictureBox3.MouseMove, PictureBox29.MouseMove, PictureBox28.MouseMove, PictureBox27.MouseMove, PictureBox26.MouseMove, PictureBox25.MouseMove, PictureBox24.MouseMove, PictureBox23.MouseMove, PictureBox22.MouseMove, PictureBox21.MouseMove, PictureBox20.MouseMove, PictureBox2.MouseMove, PictureBox19.MouseMove, PictureBox18.MouseMove, PictureBox17.MouseMove, PictureBox16.MouseMove, PictureBox15.MouseMove, PictureBox14.MouseMove, PictureBox13.MouseMove, PictureBox12.MouseMove, PictureBox11.MouseMove, PictureBox100.MouseMove, PictureBox10.MouseMove, PictureBox1.MouseMove
        sender.backcolor = drawcolor
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button12.Click, Button4.Click, Button3.Click, Button11.Click, Button10.Click
        drawcolor = sender.backcolor
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ColorDialog1.ShowDialog()
        sender.backcolor = ColorDialog1.Color
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        clear()
    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            ColorDialog1.ShowDialog()
            sender.backcolor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ColorDialog1.ShowDialog()
        sender.backcolor = ColorDialog1.Color
        For index = 1 To 100
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BackColor = drawcolor
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub
End Class

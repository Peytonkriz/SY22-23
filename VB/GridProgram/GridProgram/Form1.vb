Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For row = 0 To 40
            For col = 0 To 40
                CreatePicture(PictureBox1, row, col)
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Green
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Row = 0 To 20
            For col = 0 To 40
                GetPicture(col, Row).BackColor = Color.Orange
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Row = 0 To 40
            For col = 0 To 20
                GetPicture(col, Row).BackColor = Color.Blue
            Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Row = 0 To 40 Step 4
            For col = 0 To 40
                GetPicture(col, Row).BackColor = Color.White
            Next
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Row = 0 To 40 Step 2
            For col = 0 To 40 Step 2
                GetPicture(Row, col).BackColor = Color.Black
            Next
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For row = 0 To 40
            For col = 0 To 40
                If row Mod 2 = 0 Then
                    GetPicture(row, col).BackColor = Color.Yellow
                End If
            Next
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For row = 0 To 40
            For col = 0 To 40
                If col < row Then
                    GetPicture(row, col).BackColor = Button8.BackColor
                End If
            Next
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ColorDialog1.ShowDialog()
        sender.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        For Row = 0 To 40
            For col = 20 To 40
                GetPicture(col, Row).BackColor = Color.LightGreen
            Next
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For Row = 20 To 40
            For col = 0 To 40
                GetPicture(col, Row).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For row = 0 To 40
            For col = 0 To 40
                If row Mod 4 = 0 Then
                    GetPicture(row, col).BackColor = Color.OliveDrab
                End If
            Next
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For row = 0 To 40
            For col = 0 To 40
                If col < row Then
                    GetPicture(col, row).BackColor = Color.PaleGoldenrod
                End If
            Next
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        For row = 0 To 40
            For col = 0 To 40
                If row < col Then
                    GetPicture(row, col).BackColor = Color.BurlyWood
                End If
            Next
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For Row = 0 To 40
            For col = 10 To 30
                GetPicture(col, Row).BackColor = Color.LightGoldenrodYellow
            Next
        Next
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GetPicture(10, 10).BackColor = Color.DarkBlue
        GetPicture(30, 10).BackColor = Color.DarkBlue
        GetPicture(10, 11).BackColor = Color.White
        GetPicture(9, 11).BackColor = Color.White
        GetPicture(11, 11).BackColor = Color.White
        GetPicture(9, 10).BackColor = Color.White
        GetPicture(10, 9).BackColor = Color.White
        GetPicture(9, 9).BackColor = Color.White
        GetPicture(11, 9).BackColor = Color.White
        GetPicture(11, 10).BackColor = Color.White
        GetPicture(30, 9).BackColor = Color.White
        GetPicture(30, 11).BackColor = Color.White
        GetPicture(31, 9).BackColor = Color.White
        GetPicture(31, 10).BackColor = Color.White
        GetPicture(31, 11).BackColor = Color.White
        GetPicture(29, 11).BackColor = Color.White
        GetPicture(30, 11).BackColor = Color.White
        GetPicture(31, 11).BackColor = Color.White
        GetPicture(29, 9).BackColor = Color.White
        GetPicture(29, 10).BackColor = Color.White
        GetPicture(9, 17).BackColor = Color.DarkRed
        GetPicture(10, 18).BackColor = Color.DarkRed
        GetPicture(11, 19).BackColor = Color.DarkRed
        GetPicture(12, 20).BackColor = Color.DarkRed
        GetPicture(13, 20).BackColor = Color.DarkRed
        GetPicture(14, 20).BackColor = Color.DarkRed
        GetPicture(15, 20).BackColor = Color.DarkRed
        GetPicture(16, 20).BackColor = Color.DarkRed
        GetPicture(17, 20).BackColor = Color.DarkRed
        GetPicture(18, 20).BackColor = Color.DarkRed
        GetPicture(19, 20).BackColor = Color.DarkRed
        GetPicture(20, 20).BackColor = Color.DarkRed
        GetPicture(21, 20).BackColor = Color.DarkRed
        GetPicture(22, 20).BackColor = Color.DarkRed
        GetPicture(23, 20).BackColor = Color.DarkRed
        GetPicture(24, 20).BackColor = Color.DarkRed
        GetPicture(25, 20).BackColor = Color.DarkRed
        GetPicture(26, 20).BackColor = Color.DarkRed
        GetPicture(27, 20).BackColor = Color.DarkRed
        GetPicture(28, 20).BackColor = Color.DarkRed
        GetPicture(29, 19).BackColor = Color.DarkRed
        GetPicture(30, 18).BackColor = Color.DarkRed
        GetPicture(31, 17).BackColor = Color.DarkRed
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        For Row = 10 To 30
            For col = 0 To 40
                GetPicture(col, Row).BackColor = Color.LightGoldenrodYellow
            Next
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Row = 0 To 13
            For col = 0 To 20
                GetPicture(col, Row).BackColor = Color.LawnGreen
            Next
        Next
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        For Row = 14 To 26
            For col = 0 To 20
                GetPicture(col, Row).BackColor = Color.BlueViolet
            Next
        Next
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        For Row = 27 To 40
            For col = 0 To 20
                GetPicture(col, Row).BackColor = Color.OrangeRed
            Next
        Next
    End Sub
End Class

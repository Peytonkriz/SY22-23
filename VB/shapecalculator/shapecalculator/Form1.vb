Public Class Form1
    Private Sub calculate()
        Dim length As Integer
        Dim width As Integer

        Integer.TryParse(TextBoxlength.Text, length)
        Integer.TryParse(TextBoxwidth.Text, width)
        TextBoxarea.Text = rectanglearea(length, width)
        Textboxperimeter.Text = rectangleperimeter(length, width)
    End Sub
    Function rectanglearea(l As Integer, w As Integer) As Integer
        Return l * w
    End Function
    Function rectangleperimeter(l As Integer, w As Integer) As Integer
        Return 2 * l + 2 * w
    End Function

    Private Sub lengthTrackBar_Scroll(sender As Object, e As EventArgs) Handles lengthTrackBar.Scroll
        TextBoxlength.Text = lengthTrackBar.Value
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBoxwidth.Text = TrackBar1.Value
    End Sub

    Private Sub TextBoxwidth_TextChanged(sender As Object, e As EventArgs) Handles TextBoxwidth.TextChanged, TextBoxlength.TextChanged
        calculate()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Radiustextbox.Text = TrackBar2.Value
    End Sub


    Private Sub Radiustextbox_TextChanged(sender As Object, e As EventArgs) Handles Radiustextbox.TextChanged
        Dim radius As Integer
        Integer.TryParse(Radiustextbox.Text, radius)

    End Sub
End Class

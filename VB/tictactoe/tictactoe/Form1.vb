Public Class Form1
    Dim turn As String = ""
    Dim score1 As Integer
    Dim score2 As Integer
    Sub reset()
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
        Label3.Text = score1
        Label4.Text = score2
    End Sub
    Sub click(b As Button)
        If turn = "X" Then
            turn = "O"
        Else
            turn = "X"
        End If
    End Sub



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click
        click(sender)
        If iswinner() Then
            Me.BackColor = Color.Green
            If turn = "X" Then
                score2 = score2 + 1
            Else
                score1 = score1 + 1
            End If
            Label3.Text = score1
            Label4.Text = score2
            MsgBox("Winner")
            reset()
        End If



    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
    Function iswinner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> "" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> "" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> "" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> "" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> "" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> "" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> "" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> "" Then Return True


        Return False
    End Function
End Class

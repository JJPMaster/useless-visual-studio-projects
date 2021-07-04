Public Class Form1
    Dim TotalScore1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Users\Tekga\Downloads\albanian.wav")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Language Land, where you will guess languages.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TotalScore1 += 100
        Button5.BackColor = Color.LightGreen
        Label3.Text = (TotalScore1)
        Button4.Hide()
        Button3.Hide()
        Button2.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TotalScore1 -= 100
        Button5.BackColor = Color.LightGreen
        Button2.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TotalScore1 -= 100
        Button5.BackColor = Color.LightGreen
        Button3.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TotalScore1 -= 100
        Button5.BackColor = Color.LightGreen
        Button4.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play("C:\Users\Tekga\Downloads\portuguese.wav")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TotalScore1 += 100
        Button8.BackColor = Color.LightGreen
        Label3.Text = (TotalScore1)
        Button7.Hide()
        Button9.Hide()
        Button10.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TotalScore1 -= 100
        Button8.BackColor = Color.LightGreen
        Button9.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TotalScore1 -= 100
        Button8.BackColor = Color.LightGreen
        Button7.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TotalScore1 -= 100
        Button8.BackColor = Color.LightGreen
        Button10.BackColor = Color.DarkRed
        Label3.Text = (TotalScore1)
        If TotalScore1 < 0 Then
            MsgBox("You have a negative score. Game over.")
            Close()
        End If
    End Sub
End Class

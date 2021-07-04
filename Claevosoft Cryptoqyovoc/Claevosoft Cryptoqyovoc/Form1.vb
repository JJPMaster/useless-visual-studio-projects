Public Class Form1
    Dim thing As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        thing += 1000
        Label1.Text = (thing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        thing -= 20
        Label1.Text = (thing)
        If thing < 0 Then
            MsgBox("You are in debt! Game over.")
            Close()
        End If
        Label5.Text = ("Water Bottle(s)")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label5.Text = ("Water Bottle(s)") Then
            Label5.Text = ("")
            thing += 20
            Label1.Text = (thing)
        End If
    End Sub
End Class

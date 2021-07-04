Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("The Third Coming is angry. He says the following: You crashed my programs, now I'll crash you.", MsgBoxStyle.Critical)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "THe Third Coming is back! Press the button to end him for good!"
    End Sub
End Class

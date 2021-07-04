Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Label1.Text = OpenFileDialog1.FileName
        My.Computer.Audio.Play(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog2.ShowDialog()
        Label5.Text = OpenFileDialog2.FileName
        My.Computer.Audio.Play(OpenFileDialog2.FileName)
    End Sub
End Class

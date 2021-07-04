Public Class Form1
    Dim Thing = 1000
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ProgressBar1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do Until ProgressBar1.Value = 100
            ProgressBar1.Increment(10)
            If ProgressBar1.Value = 100 Then
                Label1.Show()
            End If
            If My.Computer.FileSystem.FileExists("C:\Users\Tekga\source\repos\ESC\ESC\obj\Debug\ESC.exe") Then
                Label1.Text = "Your computer has OnachPC.TrojanHorse.ESC!"
                Button2.Show()
            End If
        Loop
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.DeleteFile("C:\Users\Tekga\source\repos\ESC\ESC\obj\Debug\ESC.exe")
    End Sub
End Class
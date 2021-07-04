Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Process As New Process()
        Dim Number As Integer = 0
        ListView1.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            ListView1.Items.Add(Process.ProcessName)
        Next
    End Sub
End Class

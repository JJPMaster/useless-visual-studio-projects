﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RemoteDesktop1.Connect(TextBox1.Text)
    End Sub
End Class

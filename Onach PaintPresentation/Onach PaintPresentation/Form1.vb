Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        OpenFileDialog3.ShowDialog()
        If (OpenFileDialog3.ShowDialog = DialogResult.OK) Then
            PictureBox3.Image = Image.FromFile(OpenFileDialog3.FileName)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        OpenFileDialog2.ShowDialog()
        If (OpenFileDialog2.ShowDialog = DialogResult.OK) Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        OpenFileDialog4.ShowDialog()
        If (OpenFileDialog4.ShowDialog = DialogResult.OK) Then
            PictureBox4.Image = Image.FromFile(OpenFileDialog4.FileName)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        OpenFileDialog5.ShowDialog()
        If (OpenFileDialog5.ShowDialog = DialogResult.OK) Then
            PictureBox5.Image = Image.FromFile(OpenFileDialog5.FileName)
        End If
    End Sub
End Class

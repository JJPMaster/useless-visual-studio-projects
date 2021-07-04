Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        Dim SFD As New SaveFileDialog
        If RichTextBox1.Text.Length > 0 Then
            IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FontDialog1.ShowDialog()
        If (FontDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog2.ShowDialog()
        If (ColorDialog2.ShowDialog = DialogResult.OK) Then
            RichTextBox1.BackColor = ColorDialog2.Color
        End If
    End Sub
End Class
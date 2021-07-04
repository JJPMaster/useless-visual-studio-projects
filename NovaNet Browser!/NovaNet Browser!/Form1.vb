Public Class Form1
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()

        If (RichTextBox1.Text.Contains("novahome.orig")) Then
            Label1.Show()
            Label2.Show()
            Label3.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RichTextBox1.Text.Contains("novahome.orig")) Then
            Label1.Show()
            Label2.Show()
            Label3.Show()
        End If
        If (RichTextBox1.Text.Contains("prestomanickandjilly.orig")) Then
            Label1.Show()
            Label3.Hide()
            Label1.Text = ("1. I'm not special anymore: I saw K.S. solving a cube, and people gave all credit to her.")
            Label2.Text = ("2. Pranked?: D.K. became my 30th subscriber, but said he was my 29th.")
        End If
    End Sub
End Class

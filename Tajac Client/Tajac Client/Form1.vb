Public Class Form1
    Dim Price = 0
    Dim Loc As Random
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Top -= 10
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox1.Top += 10
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox1.Left -= 10
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox1.Left += 10
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox8.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Contains("rf -nh")) Then
            PictureBox8.Show()
        End If
        If (TextBox1.Text.Contains("rf - nh")) Then
            PictureBox8.Show()
        End If

        If (TextBox1.Text.Contains("red")) Then
            PictureBox7.Hide()
        End If
        If (TextBox1.Text.Contains("front")) Then
            PictureBox11.BringToFront()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
    End Sub

    Private Sub Win()
        MsgBox("You won!")
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Win()
        Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Win()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Win()
            Close()
        End If
        If CheckBox4.Checked = False Then
            MsgBox("ConCheat has detected cheating! The game cannot continue.")
            Close()
        End If
        If CheckBox4.Checked = True Then
            MsgBox("ProCheat has been used to bypass ConCheat. The game may continue.")
        End If
        PictureBox10.Hide()
        Label6.Hide()
        Label7.Hide()
        Button2.Hide()
        Button3.Hide()
        Label9.Hide()
        CheckBox4.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        PictureBox8.Show()
        Label2.Show()
        Label3.Show()
        Label5.Show()
        PictureBox7.Show()
        Label7.Show()
        CheckBox4.Show()
        Label10.Show()
    End Sub

	Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

	End Sub

	Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

	End Sub
End Class

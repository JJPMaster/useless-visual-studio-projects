Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text.Replace("a", "1b2c")
        TextBox1.Text = TextBox1.Text.Replace("b", "2c3d")
        TextBox1.Text = TextBox1.Text.Replace("c", "3d4e")
        TextBox1.Text = TextBox1.Text.Replace("d", "4e5f")
        TextBox1.Text = TextBox1.Text.Replace("e", "5f6g")
        TextBox1.Text = TextBox1.Text.Replace("f", "6g7h")
        TextBox1.Text = TextBox1.Text.Replace("g", "7h8i")
        TextBox1.Text = TextBox1.Text.Replace("h", "8i9j")
        TextBox1.Text = TextBox1.Text.Replace("i", "9j10k")
        TextBox1.Text = TextBox1.Text.Replace("j", "10k11l")
        TextBox1.Text = TextBox1.Text.Replace("k", "11l12m")
        TextBox1.Text = TextBox1.Text.Replace("l", "12m13n")
        TextBox1.Text = TextBox1.Text.Replace("m", "13n14o")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = TextBox2.Text.Replace("n", "14o15p")
        TextBox2.Text = TextBox2.Text.Replace("o", "15p16q")
        TextBox2.Text = TextBox2.Text.Replace("p", "16q17r")
        TextBox2.Text = TextBox2.Text.Replace("q", "17r18s")
        TextBox2.Text = TextBox2.Text.Replace("r", "18s19t")
        TextBox2.Text = TextBox2.Text.Replace("s", "19t20u")
        TextBox2.Text = TextBox2.Text.Replace("t", "20u21v")
        TextBox2.Text = TextBox2.Text.Replace("u", "21v22w")
        TextBox2.Text = TextBox2.Text.Replace("v", "22w23x")
        TextBox2.Text = TextBox2.Text.Replace("w", "23x24y")
        TextBox2.Text = TextBox2.Text.Replace("x", "24y25z")
        TextBox2.Text = TextBox2.Text.Replace("y", "25z26a")
        TextBox2.Text = TextBox2.Text.Replace("z", "26a27b")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = TextBox3.Text.Replace("0", "j11k12")
        TextBox3.Text = TextBox3.Text.Replace("1", "a2b3")
        TextBox3.Text = TextBox3.Text.Replace("2", "b3c4")
        TextBox3.Text = TextBox3.Text.Replace("3", "c4d5")
        TextBox3.Text = TextBox3.Text.Replace("4", "d5e6")
        TextBox3.Text = TextBox3.Text.Replace("5", "e6f7")
        TextBox3.Text = TextBox3.Text.Replace("6", "f7g8")
        TextBox3.Text = TextBox3.Text.Replace("7", "g8h9")
        TextBox3.Text = TextBox3.Text.Replace("8", "h9i10")
        TextBox3.Text = TextBox3.Text.Replace("9", "i10j11")
    End Sub
End Class

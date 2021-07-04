Public Class Form1
    Dim Num1 As Single
    Dim Num2 As Single
    Dim Ans As Single
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox3.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button12.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox3.Hide()
        Button3.Hide()
        Button1.Hide()
        Button2.Hide()
        Label2.Hide()
        Button12.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Hide()
        PictureBox3.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Label2.Hide()
        WebBrowser1.Hide()
        TextBox1.Hide()
        Button5.Hide()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        AxWindowsMediaPlayer1.Hide()
        Button35.Hide()
        Button37.Hide()
        Button34.Hide()
        Button9.Hide()
        Button10.Hide()
        Button11.Hide()
        Button12.Hide()
        Button13.Hide()
        Button38.Hide()
        PictureBox7.Hide()
        Button14.Hide()
        Label4.Hide()
        Label10.Hide()
        Label5.Hide()
        Button15.Hide()
        Button16.Hide()
        Button17.Hide()
        RichTextBox1.Hide()
        Button18.Hide()
        Button19.Hide()
        Button36.Hide()
        Timer1.Start()
        PictureBox10.Hide()
        WebBrowser2.Navigate("http://www.npr.org")
        WebBrowser3.Navigate("https://www.wunderground.com/")
        PictureBox15.Hide()
        PictureBox15.SendToBack()
        WebBrowser4.Navigate("https://www.tumblr.com")
        Button23.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox4.Show()
        PictureBox4.BringToFront()
        PictureBox1.Hide()
        Button10.Hide()
        Button11.Hide()
        Button12.Hide()
        Button13.Hide()
        My.Computer.Audio.Play("C:\Users\Tekga\Downloads\crash1.wav")
    End Sub
    Private Sub Sleep()
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox5.Hide()
        Button4.Hide()
        Button20.Hide()
        Button22.Hide()
        My.Computer.Audio.Play("C:\Users\Tekga\Downloads\start.wav")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        TextBox1.Show()
        Button5.Show()
        WebBrowser1.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Hide()
        Button5.Hide()
        WebBrowser1.Hide()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        Button9.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.Navigate("http://www.google.com")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button23.Show()
        Button19.Show()
        Button10.Show()
        Button11.Show()
        Button13.Show()
        Button38.Show()
        Button15.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Show()
        Button5.Show()
        WebBrowser1.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox3.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button12.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label2.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox7.Show()
        Button14.Show()
        Label4.Show()
        Label5.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Hide()
        PictureBox7.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Button16.Show()
        Button18.Show()
        Button17.Show()
        RichTextBox1.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button16.Hide()
        Button17.Hide()
        Button18.Hide()
        RichTextBox1.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If RichTextBox1.Text.Length > 0 Then
            SaveFileDialog1.ShowDialog()
            IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button16.Show()
        Button18.Show()
        Button17.Show()
        RichTextBox1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay
        Label18.Text = TimeOfDay
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Label10.Show()
        Label10.Location = Cursor.Position
        Label10.Text = ("Omega Desktop")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox10.Hide()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Num1 = TextBox2.Text
        Num2 = TextBox3.Text
        Ans = Num1 + Num2
        MsgBox(Ans)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        My.Computer.Audio.Play("C:\Users\Tekga\Downloads\crash2.wav")
        PictureBox15.Show()
        PictureBox15.BringToFront()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Label10.Show()
        Label10.Location = Cursor.Position
        Label10.Text = ("Omega Desktop")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button15.Hide()
        Button19.Hide()
        Button13.Hide()
        Button11.Hide()
        Button38.Hide()
        Button10.Hide()
        Button23.Hide()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        PictureBox3.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button12.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Button16.Show()
        Button18.Show()
        Button17.Show()
        RichTextBox1.Show()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        PictureBox7.Show()
        Button14.Show()
        Label4.Show()
        Label5.Show()

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox1.Show()
        Button5.Show()
        WebBrowser1.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button36_Click_1(sender As Object, e As EventArgs) Handles Button36.Click
        AxWindowsMediaPlayer1.Hide()
        Button36.Hide()
        Button35.Hide()
        Button37.Hide()
        Button34.Hide()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        AxWindowsMediaPlayer1.Show()
        Button36.Show()
        Button35.Show()
        Button37.Show()
        Button34.Show()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        AxWindowsMediaPlayer1.Show()
        Button36.Show()
        Button35.Show()
        Button37.Show()
        Button34.Show()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        AxWindowsMediaPlayer1.Show()
        Button36.Show()
        Button35.Show()
        Button37.Show()
        Button34.Show()
    End Sub
End Class

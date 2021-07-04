Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Shell("C:\Users\Tekga\source\repos\WebStab\WebStab\obj\Debug\WebStab.exe")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Shell("C:\Users\Tekga\Documents\WinDOSProject\interface.bat")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Shell("C:\Users\Tekga\Documents\OSREADME.bat")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Links.Add(6, 4, "www.onachlabs.weebly.com")
        Label21.Hide()
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Timer1.Start()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Shell("C:\Users\Tekga\source\repos\Onach Text Editor\Onach Text Editor\obj\Debug\Onach Text Editor.exe")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Shell("C:\Users\Tekga\source\repos\Onach File Manager\Onach File Manager\obj\Debug\Onach File Manager.exe")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Shell("C:\Users\Tekga\source\repos\VIARobot IDE\VIARobot IDE\obj\Debug\VIARobot IDE.exe")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Shell("C:\Users\Tekga\source\repos\Onach Chat Bot\Onach Chat Bot\obj\Debug\Onach Chat Bot.exe")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Shell("C:\Users\Tekga\source\repos\Onacalculator\Onacalculator\obj\Debug\Onacalculator.exe")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Shell("C:\Users\Tekga\source\repos\ORES\ORES\obj\Debug\ORES.exe")
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Shell("C:\Users\Tekga\source\repos\Onach Document Viewer\Onach Document Viewer\obj\Debug\Onach Document Viewer.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        Label17.Hide()
        Label18.Hide()
        Label19.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        PictureBox14.Hide()
        If (TextBox1.Text = ("")) Then
            Label21.Show()
        End If
        If (TextBox2.Text = ("")) Then
            Label21.Show()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Button1.Show()
        Label17.Show()
        Label18.Show()
        Label19.Show()
        TextBox1.Show()
        TextBox2.Show()
        PictureBox14.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Shell("C:\Users\Tekga\source\repos\OnachDefense AntiVirus\OnachDefense AntiVirus\obj\Debug\OnachDefense AntiVirus.exe")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Shell("C:\Users\Tekga\source\repos\ESC\ESC\obj\Debug\ESC.exe")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = TimeOfDay

    End Sub
End Class

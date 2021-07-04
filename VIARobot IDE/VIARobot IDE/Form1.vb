Public Class Form1
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Answer As Integer
    Dim saything, Sapi
    Dim SFD As New SaveFileDialog
    Dim OFD As New OpenFileDialog
    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        For Each a As String In RichTextBox1.Text.Split(System.Environment.NewLine())
            If (RichTextBox1.Text.Contains("type ")) Then
                Console.Write(a.Substring(4))
            End If
            If (RichTextBox1.Text.Contains("messagebox ")) Then
                MsgBox(a.Substring(11))
            End If
            If (RichTextBox1.Text.Contains("changetitle")) Then
                Console.Title = (a.Substring(12))
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor green")) Then
                Console.ForegroundColor = ConsoleColor.Green
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor blue")) Then
                Console.ForegroundColor = ConsoleColor.Blue
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor white")) Then
                Console.ForegroundColor = ConsoleColor.White
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor yellow")) Then
                Console.ForegroundColor = ConsoleColor.Yellow
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor red")) Then
                Console.ForegroundColor = ConsoleColor.Red
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor green")) Then
                Console.BackgroundColor = ConsoleColor.Green
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor blue")) Then
                Console.BackgroundColor = ConsoleColor.Blue
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor white")) Then
                Console.BackgroundColor = ConsoleColor.White
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor yellow")) Then
                Console.BackgroundColor = ConsoleColor.Yellow
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor red")) Then
                Console.BackgroundColor = ConsoleColor.Red
            End If
            If (RichTextBox1.Text.Contains("double")) Then
                Number1 = a.Substring(6)
                Number2 = a.Substring(6)
                Answer = Number1 + Number2
                Console.Write(Answer)
            End If
            If (RichTextBox1.Text.Contains("square")) Then
                Number1 = a.Substring(6)
                Number2 = a.Substring(6)
                Answer = Number1 * Number2
                Console.Write(Answer)
            End If
            If (RichTextBox1.Text.Contains("clearscreen")) Then
                Console.Clear()
            End If
            If (RichTextBox1.Text.Contains("exit")) Then
                Close()
            End If
            If (RichTextBox1.Text.Contains("beep")) Then
                Beep()
            End If
            If (RichTextBox1.Text.Contains("inputbox")) Then
                InputBox(a.Substring(8))
            End If
            If (RichTextBox1.Text.Contains("informationbox")) Then
                MsgBox(a.Substring(14), MsgBoxStyle.Information)
            End If
            If (RichTextBox1.Text.Contains("errorbox")) Then
                MsgBox(a.Substring(8), MsgBoxStyle.Critical)
            End If
            If (RichTextBox1.Text.Contains("questionbox")) Then
                MsgBox(a.Substring(11), MsgBoxStyle.Question)
            End If
            If (RichTextBox1.Text.Contains("yesandnobox")) Then
                MsgBox(a.Substring(11), MsgBoxStyle.YesNo)
            End If
            If (RichTextBox1.Text.Contains("yesnoandcancelbox")) Then
                MsgBox(a.Substring(17), MsgBoxStyle.YesNoCancel)
            End If
            If (RichTextBox1.Text.Contains("okandcancelbox")) Then
                MsgBox(a.Substring(14), MsgBoxStyle.OkCancel)
            End If
            If (RichTextBox1.Text.Contains("warningbox")) Then
                MsgBox(a.Substring(10), MsgBoxStyle.Exclamation)
            End If
            If (RichTextBox1.Text.Contains("say")) Then
                saything = (a.Substring(3))
                Sapi = CreateObject("Sapi.spvoice")
                Sapi.speak(saything)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each a As String In RichTextBox1.Text.Split(System.Environment.NewLine())
            If (RichTextBox1.Text.Contains("type ")) Then
                Console.Write(a.Substring(5))
            End If
            If (RichTextBox1.Text.Contains("messagebox ")) Then
                MsgBox(a.Substring(11))
            End If
            If (RichTextBox1.Text.Contains("changetitle")) Then
                Console.Title = (a.Substring(12))
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor green")) Then
                Console.ForegroundColor = ConsoleColor.Green
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor blue")) Then
                Console.ForegroundColor = ConsoleColor.Blue
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor white")) Then
                Console.ForegroundColor = ConsoleColor.White
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor yellow")) Then
                Console.ForegroundColor = ConsoleColor.Yellow
            End If
            If (RichTextBox1.Text.Contains("foregroundcolor red")) Then
                Console.ForegroundColor = ConsoleColor.Red
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor green")) Then
                Console.BackgroundColor = ConsoleColor.Green
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor blue")) Then
                Console.BackgroundColor = ConsoleColor.Blue
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor white")) Then
                Console.BackgroundColor = ConsoleColor.White
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor yellow")) Then
                Console.BackgroundColor = ConsoleColor.Yellow
            End If
            If (RichTextBox1.Text.Contains("backgroundcolor red")) Then
                Console.BackgroundColor = ConsoleColor.Red
            End If
            If (RichTextBox1.Text.Contains("double")) Then
                Number1 = a.Substring(6)
                Number2 = a.Substring(6)
                Answer = Number1 + Number2
                Console.Write(Answer)
            End If
            If (RichTextBox1.Text.Contains("square")) Then
                Number1 = a.Substring(6)
                Number2 = a.Substring(6)
                Answer = Number1 * Number2
                Console.Write(Answer)
            End If
            If (RichTextBox1.Text.Contains("clearscreen")) Then
                Console.Clear()
            End If
            If (RichTextBox1.Text.Contains("exit")) Then
                Close()
            End If
            If (RichTextBox1.Text.Contains("beep")) Then
                Beep()
            End If
            If (RichTextBox1.Text.Contains("inputbox")) Then
                InputBox(a.Substring(8))
            End If
            If (RichTextBox1.Text.Contains("informationbox")) Then
                MsgBox(a.Substring(14), MsgBoxStyle.Information)
            End If
            If (RichTextBox1.Text.Contains("errorbox")) Then
                MsgBox(a.Substring(8), MsgBoxStyle.Critical)
            End If
            If (RichTextBox1.Text.Contains("questionbox")) Then
                MsgBox(a.Substring(11), MsgBoxStyle.Question)
            End If
            If (RichTextBox1.Text.Contains("yesandnobox")) Then
                MsgBox(a.Substring(11), MsgBoxStyle.YesNo)
            End If
            If (RichTextBox1.Text.Contains("yesnoandcancelbox")) Then
                MsgBox(a.Substring(17), MsgBoxStyle.YesNoCancel)
            End If
            If (RichTextBox1.Text.Contains("okandcancelbox")) Then
                MsgBox(a.Substring(14), MsgBoxStyle.OkCancel)
            End If
            If (RichTextBox1.Text.Contains("warningbox")) Then
                MsgBox(a.Substring(10), MsgBoxStyle.Exclamation)
            End If
            If (RichTextBox1.Text.Contains("say")) Then
                saything = (a.Substring(4))
                Sapi = CreateObject("Sapi.spvoice")
                Sapi.speak(saything)
            End If
            If (RichTextBox1.Text.Contains("comment")) Then

            End If
            If (RichTextBox1.Text.Contains("typeforever")) Then
                Dim LoopT = 0
                Do While LoopT = 0
                    Console.Write(a.Substring(11))
                Loop
            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SFD.Filter = "VIARobot File (*.via)|*.via"
        SFD.ShowDialog()
        Dim SW As New IO.StreamWriter(SFD.FileName)
        SW.Write(RichTextBox1.Text)
        SW.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OFD.Filter = "VIARobot File (*.via)|*.via"
        OFD.ShowDialog()
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OFD.FileName)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        RichTextBox1.Text = (ListBox1.SelectedItem.ToString())
    End Sub
End Class
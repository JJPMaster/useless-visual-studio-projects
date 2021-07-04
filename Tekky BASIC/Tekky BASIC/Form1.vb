Public Class Form1
    Dim SBThing As New System.Text.StringBuilder
    Dim LoopV As Integer = 0
    Dim sayitem, Sapi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text.Contains("Print")) Then
            Console.Write(TextBox1.Text.Substring(5))
        End If
        If (TextBox1.Text.Contains("GotoPrint")) Then
            Do While LoopV = 0
                Console.Write(TextBox1.Text.Substring(10))
            Loop
        End If
        If (TextBox1.Text.Contains("Clear")) Then
            Console.Clear()
        End If
        If (TextBox1.Text.Contains("Sound")) Then
            sayitem = (TextBox1.Text.Substring(5))
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.speak(sayitem)
        End If
        If (TextBox1.Text.Contains("GraphicsInput")) Then
            InputBox(TextBox1.Text.Substring(5))
        End If
        If (TextBox1.Text.Contains("TextInput")) Then
            Console.Write(TextBox1.Text.Substring(9) + " Y/N")
        End If
        If (TextBox1.Text.Contains("Y")) Then
            Console.Write("Thanks for your input of yes!")
        End If
        If (TextBox1.Text.Contains("N")) Then
            Console.Write("Sorry for your input of no!")
        End If
    End Sub
End Class

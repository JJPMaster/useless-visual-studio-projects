Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text.Contains("Hello")) Then
            Console.Write(" How are you?")
        End If
        If (TextBox1.Text.Contains("hello")) Then
            Console.Write(" How are you?")
        End If
        If (TextBox1.Text.Contains("good")) Then
            Console.Write(" I'm glad to hear that.")
        End If
        If (TextBox1.Text.Contains("Good")) Then
            Console.Write(" I'm glad to hear that.")
        End If
        If (TextBox1.Text.Contains("bad")) Then
            Console.Write(" Why? :(")
        End If
        If (TextBox1.Text.Contains("Bad")) Then
            Console.Write(" Why? :(")
        End If
        If (TextBox1.Text.Contains("I don't know")) Then
            Console.Write(" That's okay.")
        End If
        If (TextBox1.Text.Contains("i don't know")) Then
            Console.Write(" That's okay.")
        End If
        If (TextBox1.Text.Contains("i dont know")) Then
            Console.Write(" That's okay.")
        End If
        If (TextBox1.Text.Contains("idk")) Then
            Console.Write(" That's okay.")
        End If
        If (TextBox1.Text.Contains("IDK")) Then
            Console.Write(" That's okay.")
        End If
        If (TextBox1.Text.Contains("Stop")) Then
            Console.Write("Okay, I will close in 5 seconds.")
            System.Threading.Thread.Sleep(5000)
            Close()
        End If
        If (TextBox1.Text.Contains("stop")) Then
            Console.Write(" Okay, I will close in 5 seconds.")
            System.Threading.Thread.Sleep(5000)
            Close()
        End If
        If (TextBox1.Text.Contains("ok")) Then
            Console.Write(" Luckily you are not bad!")
        End If
        If (TextBox1.Text.Contains("OK")) Then
            Console.Write(" Luckily you are not bad!")
        End If
        If (TextBox1.Text.Contains("Ok")) Then
            Console.Write(" Luckily you are not bad!")
        End If
        If (TextBox1.Text.Contains("Ok")) Then
            Console.Write(" Luckily you are not bad!")
        End If
        If (TextBox1.Text.Contains("How are you?")) Then
            Console.Write(" I am good!")
        End If
        If (TextBox1.Text.Contains("how are you?")) Then
            Console.Write(" I am good!")
        End If
        If (TextBox1.Text.Contains("How are you")) Then
            Console.Write(" I am good!")
        End If
        If (TextBox1.Text.Contains("how are you")) Then
            Console.Write(" I am good!")
        End If
    End Sub
End Class

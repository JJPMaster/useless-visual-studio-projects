Public Class Form1
    Dim ANumber1 As Single
    Dim ANumber2 As Single
    Dim AAnswer As Single
    Dim SNumber1 As Single
    Dim SNumber2 As Single
    Dim SAnswer As Single
    Dim MNumber1 As Single
    Dim MNumber2 As Single
    Dim MAnswer As Single
    Dim DNumber1 As Single
    Dim DNumber2 As Single
    Dim DAnswer As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ANumber1 = TextBox1.Text
        ANumber2 = TextBox2.Text
        AAnswer = ANumber1 + ANumber2
        MsgBox(AAnswer)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SNumber1 = RichTextBox1.Text
        SNumber2 = RichTextBox2.Text
        SAnswer = SNumber1 - SNumber2
        MsgBox(SAnswer)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MNumber1 = TextBox3.Text
        MNumber2 = TextBox4.Text
        MAnswer = MNumber1 * MNumber2
        MsgBox(MAnswer)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DNumber1 = RichTextBox3.Text
        DNumber2 = RichTextBox4.Text
        DAnswer = DNumber1 / DNumber2
        MsgBox(DAnswer)
    End Sub
End Class

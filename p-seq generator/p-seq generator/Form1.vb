Public Class Form1
	Dim integer1 As Integer
	Dim integer2 As Integer
	Dim newInteger As Integer

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		newInteger = integer1 ^ integer2
		Label1.Text = (newInteger)
		integer1 = newInteger + 1000
		integer2 = integer1 + 1000
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		integer1 = integer1 + 100000000
		integer2 = integer2 + 2
	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub
End Class

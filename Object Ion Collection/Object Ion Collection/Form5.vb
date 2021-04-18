Public Class Form5
	Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

	End Sub

	Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		WebBrowser1.Navigate("http://www.aaonline.fr/player.php?trial_id=108987")
	End Sub

	Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

	End Sub
End Class
'Author: Alexander A. Parcasio IV'
'Date Created: April 28, 2022'
'Date Modified:'
'Version: 0.1'
Public Class Form1
    Private Sub Button_Home_Click(sender As Object, e As EventArgs) Handles Button_Home.Click
        WebBrowser_window.Navigate("www.microsoft.com")
    End Sub
    Private Sub Button_Previous_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        WebBrowser_window.GoBack()
    End Sub
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        WebBrowser_window.GoForward()
    End Sub
    Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
        WebBrowser_window.Refresh()
    End Sub
    Private Sub Button_Continue_Click(sender As Object, e As EventArgs) Handles Button_Continue.Click
        WebBrowser_window.Navigate(TextBox_Uniform_Resource_Locator.Text)
    End Sub
    Private Sub TextBox_Uniform_Resource_Locator_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_Uniform_Resource_Locator.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser_window.Navigate(TextBox_Uniform_Resource_Locator.Text)
        End If
    End Sub
End Class
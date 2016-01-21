'Author:        Harrison Lingren
'Date:          2016-01-21
'Project Name:  MyWebBrowser
'Project Desc:  A simple windows application that implements
'               a web browser with go, back, forward, refresh,
'               and URL conversion functionality


Public Class MainForm
    'Navigates to the inputted Uri
    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        wbrDisplay.Navigate(CheckURL(txtURL.Text))
    End Sub

    'Refreshes the web panel
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        wbrDisplay.Refresh()
    End Sub

    'Goes back in the web panel
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        wbrDisplay.GoBack()
    End Sub

    'Goes forward in the web panel
    Private Sub btnForw_Click(sender As Object, e As EventArgs) Handles btnForw.Click
        wbrDisplay.GoForward()
    End Sub

    'Checks the URL to make sure it includes 'http://'
    Private Function CheckURL(url As String)
        If url.StartsWith("http://") Then
            Return New Uri(url)
        Else
            url = "http://" & url
            Return New Uri(url)
        End If
    End Function

    'Updates the status label
    Private Sub wbrDisplay_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbrDisplay.DocumentCompleted
        txtURL.Text = wbrDisplay.Url.ToString
        stsLabel.Text = "Done"
    End Sub

    'Updates the status label
    Private Sub wbrDisplay_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles wbrDisplay.Navigating
        stsLabel.Text = "Loading"
    End Sub

    'Resizes the window components
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        wbrDisplay.Size = New Size(Me.Size.Width, Me.Size.Height - 50)
    End Sub

    'Goes to the URL on enter keypress
    Private Sub txtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            wbrDisplay.Navigate(CheckURL(txtURL.Text))
        End If
    End Sub

End Class

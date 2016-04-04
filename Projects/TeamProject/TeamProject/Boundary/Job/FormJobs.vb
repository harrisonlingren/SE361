Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click
        FormEditJob.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) Handles btnEditJob.Click
        FormEditJob.loadJob(selectedIndex)
    End Sub

End Class
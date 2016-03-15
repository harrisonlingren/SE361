Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click
        FormEditJob.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) Handles btnEditJob.Click
        FormEditJob.loadJob(selectedIndex)
    End Sub

    Private Sub listViewJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewJobs.SelectedIndexChanged

        btnEditJob.Enabled = True

        Try
            selectedIndex = listViewJobs.SelectedItems(0).Index
        Catch ex As Exception
            selectedIndex = 0
        End Try

    End Sub
End Class
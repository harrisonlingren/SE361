Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) 
        FormEditJob.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) 
        FormEditJob.loadJob(selectedIndex)
    End Sub

End Class
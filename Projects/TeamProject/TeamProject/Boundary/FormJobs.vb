Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click
        FormEditJob.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) Handles btnEditJob.Click
        FormEditJob.loadJob(selectedIndex)
    End Sub

    Private Sub FormJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Se361DataSet.Jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.Se361DataSet.Jobs)

    End Sub
End Class
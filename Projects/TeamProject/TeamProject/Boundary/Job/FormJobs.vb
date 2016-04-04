Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) 
        FormEditJob.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs)
        FormEditJob.loadJob(selectedIndex)
    End Sub

    Private Sub FormJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Job' table. You can move, or remove it, as needed.
        Me.JobTableAdapter.Fill(Me.TeamProjectDataSet.Job)

    End Sub
End Class
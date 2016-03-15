Public Class FormEditJob
    Private Sub btnJobCancel_Click(sender As Object, e As EventArgs) Handles btnJobCancel.Click
        Me.Close()
    End Sub

    Private Sub btnJobSave_Click(sender As Object, e As EventArgs) Handles btnJobSave.Click
        Dim job1 As New cJob

        job1.id = CInt(FormJobs.listViewJobs.Items.Count)
        job1.address = txtJobAddress.Text
        job1.cost = txtJobCost.Text
        job1.datetime = dtJobTime.Value

        FormJobs.listViewJobs.Items.Add(job1.id)
        FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.datetime)
        FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.address)
        FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.cost)
    End Sub
End Class
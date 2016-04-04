Public Class FormEditJob
    Private Sub btnJobCancel_Click(sender As Object, e As EventArgs) Handles btnJobCancel.Click
        Me.Close()
    End Sub

    Private Sub btnJobSave_Click(sender As Object, e As EventArgs) Handles btnJobSave.Click
        Dim job1 As New cJob

        'job1.id = CInt(FormJobs.listViewJobs.Items.Count)
        job1.address = txtJobAddress.Text
        job1.cost = txtJobCost.Text
        job1.datetime = dtJobTime.Value

        'FormJobs.listViewJobs.Items.Add(job1.id)
        'FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.datetime)
        'FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.address)
        'FormJobs.listViewJobs.Items(FormJobs.listViewJobs.Items.Count - 1).SubItems.Add(job1.cost)

    End Sub

    Public Sub loadJob(selectedIndex As Integer)

        'txtJobID.Text = FormJobs.listViewJobs.Items(selectedIndex).Text
        'dtJobTime.Value = CDate(FormJobs.listViewJobs.Items(selectedIndex).SubItems(1).Text)
        'txtJobAddress.Text = FormJobs.listViewJobs.Items(selectedIndex).SubItems(2).Text
        'txtJobCost.Text = FormJobs.listViewJobs.Items(selectedIndex).SubItems(3).Text

        Me.Show()

    End Sub

End Class
Public Class cJobManager
    Private job As New cJob

    Public Sub save(editType As Integer)
        job.cost = CType(FormObjectEditor.txtAmount.Text, Decimal)
        job.address = CType(FormObjectEditor.txtAddress.Text, String)
        job.datetime = CType(FormObjectEditor.dtDate.Value, String)

        'Check if adding new job or editing current job
        If editType = 0 Then
            job.id = 0
            Dim testQ As Integer = FormJobs.JobTableAdapter.InsertQuery(job.datetime, job.address, job.cost)
            'MessageBox.Show("Rows affected: " & testQ)

        ElseIf editType = 1 Then
            job.id = CType(FormObjectEditor.txtID.Text, Integer)
            Dim testQ As Integer = FormJobs.JobTableAdapter.UpdateQuery(job.datetime, job.address, job.cost, job.id)
            'MessageBox.Show("Rows affected: " & testQ)
        End If

        FormJobs.Refresh()
        FormJobs.reloadData()
    End Sub

    Public Sub New()
    End Sub

    Sub delete(data As DataGridViewCellCollection)
        FormJobs.JobTableAdapter.Delete(data(0).Value, data(1).Value, data(2).Value)
    End Sub

End Class

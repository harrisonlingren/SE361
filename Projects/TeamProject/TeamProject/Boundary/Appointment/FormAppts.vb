Public Class FormAppts
    Private Sub btnAddAppt_Click(sender As Object, e As EventArgs)
        FormEditAppt.Show()
    End Sub

    Private Sub FormAppts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.TeamProjectDataSet.Appointment)

    End Sub
End Class
Public Class cAppointmentManager
    Private appt As New cAppointment

    Public Sub save(editType As Integer)
        'Check if adding new appointment or editing current appointment
        appt.address = CType(FormObjectEditor.txtAddress.Text, String)
        appt.datetime = CType(FormObjectEditor.dtDate.Value, String)

        If editType = 0 Then
            appt.id = 0
            Dim testQ As Integer = FormAppts.AppointmentTableAdapter.Insert(appt.datetime, appt.address)
            'MessageBox.Show("Rows affected: " & testQ)

        ElseIf editType = 1 Then
            appt.id = CType(FormObjectEditor.txtID.Text, Integer)
            Dim testQ As Integer = FormAppts.AppointmentTableAdapter.UpdateQuery(appt.datetime, appt.address, appt.id)
            'MessageBox.Show("Rows affected: " & testQ)

        End If

        FormAppts.Refresh()
        FormAppts.reloadData()
    End Sub

    Public Sub New()
    End Sub

    Sub delete(data As DataGridViewCellCollection)
        FormAppts.AppointmentTableAdapter.Delete(data(0).Value, data(1).Value, data(2).Value)
    End Sub

End Class

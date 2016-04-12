Public Class FormAppts
    Private selectedIndex As Integer

    Private Sub btnAddAppt_Click(sender As Object, e As EventArgs)
        FormObjectEditor.formType = 0
        FormObjectEditor.globalIndex = 0
        FormObjectEditor.Show()
    End Sub

    Private Sub FormAppts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadData()
    End Sub

    Public Sub reloadData()
        Me.AppointmentTableAdapter.Fill(Me.TeamProjectDataSet.Appointment)
    End Sub

    Private Sub dvAppts_SelectionChanged(sender As Object, e As EventArgs) Handles dvAppts.SelectionChanged
        Try
            selectedIndex = CType(dvAppts.CurrentRow.Index, Integer)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            selectedIndex -= 1
        End Try
        Console.WriteLine("Row selected: " & selectedIndex)
        btnEditAppt.Enabled = True
    End Sub

    Private Sub btnEditAppt_Click(sender As Object, e As EventArgs) Handles btnEditAppt.Click
        FormObjectEditor.formType = 1
        FormObjectEditor.globalIndex = 0
        FormObjectEditor.Show()
    End Sub

    Private Sub btnAddAppt_Click_1(sender As Object, e As EventArgs) Handles btnAddAppt.Click
        FormObjectEditor.formType = 0
        FormObjectEditor.globalIndex = 0
        FormObjectEditor.Show()
    End Sub

    Private Sub btnDelAppt_Click(sender As Object, e As EventArgs) Handles btnDelAppt.Click
        Dim apptId As String = CType(dvAppts.CurrentRow.Cells(0).Value, String)
        Console.WriteLine(apptId & " to be deleted.")
        Dim resp = MessageBox.Show("Are you sure you want to delete Appointment '" & apptId & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resp = DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvAppts.Rows(selectedIndex).Cells
            AppointmentTableAdapter.Delete(data(0).Value, data(1).Value, data(2).Value)
        End If
        Me.reloadData()
    End Sub

    Private Sub btnSaveAppt_Click(sender As Object, e As EventArgs) Handles btnSaveAppt.Click
        Me.Close()
    End Sub
End Class
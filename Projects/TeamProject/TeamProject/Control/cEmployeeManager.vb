Public Class cEmployeeManager
    Private emp As New cEmployee

    Public Sub save(editType As Integer)
        'Check if adding new employee or editing current employee

        emp.name = CType(FormObjectEditor.txtName.Text, String)
        emp.phone = CType(FormObjectEditor.txtPhone.Text, String)
        emp.hours = CType(FormObjectEditor.txtHours.Text, String)
        emp.address = CType(FormObjectEditor.txtAddress.Text, String)
        emp.payRate = CType(FormObjectEditor.txtPayRate.Text, Double)
        emp.type = CType(FormObjectEditor.comboType.Text, String)

        If editType = 0 Then
            emp.id = 0
            Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.Insert(emp.name, emp.type, emp.address, emp.phone, emp.hours, emp.payRate)
            'MessageBox.Show("Rows affected: " & testQ)

        ElseIf editType = 1 Then
            emp.id = CType(FormObjectEditor.txtID.Text, Integer)
            Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.UpdateQuery(emp.type, emp.address, emp.phone, emp.hours, emp.payRate, emp.name, emp.id)
            'MessageBox.Show("Rows affected: " & testQ)
        End If

        FormEmployees.Refresh()
        FormEmployees.reloadData()
    End Sub
End Class

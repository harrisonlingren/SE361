Public Class FormEditEmployee
    Private newID As Integer
    Public formType As Integer

    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnEmpCancel.Click
        Me.Close()
    End Sub

    Friend Shared Sub loadEmployee(selectedIndex As Integer)

    End Sub

    Private Sub btnEmpSave_Click(sender As Object, e As EventArgs) Handles btnEmpSave.Click

        'Check if adding new customer or editing current customer
        If formType = 0 Then
            Dim tempEmp As New cEmployee

            tempEmp.id = newID
            tempEmp.name = CType(txtEmpName.Text, String)
            tempEmp.phone = CType(txtEmpPhone.Text, String)
            tempEmp.hours = CType(txtEmpHours.Text, String)
            tempEmp.address = CType(txtEmpAddress.Text, String)
            tempEmp.payRate = CType(txtEmpPayRate.Text, Double)
            tempEmp.type = CType(comboEmpType.Text, String)

            Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.Insert(tempEmp.name, tempEmp.type, tempEmp.address, tempEmp.phone, tempEmp.hours, tempEmp.payRate)
            MessageBox.Show("Rows affected: " & testQ)

        ElseIf formType = 1 Then
            Dim tempEmp As New cEmployee

            tempEmp.id = CType(txtEmpID.Text, Integer)
            tempEmp.name = CType(txtEmpName.Text, String)
            tempEmp.phone = CType(txtEmpPhone.Text, String)
            tempEmp.hours = CType(txtEmpHours.Text, String)
            tempEmp.address = CType(txtEmpAddress.Text, String)
            tempEmp.payRate = CType(txtEmpPayRate.Text, Double)
            tempEmp.type = CType(comboEmpType.Text, String)

            Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.UpdateQuery(tempEmp.type, tempEmp.address, tempEmp.phone, tempEmp.hours, tempEmp.payRate, tempEmp.name, tempEmp.id)
            MessageBox.Show("Rows affected: " & testQ)
        End If

        FormCustomers.Refresh()
        FormCustomers.reloadData()
        Me.Close()

    End Sub

    Private Sub FormEditEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load

        If formType = 0 Then
            'check if adding new customer, update with new id
            newID = CType(FormEmployees.EmployeeTableAdapter.GetEmpIDs.Last.emp_id, Integer) + 1
            Console.WriteLine("New employee ID: " & newID)
            txtEmpID.Text = CStr(newID)

        ElseIf formType = 1 Then
            'if editing customer, load values to textboxes

            txtEmpID.Text = FormEmployees.dvEmp.CurrentRow.Cells(0).Value
            txtEmpName.Text = FormEmployees.dvEmp.CurrentRow.Cells(1).Value
            comboEmpType.Text = FormEmployees.dvEmp.CurrentRow.Cells(2).Value
            txtEmpAddress.Text = FormEmployees.dvEmp.CurrentRow.Cells(3).Value
            txtEmpPhone.Text = FormEmployees.dvEmp.CurrentRow.Cells(4).Value
            txtEmpHours.Text = FormEmployees.dvEmp.CurrentRow.Cells(5).Value
            txtEmpPayRate.Text = FormEmployees.dvEmp.CurrentRow.Cells(6).Value
        End If

    End Sub
End Class
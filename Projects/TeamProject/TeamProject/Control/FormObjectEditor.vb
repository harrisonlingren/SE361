Public Class FormObjectEditor
    Public formType As Integer
    Public globalIndex As Integer
    Private newID As Integer

    Private Sub FormObjectEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.JobTableAdapter.Fill(Me.TeamProjectDataSet.Job)
        Me.CustomerTableAdapter.Fill(Me.TeamProjectDataSet.Customer)

        comboObjType.SelectedIndex = globalIndex
        reloadOptions()
        loadValues(globalIndex)
    End Sub

    Private Sub loadValues(i As Integer)
        Select Case i
            Case 0
                If formType = 0 Then
                    'check if adding new appointment, update with new id
                    Try
                        newID = CType(FormAppts.AppointmentTableAdapter.GetApptID.Last.appt_id, Integer) + 1
                    Catch ex As Exception
                        newID = 0
                    End Try
                    'newID = CType(FormAppts.AppointmentTableAdapter.GetApptID.Last.appt_id, Integer) + 1
                    Console.WriteLine("New appointment ID: " & newID)
                    txtID.Text = CStr(newID)

                ElseIf formType = 1 Then
                    'if editing appointment, load values to textboxes
                    txtID.Text = FormAppts.dvAppts.CurrentRow.Cells(0).Value
                    dtDate.Text = FormAppts.dvAppts.CurrentRow.Cells(1).Value
                    txtAddress.Text = FormAppts.dvAppts.CurrentRow.Cells(2).Value
                End If

            Case 1
                If formType = 0 Then
                    'check if adding new customer, update with new id
                    newID = CType(FormCustomers.CustomerTableAdapter.GetCustID.Last.cust_id, Integer) + 1
                    Console.WriteLine("New customer ID: " & newID)
                    txtID.Text = CStr(newID)

                ElseIf formType = 1 Then
                    'if editing customer, load values to textboxes

                    txtID.Text = FormCustomers.dvCust.CurrentRow.Cells(0).Value
                    txtName.Text = FormCustomers.dvCust.CurrentRow.Cells(1).Value
                    txtPhone.Text = FormCustomers.dvCust.CurrentRow.Cells(3).Value
                    txtAddress.Text = FormCustomers.dvCust.CurrentRow.Cells(2).Value
                    txtEmail.Text = FormCustomers.dvCust.CurrentRow.Cells(4).Value
                End If

            Case 2
                If formType = 0 Then
                    'check if adding new customer, update with new id
                    newID = CType(FormEmployees.EmployeeTableAdapter.GetEmpIDs.Last.emp_id, Integer) + 1
                    Console.WriteLine("New employee ID: " & newID)
                    txtID.Text = CStr(newID)

                ElseIf formType = 1 Then
                    'if editing customer, load values to textboxes

                    txtID.Text = FormEmployees.dvEmp.CurrentRow.Cells(0).Value
                    txtName.Text = FormEmployees.dvEmp.CurrentRow.Cells(1).Value
                    comboType.Text = FormEmployees.dvEmp.CurrentRow.Cells(2).Value
                    txtAddress.Text = FormEmployees.dvEmp.CurrentRow.Cells(3).Value
                    txtPhone.Text = FormEmployees.dvEmp.CurrentRow.Cells(4).Value
                    txtHours.Text = FormEmployees.dvEmp.CurrentRow.Cells(5).Value
                    txtPayRate.Text = FormEmployees.dvEmp.CurrentRow.Cells(6).Value
                End If

            Case 3


            Case 4
        End Select


    End Sub

    Private Sub comboObjType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboObjType.SelectedIndexChanged
        globalIndex = comboObjType.SelectedIndex
        reloadOptions()
    End Sub

    Private Sub reloadOptions()
        'Reload form based on which object is being edited
        Select Case globalIndex
            Case 0
                'Appointment
                txtName.Enabled = False
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = True
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Appointment"
                dtDueDate.Enabled = False
            Case 1
                'Customer
                txtName.Enabled = True
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = True
                txtHours.Enabled = False
                txtPhone.Enabled = True
                txtPayRate.Enabled = False
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = False
                comboObjType.Text = "Customer"
                dtDueDate.Enabled = False
            Case 2
                'Employee
                txtName.Enabled = True
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = False
                txtHours.Enabled = True
                txtPhone.Enabled = True
                txtPayRate.Enabled = True
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = True
                dtDate.Enabled = False
                comboObjType.Text = "Employee"
                dtDueDate.Enabled = False
            Case 3
                'Invoice
                txtName.Enabled = False
                txtAddress.Enabled = False
                txtAmount.Enabled = True
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = True
                comboJobs.Enabled = True
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Invoice"
                dtDueDate.Enabled = True
            Case 4
                'Job
                txtName.Enabled = False
                txtAddress.Enabled = True
                txtAmount.Enabled = True
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Job"
                dtDueDate.Enabled = False
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case globalIndex
            Case 0
                'Check if adding new appointment or editing current appointment

                Dim tempAppt As New cAppointment
                tempAppt.address = CType(txtAddress.Text, String)
                tempAppt.datetime = CType(dtDate.Value, Date)

                If formType = 0 Then
                    tempAppt.id = newID
                    Dim testQ As Integer = FormAppts.AppointmentTableAdapter.Insert(tempAppt.datetime, tempAppt.address)
                    'MessageBox.Show("Rows affected: " & testQ)

                ElseIf formType = 1 Then
                    tempAppt.id = CType(txtID.Text, Integer)
                    Dim testQ As Integer = FormAppts.AppointmentTableAdapter.UpdateQuery(tempAppt.datetime, tempAppt.address, tempAppt.id)
                    'MessageBox.Show("Rows affected: " & testQ)

                End If

                FormAppts.Refresh()
                FormAppts.reloadData()
                Me.Close()
            Case 1
                'Check if adding new customer or editing current customer

                Dim tempCust As New cCustomer
                tempCust.name = CType(txtName.Text, String)
                tempCust.phone = CType(txtPhone.Text, String)
                tempCust.email = CType(txtEmail.Text, String)
                tempCust.address = CType(txtAddress.Text, String)

                If formType = 0 Then
                    tempCust.id = newID
                    Dim testQ As Integer = FormCustomers.CustomerTableAdapter.InsertQuery(tempCust.name, tempCust.address, tempCust.phone, tempCust.email)
                    'MessageBox.Show("Rows affected: " & testQ)

                ElseIf formType = 1 Then
                    tempCust.id = CType(txtID.Text, Integer)
                    Dim testQ As Integer = FormCustomers.CustomerTableAdapter.UpdateQuery(tempCust.name, tempCust.address, tempCust.phone, tempCust.email, tempCust.id)
                    'MessageBox.Show("Rows affected: " & testQ)
                End If

                FormCustomers.Refresh()
                FormCustomers.reloadData()
                Me.Close()
            Case 2
                'Check if adding new employee or editing current employee

                Dim tempEmp As New cEmployee
                tempEmp.name = CType(txtName.Text, String)
                tempEmp.phone = CType(txtPhone.Text, String)
                tempEmp.hours = CType(txtHours.Text, String)
                tempEmp.address = CType(txtAddress.Text, String)
                tempEmp.payRate = CType(txtPayRate.Text, Double)
                tempEmp.type = CType(comboType.Text, String)

                If formType = 0 Then
                    tempEmp.id = newID
                    Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.Insert(tempEmp.name, tempEmp.type, tempEmp.address, tempEmp.phone, tempEmp.hours, tempEmp.payRate)
                    'MessageBox.Show("Rows affected: " & testQ)

                ElseIf formType = 1 Then
                    tempEmp.id = CType(txtID.Text, Integer)
                    Dim testQ As Integer = FormEmployees.EmployeeTableAdapter.UpdateQuery(tempEmp.type, tempEmp.address, tempEmp.phone, tempEmp.hours, tempEmp.payRate, tempEmp.name, tempEmp.id)
                    'MessageBox.Show("Rows affected: " & testQ)
                End If

                FormEmployees.Refresh()
                FormEmployees.reloadData()
                Me.Close()
            Case 3

            Case 4

        End Select
    End Sub

End Class
Public Class FormEditEmployee
    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnEmpCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEmpSave_Click(sender As Object, e As EventArgs) Handles btnEmpSave.Click

        Dim emp1 As New cEmployee

        'emp1.id = CInt(FormEmployees.listViewEmp.Items.Count)
        emp1.type = comboEmpType.Text
        emp1.name = txtEmpName.Text
        emp1.address = txtEmpAddress.Text
        emp1.phone = txtEmpPhone.Text
        emp1.hours = txtEmpHours.Text
        emp1.payRate = txtEmpPayRate.Text

        'FormEmployees.listViewEmp.Items.Add(emp1.id)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.type)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.name)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.address)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.phone)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.hours)
        'FormEmployees.listViewEmp.Items(FormEmployees.listViewEmp.Items.Count - 1).SubItems.Add(emp1.payRate)

        Me.Close()

    End Sub

    Public Sub loadEmployee(selectedIndex As Integer)

        'txtEmpID.Text = FormEmployees.listViewEmp.Items(selectedIndex).Text
        'comboEmpType.SelectedIndex = comboEmpType.FindStringExact(FormEmployees.listViewEmp.Items(selectedIndex).SubItems(1).Text)
        'txtEmpName.Text = FormEmployees.listViewEmp.Items(selectedIndex).SubItems(2).Text
        'txtEmpAddress.Text = FormEmployees.listViewEmp.Items(selectedIndex).SubItems(3).Text
        'txtEmpPhone.Text = FormEmployees.listViewEmp.Items(selectedIndex).SubItems(4).Text
        'txtEmpHours.Text = FormEmployees.listViewEmp.Items(selectedIndex).SubItems(5).Text
        'txtEmpPayRate.Text = FormEmployees.listViewEmp.Items(selectedIndex).SubItems(6).Text

        Me.Show()

    End Sub
End Class
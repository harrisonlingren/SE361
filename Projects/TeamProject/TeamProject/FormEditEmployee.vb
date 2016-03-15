Public Class FormEditEmployee
    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnEmpCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEmpSave_Click(sender As Object, e As EventArgs) Handles btnEmpSave.Click

        Dim emp1 As New cEmployee

        emp1.id = CInt(FormCustomers.listViewCust.Items.Count)
        emp1.type = comboEmpType.SelectedValue
        emp1.name = txtEmpName.Text
        emp1.address = txtEmpAddress.Text
        emp1.phone = txtEmpPhone.Text
        emp1.hours = txtEmpHours.Text
        emp1.payRate = txtEmpPayRate.text

        FormCustomers.listViewCust.Items.Add(emp1.id)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.type)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.name)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.address)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.phone)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.hours)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(emp1.payRate)

    End Sub
End Class
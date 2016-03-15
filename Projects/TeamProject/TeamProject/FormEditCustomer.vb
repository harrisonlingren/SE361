Public Class FormEditCustomer
    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnCustCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCustSave_Click(sender As Object, e As EventArgs) Handles btnCustSave.Click

        Dim cust1 As New cCustomer

        cust1.id = CInt(FormCustomers.listViewCust.Items.Count)
        cust1.name = txtCustName.Text
        cust1.email = txtCustEmail.Text
        cust1.phone = txtCustPhone.Text
        cust1.address = txtCustAddress.Text

        FormCustomers.listViewCust.Items.Add(cust1.id)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(cust1.name)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(cust1.address)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(cust1.phone)
        FormCustomers.listViewCust.Items(FormCustomers.listViewCust.Items.Count - 1).SubItems.Add(cust1.email)

    End Sub

    Public Sub loadCustomer(selectedIndex As Integer)

        txtCustID.Text = FormCustomers.listViewCust.Items(selectedIndex).Text
        txtCustName.Text = FormCustomers.listViewCust.Items(selectedIndex).SubItems(0).Text
        txtCustAddress.Text = FormCustomers.listViewCust.Items(selectedIndex).SubItems(1).Text
        txtCustPhone.Text = FormCustomers.listViewCust.Items(selectedIndex).SubItems(2).Text
        txtCustEmail.Text = FormCustomers.listViewCust.Items(selectedIndex).SubItems(3).Text

        Me.Show()
    End Sub
End Class
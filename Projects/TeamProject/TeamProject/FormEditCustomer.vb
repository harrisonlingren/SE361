Public Class FormEditCustomer
    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnCustCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCustSave_Click(sender As Object, e As EventArgs) Handles btnCustSave.Click

        Dim cust1 As New cCustomer

        Dim itemCount As Integer
        itemCount = 0
        For Each item As ListViewItem In FormCustomers.listViewCust.Items
            If Not item.Text = "" Then
                itemCount += 1
            End If
        Next

        cust1.id = CInt(itemCount)
        cust1.name = txtCustName.Text
        cust1.email = txtCustEmail.Text
        cust1.phone = txtCustPhone.Text
        cust1.address = txtCustAddress.Text

        FormCustomers.listViewCust.Items.Add(cust1.id)
        FormCustomers.listViewCust.Items(cust1.id).SubItems.Add(cust1.name)
        FormCustomers.listViewCust.Items(cust1.id).SubItems.Add(cust1.address)
        FormCustomers.listViewCust.Items(cust1.id).SubItems.Add(cust1.phone)
        FormCustomers.listViewCust.Items(cust1.id).SubItems.Add(cust1.email)

        Me.Close()

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
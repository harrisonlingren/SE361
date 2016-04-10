Public Class FormEditCustomer
    Private newID As Integer
    Public formType As Integer

    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnCustCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCustSave_Click(sender As Object, e As EventArgs) Handles btnCustSave.Click

        'Check if adding new customer or editing current customer
        If formType = 0 Then
            Dim tempCust As New cCustomer

            tempCust.id = newID
            tempCust.name = CType(txtCustName.Text, String)
            tempCust.phone = CType(txtCustPhone.Text, String)
            tempCust.email = CType(txtCustEmail.Text, String)
            tempCust.address = CType(txtCustAddress.Text, String)

            Dim testQ As Integer = FormCustomers.CustomerTableAdapter.InsertQuery(tempCust.name, tempCust.address, tempCust.phone, tempCust.email)
            MessageBox.Show("Rows affected: " & testQ)

        ElseIf formType = 1 Then
            Dim tempCust As New cCustomer

            tempCust.id = CType(txtCustID.Text, Integer)
            tempCust.name = CType(txtCustName.Text, String)
            tempCust.phone = CType(txtCustPhone.Text, String)
            tempCust.email = CType(txtCustEmail.Text, String)
            tempCust.address = CType(txtCustAddress.Text, String)

            Dim testQ As Integer = FormCustomers.CustomerTableAdapter.UpdateQuery(tempCust.name, tempCust.address, tempCust.phone, tempCust.email, tempCust.id)
            MessageBox.Show("Rows affected: " & testQ)
        End If

        FormCustomers.Refresh()
        FormCustomers.reloadData()
        Me.Close()

    End Sub

    Private Sub FormEditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formType = 0 Then
            'check if adding new customer, update with new id
            newID = CType(FormCustomers.CustomerTableAdapter.GetCustID.Last.cust_id, Integer) + 1
            Console.WriteLine("New customer ID: " & newID)
            txtCustID.Text = CStr(newID)

        ElseIf formType = 1 Then
            'if editing customer, load values to textboxes

            txtCustID.Text = FormCustomers.dvCust.CurrentRow.Cells(0).Value
            txtCustName.Text = FormCustomers.dvCust.CurrentRow.Cells(1).Value
            txtCustPhone.Text = FormCustomers.dvCust.CurrentRow.Cells(3).Value
            txtCustAddress.Text = FormCustomers.dvCust.CurrentRow.Cells(2).Value
            txtCustEmail.Text = FormCustomers.dvCust.CurrentRow.Cells(4).Value
        End If

    End Sub
End Class
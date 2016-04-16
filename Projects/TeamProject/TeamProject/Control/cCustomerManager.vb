Public Class cCustomerManager
    Private cust As New cCustomer

    Public Sub save(editType As Integer)
        cust.name = CType(FormObjectEditor.txtName.Text, String)
        cust.phone = CType(FormObjectEditor.txtPhone.Text, String)
        cust.email = CType(FormObjectEditor.txtEmail.Text, String)
        cust.address = CType(FormObjectEditor.txtAddress.Text, String)

        'Check if adding new customer or editing current customer
        If editType = 0 Then
            cust.id = 0
            Dim testQ As Integer = FormCustomers.CustomerTableAdapter.InsertQuery(cust.name, cust.address, cust.phone, cust.email)
            'MessageBox.Show("Rows affected: " & testQ)

        ElseIf editType = 1 Then
            cust.id = CType(FormObjectEditor.txtID.Text, Integer)
            Dim testQ As Integer = FormCustomers.CustomerTableAdapter.UpdateQuery(cust.name, cust.address, cust.phone, cust.email, cust.id)
            'MessageBox.Show("Rows affected: " & testQ)
        End If

        FormCustomers.Refresh()
        FormCustomers.reloadData()
    End Sub

    Public Sub New()
    End Sub

End Class

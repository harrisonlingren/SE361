Imports MySql.Data.MySqlClient

Public Class FormEditCustomer
    Private Sub btnCustCancel_Click(sender As Object, e As EventArgs) Handles btnCustCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCustSave_Click(sender As Object, e As EventArgs) Handles btnCustSave.Click

        Dim cust1 As New cCustomer

        MessageBox.Show(FormMain.runDBquery("select count(cust_id) from Customers"))
        Dim itemcount As Integer = CInt(FormMain.runDBquery("select count(cust_id) from Customers"))

        cust1.id = CInt(itemCount)
        cust1.name = txtCustName.Text
        cust1.email = txtCustEmail.Text
        cust1.phone = txtCustPhone.Text
        cust1.address = txtCustAddress.Text

        Dim addQuery As String
        addQuery = "insert into Customers (cust_id, cust_name, cust_address, cust_phone, cust_email) values " & cust1.id & "," & cust1.name & "," & cust1.address & "," & cust1.phone & "," & cust1.email

        MessageBox.Show(FormMain.runDBquery(addQuery))
        Me.Close()

    End Sub
End Class
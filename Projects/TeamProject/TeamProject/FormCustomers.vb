Public Class FormCustomers
    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub

    Private Sub listViewCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCust.SelectedIndexChanged
        btnEditCust.Enabled = True
    End Sub
End Class
Public Class FormCustomers
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCust.SelectedIndexChanged

    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub
End Class
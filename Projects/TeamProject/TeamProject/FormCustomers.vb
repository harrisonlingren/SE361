Public Class FormCustomers

    Private selectedIndex As Integer

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub

    Private Sub listViewCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCust.SelectedIndexChanged
        btnEditCust.Enabled = True

        Try
            selectedIndex = listViewCust.SelectedItems(0).Index
        Catch ex As Exception
            selectedIndex = 0
        End Try

    End Sub

    Private Sub btnEditCust_Click(sender As Object, e As EventArgs) Handles btnEditCust.Click
        FormEditCustomer.loadCustomer(selectedIndex)
    End Sub

    Private Sub listViewCust_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listViewCust.MouseDoubleClick
        FormEditCustomer.loadCustomer(selectedIndex)
    End Sub
End Class
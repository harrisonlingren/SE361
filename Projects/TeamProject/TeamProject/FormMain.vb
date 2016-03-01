Public Class FormMain
    Private Sub btnCust_Click(sender As Object, e As EventArgs) Handles btnCust.Click
        FormCustomers.Show()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        FormEmployees.Show()
    End Sub

    Private Sub btnAppts_Click(sender As Object, e As EventArgs) Handles btnAppts.Click
        FormAppts.Show()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        FormInvoice.Show()
    End Sub

    Private Sub btnJobs_Click(sender As Object, e As EventArgs) Handles btnJobs.Click
        FormJobs.Show()
    End Sub
End Class

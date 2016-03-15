Imports MySql.Data.MySqlClient

Public Class FormMain

    Public dbString As String = "server=lingren.co;user id=se361;password=GhDTjzmRNzMEt7w7;persistsecurityinfo=True;database=se361"

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

    Public Function runDBquery(ByVal query As String)

        Using dbCustomer As New MySqlConnection
            dbCustomer.ConnectionString = dbString
            Try
                dbCustomer.Open()
                Dim cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Connection = dbCustomer
                cmd.ExecuteNonQuery()
                Return True

            Catch ex As Exception
                MessageBox.Show("Error occurred:" & ex.ToString)
                Return False

            Finally
                dbCustomer.Close()
            End Try
        End Using

    End Function

End Class

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

    Public Function runDBquery(ByVal query As String) As String

        Using dbCustomer As New MySqlConnection
            dbCustomer.ConnectionString = dbString
            Try
                dbCustomer.Open()
                Dim cmd As New MySqlCommand
                cmd.CommandText = query
                cmd.Connection = dbCustomer
                Return cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error occurred:" & ex.ToString)
                Return "Error"

            Finally
                dbCustomer.Close()
            End Try
        End Using

    End Function

    Public Function ParameterizedNonQueryCommand(ByRef NonQuery As String, ByVal Parameters As List(Of MySqlParameter),
        Optional ByVal Connection As MySql.Data.MySqlClient.MySqlConnection = Nothing) As String

        Dim comm As New MySql.Data.MySqlClient.MySqlCommand(NonQuery, Connection)
        Try
            For Each param As MySql.Data.MySqlClient.MySqlParameter In Parameters
                comm.Parameters.Add(param)
            Next
            If comm.Connection.State <> ConnectionState.Open Then comm.Connection.Open()
            comm.Prepare()
            Return comm.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.ToString
        Finally
            comm.Connection.Close()
            comm.Dispose()
        End Try
    End Function

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reloadForm()
    End Sub

    Private Sub reloadForm()
        Dim monthN, dayN, hourN, pm As String
        Timer1.Start()
        Select Case Date.Now.Month
            Case 0
                monthN = "January"
            Case 1
                monthN = "February"
            Case 2
                monthN = "March"
            Case 3
                monthN = "April"
            Case 4
                monthN = "May"
            Case 5
                monthN = "June"
            Case 6
                monthN = "July"
            Case 7
                monthN = "August"
            Case 8
                monthN = "September"
            Case 9
                monthN = "October"
            Case 10
                monthN = "November"
            Case 11
                monthN = "December"
        End Select

        Select Case Date.Now.DayOfWeek
            Case 0
                dayN = "Sunday"
            Case 1
                dayN = "Monday"
            Case 2
                dayN = "Tuesday"
            Case 3
                dayN = "Wednesday"
            Case 4
                dayN = "Thursday"
            Case 5
                dayN = "Friday"
            Case 6
                dayN = "Saturday"
        End Select
        If Date.Now.Hour > 12 Then
            hourN = CStr(Date.Now.Hour - 12)
            pm = "PM"
        Else
            pm = "AM"
            hourN = CStr(Date.Now.Hour)
        End If

        lDate.Text = dayN & ", " & vbNewLine & monthN & " " & Date.Now.Day & ", " & Date.Now.Year & vbNewLine & hourN & ":" & Date.Now.Minute & " " & pm
    End Sub
End Class

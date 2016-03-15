Imports System
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FormCustomers

    Private da = New MySqlDataAdapter()
    Private dt = New DataTable

    Private selectedIndex As Integer

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        dvCustomer.EndEdit()
        da.Update(dt)
        Me.Close()
    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataCust()
    End Sub

    Private Sub loadDataCust()
        Dim dbConn As MySqlConnection = New MySqlConnection(FormMain.dbString)

        dvCustomer.Columns.Clear()
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim stm As String

        If dbConn.State = ConnectionState.Closed Then
            dbConn.Open()
        End If

        stm = "SELECT * FROM Customers"

        cmd.CommandType = CommandType.Text
        cmd.CommandText = stm
        cmd.Connection = dbConn

        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim cb As New MySqlCommandBuilder(da)
        With dvCustomer
            .AutoGenerateColumns = True
            .DataSource = dt
        End With

        cmd.Dispose()
        cmd = Nothing
        dbConn.Close()
        dbConn.Dispose()
    End Sub

    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click
        For Each row As DataGridViewRow In dvCustomer.SelectedRows
            MessageBox.Show("Deleting customer " & row.Cells(0).Value)
            Dim delQuery As String = "delete from Customers where cust_id = ?cust_id"
            Dim Params As New List(Of MySqlParameter)
            Params.Add(New MySqlParameter("cust_id", row.Cells(0).Value))
            Dim oConnection As MySqlConnection = New MySqlConnection(FormMain.dbString)
            MessageBox.Show(FormMain.ParameterizedNonQueryCommand(delQuery, Params, oConnection))
        Next

    End Sub
End Class
Imports System
Imports System.IO
Imports System.Text

Public Class FormCustomers

    Private selectedIndex As Integer

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click

    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.TeamProjectDataSet.Customer)
        loadDataCust()
    End Sub

    Private Sub loadDataCust()

    End Sub

    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click


    End Sub
End Class
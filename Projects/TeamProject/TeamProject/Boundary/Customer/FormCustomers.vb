Imports System
Imports System.IO
Imports System.Text

Public Class FormCustomers

    Public selectedIndex As Integer

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.formType = 0
        FormEditCustomer.Show()
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        Me.Close()
    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.TeamProjectDataSet.Customer)
    End Sub

    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click
        Dim custName As String = CType(dvCust.CurrentRow.Cells(1).Value, String)
        Console.WriteLine(custName & " to be deleted.")
        Dim resp = MessageBox.Show("Are you sure you want to delete '" & custName & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resp = DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvCust.Rows(selectedIndex).Cells
            CustomerTableAdapter.Delete(data(0).Value, data(1).Value, data(2).Value, data(3).Value, data(4).Value)
        End If
        Me.reloadData()
    End Sub

    Private Sub btnEditCust_Click(sender As Object, e As EventArgs) Handles btnEditCust.Click
        FormEditCustomer.formType = 1
        FormEditCustomer.Show()
    End Sub

    Public Sub reloadData()
        Me.CustomerTableAdapter.Fill(Me.TeamProjectDataSet.Customer)
    End Sub

    Private Sub dvCust_SelectionChanged(sender As Object, e As EventArgs) Handles dvCust.SelectionChanged
        Try
            selectedIndex = CType(dvCust.CurrentRow.Index, Integer)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            selectedIndex -= 1
        End Try
        Console.WriteLine("Row selected: " & selectedIndex)
        btnEditCust.Enabled = True
    End Sub
End Class
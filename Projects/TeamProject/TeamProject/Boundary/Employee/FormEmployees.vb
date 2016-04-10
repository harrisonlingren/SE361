Public Class FormEmployees

    Private selectedIndex As Integer

    Private Sub FormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.TeamProjectDataSet.Employee)

    End Sub

    Private Sub btnSaveEmp_Click(sender As Object, e As EventArgs) Handles btnSaveEmp.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        FormEditCustomer.formType = 0
        FormEditEmployee.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        FormEditEmployee.formType = 1
        FormEditEmployee.Show()
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Dim empName As String = CType(dvEmp.CurrentRow.Cells(1).Value, String)
        Console.WriteLine(empName & " to be deleted.")
        Dim resp = MessageBox.Show("Are you sure you want to delete '" & empName & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resp = DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvEmp.Rows(selectedIndex).Cells
            EmployeeTableAdapter.Delete(data(0).Value, data(1).Value, data(2).Value, data(3).Value, data(4).Value, data(5).Value, data(6).Value)
        End If
        Me.reloadData()
    End Sub

    Private Sub reloadData()
        Me.EmployeeTableAdapter.Fill(Me.TeamProjectDataSet.Employee)
    End Sub

    Private Sub dvEmp_SelectionChanged(sender As Object, e As EventArgs) Handles dvEmp.SelectionChanged
        Try
            selectedIndex = CType(dvEmp.CurrentRow.Index, Integer)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            selectedIndex -= 1
        End Try
        Console.WriteLine("Row selected: " & selectedIndex)
        btnEditEmp.Enabled = True
    End Sub

End Class
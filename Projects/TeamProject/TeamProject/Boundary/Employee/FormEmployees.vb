Public Class FormEmployees

    Private selectedIndex As Integer

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) 
        FormEditEmployee.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) 
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub

    Private Sub FormEmployees_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub

    Private Sub FormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.TeamProjectDataSet.Employee)

    End Sub
End Class
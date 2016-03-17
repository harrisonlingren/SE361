Public Class FormEmployees

    Private selectedIndex As Integer

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        FormEditEmployee.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub

    Private Sub FormEmployees_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub

    Private Sub FormEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Se361DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Se361DataSet.Employee)

    End Sub
End Class
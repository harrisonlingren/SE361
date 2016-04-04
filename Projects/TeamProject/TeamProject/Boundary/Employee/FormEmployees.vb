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

End Class
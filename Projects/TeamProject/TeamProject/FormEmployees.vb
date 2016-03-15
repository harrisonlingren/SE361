Public Class FormEmployees

    Private selectedIndex As Integer

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        FormEditEmployee.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub

    Private Sub listViewEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewEmp.SelectedIndexChanged

        btnEditEmp.Enabled = True

        Try
            selectedIndex = listViewEmp.SelectedItems(0).Index
        Catch ex As Exception
            selectedIndex = 0
        End Try

    End Sub

    Private Sub FormEmployees_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        FormEditEmployee.loadEmployee(selectedIndex)
    End Sub
End Class
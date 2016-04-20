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
        FormObjectEditor.formType = 0
        FormObjectEditor.globalIndex = 2
        FormObjectEditor.Show()
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        FormObjectEditor.formType = 1
        FormObjectEditor.globalIndex = 2
        FormObjectEditor.Show()
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Dim empName As String = CType(dvEmp.CurrentRow.Cells(1).Value, String)
        Console.WriteLine(empName & " to be deleted.")
        Dim resp = MessageBox.Show("Are you sure you want to delete '" & empName & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resp = DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvEmp.Rows(selectedIndex).Cells
            Dim em As New cEmployeeManager
            em.delete(data)
        End If
        Me.reloadData()
    End Sub

    Public Sub reloadData()
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
Public Class FormInvoice
    Private selectedIndex As Integer

    Private Sub btnAddInvoice_Click(sender As Object, e As EventArgs) Handles btnAddInv.Click
        FormObjectEditor.globalIndex = 3
        FormObjectEditor.formType = 0
        FormObjectEditor.Show()
    End Sub

    Private Sub btnEditInvoice_Click(sender As Object, e As EventArgs) Handles btnEditInv.Click
        FormObjectEditor.globalIndex = 3
        FormObjectEditor.formType = 1
        FormObjectEditor.Show()
    End Sub

    Private Sub FormInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadData()
    End Sub

    Public Sub reloadData()
        Me.InvoiceTableAdapter.Fill(Me.TeamProjectDataSet.Invoice)
    End Sub

    Private Sub btnSaveInv_Click(sender As Object, e As EventArgs) Handles btnSaveInv.Click
        Me.Close()
    End Sub

    Private Sub btnDelInv_Click(sender As Object, e As EventArgs) Handles btnDelInv.Click
        Dim invID As String = CType(dvInv.CurrentRow.Cells(0).Value, String)
        Console.WriteLine(invID & " to be deleted.")

        Dim resp = MessageBox.Show("Are you sure you want to delete invoice'" & invID & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resp = Windows.Forms.DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvInv.Rows(selectedIndex).Cells
            Dim im As New cInvoiceManager
            im.delete(data)
        End If

        reloadData()
    End Sub
End Class
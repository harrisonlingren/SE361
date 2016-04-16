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
End Class
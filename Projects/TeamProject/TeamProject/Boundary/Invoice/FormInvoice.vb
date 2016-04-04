Public Class FormInvoice
    Private Sub btnAddInvoice_Click(sender As Object, e As EventArgs)
        FormEditInvoice.Show()
    End Sub

    Private Sub FormInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.TeamProjectDataSet.Invoice)

    End Sub
End Class
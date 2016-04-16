Public Class cInvoiceManager
    Private inv As New cInvoice

    Public Sub save(editType As Integer)
        inv.cost = CType(FormObjectEditor.txtAmount.Text, Decimal)
        inv.datetime = CType(FormObjectEditor.dtDate.Value, String)
        inv.duedate = CType(FormObjectEditor.dtDueDate.Value, String)

        'Check if adding new invoice or editing current invoice
        If editType = 0 Then
            inv.id = 0
            Dim testQ As Integer = FormInvoice.InvoiceTableAdapter.InsertQuery(inv.datetime, inv.cost, inv.duedate)
            'MessageBox.Show("Rows affected: " & testQ)

        ElseIf editType = 1 Then
            inv.id = CType(FormObjectEditor.txtID.Text, Integer)
            Dim testQ As Integer = FormInvoice.InvoiceTableAdapter.UpdateQuery(inv.datetime, inv.cost, inv.duedate, inv.id)
            'MessageBox.Show("Rows affected: " & testQ)
        End If

        FormInvoice.Refresh()
        FormInvoice.reloadData()
    End Sub

    Public Sub New()
    End Sub

End Class

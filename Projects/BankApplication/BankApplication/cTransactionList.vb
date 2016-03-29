Public Class cTransactionList

    Private transList As Collection

    Public Sub addTransaction(trans As cTransaction)
        transList.Add(trans)
        updateAccount(FormMain.am.getAccount(trans.type), FormMain.am, trans.amount)
    End Sub

    Public Sub updateAccount(acc As cAccount, am As cAccountManager, amt As Decimal)
        am.updateBalance(acc, amt)
    End Sub

    Public Sub syncItemsToGUI(name As String)
        If name = "Checking" Then
            For Each transaction In transList
                FormMain.lvCheckingDetails.Items.Add(transaction.ToString)
            Next
        ElseIf name = "Savings" Then
            For Each transaction In transList
                FormMain.lvSavingsDetails.Items.Add(transaction.ToString)
            Next
        End If
    End Sub

    Public Sub New()
        transList = New Collection
    End Sub

    Public Property transactions As Collection
        Get
            Return transList
        End Get
        Set(value As Collection)
            transList = value
        End Set
    End Property
End Class

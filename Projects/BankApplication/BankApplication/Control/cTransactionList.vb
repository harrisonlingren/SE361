Public Class cTransactionList

    Private transList As Collection

    ' Add a new transaction to the collection
    Public Sub addTransaction(trans As cTransaction)
        transList.Add(trans)
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

Public Class cInvoice

    Private invoiceID As Integer
    Private invoiceDate As String
    Private invoiceCost As Decimal
    Private invoiceDueDate As String

    Public Sub New()
        invoiceID = 0
        invoiceDate = String.Empty
        invoiceCost = 0.0
        invoiceDueDate = String.Empty
    End Sub

    Public Property id As Integer
        Get
            Return invoiceID
        End Get
        Set(ByVal value As Integer)
            invoiceID = value
        End Set
    End Property

    Public Property datetime As String
        Get
            Return invoiceDate
        End Get
        Set(value As String)
            invoiceDate = value
        End Set
    End Property

    Public Property cost As Decimal
        Get
            Return invoiceCost
        End Get
        Set(value As Decimal)
            invoiceCost = value
        End Set
    End Property

    Public Property duedate As String
        Get
            Return invoiceDueDate
        End Get
        Set(value As String)
            invoiceDueDate = duedate
        End Set
    End Property

End Class

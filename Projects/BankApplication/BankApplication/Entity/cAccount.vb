Public Class cAccount

    Private tl As cTransactionList
    Private n As String
    Private b As Decimal

    Public Sub New()
        n = ""
        b = 0.0

    End Sub

    Public Property name As String
        Get
            Return n
        End Get
        Set(value As String)
            n = value
        End Set
    End Property

    Public Property balance As Decimal
        Get
            Return b
        End Get
        Set(value As Decimal)
            b = value
        End Set
    End Property

    Public Property transList As cTransactionList
        Get
            Return tl
        End Get
        Set(value As cTransactionList)
            tl = value
        End Set
    End Property

End Class

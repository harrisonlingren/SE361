Public Class cTransaction

    Private n As String
    Private a As Decimal
    Private d As Date
    Private t As String

    ' new transaction, init method
    Public Sub New()
        n = String.Empty
        a = 0.0
        d = Date.Now
        t = String.Empty
    End Sub

    ' get/set name
    Public Property name As String
        Get
            Return n
        End Get
        Set(value As String)
            n = value
        End Set
    End Property

    ' get/set amount
    Public Property amount As Decimal
        Get
            Return a
        End Get
        Set(value As Decimal)
            a = value
        End Set
    End Property

    ' get/set datetime
    Public Property datetime As Date
        Get
            Return d
        End Get
        Set(value As Date)
            d = value
        End Set
    End Property

    ' get/set type
    Public Property type As String
        Get
            Return t
        End Get
        Set(value As String)
            t = value
        End Set
    End Property

    ' return transaction as string
    Public Function ToString2() As String
        Return d & "   " & n & "   " & a.ToString("C2")
    End Function

End Class

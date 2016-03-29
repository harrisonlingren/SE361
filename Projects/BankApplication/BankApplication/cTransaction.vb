Public Class cTransaction

    Private n As String
    Private a As Decimal
    Private d As Date
    Private t As String

    Public Sub New(na As String, am As Decimal, da As Date, ty As String)
        n = na
        a = am
        d = da
        t = ty
    End Sub

    Public Property name As String
        Get
            Return n
        End Get
        Set(value As String)
            n = value
        End Set
    End Property

    Public Property amount As Decimal
        Get
            Return a
        End Get
        Set(value As Decimal)
            a = value
        End Set
    End Property

    Public Property datetime As Date
        Get
            Return d
        End Get
        Set(value As Date)
            d = value
        End Set
    End Property

    Public Property type As String
        Get
            Return t
        End Get
        Set(value As String)
            t = value
        End Set
    End Property

    Public Function ToString() As String
        Return d & "   " & n & "   " & a
    End Function

End Class

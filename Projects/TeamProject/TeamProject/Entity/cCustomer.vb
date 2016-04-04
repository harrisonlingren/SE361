Public Class cCustomer

    Private custID As Integer
    Private custName As String
    Private custAddr As String
    Private custPhone As String
    Private custEmail As String

    Public Sub New()
        custID = 0
        custName = String.Empty
        custAddr = String.Empty
        custPhone = 0
        custEmail = String.Empty
    End Sub

    Public Property id As Integer
        Get
            Return custID
        End Get
        Set(ByVal value As Integer)
            custID = value
        End Set
    End Property

    Public Property phone As String
        Get
            Return custPhone
        End Get
        Set(ByVal value As String)
            custPhone = value
        End Set
    End Property

    Public Property name As String
        Get
            Return custName
        End Get
        Set(ByVal value As String)
            custName = value
        End Set
    End Property

    Public Property email As String
        Get
            Return custEmail
        End Get
        Set(ByVal value As String)
            custEmail = value
        End Set
    End Property

    Public Property address As String
        Get
            Return custAddr
        End Get
        Set(ByVal value As String)
            custAddr = value
        End Set
    End Property

End Class

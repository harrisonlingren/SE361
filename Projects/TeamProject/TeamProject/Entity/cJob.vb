Public Class cJob

    Private jobID As Integer
    Private jobDate As String
    Private jobAddress As String
    Private jobCost As Decimal

    Public Sub New()
        jobID = 0
        jobDate = Date.Now
        jobAddress = String.Empty
        jobCost = 0.0
    End Sub

    Public Property id As Integer
        Get
            Return jobID
        End Get
        Set(value As Integer)
            jobID = value
        End Set
    End Property

    Public Property datetime As String
        Get
            Return jobDate
        End Get
        Set(value As String)
            jobDate = value
        End Set
    End Property

    Public Property address As String
        Get
            Return jobAddress
        End Get
        Set(value As String)
            jobAddress = value
        End Set
    End Property

    Public Property cost As Double
        Get
            Return jobCost
        End Get
        Set(value As Double)
            jobCost = value
        End Set
    End Property

End Class
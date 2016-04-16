Public Class cAppointment

    Private apptID As Integer
    Private apptDate As String
    Private apptAddr As String

    Public Sub New()
        apptID = 0
        apptDate = Date.Now
        apptAddr = String.Empty
    End Sub

    Public Property id As Integer
        Get
            Return apptID
        End Get
        Set(ByVal value As Integer)
            apptID = value
        End Set
    End Property

    Public Property datetime As String
        Get
            Return apptDate
        End Get
        Set(value As String)
            apptDate = value
        End Set
    End Property

    Public Property address As String
        Get
            Return apptAddr
        End Get
        Set(value As String)
            apptAddr = value
        End Set
    End Property
End Class

Public Class cEmployee

    Private empID As Integer
    Private empName As String
    Private empAddr As String
    Private empPhone As Integer
    Private empHours As String
    Private empPayRate As Double

    Public Sub New()
        empID = 0
        empName = String.Empty
        empAddr = String.Empty
        empPhone = 0
        empHours = String.Empty
        empPayRate = 0.0
    End Sub

    Public Property id As Integer
        Get
            Return empID
        End Get
        Set(value As Integer)
            empID = id
        End Set
    End Property

    Public Property name As String
        Get
            Return empName
        End Get
        Set(value As String)
            empName = name
        End Set
    End Property

    Public Property address As String
        Get
            Return empAddr
        End Get
        Set(value As String)
            empAddr = address
        End Set
    End Property

    Public Property phone As Integer
        Get
            Return empPhone
        End Get
        Set(value As Integer)
            empPhone = phone
        End Set
    End Property

    Public Property hours As String
        Get
            Return empHours
        End Get
        Set(value As String)
            empHours = hours
        End Set
    End Property

    Public Property payRate As Double
        Get
            Return empPayRate
        End Get
        Set(value As Double)
            empPayRate = payRate
        End Set
    End Property

End Class

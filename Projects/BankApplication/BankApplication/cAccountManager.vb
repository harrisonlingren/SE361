Public Class cAccountManager

    Private check As cAccount
    Private save As cAccount

    Public Property checking As cAccount
        Get
            Return check
        End Get
        Set(value As cAccount)
            check = value
        End Set
    End Property

    Public Property savings As cAccount
        Get
            Return save
        End Get
        Set(value As cAccount)
            save = value
        End Set
    End Property

    Public Sub updateBalance(acc As cAccount, amt As Decimal)
        acc.balance = acc.balance + amt
        Console.WriteLine(acc.balance)
    End Sub

    Public Sub New()
        check = New cAccount("Checking", 0)
        save = New cAccount("Savings", 0)
    End Sub

    Public Function getAccount(index As Integer) As cAccount
        If index = 0 Then
            Return check
        ElseIf index = 1 Then
            Return save
        End If
    End Function

    Public Function getAccount(type As String) As cAccount
        If type = "Checking" Then
            Return check
        ElseIf type = "Savings" Then
            Return save
        End If
    End Function

End Class

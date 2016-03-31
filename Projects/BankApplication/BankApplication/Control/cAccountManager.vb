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

    ' Check which account is being updated, update the appropriate balance with "amt"
    Public Function updateBalance(acc As String, amt As Decimal) As Integer
        If acc = "Checking" Then
            If amt < 0 Then
                If -amt >= check.balance Then
                    MessageBox.Show("Error: insufficient funds in account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                Else
                    check.balance += amt
                    Return 1
                End If
            Else
                check.balance += amt
                Return 1
            End If

        ElseIf acc = "Savings" Then
            If amt < 0 Then
                If -amt >= save.balance Then
                    MessageBox.Show("Error: insufficient funds in account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                Else
                    save.balance += amt
                    Return 1
                End If
            Else
                save.balance += amt
                Return 1
            End If
        Else
            Return -1
        End If
    End Function

    Public Sub New()
        check = New cAccount
        check.name = "Checking"
        check.balance = 0.0
        check.transList = New cTransactionList

        save = New cAccount
        save.name = "Savings"
        save.balance = 0.0
        save.transList = New cTransactionList
    End Sub

    ' Return the right account using a selected index value (Integer)
    Public Function getAccount(index As Integer) As cAccount
        If index = 0 Then
            'Console.WriteLine(index & ": Returning checking account")
            Return check
        ElseIf index = 1 Then
            'Console.WriteLine(index & ": Returning savings account")
            Return save
        Else
            'Console.WriteLine("Error: Not account found by index=" & index)
            Return New cAccount
        End If
    End Function

    ' Return the right account using a key (String)
    Public Function getAccount(type As String) As cAccount
        If type = "Checking" Then
            'Console.WriteLine(type & ": Returning checking account")
            Return check
        ElseIf type = "Savings" Then
            'Console.WriteLine(type & ": Returning savings account")
            Return save
        Else
            'Console.WriteLine("Error: Not account found by key=" & type)
            Return New cAccount
        End If
    End Function

End Class

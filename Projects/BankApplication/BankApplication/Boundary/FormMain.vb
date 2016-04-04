Imports System.ComponentModel

Public Class FormMain

    Public am As cAccountManager
    Private files As cFileManager

    Private Sub comboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAccount.SelectedIndexChanged
        If comboAccount.SelectedIndex = 0 Then
            lvCheckingDetails.Visible = True
            lvSavingsDetails.Visible = False
        Else
            lvCheckingDetails.Visible = False
            lvSavingsDetails.Visible = True
        End If
        reload()
    End Sub

    Private Sub comboReceiveAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboReceiveAcct.SelectedIndexChanged
        If comboReceiveAcct.SelectedIndex = 0 Then
            comboTransferAcct.SelectedIndex = 1
        Else
            comboTransferAcct.SelectedIndex = 0
        End If
    End Sub

    Private Sub comboTransferAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTransferAcct.SelectedIndexChanged
        If comboTransferAcct.SelectedIndex = 0 Then
            comboReceiveAcct.SelectedIndex = 1
        Else
            comboReceiveAcct.SelectedIndex = 0
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' create account manager instance to use in program, sets account in view to checking
        am = New cAccountManager()
        comboAccount.SelectedIndex = 0

        reload()
    End Sub

    Private Sub reload()
        ' reloads the form, gets new listbox details and resets the date
        txtDate.Text = Date.Now.ToString("MM/dd/yyyy")

        Dim currAccount As cAccount = am.getAccount(comboAccount.SelectedIndex)
        If currAccount.name = "Checking" Then
            getCheckingDetails()
        ElseIf currAccount.name = "Savings" Then
            getSavingsDetails()
        End If

        txtBalance.Text = am.getAccount(comboAccount.SelectedIndex).balance.ToString("C2")

        Console.WriteLine("Checking account: " & am.checking.balance)
        Console.WriteLine("Savings account: " & am.savings.balance)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resp = MessageBox.Show("Exit without saving?", "Exit Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = DialogResult.No Then
            saveData()
        End If
    End Sub

    Private Sub saveData()
        ' adds a file manager and saves to file
        Dim fm As New cFileManager
        fm.filename = "check.txt"
        fm.saveToFile(am.getAccount("Checking").transList.transactions)
        fm.filename = "save.txt"
        fm.saveToFile(am.getAccount("Savings").transList.transactions)
    End Sub

    ' Reloads the checking listBox with the transactions on the account
    Public Sub getCheckingDetails()
        ' clears items from listbox and adds them from the account
        lvCheckingDetails.Items.Clear()
        If am.getAccount(comboAccount.SelectedIndex).transList.transactions.Count > 0 Then
            For Each transaction In am.getAccount(comboAccount.SelectedIndex).transList.transactions
                lvCheckingDetails.Items.Add(transaction.ToString2())
            Next
        End If
    End Sub

    ' Reloads the checking listBox with the transactions on the account
    Public Sub getSavingsDetails()
        ' clears items from listbox and adds them from the account
        lvSavingsDetails.Items.Clear()
        If am.getAccount(comboAccount.SelectedIndex).transList.transactions.Count > 0 Then
            For Each transaction In am.getAccount(comboAccount.SelectedIndex).transList.transactions
                lvSavingsDetails.Items.Add(transaction.ToString2())
            Next
        End If
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim dep As cTransaction = New cTransaction

        dep.name = "Deposit"
        dep.datetime = Date.Now
        dep.amount = CDec(txtDeposit.Text)
        dep.type = comboAccount.Text

        Console.WriteLine("New Transaction: " & dep.ToString) ' for debugging

        ' Get the current account and add the new Deposit transaction
        am.getAccount(comboAccount.SelectedIndex).transList.addTransaction(dep)

        ' Update the account's balance with the transaction amount
        am.updateBalance(comboAccount.Text, dep.amount)
        reload()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim withd As cTransaction = New cTransaction

        withd.amount = -1 * CDec(txtWithdraw.Text)
        withd.name = "Withdrawl"
        withd.datetime = Date.Now
        withd.type = comboAccount.Text

        Console.WriteLine("New Transaction: " & withd.ToString) ' for debugging

        Dim resp As Integer = am.updateBalance(comboAccount.Text, withd.amount)
        If resp = 1 Then
            am.getAccount(comboAccount.SelectedIndex).transList.addTransaction(withd)
        End If

        reload()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        ' make a new transfer transaction
        Dim transf As cTransaction = New cTransaction
        transf.name = "Transfer to " & comboReceiveAcct.Text
        transf.amount = CDec(txtTransferAmt.Text)
        transf.datetime = Date.Now
        transf.type = comboAccount.Text

        ' this doesn't completely work yet
        ' updates balance and makes a adds a transaction if the balance is updated
        Dim resp1 As Integer = am.updateBalance(comboReceiveAcct.Text, transf.amount)
        If resp1 = 1 Then
            am.getAccount(comboReceiveAcct.Text).transList.addTransaction(transf)
        End If

        transf.name = "Transfer from " & comboTransferAcct.Text
        transf.amount = CDec(txtTransferAmt.Text) * -1

        ' this doesn't completely work yet
        ' updates balance and makes a adds a transaction if the balance is updated
        Dim resp2 As Integer = am.updateBalance(comboTransferAcct.Text, transf.amount)
        If resp2 = 1 Then
            am.getAccount(comboTransferAcct.Text).transList.addTransaction(transf)
        End If

        reload()

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim signCheck As New cTransaction
        signCheck.name = txtCheckName.Text
        signCheck.amount = CDec(txtCheckAmt.Text)
        signCheck.type = "Checking"
        signCheck.datetime = Date.Now


        Dim resp As Integer = am.updateBalance("Checking", -1 * signCheck.amount)
        If resp = 1 Then
            am.checking.transList.addTransaction(signCheck)
        End If

        reload()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCheckAmt.Text = String.Empty
        txtCheckName.Text = String.Empty
        txtDeposit.Text = String.Empty
        txtTransferAmt.Text = String.Empty
        txtWithdraw.Text = String.Empty

        am = New cAccountManager

        reload()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveData()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' adds a file manager and loads from file
        Dim fm As New cFileManager
        fm.filename = "check.txt"
        fm.readFromFile(am.getAccount("Checking").transList.transactions)
        fm.filename = "save.txt"
        fm.readFromFile(am.getAccount("Savings").transList.transactions)

        'sync transactionList with account balances
        For Each transaction As cTransaction In am.getAccount("Checking").transList.transactions
            am.updateBalance("Checking", transaction.amount)
        Next

        For Each transaction As cTransaction In am.getAccount("Savings").transList.transactions
            am.updateBalance("Savings", transaction.amount)
        Next

        reload()
    End Sub
End Class

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
        comboAccount.SelectedIndex = 0
        reload()
    End Sub

    Private Sub reload()
        txtDate.Text = Date.Now.ToString("MM/dd/yyyy")
        am = New cAccountManager()
        Dim currAccount As cAccount = am.getAccount(comboAccount.SelectedIndex)
        currAccount.transList.syncItemsToGUI(currAccount.name)

        txtBalance.Text = am.getAccount(comboAccount.SelectedIndex).balance.ToString("C2")

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

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim acc As cAccount = am.getAccount(comboAccount.SelectedIndex)
        acc.transList.addTransaction(New cTransaction("Deposit", CDec(txtDeposit.Text), Date.Now, comboAccount.Text))
        reload()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim acc As cAccount = am.getAccount(comboAccount.SelectedIndex)
        acc.transList.addTransaction(New cTransaction("Withdrawl", CDec(txtWithdraw.Text), Date.Now, comboAccount.Text))
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboAccount = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTransferAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboReceiveAcct = New System.Windows.Forms.ComboBox()
        Me.comboTransferAcct = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCheckAmt = New System.Windows.Forms.TextBox()
        Me.txtCheckName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvCheckingDetails = New System.Windows.Forms.ListBox()
        Me.lvSavingsDetails = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account:"
        '
        'comboAccount
        '
        Me.comboAccount.FormattingEnabled = True
        Me.comboAccount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.comboAccount.Location = New System.Drawing.Point(68, 12)
        Me.comboAccount.Name = "comboAccount"
        Me.comboAccount.Size = New System.Drawing.Size(121, 21)
        Me.comboAccount.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Controls.Add(Me.txtDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 71)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit"
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(154, 28)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 1
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(6, 30)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(142, 20)
        Me.txtDeposit.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnWithdraw)
        Me.GroupBox2.Controls.Add(Me.txtWithdraw)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 71)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Withdrawl"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(154, 27)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(6, 29)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(142, 20)
        Me.txtWithdraw.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(267, 12)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(92, 20)
        Me.txtBalance.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTransferAmt)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.comboReceiveAcct)
        Me.GroupBox3.Controls.Add(Me.comboTransferAcct)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnTransfer)
        Me.GroupBox3.Location = New System.Drawing.Point(267, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 148)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transfer"
        '
        'txtTransferAmt
        '
        Me.txtTransferAmt.Location = New System.Drawing.Point(108, 80)
        Me.txtTransferAmt.Name = "txtTransferAmt"
        Me.txtTransferAmt.Size = New System.Drawing.Size(121, 20)
        Me.txtTransferAmt.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "to (Account):"
        '
        'comboReceiveAcct
        '
        Me.comboReceiveAcct.FormattingEnabled = True
        Me.comboReceiveAcct.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.comboReceiveAcct.Location = New System.Drawing.Point(108, 53)
        Me.comboReceiveAcct.Name = "comboReceiveAcct"
        Me.comboReceiveAcct.Size = New System.Drawing.Size(121, 21)
        Me.comboReceiveAcct.TabIndex = 3
        '
        'comboTransferAcct
        '
        Me.comboTransferAcct.FormattingEnabled = True
        Me.comboTransferAcct.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.comboTransferAcct.Location = New System.Drawing.Point(108, 26)
        Me.comboTransferAcct.Name = "comboTransferAcct"
        Me.comboTransferAcct.Size = New System.Drawing.Size(121, 21)
        Me.comboTransferAcct.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transfer from:"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(79, 115)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(75, 23)
        Me.btnTransfer.TabIndex = 1
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCheckAmt)
        Me.GroupBox4.Controls.Add(Me.txtCheckName)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.btnCheck)
        Me.GroupBox4.Location = New System.Drawing.Point(508, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 148)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Check"
        '
        'txtCheckAmt
        '
        Me.txtCheckAmt.Location = New System.Drawing.Point(108, 26)
        Me.txtCheckAmt.Name = "txtCheckAmt"
        Me.txtCheckAmt.Size = New System.Drawing.Size(121, 20)
        Me.txtCheckAmt.TabIndex = 5
        '
        'txtCheckName
        '
        Me.txtCheckName.Location = New System.Drawing.Point(108, 74)
        Me.txtCheckName.Name = "txtCheckName"
        Me.txtCheckName.Size = New System.Drawing.Size(121, 20)
        Me.txtCheckName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "to the order of:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pay this amount:"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(79, 115)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Sign Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(374, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Accounts to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(374, 28)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(128, 23)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load Account from File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Today's Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(651, 12)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(92, 20)
        Me.txtDate.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(157, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(418, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvCheckingDetails
        '
        Me.lvCheckingDetails.FormattingEnabled = True
        Me.lvCheckingDetails.Location = New System.Drawing.Point(12, 203)
        Me.lvCheckingDetails.Name = "lvCheckingDetails"
        Me.lvCheckingDetails.Size = New System.Drawing.Size(731, 173)
        Me.lvCheckingDetails.TabIndex = 7
        '
        'lvSavingsDetails
        '
        Me.lvSavingsDetails.FormattingEnabled = True
        Me.lvSavingsDetails.Location = New System.Drawing.Point(12, 203)
        Me.lvSavingsDetails.Name = "lvSavingsDetails"
        Me.lvSavingsDetails.Size = New System.Drawing.Size(731, 173)
        Me.lvSavingsDetails.TabIndex = 8
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 417)
        Me.Controls.Add(Me.lvSavingsDetails)
        Me.Controls.Add(Me.lvCheckingDetails)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.comboAccount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMain"
        Me.Text = "Banking Software"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransferAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboTransferAcct As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheckName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtCheckAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents comboReceiveAcct As ComboBox
    Friend WithEvents lvCheckingDetails As ListBox
    Friend WithEvents lvSavingsDetails As ListBox
End Class

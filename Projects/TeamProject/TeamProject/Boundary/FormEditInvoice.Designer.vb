<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditInvoice
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
        Me.btnCustCancel = New System.Windows.Forms.Button()
        Me.btnCustSave = New System.Windows.Forms.Button()
        Me.txtInvoiceAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvoiceID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboInvoiceJob = New System.Windows.Forms.ComboBox()
        Me.comboInvoiceCust = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCustCancel
        '
        Me.btnCustCancel.Location = New System.Drawing.Point(143, 120)
        Me.btnCustCancel.Name = "btnCustCancel"
        Me.btnCustCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCustCancel.TabIndex = 23
        Me.btnCustCancel.Text = "Cancel"
        Me.btnCustCancel.UseVisualStyleBackColor = True
        '
        'btnCustSave
        '
        Me.btnCustSave.Location = New System.Drawing.Point(15, 120)
        Me.btnCustSave.Name = "btnCustSave"
        Me.btnCustSave.Size = New System.Drawing.Size(95, 23)
        Me.btnCustSave.TabIndex = 22
        Me.btnCustSave.Text = "Save"
        Me.btnCustSave.UseVisualStyleBackColor = True
        '
        'txtInvoiceAmount
        '
        Me.txtInvoiceAmount.Location = New System.Drawing.Point(92, 89)
        Me.txtInvoiceAmount.Name = "txtInvoiceAmount"
        Me.txtInvoiceAmount.Size = New System.Drawing.Size(146, 20)
        Me.txtInvoiceAmount.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Customer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Job:"
        '
        'txtInvoiceID
        '
        Me.txtInvoiceID.Location = New System.Drawing.Point(143, 9)
        Me.txtInvoiceID.Name = "txtInvoiceID"
        Me.txtInvoiceID.ReadOnly = True
        Me.txtInvoiceID.Size = New System.Drawing.Size(95, 20)
        Me.txtInvoiceID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Invoice ID:"
        '
        'comboInvoiceJob
        '
        Me.comboInvoiceJob.FormattingEnabled = True
        Me.comboInvoiceJob.Location = New System.Drawing.Point(92, 35)
        Me.comboInvoiceJob.Name = "comboInvoiceJob"
        Me.comboInvoiceJob.Size = New System.Drawing.Size(146, 21)
        Me.comboInvoiceJob.TabIndex = 24
        '
        'comboInvoiceCust
        '
        Me.comboInvoiceCust.FormattingEnabled = True
        Me.comboInvoiceCust.Location = New System.Drawing.Point(92, 62)
        Me.comboInvoiceCust.Name = "comboInvoiceCust"
        Me.comboInvoiceCust.Size = New System.Drawing.Size(146, 21)
        Me.comboInvoiceCust.TabIndex = 25
        '
        'FormEditInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 155)
        Me.Controls.Add(Me.comboInvoiceCust)
        Me.Controls.Add(Me.comboInvoiceJob)
        Me.Controls.Add(Me.btnCustCancel)
        Me.Controls.Add(Me.btnCustSave)
        Me.Controls.Add(Me.txtInvoiceAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInvoiceID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditInvoice"
        Me.Text = "FormEditInvoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustCancel As Button
    Friend WithEvents btnCustSave As Button
    Friend WithEvents txtInvoiceAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInvoiceID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboInvoiceJob As ComboBox
    Friend WithEvents comboInvoiceCust As ComboBox
End Class

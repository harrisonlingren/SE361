<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditCustomer
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
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCustSave = New System.Windows.Forms.Button()
        Me.btnCustCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID:"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(143, 9)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(95, 20)
        Me.txtCustID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(92, 35)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(146, 20)
        Me.txtCustName.TabIndex = 3
        '
        'txtCustAddress
        '
        Me.txtCustAddress.Location = New System.Drawing.Point(92, 61)
        Me.txtCustAddress.Name = "txtCustAddress"
        Me.txtCustAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtCustAddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        '
        'txtCustPhone
        '
        Me.txtCustPhone.Location = New System.Drawing.Point(92, 87)
        Me.txtCustPhone.Name = "txtCustPhone"
        Me.txtCustPhone.Size = New System.Drawing.Size(146, 20)
        Me.txtCustPhone.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone:"
        '
        'txtCustEmail
        '
        Me.txtCustEmail.Location = New System.Drawing.Point(92, 113)
        Me.txtCustEmail.Name = "txtCustEmail"
        Me.txtCustEmail.Size = New System.Drawing.Size(146, 20)
        Me.txtCustEmail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email:"
        '
        'btnCustSave
        '
        Me.btnCustSave.Location = New System.Drawing.Point(15, 146)
        Me.btnCustSave.Name = "btnCustSave"
        Me.btnCustSave.Size = New System.Drawing.Size(95, 23)
        Me.btnCustSave.TabIndex = 10
        Me.btnCustSave.Text = "Save"
        Me.btnCustSave.UseVisualStyleBackColor = True
        '
        'btnCustCancel
        '
        Me.btnCustCancel.Location = New System.Drawing.Point(143, 146)
        Me.btnCustCancel.Name = "btnCustCancel"
        Me.btnCustCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCustCancel.TabIndex = 11
        Me.btnCustCancel.Text = "Cancel"
        Me.btnCustCancel.UseVisualStyleBackColor = True
        '
        'FormEditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 178)
        Me.Controls.Add(Me.btnCustCancel)
        Me.Controls.Add(Me.btnCustSave)
        Me.Controls.Add(Me.txtCustEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditCustomer"
        Me.Text = "FormEditCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCustSave As Button
    Friend WithEvents btnCustCancel As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditEmployee
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
        Me.btnEmpCancel = New System.Windows.Forms.Button()
        Me.btnEmpSave = New System.Windows.Forms.Button()
        Me.txtEmpHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboEmpType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpPayRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEmpCancel
        '
        Me.btnEmpCancel.Location = New System.Drawing.Point(143, 211)
        Me.btnEmpCancel.Name = "btnEmpCancel"
        Me.btnEmpCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnEmpCancel.TabIndex = 23
        Me.btnEmpCancel.Text = "Cancel"
        Me.btnEmpCancel.UseVisualStyleBackColor = True
        '
        'btnEmpSave
        '
        Me.btnEmpSave.Location = New System.Drawing.Point(15, 211)
        Me.btnEmpSave.Name = "btnEmpSave"
        Me.btnEmpSave.Size = New System.Drawing.Size(95, 23)
        Me.btnEmpSave.TabIndex = 22
        Me.btnEmpSave.Text = "Save"
        Me.btnEmpSave.UseVisualStyleBackColor = True
        '
        'txtEmpHours
        '
        Me.txtEmpHours.Location = New System.Drawing.Point(92, 139)
        Me.txtEmpHours.Name = "txtEmpHours"
        Me.txtEmpHours.Size = New System.Drawing.Size(146, 20)
        Me.txtEmpHours.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Hours:"
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.Location = New System.Drawing.Point(92, 113)
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.Size = New System.Drawing.Size(146, 20)
        Me.txtEmpPhone.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Phone:"
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(92, 87)
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtEmpAddress.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Address:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(92, 61)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(146, 20)
        Me.txtEmpName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(143, 9)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(95, 20)
        Me.txtEmpID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Employee ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Type:"
        '
        'comboEmpType
        '
        Me.comboEmpType.FormattingEnabled = True
        Me.comboEmpType.Items.AddRange(New Object() {"Cleaner", "Receptionist", "Manager"})
        Me.comboEmpType.Location = New System.Drawing.Point(92, 35)
        Me.comboEmpType.Name = "comboEmpType"
        Me.comboEmpType.Size = New System.Drawing.Size(146, 21)
        Me.comboEmpType.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Pay Rate:"
        '
        'txtEmpPayRate
        '
        Me.txtEmpPayRate.Location = New System.Drawing.Point(92, 165)
        Me.txtEmpPayRate.Name = "txtEmpPayRate"
        Me.txtEmpPayRate.Size = New System.Drawing.Size(146, 20)
        Me.txtEmpPayRate.TabIndex = 21
        '
        'FormEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 246)
        Me.Controls.Add(Me.comboEmpType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEmpCancel)
        Me.Controls.Add(Me.btnEmpSave)
        Me.Controls.Add(Me.txtEmpPayRate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmpHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmpPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmpAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditEmployee"
        Me.Text = "FormEditEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmpCancel As Button
    Friend WithEvents btnEmpSave As Button
    Friend WithEvents txtEmpHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmpPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboEmpType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmpPayRate As TextBox
End Class

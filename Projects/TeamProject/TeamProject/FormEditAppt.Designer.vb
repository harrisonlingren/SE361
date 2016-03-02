<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditAppt
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
        Me.comboApptCust = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCustCancel = New System.Windows.Forms.Button()
        Me.btnCustSave = New System.Windows.Forms.Button()
        Me.txtApptAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApptID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtApptDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'comboApptCust
        '
        Me.comboApptCust.FormattingEnabled = True
        Me.comboApptCust.Location = New System.Drawing.Point(92, 35)
        Me.comboApptCust.Name = "comboApptCust"
        Me.comboApptCust.Size = New System.Drawing.Size(146, 21)
        Me.comboApptCust.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Date / Time:"
        '
        'btnCustCancel
        '
        Me.btnCustCancel.Location = New System.Drawing.Point(143, 123)
        Me.btnCustCancel.Name = "btnCustCancel"
        Me.btnCustCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCustCancel.TabIndex = 37
        Me.btnCustCancel.Text = "Cancel"
        Me.btnCustCancel.UseVisualStyleBackColor = True
        '
        'btnCustSave
        '
        Me.btnCustSave.Location = New System.Drawing.Point(15, 123)
        Me.btnCustSave.Name = "btnCustSave"
        Me.btnCustSave.Size = New System.Drawing.Size(95, 23)
        Me.btnCustSave.TabIndex = 36
        Me.btnCustSave.Text = "Save"
        Me.btnCustSave.UseVisualStyleBackColor = True
        '
        'txtApptAddress
        '
        Me.txtApptAddress.Location = New System.Drawing.Point(92, 87)
        Me.txtApptAddress.Name = "txtApptAddress"
        Me.txtApptAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtApptAddress.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Customer:"
        '
        'txtApptID
        '
        Me.txtApptID.Location = New System.Drawing.Point(143, 9)
        Me.txtApptID.Name = "txtApptID"
        Me.txtApptID.ReadOnly = True
        Me.txtApptID.Size = New System.Drawing.Size(95, 20)
        Me.txtApptID.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Appointment ID:"
        '
        'dtApptDate
        '
        Me.dtApptDate.Location = New System.Drawing.Point(92, 61)
        Me.dtApptDate.Name = "dtApptDate"
        Me.dtApptDate.Size = New System.Drawing.Size(146, 20)
        Me.dtApptDate.TabIndex = 40
        '
        'FormEditAppt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 158)
        Me.Controls.Add(Me.dtApptDate)
        Me.Controls.Add(Me.comboApptCust)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCustCancel)
        Me.Controls.Add(Me.btnCustSave)
        Me.Controls.Add(Me.txtApptAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApptID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditAppt"
        Me.Text = "FormEditAppt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboApptCust As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCustCancel As Button
    Friend WithEvents btnCustSave As Button
    Friend WithEvents txtApptAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApptID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtApptDate As DateTimePicker
End Class

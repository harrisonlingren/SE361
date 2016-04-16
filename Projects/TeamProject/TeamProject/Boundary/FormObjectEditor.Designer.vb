<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormObjectEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblIdNum = New System.Windows.Forms.Label()
        Me.comboObjType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbProperties = New System.Windows.Forms.GroupBox()
        Me.comboJobs = New System.Windows.Forms.ComboBox()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamProjectDataSet = New TeamProject.TeamProjectDataSet()
        Me.comboCustomers = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.CustomerTableAdapter()
        Me.JobTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.JobTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDueDate = New System.Windows.Forms.DateTimePicker()
        Me.gbProperties.SuspendLayout()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(261, 248)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(133, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(146, 20)
        Me.txtEmail.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(69, 74)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(146, 20)
        Me.txtPhone.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Phone:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(69, 48)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtAddress.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Address:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 20)
        Me.txtName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(383, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(95, 20)
        Me.txtID.TabIndex = 13
        '
        'lblIdNum
        '
        Me.lblIdNum.Location = New System.Drawing.Point(292, 15)
        Me.lblIdNum.Name = "lblIdNum"
        Me.lblIdNum.Size = New System.Drawing.Size(85, 13)
        Me.lblIdNum.TabIndex = 12
        Me.lblIdNum.Text = "ID:"
        Me.lblIdNum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comboObjType
        '
        Me.comboObjType.FormattingEnabled = True
        Me.comboObjType.Items.AddRange(New Object() {"Appointment", "Customer", "Employee", "Invoice", "Job"})
        Me.comboObjType.Location = New System.Drawing.Point(52, 12)
        Me.comboObjType.Name = "comboObjType"
        Me.comboObjType.Size = New System.Drawing.Size(163, 21)
        Me.comboObjType.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Type:"
        '
        'gbProperties
        '
        Me.gbProperties.Controls.Add(Me.comboJobs)
        Me.gbProperties.Controls.Add(Me.comboCustomers)
        Me.gbProperties.Controls.Add(Me.comboType)
        Me.gbProperties.Controls.Add(Me.dtDueDate)
        Me.gbProperties.Controls.Add(Me.dtDate)
        Me.gbProperties.Controls.Add(Me.Label10)
        Me.gbProperties.Controls.Add(Me.Label2)
        Me.gbProperties.Controls.Add(Me.txtName)
        Me.gbProperties.Controls.Add(Me.Label9)
        Me.gbProperties.Controls.Add(Me.Label3)
        Me.gbProperties.Controls.Add(Me.txtHours)
        Me.gbProperties.Controls.Add(Me.txtAddress)
        Me.gbProperties.Controls.Add(Me.Label14)
        Me.gbProperties.Controls.Add(Me.Label8)
        Me.gbProperties.Controls.Add(Me.txtAmount)
        Me.gbProperties.Controls.Add(Me.txtEmail)
        Me.gbProperties.Controls.Add(Me.Label13)
        Me.gbProperties.Controls.Add(Me.Label1)
        Me.gbProperties.Controls.Add(Me.Label12)
        Me.gbProperties.Controls.Add(Me.Label4)
        Me.gbProperties.Controls.Add(Me.txtPayRate)
        Me.gbProperties.Controls.Add(Me.Label11)
        Me.gbProperties.Controls.Add(Me.Label5)
        Me.gbProperties.Controls.Add(Me.txtPhone)
        Me.gbProperties.Location = New System.Drawing.Point(15, 49)
        Me.gbProperties.Name = "gbProperties"
        Me.gbProperties.Size = New System.Drawing.Size(463, 183)
        Me.gbProperties.TabIndex = 25
        Me.gbProperties.TabStop = False
        Me.gbProperties.Text = "Object Properties"
        '
        'comboJobs
        '
        Me.comboJobs.DataSource = Me.JobBindingSource
        Me.comboJobs.DisplayMember = "job_id"
        Me.comboJobs.FormattingEnabled = True
        Me.comboJobs.Location = New System.Drawing.Point(311, 126)
        Me.comboJobs.Name = "comboJobs"
        Me.comboJobs.Size = New System.Drawing.Size(146, 21)
        Me.comboJobs.TabIndex = 24
        Me.comboJobs.ValueMember = "job_id"
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'TeamProjectDataSet
        '
        Me.TeamProjectDataSet.DataSetName = "TeamProjectDataSet"
        Me.TeamProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comboCustomers
        '
        Me.comboCustomers.DataSource = Me.CustomerBindingSource
        Me.comboCustomers.DisplayMember = "cust_name"
        Me.comboCustomers.FormattingEnabled = True
        Me.comboCustomers.Location = New System.Drawing.Point(311, 100)
        Me.comboCustomers.Name = "comboCustomers"
        Me.comboCustomers.Size = New System.Drawing.Size(146, 21)
        Me.comboCustomers.TabIndex = 24
        Me.comboCustomers.ValueMember = "cust_id"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'comboType
        '
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Cleaner", "Receptionist", "Manager"})
        Me.comboType.Location = New System.Drawing.Point(311, 20)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(146, 21)
        Me.comboType.TabIndex = 23
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(69, 126)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(146, 20)
        Me.dtDate.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Hours:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(311, 48)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(146, 20)
        Me.txtHours.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(248, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Customer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Pay Rate:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(69, 152)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(146, 20)
        Me.txtAmount.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(248, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Job:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Date:"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(311, 74)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(146, 20)
        Me.txtPayRate.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Amount:"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Due Date:"
        '
        'dtDueDate
        '
        Me.dtDueDate.Location = New System.Drawing.Point(311, 152)
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.Size = New System.Drawing.Size(146, 20)
        Me.dtDueDate.TabIndex = 22
        '
        'FormObjectEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 281)
        Me.Controls.Add(Me.gbProperties)
        Me.Controls.Add(Me.comboObjType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblIdNum)
        Me.Name = "FormObjectEditor"
        Me.Text = "FormObjectEditor"
        Me.gbProperties.ResumeLayout(False)
        Me.gbProperties.PerformLayout()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblIdNum As Label
    Friend WithEvents comboObjType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gbProperties As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents comboType As ComboBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents comboJobs As ComboBox
    Friend WithEvents comboCustomers As ComboBox
    Friend WithEvents TeamProjectDataSet As TeamProjectDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As TeamProjectDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents JobBindingSource As BindingSource
    Friend WithEvents JobTableAdapter As TeamProjectDataSetTableAdapters.JobTableAdapter
    Friend WithEvents dtDueDate As DateTimePicker
    Friend WithEvents Label1 As Label
End Class

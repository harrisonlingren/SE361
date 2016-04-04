<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployees
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Se361DataSet = New TeamProject.se361DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New TeamProject.se361DataSetTableAdapters.EmployeeTableAdapter()
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmptypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmphoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmppayrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Enabled = False
        Me.btnDelEmp.Location = New System.Drawing.Point(345, 289)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnDelEmp.TabIndex = 6
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.Enabled = False
        Me.btnEditEmp.Location = New System.Drawing.Point(229, 289)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnEditEmp.TabIndex = 5
        Me.btnEditEmp.Text = "Edit"
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(113, 289)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnAddEmp.TabIndex = 4
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn, Me.EmptypeDataGridViewTextBoxColumn, Me.EmpnameDataGridViewTextBoxColumn, Me.EmpaddrDataGridViewTextBoxColumn, Me.EmpphoneDataGridViewTextBoxColumn, Me.EmphoursDataGridViewTextBoxColumn, Me.EmppayrateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 271)
        Me.DataGridView1.TabIndex = 7
        '
        'Se361DataSet
        '
        Me.Se361DataSet.DataSetName = "se361DataSet"
        Me.Se361DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Se361DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        Me.EmpidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmptypeDataGridViewTextBoxColumn
        '
        Me.EmptypeDataGridViewTextBoxColumn.DataPropertyName = "emp_type"
        Me.EmptypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.EmptypeDataGridViewTextBoxColumn.Name = "EmptypeDataGridViewTextBoxColumn"
        Me.EmptypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpnameDataGridViewTextBoxColumn
        '
        Me.EmpnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.EmpnameDataGridViewTextBoxColumn.Name = "EmpnameDataGridViewTextBoxColumn"
        Me.EmpnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpaddrDataGridViewTextBoxColumn
        '
        Me.EmpaddrDataGridViewTextBoxColumn.DataPropertyName = "emp_addr"
        Me.EmpaddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.EmpaddrDataGridViewTextBoxColumn.Name = "EmpaddrDataGridViewTextBoxColumn"
        Me.EmpaddrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpphoneDataGridViewTextBoxColumn
        '
        Me.EmpphoneDataGridViewTextBoxColumn.DataPropertyName = "emp_phone"
        Me.EmpphoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.EmpphoneDataGridViewTextBoxColumn.Name = "EmpphoneDataGridViewTextBoxColumn"
        Me.EmpphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmphoursDataGridViewTextBoxColumn
        '
        Me.EmphoursDataGridViewTextBoxColumn.DataPropertyName = "emp_hours"
        Me.EmphoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.EmphoursDataGridViewTextBoxColumn.Name = "EmphoursDataGridViewTextBoxColumn"
        Me.EmphoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmppayrateDataGridViewTextBoxColumn
        '
        Me.EmppayrateDataGridViewTextBoxColumn.DataPropertyName = "emp_payrate"
        Me.EmppayrateDataGridViewTextBoxColumn.HeaderText = "Pay Rate"
        Me.EmppayrateDataGridViewTextBoxColumn.Name = "EmppayrateDataGridViewTextBoxColumn"
        Me.EmppayrateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnEditEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Name = "FormEmployees"
        Me.Text = "FormEmployees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnEditEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Se361DataSet As se361DataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As se361DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmpidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmptypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpaddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmphoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmppayrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployees
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
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.dvEmp = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmptypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmphoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmppayrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamProjectDataSet = New TeamProject.TeamProjectDataSet()
        Me.EmployeeTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.EmployeeTableAdapter()
        CType(Me.dvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveEmp
        '
        Me.btnSaveEmp.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveEmp.TabIndex = 5
        Me.btnSaveEmp.Text = "Save and Close"
        Me.btnSaveEmp.UseVisualStyleBackColor = True
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Location = New System.Drawing.Point(244, 289)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnDelEmp.TabIndex = 6
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.Enabled = False
        Me.btnEditEmp.Location = New System.Drawing.Point(128, 289)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnEditEmp.TabIndex = 4
        Me.btnEditEmp.Text = "Edit"
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(12, 289)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(110, 23)
        Me.btnAddEmp.TabIndex = 3
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'dvEmp
        '
        Me.dvEmp.AllowUserToAddRows = False
        Me.dvEmp.AllowUserToDeleteRows = False
        Me.dvEmp.AutoGenerateColumns = False
        Me.dvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn, Me.EmpnameDataGridViewTextBoxColumn, Me.EmptypeDataGridViewTextBoxColumn, Me.EmpaddrDataGridViewTextBoxColumn, Me.EmpphoneDataGridViewTextBoxColumn, Me.EmphoursDataGridViewTextBoxColumn, Me.EmppayrateDataGridViewTextBoxColumn})
        Me.dvEmp.DataSource = Me.EmployeeBindingSource
        Me.dvEmp.Location = New System.Drawing.Point(12, 12)
        Me.dvEmp.Name = "dvEmp"
        Me.dvEmp.ReadOnly = True
        Me.dvEmp.Size = New System.Drawing.Size(545, 271)
        Me.dvEmp.TabIndex = 8
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        Me.EmpidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpnameDataGridViewTextBoxColumn
        '
        Me.EmpnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.HeaderText = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.Name = "EmpnameDataGridViewTextBoxColumn"
        Me.EmpnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmptypeDataGridViewTextBoxColumn
        '
        Me.EmptypeDataGridViewTextBoxColumn.DataPropertyName = "emp_type"
        Me.EmptypeDataGridViewTextBoxColumn.HeaderText = "emp_type"
        Me.EmptypeDataGridViewTextBoxColumn.Name = "EmptypeDataGridViewTextBoxColumn"
        Me.EmptypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpaddrDataGridViewTextBoxColumn
        '
        Me.EmpaddrDataGridViewTextBoxColumn.DataPropertyName = "emp_addr"
        Me.EmpaddrDataGridViewTextBoxColumn.HeaderText = "emp_addr"
        Me.EmpaddrDataGridViewTextBoxColumn.Name = "EmpaddrDataGridViewTextBoxColumn"
        Me.EmpaddrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpphoneDataGridViewTextBoxColumn
        '
        Me.EmpphoneDataGridViewTextBoxColumn.DataPropertyName = "emp_phone"
        Me.EmpphoneDataGridViewTextBoxColumn.HeaderText = "emp_phone"
        Me.EmpphoneDataGridViewTextBoxColumn.Name = "EmpphoneDataGridViewTextBoxColumn"
        Me.EmpphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmphoursDataGridViewTextBoxColumn
        '
        Me.EmphoursDataGridViewTextBoxColumn.DataPropertyName = "emp_hours"
        Me.EmphoursDataGridViewTextBoxColumn.HeaderText = "emp_hours"
        Me.EmphoursDataGridViewTextBoxColumn.Name = "EmphoursDataGridViewTextBoxColumn"
        Me.EmphoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmppayrateDataGridViewTextBoxColumn
        '
        Me.EmppayrateDataGridViewTextBoxColumn.DataPropertyName = "emp_pay_rate"
        Me.EmppayrateDataGridViewTextBoxColumn.HeaderText = "emp_pay_rate"
        Me.EmppayrateDataGridViewTextBoxColumn.Name = "EmppayrateDataGridViewTextBoxColumn"
        Me.EmppayrateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'TeamProjectDataSet
        '
        Me.TeamProjectDataSet.DataSetName = "TeamProjectDataSet"
        Me.TeamProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'FormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvEmp)
        Me.Controls.Add(Me.btnSaveEmp)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnEditEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Name = "FormEmployees"
        Me.Text = "FormEmployees"
        CType(Me.dvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSaveEmp As Button
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnEditEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents dvEmp As DataGridView
    Friend WithEvents TeamProjectDataSet As TeamProjectDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As TeamProjectDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmpidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmptypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpaddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmphoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmppayrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJobs
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
        Me.btnDelJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JobidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelJob
        '
        Me.btnDelJob.Enabled = False
        Me.btnDelJob.Location = New System.Drawing.Point(345, 289)
        Me.btnDelJob.Name = "btnDelJob"
        Me.btnDelJob.Size = New System.Drawing.Size(110, 23)
        Me.btnDelJob.TabIndex = 6
        Me.btnDelJob.Text = "Delete"
        Me.btnDelJob.UseVisualStyleBackColor = True
        '
        'btnEditJob
        '
        Me.btnEditJob.Enabled = False
        Me.btnEditJob.Location = New System.Drawing.Point(229, 289)
        Me.btnEditJob.Name = "btnEditJob"
        Me.btnEditJob.Size = New System.Drawing.Size(110, 23)
        Me.btnEditJob.TabIndex = 5
        Me.btnEditJob.Text = "Edit"
        Me.btnEditJob.UseVisualStyleBackColor = True
        '
        'btnAddJob
        '
        Me.btnAddJob.Location = New System.Drawing.Point(113, 289)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(110, 23)
        Me.btnAddJob.TabIndex = 4
        Me.btnAddJob.Text = "Add"
        Me.btnAddJob.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobidDataGridViewTextBoxColumn, Me.JobdateDataGridViewTextBoxColumn, Me.JobaddrDataGridViewTextBoxColumn, Me.JobcostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JobsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 271)
        Me.DataGridView1.TabIndex = 7
        '
        'JobidDataGridViewTextBoxColumn
        '
        Me.JobidDataGridViewTextBoxColumn.DataPropertyName = "job_id"
        Me.JobidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.JobidDataGridViewTextBoxColumn.Name = "JobidDataGridViewTextBoxColumn"
        Me.JobidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobdateDataGridViewTextBoxColumn
        '
        Me.JobdateDataGridViewTextBoxColumn.DataPropertyName = "job_date"
        Me.JobdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.JobdateDataGridViewTextBoxColumn.Name = "JobdateDataGridViewTextBoxColumn"
        Me.JobdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobaddrDataGridViewTextBoxColumn
        '
        Me.JobaddrDataGridViewTextBoxColumn.DataPropertyName = "job_addr"
        Me.JobaddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.JobaddrDataGridViewTextBoxColumn.Name = "JobaddrDataGridViewTextBoxColumn"
        Me.JobaddrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobcostDataGridViewTextBoxColumn
        '
        Me.JobcostDataGridViewTextBoxColumn.DataPropertyName = "job_cost"
        Me.JobcostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.JobcostDataGridViewTextBoxColumn.Name = "JobcostDataGridViewTextBoxColumn"
        Me.JobcostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobsBindingSource
        '
        Me.JobsBindingSource.DataMember = "Jobs"
        Me.JobsBindingSource.DataSource = Me.Se361DataSet
        '
        'Se361DataSet
        '
        Me.Se361DataSet.DataSetName = "se361DataSet"
        Me.Se361DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobsTableAdapter
        '
        Me.JobsTableAdapter.ClearBeforeFill = True
        '
        'FormJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelJob)
        Me.Controls.Add(Me.btnEditJob)
        Me.Controls.Add(Me.btnAddJob)
        Me.Name = "FormJobs"
        Me.Text = "FormJobs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelJob As Button
    Friend WithEvents btnEditJob As Button
    Friend WithEvents btnAddJob As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Se361DataSet As se361DataSet
    Friend WithEvents JobsBindingSource As BindingSource
    Friend WithEvents JobsTableAdapter As se361DataSetTableAdapters.JobsTableAdapter
    Friend WithEvents JobidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobaddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobcostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

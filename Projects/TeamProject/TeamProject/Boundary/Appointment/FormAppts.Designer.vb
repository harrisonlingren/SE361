<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppts
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
        Me.dvAppts = New System.Windows.Forms.DataGridView()
        Me.ApptidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApptdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApptaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamProjectDataSet = New TeamProject.TeamProjectDataSet()
        Me.btnSaveAppt = New System.Windows.Forms.Button()
        Me.btnDelAppt = New System.Windows.Forms.Button()
        Me.btnEditAppt = New System.Windows.Forms.Button()
        Me.btnAddAppt = New System.Windows.Forms.Button()
        Me.AppointmentTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.AppointmentTableAdapter()
        CType(Me.dvAppts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvAppts
        '
        Me.dvAppts.AllowUserToAddRows = False
        Me.dvAppts.AllowUserToDeleteRows = False
        Me.dvAppts.AutoGenerateColumns = False
        Me.dvAppts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvAppts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ApptidDataGridViewTextBoxColumn, Me.ApptdateDataGridViewTextBoxColumn, Me.ApptaddressDataGridViewTextBoxColumn})
        Me.dvAppts.DataSource = Me.AppointmentBindingSource
        Me.dvAppts.Location = New System.Drawing.Point(12, 12)
        Me.dvAppts.Name = "dvAppts"
        Me.dvAppts.ReadOnly = True
        Me.dvAppts.Size = New System.Drawing.Size(545, 271)
        Me.dvAppts.TabIndex = 8
        '
        'ApptidDataGridViewTextBoxColumn
        '
        Me.ApptidDataGridViewTextBoxColumn.DataPropertyName = "appt_id"
        Me.ApptidDataGridViewTextBoxColumn.HeaderText = "appt_id"
        Me.ApptidDataGridViewTextBoxColumn.Name = "ApptidDataGridViewTextBoxColumn"
        Me.ApptidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApptdateDataGridViewTextBoxColumn
        '
        Me.ApptdateDataGridViewTextBoxColumn.DataPropertyName = "appt_date"
        Me.ApptdateDataGridViewTextBoxColumn.HeaderText = "appt_date"
        Me.ApptdateDataGridViewTextBoxColumn.Name = "ApptdateDataGridViewTextBoxColumn"
        Me.ApptdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApptaddressDataGridViewTextBoxColumn
        '
        Me.ApptaddressDataGridViewTextBoxColumn.DataPropertyName = "appt_address"
        Me.ApptaddressDataGridViewTextBoxColumn.HeaderText = "appt_address"
        Me.ApptaddressDataGridViewTextBoxColumn.Name = "ApptaddressDataGridViewTextBoxColumn"
        Me.ApptaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'TeamProjectDataSet
        '
        Me.TeamProjectDataSet.DataSetName = "TeamProjectDataSet"
        Me.TeamProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSaveAppt
        '
        Me.btnSaveAppt.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveAppt.Name = "btnSaveAppt"
        Me.btnSaveAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveAppt.TabIndex = 11
        Me.btnSaveAppt.Text = "Save and Close"
        Me.btnSaveAppt.UseVisualStyleBackColor = True
        '
        'btnDelAppt
        '
        Me.btnDelAppt.Location = New System.Drawing.Point(244, 289)
        Me.btnDelAppt.Name = "btnDelAppt"
        Me.btnDelAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnDelAppt.TabIndex = 12
        Me.btnDelAppt.Text = "Delete"
        Me.btnDelAppt.UseVisualStyleBackColor = True
        '
        'btnEditAppt
        '
        Me.btnEditAppt.Enabled = False
        Me.btnEditAppt.Location = New System.Drawing.Point(128, 289)
        Me.btnEditAppt.Name = "btnEditAppt"
        Me.btnEditAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnEditAppt.TabIndex = 10
        Me.btnEditAppt.Text = "Edit"
        Me.btnEditAppt.UseVisualStyleBackColor = True
        '
        'btnAddAppt
        '
        Me.btnAddAppt.Location = New System.Drawing.Point(12, 289)
        Me.btnAddAppt.Name = "btnAddAppt"
        Me.btnAddAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnAddAppt.TabIndex = 9
        Me.btnAddAppt.Text = "Add"
        Me.btnAddAppt.UseVisualStyleBackColor = True
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'FormAppts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.btnSaveAppt)
        Me.Controls.Add(Me.btnDelAppt)
        Me.Controls.Add(Me.btnEditAppt)
        Me.Controls.Add(Me.btnAddAppt)
        Me.Controls.Add(Me.dvAppts)
        Me.Name = "FormAppts"
        Me.Text = "FormAppts"
        CType(Me.dvAppts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvAppts As DataGridView
    Private WithEvents btnSaveAppt As Button
    Friend WithEvents btnDelAppt As Button
    Friend WithEvents btnEditAppt As Button
    Friend WithEvents btnAddAppt As Button
    Friend WithEvents TeamProjectDataSet As TeamProjectDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As TeamProjectDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents ApptidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApptdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApptaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

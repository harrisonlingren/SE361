<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInvoice
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSaveInv = New System.Windows.Forms.Button()
        Me.btnDelInv = New System.Windows.Forms.Button()
        Me.btnEditInv = New System.Windows.Forms.Button()
        Me.btnAddInv = New System.Windows.Forms.Button()
        Me.dvInv = New System.Windows.Forms.DataGridView()
        Me.InvoiceidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoicedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoicecostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceduedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamProjectDataSet = New TeamProject.TeamProjectDataSet()
        Me.InvoiceTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.InvoiceTableAdapter()
        CType(Me.dvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveInv.TabIndex = 5
        Me.btnSaveInv.Text = "Save and Close"
        Me.btnSaveInv.UseVisualStyleBackColor = True
        '
        'btnDelInv
        '
        Me.btnDelInv.Location = New System.Drawing.Point(244, 289)
        Me.btnDelInv.Name = "btnDelInv"
        Me.btnDelInv.Size = New System.Drawing.Size(110, 23)
        Me.btnDelInv.TabIndex = 6
        Me.btnDelInv.Text = "Delete"
        Me.btnDelInv.UseVisualStyleBackColor = True
        '
        'btnEditInv
        '
        Me.btnEditInv.Location = New System.Drawing.Point(128, 289)
        Me.btnEditInv.Name = "btnEditInv"
        Me.btnEditInv.Size = New System.Drawing.Size(110, 23)
        Me.btnEditInv.TabIndex = 4
        Me.btnEditInv.Text = "Edit"
        Me.btnEditInv.UseVisualStyleBackColor = True
        '
        'btnAddInv
        '
        Me.btnAddInv.Location = New System.Drawing.Point(12, 289)
        Me.btnAddInv.Name = "btnAddInv"
        Me.btnAddInv.Size = New System.Drawing.Size(110, 23)
        Me.btnAddInv.TabIndex = 3
        Me.btnAddInv.Text = "Add"
        Me.btnAddInv.UseVisualStyleBackColor = True
        '
        'dvInv
        '
        Me.dvInv.AllowUserToAddRows = False
        Me.dvInv.AllowUserToDeleteRows = False
        Me.dvInv.AutoGenerateColumns = False
        Me.dvInv.BackgroundColor = System.Drawing.Color.White
        Me.dvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceidDataGridViewTextBoxColumn, Me.InvoicedateDataGridViewTextBoxColumn, Me.InvoicecostDataGridViewTextBoxColumn, Me.InvoiceduedateDataGridViewTextBoxColumn})
        Me.dvInv.DataSource = Me.InvoiceBindingSource
        Me.dvInv.Location = New System.Drawing.Point(12, 12)
        Me.dvInv.Name = "dvInv"
        Me.dvInv.ReadOnly = True
        Me.dvInv.Size = New System.Drawing.Size(545, 271)
        Me.dvInv.TabIndex = 8
        '
        'InvoiceidDataGridViewTextBoxColumn
        '
        Me.InvoiceidDataGridViewTextBoxColumn.DataPropertyName = "invoice_id"
        Me.InvoiceidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.InvoiceidDataGridViewTextBoxColumn.Name = "InvoiceidDataGridViewTextBoxColumn"
        Me.InvoiceidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoicedateDataGridViewTextBoxColumn
        '
        Me.InvoicedateDataGridViewTextBoxColumn.DataPropertyName = "invoice_date"
        Me.InvoicedateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.InvoicedateDataGridViewTextBoxColumn.Name = "InvoicedateDataGridViewTextBoxColumn"
        Me.InvoicedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoicecostDataGridViewTextBoxColumn
        '
        Me.InvoicecostDataGridViewTextBoxColumn.DataPropertyName = "invoice_cost"
        Me.InvoicecostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.InvoicecostDataGridViewTextBoxColumn.Name = "InvoicecostDataGridViewTextBoxColumn"
        Me.InvoicecostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceduedateDataGridViewTextBoxColumn
        '
        Me.InvoiceduedateDataGridViewTextBoxColumn.DataPropertyName = "invoice_due_date"
        Me.InvoiceduedateDataGridViewTextBoxColumn.HeaderText = "Due Date"
        Me.InvoiceduedateDataGridViewTextBoxColumn.Name = "InvoiceduedateDataGridViewTextBoxColumn"
        Me.InvoiceduedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'TeamProjectDataSet
        '
        Me.TeamProjectDataSet.DataSetName = "TeamProjectDataSet"
        Me.TeamProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'FormInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvInv)
        Me.Controls.Add(Me.btnSaveInv)
        Me.Controls.Add(Me.btnDelInv)
        Me.Controls.Add(Me.btnEditInv)
        Me.Controls.Add(Me.btnAddInv)
        Me.Name = "FormInvoice"
        Me.Text = "Manage Payments"
        CType(Me.dvInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSaveInv As Button
    Friend WithEvents btnDelInv As Button
    Friend WithEvents btnEditInv As Button
    Friend WithEvents btnAddInv As Button
    Friend WithEvents dvInv As DataGridView
    Friend WithEvents TeamProjectDataSet As TeamProjectDataSet
    Friend WithEvents InvoiceBindingSource As BindingSource
    Friend WithEvents InvoiceTableAdapter As TeamProjectDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents InvoiceidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoicedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoicecostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceduedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

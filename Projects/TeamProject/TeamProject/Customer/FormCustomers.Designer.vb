﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomers
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
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.btnEditCust = New System.Windows.Forms.Button()
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.btnSaveCust = New System.Windows.Forms.Button()
        Me.dvCustomer = New System.Windows.Forms.DataGridView()
        Me.CustidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Se361DataSet = New TeamProject.se361DataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New TeamProject.se361DataSetTableAdapters.CustomersTableAdapter()
        CType(Me.dvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCust
        '
        Me.btnAddCust.Location = New System.Drawing.Point(12, 289)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(110, 23)
        Me.btnAddCust.TabIndex = 0
        Me.btnAddCust.Text = "Add"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'btnEditCust
        '
        Me.btnEditCust.Enabled = False
        Me.btnEditCust.Location = New System.Drawing.Point(128, 289)
        Me.btnEditCust.Name = "btnEditCust"
        Me.btnEditCust.Size = New System.Drawing.Size(110, 23)
        Me.btnEditCust.TabIndex = 1
        Me.btnEditCust.Text = "Edit"
        Me.btnEditCust.UseVisualStyleBackColor = True
        '
        'btnDelCust
        '
        Me.btnDelCust.Location = New System.Drawing.Point(244, 289)
        Me.btnDelCust.Name = "btnDelCust"
        Me.btnDelCust.Size = New System.Drawing.Size(110, 23)
        Me.btnDelCust.TabIndex = 2
        Me.btnDelCust.Text = "Delete"
        Me.btnDelCust.UseVisualStyleBackColor = True
        '
        'btnSaveCust
        '
        Me.btnSaveCust.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveCust.Name = "btnSaveCust"
        Me.btnSaveCust.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveCust.TabIndex = 2
        Me.btnSaveCust.Text = "Save and Close"
        Me.btnSaveCust.UseVisualStyleBackColor = True
        '
        'dvCustomer
        '
        Me.dvCustomer.AllowUserToDeleteRows = False
        Me.dvCustomer.AllowUserToResizeRows = False
        Me.dvCustomer.AutoGenerateColumns = False
        Me.dvCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustidDataGridViewTextBoxColumn, Me.CustnameDataGridViewTextBoxColumn, Me.CustaddrDataGridViewTextBoxColumn, Me.CustphoneDataGridViewTextBoxColumn, Me.CustemailDataGridViewTextBoxColumn})
        Me.dvCustomer.DataSource = Me.CustomersBindingSource1
        Me.dvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dvCustomer.Location = New System.Drawing.Point(12, 12)
        Me.dvCustomer.Name = "dvCustomer"
        Me.dvCustomer.Size = New System.Drawing.Size(545, 271)
        Me.dvCustomer.TabIndex = 4
        '
        'CustidDataGridViewTextBoxColumn
        '
        Me.CustidDataGridViewTextBoxColumn.DataPropertyName = "cust_id"
        Me.CustidDataGridViewTextBoxColumn.HeaderText = "cust_id"
        Me.CustidDataGridViewTextBoxColumn.Name = "CustidDataGridViewTextBoxColumn"
        '
        'CustnameDataGridViewTextBoxColumn
        '
        Me.CustnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.HeaderText = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.Name = "CustnameDataGridViewTextBoxColumn"
        '
        'CustaddrDataGridViewTextBoxColumn
        '
        Me.CustaddrDataGridViewTextBoxColumn.DataPropertyName = "cust_addr"
        Me.CustaddrDataGridViewTextBoxColumn.HeaderText = "cust_addr"
        Me.CustaddrDataGridViewTextBoxColumn.Name = "CustaddrDataGridViewTextBoxColumn"
        '
        'CustphoneDataGridViewTextBoxColumn
        '
        Me.CustphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_phone"
        Me.CustphoneDataGridViewTextBoxColumn.HeaderText = "cust_phone"
        Me.CustphoneDataGridViewTextBoxColumn.Name = "CustphoneDataGridViewTextBoxColumn"
        '
        'CustemailDataGridViewTextBoxColumn
        '
        Me.CustemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email"
        Me.CustemailDataGridViewTextBoxColumn.HeaderText = "cust_email"
        Me.CustemailDataGridViewTextBoxColumn.Name = "CustemailDataGridViewTextBoxColumn"
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.Se361DataSet
        '
        'Se361DataSet
        '
        Me.Se361DataSet.DataSetName = "se361DataSet"
        Me.Se361DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Se361DataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvCustomer)
        Me.Controls.Add(Me.btnSaveCust)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnEditCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Name = "FormCustomers"
        Me.Text = "FormCustomers"
        CType(Me.dvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Se361DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnEditCust As Button
    Friend WithEvents btnDelCust As Button
    Private WithEvents btnSaveCust As System.Windows.Forms.Button
    Friend WithEvents dvCustomer As DataGridView
    Friend WithEvents Se361DataSet As se361DataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As se361DataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustaddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomersBindingSource1 As BindingSource
End Class
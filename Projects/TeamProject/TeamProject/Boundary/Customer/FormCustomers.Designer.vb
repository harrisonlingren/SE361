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
        Me.dvCust = New System.Windows.Forms.DataGridView()
        Me.CustidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamProjectDataSet = New TeamProject.TeamProjectDataSet()
        Me.CustomerTableAdapter = New TeamProject.TeamProjectDataSetTableAdapters.CustomerTableAdapter()
        CType(Me.dvCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSaveCust.Text = "Close"
        Me.btnSaveCust.UseVisualStyleBackColor = True
        '
        'dvCust
        '
        Me.dvCust.AllowUserToAddRows = False
        Me.dvCust.AllowUserToDeleteRows = False
        Me.dvCust.AutoGenerateColumns = False
        Me.dvCust.BackgroundColor = System.Drawing.Color.White
        Me.dvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvCust.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustidDataGridViewTextBoxColumn, Me.CustnameDataGridViewTextBoxColumn, Me.CustaddrDataGridViewTextBoxColumn, Me.CustphoneDataGridViewTextBoxColumn, Me.CustemailDataGridViewTextBoxColumn})
        Me.dvCust.DataSource = Me.CustomerBindingSource
        Me.dvCust.Location = New System.Drawing.Point(12, 12)
        Me.dvCust.Name = "dvCust"
        Me.dvCust.ReadOnly = True
        Me.dvCust.Size = New System.Drawing.Size(545, 271)
        Me.dvCust.TabIndex = 8
        '
        'CustidDataGridViewTextBoxColumn
        '
        Me.CustidDataGridViewTextBoxColumn.DataPropertyName = "cust_id"
        Me.CustidDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CustidDataGridViewTextBoxColumn.Name = "CustidDataGridViewTextBoxColumn"
        Me.CustidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustnameDataGridViewTextBoxColumn
        '
        Me.CustnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name"
        Me.CustnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CustnameDataGridViewTextBoxColumn.Name = "CustnameDataGridViewTextBoxColumn"
        Me.CustnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustaddrDataGridViewTextBoxColumn
        '
        Me.CustaddrDataGridViewTextBoxColumn.DataPropertyName = "cust_addr"
        Me.CustaddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.CustaddrDataGridViewTextBoxColumn.Name = "CustaddrDataGridViewTextBoxColumn"
        Me.CustaddrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustphoneDataGridViewTextBoxColumn
        '
        Me.CustphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_phone"
        Me.CustphoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.CustphoneDataGridViewTextBoxColumn.Name = "CustphoneDataGridViewTextBoxColumn"
        Me.CustphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustemailDataGridViewTextBoxColumn
        '
        Me.CustemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email"
        Me.CustemailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.CustemailDataGridViewTextBoxColumn.Name = "CustemailDataGridViewTextBoxColumn"
        Me.CustemailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.TeamProjectDataSet
        '
        'TeamProjectDataSet
        '
        Me.TeamProjectDataSet.DataSetName = "TeamProjectDataSet"
        Me.TeamProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvCust)
        Me.Controls.Add(Me.btnSaveCust)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnEditCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Name = "FormCustomers"
        Me.Text = "Manage Customers"
        CType(Me.dvCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnEditCust As Button
    Friend WithEvents btnDelCust As Button
    Private WithEvents btnSaveCust As System.Windows.Forms.Button
    Friend WithEvents dvCust As DataGridView
    Friend WithEvents TeamProjectDataSet As TeamProjectDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As TeamProjectDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustphoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustemailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

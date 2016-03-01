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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listViewInvoice = New System.Windows.Forms.ListView()
        Me.custID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelInvoice = New System.Windows.Forms.Button()
        Me.btnEditInvoice = New System.Windows.Forms.Button()
        Me.btnAddInvoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewInvoice
        '
        Me.listViewInvoice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.custID, Me.custName, Me.custAddress, Me.custPhone, Me.custEmail})
        Me.listViewInvoice.Location = New System.Drawing.Point(12, 12)
        Me.listViewInvoice.Name = "listViewInvoice"
        Me.listViewInvoice.Size = New System.Drawing.Size(545, 271)
        Me.listViewInvoice.TabIndex = 7
        Me.listViewInvoice.UseCompatibleStateImageBehavior = False
        Me.listViewInvoice.View = System.Windows.Forms.View.Details
        '
        'custID
        '
        Me.custID.Text = "ID"
        Me.custID.Width = 41
        '
        'custName
        '
        Me.custName.Text = "Name"
        Me.custName.Width = 114
        '
        'custAddress
        '
        Me.custAddress.Text = "Address"
        Me.custAddress.Width = 152
        '
        'custPhone
        '
        Me.custPhone.Text = "Phone"
        Me.custPhone.Width = 93
        '
        'custEmail
        '
        Me.custEmail.Text = "Email"
        Me.custEmail.Width = 140
        '
        'btnDelInvoice
        '
        Me.btnDelInvoice.Enabled = False
        Me.btnDelInvoice.Location = New System.Drawing.Point(345, 289)
        Me.btnDelInvoice.Name = "btnDelInvoice"
        Me.btnDelInvoice.Size = New System.Drawing.Size(110, 23)
        Me.btnDelInvoice.TabIndex = 6
        Me.btnDelInvoice.Text = "Delete"
        Me.btnDelInvoice.UseVisualStyleBackColor = True
        '
        'btnEditInvoice
        '
        Me.btnEditInvoice.Enabled = False
        Me.btnEditInvoice.Location = New System.Drawing.Point(229, 289)
        Me.btnEditInvoice.Name = "btnEditInvoice"
        Me.btnEditInvoice.Size = New System.Drawing.Size(110, 23)
        Me.btnEditInvoice.TabIndex = 5
        Me.btnEditInvoice.Text = "Edit"
        Me.btnEditInvoice.UseVisualStyleBackColor = True
        '
        'btnAddInvoice
        '
        Me.btnAddInvoice.Location = New System.Drawing.Point(113, 289)
        Me.btnAddInvoice.Name = "btnAddInvoice"
        Me.btnAddInvoice.Size = New System.Drawing.Size(110, 23)
        Me.btnAddInvoice.TabIndex = 4
        Me.btnAddInvoice.Text = "Add"
        Me.btnAddInvoice.UseVisualStyleBackColor = True
        '
        'FormInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.listViewInvoice)
        Me.Controls.Add(Me.btnDelInvoice)
        Me.Controls.Add(Me.btnEditInvoice)
        Me.Controls.Add(Me.btnAddInvoice)
        Me.Name = "FormInvoice"
        Me.Text = "FormInvoice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewInvoice As ListView
    Friend WithEvents custID As ColumnHeader
    Friend WithEvents custName As ColumnHeader
    Friend WithEvents custAddress As ColumnHeader
    Friend WithEvents custPhone As ColumnHeader
    Friend WithEvents custEmail As ColumnHeader
    Friend WithEvents btnDelInvoice As Button
    Friend WithEvents btnEditInvoice As Button
    Friend WithEvents btnAddInvoice As Button
End Class

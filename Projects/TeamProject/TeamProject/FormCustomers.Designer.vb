<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomers
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
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.btnEditCust = New System.Windows.Forms.Button()
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.listViewCust = New System.Windows.Forms.ListView()
        Me.custID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnAddCust
        '
        Me.btnAddCust.Location = New System.Drawing.Point(113, 289)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(110, 23)
        Me.btnAddCust.TabIndex = 0
        Me.btnAddCust.Text = "Add"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'btnEditCust
        '
        Me.btnEditCust.Enabled = False
        Me.btnEditCust.Location = New System.Drawing.Point(229, 289)
        Me.btnEditCust.Name = "btnEditCust"
        Me.btnEditCust.Size = New System.Drawing.Size(110, 23)
        Me.btnEditCust.TabIndex = 1
        Me.btnEditCust.Text = "Edit"
        Me.btnEditCust.UseVisualStyleBackColor = True
        '
        'btnDelCust
        '
        Me.btnDelCust.Enabled = False
        Me.btnDelCust.Location = New System.Drawing.Point(345, 289)
        Me.btnDelCust.Name = "btnDelCust"
        Me.btnDelCust.Size = New System.Drawing.Size(110, 23)
        Me.btnDelCust.TabIndex = 2
        Me.btnDelCust.Text = "Delete"
        Me.btnDelCust.UseVisualStyleBackColor = True
        '
        'listViewCust
        '
        Me.listViewCust.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.custID, Me.custName, Me.custAddress, Me.custPhone, Me.custEmail})
        Me.listViewCust.Location = New System.Drawing.Point(12, 12)
        Me.listViewCust.Name = "listViewCust"
        Me.listViewCust.Size = New System.Drawing.Size(545, 271)
        Me.listViewCust.TabIndex = 3
        Me.listViewCust.UseCompatibleStateImageBehavior = False
        Me.listViewCust.View = System.Windows.Forms.View.Details
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
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.listViewCust)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnEditCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Name = "FormCustomers"
        Me.Text = "FormCustomers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnEditCust As Button
    Friend WithEvents btnDelCust As Button
    Friend WithEvents listViewCust As ListView
    Friend WithEvents custID As ColumnHeader
    Friend WithEvents custName As ColumnHeader
    Friend WithEvents custAddress As ColumnHeader
    Friend WithEvents custPhone As ColumnHeader
    Friend WithEvents custEmail As ColumnHeader
End Class

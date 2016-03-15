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
        Me.listViewEmp = New System.Windows.Forms.ListView()
        Me.empID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.empPayRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewEmp
        '
        Me.listViewEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.empID, Me.empType, Me.empName, Me.empAddress, Me.empPhone, Me.empHours, Me.empPayRate})
        Me.listViewEmp.FullRowSelect = True
        Me.listViewEmp.GridLines = True
        Me.listViewEmp.Location = New System.Drawing.Point(12, 12)
        Me.listViewEmp.Name = "listViewEmp"
        Me.listViewEmp.Size = New System.Drawing.Size(545, 271)
        Me.listViewEmp.TabIndex = 7
        Me.listViewEmp.UseCompatibleStateImageBehavior = False
        Me.listViewEmp.View = System.Windows.Forms.View.Details
        '
        'empID
        '
        Me.empID.Text = "ID"
        Me.empID.Width = 41
        '
        'empType
        '
        Me.empType.Text = "Type"
        '
        'empName
        '
        Me.empName.Text = "Name"
        Me.empName.Width = 114
        '
        'empAddress
        '
        Me.empAddress.Text = "Address"
        Me.empAddress.Width = 152
        '
        'empPhone
        '
        Me.empPhone.Text = "Phone"
        Me.empPhone.Width = 93
        '
        'empHours
        '
        Me.empHours.Text = "Hours"
        Me.empHours.Width = 140
        '
        'empPayRate
        '
        Me.empPayRate.Text = "Pay Rate"
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
        'FormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.listViewEmp)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnEditEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Name = "FormEmployees"
        Me.Text = "FormEmployees"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewEmp As ListView
    Friend WithEvents empID As ColumnHeader
    Friend WithEvents empName As ColumnHeader
    Friend WithEvents empAddress As ColumnHeader
    Friend WithEvents empPhone As ColumnHeader
    Friend WithEvents empHours As ColumnHeader
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnEditEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents empType As ColumnHeader
    Friend WithEvents empPayRate As ColumnHeader
End Class

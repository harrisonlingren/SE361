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
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.dvEmp = New System.Windows.Forms.DataGridView()
        CType(Me.dvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvEmp.Location = New System.Drawing.Point(12, 12)
        Me.dvEmp.Name = "dvEmp"
        Me.dvEmp.Size = New System.Drawing.Size(545, 271)
        Me.dvEmp.TabIndex = 8
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
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSaveEmp As Button
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnEditEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents dvEmp As DataGridView
End Class

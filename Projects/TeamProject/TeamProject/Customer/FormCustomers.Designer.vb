<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.btnEditCust = New System.Windows.Forms.Button()
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.btnSaveCust = New System.Windows.Forms.Button()
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
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.btnSaveCust)
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
    Private WithEvents btnSaveCust As System.Windows.Forms.Button
End Class

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
        Me.dvAppts = New System.Windows.Forms.DataGridView()
        Me.btnSaveAppt = New System.Windows.Forms.Button()
        Me.btnDelAppt = New System.Windows.Forms.Button()
        Me.btnEditAppt = New System.Windows.Forms.Button()
        Me.btnAddAppt = New System.Windows.Forms.Button()
        CType(Me.dvAppts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvAppts
        '
        Me.dvAppts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvAppts.Location = New System.Drawing.Point(12, 12)
        Me.dvAppts.Name = "dvAppts"
        Me.dvAppts.Size = New System.Drawing.Size(545, 271)
        Me.dvAppts.TabIndex = 8
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvAppts As DataGridView
    Private WithEvents btnSaveAppt As Button
    Friend WithEvents btnDelAppt As Button
    Friend WithEvents btnEditAppt As Button
    Friend WithEvents btnAddAppt As Button
End Class

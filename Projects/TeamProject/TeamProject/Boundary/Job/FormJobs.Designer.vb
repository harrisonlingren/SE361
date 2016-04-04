<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJobs
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
        Me.btnSaveJob = New System.Windows.Forms.Button()
        Me.btnDelJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.dvJob = New System.Windows.Forms.DataGridView()
        CType(Me.dvJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveJob
        '
        Me.btnSaveJob.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveJob.Name = "btnSaveJob"
        Me.btnSaveJob.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveJob.TabIndex = 5
        Me.btnSaveJob.Text = "Save and Close"
        Me.btnSaveJob.UseVisualStyleBackColor = True
        '
        'btnDelJob
        '
        Me.btnDelJob.Location = New System.Drawing.Point(244, 289)
        Me.btnDelJob.Name = "btnDelJob"
        Me.btnDelJob.Size = New System.Drawing.Size(110, 23)
        Me.btnDelJob.TabIndex = 6
        Me.btnDelJob.Text = "Delete"
        Me.btnDelJob.UseVisualStyleBackColor = True
        '
        'btnEditJob
        '
        Me.btnEditJob.Enabled = False
        Me.btnEditJob.Location = New System.Drawing.Point(128, 289)
        Me.btnEditJob.Name = "btnEditJob"
        Me.btnEditJob.Size = New System.Drawing.Size(110, 23)
        Me.btnEditJob.TabIndex = 4
        Me.btnEditJob.Text = "Edit"
        Me.btnEditJob.UseVisualStyleBackColor = True
        '
        'btnAddJob
        '
        Me.btnAddJob.Location = New System.Drawing.Point(12, 289)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(110, 23)
        Me.btnAddJob.TabIndex = 3
        Me.btnAddJob.Text = "Add"
        Me.btnAddJob.UseVisualStyleBackColor = True
        '
        'dvJob
        '
        Me.dvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvJob.Location = New System.Drawing.Point(12, 12)
        Me.dvJob.Name = "dvJob"
        Me.dvJob.Size = New System.Drawing.Size(545, 271)
        Me.dvJob.TabIndex = 7
        '
        'FormJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvJob)
        Me.Controls.Add(Me.btnSaveJob)
        Me.Controls.Add(Me.btnDelJob)
        Me.Controls.Add(Me.btnEditJob)
        Me.Controls.Add(Me.btnAddJob)
        Me.Name = "FormJobs"
        Me.Text = "FormJobs"
        CType(Me.dvJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSaveJob As Button
    Friend WithEvents btnDelJob As Button
    Friend WithEvents btnEditJob As Button
    Friend WithEvents btnAddJob As Button
    Friend WithEvents dvJob As DataGridView
End Class

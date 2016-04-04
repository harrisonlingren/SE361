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
        Me.btnDelJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelJob
        '
        Me.btnDelJob.Enabled = False
        Me.btnDelJob.Location = New System.Drawing.Point(345, 289)
        Me.btnDelJob.Name = "btnDelJob"
        Me.btnDelJob.Size = New System.Drawing.Size(110, 23)
        Me.btnDelJob.TabIndex = 6
        Me.btnDelJob.Text = "Delete"
        Me.btnDelJob.UseVisualStyleBackColor = True
        '
        'btnEditJob
        '
        Me.btnEditJob.Enabled = False
        Me.btnEditJob.Location = New System.Drawing.Point(229, 289)
        Me.btnEditJob.Name = "btnEditJob"
        Me.btnEditJob.Size = New System.Drawing.Size(110, 23)
        Me.btnEditJob.TabIndex = 5
        Me.btnEditJob.Text = "Edit"
        Me.btnEditJob.UseVisualStyleBackColor = True
        '
        'btnAddJob
        '
        Me.btnAddJob.Location = New System.Drawing.Point(113, 289)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(110, 23)
        Me.btnAddJob.TabIndex = 4
        Me.btnAddJob.Text = "Add"
        Me.btnAddJob.UseVisualStyleBackColor = True
        '
        'FormJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.btnDelJob)
        Me.Controls.Add(Me.btnEditJob)
        Me.Controls.Add(Me.btnAddJob)
        Me.Name = "FormJobs"
        Me.Text = "FormJobs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelJob As Button
    Friend WithEvents btnEditJob As Button
    Friend WithEvents btnAddJob As Button
End Class

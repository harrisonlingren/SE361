<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJobs
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
        Me.listViewJobs = New System.Windows.Forms.ListView()
        Me.jobID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jobDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jobAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jobCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewJobs
        '
        Me.listViewJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.jobID, Me.jobDateTime, Me.jobAddress, Me.jobCost})
        Me.listViewJobs.Location = New System.Drawing.Point(12, 12)
        Me.listViewJobs.Name = "listViewJobs"
        Me.listViewJobs.Size = New System.Drawing.Size(545, 271)
        Me.listViewJobs.TabIndex = 7
        Me.listViewJobs.UseCompatibleStateImageBehavior = False
        Me.listViewJobs.View = System.Windows.Forms.View.Details
        '
        'jobID
        '
        Me.jobID.Text = "ID"
        '
        'jobDateTime
        '
        Me.jobDateTime.Text = "Date/Time"
        Me.jobDateTime.Width = 75
        '
        'jobAddress
        '
        Me.jobAddress.Text = "Address"
        Me.jobAddress.Width = 123
        '
        'jobCost
        '
        Me.jobCost.Text = "Cost"
        Me.jobCost.Width = 63
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
        Me.Controls.Add(Me.listViewJobs)
        Me.Controls.Add(Me.btnDelJob)
        Me.Controls.Add(Me.btnEditJob)
        Me.Controls.Add(Me.btnAddJob)
        Me.Name = "FormJobs"
        Me.Text = "FormJobs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewJobs As ListView
    Friend WithEvents btnDelJob As Button
    Friend WithEvents btnEditJob As Button
    Friend WithEvents btnAddJob As Button
    Friend WithEvents jobID As ColumnHeader
    Friend WithEvents jobDateTime As ColumnHeader
    Friend WithEvents jobAddress As ColumnHeader
    Friend WithEvents jobCost As ColumnHeader
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.listViewAppts = New System.Windows.Forms.ListView()
        Me.apptID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apptDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apptTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apptCust = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apptAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelAppt = New System.Windows.Forms.Button()
        Me.btnEditAppt = New System.Windows.Forms.Button()
        Me.btnAddAppt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewAppts
        '
        Me.listViewAppts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.apptID, Me.apptDate, Me.apptTime, Me.apptCust, Me.apptAddress})
        Me.listViewAppts.Location = New System.Drawing.Point(12, 12)
        Me.listViewAppts.Name = "listViewAppts"
        Me.listViewAppts.Size = New System.Drawing.Size(545, 271)
        Me.listViewAppts.TabIndex = 7
        Me.listViewAppts.UseCompatibleStateImageBehavior = False
        Me.listViewAppts.View = System.Windows.Forms.View.Details
        '
        'apptID
        '
        Me.apptID.Text = "ID"
        '
        'apptDate
        '
        Me.apptDate.Text = "Date"
        Me.apptDate.Width = 90
        '
        'apptTime
        '
        Me.apptTime.Text = "Time"
        Me.apptTime.Width = 86
        '
        'apptCust
        '
        Me.apptCust.Text = "Customer"
        Me.apptCust.Width = 109
        '
        'apptAddress
        '
        Me.apptAddress.Text = "Address"
        Me.apptAddress.Width = 141
        '
        'btnDelAppt
        '
        Me.btnDelAppt.Enabled = False
        Me.btnDelAppt.Location = New System.Drawing.Point(345, 289)
        Me.btnDelAppt.Name = "btnDelAppt"
        Me.btnDelAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnDelAppt.TabIndex = 6
        Me.btnDelAppt.Text = "Delete"
        Me.btnDelAppt.UseVisualStyleBackColor = True
        '
        'btnEditAppt
        '
        Me.btnEditAppt.Enabled = False
        Me.btnEditAppt.Location = New System.Drawing.Point(229, 289)
        Me.btnEditAppt.Name = "btnEditAppt"
        Me.btnEditAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnEditAppt.TabIndex = 5
        Me.btnEditAppt.Text = "Edit"
        Me.btnEditAppt.UseVisualStyleBackColor = True
        '
        'btnAddAppt
        '
        Me.btnAddAppt.Location = New System.Drawing.Point(113, 289)
        Me.btnAddAppt.Name = "btnAddAppt"
        Me.btnAddAppt.Size = New System.Drawing.Size(110, 23)
        Me.btnAddAppt.TabIndex = 4
        Me.btnAddAppt.Text = "Add"
        Me.btnAddAppt.UseVisualStyleBackColor = True
        '
        'FormAppts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.listViewAppts)
        Me.Controls.Add(Me.btnDelAppt)
        Me.Controls.Add(Me.btnEditAppt)
        Me.Controls.Add(Me.btnAddAppt)
        Me.Name = "FormAppts"
        Me.Text = "FormAppts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewAppts As ListView
    Friend WithEvents btnDelAppt As Button
    Friend WithEvents btnEditAppt As Button
    Friend WithEvents btnAddAppt As Button
    Friend WithEvents apptID As ColumnHeader
    Friend WithEvents apptDate As ColumnHeader
    Friend WithEvents apptTime As ColumnHeader
    Friend WithEvents apptCust As ColumnHeader
    Friend WithEvents apptAddress As ColumnHeader
End Class
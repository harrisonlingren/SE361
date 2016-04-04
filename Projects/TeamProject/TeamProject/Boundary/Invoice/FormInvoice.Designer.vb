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
        Me.btnDelInvoice = New System.Windows.Forms.Button()
        Me.btnEditInvoice = New System.Windows.Forms.Button()
        Me.btnAddInvoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.Controls.Add(Me.btnDelInvoice)
        Me.Controls.Add(Me.btnEditInvoice)
        Me.Controls.Add(Me.btnAddInvoice)
        Me.Name = "FormInvoice"
        Me.Text = "FormInvoice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelInvoice As Button
    Friend WithEvents btnEditInvoice As Button
    Friend WithEvents btnAddInvoice As Button
End Class

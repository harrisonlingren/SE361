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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSaveInv = New System.Windows.Forms.Button()
        Me.btnDelInv = New System.Windows.Forms.Button()
        Me.btnEditInv = New System.Windows.Forms.Button()
        Me.btnAddInv = New System.Windows.Forms.Button()
        Me.dvInv = New System.Windows.Forms.DataGridView()
        CType(Me.dvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Location = New System.Drawing.Point(447, 289)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveInv.TabIndex = 5
        Me.btnSaveInv.Text = "Save and Close"
        Me.btnSaveInv.UseVisualStyleBackColor = True
        '
        'btnDelInv
        '
        Me.btnDelInv.Location = New System.Drawing.Point(244, 289)
        Me.btnDelInv.Name = "btnDelInv"
        Me.btnDelInv.Size = New System.Drawing.Size(110, 23)
        Me.btnDelInv.TabIndex = 6
        Me.btnDelInv.Text = "Delete"
        Me.btnDelInv.UseVisualStyleBackColor = True
        '
        'btnEditInv
        '
        Me.btnEditInv.Enabled = False
        Me.btnEditInv.Location = New System.Drawing.Point(128, 289)
        Me.btnEditInv.Name = "btnEditInv"
        Me.btnEditInv.Size = New System.Drawing.Size(110, 23)
        Me.btnEditInv.TabIndex = 4
        Me.btnEditInv.Text = "Edit"
        Me.btnEditInv.UseVisualStyleBackColor = True
        '
        'btnAddInv
        '
        Me.btnAddInv.Location = New System.Drawing.Point(12, 289)
        Me.btnAddInv.Name = "btnAddInv"
        Me.btnAddInv.Size = New System.Drawing.Size(110, 23)
        Me.btnAddInv.TabIndex = 3
        Me.btnAddInv.Text = "Add"
        Me.btnAddInv.UseVisualStyleBackColor = True
        '
        'dvInv
        '
        Me.dvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvInv.Location = New System.Drawing.Point(12, 12)
        Me.dvInv.Name = "dvInv"
        Me.dvInv.Size = New System.Drawing.Size(545, 271)
        Me.dvInv.TabIndex = 8
        '
        'FormInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 324)
        Me.Controls.Add(Me.dvInv)
        Me.Controls.Add(Me.btnSaveInv)
        Me.Controls.Add(Me.btnDelInv)
        Me.Controls.Add(Me.btnEditInv)
        Me.Controls.Add(Me.btnAddInv)
        Me.Name = "FormInvoice"
        Me.Text = "FormInvoice"
        CType(Me.dvInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSaveInv As Button
    Friend WithEvents btnDelInv As Button
    Friend WithEvents btnEditInv As Button
    Friend WithEvents btnAddInv As Button
    Friend WithEvents dvInv As DataGridView
End Class

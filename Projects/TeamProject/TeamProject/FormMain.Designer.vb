<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.btnCust = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnAppts = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCust
        '
        Me.btnCust.Location = New System.Drawing.Point(12, 12)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(130, 42)
        Me.btnCust.TabIndex = 0
        Me.btnCust.Text = "Customers"
        Me.btnCust.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.Location = New System.Drawing.Point(151, 12)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(130, 42)
        Me.btnJobs.TabIndex = 1
        Me.btnJobs.Text = "Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(151, 60)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(130, 42)
        Me.btnInvoice.TabIndex = 3
        Me.btnInvoice.Text = "Payments / Invoices"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'btnAppts
        '
        Me.btnAppts.Location = New System.Drawing.Point(12, 60)
        Me.btnAppts.Name = "btnAppts"
        Me.btnAppts.Size = New System.Drawing.Size(130, 42)
        Me.btnAppts.TabIndex = 2
        Me.btnAppts.Text = "Appointments"
        Me.btnAppts.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(81, 109)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(130, 42)
        Me.btnEmployee.TabIndex = 4
        Me.btnEmployee.Text = "Employees"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 165)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.btnAppts)
        Me.Controls.Add(Me.btnJobs)
        Me.Controls.Add(Me.btnCust)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCust As Button
    Friend WithEvents btnJobs As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnAppts As Button
    Friend WithEvents btnEmployee As Button
End Class

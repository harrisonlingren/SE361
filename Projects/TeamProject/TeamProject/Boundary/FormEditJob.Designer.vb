<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditJob
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
        Me.btnJobCancel = New System.Windows.Forms.Button()
        Me.btnJobSave = New System.Windows.Forms.Button()
        Me.txtJobAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJobCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtJobTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnJobCancel
        '
        Me.btnJobCancel.Location = New System.Drawing.Point(143, 119)
        Me.btnJobCancel.Name = "btnJobCancel"
        Me.btnJobCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnJobCancel.TabIndex = 23
        Me.btnJobCancel.Text = "Cancel"
        Me.btnJobCancel.UseVisualStyleBackColor = True
        '
        'btnJobSave
        '
        Me.btnJobSave.Location = New System.Drawing.Point(15, 119)
        Me.btnJobSave.Name = "btnJobSave"
        Me.btnJobSave.Size = New System.Drawing.Size(95, 23)
        Me.btnJobSave.TabIndex = 22
        Me.btnJobSave.Text = "Save"
        Me.btnJobSave.UseVisualStyleBackColor = True
        '
        'txtJobAddress
        '
        Me.txtJobAddress.Location = New System.Drawing.Point(92, 87)
        Me.txtJobAddress.Name = "txtJobAddress"
        Me.txtJobAddress.Size = New System.Drawing.Size(146, 20)
        Me.txtJobAddress.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address:"
        '
        'txtJobCost
        '
        Me.txtJobCost.Location = New System.Drawing.Point(92, 61)
        Me.txtJobCost.Name = "txtJobCost"
        Me.txtJobCost.Size = New System.Drawing.Size(146, 20)
        Me.txtJobCost.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date / Time:"
        '
        'txtJobID
        '
        Me.txtJobID.Location = New System.Drawing.Point(143, 9)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.ReadOnly = True
        Me.txtJobID.Size = New System.Drawing.Size(95, 20)
        Me.txtJobID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Job ID:"
        '
        'dtJobTime
        '
        Me.dtJobTime.Location = New System.Drawing.Point(92, 35)
        Me.dtJobTime.Name = "dtJobTime"
        Me.dtJobTime.Size = New System.Drawing.Size(146, 20)
        Me.dtJobTime.TabIndex = 25
        Me.dtJobTime.Value = New Date(2016, 3, 1, 22, 13, 29, 0)
        '
        'FormEditJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 154)
        Me.Controls.Add(Me.dtJobTime)
        Me.Controls.Add(Me.btnJobCancel)
        Me.Controls.Add(Me.btnJobSave)
        Me.Controls.Add(Me.txtJobAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJobCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtJobID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditJob"
        Me.Text = "FormEditJob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnJobCancel As Button
    Friend WithEvents btnJobSave As Button
    Friend WithEvents txtJobAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJobCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtJobTime As DateTimePicker
End Class

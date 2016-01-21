<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.wbrDisplay = New System.Windows.Forms.WebBrowser()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnForw = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.stsStrip = New System.Windows.Forms.StatusStrip()
        Me.stsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'wbrDisplay
        '
        Me.wbrDisplay.Location = New System.Drawing.Point(12, 44)
        Me.wbrDisplay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrDisplay.Name = "wbrDisplay"
        Me.wbrDisplay.ScriptErrorsSuppressed = True
        Me.wbrDisplay.Size = New System.Drawing.Size(631, 399)
        Me.wbrDisplay.TabIndex = 0
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(56, 12)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(448, 20)
        Me.txtURL.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(12, 10)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(38, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnForw
        '
        Me.btnForw.Location = New System.Drawing.Point(607, 10)
        Me.btnForw.Name = "btnForw"
        Me.btnForw.Size = New System.Drawing.Size(36, 23)
        Me.btnForw.TabIndex = 2
        Me.btnForw.Text = "-->"
        Me.btnForw.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(568, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(36, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "<--"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(510, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'stsStrip
        '
        Me.stsStrip.Location = New System.Drawing.Point(0, 452)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.Size = New System.Drawing.Size(655, 22)
        Me.stsStrip.TabIndex = 3
        '
        'stsLabel
        '
        Me.stsLabel.AutoSize = True
        Me.stsLabel.Location = New System.Drawing.Point(8, 457)
        Me.stsLabel.Name = "stsLabel"
        Me.stsLabel.Size = New System.Drawing.Size(33, 13)
        Me.stsLabel.TabIndex = 4
        Me.stsLabel.Text = "Done"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 474)
        Me.Controls.Add(Me.stsLabel)
        Me.Controls.Add(Me.stsStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnForw)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.wbrDisplay)
        Me.Name = "MainForm"
        Me.Text = "My Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbrDisplay As WebBrowser
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents btnForw As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents stsStrip As StatusStrip
    Friend WithEvents stsLabel As Label
End Class

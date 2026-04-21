<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.cmdReason = New System.Windows.Forms.ComboBox()
        Me.cmbAdmin = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdReason
        '
        Me.cmdReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmdReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdReason.FormattingEnabled = True
        Me.cmdReason.Items.AddRange(New Object() {"Paid", "Time", "Technical", "Photo/Birthday ...", "Dep.Lilit", "Dep.Astghik", "SPA", "NEW", "STATUS", "Other"})
        Me.cmdReason.Location = New System.Drawing.Point(64, 146)
        Me.cmdReason.Name = "cmdReason"
        Me.cmdReason.Size = New System.Drawing.Size(156, 21)
        Me.cmdReason.TabIndex = 3
        '
        'cmbAdmin
        '
        Me.cmbAdmin.FormattingEnabled = True
        Me.cmbAdmin.Location = New System.Drawing.Point(64, 95)
        Me.cmbAdmin.Name = "cmbAdmin"
        Me.cmbAdmin.Size = New System.Drawing.Size(156, 21)
        Me.cmbAdmin.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label42.Location = New System.Drawing.Point(-3, 95)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(61, 21)
        Me.Label42.TabIndex = 183
        Me.Label42.Text = "Admin"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-3, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Reason"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.cmdReason)
        Me.Controls.Add(Me.cmbAdmin)
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdReason As ComboBox
    Friend WithEvents cmbAdmin As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label1 As Label
End Class

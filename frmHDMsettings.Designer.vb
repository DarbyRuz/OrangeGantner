<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHDMsettings
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
        Me.hdmPassword = New System.Windows.Forms.TextBox()
        Me.hdmPort = New System.Windows.Forms.TextBox()
        Me.hdmIp = New System.Windows.Forms.TextBox()
        Me.cmbHDM = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updPort = New System.Windows.Forms.Button()
        Me.UpdIP = New System.Windows.Forms.Button()
        Me.UpdPas = New System.Windows.Forms.Button()
        Me.updOperatorID = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hdmOperatorPass = New System.Windows.Forms.TextBox()
        Me.updOperatorPass = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hdmOperatorID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'hdmPassword
        '
        Me.hdmPassword.Location = New System.Drawing.Point(84, 190)
        Me.hdmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hdmPassword.Name = "hdmPassword"
        Me.hdmPassword.Size = New System.Drawing.Size(132, 22)
        Me.hdmPassword.TabIndex = 22
        '
        'hdmPort
        '
        Me.hdmPort.Location = New System.Drawing.Point(84, 103)
        Me.hdmPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hdmPort.Name = "hdmPort"
        Me.hdmPort.Size = New System.Drawing.Size(132, 22)
        Me.hdmPort.TabIndex = 21
        '
        'hdmIp
        '
        Me.hdmIp.Location = New System.Drawing.Point(84, 146)
        Me.hdmIp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hdmIp.Name = "hdmIp"
        Me.hdmIp.Size = New System.Drawing.Size(132, 22)
        Me.hdmIp.TabIndex = 20
        '
        'cmbHDM
        '
        Me.cmbHDM.FormattingEnabled = True
        Me.cmbHDM.Location = New System.Drawing.Point(84, 52)
        Me.cmbHDM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbHDM.Name = "cmbHDM"
        Me.cmbHDM.Size = New System.Drawing.Size(132, 24)
        Me.cmbHDM.TabIndex = 19
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(31, 273)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 16)
        Me.lblUser.TabIndex = 82
        Me.lblUser.Text = "Label2"
        Me.lblUser.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "IP"
        '
        'updPort
        '
        Me.updPort.Location = New System.Drawing.Point(241, 101)
        Me.updPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updPort.Name = "updPort"
        Me.updPort.Size = New System.Drawing.Size(137, 28)
        Me.updPort.TabIndex = 86
        Me.updPort.Text = "Update port"
        Me.updPort.UseVisualStyleBackColor = True
        '
        'UpdIP
        '
        Me.UpdIP.Location = New System.Drawing.Point(241, 146)
        Me.UpdIP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdIP.Name = "UpdIP"
        Me.UpdIP.Size = New System.Drawing.Size(137, 28)
        Me.UpdIP.TabIndex = 87
        Me.UpdIP.Text = "Update IP"
        Me.UpdIP.UseVisualStyleBackColor = True
        '
        'UpdPas
        '
        Me.UpdPas.Location = New System.Drawing.Point(241, 190)
        Me.UpdPas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdPas.Name = "UpdPas"
        Me.UpdPas.Size = New System.Drawing.Size(137, 28)
        Me.UpdPas.TabIndex = 88
        Me.UpdPas.Text = "Update password"
        Me.UpdPas.UseVisualStyleBackColor = True
        '
        'updOperatorID
        '
        Me.updOperatorID.Location = New System.Drawing.Point(241, 261)
        Me.updOperatorID.Margin = New System.Windows.Forms.Padding(4)
        Me.updOperatorID.Name = "updOperatorID"
        Me.updOperatorID.Size = New System.Drawing.Size(137, 28)
        Me.updOperatorID.TabIndex = 91
        Me.updOperatorID.Text = "Update"
        Me.updOperatorID.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "OperatorPass"
        '
        'hdmOperatorPass
        '
        Me.hdmOperatorPass.Location = New System.Drawing.Point(104, 228)
        Me.hdmOperatorPass.Margin = New System.Windows.Forms.Padding(4)
        Me.hdmOperatorPass.Name = "hdmOperatorPass"
        Me.hdmOperatorPass.Size = New System.Drawing.Size(112, 22)
        Me.hdmOperatorPass.TabIndex = 89
        '
        'updOperatorPass
        '
        Me.updOperatorPass.Location = New System.Drawing.Point(241, 231)
        Me.updOperatorPass.Margin = New System.Windows.Forms.Padding(4)
        Me.updOperatorPass.Name = "updOperatorPass"
        Me.updOperatorPass.Size = New System.Drawing.Size(137, 28)
        Me.updOperatorPass.TabIndex = 94
        Me.updOperatorPass.Text = "Update "
        Me.updOperatorPass.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "OperatorID"
        '
        'hdmOperatorID
        '
        Me.hdmOperatorID.Location = New System.Drawing.Point(104, 260)
        Me.hdmOperatorID.Margin = New System.Windows.Forms.Padding(4)
        Me.hdmOperatorID.Name = "hdmOperatorID"
        Me.hdmOperatorID.Size = New System.Drawing.Size(112, 22)
        Me.hdmOperatorID.TabIndex = 92
        '
        'frmHDMsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.updOperatorPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hdmOperatorID)
        Me.Controls.Add(Me.updOperatorID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hdmOperatorPass)
        Me.Controls.Add(Me.UpdPas)
        Me.Controls.Add(Me.UpdIP)
        Me.Controls.Add(Me.updPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.hdmPassword)
        Me.Controls.Add(Me.hdmPort)
        Me.Controls.Add(Me.hdmIp)
        Me.Controls.Add(Me.cmbHDM)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHDMsettings"
        Me.Text = "frmHDMsettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hdmPassword As TextBox
    Friend WithEvents hdmPort As TextBox
    Friend WithEvents hdmIp As TextBox
    Friend WithEvents cmbHDM As ComboBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents updPort As Button
    Friend WithEvents UpdIP As Button
    Friend WithEvents UpdPas As Button
    Friend WithEvents updOperatorID As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents hdmOperatorPass As TextBox
    Friend WithEvents updOperatorPass As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents hdmOperatorID As TextBox
End Class

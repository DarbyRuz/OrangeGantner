<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamera))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(695, 507)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 47)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Copy"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbCamera
        '
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.FormattingEnabled = True
        Me.cmbCamera.Location = New System.Drawing.Point(17, 41)
        Me.cmbCamera.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(297, 24)
        Me.cmbCamera.TabIndex = 8
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Location = New System.Drawing.Point(16, 21)
        Me.lblCamera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(108, 17)
        Me.lblCamera.TabIndex = 7
        Me.lblCamera.Text = "Select Camera :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 411)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Picture Preview :"
        '
        'lstDevices
        '
        Me.lstDevices.ItemHeight = 16
        Me.lstDevices.Location = New System.Drawing.Point(420, 2)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(307, 36)
        Me.lstDevices.TabIndex = 14
        Me.lstDevices.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(34, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1074, 854)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbCamera)
        Me.Controls.Add(Me.lblCamera)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCamera"
        Me.Text = "Webcam"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents btnCapture As System.Windows.Forms.Button
    Private WithEvents cmbCamera As System.Windows.Forms.ComboBox
    Private WithEvents lblCamera As System.Windows.Forms.Label
    Private WithEvents picFeed As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents lstDevices As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

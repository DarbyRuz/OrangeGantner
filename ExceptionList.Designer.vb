<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExceptionList
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
		Me.lblCustomerId = New System.Windows.Forms.Label()
		Me.CommentSection = New System.Windows.Forms.TextBox()
		Me.AddOrSave = New System.Windows.Forms.Button()
		Me.Remove = New System.Windows.Forms.Button()
		Me.lblLastName = New System.Windows.Forms.Label()
		Me.lvlName = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblCustomerId
		'
		Me.lblCustomerId.AutoSize = True
		Me.lblCustomerId.Location = New System.Drawing.Point(199, 9)
		Me.lblCustomerId.Name = "lblCustomerId"
		Me.lblCustomerId.Size = New System.Drawing.Size(18, 16)
		Me.lblCustomerId.TabIndex = 0
		Me.lblCustomerId.Text = "Id"
		Me.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblCustomerId.Visible = False
		'
		'CommentSection
		'
		Me.CommentSection.Location = New System.Drawing.Point(31, 49)
		Me.CommentSection.Multiline = False
		Me.CommentSection.Name = "CommentSection"
		Me.CommentSection.Size = New System.Drawing.Size(408, 89)
		Me.CommentSection.TabIndex = 2
		Me.CommentSection.AutoCompleteMode = AutoCompleteMode.Suggest
		Me.CommentSection.AutoCompleteSource = AutoCompleteSource.CustomSource
		Me.CommentSection.AutoCompleteCustomSource.AddRange(New String() {"Long nail", "Fingerprint issue", "Refused"})
		'
		'AddOrSave
		'
		Me.AddOrSave.Location = New System.Drawing.Point(31, 171)
		Me.AddOrSave.Name = "AddOrSave"
		Me.AddOrSave.Size = New System.Drawing.Size(170, 23)
		Me.AddOrSave.TabIndex = 3
		Me.AddOrSave.Text = "AddOrEdit"
		Me.AddOrSave.UseVisualStyleBackColor = True
		'
		'Remove
		'
		Me.Remove.Location = New System.Drawing.Point(223, 171)
		Me.Remove.Name = "Remove"
		Me.Remove.Size = New System.Drawing.Size(170, 23)
		Me.Remove.TabIndex = 5
		Me.Remove.Text = "Remove"
		Me.Remove.UseVisualStyleBackColor = True
		'
		'lblLastName
		'
		Me.lblLastName.AutoSize = True
		Me.lblLastName.Location = New System.Drawing.Point(120, 9)
		Me.lblLastName.Name = "lblLastName"
		Me.lblLastName.Size = New System.Drawing.Size(32, 16)
		Me.lblLastName.TabIndex = 6
		Me.lblLastName.Text = "Last"
		Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lvlName
		'
		Me.lvlName.AllowDrop = True
		Me.lvlName.AutoSize = True
		Me.lvlName.Location = New System.Drawing.Point(28, 9)
		Me.lvlName.Name = "lvlName"
		Me.lvlName.Size = New System.Drawing.Size(44, 16)
		Me.lvlName.TabIndex = 7
		Me.lvlName.Text = "Name"
		Me.lvlName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ExceptionList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 240)
		Me.Controls.Add(Me.lvlName)
		Me.Controls.Add(Me.lblLastName)
		Me.Controls.Add(Me.Remove)
		Me.Controls.Add(Me.AddOrSave)
		Me.Controls.Add(Me.CommentSection)
		Me.Controls.Add(Me.lblCustomerId)
		Me.Name = "ExceptionList"
		Me.Text = "ExceptionList"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblCustomerId As Label
	Friend WithEvents CommentSection As TextBox
	Friend WithEvents AddOrSave As Button
	Friend WithEvents Remove As Button
	Friend WithEvents lblLastName As Label
	Friend WithEvents lvlName As Label
End Class

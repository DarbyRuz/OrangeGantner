<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.lstPrint = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(379, 97)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "Button1"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'rtbText
        '
        Me.rtbText.Location = New System.Drawing.Point(254, 279)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.Size = New System.Drawing.Size(209, 179)
        Me.rtbText.TabIndex = 2
        Me.rtbText.Text = ""
        '
        'lstPrint
        '
        Me.lstPrint.FormattingEnabled = True
        Me.lstPrint.Location = New System.Drawing.Point(47, 32)
        Me.lstPrint.Name = "lstPrint"
        Me.lstPrint.Size = New System.Drawing.Size(227, 186)
        Me.lstPrint.TabIndex = 3
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 496)
        Me.Controls.Add(Me.lstPrint)
        Me.Controls.Add(Me.rtbText)
        Me.Controls.Add(Me.cmdPrint)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPrint"
        Me.Text = "frmPrint"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cmdPrint As Button
    Friend WithEvents rtbText As RichTextBox
    Friend WithEvents lstPrint As ListBox
End Class

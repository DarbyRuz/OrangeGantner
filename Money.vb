Imports System.Data.SqlClient
Imports System.Console
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class Money
    Inherits System.Windows.Forms.Form

    Dim adapter As SqlDataAdapter

    Dim ds As New DataSet()

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUser As Label
    Dim j As Integer
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccountNum As System.Windows.Forms.Label
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBox16 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox17 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox18 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox19 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents DepositPay As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox20 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents WithDrowal As System.Windows.Forms.Button
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ComboBox20 = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGrid3 = New System.Windows.Forms.DataGrid()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.WithDrowal = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.DepositPay = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.lblAccountNum = New System.Windows.Forms.Label()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.DataGrid4 = New System.Windows.Forms.DataGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox19 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox18 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox17 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox16 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblUser = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, -32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1225, 824)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.lblUser)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Button11)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.DataGrid3)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.TextBox23)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.WithDrowal)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.TextBox21)
        Me.TabPage1.Controls.Add(Me.DepositPay)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.TextBox18)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.TextBox17)
        Me.TabPage1.Controls.Add(Me.TextBox16)
        Me.TabPage1.Controls.Add(Me.lblAccountNum)
        Me.TabPage1.Controls.Add(Me.ComboBox13)
        Me.TabPage1.Controls.Add(Me.DataGrid4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DataGrid2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ComboBox5)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ComboBox11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ComboBox9)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox10)
        Me.TabPage1.Controls.Add(Me.ComboBox12)
        Me.TabPage1.Controls.Add(Me.ComboBox10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.TextBox19)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.DateTimePicker4)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.DateTimePicker5)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.TextBox22)
        Me.TabPage1.Controls.Add(Me.TextBox9)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1217, 798)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Income                          +"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.ComboBox14)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.ComboBox20)
        Me.Panel2.Location = New System.Drawing.Point(637, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 177)
        Me.Panel2.TabIndex = 111
        '
        'ComboBox14
        '
        Me.ComboBox14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox14.Location = New System.Drawing.Point(21, 18)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox14.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(21, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Card Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(20, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(21, 134)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(21, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(210, 3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 96
        Me.Label27.Text = "Order ID"
        '
        'ComboBox20
        '
        Me.ComboBox20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox20.Location = New System.Drawing.Point(193, 22)
        Me.ComboBox20.Name = "ComboBox20"
        Me.ComboBox20.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox20.TabIndex = 97
        Me.ComboBox20.Text = "0"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(991, 340)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(146, 47)
        Me.Button11.TabIndex = 110
        Me.Button11.Text = "Update Planned payment and date "
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1080, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(112, 40)
        Me.Button10.TabIndex = 109
        Me.Button10.Text = "Delete WithDrowal"
        Me.Button10.Visible = False
        '
        'DataGrid3
        '
        Me.DataGrid3.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid3.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid3.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid3.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.FlatMode = True
        Me.DataGrid3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGrid3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid3.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid3.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid3.Location = New System.Drawing.Point(944, 128)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid3.Size = New System.Drawing.Size(218, 198)
        Me.DataGrid3.TabIndex = 108
        Me.DataGrid3.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(1040, 224)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 24)
        Me.Label30.TabIndex = 107
        Me.Label30.Text = "Label30"
        Me.Label30.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(320, 268)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 15)
        Me.Label29.TabIndex = 106
        Me.Label29.Text = "%"
        Me.Label29.Visible = False
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(360, 268)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 21)
        Me.TextBox23.TabIndex = 105
        Me.TextBox23.Text = "100"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox23.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox2.Location = New System.Drawing.Point(813, 302)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox2.TabIndex = 102
        Me.CheckBox2.Text = "Non Client"
        Me.CheckBox2.Visible = False
        '
        'WithDrowal
        '
        Me.WithDrowal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.WithDrowal.Location = New System.Drawing.Point(1000, 16)
        Me.WithDrowal.Name = "WithDrowal"
        Me.WithDrowal.Size = New System.Drawing.Size(80, 40)
        Me.WithDrowal.TabIndex = 101
        Me.WithDrowal.Text = "WithDrowal"
        Me.WithDrowal.Visible = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 291)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 17)
        Me.Label28.TabIndex = 100
        Me.Label28.Text = "Notes"
        Me.Label28.Visible = False
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(512, 259)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(96, 21)
        Me.TextBox21.TabIndex = 99
        Me.TextBox21.Visible = False
        '
        'DepositPay
        '
        Me.DepositPay.BackColor = System.Drawing.Color.Gray
        Me.DepositPay.Enabled = False
        Me.DepositPay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DepositPay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DepositPay.Location = New System.Drawing.Point(864, 16)
        Me.DepositPay.Name = "DepositPay"
        Me.DepositPay.Size = New System.Drawing.Size(136, 40)
        Me.DepositPay.TabIndex = 97
        Me.DepositPay.Text = "Pay from Deposit"
        Me.DepositPay.UseVisualStyleBackColor = False
        Me.DepositPay.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(944, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "Button5"
        Me.Button5.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(497, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 41)
        Me.Button3.TabIndex = 92
        Me.Button3.Text = "Edit Payment"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(288, 216)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 91
        Me.Label23.Text = "Discount%"
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(360, 208)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(96, 21)
        Me.TextBox18.TabIndex = 90
        Me.TextBox18.Text = "0"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(288, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "Unit Price"
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(360, 144)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(96, 21)
        Me.TextBox17.TabIndex = 88
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(112, 112)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(128, 21)
        Me.TextBox16.TabIndex = 78
        Me.TextBox16.Visible = False
        '
        'lblAccountNum
        '
        Me.lblAccountNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAccountNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccountNum.Location = New System.Drawing.Point(8, 268)
        Me.lblAccountNum.Name = "lblAccountNum"
        Me.lblAccountNum.Size = New System.Drawing.Size(80, 15)
        Me.lblAccountNum.TabIndex = 75
        Me.lblAccountNum.Text = "Received from"
        '
        'ComboBox13
        '
        Me.ComboBox13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox13.Location = New System.Drawing.Point(112, 268)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox13.TabIndex = 74
        '
        'DataGrid4
        '
        Me.DataGrid4.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(36, 320)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.Size = New System.Drawing.Size(950, 187)
        Me.DataGrid4.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(744, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Coach"
        Me.Label3.Visible = False
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(36, 512)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(1181, 174)
        Me.DataGrid2.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(392, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 41)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Delete Payment"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(291, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 41)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Add Payment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(837, 504)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox5.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(16, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Plan Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.AllowDrop = True
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(112, 88)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Payment Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AllowDrop = True
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker1.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(292, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Amount"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(360, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 24)
        Me.TextBox3.TabIndex = 35
        Me.TextBox3.Text = "0"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Payment Base"
        '
        'ComboBox11
        '
        Me.ComboBox11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox11.Location = New System.Drawing.Point(112, 136)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox11.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(16, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Payment Purpose"
        '
        'ComboBox9
        '
        Me.ComboBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox9.Location = New System.Drawing.Point(112, 160)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox9.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(16, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Chek Number"
        Me.Label14.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(112, 232)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(136, 21)
        Me.TextBox11.TabIndex = 70
        Me.TextBox11.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "PO Number"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(112, 208)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(136, 21)
        Me.TextBox10.TabIndex = 47
        Me.TextBox10.Text = "0"
        '
        'ComboBox12
        '
        Me.ComboBox12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox12.Location = New System.Drawing.Point(720, 160)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox12.TabIndex = 65
        Me.ComboBox12.Text = "ComboBox12"
        Me.ComboBox12.Visible = False
        '
        'ComboBox10
        '
        Me.ComboBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox10.Location = New System.Drawing.Point(112, 184)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox10.TabIndex = 40
        Me.ComboBox10.Text = "Cash"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 22)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Payment Methode"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(112, 291)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(584, 21)
        Me.TextBox4.TabIndex = 41
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1008, 576)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(104, 21)
        Me.TextBox12.TabIndex = 77
        Me.TextBox12.Text = "TextBox12"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(288, 184)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Quantity"
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(360, 184)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(96, 21)
        Me.TextBox19.TabIndex = 88
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(1007, 436)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 16)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "Activation Date"
        Me.Label25.Visible = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.AllowDrop = True
        Me.DateTimePicker4.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(1096, 460)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker4.TabIndex = 68
        Me.DateTimePicker4.Visible = False
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(1032, 468)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 16)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "DeadLine"
        Me.Label26.Visible = False
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.AllowDrop = True
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(1096, 428)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker5.TabIndex = 37
        Me.DateTimePicker5.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox7.Location = New System.Drawing.Point(658, 354)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 21)
        Me.TextBox7.TabIndex = 59
        Me.TextBox7.Text = "TextBox7"
        '
        'TextBox22
        '
        Me.TextBox22.Enabled = False
        Me.TextBox22.Location = New System.Drawing.Point(608, 320)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(88, 21)
        Me.TextBox22.TabIndex = 103
        Me.TextBox22.Text = "Category"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox9.Location = New System.Drawing.Point(480, 360)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(72, 21)
        Me.TextBox9.TabIndex = 67
        Me.TextBox9.Text = "TextBox9"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gray
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button9.Location = New System.Drawing.Point(536, 216)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(136, 23)
        Me.Button9.TabIndex = 98
        Me.Button9.Text = "Pay for Freezing"
        Me.Button9.UseVisualStyleBackColor = False
        Me.Button9.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.ComboBox19)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.TextBox14)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.ComboBox18)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.ComboBox17)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.ComboBox16)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.ComboBox15)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.TextBox13)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.DateTimePicker3)
        Me.TabPage2.Controls.Add(Me.TextBox15)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1217, 798)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Withdrawal                    -"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(736, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox1.TabIndex = 85
        Me.CheckBox1.Text = "Non Client"
        Me.CheckBox1.Visible = False
        '
        'ComboBox19
        '
        Me.ComboBox19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox19.Items.AddRange(New Object() {"000000"})
        Me.ComboBox19.Location = New System.Drawing.Point(568, 16)
        Me.ComboBox19.Name = "ComboBox19"
        Me.ComboBox19.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox19.TabIndex = 84
        Me.ComboBox19.Text = "000000"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(448, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 83
        Me.Label21.Text = "Card Number"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 232)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 23)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Notes"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(0, 256)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(1080, 21)
        Me.TextBox14.TabIndex = 80
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 23)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Return Type"
        '
        'ComboBox18
        '
        Me.ComboBox18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox18.Location = New System.Drawing.Point(176, 200)
        Me.ComboBox18.Name = "ComboBox18"
        Me.ComboBox18.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox18.TabIndex = 78
        Me.ComboBox18.Text = "ComboBox18"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 23)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Return Base"
        '
        'ComboBox17
        '
        Me.ComboBox17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox17.Location = New System.Drawing.Point(176, 160)
        Me.ComboBox17.Name = "ComboBox17"
        Me.ComboBox17.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox17.TabIndex = 76
        Me.ComboBox17.Text = "ComboBox17"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(448, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Surname"
        '
        'ComboBox16
        '
        Me.ComboBox16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox16.Location = New System.Drawing.Point(568, 88)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox16.TabIndex = 74
        Me.ComboBox16.Text = "ComboBox16"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(448, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 23)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Name"
        '
        'ComboBox15
        '
        Me.ComboBox15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox15.Location = New System.Drawing.Point(568, 56)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox15.TabIndex = 72
        Me.ComboBox15.Text = "ComboBox15"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 23)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Amount"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(176, 120)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(120, 21)
        Me.TextBox13.TabIndex = 70
        Me.TextBox13.Text = "0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Return Date"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(984, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 24)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "Delete-"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.Location = New System.Drawing.Point(896, 224)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(72, 24)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "Save-"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(144, 32)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(184, 21)
        Me.DateTimePicker3.TabIndex = 68
        '
        'TextBox15
        '
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(840, 344)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(88, 21)
        Me.TextBox15.TabIndex = 82
        Me.TextBox15.Text = "TextBox15"
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox20.Location = New System.Drawing.Point(96, 16)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(104, 21)
        Me.TextBox20.TabIndex = 95
        Me.TextBox20.Text = "0"
        Me.TextBox20.Visible = False
        '
        'ComboBox8
        '
        Me.ComboBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox8.Location = New System.Drawing.Point(472, 16)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox8.TabIndex = 30
        Me.ComboBox8.Text = "ComboBox8"
        Me.ComboBox8.Visible = False
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox7.Location = New System.Drawing.Point(200, 96)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox7.TabIndex = 29
        Me.ComboBox7.Text = "ComboBox7"
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox6.Location = New System.Drawing.Point(96, 208)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox6.TabIndex = 27
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(168, 208)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox3.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(704, 208)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(80, 21)
        Me.TextBox8.TabIndex = 62
        Me.TextBox8.Text = "TextBox8"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox4.Location = New System.Drawing.Point(160, 256)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox4.TabIndex = 61
        Me.ComboBox4.Text = "ComboBox4"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox6.Location = New System.Drawing.Point(48, 232)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(88, 21)
        Me.TextBox6.TabIndex = 58
        Me.TextBox6.Text = "TextBox6"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(160, 240)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 21)
        Me.TextBox2.TabIndex = 57
        Me.TextBox2.Text = "TextBox2"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(48, 208)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 21)
        Me.TextBox1.TabIndex = 54
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(240, 256)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 21)
        Me.TextBox5.TabIndex = 63
        Me.TextBox5.Text = "TextBox5"
        '
        'Panel1
        '
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Panel1.Location = New System.Drawing.Point(40, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 104)
        Me.Panel1.TabIndex = 66
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(66, 25)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(38, 13)
        Me.lblUser.TabIndex = 204
        Me.lblUser.Text = "Label2"
        '
        'Money
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.TextBox20)
        Me.Name = "Money"
        Me.Text = "Money"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Function GetPurchaseOrders() As Integer
        Dim connection = GetSqlConnection()
        Using connection
            Dim cmdPoDetID = connection.CreateCommand()
            cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
            Dim sqlResult1 As Object = cmdPoDetID.ExecuteScalar()
            Dim idDetID As Integer
            If IsDBNull(sqlResult1) Then
                idDetID = 1
            Else
                sqlResult1.ToString()
                idDetID = ExecuteScalar(cmdPoDetID)
                idDetID = idDetID + 1
            End If
            Return idDetID
        End Using
    End Function
    Private Function GetAllEmployees() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "Select * from Emp"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "Employees")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function
    Private Function GetAllCustomers() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "select * from Customers"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "Customers")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function

    Private Function GetAllPaymentOrders() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "select * from PaymentOrder"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "PaymentOrder")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function
    Private Function GetAllProducts() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "Select * from Products"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "Tariffs")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function
    Private Function GetPaymentPurposes() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "Select * from PaymentPurpose"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "PaymentPurpose")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function
    Private Function GetPaymentTypes() As DataSet
        Dim customerDataSet As New DataSet()
        Dim connection = GetSqlConnection()
        Using connection
            Dim daCust As New SqlDataAdapter
            Dim cmdCust As New SqlCommand
            cmdCust = connection.CreateCommand
            Using cmdCust
                cmdCust.CommandText = "Select * from PaymentType"
                Using daCust
                    daCust.SelectCommand = cmdCust
                    daCust.Fill(customerDataSet, "PaymentType")
                End Using
            End Using
        End Using
        Return customerDataSet
    End Function
    Private Sub Money_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label27.Text = ComboBox20.Text
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy "
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy "
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

        Dim worker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        Dim idDetID As Integer
        AddHandler worker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                      idDetID = GetPurchaseOrders()
                                  End Sub
        AddHandler worker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
                                                  TextBox5.Text = idDetID
                                              End Sub
        Dim customerDataset As DataSet
        Dim customerWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler customerWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                              customerDataset = GetAllCustomers()
                                          End Sub
        AddHandler customerWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
                                                          Dim st = Stopwatch.StartNew()

                                                          With ComboBox7
                                                              .DisplayMember = "Customers.ID"
                                                              .ValueMember = "ID"
                                                              .DataSource = customerDataset
                                                          End With
                                                          With ComboBox14
                                                              .DisplayMember = "Customers.CardID"
                                                              .ValueMember = "ID"
                                                              .AutoCompleteMode = AutoCompleteMode.Suggest
                                                              .AutoCompleteSource = AutoCompleteSource.ListItems
                                                              .DataSource = customerDataset
                                                          End With
                                                          With ComboBox1
                                                              .DisplayMember = "Customers.FirstName"
                                                              .ValueMember = "ID"
                                                              .AutoCompleteMode = AutoCompleteMode.Suggest
                                                              .AutoCompleteSource = AutoCompleteSource.ListItems
                                                              .DataSource = customerDataset
                                                          End With
                                                          With ComboBox2
                                                              .DisplayMember = "Customers.LastName"
                                                              .ValueMember = "ID"
                                                              .AutoCompleteMode = AutoCompleteMode.Suggest
                                                              .AutoCompleteSource = AutoCompleteSource.ListItems
                                                              .DataSource = customerDataset
                                                          End With
                                                          TextBox2.DataBindings.Add("Text", customerDataset, "Customers.ID")
                                                          st.Stop()
                                                          System.Diagnostics.Debug.WriteLine(st.ElapsedMilliseconds)

                                                      End Sub
        Dim employees As DataSet
        Dim employesWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler employesWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                              employees = GetAllEmployees()
                                          End Sub
        AddHandler employesWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)

                                                          With ComboBox13
                                                              .DisplayMember = "Employees.Name"
                                                              .ValueMember = "ID"
                                                              .SelectedIndex = -1
                                                              .AutoCompleteMode = AutoCompleteMode.Suggest
                                                              .AutoCompleteSource = AutoCompleteSource.ListItems
                                                              .DataSource = employees

                                                          End With
                                                          TextBox12.DataBindings.Add("Text", employees, "Employees.ID")

                                                      End Sub
        Dim paymentOrders As DataSet
        Dim paymentWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler paymentWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                             paymentOrders = GetAllPaymentOrders()

                                         End Sub
        AddHandler paymentWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)


                                                         With ComboBox8
                                                             .DisplayMember = "PaymentOrder.OrderID"
                                                             .ValueMember = "OrderID"
                                                             .DataSource = paymentOrders

                                                         End With
                                                         With ComboBox3
                                                             .DisplayMember = "PaymentOrder.PurchaseOrderID"
                                                             .ValueMember = "PurchaseOrderID"
                                                             .DataSource = paymentOrders

                                                         End With
                                                         TextBox20.DataBindings.Add("Text", paymentOrders, "PaymentOrder.OrderID")

                                                     End Sub
        Dim productDataSet As DataSet
        Dim productWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler productWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                             productDataSet = GetAllProducts()
                                         End Sub
        AddHandler productWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
                                                         With ComboBox11
                                                             .DisplayMember = "Tariffs.ProductCode"
                                                             .ValueMember = "id"
                                                             .AutoCompleteMode = AutoCompleteMode.Suggest
                                                             .AutoCompleteSource = AutoCompleteSource.ListItems
                                                             .SelectedIndex = -1
                                                             .DataSource = productDataSet

                                                         End With
                                                         TextBox7.DataBindings.Add("Text", productDataSet, "Tariffs.ID")
                                                         TextBox19.DataBindings.Add("Text", productDataSet, "Tariffs.Quantity")
                                                         TextBox22.DataBindings.Add("Text", productDataSet, "Tariffs.Category")
                                                     End Sub

        Dim paymentPurposeDataSet As DataSet
        Dim paymentPurposeWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler paymentPurposeWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                                    paymentPurposeDataSet = GetPaymentPurposes()
                                                End Sub
        AddHandler paymentPurposeWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
                                                                With ComboBox9
                                                                    .DisplayMember = "PaymentPurpose.PaymentPurpose"
                                                                    .ValueMember = "PaymentPurpose"
                                                                    .AutoCompleteMode = AutoCompleteMode.Suggest
                                                                    .AutoCompleteSource = AutoCompleteSource.ListItems
                                                                    .SelectedIndex = -1
                                                                    .DataSource = paymentPurposeDataSet

                                                                End With

                                                            End Sub
        Dim paymentTypeSet As DataSet
        Dim paymentTypeWorker As New BackgroundWorker With {
    .WorkerReportsProgress = False, ' No need for progress reporting if not used
    .WorkerSupportsCancellation = True
    }
        AddHandler paymentTypeWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
                                                 paymentTypeSet = GetPaymentTypes()
                                             End Sub
        AddHandler paymentTypeWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
                                                             With ComboBox10
                                                                 .DisplayMember = "PaymentType.PaymentType"
                                                                 .ValueMember = "PaymentType"
                                                                 .AutoCompleteMode = AutoCompleteMode.Suggest
                                                                 .AutoCompleteSource = AutoCompleteSource.ListItems
                                                                 .DataSource = paymentTypeSet

                                                             End With
                                                         End Sub

        customerWorker.RunWorkerAsync()
        worker.RunWorkerAsync()
        employesWorker.RunWorkerAsync()
        paymentWorker.RunWorkerAsync()
        productWorker.RunWorkerAsync()
        paymentPurposeWorker.RunWorkerAsync()
        paymentTypeWorker.RunWorkerAsync()

    End Sub
    Sub allorders()
        Dim ds As New DataSet
        Dim ordid As New SqlCommand
        Dim da As New SqlDataAdapter
        ordid = conn.CreateCommand
        'ordid.CommandText = "select * from FreezAvialable where customerID = '" & ComboBox7.SelectedValue & " ' "
        ordid.CommandText = "select orderid,ProductName,orderdate,enddate,startdate,reorderdate from OrderTp where customerID =  '" & ComboBox7.SelectedValue & " '"
        da.Fill(ds, "Ord")
        '  DataGrid6.DataSource = ds.Tables("Ord")
        With ComboBox20
            .DisplayMember = "Ord.OrderID"
            .ValueMember = "OrderID"
            .DataSource = ds
        End With


    End Sub
    Private Sub Datagrid4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid4.DoubleClick

        refreshPlan()


    End Sub

    Private Sub Refresh_Form()
        ' Dim con As SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmdDep As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim da1 As New SqlDataAdapter
        Dim daDep As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable

        ComboBox7.Refresh()
        'this part to call data from database and show in datagrid
        ' con = GetConnect()
        ReadyConnectionF()

        Try

            cmd1 = conn.CreateCommand
            cmd1.CommandText = "select * from Planned where CustomerID = '" & ComboBox7.SelectedValue & " ' "

            da1.SelectCommand = cmd1
            da1.Fill(ds, "PaymentOrder")
            '  DataGrid1.DataSource = ds.Tables("PaymentOrder")
            '   DataGrid1.DataMember = "PaymentOrder"
            ' DataGrid1.Refresh()

            cmd = conn.CreateCommand
            ' cmd.CommandText = "select * from [Purchase Order Details] where CustomerID = '" & ComboBox7.SelectedValue & " ' "
            cmd.CommandText = "select * from PaymentsMF where CustomerID = '" & ComboBox7.SelectedValue & " ' "
            da.SelectCommand = cmd
            da.Fill(ds, "Purchase Order Details")
            DataGrid2.DataSource = ds.Tables("Purchase Order Details")
            ' DataGrid2.DataSource = ds
            ' DataGrid2.DataMember = "Purchase Order Details"
            DataGrid2.Refresh()

            Dim strID As String

            strID = "select * from OrdDate where customerID =  '" & ComboBox7.SelectedValue & " '"
            adapter = New SqlDataAdapter(strID, Connection)
            adapter.Fill(ds, "OrdDate")
            With ComboBox20
                .DisplayMember = "OrdDate.OrderID"
                .ValueMember = "OrderID"
                .DataSource = ds


            End With




            cmd2 = conn.CreateCommand
            cmd2.CommandText = "select * from PlanDebt where CustomerID = '" & ComboBox7.SelectedValue & " ' "
            da.SelectCommand = cmd2
            da.Fill(ds, "PlanDebt")
            '  DataGrid4.DataSource = ds.Tables("PlanDebt")
            Dim dv As DataView
            dv = New DataView(ds.Tables("PlanDebt"))
            DataGrid4.DataSource = dv
            ' ACFCS3(Me.DataGrid4, New FCEH3(AddressOf FGC5))

            DataGrid4.Refresh()



        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try

    End Sub

    Private Sub FillListView()

        Dim ordid As New SqlCommand
        Dim fr As New SqlDataAdapter
        '  con = GetConnect()
        ReadyConnectionF()

        Try
            ordid = conn.CreateCommand()
            ordid.CommandText = "select orderid,ProductName,orderdate,enddate,reorderdate from OrderTp where customerID =  '" & ComboBox7.SelectedValue & " '"
            fr.SelectCommand = ordid
            fr.Fill(ds, "Ord")
            '  DataGrid6.DataSource = ds.Tables("Ord")


        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
    End Sub





    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.BindingContextChanged
        ' Refresh_Form()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Refresh_Form()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Refresh_Form()
    End Sub

    Sub proverka()


        If TextBox22.Text = "Freezing" Then
            If MsgBox("Pay for freezing?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                freez()
            End If


        End If


        '  Else





        If TextBox3.Text = 0 And ComboBox9.Text <> "BONUS" And ComboBox9.Text <> "Additional" Then
            MsgBox("Paid sum is null!", MsgBoxStyle.OkOnly, "Info Save Payment")
            TextBox3.Focus()
            Exit Sub
        End If

        If ComboBox11.Text = "" And TextBox16.Text = "" Then
            MsgBox("Payment Basic!", MsgBoxStyle.OkOnly, "Info Save Payment")
            ComboBox11.Focus()
            Exit Sub

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '   proverkaFreezLimit()

        addpayment()
    End Sub

    Sub addpayment()
        Dim j As Integer = ComboBox20.SelectedIndex
        Dim orderId = Label27.Text
        proverka()
        ReadyConnectionF()
        proverkaPOdublicate()
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()

        cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
        ' conn.Open()

        Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
        Dim idDetID As Integer
        If IsDBNull(sqlResult1) Then

            idDetID = 1

        Else
            sqlResult1.ToString()
            idDetID = ExecuteScalar(cmdPoDetID)

            idDetID = idDetID + 1
        End If
        ' conn.Close()
        If MsgBox("Are you sure to save Payment   ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else


            Dim CMD As New SqlCommand("InsertPayment")
            ' CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID


            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = TextBox3.Text
            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTimePicker1.Value 'na forme
            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = ComboBox10.Text

            '  If CheckBox1.Checked = False Then
            If TextBox16.Text <> "" Then
                CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = TextBox16.Text
                '  

            Else
                CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = ComboBox11.Text
                ' MsgBox("Save Payment without POID for Client With Id " & Trim(TextBox2.Text) & " OK", MsgBoxStyle.OKOnly, "Info Save Payment")
            End If


            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = ComboBox9.Text
            CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = TextBox11.Text
            CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = TextBox4.Text
            CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0 'TextBox6.Text 'coach
            CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox7.Text

            CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox2.Text


            If TextBox10.Text <> "" Then
                CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = TextBox10.Text
            Else
                CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0
            End If
            CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = TextBox12.Text
            CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTimePicker2.Value ' na forme naoborot recieveddate t.k. sort 
            CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
            CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value
            CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = Int(TextBox17.Text)

            CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = Val(TextBox19.Text)

            CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = Val(TextBox18.Text)
            CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"


            CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = orderId

            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = TextBox23.Text


            ExecuteProcedur.ExecuteCMD(CMD)
            ' MsgBox("Payment with Id " & Trim(TextBox5.Text) & " complete", MsgBoxStyle.OKOnly, "Message :")
            Dim custID As Integer = Int(TextBox2.Text)
            Dim st As String
            Dim oper As String
            oper = "mf payment  " & custID
            st = lblUser.Text
            LogFunc(st, oper)
        End If

        '  ReadyConnectionF()
        Dim sql As String = "select * from [Purchase Order Details] where CustomerID = '" & TextBox2.Text & " ' "

        ' conn.Open()
        'adapter = New SqlDataAdapter(sql, conn)
        'adapter.Fill(ds, "Purchase Order Details")

        '' conn.Close()
        'DataGrid2.DataSource = ds.Tables("Purchase Order Details")

        'DataGrid4.Refresh()
        Refresh_Form()
        DataGrid2.Refresh()
        TextBox5.Text = idDetID + 1
        TextBox3.Text = 0
        TextBox10.Text = 0
        ' TextBox20.Text = 0
        ComboBox20.SelectedIndex = j
    End Sub





    Sub proverkaPOdublicate()

        Dim cmd1 As New SqlCommand
        Dim check1 As Integer
        ReadyConnectionF()
        ' connection = GetConnect()

        Try
            ' conn.Open()
            cmd1 = conn.CreateCommand
            cmd1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = Int(TextBox10.Text)
            cmd1.CommandText = "select ID from [Purchase Order Details] where PurchaseOrderID = @ID"


            Dim sqlResult1 As Object = cmd1.ExecuteScalar()

            If sqlResult1 Is Nothing Then
                ' If Not IsDBNull(sqlResult1) Then

            Else

                sqlResult1.ToString()

                check1 = cmd1.ExecuteScalar
                If check1 > 0 And Val(TextBox10.Text) > 0 Then
                    MsgBox("Purchase order have dublicate", MsgBoxStyle.OkCancel, "Message :")

                End If

                TextBox10.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
        ' conn.Close()
    End Sub

    Sub AddDepPayment()
        proverka()
        '  freez()
        proverkaPOdublicate()
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()

        cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
        conn.Open()

        Dim sqlResult1 As Object = cmdPoDetID.ExecuteScalar()
        Dim idDetID As Integer
        If IsDBNull(sqlResult1) Then

            idDetID = 1

        Else
            sqlResult1.ToString()
            idDetID = cmdPoDetID.ExecuteScalar
            conn.Close()
            idDetID = idDetID + 1
        End If

        If MsgBox("Are you sure to save Payment  with Id : " & TextBox5.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else


            Dim CMD As New SqlCommand("InsertPayment")
            ' CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID


            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = Label30.Text
            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTimePicker1.Value 'na forme
            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = ComboBox10.Text

            '  If CheckBox1.Checked = False Then
            If TextBox16.Text <> "" Then
                CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = TextBox16.Text
                '  

            Else
                CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = ComboBox11.Text
                ' MsgBox("Save Payment without POID for Client With Id " & Trim(TextBox2.Text) & " OK", MsgBoxStyle.OKOnly, "Info Save Payment")
            End If


            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = ComboBox9.Text
            CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = TextBox11.Text
            CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = TextBox4.Text
            CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = TextBox6.Text 'coach
            CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox7.Text

            CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox2.Text


            If TextBox10.Text <> "" Then
                CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = TextBox10.Text
            Else
                CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0
            End If
            CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = TextBox12.Text
            CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTimePicker2.Value ' na forme naoborot recieveddate t.k. sort 
            CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
            CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value
            CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = Int(TextBox17.Text)

            CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = Val(TextBox19.Text)

            CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = Val(TextBox18.Text)
            CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"

            If ComboBox20.Text <> "" Then
                CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
            Else
                CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
            End If
            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = TextBox23.Text


            ExecuteProcedur.ExecuteCMD(CMD)
            ' MsgBox("Payment with Id " & Trim(TextBox5.Text) & " complete", MsgBoxStyle.OKOnly, "Message :")
        End If


        Dim sql As String = "select * from [Purchase Order Details] where CustomerID = '" & TextBox2.Text & " ' "

        '  conn.Open()
        adapter = New SqlDataAdapter(sql, Connection)
        adapter.Fill(ds, "Purchase Order Details")

        ' conn.Close()
        DataGrid2.DataSource = ds.Tables("Purchase Order Details")

        DataGrid4.Refresh()
        Refresh_Form()
        DataGrid2.Refresh()
        TextBox5.Text = TextBox5.Text + 1
        TextBox3.Text = 0
        TextBox10.Text = 0
    End Sub

    Sub payFromDeposit()
        proverkaPOdublicate()
        Dim pay As Integer
        '  freez()
        Dim check1 As Integer

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand


        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select DepositAmount from Deposit  " &
            "where CustomerID = '" & TextBox2.Text & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Then
            MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
            Exit Sub
        Else
            sqlResult1.ToString()

            check1 = ExecuteScalar(cmd1) 'deposit sum 


        End If


        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()

        cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
        Dim idDetID As Integer = ExecuteScalar(cmdPoDetID)
        idDetID = idDetID + 1

        '+++++++++++++++++++++
        Dim payment As Integer = Int(TextBox3.Text) 'amount to be pay
        If MsgBox("Are you sure to paid   from deposit? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            Dim cmdDepID As SqlCommand
            cmdDepID = conn.CreateCommand()
            If check1 - payment >= 0 Then
                cmdDepID.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = check1 - payment
                pay = payment
            Else

                cmdDepID.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = check1 - check1
                pay = check1
            End If
            Label30.Text = pay

            cmdDepID.Parameters.Add("@ID", Data.SqlDbType.Int).Value = Int(TextBox2.Text)
            cmdDepID.CommandText = "Update Deposit set DepositAmount = @Amount  where CustomerID = @ID " ' COALESCE(NULLIF(@Amount,-1),Amount)+@Amount  where ID = @ID "
            ' End If
            ExecuteReader(cmdDepID)


            AddDepPayment()

        End If

        Refresh_Form()
        TextBox20.Text = 0
    End Sub
    Sub freez()


        Dim cmd2 As New SqlCommand
        Dim checkPaid As Integer

        Dim ordID As Integer


        ordID = Int(ComboBox20.Text)


        Dim cmd1 As New SqlCommand
        cmd1 = conn.CreateCommand

        cmd1.CommandText = "select AvialableForBuying from FreezAviability where OrderID =  '" & ordID & "'"

        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or IsNothing(sqlResult1) Then
            '  checkPaid = 0
        Else

            checkPaid = ExecuteScalar(cmd1)
            '++++++++++++++++++++++++++++++

            If checkPaid >= Val(TextBox19.Text) Then

                '+++++++++++++++++++ if avialable days OK then find id in freezpaiddays table





                newPaidFreez()
            Else
                MsgBox("Freez OverLimit!", MsgBoxStyle.OkOnly, "Info Save Payment")



            End If
        End If




        Refresh_Form()



    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim check As Integer
        Dim cmd As New SqlCommand
        Dim PurID As Integer
        PurID = DataGrid2(DataGrid2.CurrentRowIndex, 0)


        If PurID <> 0 Then
            If MsgBox("Are you sure to delete data with Id : " & PurID & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else
                ' connection = GetConnect()
                ReadyConnectionF()

                Try
                    ' conn.Open()
                    cmd = conn.CreateCommand
                    cmd.CommandText = "DELETE FROM [Purchase Order Details] WHERE ID ='" & PurID & "'"
                    check = cmd.ExecuteReader.RecordsAffected
                    If check > 0 Then
                        MsgBox("Payment With Id " & PurID & " Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete")
                        Dim custID As Integer = Int(TextBox2.Text)
                        Dim st As String
                        Dim oper As String
                        oper = "mf delete  " & custID
                        st = lblUser.Text
                        LogFunc(st, oper)
                    Else
                        MsgBox("Payment With Id " & PurID & " Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete")
                    End If
                    ' conn.Close()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                End Try
            End If
        End If
        Refresh_Form()
    End Sub



    'Sub payWithdrowal()

    '    ' DateTimePicker3.Format = DateTimePickerFormat.Short
    '    If MsgBox("Are you sure to save Return Payment  with Id : " & TextBox9.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
    '        Exit Sub
    '    Else
    '        ' Dim connetionString As String = frmSqlConn.BuildSqlNativeConnStr(server, database, username, password)
    '        ' Connection = New SqlConnection(connetionString)
    '        ReadyConnectionF()
    '        Dim CMDr As New SqlCommand("InsertWithdrawal")
    '        CMDr.Parameters.Add("@ID", Data.SqlDbType.Int).Value = TextBox9.Text

    '        CMDr.Parameters.Add("@ReturnDate", Data.SqlDbType.DateTime).Value = DateTimePicker1.Value 'Payment Date
    '        CMDr.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = TextBox3.Text

    '        CMDr.Parameters.Add("@ReturnBase", Data.SqlDbType.NChar).Value = ComboBox9.Text 'payment purpose
    '        CMDr.Parameters.Add("@ReturnType", Data.SqlDbType.NChar).Value = ComboBox10.Text
    '        If CheckBox2.Checked = False Then
    '            CMDr.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox2.Text
    '        Else
    '            CMDr.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = "0"
    '        End If
    '        CMDr.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = TextBox12.Text
    '        CMDr.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = TextBox4.Text


    '        ExecuteProcedur.ExecuteCMD(CMDr)

    '        MsgBox("Payment with Id " & Trim(TextBox9.Text) & " complete", MsgBoxStyle.OkOnly, "Message :")
    '    End If
    '    ' Refresh_Form()
    '    '  RefreshWithdrawal_Form()
    '    TextBox9.Text = TextBox9.Text + 1
    'End Sub





    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        Refresh_Form()
    End Sub



    Sub proverkaFreezLimit()

        '  If ComboBox9.Text = "Additional" And ComboBox11.Text = "Freezing" Then
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim checkPaid As Integer
        Dim checkFree As Integer
        Dim ordID As Integer

        Dim sumfreez As Integer

        ReadyConnectionF()
        ' Connection = GetConnect()

        Try


            '   conn.Open()
            cmd1 = conn.CreateCommand

            cmd1.CommandText = "select Quantity from FreezPaid where OrderID =  '" & ordID & "'"

            Dim sqlResult1 As Object = cmd1.ExecuteScalar()
            If IsDBNull(sqlResult1) Or IsNothing(sqlResult1) Then
                checkPaid = 0
            Else
                sqlResult1.ToString()

                checkPaid = cmd1.ExecuteScalar

            End If
            conn.Close()



            conn.Open()
            cmd2 = conn.CreateCommand
            '  cmd1.Parameters.Add("@orderID", Data.SqlDbType.Int).Value = Int(TextBox20.Text)
            cmd2.CommandText = "select Quantity from FreezFree where OrderID =  '" & ordID & "'"

            Dim sqlResult2 As Object = cmd2.ExecuteScalar()
            If IsDBNull(sqlResult2) Or IsNothing(sqlResult2) Then
                checkFree = 0
            Else
                sqlResult2.ToString()

                checkFree = cmd2.ExecuteScalar

            End If
            '  conn.Close()

            sumfreez = checkPaid + checkFree


            If (120 - sumfreez) > Val(TextBox19.Text) Then

                If MsgBox("Are you sure to save Payment  with Id : " & TextBox5.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then


                Else
                    ordID = Int(TextBox20.Text)
                    conn.Open()
                    Dim cmdPoDetID As SqlCommand
                    cmdPoDetID = conn.CreateCommand()
                    ' conn.Open()
                    cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
                    '  conn.Close()
                    Dim idDetID As Integer = cmdPoDetID.ExecuteScalar
                    conn.Close()
                    idDetID = idDetID + 1

                    Dim CMD As New SqlCommand("InsertPayment")

                    CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID


                    CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = TextBox3.Text
                    CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTimePicker1.Value 'na forme
                    CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = ComboBox10.Text

                    '  If CheckBox1.Checked = False Then
                    If TextBox16.Text <> "" Then
                        CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = TextBox16.Text
                        '  

                    Else
                        CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = ComboBox11.Text
                        ' MsgBox("Save Payment without POID for Client With Id " & Trim(TextBox2.Text) & " OK", MsgBoxStyle.OKOnly, "Info Save Payment")
                    End If

                    ' CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = ComboBox11.Text
                    CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = ComboBox9.Text
                    CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = TextBox11.Text
                    CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = TextBox4.Text
                    CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = TextBox6.Text 'coach
                    CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox7.Text
                    '  CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox2.Text

                    ' If CheckBox2.Checked = False Then
                    CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox2.Text
                    '  Else
                    ' CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = 0
                    ' End If


                    If TextBox10.Text <> "" Then
                        CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = TextBox10.Text
                        '  MsgBox("Payment for Client With Id " & Trim(TextBox2.Text) & " ", MsgBoxStyle.OKOnly, "Info Save Payment")

                    Else
                        CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0
                        ' MsgBox("Save Payment without POID for Client With Id " & Trim(TextBox2.Text) & " OK", MsgBoxStyle.OKOnly, "Info Save Payment")
                    End If
                    CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = TextBox12.Text
                    CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTimePicker2.Value ' na forme naoborot recieveddate t.k. sort 
                    CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
                    CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value
                    CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = Int(TextBox17.Text)
                    CMD.Parameters.Add("@Quantity ", Data.SqlDbType.NChar).Value = TextBox19.Text
                    CMD.Parameters.Add("@Discount ", Data.SqlDbType.NChar).Value = TextBox18.Text
                    CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"
                    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox20.Text

                    ExecuteProcedur.ExecuteCMD(CMD)
                    ' MsgBox("Payment with Id " & Trim(TextBox5.Text) & " complete", MsgBoxStyle.OKOnly, "Message :")

                End If

            Else
                MsgBox("Avialable  " & (120 - sumfreez) & " freezing days", MsgBoxStyle.OkCancel, "Message :")
                ' MsgBox(check1 & " paided with this PO", MsgBoxStyle.OKOnly, "Message :")
                '   End If
                TextBox19.Focus()
                Exit Sub
            End If
            '  End If


        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
        '  End If
        '   conn.Close()
    End Sub



    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox19.Enabled = False
            ComboBox15.Enabled = False
            ComboBox16.Enabled = False
        Else
            ComboBox19.Enabled = True
            ComboBox15.Enabled = True
            ComboBox16.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim check As Integer
        Dim cmd As New SqlCommand
        Dim PurID As Integer
        PurID = DataGrid3(DataGrid3.CurrentRowIndex, 0)


        If PurID <> 0 Then
            If MsgBox("Are you sure to delete data with Id : " & PurID & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else
                'connection = GetConnect()
                ReadyConnectionF()

                Try
                    'conn.Open()
                    cmd = conn.CreateCommand
                    cmd.CommandText = "DELETE FROM Withdrawal WHERE ID ='" & PurID & "'"
                    check = cmd.ExecuteReader.RecordsAffected
                    If check > 0 Then
                        MsgBox("Payment With Id " & PurID & " Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
                    Else
                        MsgBox("Payment With Id " & PurID & " Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
                    End If
                    ' conn.Close()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                End Try
            End If
        End If
        'RefreshWithdrawal_Form()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        ' RefreshWithdrawal_Form()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox2.Checked = True Then
            '  ComboBox14.Enabled = False
            ComboBox14.Text = "00"
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        Else
            ComboBox14.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        Refresh_Form()

    End Sub
    Sub refreshPlan()
        Dim poid As Integer
        If DataGrid4.CurrentRowIndex + 1 > 0 And DataGrid4(DataGrid4.CurrentRowIndex, 4).ToString IsNot "" Then
            poid = DataGrid4(DataGrid4.CurrentRowIndex, 4) 'plandebt
        End If
        Dim Str As String = "select * from PlanDebt where CustomerID = '" & ComboBox7.SelectedValue & " ' and POID='" & poid & " '"

        Dim cmd2 As SqlCommand = New SqlCommand(Str, conn)


        Dim dr As SqlDataReader = ExecuteReader(cmd2)

        If dr.Read Then
            If Not IsDBNull(dr("Debt")) Then
                TextBox3.Text = (dr("Debt"))  'amount
            Else

                If Not IsDBNull(dr("Planned Payment")) Then
                    TextBox3.Text = (dr("Planned Payment"))  'amount
                End If
            End If
            If Not IsDBNull(dr(0)) Then
                DateTimePicker2.Value = dr(0) '
            End If
            If Not IsDBNull(dr("POID")) Then
                TextBox10.Text = dr("POID") 'porderid
            End If
            If Not IsDBNull(dr("ProductID")) Then
                TextBox7.Text = dr("ProductID") 'ProductID
            End If
            If Not IsDBNull(dr("PaymentBasic")) Then
                ComboBox11.Text = dr("PaymentBasic") 'tp
            End If
            If Not IsDBNull(dr("OrderID")) Then
                TextBox20.Text = dr("OrderID")
            End If
            If Not IsDBNull(dr("UnitPrice")) Then
                TextBox17.Text = dr("UnitPrice") 'ProductID
            End If
        End If
    End Sub

    Private Sub DataGrid4_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid4.Click
        refreshPlan()
    End Sub


    Sub EditPlan()
        Dim check, poid, orderid As Integer
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cc As Integer = DataGrid4.VisibleRowCount()
        Dim plandate, PlannedPayment



        If DataGrid4.CurrentRowIndex + 1 > 0 Then 'And DataGrid4(DataGrid4.CurrentRowIndex, 8) = DataGrid4(DataGrid4.CurrentRowIndex + 1, 8) Then
            Dim j = DataGrid4.CurrentRowIndex
            ' poid = DataGrid4(DataGrid4.CurrentRowIndex, 4)
            ' plpayment = DataGrid4(DataGrid4.CurrentRowIndex, 1)
            orderid = DataGrid4.Item("orderid", j).ToString()
            ' orderid = DataGrid4(DataGrid4.CurrentRowIndex, 8)
            plandate = DataGrid4.Item("Planned Date", j).ToString
            PlannedPayment = DataGrid4.Item("Planned Payment", j).ToString
            poid = DataGrid4.Item("POID", j).ToString
            ' poidNext = DataGrid4(DataGrid4.CurrentRowIndex + 1, 4)

            '  End If
            If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else


                cmd = conn.CreateCommand

                If MsgBox("All data for current client will be updated!!!", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
                    ' do nothing
                    '++++++proverka

                    '+++++++++++++
                Else

                    'If slote = 1 Then
                    '    MsgBox("One Off payment! Can't edit", MsgBoxStyle.OkOnly, "Info")
                    '    Exit Sub
                    'End If

                    '  cmd.Parameters.Add("@ExpectedDate", Data.SqlDbType.DateTime).Value = Format("Short", DateTimePicker2.Value)

                    cmd.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = PlannedPayment ' TextBox3.Text

                    cmd.CommandText = "Update [Purchase Orders] set PaymentAmount=@PaymentAmount" &
                                           ",Status = 'edited',[Planned Date]=Convert(date, '" & plandate & " ', 103) where PurchaseOrderID = '" & poid & "'"
                End If
                ' conn.Close()
                ExecuteNonQuery(cmd)



                check = ExecuteReader(cmd).RecordsAffected



                If check > 0 Then

                    MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
                Else
                    MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
                End If
            End If
            '  End If


        End If
        ' End If

        Refresh_Form()
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        'TextBox3.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        '  TextBox19.Text = 0

        If ComboBox9.Text = "Additional" Then

            DateTimePicker4.Enabled = True
            DateTimePicker5.Enabled = True
            TextBox17.Enabled = True

            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox10.Text = 0
        Else
            DateTimePicker4.Enabled = False
            DateTimePicker5.Enabled = False
            TextBox17.Enabled = False

            TextBox18.Enabled = False
            TextBox19.Enabled = False
        End If
    End Sub



    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        On Error Resume Next
        If ComboBox9.Text = "Additional" Then
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text = 0 Then
                TextBox3.Text = Math.Round(TextBox17.Text * TextBox19.Text, 0)
            End If
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text > 0 Then
                TextBox3.Text = Math.Round(Int(TextBox17.Text) * Int(TextBox19.Text) - (Int(TextBox17.Text) * Int(TextBox19.Text)) * (Int(TextBox18.Text) / 100), 0)
            End If
        End If
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        On Error Resume Next
        If ComboBox9.Text = "Additional" Then
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text = 0 Then
                TextBox3.Text = Math.Round(TextBox17.Text * TextBox19.Text, 0)
            End If
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text > 0 Then
                TextBox3.Text = Math.Round(Int(TextBox17.Text) * Int(TextBox19.Text) - (Int(TextBox17.Text) * Int(TextBox19.Text)) * (Int(TextBox18.Text) / 100), 0)
            End If
        End If
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        On Error Resume Next
        If ComboBox9.Text = "Additional" Then
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text = 0 Then
                TextBox3.Text = Math.Round(TextBox17.Text * TextBox19.Text, 0)
            End If
            If TextBox17.Text <> "" And TextBox19.Text <> "" And TextBox18.Text > 0 Then
                TextBox3.Text = Math.Round(Int(TextBox17.Text) * Int(TextBox19.Text) - (Int(TextBox17.Text) * Int(TextBox19.Text)) * (Int(TextBox18.Text) / 100), 0)
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim check, poid As Integer
        Dim cmd As New SqlCommand

        If DataGrid2.CurrentRowIndex + 1 > 0 Then
            poid = DataGrid2(DataGrid2.CurrentRowIndex, 0) 'PaymentsMF[Purchase Order Details]


            If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else
                ReadyConnectionF()


                Try


                    cmd = conn.CreateCommand
                    If MsgBox("Payment will be updated!!!", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
                        ' do nothing
                        '++++++proverka

                        '+++++++++++++
                    Else





                        cmd.Parameters.Add("@Amount", Data.SqlDbType.Decimal).Value = DataGrid2(DataGrid2.CurrentRowIndex, 1) 'TextBox3.Text
                        cmd.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = DataGrid2(DataGrid2.CurrentRowIndex, 3)

                        cmd.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = DataGrid2(DataGrid2.CurrentRowIndex, 5)

                        cmd.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = DataGrid2(DataGrid2.CurrentRowIndex, 6)
                        cmd.Parameters.Add("@planid", Data.SqlDbType.Int).Value = DataGrid2(DataGrid2.CurrentRowIndex, 8)
                        cmd.Parameters.Add("@orderid", Data.SqlDbType.Int).Value = DataGrid2(DataGrid2.CurrentRowIndex, 16)
                        cmd.CommandText = "Update [Purchase Order Details] set Amount = @Amount,PaymentMethode=@PaymentMethode,PaymentPurpose=@PaymentPurpose,Notes=@Notes,PurchaseOrderId=@planid,orderid=@orderid  where ID = '" & poid & "'"


                        check = cmd.ExecuteReader.RecordsAffected
                        If check > 0 Then

                            MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Update")
                            Dim custID As Integer = Int(TextBox2.Text)
                            Dim st As String
                            Dim oper As String
                            oper = "mf edit  " & custID
                            st = lblUser.Text
                            LogFunc(st, oper)
                        Else
                            MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Update")
                        End If
                    End If


                Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
                End Try
            End If
        End If

        Refresh_Form()
    End Sub


    Sub edit_payment()
        Dim check, poid, po As Integer
        Dim POstatus As String
        Dim cmd As New SqlCommand
        Dim amount As Decimal
        newDepositAccount()
        If DataGrid2.CurrentRowIndex + 1 > 0 Then
            poid = DataGrid2(DataGrid2.CurrentRowIndex, 0) 'Purchase Order Details id
            po = DataGrid2(DataGrid2.CurrentRowIndex, 8) 'PurchaseOrderID
            amount = DataGrid2(DataGrid2.CurrentRowIndex, 1)
            POstatus = DataGrid2(DataGrid2.CurrentRowIndex, 15)
        End If
        If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
            ' do nothing
        Else

            cmd = conn.CreateCommand

            cmd.Parameters.Add("@Notes", Data.SqlDbType.NVarChar).Value = "Cancel " & DateTimePicker1.Value

            cmd.Parameters.Add("@POstatus", Data.SqlDbType.NChar).Value = "CANCELED"

            cmd.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.NChar).Value = poid & po

            cmd.CommandText = "Update [Purchase Order Details] set Notes = @Notes,POstatus=@POstatus,PurchaseOrderID = @PurchaseOrderID  where ID = '" & poid & "'" &
                "and POStatus<> 'CANCELED' "



            check = ExecuteReader(cmd).RecordsAffected


        End If








        Refresh_Form()
    End Sub

    Sub newDepositAccount()
        ReadyConnectionF()

        Try
            conn.Open()

            Dim cmdPoDetID As SqlCommand
            cmdPoDetID = conn.CreateCommand()
            cmdPoDetID.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = Int(ComboBox7.SelectedValue)
            cmdPoDetID.CommandText = "select CustomerID  from Deposit where CustomerID = @CustomerID"

            Dim idDetID As Object = cmdPoDetID.ExecuteScalar
            If idDetID Is Nothing Then


                Dim cmdDepID1 As New SqlClient.SqlCommand("InsertDeposit")
                cmdDepID1.Parameters.Add("@DepositAmount", Data.SqlDbType.Decimal).Value = 0
                cmdDepID1.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = Int(ComboBox7.SelectedValue)
                ExecuteProcedur.ExecuteCMD(cmdDepID1)
            End If
            '   conn.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try

    End Sub
    Sub newPaidFreez()

        Dim newIDstr As Integer
        Dim ordID As Integer
        ordID = Int(ComboBox20.Text)
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()
        cmdPoDetID.CommandText = "select ID  from FreezPaidDays where OrderID = '" & ordID & "' "
        'esli net paid za etoot order insert id for this order else update + new days 
        Dim sqlResult2 As Object = ExecuteScalar(cmdPoDetID)
        If IsDBNull(sqlResult2) Or IsNothing(sqlResult2) Then
            Dim newID As SqlCommand
            newID = conn.CreateCommand()
            newID.CommandText = "select Max(ID)  from FreezPaidDays"
            newIDstr = ExecuteScalar(newID)
            newIDstr = newIDstr + 1
            Dim CMD As New SqlCommand("FreezDaysPaid")
            '   CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = newIDstr
            CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = ordID
            CMD.Parameters.Add("@PaidFreezDays", Data.SqlDbType.Int).Value = Val(TextBox19.Text)
            ExecuteProcedur.ExecuteCMD(CMD)
        Else
            newIDstr = ExecuteScalar(cmdPoDetID)
            Dim freezPaid As SqlCommand
            freezPaid = conn.CreateCommand()
            freezPaid.Parameters.Add("@PaidFreezDays", Data.SqlDbType.Int).Value = Val(TextBox19.Text)
            freezPaid.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = ordID
            freezPaid.CommandText = "Update FreezPaidDays set PaidFreezDays = PaidFreezDays+@PaidFreezDays   where OrderID = @OrderID"
            ExecuteReader(freezPaid)
        End If
    End Sub


    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' payFromDeposit()
        freez()
    End Sub



    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        proverkaPOdublicate()
    End Sub








    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithDrowal.Click
        ' withdrowalID()
        '  payWithdrowal()

        DataGrid3.Visible = True

    End Sub


    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim check As Integer
        Dim cmd As New SqlCommand
        Dim PurID As Integer
        PurID = DataGrid3(DataGrid3.CurrentRowIndex, 8)


        If PurID <> 0 Then
            If MsgBox("Are you sure to delete data with Id : " & PurID & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else
                ReadyConnectionF()
                '  Connection = GetConnect()

                Try
                    '   conn.Open()
                    cmd = conn.CreateCommand
                    cmd.CommandText = "DELETE FROM Withdrawal WHERE ID ='" & PurID & "'"
                    check = cmd.ExecuteReader.RecordsAffected
                    If check > 0 Then
                        MsgBox("Payment With Id " & PurID & " Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
                    Else
                        MsgBox("Payment With Id " & PurID & " Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
                    End If
                    '    conn.Close()

                Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                End Try
            End If
        End If
        'RefreshWithdrawal_Form()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        editplandateSum()
    End Sub
    Sub editplandateSum()
        Dim check, poid, slote, plpayment, orderid As Integer ' newplanned, poidNext, plpaymentNext,
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand

        Dim paymentDte

        If DataGrid4.CurrentRowIndex + 1 >= 0 And DataGrid4(DataGrid4.CurrentRowIndex, 4).ToString IsNot "" Then 'Then 'And DataGrid4(DataGrid4.CurrentRowIndex, 8) = DataGrid4(DataGrid4.CurrentRowIndex + 1, 8) Then
            poid = DataGrid4(DataGrid4.CurrentRowIndex, 4)
            plpayment = DataGrid4(DataGrid4.CurrentRowIndex, 2)
            paymentDte = DataGrid4(DataGrid4.CurrentRowIndex, 0)
            '  plpaymentNext = DataGrid4(DataGrid4.CurrentRowIndex + 1, 1)
            slote = DataGrid4(DataGrid4.CurrentRowIndex, 11)
            orderid = DataGrid4(DataGrid4.CurrentRowIndex, 8)
            '  poidNext = DataGrid4(DataGrid4.CurrentRowIndex + 1, 4)

            If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else


                cmd = conn.CreateCommand




                cmd.Parameters.Add("@ExpectedDate", Data.SqlDbType.DateTime).Value = paymentDte 'DateTimePicker2.Value

                cmd.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = plpayment 'TextBox3.Text



                cmd.CommandText = "Update [Purchase Orders] set ExpectedDate = convert(datetime,@ExpectedDate,121),PaymentAmount=@PaymentAmount" &
                                       ",Status = 'edited' where PurchaseOrderID = '" & poid & "'"
                ' conn.Close()
                ExecuteNonQuery(cmd)



                check = ExecuteReader(cmd).RecordsAffected



                If check > 0 Then

                    MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
                Else
                    MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
                End If
            End If
            ' End If
        Else
            MsgBox("No row selected!", MsgBoxStyle.OkOnly, "Error")
        End If



        Refresh_Form()

    End Sub





    Private Sub DataGrid4_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGrid4.KeyUp
        refreshPlan()
    End Sub

    Private Sub DataGrid4_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGrid4.KeyDown
        refreshPlan()
    End Sub





    Private Sub DataGrid4_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGrid4.MouseClick
        refreshPlan()
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged
        Label27.Text = ComboBox20.Text
    End Sub

    Private Sub ComboBox20_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox20.KeyDown
        Label27.Text = ComboBox20.Text
    End Sub

    Private Sub ComboBox14_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedValueChanged

    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel
Imports System.Threading.Tasks

Public Class ReOrder
	Inherits Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call
	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			components?.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private ReadOnly components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents DataGrid1 As DataGrid
	Friend WithEvents DataView1 As DataView
	Friend WithEvents Button5 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Orders As TabControl
	Friend WithEvents TextBox24 As TextBox
	Friend WithEvents Label26 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents ComboBox8 As ComboBox
	Friend WithEvents Label13 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents DataGrid3 As DataGrid
	Friend WithEvents DataView2 As DataView
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox19 As TextBox
	Friend WithEvents TextBox17 As TextBox
	Friend WithEvents TextBox16 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label20 As Label
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox14 As TextBox
	Friend WithEvents TextBox13 As TextBox
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents TextBox8 As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ComboBox11 As ComboBox
	Friend WithEvents Label24 As Label
	Friend WithEvents ComboBox4 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Button6 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents TextBox18 As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Button7 As Button
	Friend WithEvents ComboBox6 As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Button8 As Button
	Friend WithEvents Label10 As Label
	Friend WithEvents DateTimePicker4 As DateTimePicker
	Friend WithEvents Button9 As Button
	Friend WithEvents Button10 As Button
	Friend WithEvents Button11 As Button
	Friend WithEvents Button13 As Button
	Friend WithEvents Button14 As Button
	Friend WithEvents Repayment As Button
	Friend WithEvents Button12 As Button
	Friend WithEvents Button15 As Button
	Friend WithEvents TextBox10 As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents ComboBox7 As ComboBox
	Friend WithEvents Button16 As Button
	Friend WithEvents Button17 As Button
	Friend WithEvents TextBox23 As TextBox
	Friend WithEvents ComboBox5 As ComboBox
	Friend WithEvents ComboBox9 As ComboBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents DataGrid9 As DataGrid
	Friend WithEvents DataGrid7 As DataGrid
	Friend WithEvents TextBox15 As TextBox
	Friend WithEvents TextBox11 As TextBox
	Friend WithEvents TextBox9 As TextBox
	Friend WithEvents TextBox21 As TextBox
	Friend WithEvents TextBox22 As TextBox
	Friend WithEvents Label22 As Label
	Friend WithEvents TextBox20 As TextBox
	Friend WithEvents Button4 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents DateTimePicker5 As DateTimePicker
	Friend WithEvents TextBox12 As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents ComboBox10 As ComboBox
	Friend WithEvents Button19 As Button
	Friend WithEvents TextBox25 As TextBox
	Friend WithEvents TextBox26 As TextBox
	Friend WithEvents TextBox27 As TextBox
	Friend WithEvents dgvOrders As DataGridView
	Friend WithEvents Button18 As Button
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		DataGrid1 = New DataGrid()
		DataView1 = New DataView()
		Button5 = New Button()
		Button3 = New Button()
		Orders = New TabControl()
		TabPage3 = New TabPage()
		dgvOrders = New DataGridView()
		DataGrid3 = New DataGrid()
		Label24 = New Label()
		TabPage2 = New TabPage()
		Button19 = New Button()
		DataGrid9 = New DataGrid()
		DataGrid7 = New DataGrid()
		Button7 = New Button()
		TextBox24 = New TextBox()
		Label26 = New Label()
		Label18 = New Label()
		ComboBox8 = New ComboBox()
		Label13 = New Label()
		TextBox2 = New TextBox()
		TextBox5 = New TextBox()
		Label16 = New Label()
		TextBox6 = New TextBox()
		Label2 = New Label()
		DataView2 = New DataView()
		Button2 = New Button()
		TextBox19 = New TextBox()
		TextBox17 = New TextBox()
		TextBox16 = New TextBox()
		Button1 = New Button()
		Label20 = New Label()
		ComboBox3 = New ComboBox()
		ComboBox2 = New ComboBox()
		Label1 = New Label()
		TextBox14 = New TextBox()
		TextBox13 = New TextBox()
		DateTimePicker2 = New DateTimePicker()
		TextBox8 = New TextBox()
		Label11 = New Label()
		Label6 = New Label()
		ComboBox1 = New ComboBox()
		ComboBox11 = New ComboBox()
		ComboBox4 = New ComboBox()
		Label3 = New Label()
		Button6 = New Button()
		TextBox1 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		Label4 = New Label()
		Label7 = New Label()
		TextBox7 = New TextBox()
		TextBox18 = New TextBox()
		Label8 = New Label()
		ComboBox6 = New ComboBox()
		Label9 = New Label()
		Button8 = New Button()
		Label10 = New Label()
		DateTimePicker4 = New DateTimePicker()
		Button9 = New Button()
		Button10 = New Button()
		Button11 = New Button()
		Button13 = New Button()
		Button14 = New Button()
		Repayment = New Button()
		Button12 = New Button()
		Button15 = New Button()
		TextBox10 = New TextBox()
		Label12 = New Label()
		ComboBox7 = New ComboBox()
		Button16 = New Button()
		Button17 = New Button()
		TextBox23 = New TextBox()
		ComboBox5 = New ComboBox()
		ComboBox9 = New ComboBox()
		CheckBox1 = New CheckBox()
		Button18 = New Button()
		TextBox15 = New TextBox()
		TextBox11 = New TextBox()
		TextBox9 = New TextBox()
		TextBox21 = New TextBox()
		TextBox22 = New TextBox()
		Label22 = New Label()
		TextBox20 = New TextBox()
		Button4 = New Button()
		Label5 = New Label()
		DateTimePicker1 = New DateTimePicker()
		Label14 = New Label()
		Label15 = New Label()
		DateTimePicker5 = New DateTimePicker()
		TextBox12 = New TextBox()
		Label17 = New Label()
		Label19 = New Label()
		ComboBox10 = New ComboBox()
		TextBox25 = New TextBox()
		TextBox26 = New TextBox()
		TextBox27 = New TextBox()
		CType(DataGrid1, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataView1, ComponentModel.ISupportInitialize).BeginInit()
		Orders.SuspendLayout()
		TabPage3.SuspendLayout()
		CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGrid3, ComponentModel.ISupportInitialize).BeginInit()
		TabPage2.SuspendLayout()
		CType(DataGrid9, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGrid7, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataView2, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		'
		'DataGrid1
		'
		DataGrid1.AlternatingBackColor = Color.White
		DataGrid1.BackColor = Color.White
		DataGrid1.BackgroundColor = Color.Gainsboro
		DataGrid1.BorderStyle = BorderStyle.FixedSingle
		DataGrid1.CaptionBackColor = Color.Silver
		DataGrid1.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.CaptionForeColor = Color.Black
		DataGrid1.DataMember = ""
		DataGrid1.FlatMode = True
		DataGrid1.Font = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.ForeColor = Color.DarkSlateGray
		DataGrid1.GridLineColor = Color.DarkGray
		DataGrid1.HeaderBackColor = Color.DarkGreen
		DataGrid1.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.HeaderForeColor = Color.White
		DataGrid1.LinkColor = Color.DarkGreen
		DataGrid1.Location = New Point(0, 568)
		DataGrid1.Name = "DataGrid1"
		DataGrid1.ParentRowsBackColor = Color.Gainsboro
		DataGrid1.ParentRowsForeColor = Color.Black
		DataGrid1.SelectionBackColor = Color.DarkSeaGreen
		DataGrid1.SelectionForeColor = Color.Black
		DataGrid1.Size = New Size(1224, 184)
		DataGrid1.TabIndex = 0
		'
		'Button5
		'
		Button5.BackColor = Color.Green
		Button5.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Button5.ForeColor = Color.White
		Button5.Location = New Point(824, 183)
		Button5.Name = "Button5"
		Button5.Size = New Size(136, 24)
		Button5.TabIndex = 218
		Button5.Text = "1.Delete Planned"
		Button5.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Button3.BackColor = SystemColors.ActiveBorder
		Button3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Button3.ForeColor = Color.Black
		Button3.Location = New Point(504, 240)
		Button3.Name = "Button3"
		Button3.Size = New Size(88, 24)
		Button3.TabIndex = 216
		Button3.Text = "ReOrder"
		Button3.UseVisualStyleBackColor = False
		Button3.Visible = False
		'
		'Orders
		'
		Orders.Controls.Add(TabPage3)
		Orders.Controls.Add(TabPage2)
		Orders.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Orders.ItemSize = New Size(61, 23)
		Orders.Location = New Point(16, 269)
		Orders.Name = "Orders"
		Orders.SelectedIndex = 0
		Orders.Size = New Size(1208, 480)
		Orders.TabIndex = 215
		'
		'TabPage3
		'
		TabPage3.Controls.Add(dgvOrders)
		TabPage3.Controls.Add(DataGrid3)
		TabPage3.Controls.Add(Label24)
		TabPage3.Location = New Point(4, 27)
		TabPage3.Name = "TabPage3"
		TabPage3.Size = New Size(1200, 449)
		TabPage3.TabIndex = 2
		TabPage3.Text = "Reorder Related Info"
		TabPage3.Visible = False
		'
		'dgvOrders
		'
		dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvOrders.Location = New Point(3, 3)
		dgvOrders.Name = "dgvOrders"
		dgvOrders.RowTemplate.Height = 24
		dgvOrders.Size = New Size(1183, 185)
		dgvOrders.TabIndex = 243
		'
		'DataGrid3
		'
		DataGrid3.AlternatingBackColor = Color.LightGray
		DataGrid3.BackColor = Color.DarkGray
		DataGrid3.CaptionBackColor = Color.White
		DataGrid3.CaptionFont = New Font("Microsoft Sans Serif", 8.25!)
		DataGrid3.CaptionForeColor = Color.Navy
		DataGrid3.DataMember = ""
		DataGrid3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		DataGrid3.ForeColor = Color.Black
		DataGrid3.GridLineColor = Color.Black
		DataGrid3.GridLineStyle = DataGridLineStyle.None
		DataGrid3.HeaderBackColor = Color.Silver
		DataGrid3.HeaderForeColor = Color.Black
		DataGrid3.LinkColor = Color.Navy
		DataGrid3.Location = New Point(3, 192)
		DataGrid3.Name = "DataGrid3"
		DataGrid3.ParentRowsBackColor = Color.White
		DataGrid3.ParentRowsForeColor = Color.Black
		DataGrid3.SelectionBackColor = Color.Navy
		DataGrid3.SelectionForeColor = Color.White
		DataGrid3.Size = New Size(724, 166)
		DataGrid3.TabIndex = 143
		'
		'Label24
		'
		Label24.BackColor = Color.FromArgb(224, 224, 224)
		Label24.Location = New Point(776, 80)
		Label24.Name = "Label24"
		Label24.Size = New Size(104, 16)
		Label24.TabIndex = 227
		'
		'TabPage2
		'
		TabPage2.Controls.Add(Button19)
		TabPage2.Controls.Add(DataGrid9)
		TabPage2.Controls.Add(DataGrid7)
		TabPage2.Location = New Point(4, 27)
		TabPage2.Name = "TabPage2"
		TabPage2.Size = New Size(1200, 449)
		TabPage2.TabIndex = 3
		TabPage2.Text = "Tools"
		'
		'Button19
		'
		Button19.Location = New Point(4, 13)
		Button19.Name = "Button19"
		Button19.Size = New Size(148, 23)
		Button19.TabIndex = 251
		Button19.Text = "Allow to Enabled"
		Button19.UseVisualStyleBackColor = True
		'
		'DataGrid9
		'
		DataGrid9.AlternatingBackColor = Color.White
		DataGrid9.BackColor = Color.White
		DataGrid9.BackgroundColor = Color.Gainsboro
		DataGrid9.BorderStyle = BorderStyle.FixedSingle
		DataGrid9.CaptionBackColor = Color.Silver
		DataGrid9.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid9.CaptionForeColor = Color.Black
		DataGrid9.DataMember = ""
		DataGrid9.FlatMode = True
		DataGrid9.Font = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid9.ForeColor = Color.DarkSlateGray
		DataGrid9.GridLineColor = Color.DarkGray
		DataGrid9.HeaderBackColor = Color.DarkGreen
		DataGrid9.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid9.HeaderForeColor = Color.White
		DataGrid9.LinkColor = Color.DarkGreen
		DataGrid9.Location = New Point(1008, 0)
		DataGrid9.Name = "DataGrid9"
		DataGrid9.ParentRowsBackColor = Color.Gainsboro
		DataGrid9.ParentRowsForeColor = Color.Black
		DataGrid9.SelectionBackColor = Color.DarkSeaGreen
		DataGrid9.SelectionForeColor = Color.Black
		DataGrid9.Size = New Size(192, 288)
		DataGrid9.TabIndex = 250
		DataGrid9.Visible = False
		'
		'DataGrid7
		'
		DataGrid7.AlternatingBackColor = Color.White
		DataGrid7.BackColor = Color.White
		DataGrid7.BackgroundColor = Color.Gainsboro
		DataGrid7.BorderStyle = BorderStyle.FixedSingle
		DataGrid7.CaptionBackColor = Color.Silver
		DataGrid7.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid7.CaptionForeColor = Color.Black
		DataGrid7.DataMember = ""
		DataGrid7.FlatMode = True
		DataGrid7.Font = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid7.ForeColor = Color.DarkSlateGray
		DataGrid7.GridLineColor = Color.DarkGray
		DataGrid7.HeaderBackColor = Color.DarkGreen
		DataGrid7.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid7.HeaderForeColor = Color.White
		DataGrid7.LinkColor = Color.DarkGreen
		DataGrid7.Location = New Point(26, 70)
		DataGrid7.Name = "DataGrid7"
		DataGrid7.ParentRowsBackColor = Color.Gainsboro
		DataGrid7.ParentRowsForeColor = Color.Black
		DataGrid7.SelectionBackColor = Color.DarkSeaGreen
		DataGrid7.SelectionForeColor = Color.Black
		DataGrid7.Size = New Size(288, 288)
		DataGrid7.TabIndex = 0
		DataGrid7.Visible = False
		'
		'Button7
		'
		Button7.FlatStyle = FlatStyle.System
		Button7.Location = New Point(128, 144)
		Button7.Name = "Button7"
		Button7.Size = New Size(120, 24)
		Button7.TabIndex = 248
		Button7.Text = "Update  End Date"
		Button7.Visible = False
		'
		'TextBox24
		'
		TextBox24.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox24.ForeColor = SystemColors.WindowText
		TextBox24.Location = New Point(248, 208)
		TextBox24.Name = "TextBox24"
		TextBox24.Size = New Size(56, 21)
		TextBox24.TabIndex = 139
		TextBox24.Visible = False
		'
		'Label26
		'
		Label26.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label26.ForeColor = Color.FromArgb(0, 64, 0)
		Label26.Location = New Point(235, 189)
		Label26.Name = "Label26"
		Label26.Size = New Size(88, 16)
		Label26.TabIndex = 140
		Label26.Text = "Product Price"
		Label26.Visible = False
		'
		'Label18
		'
		Label18.BackColor = Color.FromArgb(224, 224, 224)
		Label18.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label18.ForeColor = Color.FromArgb(0, 64, 0)
		Label18.Location = New Point(219, 230)
		Label18.Name = "Label18"
		Label18.Size = New Size(104, 16)
		Label18.TabIndex = 102
		Label18.Text = "Product Name"
		'
		'ComboBox8
		'
		ComboBox8.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox8.ForeColor = SystemColors.WindowText
		ComboBox8.ItemHeight = 13
		ComboBox8.Location = New Point(215, 254)
		ComboBox8.Name = "ComboBox8"
		ComboBox8.Size = New Size(144, 21)
		ComboBox8.TabIndex = 82
		ComboBox8.Text = "ComboBox8"
		'
		'Label13
		'
		Label13.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label13.ForeColor = Color.FromArgb(0, 64, 0)
		Label13.Location = New Point(179, 189)
		Label13.Name = "Label13"
		Label13.Size = New Size(56, 16)
		Label13.TabIndex = 94
		Label13.Text = "Quantity"
		Label13.Visible = False
		'
		'TextBox2
		'
		TextBox2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox2.ForeColor = SystemColors.WindowText
		TextBox2.Location = New Point(176, 208)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(64, 21)
		TextBox2.TabIndex = 90
		TextBox2.Text = "1"
		TextBox2.Visible = False
		'
		'TextBox5
		'
		TextBox5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox5.ForeColor = SystemColors.WindowText
		TextBox5.Location = New Point(376, 254)
		TextBox5.Name = "TextBox5"
		TextBox5.Size = New Size(64, 21)
		TextBox5.TabIndex = 93
		'
		'Label16
		'
		Label16.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label16.ForeColor = Color.FromArgb(0, 64, 0)
		Label16.Location = New Point(381, 232)
		Label16.Name = "Label16"
		Label16.Size = New Size(64, 16)
		Label16.TabIndex = 97
		Label16.Text = "Unit Cost"
		'
		'TextBox6
		'
		TextBox6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox6.ForeColor = SystemColors.WindowText
		TextBox6.Location = New Point(384, 208)
		TextBox6.Name = "TextBox6"
		TextBox6.Size = New Size(56, 21)
		TextBox6.TabIndex = 99
		TextBox6.Text = "0"
		TextBox6.Visible = False
		'
		'Label2
		'
		Label2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label2.ForeColor = Color.FromArgb(0, 64, 0)
		Label2.Location = New Point(395, 189)
		Label2.Name = "Label2"
		Label2.Size = New Size(56, 16)
		Label2.TabIndex = 100
		Label2.Text = "Discount"
		Label2.Visible = False
		'
		'Button2
		'
		Button2.BackColor = Color.Gray
		Button2.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Button2.ForeColor = Color.White
		Button2.Location = New Point(944, 232)
		Button2.Name = "Button2"
		Button2.Size = New Size(120, 24)
		Button2.TabIndex = 214
		Button2.Text = "Delete Product"
		Button2.UseVisualStyleBackColor = False
		Button2.Visible = False
		'
		'TextBox19
		'
		TextBox19.Enabled = False
		TextBox19.Location = New Point(808, 464)
		TextBox19.Name = "TextBox19"
		TextBox19.Size = New Size(56, 20)
		TextBox19.TabIndex = 213
		TextBox19.Text = "TextBox19"
		'
		'TextBox17
		'
		TextBox17.Enabled = False
		TextBox17.Location = New Point(672, 208)
		TextBox17.Name = "TextBox17"
		TextBox17.Size = New Size(32, 20)
		TextBox17.TabIndex = 212
		TextBox17.Text = "TextBox17"
		'
		'TextBox16
		'
		TextBox16.Enabled = False
		TextBox16.Location = New Point(808, 512)
		TextBox16.Name = "TextBox16"
		TextBox16.Size = New Size(64, 20)
		TextBox16.TabIndex = 211
		TextBox16.Text = "TextBox16"
		'
		'Button1
		'
		Button1.BackColor = Color.Gray
		Button1.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Button1.ForeColor = Color.White
		Button1.Location = New Point(824, 232)
		Button1.Name = "Button1"
		Button1.Size = New Size(120, 24)
		Button1.TabIndex = 210
		Button1.Text = "Add Product"
		Button1.UseVisualStyleBackColor = False
		Button1.Visible = False
		'
		'Label20
		'
		Label20.BackColor = Color.FromArgb(224, 224, 224)
		Label20.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label20.ForeColor = Color.Black
		Label20.Location = New Point(592, 51)
		Label20.Name = "Label20"
		Label20.Size = New Size(56, 16)
		Label20.TabIndex = 206
		Label20.Text = "Order ID"
		'
		'ComboBox3
		'
		ComboBox3.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox3.ForeColor = SystemColors.WindowText
		ComboBox3.Location = New Point(488, 48)
		ComboBox3.Name = "ComboBox3"
		ComboBox3.Size = New Size(96, 24)
		ComboBox3.TabIndex = 200
		ComboBox3.Text = "ComboBox3"
		'
		'ComboBox2
		'
		ComboBox2.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox2.ForeColor = SystemColors.WindowText
		ComboBox2.Location = New Point(328, 72)
		ComboBox2.Name = "ComboBox2"
		ComboBox2.Size = New Size(96, 24)
		ComboBox2.TabIndex = 198
		ComboBox2.Visible = False
		'
		'Label1
		'
		Label1.BackColor = Color.FromArgb(224, 224, 224)
		Label1.Enabled = False
		Label1.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label1.ForeColor = SystemColors.WindowText
		Label1.Location = New Point(264, 80)
		Label1.Name = "Label1"
		Label1.Size = New Size(56, 16)
		Label1.TabIndex = 197
		Label1.Text = "End Date"
		Label1.Visible = False
		'
		'TextBox14
		'
		TextBox14.Location = New Point(744, 480)
		TextBox14.Name = "TextBox14"
		TextBox14.Size = New Size(56, 20)
		TextBox14.TabIndex = 205
		TextBox14.Text = "TextBox14"
		'
		'TextBox13
		'
		TextBox13.Enabled = False
		TextBox13.Location = New Point(808, 488)
		TextBox13.Name = "TextBox13"
		TextBox13.Size = New Size(64, 20)
		TextBox13.TabIndex = 204
		TextBox13.Text = "TextBox13"
		'
		'DateTimePicker2
		'
		DateTimePicker2.CalendarForeColor = Color.ForestGreen
		DateTimePicker2.CalendarTitleBackColor = Color.Gainsboro
		DateTimePicker2.CalendarTitleForeColor = Color.ForestGreen
		DateTimePicker2.CustomFormat = "dd/MM/yyyy"
		DateTimePicker2.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 204)
		DateTimePicker2.Format = DateTimePickerFormat.Custom
		DateTimePicker2.Location = New Point(112, 56)
		DateTimePicker2.Name = "DateTimePicker2"
		DateTimePicker2.Size = New Size(96, 22)
		DateTimePicker2.TabIndex = 219
		DateTimePicker2.Value = New Date(2015, 6, 1, 0, 0, 0, 0)
		'
		'TextBox8
		'
		TextBox8.Enabled = False
		TextBox8.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox8.ForeColor = Color.Red
		TextBox8.Location = New Point(696, 464)
		TextBox8.Name = "TextBox8"
		TextBox8.Size = New Size(112, 23)
		TextBox8.TabIndex = 217
		TextBox8.Visible = False
		'
		'Label11
		'
		Label11.BackColor = Color.FromArgb(224, 224, 224)
		Label11.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label11.ForeColor = SystemColors.WindowText
		Label11.Location = New Point(218, 48)
		Label11.Name = "Label11"
		Label11.Size = New Size(104, 16)
		Label11.TabIndex = 191
		Label11.Text = "Activation date"
		Label11.Visible = False
		'
		'Label6
		'
		Label6.BackColor = Color.FromArgb(224, 224, 224)
		Label6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label6.ForeColor = Color.FromArgb(0, 64, 0)
		Label6.Location = New Point(432, 88)
		Label6.Name = "Label6"
		Label6.Size = New Size(56, 16)
		Label6.TabIndex = 184
		Label6.Text = "Client"
		'
		'ComboBox1
		'
		ComboBox1.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox1.ForeColor = SystemColors.WindowText
		ComboBox1.Location = New Point(488, 80)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(168, 24)
		ComboBox1.TabIndex = 183
		ComboBox1.Text = "ComboBox1"
		'
		'ComboBox11
		'
		ComboBox11.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox11.ForeColor = SystemColors.WindowText
		ComboBox11.Location = New Point(328, 40)
		ComboBox11.Name = "ComboBox11"
		ComboBox11.Size = New Size(96, 24)
		ComboBox11.TabIndex = 185
		ComboBox11.Visible = False
		'
		'ComboBox4
		'
		ComboBox4.ItemHeight = 13
		ComboBox4.Location = New Point(584, 8)
		ComboBox4.Name = "ComboBox4"
		ComboBox4.Size = New Size(136, 21)
		ComboBox4.TabIndex = 225
		ComboBox4.Visible = False
		'
		'Label3
		'
		Label3.BackColor = Color.FromArgb(224, 224, 224)
		Label3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label3.ForeColor = Color.FromArgb(0, 64, 0)
		Label3.Location = New Point(432, 56)
		Label3.Name = "Label3"
		Label3.Size = New Size(56, 16)
		Label3.TabIndex = 234
		Label3.Text = "Card ID"
		'
		'Button6
		'
		Button6.BackColor = Color.Gray
		Button6.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Button6.ForeColor = SystemColors.ControlLight
		Button6.Location = New Point(944, 208)
		Button6.Name = "Button6"
		Button6.Size = New Size(120, 24)
		Button6.TabIndex = 237
		Button6.Text = "Edit Order"
		Button6.UseVisualStyleBackColor = False
		'
		'TextBox1
		'
		TextBox1.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox1.ForeColor = SystemColors.WindowText
		TextBox1.Location = New Point(648, 208)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(48, 21)
		TextBox1.TabIndex = 238
		TextBox1.Text = "TextBox1"
		'
		'TextBox3
		'
		TextBox3.Location = New Point(656, 208)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(8, 20)
		TextBox3.TabIndex = 239
		TextBox3.Visible = False
		'
		'TextBox4
		'
		TextBox4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox4.ForeColor = SystemColors.WindowText
		TextBox4.Location = New Point(464, 254)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(56, 21)
		TextBox4.TabIndex = 240
		'
		'Label4
		'
		Label4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label4.ForeColor = Color.FromArgb(0, 64, 0)
		Label4.Location = New Point(464, 230)
		Label4.Name = "Label4"
		Label4.Size = New Size(56, 16)
		Label4.TabIndex = 241
		Label4.Text = "Slote"
		'
		'Label7
		'
		Label7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label7.ForeColor = Color.FromArgb(0, 64, 0)
		Label7.Location = New Point(539, 189)
		Label7.Name = "Label7"
		Label7.Size = New Size(56, 16)
		Label7.TabIndex = 243
		Label7.Text = "Surcharge"
		Label7.Visible = False
		'
		'TextBox7
		'
		TextBox7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox7.ForeColor = SystemColors.WindowText
		TextBox7.Location = New Point(536, 208)
		TextBox7.Name = "TextBox7"
		TextBox7.Size = New Size(56, 21)
		TextBox7.TabIndex = 242
		TextBox7.Text = "0"
		TextBox7.Visible = False
		'
		'TextBox18
		'
		TextBox18.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox18.ForeColor = SystemColors.WindowText
		TextBox18.Location = New Point(720, 207)
		TextBox18.Name = "TextBox18"
		TextBox18.Size = New Size(24, 21)
		TextBox18.TabIndex = 244
		TextBox18.Text = "TextBox18"
		TextBox18.Visible = False
		'
		'Label8
		'
		Label8.BackColor = Color.FromArgb(224, 224, 224)
		Label8.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label8.ForeColor = SystemColors.WindowText
		Label8.Location = New Point(32, 62)
		Label8.Name = "Label8"
		Label8.Size = New Size(80, 16)
		Label8.TabIndex = 246
		Label8.Text = "Reorder  date"
		'
		'ComboBox6
		'
		ComboBox6.Location = New Point(622, 254)
		ComboBox6.Name = "ComboBox6"
		ComboBox6.Size = New Size(88, 21)
		ComboBox6.TabIndex = 248
		'
		'Label9
		'
		Label9.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label9.Location = New Point(619, 189)
		Label9.Name = "Label9"
		Label9.Size = New Size(88, 16)
		Label9.TabIndex = 249
		Label9.Text = "Product Status"
		Label9.Visible = False
		'
		'Button8
		'
		Button8.BackColor = Color.Gray
		Button8.ForeColor = SystemColors.ControlLightLight
		Button8.Location = New Point(824, 208)
		Button8.Name = "Button8"
		Button8.Size = New Size(120, 24)
		Button8.TabIndex = 250
		Button8.Text = "Update payment plan"
		Button8.UseVisualStyleBackColor = False
		'
		'Label10
		'
		Label10.BackColor = Color.FromArgb(224, 224, 224)
		Label10.Enabled = False
		Label10.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label10.ForeColor = SystemColors.WindowText
		Label10.Location = New Point(32, 102)
		Label10.Name = "Label10"
		Label10.Size = New Size(64, 16)
		Label10.TabIndex = 251
		Label10.Text = "New Date"
		'
		'DateTimePicker4
		'
		DateTimePicker4.CustomFormat = "dd/MM/yyyy"
		DateTimePicker4.Format = DateTimePickerFormat.Custom
		DateTimePicker4.Location = New Point(104, 96)
		DateTimePicker4.Name = "DateTimePicker4"
		DateTimePicker4.Size = New Size(104, 20)
		DateTimePicker4.TabIndex = 252
		'
		'Button9
		'
		Button9.FlatStyle = FlatStyle.System
		Button9.Location = New Point(16, 144)
		Button9.Name = "Button9"
		Button9.Size = New Size(112, 24)
		Button9.TabIndex = 253
		Button9.Text = "Update  Start Date"
		Button9.Visible = False
		'
		'Button10
		'
		Button10.Location = New Point(376, 144)
		Button10.Name = "Button10"
		Button10.Size = New Size(75, 23)
		Button10.TabIndex = 254
		Button10.Text = "Refresh"
		'
		'Button11
		'
		Button11.BackColor = Color.Green
		Button11.ForeColor = SystemColors.ControlLightLight
		Button11.Location = New Point(1080, 184)
		Button11.Name = "Button11"
		Button11.Size = New Size(136, 32)
		Button11.TabIndex = 255
		Button11.Text = "2.Reorder Payment Plan"
		Button11.UseVisualStyleBackColor = False
		Button11.Visible = False
		'
		'Button13
		'
		Button13.BackColor = Color.Green
		Button13.ForeColor = SystemColors.ControlLightLight
		Button13.Location = New Point(824, 160)
		Button13.Name = "Button13"
		Button13.Size = New Size(240, 24)
		Button13.TabIndex = 257
		Button13.Text = "Delete Order"
		Button13.UseVisualStyleBackColor = False
		'
		'Button14
		'
		Button14.Location = New Point(600, 240)
		Button14.Name = "Button14"
		Button14.Size = New Size(56, 24)
		Button14.TabIndex = 258
		Button14.Text = "Info"
		Button14.Visible = False
		'
		'Repayment
		'
		Repayment.BackColor = Color.Green
		Repayment.ForeColor = SystemColors.ControlLightLight
		Repayment.Location = New Point(1080, 240)
		Repayment.Name = "Repayment"
		Repayment.Size = New Size(136, 23)
		Repayment.TabIndex = 259
		Repayment.Text = "4.Repayment"
		Repayment.UseVisualStyleBackColor = False
		Repayment.Visible = False
		'
		'Button12
		'
		Button12.BackColor = Color.Green
		Button12.ForeColor = SystemColors.ControlLightLight
		Button12.Location = New Point(1080, 216)
		Button12.Name = "Button12"
		Button12.Size = New Size(136, 23)
		Button12.TabIndex = 260
		Button12.Text = "3.Send  ts to  deposit"
		Button12.UseVisualStyleBackColor = False
		Button12.Visible = False
		'
		'Button15
		'
		Button15.BackColor = SystemColors.ActiveBorder
		Button15.ForeColor = SystemColors.ActiveCaptionText
		Button15.Location = New Point(824, 176)
		Button15.Name = "Button15"
		Button15.Size = New Size(193, 32)
		Button15.TabIndex = 261
		Button15.Text = "Reorder Payment Plan"
		Button15.UseVisualStyleBackColor = False
		Button15.Visible = False
		'
		'TextBox10
		'
		TextBox10.Location = New Point(488, 112)
		TextBox10.Name = "TextBox10"
		TextBox10.Size = New Size(120, 20)
		TextBox10.TabIndex = 262
		TextBox10.Text = "TextBox10"
		TextBox10.Visible = False
		'
		'Label12
		'
		Label12.BackColor = Color.FromArgb(224, 224, 224)
		Label12.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label12.ForeColor = Color.FromArgb(0, 64, 0)
		Label12.Location = New Point(432, 117)
		Label12.Name = "Label12"
		Label12.Size = New Size(56, 16)
		Label12.TabIndex = 263
		Label12.Text = "Deposit"
		Label12.Visible = False
		'
		'ComboBox7
		'
		ComboBox7.Location = New Point(616, 112)
		ComboBox7.Name = "ComboBox7"
		ComboBox7.Size = New Size(80, 21)
		ComboBox7.TabIndex = 264
		ComboBox7.Visible = False
		'
		'Button16
		'
		Button16.Location = New Point(776, 224)
		Button16.Name = "Button16"
		Button16.Size = New Size(49, 24)
		Button16.TabIndex = 265
		Button16.Text = "Open Deposit Account"
		Button16.Visible = False
		'
		'Button17
		'
		Button17.Location = New Point(789, 48)
		Button17.Name = "Button17"
		Button17.Size = New Size(75, 23)
		Button17.TabIndex = 266
		Button17.Text = "Fill Orders"
		Button17.Visible = False
		'
		'TextBox23
		'
		TextBox23.Location = New Point(712, 64)
		TextBox23.Name = "TextBox23"
		TextBox23.Size = New Size(64, 20)
		TextBox23.TabIndex = 267
		TextBox23.Text = "TextBox23"
		TextBox23.Visible = False
		'
		'ComboBox5
		'
		ComboBox5.Location = New Point(584, 48)
		ComboBox5.Name = "ComboBox5"
		ComboBox5.Size = New Size(121, 21)
		ComboBox5.TabIndex = 268
		ComboBox5.Text = "ComboBox5"
		ComboBox5.Visible = False
		'
		'ComboBox9
		'
		ComboBox9.Location = New Point(648, 48)
		ComboBox9.Name = "ComboBox9"
		ComboBox9.Size = New Size(96, 21)
		ComboBox9.TabIndex = 269
		ComboBox9.Text = "ComboBox9"
		'
		'CheckBox1
		'
		CheckBox1.Location = New Point(32, 16)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(72, 24)
		CheckBox1.TabIndex = 270
		CheckBox1.Text = "Stopped"
		'
		'Button18
		'
		Button18.Location = New Point(112, 16)
		Button18.Name = "Button18"
		Button18.Size = New Size(120, 23)
		Button18.TabIndex = 271
		Button18.Text = "Update Order Status"
		'
		'TextBox15
		'
		TextBox15.Location = New Point(8, 256)
		TextBox15.Name = "TextBox15"
		TextBox15.Size = New Size(512, 20)
		TextBox15.TabIndex = 252
		'
		'TextBox11
		'
		TextBox11.Location = New Point(296, 24)
		TextBox11.Name = "TextBox11"
		TextBox11.Size = New Size(112, 20)
		TextBox11.TabIndex = 252
		'
		'TextBox9
		'
		TextBox9.Location = New Point(0, 136)
		TextBox9.Name = "TextBox9"
		TextBox9.Size = New Size(100, 20)
		TextBox9.TabIndex = 245
		TextBox9.Visible = False
		'
		'TextBox21
		'
		TextBox21.Location = New Point(304, 144)
		TextBox21.Name = "TextBox21"
		TextBox21.Size = New Size(64, 20)
		TextBox21.TabIndex = 161
		'
		'TextBox22
		'
		TextBox22.Location = New Point(16, 56)
		TextBox22.Name = "TextBox22"
		TextBox22.Size = New Size(40, 20)
		TextBox22.TabIndex = 162
		TextBox22.Visible = False
		'
		'Label22
		'
		Label22.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label22.ForeColor = SystemColors.ControlText
		Label22.Location = New Point(176, 144)
		Label22.Name = "Label22"
		Label22.Size = New Size(112, 24)
		Label22.TabIndex = 151
		Label22.TextAlign = ContentAlignment.MiddleCenter
		'
		'TextBox20
		'
		TextBox20.Font = New Font("Tahoma", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox20.ForeColor = Color.DarkGreen
		TextBox20.Location = New Point(8, 88)
		TextBox20.Name = "TextBox20"
		TextBox20.Size = New Size(80, 26)
		TextBox20.TabIndex = 150
		TextBox20.Visible = False
		'
		'Button4
		'
		Button4.BackColor = Color.Green
		Button4.DialogResult = DialogResult.No
		Button4.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Button4.ForeColor = SystemColors.ControlLightLight
		Button4.Location = New Point(336, 192)
		Button4.Name = "Button4"
		Button4.Size = New Size(104, 24)
		Button4.TabIndex = 160
		Button4.Text = "Save Freezing"
		Button4.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Label5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label5.ForeColor = SystemColors.ControlText
		Label5.ImageAlign = ContentAlignment.TopLeft
		Label5.Location = New Point(168, 72)
		Label5.Name = "Label5"
		Label5.Size = New Size(120, 24)
		Label5.TabIndex = 149
		Label5.TextAlign = ContentAlignment.MiddleLeft
		'
		'DateTimePicker1
		'
		DateTimePicker1.CalendarForeColor = Color.ForestGreen
		DateTimePicker1.CalendarTitleBackColor = Color.Gainsboro
		DateTimePicker1.CalendarTitleForeColor = Color.ForestGreen
		DateTimePicker1.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 204)
		DateTimePicker1.Format = DateTimePickerFormat.[Short]
		DateTimePicker1.Location = New Point(296, 72)
		DateTimePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(152, 22)
		DateTimePicker1.TabIndex = 148
		DateTimePicker1.Value = New Date(2015, 7, 25, 0, 0, 0, 0)
		'
		'Label14
		'
		Label14.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label14.ForeColor = SystemColors.ControlText
		Label14.ImageAlign = ContentAlignment.TopLeft
		Label14.Location = New Point(168, 24)
		Label14.Name = "Label14"
		Label14.Size = New Size(112, 24)
		Label14.TabIndex = 253
		Label14.TextAlign = ContentAlignment.MiddleLeft
		'
		'Label15
		'
		Label15.Enabled = False
		Label15.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label15.ForeColor = SystemColors.ControlText
		Label15.ImageAlign = ContentAlignment.TopLeft
		Label15.Location = New Point(168, 104)
		Label15.Name = "Label15"
		Label15.Size = New Size(120, 24)
		Label15.TabIndex = 255
		Label15.TextAlign = ContentAlignment.MiddleLeft
		'
		'DateTimePicker5
		'
		DateTimePicker5.CalendarForeColor = Color.ForestGreen
		DateTimePicker5.CalendarTitleBackColor = Color.Gainsboro
		DateTimePicker5.CalendarTitleForeColor = Color.ForestGreen
		DateTimePicker5.Enabled = False
		DateTimePicker5.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 204)
		DateTimePicker5.Format = DateTimePickerFormat.[Short]
		DateTimePicker5.Location = New Point(8, 168)
		DateTimePicker5.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
		DateTimePicker5.Name = "DateTimePicker5"
		DateTimePicker5.Size = New Size(152, 22)
		DateTimePicker5.TabIndex = 254
		DateTimePicker5.Value = New Date(2014, 7, 3, 0, 0, 0, 0)
		DateTimePicker5.Visible = False
		'
		'TextBox12
		'
		TextBox12.Location = New Point(32, 200)
		TextBox12.Name = "TextBox12"
		TextBox12.Size = New Size(64, 20)
		TextBox12.TabIndex = 256
		TextBox12.Visible = False
		'
		'Label17
		'
		Label17.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label17.ForeColor = SystemColors.ControlText
		Label17.Location = New Point(96, 200)
		Label17.Name = "Label17"
		Label17.Size = New Size(112, 24)
		Label17.TabIndex = 257
		Label17.TextAlign = ContentAlignment.MiddleCenter
		Label17.Visible = False
		'
		'Label19
		'
		Label19.Location = New Point(8, 232)
		Label19.Name = "Label19"
		Label19.Size = New Size(80, 16)
		Label19.TabIndex = 258
		'
		'ComboBox10
		'
		ComboBox10.Items.AddRange(New Object() {"Payable", "Free"})
		ComboBox10.Location = New Point(296, 104)
		ComboBox10.Name = "ComboBox10"
		ComboBox10.Size = New Size(152, 21)
		ComboBox10.TabIndex = 259
		'
		'TextBox25
		'
		TextBox25.Enabled = False
		TextBox25.Location = New Point(367, 8)
		TextBox25.Name = "TextBox25"
		TextBox25.Size = New Size(84, 20)
		TextBox25.TabIndex = 272
		'
		'TextBox26
		'
		TextBox26.Enabled = False
		TextBox26.Location = New Point(464, 10)
		TextBox26.Name = "TextBox26"
		TextBox26.Size = New Size(83, 20)
		TextBox26.TabIndex = 273
		'
		'TextBox27
		'
		TextBox27.Enabled = False
		TextBox27.Location = New Point(267, 8)
		TextBox27.Name = "TextBox27"
		TextBox27.Size = New Size(83, 20)
		TextBox27.TabIndex = 274
		'
		'ReOrder
		'
		AutoScaleBaseSize = New Size(5, 13)
		BackColor = Color.FromArgb(224, 224, 224)
		ClientSize = New Size(1444, 746)
		Controls.Add(ComboBox6)
		Controls.Add(TextBox4)
		Controls.Add(TextBox5)
		Controls.Add(ComboBox8)
		Controls.Add(Button13)
		Controls.Add(TextBox27)
		Controls.Add(TextBox26)
		Controls.Add(TextBox25)
		Controls.Add(Button18)
		Controls.Add(CheckBox1)
		Controls.Add(ComboBox9)
		Controls.Add(ComboBox5)
		Controls.Add(TextBox23)
		Controls.Add(Button17)
		Controls.Add(Button1)
		Controls.Add(Button8)
		Controls.Add(Button2)
		Controls.Add(Button6)
		Controls.Add(Button16)
		Controls.Add(ComboBox7)
		Controls.Add(Label12)
		Controls.Add(TextBox10)
		Controls.Add(TextBox18)
		Controls.Add(TextBox7)
		Controls.Add(TextBox3)
		Controls.Add(TextBox17)
		Controls.Add(TextBox24)
		Controls.Add(TextBox2)
		Controls.Add(TextBox6)
		Controls.Add(Button14)
		Controls.Add(Button10)
		Controls.Add(Button9)
		Controls.Add(DateTimePicker4)
		Controls.Add(Label10)
		Controls.Add(Label8)
		Controls.Add(Label7)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(ComboBox4)
		Controls.Add(Orders)
		Controls.Add(Label20)
		Controls.Add(ComboBox3)
		Controls.Add(ComboBox2)
		Controls.Add(Label1)
		Controls.Add(DateTimePicker2)
		Controls.Add(Label11)
		Controls.Add(Label6)
		Controls.Add(ComboBox1)
		Controls.Add(ComboBox11)
		Controls.Add(DataGrid1)
		Controls.Add(Label26)
		Controls.Add(Label18)
		Controls.Add(Label13)
		Controls.Add(Label16)
		Controls.Add(Label2)
		Controls.Add(Button3)
		Controls.Add(Button7)
		Controls.Add(Button5)
		Controls.Add(Button12)
		Controls.Add(Button11)
		Controls.Add(Repayment)
		Controls.Add(TextBox19)
		Controls.Add(TextBox16)
		Controls.Add(TextBox14)
		Controls.Add(TextBox13)
		Controls.Add(TextBox8)
		Controls.Add(TextBox1)
		Controls.Add(Label9)
		Controls.Add(Button15)
		Name = "ReOrder"
		Text = "ReOrder"
		CType(DataGrid1, ComponentModel.ISupportInitialize).EndInit()
		CType(DataView1, ComponentModel.ISupportInitialize).EndInit()
		Orders.ResumeLayout(False)
		TabPage3.ResumeLayout(False)
		CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGrid3, ComponentModel.ISupportInitialize).EndInit()
		TabPage2.ResumeLayout(False)
		CType(DataGrid9, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGrid7, ComponentModel.ISupportInitialize).EndInit()
		CType(DataView2, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	Private Async Sub ReOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim cultureInfoTemporary As New CultureInfo("en-US")
		cultureInfoTemporary.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		cultureInfoTemporary.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = cultureInfoTemporary

		DateTimePicker2.Value = Date.Now

		Dim dataSet As New DataSet()
		Dim result1 As New Integer
		Dim result2 As New Integer

		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()

				Dim command1 As New SqlCommand("select max(ID)  from [OrderDetails]", Connection)
				Dim dataAdapter1 As New SqlDataAdapter(command1)
				result1 = command1.ExecuteScalar()

				Dim command2 As New SqlCommand("select max(PurchaseOrderID)  from [Purchase Orders]", Connection)
				Dim dataAdapter2 As New SqlDataAdapter(command2)
				result2 = command2.ExecuteScalar()
				If Not IsDBNull(result2) Then
					dataAdapter2.Fill(dataSet, "Max2")
				End If

				Dim adapter As New SqlDataAdapter("select  * from clientOrder", Connection)
				adapter.Fill(dataSet, "Order")

				Dim adapter1 As New SqlDataAdapter("select * from Products", Connection)
				adapter1.Fill(dataSet, "Product")

				Dim adapter2 As New SqlDataAdapter("Select * from clientorder", Connection)
				adapter2.Fill(dataSet, "clientorder")

				Dim adapter4 As New SqlDataAdapter("Select * from [Order Details Status]", Connection)
				adapter4.Fill(dataSet, "status")

				Dim adapter5 As New SqlDataAdapter("select * from DepositAccount", Connection)
				adapter5.Fill(dataSet, "DepositAccount")
			End Sub)

		TextBox17.Text = 1 + If(IsDBNull(result1), 0, CStr(result1))
		TextBox18.Text = 1 + If(IsDBNull(result2), 0, CStr(result2))

		If TextBox7.Text = "1" Then
			TextBox9.Text = "One Off"
		End If

		If TextBox7.Text >= "9" Then
			TextBox9.Text = "Montly"
		End If

		If TextBox7.Text < "9" And TextBox7.Text <> "1" Then
			TextBox9.Text = "Partial"
		End If

		With ComboBox6
			.DisplayMember = "status.StatusName"
			.ValueMember = "StatusID"
			.DataSource = dataSet
		End With

		With ComboBox7
			.DisplayMember = "DepositAccount.DepositAmount"
			.ValueMember = "DepositAmount"
			.DataSource = dataSet
		End With

		With ComboBox4
			.DisplayMember = "clientorder.OrderName"
			.ValueMember = "OrderID"
			.DataSource = dataSet
		End With

		With ComboBox3
			.DisplayMember = Trim("clientorder.CardID")
			.ValueMember = "OrderID"
			.DataSource = dataSet
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems
		End With

		With ComboBox1
			.DisplayMember = "clientorder.Client"
			.ValueMember = "OrderID"
			.DataSource = dataSet
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems
		End With

		With ComboBox11
			.DisplayMember = "clientorder.OrderDate"
			.ValueMember = "OrderID"
			.DataSource = dataSet
		End With

		With ComboBox2
			.DisplayMember = "clientorder.EndDate"
			.ValueMember = "OrderID"
			.DataSource = dataSet
		End With

		With ComboBox5
			.DisplayMember = "clientorder.CustomerID"
			.ValueMember = "CustomerID"
			.DataSource = dataSet
		End With

		With ComboBox8
			.DisplayMember = "Product.ProductName"
			.ValueMember = "ID"
			.DataSource = dataSet
		End With

		TextBox21.Text = 0
		DateTimePicker5.Value = DateTimePicker1.Value.AddDays(TextBox21.Text)
		TextBox14.DataBindings.Add("Text", dataSet, "clientorder.orderid")
		TextBox1.DataBindings.Add("Text", dataSet, "Product.ID")
		TextBox3.DataBindings.Add("Text", dataSet, "clientorder.CustomerID")

		Await RefreshForm()
	End Sub

	Private IsFillingOrders = False
	Async Function FillOrders() As Task
		Try
			TextBox25.DataBindings.Clear()
			TextBox26.DataBindings.Clear()
			TextBox27.DataBindings.Clear()
			TextBox4.DataBindings.Clear()
			TextBox5.DataBindings.Clear()
			ComboBox8.DataBindings.Clear()
			ComboBox9.DataBindings.Clear()
			dgvOrders.DataSource = Nothing

			If ComboBox5.SelectedValue Is Nothing Then
				Return
			End If

			Dim dataSet As New DataSet()

			If IsFillingOrders Then Return
			IsFillingOrders = True
			Await Worker.RunWork(
				Sub()
					Using con = ReadyConnectionFNew()
						Dim idCustomer = Int(ComboBox5.SelectedValue)
						Dim commandOrder As New SqlCommand("select * from OrdersFullLast where CustomerID = '" & idCustomer & " ' ", con)
						Dim dataAdapter As New SqlDataAdapter(commandOrder)
						dataAdapter.Fill(dataSet, "OrdersFullLast")
					End Using
				End Sub)

			dgvOrders.DataSource = dataSet
			dgvOrders.DataMember = "OrdersFullLast"
			TextBox25.DataBindings.Add("Text", dataSet, "OrdersFullLast.orderid")
			TextBox26.DataBindings.Add("Text", dataSet, "OrdersFullLast.id")
			TextBox4.DataBindings.Add("Text", dataSet, "OrdersFullLast.slote")
			TextBox27.DataBindings.Add("Text", dataSet, "OrdersFullLast.prid")
			TextBox5.DataBindings.Add("Text", dataSet, "OrdersFullLast.Total")
			ComboBox8.DataBindings.Add("Text", dataSet, "OrdersFullLast.ProductName")
			ComboBox9.DataBindings.Add("Text", dataSet, "OrdersFullLast.Orderid")
			IsFillingOrders = False
		Catch ex As OperationCanceledException
			MsgBox("Canceled")
		End Try
	End Function

	Async Function FillPlan() As Task
		If TextBox25.Text = "" Then
			Return
		End If

		Dim dataSet As New DataSet()

		Await Worker.RunWork(
			Sub()
				Using con = ReadyConnectionFNew()
					Dim commandPlanned As New SqlCommand("select * from Planned where OrderID = '" & TextBox25.Text & " '", con)
					Dim dataAdapter As New SqlDataAdapter(commandPlanned)
					dataAdapter.Fill(dataSet, "Planned")
				End Using
			End Sub)

		If dataSet.Tables.Count = 0 Then
			Return
		End If

		DataGrid3.DataSource = dataSet
		DataGrid3.DataMember = "Planned"
	End Function

	Async Function RefreshForm() As Task
		Await FillOrders()
		Await FillPlan()
	End Function

	Async Function CalculateSlotAtt() As Task
		ReadyConnectionF()

		Dim check1 As Integer = Await Worker.RunWork(
			Function()
				Dim command1 As New SqlCommand("select  DateDiff(m,convert(datetime,@ExpectedDate,121), EndDate) FROM Orddate WHERE OrderID ='" & ComboBox9.Text & "' ", conn)
				command1.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
				Return command1.ExecuteScalar()
			End Function)
		If CInt(TextBox4.Text) > check1 Then
			MsgBox(" Max slote will be" & check1)
			TextBox4.Text = check1
			Return
		End If

		Dim check2 As Integer = Await Worker.RunWork(
			Function()
				Dim command2 As New SqlCommand("select count(orderid) from AttendOrder where OrderID = '" & ComboBox9.SelectedValue & " ' and AtDate >= '" & DateTimePicker4.Value & " '", conn)
				Return command2.ExecuteScalar()
			End Function)
		If check2 > 0 Then
			MsgBox("  Client have  " & check2 & "Attendance after reorder date", MsgBoxStyle.OkOnly, "Info")
			Return
		End If

		Await RefreshForm()
	End Function

	Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim idPur As Integer = ComboBox9.Text

		If idPur <> 0 Then
			ReadyConnectionF()

			Dim command1 As New SqlCommand("select  DateDiff(m,convert(datetime,@ExpectedDate,121), EndDate) FROM Orddate WHERE OrderID ='" & idPur & "' ", conn)
			command1.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
			Dim check As Integer = command1.ExecuteScalar()

			Dim command2 As New SqlCommand("select count(orderid) from AttendOrder where OrderID = '" & ComboBox9.SelectedValue & " ' and AtDate >= '" & DateTimePicker4.Value & " '", conn)
			Dim check1 As Integer = command2.ExecuteScalar()

			Dim command3 As New SqlCommand("select count(orderid) from MaxEndDate where customerID = '" & ComboBox5.SelectedValue & " '", conn)
			Dim checkCount As Integer = command3.ExecuteScalar()

			MsgBox(" Max slote" & check & "   Attendance " & check1 & "Client orders" & checkCount & "", MsgBoxStyle.OkOnly, "Info")

			Dim x As Integer
			For x = 1 To checkCount
				If conn.State = ConnectionState.Closed Then
					conn.Open()

					Dim commandMinDate As New SqlCommand("select min(orderdate)from MaxEndDate where  customerID = '" & ComboBox5.SelectedValue & " '", conn)
					Dim checkMinDate As Date = commandMinDate.ExecuteScalar()

					Dim command As New SqlCommand()
					command = conn.CreateCommand()
					command.CommandText = "select orderid from OrdDate where customerID = '" & ComboBox5.SelectedValue & " '  and OrderDate in(select min(orderdate)from MaxEndDate where customerID = '" & ComboBox5.SelectedValue & " '  and OrderDate > '" & checkMinDate & " ')"
					Dim check2 As Integer = command.ExecuteScalar()

					Dim cmd4 As New SqlCommand()
					cmd4 = conn.CreateCommand()
					cmd4.CommandText = "select EndDate from Orddate where customerID = '" & TextBox3.Text & " ' and  OrderID = '" & idPur & " '  "
					Dim actDate As Date = cmd4.ExecuteScalar()

					If check2 <> ComboBox9.SelectedValue Then
						Dim cmd5 As New SqlCommand
						cmd5 = conn.CreateCommand

						cmd5.CommandText = "select  DateDiff(m,OrderDate, EndDate) FROM Orddate  WHERE OrderID ='" & check2 & "' and customerID = '" & TextBox3.Text & " '"
						Dim newduration As Integer = cmd5.ExecuteScalar()
						Debug.Write(newduration)
						' 
						If MsgBox("Are you sure to update order activation date with Id   : " & check2 & " ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
							' do nothing
						Else
							command.Parameters.Add("@orderid", SqlDbType.Int).Value = check2 'check2
							command.Parameters.Add("@Orderdate", SqlDbType.DateTime).Value = actDate.AddDays(1)
							command.Parameters.Add("@ReorderDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
							command.Parameters.Add("@NewEndDate", SqlDbType.DateTime).Value = actDate.AddMonths(newduration)
							command.CommandText = "Update [Orders] set OrderDate = convert(datetime,@OrderDate,121),EndDate=convert(datetime,@NewEndDate,121),ReOrderDate =convert(datetime,@ReorderDate,121) where OrderID ='" & check2 & " 'and  customerID = '" & TextBox3.Text & " '"
						End If
						check = command.ExecuteReader().RecordsAffected

						If check > 0 Then
							MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
						Else
							MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
						End If

						idPur = check2
					End If
				End If
			Next
		End If

		Await RefreshForm()
		ComboBox9.Text = idPur
	End Sub

	Async Function DeletePlanned() As Task
		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()
				Dim command As New SqlCommand("DELETE FROM [Purchase Orders] WHERE OrderID ='" & CInt(ComboBox9.Text) & "' and productID ='" & TextBox1.Text & "'and  ExpectedDate >= convert(datetime,@ExpectedDate,121)", conn)
				command.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
				ExecuteReader(command)
			End Sub)
	End Function

	Async Function DeleteAllPlanned() As Task
		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()
				Dim command As New SqlCommand("DELETE FROM [Purchase Orders] WHERE OrderID ='" & CInt(ComboBox9.Text) & "'", conn)
				command.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
				ExecuteReader(command)
			End Sub)
		Await RefreshForm()
	End Function

	Async Function DeleteLimit() As Task
		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()
				Dim cmdLim As New SqlCommand("DELETE FROM [Limit] WHERE OrderID ='" & CInt(ComboBox9.Text) & "' and productID ='" & TextBox1.Text & "'", conn)
				cmdLim.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
				cmdLim.ExecuteReader()
			End Sub)
		Await RefreshForm()
	End Function

	Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
		On Error Resume Next
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text = 0 Then
			TextBox24.Text = Math.Round(TextBox5.Text * TextBox2.Text, 0)
		End If
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text > 0 Then
			TextBox24.Text = Math.Round(Int(TextBox5.Text) * Int(TextBox2.Text) - (Int(TextBox5.Text) * Int(TextBox2.Text)) * (Int(TextBox6.Text) / 100), 0)
		End If
	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
		On Error Resume Next
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text = 0 Then
			TextBox24.Text = Math.Round(TextBox5.Text * TextBox2.Text, 0)
		End If
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text > 0 Then
			TextBox24.Text = Math.Round(Int(TextBox5.Text) * Int(TextBox2.Text) - (Int(TextBox5.Text) * Int(TextBox2.Text)) * (Int(TextBox6.Text) / 100), 0)
		End If
	End Sub

	Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
		On Error Resume Next
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text = 0 Then
			TextBox24.Text = Math.Round(TextBox5.Text * TextBox2.Text, 0)
		End If
		If TextBox5.Text <> "" And TextBox2.Text <> "" And TextBox6.Text > 0 Then
			TextBox24.Text = Math.Round(Int(TextBox5.Text) * Int(TextBox2.Text) - (Int(TextBox5.Text) * Int(TextBox2.Text)) * (Int(TextBox6.Text) / 100), 0)
		End If
	End Sub

	Async Function ChangeStatus() As Task
		If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Ok Then
			Await Worker.RunWork(
				Sub()
					ReadyConnectionF()
					Dim poid As Integer
					Dim cmd As New SqlCommand("Update [OrderDetails] set StatusID=@StatusID where ID = '" & poid & "' and OrderID = '" & ComboBox9.SelectedValue & " ' ", conn)
					cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = Int(TextBox2.Text)
					cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Int(TextBox5.Text)
					cmd.Parameters.Add("@StatusID", SqlDbType.Int).Value = 1 'edited ComboBox7.Text
					cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = TextBox6.Text
					cmd.ExecuteReader()
				End Sub)
		End If

		Await DeletePlanned()
		Await RefreshForm()
	End Function

	Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Ok Then
			Dim check = Await Worker.RunWork(
				Function()
					ReadyConnectionF()
					Dim command As New SqlCommand("Update [OrderDetails] set productid=@Productid, Quantity = @Quantity,UnitPrice = @UnitPrice,StatusID=@StatusID,Discount = @Discount,Slote = @slote  where   OrderID = '" & Int(ComboBox9.Text) & " ' ", conn)
					command.Parameters.Add("@ProductID", SqlDbType.Int).Value = TextBox1.Text
					command.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = 1
					command.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Int(TextBox5.Text)
					command.Parameters.Add("@StatusID", SqlDbType.Int).Value = 1
					command.Parameters.Add("@Discount", SqlDbType.Float).Value = TextBox6.Text
					command.Parameters.Add("@slote", SqlDbType.Int).Value = Int(TextBox4.Text)
					Return command.ExecuteReader().RecordsAffected
				End Function)
			MsgBox(If(check > 0, "Succesfully", "Failure") & " To Update", MsgBoxStyle.OkOnly, "Info Delete")
		End If

		Await RefreshForm()
	End Sub

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Await AddProduct1()
	End Sub

	Async Function Repay() As Task
		Dim check1 As Integer
		Dim cmd As New SqlCommand
		Dim cmd1 As New SqlCommand
		Dim cmd2 As New SqlCommand

		ReadyConnectionF()
		cmd1 = conn.CreateCommand
		cmd1.CommandText = "select DepositAmount from Deposit  " & "where CustomerID = '" & TextBox3.Text & "'"
		Dim scalar1 = cmd1.ExecuteScalar()
		If Not IsDBNull(scalar1) Then
			check1 = cmd1.ExecuteScalar()
		End If

		conn.Close()
		conn.Open()

		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()
		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"

		Dim idDetID As Integer = cmdPoDetID.ExecuteScalar
		conn.Close()
		conn.Open()

		Dim Str As String = "select * from Planned where OrderID = '" & ComboBox9.Text & " '  and  [Planned Date] >= convert(datetime,@CancelDate,121)"
		Dim cmdPOID As New SqlCommand(Str, Connection)
		cmdPOID.Parameters.Add("@CancelDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
		Dim dr As SqlDataReader = cmdPOID.ExecuteReader
		cmdPOID.Parameters.Clear()
		Dim CMDRePay As New SqlCommand("InsertPayment")

		While dr.Read()
			idDetID += 1
			CMDRePay.Parameters.Clear()

			If check1 > 0 Then
				CMDRePay.Parameters.Add("@ID", SqlDbType.Int).Value = Int(idDetID)

				If Not IsDBNull(dr("Planned Payment")) Then
					If check1 >= dr("Planned Payment") Then
						CMDRePay.Parameters.Add("@Amount", SqlDbType.NChar).Value = Int((dr("Planned Payment")))
						check1 -= dr("Planned Payment")
					ElseIf check1 > 0 And check1 < dr("Planned Payment") Then
						CMDRePay.Parameters.Add("@Amount", SqlDbType.NChar).Value = check1
						check1 = 0
					End If
				End If
			End If

			CMDRePay.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = DateTimePicker2.Value 'wronge
			CMDRePay.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = "RePay"
			CMDRePay.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = dr("PaymentBasic")
			CMDRePay.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Repayment"
			CMDRePay.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = "DEPOSIT"
			CMDRePay.Parameters.Add("@Notes", SqlDbType.NText).Value = "Repayment"
			CMDRePay.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 1 'wronge
			CMDRePay.Parameters.Add("@ProductID", SqlDbType.Int).Value = dr("ProductID")
			CMDRePay.Parameters.Add("@CustomerID", SqlDbType.Int).Value = Int(TextBox3.Text)
			CMDRePay.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = Int(dr("POID"))
			CMDRePay.Parameters.Add("@EmplID", SqlDbType.Int).Value = 1
			CMDRePay.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = DateTimePicker2.Value ' na forme naoborot recieveddate t.k. sort 
			CMDRePay.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = DateTimePicker2.Value 'wronge
			CMDRePay.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = DateTimePicker4.Value
			CMDRePay.Parameters.Add("@UnitPrice ", SqlDbType.NChar).Value = Int(TextBox5.Text)
			CMDRePay.Parameters.Add("@Quantity ", SqlDbType.NChar).Value = Int(TextBox2.Text)
			CMDRePay.Parameters.Add("@Discount ", SqlDbType.NChar).Value = Int(TextBox6.Text)
			CMDRePay.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"
			CMDRePay.Parameters.Add("@OrderID", SqlDbType.Int).Value = Int(ComboBox9.Text) 'Int(dr("POID"))

			ExecuteProcedur.ExecuteCMD(CMDRePay)
		End While

		dr.Close()
		Dim cmdDepID As SqlCommand
		cmdDepID = conn.CreateCommand()
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = check1
		cmdDepID.Parameters.Add("@ID", SqlDbType.Int).Value = Int(TextBox3.Text)
		cmdDepID.CommandText = "Update Deposit set DepositAmount = @Amount  where CustomerID = @ID " ' COALESCE(NULLIF(@Amount,-1),Amount)+@Amount  where ID = @ID "

		ExecuteReader(cmdDepID)

		Dim check3 As Integer = cmdDepID.ExecuteReader.RecordsAffected
		dr.Close()

		Await RefreshForm()
	End Function

	Async Function AddProduct1() As Task
		Dim a As Integer

		Await DeletePlanned()

		If TextBox2.Text = "" Or TextBox5.Text = "" Or ComboBox8.Text = "" Then
			MsgBox("Product Data is not completed", MsgBoxStyle.OkOnly)
		Else
			If MsgBox("Are you sure to save Product data with Id : " & TextBox1.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
				'End If
			Else
				ReadyConnectionF()

				Dim OrderID As Integer
				OrderID = TextBox25.Text
				Dim CMD As New SqlCommand("InsertPurchaseOrder")
				Dim i As Integer
				a = Int(TextBox4.Text) 'slote
				CMD.Parameters.Clear()

				For i = 0 To a - 1
					CMD.Parameters.Clear()
					TextBox18.Text = TextBox18.Text + 1
					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = Int(TextBox18.Text)
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = TextBox1.Text
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = DateTimePicker2.Value.AddMonths(i) 'for balance
					CMD.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value.AddMonths(i)

					If TextBox7.Text > 0 Then
						CMD.Parameters.Add("@PaymentAmount", SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a) + TextBox7.Text / a)
					Else
						CMD.Parameters.Add("@PaymentAmount", SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a))
					End If

					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = "Order #" & ComboBox9.Text
					CMD.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Int(TextBox5.Text)
					CMD.Parameters.Add("@Limit", SqlDbType.Int).Value = Math.Round(Int(TextBox24.Text) / 1)
					ExecuteProcedur.ExecuteCMD(CMD)
				Next

				TextBox18.Refresh()
			End If
		End If

		Await RefreshForm()
	End Function

	Sub limitAll()
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()
		ReadyConnectionF()
		cmdPoDetID.CommandText = "select max(LimitID)  from Limit"
		Dim sqlResult1 As Object = cmdPoDetID.ExecuteScalar()
		Dim limitID As Integer
		If IsDBNull(sqlResult1) Then
			limitID = 1
		Else
			limitID = cmdPoDetID.ExecuteScalar
		End If

		Dim duration, OrderID As Integer
		Dim cmd3 As SqlCommand
		OrderID = Int(ComboBox9.Text)
		cmd3 = conn.CreateCommand
		cmd3.CommandText = "select  duration FROM Orddate WHERE OrderID ='" & OrderID & "' "
		duration = cmd3.ExecuteScalar

		Dim cntProduct As Integer
		Dim cmdProd As SqlCommand
		cmdProd = conn.CreateCommand
		cmdProd.CommandText = "select  CountProduct FROM CountProduct WHERE OrderID ='" & OrderID & "' "
		cntProduct = cmdProd.ExecuteScalar

		Dim cmd4 As SqlCommand
		OrderID = Int(ComboBox9.Text)
		cmd4 = conn.CreateCommand
		cmd4.CommandText = "select  * FROM OrderDetailsExt WHERE OrderID ='" & OrderID & "' "
		Dim dr As SqlDataReader = cmd4.ExecuteReader
		Dim i As Integer ' duration
		Dim CMD As New SqlCommand("InsertLimit")

		CMD.Parameters.Clear()
		For x As Integer = 0 To cntProduct
			If dr.Read Then
				For i = 0 To duration - 1
					CMD.Parameters.Clear()
					limitID += 1
					CMD.Parameters.Add("@LimitID", SqlDbType.Int).Value = limitID
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = dr("ProductID")
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = dr("OrderDate").AddMonths(i)
					CMD.Parameters.Add("@LimitEndDate", SqlDbType.DateTime).Value = dr("OrderDate").AddMonths(i + 1).AddDays(-1)
					CMD.Parameters.Add("@Limit", SqlDbType.Int).Value = Math.Round(Int(dr("Quantity") / duration))

					ExecuteProcedur.ExecuteCMD(CMD)
				Next
			End If
		Next

		dr.Close()
	End Sub

	Async Function LimitAllUpdate() As Task
		Dim orderId = Int(ComboBox9.Text)

		ReadyConnectionF()
		Dim command1 As New SqlCommand("select LimitID  from Limit WHERE OrderID ='" & orderId & "'", conn)
		Dim scalar1 = Await Worker.RunWork(
			Function()
				Return command1.ExecuteScalar()
			End Function)
		If scalar1 Is Nothing Or IsDBNull(scalar1) Then
			limitAll()
			Return
		End If
		Dim limitId = CInt(scalar1)

		Dim command2 As New SqlCommand("select  duration FROM Orddate WHERE OrderID ='" & orderId & "' ", conn)
		Dim duration = Await Worker.RunWork(
			Function()
				Return command2.ExecuteScalar()
			End Function)

		Dim command3 As New SqlCommand("select  CountProduct FROM CountProduct WHERE OrderID ='" & orderId & "' ", conn)
		Dim count = Await Worker.RunWork(
			Function()
				Return CInt(command3.ExecuteScalar())
			End Function)

		Dim command4 As New SqlCommand("select  * FROM OrderDetailsExt WHERE OrderID ='" & orderId & "' ", conn)
		Dim reader = Await Worker.RunWork(
			Function()
				Return command4.ExecuteReader()
			End Function)

		Dim command5 As New SqlCommand("InsertLimit")
		command5.Parameters.Clear()
		For x = 0 To count
			If Not reader.Read() Then Continue For

			For i = 0 To duration - 1
				command5.Parameters.Clear()
				command5.Parameters.Add("@LimitID", SqlDbType.Int).Value = limitId
				command5.Parameters.Add("@OrderID", SqlDbType.Int).Value = orderId
				command5.Parameters.Add("@ProductID", SqlDbType.Int).Value = reader("ProductID")
				command5.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = reader("OrderDate").AddMonths(i)
				command5.Parameters.Add("@LimitEndDate", SqlDbType.DateTime).Value = reader("OrderDate").AddMonths(i + 1).AddDays(-1)
				command5.Parameters.Add("@Limit", SqlDbType.Int).Value = Math.Round(Int(reader("Quantity") / duration))
				limitId += 1
				Await Worker.RunWork(
					Sub()
						ExecuteProcedur.ExecuteCMD(command5)
					End Sub)
			Next
		Next

		reader.Close()
	End Function

	Async Function ChangePlan() As Task
		If TextBox2.Text = "" Or TextBox5.Text = "" Or ComboBox8.Text = "" Then
			MsgBox("Product Data is not completed", MsgBoxStyle.OkOnly)
			Return
		End If

		Await CalculateSlotAtt()
		ReadyConnectionF()

		Dim scalar = Await Worker.RunWork(
			Function()
				Dim CMD2 As New SqlCommand("SELECT * FROM [OrderDetails] WHERE OrderID = '" & ComboBox9.Text & " ' and StatusID <> 2 and ProductId ='" & Trim(TextBox1.Text) & " ' ", conn)
				Return CMD2.ExecuteScalar()
			End Function)
		If (scalar > 0) Then
			Await ChangeStatus()
		End If

		Dim CMD As New SqlCommand("InsertPurchaseOrder")
		Dim a = Int(TextBox4.Text) 'slote
		CMD.Parameters.Clear()
		For i = 0 To -1
			TextBox18.Text = TextBox18.Text + 1
			CMD.Parameters.Clear()
			CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = Int(TextBox18.Text)
			CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = ComboBox9.Text
			CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = TextBox1.Text
			CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = DateTimePicker2.Value.AddMonths(i)
			CMD.Parameters.Add("@ExpectedDate", SqlDbType.DateTime).Value = DateTimePicker2.Value.AddMonths(i)
			CMD.Parameters.Add("@PaymentAmount", SqlDbType.Decimal).Value = Math.Round(((TextBox2.Text * TextBox5.Text - TextBox2.Text * TextBox5.Text * TextBox6.Text / 100) / a) + If(TextBox7.Text > 0, TextBox7.Text / a, 0))
			CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = "Order #" & ComboBox9.Text
			CMD.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Int(TextBox5.Text)
			CMD.Parameters.Add("@Limit", SqlDbType.Int).Value = Math.Round(Int(TextBox2.Text) / 1)
			Await Worker.RunWork(
				Sub()
					ExecuteProcedur.ExecuteCMD(CMD)
				End Sub)
		Next

		TextBox18.Refresh()

		Await RefreshForm()
	End Function

	Private Async Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox3.SelectionChangeCommitted
		Await RefreshForm()
	End Sub

	Private Async Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
		Await Upd()
	End Sub

	Async Function Upd() As Task
		Dim PurID, ind As Integer
		Dim cmd As New SqlCommand
		PurID = ComboBox9.Text
		ind = ComboBox9.SelectedIndex
		Dim redate As Date = DateTimePicker2.Value
		Dim reenddate As Date = DateTimePicker4.Value
		cmd = conn.CreateCommand
		cmd.Parameters.Clear()
		cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = ComboBox9.Text
		cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = PurID 'DateTimePicker2.Value
		cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = reenddate
		cmd.Parameters.Add("@ReorderDate", SqlDbType.DateTime).Value = redate

		If MsgBox("Are you sure to update order End date with Id   : " & PurID & " ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
			' do nothing
		Else
			ReadyConnectionF()
			cmd.CommandText = "Update [Orders] set EndDate=@EndDate,ReOrderDate =@ReorderDate where OrderID ='" & PurID & "' and customerID = '" & TextBox3.Text & " '"
			Dim check As Integer = cmd.ExecuteReader.RecordsAffected
			If check > 0 Then
				MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
			Else
				MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
			End If
		End If
		cmd.Parameters.Clear()

		Await RefreshForm()
		ComboBox9.Text = PurID
	End Function

	Async Function StopOrder() As Task
		If ComboBox5.SelectedValue IsNot Nothing AndAlso MsgBox("Are you sure to update order Status ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Ok Then
			ReadyConnectionF()
			Dim command As New SqlCommand("Update [Orders] set ReOrderDate =@ReorderDate,StatusID =@StatusID where OrderID = @OrderID and customerID = @customerID ", conn)
			command.Parameters.Add("@OrderID", SqlDbType.Int).Value = Int(ComboBox9.Text)
			command.Parameters.Add("@customerID", SqlDbType.Int).Value = Int(ComboBox5.SelectedValue)
			command.Parameters.Add("@ReorderDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
			command.Parameters.Add("@StatusID", SqlDbType.Int).Value = If(CheckBox1.Checked, 1, 0)
			Dim check As Integer = command.ExecuteReader().RecordsAffected
			MsgBox(If(check > 0, "Succesfully", "Failure") & " To Update", MsgBoxStyle.OkOnly, "Info Delete")
		End If

		Await RefreshForm()
	End Function

	Async Function UpdSart() As Task
		Dim duration, OrderID As Integer
		Dim cmd3 As SqlCommand

		ReadyConnectionF()
		OrderID = Int(ComboBox9.Text)
		cmd3 = conn.CreateCommand
		cmd3.CommandText = "select  duration FROM Orddate WHERE OrderID ='" & OrderID & "' "
		duration = cmd3.ExecuteScalar

		Dim PurID, ind As Integer
		Dim cmd As New SqlCommand
		cmd.Parameters.Clear()
		PurID = ComboBox9.Text
		ind = ComboBox9.SelectedIndex
		Dim redate As Date = DateTimePicker2.Value
		Dim restartdate As Date = DateTimePicker4.Value
		cmd = conn.CreateCommand
		cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = ComboBox9.Text
		cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = PurID
		cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = restartdate
		cmd.Parameters.Add("@ReorderDate", SqlDbType.DateTime).Value = redate
		cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = DateTimePicker4.Value.AddMonths(duration)

		If MsgBox("Are you sure to update order Start date with Id   : " & PurID & " ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Ok Then
			cmd.CommandText = "Update [Orders] set OrderDate=@OrderDate,ReOrderDate =@ReorderDate,EndDate =@EndDate  where OrderID ='" & PurID & "' and customerID = '" & TextBox3.Text & " '"
			Dim check As Integer = cmd.ExecuteReader().RecordsAffected
			If check > 0 Then
				MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
			Else
				MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
			End If
		End If

		Await RefreshForm()
		ComboBox9.Text = PurID
	End Function

	Private Async Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		If MsgBox("Are you sure to update payment plan ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Ok Then
			Await AddProduct1()
		End If
	End Sub

	Private Async Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		Await UpdSart()
		Await RefreshForm()
		Await LimitAllUpdate()
	End Sub

	Private Async Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		Await RefreshForm()
	End Sub

	Private Async Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		Await DeletePlanned()
		Await ChangePlan()
	End Sub

	Private Async Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
		Await DeleteOrder()
	End Sub

	Async Function DeleteOrder() As Task
		If TextBox14.Text <> "" AndAlso MsgBox("Are you sure to delete order : " & ComboBox9.SelectedValue & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Ok Then
			Order1.deleteOrder(Int(ComboBox9.Text))
			MsgBox("Order Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
		End If
		Await RefreshForm()
	End Function

	Private Async Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
		Await CalculateSlotAtt()
	End Sub

	Private Async Sub Repayment_Click(sender As Object, e As EventArgs) Handles Repayment.Click
		Await Repay()
	End Sub

	Private Async Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
		Await DeletePlanned()
		Await ChangePlan()
		Await Repay()
	End Sub

	Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
		DateTimePicker5.Value = DateTimePicker1.Value.AddDays(TextBox21.Text)
	End Sub

	Private Async Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
		Await RefreshForm()
	End Sub

	Private Async Sub ComboBox9_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox9.SelectionChangeCommitted
		Await RefreshForm()
	End Sub

	Private Async Sub ComboBox5_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox5.SelectionChangeCommitted
		Await RefreshForm()
	End Sub

	Private Async Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
		Await StopOrder()
	End Sub

	Private Async Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
		If e.KeyCode <> Keys.Enter Then Return
		Await RefreshForm()
	End Sub

	Private Async Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
		Await UpdateAllow()
	End Sub

	Async Function UpdateAllow() As Task
		If MsgBox("Are you sure to save ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
			Return
		End If

		Await Worker.RunWork(
			Sub()
				Dim cmdAllow As New SqlCommand("update customers set status='enabled' where Status='allow'", conn)
				ExecuteNonQuery(cmdAllow)
			End Sub)
	End Function

	Private Async Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
		Await RefreshForm()
	End Sub

	Private Async Sub dgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick
		Await FillPlan()
	End Sub

	Private Async Sub dgvOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOrders.KeyDown
		Await FillPlan()
	End Sub

	Private Async Sub dgvOrders_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvOrders.KeyUp
		Await FillPlan()
	End Sub

	Private Async Sub dgvOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellClick
		Await FillPlan()
	End Sub

	Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Await DeleteAllPlanned()
	End Sub
End Class

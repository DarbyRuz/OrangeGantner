Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form4

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
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents Label4 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents ComboBox4 As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBox5 As ComboBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents DataGrid1 As DataGrid
	Friend WithEvents btnEdit As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents TextBox9 As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents TextBox10 As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents ComboBox6 As ComboBox
	Friend WithEvents ComboBox7 As ComboBox
	Friend WithEvents Label18 As Label
	Friend WithEvents StartIn1 As DateTimePicker
	Friend WithEvents EndIn1 As DateTimePicker
	Friend WithEvents Out1 As DateTimePicker
	Friend WithEvents Out2 As DateTimePicker
	Friend WithEvents EndIn2 As DateTimePicker
	Friend WithEvents StartIn2 As DateTimePicker
	Friend WithEvents Out3 As DateTimePicker
	Friend WithEvents EndIn3 As DateTimePicker
	Friend WithEvents StartIn3 As DateTimePicker
	Friend WithEvents Out4 As DateTimePicker
	Friend WithEvents EndIn4 As DateTimePicker
	Friend WithEvents StartIn4 As DateTimePicker
	Friend WithEvents Out5 As DateTimePicker
	Friend WithEvents EndIn5 As DateTimePicker
	Friend WithEvents StartIn5 As DateTimePicker
	Friend WithEvents Out6 As DateTimePicker
	Friend WithEvents EndIn6 As DateTimePicker
	Friend WithEvents StartIn6 As DateTimePicker
	Friend WithEvents Out7 As DateTimePicker
	Friend WithEvents EndIn7 As DateTimePicker
	Friend WithEvents StartIn7 As DateTimePicker
	Friend WithEvents Label12 As Label
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents Button4 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents TextBox4 As TextBox
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		Label4 = New Label()
		Label1 = New Label()
		ComboBox3 = New ComboBox()
		ComboBox2 = New ComboBox()
		ComboBox1 = New ComboBox()
		Label2 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		ComboBox4 = New ComboBox()
		Label10 = New Label()
		Label3 = New Label()
		ComboBox5 = New ComboBox()
		Button1 = New Button()
		TextBox1 = New TextBox()
		Label8 = New Label()
		DataGrid1 = New DataGrid()
		btnEdit = New Button()
		btnDelete = New Button()
		Button2 = New Button()
		Button3 = New Button()
		Label9 = New Label()
		Label11 = New Label()
		TextBox7 = New TextBox()
		Label13 = New Label()
		Label14 = New Label()
		TextBox9 = New TextBox()
		Label15 = New Label()
		TextBox10 = New TextBox()
		Label16 = New Label()
		ComboBox6 = New ComboBox()
		ComboBox7 = New ComboBox()
		CheckBox4 = New CheckBox()
		CheckBox7 = New CheckBox()
		CheckBox1 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox5 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox6 = New CheckBox()
		StartIn1 = New DateTimePicker()
		Label18 = New Label()
		EndIn1 = New DateTimePicker()
		Out1 = New DateTimePicker()
		Out2 = New DateTimePicker()
		EndIn2 = New DateTimePicker()
		StartIn2 = New DateTimePicker()
		Out3 = New DateTimePicker()
		EndIn3 = New DateTimePicker()
		StartIn3 = New DateTimePicker()
		Out4 = New DateTimePicker()
		EndIn4 = New DateTimePicker()
		StartIn4 = New DateTimePicker()
		Out5 = New DateTimePicker()
		EndIn5 = New DateTimePicker()
		StartIn5 = New DateTimePicker()
		Out6 = New DateTimePicker()
		EndIn6 = New DateTimePicker()
		StartIn6 = New DateTimePicker()
		Out7 = New DateTimePicker()
		EndIn7 = New DateTimePicker()
		StartIn7 = New DateTimePicker()
		Label12 = New Label()
		Button4 = New Button()
		TextBox4 = New TextBox()
		DataGridView1 = New DataGridView()
		BindingSource1 = New BindingSource(components)
		CType(DataGrid1, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		'
		'Label4
		'
		Label4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label4.ForeColor = Color.Black
		Label4.Location = New Point(16, 32)
		Label4.Name = "Label4"
		Label4.Size = New Size(96, 16)
		Label4.TabIndex = 12
		Label4.Text = "Product Code"
		'
		'Label1
		'
		Label1.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label1.ForeColor = Color.Black
		Label1.Location = New Point(-230, 112)
		Label1.Name = "Label1"
		Label1.Size = New Size(186, 16)
		Label1.TabIndex = 11
		Label1.Text = "Client Name"
		'
		'ComboBox3
		'
		ComboBox3.BackColor = SystemColors.HighlightText
		ComboBox3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox3.ForeColor = Color.Black
		ComboBox3.Location = New Point(120, 72)
		ComboBox3.Name = "ComboBox3"
		ComboBox3.Size = New Size(168, 21)
		ComboBox3.TabIndex = 10
		ComboBox3.Text = "ComboBox3"
		'
		'ComboBox2
		'
		ComboBox2.BackColor = SystemColors.HighlightText
		ComboBox2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox2.ForeColor = Color.Black
		ComboBox2.Location = New Point(120, 48)
		ComboBox2.Name = "ComboBox2"
		ComboBox2.Size = New Size(168, 21)
		ComboBox2.TabIndex = 9
		ComboBox2.Text = "ComboBox2"
		'
		'ComboBox1
		'
		ComboBox1.BackColor = SystemColors.HighlightText
		ComboBox1.DisplayMember = "First Name"
		ComboBox1.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox1.ForeColor = Color.Black
		ComboBox1.Location = New Point(120, 24)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(168, 21)
		ComboBox1.TabIndex = 8
		ComboBox1.Text = "ComboBox1"
		ComboBox1.ValueMember = "First Name"
		'
		'Label2
		'
		Label2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label2.ForeColor = Color.Black
		Label2.Location = New Point(16, 56)
		Label2.Name = "Label2"
		Label2.Size = New Size(96, 16)
		Label2.TabIndex = 14
		Label2.Text = "Product Name"
		'
		'Label5
		'
		Label5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label5.ForeColor = Color.Black
		Label5.Location = New Point(16, 80)
		Label5.Name = "Label5"
		Label5.Size = New Size(104, 16)
		Label5.TabIndex = 16
		Label5.Text = "Product description"
		'
		'Label6
		'
		Label6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label6.ForeColor = Color.Black
		Label6.Location = New Point(16, 152)
		Label6.Name = "Label6"
		Label6.Size = New Size(96, 16)
		Label6.TabIndex = 17
		Label6.Text = "Quantity"
		'
		'Label7
		'
		Label7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label7.ForeColor = Color.Black
		Label7.Location = New Point(224, 544)
		Label7.Name = "Label7"
		Label7.Size = New Size(104, 16)
		Label7.TabIndex = 18
		Label7.Text = "Unit Price"
		Label7.Visible = False
		'
		'TextBox2
		'
		TextBox2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox2.ForeColor = Color.Black
		TextBox2.Location = New Point(120, 144)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(88, 21)
		TextBox2.TabIndex = 21
		TextBox2.Text = "1"
		'
		'TextBox3
		'
		TextBox3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox3.ForeColor = Color.Black
		TextBox3.Location = New Point(288, 584)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(88, 21)
		TextBox3.TabIndex = 22
		TextBox3.Text = "100"
		TextBox3.Visible = False
		'
		'ComboBox4
		'
		ComboBox4.BackColor = SystemColors.HighlightText
		ComboBox4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox4.ForeColor = Color.Black
		ComboBox4.Location = New Point(120, 96)
		ComboBox4.Name = "ComboBox4"
		ComboBox4.Size = New Size(168, 21)
		ComboBox4.TabIndex = 27
		ComboBox4.Text = "ComboBox4"
		'
		'Label10
		'
		Label10.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label10.ForeColor = Color.Black
		Label10.Location = New Point(16, 104)
		Label10.Name = "Label10"
		Label10.Size = New Size(96, 16)
		Label10.TabIndex = 28
		Label10.Text = "Product Category"
		'
		'Label3
		'
		Label3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label3.ForeColor = Color.Black
		Label3.Location = New Point(16, 128)
		Label3.Name = "Label3"
		Label3.Size = New Size(96, 16)
		Label3.TabIndex = 30
		Label3.Text = " Unit"
		'
		'ComboBox5
		'
		ComboBox5.BackColor = SystemColors.HighlightText
		ComboBox5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox5.ForeColor = Color.Black
		ComboBox5.Location = New Point(120, 120)
		ComboBox5.Name = "ComboBox5"
		ComboBox5.Size = New Size(96, 21)
		ComboBox5.TabIndex = 29
		ComboBox5.Text = "ComboBox5"
		'
		'Button1
		'
		Button1.ForeColor = Color.Black
		Button1.Location = New Point(440, 8)
		Button1.Name = "Button1"
		Button1.Size = New Size(56, 23)
		Button1.TabIndex = 31
		Button1.Text = "Save"
		'
		'TextBox1
		'
		TextBox1.Enabled = False
		TextBox1.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox1.ForeColor = Color.Black
		TextBox1.Location = New Point(104, 544)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(56, 23)
		TextBox1.TabIndex = 33
		TextBox1.Text = "1"
		'
		'Label8
		'
		Label8.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label8.ForeColor = Color.Black
		Label8.Location = New Point(0, 544)
		Label8.Name = "Label8"
		Label8.Size = New Size(80, 16)
		Label8.TabIndex = 32
		Label8.Text = "Product ID"
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
		DataGrid1.ForeColor = Color.Black
		DataGrid1.GridLineColor = Color.DarkGray
		DataGrid1.HeaderBackColor = Color.DarkGreen
		DataGrid1.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.HeaderForeColor = Color.White
		DataGrid1.LinkColor = Color.DarkGreen
		DataGrid1.Location = New Point(376, 32)
		DataGrid1.Name = "DataGrid1"
		DataGrid1.ParentRowsBackColor = Color.Gainsboro
		DataGrid1.ParentRowsForeColor = Color.Black
		DataGrid1.SelectionBackColor = Color.DarkSeaGreen
		DataGrid1.SelectionForeColor = Color.Black
		DataGrid1.Size = New Size(832, 535)
		DataGrid1.TabIndex = 34
		'
		'btnEdit
		'
		btnEdit.ForeColor = Color.Black
		btnEdit.Location = New Point(24, 600)
		btnEdit.Name = "btnEdit"
		btnEdit.Size = New Size(112, 23)
		btnEdit.TabIndex = 35
		btnEdit.Text = "Edit/Save"
		'
		'btnDelete
		'
		btnDelete.ForeColor = Color.Black
		btnDelete.Location = New Point(24, 632)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(112, 23)
		btnDelete.TabIndex = 36
		btnDelete.Text = "Delete"
		'
		'Button2
		'
		Button2.ForeColor = Color.Black
		Button2.Location = New Point(384, 8)
		Button2.Name = "Button2"
		Button2.Size = New Size(56, 24)
		Button2.TabIndex = 37
		Button2.Text = "New"
		'
		'Button3
		'
		Button3.ForeColor = Color.Black
		Button3.Location = New Point(160, 624)
		Button3.Name = "Button3"
		Button3.Size = New Size(56, 16)
		Button3.TabIndex = 38
		Button3.Text = "Button3"
		Button3.Visible = False
		'
		'Label9
		'
		Label9.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label9.ForeColor = Color.Black
		Label9.Location = New Point(40, 304)
		Label9.Name = "Label9"
		Label9.Size = New Size(80, 16)
		Label9.TabIndex = 39
		Label9.Text = "Start Check In  "
		'
		'Label11
		'
		Label11.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label11.ForeColor = Color.Black
		Label11.Location = New Point(256, 304)
		Label11.Name = "Label11"
		Label11.Size = New Size(80, 16)
		Label11.TabIndex = 41
		Label11.Text = "Check-out till"
		'
		'TextBox7
		'
		TextBox7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox7.ForeColor = Color.Black
		TextBox7.Location = New Point(120, 168)
		TextBox7.Name = "TextBox7"
		TextBox7.Size = New Size(88, 21)
		TextBox7.TabIndex = 46
		TextBox7.Text = "1"
		'
		'Label13
		'
		Label13.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label13.ForeColor = Color.Black
		Label13.Location = New Point(16, 176)
		Label13.Name = "Label13"
		Label13.Size = New Size(88, 16)
		Label13.TabIndex = 45
		Label13.Text = "Attendance limit "
		'
		'Label14
		'
		Label14.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label14.ForeColor = Color.Black
		Label14.Location = New Point(16, 200)
		Label14.Name = "Label14"
		Label14.Size = New Size(112, 16)
		Label14.TabIndex = 47
		Label14.Text = "Attendance limit per:"
		'
		'TextBox9
		'
		TextBox9.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox9.ForeColor = Color.Black
		TextBox9.Location = New Point(120, 216)
		TextBox9.Name = "TextBox9"
		TextBox9.Size = New Size(88, 21)
		TextBox9.TabIndex = 50
		TextBox9.Text = "1"
		TextBox9.Visible = False
		'
		'Label15
		'
		Label15.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label15.ForeColor = Color.Black
		Label15.Location = New Point(16, 224)
		Label15.Name = "Label15"
		Label15.Size = New Size(80, 16)
		Label15.TabIndex = 49
		Label15.Text = "Max freezing "
		Label15.Visible = False
		'
		'TextBox10
		'
		TextBox10.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		TextBox10.ForeColor = Color.Black
		TextBox10.Location = New Point(120, 240)
		TextBox10.Name = "TextBox10"
		TextBox10.Size = New Size(88, 21)
		TextBox10.TabIndex = 52
		TextBox10.Text = "1"
		TextBox10.Visible = False
		'
		'Label16
		'
		Label16.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label16.ForeColor = Color.Black
		Label16.Location = New Point(16, 248)
		Label16.Name = "Label16"
		Label16.Size = New Size(88, 16)
		Label16.TabIndex = 51
		Label16.Text = "Additional period"
		Label16.Visible = False
		'
		'ComboBox6
		'
		ComboBox6.BackColor = SystemColors.HighlightText
		ComboBox6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox6.ForeColor = Color.Black
		ComboBox6.Items.AddRange(New Object() {"Day", "Week", "Month", "Year"})
		ComboBox6.Location = New Point(120, 192)
		ComboBox6.Name = "ComboBox6"
		ComboBox6.Size = New Size(96, 21)
		ComboBox6.TabIndex = 53
		'
		'ComboBox7
		'
		ComboBox7.BackColor = SystemColors.HighlightText
		ComboBox7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		ComboBox7.ForeColor = Color.Black
		ComboBox7.Items.AddRange(New Object() {"mon-fri", "sat-sun"})
		ComboBox7.Location = New Point(176, 576)
		ComboBox7.Name = "ComboBox7"
		ComboBox7.Size = New Size(96, 21)
		ComboBox7.TabIndex = 54
		ComboBox7.Visible = False
		'
		'CheckBox4
		'
		CheckBox4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox4.ForeColor = SystemColors.ControlText
		CheckBox4.Location = New Point(0, 400)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(40, 16)
		CheckBox4.TabIndex = 58
		CheckBox4.Text = "4"
		'
		'CheckBox7
		'
		CheckBox7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox7.ForeColor = SystemColors.ControlText
		CheckBox7.Location = New Point(0, 472)
		CheckBox7.Name = "CheckBox7"
		CheckBox7.Size = New Size(40, 16)
		CheckBox7.TabIndex = 61
		CheckBox7.Text = "7"
		'
		'CheckBox1
		'
		CheckBox1.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox1.ForeColor = SystemColors.ControlText
		CheckBox1.Location = New Point(0, 328)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(32, 16)
		CheckBox1.TabIndex = 55
		CheckBox1.Text = "1"
		'
		'CheckBox2
		'
		CheckBox2.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox2.ForeColor = SystemColors.ControlText
		CheckBox2.Location = New Point(0, 352)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(40, 16)
		CheckBox2.TabIndex = 56
		CheckBox2.Text = "2"
		'
		'CheckBox5
		'
		CheckBox5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox5.ForeColor = SystemColors.ControlText
		CheckBox5.Location = New Point(0, 424)
		CheckBox5.Name = "CheckBox5"
		CheckBox5.Size = New Size(40, 16)
		CheckBox5.TabIndex = 59
		CheckBox5.Text = "5"
		'
		'CheckBox3
		'
		CheckBox3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox3.ForeColor = SystemColors.ControlText
		CheckBox3.Location = New Point(0, 376)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(40, 16)
		CheckBox3.TabIndex = 57
		CheckBox3.Text = "3"
		'
		'CheckBox6
		'
		CheckBox6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		CheckBox6.ForeColor = SystemColors.ControlText
		CheckBox6.Location = New Point(0, 448)
		CheckBox6.Name = "CheckBox6"
		CheckBox6.Size = New Size(40, 16)
		CheckBox6.TabIndex = 60
		CheckBox6.Text = "6"
		'
		'StartIn1
		'
		StartIn1.Checked = False
		StartIn1.CustomFormat = ""
		StartIn1.Format = DateTimePickerFormat.Time
		StartIn1.Location = New Point(32, 328)
		StartIn1.Name = "StartIn1"
		StartIn1.Size = New Size(96, 20)
		StartIn1.TabIndex = 68
		StartIn1.Value = New Date(2015, 8, 29, 0, 0, 0, 0)
		'
		'Label18
		'
		Label18.Location = New Point(8, 0)
		Label18.Name = "Label18"
		Label18.Size = New Size(112, 24)
		Label18.TabIndex = 69
		Label18.Text = "Label18"
		'
		'EndIn1
		'
		EndIn1.Format = DateTimePickerFormat.Time
		EndIn1.Location = New Point(152, 328)
		EndIn1.Name = "EndIn1"
		EndIn1.Size = New Size(80, 20)
		EndIn1.TabIndex = 70
		'
		'Out1
		'
		Out1.Format = DateTimePickerFormat.Time
		Out1.Location = New Point(256, 328)
		Out1.Name = "Out1"
		Out1.Size = New Size(80, 20)
		Out1.TabIndex = 71
		'
		'Out2
		'
		Out2.Format = DateTimePickerFormat.Time
		Out2.Location = New Point(256, 352)
		Out2.Name = "Out2"
		Out2.Size = New Size(80, 20)
		Out2.TabIndex = 74
		'
		'EndIn2
		'
		EndIn2.Format = DateTimePickerFormat.Time
		EndIn2.Location = New Point(152, 352)
		EndIn2.Name = "EndIn2"
		EndIn2.Size = New Size(80, 20)
		EndIn2.TabIndex = 73
		'
		'StartIn2
		'
		StartIn2.Format = DateTimePickerFormat.Time
		StartIn2.Location = New Point(32, 352)
		StartIn2.Name = "StartIn2"
		StartIn2.Size = New Size(96, 20)
		StartIn2.TabIndex = 72
		'
		'Out3
		'
		Out3.Format = DateTimePickerFormat.Time
		Out3.Location = New Point(256, 376)
		Out3.Name = "Out3"
		Out3.Size = New Size(80, 20)
		Out3.TabIndex = 77
		'
		'EndIn3
		'
		EndIn3.Format = DateTimePickerFormat.Time
		EndIn3.Location = New Point(152, 376)
		EndIn3.Name = "EndIn3"
		EndIn3.Size = New Size(80, 20)
		EndIn3.TabIndex = 76
		'
		'StartIn3
		'
		StartIn3.Format = DateTimePickerFormat.Time
		StartIn3.Location = New Point(32, 376)
		StartIn3.Name = "StartIn3"
		StartIn3.Size = New Size(96, 20)
		StartIn3.TabIndex = 75
		'
		'Out4
		'
		Out4.Format = DateTimePickerFormat.Time
		Out4.Location = New Point(256, 400)
		Out4.Name = "Out4"
		Out4.Size = New Size(80, 20)
		Out4.TabIndex = 80
		'
		'EndIn4
		'
		EndIn4.Format = DateTimePickerFormat.Time
		EndIn4.Location = New Point(152, 400)
		EndIn4.Name = "EndIn4"
		EndIn4.Size = New Size(80, 20)
		EndIn4.TabIndex = 79
		'
		'StartIn4
		'
		StartIn4.Format = DateTimePickerFormat.Time
		StartIn4.Location = New Point(32, 400)
		StartIn4.Name = "StartIn4"
		StartIn4.Size = New Size(96, 20)
		StartIn4.TabIndex = 78
		'
		'Out5
		'
		Out5.Format = DateTimePickerFormat.Time
		Out5.Location = New Point(256, 424)
		Out5.Name = "Out5"
		Out5.Size = New Size(80, 20)
		Out5.TabIndex = 83
		'
		'EndIn5
		'
		EndIn5.Format = DateTimePickerFormat.Time
		EndIn5.Location = New Point(152, 424)
		EndIn5.Name = "EndIn5"
		EndIn5.Size = New Size(80, 20)
		EndIn5.TabIndex = 82
		'
		'StartIn5
		'
		StartIn5.Format = DateTimePickerFormat.Time
		StartIn5.Location = New Point(32, 424)
		StartIn5.Name = "StartIn5"
		StartIn5.Size = New Size(96, 20)
		StartIn5.TabIndex = 81
		'
		'Out6
		'
		Out6.Format = DateTimePickerFormat.Time
		Out6.Location = New Point(256, 448)
		Out6.Name = "Out6"
		Out6.Size = New Size(80, 20)
		Out6.TabIndex = 86
		'
		'EndIn6
		'
		EndIn6.Format = DateTimePickerFormat.Time
		EndIn6.Location = New Point(152, 448)
		EndIn6.Name = "EndIn6"
		EndIn6.Size = New Size(80, 20)
		EndIn6.TabIndex = 85
		'
		'StartIn6
		'
		StartIn6.Format = DateTimePickerFormat.Time
		StartIn6.Location = New Point(32, 448)
		StartIn6.Name = "StartIn6"
		StartIn6.Size = New Size(96, 20)
		StartIn6.TabIndex = 84
		'
		'Out7
		'
		Out7.Format = DateTimePickerFormat.Time
		Out7.Location = New Point(256, 472)
		Out7.Name = "Out7"
		Out7.Size = New Size(80, 20)
		Out7.TabIndex = 89
		'
		'EndIn7
		'
		EndIn7.Format = DateTimePickerFormat.Time
		EndIn7.Location = New Point(152, 472)
		EndIn7.Name = "EndIn7"
		EndIn7.Size = New Size(80, 20)
		EndIn7.TabIndex = 88
		'
		'StartIn7
		'
		StartIn7.Format = DateTimePickerFormat.Time
		StartIn7.Location = New Point(32, 472)
		StartIn7.Name = "StartIn7"
		StartIn7.Size = New Size(96, 20)
		StartIn7.TabIndex = 87
		'
		'Label12
		'
		Label12.Font = New Font("Tahoma", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 204)
		Label12.ForeColor = Color.Black
		Label12.Location = New Point(152, 304)
		Label12.Name = "Label12"
		Label12.Size = New Size(80, 16)
		Label12.TabIndex = 90
		Label12.Text = "End Check In  "
		'
		'Button4
		'
		Button4.Location = New Point(320, 176)
		Button4.Name = "Button4"
		Button4.Size = New Size(32, 40)
		Button4.TabIndex = 91
		Button4.Text = "Button4"
		Button4.Visible = False
		'
		'TextBox4
		'
		TextBox4.Location = New Point(280, 640)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(72, 20)
		TextBox4.TabIndex = 92
		TextBox4.Text = "TextBox4"
		TextBox4.Visible = False
		'
		'DataGridView1
		'
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(376, 564)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.Size = New Size(815, 95)
		DataGridView1.TabIndex = 93
		'
		'Form4
		'
		AutoScaleBaseSize = New Size(5, 13)
		ClientSize = New Size(1256, 742)
		Controls.Add(DataGridView1)
		Controls.Add(TextBox4)
		Controls.Add(Button4)
		Controls.Add(Label12)
		Controls.Add(Out7)
		Controls.Add(EndIn7)
		Controls.Add(StartIn7)
		Controls.Add(Out6)
		Controls.Add(EndIn6)
		Controls.Add(StartIn6)
		Controls.Add(Out5)
		Controls.Add(EndIn5)
		Controls.Add(StartIn5)
		Controls.Add(Out4)
		Controls.Add(EndIn4)
		Controls.Add(StartIn4)
		Controls.Add(Out3)
		Controls.Add(EndIn3)
		Controls.Add(StartIn3)
		Controls.Add(Out2)
		Controls.Add(EndIn2)
		Controls.Add(StartIn2)
		Controls.Add(Out1)
		Controls.Add(EndIn1)
		Controls.Add(Label18)
		Controls.Add(StartIn1)
		Controls.Add(CheckBox4)
		Controls.Add(CheckBox7)
		Controls.Add(CheckBox1)
		Controls.Add(CheckBox2)
		Controls.Add(CheckBox5)
		Controls.Add(CheckBox3)
		Controls.Add(CheckBox6)
		Controls.Add(ComboBox7)
		Controls.Add(ComboBox6)
		Controls.Add(TextBox10)
		Controls.Add(Label16)
		Controls.Add(TextBox9)
		Controls.Add(Label15)
		Controls.Add(Label14)
		Controls.Add(TextBox7)
		Controls.Add(Label13)
		Controls.Add(Label11)
		Controls.Add(Label9)
		Controls.Add(Button3)
		Controls.Add(Button2)
		Controls.Add(btnDelete)
		Controls.Add(btnEdit)
		Controls.Add(DataGrid1)
		Controls.Add(TextBox1)
		Controls.Add(Label8)
		Controls.Add(Button1)
		Controls.Add(Label3)
		Controls.Add(ComboBox5)
		Controls.Add(Label10)
		Controls.Add(ComboBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label2)
		Controls.Add(Label4)
		Controls.Add(Label1)
		Controls.Add(ComboBox3)
		Controls.Add(ComboBox2)
		Controls.Add(ComboBox1)
		ForeColor = SystemColors.ControlText
		Name = "Form4"
		Text = "NewProduct"
		WindowState = FormWindowState.Maximized
		CType(DataGrid1, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim control As Control
		For Each control In Controls
			If (control.GetType() Is GetType(DateTimePicker)) Then
				Dim dateTimePicker = CType(control, DateTimePicker)
				dateTimePicker.Format = DateTimePickerFormat.Time
				dateTimePicker.ShowUpDown = True
				dateTimePicker.Value = "01.01.1900 0:00:00"
			End If
		Next

		Dim weekday = DateAndTime.Weekday(Today)
		If weekday = 1 Then Label18.Text = "Sunday"
		If weekday = 2 Then Label18.Text = "Monday"
		If weekday = 3 Then Label18.Text = "Tuesday"
		If weekday = 4 Then Label18.Text = "Wednesday"
		If weekday = 5 Then Label18.Text = "Thursday"
		If weekday = 6 Then Label18.Text = "Friday"
		If weekday = 7 Then Label18.Text = "Saturday"

		Dim dataSet As New DataSet()

		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}

		AddHandler worker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				ReadyConnectionF()

				Dim DAProduct As New SqlDataAdapter("select * from Products", conn)
				DAProduct.Fill(dataSet, "dtProduct")

				Dim DAUnit As New SqlDataAdapter("select * from UnitType", conn)
				DAUnit.Fill(dataSet, "Unittype")

				Dim DAPrCategory As New SqlDataAdapter("select * from ProductCategory", conn)
				DAPrCategory.Fill(dataSet, "ProductCategory")

				Dim DATarrifs As New SqlDataAdapter("SELECT  * FROM Tariffs", conn)
				DATarrifs.Fill(dataSet, "Tariffs")

				Dim DATarifftype As New SqlDataAdapter("select * from TariffType", conn)
				DATarifftype.Fill(dataSet, "TariffType")

				Dim DAMaxID As New SqlDataAdapter("select max(ID) AS MaxID from Products", conn)
				DAMaxID.Fill(dataSet, "MaxID")

				Dim dataAdapter As New SqlDataAdapter("Select * from ProdTimefrm", conn)
				dataAdapter.Fill(dataSet, "products")
			End Sub

		AddHandler worker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				If args.Error IsNot Nothing Then
					Dim ex = args.Error
					MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
					Exit Sub
				End If

				DataGrid1.DataSource = dataSet
				DataGrid1.DataMember = "products"
				DataGrid1.ReadOnly = True
			End Sub

		worker.RunWorkerAsync()

		With ComboBox1
			.DisplayMember = "Tariffs.TariffName"
			.ValueMember = "TariffID"
			.DataSource = dataSet
		End With

		With ComboBox2
			.DisplayMember = "Tariffs.TariffCategory"
			.ValueMember = "TariffID"
			.DataSource = dataSet
		End With

		With ComboBox3
			.DisplayMember = "TariffType.TariffType"
			.ValueMember = "ID"
			.DataSource = dataSet
		End With

		With ComboBox4
			.DisplayMember = "ProductCategory.ProductCategory"
			.ValueMember = "ID"
			.DataSource = dataSet
		End With

		With ComboBox5
			.DisplayMember = "Unittype.Unit"
			.ValueMember = "ID"
			.DataSource = dataSet
		End With

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		ComboBox1.Text = ""
		ComboBox2.Text = ""
		ComboBox3.Text = ""
		ComboBox4.Text = ""
		ComboBox5.Text = ""
		ComboBox6.Text = ""

		Dim column As New DataGridTextBoxColumn With {
			.MappingName = "ProductID",
			.HeaderText = "ID",
			.Width = 30
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "ProductName",
			.HeaderText = "Name",
			.Width = 140
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "QuantityPerUnit",
			.HeaderText = "QuantityPerUnit"
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "UnitPrice",
			.HeaderText = "UnitPrice"
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "UnitsInStock",
			.HeaderText = "UnitsInStock"
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "UnitsOnOrder",
			.HeaderText = "UnitsOnOrder"
		}

		column = New DataGridTextBoxColumn With {
			.MappingName = "ReorderLevel",
			.HeaderText = "ReorderLevel"
		}

		Button1.Enabled = False
	End Sub

	Private Sub Refresh_Form()
		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		ComboBox1.Text = ""
		ComboBox2.Text = ""
		ComboBox3.Text = ""
		ComboBox4.Text = ""
		ComboBox5.Text = ""
		ComboBox6.Text = ""
		TextBox4.Text = "0"
		ComboBox7.Text = ""
		TextBox7.Text = "0"
		TextBox9.Text = "0"
		TextBox10.Text = "0"

		Dim dataSet As New DataSet()
		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}

		AddHandler worker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				ReadyConnectionF()

				Dim command As New SqlCommand("Select * from ProdTimefrm", conn)
				Dim dataAdapter As New SqlDataAdapter(command)
				dataAdapter.Fill(dataSet, "ProdTimefrm")
			End Sub

		AddHandler worker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				If args.Error IsNot Nothing Then
					Dim ex = args.Error
					MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
					Exit Sub
				End If

				DataGrid1.DataSource = dataSet
				DataGrid1.DataMember = "ProdTimefrm"
				DataGrid1.ReadOnly = True
			End Sub

		worker.RunWorkerAsync()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Then
			MsgBox("Product Data is not completed", MsgBoxStyle.OkOnly)
		ElseIf MsgBox("Are you sure to save Product?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Ok Then
			Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}

			AddHandler worker.DoWork,
				Sub(workSender As Object, args As DoWorkEventArgs)
					ReadyConnectionF()

					Dim command As New SqlCommand("insert into Products(id,ProductCode, ProductName ,Unitype ,StandardCost,Category , Description, Quantity,CheckIn,CheckOut,Weekday,AttLimit,AttLimitPer,AdditionalPeriod,MaxLimit)" & "VALUES (@id,@ProductCode, @ProductName ,@Unitype ,@StandardCost,@Category , @Description, @Quantity,@CheckIn,@CheckOut,@Weekday,@AttLimit,@AttLimitPer,@AdditionalPeriod,@MaxLimit)", conn)
					command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Label8.Text
					command.Parameters.Add("@ProductCode", SqlDbType.NVarChar).Value = ComboBox1.Text
					command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = ComboBox2.Text
					command.Parameters.Add("@Unitype", SqlDbType.NVarChar).Value = ComboBox5.Text
					command.Parameters.Add("@StandardCost", SqlDbType.Int).Value = If(TextBox3.Text <> "", CInt(TextBox3.Text), 0)
					command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = ComboBox4.Text
					command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ComboBox3.Text
					command.Parameters.Add("@Quantity", SqlDbType.Int).Value = If(TextBox2.Text <> "", CInt(TextBox2.Text), 0)
					command.Parameters.Add("@CheckIn", SqlDbType.SmallInt).Value = 0
					command.Parameters.Add("@CheckOut", SqlDbType.SmallInt).Value = 0
					command.Parameters.Add("@Weekday", SqlDbType.NVarChar).Value = ComboBox7.Text
					command.Parameters.Add("@AttLimit", SqlDbType.Int).Value = TextBox7.Text
					command.Parameters.Add("@AttLimitPer", SqlDbType.NChar).Value = ComboBox6.Text
					command.Parameters.Add("@AdditionalPeriod", SqlDbType.Int).Value = TextBox10.Text
					command.Parameters.Add("@MaxLimit", SqlDbType.Int).Value = TextBox9.Text
					command.ExecuteNonQuery()
				End Sub

			AddHandler worker.RunWorkerCompleted,
				Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
					If args.Error IsNot Nothing Then
						Dim ex = args.Error
						MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
						Exit Sub
					End If

					Refresh_Form()
					MsgBox("Product succesfully to added", MsgBoxStyle.OkOnly, "Message :")
				End Sub

			worker.RunWorkerAsync()
		Else
			MsgBox("Product  Failure to added", MsgBoxStyle.OkOnly, "Message :")
		End If

		Button1.Enabled = False
	End Sub

	Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
		Dim currencyManager = CType(BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)
		Dim dataView = CType(currencyManager.List, DataView)
		Dim dataRow = dataView.Item(currencyManager.Position).Row
		dataRow.BeginEdit()
		DataGrid1.ReadOnly = False
		Refresh_Form()
	End Sub

	Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim currencyManager = CType(BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)
		Dim dataView = CType(currencyManager.List, DataView)
		Dim dataRow = dataView.Item(currencyManager.Position).Row
		Dim stringId = dataRow(0).ToString()

		If MsgBox("Are you sure to delete data with Id : " & TextBox1.Text & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
			Exit Sub
		End If

		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
		Dim check1 As New Integer

		AddHandler worker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				Dim conn As SqlConnection = GetConnect()

				conn.Open()
				Dim command1 As New SqlCommand("DELETE FROM Products WHERE Id ='" & stringId & "'", conn)
				check1 = command1.ExecuteReader().RecordsAffected
				conn.Close()

				conn.Open()
				Dim command2 As New SqlCommand("DELETE FROM ProductTime WHERE ProductId ='" & stringId & "'", conn)
				Dim chack2 = command2.ExecuteReader().RecordsAffected
				conn.Close()
			End Sub

		AddHandler worker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				If args.Error IsNot Nothing Then
					Dim ex = args.Error
					MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
					Exit Sub
				End If

				If check1 > 0 Then
					MsgBox("Product With Id " & Trim(TextBox1.Text) & " Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
				Else
					MsgBox("Product With Id " & Trim(TextBox1.Text) & " Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
				End If

				Refresh_Form()
			End Sub

		worker.RunWorkerAsync()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Button1.Enabled = True

		Dim id As New Object
		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}

		AddHandler worker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				ReadyConnectionF()
				Dim commandId As New SqlCommand("select max(ID)  from Products", conn)
				id = commandId.ExecuteScalar()
			End Sub

		AddHandler worker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				If args.Error IsNot Nothing Then
					Dim ex = args.Error
					MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
					Exit Sub
				End If

				Label8.Text = 1 + If(IsDBNull(id), 0, CInt(id))
				Refresh_Form()
			End Sub

		worker.RunWorkerAsync()
	End Sub

	Private Sub DataGrid1_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid1.DoubleClick
		TextBox1.Text = DataGrid1(DataGrid1.CurrentRowIndex, 0)
		ComboBox2.Text = DataGrid1(DataGrid1.CurrentRowIndex, 2)
		ComboBox1.Text = DataGrid1(DataGrid1.CurrentRowIndex, 1)
		ComboBox4.Text = DataGrid1(DataGrid1.CurrentRowIndex, 5)
		ComboBox5.Text = If(IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 3)), String.Empty, DataGrid1(DataGrid1.CurrentRowIndex, 3))
		TextBox2.Text = If(IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 6)), 1, DataGrid1(DataGrid1.CurrentRowIndex, 6))
		ComboBox3.Text = If(IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 4)), String.Empty, DataGrid1(DataGrid1.CurrentRowIndex, 4))
		TextBox7.Text = If(IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 7)), 0, DataGrid1(DataGrid1.CurrentRowIndex, 7))
		ComboBox6.Text = If(IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 8)), String.Empty, DataGrid1(DataGrid1.CurrentRowIndex, 8))
	End Sub

	Private Sub StartIn1_ValueChanged(sender As Object, e As EventArgs) Handles StartIn1.ValueChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				dtime.Checked = (Microsoft.VisualBasic.Right(dtime.Name, 1) = Microsoft.VisualBasic.Right(dtime.Name, 1))
			End If
		Next
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 1 And CheckBox1.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox1.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 1 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 2 And CheckBox2.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox2.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 2 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 3 And CheckBox3.Checked = True Then
					dtime.Checked = True
				ElseIf CheckBox3.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 3 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 4 And CheckBox4.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox4.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 4 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 5 And CheckBox5.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox5.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 5 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 6 And CheckBox6.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox6.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 6 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub

	Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
		Dim ctrl As Control
		For Each ctrl In Controls
			If (ctrl.GetType() Is GetType(DateTimePicker)) Then
				Dim dtime = CType(ctrl, DateTimePicker)
				If Microsoft.VisualBasic.Right(dtime.Name, 1) = 7 And CheckBox7.Checked = True Then
					dtime.Checked = True
					Debug.Write(Microsoft.VisualBasic.Right(dtime.Name, 1))
				ElseIf CheckBox7.Checked = False And Microsoft.VisualBasic.Right(dtime.Name, 1) = 7 Then
					dtime.Checked = False
				End If
			End If
		Next
	End Sub
End Class

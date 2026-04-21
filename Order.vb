Imports System.Data.SqlClient
Imports System.Globalization
Public Class Order
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtGuest As TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DataView1 = New System.Data.DataView()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGrid3 = New System.Windows.Forms.DataGrid()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(32, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 24)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Slot"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox7.Location = New System.Drawing.Point(176, 224)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(32, 22)
        Me.TextBox7.TabIndex = 101
        Me.TextBox7.Text = "1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(360, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Discount"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox6.Location = New System.Drawing.Point(352, 40)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 22)
        Me.TextBox6.TabIndex = 99
        Me.TextBox6.Text = "0"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label12.Location = New System.Drawing.Point(32, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 24)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Duration(month)"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(176, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 22)
        Me.TextBox1.TabIndex = 88
        Me.TextBox1.Text = "12"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(32, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Contract Activation date"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CalendarForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker5.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.DateTimePicker5.CalendarTitleForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy "
        Me.DateTimePicker5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(176, 96)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker5.TabIndex = 86
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CalendarForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker4.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.DateTimePicker4.CalendarTitleForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker4.CustomFormat = "dd/MM/yyyy "
        Me.DateTimePicker4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(176, 160)
        Me.DateTimePicker4.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker4.TabIndex = 85
        Me.DateTimePicker4.Value = New Date(2014, 7, 3, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(32, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Contract creation date"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker3.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.DateTimePicker3.CalendarTitleForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy "
        Me.DateTimePicker3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(176, 64)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker3.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(432, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Manager"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(432, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Client"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.Location = New System.Drawing.Point(528, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox1.TabIndex = 77
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ComboBox11
        '
        Me.ComboBox11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox11.Location = New System.Drawing.Point(514, 115)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox11.TabIndex = 79
        Me.ComboBox11.Visible = False
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(32, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Contract deadline"
        '
        'ComboBox9
        '
        Me.ComboBox9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox9.Location = New System.Drawing.Point(672, 56)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox9.TabIndex = 110
        Me.ComboBox9.Text = "ComboBox9"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox2.Location = New System.Drawing.Point(524, 96)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(300, 24)
        Me.ComboBox2.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(592, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Card ID"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox3.Location = New System.Drawing.Point(664, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox3.TabIndex = 111
        Me.ComboBox3.Text = "ComboBox3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(32, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Weekly attendance"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(176, 312)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(48, 22)
        Me.TextBox9.TabIndex = 116
        Me.TextBox9.Text = "10000"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox10.Location = New System.Drawing.Point(208, 224)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(80, 22)
        Me.TextBox10.TabIndex = 98
        Me.TextBox10.Text = "TextBox10"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(144, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 22)
        Me.TextBox2.TabIndex = 90
        Me.TextBox2.Text = "1"
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(416, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 22)
        Me.TextBox3.TabIndex = 91
        Me.TextBox3.Text = "TextBox3"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label14.Location = New System.Drawing.Point(416, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Product Category"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(144, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Quantity"
        Me.Label13.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label15.Location = New System.Drawing.Point(696, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "UnitType"
        Me.Label15.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox4.Location = New System.Drawing.Point(696, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(64, 22)
        Me.TextBox4.TabIndex = 92
        Me.TextBox4.Text = "TextBox4"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label16.Location = New System.Drawing.Point(288, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Unit Cost"
        Me.Label16.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox5.Location = New System.Drawing.Point(280, 40)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(64, 22)
        Me.TextBox5.TabIndex = 93
        Me.TextBox5.Text = "1"
        '
        'ComboBox8
        '
        Me.ComboBox8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox8.ItemHeight = 14
        Me.ComboBox8.Location = New System.Drawing.Point(0, 40)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(144, 22)
        Me.ComboBox8.TabIndex = 82
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox12.Location = New System.Drawing.Point(520, 40)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(96, 22)
        Me.TextBox12.TabIndex = 106
        Me.TextBox12.Text = "TextBox12"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label19.Location = New System.Drawing.Point(528, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "TP Category"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox11.Location = New System.Drawing.Point(624, 40)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(64, 22)
        Me.TextBox11.TabIndex = 103
        Me.TextBox11.Text = "TextBox11"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(632, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "TP Type"
        Me.Label10.Visible = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label18.Location = New System.Drawing.Point(2, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 16)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = "Product Name"
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(800, 144)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(64, 22)
        Me.TextBox13.TabIndex = 128
        Me.TextBox13.Text = "TextBox13"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(664, 152)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(56, 22)
        Me.TextBox14.TabIndex = 130
        Me.TextBox14.Text = "TextBox14"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(0, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 24)
        Me.Label20.TabIndex = 131
        Me.Label20.Text = "Order #"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(824, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(16, 24)
        Me.Button6.TabIndex = 134
        Me.Button6.Text = "X"
        Me.Button6.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(16, 400)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(784, 20)
        Me.TextBox15.TabIndex = 135
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 376)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "Notes"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(440, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "Add Product"
        '
        'TextBox16
        '
        Me.TextBox16.Enabled = False
        Me.TextBox16.Location = New System.Drawing.Point(800, 168)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(64, 22)
        Me.TextBox16.TabIndex = 139
        Me.TextBox16.Text = "TextBox16"
        '
        'TextBox17
        '
        Me.TextBox17.Enabled = False
        Me.TextBox17.Location = New System.Drawing.Point(664, 184)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(56, 22)
        Me.TextBox17.TabIndex = 141
        Me.TextBox17.Text = "TextBox17"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(800, 196)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(68, 22)
        Me.TextBox18.TabIndex = 142
        Me.TextBox18.Text = "TextBox18"
        '
        'TextBox19
        '
        Me.TextBox19.Enabled = False
        Me.TextBox19.Location = New System.Drawing.Point(800, 120)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(56, 22)
        Me.TextBox19.TabIndex = 143
        Me.TextBox19.Text = "TextBox19"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(544, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 145
        Me.Button2.Text = "Delete Product"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(61, 23)
        Me.TabControl1.Location = New System.Drawing.Point(16, 425)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(996, 261)
        Me.TabControl1.TabIndex = 146
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox20)
        Me.TabPage1.Controls.Add(Me.TextBox24)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.ComboBox8)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.TextBox14)
        Me.TabPage1.Controls.Add(Me.TextBox17)
        Me.TabPage1.Controls.Add(Me.TextBox18)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.TextBox16)
        Me.TabPage1.Controls.Add(Me.TextBox13)
        Me.TabPage1.Controls.Add(Me.TextBox19)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(988, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DataView1
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid1.Location = New System.Drawing.Point(2, 68)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Size = New System.Drawing.Size(1089, 168)
        Me.DataGrid1.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(776, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Max Limit"
        Me.Label5.Visible = False
        '
        'TextBox20
        '
        Me.TextBox20.Enabled = False
        Me.TextBox20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox20.Location = New System.Drawing.Point(776, 40)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(64, 22)
        Me.TextBox20.TabIndex = 153
        Me.TextBox20.Text = "TextBox20"
        '
        'TextBox24
        '
        Me.TextBox24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox24.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox24.Location = New System.Drawing.Point(160, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(112, 22)
        Me.TextBox24.TabIndex = 139
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label26.Location = New System.Drawing.Point(200, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 140
        Me.Label26.Text = "Product Price"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Red
        Me.TextBox8.Location = New System.Drawing.Point(634, 119)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(112, 23)
        Me.TextBox8.TabIndex = 152
        Me.TextBox8.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGrid3)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(988, 230)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PAYMENT PLAN"
        '
        'DataGrid3
        '
        Me.DataGrid3.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGrid3.BackColor = System.Drawing.Color.White
        Me.DataGrid3.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid3.CaptionBackColor = System.Drawing.Color.Silver
        Me.DataGrid3.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid3.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.FlatMode = True
        Me.DataGrid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGrid3.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGrid3.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.DataGrid3.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid3.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid3.LinkColor = System.Drawing.Color.DarkGreen
        Me.DataGrid3.Location = New System.Drawing.Point(0, 8)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGrid3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid3.Size = New System.Drawing.Size(1024, 224)
        Me.DataGrid3.TabIndex = 143
        '
        'ListBox1
        '
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(976, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(40, 148)
        Me.ListBox1.TabIndex = 144
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.DateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.ForestGreen
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(456, 240)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker2.TabIndex = 156
        Me.DateTimePicker2.Value = New Date(2016, 12, 16, 0, 0, 0, 0)
        Me.DateTimePicker2.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button3.Location = New System.Drawing.Point(440, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 32)
        Me.Button3.TabIndex = 147
        Me.Button3.Text = "Save Order"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button5.Location = New System.Drawing.Point(549, 322)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 32)
        Me.Button5.TabIndex = 154
        Me.Button5.Text = "Delete Order"
        '
        'TextBox25
        '
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox25.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox25.Location = New System.Drawing.Point(760, 216)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(88, 29)
        Me.TextBox25.TabIndex = 168
        Me.TextBox25.Text = "0"
        Me.TextBox25.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(664, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 24)
        Me.Label27.TabIndex = 167
        Me.Label27.Text = "Surcharge"
        Me.Label27.Visible = False
        '
        'TextBox27
        '
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox27.ForeColor = System.Drawing.Color.Black
        Me.TextBox27.Location = New System.Drawing.Point(800, 256)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(48, 22)
        Me.TextBox27.TabIndex = 172
        Me.TextBox27.Text = "0"
        Me.TextBox27.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(664, 256)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 24)
        Me.Label29.TabIndex = 171
        Me.Label29.Text = "Surcharge unit price"
        Me.Label29.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.Location = New System.Drawing.Point(144, 8)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox4.TabIndex = 173
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(456, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 16)
        Me.Label24.TabIndex = 176
        '
        'TextBox26
        '
        Me.TextBox26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox26.Location = New System.Drawing.Point(896, 144)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(88, 27)
        Me.TextBox26.TabIndex = 180
        Me.TextBox26.Text = "0"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(616, 152)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 24)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "TOTAL ORDER PRICE"
        Me.Label28.Visible = False
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox23.Location = New System.Drawing.Point(896, 176)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(88, 27)
        Me.TextBox23.TabIndex = 178
        Me.TextBox23.Text = "0"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(624, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 24)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "Total Products Price"
        Me.Label8.Visible = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Green
        Me.Button7.Location = New System.Drawing.Point(936, 368)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 23)
        Me.Button7.TabIndex = 183
        Me.Button7.Text = "Save And New "
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(936, 400)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 23)
        Me.Button8.TabIndex = 184
        Me.Button8.Text = "Close"
        Me.Button8.Visible = False
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGrid2.BackColor = System.Drawing.Color.White
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.Silver
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGrid2.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid2.LinkColor = System.Drawing.Color.DarkGreen
        Me.DataGrid2.Location = New System.Drawing.Point(848, 16)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid2.Size = New System.Drawing.Size(352, 344)
        Me.DataGrid2.TabIndex = 185
        '
        'ComboBox5
        '
        Me.ComboBox5.Location = New System.Drawing.Point(712, 320)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox5.TabIndex = 186
        Me.ComboBox5.Text = "ComboBox5"
        Me.ComboBox5.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(312, 96)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 23)
        Me.Button9.TabIndex = 187
        Me.Button9.Text = "Activation Date"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(32, 256)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 23)
        Me.Label23.TabIndex = 189
        Me.Label23.Text = "Free freezing days"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(176, 256)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(64, 20)
        Me.TextBox21.TabIndex = 188
        Me.TextBox21.Text = "30"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(32, 288)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 16)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "Max freezing days"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(176, 288)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(64, 20)
        Me.TextBox22.TabIndex = 190
        Me.TextBox22.Text = "90"
        '
        'TextBox28
        '
        Me.TextBox28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(264, 128)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(40, 22)
        Me.TextBox28.TabIndex = 192
        Me.TextBox28.Text = "0"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(224, 128)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 24)
        Me.Label25.TabIndex = 193
        Me.Label25.Text = "Days"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.Location = New System.Drawing.Point(32, 337)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 23)
        Me.Label30.TabIndex = 195
        Me.Label30.Text = "Free Guests"
        '
        'txtGuest
        '
        Me.txtGuest.Location = New System.Drawing.Point(176, 337)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(64, 20)
        Me.txtGuest.TabIndex = 194
        Me.txtGuest.Text = "0"
        '
        'Order
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1448, 746)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker5)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.TextBox23)
        Me.Name = "Order"
        Me.Text = "Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    ' Public strCon As String = frmSqlConn.BuildSqlNativeConnStr(server, database, username, password)
    ' Dim connection As New SqlClient.SqlConnection(strCon)
    Private DAProducts As New SqlClient.SqlDataAdapter("SELECT  * FROM Products", conn)
    ' Private DALocation As New SqlClient.SqlDataAdapter("SELECT * FROM Locations ", connection)

    ' Private DATime As New SqlClient.SqlDataAdapter("Select * from Fix", conn)
    Private DAClient As New SqlClient.SqlDataAdapter("Select ID,CardID,[FirstName],[LastName] from Customers", conn)
    'Private DAEmployee As New SqlClient.SqlDataAdapter("Select ID,[FirstName],[LastName] from Employees", connection)
    Private DAEmployee As New SqlClient.SqlDataAdapter("Select ID,Name from Emp", conn)
    Private DAGrafik As New SqlClient.SqlDataAdapter("SELECT  * FROM CustFromOrder ", conn)
    Private DAOrders As New SqlClient.SqlDataAdapter("SELECT  * FROM orders ", conn)
    Private DAOrderID As New SqlClient.SqlDataAdapter("SELECT   max(OrderID) FROM orders ", conn)
    Private DAPayment As New SqlClient.SqlDataAdapter("SELECT  * FROM TPPaymentMethod ", conn)
    Private DAOrdersStatus As New SqlClient.SqlDataAdapter("SELECT  * FROM [Orders Status] ", conn)

    Private mctlCombo As New ComboBox()
    Private mds As New DataSet()
    Private dv As New DataView()


    Private Sub UpdateUi()
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        Me.Left = 10
        Me.Top = 10
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox11.Text = ""
        TextBox2.Text = 1
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox19.Text = ""
        Button1.Enabled = False
        Button2.Enabled = False
        Button5.Enabled = False

        DateTimePicker4.Value = DateTimePicker5.Value.AddMonths(TextBox1.Text)
        DateTimePicker4.Value = DateTimePicker4.Value.AddDays(TextBox28.Text)
        DateTimePicker2.Enabled = False
        '   Button4.Enabled = False
        TabControl1.Enabled = False
    End Sub


    Private Function ExecuteScalarAsync(ByVal command As String) As Object
        Dim connection As SqlConnection
        connection = GetSqlConnection()
        Using (connection)
            Dim sqlCommand As New SqlCommand(command, connection)
            Using sqlCommand
                Return sqlCommand.ExecuteScalar()
            End Using
        End Using
    End Function
    Private Sub Order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UpdateUi()

        Dim cmd1 As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim s, s1, s2, sql3, OrdID, OrdDetID, PayID As String
        s = "select max(OrderID)  from Orders"
        s1 = "select max(ID)  from [OrderDetails]"
        s2 = "select max(PurchaseOrderID)  from [Purchase Orders]"
        sql3 = "Select  * from OrderPackage where OrderId ='" & Trim(TextBox14.Text) & " ' "
        Dim s4 As String = "Select Name from OrderName"

        ReadyConnectionF()
        cmd1 = New SqlCommand(s, conn)
        da.SelectCommand = cmd1
        Dim sqlResult As Object = cmd1.ExecuteScalar()
        If IsDBNull(sqlResult) Then
            ' If sqlResult Is Nothing Then
            ' No result found
            TextBox14.Text = 1
            Label20.Text = 1
        Else
            da.Fill(ds, "Max")
            OrdID = sqlResult.ToString()
            TextBox14.Text = OrdID + 1
            Label20.Text = "OrderID" & OrdID + 1
        End If



        cmd1 = New SqlCommand(s1, conn)

        da.SelectCommand = cmd1
        Dim sqlResult1 As Object = cmd1.ExecuteScalar()
        If IsDBNull(sqlResult1) Then
            TextBox17.Text = 1
        Else
            sqlResult1.ToString()
            da.Fill(ds, "Max2")
            OrdDetID = cmd1.ExecuteScalar

            TextBox17.Text = OrdDetID + 1
        End If

        cmd1 = New SqlCommand(s2, conn)
        da.SelectCommand = cmd1

        If IsDBNull(sqlResult) Then
            TextBox18.Text = 1
        Else

            sqlResult.ToString()
            da.Fill(ds, "Max2")
            PayID = cmd1.ExecuteScalar()

            TextBox18.Text = PayID + 1
            ' TextBox17.Text = Int(sqlResult.ToString()) + 1
        End If



        DAOrdersStatus.Fill(mds, "Orders Status")
        'DATime.Fill(mds, "dtTime")
        DAClient.Fill(mds, "dtCustomers")
        DAEmployee.Fill(mds, "dtEmployee")
        DAPayment.Fill(mds, "TPPaymentMethod")
        DAProducts.Fill(mds, "dtProducts")

        cmd1 = New SqlCommand(s4, Connection)
        da.SelectCommand = cmd1

        da.Fill(ds, "OrderName")
        Dim i As Integer = 0



        If TextBox7.Text = "1" Then
            TextBox10.Text = "One Off"
        End If
        If TextBox7.Text >= "12" Then
            TextBox10.Text = "Montly"
        End If
        If TextBox7.Text < "12" And TextBox7.Text <> "1" Then
            TextBox10.Text = "Partial"
        End If


        With ComboBox4
            .DisplayMember = "OrderName.Name"
            .ValueMember = "Name"
            .DataSource = ds
            ' .AutoCompleteMode = AutoCompleteMode.Suggest
            ' .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        With ComboBox3
            .DisplayMember = "dtCustomers.CardID"
            .ValueMember = "ID"
            .DataSource = mds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        With ComboBox5
            .DisplayMember = "dtCustomers.ID"
            .ValueMember = "ID"
            .DataSource = mds
            '  .SelectedIndex = -1
            ' .Text = ""
        End With

        With ComboBox1
            .DisplayMember = "dtCustomers.FirstName"
            .ValueMember = "ID"
            .DataSource = mds
            ' .AutoCompleteMode = AutoCompleteMode.Suggest
            ' .AutoCompleteSource = AutoCompleteSource.ListItems
        End With


        With ComboBox9
            .DisplayMember = "dtCustomers.LastName"
            .ValueMember = "ID"
            .DataSource = mds
            '  .AutoCompleteMode = AutoCompleteMode.Suggest
            ' .AutoCompleteSource = AutoCompleteSource.ListItems
        End With



        With ComboBox2
            .DisplayMember = "dtEmployee.Name"
            .ValueMember = "ID"
            .DataSource = mds
            .Text = ""
        End With

        'With ComboBox11
        '    .DisplayMember = "dtEmployee.LastName"
        '    .ValueMember = "ID"
        '    .DataSource = mds
        '    '  .Text = ""
        'End With



        With ComboBox8
            .DisplayMember = "dtproducts.ProductName"
            .ValueMember = "ID"
            .DataSource = mds
            .SelectedIndex = -1
            ' .AutoCompleteMode = AutoCompleteMode.Suggest
            ' .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        TextBox13.DataBindings.Add("Text", mds, "dtCustomers.ID")
        TextBox2.DataBindings.Add("Text", mds, "dtproducts.Quantity")
        TextBox12.DataBindings.Add("Text", mds, "dtproducts.ProductCode")
        TextBox3.DataBindings.Add("Text", mds, "dtproducts.Category")
        TextBox4.DataBindings.Add("Text", mds, "dtproducts.Unitype")
        TextBox5.DataBindings.Add("Text", mds, "dtproducts.StandardCost")
        TextBox11.DataBindings.Add("Text", mds, "dtproducts.Description")
        TextBox20.DataBindings.Add("Text", mds, "dtproducts.MaxLimit")
        TextBox16.DataBindings.Add("Text", mds, "dtEmployee.ID")
        TextBox19.DataBindings.Add("Text", mds, "dtproducts.ID")


        allorders()


    End Sub




    Private Sub DateTimePicker5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker5.ValueChanged
        If TextBox1.Text <> "" Then
            DateTimePicker4.Value = DateTimePicker5.Value.AddMonths(TextBox1.Text)
        End If
        If TextBox28.Text <> "" Then
            DateTimePicker4.Value = DateTimePicker4.Value.AddDays(TextBox28.Text)
        End If
    End Sub





    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged


        On Error Resume Next
        If Int(TextBox7.Text) = 1 Then
            TextBox10.Text = "One Off"
            TextBox25.Text = 0
        End If
        If Int(TextBox7.Text) >= 12 Then
            TextBox10.Text = "Monthly"
            TextBox25.Text = 0
        Else
            If Int(TextBox7.Text) <> 1 And Int(TextBox7.Text) < 12 Then

                TextBox10.Text = "Partial"
                TextBox25.Text = (Int(TextBox7.Text) - 1) * Int(TextBox27.Text)
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        On Error Resume Next
        DateTimePicker4.Value = DateTimePicker5.Value.AddMonths(TextBox1.Text)
        DateTimePicker4.Value = DateTimePicker4.Value.AddDays(TextBox28.Text)
        If Int(TextBox1.Text) <= 3 Then

            TextBox21.Text = 0
            TextBox22.Text = 0
        End If
        If Int(TextBox1.Text) >= 4 And Int(TextBox1.Text) <= 6 Then

            TextBox21.Text = 15
            TextBox22.Text = 45 '30
        Else
            If Int(TextBox1.Text) >= 7 And Int(TextBox1.Text) <= 9 Then

                TextBox21.Text = 30
                TextBox22.Text = 90 '60
            Else
                If Int(TextBox1.Text) >= 10 And Int(TextBox1.Text) <= 16 Then

                    TextBox21.Text = 30
                    TextBox22.Text = 120 '90
                End If
            End If
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox1.Text = ""
        ComboBox9.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ComboBox11.Text = ""
        ComboBox2.Text = ""
        'TextBox16.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox8.Text = ""
    End Sub


    Private Sub Refresh_Form()
        ' Dim con As SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        Dim adapter3 As New SqlDataAdapter
        Dim adapter2 As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim sql, sql2, sql3 As String


        sql = "Select  * from [ProductOrder] where OrderId ='" & Trim(TextBox14.Text) & " ' "

        sql2 = "Select  SubTotal from OrderSubTotal where OrderId ='" & Trim(TextBox14.Text) & " ' "
        sql3 = "Select  * from OrderPackage where OrderId ='" & Trim(TextBox14.Text) & " ' "
        Try
            ReadyConnectionF()
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(ds, "dtOrd")

            adapter2 = New SqlDataAdapter(sql2, conn)
            adapter2.Fill(ds, "OrderSubTotal")
            cmd2 = New SqlCommand(sql2, conn)
            TextBox23.Text = cmd2.ExecuteScalar

            adapter3 = New SqlDataAdapter(sql3, conn)
            adapter3.Fill(ds, "OrderPackage")

            DataGrid1.DataSource = ds.Tables("dtOrd")
            DataGrid3.DataSource = ds.Tables("OrderPackage")
            DataGrid1.Refresh()

            DataGrid3.Refresh()
            DAProducts.Fill(mds, "dtProducts")


            '++++++++++++++

            '  Dim surcharge As Integer
            ' If TextBox25.Text <> "" Then
            ' surcharge = Int(TextBox25.Text)
            '   Else
            '   surcharge = 0
            '   End If
            '  If TextBox23.Text <> "" Then
            '   TextBox26.Text = Int(TextBox23.Text) + surcharge
            '   End If

            '++++++++++++++++




            allorders()

            TextBox19.Text = ""

            With ComboBox8
                .DisplayMember = "dtproducts.ProductName"
                .ValueMember = "ID"
                .DataSource = mds
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
            ComboBox8.Text = ""


        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress

        Dim Combo As ComboBox = CType(sender, ComboBox)
        ' Dim Controlkey As ControlChars

        If Asc(e.KeyChar) = Keys.Escape Then

            Combo.SelectedIndex = -1

            Combo.Text = ""

            ' Controlkey = Keys.Escape

        ElseIf Char.IsControl(e.KeyChar) Then

            '  Controlkey = True

        Else

            '  Controlkey = False

        End If

    End Sub
    Sub addProduct()
        TabControl1.Enabled = True
        Dim a As Integer


        Dim CMD2 As SqlCommand
        If TextBox24.Text = "" Or ComboBox8.Text = "" Then
            MsgBox("Product Data is not completed", MsgBoxStyle.OkOnly)
            TextBox24.Focus()
        Else '  End If
            If MsgBox("Are you sure to save Product data with Id : " & TextBox19.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
                'End If
            Else
                '  Try
                ReadyConnectionF()
                CMD2 = conn.CreateCommand
                CMD2.Parameters.Clear()
                CMD2.CommandText = "SELECT * FROM [Purchase Orders] WHERE OrderID = '" & Trim(TextBox14.Text) & " ' and ProductId ='" & Trim(TextBox19.Text) & " ' "

                If (CMD2.ExecuteScalar > 0) Then

                    MsgBox("Product with Id " & Trim(TextBox19.Text) & " already in database", MsgBoxStyle.OkOnly, "Message :")
                    'End If
                Else

                    '   If (CMD2.ExecuteScalar = 0) Then

                    Dim CMD As New SqlClient.SqlCommand("InsertPurchaseOrder")

                    Dim i As Integer

                    If TextBox3.Text = "Abonement" Then
                        a = 1
                    Else

                        a = Int(TextBox7.Text)
                    End If
                    '  a = TextBox18.Text

                    If TextBox12.Text = "Freezing" And Val(TextBox2.Text) >= Val(TextBox20.Text) Then

                        TextBox20.Focus()
                        MsgBox("Overlimit freezing days!", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If

                    TextBox18.Refresh()
                    CMD.Parameters.Clear()



                    For i = 0 To a - 1

                        CMD.Parameters.Clear()
                        TextBox18.Text = TextBox18.Text + 1
                        CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = Int(TextBox18.Text)
                        CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox14.Text
                        CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox19.Text
                        CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value.AddMonths(i)
                        CMD.Parameters.Add("@ExpectedDate", Data.SqlDbType.DateTime).Value = DateTimePicker3.Value.AddMonths(i)
                        If TextBox25.Text > 0 And TextBox3.Text <> "Abonement" Then
                            ' CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox2.Text * TextBox5.Text - TextBox2.Text * TextBox5.Text * TextBox6.Text / 100) / a) + TextBox25.Text / a)
                            CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a) + TextBox25.Text / a)
                        Else
                            CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a))
                        End If

                        CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = "Purchase generated based on Order #" & TextBox14.Text
                        ' CMD.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox5.Text)
                        CMD.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox24.Text) '

                        'CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox2.Text) / Int(TextBox1.Text))
                        '    CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox24.Text) / Int(TextBox1.Text))

                        CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox24.Text))

                        ExecuteProcedur.ExecuteCMD(CMD)


                    Next

                    '   TextBox18.Text = TextBox18.Text + 1
                    TextBox18.Refresh()

                    Dim CMD1 As New SqlClient.SqlCommand("InsertOrdersDetails1")
                    CMD1.Parameters.Clear()

                    CMD1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = TextBox17.Text
                    CMD1.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox14.Text
                    CMD1.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox19.Text
                    CMD1.Parameters.Add("@StartDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
                    If TextBox1.Text > 0 Then
                        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = TextBox1.Text
                    Else
                        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = 1
                    End If
                    ' CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = Int(TextBox2.Text)
                    CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = 1

                    ' CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox5.Text)
                    CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox24.Text) 'fitness quantity 1 unit price =amount

                    CMD1.Parameters.Add("@Discount", Data.SqlDbType.Float).Value = TextBox6.Text
                    CMD1.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
                    CMD1.Parameters.Add("@PaymentDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
                    CMD1.Parameters.Add("@PaymentSystem", Data.SqlDbType.NChar).Value = TextBox10.Text
                    If TextBox3.Text = "Abonement" Then
                        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = 1
                        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0
                    Else
                        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = TextBox7.Text
                        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0 'TextBox25.Text
                    End If

                    CMD1.Parameters.Add("@WeeklyAttendance", Data.SqlDbType.SmallInt).Value = TextBox9.Text

                    ExecuteProcedur.ExecuteCMD(CMD1)


                    Dim command1 As SqlCommand

                    Dim adapter As New SqlDataAdapter
                    Dim adapter1 As New SqlDataAdapter
                    Dim adapter2 As New SqlDataAdapter
                    Dim adapter3 As New SqlDataAdapter
                    Dim ds As New DataSet
                    Dim ds1 As New DataSet
                    Dim ds2 As New DataSet
                    Dim sql, sql1, sql2, sql3 As String

                    sql = "Select  * from [ProductOrder] where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql1 = "Select ExpectedDate, PaymentAmount   from [Purchase Orders] where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql2 = "Select  SubTotal from OrderSubTotal where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql3 = "Select  * from OrderPackage where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    '   Try

                    adapter = New SqlDataAdapter(sql, conn)
                    adapter.Fill(ds, "dtOrd")
                    adapter1 = New SqlDataAdapter(sql1, conn)
                    adapter1.Fill(ds1, "dtOrdPur")
                    adapter2 = New SqlDataAdapter(sql2, conn)
                    adapter2.Fill(ds2, "OrderSubTotal")
                    adapter3 = New SqlDataAdapter(sql3, conn)
                    adapter3.Fill(ds, "OrderPackage")
                    command1 = New SqlCommand(sql2, conn)
                    TextBox23.Text = command1.ExecuteScalar

                    DataGrid1.DataSource = ds.Tables("dtOrd")
                    ' DataGrid2.DataSource = ds1.Tables("dtOrdPur")
                    DataGrid3.DataSource = ds.Tables("OrderPackage")

                    DataGrid1.Refresh()
                    ' DataGrid1.Show()
                    DataGrid3.Refresh()


                    TextBox17.Text = TextBox17.Text + 1

                End If
            End If
        End If
        Dim surcharge As Integer
        If TextBox25.Text <> "" Then
            surcharge = Int(TextBox25.Text)
        Else
            surcharge = 0
        End If
        If TextBox23.Text <> "" Then
            TextBox26.Text = Int(TextBox23.Text) + surcharge
        End If
        '   limit()

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '   On Error Resume Next
        Dim a As Integer

        Dim CMD2 As SqlCommand
        If TextBox24.Text = "" Or ComboBox8.Text = "" Then
            MsgBox("Product Data is not completed", MsgBoxStyle.OkOnly)
            TextBox24.Focus()
        Else '  End If
            If MsgBox("Are you sure to save Product data with Id : " & TextBox19.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
                'End If
            Else
                '  Try
                ReadyConnectionF()
                CMD2 = conn.CreateCommand
                CMD2.Parameters.Clear()
                CMD2.CommandText = "SELECT * FROM [Purchase Orders] WHERE OrderID = '" & Trim(TextBox14.Text) & " ' and ProductId ='" & Trim(TextBox19.Text) & " ' "

                If (CMD2.ExecuteScalar > 0) Then

                    MsgBox("Product with Id " & Trim(TextBox19.Text) & " already in database", MsgBoxStyle.OkOnly, "Message :")
                    'End If
                Else

                    '   If (CMD2.ExecuteScalar = 0) Then

                    Dim CMD As New SqlClient.SqlCommand("InsertPurchaseOrder")

                    Dim i As Integer

                    If TextBox3.Text = "Abonement" Then
                        a = 1
                    Else

                        a = Int(TextBox7.Text)
                    End If
                    '  a = TextBox18.Text

                    If TextBox12.Text = "Freezing" And Val(TextBox2.Text) >= Val(TextBox20.Text) Then

                        TextBox20.Focus()
                        MsgBox("Overlimit freezing days!", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If

                    TextBox18.Refresh()
                    CMD.Parameters.Clear()



                    For i = 0 To a - 1

                        CMD.Parameters.Clear()
                        TextBox18.Text = TextBox18.Text + 1
                        CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = Int(TextBox18.Text)
                        CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox14.Text
                        CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox19.Text
                        CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value.AddMonths(i)
                        CMD.Parameters.Add("@ExpectedDate", Data.SqlDbType.DateTime).Value = DateTimePicker3.Value.AddMonths(i)
                        If TextBox25.Text > 0 And TextBox3.Text <> "Abonement" Then
                            ' CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox2.Text * TextBox5.Text - TextBox2.Text * TextBox5.Text * TextBox6.Text / 100) / a) + TextBox25.Text / a)
                            CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a) + TextBox25.Text / a)
                        Else
                            CMD.Parameters.Add("@PaymentAmount", Data.SqlDbType.Decimal).Value = Math.Round(((TextBox24.Text - TextBox24.Text * TextBox6.Text / 100) / a))
                        End If

                        CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = "Purchase generated based on Order #" & TextBox14.Text
                        ' CMD.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox5.Text)
                        CMD.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox24.Text) '

                        'CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox2.Text) / Int(TextBox1.Text))
                        '    CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox24.Text) / Int(TextBox1.Text))

                        CMD.Parameters.Add("@Limit", Data.SqlDbType.Int).Value = Math.Round(Int(TextBox24.Text))

                        ExecuteProcedur.ExecuteCMD(CMD)


                    Next

                    '   TextBox18.Text = TextBox18.Text + 1
                    TextBox18.Refresh()

                    Dim CMD1 As New SqlClient.SqlCommand("InsertOrdersDetails1")
                    CMD1.Parameters.Clear()

                    CMD1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = TextBox17.Text
                    CMD1.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox14.Text
                    CMD1.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = TextBox19.Text
                    CMD1.Parameters.Add("@StartDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
                    If TextBox1.Text > 0 Then
                        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = TextBox1.Text
                    Else
                        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = 1
                    End If
                    ' CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = Int(TextBox2.Text)
                    CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = 1

                    ' CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox5.Text)
                    CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = Int(TextBox24.Text) 'fitness quantity 1 unit price =amount

                    CMD1.Parameters.Add("@Discount", Data.SqlDbType.Float).Value = TextBox6.Text
                    CMD1.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
                    CMD1.Parameters.Add("@PaymentDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
                    CMD1.Parameters.Add("@PaymentSystem", Data.SqlDbType.NChar).Value = TextBox10.Text
                    If TextBox3.Text = "Abonement" Then
                        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = 1
                        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0
                    Else
                        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = TextBox7.Text
                        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0 'TextBox25.Text
                    End If

                    CMD1.Parameters.Add("@WeeklyAttendance", Data.SqlDbType.SmallInt).Value = TextBox9.Text
                    CMD1.Parameters.Add("@DurDays", Data.SqlDbType.SmallInt).Value = TextBox28.Text
                    ExecuteProcedur.ExecuteCMD(CMD1)


                    Dim command1 As SqlCommand

                    Dim adapter As New SqlDataAdapter
                    Dim adapter1 As New SqlDataAdapter
                    Dim adapter2 As New SqlDataAdapter
                    Dim adapter3 As New SqlDataAdapter
                    Dim ds As New DataSet
                    Dim ds1 As New DataSet
                    Dim ds2 As New DataSet
                    Dim sql, sql1, sql2, sql3 As String

                    sql = "Select  * from [ProductOrder] where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql1 = "Select ExpectedDate, PaymentAmount   from [Purchase Orders] where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql2 = "Select  SubTotal from OrderSubTotal where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    sql3 = "Select  * from OrderPackage where OrderId ='" & Trim(TextBox14.Text) & " ' "
                    '   Try

                    adapter = New SqlDataAdapter(sql, conn)
                    adapter.Fill(ds, "dtOrd")
                    adapter1 = New SqlDataAdapter(sql1, conn)
                    adapter1.Fill(ds1, "dtOrdPur")
                    adapter2 = New SqlDataAdapter(sql2, conn)
                    adapter2.Fill(ds2, "OrderSubTotal")
                    adapter3 = New SqlDataAdapter(sql3, conn)
                    adapter3.Fill(ds, "OrderPackage")
                    command1 = New SqlCommand(sql2, conn)
                    TextBox23.Text = command1.ExecuteScalar
                    conn.Close()
                    DataGrid1.DataSource = ds.Tables("dtOrd")
                    ' DataGrid2.DataSource = ds1.Tables("dtOrdPur")
                    DataGrid3.DataSource = ds.Tables("OrderPackage")

                    DataGrid1.Refresh()
                    ' DataGrid1.Show()
                    DataGrid3.Refresh()


                    TextBox17.Text = TextBox17.Text + 1

                End If
            End If
        End If
        Dim surcharge As Integer
        If TextBox25.Text <> "" Then
            surcharge = Int(TextBox25.Text)
        Else
            surcharge = 0
        End If
        If TextBox23.Text <> "" Then
            TextBox26.Text = Int(TextBox23.Text) + surcharge
        End If
        '   limit()

    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        '  Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim str, str1 As String

        Dim cm As CurrencyManager = CType(Me.BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)
        Dim dv As DataView = CType(cm.List, DataView)
        Dim dr As DataRow
        ' If Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 0)) Then
        If dv.Count > 0 Then

            dr = dv.Item(cm.Position).Row

            ' Display the Current Row Data
            str = dr(0).ToString
            str1 = dr(12).ToString
            Debug.Write(str)
            If TextBox14.Text <> "" Then
                If MsgBox("Are you sure to delete data  ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then


                    ' do nothing


                Else

                    cmd = conn.CreateCommand
                    cmd.CommandText = "DELETE FROM [OrderDetails] WHERE Id ='" & str & "' and OrderId ='" & Trim(TextBox14.Text) & "'"
                    ExecuteReader(cmd)

                    cmd1 = conn.CreateCommand
                    cmd1.CommandText = "DELETE FROM [Purchase Orders] WHERE ProductId ='" & str1 & "' and OrderId ='" & Trim(TextBox14.Text) & "'"

                    ExecuteReader(cmd1)




                End If
            End If
        Else

        End If

        Refresh_Form()

    End Sub

    Sub allorders()
        Dim ds As New DataSet
        Dim ordid As New SqlCommand
        ordid = conn.CreateCommand
        '  cmd.CommandText = "select orderid from MaxEndDate where customerID = '" & ComboBox5.SelectedValue & " '  "
        ordid.CommandText = "select orderid,ProductName,orderdate,enddate from OrdDateLast where customerID =  '" & ComboBox5.SelectedValue & " '" ' and OrderDate >'" & Format(reDate, "yyyy.MM.dd") & " ' order by orderdate"
        Dim da3 = New SqlDataAdapter(ordid.CommandText, Connection)
        da3.Fill(ds, "Ord")
        DataGrid2.DataSource = ds.Tables("Ord")
        NewDate()
        DateTimePicker4.Value = DateTimePicker5.Value.AddMonths(TextBox1.Text)
    End Sub
    Sub NewDate()
        Dim maxDate As New SqlCommand
        maxDate = conn.CreateCommand
        Dim provider As CultureInfo = CultureInfo.InvariantCulture

        maxDate.CommandText = "select max(enddate)from OrdDateLast where  customerID = '" & ComboBox5.SelectedValue & " '" ' and OrderDate >'" & Format(reendDate, "yyyy.MM.dd") & " '"
        Dim checkmindate As Object = ExecuteScalar(maxDate)
        Dim NewDate As DateTime

        If checkmindate Is Nothing OrElse IsDBNull(checkmindate) Then
            DateTimePicker5.Value = Now()
            Dim DP1 As String = DateTimePicker5.Text

        Else
            NewDate = maxDate.ExecuteScalar() ' ExecuteScalar(maxDate)

            ' NewDate = Date.TryParseExact(DateTimePicker5.Value, "dd/MM/yyyy", enUs, Globalization.DateTimeStyles.AssumeLocal, NewDate.AddDays(1)) 'ExecuteScalar(maxDate)
            DateTimePicker5.Value = NewDate.AddDays(1)
        End If


    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' addProduct()
        newOrder()
        ' Order_Load(Nothing, Nothing)
    End Sub

    Sub newOrder()
        If TextBox1.Text = "" Then
            TextBox1.Focus()
            MsgBox("duration!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        ReadyConnectionF()

        If MsgBox("Are you sure to save Order for Client : " & ComboBox1.Text & " ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

        Else
            Button1.Enabled = True
            Button2.Enabled = True

            TabControl1.Enabled = True
            Dim CMD2 As New SqlClient.SqlCommand("InsertOrders")

            CMD2.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = TextBox14.Text
            CMD2.Parameters.Add("@OrderName", Data.SqlDbType.NVarChar).Value = ComboBox4.Text
            CMD2.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = TextBox13.Text

            CMD2.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = TextBox16.Text


            CMD2.Parameters.Add("@OrderDate", Data.SqlDbType.DateTime).Value = DateTimePicker5.Value
            CMD2.Parameters.Add("@DeadLine", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value
            CMD2.Parameters.Add("@EndDate", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value

            CMD2.Parameters.Add("@ReorderDate", Data.SqlDbType.DateTime).Value = DateTimePicker3.Value' DateTime.Now

            '  If TextBox25.Text <> "" Then
            ' CMD2.Parameters.Add("@Surcharge", Data.SqlDbType.NChar).Value = TextBox25.Text
            '  Else
            CMD2.Parameters.Add("@Surcharge", Data.SqlDbType.NChar).Value = 0
            CMD2.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
            CMD2.Parameters.Add("@FreezingDays", Data.SqlDbType.Int).Value = TextBox21.Text
            CMD2.Parameters.Add("@FreezingLimit", Data.SqlDbType.Int).Value = TextBox22.Text

            CMD2.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = TextBox15.Text
            CMD2.Parameters.Add("@duration", Data.SqlDbType.Int).Value = txtGuest.Text
            ExecuteProcedur.ExecuteCMD(CMD2)
        End If


        TextBox25.Enabled = False
        ' Me.Button3.Enabled = False
        Button5.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub









    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' Dim check As Integer
        'Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        If TextBox14.Text <> "" Then
            If MsgBox("Are you sure to delete order : " & TextBox14.Text & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
                ' do nothing
            Else
                ReadyConnectionF()
                cmd = conn.CreateCommand
                cmd.CommandText = "DELETE FROM [OrderDetails] WHERE OrderId ='" & Trim(TextBox14.Text) & "'"

                ExecuteReader(cmd)

                cmd1 = conn.CreateCommand
                cmd1.CommandText = "DELETE FROM [Purchase Orders] WHERE OrderId ='" & Trim(TextBox14.Text) & "'"

                ExecuteReader(cmd1)

                cmd2 = conn.CreateCommand
                cmd2.CommandText = "DELETE FROM [Orders] WHERE OrderId ='" & Trim(TextBox14.Text) & "'"
                ExecuteReader(cmd2)


                MsgBox("Order With Id " & Trim(TextBox14.Text) & " Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")

            End If

        End If
        Button3.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub



    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged
        'On Error Resume Next
        If TextBox24.Text <> "" And TextBox6.Text = 0 Then
            ' TextBox5.Text = Math.Round(TextBox24.Text / TextBox2.Text, 0)
            TextBox5.Text = TextBox24.Text
        End If
        '  If TextBox24.Text <> "" And TextBox6.Text > 0 Then
        '  TextBox5.Text = Math.Round((Int(TextBox24.Text) / Int(TextBox2.Text)) * (Int(TextBox6.Text) / 100), 0)
        ' End If

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        TextBox24.Text = ""
    End Sub




    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' If CheckBox1.Checked = True Then DateTimePicker2.Enabled = True
    End Sub





    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim f1 As New Order
        Me.Close()
        f1.Show()


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub



    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        '  On Error Resume Next
        '   If TextBox24.Text <> "" Then
        '  TextBox5.Text = Math.Round(TextBox24.Text / TextBox2.Text, 0)
        '  End If

    End Sub




    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        allorders()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        NewDate()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged

    End Sub

    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged

        If TextBox28.Text <> "" And TextBox1.Text <> "" Then
            DateTimePicker4.Value = DateTimePicker5.Value.AddMonths(TextBox1.Text)
            DateTimePicker4.Value = DateTimePicker4.Value.AddDays(TextBox28.Text)
        Else
            MsgBox("Value can'not be empthy!")
        End If
    End Sub

    Private Sub DataGrid1_Navigate(sender As System.Object, ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged

    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel

Public Class MoneyByDate
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
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents DataGrid1 As DataGrid
	Friend WithEvents Label1 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents DataGrid2 As DataGrid
	Friend WithEvents DataGrid3 As DataGrid
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents DataGridView1 As DataGridView
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		DateTimePicker1 = New DateTimePicker()
		DateTimePicker2 = New DateTimePicker()
		ComboBox1 = New ComboBox()
		DataGrid1 = New DataGrid()
		Label1 = New Label()
		Button2 = New Button()
		Label2 = New Label()
		Button3 = New Button()
		DataGrid2 = New DataGrid()
		DataGrid3 = New DataGrid()
		TextBox1 = New TextBox()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		Button4 = New Button()
		Label8 = New Label()
		DataGridView1 = New DataGridView()
		Label9 = New Label()
		DataGridView2 = New DataGridView()
		CType(DataGrid1, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGrid2, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGrid3, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		'
		'DateTimePicker1
		'
		DateTimePicker1.CustomFormat = "dd/MM/yyyy"
		DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		DateTimePicker1.Format = DateTimePickerFormat.Custom
		DateTimePicker1.Location = New Point(288, 0)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(176, 26)
		DateTimePicker1.TabIndex = 0
		'
		'DateTimePicker2
		'
		DateTimePicker2.CustomFormat = "dd/MM/yyyy"
		DateTimePicker2.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		DateTimePicker2.Format = DateTimePickerFormat.Custom
		DateTimePicker2.Location = New Point(528, 0)
		DateTimePicker2.Name = "DateTimePicker2"
		DateTimePicker2.Size = New Size(176, 26)
		DateTimePicker2.TabIndex = 1
		'
		'ComboBox1
		'
		ComboBox1.Location = New Point(776, 40)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(120, 21)
		ComboBox1.TabIndex = 2
		ComboBox1.Visible = False
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
		DataGrid1.Location = New Point(8, 104)
		DataGrid1.Name = "DataGrid1"
		DataGrid1.ParentRowsBackColor = Color.Gainsboro
		DataGrid1.ParentRowsForeColor = Color.Black
		DataGrid1.SelectionBackColor = Color.DarkSeaGreen
		DataGrid1.SelectionForeColor = Color.Black
		DataGrid1.Size = New Size(736, 604)
		DataGrid1.TabIndex = 3
		'
		'Label1
		'
		Label1.Font = New Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Label1.Location = New Point(480, 8)
		Label1.Name = "Label1"
		Label1.Size = New Size(32, 16)
		Label1.TabIndex = 5
		Label1.Text = "-"
		Label1.TextAlign = ContentAlignment.MiddleCenter
		'
		'Button2
		'
		Button2.Location = New Point(776, 64)
		Button2.Name = "Button2"
		Button2.Size = New Size(120, 24)
		Button2.TabIndex = 6
		Button2.Text = "BALANCE NOW"
		Button2.Visible = False
		'
		'Label2
		'
		Label2.Font = New Font("Tahoma", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Label2.Location = New Point(763, 482)
		Label2.Name = "Label2"
		Label2.Size = New Size(168, 24)
		Label2.TabIndex = 7
		'
		'Button3
		'
		Button3.Location = New Point(520, 376)
		Button3.Name = "Button3"
		Button3.Size = New Size(200, 24)
		Button3.TabIndex = 8
		Button3.Text = "TOTAL CASHBOX TRANSACTIONS"
		Button3.Visible = False
		'
		'DataGrid2
		'
		DataGrid2.AlternatingBackColor = Color.White
		DataGrid2.BackColor = Color.White
		DataGrid2.BackgroundColor = Color.Gainsboro
		DataGrid2.BorderStyle = BorderStyle.FixedSingle
		DataGrid2.CaptionBackColor = Color.Silver
		DataGrid2.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid2.CaptionForeColor = Color.Black
		DataGrid2.DataMember = ""
		DataGrid2.FlatMode = True
		DataGrid2.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(204, Byte))
		DataGrid2.ForeColor = Color.DarkSlateGray
		DataGrid2.GridLineColor = Color.DarkGray
		DataGrid2.HeaderBackColor = Color.DarkGreen
		DataGrid2.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid2.HeaderForeColor = Color.White
		DataGrid2.LinkColor = Color.DarkGreen
		DataGrid2.Location = New Point(741, 413)
		DataGrid2.Name = "DataGrid2"
		DataGrid2.ParentRowsBackColor = Color.Gainsboro
		DataGrid2.ParentRowsForeColor = Color.Black
		DataGrid2.PreferredColumnWidth = 150
		DataGrid2.SelectionBackColor = Color.DarkSeaGreen
		DataGrid2.SelectionForeColor = Color.Black
		DataGrid2.Size = New Size(300, 182)
		DataGrid2.TabIndex = 9
		'
		'DataGrid3
		'
		DataGrid3.AlternatingBackColor = Color.White
		DataGrid3.BackColor = Color.White
		DataGrid3.BackgroundColor = Color.Gainsboro
		DataGrid3.BorderStyle = BorderStyle.FixedSingle
		DataGrid3.CaptionBackColor = Color.Silver
		DataGrid3.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid3.CaptionForeColor = Color.Black
		DataGrid3.DataMember = ""
		DataGrid3.FlatMode = True
		DataGrid3.Font = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid3.ForeColor = Color.DarkSlateGray
		DataGrid3.GridLineColor = Color.DarkGray
		DataGrid3.HeaderBackColor = Color.DarkGreen
		DataGrid3.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid3.HeaderForeColor = Color.White
		DataGrid3.LinkColor = Color.DarkGreen
		DataGrid3.Location = New Point(1113, 433)
		DataGrid3.Name = "DataGrid3"
		DataGrid3.ParentRowsBackColor = Color.Gainsboro
		DataGrid3.ParentRowsForeColor = Color.Black
		DataGrid3.SelectionBackColor = Color.DarkSeaGreen
		DataGrid3.SelectionForeColor = Color.Black
		DataGrid3.Size = New Size(74, 141)
		DataGrid3.TabIndex = 10
		DataGrid3.Visible = False
		'
		'TextBox1
		'
		TextBox1.Location = New Point(96, 8)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(88, 20)
		TextBox1.TabIndex = 11
		TextBox1.Text = "100000"
		TextBox1.Visible = False
		'
		'Label3
		'
		Label3.Location = New Point(24, 8)
		Label3.Name = "Label3"
		Label3.Size = New Size(64, 24)
		Label3.TabIndex = 12
		Label3.Text = "PLAN"
		Label3.Visible = False
		'
		'Label4
		'
		Label4.Location = New Point(24, 48)
		Label4.Name = "Label4"
		Label4.Size = New Size(56, 24)
		Label4.TabIndex = 13
		Label4.Text = "FACT"
		Label4.Visible = False
		'
		'Label5
		'
		Label5.Location = New Point(88, 48)
		Label5.Name = "Label5"
		Label5.Size = New Size(64, 16)
		Label5.TabIndex = 14
		Label5.Text = "FACT"
		Label5.Visible = False
		'
		'Label6
		'
		Label6.Location = New Point(88, 80)
		Label6.Name = "Label6"
		Label6.Size = New Size(64, 16)
		Label6.TabIndex = 16
		Label6.Text = "REST"
		Label6.Visible = False
		'
		'Label7
		'
		Label7.Location = New Point(24, 80)
		Label7.Name = "Label7"
		Label7.Size = New Size(56, 24)
		Label7.TabIndex = 15
		Label7.Text = "REST"
		Label7.Visible = False
		'
		'Button4
		'
		Button4.Location = New Point(216, 72)
		Button4.Name = "Button4"
		Button4.Size = New Size(96, 24)
		Button4.TabIndex = 17
		Button4.Text = "Calculate Rest"
		Button4.Visible = False
		'
		'Label8
		'
		Label8.Font = New Font("Microsoft Sans Serif", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Label8.Location = New Point(737, 506)
		Label8.Name = "Label8"
		Label8.Size = New Size(283, 24)
		Label8.TabIndex = 18
		'
		'DataGridView1
		'
		DataGridView1.BackgroundColor = SystemColors.ControlLight
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(741, 156)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.Size = New Size(246, 260)
		DataGridView1.TabIndex = 20
		'
		'Label9
		'
		Label9.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Label9.ForeColor = Color.Red
		Label9.Location = New Point(762, 104)
		Label9.Name = "Label9"
		Label9.Size = New Size(238, 24)
		Label9.TabIndex = 21
		Label9.Text = "TOTAL BALANCE"
		'
		'DataGridView2
		'
		DataGridView2.BackgroundColor = SystemColors.ControlLight
		DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView2.Location = New Point(993, 156)
		DataGridView2.Name = "DataGridView2"
		DataGridView2.Size = New Size(256, 260)
		DataGridView2.TabIndex = 22
		'
		'MoneyByDate
		'
		AutoScaleBaseSize = New Size(5, 13)
		ClientSize = New Size(1248, 710)
		Controls.Add(DataGridView2)
		Controls.Add(Label9)
		Controls.Add(DataGridView1)
		Controls.Add(Button4)
		Controls.Add(Label6)
		Controls.Add(Label7)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(TextBox1)
		Controls.Add(DataGrid3)
		Controls.Add(DataGrid2)
		Controls.Add(Button3)
		Controls.Add(Label2)
		Controls.Add(Button2)
		Controls.Add(Label1)
		Controls.Add(DataGrid1)
		Controls.Add(ComboBox1)
		Controls.Add(DateTimePicker2)
		Controls.Add(DateTimePicker1)
		Controls.Add(Label8)
		Name = "MoneyByDate"
		Text = "MoneyByDate"
		WindowState = FormWindowState.Maximized
		CType(DataGrid1, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGrid2, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGrid3, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	Private Sub MoneyByDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		RefreshDate()

		'Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
		'Dim resultTotal As New Object
		'Dim dataSet As New DataSet
		'Dim result4 As New Object

		'AddHandler worker.DoWork,
		'	Sub(workSender As Object, args As DoWorkEventArgs)
		'		Try
		'			Dim dateStart = DateTimePicker1.Value
		'			Dim dateEnd = DateTimePicker2.Value

		'			ReadyConnectionF()

		'			Dim commandTotal As New SqlCommand("SELECT BALANCE  FROM Balance1", conn)
		'			resultTotal = commandTotal.ExecuteScalar()

		'			Dim commandBal As New SqlCommand("SELECT *  FROM CashBoxOut Where ReturnDate between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) ", conn)
		'			Dim adapterBal As New SqlDataAdapter(commandBal)
		'			adapterBal.Fill(dataSet, "CashBoxOut")

		'			Dim command1 As New SqlCommand("select * from CashBox Where DateReceived between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) ", conn)
		'			Dim adapter As New SqlDataAdapter(command1)
		'			adapter.Fill(dataSet, "CashBox")

		'			Dim command2 = New SqlCommand("Select PaymentType from PaymentType", conn)
		'			Dim dataAdapter As New SqlDataAdapter(command2)
		'			dataAdapter.Fill(dataSet, "PaymentType")

		'			Dim command4 As New SqlCommand("select  sum(Amount) from Fact Where Month= '" & DatePart(DateInterval.Month, dateEnd) & " ' and PaymentPurpose <> 'Deposit'", conn)
		'			result4 = command4.ExecuteScalar()
		'		Catch
		'			MessageBox.Show("Internal error. Try again!")
		'		End Try
		'	End Sub

		'AddHandler worker.RunWorkerCompleted,
		'	Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
		'		Label2.Text = If(IsDBNull(resultTotal), 0, CStr(resultTotal))

		'		DataGrid3.DataSource = dataSet.Tables("CashBoxOut")
		'		DataGrid3.CaptionText = "CASHBOX WITHDRAWAL"

		'		DataGrid1.DataSource = dataSet.Tables("CashBox")
		'		DataGrid1.CaptionText = "CASHBOX INCOME"

		'		With ComboBox1
		'			.DisplayMember = "PaymentType.PaymentType"
		'			.ValueMember = "PaymentType"
		'			.DataSource = dataSet
		'			.DropDownStyle = ComboBoxStyle.DropDownList
		'		End With

		'		Label5.Text = ""
		'		If IsDBNull(result4) Then
		'			Label5.Text = 0
		'		Else
		'			Label6.Text = CInt(TextBox1.Text) - CInt(result4)
		'			Label5.Text = CStr(result4)
		'		End If
		'	End Sub

		'worker.RunWorkerAsync()
	End Sub

	'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	'	MsgBox("Button2_Click")
	'	Dim endDate As Date = Format("Short", DateTimePicker2.Value)
	'	Label2.Text = ""
	'	Dim bal As String
	'	Dim strSQL3 As String = "select BALANCE from BAL"
	'	ReadyConnectionF()
	'	Dim cmd3 As New SqlCommand(strSQL3, conn)
	'	Dim sqlResult As Object = cmd3.ExecuteScalar()
	'	If IsDBNull(sqlResult) Then
	'		Label2.Text = 0
	'	Else
	'		Dim adapter3 As New SqlDataAdapter(cmd3)
	'		adapter3.Fill(ds, "BALANCE1")
	'		Dim dt As New DataTable
	'		dt = ds.Tables(0)
	'		bal = cmd3.ExecuteScalar()
	'		Label2.Text = bal
	'	End If
	'End Sub

	'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
	'	MsgBox("Button3_Click")
	'	Dim sqlTotal As String = "SELECT *  FROM Balance1"
	'	Dim ds As New DataSet

	'	Dim startDate As Date = Format("Short", DateTimePicker1.Value)
	'	Dim endDate As Date = Format("Short", DateTimePicker2.Value)
	'	endDate = DateTimePicker2.Value.AddDays(1)

	'	Dim cmdTotal As New SqlCommand(sqlTotal, conn)
	'	Dim adapterTotal As New SqlDataAdapter(cmdTotal)

	'	Try
	'		ReadyConnectionF()
	'		adapterTotal = New SqlDataAdapter(sqlTotal, conn)
	'		adapterTotal.Fill(ds, "Balance1")

	'		Dim strBal As String = "SELECT *  FROM CashBoxOut"
	'		Dim cmdBal As New SqlCommand(strBal, conn)
	'		Dim adapterBal As New SqlDataAdapter(cmdBal)
	'		adapterBal = New SqlDataAdapter(strBal, conn)
	'		adapterBal.Fill(ds, "Balance")

	'		DataGrid3.DataSource = ds.Tables("CashBoxOut")
	'		DataGrid3.CaptionText = "CASHBOX OUT"
	'		DataGrid2.DataSource = ds.Tables("Balance1")
	'		DataGrid2.CaptionText = "TOTAL"
	'	Catch ex As Exception
	'		MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
	'	End Try
	'End Sub

	Private InProgress = False
	Private ProgressStartDate As Date
	Private ProgressEndDate As Date

	Sub RefreshDate()
		If InProgress Then Exit Sub
		InProgress = True

		Dim cultureInfoTemporary As New CultureInfo("en-US")
		cultureInfoTemporary.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		cultureInfoTemporary.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = cultureInfoTemporary

		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
		Dim dataSet As New DataSet
		Dim resultOut As New Object

		AddHandler worker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				Try
					ProgressStartDate = DateTimePicker1.Value
					ProgressEndDate = DateTimePicker2.Value

					Dim dateStart = DateTimePicker1.Value
					Dim dateEnd = DateTimePicker2.Value.AddDays(1)

					ReadyConnectionF()

					Dim command3 As New SqlCommand("select Sum(Sum) AS SumAmount, PaymentMethode from CashBox  Where DateReceived between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) GROUP BY PaymentMethode  ", conn)
					Dim adapter3 As New SqlDataAdapter(command3)
					adapter3.Fill(dataSet, "income")

					Dim commandTotal1 As New SqlCommand("select Sum(Sum) AS SumAmount, Paymentbasic from CashBox  Where DateReceived between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) and PaymentPurpose='Additional' GROUP BY Paymentbasic ", conn)
					Dim adapterTotal1 As New SqlDataAdapter(commandTotal1)
					adapterTotal1.Fill(dataSet, "Cash1")

					Dim commandTotal As New SqlCommand("select Sum(Sum) AS SumAmount, PaymentPurpose from CashBox  Where DateReceived between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) GROUP BY PaymentPurpose ", conn)
					Dim adapterTotal As New SqlDataAdapter(commandTotal)
					adapterTotal.Fill(dataSet, "Cash")

					Dim command1 As New SqlCommand("select * from CashBox Where DateReceived between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) ", conn)
					Dim adapter As New SqlDataAdapter(command1)
					adapter.Fill(dataSet, "CashBox")

					Dim commandBal As New SqlCommand("SELECT *  FROM CashBoxOut Where ReturnDate between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) ", conn)
					Dim adapterBal As New SqlDataAdapter(commandBal)
					adapterBal.Fill(dataSet, "CashBoxOut")

					Dim commandOut As New SqlCommand("SELECT Sum(Amount) as Withdrawal   FROM CashBoxOut Where ReturnDate between Convert(date, '" & dateStart & " ', 103)  and Convert(date, '" & dateEnd & " ', 103) ", conn)
					resultOut = commandOut.ExecuteScalar()
				Catch
					MessageBox.Show("Internal error. Try again!")
				End Try
			End Sub

		AddHandler worker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				DataGrid2.DataSource = dataSet.Tables("income")
				DataGrid2.CaptionText = "TOTAL"

				DataGridView2.DataSource = dataSet.Tables("Cash1")

				DataGridView1.DataSource = dataSet.Tables("Cash")
				Dim total As Double = 0
				For Each row As DataGridViewRow In DataGridView1.Rows
					total += row.Cells(0).Value
				Next
				Label9.Text = total

				DataGrid1.DataSource = dataSet.Tables("Cashbox")

				DataGrid3.DataSource = dataSet.Tables("CashBoxOut")
				DataGrid3.CaptionText = "CASHBOX WITHDRAWAL"

				Label8.Text = If(IsDBNull(resultOut), 0, "TOTAL     " & CStr(resultOut))

				InProgress = False
				DateTimePicker1.Value = ProgressStartDate
				DateTimePicker2.Value = ProgressEndDate
			End Sub

		worker.RunWorkerAsync()
	End Sub

	'Private Sub RefreshForm()
	'	MsgBox("RefreshForm")
	'	Label5.Text = ""

	'	ReadyConnectionF()

	'	Dim cmd4 As New SqlCommand("select  sum(Amount) from Fact Where Month= '" & DatePart(DateInterval.Month, DateTimePicker2.Value) & " ' and PaymentPurpose <> 'Deposit'", conn)
	'	Dim sqlResult1 As Object = cmd4.ExecuteScalar()

	'	If IsDBNull(sqlResult1) Then
	'		Label5.Text = 0
	'	Else
	'		Dim adapter3 As New SqlDataAdapter(cmd4)
	'		adapter3.Fill(ds, "Fact")

	'		Dim fact As String = cmd4.ExecuteScalar()

	'		Label6.Text = Int(TextBox1.Text) - fact
	'		Label5.Text = fact
	'	End If
	'End Sub

	'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
	'	MsgBox("TextBox1_TextChanged")
	'	RefreshForm()
	'End Sub

	Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
		RefreshDate()
	End Sub

	Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
		RefreshDate()
	End Sub
End Class

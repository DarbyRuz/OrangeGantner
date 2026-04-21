Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports DataGridViewAutoFilter
Imports System.ComponentModel
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class REPORTS
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
	Private components As IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button3 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button4 As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PView As PictureBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents ShowAllLabel As Button
	Friend WithEvents FilterStatusLabel As Label
	Friend WithEvents BtnExportExcel As Button
	Friend WithEvents LblUser As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Timer1 As Windows.Forms.Timer
	Friend WithEvents BtnImport As Button
	Friend WithEvents NumericUpDown1 As NumericUpDown
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		components = New Container()
		Dim resources As New ComponentResourceManager(GetType(REPORTS))
		Button1 = New Button()
		DateTimePicker1 = New DateTimePicker()
		DateTimePicker2 = New DateTimePicker()
		ComboBox1 = New ComboBox()
		Button2 = New Button()
		Timer1 = New Windows.Forms.Timer(components)
		BtnImport = New Button()
		NumericUpDown1 = New NumericUpDown()
		DataGridView1 = New DataGridView()
		Button3 = New Button()
		TextBox1 = New TextBox()
		Button4 = New Button()
		TextBox2 = New TextBox()
		Label1 = New Label()
		PView = New PictureBox()
		TextBox3 = New TextBox()
		ShowAllLabel = New Button()
		FilterStatusLabel = New Label()
		BtnExportExcel = New Button()
		LblUser = New Label()
		CType(NumericUpDown1, ISupportInitialize).BeginInit()
		CType(DataGridView1, ISupportInitialize).BeginInit()
		CType(PView, ISupportInitialize).BeginInit()
		SuspendLayout()
		'
		'Button1
		'
		Button1.Location = New Point(627, 48)
		Button1.Name = "Button1"
		Button1.Size = New Size(92, 22)
		Button1.TabIndex = 0
		Button1.Text = "Create Report "
		'
		'DateTimePicker1
		'
		DateTimePicker1.CustomFormat = "dd/MM/yyyy"
		DateTimePicker1.Format = DateTimePickerFormat.Custom
		DateTimePicker1.Location = New Point(8, 16)
		DateTimePicker1.Name = "DateTimePicker1"
		DateTimePicker1.Size = New Size(200, 20)
		DateTimePicker1.TabIndex = 1
		'
		'DateTimePicker2
		'
		DateTimePicker2.CustomFormat = "dd/MM/yyyy"
		DateTimePicker2.Format = DateTimePickerFormat.Custom
		DateTimePicker2.Location = New Point(8, 48)
		DateTimePicker2.Name = "DateTimePicker2"
		DateTimePicker2.Size = New Size(200, 20)
		DateTimePicker2.TabIndex = 2
		'
		'ComboBox1
		'
		ComboBox1.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		ComboBox1.ForeColor = Color.Firebrick
		ComboBox1.Location = New Point(288, 24)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(272, 24)
		ComboBox1.TabIndex = 4
		ComboBox1.Text = "ComboBox1"
		'
		'Button2
		'
		Button2.Location = New Point(744, 24)
		Button2.Name = "Button2"
		Button2.Size = New Size(101, 23)
		Button2.TabIndex = 6
		Button2.Text = "Export to Excel"
		'
		'btnImport
		'
		BtnImport.Location = New Point(952, 24)
		BtnImport.Name = "btnImport"
		BtnImport.Size = New Size(75, 23)
		BtnImport.TabIndex = 9
		BtnImport.Text = "Button4"
		BtnImport.Visible = False
		'
		'NumericUpDown1
		'
		NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
		NumericUpDown1.Location = New Point(288, 70)
		NumericUpDown1.Name = "NumericUpDown1"
		NumericUpDown1.Size = New Size(120, 20)
		NumericUpDown1.TabIndex = 12
		NumericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
		'
		'DataGridView1
		'
		DataGridView1.AllowDrop = True
		DataGridView1.AllowUserToOrderColumns = True
		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Dock = DockStyle.Bottom
		DataGridView1.Location = New Point(0, 175)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.Size = New Size(1487, 527)
		DataGridView1.TabIndex = 13
		'
		'Button3
		'
		Button3.Location = New Point(1123, 120)
		Button3.Name = "Button3"
		Button3.Size = New Size(10, 23)
		Button3.TabIndex = 15
		Button3.Text = "Save"
		'
		'TextBox1
		'
		TextBox1.Location = New Point(12, 74)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(260, 20)
		TextBox1.TabIndex = 14
		TextBox1.Text = "TextBox1"
		'
		'Button4
		'
		Button4.Location = New Point(679, 77)
		Button4.Name = "Button4"
		Button4.Size = New Size(75, 23)
		Button4.TabIndex = 16
		Button4.Text = "Search"
		Button4.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		TextBox2.Location = New Point(442, 79)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(231, 20)
		TextBox2.TabIndex = 17
		'
		'Label1
		'
		Label1.AutoSize = True
		Label1.Location = New Point(634, 8)
		Label1.Name = "Label1"
		Label1.Size = New Size(39, 13)
		Label1.TabIndex = 18
		Label1.Text = "Label1"
		'
		'pView
		'
		PView.Location = New Point(850, 4)
		PView.Name = "pView"
		PView.Size = New Size(116, 98)
		PView.TabIndex = 19
		PView.TabStop = False
		'
		'TextBox3
		'
		TextBox3.Location = New Point(971, 133)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(66, 20)
		TextBox3.TabIndex = 21
		'
		'showAllLabel
		'
		ShowAllLabel.Location = New Point(627, 25)
		ShowAllLabel.Name = "showAllLabel"
		ShowAllLabel.Size = New Size(92, 20)
		ShowAllLabel.TabIndex = 22
		ShowAllLabel.Text = "Remove filter"
		ShowAllLabel.UseVisualStyleBackColor = True
		'
		'filterStatusLabel
		'
		FilterStatusLabel.AutoSize = True
		FilterStatusLabel.Location = New Point(294, 4)
		FilterStatusLabel.Name = "filterStatusLabel"
		FilterStatusLabel.Size = New Size(39, 13)
		FilterStatusLabel.TabIndex = 23
		FilterStatusLabel.Text = "Label2"
		'
		'btnExportExcel
		'
		BtnExportExcel.Cursor = Cursors.Hand
		BtnExportExcel.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		BtnExportExcel.Image = CType(resources.GetObject("btnExportExcel.Image"), Image)
		BtnExportExcel.ImageAlign = ContentAlignment.MiddleLeft
		BtnExportExcel.Location = New Point(971, 16)
		BtnExportExcel.Name = "btnExportExcel"
		BtnExportExcel.Size = New Size(129, 64)
		BtnExportExcel.TabIndex = 24
		BtnExportExcel.Text = "Export Excel"
		BtnExportExcel.TextAlign = ContentAlignment.MiddleRight
		BtnExportExcel.UseVisualStyleBackColor = True
		'
		'lblUser
		'
		LblUser.AutoSize = True
		LblUser.Location = New Point(984, 85)
		LblUser.Name = "lblUser"
		LblUser.Size = New Size(39, 13)
		LblUser.TabIndex = 205
		LblUser.Text = "Label2"
		'
		'REPORTS
		'
		AutoScaleBaseSize = New Size(5, 13)
		ClientSize = New Size(1487, 702)
		Controls.Add(LblUser)
		Controls.Add(BtnExportExcel)
		Controls.Add(FilterStatusLabel)
		Controls.Add(ShowAllLabel)
		Controls.Add(PView)
		Controls.Add(Label1)
		Controls.Add(TextBox2)
		Controls.Add(Button4)
		Controls.Add(TextBox1)
		Controls.Add(DataGridView1)
		Controls.Add(NumericUpDown1)
		Controls.Add(BtnImport)
		Controls.Add(Button2)
		Controls.Add(ComboBox1)
		Controls.Add(DateTimePicker2)
		Controls.Add(DateTimePicker1)
		Controls.Add(Button1)
		Controls.Add(Button3)
		Controls.Add(TextBox3)
		Name = "REPORTS"
		Text = "REPORTS"
		CType(NumericUpDown1, ISupportInitialize).EndInit()
		CType(DataGridView1, ISupportInitialize).EndInit()
		CType(PView, ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	ReadOnly Worker As New AsyncWorker()

	Private Async Sub REPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim customCulture As CultureInfo = CType(CultureInfo.InvariantCulture.Clone(), CultureInfo)
		customCulture.DateTimeFormat.Calendar = New GregorianCalendar()
		customCulture.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Monday
		customCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
		customCulture.DateTimeFormat.LongDatePattern = "yyyy/MM/dd"
		customCulture.DateTimeFormat.ShortTimePattern = "HH:mm"
		customCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss"
		customCulture.NumberFormat.NativeDigits = New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
		customCulture.DateTimeFormat.CalendarWeekRule = CalendarWeekRule.FirstDay

		' Делаем культуру ReadOnly
		Dim readOnlyCulture As CultureInfo = CultureInfo.ReadOnly(customCulture)

		' Устанавливаем культуру как глобальную для текущего потока
		CultureInfo.CurrentCulture = readOnlyCulture
		CultureInfo.CurrentUICulture = readOnlyCulture

		' Если надо глобально для всего приложения (с .NET 4.6+), то:
		CultureInfo.DefaultThreadCurrentCulture = readOnlyCulture
		CultureInfo.DefaultThreadCurrentUICulture = readOnlyCulture

		'Dim cultureInfoTemporary As New CultureInfo("en-US")
		'cultureInfoTemporary.DateTimeFormat.LongDatePattern = "yyyy/MM/dd"
		'cultureInfoTemporary.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
		'cultureInfoTemporary.DateTimeFormat.LongTimePattern = "HH:mm:ss"
		'cultureInfoTemporary.DateTimeFormat.ShortTimePattern = "HH:mm"
		'Thread.CurrentThread.CurrentCulture = cultureInfoTemporary

		If String.Compare(RTrim(LblUser.Text), "FullAdministrator", False) Then
			TextBox1.Enabled = False
		End If

		Dim dataSet As New DataSet()

		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()

				Dim dataAdapter As New SqlDataAdapter("Select * from Reports", conn)
				dataAdapter.Fill(dataSet, "Reports")
			End Sub)

		With ComboBox1
			.DisplayMember = "Reports.ReportName"
			.ValueMember = "strSql"
			.DataSource = dataSet
		End With

		TextBox1.DataBindings.Add("Text", dataSet, "Reports.strSql")
	End Sub

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim table As New DataTable With {.Locale = CultureInfo.InvariantCulture}

		Await Worker.RunWork(
			Sub()
				ReadyConnectionF()

				Dim commandBal As New SqlCommand(TextBox1.Text, conn)
				commandBal.Parameters.Add("@startDate", SqlDbType.DateTime).Value = DateTimePicker1.Value
				commandBal.Parameters.Add("@endDate", SqlDbType.DateTime).Value = DateTimePicker2.Value
				Dim dataAdapter As New SqlDataAdapter(commandBal)
				dataAdapter.Fill(table)
			End Sub)

		TextBox3.DataBindings.Clear()

		DataGridView1.DataSource = New BindingSource With {.DataSource = table}

		If table.Columns("CardId") IsNot Nothing Then
			TextBox3.DataBindings.Add("Text", table, "CardId")
		End If

		For Each column As DataGridViewColumn In DataGridView1.Columns
			column.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell)
		Next

		Refresh_Form()
	End Sub

	Private Sub DataGridView1_BindingContextChanged(sender As Object, e As EventArgs) Handles DataGridView1.BindingContextChanged
		If DataGridView1.DataSource Is Nothing Then
			Return
		End If

		For Each column As DataGridViewColumn In DataGridView1.Columns
			column.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell)
		Next

		Refresh_Form()
		DataGridView1.AutoResizeColumns()
	End Sub

	Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
		Dim filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(DataGridView1)

		If String.IsNullOrEmpty(filterStatus) Then
			ShowAllLabel.Visible = False
			FilterStatusLabel.Visible = False
		Else
			ShowAllLabel.Visible = True
			FilterStatusLabel.Visible = True
			FilterStatusLabel.Text = filterStatus
		End If

		Refresh_Form()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		DATAGRIDVIEW_TO_EXCEL(DataGridView1)
	End Sub

	<DllImport("user32.dll")>
	Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
	End Function

	Sub ExportExcel(grid As DataGridView)
		Dim xlApp As New Excel.Application()
		Dim xlWorkBook = xlApp.Workbooks.Add()
		Dim xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

		Dim gridColumns = grid.Columns
		Dim gridRows = grid.Rows
		Dim gridRowsCount = gridRows.Count
		Dim gridColumnsCount = gridColumns.Count

		For x = 0 To gridColumnsCount - 1
			xlWorkSheet.Cells(1, x + 1) = gridColumns(x).HeaderText
		Next

		For y = 0 To gridRowsCount - 1
			Dim gridRow = gridRows(y)

			For x = 0 To gridColumnsCount - 1
				Try
					xlWorkSheet.Cells(y + 2, x + 1) = gridRow.Cells(x).Value
				Catch
					Continue For
				End Try
			Next
		Next

		Dim tableRange = xlWorkSheet.Range("A1", xlWorkSheet.Cells(gridRowsCount + 1, gridColumnsCount))
		Dim xlListObjects = xlWorkSheet.ListObjects
		Dim xlTable = xlListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, tableRange, , Excel.XlYesNoGuess.xlYes)

		xlTable.Name = "ExportedTable"
		xlTable.TableStyle = "TableStyleMedium2"
		xlWorkSheet.Columns.AutoFit()
		xlApp.WindowState = Excel.XlWindowState.xlMaximized
		SetForegroundWindow(xlApp.Hwnd)
		xlApp.Visible = True
	End Sub

	Private Sub Filter()
		If DataGridView1.DataSource Is Nothing Then
			Return
		End If
		DataGridView1.DataSource.Filter = String.Format("LastName + FirstName + CardID Like '%{0}%'", TextBox2.Text)
		Label1.Text = DataGridView1.RowCount
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Filter()
	End Sub

	Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
		If e.KeyCode = Keys.Enter Then
			Filter()
		End If
	End Sub

	Sub Refresh_Form()
		Dim path As String = imagePath & Trim(TextBox3.Text) & ".jpg"
		PView.Image = If(File.Exists(path), Image.FromFile(path), Nothing)
		PView.SizeMode = PictureBoxSizeMode.StretchImage
		PView.Refresh()
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		Refresh_Form()
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		Refresh_Form()
	End Sub

	Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
		Refresh_Form()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ShowAllLabel.Click
		If DataGridView1.DataSource Is Nothing Then
			Return
		End If
		DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(DataGridView1)
	End Sub

	Private Sub BtnExportExcel_Click(sender As Object, e As EventArgs) Handles BtnExportExcel.Click
		ExportExcel(DataGridView1)
	End Sub
End Class

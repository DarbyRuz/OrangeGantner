Imports System.Data.SqlClient
Imports DataGridViewAutoFilter
Imports System.Globalization
Imports System.Threading
Imports System.Threading.Tasks
Imports System.ComponentModel


Public Class Customer
	Inherits Form

	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BindingSource2 As BindingSource
	Friend WithEvents BindingNavigator1 As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripButton1 As ToolStripButton
	Friend WithEvents ToolStripButton2 As ToolStripButton
	Friend WithEvents Button5 As Button
	Friend WithEvents LblUser As Label
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
	Friend WithEvents PageNo As TextBox

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
	Friend WithEvents DataGrid1 As DataGrid
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents DataView1 As DataView
	Friend WithEvents DataGridTableStyle1 As DataGridTableStyle
	Friend WithEvents Btn_next As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Search As Button
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		components = New Container()
		Dim resources As New ComponentResourceManager(GetType(Customer))
		DataGrid1 = New DataGrid()
		DataView1 = New DataView()
		DataGridTableStyle1 = New DataGridTableStyle()
		Button2 = New Button()
		Button3 = New Button()
		Button4 = New Button()
		Btn_next = New Button()
		Button1 = New Button()
		TextBox1 = New TextBox()
		Search = New Button()
		BindingSource1 = New BindingSource(components)
		DataGridView1 = New DataGridView()
		BindingSource2 = New BindingSource(components)
		BindingNavigator1 = New BindingNavigator(components)
		BindingNavigatorAddNewItem = New ToolStripButton()
		BindingNavigatorCountItem = New ToolStripLabel()
		BindingNavigatorDeleteItem = New ToolStripButton()
		BindingNavigatorMoveFirstItem = New ToolStripButton()
		BindingNavigatorMovePreviousItem = New ToolStripButton()
		BindingNavigatorSeparator = New ToolStripSeparator()
		BindingNavigatorPositionItem = New ToolStripTextBox()
		BindingNavigatorSeparator1 = New ToolStripSeparator()
		BindingNavigatorMoveNextItem = New ToolStripButton()
		BindingNavigatorMoveLastItem = New ToolStripButton()
		BindingNavigatorSeparator2 = New ToolStripSeparator()
		ToolStripButton1 = New ToolStripButton()
		ToolStripButton2 = New ToolStripButton()
		Button5 = New Button()
		LblUser = New Label()
		ToolStrip1 = New ToolStrip()
		PageNo = New TextBox()
		ToolStripTextBox1 = New ToolStripTextBox()
		CType(DataGrid1, ISupportInitialize).BeginInit()
		CType(DataView1, ISupportInitialize).BeginInit()
		CType(BindingSource1, ISupportInitialize).BeginInit()
		CType(DataGridView1, ISupportInitialize).BeginInit()
		CType(BindingSource2, ISupportInitialize).BeginInit()
		CType(BindingNavigator1, ISupportInitialize).BeginInit()
		BindingNavigator1.SuspendLayout()
		ToolStrip1.SuspendLayout()
		SuspendLayout()
		'
		'DataGrid1
		'
		DataGrid1.AlternatingBackColor = Color.GhostWhite
		DataGrid1.BackColor = Color.GhostWhite
		DataGrid1.BackgroundColor = Color.Lavender
		DataGrid1.BorderStyle = BorderStyle.None
		DataGrid1.CaptionBackColor = Color.RoyalBlue
		DataGrid1.CaptionFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.CaptionForeColor = Color.White
		DataGrid1.DataMember = ""
		DataGrid1.DataSource = DataView1
		DataGrid1.FlatMode = True
		DataGrid1.Font = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.ForeColor = Color.MidnightBlue
		DataGrid1.GridLineColor = Color.RoyalBlue
		DataGrid1.HeaderBackColor = Color.MidnightBlue
		DataGrid1.HeaderFont = New Font("Microsoft Sans Serif", 8.0!)
		DataGrid1.HeaderForeColor = Color.Lavender
		DataGrid1.LinkColor = Color.Teal
		DataGrid1.Location = New Point(1097, 153)
		DataGrid1.Name = "DataGrid1"
		DataGrid1.ParentRowsBackColor = Color.Lavender
		DataGrid1.ParentRowsForeColor = Color.MidnightBlue
		DataGrid1.SelectionBackColor = Color.Teal
		DataGrid1.SelectionForeColor = Color.PaleGreen
		DataGrid1.Size = New Size(295, 133)
		DataGrid1.TabIndex = 1
		DataGrid1.TableStyles.AddRange(New DataGridTableStyle() {DataGridTableStyle1})
		DataGrid1.Visible = False
		'
		'DataView1
		'
		DataView1.ApplyDefaultSort = True
		'
		'DataGridTableStyle1
		'
		DataGridTableStyle1.DataGrid = DataGrid1
		DataGridTableStyle1.HeaderForeColor = SystemColors.ControlText
		'
		'Button2
		'
		Button2.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Button2.Location = New Point(514, 1)
		Button2.Name = "Button2"
		Button2.Size = New Size(96, 28)
		Button2.TabIndex = 17
		Button2.Text = "Edit/Save"
		'
		'Button3
		'
		Button3.Enabled = False
		Button3.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Button3.Location = New Point(617, 1)
		Button3.Name = "Button3"
		Button3.Size = New Size(77, 28)
		Button3.TabIndex = 16
		Button3.Text = "Delete"
		'
		'Button4
		'
		Button4.Font = New Font("Tahoma", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(204, Byte))
		Button4.Location = New Point(449, 1)
		Button4.Name = "Button4"
		Button4.Size = New Size(57, 28)
		Button4.TabIndex = 15
		Button4.Text = "New"
		'
		'btn_next
		'
		Btn_next.Dock = DockStyle.Bottom
		Btn_next.Location = New Point(0, 755)
		Btn_next.Name = "btn_next"
		Btn_next.Size = New Size(1503, 28)
		Btn_next.TabIndex = 18
		Btn_next.Text = "Single record View"
		Btn_next.Visible = False
		'
		'Button1
		'
		Button1.Location = New Point(1046, 0)
		Button1.Name = "Button1"
		Button1.Size = New Size(116, 27)
		Button1.TabIndex = 19
		Button1.Text = "Search By CardID"
		'
		'TextBox1
		'
		TextBox1.Location = New Point(744, 6)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(181, 22)
		TextBox1.TabIndex = 20
		'
		'Search
		'
		Search.Location = New Point(1181, 0)
		Search.Name = "Search"
		Search.Size = New Size(115, 27)
		Search.TabIndex = 21
		Search.Text = "Search By Phonenumber"
		'
		'DataGridView1
		'
		DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
		DataGridView1.Location = New Point(0, 153)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.RowTemplate.Height = 24
		DataGridView1.Size = New Size(1275, 581)
		DataGridView1.TabIndex = 22
		'
		'BindingNavigator1
		'
		BindingNavigator1.AddNewItem = BindingNavigatorAddNewItem
		BindingNavigator1.CountItem = BindingNavigatorCountItem
		BindingNavigator1.DeleteItem = BindingNavigatorDeleteItem
		BindingNavigator1.ImageScalingSize = New Size(20, 20)
		BindingNavigator1.Items.AddRange(New ToolStripItem() {BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, BindingNavigatorDeleteItem, ToolStripButton1, ToolStripButton2})
		BindingNavigator1.Location = New Point(0, 0)
		BindingNavigator1.MoveFirstItem = BindingNavigatorMoveFirstItem
		BindingNavigator1.MoveLastItem = BindingNavigatorMoveLastItem
		BindingNavigator1.MoveNextItem = BindingNavigatorMoveNextItem
		BindingNavigator1.MovePreviousItem = BindingNavigatorMovePreviousItem
		BindingNavigator1.Name = "BindingNavigator1"
		BindingNavigator1.PositionItem = BindingNavigatorPositionItem
		BindingNavigator1.Size = New Size(1503, 27)
		BindingNavigator1.TabIndex = 23
		BindingNavigator1.Text = "BindingNavigator1"
		'
		'BindingNavigatorAddNewItem
		'
		BindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorAddNewItem.Enabled = False
		BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), Image)
		BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorAddNewItem.Size = New Size(24, 24)
		BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorCountItem
		'
		BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		BindingNavigatorCountItem.Size = New Size(45, 24)
		BindingNavigatorCountItem.Text = "of {0}"
		BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorDeleteItem
		'
		BindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorDeleteItem.Enabled = False
		BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), Image)
		BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorDeleteItem.Size = New Size(24, 24)
		BindingNavigatorDeleteItem.Text = "Delete"
		'
		'BindingNavigatorMoveFirstItem
		'
		BindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), Image)
		BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorMoveFirstItem.Size = New Size(24, 24)
		BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		BindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), Image)
		BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorMovePreviousItem.Size = New Size(24, 24)
		BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		BindingNavigatorSeparator.Size = New Size(6, 27)
		'
		'BindingNavigatorPositionItem
		'
		BindingNavigatorPositionItem.AccessibleName = "Position"
		BindingNavigatorPositionItem.AutoSize = False
		BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		BindingNavigatorPositionItem.Size = New Size(50, 27)
		BindingNavigatorPositionItem.Text = "0"
		BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorSeparator1
		'
		BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		BindingNavigatorSeparator1.Size = New Size(6, 27)
		'
		'BindingNavigatorMoveNextItem
		'
		BindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), Image)
		BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorMoveNextItem.Size = New Size(24, 24)
		BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		BindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image
		BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), Image)
		BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		BindingNavigatorMoveLastItem.Size = New Size(24, 24)
		BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		BindingNavigatorSeparator2.Size = New Size(6, 27)
		'
		'ToolStripButton1
		'
		ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
		ToolStripButton1.Enabled = False
		ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
		ToolStripButton1.ImageTransparentColor = Color.Magenta
		ToolStripButton1.Name = "ToolStripButton1"
		ToolStripButton1.Size = New Size(24, 24)
		ToolStripButton1.Text = "ToolStripButton1"
		'
		'ToolStripButton2
		'
		ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
		ToolStripButton2.Enabled = False
		ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
		ToolStripButton2.ImageTransparentColor = Color.Magenta
		ToolStripButton2.Name = "ToolStripButton2"
		ToolStripButton2.Size = New Size(24, 24)
		ToolStripButton2.Text = "ToolStripButton2"
		'
		'Button5
		'
		Button5.Location = New Point(316, 0)
		Button5.Name = "Button5"
		Button5.Size = New Size(90, 27)
		Button5.TabIndex = 24
		Button5.Text = "Refresh"
		Button5.UseVisualStyleBackColor = True
		'
		'lblUser
		'
		LblUser.AutoSize = True
		LblUser.Location = New Point(1143, 54)
		LblUser.Name = "lblUser"
		LblUser.Size = New Size(51, 17)
		LblUser.TabIndex = 31
		LblUser.Text = "Label2"
		'
		'ToolStrip1
		'
		ToolStrip1.ImageScalingSize = New Size(20, 20)
		ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripTextBox1})
		ToolStrip1.Location = New Point(0, 27)
		ToolStrip1.Name = "ToolStrip1"
		ToolStrip1.Size = New Size(1503, 27)
		ToolStrip1.TabIndex = 32
		ToolStrip1.Text = "ToolStrip1"
		'
		'PageNo
		'
		PageNo.Location = New Point(459, 51)
		PageNo.Name = "PageNo"
		PageNo.Size = New Size(102, 22)
		PageNo.TabIndex = 33
		'
		'ToolStripTextBox1
		'
		ToolStripTextBox1.Name = "ToolStripTextBox1"
		ToolStripTextBox1.Size = New Size(100, 27)
		'
		'Customer
		'
		AutoScaleBaseSize = New Size(6, 15)
		AutoScroll = True
		ClientSize = New Size(1503, 783)
		Controls.Add(PageNo)
		Controls.Add(ToolStrip1)
		Controls.Add(LblUser)
		Controls.Add(Button5)
		Controls.Add(DataGridView1)
		Controls.Add(Search)
		Controls.Add(TextBox1)
		Controls.Add(Button1)
		Controls.Add(Btn_next)
		Controls.Add(Button2)
		Controls.Add(Button3)
		Controls.Add(Button4)
		Controls.Add(DataGrid1)
		Controls.Add(BindingNavigator1)
		Name = "Customer"
		Text = "Customer"
		WindowState = FormWindowState.Maximized
		CType(DataGrid1, ISupportInitialize).EndInit()
		CType(DataView1, ISupportInitialize).EndInit()
		CType(BindingSource1, ISupportInitialize).EndInit()
		CType(DataGridView1, ISupportInitialize).EndInit()
		CType(BindingSource2, ISupportInitialize).EndInit()
		CType(BindingNavigator1, ISupportInitialize).EndInit()
		BindingNavigator1.ResumeLayout(False)
		BindingNavigator1.PerformLayout()
		ToolStrip1.ResumeLayout(False)
		ToolStrip1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	Dim sql As String
	Dim cmd As New SqlCommand

	Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim tmpCurrentCulture As New CultureInfo("en-US")
		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

		sql = "select * from Customers"
		Try
			ReadyConnectionF()

			Dim adapter As New SqlDataAdapter(sql, conn)
			Dim dataTable As New DataTable

			adapter.FillSchema(dataTable, SchemaType.Mapped)
			DataGrid1.DataSource = dataTable
			DataGridView1.DataSource = dataTable
			BindingSource1.DataSource = dataTable
			BindingSource1.DataSource = DataGridView1.Rows
			BindingNavigator1.BindingSource = BindingSource1
			BindingNavigator1.Refresh()

			Dim allOrdersWorker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
			AddHandler allOrdersWorker.DoWork,
				Sub(workSender As Object, args As DoWorkEventArgs)
					adapter.Fill(dataTable)
				End Sub
			AddHandler allOrdersWorker.RunWorkerCompleted,
				Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
					DataGrid1.DataSource = dataTable
					DataGridView1.DataSource = dataTable
					BindingSource1.DataSource = dataTable
					BindingSource1.DataSource = DataGridView1.Rows
					BindingNavigator1.BindingSource = BindingSource1
					BindingNavigator1.Refresh()
				End Sub
			allOrdersWorker.RunWorkerAsync()
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub

	''' <summary>
	''' Not detected function
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
	'	Dim da As New SqlDataAdapter
	'	Dim ds As New DataSet
	'	Dim str As String
	'	Dim j As Integer = DataGrid1.CurrentRowIndex()
	'	Dim cm As CurrencyManager = CType(BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)
	'	Dim dv As DataView = CType(cm.List, DataView)
	'	Dim dr As DataRow
	'	dr = dv.Item(cm.Position).Row

	'	str = dr(0).ToString
	'	If MsgBox("Are you sure to delete data with Id : " & str & " ?", MsgBoxStyle.OkCancel, "Delete confirm") = MsgBoxResult.Cancel Then
	'		' do nothing
	'	Else

	'		Try
	'			ReadyConnectionF()

	'			Dim cmd As SqlCommand = conn.CreateCommand()
	'			cmd.CommandText = "DELETE FROM Customers where ID ='" & str & "'"

	'			Dim check As Integer = cmd.ExecuteReader().RecordsAffected
	'			If check > 0 Then
	'				MsgBox(" Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
	'				Dim oper As String = ""
	'				Dim st As String = ""
	'				oper = "Delete customer " & str
	'				st = LblUser.Text
	'				LogFunc(st, oper)
	'			Else
	'				MsgBox(" Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete Product")
	'			End If
	'		Catch ex As Exception
	'			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
	'		End Try
	'	End If
	'	sql = "select * from Customers"
	'	If DataGrid1.CurrentRowIndex >= 1 Then
	'		DataGrid1.Select(j - 1)
	'		DataGrid1.CurrentRowIndex = j - 1
	'	Else
	'		DataGrid1.CurrentRowIndex = 0
	'	End If
	'End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dim frm As New Cust
		frm.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
			Exit Sub
		End If

		Dim currencyManager = CType(BindingContext(DataGridView1.DataSource, DataGridView1.DataMember), CurrencyManager)
		Dim dataView = CType(currencyManager.List, DataView)
		Dim dataRow As DataRow = dataView.Item(currencyManager.Position).Row

		Dim id = dataRow(0).ToString()
		Dim cardId = dataRow(1).ToString()
		Dim lastName = dataRow(2).ToString()
		Dim firstName = dataRow(3).ToString()
		Dim sex = dataRow(4).ToString()
		Dim language = dataRow(5).ToString()
		Dim cardType = dataRow(6).ToString()
		Dim UID = dataRow(7).ToString()
		Dim homePhone = dataRow(8).ToString()
		Dim mobilePhone = dataRow(9).ToString()
		Dim address = dataRow(10).ToString()
		Dim passport = dataRow(11).ToString()
		Dim birthday As Date
		If dataRow(12).ToString() <> "" Then
			birthday = dataRow(12).ToString()
		Else
			birthday = " 1 / 1 / 1900"
		End If
		Dim status = dataRow(13).ToString()
		Dim webPage = dataRow(14).ToString()
		Dim email = dataRow(15).ToString()
		Dim contactPerson = dataRow(16).ToString()
		Dim contactPersonPhone = dataRow(17).ToString()
		Dim notes = dataRow(18).ToString()
		Dim attachments = dataRow(19).ToString()

		Dim allOrdersWorker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}

		Dim check = 0
		AddHandler allOrdersWorker.DoWork,
			Sub(workSender As Object, args As DoWorkEventArgs)
				'Async actions
				Try
					ReadyConnectionF()

					Dim commandFindCardId = conn.CreateCommand()
					commandFindCardId.Parameters.Add("@CardID", SqlDbType.NChar).Value = dataRow(1)
					commandFindCardId.CommandText = "select count(CardID) from Customers where CardID = @CardID"
					Dim countCardWithId As Integer = commandFindCardId.ExecuteScalar()

					If (countCardWithId > 1) Then
						MsgBox("CardID dublicate", MsgBoxStyle.Information, "Message :")
						Exit Sub
					Else
						Dim commandUpdateCustomers = conn.CreateCommand()
						commandUpdateCustomers.CommandText = "UPDATE  Customers set CardID = '" & cardId & "', LastName = '" & lastName &
				 "', FirstName = '" & firstName & "',Sex = '" & sex & "',Language= '" & language &
				 "' ,CardType = '" & cardType & "',UID= '" & UID & "',HomePhone= '" & homePhone &
				"', MobilePhone= '" & mobilePhone & "',Address = '" & address & "',Passport= '" & passport &
				   "', BornOn = Convert(date, '" & birthday & " ', 103),Status = '" & status & "',WebPage= '" & webPage &
				 "' ,Email = '" & email & "',ContactPerson= '" & contactPerson & "',ContactPersonPhone= '" & contactPersonPhone &
				  "' ,Notes= '" & notes & "',Attachments= '" & attachments & "'  where id ='" & id & "'"

						check = commandUpdateCustomers.ExecuteReader().RecordsAffected
					End If
				Catch ex As Exception
					MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
				End Try
			End Sub

		AddHandler allOrdersWorker.RunWorkerCompleted,
			Sub(workFinished As Object, args As RunWorkerCompletedEventArgs)
				If check > 0 Then
					MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info Delete")
					LogFunc(LblUser.Text, "edit customer " & id)
				Else
					MsgBox(" Failure To Update", MsgBoxStyle.OkOnly, "Info Delete")
				End If

				sql = "select * from Customers" 'What is this?
			End Sub

		allOrdersWorker.RunWorkerAsync()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Find()
	End Sub

	Private Sub Find()
		If TextBox1.Text <> "" Then
			If DataGridView1.Rows.Count > 0 Then
				DataGridView1.Rows(0).Selected = True
			End If
		End If

		Dim currencyManager = CType(BindingContext(DataGridView1.DataSource, DataGridView1.DataMember), CurrencyManager)
		Dim dataView = CType(currencyManager.List, DataView)
		dataView.RowFilter = String.Format("LastName + FirstName + CardID + UID Like '%{0}%'", TextBox1.Text)

		If currencyManager.List.Count = 0 Then
			MessageBox.Show("No any data!")
			If DataGridView1.Rows.Count > 0 Then
				DataGridView1.Rows(0).Selected = True
			End If
		End If
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Search.Click
		DataGridView1.ClearSelection()

		Dim match = From row As DataGridViewRow In DataGridView1.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(TextBox1.Text)
		If match.Any() Then
			DataGridView1.CurrentCell = match.First()
		End If

		For Each cell In match
			cell.Selected = True
		Next
	End Sub

	''' <summary>
	''' Not detected function
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	'Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
	'	DataGridView1.ClearSelection()

	'	Dim output(DataGridView1.Columns.Count * If(DataGridView1.NewRowIndex <> -1, DataGridView1.Rows.Count - 1, DataGridView1.Rows.Count) - 1) As String
	'	Dim i As Integer = 0
	'	Dim match As DataGridViewCell() = (From row As DataGridViewRow In DataGridView1.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(TextBox1.Text)).ToArray()
	'	For Each cell As DataGridViewCell In match
	'		If match(i) IsNot Nothing Then
	'			match(i).Selected = True
	'		End If

	'		DataGridView1.CurrentCell = match(0)
	'		i += 1
	'	Next
	'End Sub

	''' <summary>
	''' Not detected function
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	'Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
	'	For Each row In DataGridView1.SelectedRows.Cast(Of DataGridViewRow)().OrderByDescending(Function(dgvr) dgvr.Index)

	'	Next
	'End Sub

	Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
		If e.KeyCode = Keys.Enter Then
			Find()
		End If
	End Sub

	Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
		BindingNavigator1.Refresh()
	End Sub
End Class

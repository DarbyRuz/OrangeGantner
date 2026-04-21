Imports System.Data.SqlClient



Public Class HDM

	Private ItemsBackup As New List(Of ListViewItem)





	Sub GetDataCustNew(ByVal selectCommand As String)
		Try

			'   Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))

			Dim dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

			Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

			Dim table As New DataTable()
			table.Locale = System.Globalization.CultureInfo.InvariantCulture
			dataAdapter.Fill(table)
			Dim bindingSource As New BindingSource
			bindingSource.DataSource = table

			DataGridView3.DataSource = bindingSource 'table.DefaultView

			BindingNavigator2.BindingSource = bindingSource
			bindingSource.Filter = String.Format("FirstName like '{0}*' AND LastName like '{1}*'", txtFind.Text, txtfind1.Text)
			' bindingSource.Filter = String.Format("LastName Like '%{0}%' + FirstName Like '%{0}%' or CardID+ UID + MobilePhone Like '%{0}%'", txtFind.Text)
			'  bindingSource.Filter = String.Format("LastName + FirstName + CardID + UID + MobilePhone Like '%{0}%'", txtFind.Text)
			'bindingSource.Filter = String.Format(" LastName like '%{0}%' or FirstName like '%{0}%' or CardID like '%{0}%' or UID like '%{0}%' or MobilePhone like '%{0}%", txtFind.Text)
			custid.DataBindings.Add("Text", DataGridView3.DataSource, "ID")

			DataGridView3.GridColor = Color.Red
			DataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None
			DataGridView3.BackgroundColor = Color.LightGray

			DataGridView3.DefaultCellStyle.SelectionBackColor = Color.Red
			DataGridView3.DefaultCellStyle.SelectionForeColor = Color.Yellow

			DataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

			DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			DataGridView3.AllowUserToResizeColumns = False

			DataGridView3.RowsDefaultCellStyle.BackColor = Color.Bisque
			DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige


		Catch ex As SqlException
			MessageBox.Show("To run , replace the value of the " +
				"connectionString variable with a connection string that is " +
				"valid for your system.")
		End Try

	End Sub
	Sub GetDataCust(ByVal selectCommand As String)
		Try

			'   Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))

			Dim dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

			Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

			Dim table As New DataTable()
			table.Locale = System.Globalization.CultureInfo.InvariantCulture
			dataAdapter.Fill(table)
			Dim bindingSource As New BindingSource
			bindingSource.DataSource = table

			DataGridView3.DataSource = bindingSource 'table.DefaultView

			BindingNavigator2.BindingSource = bindingSource
			'    bindingSource.Filter = String.Format("FirstName like '{0}*' AND LastName like '{1}*'", txtFind.Text, txtfind1.Text)
			' bindingSource.Filter = String.Format("LastName Like '%{0}%' + FirstName Like '%{0}%' or CardID+ UID + MobilePhone Like '%{0}%'", txtFind.Text)
			bindingSource.Filter = String.Format("LastName + FirstName + CardID + UID + MobilePhone Like '%{0}%'", txtFind.Text)
			'  bindingSource.Filter = String.Format("LastName + FirstName + CardID Like '%{0}%'", txtFind.Text)
			custid.DataBindings.Add("Text", DataGridView3.DataSource, "ID")

			DataGridView3.GridColor = Color.Red
			DataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None
			DataGridView3.BackgroundColor = Color.LightGray

			DataGridView3.DefaultCellStyle.SelectionBackColor = Color.Red
			DataGridView3.DefaultCellStyle.SelectionForeColor = Color.Yellow

			DataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

			DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			DataGridView3.AllowUserToResizeColumns = False

			DataGridView3.RowsDefaultCellStyle.BackColor = Color.Bisque
			DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige


		Catch ex As SqlException
			MessageBox.Show("To run , replace the value of the " +
				"connectionString variable with a connection string that is " +
				"valid for your system.")
		End Try

	End Sub
	Private Sub Find()
		custid.DataBindings.Clear()
		'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
		'    "From customers Where Cardid Like '" & txtFind.Text & "%'  order by cardid", conn)



		GetDataCust("select CardID,LastName,FirstName,MobilePhone,UID,Id from Customers Where Cardid Like '" & txtFind.Text & "%'  order by cardid ASC ")
		' GetDataCust("select CardID from Customers order by CardID ASC ")
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim cardid As String
			cardid = txtFind.Text
			Try
				If Not IsDBNull(GetCustomerByID(id).Id) Then
					'  custid.Text = GetCustomerByCardID(cardid).Id
					' If cust = strUID Then
					'  Label2.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
					' txtUID.Text = GetCustomerByID(id).Uid
					' outPaid()
				Else
					MsgBox("Wrong data!", MsgBoxStyle.OkOnly, "Message :")
					custid.Focus()
					Exit Sub
				End If

			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End If
	End Sub
	Private Sub FindNew()
		custid.DataBindings.Clear()
		GetDataCustNew("select CardID,LastName,FirstName,MobilePhone,UID,Id from Customers order by CardID ASC ")
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Try
				If Not IsDBNull(GetCustomerByID(id).Id) Then
					' Cust = GetCustomerByUID(strUID).Uid
					' If cust = strUID Then
					'  Label2.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
					' txtUID.Text = GetCustomerByID(id).Uid
					' outPaid()
				Else
					MsgBox("Wrong data!", MsgBoxStyle.OkOnly, "Message :")
					custid.Focus()
					Exit Sub
				End If

			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End If
	End Sub

	Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
		Dim hdmId As Integer = ComboBox2.SelectedValue
		connectToHDM(hdmId)
		Dim con As Boolean
		con = HDMfr.ConnectionCheck()
		If con = True Then
			MsgBox("Connected!", MsgBoxStyle.OkOnly, "Message :")
			connect.Text = "Connected!"
		Else
			' MsgBox("No connection!", MsgBoxStyle.OkOnly, "Message :")
			MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
			connect.Text = "No Connection!"
		End If
	End Sub

	Private Sub HDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		InitCardReader()
		Dim cmd1 As New SqlCommand
		Dim da1 As New SqlDataAdapter
		Dim adapter As New SqlDataAdapter
		Dim ds As New DataSet
		ReadyConnectionF()
		cmd1 = conn.CreateCommand
		cmd1.CommandText = "select * from HdmSettings"
		da1.SelectCommand = cmd1
		da1.Fill(ds, "HdmSettings")
		With ComboBox2
			.DisplayMember = "HdmSettings.hdmId"
			.ValueMember = "hdmId"
			.DataSource = ds
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems

		End With
		hdmIp.DataBindings.Add("Text", ds, "HdmSettings.hdmIp")
		hdmPort.DataBindings.Add("Text", ds, "HdmSettings.hdmPort")
		hdmPassword.DataBindings.Add("Text", ds, "HdmSettings.hdmPassword")

		hdmProduct()
		Dim cmd2 As New SqlCommand
		Dim da2 As New SqlDataAdapter
		Dim ds1 As New DataSet
		cmd2 = conn.CreateCommand
		'   cmd2.CommandText = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm where ADG = '96.02'" 'SPA
		Dim strSql As String
		If lblHDM.Text = 3 Then 'spa salon
			strSql = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description   from ProductHdm where Category = 'salon'"
			cmd2.CommandText = strSql
		End If
		If lblHDM.Text = 1 Then 'KINETIK
			strSql = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm where Category = 'kinetik'"
			cmd2.CommandText = strSql
		End If
		If lblHDM.Text = 2 Then 'spa
			strSql = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm where Category = 'spa'"
			cmd2.CommandText = strSql
		End If
		If lblHDM.Text = 4 Then 'rest
			strSql = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm where Category = 'restoran'"
			cmd2.CommandText = strSql
		End If
		' cmd2.CommandText = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm "
		da2.SelectCommand = cmd2
		da2.Fill(ds1, "ProductHdm")
		With ComboBox3

			.DisplayMember = "ProductHdm.Description"
			.ValueMember = "Category"
			.DataSource = ds1
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems
			' .DropDownStyle = ComboBoxStyle.DropDownList
		End With
		TextBox1.DataBindings.Add("Text", ds1, "ProductHdm.Category")



		Label13.ForeColor = Color.Red
		Label14.ForeColor = Color.Red
		Label15.ForeColor = Color.Red
		Label16.ForeColor = Color.Red
		txtQuantity.Text = 1

	End Sub
	Sub hdmProduct()

		Dim ds As New DataSet
		Dim cmd As New SqlCommand
		Dim da As New SqlDataAdapter
		Dim adapter As New SqlDataAdapter
		Dim cmd3 As New SqlCommand
		ReadyConnectionF()
		Dim cmd2 As New SqlCommand
		Dim da2 As New SqlDataAdapter
		Dim ds1 As New DataSet
		cmd = conn.CreateCommand
		cmd.CommandText = "select * from ProductHdm where Category = '" & TextBox1.Text & " ' "
		da.SelectCommand = cmd
		da.Fill(ds, "ProductHdm")
		With ComboBox1
			.DisplayMember = "ProductHdm.ProductName"
			.ValueMember = "Id"
			.DataSource = ds
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems

		End With
		prodId.DataBindings.Clear()
		prodId.DataBindings.Add("Text", ds, "ProductHdm.ID")
		txtQuantity.DataBindings.Clear()
		txtQuantity.DataBindings.Add("Text", ds, "ProductHdm.Quantity")
		TextBox5.DataBindings.Clear()
		TextBox5.DataBindings.Add("Text", ds, "ProductHdm.NDS")
		TextBox6.DataBindings.Clear()
		TextBox6.DataBindings.Add("Text", ds, "ProductHdm.UniType")
		TextBox2.DataBindings.Clear()
		TextBox2.DataBindings.Add("Text", ds, "ProductHdm.Category1")
		'TextBox1.DataBindings.Clear()
		'TextBox1.DataBindings.Add("Text", ds, "ProductHdm.dep")
		CheckBox2.Checked = False
	End Sub
	Private Sub deposit_Click(sender As Object, e As EventArgs) Handles deposit.Click

		Dim idProd As Integer
		idProd = Int(prodId.Text)
		nameProd = GetHdmItemsByID(idProd).ProductName
		PaidAmount = Math.Round(CDec(Val(amountCash.Text)))

		hdmCashDeposit(idProd, nameProd, PaidAmount)
		ref()
		'  End If
	End Sub
	Public Sub hdmCashDeposit(idProd As Integer, nameProd As String, Paidamount As Decimal)
		If custid.Text <> "" Then
			'Dim dep As Integer
			'dep = CInt(TextBox1.Text)
			Dim id As Integer = CInt(custid.Text)

			Dim hdmid As Integer
			' hdmid = CInt(ComboBox2.SelectedValue)
			hdmid = CInt(lblHDM.Text)
			nameProd = GetHdmItemsByID(idProd).ProductName
			HDMfr.OpenSaleDocument(3)

			Dim check As Boolean
			Dim result As DialogResult
			result = MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm")
			If result = MsgBoxResult.Cancel Then
				Exit Sub
			ElseIf result = MsgBoxResult.Ok Then
				check = HDMfr.PrintDocument(Paidamount, 0)
				If check = True Then

					paidDeposit(PayMethode:="Cash")
					'  insertHdmCheck(Paidamount, nameProd, PaymentMethode:="Cash", hdmId:=hdmid, dep:=16)
					insertHdmCheckNew(Paidamount, nameProd, PaymentMethode:="Cash", hdmId:=1, dep:=id) 'dep eto customerid
					'MsgBox("ok print")
				Else
					MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
					MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
				End If


			End If

		Else
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
	End Sub
	Public Sub hdmPOSDeposit(idProd As Integer, nameProd As String, Paidamount As Decimal)
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim hdmid As Integer
			'  hdmid = CInt(ComboBox2.SelectedValue)
			hdmid = CInt(lblHDM.Text)
			nameProd = GetHdmItemsByID(idProd).ProductName
			HDMfr.OpenSaleDocument(3)
			Dim check As Boolean
			Dim result As DialogResult
			result = MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm")
			If result = MsgBoxResult.Cancel Then
				Exit Sub
			ElseIf result = MsgBoxResult.Ok Then
				check = HDMfr.PrintDocument(0, Paidamount)

				If check = True Then
					paidDeposit(PayMethode:="POS")
					'  MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
					'   insertHdmCheck(Paidamount, nameProd, PaymentMethode:="POS", hdmId:=hdmid, dep:=16)
					insertHdmCheckNew(Paidamount, nameProd, PaymentMethode:="POS", hdmId:=1, dep:=id)

				Else
					MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
					MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
				End If
			End If
		Else
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
	End Sub
	Sub hdmPrintCheckCash(cashAmount As Decimal, posamount As Decimal, paymethode As String)
		' Dim frm As New StartForm
		Dim hdmid As Integer
		hdmid = CInt(ComboBox2.SelectedValue)
		Dim item As Boolean
		Dim idProd As Integer
		'  hdmSettings()
		idProd = Int(prodId.Text)
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			dep = GetHdmItemsByID(idProd).dep
			If dep = 16 Then
				MsgBox("Wrong product", MsgBoxStyle.OkOnly, "Message :")
				ComboBox3.Focus()
				Exit Sub
			Else

				nameProd = GetHdmItemsByID(idProd).ProductName
				codeProd = GetHdmItemsByID(idProd).ProductCode
				unit = GetHdmItemsByID(idProd).UnitType
				adgCode = GetHdmItemsByID(idProd).ADG
				pos = CDec(Val(amountPOS.Text))
				qty1 = CDec(Val(txtQuantity.Text))
				price = Math.Round(CDec(Val(txtPrice.Text)))
				cash = Math.Round(price * qty1, 2)
				discount = CDec(Val(txtDiscount.Text))
				' amountCash.Text = cash - cash * discount / 100
				' Totalprice = Math.Round(CDec(Val(amountCash.Text)))
				Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
				HDMfr.OpenSaleDocument(2)
				item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, cash, 1) 'OK
				Dim PaymentMethode As String
				'  HDM.PrintDocument(cashAmount, posamount)
				PaymentMethode = paymethode
				Dim checkNumber
				checkNumber = HDMfr.FiscalData.Rseq
				'HDM.PrintDocument(0, Totalprice)
				'    PaymentMethode = "POS"
				'  Dim check As Boolean
				Dim result As DialogResult
				result = MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm")
				If result = MsgBoxResult.Cancel Then
					Exit Sub
				ElseIf result = MsgBoxResult.Ok Then
					'   check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

					If HDMfr.PrintDocument(cashAmount, posamount) = True Then
						'  MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
						'  insertHdmCheck(Totalprice, nameProd, PaymentMethode, hdmid, dep)
						insertHdmCheckNew(Totalprice, nameProd, PaymentMethode, 1, id)
						paidCash(PayMethode:="Cash")
					Else
						MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
						MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
						' Console.Write("Not")
					End If
				End If

			End If

		Else
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If


	End Sub
	Sub hdmPrintCheckPOS(cashAmount As Decimal, posamount As Decimal, paymethode As String)
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim hdmid As Integer
			hdmid = CInt(ComboBox2.SelectedValue)
			Dim item As Boolean
			Dim idProd As Integer
			'  hdmSettings()
			idProd = Int(prodId.Text)
			'If CheckBox2.Checked = False Then
			'    dep = GetHdmItemsByID(idProd).dep
			'Else
			'    dep = 13
			'End If
			dep = GetHdmItemsByID(idProd).dep
			If dep = 16 Then
				MsgBox("Wrong product", MsgBoxStyle.OkOnly, "Message :")
				ComboBox3.Focus()
				Exit Sub
			Else
				dep = 14
				nameProd = GetHdmItemsByID(idProd).ProductName
				codeProd = GetHdmItemsByID(idProd).ProductCode
				unit = GetHdmItemsByID(idProd).UnitType
				adgCode = GetHdmItemsByID(idProd).ADG
				pos = CDec(Val(amountPOS.Text))
				qty1 = CDec(Val(txtQuantity.Text))
				price = Math.Round(CDec(Val(txtPrice.Text)))
				cash = Math.Round(price * qty1, 2)
				discount = CDec(Val(txtDiscount.Text))
				' amountCash.Text = cash - cash * discount / 100
				' Totalprice = Math.Round(CDec(Val(amountCash.Text)))
				Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
				HDMfr.OpenSaleDocument(2)
				item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, cash, 1) 'OK
				Dim PaymentMethode As String
				'  HDM.PrintDocument(cashAmount, posamount)
				PaymentMethode = paymethode

				'HDM.PrintDocument(0, Totalprice)
				'    PaymentMethode = "POS"
				Dim check As Boolean
				Dim result As DialogResult
				result = MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm")
				If result = MsgBoxResult.Cancel Then
					Exit Sub
				ElseIf result = MsgBoxResult.Ok Then
					check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

					If check = True Then
						'  MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
						'   insertHdmCheck(Totalprice, nameProd, PaymentMethode, hdmid, dep)
						insertHdmCheckNew(Totalprice, nameProd, PaymentMethode, 1, id)
						paidCash(PayMethode:="POS")
					Else
						MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
						MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
						' Console.Write("Not")
					End If
				End If
			End If

		Else
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If



	End Sub
	Sub hdmPOS()
		Dim hdmId As Integer
		hdmId = CInt(ComboBox2.SelectedText)
		Dim item As Boolean
		Dim idProd As Integer
		idProd = Int(prodId.Text)
		If CheckBox2.Checked = False Then
			dep = GetHdmItemsByID(idProd).dep
		Else
			dep = 13
		End If
		nameProd = GetHdmItemsByID(idProd).ProductName
		codeProd = GetHdmItemsByID(idProd).ProductCode
		unit = GetHdmItemsByID(idProd).UnitType
		adgCode = GetHdmItemsByID(idProd).ADG
		pos = CDec(Val(amountPOS.Text))
		qty1 = CDec(Val(txtQuantity.Text))
		price = Math.Round(CDec(Val(txtPrice.Text)))
		cash = Math.Round(price * qty1, 2)
		discount = CDec(Val(txtDiscount.Text))
		'  amountCash.Text = cash - cash * discount / 100
		' Totalprice = Math.Round(CDec(Val(amountCash.Text)))
		Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
		HDMfr.OpenSaleDocument(2)
		item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, cash, 1) 'OK
		Dim PaymentMethode As String

		'HDM.PrintDocument(Totalprice, 0)
		'PaymentMethode = "cash"

		HDMfr.PrintDocument(0, Totalprice)
		PaymentMethode = "POS"



		' insertHdmCheck(Totalprice, nameProd, PaymentMethode, hdmId, dep)




	End Sub
	Sub hdmPrepaymentUsage()
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim hdmId As Integer
			hdmId = CInt(ComboBox2.SelectedValue)
			Dim item As Boolean
			Dim idProd As Integer
			idProd = Int(prodId.Text)
			dep = GetHdmItemsByID(idProd).dep
			nameProd = GetHdmItemsByID(idProd).ProductName
			codeProd = GetHdmItemsByID(idProd).ProductCode
			unit = GetHdmItemsByID(idProd).UnitType
			adgCode = GetHdmItemsByID(idProd).ADG
			pos = CDec(Val(amountPOS.Text))
			qty1 = CDec(Val(txtQuantity.Text))
			price = Math.Round(CDec(Val(txtPrice.Text)))
			cash = Math.Round(price * qty1, 2)
			discount = CDec(Val(txtDiscount.Text))
			Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
			HDMfr.OpenSaleDocument(2)
			item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, cash, 1) 'OK
			If item = False Then
				MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
				Exit Sub
			Else

				Dim PaymentMethode As String
				Dim check As Boolean
				Dim result As DialogResult
				result = MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm")
				If result = MsgBoxResult.Cancel Then
					Exit Sub
				ElseIf result = MsgBoxResult.Ok Then
					check = HDMfr.PrintDocument(0, 0, 0, Totalprice) 'prePaymentAmount
					PaymentMethode = "PrepUsage"
					If check = True Then
						'    MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
						' insertHdmCheck(Totalprice, nameProd, PaymentMethode, hdmId, dep)
						insertHdmCheckNew(Totalprice, nameProd, PaymentMethode, hdmId, id)
						paidFromdepositRest()
					Else
						MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
						MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")

					End If
				End If
			End If
		Else
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		hdmPrepaymentUsage()

	End Sub
	Sub outPaid()
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim cmd1 As New SqlCommand

			Dim da1 As New SqlDataAdapter

			Dim ds As New DataSet
			Dim dt As New DataTable
			ReadyConnectionF()
			cmd1 = conn.CreateCommand
			cmd1.CommandText = "select * from unionTotal where  CustomerID = '" & id & " ' "
			'cmd1.CommandText = "select * from OutReceptionAll where  CustomerID = '" & custid.Text & " ' "
			da1.SelectCommand = cmd1
			da1.Fill(ds, "OutReception")
			ListView1.Clear()
			For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
				ListView1.Columns.Add(ds.Tables(0).Columns(i).ToString())
				With ListView1
					.Items.Clear()
					.View = View.Details
					.GridLines = True
					.FullRowSelect = True
					.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
					.MultiSelect = False
					'.CheckBoxes = True
				End With
			Next
			For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				Dim listRow As New ListViewItem
				listRow.Text = ds.Tables(0).Rows(i)(0).ToString()
				For j As Integer = 1 To ds.Tables(0).Columns.Count - 1
					listRow.SubItems.Add(ds.Tables(0).Rows(i)(j).ToString())
					'If ListView1.Items(i).SubItems(8).Text IsNot Nothing And ListView1.Items(i).SubItems(6).Text = 2 Then
					'    ListView1.Items(i).BackColor = Drawing.Color.Red
					'End If
				Next
				ListView1.Items.Add(listRow)
			Next
		Else
		End If
		Dim sql As String
		Dim adapter As New SqlDataAdapter
		Dim ds1 As New DataSet
		sql = "select * from Customers order by CardID "
		adapter = New SqlDataAdapter(sql, Connection)
		adapter.Fill(ds1, "dtCustomers")
		With Combobox7
			.DisplayMember = "dtCustomers.ID"
			.ValueMember = "ID"
			.DataSource = ds1

		End With

	End Sub
	Private Sub Button4_Click(sender As Object, e As EventArgs)
		hdmProduct()
	End Sub



	Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown

		hdmProduct()
		If e.KeyCode = Keys.Enter Then
			SendKeys.Send(vbTab)
		End If
	End Sub

	Private Sub ComboBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyUp
		hdmProduct()
	End Sub

	Private Sub ComboBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox3.MouseClick
		hdmProduct()
	End Sub



	Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
		hdmProduct()
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		hdmProduct()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
		' paidCash(PayMethode:="Cash")
		hdmPrintCheckCash(Totalprice, 0, "Cash")
		ref()
	End Sub



	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
		qty1 = CDec(Val(txtQuantity.Text))
		txtPrice.Text = Math.Round(CDec(Val(amountCash.Text)) / qty1, 2)

		discount = CDec(Val(txtDiscount.Text))
		cash = amountCash.Text
		amountDisc.Text = cash - cash * discount / 100

	End Sub

	Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
		qty1 = CDec(Val(txtQuantity.Text))
		discount = CDec(Val(txtDiscount.Text))
		cash = amountCash.Text
		amountDisc.Text = cash - cash * discount / 100
	End Sub

	Sub FindName()
		Dim sql As String
		Dim adapter As New SqlDataAdapter
		Dim ds1 As New DataSet
		ReadyConnectionF()
		sql = "select * from Customers order by CardID "
		adapter = New SqlDataAdapter(sql, Connection)
		adapter.Fill(ds1, "dtCustomers")
		With Combobox7
			.DisplayMember = "dtCustomers.ID"
			.ValueMember = "ID"
			.DataSource = ds1

		End With
		If txtFind.Text <> "" And Combobox7.Items.Count > 0 Then
			Combobox7.SelectedIndex = 0
		Else
			'If txtFind.Text <> "" And custid.Text > 0 Then
			'    custid.Text = custid.Text ' Combobox7.SelectedIndex = 0
			'Else
			DataGridView3.Rows(0).Selected = True
		End If
		Try
			Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView3.DataSource, DataGridView3.DataMember), CurrencyManager)
			Dim dv As DataView = CType(cm.List, DataView)
			'  dv.RowFilter = String.Format("FirstName like '{0}*' AND LastName like '{1}*'", txtFirst.Text, txtLast.Text)
			dv.RowFilter = String.Format("FirstName like '{0}*' AND LastName like '{1}*'", txtFind.Text, txtfind1.Text)

			cm.Refresh()
			If cm.List.Count = 0 Then
				MessageBox.Show("No any data!")
				DataGridView3.Rows(0).Selected = True
				Exit Sub
			Else

			End If



		Catch abc As Exception
			MessageBox.Show("Sorry!")
		End Try

	End Sub

	Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
		Find()
		ref()
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
		ref()
	End Sub
	Sub ref()
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName

			Label14.Text = GetActiveOrderByID(id) ' + GetTotalHdmByID(id).Total + GetTotalHdmByID(id).Restoran + GetTotalHdmByID(id).SPA
			'  Dim depos = depositBalance(cusID:=id)
			Label16.Text = "Deposit balance restoran  " & depositBalance(id)
			Label19.Text = "Deposit balance spa  " & depositBalanceSPA(id)
			Dim Result = GetTotalHdmByID(id)

			If Result Is Nothing OrElse IsDBNull(Result) Then
				'no result!'
				Label15.Text = "TOTAL  " & 0
				Label13.Text = "Restoran  " & 0
				Label14.Text = "SPA  " & 0
			Else
				Label15.Text = "TOTAL  " & GetTotalHdmByID(id).Total
				Label13.Text = "Restoran  " & GetTotalHdmByID(id).Restoran
				Label14.Text = "SPA  " & GetTotalHdmByID(id).SPA
			End If
			CheckBox2.Checked = False
			'no result!'
			' outPaid()
		Else
			Label3.Text = "FIO"
			' MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
	End Sub

	Private Sub DataGridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView3.KeyDown
		ref()
	End Sub

	Private Sub DataGridView3_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView3.KeyUp
		ref()
	End Sub

	Private Sub DataGridView3_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView3.MouseClick
		ref()
		'  refList()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		'   outPaid()

	End Sub





	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
		'  paidCash(PayMethode:="POS")
		hdmPrintCheckPOS(0, Totalprice, "POS")
		ref()
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

		Dim id As Integer = CInt(custid.Text)
		Dim idProd As Integer
		idProd = Int(prodId.Text)
		nameProd = GetHdmItemsByID(idProd).ProductName
		PaidAmount = Math.Round(CDec(Val(amountCash.Text)))

		hdmPOSDeposit(idProd, nameProd, PaidAmount)
		ref()
		'  End If
	End Sub
	Sub paidCash(PayMethode As String)


		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim idProd As Integer
			idProd = Int(prodId.Text)
			Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
			codeProd = GetHdmItemsByID(idProd).ProductCode
			'  Dim id As Integer  = CInt(custid.Text)
			PaidAmount = Math.Round(CDec(Val(amountCash.Text)))
			If codeProd = "16" Then
				MsgBox("Selection not valid!")
				ComboBox3.Focus()
				Exit Sub
			Else
				If PaidAmount > 0 Then
					Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
					dep = GetHdmItemsByID(idProd).dep
					nameProd = GetHdmItemsByID(idProd).ProductName
					codeProd = GetHdmItemsByID(idProd).ProductCode
					unit = GetHdmItemsByID(idProd).UnitType
					adgCode = GetHdmItemsByID(idProd).ADG
					PaymentBase = GetHdmItemsByID(idProd).Category1
					pos = CDec(Val(amountPOS.Text))
					qty1 = CDec(Val(txtQuantity.Text))
					price = Math.Round(CDec(Val(txtPrice.Text)))
					cash = Math.Round(price * qty1, 2)
					discount = CDec(Val(txtDiscount.Text))
					'  amountCash.Text = cash - cash * discount / 100
					' Totalprice = Math.Round(CDec(Val(amountCash.Text)))
					PaidAmount = Math.Round(CDec(Val(amountCash.Text)))
					Totalprice = cash - cash * discount / 100
					PayAdditional(id, cashier:="HDM", prodId:=idProd, PaymentMethode:=PayMethode, PaymentBasic:=PaymentBase, UnitPrice:=price, OrderID:=0, Quantity:=qty1, amount:=Totalprice)
					MsgBox("Payment complete!") ''mojno dobavit print check
					'insertHdmCheck(PaidAmount, TextBox2.Text, PayMethode)
					'insertHdmCheck(PaidAmount, nameProd, PayMethode)
				Else
					MsgBox("Amount is not valid!")
					amountCash.Focus()
					Exit Sub
				End If
			End If
		Else
			Label3.Text = "FIO"
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If

	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		paidCash(PayMethode:="Cash")
		ref()
	End Sub

	Private Sub amountCash_TextChanged(sender As Object, e As EventArgs) Handles amountCash.TextChanged
		If amountCash.Text = "" Then
			MsgBox("Please enter amount !")
			amountCash.Focus()
			Exit Sub
		Else
			qty1 = CDec(Val(txtQuantity.Text))

			txtPrice.Text = Math.Round(CDec(Val(amountCash.Text)) / qty1, 2)
			' cash = Math.Round(CDec(Val(txtPrice.Text)) * qty1, 2)
			discount = CDec(Val(txtDiscount.Text))
			cash = amountCash.Text
			amountDisc.Text = cash - cash * discount / 100
		End If
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		paidCash(PayMethode:="POS")
		ref()
	End Sub

	Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown

		If e.KeyCode = Keys.Enter Then
			SendKeys.Send(vbTab)
			Find()
		End If
	End Sub

	Sub paidFromdepositRest()


		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim idProd As Integer
			idProd = Int(prodId.Text)
			Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
			codeProd = GetHdmItemsByID(idProd).ProductCode
			'  Dim id As Integer  = CInt(custid.Text)
			PaidAmount = Math.Round(CDec(Val(amountCash.Text)))
			If codeProd = "16" Then
				MsgBox("Selection not valid!")
				ComboBox3.Focus()
				Exit Sub
			Else
				If PaidAmount > 0 And GetDeposit(id) >= PaidAmount Then
					Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
					dep = GetHdmItemsByID(idProd).dep
					nameProd = GetHdmItemsByID(idProd).ProductName
					codeProd = GetHdmItemsByID(idProd).ProductCode
					unit = GetHdmItemsByID(idProd).UnitType
					adgCode = GetHdmItemsByID(idProd).ADG
					PaymentBase = GetHdmItemsByID(idProd).Category1
					pos = CDec(Val(amountPOS.Text))
					qty1 = CDec(Val(txtQuantity.Text))
					price = Math.Round(CDec(Val(txtPrice.Text)))
					cash = Math.Round(price * qty1, 2)
					discount = CDec(Val(txtDiscount.Text))
					'  amountCash.Text = cash - cash * discount / 100
					' Totalprice = Math.Round(CDec(Val(amountCash.Text)))
					PaidAmount = Math.Round(CDec(Val(amountCash.Text)))
					Totalprice = cash - cash * discount / 100
					PayAdditional(id, cashier:="HDM", prodId:=idProd, PaymentMethode:="deposit", PaymentBasic:=PaymentBase, UnitPrice:=price, OrderID:=0, Quantity:=qty1, amount:=Totalprice)
					MsgBox("Payment complete!") ''mojno dobavit print check
					minusDepositRest(id, Totalprice)
					depositHistory(customerID:=id, amount:=-(Totalprice), Reason:="HDM")
					PayAdditional(id, cashier:="HDM", prodId:=idProd, PaymentMethode:="deposit", PaymentBasic:="deposit", UnitPrice:=price, OrderID:=0, Quantity:=qty1, amount:=-(Totalprice))
				Else
					MsgBox("Amount is not valid!")
					amountCash.Focus()
					Exit Sub
				End If
			End If
		Else
			Label3.Text = "FIO"
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
		ref()
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		If CardReaderAvailable Then
			Try
				txtFind.Text = CardReader.GetUniqueNumber()
			Catch
				MessageBox.Show("Place card on reader")
			End Try
		Else
			MessageBox.Show("Card reader not connected")
		End If
	End Sub

	Sub paidDeposit(PayMethode As String) 'rabotaet ok
		If custid.Text <> "" Then
			Dim id As Integer = CInt(custid.Text)
			Dim idProd As Integer
			idProd = Int(prodId.Text)
			Label3.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
			codeProd = GetHdmItemsByID(idProd).ProductCode
			'  Dim id As Integer  = CInt(custid.Text)

			PaidAmount = Math.Round(CDec(Val(amountCash.Text)))
			If codeProd <> "16" Then
				MsgBox("Selection not valid!")
				ComboBox3.Focus()
				Exit Sub
			Else
				If PaidAmount > 0 And idProd <> 260 Then
					If lblHDM.Text = 4 Then
						PayAdditional(id, cashier:="HDM", prodId:=0, PaymentMethode:=PayMethode, PaymentBasic:=TextBox2.Text, UnitPrice:=PaidAmount, OrderID:=0, Quantity:=1, amount:=PaidAmount)

						createDepositAccount(id)
						addDeposit(id, PaidAmount)
						depositHistory(customerID:=id, amount:=PaidAmount, Reason:="Prepayment")
					Else
						If lblHDM.Text = 2 Or lblHDM.Text = 3 Then
							PayAdditional(id, cashier:="HDM", prodId:=0, PaymentMethode:=PayMethode, PaymentBasic:=TextBox2.Text, UnitPrice:=PaidAmount, OrderID:=0, Quantity:=1, amount:=PaidAmount)
							createDepositSPA(id)
							addDepositSPA(id, PaidAmount)
							depositHistory(customerID:=id, amount:=PaidAmount, Reason:="Prepayment")

						End If
					End If
				Else
					'  MsgBox("Amount is not valid!")
					amountCash.Focus()
					Exit Sub
				End If
			End If
		Else
			Label3.Text = "FIO"
			MsgBox("Please select client!")
			txtFind.Focus()
			Exit Sub
		End If
	End Sub
	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		paidDeposit(PayMethode:="Cash")
		ref()
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		paidDeposit(PayMethode:="POS")
		ref()
	End Sub



	Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
		FindNew()
		ref()
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		'hdmProduct()
	End Sub

	Private Sub ComboBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyUp
		' hdmProduct()
	End Sub

	Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
		'  hdmProduct()
	End Sub

	Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

	End Sub

	Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

		'paidFromdeposit()
	End Sub

	Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
		HDMfr.PrintCopy()
	End Sub

	Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

	End Sub

	Private Sub amountCash_Leave(sender As Object, e As EventArgs) Handles amountCash.Leave
		If amountCash.Text = "" Then
			MsgBox("Please enter amount !")
			amountCash.Focus()
			Exit Sub
		End If
	End Sub

	Private Sub Button11_Click_1()

	End Sub

	Private Sub Button3_Click_1()

	End Sub
End Class
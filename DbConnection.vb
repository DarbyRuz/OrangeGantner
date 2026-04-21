Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports System.ComponentModel
Imports System.IO

Module Connect
	Friend Class AsyncWorker
		Private Task As Task = Nothing

		Public Async Function RunWork(action As Action) As Task
			If (Task IsNot Nothing) Then Await Task
			Dim source As New TaskCompletionSource(Of Object)()
			Task = source.Task

			Dim worker As New BackgroundWorker() With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
			AddHandler worker.DoWork,
				Sub(sender, e)
					action.Invoke()
				End Sub
			AddHandler worker.RunWorkerCompleted,
				Sub(sender, e)
					If e.Error IsNot Nothing Then
						source.SetException(e.Error)
					Else
						source.SetResult(Nothing)
					End If
				End Sub

			worker.RunWorkerAsync()
			Await source.Task
		End Function

		Public Async Function RunWork(Of T)(action As Func(Of T)) As Task(Of T)
			If (Task IsNot Nothing) Then Await Task
			Dim source As New TaskCompletionSource(Of T)()
			Task = source.Task

			Dim worker As New BackgroundWorker() With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
			AddHandler worker.DoWork,
				Sub(sender, e)
					e.Result = action.Invoke()
				End Sub
			AddHandler worker.RunWorkerCompleted,
				Sub(sender, e)
					If e.Error IsNot Nothing Then
						source.SetException(e.Error)
					Else
						source.SetResult(e.Result)
					End If
				End Sub

			worker.RunWorkerAsync()
			Return Await source.Task
		End Function
	End Class

	Public ReadOnly Worker As New AsyncWorker()

	Public Function GetConnect()
		conn = New SqlConnection(connectionString)
		Return conn
	End Function


	Public ReadOnly Property Connection() As SqlConnection
		Get
			Return conn
		End Get
	End Property

	Public Async Function ReadyConnectionFAsync() As Task
		conn = New SqlConnection()

		conn = New SqlConnection(connectionString)

		If conn.State <> ConnectionState.Open Then
			Await (conn.OpenAsync())
		End If

	End Function

	Public Function ReadyConnectionFNew() As SqlConnection
		Dim newconn = New SqlConnection()

		newconn = New SqlConnection(connectionString)

		If newconn.State <> ConnectionState.Open Then
			newconn.Open()
		End If
		Return newconn
	End Function

	Public Sub ReadyConnectionF()
		conn = New SqlConnection()

		conn = New SqlConnection(connectionString)

		If conn.State <> ConnectionState.Open Then
			conn.Open()
		End If
		Return
	End Sub

	Public Function GetSqlConnection() As SqlConnection
		Dim newConn = New SqlConnection()

		newConn = New SqlConnection(connectionString)

		If newConn.State <> ConnectionState.Open Then
			newConn.Open()
		End If
		Return newConn
	End Function

	Public Function ExecuteNonQuery(command As SqlCommand) As Integer
		Try

			ReadyConnectionF()
			command.Connection = conn
			Dim result As Integer = command.ExecuteNonQuery()
			Return result


			Throw New Exception()
		Catch Ex As Exception

			Throw Ex
		End Try
	End Function

	Public Async Function ExecuteReaderAsync(command As SqlCommand) As Task(Of SqlDataReader)
		Try
			Await (ReadyConnectionFAsync())
			command.Connection = conn
			Dim result As SqlDataReader = Await (command.ExecuteReaderAsync(CommandBehavior.CloseConnection))
			Return result
			Throw New Exception()
		Catch Ex As Exception

			Throw Ex
		End Try
	End Function

	Public Function ExecuteReader(command As SqlCommand) As SqlDataReader
		Try
			ReadyConnectionF()
			command.Connection = conn
			Dim result As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
			Return result
			Throw New Exception()
		Catch Ex As Exception

			Throw Ex
		End Try
	End Function

	Public Function ExecuteScalar(command As SqlCommand) As Object
		Try
			ReadyConnectionF()
			command.Connection = conn

			Dim value As Object = command.ExecuteScalar()
			If TypeOf value Is DBNull Then
				Return Nothing
			Else
				Return value
			End If
		Catch ex As Exception
			Throw ex
		End Try
	End Function

	Public Function GetClipId(customerID As Integer) As Object


		Dim command As New SqlCommand
		command.CommandText = "Select clid From clipNew where customerid = '" & customerID & " ' "

		Dim retVal As Boolean = False

		Dim sqlResult As Object = ExecuteScalar(command)

		If (sqlResult IsNot Nothing) Then

			retVal = True
			' Debug.Print(CardID)
		Else

			'MsgBox("Item Not Found", MsgBoxStyle.Exclamation, "Warning")
			retVal = False

		End If

		Return retVal

	End Function

	Public Function CashManualyRest(customerID As Integer) As Boolean
		Dim retvalue As Boolean = False
		'Using con = New SqlConnection(connectionString)
		'    con.Open()
		ReadyConnectionF()
		Using cmd = New SqlCommand("Getbalance", conn)
			Using cmd1 = New SqlCommand("GetDepositF", conn)
				Using cmdUpdPay = New SqlCommand("GatUpdateOutPayment", conn)
					Using cmdUpdDeposit = New SqlCommand("GatUpdateDeposit", conn)
						Dim custid As Integer = GetCustomerByID(customerID).Id
						cmd.CommandType = CommandType.StoredProcedure
						cmd.Parameters.Add(New SqlParameter("@CustomerID", custid))
						Dim retvalP As SqlParameter = New SqlParameter("@result_paid", SqlDbType.Decimal, 50)
						retvalP.Direction = ParameterDirection.ReturnValue
						cmd.Parameters.Add(retvalP)
						cmd.ExecuteNonQuery()
						Dim resultToPaid = Convert.ToDecimal(retvalP.Value)
						If resultToPaid > 0 Then
							cmd1.CommandType = CommandType.StoredProcedure
							cmd1.Parameters.Add(New SqlParameter("@CustomerID", custid))
							Dim returnParameter = cmd1.Parameters.Add("@result_deposit", SqlDbType.Decimal)
							returnParameter.Direction = ParameterDirection.ReturnValue
							cmd1.ExecuteScalar()

							Dim resultDeposit = Convert.ToDecimal(returnParameter.Value)
							If resultDeposit >= resultToPaid Then
								Dim newDepResult = resultDeposit - resultToPaid
								cmdUpdPay.CommandType = CommandType.StoredProcedure
								cmdUpdPay.Parameters.Add(New SqlParameter("@CustomerID", custid))
								' cmdUpdPay.Parameters.Add(New SqlParameter("@minusDepos", resultDeposit))
								cmdUpdPay.ExecuteNonQuery()
								cmdUpdDeposit.CommandType = CommandType.StoredProcedure
								cmdUpdDeposit.Parameters.Add(New SqlParameter("@CustomerID", custid))
								cmdUpdDeposit.Parameters.Add(New SqlParameter("@DepositAmount", newDepResult))
								cmdUpdDeposit.ExecuteNonQuery()
								retvalue = True
								Return retvalue
							Else
								retvalue = False
								Return retvalue
							End If
						Else
							retvalue = True
							Return retvalue
						End If
					End Using
				End Using
			End Using
		End Using
		' End Using
	End Function

	Public Function CashManualySPA(customerID As Integer) As Boolean
		Dim retvalue As Boolean = False
		'Using con = New SqlConnection(connectionString)
		'    con.Open()
		ReadyConnectionF()
		Using cmd = New SqlCommand("GetbalanceSpa", conn)
			Using cmd1 = New SqlCommand("GetDepositSpa", conn)
				Using cmdUpdPay = New SqlCommand("GatUpdateOutPaymentSPA", conn)
					Using cmdUpdDeposit = New SqlCommand("GatUpdateDepositSPA", conn)
						Dim custid As Integer = GetCustomerByID(customerID).Id
						cmd.CommandType = CommandType.StoredProcedure
						cmd.Parameters.Add(New SqlParameter("@CustomerID", custid))
						Dim retvalP As SqlParameter = New SqlParameter("@result_paid", SqlDbType.Decimal, 50)
						retvalP.Direction = ParameterDirection.ReturnValue
						cmd.Parameters.Add(retvalP)
						cmd.ExecuteNonQuery()
						Dim resultToPaid = Convert.ToDecimal(retvalP.Value)
						If resultToPaid > 0 Then
							cmd1.CommandType = CommandType.StoredProcedure
							cmd1.Parameters.Add(New SqlParameter("@CustomerID", custid))
							Dim returnParameter = cmd1.Parameters.Add("@result_deposit", SqlDbType.Decimal)
							returnParameter.Direction = ParameterDirection.ReturnValue
							cmd1.ExecuteScalar()
							Dim resultDeposit = Convert.ToDecimal(returnParameter.Value)
							If resultDeposit >= resultToPaid Then
								Dim newDepResult = resultDeposit - resultToPaid
								cmdUpdPay.CommandType = CommandType.StoredProcedure
								cmdUpdPay.Parameters.Add(New SqlParameter("@CustomerID", custid))
								'cmdUpdPay.Parameters.Add(New SqlParameter("@minusDepos", newDepResult))
								cmdUpdPay.ExecuteNonQuery()
								cmdUpdDeposit.CommandType = CommandType.StoredProcedure
								cmdUpdDeposit.Parameters.Add(New SqlParameter("@CustomerID", custid))
								cmdUpdDeposit.Parameters.Add(New SqlParameter("@DepositAmount", newDepResult))
								cmdUpdDeposit.ExecuteNonQuery()
								retvalue = True
								Return retvalue
							Else
								retvalue = False
								Return retvalue
							End If
						Else
							retvalue = True
							Return retvalue
						End If
					End Using
				End Using
			End Using
		End Using
		' End Using
	End Function

	Public Function StatusCardId(cID As Integer) As Object

		Dim command, command1 As New SqlCommand

		Dim sqlResult, sqlResult1 As New Object

		ReadyConnectionF()

		Dim retVal As String = Nothing
		command.CommandText = "select status from OrderBalance where CustomerID = '" & cID & " 'and status=1 "
		sqlResult = ExecuteScalar(command)
		If (sqlResult IsNot Nothing) Then
			'   MsgBox("No Contract", MsgBoxStyle.Exclamation, "Warning")

			retVal = retVal + "ACTIVE"
			Return retVal
		Else


			command.CommandText = "select * from freezSql where CustomerID = '" & cID & " '" &
										"and ddStart >=0  and ddEnd <= 0"

			sqlResult = ExecuteScalar(command)
			If (sqlResult IsNot Nothing) Then
				retVal = retVal + "Frozen"
				Return retVal

			Else
				retVal = retVal + "Not Active"
				Return retVal
			End If
		End If

	End Function

	Public Sub CustomerHistory(customerID As Integer, CardID As String, Reason As String, Admin As String)
		Dim stComp As String = Environment.GetEnvironmentVariable("COMPUTERNAME")

		Dim cmd1 As New SqlCommand("Insert into CustomerHistory(customerID, DateChanges,CardID, Reason,Administrator,computer) VALUES(@customerID ,@DateChanges,@CardID,@Reason,@Administrator,@computer)", conn)
		cmd1.Parameters.Add(New SqlParameter("@CustomerID", customerID))
		cmd1.Parameters.Add(New SqlParameter("@DateChanges", Date.Now))
		cmd1.Parameters.Add(New SqlParameter("@CardID", CardID))
		cmd1.Parameters.Add(New SqlParameter("@Reason", Reason))
		cmd1.Parameters.Add(New SqlParameter("@Administrator", Admin))
		cmd1.Parameters.Add(New SqlParameter("@computer", stComp))

		Try
			ExecuteNonQuery(cmd1)
		Catch ex As SqlException

		End Try
	End Sub

	Public Sub PayAdditional(custID As Integer, cashier As String, prodId As Integer, PaymentMethode As String, PaymentBasic As String, UnitPrice As Decimal, OrderID As Integer, Quantity As Decimal, amount As Decimal)

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
			'  conn.Close()
			idDetID = idDetID + 1
		End If


		Dim CMD As New SqlCommand("InsertPayment")
		' CMD.Parameters.Clear()
		CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

		CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
		CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
		CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = PaymentMethode



		CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = PaymentBasic ' "ClipCard" 'cmbBasic.Text

		CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Additional"

		CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
		CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = "" 'cmbAdmin.Text & "/" & RichTextBox3.Text
		CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'Int(TextBox31.Text) 'coach
		CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = prodId ' Int(TextBox29.Text)
		CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


		CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

		CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
		CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
		CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
		CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
		CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = UnitPrice ' Int(amount / Int(TextBox27.Text))

		CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = Quantity ' Int(TextBox27.Text)

		CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
		CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"


		CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID
		'End If
		CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

		ExecuteProcedur.ExecuteCMD(CMD)

		'createDepositAccount(custID)
		' addDeposit(custID, amount)
		'  depositHistory(customerID:=custID, amount:=amount, Reason:=cashier)


	End Sub

	Public Function createDepositAccount(customerID)

		Dim res As Customer = Nothing

		Dim cmdPoDetID As New SqlCommand("select CustomerID  from Deposit where CustomerID = customerID", conn)

		cmdPoDetID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		cmdPoDetID.CommandText = "select CustomerID  from Deposit where CustomerID = @CustomerID"

		Dim idDetID As Object = ExecuteScalar(cmdPoDetID)
		If idDetID Is Nothing Then


			Dim cmdDepID1 As New SqlCommand("InsertDeposit")
			cmdDepID1.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = 0
			cmdDepID1.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
			ExecuteProcedur.ExecuteCMD(cmdDepID1)
		End If
		Return res
	End Function

	Public Function createDepositSPA(customerID)

		Dim res As Customer = Nothing

		Dim cmdPoDetID As New SqlCommand("select CustomerID  from DepositSPA where CustomerID = customerID", conn)

		cmdPoDetID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		cmdPoDetID.CommandText = "select CustomerID  from DepositSPA where CustomerID = @CustomerID"

		Dim idDetID As Object = ExecuteScalar(cmdPoDetID)
		If idDetID Is Nothing Then


			Dim cmdDepID1 As New SqlCommand("InsertDepositSPA")
			cmdDepID1.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = 0
			cmdDepID1.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
			ExecuteProcedur.ExecuteCMD(cmdDepID1)
		End If
		Return res
	End Function

	Public Function createDepositSPABonus(customerID)

		Dim res As Customer = Nothing

		Dim cmdPoDetID As New SqlCommand("select CustomerID  from DepositSPABonus where CustomerID = customerID", conn)

		cmdPoDetID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		cmdPoDetID.CommandText = "select CustomerID  from DepositSPABonus where CustomerID = @CustomerID"

		Dim idDetID As Object = ExecuteScalar(cmdPoDetID)
		If idDetID Is Nothing Then


			Dim cmdDepID1 As New SqlCommand("InsertSPABonus")
			cmdDepID1.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = 0
			cmdDepID1.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
			ExecuteProcedur.ExecuteCMD(cmdDepID1)
		End If
		Return res
	End Function

	Public Function GetGuestOwnerID(guestID As Integer)

		ReadyConnectionF()
		Dim cmdOwnerID As New SqlCommand("select distinct CustomerID  from guestcust where GuestID = @guestID", conn)

		cmdOwnerID.Parameters.Add("@guestID", SqlDbType.Int).Value = guestID
		Dim retVal As Integer

		Dim sqlResult As Object = ExecuteScalar(cmdOwnerID)

		If (sqlResult IsNot Nothing) Then

			retVal = ExecuteScalar(cmdOwnerID)
			' Debug.Print(CardID)
		Else


			retVal = 0

		End If

		Return retVal



	End Function

	Public Function updGuestLimit(customerID, limit, orderid)
		Dim res As Customer = Nothing

		' Dim cmdDepID As New SqlCommand("Update guestLimit set guestLimit = @limit   where CustomerID = @CustomerID And orderid = @ordID", conn)
		Dim cmdDepID As New SqlCommand("Update Orders set duration = @limit   where CustomerID = @CustomerID And orderid = @ordID", conn)
		cmdDepID.Parameters.Add("@limit", SqlDbType.Decimal).Value = limit
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		cmdDepID.Parameters.Add("@ordID", SqlDbType.Int).Value = orderid
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function GetDeposit(customerID As Integer)


		Dim cmdDepID As New SqlCommand("Select DepositAmount from Deposit   where CustomerID = @CustomerID", conn)

		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		Dim retVal As Integer

		Dim sqlResult As Object = ExecuteScalar(cmdDepID)

		If (sqlResult IsNot Nothing) Then

			retVal = ExecuteScalar(cmdDepID)
			' Debug.Print(CardID)
		Else


			retVal = 0

		End If

		Return retVal



	End Function

	Public Function addDeposit(customerID, amount)
		Dim res As Customer = Nothing

		Dim cmdDepID As New SqlCommand("Update Deposit set DepositAmount = DepositAmount+ @Amount   where CustomerID = @CustomerID", conn)
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function minusDepositRest(customerID, amount)
		Dim res As Customer = Nothing

		Dim cmdDepID As New SqlCommand("Update Deposit set DepositAmount = DepositAmount- @Amount   where CustomerID = @CustomerID", conn)
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function addDepositSPA(customerID, amount)
		Dim res As Customer = Nothing

		Dim cmdDepID As New SqlCommand("Update DepositSPA set DepositAmount = DepositAmount + @Amount   where CustomerID = @CustomerID", conn)
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function GetCreateDepositSPABonus(customerID As Integer)


		Dim cmdDepID As New SqlCommand("Select DepositAmount from DepositSPABonus   where CustomerID = @CustomerID", conn)

		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		Dim retVal

		Dim sqlResult As Object = ExecuteScalar(cmdDepID)

		If (sqlResult IsNot Nothing) Then

			retVal = ExecuteScalar(cmdDepID)
			' Debug.Print(CardID)
		Else

			retVal = createDepositSPABonus(customerID)
			'  retVal = 0

		End If

		Return retVal



	End Function

	Public Function useDepositSPABonus(customerID, amount)
		Dim res As Customer = Nothing

		Dim cmdDepID As New SqlCommand("Update DepositSPABonus set DepositAmount = DepositAmount- @Amount   where CustomerID = @CustomerID", conn)
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function addDepositSPABonus(customerID, amount)
		Dim res As Customer = Nothing

		Dim cmdDepID As New SqlCommand("Update DepositSPAbonus set DepositAmount = DepositAmount + @Amount   where CustomerID = @CustomerID", conn)
		cmdDepID.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmdDepID.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		ExecuteReader(cmdDepID)
		Return res

	End Function

	Public Function depositHistory(customerID As Integer, amount As Integer, Reason As String) As Customer
		Dim res As Customer = Nothing

		Dim cmd1 As New SqlCommand("Insert into depositHistory(customerID, PaymentDate, DepositSum, cashier) VALUES(@customerID ,@DateChanges,@Amount,@Reason)", conn)

		cmd1.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		cmd1.Parameters.Add(New SqlParameter("@DateChanges", Date.Now))
		cmd1.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount
		cmd1.Parameters.Add(New SqlParameter("@Reason", Reason))
		Try
			ExecuteNonQuery(cmd1)

		Catch ex As SqlException

		End Try
		Return res

	End Function

	Public Function ClipCardUsage(EmployeeID As Integer, custid As Integer, mainId As Integer) As Customer  'into ClipCardUsage
		' Public Function ClipCardUsage(EmployeeID As Integer, custid As Integer, productid As Integer) As Customer  'into ClipCardUsage'
		Dim res As Customer = Nothing
		Dim cmdClipID As New SqlCommand
		cmdClipID = conn.CreateCommand
		cmdClipID.CommandText = "Select max(UsageID)  from AddPrductUsage"
		Dim ClipId As Integer
		Dim sqlResult1 As Object = ExecuteScalar(cmdClipID)
		If IsDBNull(sqlResult1) Then
			ClipId = 1
		Else
			sqlResult1.ToString() 'result found
			ClipId = cmdClipID.ExecuteScalar
			ClipId = ClipId + 1
		End If

		Dim cmdInsertClip As New SqlCommand("ClipCardUsage")   '
		cmdInsertClip = conn.CreateCommand
		cmdInsertClip.Parameters.Add("@ID", SqlDbType.Int).Value = ClipId
		cmdInsertClip.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custid  '
		cmdInsertClip.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeID 'coach
		cmdInsertClip.Parameters.Add("@LocationID", SqlDbType.Int).Value = mainId
		cmdInsertClip.Parameters.Add("@productID", SqlDbType.Int).Value = 0 'productid
		cmdInsertClip.Parameters.Add("@attdate", SqlDbType.SmallDateTime).Value = Date.Now
		cmdInsertClip.Parameters.Add("@Quantity", SqlDbType.Int).Value = 1
		cmdInsertClip.Parameters.Add("@status", SqlDbType.Int).Value = 0
		' cmdInsertClip.CommandText = "Insert into AddPrductUsage VALUES (@ID,@EmployeeId,@CustomerID,@attdate,@Quantity)"
		cmdInsertClip.CommandText = "Insert into AddPrductUsage VALUES (@ID,@EmployeeId,@CustomerID,@LocationID,@productID,@attdate,@Quantity,@status)"
		ExecuteNonQuery(cmdInsertClip)
		MsgBox("Done", MsgBoxStyle.Information, "OK")



		Return res
	End Function

	Public Function CustGuestRepeat(custid As Integer, GuestID As Integer) As Customer  'into customers
		Dim res As Customer = Nothing
		ReadyConnectionF()
		'Dim strID As String = "Select max(ID) from customers"
		'Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
		'Dim GuestID As Integer = ExecuteScalar(cmdMax)
		'++++++

		'+++++++
		Dim ds As New DataSet

		Dim cmdGuestID As New SqlCommand
		cmdGuestID = conn.CreateCommand
		cmdGuestID.CommandText = "select max(ID)  from GuestCheckIn"
		Dim GCheckInId As Integer
		Dim sqlResult1 As Object = cmdGuestID.ExecuteScalar()
		If IsDBNull(sqlResult1) Then
			GCheckInId = 1
		Else
			sqlResult1.ToString() 'result found
			GCheckInId = cmdGuestID.ExecuteScalar
			GCheckInId = GCheckInId + 1
		End If

		Dim cmdInsertGuest As New SqlCommand   'GuestCheckin
		cmdInsertGuest = conn.CreateCommand
		cmdInsertGuest.Parameters.Add("@operden", SqlDbType.SmallDateTime).Value = Date.Now '
		cmdInsertGuest.Parameters.Add("@ID", SqlDbType.Int).Value = GCheckInId
		cmdInsertGuest.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custid  'guest owner id
		cmdInsertGuest.Parameters.Add("@GuestID", SqlDbType.Int).Value = GuestID 'the same guest from guestcust
		cmdInsertGuest.CommandText = "Insert into GuestCheckIn VALUES (@ID ,@GuestID,@CustomerID,@operDen)"
		cmdInsertGuest.ExecuteNonQuery()

		Dim timeStamp As String = Date.Now.ToString("yyyyMMddhhmmss")




		' Profile.ref()
		MsgBox("Done", MsgBoxStyle.Information, "OK")

		' focusCardId(Profile.DataGridView3, "gst" & custid & "gst" & timeStamp)
		Return res
	End Function

	Public Sub DATAGRIDVIEW_TO_EXCEL(grid As DataGridView)
		Try
			Dim dataTable As New DataTable(grid.Name)
			Dim dataTableColumns = dataTable.Columns
			Dim dataTableRows = dataTable.Rows

			For Each gridColumn As DataGridViewColumn In grid.Columns
				dataTableColumns.Add(gridColumn.Name)
			Next

			For Each gridRow As DataGridViewRow In grid.Rows
				Dim gridRowCells = gridRow.Cells

				Dim dataTableRow = dataTable.NewRow()
				For x = 0 To grid.ColumnCount - 1
					Try
						dataTableRow(dataTableColumns(x).ColumnName) = gridRowCells(x).Value
					Catch ex As Exception
						MsgBox(ex.Message)
						Continue For
					End Try
				Next
				dataTableRows.Add(dataTableRow)
			Next

			dataTable.AcceptChanges()

			Dim xmlPath = Path.Combine(Path.GetTempPath(), "LastReport.xml")
			dataTable.WriteXml(xmlPath)
			Process.Start("EXCEL.EXE", """" & xmlPath & """")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
		End Try
	End Sub

	Public Function GetCustomerByUID(uid As String) As Customer
		Dim res As Customer = Nothing

		ReadyConnectionF()
		Dim cmd As New SqlCommand((Convert.ToString("Select ID, UID, FirstName, LastName,CardID,RelaxxGroupId,Status,CardType,Passport From Customers where UID = '") & uid) + " ' ", Connection)
		Dim r = cmd.ExecuteReader()

		If r.HasRows Then
			res = New Customer()
			r.Read()
			res.Id = Convert.ToInt32(r.GetInt32(0).ToString())
			'
			res.Uid = r.GetString(1)
			res.FirstName = r.GetString(2)
			res.LastName = r.GetString(3)
			res.CardID = r.GetString(4)
			Dim grId = r.GetGuid(5)

			res.RelaxxGroupId = grId
			res.Status = r.GetString(6)
			res.CardType = r.GetString(7)
			res.Passport = r.GetString(8)


			' con.Close()
		End If
		'  End Using
		Return res
	End Function

	Public Function GetCustomerByID(id As Integer) As Customer
		Dim res As Customer = Nothing

		ReadyConnectionF()
		Dim cmd As New SqlCommand((Convert.ToString("Select ID, UID, FirstName, LastName,CardID, MobilePhone From Customers where ID = '") & id) + " ' ", conn)
		Dim r = cmd.ExecuteReader()

		If r.HasRows Then
			res = New Customer()
			r.Read()
			res.Id = Convert.ToInt32(r.GetInt32(0).ToString())
			'
			res.Uid = r.GetString(1)
			res.FirstName = r.GetString(2)
			res.LastName = r.GetString(3)
			res.CardID = r.GetString(4)
			res.MobilePhone = r.GetString(5)
			'  Dim grId = r.GetGuid(5)

			'  res.RelaxxGroupId = grId
			' res.Status = r.GetString(6)
			'  res.CardType = r.GetString(7)
			' res.Passport = r.GetString(8)


			' con.Close()
		End If
		'  End Using
		Return res
	End Function

	Public Function updRestStatus(zakazId)
		Dim res As Customer = Nothing

		Dim cmd As New SqlCommand("Update foodcort set Status = 2   where ID = @zakazId", conn)

		cmd.Parameters.Add("@zakazId", SqlDbType.Int).Value = zakazId
		ExecuteReader(cmd)
		Return res

	End Function

	Public Sub DeleteCheckins(customerID As Integer)
		Dim cmdDel As New SqlCommand("Delete   from GatCheckIn   where Customerid = @CustomerID", conn)

		cmdDel.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
		Try
			ExecuteNonQuery(cmdDel)

		Catch ex As SqlException

		End Try
	End Sub

	Public Function GetInter(id As Integer) As Interactions
		Dim res As Interactions = Nothing

		ReadyConnectionF()
		Dim cmd As New SqlCommand((Convert.ToString("Select * From Interactions where ID = '") & id) + " ' ", Connection)
		Dim r = cmd.ExecuteReader()

		If r.HasRows Then
			res = New Interactions()
			r.Read()

			res.Id = Convert.ToInt32(r.GetInt32(0).ToString())

			'res.InfoSource = r.GetString(1)
			' res.FirstContactType = r.GetString(2)
			'res.FirstContactDate = r.GetDateTime(3)
			res.Name = r.GetString(4)
			res.SurName = r.GetString(5)
			res.ContactPhone = r.GetString(6)
			'res.InteractionDate = r.GetDateTime(7)
			'res.InteractionType = r.GetString(8)
			'res.NextInteraction = r.GetString(9)
			'res.NextInteractionDate = r.GetDateTime(10)
			'res.NextInteractionTime = r.GetTimeSpan(11)
			'res.Comment = r.GetString(12)

			'res.CardQuantity = r.GetDecimal(13)

			'res.PlanedAmount = r.GetDecimal(14)
			' con.Close()
		End If
		'  End Using
		Return res
	End Function

	Sub LogFunc(st1 As String, st2 As String)
		'Dim st3 As String = ""
		ReadyConnectionF()
		Dim cmd As New SqlCommand
		Dim localIp As String
		For Each address As Net.IPAddress In Net.Dns.GetHostEntry(Net.Dns.GetHostName).AddressList
			If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
				localIp = address.ToString()
				' Debug.Write(localIp)

				'Dim strIPAddress As String
				'strIPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString
				Dim stComp As String
				stComp = Environment.GetEnvironmentVariable("COMPUTERNAME")


				Dim cb As String = "insert into Logs(UserID,Date,Operation,comp,ip) VALUES (@d1,@d2,@d3,@d4,@d5)"
				cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", st1) 'st1
				cmd.Parameters.AddWithValue("@d2", Date.Now)
				cmd.Parameters.AddWithValue("@d3", st2)
				cmd.Parameters.AddWithValue("@d4", stComp)
				cmd.Parameters.AddWithValue("@d5", localIp)
				cmd.ExecuteReader()
				Exit For
			End If
		Next
	End Sub

	Public Class Customer
		Public Property Id() As Integer
			Get
				Return m_Id
			End Get
			Set(value As Integer)
				m_Id = value
			End Set
		End Property

		Private m_Id As Integer

		Public Property Uid() As String
			Get
				Return m_Uid
			End Get
			Set(value As String)
				m_Uid = value
			End Set
		End Property

		Private m_Uid As String

		Public Property FirstName() As String
			Get
				Return m_FirstName
			End Get
			Set(value As String)
				m_FirstName = value
			End Set
		End Property

		Private m_FirstName As String

		Public Property LastName() As String
			Get
				Return m_LastName
			End Get
			Set(value As String)
				m_LastName = value
			End Set
		End Property

		Private m_LastName As String

		Public Property CardID() As String
			Get
				Return m_CardID
			End Get
			Set(value As String)
				m_CardID = value
			End Set
		End Property

		Private m_CardID As String

		Public Property RelaxxGroupId() As Guid
			Get
				Return m_RelaxxGroupId
			End Get
			Set(value As Guid)
				m_RelaxxGroupId = value
			End Set
		End Property

		Private m_RelaxxGroupId As Guid
		Public Property Status() As String
			Get
				Return m_Status
			End Get
			Set(value As String)
				m_Status = value
			End Set
		End Property

		Private m_Status As String
		Public Property CardType() As String
			Get
				Return m_CardType
			End Get
			Set(value As String)
				m_CardType = value
			End Set
		End Property

		Private m_CardType As String
		Public Property Passport() As String
			Get
				Return m_Passport
			End Get
			Set(value As String)
				m_Passport = value
			End Set
		End Property

		Private m_Passport As String

		Public Property MobilePhone() As String
			Get
				Return m_MobilePhone
			End Get
			Set(value As String)
				m_MobilePhone = value
			End Set
		End Property

		Private m_MobilePhone As String
	End Class
End Module



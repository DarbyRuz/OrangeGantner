Imports System.Data
Imports System.Data.SqlClient
Module Order1
    Public Class Orders
        Public Property OrderId() As Integer
            Get
                Return m_Id
            End Get
            Set(value As Integer)
                m_Id = value
            End Set
        End Property
        Private m_Id As Integer
        Public Property CustomerId() As Integer
            Get
                Return m_CustomerId
            End Get
            Set(value As Integer)
                m_CustomerId = value
            End Set
        End Property
        Private m_CustomerId As Integer
        Public Property OrderDate() As Date
            Get
                Return m_OrderDate
            End Get
            Set(value As Date)
                m_OrderDate = value
            End Set
        End Property
        Private m_OrderDate As Date
        Public Property EndDate() As Date
            Get
                Return m_EndDate
            End Get
            Set(value As Date)
                m_EndDate = value
            End Set
        End Property
        Private m_EndDate As Date
        Public Property DeadLine() As Date
            Get
                Return m_DeadLine
            End Get
            Set(value As Date)
                m_DeadLine = value
            End Set
        End Property
        Private m_DeadLine As Date
        Public Property endByContract() As Date
            Get
                Return m_endByContract
            End Get
            Set(value As Date)
                m_endByContract = value
            End Set
        End Property
        Private m_endByContract As Date
    End Class


    Public Function GetOrderByID(id As Integer) As Orders
        Dim res As Orders = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select OrderID,OrderDate,EndDate,DeadLine  From Orders where CustomerId= '") & id) + " ' ", Connection)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New Orders()
            r.Read()
            res.OrderId = Convert.ToInt32(r.GetInt32(0).ToString())
            '
            res.OrderDate = r.GetDateTime(1)
            res.EndDate = r.GetDateTime(2)
            res.DeadLine = r.GetDateTime(3)



        End If
        '  End Using
        Return res
    End Function
    Public Function GetOrder(Ordid As Integer) As Orders
        Dim res As Orders = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select CustomerID,OrderDate,EndDate,DeadLine  From Orders where OrderID= '") & Ordid) + " ' ", Connection)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New Orders()
            r.Read()
            res.CustomerId = Convert.ToInt32(r.GetInt32(0).ToString())
            '
            res.OrderDate = r.GetDateTime(1)
            res.EndDate = r.GetDateTime(2)
            res.DeadLine = r.GetDateTime(3)

        End If
        '  End Using
        Return res
    End Function
    Public Function GetTotalHdmByID(id As Integer) As UnionTotalPay
        Dim res As UnionTotalPay = Nothing
        ReadyConnectionF() 'cmd1.CommandText = "select * from unionTotal"
        Dim cmd As New SqlCommand((Convert.ToString("select * from unionTotal where CustomerId= '") & id) + " ' ", Connection)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New UnionTotalPay()
            r.Read()
            res.CustomerId = Convert.ToInt32(r.GetInt32(5).ToString())
            res.Total = r.GetValue(4).ToString()
            ' res.Total = Convert.ToInt32(r.GetInt32(4).ToString()) ' r.GetDecimal(5).ToString()
            res.Restoran = r.GetDecimal(2)
            res.SPA = r.GetDecimal(3)

        End If
        Return res
    End Function
    Public Function GetOrderEnd(Ordid As Integer) As Orders
        Dim res As Orders = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select CustomerID,OrderDate,EndDate,EndByContract  From OrdDateLast where OrderID= '") & Ordid) + " ' ", Connection)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New Orders()
            r.Read()
            res.CustomerId = Convert.ToInt32(r.GetInt32(0).ToString())
            '
            res.OrderDate = r.GetDateTime(1)
            res.EndDate = r.GetDateTime(2)
            res.endByContract = r.GetDateTime(3)

        End If
        '  End Using
        Return res
    End Function

    Public Function maxId(TableName As String)
        Dim res As Orders = Nothing
        ReadyConnectionF()
        Dim cmdMaxid As New SqlClient.SqlCommand("MaxIdFromTable", Connection)
        cmdMaxid.CommandType = CommandType.StoredProcedure
        Dim retValParam As New SqlParameter("@RETURN_VALUE", SqlDbType.Int)
        cmdMaxid.Parameters.Add("@TableName", Data.SqlDbType.NVarChar).Value = TableName
        retValParam.Direction = ParameterDirection.ReturnValue
        cmdMaxid.Parameters.Add(retValParam)
        retValParam.Direction = ParameterDirection.ReturnValue
        'Call the sproc...
        Dim reader As SqlDataReader = cmdMaxid.ExecuteReader()
        retValParam.Value = Convert.ToInt32(retValParam.Value)
        Dim orderId As Integer = Convert.ToInt32(retValParam.Value)
        Return orderId

    End Function

    Sub maxOrderId()
        ReadyConnectionF()
        Dim strID As String = "Select max(OrderID) from Orders"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
        Dim orderId As Integer = ExecuteScalar(cmdMax) + 1

        ' Dim Str As Integer = Custid + 1
    End Sub
    Public Function GetActiveOrderByID(id As Integer)
        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select OrderID  From ordActive where CustomerId= '") & id) + " ' ", conn)
        Dim orderId As Integer = cmd.ExecuteScalar()
        Return orderId

    End Function
    Public Function GetOrdId(ByVal ID As Integer)


        Dim command As New SqlCommand
        command.CommandText = "Select count(customerid) From ordActive where OrderId= '" & ID & "'"

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
    Public Function GetActOrder(ID As Integer)
        Dim check1 As Integer
        Dim cmd1 As New SqlCommand
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "Select count(customerid) From ordActive where OrderId= '" & ID & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
            check1 = 0
        Else
            sqlResult1.ToString()
            check1 = ExecuteScalar(cmd1) 'order active


        End If

        Return check1
    End Function
    Public Function depositBalance(ID As Integer)
        Dim check1 As Integer
        Dim cmd1 As New SqlCommand
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select DepositAmount from Deposit  " &
            "where CustomerID = '" & ID & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
            check1 = 0
        Else
            sqlResult1.ToString()
            check1 = cmd1.ExecuteScalar 'deposit sum 


        End If

        Return check1
    End Function
    Public Function depositBalanceSPA(ID As Integer)
        Dim check1 As Integer
        Dim cmd1 As New SqlCommand
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select DepositAmount from DepositSPA  " &
            "where CustomerID = '" & ID & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
            check1 = 0
        Else
            sqlResult1.ToString()
            check1 = cmd1.ExecuteScalar 'deposit sum 


        End If

        Return check1
    End Function

    Public Function GiftOrder(customerId As Integer, OrderDate As DateTime, EndDate As DateTime) As Orders
        Dim res As Orders = Nothing
        ReadyConnectionF()
        '  Dim orderId As Integer = maxId("Orders")
        Dim strID As String = "Select max(OrderID) from Orders"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
        Dim orderId As Integer = ExecuteScalar(cmdMax) + 1
        Dim CMD2 As New SqlClient.SqlCommand("InsertOrders")
        CMD2.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = orderId
        CMD2.Parameters.Add("@OrderName", Data.SqlDbType.NVarChar).Value = "Gift"
        CMD2.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = customerId
        CMD2.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@OrderDate", Data.SqlDbType.DateTime).Value = OrderDate 'DateTime.Now
        CMD2.Parameters.Add("@DeadLine", Data.SqlDbType.DateTime).Value = EndDate 'DateAdd(DateInterval.Month, 1, DateTime.Now)
        CMD2.Parameters.Add("@EndDate", Data.SqlDbType.DateTime).Value = EndDate 'DateAdd(DateInterval.Month, 1, DateTime.Now)
        CMD2.Parameters.Add("@ReorderDate", Data.SqlDbType.DateTime).Value = DateTime.Now
        CMD2.Parameters.Add("@Surcharge", Data.SqlDbType.NChar).Value = 0
        CMD2.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@FreezingDays", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@FreezingLimit", Data.SqlDbType.Int).Value = 0

        CMD2.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = "gift days" & DateDiff(DateInterval.Day, EndDate, OrderDate)
        CMD2.Parameters.Add("@duration", Data.SqlDbType.Int).Value = 0
        ExecuteProcedur.ExecuteCMD(CMD2)
        GiftOrderDetails(orderId, durdays:=DateDiff(DateInterval.Day, OrderDate, EndDate))
        Return res
    End Function
    Public Function GiftOrderDetails(orderId As Integer, durdays As Integer) As Orders
        Dim res As Orders = Nothing
        ReadyConnectionF()
        Dim strID As String = "Select max(ID) from OrderDetails"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
        Dim Id As Integer = ExecuteScalar(cmdMax) + 1

        Dim CMD1 As New SqlClient.SqlCommand("InsertOrdersDetails1")


        CMD1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = Id
        CMD1.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = orderId
        CMD1.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = 12
        CMD1.Parameters.Add("@StartDate", Data.SqlDbType.DateTime).Value = Now()

        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = 0


        CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = 1


        CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = 0 'fitness quantity 1 unit price =amount

        CMD1.Parameters.Add("@Discount", Data.SqlDbType.Float).Value = 0
        CMD1.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
        CMD1.Parameters.Add("@PaymentDate", Data.SqlDbType.DateTime).Value = Now()
        CMD1.Parameters.Add("@PaymentSystem", Data.SqlDbType.NChar).Value = "Gift"

        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = 1
        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0


        CMD1.Parameters.Add("@WeeklyAttendance", Data.SqlDbType.SmallInt).Value = 100
        CMD1.Parameters.Add("@DurDays", Data.SqlDbType.SmallInt).Value = durdays
        ExecuteProcedur.ExecuteCMD(CMD1)
        Return res
    End Function
    Public Function GuestOrder(customerId As Integer, OrderDate As DateTime, EndDate As DateTime) As Orders
        Dim res As Orders = Nothing
        ReadyConnectionF()
        '  Dim orderId As Integer = maxId("Orders")
        Dim strID As String = "Select max(OrderID) from Orders"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
        Dim orderId As Integer = ExecuteScalar(cmdMax) + 1
        Dim CMD2 As New SqlClient.SqlCommand("InsertOrders")
        CMD2.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = orderId
        CMD2.Parameters.Add("@OrderName", Data.SqlDbType.NVarChar).Value = "Guest"
        CMD2.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = customerId
        CMD2.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@OrderDate", Data.SqlDbType.DateTime).Value = OrderDate 'DateTime.Now
        CMD2.Parameters.Add("@DeadLine", Data.SqlDbType.DateTime).Value = EndDate 'DateAdd(DateInterval.Month, 1, DateTime.Now)
        CMD2.Parameters.Add("@EndDate", Data.SqlDbType.DateTime).Value = EndDate 'DateAdd(DateInterval.Month, 36, DateTime.Now)
        CMD2.Parameters.Add("@ReorderDate", Data.SqlDbType.DateTime).Value = DateTime.Now
        CMD2.Parameters.Add("@Surcharge", Data.SqlDbType.NChar).Value = 0
        CMD2.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@FreezingDays", Data.SqlDbType.Int).Value = 0
        CMD2.Parameters.Add("@FreezingLimit", Data.SqlDbType.Int).Value = 0

        CMD2.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = "guest days" & DateDiff(DateInterval.Day, EndDate, OrderDate)
        CMD2.Parameters.Add("@duration", Data.SqlDbType.Int).Value = 0
        ExecuteProcedur.ExecuteCMD(CMD2)
        GuestOrderDetails(orderId, durdays:=DateDiff(DateInterval.Day, OrderDate, EndDate))
        Return res
    End Function
    Public Function GuestOrderDetails(orderId As Integer, durdays As Integer) As Orders
        Dim res As Orders = Nothing
        ReadyConnectionF()
        Dim strID As String = "Select max(ID) from OrderDetails"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, Connection)
        Dim Id As Integer = ExecuteScalar(cmdMax) + 1

        Dim CMD1 As New SqlClient.SqlCommand("InsertOrdersDetails1")


        CMD1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = Id
        CMD1.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = orderId
        CMD1.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = 10
        CMD1.Parameters.Add("@StartDate", Data.SqlDbType.DateTime).Value = Now()

        CMD1.Parameters.Add("@Duration", Data.SqlDbType.SmallInt).Value = 36


        CMD1.Parameters.Add("@Quantity", Data.SqlDbType.Decimal).Value = 1


        CMD1.Parameters.Add("@UnitPrice", Data.SqlDbType.Decimal).Value = 0 'fitness quantity 1 unit price =amount

        CMD1.Parameters.Add("@Discount", Data.SqlDbType.Float).Value = 0
        CMD1.Parameters.Add("@StatusID", Data.SqlDbType.Int).Value = 0
        CMD1.Parameters.Add("@PaymentDate", Data.SqlDbType.DateTime).Value = Now()
        CMD1.Parameters.Add("@PaymentSystem", Data.SqlDbType.NChar).Value = "Guest"

        CMD1.Parameters.Add("@Slote", Data.SqlDbType.Int).Value = 1
        CMD1.Parameters.Add("@Surcharge", Data.SqlDbType.Int).Value = 0


        CMD1.Parameters.Add("@WeeklyAttendance", Data.SqlDbType.SmallInt).Value = 100
        CMD1.Parameters.Add("@DurDays", Data.SqlDbType.SmallInt).Value = durdays
        ExecuteProcedur.ExecuteCMD(CMD1)
        Return res
    End Function

    Public Sub deleteOrder(orderId As Integer)
        ' Dim res As Orders = Nothing
        ReadyConnectionF()

        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet


        cmd = conn.CreateCommand
        cmd.CommandText = "DELETE FROM [OrderDetails] WHERE OrderId ='" & orderId & " ' "

        ExecuteReader(cmd)

        cmd1 = conn.CreateCommand
        cmd1.CommandText = "DELETE FROM [Purchase Orders] WHERE OrderId ='" & orderId & " ' "

        ExecuteReader(cmd1)

        cmd2 = conn.CreateCommand
        cmd2.CommandText = "DELETE FROM [Orders] WHERE OrderId ='" & orderId & " ' "
        ExecuteReader(cmd2)





    End Sub



End Module

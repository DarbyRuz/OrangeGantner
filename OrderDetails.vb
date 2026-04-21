
Imports System.Data
    Imports System.Data.SqlClient
Module OrderDet
    Public Class OrderDetails
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

    End Class


    'Public Function GetOrderID(custid As Integer) As OrderDetails
    '    Dim res As OrderDetails = Nothing

    '    ReadyConnectionF()
    '    '   Dim cmd As New SqlCommand((Convert.ToString("Select OrderID,OrderDate,EndDate   From OrdersFullLast where OrderId= '") & Orderid) + " ' ", conn)
    '    Dim cmd As New SqlCommand((Convert.ToString("select orderid from FreezBalance where CustomerID = '") & custid) + " ' ", conn)


    '    Dim r = cmd.ExecuteScalar()

    '    If r.HasRows Then
    '        res = New OrderDetails()
    '        r.Read()

    '        res.OrderId = Convert.ToInt32(r.GetInt32(0).ToString())
    '        'res.OrderDate = r.Item("OrderId").ToString
    '        ' res.OrderDate = r.GetDateTime(1)
    '        'res.EndDate = r.GetDateTime(2)




    '    End If
    '    ' Debug.Write(res.OrderId & "/" & res.OrderDate & "/" & res.EndDate)
    '    '  End Using
    '    Return res
    'End Function

    Public Function GetOrderID(cid As Integer) As Object


        Dim command As New SqlCommand
        '  command.CommandText = "Select Cardid From customers where cardid = '" & CardID & " ' "
        command.CommandText = "select orderid from FreezBalance where CustomerID =  '" & cid & " ' "
        Dim retVal As Boolean = False

        Dim sqlResult As Object = ExecuteScalar(command)

        If (sqlResult IsNot Nothing) Then

            retVal = True
            ' Debug.Print(CardID)
        Else

            ' MsgBox("Item Not Found", MsgBoxStyle.Exclamation, "Warning")
            retVal = False

        End If

        Return retVal

    End Function
    Public Function GetGuestOrder(ordid As Integer) As Object


        Dim command As New SqlCommand
        '  command.CommandText = "Select Cardid From customers where cardid = '" & CardID & " ' "
        command.CommandText = "select orderid from guestlimit where orderID =  '" & ordid & " ' "
        Dim retVal As Boolean = False

        Dim sqlResult As Object = ExecuteScalar(command)

        If (sqlResult IsNot Nothing) Then

            retVal = True
            ' Debug.Print(CardID)
        Else

            ' MsgBox("Item Not Found", MsgBoxStyle.Exclamation, "Warning")
            retVal = False

        End If

        Return retVal

    End Function
    Public Function GetOrders(Customerid As Integer) As OrderDetails
        Dim res As OrderDetails = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select OrderID,OrderDate,EndDate, Customerid , LEAD(OrderDate, 1, '01-Jan-2100') OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderDate,LEAD(OrderId, 1, 0) OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderId,prid   From OrdersFullLast where prid <> 12 and CustomerID= '") & Customerid) + " ' ", conn)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New OrderDetails()
            Do While r.Read()

                res.OrderId = Convert.ToInt32(r.GetInt32(0).ToString())
                'res.OrderDate = r.Item("OrderId").ToString
                ' res.OrderDate = r.GetDateTime(r.GetOrdinal("OrderDate"))
                res.OrderDate = r.GetDateTime(1)
                res.EndDate = r.GetDateTime(2)
                res.CustomerId = Convert.ToInt32(r.GetInt32(3).ToString())

                Dim NextStart = r.GetDateTime(4)
                Dim NextId = Convert.ToInt32(r.GetInt32(5).ToString())
                Dim daysDiff = DateDiff(DateInterval.Day, res.EndDate, NextStart)
                Dim startDate = DateAdd(DateInterval.Day, 1, res.EndDate)
                '  Debug.WriteLine(res.OrderId & "/" & res.OrderDate & "/" & res.EndDate & "/" & NextStart & "/" & NextId & "/" & daysDiff)
                If NextId > 0 And daysDiff <= 0 And NextId <> res.OrderId And NextStart > res.OrderDate Then
                    ' Debug.WriteLine(res.OrderId & "/" & res.OrderDate & "/" & res.EndDate & "/" & NextStart & "/" & NextId & "/" & daysDiff)

                    Dim cmdDatabase As New SqlClient.SqlCommand

                    cmdDatabase = conn.CreateCommand
                    cmdDatabase.CommandText = "Update Orders set OrderDate=Convert(date, '" & startDate & " ', 103) where Orderid = '" & NextId & "' "
                    ExecuteNonQuery(cmdDatabase)
                    MsgBox("Done", MsgBoxStyle.Information, "OK")
                End If
            Loop

        Else
            'Console.WriteLine("No rows found.")

        End If


        Return res
        r.Close()
    End Function
    Public Function GetAllOrders() As OrderDetails
        Dim res As OrderDetails = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select OrderID,OrderDate,EndDate, Customerid , LEAD(OrderDate, 1, '01-Jan-2100') OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderDate,LEAD(OrderId, 1, 0) OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderId   From OrdersFullLast")), Connection)
        ' Dim cmd As New SqlCommand
        ' cmd.CommandText = ("Select OrderID,OrderDate,EndDate, Customerid , LEAD(OrderDate, 1, '01-Jan-2100') OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderDate,LEAD(OrderId, 1, 0) OVER(Partition BY   CustomerId ORDER BY OrderDate) As NextOrderId   From OrdersFullLast",Connection)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New OrderDetails()
            Do While r.Read()

                res.OrderId = Convert.ToInt32(r.GetInt32(0).ToString())
                'res.OrderDate = r.Item("OrderId").ToString
                ' res.OrderDate = r.GetDateTime(r.GetOrdinal("OrderDate"))
                res.OrderDate = r.GetDateTime(1)
                res.EndDate = r.GetDateTime(2)
                res.CustomerId = Convert.ToInt32(r.GetInt32(3).ToString())
                Dim NextStart = r.GetDateTime(4)
                Dim NextId = Convert.ToInt32(r.GetInt32(5).ToString())
                Dim daysDiff = DateDiff(DateInterval.Day, res.EndDate, NextStart)
                Dim startDate = DateAdd(DateInterval.Day, 1, res.EndDate)
                If NextId > 0 And daysDiff <= 0 And NextId <> res.OrderId And NextStart > DateTime.Now Then
                    '  Debug.WriteLine(res.OrderId & "/" & res.OrderDate & "/" & res.EndDate & "/" & NextStart & "/" & NextId & "/" & daysDiff)
                    'If Not r.NextResult() Then
                    '    Console.WriteLine("No rows found.")
                    Dim cmdDatabase As New SqlClient.SqlCommand

                    cmdDatabase = conn.CreateCommand
                    cmdDatabase.CommandText = "Update Orders set OrderDate=Convert(date, '" & startDate & " ', 103) where Orderid = '" & NextId & "' "
                    ExecuteNonQuery(cmdDatabase)
                    MsgBox("Done", MsgBoxStyle.Information, "OK")
                End If
            Loop

        Else
            Console.WriteLine("No rows found.")

        End If


        Return res
        r.Close()
    End Function
End Module

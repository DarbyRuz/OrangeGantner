Imports System.Data
Imports System.Data.SqlClient

Module Connect
    Public conn As SqlConnection
    Public connRelaxx As SqlConnection
    Public Function BuildSqlNativeConnStr(ByVal server As String, ByVal database As String)
        Return String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", server, database)
    End Function
    Public Function GetConnect()
        conn = New SqlConnection(BuildSqlNativeConnStr(server, database))
        Return conn
    End Function
    Public ReadOnly Property Connection() As SqlConnection
        Get
            Return conn
        End Get
    End Property


    Public Sub ReadyConnection()
        conn = New SqlConnection()
        connRelaxx = New SqlConnection()
        '  conn.ConnectionString = "Data Source={0};Initial Catalog={1};Integrated Security=True;"
        '"Data Source=Server;" + "Initial Catalog=DataBase;" + "Integrated Security=SSPI;"
        ' conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        conn = New SqlConnection(BuildSqlNativeConnStr(server, database))
        connRelaxx = New SqlConnection(BuildSqlNativeConnStr(server, database1))
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        If connRelaxx.State <> ConnectionState.Open Then
            connRelaxx.Open()
        End If
    End Sub

    Public Function ExecuteNonQuery(ByVal command As SqlCommand) As Integer
        Try
            ReadyConnection()
            command.Connection = conn
            Dim result As Integer = command.ExecuteNonQuery()
            Return result
        Catch ex As Exception
            Throw ex
        Finally

            command.Dispose()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Dispose()
        End Try
    End Function
    Public Function ExecuteNonQueryGat(ByVal command As SqlCommand) As Integer
        Try
            ReadyConnection()
            command.Connection = connRelaxx
            Dim result As Integer = command.ExecuteNonQuery()
            Return result
        Catch ex As Exception
            Throw ex
        Finally

            command.Dispose()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Dispose()
        End Try
    End Function
    Public Function ExecuteReader(ByVal command As SqlCommand) As SqlDataReader
        Try
            ReadyConnection()
            command.Connection = conn
            Dim result As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Return result
        Catch Ex As Exception

            Throw Ex
        End Try
    End Function
    Public Function ExecuteReaderGatRelaxx(ByVal command As SqlCommand) As SqlDataReader
        Try
            ReadyConnection()
            command.Connection = connRelaxx
            Dim result As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Return result
        Catch Ex As Exception

            Throw Ex
        End Try
    End Function
    Public Function ExecuteScalar(ByVal command As SqlCommand) As Object
        Try
            ReadyConnection()

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
    Public Function ExecuteScalarRelaxx(ByVal command As SqlCommand) As Object
        Try
            ReadyConnection()

            command.Connection = connRelaxx

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
    Public Sub ClearPool()
        SqlConnection.ClearAllPools()
    End Sub

    Public Function GatCardId(ByVal CardID As String) As Object


        Dim command As New SqlCommand
        command.CommandText = "Select Cardid From customers where cardid = '" & CardID & " ' "

        Dim retVal As Boolean = False

        Dim sqlResult As Object = ExecuteScalar(command)

        If (sqlResult IsNot Nothing) Then

            retVal = True
            Debug.Print(CardID)
        Else

            MsgBox("Item Not Found", MsgBoxStyle.Exclamation, "Warning")
            retVal = False

        End If

        Return retVal

    End Function

    Public Function StatusCardId(ByVal StCardID As String) As Object

        Dim command As New SqlCommand

        Dim sqlResult As New Object


        'Dim UID As String = AccessCardReader.UniqueId
        Dim retVal As String = Nothing
        command.CommandText = "select * from orddateSQL where CustomerID = '" & StCardID & " ' "
        sqlResult = ExecuteScalar(command)
        If (sqlResult Is Nothing) Then
            '   MsgBox("No Contract", MsgBoxStyle.Exclamation, "Warning")
          
            retVal = "No Contract"
            Return retVal
        Else

            command.CommandText = "select * from orddateSQL where CustomerID = '" & StCardID & " ' " & _
  "and late>=0 and dd<=0 order by orderdate"
            sqlResult = ExecuteScalar(command)
            If (sqlResult IsNot Nothing) Then
                retVal = "Late Activation"
                Return retVal
            Else

                command.CommandText = "select * from orddateSQL where CustomerID = '" & StCardID & " ' " & _
        "and Statusid=1 and  ddReorder>=0  order by orderdate"
                sqlResult = ExecuteScalar(command)
                If (sqlResult IsNot Nothing) Then
                    retVal = "Stoped"
                    Return retVal
                Else
                    command.CommandText = "select * from freezSql where CustomerID = '" & StCardID & " '" & _
                                        "and ddStart >=0  and ddEnd <= 0"

                    sqlResult = ExecuteScalar(command)
                    If (sqlResult IsNot Nothing) Then
                        retVal = "SUSPENDED"
                        Return retVal
                    Else


                        command.CommandText = "select * from Plandebt1 where CustomerID = '" & StCardID & " ' "
                        sqlResult = ExecuteScalar(command)
                        If (sqlResult IsNot Nothing) Then
                            retVal = "BLOCKED"
                            Return retVal
                        Else

                            retVal = "ACTIVE"
                            Return retVal

                        End If

                    End If

                End If

            End If
        End If


        ' Return retVal
    End Function
    Public Function CheckOUT(id As Integer) As Customer
        Dim res As Customer = Nothing
    

        Dim cmd As New SqlCommand("Insert into GatCheckIn(CustomerID, DateCheckIn,InOut) VALUES(@CustomerID ,@DateCheckIn,@InOut)", conn)

        cmd.Parameters.Add(New SqlParameter("@CustomerID", id))

        cmd.Parameters.Add(New SqlParameter("@DateCheckIn", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@InOut", "OUT"))
        Try
            cmd.ExecuteNonQuery()
            MsgBox("CheckOut successful")
           

        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        End Try
        Return res

    End Function
    Public Function CheckInn(id As Integer) As Customer
        Dim res As Customer = Nothing


        Dim cmd As New SqlCommand("Insert into GatCheckIn(CustomerID, DateCheckIn,InOut) VALUES(@CustomerID ,@DateCheckIn,@InOut)", conn)

        cmd.Parameters.Add(New SqlParameter("@CustomerID", id))

        cmd.Parameters.Add(New SqlParameter("@DateCheckIn", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@InOut", "IN"))
        Try
            cmd.ExecuteNonQuery()
            MsgBox("CheckIN successful")


        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        End Try
        Return res

    End Function
End Module



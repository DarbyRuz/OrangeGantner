Imports System.Data.SqlClient
Module Clip
    Public Class Clip
        Public Property CustomerId() As Integer
            Get
                Return m_CustomerId
            End Get
            Set(value As Integer)
                m_CustomerId = value
            End Set
        End Property
        Private m_CustomerId As Integer
        Public Property EmployeeId() As Integer
            Get
                Return m_EmployeeId
            End Get
            Set(value As Integer)
                m_EmployeeId = value
            End Set
        End Property
        Private m_EmployeeId As Integer
        Public Property clId() As Integer
            Get
                Return m_clId
            End Get
            Set(value As Integer)
                m_clId = value
            End Set
        End Property
        Private m_clId As Integer
        Public Property EndDate() As Date
            Get
                Return m_EndDate
            End Get
            Set(value As Date)
                m_EndDate = value
            End Set
        End Property
        Private m_EndDate As Date
        Public Property duration() As Integer
            Get
                Return m_duration
            End Get
            Set(value As Integer)
                m_duration = value
            End Set
        End Property
        Private m_duration As Integer

        Public Property valid() As Integer
            Get
                Return m_valid
            End Get
            Set(value As Integer)
                m_valid = value
            End Set
        End Property
        Private m_valid As Integer
        Public Property dt() As Date
            Get
                Return m_dt
            End Get
            Set(value As Date)
                m_dt = value
            End Set
        End Property
        Private m_dt As Date
    End Class

    Public Function GetClipUsageCount(custid As Integer, empid As Integer) As Boolean
        Dim res As Clip = Nothing
        Dim dt As DateTime = Date.Now()
        ReadyConnectionF()
        '   Dim cmd As New SqlCommand("Select  count(customerid) As Usage from addprductusage where customerid=@custid And EmployeeID=@empid and CONVERT( nchar(8), AttDate, 112 )= CONVERT( nchar(8), GetDate(), 112 ) group by EmployeeID")
        Dim cmd As New SqlCommand((Convert.ToString("Select count(customerid) From addprductusage where  EmployeeID= '" & empid & "' and  CONVERT(Date, AttDate , 103)= CONVERT( Date, ' " & dt & " ', 103 ) and CustomerId= '") & custid) + " ' ", conn)

        Dim result = ExecuteScalar(cmd)
        If result > 0 Then

            res = New Clip()
            MsgBox("Double usage today!")
            Return True
        Else
            Return False
        End If
        ' Return True

    End Function
    Public Function GetClipFeezAdd(cstid As Integer, dfreez As Integer) As Clip
        Dim res As Clip = Nothing
        Dim dt As DateTime = Date.Now()
        ReadyConnectionF()

        '   Dim cmd As New SqlCommand '((Convert.ToString("Select Customerid,EndDate,duration,valid  From Clipfrm where Customerid='" & Customerid & "'  and EndDate > ='" & dt & " '", conn)
        Dim cmd As New SqlCommand((Convert.ToString("Select Customerid,clid,EndDate,duration,valid,dt  From Clipfrm where EndDate>=dt and CustomerId= '") & cstid) + " ' ", conn)
        '  Dim cmd As New SqlCommand(sql, conn)
        Dim r = cmd.ExecuteReader()
        If r.HasRows Then
            res = New Clip()
            Do While r.Read()
                ' r.Read()
                res.CustomerId = Convert.ToInt32(r.GetInt32(0).ToString())
                res.clId = Convert.ToInt32(r.GetInt32(1).ToString())
                res.EndDate = r.GetDateTime(2)
                res.duration = Convert.ToInt32(r.GetInt32(3).ToString())
                res.valid = Convert.ToInt32(r.GetInt32(4).ToString())
                res.dt = r.GetDateTime(5)

                Dim clipid = Convert.ToInt32(r.GetInt32(1).ToString())
                If res.EndDate >= res.dt Then
                    Dim cmdDatabase As New SqlClient.SqlCommand
                    cmdDatabase.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = res.CustomerId
                    cmdDatabase.Parameters.Add("@clid", Data.SqlDbType.Int).Value = clipid
                    cmdDatabase.Parameters.Add("@dur", Data.SqlDbType.Int).Value = res.duration
                    '  cmdDatabase.Parameters.Add("@endDt", Data.SqlDbType.DateTime2).Value = res.EndDate
                    cmdDatabase = conn.CreateCommand
                    cmdDatabase.CommandText = "update ClipNew set duration=duration + '" & dfreez & " '+1  where CustomerID='" & cstid & " ' and clid= '" & clipid & " ' "
                    ExecuteNonQuery(cmdDatabase)
                    '  MsgBox("Done", MsgBoxStyle.Information, "OK")
                End If
            Loop
        End If


        Return res
        r.Close()
    End Function
    Public Function GetClipFeezDel(cstid As Integer, dfreez As Integer) As Clip
        Dim res As Clip = Nothing
        Dim dt As DateTime = Date.Now()
        ReadyConnectionF()

        '   Dim cmd As New SqlCommand '((Convert.ToString("Select Customerid,EndDate,duration,valid  From Clipfrm where Customerid='" & Customerid & "'  and EndDate > ='" & dt & " '", conn)
        Dim cmd As New SqlCommand((Convert.ToString("Select Customerid,clid,EndDate,duration,valid,dt  From Clipfrm where EndDate>=dt and CustomerId= '") & cstid) + " ' ", conn)
        '  Dim cmd As New SqlCommand(sql, conn)
        Dim r = cmd.ExecuteReader()
        If r.HasRows Then
            res = New Clip()
            Do While r.Read()
                ' r.Read()
                res.CustomerId = Convert.ToInt32(r.GetInt32(0).ToString())
                res.clId = Convert.ToInt32(r.GetInt32(1).ToString())
                res.EndDate = r.GetDateTime(2)
                res.duration = Convert.ToInt32(r.GetInt32(3).ToString())
                res.valid = Convert.ToInt32(r.GetInt32(4).ToString())
                res.dt = r.GetDateTime(5)
                Dim cmdDatabase As New SqlClient.SqlCommand
                Dim clipid = Convert.ToInt32(r.GetInt32(1).ToString())
                Dim dur = Convert.ToInt32(r.GetInt32(3).ToString())
                If res.EndDate >= res.dt Then
                    If res.duration - dfreez - 1 >= res.valid Then
                        cmdDatabase.Parameters.Add("@dur", Data.SqlDbType.Int).Value = res.duration - dfreez - 1 ' res.duration
                        dur = res.duration - dfreez - 1
                    Else
                        cmdDatabase.Parameters.Add("@dur", Data.SqlDbType.Int).Value = res.valid
                        dur = res.valid
                    End If

                    cmdDatabase.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = res.CustomerId
                    cmdDatabase.Parameters.Add("@clid", Data.SqlDbType.Int).Value = clipid

                    '  cmdDatabase.Parameters.Add("@endDt", Data.SqlDbType.DateTime2).Value = res.EndDate
                    cmdDatabase = conn.CreateCommand
                    'cmdDatabase.CommandText = "update ClipNew set duration =duration - '" & dfreez & " '  where CustomerID='" & cstid & " ' and clid= '" & clipid & " ' "
                    cmdDatabase.CommandText = "update ClipNew set duration = '" & dur & " '   where CustomerID='" & cstid & " ' and clid= '" & clipid & " ' "
                    ExecuteNonQuery(cmdDatabase)
                    'MsgBox("Clip updated!", MsgBoxStyle.Information, "OK")
                End If
            Loop
        End If


        Return res
        r.Close()
    End Function
End Module


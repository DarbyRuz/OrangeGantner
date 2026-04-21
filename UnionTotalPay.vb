Imports System.Data.SqlClient
Public Class UnionTotalPay

    Public Property CustomerId() As Integer
        Get
            Return m_CustomerId
        End Get
        Set(value As Integer)
            m_CustomerId = value
        End Set
    End Property
    Private m_CustomerId As Integer
    Public Property Total() As Integer
        Get
            Return m_Total
        End Get
        Set(value As Integer)
            m_Total = value
        End Set
    End Property
    Private m_Total As Integer
    Public Property Restoran() As Decimal
        Get
            Return m_Restoran
        End Get
        Set(value As Decimal)
            m_Restoran = value
        End Set
    End Property
    Private m_Restoran As Decimal
    Public Property SPA() As Decimal
        Get
            Return m_SPA
        End Get
        Set(value As Decimal)
            m_SPA = value
        End Set
    End Property
    Private m_SPA As Decimal
    Public Function GetTotalHdmByID(id As Integer) As UnionTotalPay
        Dim res As UnionTotalPay = Nothing
        ReadyConnectionF() 'cmd1.CommandText = "select * from unionTotal"
        Dim cmd As New SqlCommand((Convert.ToString("select * from unionTotal where CustomerId= '") & id) + " ' ", conn)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New UnionTotalPay()
            r.Read()
            res.CustomerId = Convert.ToInt32(r.GetInt32(5).ToString())
            res.Total = r.GetString(4)
            ' res.Total = Convert.ToInt32(r.GetInt32(4).ToString()) ' r.GetDecimal(5).ToString()
            res.Restoran = r.GetString(2)
            res.SPA = r.GetString(3)

        End If
        Return res
    End Function
End Class


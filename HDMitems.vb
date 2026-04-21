Imports System.Data.SqlClient
Public Class HDMitems
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property
    Private m_Id As Integer
    Public Property ProductCode() As String
        Get
            Return m_ProductCode
        End Get
        Set(value As String)
            m_ProductCode = value
        End Set
    End Property
    Private m_ProductCode As String
    Public Property ProductName() As String
        Get
            Return m_ProductName
        End Get
        Set(value As String)
            m_ProductName = value
        End Set
    End Property
    Private m_ProductName As String
    Public Property ADG() As String
        Get
            Return m_ADG
        End Get
        Set(value As String)
            m_ADG = value
        End Set
    End Property
    Private m_ADG As String
    Public Property UnitType() As String
        Get
            Return m_UnitType
        End Get
        Set(value As String)
            m_UnitType = value
        End Set
    End Property
    Private m_UnitType As String
    Public Property NDS() As String
        Get
            Return m_NDS
        End Get
        Set(value As String)
            m_NDS = value
        End Set
    End Property
    Private m_NDS As String
    Public Property dep() As Integer
        Get
            Return m_dep
        End Get
        Set(value As Integer)
            m_dep = value
        End Set
    End Property
    Private m_dep As Integer
    Public Property Category1() As String
        Get
            Return m_Category1
        End Get
        Set(value As String)
            m_Category1 = value
        End Set
    End Property
    Private m_Category1 As String
   
End Class
Public Class HDMSettings
    Public Property hdmId() As Integer
        Get
            Return m_hdmId
        End Get
        Set(value As Integer)
            m_hdmId = value
        End Set
    End Property
    Private m_hdmId As Integer
    Public Property hdmIP() As String
        Get
            Return m_hdmIP
        End Get
        Set(value As String)
            m_hdmIP = value
        End Set
    End Property
    Private m_hdmIP As String
    Public Property hdmPort() As Integer
        Get
            Return m_hdmPort
        End Get
        Set(value As Integer)
            m_hdmPort = value
        End Set
    End Property
    Private m_hdmPort As Integer
    Public Property hdmPassword() As String
        Get
            Return m_hdmPassword
        End Get
        Set(value As String)
            m_hdmPassword = value
        End Set
    End Property
    Private m_hdmPassword As String

    Public Property hdmOperatorId() As Integer
        Get
            Return m_hdmOperatorId
        End Get
        Set(value As Integer)
            m_hdmOperatorId = value
        End Set
    End Property
    Private m_hdmOperatorId As Integer

    Public Property hdmOperatorPass() As String
        Get
            Return m_hdmOperatorPass
        End Get
        Set(value As String)
            m_hdmOperatorPass = value
        End Set
    End Property
    Private m_hdmOperatorPass As String
   

End Class
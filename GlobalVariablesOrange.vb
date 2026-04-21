Imports System.Data.SqlClient
Imports System.Configuration
'Imports System.Collections.SpecializedD
Public Module Globals
    '  Public server As String = ConfigurationSettings.AppSettings("server")
    ' Public database As String = ConfigurationSettings.AppSettings("database")
    '  Public imagePath As String = ConfigurationSettings.AppSettings("imagePath")
    '  Public server As String = "RUZ\SQLEXPRESS"
    Public conn As SqlConnection
    Public connRelaxx As SqlConnection

    Public server1 As String = "SHBO5747\SQLEXPRESS"
    Public server As String = "SHBO5747"
   
    Public Const connectionString As String = "Data Source = SHBO5747;Initial Catalog=FITNESS;User Id=Ruz;Password=Qwer1234;"
    Public Const connectionStringRelaxx As String = "Data Source =SHBO5747\SQLEXPRESS;Initial Catalog=GATRelaxx;User Id=RelaxxDB;Password=qwer1234;"
    Public database As String = "FITNESS"
    Public database1 As String = "GATRelaxx"
    Public username1 As String = "RelaxxDB"
    Public username As String = "Ruz"
    Public password1 As String = "qwer1234"
    Public password As String = "Qwer1234"
    Public imagePath As String = "\\SHBO5747\Income\ImageBasa\"


End Module

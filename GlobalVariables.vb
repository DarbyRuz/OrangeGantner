Imports System.Data.SqlClient

Public Module Globals
	Public conn As SqlConnection

	'Public Const connectionString As String = "Server=localhost\SQLEXPRESS;Database=FITNESS;Trusted_Connection=True;User Id=Ruz;Password=Qwer1234;"
	Public Const connectionString As String = "Data Source = SHBO5747;Initial Catalog=FITNESS;User Id=Ruz;Password=Qwer1234;"

	Public database As String = "FITNESS"
	Public password As String = "qwer1234"
	Public imagePath As String = "\\SHBO5747\Income\ImageBasa\"

	'Public imagePath As String = "C:\Users\Ruz\Documents\Image\"
End Module

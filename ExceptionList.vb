Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class ExceptionList
	Private ReadOnly Worker As New AsyncWorker()
	Private Id As Long

	Private Async Sub ExceptionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Id = CLng(lblCustomerId.Text)
		If (Not Await CheckCustomerById(Id)) Then
			MsgBox($"Selected user at identifier '{Id}' not found", MsgBoxStyle.Exclamation, "Warning")
			Close()
		End If

		Try
			Dim comment As String = Await GetExceptionForCustomer(Id)
			CommentSection.Text = comment
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
		End Try
	End Sub

	Private Async Sub AddOrSave_Click(sender As Object, e As EventArgs) Handles AddOrSave.Click
		Try
			Dim comment As String = CommentSection.Text
			Await SetExceptionForCustomer(Id, comment)
			MsgBox("Done", MsgBoxStyle.Information, "Message")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
		End Try
	End Sub

	Private Shadows Async Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
		Try
			Await RemoveExceptionForCustomer(Id)
			Dim comment As String = Await GetExceptionForCustomer(Id)
			CommentSection.Text = comment
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning")
		End Try
	End Sub

	Private Async Function CheckCustomerById(id As Integer) As Task(Of Boolean)
		Using connection = GetSqlConnection()
			Dim commandCheckCustomerById As New SqlCommand($"SELECT ID FROM Customers WHERE ID = {id}", connection)
			Return Await Worker.RunWork(
				Function()
					Return (commandCheckCustomerById.ExecuteScalar() IsNot Nothing)
				End Function)
		End Using
	End Function

	Private Async Function SetExceptionForCustomer(id As Long, comment As String) As Task
		If (String.IsNullOrEmpty(comment)) Then Throw New Exception("Cant set exception with empty comment")

		Using connection = GetSqlConnection()
			Dim commandSetException As New SqlCommand($"
			IF EXISTS (SELECT 1 FROM CustomerFingerPrintExceptionList WHERE CustomerId = @id)
			BEGIN
				UPDATE CustomerFingerPrintExceptionList 
				SET Comment = @comment, AddedDate = @date 
				WHERE CustomerId = @id
			END
			ELSE
			BEGIN
				INSERT INTO CustomerFingerPrintExceptionList (CustomerId, Comment, AddedDate) 
				VALUES (@id, @comment, @date)
			END", connection)

			commandSetException.Parameters.AddWithValue("@id", id)
			commandSetException.Parameters.AddWithValue("@comment", comment)
			commandSetException.Parameters.AddWithValue("@date", Date.Now)

			Await Worker.RunWork(
				Sub()
					commandSetException.ExecuteNonQuery()
				End Sub)
		End Using

		Profile.AdminByReason("Fingerprint exception set")
	End Function

	Private Async Function GetExceptionForCustomer(id As Long) As Task(Of String)
		Using connection = GetSqlConnection()
			Dim commandGetException As New SqlCommand($"SELECT Comment FROM CustomerFingerPrintExceptionList WHERE CustomerId = {id}", connection)

			Return Await Worker.RunWork(
				Function()
					Dim result As Object = commandGetException.ExecuteScalar()
					If (result Is Nothing) Then Return String.Empty
					Return CStr(result)
				End Function)
		End Using
	End Function

	Private Async Function RemoveExceptionForCustomer(id As Long) As Task
		Using connection = GetSqlConnection()
			Dim commandRemoveException As New SqlCommand($"
				IF EXISTS (SELECT * FROM CustomerFingerPrintExceptionList WHERE CustomerId = {id})
				BEGIN
					DELETE FROM CustomerFingerPrintExceptionList WHERE CustomerId = {id}
				END", connection)

			Await Worker.RunWork(
				Sub()
					commandRemoveException.ExecuteNonQuery()
				End Sub)
		End Using
	End Function
End Class
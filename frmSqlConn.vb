Public Class ExecuteProcedur
	Public Shared Function ExecuteCMD(ByRef CMD As SqlClient.SqlCommand) As DataSet
		ReadyConnectionF()
		Dim ds As New DataSet()

		Try
			Dim connection As New SqlClient.SqlConnection(connectionString)
			CMD.Connection = connection
			CMD.CommandType = CommandType.StoredProcedure
			Dim adapter As New SqlClient.SqlDataAdapter(CMD)
			adapter.SelectCommand.CommandTimeout = 300

			adapter.Fill(ds)
		Catch ex As Exception
			Throw (New Exception("Database Error:" & ex.Message))
			MsgBox(ex.Message)
			MessageBox.Show("No Button Pressed", "MessageBox Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		Return ds
	End Function
End Class


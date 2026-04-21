Imports System.Runtime.InteropServices
Imports GAT_Writer_5250

Module CardReaderManager

	Public CardReaderAvailable As Boolean = False
	Public CardReader As CardReader = Nothing

	Public Sub InitCardReader()
		CloseCardReader()

		Try
			Dim newReader As New CardReader With {
				.CryptKey = "E6147DD79B589816B733BE7B4D52EE32",
				.FID = "9999",
				.FID_SUB = "00"
			}

			If newReader.OpenDevice() Then
				CardReader = newReader
				CardReaderAvailable = True
			Else
				ReleaseReader(newReader)
			End If

		Catch
			CardReaderAvailable = False
			CardReader = Nothing
		End Try
	End Sub

	Public Sub CloseCardReader()
		If CardReader Is Nothing Then Return
		Try
			CardReader.CloseDevice()
		Catch
		Finally
			ReleaseReader(CardReader)
			CardReader = Nothing
			CardReaderAvailable = False
		End Try
	End Sub

	Private Sub ReleaseReader(reader As CardReader)
		If reader Is Nothing Then Return
		Try
			Marshal.ReleaseComObject(reader)
		Catch
		End Try
	End Sub

End Module

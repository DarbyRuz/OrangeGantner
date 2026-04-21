Imports System.IO
Imports System.Runtime.InteropServices
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing
Public Class frmCamera
	Private videoDevices As FilterInfoCollection
	Private videoSource As VideoCaptureDevice





	Private Sub frmCamera_Load(sender As Object, e As EventArgs) Handles Me.Load

		' Get available webcams
		videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

		cmbCamera.Items.Clear()

		For Each device As FilterInfo In videoDevices
			cmbCamera.Items.Add(device.Name)
		Next

		If cmbCamera.Items.Count > 0 Then
			cmbCamera.SelectedIndex = 0
		Else
			MessageBox.Show("There are no cameras detected.")
			Me.Close()
			Exit Sub
		End If

		btnSave.Enabled = True

		If lstDevices.Items.Count > 0 Then
			lstDevices.SelectedIndex = 0
		Else
			lstDevices.Items.Add("No Capture Device")
		End If

	End Sub
	Private Sub StartCamera()
		Dim index As Integer = cmbCamera.SelectedIndex
		If index < 0 Then Return

		StopCamera()

		Try
			videoSource = New VideoCaptureDevice(videoDevices(index).MonikerString)
			AddHandler videoSource.NewFrame, AddressOf Video_NewFrame
			videoSource.Start()
		Catch
		End Try

	End Sub

	Private Sub StopCamera()
		If videoSource IsNot Nothing Then
			If videoSource.IsRunning Then
				videoSource.SignalToStop()
				videoSource.WaitForStop()
			End If
			RemoveHandler videoSource.NewFrame, AddressOf Video_NewFrame
			videoSource = Nothing
		End If
	End Sub

	Private Sub frmCamera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		StopCamera()
	End Sub


	Private Sub cmbCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCamera.SelectedIndexChanged
		StartCamera()
	End Sub

	Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)

		If videoSource Is Nothing OrElse Not videoSource.IsRunning Then Return

		Try
			Dim bmp As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)

			If PictureBox1.IsDisposed OrElse PictureBox1.Disposing Then Return

			If PictureBox1.InvokeRequired Then
				PictureBox1.BeginInvoke(New Action(Sub()
													   If PictureBox1.IsDisposed OrElse PictureBox1.Disposing Then Return
													   If PictureBox1.Image IsNot Nothing Then
														   PictureBox1.Image.Dispose()
													   End If
													   PictureBox1.Image = bmp
												   End Sub))
			Else
				If PictureBox1.Image IsNot Nothing Then
					PictureBox1.Image.Dispose()
				End If
				PictureBox1.Image = bmp
			End If
		Catch
			' Ignore errors during frame processing
		End Try

	End Sub


	Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
		'   OpenPreviewWindow()
		' SavePhotoAuto()
		savePhoto()
	End Sub
	Sub SavePhotoAuto()

		Dim path As String = IO.Path.Combine(imagePath, Label1.Text & ".jpg")

		Using bmp As New Bitmap(PictureBox1.Image)
			bmp.Save(path, Imaging.ImageFormat.Jpeg)
		End Using
		Dim frm As New Profile
		' frm.pView.Image = Image.FromFile(FileName)
		frm.pView.Refresh()

		'  bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
		'  End If


		Me.Close()
	End Sub
	Sub SavePhoto1()

		If picPreview.Image Is Nothing Then
			MessageBox.Show("No image to save.")
			Exit Sub
		End If

		Dim fileName As String = Label1.Text & ".jpg"

		Using sfd As New SaveFileDialog
			sfd.Title = "Save Photo"
			sfd.Filter = "JPEG Image|*.jpg"
			sfd.FileName = fileName
			sfd.InitialDirectory = imagePath
			sfd.OverwritePrompt = True

			If sfd.ShowDialog() = DialogResult.OK Then
				Using bmp As New Bitmap(picPreview.Image)
					bmp.Save(sfd.FileName, Imaging.ImageFormat.Jpeg)
				End Using

				MessageBox.Show("Photo saved successfully.")
			End If
		End Using

	End Sub

	Sub savePhoto()
		'CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex)
		'  Dim data As IDataObject
		' Dim bmap As Image
		Dim str As String = Label1.Text
		Dim SourcePath As String = imagePath & str & ".jpg" '"c:\SomeFolder\SomeFileYouWantToCopy.txt" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
		Dim SaveDirectory As String = imagePath ' "c:\DestinationFolder"

		Dim Filename As String = System.IO.Path.GetFileName(SourcePath) 'get the filename of the original file without the directory on it
		Dim SavePath As String = System.IO.Path.Combine(SaveDirectory, Filename) 'combines the saveDirectory and the filename to get a fully qualified path.

		Filename = imagePath & str & ".jpg"

		Dim savefiledialog1 As New SaveFileDialog
		savefiledialog1.Title = "Save File"
		savefiledialog1.FileName = imagePath & str & ".jpg"
		savefiledialog1.Filter = "Jpeg |*.jpg"
		savefiledialog1.OverwritePrompt = True

		If savefiledialog1.ShowDialog() = DialogResult.OK Then


			PictureBox1.Image.Save(imagePath & str & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


		End If
		' End If

		' PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage


		Dim frm As New Profile
		' frm.pView.Image = Image.FromFile(FileName)
		frm.pView.Refresh()

		'  bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
		'  End If


		Me.Close()
		' End If
	End Sub

	Private Sub frmCamera_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Me.Close()
	End Sub
End Class

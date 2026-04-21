Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO





Public Class FormImage
    Inherits System.Windows.Forms.Form
    Public CamMgr As TouchlessLib.TouchlessMgr
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picCapture As System.Windows.Forms.PictureBox
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents lblDevice As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    Private WithEvents cmbCamera As ComboBox
    Private WithEvents lblCamera As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picCapture = New System.Windows.Forms.PictureBox()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCapture
        '
        Me.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCapture.ErrorImage = Nothing
        Me.picCapture.Location = New System.Drawing.Point(250, 28)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(307, 314)
        Me.picCapture.TabIndex = 0
        Me.picCapture.TabStop = False
        '
        'lstDevices
        '
        Me.lstDevices.ItemHeight = 16
        Me.lstDevices.Location = New System.Drawing.Point(10, 63)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(220, 212)
        Me.lstDevices.TabIndex = 1
        '
        'lblDevice
        '
        Me.lblDevice.Location = New System.Drawing.Point(10, 37)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(220, 18)
        Me.lblDevice.TabIndex = 2
        Me.lblDevice.Text = "Available Devices"
        Me.lblDevice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(24, 369)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(101, 37)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start Preview"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(409, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 38)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Image"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(288, 369)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(115, 37)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop Preview"
        '
        'sfdImage
        '
        Me.sfdImage.Filter = "Bitmap|*.bmp"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 6
        '
        'cmbCamera
        '
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.FormattingEnabled = True
        Me.cmbCamera.Location = New System.Drawing.Point(10, 28)
        Me.cmbCamera.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(240, 24)
        Me.cmbCamera.TabIndex = 10
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Location = New System.Drawing.Point(9, 8)
        Me.lblCamera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(108, 17)
        Me.lblCamera.TabIndex = 9
        Me.lblCamera.Text = "Select Camera :"
        '
        'Timer1
        '
        '
        'FormImage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(622, 406)
        Me.Controls.Add(Me.cmbCamera)
        Me.Controls.Add(Me.lblCamera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDevice)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.picCapture)
        Me.Name = "FormImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Capture"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer
    Private Declare Function GetTickCount Lib "kernel32" () As Long
    ' 
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean

    Private Sub FormImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CamMgr = New TouchlessLib.TouchlessMgr
        TempFileNames2 = ""

        For i As Integer = 0 To CamMgr.Cameras.Count - 1
            cmbCamera.Items.Add(CamMgr.Cameras(i).ToString)
        Next
        If cmbCamera.Items.Count > 0 Then
            cmbCamera.SelectedIndex = 0
            Timer1.Enabled = True
        Else
            MsgBox("There are no Camera ...")
            Me.Close()
        End If
        LoadDeviceList()
        If lstDevices.Items.Count > 0 Then
            btnStart.Enabled = True
            lstDevices.SelectedIndex = 0
            btnStart.Enabled = True
        Else
            lstDevices.Items.Add("No Capture Device")
            btnStart.Enabled = False
        End If

        btnStop.Enabled = False
        btnSave.Enabled = False
        picCapture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    ' Private Sub PreviewVideo(ByVal pbCtrl As PictureBox)

    '     hWnd = capCreateCaptureWindowA(VideoSource, WS_VISIBLE Or WS_CHILD, 0, 0, 0,
    '0, pbCtrl.Handle.ToInt64, 0)
    '     Dim IniTime As Long = GetTickCount()
    '     While GetTickCount() < (IniTime + 1000)
    '         Application.DoEvents()
    '     End While
    '     Dim OKAnswer As Boolean = False
    '     For xretries As Integer = 1 To 10
    '         ' I'll give you Only 10 tries to connect, otherwise I AM LEAVING MICROSOFT!
    '         OKAnswer = SendMessage(hWnd, WM_CAP_DRIVER_CONNECT, VideoSource, 0)
    '         If OKAnswer Then
    '             Exit For
    '         End If
    '     Next
    '     If OKAnswer Then
    '         SendMessage(hWnd, WM_CAP_SET_SCALE, True, 0)
    '         SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, 30, 0)
    '         SendMessage(hWnd, WM_CAP_SET_PREVIEW, True, 0)
    '         SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, pbCtrl.Width, pbCtrl.Height, SWP_NOMOVE Or SWP_NOZORDER)
    '     Else
    '         DestroyWindow(hWnd)
    '     End If
    ' End Sub

    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0

        ' Load name of all avialable devices into the lstDevices
        '
        'strName = "FaceCam 1000"
        CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex)
        lstDevices.Items.Add(CamMgr.CurrentCamera)
        Do
            '
            '   Get Driver name and version
            '
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)

            '
            ' If there was a device add device name to the list
            '
            If bReturn Then lstDevices.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub

    Private Sub OpenPreviewWindow()
        ' On Error Resume Next

        Dim iHeight As Integer = picCapture.Height
        Dim iWidth As Integer = picCapture.Width

        '
        ' Open Preview window in picturebox
        ' Dim IniTime As Integer = GetTickCount()
        ' While GetTickCount() < (IniTime + 1000)

        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640,
            480, picCapture.Handle.ToInt32, 0)

        ' End While
        ' Connect to device
        '
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Set the preview scale
            '
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Set the preview rate in milliseconds
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Start previewing the image from the camera
            '
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Resize window to fit in picturebox
            '
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCapture.Width, picCapture.Height,
                    SWP_NOMOVE Or SWP_NOZORDER)

            btnSave.Enabled = True
            btnStop.Enabled = True
            btnStart.Enabled = False
        Else
            '
            ' Error connecting to device close window
            ' 
            DestroyWindow(hHwnd)

            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        savePhoto()


        OpenPreviewWindow()
    End Sub

    Private Sub ClosePreviewWindow()
        '
        ' Disconnect from device
        '
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        '
        ' close window
        '
        'Timer1.Enabled = False
        'CamMgr.CurrentCamera.Dispose()
        'CamMgr.Cameras.Item(cmbCamera.SelectedIndex).Dispose()
        'CamMgr.Dispose()

        'Me.Close()
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ClosePreviewWindow()
        btnSave.Enabled = True
        btnStart.Enabled = True
        btnStop.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim data As IDataObject
        Dim bmap As Image
        Dim str As String = Label1.Text
        Dim SourcePath As String = imagePath & str & ".jpg" '"c:\SomeFolder\SomeFileYouWantToCopy.txt" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim SaveDirectory As String = imagePath ' "c:\DestinationFolder"

        Dim Filename As String = System.IO.Path.GetFileName(SourcePath) 'get the filename of the original file without the directory on it
        Dim SavePath As String = System.IO.Path.Combine(SaveDirectory, Filename) 'combines the saveDirectory and the filename to get a fully qualified path.

        If System.IO.File.Exists(SavePath) Then
            'The file exists

            Console.Write(SourcePath)
        Else
            'the file doesn't exist

            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

            '
            ' Get image from clipboard and convert it to a bitmap
            '
            data = Clipboard.GetDataObject()
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
                picCapture.Image = bmap
                ClosePreviewWindow()
                btnSave.Enabled = False
                btnStop.Enabled = False
                btnStart.Enabled = True

                '  If sfdImage.ShowDialog = DialogResult.OK Then


                '  Dim FileName As String
                Filename = imagePath & str & ".jpg"
                Dim savefiledialog1 As New SaveFileDialog
                savefiledialog1.Title = "Save File"
                savefiledialog1.FileName = imagePath & str & ".jpg"
                savefiledialog1.Filter = "Jpeg |*.jpg"
                ' savefiledialog1.OverwritePrompt = True

                If savefiledialog1.ShowDialog() = DialogResult.OK Then


                    picCapture.Image.Save(imagePath & str & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


                End If


                picCapture.SizeMode = PictureBoxSizeMode.StretchImage


                Dim frm As New Profile
                ' frm.pView.Image = Image.FromFile(FileName)
                frm.pView.Refresh()

                '  bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
            End If

        End If
    End Sub
    Sub savePhoto()
        CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex)
        iDevice = lstDevices.SelectedIndex
        Dim data As IDataObject
        Dim bmap As Image
        Dim str As String = Label1.Text
        Dim SourcePath As String = imagePath & str & ".jpg" '"c:\SomeFolder\SomeFileYouWantToCopy.txt" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim SaveDirectory As String = imagePath ' "c:\DestinationFolder"

        Dim Filename As String = System.IO.Path.GetFileName(SourcePath) 'get the filename of the original file without the directory on it
        Dim SavePath As String = System.IO.Path.Combine(SaveDirectory, Filename) 'combines the saveDirectory and the filename to get a fully qualified path.

        If System.IO.File.Exists(SavePath) Then
            MsgBox("File exists!", MsgBoxStyle.Information)
            'The file exists
            ' If MsgBox(" Delete Photo?", MsgBoxStyle.OkCancel, "Info") = MsgBoxResult.Ok Then
            ' System.IO.File.Delete(Filename)
            '  System.IO.File.Move(SourcePath, "D:\")


            '  MsgBox("File Deleted")
            Console.Write(SourcePath & Filename)

            Exit Sub


        Else
            'the file doesn't exist

            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

            '
            ' Get image from clipboard and convert it to a bitmap
            '
            data = Clipboard.GetDataObject()
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
                picCapture.Image = bmap
                ClosePreviewWindow()
                btnSave.Enabled = False
                btnStop.Enabled = False
                btnStart.Enabled = True

                '  If sfdImage.ShowDialog = DialogResult.OK Then


                '  Dim FileName As String
                Filename = imagePath & str & ".jpg"
                Dim savefiledialog1 As New SaveFileDialog
                savefiledialog1.Title = "Save File"
                savefiledialog1.FileName = imagePath & str & ".jpg"
                savefiledialog1.Filter = "Jpeg |*.jpg"
                ' savefiledialog1.OverwritePrompt = True

                If savefiledialog1.ShowDialog() = DialogResult.OK Then


                    picCapture.Image.Save(imagePath & str & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


                End If


                picCapture.SizeMode = PictureBoxSizeMode.StretchImage


                Dim frm As New Profile
                ' frm.pView.Image = Image.FromFile(FileName)
                frm.pView.Refresh()

                '  bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
            End If

        End If
    End Sub
    Private Sub FormImage_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' If btnStop.Enabled Then
        'ClosePreviewWindow()
        '  End If
    End Sub




    Public Function ConvertImage(ByVal myImage As Image) As Byte()

        Dim mstream As New MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp)

        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0

        mstream.Read(myBytes, 0, mstream.Length)

        Return myBytes

    End Function

    Private Sub cmbCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCamera.SelectedIndexChanged
        CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex)

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        picCapture.Image = CamMgr.CurrentCamera.GetCurrentImage()
    End Sub
End Class

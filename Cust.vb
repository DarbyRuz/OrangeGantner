Imports System.Data.SqlClient
Imports System.Text

Imports System.Globalization

Imports System.Runtime.InteropServices

Public Class Cust
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblCardID As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents editID As System.Windows.Forms.TextBox
    Friend WithEvents editCardID As System.Windows.Forms.TextBox
    Friend WithEvents editLastName As System.Windows.Forms.TextBox
    Friend WithEvents editFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblMobilePhone As System.Windows.Forms.Label
    Friend WithEvents lblBornOn As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents editMobilePhone As System.Windows.Forms.TextBox
    Friend WithEvents editBornOn As System.Windows.Forms.TextBox
    Friend WithEvents editNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnPhoto As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtUID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents editHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AxCardReader1 As AxGAT_Writer_5250.AxCardReader
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents dtBornOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cust))
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCardID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.editID = New System.Windows.Forms.TextBox()
        Me.editCardID = New System.Windows.Forms.TextBox()
        Me.editLastName = New System.Windows.Forms.TextBox()
        Me.editFirstName = New System.Windows.Forms.TextBox()
        Me.lblMobilePhone = New System.Windows.Forms.Label()
        Me.lblBornOn = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.editMobilePhone = New System.Windows.Forms.TextBox()
        Me.editBornOn = New System.Windows.Forms.TextBox()
        Me.editNotes = New System.Windows.Forms.TextBox()
        Me.btnNavFirst = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.lblNavLocation = New System.Windows.Forms.Label()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPhoto = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.editHomePhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AxCardReader1 = New AxGAT_Writer_5250.AxCardReader()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dtBornOn = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblUser = New System.Windows.Forms.Label()
        CType(Me.AxCardReader1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(10, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(100, 23)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID"
        '
        'lblCardID
        '
        Me.lblCardID.Location = New System.Drawing.Point(10, 76)
        Me.lblCardID.Name = "lblCardID"
        Me.lblCardID.Size = New System.Drawing.Size(100, 23)
        Me.lblCardID.TabIndex = 2
        Me.lblCardID.Text = "CardNumber"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(10, 140)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 23)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Surname"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(10, 106)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "Name"
        '
        'editID
        '
        Me.editID.Enabled = False
        Me.editID.Location = New System.Drawing.Point(120, 43)
        Me.editID.Name = "editID"
        Me.editID.Size = New System.Drawing.Size(100, 20)
        Me.editID.TabIndex = 5
        '
        'editCardID
        '
        Me.editCardID.Location = New System.Drawing.Point(120, 76)
        Me.editCardID.Name = "editCardID"
        Me.editCardID.Size = New System.Drawing.Size(100, 20)
        Me.editCardID.TabIndex = 6
        '
        'editLastName
        '
        Me.editLastName.Location = New System.Drawing.Point(120, 140)
        Me.editLastName.Name = "editLastName"
        Me.editLastName.Size = New System.Drawing.Size(128, 20)
        Me.editLastName.TabIndex = 7
        '
        'editFirstName
        '
        Me.editFirstName.Location = New System.Drawing.Point(120, 106)
        Me.editFirstName.Name = "editFirstName"
        Me.editFirstName.Size = New System.Drawing.Size(128, 20)
        Me.editFirstName.TabIndex = 8
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.Location = New System.Drawing.Point(267, 43)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(77, 23)
        Me.lblMobilePhone.TabIndex = 9
        Me.lblMobilePhone.Text = "Phone"
        '
        'lblBornOn
        '
        Me.lblBornOn.Location = New System.Drawing.Point(267, 76)
        Me.lblBornOn.Name = "lblBornOn"
        Me.lblBornOn.Size = New System.Drawing.Size(61, 23)
        Me.lblBornOn.TabIndex = 10
        Me.lblBornOn.Text = "E-Mail"
        '
        'lblNotes
        '
        Me.lblNotes.Location = New System.Drawing.Point(267, 109)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(61, 23)
        Me.lblNotes.TabIndex = 11
        Me.lblNotes.Text = "Notes"
        '
        'editMobilePhone
        '
        Me.editMobilePhone.Location = New System.Drawing.Point(340, 43)
        Me.editMobilePhone.Name = "editMobilePhone"
        Me.editMobilePhone.Size = New System.Drawing.Size(107, 20)
        Me.editMobilePhone.TabIndex = 12
        '
        'editBornOn
        '
        Me.editBornOn.Location = New System.Drawing.Point(340, 76)
        Me.editBornOn.Name = "editBornOn"
        Me.editBornOn.Size = New System.Drawing.Size(165, 20)
        Me.editBornOn.TabIndex = 13
        '
        'editNotes
        '
        Me.editNotes.Location = New System.Drawing.Point(340, 109)
        Me.editNotes.Name = "editNotes"
        Me.editNotes.Size = New System.Drawing.Size(268, 20)
        Me.editNotes.TabIndex = 14
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(203, 242)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 15
        Me.btnNavFirst.Text = "<<"
        Me.btnNavFirst.Visible = False
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(243, 242)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 16
        Me.btnNavPrev.Text = "<"
        Me.btnNavPrev.Visible = False
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(278, 242)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 17
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNavLocation.Visible = False
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(373, 242)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 18
        Me.btnNavNext.Text = ">"
        Me.btnNavNext.Visible = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(408, 242)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 19
        Me.btnLast.Text = ">>"
        Me.btnLast.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(651, 271)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "&Save"
        '
        'btnPhoto
        '
        Me.btnPhoto.Location = New System.Drawing.Point(651, 300)
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(75, 23)
        Me.btnPhoto.TabIndex = 21
        Me.btnPhoto.Text = "Photo"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(533, 329)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 22
        Me.btnNew.Text = "New"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(344, 144)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(264, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Manager"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(453, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Read UID from CardReader"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(522, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "&Load"
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(340, 18)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(107, 20)
        Me.txtUID.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(267, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "UID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 20)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Send to GatRelaxx"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'editHomePhone
        '
        Me.editHomePhone.Location = New System.Drawing.Point(453, 42)
        Me.editHomePhone.Name = "editHomePhone"
        Me.editHomePhone.Size = New System.Drawing.Size(100, 20)
        Me.editHomePhone.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 32)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Authorization Group"
        '
        'ComboBox15
        '
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Location = New System.Drawing.Point(104, 276)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox15.TabIndex = 81
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 84
        '
        'AxCardReader1
        '
        Me.AxCardReader1.Location = New System.Drawing.Point(426, 317)
        Me.AxCardReader1.Name = "AxCardReader1"
        Me.AxCardReader1.OcxState = CType(resources.GetObject("AxCardReader1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCardReader1.Size = New System.Drawing.Size(75, 23)
        Me.AxCardReader1.TabIndex = 85
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Client", "Gift Card", "Temporary Card", "Tennis", "Staff"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(618, 10)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 60)
        Me.CheckedListBox1.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Born On"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 23)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Gender"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 89
        '
        'cmbGender
        '
        Me.cmbGender.AutoCompleteCustomSource.AddRange(New String() {"M", "F"})
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"M", "F"})
        Me.cmbGender.Location = New System.Drawing.Point(115, 192)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(87, 21)
        Me.cmbGender.TabIndex = 90
        '
        'dtBornOn
        '
        Me.dtBornOn.CustomFormat = "dd/MM/yyyy"
        Me.dtBornOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBornOn.Location = New System.Drawing.Point(115, 165)
        Me.dtBornOn.Name = "dtBornOn"
        Me.dtBornOn.Size = New System.Drawing.Size(128, 20)
        Me.dtBornOn.TabIndex = 91
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(651, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 92
        Me.Button4.Text = "Deposit Client"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(775, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 22)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "Gift"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(592, 152)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker1.TabIndex = 94
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(592, 176)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker2.TabIndex = 95
        Me.DateTimePicker2.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(681, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 96
        Me.TextBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(762, 276)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 97
        Me.CheckBox1.Text = "New braslet"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(12, 339)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(39, 13)
        Me.lblUser.TabIndex = 204
        Me.lblUser.Text = "Label2"
        '
        'Cust
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(905, 417)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dtBornOn)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(AxCardReader1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox15)
        Me.Controls.Add(Me.editHomePhone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCardID)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.editID)
        Me.Controls.Add(Me.editCardID)
        Me.Controls.Add(Me.editLastName)
        Me.Controls.Add(Me.editFirstName)
        Me.Controls.Add(Me.editMobilePhone)
        Me.Controls.Add(Me.editBornOn)
        Me.Controls.Add(Me.editNotes)
        Me.Controls.Add(Me.lblMobilePhone)
        Me.Controls.Add(Me.lblBornOn)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPhoto)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "Cust"
        Me.Text = "New Client Registration"
        CType(Me.AxCardReader1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str, str1 As String
    ' Dim CardReader1 As GAT.Comms.AccessEngine.Data.ICardReaderCommandsSection
    Dim dv As DataView
    '  Public Cardreader1 As GAT.Comms.AccessEngine.Data.ICardReaderEventsSection
    ' Dim Cardreader1 As GAT_Writer_5250.CardReader ' = "GATWriter5250.ocx"
    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder

    Dim dt As DataTable

    Dim changes As DataSet

    Private Function GenerateCustID() As Integer
        ReadyConnectionF()
        Dim value As Integer


        Dim cmd = New SqlCommand("SELECT max(ID) FROM Customers", conn)


        Dim sqlResult1 As Object = ExecuteScalar(cmd)

        If IsDBNull(sqlResult1) Then

            value = 1

        Else
            sqlResult1.ToString()
            value = ExecuteScalar(cmd)

            value = value + 1
        End If
        Return value
    End Function

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")

        editCardID.Text = timeStamp
        editFirstName.Text = ""
        editLastName.Text = ""
        editMobilePhone.Text = ""
        txtUID.Text = ""
        '  editBornOn.Text = ""
        editNotes.Text = ""
        TextBox1.Text = ""
        ComboBox15.SelectedIndex = -1
        btnAdd.Enabled = True

    End Sub
    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click
        Photo()
        'Dim f As New FormImage
        'Try
        '    f.Owner = Me
        '    f.Label1.Text = Trim(editCardID.Text)
        '    f.ShowDialog()

        'Finally
        '    f.Dispose()
        'End Try
    End Sub
    Sub Photo()
        Dim f As New frmCamera
        Try
            f.Owner = Me
            f.Label1.Text = Trim(editCardID.Text)
            f.ShowDialog()

        Finally
            f.Dispose()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")

        'Dim D1 As Date = Format(dtBornOn.Value, "yyyy.MM.dd")
        'Dim D2 As Date = Format(Now(), "yyyy.MM.dd")
        '  Dim D1 As Date = dtBornOn.Value
        '   Dim D2 As Date = Now()
        Dim cID, UID, cardtype As String
        If editCardID.Text <> "" Then
            cID = editCardID.Text 'CardId from customers table

        Else
            MsgBox("Card Number,Please! ", MsgBoxStyle.Information, "CardID")
            editCardID.Focus()
            Exit Sub
        End If

        If txtUID.Text = "" Then
            MsgBox("Please enter CardUID", MsgBoxStyle.Exclamation, "Warning")
            txtUID.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("Please select group", MsgBoxStyle.Exclamation, "Warning")
            ComboBox15.Focus()
            Exit Sub
        End If
        If editLastName.Text = "" Then
            MsgBox("Please enter Surname", MsgBoxStyle.Exclamation, "Warning")
            editLastName.Focus()
            Exit Sub
        End If
        If editFirstName.Text = "" Then
            MsgBox("Please enter Name", MsgBoxStyle.Exclamation, "Warning")
            editFirstName.Focus()
            Exit Sub
        End If
        If editMobilePhone.Text = "" Then
            MsgBox("Please enter Phone Number", MsgBoxStyle.Exclamation, "Warning")
            editMobilePhone.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Please enter Admin or manager", MsgBoxStyle.Exclamation, "Warning")
            ComboBox1.Focus()
            Exit Sub
        End If
        Dim cmd1 As New SqlCommand

        If CheckedListBox1.SelectedIndex = 0 Then

            cID = editCardID.Text
            cardtype = "permanent"
        Else

            If CheckedListBox1.SelectedIndex = 1 Then

                cID = "gft" + timeStamp
                editCardID.Text = cID
                cardtype = "gift"

            Else
                If CheckedListBox1.SelectedIndex = 2 Then
                    cID = "tmp" + timeStamp
                    editCardID.Text = cID
                    cardtype = "temp"

                Else
                    If CheckedListBox1.SelectedIndex = 3 Then
                        cID = "ten" + timeStamp
                        editCardID.Text = cID
                        cardtype = "tenis"

                    Else
                        If CheckedListBox1.SelectedIndex = 4 Then
                            cID = "st" + timeStamp
                            editCardID.Text = cID
                            cardtype = "staff"

                        Else


                            cardtype = "permanent"
                        End If
                    End If
                End If
            End If
        End If

        cmd1 = conn.CreateCommand
        cmd1.Parameters.Add("@CardID", Data.SqlDbType.NChar).Value = cID

        cmd1.CommandText = "select count(CardID) from Customers where CardID = @CardID"


        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If (sqlResult1 > 0) Then

            MsgBox("CardID dublicate", MsgBoxStyle.Information, "Message :")
            editCardID.Focus()
            Exit Sub
        Else


            Dim cmdUID As New SqlCommand

            UID = txtUID.Text
            cmdUID = conn.CreateCommand
            cmdUID.Parameters.Add("@UID", Data.SqlDbType.NChar).Value = UID

            cmdUID.CommandText = "select count(UID) from Customers where UID = @UID"


            Dim sqlResult2 As Object = ExecuteScalar(cmdUID)
            If (sqlResult2 > 0) Then

                MsgBox("UID dublicate", MsgBoxStyle.Information, "Message :")
                txtUID.Focus()
                Exit Sub
            Else


                Dim strID As String = "Select max(ID) from customers"
                Dim cmdMax As SqlCommand = New SqlCommand(strID, conn)
                Dim Custid As Integer = ExecuteScalar(cmdMax)

                Dim Str As Integer = Custid + 1
                editID.Text = Str
                Dim Str0 = editID.Text
                Dim str1 As String
                Dim str2 As String = editLastName.Text
                Dim str3 As String = editFirstName.Text
                Dim str4 As String = cmbGender.Text
                Dim str5 As String = ""
                Dim str6 As String = cardtype
                Str = Custid + 1
                str1 = cID
                Dim str7 As String = txtUID.Text
                Dim str8 As String = editHomePhone.Text
                Dim str9 As String = editMobilePhone.Text
                Dim str10 As String = ""
                Dim str11 As String = ""
                '  Dim str12 As Date = D1
                Dim str13 As String = "enabled"
                Dim str14 As String = ""
                Dim str15 As String = editBornOn.Text 'Email
                Dim str16 As String = ComboBox1.Text 'Manager
                Dim str17 As String = ""
                Dim str18 As String = editNotes.Text
                Dim str19 As String = ComboBox15.Text
                Dim str20 As String = TextBox1.Text
                '  Dim str21 As Date = D2
                '   Dim fp As Integer = 0
                '  fp = 0 ', '" & fp & "' 
                Dim st As String
                Dim oper As String
                oper = "new customer " & Str
                st = lblUser.Text
                Dim CMD2 As New SqlCommand("InsertCustomers")

                CMD2.Parameters.Add("@id", Data.SqlDbType.Int).Value = GenerateCustID()
                CMD2.Parameters.Add("@CardID", Data.SqlDbType.NChar).Value = str1
                CMD2.Parameters.Add("@LastName", Data.SqlDbType.NVarChar).Value = editLastName.Text
                CMD2.Parameters.Add("@FirstName", Data.SqlDbType.NVarChar).Value = editFirstName.Text
                CMD2.Parameters.Add("@Sex", Data.SqlDbType.NChar).Value = cmbGender.Text
                CMD2.Parameters.Add("@Language", Data.SqlDbType.NVarChar).Value = ""
                CMD2.Parameters.Add ("@CardType", Data.SqlDbType.NVarChar).Value = cardtype
                CMD2.Parameters.Add("@UID" , Data.SqlDbType.NVarChar).Value = txtUID.Text
                CMD2.Parameters.Add("@HomePhone", Data.SqlDbType.NVarChar).Value = editHomePhone.Text
                CMD2.Parameters.Add("@MobilePhone", Data.SqlDbType.NVarChar).Value = editMobilePhone.Text
                CMD2.Parameters.Add("@Address", Data.SqlDbType.NText).Value = ""
                CMD2.Parameters.Add("@Passport", Data.SqlDbType.NVarChar).Value = ""
                CMD2.Parameters.Add("@BornOn", Data.SqlDbType.DateTime).Value = dtBornOn.Value
                CMD2.Parameters.Add("@Status", Data.SqlDbType.NVarChar).Value = "enabled"
                CMD2.Parameters.Add("@WebPage ", Data.SqlDbType.NText).Value = ""
                CMD2.Parameters.Add("@Email", Data.SqlDbType.NVarChar).Value = editBornOn.Text
                CMD2.Parameters.Add("@ContactPerson", Data.SqlDbType.NVarChar).Value = ComboBox1.Text
                CMD2.Parameters.Add("@ContactPersonPhone", Data.SqlDbType.NVarChar).Value = ""
                CMD2.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = editNotes.Text
                CMD2.Parameters.Add("@Attachments", Data.SqlDbType.NText).Value = ComboBox15.Text
                '  CMD2.Parameters.Add("@RelaxxGroupId", SqlDbType.UniqueIdentifier.VarChar = TextBox1.Text
                CMD2.Parameters.AddWithValue("@RelaxxGroupId", TextBox1.Text)
                CMD2.Parameters.Add("@regdate", Data.SqlDbType.DateTime).Value = DateTime.Now
                CMD2.Parameters.Add("@FP", Data.SqlDbType.Int).Value = 0

                ' ExecuteProcedur.ExecuteCMD(CMD2)

                'Dim strInsert As String = "INSERT INTO Customers VALUES('" & Str & "','" & str1 & "','" & str2 & "','" & str3 & "','" & str4 & "','" & str5 & "','" & str6 & "','" & str7 &
                '       "','" & str8 & "','" & str9 & "','" & str10 & "','" & str11 & "', '" & str12 & " ','" & str13 & "','" & str14 & "','" & str15 & "','" & str16 & "','" & str17 & "','" & str18 &
                '      "','" & str19 & "','" & str20 & "','" & str21 & "', 0)"
                Dim reas As String

                If CheckBox1.Checked = True Then
                        reas = "New With braslet"
                    Else
                        reas = "New without braslet"
                    End If
                    CustomerHistory(customerID:=Str, CardID:=str1, Reason:=reas, Admin:=str17)
                '  Photo()
                ExecuteProcedur.ExecuteCMD(CMD2)
                ' Dim cmdDatabase As SqlCommand = New SqlCommand(strInsert, conn)

                ' Dim check As Object = ExecuteReader(CMD2).RecordsAffected
                '   If check > 0 Then
                MsgBox(" Succesfully Save", MsgBoxStyle.OkOnly, "Info")

                        LogFunc(st, oper)
                    btnAdd.Enabled = False


                    Profile.txtFind.Text = Str
                    Profile.FindByCustid()
                    Profile.Refresh_Form()

                ' Else
                'MsgBox(" Failure Save", MsgBoxStyle.OkOnly, "Info")
                'End If

            End If

            End If

        ' End If




        'Profile.DataGridView3.Refresh()
    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(ds, "Customers").Position = 0
        Me.objClients_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(ds, "Customers").Position = (Me.ds.Tables("Customers").Rows.Count - 1)
        Me.objClients_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(ds, "Customers").Position = (Me.BindingContext(ds, "Customers").Position - 1)
        Me.objClients_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(ds, "Customers").Position = (Me.BindingContext(ds, "Customers").Position + 1)
        Me.objClients_PositionChanged()

    End Sub
    Private Sub objClients_PositionChanged()

    End Sub

    Private Sub Cust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim newCard As String = editCardID.Text
        'If then

        'End If
        If MessageBox.Show("Are you sure To close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim f As New Profile
            'Try
            f.Owner = Me
            f.txtCardId.Text = newCard
            f.ref()
            ' f.ShowDialog()
            f.txtCardId.Focus()
        Else
            e.Cancel = True
        End If
        'Finally
        '    f.Dispose()
        'End Try
    End Sub




    Private Sub Cust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim OrderDate As DateTime = DateTimePicker1.Value
        '  DateTimePicker2.Value = DateAdd(DateInterval.Month, 1, DateTimePicker1.Value)
        '  Dim EndDate As DateTime = DateTimePicker2.Value



        InitCardReader()

        CheckedListBox1.SelectedIndex = 0

        ReadyConnectionF()
        Dim sqlRelaxx As String

        sqlRelaxx = "Select * from AuthorizationGroup"
        ' connectionRelaxx.Open()
        adapter = New SqlDataAdapter(sqlRelaxx, conn)
        adapter.Fill(ds, "dtGroup")
        With ComboBox15
            .DisplayMember = "dtGroup.Name"
            .ValueMember = "RecordId"
            .DataSource = ds
            .SelectedIndex = -1
        End With
        Dim sqlEmpl As String
        sqlEmpl = "Select * from Emp"

        Try
            ReadyConnectionF()

            Dim dacust As New SqlDataAdapter

            dacust = New SqlDataAdapter(sqlEmpl, conn)
            dacust.Fill(ds, "Emp")


            With ComboBox1
                .DisplayMember = "Emp.Name"
                .ValueMember = "ID"
                .DataSource = ds
                .SelectedIndex = -1
            End With


            '    conn.Close()
            TextBox1.DataBindings.Add("Text", ds, "dtGroup.RecordId")
            TextBox1.Text = ""
            Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")

            editCardID.Text = timeStamp
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim sql As String = "Select  ID, CardID,UID, LastName, FirstName, MobilePhone, Notes  from Customers"

        ' Dim sql As String = "Select * from Customers"


        Try
            ReadyConnectionF()
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(ds)

            '  DataGrid1.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ref()
        Dim sql As String = "Select * from Customers"


        Try
            ReadyConnectionF()
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(ds)

            'Profile.DataGridView3.DataSource = ds
            '  DataGrid1.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub editCardID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editCardID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub



    Private Sub editLastName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    

    Private Sub editFirstName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editFirstName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub editMobilePhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editMobilePhone.TextChanged

    End Sub

    Private Sub editMobilePhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editMobilePhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub editBornOn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBornOn.TextChanged

    End Sub

    Private Sub editBornOn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editBornOn.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub editNotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editNotes.TextChanged

    End Sub

    Private Sub editNotes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editNotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' TextBox1.Text = CardReader1.GetUniqueNumber
        ' Dim myprocess As Process = System.Diagnostics.Process.Start("C:\Users\Gantner\Documents\OrangeGantner\OrangeGantner\Demo VB\Project1.exe")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If CardReaderAvailable Then
            Try
                txtUID.Text = CardReader.GetUniqueNumber()
            Catch
                MessageBox.Show("Place card on reader")
            End Try
        Else
            MessageBox.Show("Card reader not connected")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
    End Sub

    Private Sub editCardID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editCardID.TextChanged

    End Sub
    'Private Sub GatRelaxxAuthorization()
    '    If editCardID.Text = "" Then
    '        MsgBox("Please enter CardNumber", MsgBoxStyle.Exclamation, "Warning")
    '        editCardID.Focus()
    '    End If
    '    If txtUID.Text = "" Then
    '        MsgBox("Please enter CardUID", MsgBoxStyle.Exclamation, "Warning")
    '        txtUID.Focus()
    '    End If
    '    Dim command As New SqlCommand
    '    Dim sqlResult As New Object

    '    command.CommandText = "select * from AuthorizationTag where CardUID = '" & txtUID.Text & " ' "
    '    sqlResult = ExecuteScalarRelaxx(command)

    '    If (sqlResult Is Nothing) Then
    '        '  
    '        Dim CMD As New SqlClient.SqlCommand("InsertAuthorization")
    '        '  Dim newID As String = System.Guid.NewGuid.ToString()
    '        CMD.Parameters.Add("@RecordID", Data.SqlDbType.UniqueIdentifier).Value = System.Guid.NewGuid '1219148657674368
    '        CMD.Parameters.Add("@CardNumber", Data.SqlDbType.NVarChar).Value = editCardID.Text
    '        CMD.Parameters.Add("@CardUID", Data.SqlDbType.NVarChar).Value = txtUID.Text
    '        CMD.Parameters.Add("@MemberNumber", Data.SqlDbType.NVarChar).Value = editID.Text
    '        CMD.Parameters.Add("@FirstName", Data.SqlDbType.NVarChar).Value = editFirstName.Text
    '        CMD.Parameters.Add("@LastName", Data.SqlDbType.NVarChar).Value = editLastName.Text
    '        ExecuteProcRelaxx.ExecuteCMD(CMD)


    '        MsgBox("Done", MsgBoxStyle.Information, "OK")
    '    Else
    '        MsgBox("Dublicate UID", MsgBoxStyle.Exclamation, "Warning")
    '    End If

    'End Sub
    'Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '    GatRelaxxAuthorization()
    '  End Sub



    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)

        Next

        CheckedListBox1.SetItemCheckState(CheckedListBox1.SelectedIndex, CheckState.Checked)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim strID As String = "Select max(ID) from customers"
        Dim cmdMax As SqlCommand = New SqlCommand(strID, connection)
        Dim Custid As Integer = ExecuteScalar(cmdMax)
        Dim D1 As Date = Format(dtBornOn.Value, "yyyy.MM.dd")
        Dim Str As Integer = Custid + 1
        editID.Text = Str
        ' str = dr(0).ToString
        Dim Str0 = editID.Text
        Dim str1 As String
        Dim str2 As String = editLastName.Text
        Dim str3 As String = editFirstName.Text
        Dim str4 As String = cmbGender.Text
        Dim str5 As String = ""
        Dim str6 As String = "deposit"
        Str = Custid + 1
        str1 = str6 & Str


        Dim str7 As String = txtUID.Text
        Dim str8 As String = editHomePhone.Text
        Dim str9 As String = editMobilePhone.Text
        Dim str10 As String = ""
        Dim str11 As String = ""
        Dim str12 As Date = D1
        Dim str13 As String = "enabled"
        Dim str14 As String = ""
        Dim str15 As String = editBornOn.Text 'Email
        Dim str16 As String = ""
        Dim str17 As String = ComboBox1.Text 'Manager
        Dim str18 As String = editNotes.Text
        Dim str19 As String = ComboBox15.Text
        Dim str20 As String = TextBox1.Text 'group
        '   Dim str21 As Date = reDate ' dtBornOn.Value


        Dim strInsert As String = "INSERT INTO Customers VALUES('" & Str & "','" & str1 & "','" & str2 & "','" & str3 & "','" & str4 & "','" & str5 & "','" & str6 & "','" & str7 &
           "','" & str8 & "','" & str9 & "','" & str10 & "','" & str11 & "', '" & str12 & " ','" & str13 & "','" & str14 & "','" & str15 & "','" & str16 & "','" & str17 & "','" & str18 &
          "','" & str19 & "','" & str20 & "' )"

        CustomerHistory(customerID:=Str, CardID:=str1, Reason:="New", Admin:=str17)

        Dim cmdDatabase As SqlCommand = New SqlCommand(strInsert, connection)


        Dim check As Object = ExecuteReader(cmdDatabase).RecordsAffected
        If check > 0 Then
            MsgBox(" Succesfully Save", MsgBoxStyle.OkOnly, "Info")



        Else
            MsgBox(" Failure Save", MsgBoxStyle.OkOnly, "Info")
        End If



        CheckedListBox1.SelectedIndex = 0


        '  MsgBox(" Send authorization to GatRelaxx?", MsgBoxStyle.YesNo, "Info")
        '  If MsgBoxResult.Yes = True Then
        ' GatRelaxxAuthorization()
        '  Else
        'do nothing
        '  End If
        Profile.ref()
        Profile.Refresh()
        'Profile.RefreshLast()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim OrderDate As DateTime = DateTimePicker1.Value
        Dim EndDate As DateTime = DateTimePicker2.Value

        DateTimePicker2.Value = DateAdd(DateInterval.Day, Int(TextBox2.Text), OrderDate)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OrderDate As DateTime = DateTimePicker1.Value
        Dim EndDate As DateTime = DateTimePicker2.Value
        Dim custid As Integer = Int(editID.Text)
        ' GiftOrder(custid, DateTimePicker1.Value, DateTimePicker2.Value)
        GiftOrder(custid, OrderDate, EndDate)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
      
        Dim OrderDate As DateTime = DateTimePicker1.Value
        Dim EndDate As DateTime = DateTimePicker2.Value

        DateTimePicker2.Value = DateAdd(DateInterval.Day, Int(TextBox2.Text), OrderDate)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
       


    End Sub
End Class

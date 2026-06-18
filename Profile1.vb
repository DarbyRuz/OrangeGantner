Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Runtime.Remoting.Channels
Imports System.ComponentModel.Design
Imports System.Collections.Concurrent

Public Class Profile
	Inherits Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			components?.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As IContainer
	Friend WithEvents Button23 As Button
	Friend WithEvents Label23 As Label
	Friend WithEvents Button25 As Button
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents pView As PictureBox
	Private WithEvents AxCardReader1 As AxGAT_Writer_5250.AxCardReader
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BindingSource2 As BindingSource
	Friend WithEvents Label28 As Label
	Friend WithEvents BindingNavigator1 As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents ComboBox7 As ComboBox
	Friend WithEvents Button29 As Button
	Friend WithEvents ComboBox15 As ComboBox
	Friend WithEvents TextBox23 As TextBox
	Friend WithEvents TextBox32 As TextBox
	Friend WithEvents Button17 As Button
	Friend WithEvents txtCardId As TextBox
	Friend WithEvents txtPhone2 As TextBox
	Friend WithEvents Disabled As CheckBox
	Friend WithEvents chBoxAllow As CheckBox
	Friend WithEvents tmp As CheckBox
	Friend WithEvents chForgot As CheckBox
	Friend WithEvents cmbAdmin As ComboBox
	Friend WithEvents Label16 As Label
	Friend WithEvents LinkLabel2 As LinkLabel
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents DeleteCheckInsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label38 As Label
	Friend WithEvents Button8 As Button
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents cmbReason As ComboBox
	Friend WithEvents Label46 As Label
	Friend WithEvents Label51 As Label
	Friend WithEvents dtBornOn As DateTimePicker
	Friend WithEvents Button53 As Button
	Friend WithEvents LinkLabel3 As LinkLabel
	Friend WithEvents lblUser As Label
	Friend WithEvents txtUID As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Button26 As Button
	Friend WithEvents txtFirst As TextBox
	Friend WithEvents txtLast As TextBox
	Friend WithEvents btnFindLF As Button
	Friend WithEvents Button27 As Button
	Friend WithEvents txtFind As TextBox
	Friend WithEvents xStart As TabPage
	Friend WithEvents txtUsed As TextBox
	Friend WithEvents txtFree As TextBox
	Friend WithEvents dgw1 As DataGridView
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents Label62 As Label
	Friend WithEvents Label63 As Label
	Friend WithEvents Label64 As Label
	Friend WithEvents Label65 As Label
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnNew As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents cmbCoach As ComboBox
	Friend WithEvents guests As TabPage
	Friend WithEvents Button46 As Button
	Friend WithEvents Button42 As Button
	Friend WithEvents Button41 As Button
	Friend WithEvents TextBox37 As TextBox
	Friend WithEvents TextBox38 As TextBox
	Friend WithEvents TextBox35 As TextBox
	Friend WithEvents TextBox36 As TextBox
	Friend WithEvents Label52 As Label
	Friend WithEvents Label53 As Label
	Friend WithEvents Label54 As Label
	Friend WithEvents ComboBox19 As ComboBox
	Friend WithEvents Button40 As Button
	Friend WithEvents DataGridView6 As DataGridView
	Friend WithEvents DataGridView5 As DataGridView
	Friend WithEvents Button7 As Button
	Friend WithEvents Label49 As Label
	Friend WithEvents Label50 As Label
	Friend WithEvents deposit As TabPage
	Friend WithEvents Button55 As Button
	Friend WithEvents Button54 As Button
	Friend WithEvents Button52 As Button
	Friend WithEvents Button48 As Button
	Friend WithEvents Button47 As Button
	Friend WithEvents TextBox26 As TextBox
	Friend WithEvents TextBox24 As TextBox
	Friend WithEvents txtId As TextBox
	Friend WithEvents RichTextBox3 As RichTextBox
	Friend WithEvents txtDeposit As TextBox
	Friend WithEvents ComboBox17 As ComboBox
	Friend WithEvents Label41 As Label
	Friend WithEvents Label40 As Label
	Friend WithEvents Button34 As Button
	Friend WithEvents cmbBasic As ComboBox
	Friend WithEvents Button19 As Button
	Friend WithEvents Label21 As Label
	Friend WithEvents Label30 As Label
	Friend WithEvents cmbPurpose As ComboBox
	Friend WithEvents Label31 As Label
	Friend WithEvents Label32 As Label
	Friend WithEvents Label33 As Label
	Friend WithEvents CmbMethode As ComboBox
	Friend WithEvents payments As TabPage
	Friend WithEvents DataGridView4 As DataGridView
	Friend WithEvents debt As TabPage
	Friend WithEvents DataGrid2 As DataGrid
	Friend WithEvents Button4 As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents ComboBox10 As ComboBox
	Friend WithEvents orders As TabPage
	Friend WithEvents Button37 As Button
	Friend WithEvents Button36 As Button
	Friend WithEvents Button35 As Button
	Friend WithEvents dgvOrders As DataGridView
	Friend WithEvents freezBalance As TabPage
	Friend WithEvents Button49 As Button
	Friend WithEvents Label39 As Label
	Friend WithEvents Label37 As Label
	Friend WithEvents Label36 As Label
	Friend WithEvents ComboBox16 As ComboBox
	Friend WithEvents Label35 As Label
	Friend WithEvents Label34 As Label
	Friend WithEvents frAmount As TextBox
	Friend WithEvents frDays As TextBox
	Friend WithEvents TextBox25 As TextBox
	Friend WithEvents TextBox17 As TextBox
	Friend WithEvents TextBox16 As TextBox
	Friend WithEvents TextBox15 As TextBox
	Friend WithEvents TextBox13 As TextBox
	Friend WithEvents TextBox12 As TextBox
	Friend WithEvents TextBox11 As TextBox
	Friend WithEvents TextBox9 As TextBox
	Friend WithEvents TextBox20 As TextBox
	Friend WithEvents TextBox14 As TextBox
	Friend WithEvents frPay As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label18 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents DateTimePicker3 As DateTimePicker
	Friend WithEvents Button3 As Button
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents DataGrid8 As DataGrid
	Friend WithEvents DataGrid6 As DataGrid
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents details As TabPage
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents txtBorn As MaskedTextBox
	Friend WithEvents txtGroup As TextBox
	Friend WithEvents txtMail As TextBox
	Friend WithEvents dgw As DataGridView
	Friend WithEvents Button5 As Button
	Friend WithEvents Button9 As Button
	Friend WithEvents Button11 As Button
	Friend WithEvents Button15 As Button
	Friend WithEvents Button16 As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents txtDays As TextBox
	Friend WithEvents dtpEndDate As DateTimePicker
	Friend WithEvents dtpOrderDate As DateTimePicker
	Friend WithEvents Button12 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox18 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents cmbProd As ComboBox
	Friend WithEvents txtCoachId As TextBox
	Friend WithEvents txtPrId As TextBox
	Friend WithEvents txtClid As TextBox
	Friend WithEvents Button30 As Button
	Friend WithEvents dgvUsage As DataGridView
	Friend WithEvents Button18 As Button
	Friend WithEvents PrintDialog1 As PrintDialog
	Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
	Friend WithEvents PageSetupDialog1 As PageSetupDialog
	Friend WithEvents PrintDocument1 As PrintDocument
	Friend WithEvents txtCustid As TextBox
	Friend WithEvents TextBox22 As TextBox
	Friend WithEvents Button31 As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents txtAmount As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents delUsed As Button
	Friend WithEvents Button39 As Button
	Friend WithEvents Button43 As Button
	Friend WithEvents Button38 As Button
	Friend WithEvents Button32 As Button
	Friend WithEvents txtManager As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents usid As DataGridViewTextBoxColumn
	Friend WithEvents Column9 As DataGridViewTextBoxColumn
	Friend WithEvents Column10 As DataGridViewTextBoxColumn
	Friend WithEvents s As DataGridViewTextBoxColumn
	Friend WithEvents Label22 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Button24 As Button
	Friend WithEvents Button33 As Button
	Friend WithEvents Button56 As Button
	Friend WithEvents Button28 As Button
	Friend WithEvents Button20 As Button
	Friend WithEvents Button22 As Button
	Friend WithEvents Label25 As Label
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtCompany As TextBox
	Friend WithEvents admTools As TabPage
	Friend WithEvents updAddress As Button
	Friend WithEvents updCardId As Button
	Friend WithEvents updFLname As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents clId As TextBox
	Friend WithEvents cmbPyMet As ComboBox
	Friend WithEvents Button44 As Button
	Friend WithEvents custid As DataGridViewTextBoxColumn
	Friend WithEvents Cardid As DataGridViewTextBoxColumn
	Friend WithEvents FirstName As DataGridViewTextBoxColumn
	Friend WithEvents LastName As DataGridViewTextBoxColumn
	Friend WithEvents MobilePhone As DataGridViewTextBoxColumn
	Friend WithEvents UID As DataGridViewTextBoxColumn
	Friend WithEvents stat As DataGridViewTextBoxColumn
	Friend WithEvents cardtype As DataGridViewTextBoxColumn
	Friend WithEvents Attachments As DataGridViewTextBoxColumn
	Friend WithEvents Email As DataGridViewTextBoxColumn
	Friend WithEvents Notes As DataGridViewTextBoxColumn
	Friend WithEvents BornOn As DataGridViewTextBoxColumn
	Friend WithEvents ContactPerson As DataGridViewTextBoxColumn
	Friend WithEvents Address As DataGridViewTextBoxColumn
	Friend WithEvents btnUnused As Button
	Friend WithEvents btnUndoUs As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents dtEnd As DateTimePicker
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Button45 As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents setCoach As Button
	Friend WithEvents btnRemoveCoach As Button
	Friend WithEvents product As DataGridViewTextBoxColumn
	Friend WithEvents coach As DataGridViewTextBoxColumn
	Friend WithEvents quantity As DataGridViewTextBoxColumn
	Friend WithEvents dateReg As DataGridViewTextBoxColumn
	Friend WithEvents duration As DataGridViewTextBoxColumn
	Friend WithEvents EndDate As DataGridViewTextBoxColumn
	Friend WithEvents used As DataGridViewTextBoxColumn
	Friend WithEvents Column7 As DataGridViewTextBoxColumn
	Friend WithEvents id As DataGridViewTextBoxColumn
	Friend WithEvents Column11 As DataGridViewTextBoxColumn
	Friend WithEvents Column12 As DataGridViewTextBoxColumn
	Friend WithEvents Column13 As DataGridViewTextBoxColumn
	Friend WithEvents Column14 As DataGridViewTextBoxColumn
	Friend WithEvents st As DataGridViewTextBoxColumn
	Friend WithEvents amount As DataGridViewTextBoxColumn
	Friend WithEvents lblFP As Label
	Friend WithEvents lblUserId As Label
	Friend WithEvents UpdateFpInfoButton As Button
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents ComboBox4 As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents ComboBox6 As ComboBox
	Friend WithEvents Button1 As Button
	Friend WithEvents ComboBox8 As ComboBox
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents TextBox8 As TextBox
	Friend WithEvents DataView1 As DataView
	Friend WithEvents DataView2 As DataView
	Friend WithEvents Label19 As Label
	Friend WithEvents TextBox19 As TextBox
	Friend WithEvents Label20 As Label
	Friend WithEvents Button10 As Button
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Button13 As Button
	Friend WithEvents Button14 As Button
	Friend WithEvents Button21 As Button
	Friend WithEvents Label24 As Label
	Friend WithEvents addGuestOrder As Button
	Friend WithEvents TextBox21 As TextBox
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.cmbAdmin = New System.Windows.Forms.ComboBox()
		Me.Button10 = New System.Windows.Forms.Button()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.ComboBox4 = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.ComboBox6 = New System.Windows.Forms.ComboBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ComboBox8 = New System.Windows.Forms.ComboBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.DataView1 = New System.Data.DataView()
		Me.DataView2 = New System.Data.DataView()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.TextBox19 = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Button13 = New System.Windows.Forms.Button()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.TextBox21 = New System.Windows.Forms.TextBox()
		Me.Button23 = New System.Windows.Forms.Button()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Button25 = New System.Windows.Forms.Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label28 = New System.Windows.Forms.Label()
		Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.ComboBox7 = New System.Windows.Forms.ComboBox()
		Me.Button29 = New System.Windows.Forms.Button()
		Me.ComboBox15 = New System.Windows.Forms.ComboBox()
		Me.TextBox23 = New System.Windows.Forms.TextBox()
		Me.TextBox32 = New System.Windows.Forms.TextBox()
		Me.Button17 = New System.Windows.Forms.Button()
		Me.txtCardId = New System.Windows.Forms.TextBox()
		Me.txtPhone2 = New System.Windows.Forms.TextBox()
		Me.Disabled = New System.Windows.Forms.CheckBox()
		Me.chBoxAllow = New System.Windows.Forms.CheckBox()
		Me.tmp = New System.Windows.Forms.CheckBox()
		Me.chForgot = New System.Windows.Forms.CheckBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DeleteCheckInsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.cmbReason = New System.Windows.Forms.ComboBox()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.Label51 = New System.Windows.Forms.Label()
		Me.dtBornOn = New System.Windows.Forms.DateTimePicker()
		Me.Button53 = New System.Windows.Forms.Button()
		Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
		Me.lblUser = New System.Windows.Forms.Label()
		Me.txtUID = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Button26 = New System.Windows.Forms.Button()
		Me.txtFirst = New System.Windows.Forms.TextBox()
		Me.txtLast = New System.Windows.Forms.TextBox()
		Me.txtFind = New System.Windows.Forms.TextBox()
		Me.xStart = New System.Windows.Forms.TabPage()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.dtEnd = New System.Windows.Forms.DateTimePicker()
		Me.btnUndoUs = New System.Windows.Forms.Button()
		Me.btnUnused = New System.Windows.Forms.Button()
		Me.Button44 = New System.Windows.Forms.Button()
		Me.cmbPyMet = New System.Windows.Forms.ComboBox()
		Me.Button39 = New System.Windows.Forms.Button()
		Me.Button43 = New System.Windows.Forms.Button()
		Me.Button38 = New System.Windows.Forms.Button()
		Me.Button32 = New System.Windows.Forms.Button()
		Me.delUsed = New System.Windows.Forms.Button()
		Me.txtAmount = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.dgvUsage = New System.Windows.Forms.DataGridView()
		Me.usid = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.s = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Button30 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cmbProd = New System.Windows.Forms.ComboBox()
		Me.txtUsed = New System.Windows.Forms.TextBox()
		Me.txtFree = New System.Windows.Forms.TextBox()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.Label62 = New System.Windows.Forms.Label()
		Me.Label63 = New System.Windows.Forms.Label()
		Me.Label64 = New System.Windows.Forms.Label()
		Me.Label65 = New System.Windows.Forms.Label()
		Me.cmbCoach = New System.Windows.Forms.ComboBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnNew = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.txtClid = New System.Windows.Forms.TextBox()
		Me.txtCoachId = New System.Windows.Forms.TextBox()
		Me.Button18 = New System.Windows.Forms.Button()
		Me.dgw1 = New System.Windows.Forms.DataGridView()
		Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.coach = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dateReg = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.used = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.st = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtPrId = New System.Windows.Forms.TextBox()
		Me.clId = New System.Windows.Forms.TextBox()
		Me.guests = New System.Windows.Forms.TabPage()
		Me.addGuestOrder = New System.Windows.Forms.Button()
		Me.Button46 = New System.Windows.Forms.Button()
		Me.Button42 = New System.Windows.Forms.Button()
		Me.Button41 = New System.Windows.Forms.Button()
		Me.TextBox37 = New System.Windows.Forms.TextBox()
		Me.TextBox38 = New System.Windows.Forms.TextBox()
		Me.TextBox35 = New System.Windows.Forms.TextBox()
		Me.TextBox36 = New System.Windows.Forms.TextBox()
		Me.Label52 = New System.Windows.Forms.Label()
		Me.Label53 = New System.Windows.Forms.Label()
		Me.Label54 = New System.Windows.Forms.Label()
		Me.ComboBox19 = New System.Windows.Forms.ComboBox()
		Me.Button40 = New System.Windows.Forms.Button()
		Me.DataGridView6 = New System.Windows.Forms.DataGridView()
		Me.DataGridView5 = New System.Windows.Forms.DataGridView()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Label49 = New System.Windows.Forms.Label()
		Me.Label50 = New System.Windows.Forms.Label()
		Me.deposit = New System.Windows.Forms.TabPage()
		Me.Button55 = New System.Windows.Forms.Button()
		Me.Button54 = New System.Windows.Forms.Button()
		Me.Button52 = New System.Windows.Forms.Button()
		Me.Button48 = New System.Windows.Forms.Button()
		Me.Button47 = New System.Windows.Forms.Button()
		Me.TextBox26 = New System.Windows.Forms.TextBox()
		Me.TextBox24 = New System.Windows.Forms.TextBox()
		Me.txtId = New System.Windows.Forms.TextBox()
		Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
		Me.txtDeposit = New System.Windows.Forms.TextBox()
		Me.ComboBox17 = New System.Windows.Forms.ComboBox()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.Button34 = New System.Windows.Forms.Button()
		Me.cmbBasic = New System.Windows.Forms.ComboBox()
		Me.Button19 = New System.Windows.Forms.Button()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.cmbPurpose = New System.Windows.Forms.ComboBox()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.CmbMethode = New System.Windows.Forms.ComboBox()
		Me.payments = New System.Windows.Forms.TabPage()
		Me.DataGridView4 = New System.Windows.Forms.DataGridView()
		Me.debt = New System.Windows.Forms.TabPage()
		Me.DataGrid2 = New System.Windows.Forms.DataGrid()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.ComboBox10 = New System.Windows.Forms.ComboBox()
		Me.orders = New System.Windows.Forms.TabPage()
		Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
		Me.txtDays = New System.Windows.Forms.TextBox()
		Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
		Me.Button12 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button37 = New System.Windows.Forms.Button()
		Me.Button36 = New System.Windows.Forms.Button()
		Me.Button35 = New System.Windows.Forms.Button()
		Me.dgvOrders = New System.Windows.Forms.DataGridView()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox18 = New System.Windows.Forms.TextBox()
		Me.freezBalance = New System.Windows.Forms.TabPage()
		Me.Button49 = New System.Windows.Forms.Button()
		Me.DataGrid6 = New System.Windows.Forms.DataGrid()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.ComboBox16 = New System.Windows.Forms.ComboBox()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.frAmount = New System.Windows.Forms.TextBox()
		Me.frDays = New System.Windows.Forms.TextBox()
		Me.TextBox25 = New System.Windows.Forms.TextBox()
		Me.TextBox17 = New System.Windows.Forms.TextBox()
		Me.TextBox16 = New System.Windows.Forms.TextBox()
		Me.TextBox15 = New System.Windows.Forms.TextBox()
		Me.TextBox13 = New System.Windows.Forms.TextBox()
		Me.TextBox12 = New System.Windows.Forms.TextBox()
		Me.TextBox11 = New System.Windows.Forms.TextBox()
		Me.TextBox9 = New System.Windows.Forms.TextBox()
		Me.frPay = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.DataGrid8 = New System.Windows.Forms.DataGrid()
		Me.TextBox20 = New System.Windows.Forms.TextBox()
		Me.TextBox14 = New System.Windows.Forms.TextBox()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.details = New System.Windows.Forms.TabPage()
		Me.UpdateFpInfoButton = New System.Windows.Forms.Button()
		Me.lblFP = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCompany = New System.Windows.Forms.TextBox()
		Me.Button24 = New System.Windows.Forms.Button()
		Me.Button33 = New System.Windows.Forms.Button()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.Button56 = New System.Windows.Forms.Button()
		Me.Button28 = New System.Windows.Forms.Button()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.Button20 = New System.Windows.Forms.Button()
		Me.Button22 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtMail = New System.Windows.Forms.TextBox()
		Me.txtCustid = New System.Windows.Forms.TextBox()
		Me.txtManager = New System.Windows.Forms.TextBox()
		Me.txtGroup = New System.Windows.Forms.TextBox()
		Me.txtBorn = New System.Windows.Forms.MaskedTextBox()
		Me.Button16 = New System.Windows.Forms.Button()
		Me.admTools = New System.Windows.Forms.TabPage()
		Me.btnRemoveCoach = New System.Windows.Forms.Button()
		Me.setCoach = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Button45 = New System.Windows.Forms.Button()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.updAddress = New System.Windows.Forms.Button()
		Me.updCardId = New System.Windows.Forms.Button()
		Me.updFLname = New System.Windows.Forms.Button()
		Me.dgw = New System.Windows.Forms.DataGridView()
		Me.custid = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cardid = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MobilePhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cardtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Attachments = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BornOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ContactPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.TextBox22 = New System.Windows.Forms.TextBox()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.Button31 = New System.Windows.Forms.Button()
		Me.Button9 = New System.Windows.Forms.Button()
		Me.Button15 = New System.Windows.Forms.Button()
		Me.Button11 = New System.Windows.Forms.Button()
		Me.Button14 = New System.Windows.Forms.Button()
		Me.btnFindLF = New System.Windows.Forms.Button()
		Me.Button27 = New System.Windows.Forms.Button()
		Me.Button21 = New System.Windows.Forms.Button()
		Me.pView = New System.Windows.Forms.PictureBox()
		Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblUserId = New System.Windows.Forms.Label()
		CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BindingNavigator1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.xStart.SuspendLayout()
		CType(Me.dgvUsage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.guests.SuspendLayout()
		CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.deposit.SuspendLayout()
		Me.payments.SuspendLayout()
		CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.debt.SuspendLayout()
		CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.orders.SuspendLayout()
		CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.freezBalance.SuspendLayout()
		CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.details.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.admTools.SuspendLayout()
		CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button8
		'
		Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button8.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button8.Location = New System.Drawing.Point(1034, 89)
		Me.Button8.Margin = New System.Windows.Forms.Padding(2)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(85, 46)
		Me.Button8.TabIndex = 149
		Me.Button8.Text = "Deposit balance"
		Me.Button8.UseVisualStyleBackColor = False
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.LinkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen
		Me.LinkLabel1.Location = New System.Drawing.Point(1030, 32)
		Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(89, 24)
		Me.LinkLabel1.TabIndex = 164
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "Restoran"
		'
		'cmbAdmin
		'
		Me.cmbAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbAdmin.BackColor = System.Drawing.Color.WhiteSmoke
		Me.cmbAdmin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.cmbAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.cmbAdmin.FormattingEnabled = True
		Me.cmbAdmin.Location = New System.Drawing.Point(760, 226)
		Me.cmbAdmin.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbAdmin.Name = "cmbAdmin"
		Me.cmbAdmin.Size = New System.Drawing.Size(219, 26)
		Me.cmbAdmin.TabIndex = 166
		'
		'Button10
		'
		Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button10.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button10.Location = New System.Drawing.Point(935, 8)
		Me.Button10.Margin = New System.Windows.Forms.Padding(2)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(104, 32)
		Me.Button10.TabIndex = 33
		Me.Button10.Text = "Show All Attendance"
		'
		'ComboBox3
		'
		Me.ComboBox3.Location = New System.Drawing.Point(1210, 118)
		Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(212, 25)
		Me.ComboBox3.TabIndex = 3
		Me.ComboBox3.Visible = False
		'
		'ComboBox4
		'
		Me.ComboBox4.Location = New System.Drawing.Point(1210, 165)
		Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox4.Name = "ComboBox4"
		Me.ComboBox4.Size = New System.Drawing.Size(212, 25)
		Me.ComboBox4.TabIndex = 4
		Me.ComboBox4.Visible = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Label6.Location = New System.Drawing.Point(748, 114)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(105, 29)
		Me.Label6.TabIndex = 12
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
		Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.TextBox2.Location = New System.Drawing.Point(1310, 49)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(112, 24)
		Me.TextBox2.TabIndex = 13
		Me.TextBox2.Visible = False
		'
		'ComboBox6
		'
		Me.ComboBox6.Location = New System.Drawing.Point(1422, 118)
		Me.ComboBox6.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox6.Name = "ComboBox6"
		Me.ComboBox6.Size = New System.Drawing.Size(213, 25)
		Me.ComboBox6.TabIndex = 14
		Me.ComboBox6.Visible = False
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(1368, 382)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(112, 30)
		Me.Button1.TabIndex = 16
		Me.Button1.Text = "Refresh"
		Me.Button1.Visible = False
		'
		'ComboBox8
		'
		Me.ComboBox8.BackColor = System.Drawing.SystemColors.Control
		Me.ComboBox8.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.ComboBox8.Location = New System.Drawing.Point(1310, 19)
		Me.ComboBox8.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox8.Name = "ComboBox8"
		Me.ComboBox8.Size = New System.Drawing.Size(146, 25)
		Me.ComboBox8.TabIndex = 18
		Me.ComboBox8.Text = "ComboBox8"
		Me.ComboBox8.Visible = False
		'
		'TextBox6
		'
		Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
		Me.TextBox6.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.TextBox6.Location = New System.Drawing.Point(1322, 29)
		Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(123, 24)
		Me.TextBox6.TabIndex = 19
		Me.TextBox6.Text = "TextBox6"
		Me.TextBox6.Visible = False
		'
		'TextBox8
		'
		Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
		Me.TextBox8.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.TextBox8.Location = New System.Drawing.Point(1154, 10)
		Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.Size = New System.Drawing.Size(140, 24)
		Me.TextBox8.TabIndex = 21
		Me.TextBox8.Text = "TextBox8"
		Me.TextBox8.Visible = False
		'
		'Label19
		'
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label19.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label19.Location = New System.Drawing.Point(576, 26)
		Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(58, 28)
		Me.Label19.TabIndex = 26
		Me.Label19.Text = "Label19"
		Me.Label19.Visible = False
		'
		'TextBox19
		'
		Me.TextBox19.Location = New System.Drawing.Point(868, 91)
		Me.TextBox19.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox19.Name = "TextBox19"
		Me.TextBox19.Size = New System.Drawing.Size(213, 23)
		Me.TextBox19.TabIndex = 1
		'
		'Label20
		'
		Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label20.ForeColor = System.Drawing.Color.Black
		Me.Label20.Location = New System.Drawing.Point(110, 118)
		Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(268, 10)
		Me.Label20.TabIndex = 30
		Me.Label20.Text = "Email"
		Me.Label20.Visible = False
		'
		'RichTextBox1
		'
		Me.RichTextBox1.ForeColor = System.Drawing.Color.Maroon
		Me.RichTextBox1.Location = New System.Drawing.Point(162, 230)
		Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(379, 43)
		Me.RichTextBox1.TabIndex = 35
		Me.RichTextBox1.Text = ""
		'
		'Button13
		'
		Me.Button13.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button13.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button13.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button13.Location = New System.Drawing.Point(398, 332)
		Me.Button13.Margin = New System.Windows.Forms.Padding(2)
		Me.Button13.Name = "Button13"
		Me.Button13.Size = New System.Drawing.Size(142, 29)
		Me.Button13.TabIndex = 36
		Me.Button13.Text = "Update Manager"
		Me.Button13.UseVisualStyleBackColor = False
		'
		'Label24
		'
		Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label24.ForeColor = System.Drawing.Color.Red
		Me.Label24.Location = New System.Drawing.Point(881, 30)
		Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(112, 28)
		Me.Label24.TabIndex = 45
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'TextBox21
		'
		Me.TextBox21.Location = New System.Drawing.Point(1341, 685)
		Me.TextBox21.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox21.Name = "TextBox21"
		Me.TextBox21.Size = New System.Drawing.Size(58, 24)
		Me.TextBox21.TabIndex = 47
		Me.TextBox21.Text = "TextBox21"
		Me.TextBox21.Visible = False
		'
		'Button23
		'
		Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Button23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button23.ForeColor = System.Drawing.SystemColors.InfoText
		Me.Button23.Location = New System.Drawing.Point(1639, 651)
		Me.Button23.Margin = New System.Windows.Forms.Padding(2)
		Me.Button23.Name = "Button23"
		Me.Button23.Size = New System.Drawing.Size(75, 28)
		Me.Button23.TabIndex = 48
		Me.Button23.Text = "Refresh"
		Me.Button23.UseVisualStyleBackColor = True
		Me.Button23.Visible = False
		'
		'Label23
		'
		Me.Label23.ForeColor = System.Drawing.Color.Red
		Me.Label23.Location = New System.Drawing.Point(689, 238)
		Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(218, 19)
		Me.Label23.TabIndex = 51
		Me.Label23.Visible = False
		'
		'Button25
		'
		Me.Button25.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button25.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.Button25.Location = New System.Drawing.Point(391, 129)
		Me.Button25.Margin = New System.Windows.Forms.Padding(2)
		Me.Button25.Name = "Button25"
		Me.Button25.Size = New System.Drawing.Size(150, 29)
		Me.Button25.TabIndex = 59
		Me.Button25.Text = "Read UID"
		Me.Button25.UseVisualStyleBackColor = False
		'
		'Timer1
		'
		Me.Timer1.Interval = 10
		'
		'Label28
		'
		Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label28.ForeColor = System.Drawing.Color.Black
		Me.Label28.Location = New System.Drawing.Point(32, 89)
		Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(134, 19)
		Me.Label28.TabIndex = 65
		Me.Label28.Text = "Mobile Phone"
		Me.Label28.Visible = False
		'
		'BindingNavigator1
		'
		Me.BindingNavigator1.AddNewItem = Nothing
		Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
		Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
		Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
		Me.BindingNavigator1.Location = New System.Drawing.Point(819, 42)
		Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.BindingNavigator1.Name = "BindingNavigator1"
		Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
		Me.BindingNavigator1.Size = New System.Drawing.Size(291, 28)
		Me.BindingNavigator1.TabIndex = 72
		Me.BindingNavigator1.Text = "BindingNavigator1"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 25)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Enabled = False
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.081081!)
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(70, 28)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Enabled = False
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 25)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'ComboBox7
		'
		Me.ComboBox7.FormattingEnabled = True
		Me.ComboBox7.Location = New System.Drawing.Point(1639, 592)
		Me.ComboBox7.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox7.Name = "ComboBox7"
		Me.ComboBox7.Size = New System.Drawing.Size(93, 25)
		Me.ComboBox7.TabIndex = 73
		Me.ComboBox7.Visible = False
		'
		'Button29
		'
		Me.Button29.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button29.ForeColor = System.Drawing.Color.Black
		Me.Button29.Location = New System.Drawing.Point(225, 19)
		Me.Button29.Margin = New System.Windows.Forms.Padding(2)
		Me.Button29.Name = "Button29"
		Me.Button29.Size = New System.Drawing.Size(84, 28)
		Me.Button29.TabIndex = 75
		Me.Button29.Text = "Edit"
		Me.Button29.UseVisualStyleBackColor = False
		Me.Button29.Visible = False
		'
		'ComboBox15
		'
		Me.ComboBox15.FormattingEnabled = True
		Me.ComboBox15.Location = New System.Drawing.Point(391, 62)
		Me.ComboBox15.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox15.Name = "ComboBox15"
		Me.ComboBox15.Size = New System.Drawing.Size(150, 25)
		Me.ComboBox15.TabIndex = 77
		'
		'TextBox23
		'
		Me.TextBox23.Location = New System.Drawing.Point(25, 432)
		Me.TextBox23.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox23.Name = "TextBox23"
		Me.TextBox23.Size = New System.Drawing.Size(212, 23)
		Me.TextBox23.TabIndex = 80
		'
		'TextBox32
		'
		Me.TextBox32.Location = New System.Drawing.Point(21, 360)
		Me.TextBox32.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox32.Name = "TextBox32"
		Me.TextBox32.Size = New System.Drawing.Size(213, 23)
		Me.TextBox32.TabIndex = 91
		Me.TextBox32.Visible = False
		'
		'Button17
		'
		Me.Button17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button17.ForeColor = System.Drawing.Color.Black
		Me.Button17.Location = New System.Drawing.Point(178, 296)
		Me.Button17.Margin = New System.Windows.Forms.Padding(2)
		Me.Button17.Name = "Button17"
		Me.Button17.Size = New System.Drawing.Size(101, 34)
		Me.Button17.TabIndex = 39
		Me.Button17.Text = "Delete Photo"
		'
		'txtCardId
		'
		Me.txtCardId.BackColor = System.Drawing.Color.MintCream
		Me.txtCardId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtCardId.Location = New System.Drawing.Point(938, 34)
		Me.txtCardId.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCardId.Name = "txtCardId"
		Me.txtCardId.Size = New System.Drawing.Size(192, 27)
		Me.txtCardId.TabIndex = 93
		'
		'txtPhone2
		'
		Me.txtPhone2.BackColor = System.Drawing.Color.MintCream
		Me.txtPhone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtPhone2.Location = New System.Drawing.Point(164, 174)
		Me.txtPhone2.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPhone2.Name = "txtPhone2"
		Me.txtPhone2.Size = New System.Drawing.Size(209, 22)
		Me.txtPhone2.TabIndex = 97
		'
		'Disabled
		'
		Me.Disabled.AutoSize = True
		Me.Disabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Disabled.ForeColor = System.Drawing.Color.DarkRed
		Me.Disabled.Location = New System.Drawing.Point(408, 110)
		Me.Disabled.Margin = New System.Windows.Forms.Padding(2)
		Me.Disabled.Name = "Disabled"
		Me.Disabled.Size = New System.Drawing.Size(87, 21)
		Me.Disabled.TabIndex = 99
		Me.Disabled.Text = "Disabled"
		Me.Disabled.UseVisualStyleBackColor = True
		'
		'chBoxAllow
		'
		Me.chBoxAllow.AutoSize = True
		Me.chBoxAllow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.chBoxAllow.ForeColor = System.Drawing.Color.DarkRed
		Me.chBoxAllow.Location = New System.Drawing.Point(408, 144)
		Me.chBoxAllow.Margin = New System.Windows.Forms.Padding(2)
		Me.chBoxAllow.Name = "chBoxAllow"
		Me.chBoxAllow.Size = New System.Drawing.Size(109, 21)
		Me.chBoxAllow.TabIndex = 102
		Me.chBoxAllow.Text = "Allow Entry"
		Me.chBoxAllow.UseVisualStyleBackColor = True
		'
		'tmp
		'
		Me.tmp.AutoSize = True
		Me.tmp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.tmp.ForeColor = System.Drawing.Color.DarkRed
		Me.tmp.Location = New System.Drawing.Point(408, 172)
		Me.tmp.Margin = New System.Windows.Forms.Padding(2)
		Me.tmp.Name = "tmp"
		Me.tmp.Size = New System.Drawing.Size(132, 21)
		Me.tmp.TabIndex = 103
		Me.tmp.Text = "One Time Card"
		Me.tmp.UseVisualStyleBackColor = True
		'
		'chForgot
		'
		Me.chForgot.AutoSize = True
		Me.chForgot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.chForgot.ForeColor = System.Drawing.Color.DarkRed
		Me.chForgot.Location = New System.Drawing.Point(408, 206)
		Me.chForgot.Margin = New System.Windows.Forms.Padding(2)
		Me.chForgot.Name = "chForgot"
		Me.chForgot.Size = New System.Drawing.Size(114, 21)
		Me.chForgot.TabIndex = 110
		Me.chForgot.Text = "Forgot Card"
		Me.chForgot.UseVisualStyleBackColor = True
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.Red
		Me.Label16.Location = New System.Drawing.Point(732, 308)
		Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(0, 56)
		Me.Label16.TabIndex = 167
		'
		'LinkLabel2
		'
		Me.LinkLabel2.AutoSize = True
		Me.LinkLabel2.Location = New System.Drawing.Point(1302, 255)
		Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(71, 17)
		Me.LinkLabel2.TabIndex = 168
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "LinkLabel2"
		Me.LinkLabel2.Visible = False
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 893)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1924, 28)
		Me.MenuStrip1.TabIndex = 169
		Me.MenuStrip1.Text = "Administration Tools"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCheckInsToolStripMenuItem})
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(56, 24)
		Me.ToolStripMenuItem1.Text = "Tools"
		'
		'DeleteCheckInsToolStripMenuItem
		'
		Me.DeleteCheckInsToolStripMenuItem.Name = "DeleteCheckInsToolStripMenuItem"
		Me.DeleteCheckInsToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
		Me.DeleteCheckInsToolStripMenuItem.Text = "Delete CheckIns"
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Location = New System.Drawing.Point(18, 4)
		Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(55, 17)
		Me.Label38.TabIndex = 170
		Me.Label38.Text = "Label38"
		Me.Label38.Visible = False
		'
		'cmbReason
		'
		Me.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbReason.FormattingEnabled = True
		Me.cmbReason.Items.AddRange(New Object() {"To be Paid", "Paid", "Technical", "Photo/Birthday ...", "Dep.Lilit", "SPA", "Guest", "1Time", "Restoran", "Forgot", "New braslet", "Freezing"})
		Me.cmbReason.Location = New System.Drawing.Point(760, 259)
		Me.cmbReason.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbReason.Name = "cmbReason"
		Me.cmbReason.Size = New System.Drawing.Size(219, 25)
		Me.cmbReason.TabIndex = 171
		'
		'Label46
		'
		Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label46.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.Label46.Location = New System.Drawing.Point(658, 226)
		Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(74, 24)
		Me.Label46.TabIndex = 172
		Me.Label46.Text = "Admin"
		'
		'Label51
		'
		Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label51.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.Label51.Location = New System.Drawing.Point(658, 259)
		Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(74, 32)
		Me.Label51.TabIndex = 173
		Me.Label51.Text = "Reason"
		'
		'dtBornOn
		'
		Me.dtBornOn.CustomFormat = "dd/MM/yyyy"
		Me.dtBornOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtBornOn.Location = New System.Drawing.Point(391, 99)
		Me.dtBornOn.Margin = New System.Windows.Forms.Padding(2)
		Me.dtBornOn.Name = "dtBornOn"
		Me.dtBornOn.Size = New System.Drawing.Size(150, 23)
		Me.dtBornOn.TabIndex = 200
		'
		'Button53
		'
		Me.Button53.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button53.Location = New System.Drawing.Point(822, 8)
		Me.Button53.Margin = New System.Windows.Forms.Padding(2)
		Me.Button53.Name = "Button53"
		Me.Button53.Size = New System.Drawing.Size(106, 32)
		Me.Button53.TabIndex = 201
		Me.Button53.Text = "Show old attendance"
		Me.Button53.UseVisualStyleBackColor = True
		'
		'LinkLabel3
		'
		Me.LinkLabel3.AutoSize = True
		Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.LinkLabel3.LinkColor = System.Drawing.Color.LightSeaGreen
		Me.LinkLabel3.Location = New System.Drawing.Point(1030, 56)
		Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.LinkLabel3.Name = "LinkLabel3"
		Me.LinkLabel3.Size = New System.Drawing.Size(44, 24)
		Me.LinkLabel3.TabIndex = 202
		Me.LinkLabel3.TabStop = True
		Me.LinkLabel3.Text = "SPA"
		'
		'lblUser
		'
		Me.lblUser.AutoSize = True
		Me.lblUser.Location = New System.Drawing.Point(1744, 10)
		Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(47, 17)
		Me.lblUser.TabIndex = 203
		Me.lblUser.Text = "Label2"
		'
		'txtUID
		'
		Me.txtUID.BackColor = System.Drawing.Color.MintCream
		Me.txtUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtUID.Location = New System.Drawing.Point(162, 132)
		Me.txtUID.Margin = New System.Windows.Forms.Padding(2)
		Me.txtUID.Name = "txtUID"
		Me.txtUID.Size = New System.Drawing.Size(209, 22)
		Me.txtUID.TabIndex = 242
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(19, 925)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 24)
		Me.TextBox3.TabIndex = 241
		Me.TextBox3.Visible = False
		'
		'Button26
		'
		Me.Button26.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button26.Font = New System.Drawing.Font("Tahoma", 8.0!)
		Me.Button26.ForeColor = System.Drawing.Color.Black
		Me.Button26.Location = New System.Drawing.Point(678, 146)
		Me.Button26.Margin = New System.Windows.Forms.Padding(2)
		Me.Button26.Name = "Button26"
		Me.Button26.Size = New System.Drawing.Size(76, 42)
		Me.Button26.TabIndex = 239
		Me.Button26.Text = "Read UID"
		Me.Button26.UseVisualStyleBackColor = False
		'
		'txtFirst
		'
		Me.txtFirst.BackColor = System.Drawing.Color.MintCream
		Me.txtFirst.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtFirst.Location = New System.Drawing.Point(739, 68)
		Me.txtFirst.Margin = New System.Windows.Forms.Padding(2)
		Me.txtFirst.Name = "txtFirst"
		Me.txtFirst.Size = New System.Drawing.Size(192, 28)
		Me.txtFirst.TabIndex = 238
		'
		'txtLast
		'
		Me.txtLast.BackColor = System.Drawing.Color.MintCream
		Me.txtLast.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtLast.Location = New System.Drawing.Point(938, 68)
		Me.txtLast.Margin = New System.Windows.Forms.Padding(2)
		Me.txtLast.Name = "txtLast"
		Me.txtLast.Size = New System.Drawing.Size(192, 28)
		Me.txtLast.TabIndex = 237
		'
		'txtFind
		'
		Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtFind.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtFind.Location = New System.Drawing.Point(760, 159)
		Me.txtFind.Margin = New System.Windows.Forms.Padding(2)
		Me.txtFind.Name = "txtFind"
		Me.txtFind.Size = New System.Drawing.Size(220, 26)
		Me.txtFind.TabIndex = 234
		'
		'xStart
		'
		Me.xStart.Controls.Add(Me.Label7)
		Me.xStart.Controls.Add(Me.dtEnd)
		Me.xStart.Controls.Add(Me.btnUndoUs)
		Me.xStart.Controls.Add(Me.btnUnused)
		Me.xStart.Controls.Add(Me.Button44)
		Me.xStart.Controls.Add(Me.cmbPyMet)
		Me.xStart.Controls.Add(Me.Button39)
		Me.xStart.Controls.Add(Me.Button43)
		Me.xStart.Controls.Add(Me.Button38)
		Me.xStart.Controls.Add(Me.Button32)
		Me.xStart.Controls.Add(Me.delUsed)
		Me.xStart.Controls.Add(Me.txtAmount)
		Me.xStart.Controls.Add(Me.Label4)
		Me.xStart.Controls.Add(Me.dgvUsage)
		Me.xStart.Controls.Add(Me.Button30)
		Me.xStart.Controls.Add(Me.Label2)
		Me.xStart.Controls.Add(Me.cmbProd)
		Me.xStart.Controls.Add(Me.txtUsed)
		Me.xStart.Controls.Add(Me.txtFree)
		Me.xStart.Controls.Add(Me.dtpDate)
		Me.xStart.Controls.Add(Me.Label62)
		Me.xStart.Controls.Add(Me.Label63)
		Me.xStart.Controls.Add(Me.Label64)
		Me.xStart.Controls.Add(Me.Label65)
		Me.xStart.Controls.Add(Me.cmbCoach)
		Me.xStart.Controls.Add(Me.btnDelete)
		Me.xStart.Controls.Add(Me.btnUpdate)
		Me.xStart.Controls.Add(Me.btnNew)
		Me.xStart.Controls.Add(Me.btnSave)
		Me.xStart.Controls.Add(Me.txtClid)
		Me.xStart.Controls.Add(Me.txtCoachId)
		Me.xStart.Controls.Add(Me.Button18)
		Me.xStart.Controls.Add(Me.dgw1)
		Me.xStart.Controls.Add(Me.txtPrId)
		Me.xStart.Controls.Add(Me.clId)
		Me.xStart.Location = New System.Drawing.Point(4, 26)
		Me.xStart.Margin = New System.Windows.Forms.Padding(2)
		Me.xStart.Name = "xStart"
		Me.xStart.Padding = New System.Windows.Forms.Padding(2)
		Me.xStart.Size = New System.Drawing.Size(1192, 539)
		Me.xStart.TabIndex = 12
		Me.xStart.Text = "CLIP CARDS"
		Me.xStart.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(246, 179)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(33, 17)
		Me.Label7.TabIndex = 237
		Me.Label7.Text = "To :"
		'
		'dtEnd
		'
		Me.dtEnd.CustomFormat = "dd/MM/yyyy"
		Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtEnd.Location = New System.Drawing.Point(282, 172)
		Me.dtEnd.Margin = New System.Windows.Forms.Padding(2)
		Me.dtEnd.Name = "dtEnd"
		Me.dtEnd.Size = New System.Drawing.Size(135, 23)
		Me.dtEnd.TabIndex = 236
		'
		'btnUndoUs
		'
		Me.btnUndoUs.Location = New System.Drawing.Point(904, 200)
		Me.btnUndoUs.Margin = New System.Windows.Forms.Padding(4)
		Me.btnUndoUs.Name = "btnUndoUs"
		Me.btnUndoUs.Size = New System.Drawing.Size(116, 26)
		Me.btnUndoUs.TabIndex = 235
		Me.btnUndoUs.Text = "Undo Unused"
		Me.btnUndoUs.UseVisualStyleBackColor = True
		'
		'btnUnused
		'
		Me.btnUnused.Location = New System.Drawing.Point(904, 162)
		Me.btnUnused.Margin = New System.Windows.Forms.Padding(4)
		Me.btnUnused.Name = "btnUnused"
		Me.btnUnused.Size = New System.Drawing.Size(116, 26)
		Me.btnUnused.TabIndex = 234
		Me.btnUnused.Text = "Unused"
		Me.btnUnused.UseVisualStyleBackColor = True
		'
		'Button44
		'
		Me.Button44.Enabled = False
		Me.Button44.Location = New System.Drawing.Point(551, 15)
		Me.Button44.Margin = New System.Windows.Forms.Padding(4)
		Me.Button44.Name = "Button44"
		Me.Button44.Size = New System.Drawing.Size(131, 29)
		Me.Button44.TabIndex = 233
		Me.Button44.Text = "Pay&Print Check"
		Me.Button44.UseVisualStyleBackColor = True
		'
		'cmbPyMet
		'
		Me.cmbPyMet.Items.AddRange(New Object() {"Cash", "POS"})
		Me.cmbPyMet.Location = New System.Drawing.Point(550, 52)
		Me.cmbPyMet.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbPyMet.Name = "cmbPyMet"
		Me.cmbPyMet.Size = New System.Drawing.Size(133, 25)
		Me.cmbPyMet.TabIndex = 232
		Me.cmbPyMet.Text = "Cash"
		'
		'Button39
		'
		Me.Button39.Location = New System.Drawing.Point(1042, 122)
		Me.Button39.Margin = New System.Windows.Forms.Padding(2)
		Me.Button39.Name = "Button39"
		Me.Button39.Size = New System.Drawing.Size(142, 35)
		Me.Button39.TabIndex = 231
		Me.Button39.Text = "Undo delete"
		Me.Button39.UseVisualStyleBackColor = True
		'
		'Button43
		'
		Me.Button43.Location = New System.Drawing.Point(1042, 79)
		Me.Button43.Margin = New System.Windows.Forms.Padding(2)
		Me.Button43.Name = "Button43"
		Me.Button43.Size = New System.Drawing.Size(142, 35)
		Me.Button43.TabIndex = 230
		Me.Button43.Text = "Mark as deleted"
		Me.Button43.UseVisualStyleBackColor = True
		'
		'Button38
		'
		Me.Button38.Location = New System.Drawing.Point(445, 195)
		Me.Button38.Margin = New System.Windows.Forms.Padding(2)
		Me.Button38.Name = "Button38"
		Me.Button38.Size = New System.Drawing.Size(142, 35)
		Me.Button38.TabIndex = 229
		Me.Button38.Text = "Undo delete"
		Me.Button38.UseVisualStyleBackColor = True
		'
		'Button32
		'
		Me.Button32.Location = New System.Drawing.Point(445, 162)
		Me.Button32.Margin = New System.Windows.Forms.Padding(2)
		Me.Button32.Name = "Button32"
		Me.Button32.Size = New System.Drawing.Size(142, 35)
		Me.Button32.TabIndex = 228
		Me.Button32.Text = "Mark as deleted"
		Me.Button32.UseVisualStyleBackColor = True
		'
		'delUsed
		'
		Me.delUsed.Location = New System.Drawing.Point(1042, 172)
		Me.delUsed.Margin = New System.Windows.Forms.Padding(2)
		Me.delUsed.Name = "delUsed"
		Me.delUsed.Size = New System.Drawing.Size(142, 35)
		Me.delUsed.TabIndex = 227
		Me.delUsed.Text = "Delete Usage"
		Me.delUsed.UseVisualStyleBackColor = True
		'
		'txtAmount
		'
		Me.txtAmount.BackColor = System.Drawing.Color.White
		Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAmount.Location = New System.Drawing.Point(105, 209)
		Me.txtAmount.Margin = New System.Windows.Forms.Padding(2)
		Me.txtAmount.Name = "txtAmount"
		Me.txtAmount.Size = New System.Drawing.Size(312, 24)
		Me.txtAmount.TabIndex = 225
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(29, 212)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 226
		Me.Label4.Text = "Amount:"
		'
		'dgvUsage
		'
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
		Me.dgvUsage.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvUsage.BackgroundColor = System.Drawing.Color.White
		Me.dgvUsage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvUsage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usid, Me.Column9, Me.Column10, Me.s})
		Me.dgvUsage.Location = New System.Drawing.Point(689, 1)
		Me.dgvUsage.Margin = New System.Windows.Forms.Padding(2)
		Me.dgvUsage.MultiSelect = False
		Me.dgvUsage.Name = "dgvUsage"
		Me.dgvUsage.RowHeadersWidth = 47
		Me.dgvUsage.Size = New System.Drawing.Size(331, 228)
		Me.dgvUsage.TabIndex = 222
		'
		'usid
		'
		Me.usid.HeaderText = "usid"
		Me.usid.MinimumWidth = 6
		Me.usid.Name = "usid"
		Me.usid.Width = 116
		'
		'Column9
		'
		Me.Column9.HeaderText = "clid"
		Me.Column9.MinimumWidth = 6
		Me.Column9.Name = "Column9"
		Me.Column9.Visible = False
		Me.Column9.Width = 116
		'
		'Column10
		'
		Me.Column10.HeaderText = "Usage date"
		Me.Column10.MinimumWidth = 6
		Me.Column10.Name = "Column10"
		Me.Column10.Width = 116
		'
		's
		'
		Me.s.HeaderText = "st"
		Me.s.MinimumWidth = 6
		Me.s.Name = "s"
		Me.s.Visible = False
		Me.s.Width = 116
		'
		'Button30
		'
		Me.Button30.ForeColor = System.Drawing.Color.Red
		Me.Button30.Location = New System.Drawing.Point(1038, 4)
		Me.Button30.Margin = New System.Windows.Forms.Padding(2)
		Me.Button30.Name = "Button30"
		Me.Button30.Size = New System.Drawing.Size(148, 39)
		Me.Button30.TabIndex = 221
		Me.Button30.Text = "Print Ticket(-1)"
		Me.Button30.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(29, 29)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.TabIndex = 217
		Me.Label2.Text = "Product :"
		'
		'cmbProd
		'
		Me.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbProd.FormattingEnabled = True
		Me.cmbProd.Location = New System.Drawing.Point(105, 19)
		Me.cmbProd.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbProd.Name = "cmbProd"
		Me.cmbProd.Size = New System.Drawing.Size(312, 25)
		Me.cmbProd.TabIndex = 216
		'
		'txtUsed
		'
		Me.txtUsed.BackColor = System.Drawing.Color.White
		Me.txtUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsed.Location = New System.Drawing.Point(106, 131)
		Me.txtUsed.Margin = New System.Windows.Forms.Padding(2)
		Me.txtUsed.Name = "txtUsed"
		Me.txtUsed.Size = New System.Drawing.Size(312, 24)
		Me.txtUsed.TabIndex = 209
		Me.txtUsed.Text = "0"
		'
		'txtFree
		'
		Me.txtFree.BackColor = System.Drawing.Color.White
		Me.txtFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFree.Location = New System.Drawing.Point(106, 92)
		Me.txtFree.Margin = New System.Windows.Forms.Padding(2)
		Me.txtFree.Name = "txtFree"
		Me.txtFree.Size = New System.Drawing.Size(312, 24)
		Me.txtFree.TabIndex = 207
		'
		'dtpDate
		'
		Me.dtpDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDate.Location = New System.Drawing.Point(106, 172)
		Me.dtpDate.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(135, 23)
		Me.dtpDate.TabIndex = 214
		'
		'Label62
		'
		Me.Label62.AutoSize = True
		Me.Label62.Location = New System.Drawing.Point(31, 64)
		Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label62.Name = "Label62"
		Me.Label62.Size = New System.Drawing.Size(53, 17)
		Me.Label62.TabIndex = 210
		Me.Label62.Text = "Name :"
		'
		'Label63
		'
		Me.Label63.AutoSize = True
		Me.Label63.Location = New System.Drawing.Point(31, 102)
		Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label63.Name = "Label63"
		Me.Label63.Size = New System.Drawing.Size(69, 17)
		Me.Label63.TabIndex = 211
		Me.Label63.Text = "Quantity :"
		'
		'Label64
		'
		Me.Label64.AutoSize = True
		Me.Label64.Location = New System.Drawing.Point(31, 142)
		Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label64.Name = "Label64"
		Me.Label64.Size = New System.Drawing.Size(70, 17)
		Me.Label64.TabIndex = 212
		Me.Label64.Text = "Duration :"
		'
		'Label65
		'
		Me.Label65.AutoSize = True
		Me.Label65.Location = New System.Drawing.Point(31, 181)
		Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label65.Name = "Label65"
		Me.Label65.Size = New System.Drawing.Size(46, 17)
		Me.Label65.TabIndex = 213
		Me.Label65.Text = "Date :"
		'
		'cmbCoach
		'
		Me.cmbCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCoach.FormattingEnabled = True
		Me.cmbCoach.Location = New System.Drawing.Point(106, 55)
		Me.cmbCoach.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbCoach.Name = "cmbCoach"
		Me.cmbCoach.Size = New System.Drawing.Size(312, 25)
		Me.cmbCoach.TabIndex = 204
		'
		'btnDelete
		'
		Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
		Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnDelete.Location = New System.Drawing.Point(445, 128)
		Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(99, 35)
		Me.btnDelete.TabIndex = 208
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
		Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnUpdate.Location = New System.Drawing.Point(445, 91)
		Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(99, 35)
		Me.btnUpdate.TabIndex = 206
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'btnNew
		'
		Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
		Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnNew.Location = New System.Drawing.Point(445, 12)
		Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(99, 35)
		Me.btnNew.TabIndex = 201
		Me.btnNew.Text = "New"
		Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnNew.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
		Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSave.Location = New System.Drawing.Point(445, 50)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(99, 35)
		Me.btnSave.TabIndex = 203
		Me.btnSave.Text = "Save"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'txtClid
		'
		Me.txtClid.Location = New System.Drawing.Point(1084, 285)
		Me.txtClid.Margin = New System.Windows.Forms.Padding(2)
		Me.txtClid.Name = "txtClid"
		Me.txtClid.Size = New System.Drawing.Size(102, 23)
		Me.txtClid.TabIndex = 220
		'
		'txtCoachId
		'
		Me.txtCoachId.Location = New System.Drawing.Point(1084, 456)
		Me.txtCoachId.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCoachId.Name = "txtCoachId"
		Me.txtCoachId.Size = New System.Drawing.Size(63, 23)
		Me.txtCoachId.TabIndex = 219
		'
		'Button18
		'
		Me.Button18.Location = New System.Drawing.Point(1084, 6)
		Me.Button18.Margin = New System.Windows.Forms.Padding(2)
		Me.Button18.Name = "Button18"
		Me.Button18.Size = New System.Drawing.Size(105, 35)
		Me.Button18.TabIndex = 224
		Me.Button18.Text = "Print preview"
		Me.Button18.UseVisualStyleBackColor = True
		Me.Button18.Visible = False
		'
		'dgw1
		'
		Me.dgw1.AllowUserToAddRows = False
		Me.dgw1.AllowUserToDeleteRows = False
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite
		Me.dgw1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
		Me.dgw1.BackgroundColor = System.Drawing.Color.White
		Me.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgw1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgw1.ColumnHeadersHeight = 24
		Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product, Me.coach, Me.quantity, Me.dateReg, Me.duration, Me.EndDate, Me.used, Me.Column7, Me.id, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.st, Me.amount})
		Me.dgw1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.dgw1.EnableHeadersVisualStyles = False
		Me.dgw1.GridColor = System.Drawing.Color.White
		Me.dgw1.Location = New System.Drawing.Point(0, 239)
		Me.dgw1.Margin = New System.Windows.Forms.Padding(2)
		Me.dgw1.MultiSelect = False
		Me.dgw1.Name = "dgw1"
		Me.dgw1.ReadOnly = True
		Me.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgw1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgw1.RowHeadersWidth = 25
		Me.dgw1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
		Me.dgw1.RowsDefaultCellStyle = DataGridViewCellStyle5
		Me.dgw1.RowTemplate.Height = 18
		Me.dgw1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgw1.Size = New System.Drawing.Size(1056, 242)
		Me.dgw1.TabIndex = 205
		'
		'product
		'
		Me.product.HeaderText = "Product"
		Me.product.MinimumWidth = 6
		Me.product.Name = "product"
		Me.product.ReadOnly = True
		Me.product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.product.Width = 58
		'
		'coach
		'
		Me.coach.HeaderText = "Coach"
		Me.coach.MinimumWidth = 6
		Me.coach.Name = "coach"
		Me.coach.ReadOnly = True
		Me.coach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.coach.Width = 51
		'
		'quantity
		'
		Me.quantity.HeaderText = "Quantity"
		Me.quantity.MinimumWidth = 6
		Me.quantity.Name = "quantity"
		Me.quantity.ReadOnly = True
		Me.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.quantity.Width = 60
		'
		'dateReg
		'
		Me.dateReg.HeaderText = "Date Registration"
		Me.dateReg.MinimumWidth = 6
		Me.dateReg.Name = "dateReg"
		Me.dateReg.ReadOnly = True
		Me.dateReg.Width = 139
		'
		'duration
		'
		Me.duration.HeaderText = "Duration"
		Me.duration.MinimumWidth = 6
		Me.duration.Name = "duration"
		Me.duration.ReadOnly = True
		Me.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.duration.Width = 62
		'
		'EndDate
		'
		Me.EndDate.HeaderText = "End Date"
		Me.EndDate.MinimumWidth = 6
		Me.EndDate.Name = "EndDate"
		Me.EndDate.ReadOnly = True
		Me.EndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.EndDate.Width = 68
		'
		'used
		'
		Me.used.HeaderText = "Used"
		Me.used.MinimumWidth = 6
		Me.used.Name = "used"
		Me.used.ReadOnly = True
		Me.used.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.used.Width = 45
		'
		'Column7
		'
		Me.Column7.HeaderText = "Balance"
		Me.Column7.MinimumWidth = 6
		Me.Column7.Name = "Column7"
		Me.Column7.ReadOnly = True
		Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Column7.Width = 62
		'
		'id
		'
		Me.id.HeaderText = "id"
		Me.id.MinimumWidth = 6
		Me.id.Name = "id"
		Me.id.ReadOnly = True
		Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.id.Width = 23
		'
		'Column11
		'
		Me.Column11.HeaderText = "Column11"
		Me.Column11.MinimumWidth = 6
		Me.Column11.Name = "Column11"
		Me.Column11.ReadOnly = True
		Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Column11.Visible = False
		Me.Column11.Width = 72
		'
		'Column12
		'
		Me.Column12.HeaderText = "Column12"
		Me.Column12.MinimumWidth = 6
		Me.Column12.Name = "Column12"
		Me.Column12.ReadOnly = True
		Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Column12.Visible = False
		Me.Column12.Width = 72
		'
		'Column13
		'
		Me.Column13.HeaderText = "Column13"
		Me.Column13.MinimumWidth = 6
		Me.Column13.Name = "Column13"
		Me.Column13.ReadOnly = True
		Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Column13.Visible = False
		Me.Column13.Width = 72
		'
		'Column14
		'
		Me.Column14.HeaderText = "Column14"
		Me.Column14.MinimumWidth = 6
		Me.Column14.Name = "Column14"
		Me.Column14.ReadOnly = True
		Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.Column14.Visible = False
		Me.Column14.Width = 72
		'
		'st
		'
		Me.st.HeaderText = "Status"
		Me.st.MinimumWidth = 6
		Me.st.Name = "st"
		Me.st.ReadOnly = True
		Me.st.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.st.Width = 49
		'
		'amount
		'
		Me.amount.HeaderText = "Amount"
		Me.amount.MinimumWidth = 6
		Me.amount.Name = "amount"
		Me.amount.ReadOnly = True
		Me.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.amount.Width = 57
		'
		'txtPrId
		'
		Me.txtPrId.Location = New System.Drawing.Point(931, 268)
		Me.txtPrId.Margin = New System.Windows.Forms.Padding(2)
		Me.txtPrId.Name = "txtPrId"
		Me.txtPrId.Size = New System.Drawing.Size(63, 23)
		Me.txtPrId.TabIndex = 218
		'
		'clId
		'
		Me.clId.Location = New System.Drawing.Point(979, 336)
		Me.clId.Margin = New System.Windows.Forms.Padding(2)
		Me.clId.Name = "clId"
		Me.clId.Size = New System.Drawing.Size(76, 23)
		Me.clId.TabIndex = 215
		'
		'guests
		'
		Me.guests.Controls.Add(Me.addGuestOrder)
		Me.guests.Controls.Add(Me.Button46)
		Me.guests.Controls.Add(Me.Button42)
		Me.guests.Controls.Add(Me.Button41)
		Me.guests.Controls.Add(Me.TextBox37)
		Me.guests.Controls.Add(Me.TextBox38)
		Me.guests.Controls.Add(Me.TextBox35)
		Me.guests.Controls.Add(Me.TextBox36)
		Me.guests.Controls.Add(Me.Label52)
		Me.guests.Controls.Add(Me.Label53)
		Me.guests.Controls.Add(Me.Label54)
		Me.guests.Controls.Add(Me.ComboBox19)
		Me.guests.Controls.Add(Me.Button40)
		Me.guests.Controls.Add(Me.DataGridView6)
		Me.guests.Controls.Add(Me.DataGridView5)
		Me.guests.Controls.Add(Me.Button7)
		Me.guests.Controls.Add(Me.Label49)
		Me.guests.Controls.Add(Me.Label50)
		Me.guests.Controls.Add(Me.TextBox19)
		Me.guests.Location = New System.Drawing.Point(4, 26)
		Me.guests.Margin = New System.Windows.Forms.Padding(2)
		Me.guests.Name = "guests"
		Me.guests.Padding = New System.Windows.Forms.Padding(2)
		Me.guests.Size = New System.Drawing.Size(1192, 539)
		Me.guests.TabIndex = 10
		Me.guests.Text = "GUESTS"
		Me.guests.UseVisualStyleBackColor = True
		'
		'addGuestOrder
		'
		Me.addGuestOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.addGuestOrder.Image = Global.OrangeGantner.My.Resources.Resources._1
		Me.addGuestOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.addGuestOrder.Location = New System.Drawing.Point(706, 76)
		Me.addGuestOrder.Margin = New System.Windows.Forms.Padding(2)
		Me.addGuestOrder.Name = "addGuestOrder"
		Me.addGuestOrder.Size = New System.Drawing.Size(105, 38)
		Me.addGuestOrder.TabIndex = 190
		Me.addGuestOrder.Text = "GUESTS"
		Me.addGuestOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.addGuestOrder.UseVisualStyleBackColor = True
		'
		'Button46
		'
		Me.Button46.Location = New System.Drawing.Point(206, 89)
		Me.Button46.Margin = New System.Windows.Forms.Padding(2)
		Me.Button46.Name = "Button46"
		Me.Button46.Size = New System.Drawing.Size(135, 28)
		Me.Button46.TabIndex = 189
		Me.Button46.Text = "the same  Guest"
		Me.Button46.UseVisualStyleBackColor = True
		'
		'Button42
		'
		Me.Button42.Location = New System.Drawing.Point(511, 89)
		Me.Button42.Margin = New System.Windows.Forms.Padding(2)
		Me.Button42.Name = "Button42"
		Me.Button42.Size = New System.Drawing.Size(105, 28)
		Me.Button42.TabIndex = 188
		Me.Button42.Text = "Edit Free"
		Me.Button42.UseVisualStyleBackColor = True
		'
		'Button41
		'
		Me.Button41.Location = New System.Drawing.Point(378, 89)
		Me.Button41.Margin = New System.Windows.Forms.Padding(2)
		Me.Button41.Name = "Button41"
		Me.Button41.Size = New System.Drawing.Size(105, 28)
		Me.Button41.TabIndex = 187
		Me.Button41.Text = "Delete Guest"
		Me.Button41.UseVisualStyleBackColor = True
		'
		'TextBox37
		'
		Me.TextBox37.Location = New System.Drawing.Point(351, 44)
		Me.TextBox37.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox37.Name = "TextBox37"
		Me.TextBox37.Size = New System.Drawing.Size(115, 23)
		Me.TextBox37.TabIndex = 186
		Me.TextBox37.Text = "1"
		'
		'TextBox38
		'
		Me.TextBox38.Location = New System.Drawing.Point(351, 9)
		Me.TextBox38.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox38.Name = "TextBox38"
		Me.TextBox38.Size = New System.Drawing.Size(115, 23)
		Me.TextBox38.TabIndex = 182
		Me.TextBox38.Text = "15000"
		'
		'TextBox35
		'
		Me.TextBox35.Location = New System.Drawing.Point(868, 49)
		Me.TextBox35.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox35.Name = "TextBox35"
		Me.TextBox35.Size = New System.Drawing.Size(213, 23)
		Me.TextBox35.TabIndex = 99
		'
		'TextBox36
		'
		Me.TextBox36.Location = New System.Drawing.Point(868, 12)
		Me.TextBox36.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox36.Name = "TextBox36"
		Me.TextBox36.Size = New System.Drawing.Size(213, 23)
		Me.TextBox36.TabIndex = 98
		'
		'Label52
		'
		Me.Label52.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label52.Location = New System.Drawing.Point(202, 44)
		Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label52.Name = "Label52"
		Me.Label52.Size = New System.Drawing.Size(81, 19)
		Me.Label52.TabIndex = 185
		Me.Label52.Text = "Quantity"
		'
		'Label53
		'
		Me.Label53.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label53.Location = New System.Drawing.Point(202, 9)
		Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(81, 19)
		Me.Label53.TabIndex = 181
		Me.Label53.Text = "Amount"
		'
		'Label54
		'
		Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label54.Location = New System.Drawing.Point(18, 11)
		Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label54.Name = "Label54"
		Me.Label54.Size = New System.Drawing.Size(131, 22)
		Me.Label54.TabIndex = 184
		Me.Label54.Text = "Payment Methode"
		'
		'ComboBox19
		'
		Me.ComboBox19.Items.AddRange(New Object() {"Cash", "POS"})
		Me.ComboBox19.Location = New System.Drawing.Point(28, 36)
		Me.ComboBox19.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox19.Name = "ComboBox19"
		Me.ComboBox19.Size = New System.Drawing.Size(119, 25)
		Me.ComboBox19.TabIndex = 183
		Me.ComboBox19.Text = "Cash"
		'
		'Button40
		'
		Me.Button40.Enabled = False
		Me.Button40.Location = New System.Drawing.Point(535, 40)
		Me.Button40.Margin = New System.Windows.Forms.Padding(2)
		Me.Button40.Name = "Button40"
		Me.Button40.Size = New System.Drawing.Size(118, 28)
		Me.Button40.TabIndex = 103
		Me.Button40.Text = "Add Payment"
		Me.Button40.UseVisualStyleBackColor = True
		'
		'DataGridView6
		'
		Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView6.Location = New System.Drawing.Point(696, 151)
		Me.DataGridView6.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGridView6.Name = "DataGridView6"
		Me.DataGridView6.RowHeadersWidth = 47
		Me.DataGridView6.Size = New System.Drawing.Size(489, 370)
		Me.DataGridView6.TabIndex = 102
		'
		'DataGridView5
		'
		Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView5.Location = New System.Drawing.Point(40, 151)
		Me.DataGridView5.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGridView5.Name = "DataGridView5"
		Me.DataGridView5.RowHeadersWidth = 47
		Me.DataGridView5.Size = New System.Drawing.Size(651, 249)
		Me.DataGridView5.TabIndex = 101
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(40, 89)
		Me.Button7.Margin = New System.Windows.Forms.Padding(2)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(134, 28)
		Me.Button7.TabIndex = 100
		Me.Button7.Text = "Add New  Guest"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Label49
		'
		Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label49.ForeColor = System.Drawing.Color.DarkBlue
		Me.Label49.Location = New System.Drawing.Point(725, 44)
		Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(135, 19)
		Me.Label49.TabIndex = 97
		Me.Label49.Text = "LastName"
		'
		'Label50
		'
		Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label50.ForeColor = System.Drawing.Color.DarkBlue
		Me.Label50.Location = New System.Drawing.Point(725, 12)
		Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(135, 19)
		Me.Label50.TabIndex = 96
		Me.Label50.Text = "FirstName"
		'
		'deposit
		'
		Me.deposit.BackColor = System.Drawing.Color.White
		Me.deposit.Controls.Add(Me.Button55)
		Me.deposit.Controls.Add(Me.Button54)
		Me.deposit.Controls.Add(Me.Button52)
		Me.deposit.Controls.Add(Me.Button48)
		Me.deposit.Controls.Add(Me.Button47)
		Me.deposit.Controls.Add(Me.TextBox26)
		Me.deposit.Controls.Add(Me.TextBox24)
		Me.deposit.Controls.Add(Me.txtId)
		Me.deposit.Controls.Add(Me.RichTextBox3)
		Me.deposit.Controls.Add(Me.txtDeposit)
		Me.deposit.Controls.Add(Me.ComboBox17)
		Me.deposit.Controls.Add(Me.Label41)
		Me.deposit.Controls.Add(Me.Label40)
		Me.deposit.Controls.Add(Me.Button34)
		Me.deposit.Controls.Add(Me.cmbBasic)
		Me.deposit.Controls.Add(Me.Button19)
		Me.deposit.Controls.Add(Me.Label21)
		Me.deposit.Controls.Add(Me.Label30)
		Me.deposit.Controls.Add(Me.cmbPurpose)
		Me.deposit.Controls.Add(Me.Label31)
		Me.deposit.Controls.Add(Me.Label32)
		Me.deposit.Controls.Add(Me.Label33)
		Me.deposit.Controls.Add(Me.CmbMethode)
		Me.deposit.Controls.Add(Me.LinkLabel3)
		Me.deposit.Controls.Add(Me.Button8)
		Me.deposit.Controls.Add(Me.LinkLabel1)
		Me.deposit.Location = New System.Drawing.Point(4, 26)
		Me.deposit.Margin = New System.Windows.Forms.Padding(2)
		Me.deposit.Name = "deposit"
		Me.deposit.Size = New System.Drawing.Size(1192, 539)
		Me.deposit.TabIndex = 8
		Me.deposit.Text = "DEPOSIT"
		'
		'Button55
		'
		Me.Button55.Location = New System.Drawing.Point(524, 205)
		Me.Button55.Margin = New System.Windows.Forms.Padding(2)
		Me.Button55.Name = "Button55"
		Me.Button55.Size = New System.Drawing.Size(182, 26)
		Me.Button55.TabIndex = 174
		Me.Button55.Text = "Save Deposit SPA"
		Me.Button55.UseVisualStyleBackColor = True
		'
		'Button54
		'
		Me.Button54.Location = New System.Drawing.Point(524, 82)
		Me.Button54.Margin = New System.Windows.Forms.Padding(2)
		Me.Button54.Name = "Button54"
		Me.Button54.Size = New System.Drawing.Size(182, 46)
		Me.Button54.TabIndex = 173
		Me.Button54.Text = "Subtract from  Deposit SPA"
		Me.Button54.UseVisualStyleBackColor = True
		'
		'Button52
		'
		Me.Button52.Location = New System.Drawing.Point(524, 30)
		Me.Button52.Margin = New System.Windows.Forms.Padding(2)
		Me.Button52.Name = "Button52"
		Me.Button52.Size = New System.Drawing.Size(182, 48)
		Me.Button52.TabIndex = 172
		Me.Button52.Text = "Subtract from  Deposit Restoran"
		Me.Button52.UseVisualStyleBackColor = True
		'
		'Button48
		'
		Me.Button48.Location = New System.Drawing.Point(742, 89)
		Me.Button48.Margin = New System.Windows.Forms.Padding(2)
		Me.Button48.Name = "Button48"
		Me.Button48.Size = New System.Drawing.Size(171, 34)
		Me.Button48.TabIndex = 171
		Me.Button48.Text = "Add SPA bonus amount"
		Me.Button48.UseVisualStyleBackColor = True
		'
		'Button47
		'
		Me.Button47.Location = New System.Drawing.Point(738, 30)
		Me.Button47.Margin = New System.Windows.Forms.Padding(2)
		Me.Button47.Name = "Button47"
		Me.Button47.Size = New System.Drawing.Size(175, 32)
		Me.Button47.TabIndex = 170
		Me.Button47.Text = "SPA bonus balance"
		Me.Button47.UseVisualStyleBackColor = True
		'
		'TextBox26
		'
		Me.TextBox26.Location = New System.Drawing.Point(239, 355)
		Me.TextBox26.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox26.Name = "TextBox26"
		Me.TextBox26.Size = New System.Drawing.Size(119, 23)
		Me.TextBox26.TabIndex = 169
		Me.TextBox26.Visible = False
		'
		'TextBox24
		'
		Me.TextBox24.Location = New System.Drawing.Point(168, 49)
		Me.TextBox24.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox24.Name = "TextBox24"
		Me.TextBox24.Size = New System.Drawing.Size(119, 23)
		Me.TextBox24.TabIndex = 166
		Me.TextBox24.Text = "1"
		'
		'txtId
		'
		Me.txtId.Location = New System.Drawing.Point(48, 355)
		Me.txtId.Margin = New System.Windows.Forms.Padding(2)
		Me.txtId.Name = "txtId"
		Me.txtId.Size = New System.Drawing.Size(140, 23)
		Me.txtId.TabIndex = 161
		Me.txtId.Visible = False
		'
		'RichTextBox3
		'
		Me.RichTextBox3.Location = New System.Drawing.Point(165, 124)
		Me.RichTextBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.RichTextBox3.Name = "RichTextBox3"
		Me.RichTextBox3.Size = New System.Drawing.Size(306, 33)
		Me.RichTextBox3.TabIndex = 159
		Me.RichTextBox3.Text = ""
		'
		'txtDeposit
		'
		Me.txtDeposit.Location = New System.Drawing.Point(168, 89)
		Me.txtDeposit.Margin = New System.Windows.Forms.Padding(2)
		Me.txtDeposit.Name = "txtDeposit"
		Me.txtDeposit.Size = New System.Drawing.Size(119, 23)
		Me.txtDeposit.TabIndex = 151
		Me.txtDeposit.Text = "0"
		'
		'ComboBox17
		'
		Me.ComboBox17.Items.AddRange(New Object() {"Deposit"})
		Me.ComboBox17.Location = New System.Drawing.Point(160, 182)
		Me.ComboBox17.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox17.Name = "ComboBox17"
		Me.ComboBox17.Size = New System.Drawing.Size(218, 25)
		Me.ComboBox17.TabIndex = 167
		Me.ComboBox17.Text = "Coach"
		Me.ComboBox17.Visible = False
		'
		'Label41
		'
		Me.Label41.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label41.Location = New System.Drawing.Point(14, 186)
		Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(85, 25)
		Me.Label41.TabIndex = 168
		Me.Label41.Text = "Coach"
		Me.Label41.Visible = False
		'
		'Label40
		'
		Me.Label40.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label40.Location = New System.Drawing.Point(14, 52)
		Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(85, 21)
		Me.Label40.TabIndex = 165
		Me.Label40.Text = "Quantity"
		'
		'Button34
		'
		Me.Button34.Location = New System.Drawing.Point(389, 346)
		Me.Button34.Margin = New System.Windows.Forms.Padding(2)
		Me.Button34.Name = "Button34"
		Me.Button34.Size = New System.Drawing.Size(80, 32)
		Me.Button34.TabIndex = 163
		Me.Button34.Text = "Hide"
		Me.Button34.UseVisualStyleBackColor = True
		Me.Button34.Visible = False
		'
		'cmbBasic
		'
		Me.cmbBasic.Items.AddRange(New Object() {"Deposit"})
		Me.cmbBasic.Location = New System.Drawing.Point(168, 231)
		Me.cmbBasic.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbBasic.Name = "cmbBasic"
		Me.cmbBasic.Size = New System.Drawing.Size(119, 25)
		Me.cmbBasic.TabIndex = 156
		Me.cmbBasic.Text = "Deposit"
		Me.cmbBasic.Visible = False
		'
		'Button19
		'
		Me.Button19.Location = New System.Drawing.Point(524, 171)
		Me.Button19.Margin = New System.Windows.Forms.Padding(2)
		Me.Button19.Name = "Button19"
		Me.Button19.Size = New System.Drawing.Size(182, 26)
		Me.Button19.TabIndex = 158
		Me.Button19.Text = "Save Deposit Restoran"
		Me.Button19.UseVisualStyleBackColor = True
		'
		'Label21
		'
		Me.Label21.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label21.Location = New System.Drawing.Point(14, 126)
		Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(108, 29)
		Me.Label21.TabIndex = 160
		Me.Label21.Text = "Comment"
		'
		'Label30
		'
		Me.Label30.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label30.Location = New System.Drawing.Point(14, 268)
		Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(151, 22)
		Me.Label30.TabIndex = 154
		Me.Label30.Text = "Payment Purpose"
		Me.Label30.Visible = False
		'
		'cmbPurpose
		'
		Me.cmbPurpose.Items.AddRange(New Object() {"Additional", "Deposit"})
		Me.cmbPurpose.Location = New System.Drawing.Point(168, 268)
		Me.cmbPurpose.Margin = New System.Windows.Forms.Padding(2)
		Me.cmbPurpose.Name = "cmbPurpose"
		Me.cmbPurpose.Size = New System.Drawing.Size(155, 25)
		Me.cmbPurpose.TabIndex = 152
		Me.cmbPurpose.Text = "Deposit"
		Me.cmbPurpose.Visible = False
		'
		'Label31
		'
		Me.Label31.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label31.Location = New System.Drawing.Point(14, 234)
		Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(119, 26)
		Me.Label31.TabIndex = 157
		Me.Label31.Text = "Payment Basic"
		Me.Label31.Visible = False
		'
		'Label32
		'
		Me.Label32.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label32.Location = New System.Drawing.Point(14, 89)
		Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(85, 19)
		Me.Label32.TabIndex = 150
		Me.Label32.Text = "Amount"
		'
		'Label33
		'
		Me.Label33.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label33.Location = New System.Drawing.Point(14, 16)
		Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(132, 22)
		Me.Label33.TabIndex = 155
		Me.Label33.Text = "Payment Methode"
		'
		'CmbMethode
		'
		Me.CmbMethode.Items.AddRange(New Object() {"Cash", "POS"})
		Me.CmbMethode.Location = New System.Drawing.Point(168, 16)
		Me.CmbMethode.Margin = New System.Windows.Forms.Padding(2)
		Me.CmbMethode.Name = "CmbMethode"
		Me.CmbMethode.Size = New System.Drawing.Size(119, 25)
		Me.CmbMethode.TabIndex = 153
		Me.CmbMethode.Text = "Cash"
		'
		'payments
		'
		Me.payments.Controls.Add(Me.DataGridView4)
		Me.payments.Location = New System.Drawing.Point(4, 26)
		Me.payments.Margin = New System.Windows.Forms.Padding(2)
		Me.payments.Name = "payments"
		Me.payments.Size = New System.Drawing.Size(1192, 539)
		Me.payments.TabIndex = 7
		Me.payments.Text = "PAYMENTS"
		Me.payments.UseVisualStyleBackColor = True
		'
		'DataGridView4
		'
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
		Me.DataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
		Me.DataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke
		Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView4.Location = New System.Drawing.Point(0, 26)
		Me.DataGridView4.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGridView4.Name = "DataGridView4"
		Me.DataGridView4.RowHeadersWidth = 47
		Me.DataGridView4.Size = New System.Drawing.Size(1192, 440)
		Me.DataGridView4.TabIndex = 0
		'
		'debt
		'
		Me.debt.BackColor = System.Drawing.Color.Transparent
		Me.debt.Controls.Add(Me.DataGrid2)
		Me.debt.Controls.Add(Me.Button4)
		Me.debt.Controls.Add(Me.Label12)
		Me.debt.Controls.Add(Me.Label11)
		Me.debt.Controls.Add(Me.TextBox4)
		Me.debt.Controls.Add(Me.TextBox5)
		Me.debt.Controls.Add(Me.ComboBox10)
		Me.debt.Location = New System.Drawing.Point(4, 26)
		Me.debt.Margin = New System.Windows.Forms.Padding(2)
		Me.debt.Name = "debt"
		Me.debt.Size = New System.Drawing.Size(1192, 539)
		Me.debt.TabIndex = 1
		Me.debt.Text = "DEBT"
		'
		'DataGrid2
		'
		Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.LightGray
		Me.DataGrid2.BackColor = System.Drawing.Color.DarkGray
		Me.DataGrid2.CaptionBackColor = System.Drawing.Color.White
		Me.DataGrid2.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.DataGrid2.CaptionForeColor = System.Drawing.Color.Navy
		Me.DataGrid2.DataMember = ""
		Me.DataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.DataGrid2.ForeColor = System.Drawing.Color.Black
		Me.DataGrid2.GridLineColor = System.Drawing.Color.Black
		Me.DataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
		Me.DataGrid2.HeaderBackColor = System.Drawing.Color.Silver
		Me.DataGrid2.HeaderForeColor = System.Drawing.Color.Black
		Me.DataGrid2.LinkColor = System.Drawing.Color.Navy
		Me.DataGrid2.Location = New System.Drawing.Point(0, 1)
		Me.DataGrid2.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGrid2.Name = "DataGrid2"
		Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.White
		Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.Black
		Me.DataGrid2.SelectionBackColor = System.Drawing.Color.Navy
		Me.DataGrid2.SelectionForeColor = System.Drawing.Color.White
		Me.DataGrid2.Size = New System.Drawing.Size(1192, 538)
		Me.DataGrid2.TabIndex = 22
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(1558, 369)
		Me.Button4.Margin = New System.Windows.Forms.Padding(2)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(78, 29)
		Me.Button4.TabIndex = 16
		Me.Button4.Text = "Delete"
		Me.Button4.Visible = False
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(1154, 330)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(145, 29)
		Me.Label12.TabIndex = 10
		Me.Label12.Text = "Notes"
		Me.Label12.Visible = False
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(1154, 282)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(156, 29)
		Me.Label11.TabIndex = 9
		Me.Label11.Text = "Payment Methode"
		Me.Label11.Visible = False
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(1332, 321)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(292, 23)
		Me.TextBox4.TabIndex = 7
		Me.TextBox4.Visible = False
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(1042, 359)
		Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(56, 23)
		Me.TextBox5.TabIndex = 12
		Me.TextBox5.Visible = False
		'
		'ComboBox10
		'
		Me.ComboBox10.Location = New System.Drawing.Point(1332, 272)
		Me.ComboBox10.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox10.Name = "ComboBox10"
		Me.ComboBox10.Size = New System.Drawing.Size(169, 25)
		Me.ComboBox10.TabIndex = 6
		Me.ComboBox10.Text = "Cash"
		Me.ComboBox10.Visible = False
		'
		'orders
		'
		Me.orders.Controls.Add(Me.dtpEndDate)
		Me.orders.Controls.Add(Me.txtDays)
		Me.orders.Controls.Add(Me.dtpOrderDate)
		Me.orders.Controls.Add(Me.Button12)
		Me.orders.Controls.Add(Me.Button5)
		Me.orders.Controls.Add(Me.Button37)
		Me.orders.Controls.Add(Me.Button36)
		Me.orders.Controls.Add(Me.Button35)
		Me.orders.Controls.Add(Me.dgvOrders)
		Me.orders.Controls.Add(Me.Panel1)
		Me.orders.Controls.Add(Me.TextBox23)
		Me.orders.Controls.Add(Me.TextBox32)
		Me.orders.Location = New System.Drawing.Point(4, 26)
		Me.orders.Margin = New System.Windows.Forms.Padding(2)
		Me.orders.Name = "orders"
		Me.orders.Size = New System.Drawing.Size(1192, 539)
		Me.orders.TabIndex = 0
		Me.orders.Text = "ORDERS"
		'
		'dtpEndDate
		'
		Me.dtpEndDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEndDate.Location = New System.Drawing.Point(688, 45)
		Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpEndDate.Name = "dtpEndDate"
		Me.dtpEndDate.Size = New System.Drawing.Size(116, 23)
		Me.dtpEndDate.TabIndex = 110
		'
		'txtDays
		'
		Me.txtDays.Location = New System.Drawing.Point(816, 8)
		Me.txtDays.Margin = New System.Windows.Forms.Padding(2)
		Me.txtDays.Name = "txtDays"
		Me.txtDays.Size = New System.Drawing.Size(88, 23)
		Me.txtDays.TabIndex = 111
		Me.txtDays.Text = "30"
		'
		'dtpOrderDate
		'
		Me.dtpOrderDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpOrderDate.Location = New System.Drawing.Point(686, 8)
		Me.dtpOrderDate.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpOrderDate.Name = "dtpOrderDate"
		Me.dtpOrderDate.Size = New System.Drawing.Size(116, 23)
		Me.dtpOrderDate.TabIndex = 109
		'
		'Button12
		'
		Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button12.Image = Global.OrangeGantner.My.Resources.Resources._1
		Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button12.Location = New System.Drawing.Point(816, 31)
		Me.Button12.Margin = New System.Windows.Forms.Padding(2)
		Me.Button12.Name = "Button12"
		Me.Button12.Size = New System.Drawing.Size(105, 38)
		Me.Button12.TabIndex = 108
		Me.Button12.Text = "Gift card"
		Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button12.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(541, 10)
		Me.Button5.Margin = New System.Windows.Forms.Padding(2)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(122, 22)
		Me.Button5.TabIndex = 7
		Me.Button5.Text = "Save edited"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button37
		'
		Me.Button37.Location = New System.Drawing.Point(294, 10)
		Me.Button37.Margin = New System.Windows.Forms.Padding(2)
		Me.Button37.Name = "Button37"
		Me.Button37.Size = New System.Drawing.Size(169, 22)
		Me.Button37.TabIndex = 6
		Me.Button37.Text = "synchronized dates"
		Me.Button37.UseVisualStyleBackColor = True
		'
		'Button36
		'
		Me.Button36.Enabled = False
		Me.Button36.Location = New System.Drawing.Point(176, 10)
		Me.Button36.Margin = New System.Windows.Forms.Padding(2)
		Me.Button36.Name = "Button36"
		Me.Button36.Size = New System.Drawing.Size(88, 22)
		Me.Button36.TabIndex = 5
		Me.Button36.Text = "Activate"
		Me.Button36.UseVisualStyleBackColor = True
		'
		'Button35
		'
		Me.Button35.Location = New System.Drawing.Point(12, 10)
		Me.Button35.Margin = New System.Windows.Forms.Padding(2)
		Me.Button35.Name = "Button35"
		Me.Button35.Size = New System.Drawing.Size(148, 22)
		Me.Button35.TabIndex = 3
		Me.Button35.Text = "Waiting orders"
		Me.Button35.UseVisualStyleBackColor = True
		'
		'dgvOrders
		'
		Me.dgvOrders.AllowUserToAddRows = False
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.FloralWhite
		Me.dgvOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvOrders.BackgroundColor = System.Drawing.Color.White
		Me.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
		Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvOrders.Cursor = System.Windows.Forms.Cursors.Hand
		Me.dgvOrders.EnableHeadersVisualStyles = False
		Me.dgvOrders.GridColor = System.Drawing.Color.DarkGreen
		Me.dgvOrders.Location = New System.Drawing.Point(0, 74)
		Me.dgvOrders.Margin = New System.Windows.Forms.Padding(2)
		Me.dgvOrders.Name = "dgvOrders"
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvOrders.RowHeadersWidth = 47
		Me.dgvOrders.RowTemplate.Height = 24
		Me.dgvOrders.Size = New System.Drawing.Size(1285, 381)
		Me.dgvOrders.TabIndex = 2
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Controls.Add(Me.TextBox18)
		Me.Panel1.Location = New System.Drawing.Point(995, 89)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(288, 172)
		Me.Panel1.TabIndex = 109
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(45, 106)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(102, 23)
		Me.TextBox1.TabIndex = 11
		Me.TextBox1.Text = "TextBox1"
		Me.TextBox1.Visible = False
		'
		'TextBox18
		'
		Me.TextBox18.Location = New System.Drawing.Point(35, 32)
		Me.TextBox18.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox18.Name = "TextBox18"
		Me.TextBox18.Size = New System.Drawing.Size(99, 23)
		Me.TextBox18.TabIndex = 24
		Me.TextBox18.Text = "TextBox18"
		Me.TextBox18.Visible = False
		'
		'freezBalance
		'
		Me.freezBalance.BackColor = System.Drawing.Color.Gainsboro
		Me.freezBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.freezBalance.Controls.Add(Me.Button49)
		Me.freezBalance.Controls.Add(Me.DataGrid6)
		Me.freezBalance.Controls.Add(Me.Label39)
		Me.freezBalance.Controls.Add(Me.Label37)
		Me.freezBalance.Controls.Add(Me.Label36)
		Me.freezBalance.Controls.Add(Me.ComboBox16)
		Me.freezBalance.Controls.Add(Me.Label35)
		Me.freezBalance.Controls.Add(Me.Label34)
		Me.freezBalance.Controls.Add(Me.frAmount)
		Me.freezBalance.Controls.Add(Me.frDays)
		Me.freezBalance.Controls.Add(Me.TextBox25)
		Me.freezBalance.Controls.Add(Me.TextBox17)
		Me.freezBalance.Controls.Add(Me.TextBox16)
		Me.freezBalance.Controls.Add(Me.TextBox15)
		Me.freezBalance.Controls.Add(Me.TextBox13)
		Me.freezBalance.Controls.Add(Me.TextBox12)
		Me.freezBalance.Controls.Add(Me.TextBox11)
		Me.freezBalance.Controls.Add(Me.TextBox9)
		Me.freezBalance.Controls.Add(Me.frPay)
		Me.freezBalance.Controls.Add(Me.Button6)
		Me.freezBalance.Controls.Add(Me.Button2)
		Me.freezBalance.Controls.Add(Me.Label18)
		Me.freezBalance.Controls.Add(Me.Label17)
		Me.freezBalance.Controls.Add(Me.Label15)
		Me.freezBalance.Controls.Add(Me.Label14)
		Me.freezBalance.Controls.Add(Me.DateTimePicker3)
		Me.freezBalance.Controls.Add(Me.Button3)
		Me.freezBalance.Controls.Add(Me.DateTimePicker2)
		Me.freezBalance.Controls.Add(Me.DataGrid8)
		Me.freezBalance.Controls.Add(Me.TextBox20)
		Me.freezBalance.Controls.Add(Me.TextBox14)
		Me.freezBalance.ForeColor = System.Drawing.Color.Black
		Me.freezBalance.Location = New System.Drawing.Point(4, 26)
		Me.freezBalance.Margin = New System.Windows.Forms.Padding(2)
		Me.freezBalance.Name = "freezBalance"
		Me.freezBalance.Size = New System.Drawing.Size(1192, 539)
		Me.freezBalance.TabIndex = 3
		Me.freezBalance.Text = "FREEZING"
		Me.freezBalance.ToolTipText = "Freezing Balance"
		'
		'Button49
		'
		Me.Button49.Location = New System.Drawing.Point(550, 321)
		Me.Button49.Margin = New System.Windows.Forms.Padding(2)
		Me.Button49.Name = "Button49"
		Me.Button49.Size = New System.Drawing.Size(148, 28)
		Me.Button49.TabIndex = 160
		Me.Button49.Text = "Pay from deposit"
		Me.Button49.UseVisualStyleBackColor = True
		Me.Button49.Visible = False
		'
		'DataGrid6
		'
		Me.DataGrid6.DataMember = ""
		Me.DataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.DataGrid6.Location = New System.Drawing.Point(871, -1)
		Me.DataGrid6.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGrid6.Name = "DataGrid6"
		Me.DataGrid6.Size = New System.Drawing.Size(538, 336)
		Me.DataGrid6.TabIndex = 0
		'
		'Label39
		'
		Me.Label39.AutoSize = True
		Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label39.Location = New System.Drawing.Point(224, 58)
		Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(59, 18)
		Me.Label39.TabIndex = 159
		Me.Label39.Text = "Label39"
		'
		'Label37
		'
		Me.Label37.AutoSize = True
		Me.Label37.ForeColor = System.Drawing.Color.Red
		Me.Label37.Location = New System.Drawing.Point(118, 6)
		Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(17, 17)
		Me.Label37.TabIndex = 158
		Me.Label37.Text = "A"
		'
		'Label36
		'
		Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Label36.Location = New System.Drawing.Point(268, 290)
		Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(132, 22)
		Me.Label36.TabIndex = 157
		Me.Label36.Text = "Payment Methode"
		'
		'ComboBox16
		'
		Me.ComboBox16.Items.AddRange(New Object() {"Cash", "POS"})
		Me.ComboBox16.Location = New System.Drawing.Point(408, 288)
		Me.ComboBox16.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox16.Name = "ComboBox16"
		Me.ComboBox16.Size = New System.Drawing.Size(119, 25)
		Me.ComboBox16.TabIndex = 156
		Me.ComboBox16.Text = "Cash"
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(19, 321)
		Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(56, 17)
		Me.Label35.TabIndex = 25
		Me.Label35.Text = "Amount"
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(19, 298)
		Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(40, 17)
		Me.Label34.TabIndex = 24
		Me.Label34.Text = "Days"
		'
		'frAmount
		'
		Me.frAmount.Location = New System.Drawing.Point(91, 318)
		Me.frAmount.Margin = New System.Windows.Forms.Padding(2)
		Me.frAmount.Name = "frAmount"
		Me.frAmount.Size = New System.Drawing.Size(140, 23)
		Me.frAmount.TabIndex = 23
		'
		'frDays
		'
		Me.frDays.Location = New System.Drawing.Point(91, 288)
		Me.frDays.Margin = New System.Windows.Forms.Padding(2)
		Me.frDays.Name = "frDays"
		Me.frDays.Size = New System.Drawing.Size(140, 23)
		Me.frDays.TabIndex = 22
		'
		'TextBox25
		'
		Me.TextBox25.Location = New System.Drawing.Point(8, 2)
		Me.TextBox25.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox25.Name = "TextBox25"
		Me.TextBox25.Size = New System.Drawing.Size(79, 23)
		Me.TextBox25.TabIndex = 20
		'
		'TextBox17
		'
		Me.TextBox17.Location = New System.Drawing.Point(906, 298)
		Me.TextBox17.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox17.Name = "TextBox17"
		Me.TextBox17.Size = New System.Drawing.Size(123, 23)
		Me.TextBox17.TabIndex = 17
		Me.TextBox17.Text = "TextBox17"
		Me.TextBox17.Visible = False
		'
		'TextBox16
		'
		Me.TextBox16.Enabled = False
		Me.TextBox16.Location = New System.Drawing.Point(896, 175)
		Me.TextBox16.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox16.Name = "TextBox16"
		Me.TextBox16.Size = New System.Drawing.Size(90, 23)
		Me.TextBox16.TabIndex = 16
		Me.TextBox16.Visible = False
		'
		'TextBox15
		'
		Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.TextBox15.ForeColor = System.Drawing.Color.Red
		Me.TextBox15.Location = New System.Drawing.Point(584, 6)
		Me.TextBox15.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox15.Name = "TextBox15"
		Me.TextBox15.Size = New System.Drawing.Size(66, 24)
		Me.TextBox15.TabIndex = 13
		'
		'TextBox13
		'
		Me.TextBox13.Location = New System.Drawing.Point(11, 78)
		Me.TextBox13.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox13.Name = "TextBox13"
		Me.TextBox13.Size = New System.Drawing.Size(692, 23)
		Me.TextBox13.TabIndex = 8
		'
		'TextBox12
		'
		Me.TextBox12.Location = New System.Drawing.Point(918, 242)
		Me.TextBox12.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox12.Name = "TextBox12"
		Me.TextBox12.Size = New System.Drawing.Size(140, 23)
		Me.TextBox12.TabIndex = 7
		Me.TextBox12.Text = "TextBox12"
		Me.TextBox12.Visible = False
		'
		'TextBox11
		'
		Me.TextBox11.Location = New System.Drawing.Point(448, 28)
		Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox11.Name = "TextBox11"
		Me.TextBox11.Size = New System.Drawing.Size(78, 23)
		Me.TextBox11.TabIndex = 6
		Me.TextBox11.Text = "7"
		'
		'TextBox9
		'
		Me.TextBox9.Location = New System.Drawing.Point(896, 204)
		Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox9.Name = "TextBox9"
		Me.TextBox9.Size = New System.Drawing.Size(90, 23)
		Me.TextBox9.TabIndex = 4
		Me.TextBox9.Text = "TextBox9"
		Me.TextBox9.Visible = False
		'
		'frPay
		'
		Me.frPay.Location = New System.Drawing.Point(550, 285)
		Me.frPay.Margin = New System.Windows.Forms.Padding(2)
		Me.frPay.Name = "frPay"
		Me.frPay.Size = New System.Drawing.Size(148, 28)
		Me.frPay.TabIndex = 21
		Me.frPay.Text = "Pay for freezing"
		Me.frPay.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(532, 108)
		Me.Button6.Margin = New System.Windows.Forms.Padding(2)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(139, 28)
		Me.Button6.TabIndex = 19
		Me.Button6.Text = "Edit paid days"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button2.Location = New System.Drawing.Point(160, 108)
		Me.Button2.Margin = New System.Windows.Forms.Padding(2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(88, 29)
		Me.Button2.TabIndex = 18
		Me.Button2.Text = "Delete"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label18
		'
		Me.Label18.Enabled = False
		Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label18.ForeColor = System.Drawing.Color.Black
		Me.Label18.Location = New System.Drawing.Point(892, 204)
		Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(68, 29)
		Me.Label18.TabIndex = 15
		Me.Label18.Text = "OrderID"
		Me.Label18.Visible = False
		'
		'Label17
		'
		Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label17.ForeColor = System.Drawing.Color.Red
		Me.Label17.Location = New System.Drawing.Point(419, 10)
		Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(165, 19)
		Me.Label17.TabIndex = 14
		Me.Label17.Text = "Avialable for freezing"
		'
		'Label15
		'
		Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.Black
		Me.Label15.Location = New System.Drawing.Point(402, 34)
		Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(45, 19)
		Me.Label15.TabIndex = 10
		Me.Label15.Text = "Days"
		'
		'Label14
		'
		Me.Label14.ForeColor = System.Drawing.Color.Black
		Me.Label14.Location = New System.Drawing.Point(19, 61)
		Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(141, 19)
		Me.Label14.TabIndex = 9
		Me.Label14.Text = "Notes"
		'
		'DateTimePicker3
		'
		Me.DateTimePicker3.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
		Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker3.Location = New System.Drawing.Point(228, 30)
		Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(2)
		Me.DateTimePicker3.Name = "DateTimePicker3"
		Me.DateTimePicker3.Size = New System.Drawing.Size(179, 23)
		Me.DateTimePicker3.TabIndex = 5
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.DimGray
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Button3.ForeColor = System.Drawing.Color.Black
		Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button3.Location = New System.Drawing.Point(11, 108)
		Me.Button3.Margin = New System.Windows.Forms.Padding(2)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(141, 29)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Add Freez days"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
		Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker2.Location = New System.Drawing.Point(11, 29)
		Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(192, 23)
		Me.DateTimePicker2.TabIndex = 2
		'
		'DataGrid8
		'
		Me.DataGrid8.AllowNavigation = False
		Me.DataGrid8.DataMember = ""
		Me.DataGrid8.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.DataGrid8.Location = New System.Drawing.Point(0, 136)
		Me.DataGrid8.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGrid8.Name = "DataGrid8"
		Me.DataGrid8.Size = New System.Drawing.Size(865, 138)
		Me.DataGrid8.TabIndex = 1
		'
		'TextBox20
		'
		Me.TextBox20.Enabled = False
		Me.TextBox20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.TextBox20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.TextBox20.Location = New System.Drawing.Point(974, 78)
		Me.TextBox20.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox20.Name = "TextBox20"
		Me.TextBox20.Size = New System.Drawing.Size(30, 30)
		Me.TextBox20.TabIndex = 11
		Me.TextBox20.Text = "7"
		'
		'TextBox14
		'
		Me.TextBox14.Enabled = False
		Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.TextBox14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.TextBox14.Location = New System.Drawing.Point(974, 48)
		Me.TextBox14.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox14.Name = "TextBox14"
		Me.TextBox14.Size = New System.Drawing.Size(56, 30)
		Me.TextBox14.TabIndex = 11
		Me.TextBox14.Text = "7"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.details)
		Me.TabControl1.Controls.Add(Me.orders)
		Me.TabControl1.Controls.Add(Me.freezBalance)
		Me.TabControl1.Controls.Add(Me.debt)
		Me.TabControl1.Controls.Add(Me.payments)
		Me.TabControl1.Controls.Add(Me.deposit)
		Me.TabControl1.Controls.Add(Me.guests)
		Me.TabControl1.Controls.Add(Me.xStart)
		Me.TabControl1.Controls.Add(Me.admTools)
		Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.TabControl1.Location = New System.Drawing.Point(12, 339)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
		Me.TabControl1.Multiline = True
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.ShowToolTips = True
		Me.TabControl1.Size = New System.Drawing.Size(1200, 569)
		Me.TabControl1.TabIndex = 21
		'
		'details
		'
		Me.details.BackColor = System.Drawing.Color.Gainsboro
		Me.details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.details.Controls.Add(Me.UpdateFpInfoButton)
		Me.details.Controls.Add(Me.lblFP)
		Me.details.Controls.Add(Me.Panel2)
		Me.details.Controls.Add(Me.Label3)
		Me.details.Controls.Add(Me.txtCompany)
		Me.details.Controls.Add(Me.Button24)
		Me.details.Controls.Add(Me.Button33)
		Me.details.Controls.Add(Me.BindingNavigator1)
		Me.details.Controls.Add(Me.TextBox7)
		Me.details.Controls.Add(Me.Button53)
		Me.details.Controls.Add(Me.Button56)
		Me.details.Controls.Add(Me.Button10)
		Me.details.Controls.Add(Me.Button28)
		Me.details.Controls.Add(Me.DataGridView2)
		Me.details.Controls.Add(Me.Button20)
		Me.details.Controls.Add(Me.Button22)
		Me.details.Controls.Add(Me.ComboBox15)
		Me.details.Controls.Add(Me.Button25)
		Me.details.Controls.Add(Me.dtBornOn)
		Me.details.Controls.Add(Me.txtPhone2)
		Me.details.Controls.Add(Me.Label5)
		Me.details.Controls.Add(Me.txtMail)
		Me.details.Controls.Add(Me.txtCustid)
		Me.details.Controls.Add(Me.txtManager)
		Me.details.Controls.Add(Me.txtGroup)
		Me.details.Controls.Add(Me.txtUID)
		Me.details.Controls.Add(Me.txtBorn)
		Me.details.Controls.Add(Me.RichTextBox1)
		Me.details.Controls.Add(Me.Button13)
		Me.details.Controls.Add(Me.Button16)
		Me.details.Location = New System.Drawing.Point(4, 26)
		Me.details.Margin = New System.Windows.Forms.Padding(2)
		Me.details.Name = "details"
		Me.details.Size = New System.Drawing.Size(1192, 539)
		Me.details.TabIndex = 13
		Me.details.Text = "DETAILS"
		'
		'UpdateFpInfoButton
		'
		Me.UpdateFpInfoButton.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.UpdateFpInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.UpdateFpInfoButton.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.UpdateFpInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.UpdateFpInfoButton.Location = New System.Drawing.Point(574, 198)
		Me.UpdateFpInfoButton.Margin = New System.Windows.Forms.Padding(2)
		Me.UpdateFpInfoButton.Name = "UpdateFpInfoButton"
		Me.UpdateFpInfoButton.Size = New System.Drawing.Size(134, 25)
		Me.UpdateFpInfoButton.TabIndex = 268
		Me.UpdateFpInfoButton.Text = "Update FP Info"
		Me.UpdateFpInfoButton.UseVisualStyleBackColor = False
		'
		'lblFP
		'
		Me.lblFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblFP.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.lblFP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblFP.Location = New System.Drawing.Point(571, 130)
		Me.lblFP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblFP.Name = "lblFP"
		Me.lblFP.Size = New System.Drawing.Size(198, 28)
		Me.lblFP.TabIndex = 266
		Me.lblFP.Text = "FINGERPRRINT"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
		Me.Panel2.Controls.Add(Me.Label25)
		Me.Panel2.Location = New System.Drawing.Point(72, 15)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(288, 39)
		Me.Panel2.TabIndex = 265
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label25.ForeColor = System.Drawing.Color.White
		Me.Label25.Location = New System.Drawing.Point(44, 1)
		Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(174, 24)
		Me.Label25.TabIndex = 50
		Me.Label25.Text = "UPDATE and SAVE"
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(56, 302)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 24)
		Me.Label3.TabIndex = 264
		Me.Label3.Text = "Company"
		'
		'txtCompany
		'
		Me.txtCompany.BackColor = System.Drawing.Color.MintCream
		Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtCompany.Location = New System.Drawing.Point(152, 301)
		Me.txtCompany.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCompany.Name = "txtCompany"
		Me.txtCompany.Size = New System.Drawing.Size(219, 27)
		Me.txtCompany.TabIndex = 263
		'
		'Button24
		'
		Me.Button24.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button24.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.Button24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button24.Location = New System.Drawing.Point(72, 128)
		Me.Button24.Margin = New System.Windows.Forms.Padding(2)
		Me.Button24.Name = "Button24"
		Me.Button24.Size = New System.Drawing.Size(76, 25)
		Me.Button24.TabIndex = 256
		Me.Button24.Text = "UID"
		Me.Button24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button24.UseVisualStyleBackColor = False
		'
		'Button33
		'
		Me.Button33.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button33.Location = New System.Drawing.Point(72, 90)
		Me.Button33.Margin = New System.Windows.Forms.Padding(2)
		Me.Button33.Name = "Button33"
		Me.Button33.Size = New System.Drawing.Size(76, 25)
		Me.Button33.TabIndex = 257
		Me.Button33.Text = "Born on"
		Me.Button33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button33.UseVisualStyleBackColor = False
		'
		'TextBox7
		'
		Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
		Me.TextBox7.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.TextBox7.Location = New System.Drawing.Point(558, 64)
		Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(212, 23)
		Me.TextBox7.TabIndex = 262
		Me.TextBox7.Text = "TextBox7"
		'
		'Button56
		'
		Me.Button56.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button56.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button56.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button56.Location = New System.Drawing.Point(72, 58)
		Me.Button56.Margin = New System.Windows.Forms.Padding(2)
		Me.Button56.Name = "Button56"
		Me.Button56.Size = New System.Drawing.Size(76, 25)
		Me.Button56.TabIndex = 258
		Me.Button56.Text = "Group"
		Me.Button56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button56.UseVisualStyleBackColor = False
		'
		'Button28
		'
		Me.Button28.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button28.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button28.Location = New System.Drawing.Point(72, 230)
		Me.Button28.Margin = New System.Windows.Forms.Padding(2)
		Me.Button28.Name = "Button28"
		Me.Button28.Size = New System.Drawing.Size(76, 25)
		Me.Button28.TabIndex = 261
		Me.Button28.Text = "Notes"
		Me.Button28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button28.UseVisualStyleBackColor = False
		'
		'DataGridView2
		'
		Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
		Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(775, 70)
		Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
		Me.DataGridView2.Name = "DataGridView2"
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
		Me.DataGridView2.RowHeadersWidth = 47
		Me.DataGridView2.RowTemplate.Height = 24
		Me.DataGridView2.Size = New System.Drawing.Size(412, 482)
		Me.DataGridView2.TabIndex = 0
		'
		'Button20
		'
		Me.Button20.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button20.Location = New System.Drawing.Point(72, 198)
		Me.Button20.Margin = New System.Windows.Forms.Padding(2)
		Me.Button20.Name = "Button20"
		Me.Button20.Size = New System.Drawing.Size(76, 25)
		Me.Button20.TabIndex = 259
		Me.Button20.Text = "Email"
		Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button20.UseVisualStyleBackColor = False
		'
		'Button22
		'
		Me.Button22.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button22.Location = New System.Drawing.Point(72, 165)
		Me.Button22.Margin = New System.Windows.Forms.Padding(2)
		Me.Button22.Name = "Button22"
		Me.Button22.Size = New System.Drawing.Size(76, 25)
		Me.Button22.TabIndex = 260
		Me.Button22.Text = "Phone"
		Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button22.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(58, 336)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(84, 24)
		Me.Label5.TabIndex = 254
		Me.Label5.Text = "Manager"
		'
		'txtMail
		'
		Me.txtMail.BackColor = System.Drawing.Color.MintCream
		Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtMail.Location = New System.Drawing.Point(164, 202)
		Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
		Me.txtMail.Name = "txtMail"
		Me.txtMail.Size = New System.Drawing.Size(209, 22)
		Me.txtMail.TabIndex = 243
		'
		'txtCustid
		'
		Me.txtCustid.BackColor = System.Drawing.SystemColors.Control
		Me.txtCustid.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.txtCustid.Location = New System.Drawing.Point(36, 461)
		Me.txtCustid.Margin = New System.Windows.Forms.Padding(2)
		Me.txtCustid.Name = "txtCustid"
		Me.txtCustid.Size = New System.Drawing.Size(140, 23)
		Me.txtCustid.TabIndex = 250
		Me.txtCustid.Text = "0"
		'
		'txtManager
		'
		Me.txtManager.BackColor = System.Drawing.Color.MintCream
		Me.txtManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtManager.Location = New System.Drawing.Point(154, 332)
		Me.txtManager.Margin = New System.Windows.Forms.Padding(2)
		Me.txtManager.Name = "txtManager"
		Me.txtManager.Size = New System.Drawing.Size(219, 27)
		Me.txtManager.TabIndex = 253
		'
		'txtGroup
		'
		Me.txtGroup.BackColor = System.Drawing.Color.MintCream
		Me.txtGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtGroup.Location = New System.Drawing.Point(164, 61)
		Me.txtGroup.Margin = New System.Windows.Forms.Padding(2)
		Me.txtGroup.Name = "txtGroup"
		Me.txtGroup.Size = New System.Drawing.Size(209, 22)
		Me.txtGroup.TabIndex = 244
		'
		'txtBorn
		'
		Me.txtBorn.BackColor = System.Drawing.Color.MintCream
		Me.txtBorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtBorn.Location = New System.Drawing.Point(164, 96)
		Me.txtBorn.Margin = New System.Windows.Forms.Padding(2)
		Me.txtBorn.Mask = "00/00/0000"
		Me.txtBorn.Name = "txtBorn"
		Me.txtBorn.Size = New System.Drawing.Size(209, 22)
		Me.txtBorn.TabIndex = 245
		Me.txtBorn.ValidatingType = GetType(Date)
		'
		'Button16
		'
		Me.Button16.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button16.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button16.Location = New System.Drawing.Point(684, 8)
		Me.Button16.Margin = New System.Windows.Forms.Padding(2)
		Me.Button16.Name = "Button16"
		Me.Button16.Size = New System.Drawing.Size(85, 49)
		Me.Button16.TabIndex = 191
		Me.Button16.Text = "Whose guest?"
		Me.Button16.UseVisualStyleBackColor = False
		'
		'admTools
		'
		Me.admTools.Controls.Add(Me.btnRemoveCoach)
		Me.admTools.Controls.Add(Me.setCoach)
		Me.admTools.Controls.Add(Me.Label8)
		Me.admTools.Controls.Add(Me.Button45)
		Me.admTools.Controls.Add(Me.DateTimePicker1)
		Me.admTools.Controls.Add(Me.updAddress)
		Me.admTools.Controls.Add(Me.updCardId)
		Me.admTools.Controls.Add(Me.updFLname)
		Me.admTools.Location = New System.Drawing.Point(4, 26)
		Me.admTools.Margin = New System.Windows.Forms.Padding(2)
		Me.admTools.Name = "admTools"
		Me.admTools.Size = New System.Drawing.Size(1192, 539)
		Me.admTools.TabIndex = 14
		Me.admTools.Text = "Administrative Tools"
		Me.admTools.UseVisualStyleBackColor = True
		'
		'btnRemoveCoach
		'
		Me.btnRemoveCoach.Location = New System.Drawing.Point(51, 268)
		Me.btnRemoveCoach.Margin = New System.Windows.Forms.Padding(2)
		Me.btnRemoveCoach.Name = "btnRemoveCoach"
		Me.btnRemoveCoach.Size = New System.Drawing.Size(178, 32)
		Me.btnRemoveCoach.TabIndex = 205
		Me.btnRemoveCoach.Text = "Remove coach"
		Me.btnRemoveCoach.UseVisualStyleBackColor = True
		Me.btnRemoveCoach.Visible = False
		'
		'setCoach
		'
		Me.setCoach.Location = New System.Drawing.Point(51, 219)
		Me.setCoach.Margin = New System.Windows.Forms.Padding(2)
		Me.setCoach.Name = "setCoach"
		Me.setCoach.Size = New System.Drawing.Size(178, 32)
		Me.setCoach.TabIndex = 204
		Me.setCoach.Text = "Coach"
		Me.setCoach.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(642, 39)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(90, 17)
		Me.Label8.TabIndex = 203
		Me.Label8.Text = "where date= "
		'
		'Button45
		'
		Me.Button45.Location = New System.Drawing.Point(472, 36)
		Me.Button45.Margin = New System.Windows.Forms.Padding(2)
		Me.Button45.Name = "Button45"
		Me.Button45.Size = New System.Drawing.Size(146, 41)
		Me.Button45.TabIndex = 202
		Me.Button45.Text = "Delete checkin"
		Me.Button45.UseVisualStyleBackColor = True
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker1.Location = New System.Drawing.Point(738, 36)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(150, 23)
		Me.DateTimePicker1.TabIndex = 201
		'
		'updAddress
		'
		Me.updAddress.Location = New System.Drawing.Point(51, 158)
		Me.updAddress.Margin = New System.Windows.Forms.Padding(2)
		Me.updAddress.Name = "updAddress"
		Me.updAddress.Size = New System.Drawing.Size(178, 32)
		Me.updAddress.TabIndex = 2
		Me.updAddress.Text = "Update Company"
		Me.updAddress.UseVisualStyleBackColor = True
		'
		'updCardId
		'
		Me.updCardId.Location = New System.Drawing.Point(51, 98)
		Me.updCardId.Margin = New System.Windows.Forms.Padding(2)
		Me.updCardId.Name = "updCardId"
		Me.updCardId.Size = New System.Drawing.Size(178, 32)
		Me.updCardId.TabIndex = 1
		Me.updCardId.Text = "Update Cardid"
		Me.updCardId.UseVisualStyleBackColor = True
		'
		'updFLname
		'
		Me.updFLname.Location = New System.Drawing.Point(51, 45)
		Me.updFLname.Margin = New System.Windows.Forms.Padding(2)
		Me.updFLname.Name = "updFLname"
		Me.updFLname.Size = New System.Drawing.Size(178, 32)
		Me.updFLname.TabIndex = 0
		Me.updFLname.Text = "Update First Last Name"
		Me.updFLname.UseVisualStyleBackColor = True
		'
		'dgw
		'
		Me.dgw.AllowUserToAddRows = False
		Me.dgw.AllowUserToDeleteRows = False
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FloralWhite
		Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
		Me.dgw.BackgroundColor = System.Drawing.Color.White
		Me.dgw.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
		Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSteelBlue
		DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
		Me.dgw.ColumnHeadersHeight = 24
		Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.custid, Me.Cardid, Me.FirstName, Me.LastName, Me.MobilePhone, Me.UID, Me.stat, Me.cardtype, Me.Attachments, Me.Email, Me.Notes, Me.BornOn, Me.ContactPerson, Me.Address})
		Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
		DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgw.DefaultCellStyle = DataGridViewCellStyle14
		Me.dgw.EnableHeadersVisualStyles = False
		Me.dgw.GridColor = System.Drawing.Color.White
		Me.dgw.Location = New System.Drawing.Point(1214, 12)
		Me.dgw.Margin = New System.Windows.Forms.Padding(2)
		Me.dgw.MultiSelect = False
		Me.dgw.Name = "dgw"
		Me.dgw.ReadOnly = True
		Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSeaGreen
		DataGridViewCellStyle15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange
		DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
		Me.dgw.RowHeadersWidth = 25
		Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumTurquoise
		DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
		Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle16
		Me.dgw.RowTemplate.Height = 18
		Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgw.Size = New System.Drawing.Size(588, 892)
		Me.dgw.TabIndex = 246
		'
		'custid
		'
		Me.custid.Frozen = True
		Me.custid.HeaderText = "id"
		Me.custid.MinimumWidth = 6
		Me.custid.Name = "custid"
		Me.custid.ReadOnly = True
		Me.custid.Visible = False
		Me.custid.Width = 116
		'
		'Cardid
		'
		Me.Cardid.Frozen = True
		Me.Cardid.HeaderText = "Card ID"
		Me.Cardid.MinimumWidth = 6
		Me.Cardid.Name = "Cardid"
		Me.Cardid.ReadOnly = True
		Me.Cardid.Width = 116
		'
		'FirstName
		'
		Me.FirstName.Frozen = True
		Me.FirstName.HeaderText = "First Name"
		Me.FirstName.MinimumWidth = 6
		Me.FirstName.Name = "FirstName"
		Me.FirstName.ReadOnly = True
		Me.FirstName.Width = 116
		'
		'LastName
		'
		Me.LastName.Frozen = True
		Me.LastName.HeaderText = "Last Name"
		Me.LastName.MinimumWidth = 6
		Me.LastName.Name = "LastName"
		Me.LastName.ReadOnly = True
		Me.LastName.Width = 116
		'
		'MobilePhone
		'
		Me.MobilePhone.Frozen = True
		Me.MobilePhone.HeaderText = "MobilePhone"
		Me.MobilePhone.MinimumWidth = 6
		Me.MobilePhone.Name = "MobilePhone"
		Me.MobilePhone.ReadOnly = True
		Me.MobilePhone.Width = 116
		'
		'UID
		'
		Me.UID.Frozen = True
		Me.UID.HeaderText = "UID"
		Me.UID.MinimumWidth = 6
		Me.UID.Name = "UID"
		Me.UID.ReadOnly = True
		Me.UID.Visible = False
		Me.UID.Width = 116
		'
		'stat
		'
		Me.stat.Frozen = True
		Me.stat.HeaderText = "Status"
		Me.stat.MinimumWidth = 6
		Me.stat.Name = "stat"
		Me.stat.ReadOnly = True
		Me.stat.Visible = False
		Me.stat.Width = 116
		'
		'cardtype
		'
		Me.cardtype.Frozen = True
		Me.cardtype.HeaderText = "cardtype"
		Me.cardtype.MinimumWidth = 6
		Me.cardtype.Name = "cardtype"
		Me.cardtype.ReadOnly = True
		Me.cardtype.Visible = False
		Me.cardtype.Width = 116
		'
		'Attachments
		'
		Me.Attachments.Frozen = True
		Me.Attachments.HeaderText = "Group"
		Me.Attachments.MinimumWidth = 6
		Me.Attachments.Name = "Attachments"
		Me.Attachments.ReadOnly = True
		Me.Attachments.Visible = False
		Me.Attachments.Width = 116
		'
		'Email
		'
		Me.Email.Frozen = True
		Me.Email.HeaderText = "Email"
		Me.Email.MinimumWidth = 6
		Me.Email.Name = "Email"
		Me.Email.ReadOnly = True
		Me.Email.Visible = False
		Me.Email.Width = 116
		'
		'Notes
		'
		Me.Notes.Frozen = True
		Me.Notes.HeaderText = "Notes"
		Me.Notes.MinimumWidth = 6
		Me.Notes.Name = "Notes"
		Me.Notes.ReadOnly = True
		Me.Notes.Visible = False
		Me.Notes.Width = 116
		'
		'BornOn
		'
		Me.BornOn.Frozen = True
		Me.BornOn.HeaderText = "BornOn"
		Me.BornOn.MinimumWidth = 6
		Me.BornOn.Name = "BornOn"
		Me.BornOn.ReadOnly = True
		Me.BornOn.Visible = False
		Me.BornOn.Width = 116
		'
		'ContactPerson
		'
		Me.ContactPerson.HeaderText = "ContactPerson"
		Me.ContactPerson.MinimumWidth = 6
		Me.ContactPerson.Name = "ContactPerson"
		Me.ContactPerson.ReadOnly = True
		Me.ContactPerson.Visible = False
		Me.ContactPerson.Width = 116
		'
		'Address
		'
		Me.Address.HeaderText = "Company"
		Me.Address.MinimumWidth = 6
		Me.Address.Name = "Address"
		Me.Address.ReadOnly = True
		Me.Address.Width = 116
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
		'
		'PrintPreviewDialog1
		'
		Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.PrintPreviewDialog1.Enabled = True
		Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
		Me.PrintPreviewDialog1.Visible = False
		'
		'TextBox22
		'
		Me.TextBox22.BackColor = System.Drawing.SystemColors.Control
		Me.TextBox22.ForeColor = System.Drawing.SystemColors.InactiveCaption
		Me.TextBox22.Location = New System.Drawing.Point(1154, 86)
		Me.TextBox22.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox22.Name = "TextBox22"
		Me.TextBox22.Size = New System.Drawing.Size(140, 24)
		Me.TextBox22.TabIndex = 251
		Me.TextBox22.Text = "TextBox22"
		Me.TextBox22.Visible = False
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Button31
		'
		Me.Button31.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button31.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button31.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button31.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button31.Image = Global.OrangeGantner.My.Resources.Resources._1__6_
		Me.Button31.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button31.Location = New System.Drawing.Point(1001, 296)
		Me.Button31.Margin = New System.Windows.Forms.Padding(2)
		Me.Button31.Name = "Button31"
		Me.Button31.Size = New System.Drawing.Size(110, 40)
		Me.Button31.TabIndex = 252
		Me.Button31.Text = "By ID"
		Me.Button31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button31.UseVisualStyleBackColor = False
		'
		'Button9
		'
		Me.Button9.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
		Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button9.Location = New System.Drawing.Point(408, 232)
		Me.Button9.Margin = New System.Windows.Forms.Padding(2)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(145, 45)
		Me.Button9.TabIndex = 247
		Me.Button9.Text = "Update status"
		Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button9.UseVisualStyleBackColor = False
		'
		'Button15
		'
		Me.Button15.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button15.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button15.Image = Global.OrangeGantner.My.Resources.Resources._1__6_
		Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button15.Location = New System.Drawing.Point(1000, 199)
		Me.Button15.Margin = New System.Windows.Forms.Padding(2)
		Me.Button15.Name = "Button15"
		Me.Button15.Size = New System.Drawing.Size(110, 40)
		Me.Button15.TabIndex = 249
		Me.Button15.Text = "By UID"
		Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button15.UseVisualStyleBackColor = False
		'
		'Button11
		'
		Me.Button11.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button11.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button11.Image = Global.OrangeGantner.My.Resources.Resources._1__6_
		Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button11.Location = New System.Drawing.Point(1001, 246)
		Me.Button11.Margin = New System.Windows.Forms.Padding(2)
		Me.Button11.Name = "Button11"
		Me.Button11.Size = New System.Drawing.Size(110, 40)
		Me.Button11.TabIndex = 248
		Me.Button11.Text = "By Phone"
		Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button11.UseVisualStyleBackColor = False
		'
		'Button14
		'
		Me.Button14.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button14.ForeColor = System.Drawing.SystemColors.InfoText
		Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
		Me.Button14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button14.Location = New System.Drawing.Point(408, 22)
		Me.Button14.Margin = New System.Windows.Forms.Padding(2)
		Me.Button14.Name = "Button14"
		Me.Button14.Size = New System.Drawing.Size(114, 34)
		Me.Button14.TabIndex = 34
		Me.Button14.Text = "Add New Client"
		Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button14.UseVisualStyleBackColor = False
		'
		'btnFindLF
		'
		Me.btnFindLF.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnFindLF.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnFindLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFindLF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.btnFindLF.ForeColor = System.Drawing.SystemColors.Desktop
		Me.btnFindLF.Image = Global.OrangeGantner.My.Resources.Resources._1__6_
		Me.btnFindLF.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.btnFindLF.Location = New System.Drawing.Point(971, 101)
		Me.btnFindLF.Margin = New System.Windows.Forms.Padding(2)
		Me.btnFindLF.Name = "btnFindLF"
		Me.btnFindLF.Size = New System.Drawing.Size(142, 36)
		Me.btnFindLF.TabIndex = 236
		Me.btnFindLF.Text = "By First&Last  Name"
		Me.btnFindLF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Button27
		'
		Me.Button27.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button27.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.Button27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button27.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Button27.Image = Global.OrangeGantner.My.Resources.Resources._1__6_
		Me.Button27.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button27.Location = New System.Drawing.Point(1001, 150)
		Me.Button27.Margin = New System.Windows.Forms.Padding(2)
		Me.Button27.Name = "Button27"
		Me.Button27.Size = New System.Drawing.Size(110, 40)
		Me.Button27.TabIndex = 235
		Me.Button27.Text = "By Card"
		Me.Button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button27.UseVisualStyleBackColor = False
		'
		'Button21
		'
		Me.Button21.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.Button21.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button21.ForeColor = System.Drawing.SystemColors.InfoText
		Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
		Me.Button21.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button21.Location = New System.Drawing.Point(58, 296)
		Me.Button21.Margin = New System.Windows.Forms.Padding(2)
		Me.Button21.Name = "Button21"
		Me.Button21.Size = New System.Drawing.Size(114, 34)
		Me.Button21.TabIndex = 44
		Me.Button21.Text = "Add Photo"
		Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button21.UseVisualStyleBackColor = False
		'
		'pView
		'
		Me.pView.Location = New System.Drawing.Point(34, 4)
		Me.pView.Margin = New System.Windows.Forms.Padding(2)
		Me.pView.Name = "pView"
		Me.pView.Size = New System.Drawing.Size(344, 281)
		Me.pView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pView.TabIndex = 61
		Me.pView.TabStop = False
		'
		'Label22
		'
		Me.Label22.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label22.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Label22.Location = New System.Drawing.Point(356, 221)
		Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(99, 29)
		Me.Label22.TabIndex = 34
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(934, 11)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 19)
		Me.Label1.TabIndex = 246
		Me.Label1.Text = "Card ID"
		Me.Label1.Visible = False
		'
		'lblUserId
		'
		Me.lblUserId.AutoSize = True
		Me.lblUserId.Location = New System.Drawing.Point(446, 84)
		Me.lblUserId.Name = "lblUserId"
		Me.lblUserId.Size = New System.Drawing.Size(47, 17)
		Me.lblUserId.TabIndex = 253
		Me.lblUserId.Text = "Label9"
		Me.lblUserId.Visible = False
		'
		'Profile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1924, 921)
		Me.Controls.Add(Me.lblUserId)
		Me.Controls.Add(Me.chForgot)
		Me.Controls.Add(Me.pView)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button31)
		Me.Controls.Add(Me.Button9)
		Me.Controls.Add(Me.Label22)
		Me.Controls.Add(Me.tmp)
		Me.Controls.Add(Me.chBoxAllow)
		Me.Controls.Add(Me.Disabled)
		Me.Controls.Add(Me.Button29)
		Me.Controls.Add(Me.cmbReason)
		Me.Controls.Add(Me.txtCardId)
		Me.Controls.Add(Me.cmbAdmin)
		Me.Controls.Add(Me.Button15)
		Me.Controls.Add(Me.Label46)
		Me.Controls.Add(Me.Button11)
		Me.Controls.Add(Me.Label51)
		Me.Controls.Add(Me.Button14)
		Me.Controls.Add(Me.Button26)
		Me.Controls.Add(Me.txtFirst)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.txtLast)
		Me.Controls.Add(Me.btnFindLF)
		Me.Controls.Add(Me.Button27)
		Me.Controls.Add(Me.txtFind)
		Me.Controls.Add(Me.Label28)
		Me.Controls.Add(Me.lblUser)
		Me.Controls.Add(Me.Label38)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.Button17)
		Me.Controls.Add(Me.Label23)
		Me.Controls.Add(Me.Label24)
		Me.Controls.Add(Me.Button21)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.TextBox21)
		Me.Controls.Add(Me.dgw)
		Me.Controls.Add(Me.Button23)
		Me.Controls.Add(Me.ComboBox7)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox22)
		Me.Controls.Add(Me.TextBox8)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ComboBox6)
		Me.Controls.Add(Me.ComboBox4)
		Me.Controls.Add(Me.ComboBox3)
		Me.Controls.Add(Me.LinkLabel2)
		Me.Controls.Add(Me.ComboBox8)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.ForeColor = System.Drawing.Color.Black
		Me.KeyPreview = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Profile"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Profile"
		CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.BindingNavigator1.ResumeLayout(False)
		Me.BindingNavigator1.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.xStart.ResumeLayout(False)
		Me.xStart.PerformLayout()
		CType(Me.dgvUsage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.guests.ResumeLayout(False)
		Me.guests.PerformLayout()
		CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.deposit.ResumeLayout(False)
		Me.deposit.PerformLayout()
		Me.payments.ResumeLayout(False)
		CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.debt.ResumeLayout(False)
		Me.debt.PerformLayout()
		CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.orders.ResumeLayout(False)
		Me.orders.PerformLayout()
		CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.freezBalance.ResumeLayout(False)
		Me.freezBalance.PerformLayout()
		CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.details.ResumeLayout(False)
		Me.details.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.admTools.ResumeLayout(False)
		Me.admTools.PerformLayout()
		CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	ReadOnly Worker As New AsyncWorker()

	Private bindingSource1 As New BindingSource()
	Private dataAdapter As New SqlDataAdapter()
	Private WithEvents reloadButton As New Button()
	Dim blnEscape As Boolean = False
	Dim connetionString As String
	Dim connection As SqlConnection
	Dim connectionRelaxx As SqlConnection
	Dim adapter As SqlDataAdapter
	Dim adapter1 As SqlDataAdapter
	Dim adapter2 As SqlDataAdapter
	Dim adapter3 As SqlDataAdapter
	Dim adapter4 As SqlDataAdapter
	Dim cmdBuilder As SqlCommandBuilder
	Dim dt As DataTable
	Dim ds As New DataSet
	Dim changes As DataSet
	Dim sql, sql1 As String
	Dim i As Integer
	Dim j As Integer

	Function GetdataAll() As SqlDataReader
		Try
			ReadyConnectionF()
			Dim sql As String
			'  sql = "SELECT  id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson  from Customers   &
			' OFFSET " & ((IIf(PageNo.Text = "", 1, CInt(PageNo.Text)) - 1) * 50) & " 
			'ROWS FETCH Next " & 50 & " ROWS ONLY "

			'  sql = "select id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson  from Customers  ORDER BY cardId ASC  OFFSET ((IIf(PageNo.Text = "", 1, CInt(PageNo.Text)) - 1) * 50)  FETCH Next 50 ROWS ONLY"

			sql = "select id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address  from Customers"
			'"OFFSET (10) ROWS FETCH NEXT 50 ROWS ONLY"

			' Dim cmd = New SqlCommand("Select id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
			' "from customers", conn)
			Dim cmd = New SqlCommand(sql, conn)
			'Dim dt As New DataTable()
			'dt.Load(cmd.ExecuteReader())
			'dgw.DataSource = dt
			'  con.Close()
			Return cmd.ExecuteReader(CommandBehavior.CloseConnection)

			' txtCustid.DataBindings.Add("Text", dt, "id")
			'For Each col As DataGridViewColumn In dgw.Columns
			'    col.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell)

			'    ' AdvancedDataGridViewSearchToolBar.
			'Next
		Catch ex As Exception
			'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Function

	Public Function GetdataCust(custid As Integer) As Customer
		Dim res As Customer = Nothing
		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("Select id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " & "from customers where id = '" & custid & " ' ", conn)
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
			End While
			rdr.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return res
	End Function

	Sub GetClipUsage(clipId As Integer)
		'  Dim res As Customer = Nothing
		'Dim tmpCurrentCulture As System.Globalization.CultureInfo
		'tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

		'tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		'tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		'System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

		Try
			Dim custID As Integer = CInt(txtCustid.Text)

			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT usageid,Locationid,attdate,st " &
			 "from AddPrductUsage where customerid = '" & custID & " ' and Locationid = '" & clipId & " ' ", conn)

			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgvUsage.Rows.Clear()
			While rdr.Read() = True
				dgvUsage.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
			End While
			rdr.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		'Return res
	End Sub

	Public Function GetGuestOwner(guestid As Integer) As Customer
		Dim res As Customer = Nothing
		Try
			Dim gID As Integer = CInt(txtCustid.Text)
			Dim custGid As Integer
			custGid = GetGuestOwnerID(gID)
			ReadyConnectionF()



			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
		   "from customers where id = '" & custGid & " ' ", conn)
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			'ListView1.Clear()
			While rdr.Read() = True
				MessageBox.Show(rdr(1) & " " & rdr(2) & " " & rdr(3))
				'ListView1.Items.Add(rdr(0))
				'ListView1.Items.Add(rdr(1))
				'ListView1.Items.Add(rdr(2))
				'ListView1.Items.Add(rdr(3))
			End While
			rdr.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return res
	End Function

	Sub ReadUID()
		If CardReaderAvailable Then
			Try
				txtFind.Text = CardReader.GetUniqueNumber()
			Catch
				MessageBox.Show("Place card on reader")
			End Try
		Else
			MessageBox.Show("Card reader not connected")
		End If
	End Sub

	Sub ReadUID1()
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

	Sub FindName()

		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
	"from customers where FirstName like '" & txtFirst.Text & "%' AND LastName like '" & txtLast.Text & "%'  order by cardid", conn)
			Dim count As Integer
			count = 0
			'  "from customers where FirstName Like '%" & txtFirst.Text & "%' and LastName like '%" & txtLast.Text & "%'  order by cardid", conn)
			'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
				count = count + 1
			End While
			If count > 0 Then
				GetStatus()
				GetDetails()
				Refresh_Tab()
			Else
				MessageBox.Show("No record found!")
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub GetStatus()
		Try
			Dim j As Integer = 0

			Dim countRow = dgw.RowCount
			j = dgw.CurrentRow.Index


			If dgw.Rows.Count > 0 Then
				Dim dr As DataGridViewRow = dgw.SelectedRows(0)
				If Not IsDBNull(dgw.Item("stat", j).Value) Then
					If dgw.Item("stat", j).Value = "disabled" Then
						Disabled.Checked = True
					Else
						Disabled.Checked = False

					End If
					If dgw.Item("stat", j).Value = "allow" Then
						chBoxAllow.Checked = True
					Else
						chBoxAllow.Checked = False

					End If
					If dgw.Item("Cardtype", j).Value = "temp" Then
						tmp.Checked = True

					Else
						tmp.Checked = False

					End If
					If dgw.Item("Cardtype", j).Value = "forgot" Then
						chForgot.Checked = True
					Else
						chForgot.Checked = False
					End If

				End If
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub FindByUID()
		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
	 "From customers Where UID Like '%" & txtFind.Text & "%'  order by cardid", conn)
			'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
			Dim count As Integer
			count = 0
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
				count = count + 1
			End While
			If count > 0 Then
				GetStatus()
				GetDetails()
				Refresh_Tab()
			Else
				MessageBox.Show("No record found!")
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub FindByCustid()
		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
	 "From customers Where id = '" & txtFind.Text & "'  order by id", conn)
			'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
			Dim count As Integer
			count = 0
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
				count = count + 1
			End While
			If count > 0 Then
				GetStatus()
				GetDetails()
				Refresh_Tab()
			Else
				MessageBox.Show("No record found!")
				Exit Sub
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub FindByCardid()
		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
		   "From customers Where Cardid Like '" & txtFind.Text & "%'  order by cardid", conn)
			'       Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
			'"From customers Where Cardid = '" & txtFind.Text & "'  order by cardid", conn)
			'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			Dim count As Integer
			count = 0
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
				count = count + 1

			End While

			If count > 0 Then
				GetStatus()
				GetDetails()
				Refresh_Tab()
			Else

				MessageBox.Show("No record found!")
				Exit Sub
			End If
		Catch ex As Exception
			MessageBox.Show("No record found!")
			' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub FindByPhone()
		Try
			ReadyConnectionF()
			Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson,Address " &
	 "From customers Where  MobilePhone like '%" & txtFind.Text & "%'   order by cardid", conn)
			'  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
			Dim count As Integer
			count = 0
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw.Rows.Clear()
			While rdr.Read() = True
				dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
				count = count + 1
			End While
			If count > 0 Then
				GetStatus()
				GetDetails()
				Refresh_Tab()
			Else

				MessageBox.Show("No record found!")
				Exit Sub
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub GetDetails()
		Dim j As Integer

		Dim countRow = dgw.RowCount
		j = dgw.CurrentRow.Index

		If j <= countRow And j >= 0 Then
			txtFirst.Text = dgw.Item("Firstname", j).Value.ToString
			txtLast.Text = dgw.Item("Lastname", j).Value.ToString
			txtCardId.Text = dgw.Item("Cardid", j).Value.ToString
			txtCustid.Text = dgw.Item("custid", j).Value.ToString
			' txtLastName.Text = DataGridView3.Item("LastName", j).Value.ToString
			txtPhone2.Text = dgw.Item("MobilePhone", j).Value.ToString
			txtBorn.Text = dgw.Item("BornOn", j).Value.ToString
			RichTextBox1.Text = dgw.Item("Notes", j).Value.ToString 'notes
			txtGroup.Text = dgw.Item("Attachments", j).Value.ToString 'gr
			txtUID.Text = dgw.Item("UID", j).Value.ToString 'UID

			txtMail.Text = dgw.Item("Email", j).Value.ToString 'email
			txtManager.Text = dgw.Item("ContactPerson", j).Value.ToString
			txtCompany.Text = dgw.Item("Address", j).Value.ToString
			'TextBox7.Text = ""
		Else
			Exit Sub
		End If

	End Sub

	Private Sub dgw_KeyDown(sender As Object, e As KeyEventArgs) Handles dgw.KeyDown, dgw.KeyDown
		Refresh_Tab()
	End Sub

	Private Sub dgw_KeyUp(sender As Object, e As KeyEventArgs) Handles dgw.KeyUp, dgw.KeyUp
		Refresh_Tab()
	End Sub

	Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint, dgw.RowPostPaint
		Dim strRowNumber As String = (e.RowIndex + 1).ToString()
		Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Font)
		If dgw.RowHeadersWidth < Convert.ToInt32(size.Width + 20) Then
			dgw.RowHeadersWidth = Convert.ToInt32(size.Width + 20)
		End If
		Dim b As Brush = SystemBrushes.ControlText
		e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
	End Sub

	Private Sub dgvOrders_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvOrders.RowPostPaint, dgvOrders.RowPostPaint
		Dim strRowNumber As String = (e.RowIndex + 1).ToString()
		Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Font)
		If dgvOrders.RowHeadersWidth < Convert.ToInt32(size.Width + 20) Then
			dgvOrders.RowHeadersWidth = Convert.ToInt32(size.Width + 20)
		End If
		Dim b As Brush = SystemBrushes.ControlText
		e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
	End Sub

	Sub relaxxGroup()
		ReadyConnectionF()
		Dim adapter As SqlDataAdapter


		Dim cmd1 As New SqlCommand
		Dim da As New SqlDataAdapter
		Dim ds As New DataSet
		Dim dt As New DataTable



		Dim sqlRelaxx As String

		sqlRelaxx = "select * from AuthorizationGroup"

		adapter = New SqlDataAdapter(sqlRelaxx, conn)
		adapter.Fill(ds, "dtGroup")
		With ComboBox15
			.DisplayMember = "dtGroup.Name"
			.ValueMember = "RecordId"
			.DataSource = ds
			.SelectedIndex = -1
		End With

		TextBox7.DataBindings.Clear()
		TextBox7.DataBindings.Add("Text", ds, "dtGroup.RecordId")
	End Sub

	Sub Admin()
		ReadyConnectionF()

		Dim sqlEmpl As String
		sqlEmpl = "Select * from Emp"
		Dim dacust As New SqlDataAdapter
		dacust = New SqlDataAdapter(sqlEmpl, conn)
		dacust.Fill(ds, "Emp")


		With cmbAdmin
			.DisplayMember = "Emp.Name"
			.ValueMember = "ID"
			.DataSource = ds
			.SelectedIndex = -1
		End With
	End Sub

	Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim worker As New BackgroundWorker With {.WorkerReportsProgress = False, .WorkerSupportsCancellation = True}
		Dim disposedGridView As Boolean

		AddHandler dgw.Disposed, Sub(workSender As Object, args As EventArgs)
									 disposedGridView = True

								 End Sub

		Dim rows As New List(Of Object())
		Dim rowList As New List(Of DataGridViewRow)()
		InitCardReader()

		' Handle the DoWork event - where background work happens
		AddHandler worker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
									  ' Fetch data in the background
									  Dim rdr = GetdataAll()
									  While rdr.Read()
										  ' Add row data to list
										  rows.Add(New Object() {rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13)})
									  End While
									  ' Add all rows to DataGridView at once
									  For Each rowData As Object() In rows
										  If Not disposedGridView Then
											  Dim row As New DataGridViewRow()
											  row.CreateCells(dgw, rowData) ' Create cells for the DataGridViewRow and assign data
											  ' Add the row to the DataGridView
											  rowList.Add(row)
										  End If


									  Next
									  rdr.Close()

								  End Sub

		' Handle the RunWorkerCompleted event - when the work is complete

		AddHandler worker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
												  ' Ensure that the DataReader is retrieved safely

												  Try
													  If Not disposedGridView Then
														  dgw.Rows.Clear()
														  dgw.Rows.AddRange(rowList.ToArray())
														  ' Update UI components
														  GetStatus()
														  TabControl1.BackColor = Color.Blue
														  fillComboProduct()
														  FillCoach()
														  ref()
													  End If

												  Finally
													  ' Ensure reader is closed
												  End Try



											  End Sub

		' Start the background worker asynchronously
		worker.RunWorkerAsync()

	End Sub

	Sub ref()
		relaxxGroup()
		Admin()
	End Sub

	Private Sub dataGridView5_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView5.CellFormatting
		If DataGridView5.Columns(e.ColumnIndex).Name.Equals("ordActive") Then
			If e.Value = "1" Then
				DataGridView5.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.SkyBlue
			Else
				DataGridView5.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
			End If
		End If
	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
		Refresh_Form()
	End Sub

	Sub Refresh_Tab()
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")
		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

		Dim allOrdersDataSet As DataSet
		Dim allPaymentsDataSet As DataSet
		Dim freezeDataSet As DataSet
		Dim planDataSet As DataSet
		Dim guestBalanceDataSet As DataSet
		Dim guestCustmerDataset As DataSet

		Dim clipDataReader As ComplexReader

		Dim clipUsageDataReader As ComplexReader



		Dim allOrdersWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim allPaymentsWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim freezeWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim planDataWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}

		Dim GuestBalanceWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim GuestCustomerWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}

		Dim clipWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim clipUSageWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}
		Dim checkInWorker As New BackgroundWorker With {
				 .WorkerReportsProgress = False, ' No need for progress reporting if not used
				 .WorkerSupportsCancellation = True
	}

#Region "Background Threads"

		AddHandler allOrdersWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
											   Dim st = Stopwatch.StartNew()
											   allOrdersDataSet = AllOrdersAsync()
											   st.Stop()
											   Debug.WriteLine(st.ElapsedMilliseconds)
										   End Sub

		AddHandler allOrdersWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
														   Button36.Enabled = False
														   orders.Text = "All orders"
														   dgvOrders.DataSource = allOrdersDataSet
														   dgvOrders.DataMember = "OrdersFullLast"
													   End Sub

		AddHandler allPaymentsWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
												 allPaymentsDataSet = GetPaymentsAsync()
											 End Sub

		AddHandler allPaymentsWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
															 DataGridView4.DataSource = allPaymentsDataSet
															 DataGridView4.DataMember = "dtPay"
														 End Sub

		AddHandler planDataWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
											  planDataSet = GetDebtAsync()
										  End Sub

		AddHandler planDataWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
														  DataGrid2.DataSource = planDataSet.Tables("PlanDebt")
														  DataGrid2.CaptionText = "Payment Debt"
													  End Sub

		AddHandler freezeWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
											freezeDataSet = GetFreezAsync()
										End Sub


		AddHandler freezeWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
														DataGrid8.DataSource = freezeDataSet
														DataGrid8.DataMember = "FreezPaidFree"
														DataGrid8.CaptionText = "Freezing Balance"
														If DataGrid8.CurrentRowIndex + 1 > 0 Then
															TextBox15.Text = DataGrid8(DataGrid8.CurrentRowIndex, 4) '
															Dim ds1 = GetFreezeBalanceAsync()
															DataGrid6.DataSource = ds1
															DataGrid6.DataMember = "FreezBalance"
															DataGrid6.CaptionText = "Freezing History"
														Else
															DataGrid6.DataSource = Nothing
														End If
													End Sub

		AddHandler GuestCustomerWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
												   guestCustmerDataset = GuestCustomerAsync()
											   End Sub

		AddHandler GuestCustomerWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
															   DataGridView6.DataSource = guestCustmerDataset.Tables("guestCust")
														   End Sub

		AddHandler GuestBalanceWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
												  guestBalanceDataSet = GuestGetBalanceAsync()
											  End Sub

		AddHandler GuestBalanceWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
															  DataGridView5.DataSource = guestBalanceDataSet.Tables("guestBalance1")
															  DataGridView5.Refresh()
														  End Sub

		AddHandler clipWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
										  clipDataReader = GetClipDataReader()
									  End Sub

		AddHandler clipWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
													  dgw1.Rows.Clear()
													  Using clipDataReader.SqlConnection
														  Using clipDataReader.SqlDataReader
															  While clipDataReader.SqlDataReader.Read()
																  dgw1.Rows.Add(clipDataReader.SqlDataReader(0), clipDataReader.SqlDataReader(1), clipDataReader.SqlDataReader(2), clipDataReader.SqlDataReader(3), clipDataReader.SqlDataReader(4), clipDataReader.SqlDataReader(5), clipDataReader.SqlDataReader(6), clipDataReader.SqlDataReader(7), clipDataReader.SqlDataReader(8), clipDataReader.SqlDataReader(9), clipDataReader.SqlDataReader(10), clipDataReader.SqlDataReader(11), clipDataReader.SqlDataReader(12), clipDataReader.SqlDataReader(13), clipDataReader.SqlDataReader(14))
															  End While
															  If dgw1.Rows.Count > 0 Then
																  i = dgw1.CurrentRow.Index
																  Dim dr As DataGridViewRow = dgw1.SelectedRows(i)

																  If dr.Cells(0).Value.ToString() = "" Then
																	  cmbProd.SelectedIndex = -1
																  Else
																	  cmbProd.Text = dr.Cells(0).Value.ToString()
																  End If
																  If dr.Cells(1).Value.ToString() = "" Then
																	  cmbCoach.SelectedIndex = -1
																  Else
																	  cmbCoach.Text = dr.Cells(1).Value.ToString()
																  End If

																  txtFree.Text = dr.Cells(2).Value.ToString()
																  dtpDate.Text = dr.Cells(3).Value
																  dtEnd.Text = dr.Cells(5).Value
																  txtUsed.Text = dr.Cells(4).Value.ToString()


																  txtClid.Text = dr.Cells(8).Value.ToString()
																  txtAmount.Text = dr.Cells(14).Value.ToString()
																  btnSave.Enabled = False
															  End If
															  If txtClid.Text <> "" Then
																  clipUSageWorker.RunWorkerAsync()
															  End If
														  End Using

													  End Using
												  End Sub

		AddHandler clipUSageWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
											   clipUsageDataReader = GetClipUsageAsync()
										   End Sub

		AddHandler clipUSageWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
														   dgvUsage.Rows.Clear()
														   If clipUsageDataReader.SqlConnection IsNot Nothing Then
															   Using clipUsageDataReader.SqlConnection
																   If clipUsageDataReader.SqlDataReader IsNot Nothing Then
																	   Using clipUsageDataReader.SqlDataReader
																		   While clipUsageDataReader.SqlDataReader.Read()
																			   dgvUsage.Rows.Add(clipUsageDataReader.SqlDataReader(0), clipUsageDataReader.SqlDataReader(1), clipUsageDataReader.SqlDataReader(2), clipUsageDataReader.SqlDataReader(3))
																		   End While
																	   End Using
																   End If

															   End Using
														   End If
													   End Sub


		Dim dtTable As DataTable

		AddHandler checkInWorker.DoWork, Sub(workSender As Object, args As DoWorkEventArgs)
											 dtTable = GetCheckInHistoryAsync()
										 End Sub

		AddHandler checkInWorker.RunWorkerCompleted, Sub(workFinished As Object, wf As RunWorkerCompletedEventArgs)
														 Dim bindingSource As New BindingSource
														 bindingSource.DataSource = dtTable
														 DataGridView2.DataSource = bindingSource
														 BindingNavigator1.BindingSource = bindingSource
														 DataGridView2.AutoResizeColumns(
														 DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
														 DataGridView2.Columns(0).Visible = False
														 DataGridView2.Visible = True
													 End Sub

#End Region


		planDataWorker.RunWorkerAsync()
		freezeWorker.RunWorkerAsync()
		allPaymentsWorker.RunWorkerAsync()
		allOrdersWorker.RunWorkerAsync()
		GuestBalanceWorker.RunWorkerAsync()
		GuestCustomerWorker.RunWorkerAsync()
		clipWorker.RunWorkerAsync()
		checkInWorker.RunWorkerAsync()
		'ReadyConnectionF()
		'AllOrders()
		'tabPayments()
		'tabFreez()
		tabDebt()
		'tabGuest()
		'tabClip()

		GetStatus()
		GetDetails()
		' checkInHistory()

		Refresh_Form()
	End Sub

	Function GetFreezeBalanceAsync()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim ordid As Integer
		ordid = DataGrid8(DataGrid8.CurrentRowIndex, 7)
		Dim connection = GetSqlConnection()
		Dim da6 As New SqlDataAdapter
		Dim ds1 As New DataSet
		Using connection
			Dim cmd As New SqlCommand
			cmd = connection.CreateCommand
			Using cmd
				cmd.CommandText = "select * from FreezBalance where CustomerID = '" & custID & "' and orderid='" & ordid & "' "
				da6.SelectCommand = cmd
				da6.Fill(ds1, "FreezBalance")
			End Using
			Return ds1
		End Using
	End Function

	Sub Refresh_Form()
		Dim str As String = Trim(txtCardId.Text)
		Dim path As String = imagePath & str & ".jpg"
		Dim fs As FileStream
		' Specify a valid picture file path on your computer.

		If File.Exists(path) Then
			fs = New FileStream(path, FileMode.Open, FileAccess.Read)
			pView.Image = Image.FromStream(fs)
			fs.Close()

			'If File.Exists(Path) Then
			'    pView.Image = Image.FromFile(Path)

		Else
			pView.Image = Nothing
		End If

		pView.SizeMode = PictureBoxSizeMode.StretchImage
		pView.Refresh()



	End Sub

	Sub deletePhoto()

		Dim str As String = txtCardId.Text
		Dim SourcePath As String = imagePath & str & ".jpg" '"c:\SomeFolder\SomeFileYouWantToCopy.txt" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
		Dim SaveDirectory As String = imagePath ' "c:\DestinationFolder"

		Dim Filename As String = Path.GetFileName(SourcePath) 'get the filename of the original file without the directory on it
		Dim SavePath As String = Path.Combine(SaveDirectory, Filename) 'combines the saveDirectory and the filename to get a fully qualified path.

		Filename = imagePath & str & ".jpg"




		If File.Exists(SavePath) Then

			If MsgBox(" Delete Photo?", MsgBoxStyle.OkCancel, "Info") = MsgBoxResult.Ok Then

				Kill(Filename)

				MsgBox("File Deleted")

			Else
				Exit Sub


			End If
		End If


		pView.Refresh()

		Refresh_Form()
	End Sub

	Sub tabClip()
		Dim cID As Integer = CInt(txtCustid.Text)

		Getdata()
		'GetClipUsageCust(cID)
		If txtClid.Text <> "" Then
			GetClipUsage(CInt(txtClid.Text))
		End If
	End Sub

	Function GetClipUsageAsync() As ComplexReader
		Dim readerData As SqlDataReader
		Dim connection As SqlConnection
		Try
			Dim custID As Integer = CInt(txtCustid.Text)
			connection = GetSqlConnection()
			Dim cmd = New SqlCommand("SELECT usageid,Locationid,attdate,st " &
			 "from AddPrductUsage where customerid = '" & custID & " ' and Locationid = '" & CInt(txtClid.Text) & " ' ", connection)
			readerData = cmd.ExecuteReader()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Dim com As New ComplexReader With {.SqlConnection = connection, .SqlDataReader = readerData}
		Return com

	End Function

	Function GetDebtAsync() As DataSet
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim dsDebt As New DataSet
		Dim da As New SqlDataAdapter
		Dim cmd As New SqlCommand
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			Dim connection = GetSqlConnection()
			Using connection
				Dim cmdPayment As SqlCommand
				cmdPayment = connection.CreateCommand()
				Using cmdPayment
					cmdPayment.CommandText = "Select orderID,  PaymentBasic,[Planned Date],[Planned Payment],Paid,Debt from PlanDebt where CustomerID = '" & custID & " ' "
					Dim daPayment As New SqlDataAdapter
					daPayment.SelectCommand = cmdPayment
					daPayment.Fill(dsDebt, "PlanDebt")
				End Using

			End Using
		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
		End Try
		Return dsDebt
	End Function

	Sub tabDebt()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim ds As New DataSet
		Dim da As New SqlDataAdapter
		Dim cmd As New SqlCommand
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			ReadyConnectionF()
			Dim cmdPayment As SqlCommand
			cmdPayment = conn.CreateCommand()

			cmdPayment.CommandText = "Select orderID,  PaymentBasic,[Planned Date],[Planned Payment],Paid,Debt from PlanDebt where CustomerID = '" & custID & " ' "
			Dim daPayment As New SqlDataAdapter
			daPayment.SelectCommand = cmdPayment
			daPayment.Fill(ds, "PlanDebt")
			DataGrid2.DataSource = ds.Tables("PlanDebt")
			DataGrid2.CaptionText = "Payment Debt"
		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
		End Try
	End Sub

	Function GuestGetBalanceAsync() As DataSet
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim balanceDataSet As New DataSet
		Try
			Dim connection = GetSqlConnection()
			Using connection
				Dim cmdAdd As SqlCommand
				cmdAdd = connection.CreateCommand()
				Using cmdAdd
					cmdAdd.CommandText = "Select * from guestBalance1 where ID = '" & custID & " '  order by orderDate "
					Dim daAdd As New SqlDataAdapter
					daAdd.SelectCommand = cmdAdd
					daAdd.Fill(balanceDataSet, "guestBalance1")
				End Using

			End Using

		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
		End Try
		Return balanceDataSet

	End Function

	Function GuestCustomerAsync() As DataSet
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim customerDataSet As New DataSet
		Try
			Dim connection = GetSqlConnection()
			Using connection
				Dim cmdCustomer As SqlCommand
				cmdCustomer = connection.CreateCommand()
				Using cmdCustomer
					cmdCustomer.CommandText = "Select * from guestCust where CustomerID = '" & custID & " ' "
					Dim daGuest As New SqlDataAdapter
					daGuest.SelectCommand = cmdCustomer
					daGuest.Fill(customerDataSet, "guestCust")
				End Using

			End Using

		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
		End Try
		Return customerDataSet
	End Function

	Sub tabGuest()
		Dim custID As Integer = CInt(txtCustid.Text)
		'GuestBalance
		Try
			ReadyConnectionF()
			Dim cmdAdd As SqlCommand
			cmdAdd = conn.CreateCommand()
			Dim ds As New DataSet
			cmdAdd.CommandText = "Select * from guestBalance1 where ID = '" & custID & " '  order by orderDate "
			Dim daAdd As New SqlDataAdapter
			daAdd.SelectCommand = cmdAdd
			daAdd.Fill(ds, "guestBalance1")
			DataGridView5.DataSource = ds.Tables("guestBalance1")
			DataGridView5.Refresh()

			'guestCust list
			Dim cmdGuest As SqlCommand
			cmdGuest = conn.CreateCommand()

			cmdGuest.CommandText = "Select * from guestCust where CustomerID = '" & custID & " ' "
			Dim daGuest As New SqlDataAdapter
			daGuest.SelectCommand = cmdGuest
			daGuest.Fill(ds, "guestCust")
			DataGridView6.DataSource = ds.Tables("guestCust")
		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
		End Try
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If DataGrid8.CurrentRowIndex + 1 > 0 Then

			j = DataGrid8.CurrentRowIndex
			If AdminByReason("freezing") = True Then
				freez()

				' 
				' Refresh_Tab()
				tabFreez()
				tabClip()
				DataGrid8.CurrentRowIndex = j

			End If
			freezAdminDisplay()
		Else
			Exit Sub
		End If
	End Sub

	Sub freez()

		Dim custID As Integer = CInt(txtCustid.Text)
		Dim OrdID, ind, checkPaid As Integer
		Dim cmd As New SqlCommand
		'
		Dim D1 As Date = DateTimePicker2.Value
		Dim D2 As Date = DateTimePicker3.Value
		ind = DateDiff(DateInterval.Day, D1, D2)

		Dim provider As CultureInfo = CultureInfo.InvariantCulture
		Dim DP2 As String = DateTimePicker2.Text
		Dim DP3 As String = DateTimePicker3.Text

		Dim dateString1, dateString2, format As String
		Dim reDate, reendDate As Date

		dateString1 = DP2
		dateString2 = DP3
		format = "dd/MM/yyyy"

		reDate = Date.ParseExact(dateString1, format, provider)
		reendDate = Date.ParseExact(dateString2, format, provider)

		Try
			Dim j As Integer
			j = DataGrid8.CurrentRowIndex
			If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 7)) Then
				OrdID = DataGrid8(DataGrid8.CurrentRowIndex, 7)  'orderid
			End If



			If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 4)) Then
				checkPaid = DataGrid8(DataGrid8.CurrentRowIndex, 4)  'balance
			End If




			'++++++MaxFreezDate   for current order
			Dim x As Integer = TextBox11.Text
			' Dim MaxEnd As DateTime
			Dim res As Integer

			ReadyConnectionF()


			'conn.Open()

			Dim ResAct As Integer

			Dim cmdActive As New SqlCommand
			cmdActive = conn.CreateCommand
			cmdActive.CommandText = "select count(orderid) from OrdActive where CustomerID = '" & custID & " ' and orderid='" & OrdID & "'and (OrderDate <= Convert(date, '" & reDate & " ', 103) )"

			ResAct = ExecuteScalar(cmdActive)
			If ResAct = 0 Then
				MsgBox("Client order not Active or Failure Date Period", MsgBoxStyle.OkOnly, "Info ")

				Exit Sub
			Else






				Dim cmdFreezEnd As New SqlCommand
				cmdFreezEnd = conn.CreateCommand

				cmdFreezEnd.CommandText = "select count(CustomerID)  from Freezing where OrderID ='" & OrdID & "' and (EndDate >= Convert(date, '" & reDate & " ', 103)  and Convert(date, '" & reendDate & " ', 103)>=StartDate) "

				res = ExecuteScalar(cmdFreezEnd)
				If res > 0 Then
					MsgBox(" Failure Date Period", MsgBoxStyle.OkOnly, "Info ")
					DateTimePicker2.Focus()
					Exit Sub

				Else

					If x < Val(TextBox14.Text) Then
						MsgBox(" Minimum Freezing Days Failure", MsgBoxStyle.OkOnly, "Info ")
						DateTimePicker2.Focus()
						Exit Sub
					Else

						'++++++MaxFreezDate   for current order


						Dim cmdAtt As SqlCommand
						cmdAtt = conn.CreateCommand

						cmdAtt.CommandText = "select count(customerid) from GatCheckin where customerid = '" & custID & " ' and  DateCheckin between Convert(date, '" & reDate & " ', 103)  and Convert(date, '" & reendDate & " ', 103)"

						' conn.Open()
						Dim check2 As Integer = ExecuteScalar(cmdAtt)
						If check2 > 0 Then
							MsgBox("Client have attendance in selected period!", MsgBoxStyle.OkOnly, "Info")

							Exit Sub

						Else
							'  conn.Close()
							'*****************
							'   dublicate()


							Dim cmd2 As New SqlCommand





							If checkPaid <= ind Then
								MsgBox(" Not avialable days", MsgBoxStyle.OkOnly, "Info Freezing")
								Exit Sub
							Else

								Dim FreezID As Integer
								Dim s As String = "select max(FreeezingID)  from Freezing"
								Dim ds As New DataSet
								Dim da As New SqlDataAdapter
								' conn.Open()

								Dim cmdID As New SqlCommand
								cmdID = conn.CreateCommand
								cmdID.CommandText = "select max(FreeezingID)  from Freezing"

								Dim sqlResult As Object = ExecuteScalar(cmdID)
								If IsDBNull(sqlResult) Then

									TextBox12.Text = 1

								Else

									sqlResult.ToString() 'result found

									FreezID = cmdID.ExecuteScalar
									TextBox12.Text = FreezID + 1


								End If

								' conn.Open()
								Dim cmdFreezDub As New SqlCommand

								cmdFreezDub = conn.CreateCommand
								Dim yy As String = DatePart(DateInterval.Year, DateTimePicker2.Value)
								Dim mm As String = DatePart(DateInterval.Month, DateTimePicker2.Value)
								Dim dd As String = DatePart(DateInterval.Day, DateTimePicker2.Value)
								Dim StDate As String
								StDate = Trim(yy) & Trim(mm) & Trim(dd)
								'   Debug.Write(StDate)
								Dim yyy As String = DatePart(DateInterval.Year, DateTimePicker3.Value)
								Dim mmm As String = DatePart(DateInterval.Month, DateTimePicker3.Value)
								Dim ddd As String = DatePart(DateInterval.Day, DateTimePicker3.Value)
								Dim EnDate As String
								EnDate = Trim(yyy) & Trim(mmm) & Trim(ddd)

								cmdFreezDub.CommandText = "select FreeezingID from FreezDate where OrderID ='" & OrdID & "' and StartStr= '" & StDate & " ' and EndStr = '" & EnDate & " '"
								Dim sqlResult2 As Object
								sqlResult2 = ExecuteScalar(cmdFreezDub)
								If Not sqlResult2 Is Nothing Then


									sqlResult2.ToString() 'result found
									Dim m As String
									m = ExecuteScalar(cmdFreezDub)

									MsgBox(" Date period dublicate!", MsgBoxStyle.OkOnly, "Info ")
									DateTimePicker2.Focus()
									' conn.Close()
									Exit Sub
									'  conn.Close()
								End If
								Dim today = Date.Today

								Dim month = today.Month
								Dim todayYear = today.Year
								'   If lblUserId.Text = 3 And (reDate.Month < month Or reDate.AddDays(ind).Month < month) Then
								If (lblUserId.Text = 3 OrElse lblUserId.Text = 6 OrElse lblUserId.Text = 8) And (reDate < today) And (reDate.Month < month Or reDate.AddDays(ind).Month < month) Then
									MsgBox("You can't freeze to a previous date", MsgBoxStyle.OkOnly, "Info ")
									Exit Sub
								Else
									Dim cmdfreez As New SqlCommand


									cmdfreez = conn.CreateCommand
									' cmdfreez.Parameters.Clear()
									cmdfreez.Parameters.Add("@FreeezingID", SqlDbType.Int).Value = Int(TextBox12.Text)
									cmdfreez.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = reDate '
									' cmdfreez.Parameters.Add("@EndDate", Data.SqlDbType.DateTime).Value = StartDate.AddDays(ind - 1)
									cmdfreez.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = reDate.AddDays(ind) '
									cmdfreez.Parameters.Add("@Days", SqlDbType.SmallInt).Value = ind + 1
									cmdfreez.Parameters.Add("@FreezCategory", SqlDbType.NVarChar).Value = 1 ' ComboBox10.Text
									cmdfreez.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = TextBox13.Text
									cmdfreez.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrdID
									cmdfreez.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


									cmdfreez.CommandText = "Insert into Freezing VALUES (@FreeezingID ,@StartDate,@EndDate,@Days,@FreezCategory,@Notes, @OrderID,@CustomerID)"

									ExecuteReader(cmdfreez)

									ReadyConnectionF()
									GetClipFeezAdd(custID, ind)


								End If



								GetOrders(custID)

							End If
							MsgBox(" Succesfully To Update", MsgBoxStyle.OkOnly, "Info")

						End If
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, " Error !!")
		End Try

		TextBox13.Text = ""


	End Sub

	Sub deleteFreez()

		Dim custID As Integer = CInt(txtCustid.Text)

		Dim OrdID, ind, days As Integer
		Dim cmd As New SqlCommand

		Dim D1 As Date = DateTimePicker2.Value
		Dim D2 As Date = DateTimePicker3.Value
		'   ind = DateDiff(DateInterval.Day, D1, D2)

		'  Try

		'freezbalance
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 0)) Then
			TextBox16.Text = DataGrid6(DataGrid6.CurrentRowIndex, 0)
			'orderid
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 1)) Then
			DateTimePicker2.Value = DataGrid6(DataGrid6.CurrentRowIndex, 1)  'FreezStartDate
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 2)) Then
			DateTimePicker3.Value = DataGrid6(DataGrid6.CurrentRowIndex, 2)  'FreezEndDate
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 3)) Then
			days = DataGrid6(DataGrid6.CurrentRowIndex, 3)  'days
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 6)) Then
			TextBox12.Text = DataGrid6(DataGrid6.CurrentRowIndex, 6)  'freezID
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 5)) Then
			TextBox13.Text = DataGrid6(DataGrid6.CurrentRowIndex, 5)  'notes
		End If
		'If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 7)) Then

		'    TextBox17.Text = DataGrid6(DataGrid6.CurrentRowIndex, 7)  'OrderEndDate
		'End If
		OrdID = DataGrid6(DataGrid6.CurrentRowIndex, 0) ' Int(TextBox16.Text)

		' ind = CInt(TextBox11.Text)
		ind = DataGrid6(DataGrid6.CurrentRowIndex, 3)
		'++++++MaxFreezDate   for current order
		' UpdateDate(DataGrid6(DataGrid6.CurrentRowIndex, 0), ind)
		'check attendance
		Dim provider As CultureInfo = CultureInfo.InvariantCulture
		Dim DP2 As String = DateTimePicker2.Text
		Dim DP3 As String = DateTimePicker3.Text
		' Dim DP4 As String = DataGrid6(DataGrid6.CurrentRowIndex, 7)
		Dim dateString1, dateString2, format As String
		Dim reDate, reendDate As Date

		dateString1 = DP2
		dateString2 = DP3
		'  dateString3 = DP4
		format = "dd/MM/yyyy"

		reDate = Date.ParseExact(dateString1, format, provider)
		reendDate = Date.ParseExact(dateString2, format, provider)
		' Enddate = Date.ParseExact(dateString3, format, provider)
		' Try
		ReadyConnectionF()
		Dim cmdAtt As SqlCommand
		cmdAtt = conn.CreateCommand
		cmdAtt.CommandText = "select count(orderid) from AttendOrder where OrderID = '" & TextBox16.Text & " ' and AttDate between '" & reDate & " ' and  '" & reendDate & " ' "

		Dim check2 As Integer = ExecuteScalar(cmdAtt)
		If check2 > 0 Then
			MsgBox("  Client have  " & check2 & "attendance!", MsgBoxStyle.OkOnly, "Info")
			Exit Sub
		Else

			'*****************
			Dim cmdfreez As New SqlCommand


			cmdfreez = conn.CreateCommand

			cmdfreez.CommandText = "Delete from Freezing where FreeezingID = '" & TextBox12.Text & " '"

			Dim check1 As Integer = ExecuteReader(cmdfreez).RecordsAffected
			If check1 > 0 Then
				'  Dim dt As Date = Now().AddDays(-ind - 1)
				GetClipFeezDel(custID, ind)

				MsgBox(" Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete")
			Else
				MsgBox(" Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete")
			End If
		End If


		GetOrders(custID)
	End Sub

	Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
		Dim ind As Integer
		Dim D1 As Date = DateTimePicker2.Value
		Dim D2 As Date = DateTimePicker3.Value

		ind = DateDiff(DateInterval.Day, D1, D2)
		If ind > 0 Then
			' TextBox11.Text = ind
			TextBox25.Text = ind
		End If
	End Sub

	Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
		Dim ind As Integer
		Dim D1 As Date = DateTimePicker2.Value
		Dim D2 As Date = DateTimePicker3.Value

		ind = DateDiff(DateInterval.Day, D1, D2)
		If ind > 0 Then
			TextBox11.Text = ind
			TextBox25.Text = ind
		End If
	End Sub

	Private Sub DataGrid8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGrid8.KeyPress
		If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 0)) Then
			TextBox16.Text = DataGrid8(DataGrid8.CurrentRowIndex, 0)  'orderid
		End If

		If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 5)) Then
			TextBox15.Text = DataGrid8(DataGrid8.CurrentRowIndex, 5)  'balance
		End If
		freezAdminDisplay()
	End Sub

	Private Sub DataGrid6_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid6.DoubleClick
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 0)) Then
			TextBox16.Text = DataGrid6(DataGrid6.CurrentRowIndex, 0)  'orderid
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 1)) Then
			DateTimePicker2.Value = DataGrid6(DataGrid6.CurrentRowIndex, 1)  'FreezStartDate
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 2)) Then
			DateTimePicker3.Value = DataGrid6(DataGrid6.CurrentRowIndex, 2)  'FreezEndDate
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 3)) Then
			TextBox11.Text = DataGrid6(DataGrid6.CurrentRowIndex, 3)  'days
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 6)) Then
			TextBox12.Text = DataGrid6(DataGrid6.CurrentRowIndex, 6)  'freezID
		End If
		If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 5)) Then
			TextBox13.Text = DataGrid6(DataGrid6.CurrentRowIndex, 5)  'notes
		End If
		'If Not IsDBNull(DataGrid6(DataGrid6.CurrentRowIndex, 7)) Then
		'    TextBox17.Text = DataGrid6(DataGrid6.CurrentRowIndex, 7)  'OrderEndDate
		'End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		deleteFreez()
		tabFreez()
		tabClip()
	End Sub

	Sub checkinOld()
		Dim custId = txtCustid.Text
		DataGridView2.DataSource = bindingSource1
		GetDataF("select  * from GatCheckInBackUp where Customerid = '" & custId & "' ORDER BY DateCheckin DESC")
		' GetDataF("select DateCheckIn from ReportCheckIn where ID = '" & ComboBox7.SelectedValue & "'")
		DataGridView2.Columns(0).Visible = False

		DataGridView2.Visible = True
	End Sub

	Sub checkInHistory()
		Dim custID As Integer = CInt(txtCustid.Text)
		DataGridView2.DataSource = bindingSource1
		GetDataF("select top 10 * from GatCheckIn where Customerid = '" & custID & "' ORDER BY DateCheckin DESC")
		DataGridView2.Columns(0).Visible = False

		DataGridView2.Visible = True
	End Sub

	Sub checkinAll()
		Dim custId = txtCustid.Text
		DataGridView2.DataSource = bindingSource1
		GetDataF("select  * from GatCheckIn where Customerid = '" & custId & "' ORDER BY DateCheckin DESC")
		' GetDataF("select DateCheckIn from ReportCheckIn where ID = '" & ComboBox7.SelectedValue & "'")
		DataGridView2.Columns(0).Visible = False

		DataGridView2.Visible = True
	End Sub

	Private Function getAllControls(mainControl As Control, allControls As List(Of Control)) As List(Of Control)

		If Not allControls.Contains(mainControl) Then allControls.Add(mainControl)
		If mainControl.HasChildren Then

			For Each child In mainControl.Controls

				If Not allControls.Contains(DirectCast(child, Control)) Then allControls.Add(DirectCast(child, Control))
				If DirectCast(child, Control).HasChildren Then getAllControls(DirectCast(child, Control), allControls)
			Next
		End If

		Return allControls
	End Function

	Private Sub SetControls()
		For Each ctl As Control In xStart.Controls
			If TypeOf ctl Is Button Then
				Console.WriteLine(ctl.Text)
			End If
		Next
	End Sub

	Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
		SetControls()
		updManager()
	End Sub

	Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
		Dim SelectedTab As TabPage = TabControl1.TabPages(e.Index)
		Dim HeaderRect As Rectangle = TabControl1.GetTabRect(e.Index)
		Dim BlackTextBrush As New SolidBrush(Color.Black)
		Dim RedTextBrush As New SolidBrush(Color.Black)
		Dim sf As New StringFormat()
		sf.Alignment = StringAlignment.Center
		sf.LineAlignment = StringAlignment.Center

		If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
			e.Graphics.FillRectangle(New SolidBrush(Color.Aquamarine), HeaderRect)
			Dim BoldFont As New Font(TabControl1.Font.Name, TabControl1.Font.Size, FontStyle.Italic)
			e.Graphics.DrawString(SelectedTab.Text, BoldFont, RedTextBrush, HeaderRect, sf)
		Else
			e.Graphics.DrawString(SelectedTab.Text, e.Font, BlackTextBrush, HeaderRect, sf)
		End If

		BlackTextBrush.Dispose()
		RedTextBrush.Dispose()
	End Sub

	Sub SaveEdited()
		If MsgBox("Are you sure to save data  ?", MsgBoxStyle.YesNo, "Saving") = MsgBoxResult.No Then

		Else
			Dim custId As Integer
			custId = txtCustid.Text
			Dim cmd1 As New SqlCommand

			ReadyConnectionF()

			Dim notStat, cardType As String
			If Disabled.Checked = True Then
				'status = UID
				notStat = "disabled"
			Else
				'status = UID
				notStat = "enabled"
			End If
			If chBoxAllow.Checked = True Then
				' status = Trim(TextBox22.Text)
				notStat = "allow"
			Else
			End If
			If tmp.Checked = True Then
				cardType = "temp"
			Else
				If chForgot.Checked = True Then
					cardType = "forgot"

				Else
					cardType = "permanent"
				End If
			End If
			Dim cmdDatabase As New SqlCommand

			cmdDatabase = conn.CreateCommand
			cmdDatabase.Parameters.Add("@Status", SqlDbType.VarChar).Value = notStat
			cmdDatabase.Parameters.Add("@CardType", SqlDbType.VarChar).Value = cardType 'temporary
			cmdDatabase.CommandText = "Update Customers set Status =@Status,CardType=@CardType where id = '" & custId & "' "
			ExecuteNonQuery(cmdDatabase)
			MsgBox("Done", MsgBoxStyle.Information, "Message :")
		End If
	End Sub

	Async Function UpdateUID() As Task
		If Not AdminByReason("UID updated") Then
			Return
		End If

		Dim customerId = CInt(txtCustid.Text)
		Dim manually = MessageBox.Show("Fingerprint manual set:", "Message", MessageBoxButtons.YesNoCancel)
		Await Worker.RunWork(
			Sub()
				Dim cmdDatabase = conn.CreateCommand()
				cmdDatabase.Parameters.Add("@UID", SqlDbType.VarChar).Value = Trim(txtUID.Text)

				If (manually = DialogResult.Cancel) Then
					cmdDatabase.CommandText = "UPDATE Customers SET UID = @UID WHERE id = '" & customerId & "'"
				Else
					cmdDatabase.CommandText = "UPDATE Customers SET UID = @UID, fp = @Fp WHERE id = '" & customerId & "'"
					cmdDatabase.Parameters.Add("@Fp", SqlDbType.SmallInt).Value = If(manually = DialogResult.Yes, 8, 7)
				End If

				cmdDatabase.ExecuteNonQuery()
			End Sub)
		Dim result = Await Worker.RunWork(
			Function()
				Dim cmd As New SqlCommand("SELECT fp FROM Customers WHERE id = @ID", conn)
				cmd.Parameters.Add("@ID", SqlDbType.Int).Value = customerId
				Return cmd.ExecuteScalar()
			End Function)

		lblFP.Text = If(result IsNot Nothing AndAlso IsNumeric(result) AndAlso result = 8, "WITH FINGERPRINT", "WITHOUT FINGERPRINT")
		GetdataCust(customerId)
		GetDetails()

		MsgBox("Done", MsgBoxStyle.Information, "Message")
	End Function

	Function AdminByReason(reason As String) As Boolean
		If cmbAdmin.Text = "" Then
			MsgBox("Please select Admin", MsgBoxStyle.Exclamation, "Warning")
			cmbAdmin.Focus()
			Return False
		End If

		CustomerHistory(txtCustid.Text, txtCardId.Text, reason, cmbAdmin.Text)
		Return True
	End Function

	Function EnsureAdmin() As Boolean
		If cmbAdmin.Text = "" Then
			MsgBox("Please select Admin", MsgBoxStyle.Exclamation, "Warning")
			cmbAdmin.Focus()
			Return False
		End If

		Return True
	End Function

	Sub updateGroup()
		ReadyConnectionF()
		Dim custID As Integer = CInt(txtCustid.Text)
		If AdminByReason("group updated") = False Then
			Exit Sub
		End If
		If ComboBox15.Text <> "" And TextBox7.Text <> "" Then

			' If adminByReason("group updated") = True Then
			Dim cmdDatabase As New SqlCommand

			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@GroupName", SqlDbType.VarChar).Value = ComboBox15.Text ' grName
			cmdDatabase.Parameters.Add("@RelaxxGroupId", SqlDbType.VarChar).Value = TextBox7.Text ' grName

			cmdDatabase.CommandText = "Update Customers set Attachments =  @GroupName,RelaxxGroupId=@RelaxxGroupId  where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)

			Dim st As String
			Dim oper As String
			oper = custID & "group set to  " & ComboBox15.Text
			st = lblUser.Text
			LogFunc(st, oper)
			MsgBox("Done", MsgBoxStyle.Information, "OK")
			txtGroup.ForeColor = Color.Red
			ComboBox15.SelectedIndex = -1
			' End If
		Else

			MsgBox("Group not selected ", MsgBoxStyle.Information, "OK")
			Exit Sub
			ComboBox15.Focus()
		End If
		' End If

	End Sub

	Sub updateBornOn()
		'  Dim D1 As DateTime = dtBornOn.Value
		If AdminByReason("BornOn updated") = True Then

			Dim custID As Integer = CInt(txtCustid.Text)
			Dim provider As CultureInfo = CultureInfo.InvariantCulture
			Dim DP2 As String = dtBornOn.Text


			Dim dateString1, format As String
			Dim reDate As Date

			dateString1 = DP2
			'
			format = "dd/MM/yyyy"

			reDate = Date.ParseExact(dateString1, format, provider)

			Dim cmdDatabase As New SqlCommand

			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@BornOn", SqlDbType.Date).Value = reDate

			cmdDatabase.CommandText = "Update Customers set BornOn = @BornOn   where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)

			GetdataCust(custID)
			GetDetails()

			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Sub updateMail()
		If AdminByReason("Mail updated") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtMail.Text

			cmdDatabase.CommandText = "Update Customers set Email =  @Email  where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Sub updatePhone()
		If AdminByReason("Phone updated") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand
			cmdDatabase.Parameters.Add("@PhoneNumber2", SqlDbType.VarChar).Value = txtPhone2.Text
			' cmdDatabase.Parameters.Add("@Email", Data.SqlDbType.VarChar).Value = txtMail.Text

			cmdDatabase.CommandText = "Update Customers set MobilePhone =  @PhoneNumber2  where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Sub updManager()
		Dim custId = txtCustid.Text
		Dim cmdDatabase As New SqlCommand
		If AdminByReason("Manager updated") = True Then
			cmdDatabase = conn.CreateCommand
			cmdDatabase.Parameters.Add("@Manager", SqlDbType.VarChar).Value = cmbAdmin.Text 'keynumber
			cmdDatabase.CommandText = "Update Customers set ContactPerson =  @Manager  where ID =  '" & custId & " '"
			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custId)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")
		End If
	End Sub

	Sub updateNotes()
		If AdminByReason("Notes updated") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand
			cmdDatabase.Parameters.Add("@Notes", SqlDbType.VarChar).Value = RichTextBox1.Text
			cmdDatabase.CommandText = "Update Customers set Notes =  @Notes  where id = '" & custID & "' "
			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
		Dim f = My.Application.OpenForms("Cust")

		If f Is Nothing Then
			Cust.lblUser.Text = lblUser.Text
			Cust.Show()
		Else
			Cust.BringToFront()
		End If
	End Sub

	Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
		deletePhoto()
	End Sub

	Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
		Dim f As New frmCamera
		Try
			f.Owner = Me
			f.Label1.Text = Trim(txtCardId.Text)
			f.ShowDialog()
		Finally
			f.Dispose()
		End Try
		Refresh_Form()
	End Sub

	Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
		ReadUID1()
	End Sub

	Private Function GetCheckInHistoryAsync() As DataTable
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim connection As SqlConnection
		connection = GetSqlConnection()
		Using connection
			Dim dataAdapter As New SqlDataAdapter("select top 10 * from GatCheckIn where Customerid = '" & custID & "' ORDER BY DateCheckin DESC", connection)
			Dim table As New DataTable()
			table.Locale = CultureInfo.InvariantCulture
			dataAdapter.Fill(table)
			dataAdapter.Dispose()
			Return table
		End Using
	End Function

	Public Sub GetDataF(selectCommand As String)
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try

			'  Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))

			dataAdapter = New SqlDataAdapter(selectCommand, conn)

			Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

			Dim table As New DataTable()
			table.Locale = CultureInfo.InvariantCulture
			dataAdapter.Fill(table)
			Dim bindingSource As New BindingSource
			bindingSource.DataSource = table
			DataGridView2.DataSource = bindingSource

			BindingNavigator1.BindingSource = bindingSource
			DataGridView2.AutoResizeColumns(
		   DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
		Catch ex As SqlException
			MessageBox.Show("To run , replace the value of the " +
				"connectionString variable with a connection string that is " +
				"valid for your system.")
		End Try

	End Sub

	Sub saveChanges()
		If cmbReason.Text = "" Then
			MsgBox("Please select Reason", MsgBoxStyle.Exclamation, "Warning")
			cmbReason.Focus()
			Exit Sub
		End If
		If cmbAdmin.Text = "" Then
			MsgBox("Please select Admin", MsgBoxStyle.Exclamation, "Warning")
			cmbAdmin.Focus()
			Exit Sub
		End If
		Dim str As String = txtCardId.SelectedText
		Dim newStatus

		Dim custID As Integer = CInt(txtCustid.Text)
		' Dim customerid As Integer = CInt(ComboBox7.SelectedValue)
		Dim CardID As String = txtCardId.Text
		Dim cmdOldValue As New SqlCommand("Select Status from customers where id = '" & custID & " '", conn)
		'  newStatus = GetCustomerByID(customerid).Status
		' Console.Write(newStatus)
		Dim sqlResult, Reason, oldStatus
		sqlResult = ExecuteScalar(cmdOldValue)
		If sqlResult IsNot Nothing Then
			oldStatus = sqlResult
			'Reason = sqlResult & "/" & cmbReason.Text

		Else
			oldStatus = ""
			' Reason = cmbReason.Text
		End If
		If chForgot.Checked = True Then
			Dim cmdOldUID As New SqlCommand("Select UID from customers where id = '" & custID & " '", conn)
			Dim sqlResultUID, oldUID As String
			sqlResultUID = ExecuteScalar(cmdOldUID)
			If sqlResultUID IsNot Nothing Then

				oldUID = sqlResultUID.ToString

			Else
				oldUID = ""
			End If

			Dim cmdUpdUID As New SqlCommand
			cmdUpdUID.Parameters.Add("@oldUID", SqlDbType.VarChar).Value = oldUID

			cmdUpdUID.CommandText = "Update customers set Passport = '" & oldUID & " '  where id = '" & custID & " '"
			ExecuteNonQuery(cmdUpdUID)
		End If
		SaveEdited()
		' refNew()
		GetdataCust(custID)

		Dim status, stat As String
		If Disabled.Checked = True Then
			stat = TextBox22.Text
			'stat = " " & TextBox22.Text 's probelom
			status = "disabled"
		Else
			If chBoxAllow.Checked = True Then
				stat = Trim(TextBox22.Text)
				status = "allow"
			Else
				If chForgot.Checked = True Then
					'stat = Trim(TextBox22.Text)
					status = "forgot"
				Else

					stat = Trim(TextBox22.Text)
					status = "enabled"
				End If
			End If
		End If
		Dim sqlResultnew
		Dim cmdNewValue As New SqlCommand("Select Status from customers where id = '" & custID & " '", conn)
		sqlResultnew = ExecuteScalar(cmdNewValue)
		If sqlResultnew IsNot Nothing Then
			newStatus = sqlResultnew
			'Reason = sqlResult & "/" & cmbReason.Text

		Else
			newStatus = ""
			' Reason = cmbReason.Text
		End If
		' newStatus = GetCustomerByID(customerid).Status

		Reason = oldStatus & "/" & cmbReason.Text & "/" & newStatus
		If AdminByReason(Reason) = True Then
			' CustomerHistory(custID, CardID, Reason, Admin)
			cmbReason.Text = ""


			Dim st As String
			Dim oper As String
			oper = "status change customerid " & custID
			st = lblUser.Text
			LogFunc(st, oper)
			'  focusCardId(DataGridView3, CardID)
		End If
	End Sub


	Private Sub Button31_Click(sender As Object, e As EventArgs)
		txtFind.Text = ""
		Dim openSuccess As Boolean
		Dim AxCardReader1 As New GAT_Writer_5250.CardReader
		REM You need to set a valid key to read Segments / cash
		REM THIS KEY IS ONLY VALID FOR FID="9999"
		AxCardReader1.CryptKey = "E5512F6C014264715B20602950248E9E3398" '"E6147DD79B589816B733BE7B4D52EE32"
		AxCardReader1.FID = "10002302" '"9999"
		AxCardReader1.FID_SUB = "00"
		' Label2.Caption = "FID: " + AxCardReader2.FID
		openSuccess = AxCardReader1.OpenDevice
		If openSuccess = True Then 'Button2.Enabled = True

			Dim txtUID As String = AxCardReader1.GetUniqueNumber
			txtFind.Text = txtUID

		End If
	End Sub










	Private Sub Disabled_CheckedChanged(sender As Object, e As EventArgs) Handles Disabled.CheckedChanged
		If Disabled.Checked = True Then
			chBoxAllow.Checked = False
		End If
	End Sub


	Sub updOrder()
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Dim j As Integer
		Try
			If dgvOrders IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
				'DataGridView.Item("ColumnNameHere",0).Value = "Hello"
				If dgvOrders.CurrentRow.Index >= 0 Then
					j = dgvOrders.CurrentRow.Index

					Dim ordID As Integer
					ordID = dgvOrders.Item("Orderid", j).Value.ToString
					'  If Not IsDBNull(dgvOrders.SelectedRows, "Orderid")) AndAlso DataGrid1(DataGrid1.CurrentRowIndex, 8) IsNot Nothing Then
					Dim startDate As Date
					startDate = dgvOrders.Item("OrderDate", j).Value.ToString
					Dim duration, durDays As Integer
					Dim FreezingLimit As Integer
					Dim FreeFreez As Integer
					Dim reorderDate As Date
					reorderDate = dgvOrders.Item("ReorderDate", j).Value.ToString()
					Dim addDays As Integer

					Dim notes As String
					Dim ordName As String
					duration = dgvOrders.Item("Duration", j).Value.ToString
					durDays = dgvOrders.Item("durDays", j).Value.ToString
					FreezingLimit = dgvOrders.Item("FreezingLimit", j).Value.ToString
					FreeFreez = dgvOrders.Item("FreeFreez", j).Value.ToString
					'reorderDate = Date.Now
					Dim unitprice = dgvOrders.Item("Total", j).Value.ToString
					addDays = dgvOrders.Item("addDays", j).Value.ToString
					Dim att = dgvOrders.Item("Attend limit", j).Value.ToString
					notes = dgvOrders.Item("Notes", j).Value.ToString
					ordName = dgvOrders.Item("OrderName", j).Value.ToString

					Dim cmdDatabase As New SqlCommand

					cmdDatabase = conn.CreateCommand

					cmdDatabase.Parameters.Add("@reDate", SqlDbType.DateTime).Value = reorderDate
					cmdDatabase.Parameters.Add("@FreezingLimit", SqlDbType.Int).Value = FreezingLimit
					cmdDatabase.Parameters.Add("@FreeFreez", SqlDbType.Int).Value = FreeFreez
					cmdDatabase.Parameters.Add("@notes", SqlDbType.NChar).Value = notes
					cmdDatabase.Parameters.Add("@addDays", SqlDbType.Int).Value = addDays
					cmdDatabase.Parameters.Add("@ordname", SqlDbType.NChar).Value = ordName
					cmdDatabase.CommandText = "Update Orders set OrderDate=Convert(date, '" & startDate & " ', 103),ReorderDate=Convert(date, '" & reorderDate & " ', 103),FreezingLimit=@FreezingLimit,FreezingDays=@FreeFreez,Notes=@notes,addDays =  @addDays,OrderName=@ordname where Orderid = '" & ordID & "' "

					ExecuteNonQuery(cmdDatabase)



					Dim cmdorderDet As New SqlCommand

					cmdorderDet = conn.CreateCommand
					cmdorderDet.Parameters.Add("@duration", SqlDbType.Int).Value = duration
					cmdorderDet.Parameters.Add("@durDays", SqlDbType.Int).Value = durDays
					cmdorderDet.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Int(unitprice)
					cmdorderDet.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = 1
					cmdorderDet.Parameters.Add("@attDays", SqlDbType.Int).Value = att
					cmdorderDet.CommandText = "Update OrderDetails set Quantity=@Quantity , unitprice = @UnitPrice,duration = @duration,durDays=@durDays,WeeklyAttendance=@attDays where Orderid = '" & ordID & "' and Statusid <> 2 "

					ExecuteNonQuery(cmdorderDet)
					MsgBox("Done", MsgBoxStyle.Information, "OK")
					Dim custID As Integer = CInt(txtCustid.Text)
					Dim st As String
					Dim oper As String
					oper = "edit order  " & custID
					st = lblUser.Text
					LogFunc(st, oper)
				Else
				End If
			End If
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
		AllOrders()
		' Refresh_Tab()
	End Sub

	Sub checkActiveOrders()
		ReadyConnectionF()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim Res As Integer
		Dim actDate = Date.Now
		Dim cmdActive As New SqlCommand
		cmdActive = conn.CreateCommand
		cmdActive.CommandText = "select count(orderid) from OrdActive where CustomerID = '" & custID & " ' "

		Res = ExecuteScalar(cmdActive)
		If Res > 0 Then
			MsgBox("Client have Active order", MsgBoxStyle.OkOnly, "Info ")

			Exit Sub

		End If
	End Sub
	Sub activateWaiting()
		Dim custID As Integer = CInt(txtCustid.Text)
		If MsgBox("Are you sure to change Order Activation", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

		Else

			ReadyConnectionF()
			Dim Res As Integer
			Dim actDate = Date.Now
			Dim cmdActive As New SqlCommand
			cmdActive = conn.CreateCommand
			cmdActive.CommandText = "Select count(orderid)  From OrdActive Where CustomerID = '" & custID & " ' "

			Res = ExecuteScalar(cmdActive)
			If Res > 0 Then
				MsgBox("Client have Active order", MsgBoxStyle.OkOnly, "Info ")
				AllOrders()
				Exit Sub
			Else

				Dim tmpCurrentCulture As CultureInfo
				tmpCurrentCulture = New CultureInfo("en-US")

				tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
				tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
				Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
				Dim j As Integer
				If AdminByReason("order activation") = True Then
					Try




						If dgvOrders IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
							'DataGridView.Item("ColumnNameHere",0).Value = "Hello"
							If dgvOrders.CurrentRow.Index >= 0 Then
								j = dgvOrders.CurrentRow.Index
								' Console.Write(j)
								Dim ordID As Integer
								ordID = dgvOrders.Item("Orderid", j).Value.ToString
								'  If Not IsDBNull(dgvOrders.SelectedRows, "Orderid")) AndAlso DataGrid1(DataGrid1.CurrentRowIndex, 8) IsNot Nothing Then
								Dim startDate As Date
								startDate = dgvOrders.Item("OrderDate", j).Value.ToString

								Dim reorderDate As Date



								Dim notes As String

								reorderDate = Date.Now



								notes = dgvOrders.Item("Notes", j).Value.ToString
								Dim cmdDatabase As New SqlCommand

								cmdDatabase = conn.CreateCommand

								cmdDatabase.Parameters.Add("@reDate", SqlDbType.DateTime).Value = reorderDate

								cmdDatabase.Parameters.Add("@notes", SqlDbType.NChar).Value = notes


								cmdDatabase.CommandText = "Update Orders Set OrderDate=@reDate,Notes=@notes where Orderid = '" & ordID & "' "

								ExecuteNonQuery(cmdDatabase)
								MsgBox("Done", MsgBoxStyle.Information, "OK")
								Refresh_Tab()
							Else
							End If
						End If

					Catch ex As SqlException
						MessageBox.Show(ex.ToString)
						'  MessageBox.Show("No any data!")
					End Try
				End If
			End If
			'Refresh_Tab()
		End If
	End Sub


	Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
		On Error Resume Next
		If TextBox11.Text <> "" Then
			j = TextBox11.Text
			If j > 0 Then
				DateTimePicker3.Value = DateTimePicker2.Value.AddDays(j - 1)
			End If
		End If
	End Sub


	Private Sub DataGrid8_Navigate(sender As Object, ne As NavigateEventArgs) Handles DataGrid8.Navigate
		'freezAdminDisplay()
	End Sub

	Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
		' Dim j As Integer = 0
		Try
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex

					Dim paidFreez As Integer = DataGrid8(j, 1)


					Dim cmdDatabase As New SqlCommand
					Dim ordID As Integer = DataGrid8(j, 7)
					cmdDatabase = conn.CreateCommand

					cmdDatabase.Parameters.Add("@paidFreez", SqlDbType.Int).Value = paidFreez


					cmdDatabase.CommandText = "Update FreezPaidDays set PaidFreezDays=@paidFreez where Orderid = '" & ordID & "' "

					ExecuteNonQuery(cmdDatabase)
					MsgBox("Done", MsgBoxStyle.Information, "OK")
				Else
				End If
			End If
		Catch ex As SqlException
			MessageBox.Show("No any data!")
		End Try
		Refresh_Tab()
		'refNew()
	End Sub
	Sub updateGuestFree()

		Dim j As Integer


		j = DataGridView5.CurrentRow.Index

		Dim gID As Integer
		Dim freeLimit As Integer
		Dim orderid As Integer
		'   If GetGuestOrder(orderid) = True Then
		gID = CInt(txtCustid.Text)
		orderid = DataGridView5.Item("Orderid", j).Value.ToString
		freeLimit = DataGridView5.Item("Free", j).Value.ToString 'id customer as  guest-not owner


		updGuestLimit(gID, freeLimit, orderid)
		'Else
		'    Dim cmdDepID1 As New SqlClient.SqlCommand("InsertGuestLimit")

		'    cmdDepID1.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = gID
		'    cmdDepID1.Parameters.Add("@guestLimit", Data.SqlDbType.Int).Value = 0
		'    cmdDepID1.Parameters.Add("@ordID", Data.SqlDbType.Int).Value = orderid
		'    ExecuteProcedur.ExecuteCMD(cmdDepID1)
		'  End If
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim st As String
		Dim oper As String
		oper = "guest free update  " & custID
		st = lblUser.Text
		LogFunc(st, oper)

		'    End If
		'End If

		Refresh_Tab()
	End Sub
	'Sub updateClipFree()
	'    Dim custID As Integer = CInt(txtCustid.Text)
	'    Dim j As Integer

	'    If DataGridView8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

	'        If DataGridView8.CurrentRow.Index >= 0 Then
	'            j = DataGridView8.CurrentRow.Index


	'            Dim freeLimit As Integer

	'            freeLimit = DataGridView8.Item("Free", j).Value.ToString 'id customer as  guest-not owner
	'            createClipLimit(custID)
	'            updCliplimit(custID, freeLimit)


	'        End If
	'    End If

	'    tabClip()
	'End Sub

	Private Sub chBoxAllow_CheckedChanged(sender As Object, e As EventArgs) Handles chBoxAllow.CheckedChanged
		If Disabled.Checked = True Then
			chBoxAllow.Checked = False
		End If
	End Sub

	Private Sub txtFind_Enter(sender As Object, e As EventArgs)
		'Find()
	End Sub



	Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs)
		' If e.KeyCode = Keys.Enter Then
		' ref()
		'Find()
		' End If
	End Sub




	Private Sub txtFind_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub ComboBox5_Validating(sender As Object, e As CancelEventArgs)
		'If ComboBox5.SelectedItem Is Nothing Then
		'    MessageBox.Show("Value entered not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		'    e.Cancel = True
		'    Exit Sub
		'End If
	End Sub

	Private Sub DataGridView3_DataError(sender As Object,
e As DataGridViewDataErrorEventArgs) _


		'MessageBox.Show("Error happened " _
		'    & e.Context.ToString())

		'If (e.Context = DataGridViewDataErrorContexts.Commit) _
		'    Then
		'    MessageBox.Show("Commit error")
		'End If
		'If (e.Context = DataGridViewDataErrorContexts _
		'    .CurrentCellChange) Then
		'    MessageBox.Show("Cell change")
		'End If
		'If (e.Context = DataGridViewDataErrorContexts.Parsing) _
		'    Then
		'    MessageBox.Show("parsing error")
		'End If
		'If (e.Context =
		'    DataGridViewDataErrorContexts.LeaveControl) Then
		'    MessageBox.Show("leave control error")
		'End If

		'If (TypeOf (e.Exception) Is ConstraintException) Then
		'    Dim view As DataGridView = CType(sender, DataGridView)
		'    view.Rows(e.RowIndex).ErrorText = "an error"
		'    view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
		'        .ErrorText = "an error"

		'    e.ThrowException = False
		'    e.Cancel = True
		'End If
	End Sub
	Sub payDepositMinusRest()
		ReadyConnectionF()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim cashier As String = cmbAdmin.Text
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()

		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
		' conn.Open()

		Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
		Dim idDetID As Integer
		If IsDBNull(sqlResult1) Then

			idDetID = 1

		Else
			sqlResult1.ToString()
			idDetID = ExecuteScalar(cmdPoDetID)
			'  conn.Close()
			idDetID = idDetID + 1
		End If


		If txtDeposit.Text <> "" And txtDeposit.Text < 0 Then
			Dim amount As Integer = Int(txtDeposit.Text)

			If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

				Exit Sub
			Else
				If AdminByReason("DepositRestMinus") = True Then

					Dim CMD As New SqlCommand("InsertPayment")
					' CMD.Parameters.Clear()
					CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

					CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
					CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
					CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = CmbMethode.Text



					CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "DepositRestMinus" 'cmbBasic.Text
					' If cmbBasic.Text = "Deposit" Then
					CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "DepositRestMinus"
					' Else
					' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
					'  End If
					CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
					CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

					CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

					CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = 1

					CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
					CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

					'If ComboBox20.Text <> "" Then
					'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
					'Else
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
					'End If
					CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

					ExecuteProcedur.ExecuteCMD(CMD)




					' If cmbBasic.Text = "Deposit" Then
					Dim depos As Integer = Int(txtDeposit.Text)
					createDepositAccount(custID)
					addDeposit(custID, depos)
					depositHistory(customerID:=custID, amount:=depos, Reason:="DepositRestoranMinus")
					Dim st As String
					Dim oper As String
					oper = "DepositRestoranMinus " & custID
					st = lblUser.Text
					LogFunc(st, oper)
					'End If
					MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
				End If
			End If
		Else
			MsgBox("Only negative amount must be entered!")
		End If
		Refresh_Tab()
	End Sub
	Sub payDepositMinusSPA()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim cashier As String = cmbAdmin.Text
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()
		ReadyConnectionF()

		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
		' conn.Open()

		Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
		Dim idDetID As Integer
		If IsDBNull(sqlResult1) Then

			idDetID = 1

		Else
			sqlResult1.ToString()
			idDetID = ExecuteScalar(cmdPoDetID)
			'  conn.Close()
			idDetID = idDetID + 1
		End If


		If txtDeposit.Text <> "" And txtDeposit.Text < 0 Then
			Dim amount As Integer = Int(txtDeposit.Text)

			If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

				Exit Sub
			Else
				If AdminByReason("DepositSPAMinus") = True Then

					Dim CMD As New SqlCommand("InsertPayment")
					' CMD.Parameters.Clear()
					CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

					CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
					CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
					CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = CmbMethode.Text



					CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "DepositSPAMinus" 'cmbBasic.Text
					' If cmbBasic.Text = "Deposit" Then
					CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "DepositSPAMinus"
					' Else
					' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
					'  End If
					CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
					CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

					CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

					CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = 1

					CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
					CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

					'If ComboBox20.Text <> "" Then
					'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
					'Else
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
					'End If
					CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

					ExecuteProcedur.ExecuteCMD(CMD)




					' If cmbBasic.Text = "Deposit" Then
					Dim depos As Integer = Int(txtDeposit.Text)
					createDepositSPA(custID)
					addDepositSPA(custID, depos)
					depositHistory(customerID:=custID, amount:=depos, Reason:="DepositSPAMinus")
					Dim st As String
					Dim oper As String
					oper = "DepositSPAMinus " & custID
					st = lblUser.Text
					LogFunc(st, oper)
					'End If
					MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
				End If
			End If
		Else
			MsgBox("Only negative amount must be entered!")
		End If
		Refresh_Tab()
	End Sub
	Sub payDepositRest()
		ReadyConnectionF()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim cashier As String = cmbAdmin.Text
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()

		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
		' conn.Open()

		Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
		Dim idDetID As Integer
		If IsDBNull(sqlResult1) Then

			idDetID = 1

		Else
			sqlResult1.ToString()
			idDetID = ExecuteScalar(cmdPoDetID)
			'  conn.Close()
			idDetID = idDetID + 1
		End If


		If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
			Dim amount As Integer = Int(txtDeposit.Text)

			If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

				Exit Sub
			Else
				If AdminByReason("DepositRestPlus") = True Then

					Dim CMD As New SqlCommand("InsertPayment")
					' CMD.Parameters.Clear()
					CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

					CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
					CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
					CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = CmbMethode.Text



					CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "DepositRest" 'cmbBasic.Text
					' If cmbBasic.Text = "Deposit" Then
					CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "DepositRest"
					' Else
					' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
					'  End If
					CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
					CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

					CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

					CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = 1

					CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
					CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

					'If ComboBox20.Text <> "" Then
					'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
					'Else
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
					'End If
					CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

					ExecuteProcedur.ExecuteCMD(CMD)




					' If cmbBasic.Text = "Deposit" Then
					Dim depos As Integer = Int(txtDeposit.Text)
					createDepositAccount(custID)
					addDeposit(custID, depos)
					depositHistory(customerID:=custID, amount:=depos, Reason:="DepositRest")
					Dim st As String
					Dim oper As String
					oper = "DepositRestoran " & custID
					st = lblUser.Text
					LogFunc(st, oper)
					'End If
					MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
				End If
			End If
		Else
			MsgBox("No amount entered!")
		End If
		Refresh_Tab()
	End Sub
	Sub payDepositSPA()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim cashier As String = cmbAdmin.Text
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()
		ReadyConnectionF()
		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
		' conn.Open()

		Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
		Dim idDetID As Integer
		If IsDBNull(sqlResult1) Then

			idDetID = 1

		Else
			sqlResult1.ToString()
			idDetID = ExecuteScalar(cmdPoDetID)
			'  conn.Close()
			idDetID = idDetID + 1
		End If


		If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
			Dim amount As Integer = Int(txtDeposit.Text)

			If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

				Exit Sub
			Else
				If AdminByReason("DepositSPAPlus") = True Then

					Dim CMD As New SqlCommand("InsertPayment")
					' CMD.Parameters.Clear()
					CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

					CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
					CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
					CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = CmbMethode.Text



					CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "DepositSPA" 'cmbBasic.Text
					' If cmbBasic.Text = "Deposit" Then
					CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "DepositSPA"
					' Else
					' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
					'  End If
					CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
					CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

					CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

					CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = 1

					CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
					CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

					'If ComboBox20.Text <> "" Then
					'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
					'Else
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
					'End If
					CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

					ExecuteProcedur.ExecuteCMD(CMD)




					' If cmbBasic.Text = "Deposit" Then
					Dim depos As Integer = Int(txtDeposit.Text)
					createDepositSPA(custID)
					addDepositSPA(custID, depos)
					depositHistory(customerID:=custID, amount:=depos, Reason:="DepositSPA")
					Dim st As String
					Dim oper As String
					oper = "DepositSPA " & custID
					st = lblUser.Text
					LogFunc(st, oper)
					'End If
					MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
				End If
			End If
		Else
			MsgBox("No amount entered!")
		End If
		Refresh_Tab()
	End Sub
	'Sub payFromDeposit() ' v PO dobavlyaet oplatu from deposit i iz deposita vichitaet
	'    Dim custID As Integer = ComboBox7.SelectedValue
	'    Dim cashier As String = cmbAdmin.Text
	'    GetDeposit(custID)
	'    If frAmount.Text <> "" And frAmount.Text < GetDeposit(custID) Then
	'        Dim amount As Integer = Int(frAmount.Text)

	'        If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

	'            Exit Sub
	'        Else
	'            Dim cmdPoDetID As SqlCommand

	'            cmdPoDetID = conn.CreateCommand()

	'            cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
	'            ' conn.Open()

	'            Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
	'            Dim idDetID As Integer
	'            If IsDBNull(sqlResult1) Then

	'                idDetID = 1

	'            Else
	'                sqlResult1.ToString()
	'                idDetID = ExecuteScalar(cmdPoDetID)
	'                '  conn.Close()
	'                idDetID = idDetID + 1
	'            End If





	'            Dim CMD As New SqlCommand("InsertPayment")
	'            ' CMD.Parameters.Clear()
	'            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID

	'            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = amount
	'            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
	'            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = "from deposit"



	'            CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = cmbBasic.Text
	'            ' If cmbBasic.Text = "Deposit" Then
	'            '   CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "From Deposit"
	'            ' Else
	'            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
	'            '  End If
	'            CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = 0
	'            CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
	'            CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0 'coach
	'            CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = 0
	'            CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID


	'            CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0

	'            CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = 0
	'            CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTime.Now ' na forme naoborot recieveddate t.k. sort 
	'            CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTime.Now
	'            CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTime.Now
	'            CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = amount

	'            CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = 1

	'            CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = 0
	'            CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"

	'            'If ComboBox20.Text <> "" Then
	'            '    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
	'            'Else
	'            CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
	'            'End If
	'            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = 0

	'            ExecuteProcedur.ExecuteCMD(CMD)




	'            ' If cmbBasic.Text = "Deposit" Then
	'            Dim depos As Integer = Int(amount)
	'            '  createDepositAccount(custID)
	'            minusDeposit(custID, depos)
	'            depositHistory(customerID:=custID, amount:=depos, Reason:=cashier)
	'            'End If
	'            MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
	'        End If
	'    Else
	'        MsgBox("Check Deposit balance!!!")
	'    End If
	'    Refresh_Tab()
	'End Sub
	Sub SpaBonus()
		Dim custID As Integer = CInt(txtCustid.Text)
		'  Dim cashier As String = cmbAdmin.Text
		If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
			Dim amount As Decimal = CDec(txtDeposit.Text)

			If MsgBox("Are you sure to save Bonus? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

				Exit Sub
			Else

				' If cmbBasic.Text = "Deposit" Then
				Dim depos As Decimal = CDec(txtDeposit.Text)
				GetCreateDepositSPABonus(custID)
				addDepositSPABonus(custID, depos)
				'depositHistory(customerID:=custID, amount:=depos, Reason:=cashier)
				'End If
				MsgBox("Bonus complete", MsgBoxStyle.OkOnly, "Message :")
			End If
		Else
			MsgBox("No amount entered!")
		End If
		Refresh_Tab()
	End Sub
	Sub PayGuest()
		Dim cmdPoDetID As SqlCommand
		cmdPoDetID = conn.CreateCommand()

		cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
		' conn.Open()

		Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
		Dim idDetID As Integer
		If IsDBNull(sqlResult1) Then

			idDetID = 1

		Else
			sqlResult1.ToString()
			idDetID = ExecuteScalar(cmdPoDetID)
			'  conn.Close()
			idDetID = idDetID + 1
		End If

		Dim custID As Integer = CInt(txtCustid.Text)
		Dim cashier As String = cmbAdmin.Text
		' If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
		Dim amount As Integer

		amount = Int(TextBox38.Text)

		If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

			Exit Sub
		Else


			Dim CMD As New SqlCommand("InsertPayment")
			' CMD.Parameters.Clear()
			CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

			CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
			CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
			CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = ComboBox19.Text



			CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "Guest" 'cmbBasic.Text

			CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Additional"

			CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
			CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
			CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
			CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 10
			CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


			CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

			CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
			CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
			CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
			CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
			CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount ' / Int(TextBox27.Text)

			CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = 1 ' Int(TextBox27.Text)

			CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
			CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"


			CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
			'End If
			CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

			ExecuteProcedur.ExecuteCMD(CMD)



			Dim st As String
			Dim oper As String
			oper = "guest payment  " & custID
			st = lblUser.Text
			LogFunc(st, oper)


			MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
		End If
		' CheckBox1.Checked = False
		Refresh_Tab()
	End Sub


	'Sub PayClipCard()
	'    If TextBox28.Text = "" Or TextBox28.Text = 0 Then
	'        MsgBox("Please enter amount", MsgBoxStyle.Exclamation, "Warning")
	'        TextBox28.Focus()
	'        Exit Sub
	'    End If
	'    Dim cmdPoDetID As SqlCommand
	'    cmdPoDetID = conn.CreateCommand()

	'    cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
	'    ' conn.Open()

	'    Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
	'    Dim idDetID As Integer
	'    If IsDBNull(sqlResult1) Then

	'        idDetID = 1

	'    Else
	'        sqlResult1.ToString()
	'        idDetID = ExecuteScalar(cmdPoDetID)
	'        '  conn.Close()
	'        idDetID = idDetID + 1
	'    End If

	'    Dim custID As Integer = CInt(txtCustid.Text)
	'    Dim cashier As String = cmbAdmin.Text
	'    ' If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
	'    Dim amount As Integer
	'    If Int(TextBox28.Text) > 0 And CheckBox1.Checked = True Then
	'        amount = Int(TextBox28.Text) - Int(TextBox28.Text) * 0.1
	'    Else
	'        amount = Int(TextBox28.Text)
	'    End If





	'    If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

	'        Exit Sub
	'    Else


	'        Dim CMD As New SqlCommand("InsertPayment")
	'        ' CMD.Parameters.Clear()
	'        CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID

	'        CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = amount
	'        CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTimePicker4.Value ' DateTime.Now 'na forme
	'        CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = ComboBox21.Text



	'        CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = "ClipCard" 'cmbBasic.Text

	'        CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"

	'        CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = 0
	'        CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
	'        CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0 'Int(TextBox31.Text) 'coach
	'        CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = Int(TextBox29.Text)
	'        CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID


	'        CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0

	'        CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = 0
	'        CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTime.Now ' na forme naoborot recieveddate t.k. sort 
	'        CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTime.Now
	'        CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTime.Now
	'        CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = Int(amount / Int(TextBox27.Text))

	'        CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = Int(TextBox27.Text)

	'        CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = 0
	'        CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"


	'        CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
	'        'End If
	'        CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = 0

	'        ExecuteProcedur.ExecuteCMD(CMD)


	'        Dim st As String
	'        Dim oper As String
	'        oper = "clipcard payment  " & custID
	'        st = lblUser.Text
	'        LogFunc(st, oper)



	'        MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
	'    End If
	'    CheckBox1.Checked = False
	'    tabClip()
	'End Sub

	'Sub outPaid()


	'    Dim cmd1 As New SqlCommand

	'    Dim da1 As New SqlDataAdapter

	'    Dim ds As New DataSet
	'    Dim dt As New DataTable
	'    ' ReadyConnectionF()
	'    cmd1 = conn.CreateCommand

	'    cmd1.CommandText = "select * from OutReceptionAll where  CustomerID = '" & ComboBox7.SelectedValue & " '" 'and Amount=Paid"
	'    da1.SelectCommand = cmd1
	'    da1.Fill(ds, "OutReception")
	'    ListView1.Clear()
	'    For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
	'        ListView1.Columns.Add(ds.Tables(0).Columns(i).ToString())
	'        With ListView1
	'            .Items.Clear()
	'            .View = View.Details
	'            .GridLines = True
	'            .FullRowSelect = True

	'        End With
	'    Next
	'    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
	'        Dim listRow As New ListViewItem
	'        listRow.Text = ds.Tables(0).Rows(i)(0).ToString()
	'        For j As Integer = 1 To ds.Tables(0).Columns.Count - 1
	'            listRow.SubItems.Add(ds.Tables(0).Rows(i)(j).ToString())
	'        Next
	'        ListView1.Items.Add(listRow)
	'    Next
	'    'Dim f As Integer
	'    'For f = 0 To dgvOutPayment.RowCount
	'    '    dgvOutPayment.DataSource = ds
	'    '    dgvOutPayment.DataMember = "OutReception"
	'    '    If dgvOutPayment.Rows(f).Cells(3).Value > dgvOutPayment.Rows(f).Cells(4).Value Then

	'    '        dgvOutPayment.Rows(f).DefaultCellStyle.BackColor = Color.Red
	'    '    End If
	'    'Next
	'End Sub
	'Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
	'    ListView1.Visible = True
	'    outPaid()
	'End Sub

	Private Sub Button11_Click_1(sender As Object, e As EventArgs)
		txtFind.Clear()
		txtFind.Focus()
		ref()
	End Sub

	Private Sub chForgot_CheckedChanged(sender As Object, e As EventArgs) Handles chForgot.CheckedChanged
		If chForgot.Checked = True Then
			tmp.Checked = False
		End If
	End Sub

	Private Sub tmp_CheckedChanged(sender As Object, e As EventArgs) Handles tmp.CheckedChanged
		If tmp.Checked = True Then
			chForgot.Checked = False
		End If
	End Sub

	Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
		payDepositRest()
	End Sub

	Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
		Dim check1, check2 As Integer

		Dim cmd1 As New SqlCommand
		Dim cmd2 As New SqlCommand

		Dim custID As Integer = CInt(txtCustid.Text)
		cmd1 = conn.CreateCommand
		cmd1.CommandText = "select DepositAmount from Deposit  " &
		"where CustomerID = '" & custID & "'"
		Dim sqlResult1 As Object = ExecuteScalar(cmd1)
		If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
			check1 = 0
			LinkLabel1.Text = check1
			'MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
			'Exit Sub
		Else
			sqlResult1.ToString()

			check1 = ExecuteScalar(cmd1) 'deposit sum 

			LinkLabel1.Text = check1
		End If

		cmd2 = conn.CreateCommand
		cmd2.CommandText = "select DepositAmount from DepositSPA  " &
		"where CustomerID = '" & custID & "'"
		Dim sqlResultSpa As Object = ExecuteScalar(cmd2)
		If IsDBNull(sqlResultSpa) Or sqlResultSpa Is Nothing Or sqlResultSpa = 0 Then
			check2 = 0
			LinkLabel3.Text = check2
			'MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
			'Exit Sub
		Else
			sqlResultSpa.ToString()

			check2 = ExecuteScalar(cmd2) 'deposit sum 

			LinkLabel3.Text = check2
		End If
	End Sub



	'Private Sub TextBox25_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox25.TextChanged
	'    txtDays.Text = DateDiff(DateInterval.Day, dtpEndDate.Value, dtpOrderDate.Value)
	'End Sub


	'Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged
	'    Dim OrderDate As DateTime = dtpOrderDate.Value
	'    Dim EndDate As DateTime = dtpEndDate.Value

	'    dtpEndDate.Value = DateAdd(DateInterval.Day, Int(txtDays.Text), OrderDate)
	'End Sub



	Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click

		Dim OrderDate As Date = dtpOrderDate.Value
		Dim EndDate As Date = dtpEndDate.Value
		Dim custID As Integer = CInt(txtCustid.Text)
		'Dim Admin = cmbAdmin.Text
		'Dim Reason = "GIFT"
		Dim customerid = custID
		Dim CardId = txtCardId.Text
		If MsgBox("Save gift card?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

		Else
			If AdminByReason("new gift") = True Then
				GiftOrder(custID, OrderDate, EndDate)

				' CustomerHistory(customerid, CardId, Reason, Admin)
				'focusCardId(DataGridView3, CardId)
				AllOrders()
			End If
		End If
	End Sub

	Private Sub Button35_Click(sender As Object, e As EventArgs)
		' cmbAdmin.Items.Add(cmbAdmin.Text)
	End Sub
	'Sub FindName()
	'    If txtFind.Text <> "" And ComboBox7.Items.Count > 0 Then
	'        ComboBox7.SelectedIndex = 0
	'    Else
	'        DataGridView3.Rows(0).Selected = True
	'    End If
	'    Try
	'        Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView3.DataSource, DataGridView3.DataMember), CurrencyManager)
	'        Dim dv As DataView = CType(cm.List, DataView)

	'        dv.RowFilter = String.Format("FirstName like '{0}*' AND LastName like '{1}*'", txtFirst.Text, txtLast.Text)

	'        cm.Refresh()
	'        If cm.List.Count = 0 Then
	'            MessageBox.Show("No any data!")
	'            DataGridView3.Rows(0).Selected = True
	'            Exit Sub
	'        Else



	'            Refresh_Tab()

	'        End If



	'    Catch abc As Exception
	'        MessageBox.Show("Sorry!")
	'    End Try

	'End Sub

	Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnFindLF.Click
		FindName()
	End Sub





	Private Sub Button36_Click(sender As Object, e As EventArgs)
		cmbAdmin.Items.Remove(cmbAdmin.SelectedItem)
	End Sub

	Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub txtLast_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			' ref()
			FindName()
		End If
	End Sub

	Private Sub DeleteCheckInsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCheckInsToolStripMenuItem.Click
		Dim custID As Integer = CInt(txtCustid.Text)
		DeleteCheckins(custID)
	End Sub

	Sub freezAdminDisplay()
		Label39.Text = ""
		'   If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
		Dim custID As Integer = CInt(txtCustid.Text)
		If GetOrderID(custID) = True Then
			If DataGrid8.CurrentRowIndex + 1 > 0 Then
				'TextBox15.Text = DataGrid8(DataGrid8.CurrentRowIndex, 4) '
				Dim ordId As Integer
				ordId = DataGrid8(DataGrid8.CurrentRowIndex, 7)
				'    If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
				j = DataGrid8.CurrentRowIndex

				'  Dim paidFreez As Integer = DataGrid8(j, 1)
				Dim limit As Integer = DataGrid8(j, 5)
				Dim used As Integer = DataGrid8(j, 3)
				TextBox15.Text = limit - used


				Dim checkPaid As Integer
				Dim cmd As New SqlCommand
				cmd = conn.CreateCommand
				cmd.CommandText = "select * from FreezBalance where CustomerID = '" & custID & " ' and orderid='" & ordId & "' "
				Dim da6 As New SqlDataAdapter
				Dim ds1 As New DataSet
				da6.SelectCommand = cmd
				da6.Fill(ds1, "FreezBalance")
				DataGrid6.DataSource = ds1
				DataGrid6.DataMember = "FreezBalance"
				DataGrid6.CaptionText = "Freezing History"





				Dim cmd1 As New SqlCommand
				cmd1 = conn.CreateCommand
				cmd1.CommandText = "Select AvialableForBuying from FreezAviability where CustomerID = '" & custID & " ' and OrderID =  '" & ordId & "'"
				Dim sqlResult1 As Object = ExecuteScalar(cmd1)
				If IsDBNull(sqlResult1) Or IsNothing(sqlResult1) Then
					Label37.Text = "Avialable for buying   0   day"
				Else

					checkPaid = ExecuteScalar(cmd1)
					'++++++++++++++++++++++++++++++
					Label37.Text = "Avialable for buying  " & checkPaid & "  days"
					' If checkPaid >= Val(frDays.Text) Then

					'+++++++++++++++++++ if avialable days OK then find id in freezpaiddays table

				End If

				'Else
				'    DataGrid6.DataSource = Nothing
			End If
		End If

	End Sub
	Sub freezAdmin()
		Try
			Dim custID As Integer = CInt(txtCustid.Text)
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex
					Dim ordID As Integer = DataGrid8(j, 7)
					'  Dim paidFreez As Integer = DataGrid8(j, 1)
					Dim ResAct As Integer

					Dim cmdActive As New SqlCommand
					cmdActive = conn.CreateCommand
					cmdActive.CommandText = "select count(orderid) from OrdActive where CustomerID = '" & custID & " ' and orderid='" & ordID & "'"

					ResAct = ExecuteScalar(cmdActive)
					If ResAct = 0 Then
						MsgBox("Client order not Active", MsgBoxStyle.OkOnly, "Info ")

						Exit Sub
					Else
						Dim cmdDatabase As New SqlCommand


						Dim cmd2 As New SqlCommand
						Dim checkPaid As Integer

						'  Dim ordID As Integer


						'             ordID = Int(TextBox16.Text)


						Dim cmd1 As New SqlCommand
						cmd1 = conn.CreateCommand

						cmd1.CommandText = "Select AvialableForBuying from FreezAviability where OrderID =  '" & ordID & "'"

						Dim sqlResult1 As Object = ExecuteScalar(cmd1)
						If IsDBNull(sqlResult1) Or IsNothing(sqlResult1) Then
							'  checkPaid = 0
						Else

							checkPaid = ExecuteScalar(cmd1)
							'++++++++++++++++++++++++++++++

							If checkPaid >= Val(frDays.Text) Then

								'+++++++++++++++++++ if avialable days OK then find id in freezpaiddays table





								newPaidFreez()
								payFreezDays()
								Dim st As String
								Dim oper As String
								oper = "Paid freezing " & custID
								st = lblUser.Text
								LogFunc(st, oper)
							Else
								MsgBox("Freez OverLimit!", MsgBoxStyle.OkOnly, "Info Save Payment")
								Exit Sub


							End If
						End If

					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("freez admin", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try





	End Sub
	Sub freezAdminDeposit()
		Try
			Dim custID As Integer = CInt(txtCustid.Text)
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex
					Dim ordID As Integer = DataGrid8(j, 7)
					'  Dim paidFreez As Integer = DataGrid8(j, 1)
					Dim ResAct As Integer

					Dim cmdActive As New SqlCommand
					cmdActive = conn.CreateCommand
					cmdActive.CommandText = "select count(orderid) from OrdActive where CustomerID = '" & custID & " ' and orderid='" & ordID & "'"

					ResAct = ExecuteScalar(cmdActive)
					If ResAct = 0 Then
						MsgBox("Client order not Active", MsgBoxStyle.OkOnly, "Info ")

						Exit Sub
					Else
						Dim cmdDatabase As New SqlCommand


						Dim cmd2 As New SqlCommand
						Dim checkPaid As Integer

						'  Dim ordID As Integer


						'             ordID = Int(TextBox16.Text)


						Dim cmd1 As New SqlCommand
						cmd1 = conn.CreateCommand

						cmd1.CommandText = "Select AvialableForBuying from FreezAviability where OrderID =  '" & ordID & "'"

						Dim sqlResult1 As Object = ExecuteScalar(cmd1)
						If IsDBNull(sqlResult1) Or IsNothing(sqlResult1) Then
							'  checkPaid = 0
						Else

							checkPaid = ExecuteScalar(cmd1)
							'++++++++++++++++++++++++++++++

							If checkPaid >= Val(frDays.Text) Then

								'+++++++++++++++++++ if avialable days OK then find id in freezpaiddays table





								newPaidFreez()
								payFreezDaysFrdeposit()
							Else
								MsgBox("Freez OverLimit!", MsgBoxStyle.OkOnly, "Info Save Payment")
								Exit Sub


							End If
						End If

					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try





	End Sub
	Sub newPaidFreez()

		Dim newIDstr As Integer
		Try
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex
					Dim ordID As Integer = DataGrid8(j, 7)
					Dim cmdPoDetID As SqlCommand
					cmdPoDetID = conn.CreateCommand()
					cmdPoDetID.CommandText = "select ID  from FreezPaidDays where OrderID = '" & ordID & "' "
					'esli net paid za etoot order insert id for this order else update + new days 
					Dim sqlResult2 As Object = ExecuteScalar(cmdPoDetID)
					If IsDBNull(sqlResult2) Or IsNothing(sqlResult2) Then
						Dim newID As SqlCommand
						newID = conn.CreateCommand()
						newID.CommandText = "select Max(ID)  from FreezPaidDays"
						newIDstr = ExecuteScalar(newID)
						newIDstr = newIDstr + 1
						Dim CMD As New SqlCommand("FreezDaysPaid")
						'   CMD.Parameters.Clear()
						CMD.Parameters.Add("@ID", SqlDbType.Int).Value = newIDstr
						CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = ordID
						CMD.Parameters.Add("@PaidFreezDays", SqlDbType.Int).Value = Val(frDays.Text)
						ExecuteProcedur.ExecuteCMD(CMD)
					Else
						newIDstr = ExecuteScalar(cmdPoDetID)
						Dim freezPaid As SqlCommand
						freezPaid = conn.CreateCommand()
						freezPaid.Parameters.Add("@PaidFreezDays", SqlDbType.Int).Value = Val(frDays.Text)
						freezPaid.Parameters.Add("@OrderID", SqlDbType.Int).Value = ordID
						freezPaid.CommandText = "Update FreezPaidDays set PaidFreezDays = PaidFreezDays+@PaidFreezDays   where OrderID = @OrderID"
						ExecuteReader(freezPaid)
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("new paid freez!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try
	End Sub
	Sub payFreezDaysFrdeposit()

		Try
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex
					Dim ordID As Integer = DataGrid8(j, 7)

					'If TextBox16.Text <> "" Then
					'    ordID = Int(TextBox16.Text)
					'Else
					'    MsgBox("No order selected!")
					'    Exit Sub
					'End If
					Dim CardID As String = txtCardId.Text

					Dim cmdPoDetID As SqlCommand
					cmdPoDetID = conn.CreateCommand()

					cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
					' conn.Open()

					Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
					Dim idDetID As Integer
					If IsDBNull(sqlResult1) Then

						idDetID = 1

					Else
						sqlResult1.ToString()
						idDetID = ExecuteScalar(cmdPoDetID)
						'  conn.Close()
						idDetID = idDetID + 1
					End If

					Dim custID As Integer = CInt(txtCustid.Text)
					Dim cashier As String = cmbAdmin.Text

					If frDays.Text <> "" And frAmount.Text <= GetDeposit(custID) Then
						Dim amount As Integer = Int(frAmount.Text)
						Dim days As Integer = Int(frDays.Text)
						If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

							Exit Sub
						Else

							Dim CMD As New SqlCommand("InsertPayment")
							' CMD.Parameters.Clear()
							CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

							CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
							CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
							CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = "deposit"



							CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "Freezing" 'cmbBasic.Text
							' If cmbBasic.Text = "Deposit" Then
							CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Additional"
							' Else
							' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
							'  End If
							CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
							CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
							CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
							CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
							CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


							CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

							CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
							CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
							CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
							CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
							CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

							CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = days

							CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
							CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "from deposit"

							'If ComboBox20.Text <> "" Then
							'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
							'Else
							CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = ordID
							'End If
							CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

							ExecuteProcedur.ExecuteCMD(CMD)
							' minusDeposit(custID, amount)
							CustomerHistory(custID, CardID, Reason:="FreezDeposit", Admin:=cashier)
							depositHistory(customerID:=custID, amount:=-amount, Reason:="HDM")
							PayAdditional(custID, cashier:="HDM", prodId:=0, PaymentMethode:="deposit", PaymentBasic:="deposit", UnitPrice:=amount, OrderID:=0, Quantity:=days, amount:=-amount)
							' PayAdditional(custID, cashier:="HDM", prodId:=0, PaymentMethode:="deposit", PaymentBasic:="Freezing", UnitPrice:=price, OrderID:=0, Quantity:=qty1, amount:=-(Totalprice))
							'End If
							MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
							' If ComboBox16.Text = "Cash" Then
							'  hdmPrintCheckFreezFromDeposit(cashAmount:=amount, posamount:=0, paymethode:="deposit", hdmId:=1, price:=amount)
							insertHdmCheckNew(PaidAmount:=amount, prodName:="Freezing", PaymentMethode:="deposit", hdmId:=1, dep:=custID)
						End If
					Else
						MsgBox("Check deposit balance!")
					End If
					Refresh_Tab()
				End If
			End If

		Catch ex As Exception
			MsgBox("Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try
	End Sub
	Sub payFreezDays()

		Try
			If DataGrid8 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then


				If Not IsDBNull(DataGrid8(DataGrid8.CurrentRowIndex, 8)) AndAlso DataGrid8(DataGrid8.CurrentRowIndex, 8) IsNot Nothing Then
					j = DataGrid8.CurrentRowIndex
					Dim ordID As Integer = DataGrid8(j, 7)


					Dim CardID As String = txtCardId.Text

					Dim cmdPoDetID As SqlCommand
					cmdPoDetID = conn.CreateCommand()

					cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
					' conn.Open()

					Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
					Dim idDetID As Integer
					If IsDBNull(sqlResult1) Then

						idDetID = 1

					Else
						sqlResult1.ToString()
						idDetID = ExecuteScalar(cmdPoDetID)
						'  conn.Close()
						idDetID = idDetID + 1
					End If

					Dim custID As Integer = CInt(txtCustid.Text)
					Dim cashier As String = cmbAdmin.Text
					If frDays.Text <> "" And frAmount.Text <> "" Then
						Dim amount As Integer = Int(frAmount.Text)
						Dim days As Integer = Int(frDays.Text)
						If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

							Exit Sub
						Else


							Dim CMD As New SqlCommand("InsertPayment")
							' CMD.Parameters.Clear()
							CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

							CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
							CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
							CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = ComboBox16.Text



							CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "Freezing" 'cmbBasic.Text
							' If cmbBasic.Text = "Deposit" Then
							CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Additional"
							' Else
							' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
							'  End If
							CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
							CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = cmbAdmin.Text & "/" & RichTextBox3.Text
							CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = 0 'coach
							CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = 0
							CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


							CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

							CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
							CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
							CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
							CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
							CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

							CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = days

							CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
							CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

							'If ComboBox20.Text <> "" Then
							'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
							'Else
							CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = ordID
							'End If
							CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

							ExecuteProcedur.ExecuteCMD(CMD)

							CustomerHistory(custID, CardID, Reason:="FreezPayments", Admin:=cashier)

							Dim qntHDM As Double
							Totalprice = CDbl(Val(frAmount.Text))
							'Totalprice = amount
							qntHDM = 1 ' CDbl(Val(frDays.Text))
							price = Totalprice ' Math.Round(Totalprice / qntHDM, 2)


							'End If
							MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
							If ComboBox16.Text = "Cash" Then
								HdmPrintCheckFreezCashP(cashAmount:=Totalprice, posamount:=0, paymethode:=ComboBox16.Text, hdmId:=1)
								insertHdmCheckNew(PaidAmount:=amount, prodName:="Freezing", PaymentMethode:="Cash", hdmId:=1, dep:=custID) 'dep eto customerid
							Else
								HdmPrintCheckFreezPOSP(cashAmount:=0, posamount:=Totalprice, paymethode:=ComboBox16.Text, hdmId:=1)
								insertHdmCheckNew(PaidAmount:=amount, prodName:="Freezing", PaymentMethode:="POS", hdmId:=1, dep:=custID)
							End If
						End If
					Else
						MsgBox("No amount entered!")
					End If
					Refresh_Tab()
				End If
			End If

		Catch ex As Exception
			MsgBox("payreezdays", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try
	End Sub
	Public Sub HdmPrintCheckFreezCashP(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer) ', price As Double, qty As Double)

		' hdmId = CInt(ComboBox2.SelectedValue)
		Dim item As Boolean
		Dim idProd As Integer
		'  hdmSettings()
		idProd = 235
		dep = GetHdmItemsByID(idProd).dep
		'nameProd = GetHdmItemsByID(idProd).ProductName
		nameProd = "Քարտի սառեցում" & " " & frDays.Text & " օր"

		codeProd = GetHdmItemsByID(idProd).ProductCode
		unit = GetHdmItemsByID(idProd).UnitType
		adgCode = GetHdmItemsByID(idProd).ADG
		'  dep = 9
		discount = 0
		Totalprice = cashAmount

		qty1 = 1 ' CDbl(Val(frDays.Text))
		price = Math.Round(Totalprice, 2)
		'price = Math.Round(Totalprice / qty1, 2)
		PaymentBase = paymethode
		'cash = cashAmount
		'pos = posamount

		HDMfr.OpenSaleDocument(2)
		item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
		Dim PaymentMethode As String

		PaymentMethode = paymethode


		Dim check As Boolean
		If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

			Exit Sub
		Else

			check = HDMfr.printdocument(cashAmount, posamount) 'ok cash

			If check = True Then
				MsgBox("ok print", MsgBoxStyle.OkOnly, "message :")
				insertHdmCheck(cashAmount, nameProd, PaymentMethode, hdmId, dep)
			Else
				MsgBox("print error", MsgBoxStyle.OkOnly, "message :")
				MsgBox(HDMfr.errcode & HDMfr.errdescription, MsgBoxStyle.OkOnly, "message :")
				' console.write("not")
			End If
		End If
	End Sub
	Public Sub HdmPrintCheckFreezPOSP(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer)



		Dim item As Boolean
		Dim idProd As Integer

		idProd = 235
		dep = 14

		codeProd = GetHdmItemsByID(idProd).ProductCode
		unit = GetHdmItemsByID(idProd).UnitType
		adgCode = GetHdmItemsByID(idProd).ADG
		'  dep = 9
		discount = 0
		Totalprice = posamount

		qty1 = 1 ' CDbl(Val(frDays.Text))
		price = Math.Round(Totalprice, 2)

		nameProd = "Քարտի սառեցում" & " " & frDays.Text & " օր"
		PaymentBase = paymethode


		HDMfr.OpenSaleDocument(2)
		item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
		Dim PaymentMethode As String
		'  HDM.PrintDocument(cashAmount, posamount)
		PaymentMethode = paymethode

		'HDM.PrintDocument(0, Totalprice)
		'    PaymentMethode = "POS"
		Dim check As Boolean
		If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

			Exit Sub
		Else
			check = HDMfr.PrintDocument(0, posamount)

			If check = True Then
				MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
				insertHdmCheck(posamount, nameProd, PaymentMethode, hdmId, dep)
			Else
				MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
				MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
				' Console.Write("Not")
			End If
		End If
	End Sub
	Sub payClip()

		Try
			Dim custID As Integer = CInt(txtCustid.Text)
			Dim cashier As String = cmbAdmin.Text
			'If frDays.Text <> "" And frAmount.Text <> "" Then
			Dim amount As Integer = Int(txtAmount.Text)
			Dim days As Integer = Int(txtFree.Text)
			Dim coachid As Integer = Int(txtCoachId.Text)
			Dim prid As Integer = Int(txtPrId.Text)
			Dim clipid As Integer = GenerateID() - 1 ' Int(txtClid.Text)

			Dim CardID As String = txtCardId.Text
			If amount = 0 Then
				'  If MsgBox("Save as bonus? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Ok Then
				Exit Sub
			Else
				Dim cmdPoDetID As SqlCommand
				cmdPoDetID = conn.CreateCommand()

				cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
				' conn.Open()

				Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
				Dim idDetID As Integer
				If IsDBNull(sqlResult1) Then

					idDetID = 1

				Else
					sqlResult1.ToString()
					idDetID = ExecuteScalar(cmdPoDetID)
					'  conn.Close()
					idDetID = idDetID + 1
				End If



				If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

					Exit Sub
				Else
					ReadyConnectionF()


					Dim CMD As New SqlCommand("InsertPayment")
					' CMD.Parameters.Clear()
					CMD.Parameters.Add("@ID", SqlDbType.Int).Value = idDetID

					CMD.Parameters.Add("@Amount", SqlDbType.NChar).Value = amount
					CMD.Parameters.Add("@DateReceived", SqlDbType.DateTime).Value = Date.Now 'na forme
					CMD.Parameters.Add("@PaymentMethode", SqlDbType.NChar).Value = cmbPyMet.Text



					CMD.Parameters.Add("@PaymentBasic", SqlDbType.NChar).Value = "ClipCard" 'cmbBasic.Text
					' If cmbBasic.Text = "Deposit" Then
					CMD.Parameters.Add("@PaymentPurpose", SqlDbType.NChar).Value = "Additional"
					' Else
					' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
					'  End If
					CMD.Parameters.Add("@ChekNumber", SqlDbType.NVarChar).Value = 0
					CMD.Parameters.Add("@Notes", SqlDbType.NText).Value = clipid 'cmbAdmin.Text & "/" & RichTextBox3.Text
					CMD.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = coachid
					CMD.Parameters.Add("@ProductID", SqlDbType.Int).Value = prid
					CMD.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custID


					CMD.Parameters.Add("@PurchaseOrderID", SqlDbType.Int).Value = 0

					CMD.Parameters.Add("@EmplID", SqlDbType.Int).Value = 0
					CMD.Parameters.Add("@RegistrationDate", SqlDbType.DateTime).Value = Date.Now ' na forme naoborot recieveddate t.k. sort 
					CMD.Parameters.Add("@ActivationDate", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@Deadline", SqlDbType.DateTime).Value = Date.Now
					CMD.Parameters.Add("@UnitPrice ", SqlDbType.Decimal).Value = amount

					CMD.Parameters.Add("@Quantity ", SqlDbType.Decimal).Value = days

					CMD.Parameters.Add("@Discount ", SqlDbType.Float).Value = 0
					CMD.Parameters.Add("@POstatus ", SqlDbType.NChar).Value = "PAID"

					'If ComboBox20.Text <> "" Then
					'    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
					'Else
					CMD.Parameters.Add("@OrderID", SqlDbType.Int).Value = 0
					'End If
					CMD.Parameters.Add("@EmpPercent", SqlDbType.Int).Value = 0

					ExecuteProcedur.ExecuteCMD(CMD)

					CustomerHistory(custID, CardID, Reason:="ClipPayments", Admin:=cashier)




				End If
				MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
				Refresh_Tab()
				If MsgBox("Are you sure to print hdm check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

					Exit Sub
				Else
					If cmbPyMet.Text = "Cash" Then
						hdmPrintCheckClipCash(cashAmount:=amount, posamount:=0, paymethode:=cmbPyMet.Text, hdmId:=1, price:=amount, clipProduct:=prid)
						insertHdmCheckNew(PaidAmount:=amount, prodName:="Clip", PaymentMethode:="Cash", hdmId:=1, dep:=custID) 'dep eto customerid
					Else
						hdmPrintCheckClipPOS(cashAmount:=0, posamount:=amount, paymethode:=cmbPyMet.Text, hdmId:=1, price:=amount, clipProduct:=prid)
						insertHdmCheckNew(PaidAmount:=amount, prodName:="clip", PaymentMethode:="POS", hdmId:=1, dep:=custID)
					End If
				End If

				'Else
				'MsgBox("No amount entered!")
			End If

			'End If
			'End If

		Catch ex As Exception
			MsgBox("hdm error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End Try
	End Sub


	Private Sub frPay_Click(sender As Object, e As EventArgs) Handles frPay.Click
		freezAdmin()
		' payFreezDays()
	End Sub

	Private Sub txtFirst_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			' ref()
			FindName()
		End If
	End Sub

	Private Sub DataGrid8_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGrid8.KeyUp
		freezAdminDisplay()
	End Sub



	Private Sub DataGrid8_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGrid8.MouseClick
		freezAdminDisplay()
	End Sub

	Private Sub DataGrid8_Click(sender As Object, e As EventArgs) Handles DataGrid8.Click
		freezAdminDisplay()
	End Sub

	Private Sub DataGrid8_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGrid8.KeyDown
		freezAdminDisplay()
	End Sub

	Private Sub DataGrid8_VisibleChanged(sender As Object, e As EventArgs) Handles DataGrid8.VisibleChanged
		'freezAdminDisplay()
	End Sub

	Private Sub DataGrid8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGrid8.MouseDoubleClick
		freezAdminDisplay()
	End Sub
	Sub WaitOrders()
		orders.Text = "Waiting orders"
		Dim custID As Integer = CInt(txtCustid.Text)

		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			'    If adminByReason("new clip") = True Then
			Dim Res As Integer
			ReadyConnectionF()
			Dim cmdActive As New SqlCommand
			cmdActive = conn.CreateCommand
			cmdActive.CommandText = "Select count(orderid)  From ordWaitting Where CustomerID = '" & custID & " ' "
			Res = ExecuteScalar(cmdActive)
			If Res = 0 Then
				MsgBox("No waiting order!", MsgBoxStyle.OkOnly, "Info ")

				Exit Sub
			Else
				Button36.Enabled = True

				'  Dim ds As New DataSet
				Dim cmdord As New SqlCommand
				cmdord = conn.CreateCommand
				Dim da As New SqlDataAdapter
				Dim LateDate = Date.Now
				' cmd.CommandText = "select * from OrdDate where CustomerID = '" & ComboBox7.SelectedValue & " ' "
				ds.Clear()
				cmdord.CommandText = "select * from ordWaitting where CustomerID = '" & custID & " '  "

				da.SelectCommand = cmdord

				' dgvOrders.Refresh()
				' da.Fill(ds, "ProductOrder")

				dgvOrders.DataSource = ds

				da.Fill(ds, "ordWaitting")
				dgvOrders.DataMember = "ordWaitting"



				cmdord = conn.CreateCommand
			End If
			fillComboProduct()
			FillCoach()
			Admin()
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
	End Sub

	Private Sub Button35_Click_1(sender As Object, e As EventArgs) Handles Button35.Click
		WaitOrders()

	End Sub
	Function AllOrdersAsync() As DataSet

		Dim custID As Integer = CInt(txtCustid.Text)
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Dim allOrders As New DataSet

		Try
			Dim connecton = GetSqlConnection()
			Using connection
				Dim cmdord As New SqlCommand
				cmdord = connecton.CreateCommand
				Using cmdord
					Dim da As New SqlDataAdapter
					cmdord.CommandText = "select * from OrdersFullLast where CustomerID = '" & custID & " ' AND OrderName <> 'Guest'"
					da.SelectCommand = cmdord
					da.Fill(allOrders, "OrdersFullLast")
				End Using
			End Using
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
		End Try
		Return allOrders
	End Function

	Sub AllOrders()

		Dim custID As Integer = CInt(txtCustid.Text)
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			ReadyConnectionF()
			Dim ds As New DataSet
			Dim cmdord As New SqlCommand
			cmdord = conn.CreateCommand
			Dim da As New SqlDataAdapter
			Dim LateDate = Date.Now
			custID = Trim(custID)
			cmdord.Parameters.AddWithValue("@custID", custID)
			cmdord.CommandText = "SELECT * FROM OrdersFullLast WHERE CustomerID = @custID AND OrderName <> 'Guest'"



			'cmdord.CommandText = "select * from OrdersFullLast where CustomerID = '" & custID & " ' and OrderName <>'Guest' "

			da.SelectCommand = cmdord            ' 

			da.Fill(ds, "OrdersFullLast")
			dgvOrders.DataSource = ds


			dgvOrders.DataMember = "OrdersFullLast"

		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
	End Sub


	Function GetPaymentsAsync() As DataSet
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim ds As New DataSet
		Dim da As New SqlDataAdapter
		Dim cmd As New SqlCommand
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			Dim connection = GetSqlConnection()
			Using connection
				cmd = connection.CreateCommand
				Using cmd
					cmd.CommandText = "select * from profilePO where CustomerID  = '" & custID & " ' order by DateReceived "
					da.SelectCommand = cmd
					da.Fill(ds, "dtPay")
				End Using
			End Using
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
		End Try
		Return ds

	End Function
	Function GetFreezAsync() As DataSet
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")
		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Dim ds As New DataSet
		Dim cmd7 As New SqlCommand
		Try
			Dim connection = GetSqlConnection()
			Using connection
				cmd7 = connection.CreateCommand
				cmd7.CommandText = "select * from FreezBalUsed where CustomerID = '" & custID & " ' "
				Dim da7 As New SqlDataAdapter
				da7.SelectCommand = cmd7
				da7.Fill(ds, "FreezPaidFree")
			End Using
			'freezAdminDisplay()
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
		Return ds
	End Function
	Sub tabPayments()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim ds As New DataSet
		Dim da As New SqlDataAdapter
		Dim cmd As New SqlCommand
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			ReadyConnectionF()

			cmd = conn.CreateCommand
			cmd.CommandText = "select * from profilePO where CustomerID  = '" & custID & " ' order by DateReceived "

			da.SelectCommand = cmd
			da.Fill(ds, "dtPay")

			DataGridView4.DataSource = ds
			DataGridView4.DataMember = "dtPay"
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try

	End Sub
	Sub tabFreez()
		Dim custID As Integer = CInt(txtCustid.Text)

		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Try
			ReadyConnectionF()


			Dim ds As New DataSet
			Dim cmd7 As New SqlCommand
			cmd7 = conn.CreateCommand
			cmd7.CommandText = "select * from FreezBalUsed where CustomerID = '" & custID & " ' "
			Dim da7 As New SqlDataAdapter
			da7.SelectCommand = cmd7
			da7.Fill(ds, "FreezPaidFree")
			DataGrid8.DataSource = ds
			DataGrid8.DataMember = "FreezPaidFree"
			DataGrid8.CaptionText = "Freezing Balance"
			If DataGrid8.CurrentRowIndex + 1 > 0 Then
				TextBox15.Text = DataGrid8(DataGrid8.CurrentRowIndex, 4) '
				Dim ordid As Integer
				ordid = DataGrid8(DataGrid8.CurrentRowIndex, 7)
				' j = DataGrid8.CurrentRowIndex  'ad
				Dim cmd As New SqlCommand
				cmd = conn.CreateCommand

				cmd.CommandText = "select * from FreezBalance where CustomerID = '" & custID & "' and orderid='" & ordid & "' "




				Dim da6 As New SqlDataAdapter
				Dim ds1 As New DataSet
				da6.SelectCommand = cmd
				da6.Fill(ds1, "FreezBalance")
				DataGrid6.DataSource = ds1
				DataGrid6.DataMember = "FreezBalance"
				DataGrid6.CaptionText = "Freezing History"
			Else
				DataGrid6.DataSource = Nothing
			End If

			'freezAdminDisplay()
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try

	End Sub

	Private Sub Button36_Click_1(sender As Object, e As EventArgs) Handles Button36.Click
		activateWaiting()
		fillComboProduct()
		FillCoach()
		Admin()
	End Sub

	Private Sub DataGrid8_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid8.DoubleClick
		freezAdminDisplay()
	End Sub



	Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
		Dim custID As Integer = CInt(txtCustid.Text)
		GetOrders(custID)
	End Sub

	Private Sub DataGrid8_Enter(sender As Object, e As EventArgs) Handles DataGrid8.Enter
		freezAdminDisplay()
	End Sub



	'Private Sub Button38_Click(sender As Object, e As EventArgs)
	'    PayClipCard()
	'End Sub





	'Private Sub TextBox33_KeyDown(sender As Object, e As KeyEventArgs)
	'    Dim amount As Integer = Int(TextBox28.Text)
	'    If amount > 0 Then
	'        TextBox34.Text = amount - Int(TextBox33.Text) * amount / 100
	'    End If
	'End Sub
	Sub addGuest()

		Dim custID As Integer = CInt(txtCustid.Text)
		Dim CardID As String = txtCardId.Text
		Dim FirstName = TextBox36.Text
		Dim LastName = TextBox35.Text
		If TextBox36.Text = "" Then
			MsgBox("Please enter first name", MsgBoxStyle.Exclamation, "Warning")
			TextBox36.Focus()
			Exit Sub
		End If
		If TextBox35.Text = "" Then
			MsgBox("Please enter last name", MsgBoxStyle.Exclamation, "Warning")
			TextBox35.Focus()
			Exit Sub
		End If
		If cmbAdmin.Text = "" Then
			MsgBox("Please select Admin", MsgBoxStyle.Exclamation, "Warning")
			cmbAdmin.Focus()
			Exit Sub
		End If



		CustGuest(custID, FirstName, LastName)
		GetDetails()
		Refresh_Tab()
		'If DataGridView6 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
		'    'DataGridView.Item("ColumnNameHere",0).Value = "Hello"
		'    If DataGridView6.CurrentRow.Index >= 0 Then
		'        j = DataGridView6.CurrentRow.Index

		'        Dim GstID As Integer
		'        GstID = DataGridView6.Item("Guestid", j).Value.ToString
		'        GetdataCust(GstID)
		'    End If
		'End If
		CustomerHistory(custID, CardID, Reason:="Guest", Admin:=cmbAdmin.Text)
		'tabGuest()
		' updateDisplay()
		' ref()
		' Refresh_Tab()
		cmbReason.Text = ""
	End Sub
	Public Function CustGuest(custid As Integer, FirstName As String, LastName As String) As Customer  'into customers
		Dim res As Customer = Nothing
		ReadyConnectionF()
		Dim strID As String = "Select max(ID) from customers"
		Dim cmdMax As SqlCommand = New SqlCommand(strID, conn)
		Dim GuestID As Integer = ExecuteScalar(cmdMax)
		'++++++

		'+++++++


		Dim cmdGuestID As New SqlCommand
		cmdGuestID = conn.CreateCommand
		cmdGuestID.CommandText = "Select max(ID)  from GuestCheckIn"
		Dim GCheckInId As Integer
		Dim sqlResult1 As Object = cmdGuestID.ExecuteScalar()
		If IsDBNull(sqlResult1) Then
			GCheckInId = 1
		Else
			sqlResult1.ToString() 'result found
			GCheckInId = cmdGuestID.ExecuteScalar
			GCheckInId = GCheckInId + 1
		End If

		Dim cmdInsertGuest As New SqlCommand   'GuestCheckin
		cmdInsertGuest = conn.CreateCommand
		cmdInsertGuest.Parameters.Add("@operden", SqlDbType.SmallDateTime).Value = Date.Now '
		cmdInsertGuest.Parameters.Add("@ID", SqlDbType.Int).Value = GCheckInId
		cmdInsertGuest.Parameters.Add("@CustomerID", SqlDbType.Int).Value = custid  'guest owner id
		cmdInsertGuest.Parameters.Add("@GuestID", SqlDbType.Int).Value = GuestID + 1 'new customer id
		cmdInsertGuest.CommandText = "Insert into GuestCheckIn VALUES (@ID ,@GuestID,@CustomerID,@operDen)"
		cmdInsertGuest.ExecuteNonQuery()

		Dim timeStamp As String = Date.Now.ToString("yyyyMMddhhmmss")

		Dim cmdInsertCustG As New SqlCommand   'GuestCheckin
		cmdInsertCustG = conn.CreateCommand
		cmdInsertCustG.Parameters.Add("@ID", SqlDbType.Int).Value = GuestID + 1 'customerId
		cmdInsertCustG.Parameters.Add("@CardID", SqlDbType.NVarChar).Value = "gst" & custid & "gst" & timeStamp
		cmdInsertCustG.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName  '
		cmdInsertCustG.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName
		cmdInsertCustG.Parameters.Add("@cardType", SqlDbType.NVarChar).Value = "temp"
		cmdInsertCustG.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "enabled"
		cmdInsertCustG.CommandText = "Insert into Customers(Id,CardId,FirstName,LastName,CardType,Status) VALUES (@ID ,@CardID,@FirstName,@LastName,@cardType,@Status)"
		cmdInsertCustG.ExecuteNonQuery()


		Dim dt As Date
		dt = Now()
		Dim cmd
		cmd = conn.CreateCommand

		cmd.CommandText = "UPDATE  Customers Set Sex = '',Language= '', UID = '',HomePhone= '', MobilePhone= '',Address = ''," &
		"Passport= '', BornOn =  '',WebPage= '' ,Email = '',ContactPerson= '',ContactPersonPhone= '',Notes= '',Attachments= '' where id ='" & GuestID + 1 & "'"

		ExecuteReader(cmd)
		' Profile.ref()
		' Dim GstID As Integer
		GetdataCust(GuestID + 1)
		MsgBox("Done", MsgBoxStyle.Information, "OK")

		'focusCardId(Profile.dgw, "gst" & custid & "gst" & timeStamp)
		Return res
	End Function
	Sub addSameGuest()

		Dim custID As Integer = CInt(txtCustid.Text)

		If DataGridView6 IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
			'DataGridView.Item("ColumnNameHere",0).Value = "Hello"
			If DataGridView6.CurrentRow.Index >= 0 Then
				j = DataGridView6.CurrentRow.Index

				Dim GstID As Integer
				GstID = DataGridView6.Item("Guestid", j).Value.ToString


				CustGuestRepeat(custID, GuestID:=GstID)
			End If
		End If
		' updateDisplay()
		' ref()
		' Refresh_Tab()
		tabGuest()
	End Sub
	Sub Guest()
		ReadyConnectionF()
		Dim ordActive As Integer
		Dim balance As Integer
		Dim j As Integer
		j = DataGridView5.CurrentRow.Index
		Dim custID As Integer = CInt(txtCustid.Text)

		ordActive = DataGridView5.Item("ordActive", j).Value.ToString
		balance = DataGridView5.Item("balance", j).Value.ToString
		'ordid = DataGridView5.Item("orderid", j).Value.ToString
		'    Dim custID As Integer = CInt(txtCustid.Text)

		' Using CMDOrd = New SqlCommand("GetGuestOrder", conn)

		'        ' Dim custID As Integer = CInt(txtCustid.Text)

		'        CMDOrd.CommandType = System.Data.CommandType.StoredProcedure
		'        CMDOrd.Parameters.Add(New SqlParameter("@ordid", ordid))


		'        Dim returnParameter1 = CMDOrd.Parameters.Add("@result", SqlDbType.Int)
		'        returnParameter1.Direction = ParameterDirection.ReturnValue
		'        CMDOrd.ExecuteScalar()
		'        Dim result1 = Convert.ToInt32(returnParameter1.Value)
		'        If result1 = 0 Then

		If ordActive = 0 Then
			MessageBox.Show("Order not active!")


			Exit Sub

		Else




			'Using CMD = New SqlCommand("GetGuestBalance", conn)

			'            CMD.CommandType = System.Data.CommandType.StoredProcedure
			'            CMD.Parameters.Add(New SqlParameter("@ordID", ordid))


			'            Dim returnParameter = CMD.Parameters.Add("@result", SqlDbType.Decimal)
			'            returnParameter.Direction = ParameterDirection.ReturnValue
			'            CMD.ExecuteScalar()
			'            Dim result = Convert.ToInt32(returnParameter.Value)
			' If result > 0 Then

			If balance > 0 Then
				addGuest()
				Dim st As String
				Dim oper As String
				oper = "new guest customerid  " & custID
				st = lblUser.Text
				LogFunc(st, oper)

			Else
				MessageBox.Show("Limit reached!")
				Exit Sub
			End If
			' End Using
		End If
		'  End Using








	End Sub


	'Private Sub usedFreeClipCard()
	'    Dim custID As Integer = CInt(txtCustid.Text)
	'    Try

	'        Dim EmployeeID = Int(TextBox31.Text)
	'        '  Dim productid = Int(TextBox29.Text)

	'        ' ClipCardUsage(EmployeeID, custID, productid)
	'        ClipCardUsage(EmployeeID, custID)

	'    Catch ex As SqlException
	'        MessageBox.Show(ex.ToString)
	'        '  MessageBox.Show("No any data!")
	'    End Try
	'    'updateDisplay()
	'    'Refresh_Tab()
	'End Sub


	Private Sub usedClipCard()
		If txtClid.Text <> "" And txtCustid.Text <> "" And txtCoachId.Text <> "" Then
			Dim custID As Integer = CInt(txtCustid.Text)
			Dim EmployeeID = Int(txtCoachId.Text)
			Dim recId = Int(txtClid.Text)
			If cmbCoach.Text = "" Then
				MsgBox("Please select coach", MsgBoxStyle.Exclamation, "Warning")
				cmbCoach.Focus()
				Exit Sub
			End If
			Dim myDate As Date = Date.Parse(dtEnd.Text)

			Dim daysToAdd As Integer = Integer.Parse(txtUsed.Text)
			Dim res As Date = myDate.AddDays(1)
			' Dim res As DateTime = myDate
			' Debug.Print(myDate & "  " & daysToAdd & "  " & res)
			If res <= Date.Now Then
				MessageBox.Show("Date period endeed!")
				Exit Sub
			End If


			'        
			Dim CMD = New SqlCommand
			CMD = conn.CreateCommand
			CMD.CommandText = "select balance from Clipfrm where clID = '" & recId & " ' and CustomerID = '" & custID & " '"
			CMD.Parameters.Add(New SqlParameter("@CustomerID", custID))
			CMD.Parameters.Add(New SqlParameter("@LocationID", recId))

			Dim result = ExecuteScalar(CMD)
			If result > 0 Then
				If AdminByReason("clip usage") = True Then

					ClipCardUsage(EmployeeID, custID, recId)
					txtClid.Text = recId
					printClip(recId, result - 1, res)
					GetClipUsage(txtClid.Text)
					'  tabClip()
				End If
			Else
				MessageBox.Show("Limit reached!")
				Exit Sub
			End If
		End If
		'DataGridView7.Rows(j).Cells(0).Selected = True

	End Sub
	Private Sub DelUsedClipCard()
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim j As Integer
		Try
			If dgvUsage.CurrentRow IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

				If dgvUsage.CurrentRow.Index >= 0 Then
					If AdminByReason("delete clip usage") = True Then
						j = dgvUsage.CurrentRow.Index
						Dim usID = dgvUsage.Item("usid", j).Value.ToString

						Dim cmdDelUsed As New SqlCommand
						cmdDelUsed = conn.CreateCommand
						cmdDelUsed.CommandText = "Delete  from AddPrductUsage where usageid = '" & usID & " ' "
						Dim check1 As Integer = ExecuteReader(cmdDelUsed).RecordsAffected
						If check1 > 0 Then

							MsgBox(" Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete")

							Dim st As String
							Dim oper As String
							oper = "delete clip usage  " & custID
							st = lblUser.Text
							LogFunc(st, oper)
						End If
					Else
						MsgBox(" Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete")
					End If



				End If
			Else
				Exit Sub
			End If
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
		' updateDisplay()
		GetClipUsage(txtClid.Text)
		'  Refresh_Tab()
		' dgvUsage.Rows(j).Cells(0).Selected = True
	End Sub
	Private Sub markUsedClipCard()
		'   Dim custID As Integer = CInt(txtCustid.Text)
		Dim j As Integer

		Try
			If dgvUsage.CurrentRow IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

				If dgvUsage.CurrentRow.Index >= 0 Then

					j = dgvUsage.CurrentRow.Index
					Dim usID = dgvUsage.Item("usid", j).Value.ToString

					Dim cmdDelUsed As New SqlCommand
					cmdDelUsed = conn.CreateCommand
					cmdDelUsed.CommandText = "update   AddPrductUsage set st = 1 where usageid = '" & usID & " ' "
					If AdminByReason("mark clip usage") = True Then
						Dim check1 As Integer = ExecuteReader(cmdDelUsed).RecordsAffected
						If check1 > 0 Then

							MsgBox(" Succesfully", MsgBoxStyle.OkOnly, "Info Delete")

							'Dim str As String
							'Dim oper As String
							'oper = "mark clip usage  " & custID
							'str = lblUser.Text
							'LogFunc(str, oper)
						End If
					Else
						Exit Sub
						' MsgBox(" Failure", MsgBoxStyle.OkOnly, "Info")
					End If




				Else
					Exit Sub
				End If
			End If
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
		' updateDisplay()
		GetClipUsage(txtClid.Text)
		'  Refresh_Tab()
		' dgvUsage.Rows(j).Cells(0).Selected = True
	End Sub
	Private Sub Button39_Click(sender As Object, e As EventArgs)
		usedClipCard()
	End Sub

	Private Sub undoUsedClipCard()
		'   Dim custID As Integer = CInt(txtCustid.Text)
		Dim j As Integer

		Try
			If dgvUsage.CurrentRow IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

				If dgvUsage.CurrentRow.Index >= 0 Then

					j = dgvUsage.CurrentRow.Index
					Dim usID = dgvUsage.Item("usid", j).Value.ToString

					Dim cmdDelUsed As New SqlCommand
					cmdDelUsed = conn.CreateCommand
					cmdDelUsed.CommandText = "update   AddPrductUsage set st = 0 where usageid = '" & usID & " ' "
					If AdminByReason("undo mark clip usage") = True Then
						Dim check1 As Integer = ExecuteReader(cmdDelUsed).RecordsAffected
						If check1 > 0 Then

							MsgBox(" Succesfully", MsgBoxStyle.OkOnly, "Info Delete")

							'Dim str As String
							'Dim oper As String
							'oper = "mark clip usage  " & custID
							'str = lblUser.Text
							'LogFunc(str, oper)
						End If
					Else
						Exit Sub
						' MsgBox(" Failure", MsgBoxStyle.OkOnly, "Info")
					End If




				Else
					Exit Sub
				End If
			End If
		Catch ex As SqlException
			MessageBox.Show(ex.ToString)
			'  MessageBox.Show("No any data!")
		End Try
		' updateDisplay()
		GetClipUsage(txtClid.Text)
		'  Refresh_Tab()
		' dgvUsage.Rows(j).Cells(0).Selected = True
	End Sub



	'Private Sub txtPhone1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPhone1.KeyUp
	'    If e.KeyCode = Keys.Escape Then
	'        blnEscape = True
	'    End If
	'End Sub

	Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
		PayGuest()
	End Sub
	Sub deleteGuest()
		Dim j As Integer
		ReadyConnectionF()

		If DataGridView6.CurrentRow IsNot Nothing Then ' 
			If DataGridView6.CurrentRow.Index >= 0 Then
				j = DataGridView6.CurrentRow.Index

				Dim gID As Integer
				Dim custGID As Integer
				gID = DataGridView6.Item("ID", j).Value.ToString 'id guestCheckin
				custGID = DataGridView6.Item("GuestId", j).Value.ToString 'id customer as  guest-not owner

				Dim cmdDel As New SqlCommand
				cmdDel = conn.CreateCommand
				cmdDel.CommandText = "Delete from GuestCheckIn where ID = '" & gID & " '"
				ExecuteReader(cmdDel)

				'Dim cmdDelCust As New SqlClient.SqlCommand
				'cmdDelCust = conn.CreateCommand
				'cmdDelCust.CommandText = "Delete from Customers where ID = '" & custGID & " '"
				' ExecuteReader(cmdDelCust)


				Dim check1 As Integer = ExecuteReader(cmdDel).RecordsAffected


				' Dim check1 As Integer = ExecuteReader(cmdDelCust).RecordsAffected
				If check1 > 0 Then

					MsgBox(" Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete")
					Dim custID As Integer = CInt(txtCustid.Text)
					Dim st As String
					Dim oper As String
					oper = "guest delete  " & custID
					st = lblUser.Text
					LogFunc(st, oper)
				Else
					MsgBox(" Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete")
				End If

			End If
		End If
		tabGuest()
	End Sub
	Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click

		deleteGuest()
	End Sub

	Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
		updateGuestFree()
	End Sub

	'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
	'    Dim amount As Integer = Int(TextBox28.Text)
	'    Dim sumAm
	'    If TextBox28.Text > 0 Then
	'        If CheckBox1.Checked = True Then
	'            sumAm = amount - amount * 0.1
	'            TextBox34.Text = sumAm
	'        Else
	'            TextBox34.Text = amount
	'            ' TextBox34.Text = amount - Int(TextBox33.Text) * amount / 100
	'        End If
	'    End If
	'End Sub



	''Private Sub txtPhone1_Leave(sender As Object, e As EventArgs) Handles txtPhone1.Leave
	''    If blnEscape = False Then
	''        Dim dt As Date
	'        If Date.TryParseExact(txtPhone1.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, dt) Then
	'            Console.WriteLine(dt)
	'        Else
	'            MsgBox("Please enter date in  dd/mm/yyyy format!")
	'            txtPhone1.Focus()
	'        End If



	'    End If
	'End Sub



	Private Sub Button44_Click(sender As Object, e As EventArgs)
		DelUsedClipCard()
	End Sub

	Private Sub Button43_Click(sender As Object, e As EventArgs)
		' updateClipFree()
	End Sub

	'Private Sub Button45_Click(sender As Object, e As EventArgs)
	'    Dim j As Integer
	'    If ComboBox18.Text = "" Then
	'        MsgBox("Please select coach", MsgBoxStyle.Exclamation, "Warning")
	'        ComboBox18.Focus()
	'        Exit Sub
	'    End If
	'    Dim custID As Integer = CInt(txtCustid.Text)
	'    If dgvUsage.CurrentRow IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

	'        If dgvUsage.CurrentRow.Index >= 0 Then
	'            j = dgvUsage.CurrentRow.Index

	'            Dim oldEmployeeID As Integer = dgvUsage.Item("EmplID", j).Value.ToString

	'            Dim newEmployeeID = Int(TextBox31.Text)
	'            ClipCoachUpdate(newEmployeeID, oldEmployeeID, custID)
	'            tabClip()
	'        End If
	'    End If
	'    ' Refresh_Tab()

	'    dgvUsage.Rows(j).Cells(0).Selected = True

	'End Sub

	Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
		If DataGridView5.CurrentCell Is Nothing Then
			Exit Sub
		Else
			TheSameGuest()
		End If
	End Sub
	'    ReadyConnectionF()
	'    Dim ordid As Integer
	'    Dim j As Integer


	'    j = DataGridView5.CurrentRow.Index
	'    ordid = DataGridView5.Item("orderid", j).Value.ToString
	'    Using CMD = New SqlCommand("GetGuestBalance", conn)
	'        Dim custID As Integer = CInt(txtCustid.Text)

	'        CMD.CommandType = System.Data.CommandType.StoredProcedure
	'        CMD.Parameters.Add(New SqlParameter("@ordID", ordid))


	'        Dim returnParameter = CMD.Parameters.Add("@result", SqlDbType.Decimal)
	'        returnParameter.Direction = ParameterDirection.ReturnValue
	'        CMD.ExecuteScalar()
	'        Dim result = Convert.ToInt32(returnParameter.Value)
	'        If result > 0 Then

	'            addSameGuest()

	'            Dim st As String
	'            Dim oper As String
	'            oper = "new guest customerid  " & custID
	'            st = lblUser.Text
	'            LogFunc(st, oper)
	'        Else
	'            MessageBox.Show("Limit reached!")
	'            Exit Sub
	'        End If


	'    End Using



	'End Sub
	Sub TheSameGuest()
		ReadyConnectionF()
		Dim ordid As Integer
		Dim j As Integer


		j = DataGridView5.CurrentRow.Index
		ordid = DataGridView5.Item("orderid", j).Value.ToString
		Dim custID As Integer = CInt(txtCustid.Text)

		Using CMDOrd = New SqlCommand("GetGuestOrder", conn)

			' Dim custID As Integer = CInt(txtCustid.Text)

			CMDOrd.CommandType = CommandType.StoredProcedure
			CMDOrd.Parameters.Add(New SqlParameter("@ordid", ordid))


			Dim returnParameter1 = CMDOrd.Parameters.Add("@result", SqlDbType.Int)
			returnParameter1.Direction = ParameterDirection.ReturnValue
			CMDOrd.ExecuteScalar()
			Dim result1 = Convert.ToInt32(returnParameter1.Value)
			If result1 = 0 Then
				MessageBox.Show("Order not active!")


				Exit Sub

			Else




				Using CMD = New SqlCommand("GetGuestBalance1", conn)

					CMD.CommandType = CommandType.StoredProcedure
					CMD.Parameters.Add(New SqlParameter("@ordID", ordid))


					Dim returnParameter = CMD.Parameters.Add("@result", SqlDbType.Decimal)
					returnParameter.Direction = ParameterDirection.ReturnValue
					CMD.ExecuteScalar()
					Dim result = Convert.ToInt32(returnParameter.Value)
					If result > 0 Then

						addSameGuest()
						Dim st As String
						Dim oper As String
						oper = "new guest customerid  " & custID
						st = lblUser.Text
						LogFunc(st, oper)

					Else
						MessageBox.Show("Limit reached!")
						Exit Sub
					End If
				End Using
			End If
		End Using











	End Sub
	Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
		Dim check1 As Decimal

		Dim cmd1 As New SqlCommand
		Dim cmd2 As New SqlCommand

		Dim custID As Integer = CInt(txtCustid.Text)
		cmd1 = conn.CreateCommand
		cmd1.CommandText = "select DepositAmount from DepositSPABonus  " &
		"where CustomerID = '" & custID & "'"
		Dim sqlResult1 As Object = ExecuteScalar(cmd1)
		If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
			check1 = 0
			'  LinkLabel1.Text = check1
			MsgBox("Balanc is 0!", MsgBoxStyle.OkOnly, "Info BONUS")
			'Exit Sub
		Else
			sqlResult1.ToString()

			check1 = ExecuteScalar(cmd1) 'deposit sum 
			MsgBox("Balance is " & check1 & " !", MsgBoxStyle.OkOnly, "Info BONUS")
			'  LinkLabel1.Text = check1
		End If
	End Sub

	Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
		SpaBonus()
	End Sub

	Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
		freezAdminDeposit()
	End Sub


	'Private Sub refVisitors()
	'    Dim i As Integer
	'    For i = 0 To dgvVisitors.Rows.Count - 1
	'        If CheckBox2.CheckState = CheckState.Checked Then
	'            ' If dgvVisitors.Rows(i).Cells(0).Value = "Kids" Then
	'            phone.BackColor = Color.Red
	'            reason.BackColor = Color.Red
	'            age.BackColor = Color.White
	'            phone.Enabled = False
	'            reason.Enabled = False
	'            age.Enabled = True
	'            ' dgvVisitors.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
	'            'dgvVisitors.Rows(i).Cells(0).Style.BackColor = Color.LightSkyBlue
	'            'dgvVisitors.Rows(i).Cells(1).Style.BackColor = Color.LightSkyBlue
	'            'dgvVisitors.Rows(i).Cells(2).Style.BackColor = Color.LightSkyBlue
	'            'dgvVisitors.Rows(i).Cells(3).Style.BackColor = Color.LightSkyBlue
	'            'dgvVisitors.Rows(i).Cells(4).Style.BackColor = Color.LightSkyBlue
	'        Else
	'            age.BackColor = Color.Red
	'            phone.BackColor = Color.White
	'            reason.BackColor = Color.White
	'            phone.Enabled = True
	'            reason.Enabled = True
	'            age.Enabled = False
	'            'dgvVisitors.Rows(i).Cells(0).Style.BackColor = Color.LightGreen
	'            'dgvVisitors.Rows(i).Cells(1).Style.BackColor = Color.LightGreen
	'            'dgvVisitors.Rows(i).Cells(2).Style.BackColor = Color.LightGreen
	'            'dgvVisitors.Rows(i).Cells(3).Style.BackColor = Color.LightGreen
	'            'dgvVisitors.Rows(i).Cells(6).Style.BackColor = Color.LightGreen
	'            'dgvVisitors.Rows(i).Cells(7).Style.BackColor = Color.LightGreen
	'        End If
	'    Next
	'End Sub


	Private Sub CheckBox2_Click(sender As Object, e As EventArgs)
		'refVisitors()
	End Sub

	'Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
	'    Dim custID As Integer = CInt(txtCustid.Text)
	'    Dim CardID As String = txtCardId.Text
	'    Dim FirstName = fName.Text
	'    Dim LastName = lName.Text
	'    If fName.Text = "" Then
	'        MsgBox("Please enter first name", MsgBoxStyle.Exclamation, "Warning")
	'        fName.Focus()
	'        Exit Sub
	'    End If
	'    If lName.Text = "" Then
	'        MsgBox("Please enter last name", MsgBoxStyle.Exclamation, "Warning")
	'        lName.Focus()
	'        Exit Sub
	'    End If
	'    If CheckBox2.CheckState = CheckState.Checked Then
	'        If age.Text = "" Then
	'            MsgBox("Please enter age", MsgBoxStyle.Exclamation, "Warning")
	'            age.Focus()
	'            Exit Sub
	'        End If
	'    End If
	'    If cmbAdmin.Text = "" Then
	'        MsgBox("Please select Admin", MsgBoxStyle.Exclamation, "Warning")
	'        cmbAdmin.Focus()
	'        Exit Sub
	'    End If

	'    CustomerHistory(custID, CardID, Reason:="Kids&Visitor", Admin:=cmbAdmin.Text)
	'    If CheckBox2.CheckState = CheckState.Checked Then
	'        InsertVisitors(custID, DateTime.Now, 1, FirstName, LastName, age.Text, phone.Text, reason.Text)
	'    Else
	'        InsertVisitors(custID, DateTime.Now, 0, fName.Text, lName.Text, 0, phone.Text, reason.Text)
	'    End If
	'    'updateDisplay()
	'    ' ref()
	'    Refresh_Tab()
	'    cmbReason.Text = ""
	'End Sub

	'Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
	'    deleteVisitors()
	'End Sub
	'Sub deleteVisitors()
	'    Dim j As Integer

	'    If dgvVisitors.CurrentRow IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then
	'        'DataGridView.Item("ColumnNameHere",0).Value = "Hello"
	'        If dgvVisitors.CurrentRow.Index >= 0 Then
	'            j = dgvVisitors.CurrentRow.Index

	'            Dim gID As Integer

	'            gID = dgvVisitors.Item("ID", j).Value.ToString 'id guestCheckin


	'            Dim cmdDel As New SqlClient.SqlCommand
	'            cmdDel = conn.CreateCommand
	'            cmdDel.CommandText = "Delete from tblVisitors where ID = '" & gID & " '"
	'            ExecuteReader(cmdDel)






	'            'Dim check1 As Integer = ExecuteReader(cmdDel).RecordsAffected
	'            'If check1 > 0 Then

	'            '    MsgBox(" Succesfully To Delete", MsgBoxStyle.OkOnly, "Info Delete")

	'            'Else
	'            '    MsgBox(" Failure To Delete", MsgBoxStyle.OkOnly, "Info Delete")
	'            'End If

	'        End If
	'    End If
	'    Refresh_Tab()
	'End Sub

	Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
		payDepositMinusRest()

	End Sub

	Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
		checkinOld()
	End Sub



	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		Reset()
	End Sub

	Private Sub cmbAdmin_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbAdmin.KeyDown
		If e.KeyCode = Keys.Enter Then
			cmbReason.Focus()
		End If
	End Sub

	Private Function GenerateID() As Integer
		ReadyConnectionF()
		Dim value As Integer


		Dim cmd = New SqlCommand("SELECT max(clID) FROM ClipNew ", conn)


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

	Private Sub fillCombo(sql As String, cbo As ComboBox)
		Try
			ReadyConnectionF()

			cmd = New SqlCommand
			Dim daEmp As New SqlDataAdapter
			dt = New DataTable

			With cmd
				.Connection = conn
				.CommandText = sql
			End With

			With daEmp
				.SelectCommand = cmd
				.Fill(dt)
			End With

			cbo.DataSource = dt
			cbo.DisplayMember = dt.Columns(1).ColumnName
			cbo.ValueMember = dt.Columns(0).ColumnName

		Catch ex As Exception
			MsgBox(ex.Message)
		Finally
			conn.Close()
			' Dim daEmp As Object = Nothing
			'daEmp.Dispose()
		End Try
	End Sub



	Public Sub FillCoach()

		ReadyConnectionF()
		Dim ds As New DataSet
		Dim daEmp As New SqlDataAdapter
		Dim cmdEmp As New SqlCommand
		cmdEmp = conn.CreateCommand
		' cmdEmp.CommandText = "Select id,lastname +' '+ firstname as fullname from Employees where notes NOT LIKE '%deleted%' ORDER BY FirstName ASC" 'coach
		'cmdEmp.CommandText = "Select id,lastname +' '+ firstname as fullname from Employees" ' where notes NOT LIKE '%deleted%' ORDER BY FirstName ASC" 'coach
		' cmdEmp.CommandText = "Select * from Employees ORDER BY FirstName ASC" 'coach
		cmdEmp.CommandText = "Select id,lastname +' '+ firstname as fullname from Employees where notes NOT LIKE '%deleted%'and notes  LIKE '' or notes IS NULL ORDER BY FirstName ASC" 'coach
		daEmp.SelectCommand = cmdEmp
		cmbCoach.DataSource = Nothing
		daEmp.Fill(ds, "Employees")

		With cmbCoach
			.DisplayMember = "Employees.fullname"
			.ValueMember = "ID"
			.DataSource = ds
			'  .SelectedIndex = -1
			'  .AutoCompleteMode = AutoCompleteMode.Suggest
			' .AutoCompleteSource = AutoCompleteSource.ListItems
		End With

		txtCoachId.DataBindings.Clear()


		txtCoachId.DataBindings.Add("Text", ds, "Employees.ID")
		'cmbCoach.DataSource = ""
		'cmbCoach.Items.Clear()

		'sql = "Select id,lastname +' '+ firstname as fullname from Employees"
		'fillCombo(sql, cmbCoach)






		'ReadyConnectionF()

		'Dim daEmp As New SqlDataAdapter
		'Dim cmdEmp As New SqlCommand
		'cmdEmp = conn.CreateCommand
		'cmdEmp.CommandText = "Select id,lastname +' '+ firstname as fullname from Employees ORDER BY FirstName ASC" 'coach
		'cmdEmp.CommandText = "Select id,lastname +' '+ firstname as fullname from Coach"
		'cmdEmp.CommandText = "Select * from Employees ORDER BY FirstName ASC" 'coach
		'daEmp.SelectCommand = cmdEmp
		'daEmp.Fill(ds, "Employees")
		'cmbCoach.Items.Clear()

		'With cmbCoach
		'    .DisplayMember = "Employees.fullname"
		'    .ValueMember = "ID"
		'    .DataSource = ds
		'    .SelectedIndex = -1
		'    .AutoCompleteMode = AutoCompleteMode.Suggest
		'    .AutoCompleteSource = AutoCompleteSource.ListItems
		'End With
		'cmbCoach.DataBindings.Clear()
		'cmbCoach.DataBindings.Add("Text", ds, "Employees.fullname")
		'txtCoachId.DataBindings.Clear()
		'txtCoachId.DataBindings.Add("Text", ds, "Employees.ID")
	End Sub

	'Sub fillCombo()
	'    Try
	'        ReadyConnectionF()
	'        Dim adp = New SqlDataAdapter()
	'        adp.SelectCommand = New SqlCommand("Select distinct LastName+Firstname FROM employees", conn)
	'        ds = New DataSet("ds")
	'        adp.Fill(ds)
	'        Dim dtable As DataTable = ds.Tables(0)
	'        cmbCoach.Items.Clear()
	'        For Each drow As DataRow In dtable.Rows
	'            cmbCoach.Items.Add(drow(0).ToString())
	'        Next
	'    Catch ex As Exception
	'        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'    End Try
	'End Sub
	Sub fillComboProduct()
		ReadyConnectionF()
		Dim daCl As New SqlDataAdapter
		Dim cmdcl As New SqlCommand
		Dim ds As New DataSet
		cmdcl = conn.CreateCommand

		cmdcl.CommandText = "Select * from ClipCard"
		daCl.SelectCommand = cmdcl
		daCl.Fill(ds, "ClipCard")

		With cmbProd
			.DisplayMember = "ClipCard.ProductName"
			.ValueMember = "ID"
			.DataSource = ds
			' .SelectedIndex = -1
			'  .AutoCompleteMode = AutoCompleteMode.Suggest
			'  .AutoCompleteSource = AutoCompleteSource.ListItems
		End With
		txtFree.DataBindings.Clear()
		txtUsed.DataBindings.Clear()
		txtPrId.DataBindings.Clear()
		txtFree.DataBindings.Add("Text", ds, "ClipCard.Quantity")
		txtUsed.DataBindings.Add("Text", ds, "ClipCard.Valid")
		txtPrId.DataBindings.Add("Text", ds, "ClipCard.Id")
		'TextBox30.DataBindings.Add("Text", ds, "ClipCard.Category")
	End Sub


	Public Function GetClipDataReader() As ComplexReader
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim rdr As SqlDataReader
		Dim connection As SqlConnection
		Try
			connection = GetSqlConnection()
			Dim cmd = New SqlCommand("SELECT * from ClipFrm  where Customerid = '" & custID & "' order by regdate desc", connection)
			rdr = cmd.ExecuteReader()

			' Dim cmd = New SqlCommand("Select RTRIM(Coach),free,used,regdate,id from ClipStX  where Customerid = '" & custID & "'", conn)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error clip", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return New ComplexReader With {.SqlConnection = connection, .SqlDataReader = rdr}

	End Function
	Public Sub Getdata()
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
		Dim custID As Integer = CInt(txtCustid.Text)
		Try
			ReadyConnectionF()

			' Dim cmd = New SqlCommand("Select RTRIM(Coach),free,used,regdate,id from ClipStX  where Customerid = '" & custID & "'", conn)
			Dim cmd = New SqlCommand("SELECT * from ClipFrm  where Customerid = '" & custID & "' order by regdate desc", conn)
			Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			dgw1.Rows.Clear()
			While rdr.Read() = True
				dgw1.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14))
			End While
			rdr.Close()

			If dgw1.Rows.Count > 0 Then
				i = dgw1.CurrentRow.Index
				Dim dr As DataGridViewRow = dgw1.SelectedRows(i)

				If dr.Cells(0).Value.ToString() = "" Then
					cmbProd.SelectedIndex = -1
				Else
					cmbProd.Text = dr.Cells(0).Value.ToString()
				End If
				If dr.Cells(1).Value.ToString() = "" Then
					cmbCoach.SelectedIndex = -1
				Else
					cmbCoach.Text = dr.Cells(1).Value.ToString()
				End If

				txtFree.Text = dr.Cells(2).Value.ToString()
				dtpDate.Text = dr.Cells(3).Value
				dtEnd.Text = dr.Cells(5).Value
				txtUsed.Text = dr.Cells(4).Value.ToString()


				txtClid.Text = dr.Cells(8).Value.ToString()
				txtAmount.Text = dr.Cells(14).Value.ToString()
				'  GetClipUsage(CInt(txtClid.Text))
				'btnUpdate.Enabled = True
				'btnDelete.Enabled = True
				btnSave.Enabled = False
				' Status()
			Else
				Exit Sub
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error clip", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub
	'Public Sub GetdataCl()
	'    Dim tmpCurrentCulture As System.Globalization.CultureInfo
	'    tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

	'    tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
	'    tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
	'    System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
	'    Dim custID As Integer = ComboBox7.SelectedValue
	'    Try
	'        ReadyConnectionF()
	'        DataGridView3.ColumnCount = 17
	'        DataGridView3.Columns(0).Name = "Client ID"
	'        DataGridView3.Columns(1).Name = "Last Name"
	'        DataGridView3.Columns(2).Name = "First Name"
	'        DataGridView3.Columns(4).Name = "Client ID"
	'        DataGridView3.Columns(5).Name = "Last Name"
	'        DataGridView3.Columns(6).Name = "First Name"
	'        DataGridView3.Columns(7).Name = "Type"
	'        DataGridView3.Columns(8).Name = "UID"
	'        DataGridView3.Columns(9).Name = "Phone1"
	'        DataGridView3.Columns(10).Name = "Phone2"
	'        DataGridView3.Columns(11).Name = "old UID"
	'        DataGridView3.Columns(12).Name = "Born on"
	'        DataGridView3.Columns(13).Name = "Status"
	'        DataGridView3.Columns(14).Name = "EMail"
	'        Dim cmd = New SqlCommand("SELECT ID, CardID, LastName, FirstName, CardType, UID, HomePhone, MobilePhone, Passport, BornOn, Status, Email, ContactPerson, Notes, Attachments, RelaxxGroupId, regDate" & " " &
	'        "FROM Customers  where id = '" & custID & "'", conn)
	'        Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
	'        DataGridView3.Rows.Clear()
	'        While (rdr.Read() = True)
	'            DataGridView3.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8))
	'        End While

	'    Catch ex As Exception
	'        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'    End Try
	'End Sub
	'Private Sub TabPage10_Click(sender As Object, e As EventArgs) Handles TabPage10.Click
	'    fillCombo()
	'End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


		saveNewClip()




	End Sub
	Sub saveNewClip()
		If Len(Trim(txtFree.Text)) = 0 Then
			MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtFree.Focus()
			Exit Sub
		End If
		If txtUsed.Text = "" Then
			MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtUsed.Focus()
			Return
		End If
		Try
			If AdminByReason("new clip") = True Then
				Dim custID As Integer = CInt(txtCustid.Text)

				ReadyConnectionF()
				Dim cb As String = "insert into ClipNew(clid,customerid,coachid,productid,quantity,regdate,duration,amount) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", GenerateID())
				cmd.Parameters.AddWithValue("@d2", custID) ' GenerateID())
				cmd.Parameters.AddWithValue("@d3", txtCoachId.Text)
				cmd.Parameters.AddWithValue("@d4", txtPrId.Text)
				cmd.Parameters.AddWithValue("@d5", txtFree.Text)
				If Label38.Text = "4" Or Label38.Text = "10" Then
					cmd.Parameters.AddWithValue("@d6", dtpDate.Value)
				Else
					cmd.Parameters.AddWithValue("@d6", DateTime.Now)
				End If

				cmd.Parameters.AddWithValue("@d7", txtUsed.Text)
				cmd.Parameters.AddWithValue("@d8", txtAmount.Text)
				cmd.ExecuteReader()

				Dim st As String = "added the new clip '"

				MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Getdata()



				btnSave.Enabled = False

			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub
	Sub clipAddFreez()
		Dim custID As Integer = CInt(txtCustid.Text)
		If GetClipId(custID) = True Then
			Dim cb As String = "update ClipNew set duration=@d2  where custID=@d1 "
			Dim cmd = New SqlCommand(cb)
			cmd.Connection = conn
			cmd.Parameters.AddWithValue("@d1", custID)
			cmd.ExecuteReader()
		End If
	End Sub
	Sub updateClip()
		If Len(Trim(txtFree.Text)) = 0 Then
			MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtFree.Focus()
			Exit Sub
		End If
		If txtUsed.Text = "" Then
			MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtUsed.Focus()
			Return
		End If
		Try
			ReadyConnectionF()
			Dim custID As Integer = CInt(txtCustid.Text)


			If AdminByReason("clip updated") = True Then
				Dim cb As String = "update ClipNew set coachid=@d3,productid=@d4,quantity=@d5,regdate=@d6,duration=@d2,amount=@d7  where clId=@d1 "
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)
				cmd.Parameters.AddWithValue("@d2", txtUsed.Text)
				' cmd.Parameters.AddWithValue("@d2", custID) ' GenerateID())
				cmd.Parameters.AddWithValue("@d3", txtCoachId.Text)
				cmd.Parameters.AddWithValue("@d4", txtPrId.Text)
				cmd.Parameters.AddWithValue("@d5", txtFree.Text)
				cmd.Parameters.AddWithValue("@d6", dtpDate.Value)
				cmd.Parameters.AddWithValue("@d7", txtAmount.Text)
				cmd.ExecuteReader()

				Dim st As String = "updated clip '"

				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				btnSave.Enabled = False
				Getdata()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub
	Sub markClipDel()

		Try
			ReadyConnectionF()
			Dim custID As Integer = CInt(txtCustid.Text)


			If AdminByReason("clip mark del") = True Then
				Dim cb As String = "update ClipNew set st=1  where clId=@d1 "
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)

				cmd.ExecuteReader()
				'
				'   Dim st As String = "updated clip '"

				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				btnSave.Enabled = False
				Getdata()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub
	Sub markClipundo()

		Try
			ReadyConnectionF()
			Dim custID As Integer = CInt(txtCustid.Text)


			If AdminByReason("clip undo del") = True Then
				Dim cb As String = "update ClipNew set st=0  where clId=@d1 "
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)

				cmd.ExecuteReader()

				' Dim st As String = "updated clip '"

				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				btnSave.Enabled = False
				Getdata()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	Sub Reset()
		fillComboProduct()
		'cmbProd.SelectedIndex = 0
		cmbCoach.SelectedIndex = -1
		'txtUsed.Text = ""
		'txtFree.Text = ""
		txtAmount.Text = 0
		dtpDate.Value = Date.Now()

		btnSave.Enabled = True

	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Try
			If AdminByReason("clip deleted") = True Then
				ReadyConnectionF()
				Dim RowsAffected As Integer = 0
				Dim cq As String = "delete from ClipNew where clId=@d1"
				Dim cmd = New SqlCommand(cq)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)
				RowsAffected = cmd.ExecuteNonQuery()
				If RowsAffected > 0 Then
					Dim st As String = "deleted  '" & txtClid.Text & "'"

					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Getdata()
					Reset()
				Else
					MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Reset()
				End If
			End If

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		If dgw1.CurrentRow.Index >= 0 Then
			Dim j As Integer
			j = dgw1.CurrentRow.Index

			updateClip()


			dgw1.Rows(j).Selected = True
			txtClid.Text = dgw1.Item("id", j).Value.ToString()
			txtAmount.Text = dgw1.Item("amount", j).Value.ToString()
			cmbCoach.Text = dgw1.Item("coach", j).Value.ToString()
			cmbProd.Text = dgw1.Item("product", j).Value.ToString()
			dtpDate.Value = dgw1.Item("DateReg", j).Value.ToString()
			txtUsed.Text = dgw1.Item("duration", j).Value.ToString()
			txtFree.Text = dgw1.Item("quantity", j).Value.ToString()
		Else
			Exit Sub
		End If

	End Sub



	Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
		payDepositMinusSPA()
	End Sub

	Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
		payDepositSPA()
	End Sub



	Private Sub dgw1_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw1.MouseClick, dgw1.MouseClick
		clipClick()
	End Sub
	'Sub clipUsageClick()
	'    Try
	'        If dgw1.Rows.Count > 0 Then
	'            Dim dr As DataGridViewRow = dgw1.SelectedRows(0)
	'            If dr.Cells(1).Value.ToString() = "" Then
	'                cmbCoach.SelectedIndex = -1
	'            Else
	'                cmbCoach.Text = dr.Cells(1).Value.ToString()
	'            End If
	'            If dr.Cells(0).Value.ToString() = "" Then
	'                cmbProd.SelectedIndex = -1
	'            Else
	'                cmbProd.Text = dr.Cells(0).Value.ToString()
	'            End If
	'            txtFree.Text = dr.Cells(2).Value.ToString()
	'        End If
	'    Catch ex As Exception
	'        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'    End Try
	'End Sub
	Sub clipClick()
		' Getdata()
		Dim tmpCurrentCulture As CultureInfo
		tmpCurrentCulture = New CultureInfo("en-US")

		tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
		tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

		If dgw1.CurrentCell Is Nothing Then
			Exit Sub
		Else
			' Dim j As Integer = 0

			Dim countRow = dgw1.RowCount
			j = dgw1.CurrentRow.Index

			If j <= countRow + 1 And j >= 0 Then
				txtClid.Text = dgw1.Item("id", j).Value.ToString()
				txtAmount.Text = dgw1.Item("amount", j).Value.ToString()
				cmbCoach.Text = dgw1.Item("coach", j).Value.ToString()
				cmbProd.Text = dgw1.Item("product", j).Value.ToString()
				dtpDate.Value = dgw1.Item("DateReg", j).Value.ToString()
				dtEnd.Value = dgw1.Item("EndDate", j).Value.ToString()
				txtUsed.Text = dgw1.Item("duration", j).Value.ToString()
				txtFree.Text = dgw1.Item("quantity", j).Value.ToString()

			End If
		End If




		GetClipUsage(txtClid.Text)
	End Sub
	Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
		FindByCardid()
	End Sub



	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		checkinAll()
	End Sub



	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		saveChanges()
	End Sub





	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		updOrder()
	End Sub

	Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
		ReadUID()
	End Sub

	Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
		FindByUID()
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		FindByPhone()
	End Sub

	Private Sub guests_Click(sender As Object, e As EventArgs) Handles guests.Click

	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		If DataGridView5.CurrentCell Is Nothing Then
			Exit Sub
		Else
			Guest()
		End If

	End Sub

	Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
		Dim custID As Integer = CInt(txtCustid.Text)
		GetGuestOwner(custID)
	End Sub
	Dim Print As New TicketPrinter
	Dim myprintdialog As New PrintDialog
	Public printer As String
	Public copies As Integer




	Sub printClip(clipID As Integer, Balance As Integer, EDate As Date)
		Dim custID As Integer = CInt(txtCustid.Text)
		Dim a As String
		a = Space(4) & "TicketN" & clipID & vbCrLf & vbCrLf & Now & vbCrLf & vbCrLf & Space(4) & "OrderN" & Space(2) & GetCustomerByID(custID).CardID & vbCrLf & vbCrLf
		a = a + GetCustomerByID(custID).LastName & Space(2) & GetCustomerByID(custID).FirstName & vbCrLf & vbCrLf
		a = a + "Coach" & Space(5) & cmbCoach.Text & vbCrLf & vbCrLf
		a = a + cmbProd.Text & vbCrLf & vbCrLf
		a = a + "Balance" & Space(2) & Balance & vbCrLf & vbCrLf & "End Date" & Space(2) & EDate.AddDays(-1).ToString
		Dim psz As New PaperSize


		With myprintdialog
			If .ShowDialog = Windows.Forms.DialogResult.OK Then
				printer = .PrinterSettings.PrinterName
				copies = .PrinterSettings.Copies

				Print.Print(a)
			End If
		End With
	End Sub

	Private Sub ComboBox15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox15.SelectedIndexChanged

	End Sub




	Private Sub dgw1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgw1.CellFormatting
		For i As Integer = 0 To dgw1.Rows.Count - 1
			If dgw1.Rows(i).Cells("st").Value = 1 Then
				'  dgw1.Rows(i).Cells("st").Style.ForeColor = Color.LightGray
				dgw1.Rows(i).DefaultCellStyle.BackColor = Color.Red

			End If
		Next
	End Sub

	Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

		If MsgBox("Are you sure to print ticket? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

			Exit Sub
		Else

			If dgw1.CurrentRow.Index >= 0 Then
				Dim j As Integer
				j = dgw1.CurrentRow.Index

				Dim emplid = Int(txtCoachId.Text)
				Dim custID As Integer = CInt(txtCustid.Text)
				If lblUserId.Text = 3 Then 'reception  only 1 usage for every coach
					If GetClipUsageCount(custID, emplid) = True Then
						Exit Sub
					End If
				End If

				usedClipCard()
				Getdata()


				dgw1.Rows(j).Selected = True

				txtClid.Text = dgw1.Item("id", j).Value.ToString()
				txtAmount.Text = dgw1.Item("amount", j).Value.ToString()
				cmbCoach.Text = dgw1.Item("coach", j).Value.ToString()
				cmbProd.Text = dgw1.Item("product", j).Value.ToString()
				dtpDate.Value = dgw1.Item("DateReg", j).Value.ToString()
				dtEnd.Value = dgw1.Item("EndDate", j).Value.ToString()
				txtUsed.Text = dgw1.Item("duration", j).Value.ToString()
				txtFree.Text = dgw1.Item("quantity", j).Value.ToString()
			Else
				Exit Sub
			End If
		End If
	End Sub

	Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
		Refresh_Tab()
	End Sub



	Private Sub dgw1_KeyDown(sender As Object, e As KeyEventArgs) Handles dgw1.KeyDown
		clipClick()
	End Sub



	Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

		'leftMargin = Convert.ToInt32(e.MarginBounds.Left)
		'rightMargin = Convert.ToInt32(e.MarginBounds.Right)
		'topMargin = Convert.ToInt32(e.MarginBounds.Top)
		'bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
		'InvoiceWidth = Convert.ToInt32(e.MarginBounds.Width)
		'InvoiceHeight = Convert.ToInt32(e.MarginBounds.Height)

		''If (Not ReadInvoice) Then patinfo()

		'SetInvoiceHead(e.Graphics) ' Draw Invoice Head
		'SetOrderData(e.Graphics) ' Draw Order Data
		Dim psz As New PaperSize
		With psz
			.RawKind = PaperKind.Custom
			.Width = 80
			.Height = 50
			PrintDocument1.DefaultPageSettings.PaperSize = psz
		End With
		'ReadInvoice = True
	End Sub


	Private Sub dgw1_KeyUp(sender As Object, e As KeyEventArgs) Handles dgw1.KeyUp
		clipClick()
	End Sub

	Private Sub dtpOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpOrderDate.ValueChanged
		Dim j As Integer
		Dim D1 As Date = dtpOrderDate.Value
		Dim D2 As Date = dtpEndDate.Value
		j = txtDays.Text
		' ind = DateDiff(DateInterval.Day, D1, D2)
		If j > 0 Then
			dtpEndDate.Value = dtpOrderDate.Value.AddDays(j)

		End If
	End Sub

	Private Sub cmbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedIndexChanged

	End Sub

	Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
		Dim j As Integer
		Dim D1 As Date = dtpOrderDate.Value
		Dim D2 As Date = dtpEndDate.Value
		j = txtDays.Text
		' ind = DateDiff(DateInterval.Day, D1, D2)
		If j > 0 Then
			dtpEndDate.Value = dtpOrderDate.Value.AddDays(j)

		End If
	End Sub

	Private Sub DataGrid6_Navigate(sender As Object, ne As NavigateEventArgs) Handles DataGrid6.Navigate

	End Sub

	'Private Sub dgw_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgw.DataBindingComplete
	'    If dgw.DataSource Is Nothing Then
	'        Return
	'    End If

	'    For Each col As DataGridViewColumn In DataGridView1.Columns
	'        col.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell)
	'        ' col.HeaderCell = New AdvancedDataGridView(col.HeaderCell)
	'    Next

	'    dgw.AutoResizeColumns()
	'End Sub

	Private Sub DataGrid8_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGrid8.MouseDown
		freezAdminDisplay()
	End Sub

	Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged
		Dim j As Integer
		Dim D1 As Date = dtpOrderDate.Value
		Dim D2 As Date = dtpEndDate.Value
		j = txtDays.Text
		' ind = DateDiff(DateInterval.Day, D1, D2)
		If j > 0 Then
			dtpEndDate.Value = dtpOrderDate.Value.AddDays(j)

		End If
	End Sub

	Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
		FindByCustid()
	End Sub



	Private Sub DataGrid8_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGrid8.MouseUp
		freezAdminDisplay()
	End Sub

	Private Sub dgw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellClick
		Refresh_Tab()
	End Sub

	Private Sub txtCardId_TextChanged(sender As Object, e As EventArgs) Handles txtCardId.TextChanged

	End Sub

	Private Sub delUsed_Click(sender As Object, e As EventArgs) Handles delUsed.Click
		DelUsedClipCard()
		Getdata()
	End Sub

	Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
		markClipDel()
	End Sub

	Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
		markClipundo()
	End Sub



	Private Sub xStart_Click(sender As Object, e As EventArgs) Handles xStart.Click

	End Sub

	Private Sub Button43_Click_1(sender As Object, e As EventArgs) Handles Button43.Click
		markUsedClipCard()
	End Sub

	Private Sub dgw_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentDoubleClick
		Refresh_Tab()
	End Sub



	Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
		updatePhone()
	End Sub

	Private Async Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
		If MsgBox("Are you sure to save data?", MsgBoxStyle.YesNo, "Saving") = MsgBoxResult.No Then
			Return
		End If

		Dim uid = Trim(txtUID.Text)

		Dim count = Await Worker.RunWork(
			Function()
				ReadyConnectionF()
				Dim cmd2 As New SqlCommand("select count(UID) from uidVBcheck where UID = @UID and Id<>'" & txtCustid.Text & "' ", conn)
				cmd2.Parameters.Add("@UID", SqlDbType.NChar).Value = uid
				Return ExecuteScalar(cmd2)
			End Function)

		If count > 0 Then
			MsgBox("Customer with UID '" & uid & "' already exists", MsgBoxStyle.Exclamation, "Warning")
			txtUID.Focus()
			Return
		End If

		Await UpdateUID()
	End Sub

	Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click

		Dim custID As Integer = CInt(txtCustid.Text)
		updateGroup()
		GetdataCust(custID)
		GetDetails()

	End Sub

	Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click

		updateBornOn()
		' ref()


	End Sub

	Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
		updateNotes()
	End Sub

	Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
		updateMail()
	End Sub

	Private Sub txtFind_TextChanged_1(sender As Object, e As EventArgs) Handles txtFind.TextChanged

	End Sub

	Private Sub details_Click(sender As Object, e As EventArgs) Handles details.Click

	End Sub

	Private Sub updCardId_Click(sender As Object, e As EventArgs) Handles updCardId.Click
		If MsgBox("Are you sure to update data ?", MsgBoxStyle.OkCancel, "Update confirm") = MsgBoxResult.Cancel Then
			' do nothing
		Else
			Dim cmd1 As New SqlCommand

			ReadyConnectionF()



			cmd1 = conn.CreateCommand
			cmd1.Parameters.Add("@CardID", SqlDbType.NChar).Value = txtCardId.Text

			cmd1.CommandText = "select count(CardID) from Customers where CardID = @CardID"


			Dim sqlResult1 As Object = cmd1.ExecuteScalar()
			If cmd1.ExecuteScalar > 0 Then

				MsgBox("CardID dublicate", MsgBoxStyle.Information, "Message :")

				Exit Sub

			Else

				If AdminByReason("cardid updated") = True Then
					Dim cmdDatabase As New SqlCommand
					Dim custID As Integer = CInt(txtCustid.Text)
					cmdDatabase = conn.CreateCommand

					cmdDatabase.Parameters.Add("@cardid", SqlDbType.VarChar).Value = txtCardId.Text

					cmdDatabase.CommandText = "Update Customers set cardid =  @cardid  where id = '" & custID & "' "

					ExecuteNonQuery(cmdDatabase)
					GetdataCust(custID)
					GetDetails()
					MsgBox("Done", MsgBoxStyle.Information, "OK")
				End If
			End If
		End If
	End Sub

	Private Sub updFLname_Click(sender As Object, e As EventArgs) Handles updFLname.Click
		If AdminByReason("name updated") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@fname", SqlDbType.VarChar).Value = txtFirst.Text
			cmdDatabase.Parameters.Add("@lname", SqlDbType.VarChar).Value = txtLast.Text
			cmdDatabase.CommandText = "Update Customers set FirstName =  @fname,LastName=@lname  where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Private Sub updAddress_Click(sender As Object, e As EventArgs) Handles updAddress.Click
		If AdminByReason("company updated") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@company", SqlDbType.VarChar).Value = txtCompany.Text

			cmdDatabase.CommandText = "Update Customers set address =  @company where id = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub



	Private Sub dgvUsage_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsage.CellFormatting
		For i As Integer = 0 To dgvUsage.Rows.Count - 1
			If dgvUsage.Rows(i).Cells("s").Value = 1 Then
				' dgw1.Rows(i).Cells("st").Style.ForeColor = Color.Red
				dgvUsage.Rows(i).DefaultCellStyle.BackColor = Color.Red



			End If
		Next
	End Sub

	Private Sub cmbPyMet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPyMet.SelectedIndexChanged

	End Sub

	Private Sub Button44_Click_1(sender As Object, e As EventArgs) Handles Button44.Click
		payClip()
	End Sub

	Private Sub btnUnused_Click(sender As Object, e As EventArgs) Handles btnUnused.Click
		Try
			ReadyConnectionF()
			Dim custID As Integer = CInt(txtCustid.Text)


			If AdminByReason("clip unused") = True Then
				Dim cb As String = "update ClipNew set st=2  where clId=@d1 "
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)

				cmd.ExecuteReader()
				'
				'   Dim st As String = "updated clip '"

				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				btnSave.Enabled = False
				Getdata()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	Private Sub Button45_Click(sender As Object, e As EventArgs) Handles btnUndoUs.Click
		Try
			ReadyConnectionF()
			Dim custID As Integer = CInt(txtCustid.Text)


			If AdminByReason("clip undo unused") = True Then
				Dim cb As String = "update ClipNew set st=0  where clId=@d1 "
				Dim cmd = New SqlCommand(cb)
				cmd.Connection = conn
				cmd.Parameters.AddWithValue("@d1", txtClid.Text)

				cmd.ExecuteReader()
				'
				'   Dim st As String = "updated clip '"

				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
				btnSave.Enabled = False
				Getdata()
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	Private Sub Button39_Click_1(sender As Object, e As EventArgs) Handles Button39.Click
		undoUsedClipCard()
	End Sub

	Private Sub setCoach_Click(sender As Object, e As EventArgs) Handles setCoach.Click
		Dim frm As New Coach
		frm.Show()
	End Sub

	Private Sub Button45_Click_1(sender As Object, e As EventArgs) Handles Button45.Click
		If AdminByReason("checkin deleted") = True Then
			Dim cmdDatabase As New SqlCommand
			Dim custID As Integer = CInt(txtCustid.Text)
			cmdDatabase = conn.CreateCommand

			cmdDatabase.Parameters.Add("@dt", SqlDbType.Date).Value = DateTimePicker1.Text

			cmdDatabase.CommandText = "Delete from GatCheckIn where  Convert(date, DateCheckIn , 103) =  @dt and customerid = '" & custID & "' "

			ExecuteNonQuery(cmdDatabase)
			GetdataCust(custID)
			GetDetails()
			checkInHistory()
			MsgBox("Done", MsgBoxStyle.Information, "OK")

		End If
	End Sub

	Private Sub UpdateFpInfoButton_Click(sender As Object, e As EventArgs) Handles UpdateFpInfoButton.Click
		If Not EnsureAdmin() Then Return
		Dim f = My.Application.OpenForms("ExceptionList")
		ExceptionList.lvlName.Text = txtFirst.Text
		ExceptionList.lblLastName.Text = txtLast.Text
		ExceptionList.lblCustomerId.Text = txtCustid.Text
		If f Is Nothing Then ExceptionList.Show()
	End Sub



	Private Sub Profile_Closed(sender As Object, e As EventArgs) Handles Me.Closed
	End Sub

	Private Sub addGuestOrder_Click(sender As Object, e As EventArgs) Handles addGuestOrder.Click
		Dim OrderDate As Date = dtpOrderDate.Value
		Dim EndDate As Date = dtpEndDate.Value
		Dim custID As Integer = CInt(txtCustid.Text)
		'Dim Admin = cmbAdmin.Text
		'Dim Reason = "GIFT"
		Dim customerid = custID
		Dim CardId = txtCardId.Text
		If MsgBox("Save ?", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

		Else
			If AdminByReason("new guestOrder") = True Then
				If GetActiveOrderByID(custID) = False Then
					GuestOrder(custID, OrderDate, EndDate)
					Refresh_Tab()
					'AllOrders()
					'End If
				Else
					MsgBox("Client have Active Order")
					Exit Sub
				End If
			End If
		End If
	End Sub

	Private Sub Button40_MouseClick(sender As Object, e As MouseEventArgs) Handles Button40.MouseClick

	End Sub
End Class

Public Class TicketPrinter
	Private TextToBePrinted As String

	Public Sub Print(text As String)
		TextToBePrinted = text

		'Dim CM = graphics.DpiX / 2.54F
		Using document As New PrintDocument()
			document.PrinterSettings.PrinterName = Profile.printer
			document.PrinterSettings.Copies = Profile.copies
			document.DefaultPageSettings.PaperSize = New PaperSize("Custom", 302, 340)
			document.DefaultPageSettings.Margins = New Margins(38, 38, 38, 38)
			document.DefaultPageSettings.Landscape = False

			AddHandler document.PrintPage, AddressOf PrintPageHandler
			document.Print()
			RemoveHandler document.PrintPage, AddressOf PrintPageHandler
		End Using
	End Sub

	Private Sub PrintPageHandler(sender As Object, args As PrintPageEventArgs)
		Dim graphics = args.Graphics
		Dim content = args.MarginBounds

		Dim path = IO.Path.Combine(imagePath, "TicketBackground.png")
		Dim logo = Image.FromFile(path)
		Dim font As New Font("Microsoft Sans Serif", 10, FontStyle.Regular)

		' Logo
		Dim scaleX = CSng(content.Width / logo.Width)
		Dim scaleY = CSng(content.Height / logo.Height)
		Dim scale = Math.Min(scaleX, scaleY)

		Dim logoWidth = logo.Width * scale
		Dim logoHeight = logo.Height * scale

		Dim logoX = content.X + (content.Width - logoWidth) \ 2
		Dim logoY = content.Y

		graphics.DrawImage(logo, logoX, logoY, logoWidth, logoHeight)

		' Text
		Dim lines = TextToBePrinted.Split({vbCrLf, vbLf}, StringSplitOptions.None)
		Dim textY = logoY + logoHeight

		For Each line In lines
			line = line.Trim()
			If String.IsNullOrEmpty(line) Then Continue For

			Dim textSize = graphics.MeasureString(line, font)
			Dim textX = content.X + (content.Width - textSize.Width) \ 2
			textY += font.Height

			graphics.DrawString(line, font, Brushes.Black, textX, textY)
		Next
	End Sub
End Class

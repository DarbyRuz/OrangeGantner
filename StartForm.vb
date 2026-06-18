Imports System.Data.SqlClient
Public Class StartForm

	Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
		'If Label6.Text = "5" Then
		'Else

		Dim f = My.Application.OpenForms("Profile")

		If f Is Nothing Then 'reception
			Profile.lblUserId.Text = Label6.Text
			Profile.lblUser.Text = lblUser.Text
			If Label6.Text = "3" Then
				Profile.Button5.Enabled = False
				Profile.Button6.Enabled = False
				Profile.Button13.Enabled = False
				Profile.Button41.Enabled = False
				Profile.Button42.Enabled = False
				Profile.Button2.Enabled = False
				Profile.Button19.Enabled = False
				Profile.Button47.Enabled = False
				Profile.Button48.Enabled = False
				Profile.btnDelete.Enabled = False
				Profile.btnUpdate.Enabled = False
				Profile.btnUpdate.Enabled = False
				Profile.delUsed.Enabled = False
				Profile.btnUnused.Enabled = False
				Profile.btnUndoUs.Enabled = False
				Profile.Button55.Enabled = False
				Profile.btnSave.Enabled = False 'clip save after new
				Profile.txtUsed.Enabled = False 'clip duration
				Profile.dtpDate.Enabled = False 'clip duration start date
				Profile.dtEnd.Enabled = False 'clip duration end date
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
			End If


			If Label6.Text = "7" Then 'Mariya 
				Profile.Button5.Enabled = False
				Profile.Button6.Enabled = False
				Profile.Button13.Enabled = False
				Profile.Button41.Enabled = False
				Profile.Button42.Enabled = False
				Profile.Button2.Enabled = False
				Profile.Button19.Enabled = False
				Profile.Button47.Enabled = False
				Profile.Button48.Enabled = False
				Profile.btnDelete.Enabled = False
				Profile.btnUpdate.Enabled = False
				Profile.btnUpdate.Enabled = False
				Profile.delUsed.Enabled = False
				Profile.btnUnused.Enabled = False
				Profile.btnUndoUs.Enabled = False
				Profile.Button55.Enabled = False
				Profile.btnSave.Enabled = False 'clip save after new
				Profile.txtUsed.Enabled = False 'clip duration
				Profile.dtpDate.Enabled = False 'clip duration start date
				Profile.dtEnd.Enabled = False 'clip duration end date
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
			End If

			If Label6.Text = "4" Then 'Vardui

				Profile.Button30.Enabled = False  'printticket clip

			End If
			'If Label6.Text = "5" Then
			'    Profile.Button9.Enabled = False 'Save changes
			'    Profile.Button5.Enabled = False
			'    Profile.Button6.Enabled = False
			'    Profile.Button12.Enabled = False
			'    Profile.Button13.Enabled = False
			'    Profile.Button14.Enabled = False
			'    Profile.Button41.Enabled = False
			'    Profile.Button42.Enabled = False
			'    Profile.Button2.Enabled = False
			'    Profile.Button19.Enabled = False
			'    Profile.Button47.Enabled = False
			'    Profile.Button48.Enabled = False
			'    Profile.btnDelete.Enabled = False
			'    Profile.btnUpdate.Enabled = False
			'    Profile.btnSave.Enabled = False
			'    Profile.btnNew.Enabled = False
			'    Profile.dgw.Enabled = False
			'    Profile.Button55.Enabled = False
			'    Profile.orders.Enabled = False
			'    Profile.debt.Enabled = False
			'    Profile.payments.Enabled = False
			'    Profile.freezBalance.Enabled = False
			'    Profile.deposit.Enabled = False
			'    '  Profile.clipCard.Enabled = False
			'    Profile.guests.Enabled = False
			'    Profile.visit.Enabled = False
			'    Profile.xStart.Enabled = False
			'End If
			If Label6.Text = "2" Then  'Sales lilit

				'Profile.Button13.Enabled = False 'update manager
				For Each ctl As Control In Profile.deposit.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.xStart.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.orders.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				'For Each ctl As Control In Profile.freezBalance.Controls
				'    If TypeOf ctl Is Button Then
				'        ctl.Enabled = False
				'    End If
				'Next
				For Each ctl As Control In Profile.guests.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.details.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				Profile.Button2.Enabled = False  'Delete freezing
				Profile.Button8.Enabled = True  'Deposit balance
				Profile.Button28.Enabled = True  'notes
				Profile.Button16.Enabled = True  'whoes guest
				Profile.Button13.Enabled = True 'update manager
				Profile.Button14.Enabled = False  'new client
				Profile.Button21.Enabled = False  'photo
				Profile.Button9.Enabled = True  'update status
				Profile.Button17.Enabled = False 'delete photo
				Profile.Button53.Enabled = True  'att
				Profile.Button10.Enabled = True  'att
			End If
			If Label6.Text = "6" Then  'Sales 

				For Each ctl As Control In Profile.details.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.deposit.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.xStart.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.orders.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.guests.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				Profile.Button2.Enabled = False  'Delete freezing
				Profile.Button8.Enabled = True  'Deposit balance
				Profile.Button28.Enabled = True  'notes
				Profile.Button16.Enabled = True  'whoes guest
				Profile.Button14.Enabled = False  'new client
				Profile.Button21.Enabled = False  'photo
				Profile.Button9.Enabled = True  'update status
				Profile.Button17.Enabled = False 'delete photo
				Profile.Button53.Enabled = True  'att
				Profile.Button10.Enabled = True  'att
				Profile.txtUsed.Enabled = False 'clip duration
			End If

			If Label6.Text = "8" Then  'Sales +printticket+name

				For Each ctl As Control In Profile.details.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.deposit.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.xStart.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.orders.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.guests.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				Profile.Button8.Enabled = True  'Deposit balance
				Profile.Button28.Enabled = True  'notes
				Profile.Button16.Enabled = True  'whoes guest
				Profile.Button14.Enabled = False  'new client
				Profile.Button21.Enabled = False  'photo
				Profile.Button9.Enabled = True  'update status
				Profile.Button17.Enabled = False 'delete photo
				Profile.Button53.Enabled = True  'att
				Profile.Button10.Enabled = True  'att
				Profile.txtUsed.Enabled = False 'clip duration
				Profile.Button30.Enabled = True  'printticket clip
				Profile.btnUpdate.Enabled = True ' clip update
				Profile.txtAmount.Enabled = False ' clip amount
				Profile.txtFree.Enabled = False ' clip quantity
				Profile.txtUsed.Enabled = False ' clip duration
				Profile.dtpDate.Enabled = False ' clip start date
				Profile.dtEnd.Enabled = False ' clip end date
				'freezing
				Profile.Button2.Enabled = False  'Delete freezing
				Profile.Button3.Enabled = False
				Profile.Button6.Enabled = False
				Profile.frPay.Enabled = False
			End If


			If Label6.Text = "5" Then  ' SPA

				For Each ctl As Control In Profile.details.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.deposit.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				For Each ctl As Control In Profile.xStart.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.orders.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.freezBalance.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.guests.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next
				For Each ctl As Control In Profile.admTools.Controls
					If TypeOf ctl Is Button Then
						ctl.Enabled = False
					End If
				Next

				Profile.Button8.Enabled = True  'Deposit balance
				Profile.Button28.Enabled = True  'notes
				Profile.Button16.Enabled = True  'whoes guest
				Profile.Button14.Enabled = False  'new client
				Profile.Button21.Enabled = False  'photo
				Profile.Button9.Enabled = False  'photo
				Profile.Button17.Enabled = False 'delete photo
				Profile.Button53.Enabled = True  'att
				Profile.Button10.Enabled = True  'att
				Profile.txtUsed.Enabled = False 'clip duration
			End If

			If f Is Nothing Then 'reception +btnUpdate
				Profile.lblUser.Text = lblUser.Text
				If Label6.Text = "7" Then
					Profile.Button5.Enabled = False
					Profile.Button6.Enabled = False
					Profile.Button13.Enabled = False
					Profile.Button41.Enabled = False
					Profile.Button42.Enabled = False
					Profile.Button2.Enabled = False
					Profile.Button19.Enabled = False
					Profile.Button47.Enabled = False
					Profile.Button48.Enabled = False
					Profile.btnDelete.Enabled = False
					Profile.btnUpdate.Enabled = True

					Profile.delUsed.Enabled = False
					Profile.btnUnused.Enabled = False
					Profile.btnUndoUs.Enabled = False
					Profile.Button55.Enabled = False
					Profile.txtUsed.Enabled = False 'clip duration
					For Each ctl As Control In Profile.admTools.Controls
						If TypeOf ctl Is Button Then
							ctl.Enabled = False
						End If
					Next
				End If
			End If

			Profile.Show()
		Else
			Profile.BringToFront()
		End If


		Profile.Label38.Text = Label6.Text
		'  End If

		'Dim frm As New Profile
		'If Label6.Text = "3" Then
		'    frm.Button5.Enabled = False
		'    frm.Button6.Enabled = False
		'End If
		'frm.Show()
	End Sub

	Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
		Dim frm As New Order
		frm.Show()
	End Sub

	Private Sub StartForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Application.Exit()
	End Sub

	Private Sub StartForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		InitCardReader()
		If Label6.Text = "3" Or Label6.Text = "7" Then
			Button2.Enabled = True
			Button3.Enabled = False
			Button4.Enabled = False
			Button5.Enabled = False
			Button6.Enabled = False
			Button8.Enabled = False
			Button12.Enabled = False
			Button14.Enabled = False
			Button13.Enabled = False 'interactions
			btnUser.Enabled = True
		End If
		If Label6.Text = "5" Then 'spa
			' Button1.Enabled = False
			Button2.Enabled = False
			Button3.Enabled = False
			Button4.Enabled = False
			Button5.Enabled = False
			Button6.Enabled = False
			' Button7.Enabled = False
			Button8.Enabled = False
			Button9.Enabled = True 'rECEPTION
			btnReport.Enabled = True
			Button11.Enabled = False
			Button13.Enabled = False
			Button14.Enabled = False
			'' Button15.Enabled = False   'HDM
			btnUser.Enabled = True
		End If


		If Label6.Text = 2 Then 'Sales Lilit
			For Each ctl As Control In Controls
				If TypeOf ctl Is Button Then
					ctl.Enabled = False
				End If
			Next
			Button11.Enabled = True ' attendance
			Button1.Enabled = True 'profile
			btnReport.Enabled = True 'report
			Button7.Enabled = True 'exit
			Button4.Enabled = True 'cashbox
			btnUser.Enabled = True
		End If

		If Label6.Text = 6 Or Label6.Text = 8 Then 'Sales
			For Each ctl As Control In Controls
				If TypeOf ctl Is Button Then
					ctl.Enabled = False
				End If
			Next
			Button11.Enabled = True ' attendance
			Button1.Enabled = True 'profile
			btnReport.Enabled = True 'report
			Button7.Enabled = True 'exit
			btnUser.Enabled = True
		End If


		Dim cmd1 As New SqlCommand
		Dim da1 As New SqlDataAdapter
		Dim adapter As New SqlDataAdapter
		Dim ds As New DataSet
		ReadyConnectionF()
		cmd1 = conn.CreateCommand
		cmd1.CommandText = "select * from HdmSettings"
		da1.SelectCommand = cmd1
		da1.Fill(ds, "HdmSettings")
		With ComboBox1
			.DisplayMember = "HdmSettings.hdmId"
			.ValueMember = "hdmId"
			.DataSource = ds
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems

		End With
		With ComboBox2
			.DisplayMember = "HdmSettings.hdmUser"
			.ValueMember = "hdmId"
			.DataSource = ds
			.AutoCompleteMode = AutoCompleteMode.Suggest
			.AutoCompleteSource = AutoCompleteSource.ListItems

		End With
		' lblHdmMember.DataBindings.Add("Text", ds, "hdmUser")
	End Sub

	Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
		Dim oper As String = ""
		Dim st As String = ""
		oper = "Log out "
		st = lblUser.Text
		LogFunc(st, oper)

		Application.Exit()
	End Sub

	Private Sub Button10_Click(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)


	End Sub

	Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
		Dim frm As New REPORTS
		frm.LblUser.Text = lblUser.Text
		frm.Show()
	End Sub

	Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click

		Dim frm As New Order
		frm.Show()
	End Sub

	Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
		Dim frm1 As New ReOrder

		frm1.Show()
	End Sub

	Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
		Dim frm As New Customer
		'  frm.lblUser.Text = lblUser.Text
		frm.Show()

	End Sub

	Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
		Dim frm As New Money
		frm.lblUser.Text = lblUser.Text
		frm.Show()
	End Sub

	Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
		Dim frm As New MoneyByDate
		frm.Show()
	End Sub

	Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
		Dim frm As New Form4
		frm.Show()
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		Dim f = My.Application.OpenForms("RESTORAN")

		If f Is Nothing Then
			Dim hdmNumber = CInt(ComboBox1.SelectedValue)
			RESTORAN.lblHDM.Text = hdmNumber

			Dim hdmMember = ComboBox2.Text
			RESTORAN.lblHdmMember.Text = hdmMember
			If hdmNumber = 2 Then
				RESTORAN.Button4.Enabled = False
				RESTORAN.Button6.Enabled = False
				RESTORAN.Button9.Enabled = False
			End If
			If hdmNumber = 4 Then
				RESTORAN.Button11.Enabled = False
				RESTORAN.Button10.Enabled = False
				RESTORAN.Button7.Enabled = False
			End If

			If hdmNumber = 1 Then
				RESTORAN.Button11.Enabled = False
				RESTORAN.Button10.Enabled = False
				RESTORAN.Button7.Enabled = False
				RESTORAN.Button4.Enabled = False
				RESTORAN.Button6.Enabled = False
				RESTORAN.Button9.Enabled = False
			End If

			If hdmNumber = 3 Then
				RESTORAN.Button11.Enabled = True
				RESTORAN.Button10.Enabled = True
				RESTORAN.Button7.Enabled = True
				RESTORAN.Button4.Enabled = False
				RESTORAN.Button6.Enabled = False
				RESTORAN.Button9.Enabled = False
			End If
			RESTORAN.lblUser.Text = lblUser.Text
			RESTORAN.Show()
			Dim st As String = "login"
			LogFunc(lblUser.Text, st)


		Else
			RESTORAN.BringToFront()
		End If



	End Sub

	Private Sub Button10_Click_1(sender As Object, e As EventArgs)
		'Dim frm As New SPA
		'frm.Show()
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		Dim frm As New Monitoring
		frm.Show()
	End Sub

	Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
		Dim frm As New frmOutPayment()
		frm.lblUser.Text = lblUser.Text
		frm.Show()
	End Sub

	Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
		'Dim frm As New frmInteractions
		Dim frm As New frmHDMsettings
		'  Dim frm As New frmCamera
		frm.Show()
	End Sub

	Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
		Dim f = My.Application.OpenForms("RestoranPrint")

		If f Is Nothing Then

			If Label6.Text = "1" Or Label6.Text = "3" Then
				RestoranPrint.Button1.Enabled = True
			Else
				RestoranPrint.Button1.Enabled = False
			End If

			RestoranPrint.Show()
		Else
			RestoranPrint.BringToFront()
		End If
	End Sub

	Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
		Dim frm As New HDM
		Dim hdmNumber = CInt(ComboBox1.SelectedValue)
		frm.lblHDM.Text = hdmNumber
		frm.lblUser.Text = lblUser.Text
		Dim hdmMember = ComboBox2.Text
		frm.lblHdmMember.Text = hdmMember
		If hdmNumber = 2 Or hdmNumber = 4 Then  'Reception restoran spa miayn kanxavchar
			frm.Button2.Enabled = False
			frm.Button3.Enabled = False
		End If
		'If hdmNumber = 3 Then 'spa salon
		'    frm.Button2.Enabled = False
		'    frm.Button3.Enabled = False
		'    frm.Button6.Enabled = False
		'    frm.deposit.Enabled = False
		'End If
		frm.Show()
	End Sub

	Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
		Dim hdmId As Integer = ComboBox1.SelectedValue
		connectToHDM(hdmId)
		Dim frm As New HDM
		Dim con As Boolean
		con = HDMfr.ConnectionCheck()
		If con = True Then
			MsgBox("Connected!", MsgBoxStyle.OkOnly, "Message :")
			connect.Text = "Connected!"
			frm.ComboBox2.SelectedValue = hdmId
			Dim hdmNumber = CInt(ComboBox1.SelectedValue)
			frm.lblHDM.Text = hdmNumber
			Dim hdmMember = ComboBox2.Text
			frm.lblHdmMember.Text = hdmMember
			frm.Show()
		Else
			' MsgBox("No connection!", MsgBoxStyle.OkOnly, "Message :")
			MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
			connect.Text = "Disconnected!"
			' frm.Label6.Text = "Disconnected!"
		End If
	End Sub

	Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
		'For Each f As Form In My.Application.OpenForms
		'    f.Close()
		'    Next



		Dim frm As New Form1
		''  Dim frm As New frmCamera
		frm.Show()


		'Me.Dispose()
	End Sub

	Private Sub StartForm_Load_1()
		'MessageBox.Show(
		'If (Environment.Is64BitProcess, "x64", "x86")Then
		')
	End Sub
End Class
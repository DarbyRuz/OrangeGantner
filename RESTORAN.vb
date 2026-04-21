Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Globalization
Imports System.ComponentModel
Public Class RESTORAN
    'Dim open As TcpListener
    'Dim Tcpserver As TcpListener
    'Dim client, host As TcpClient
    'Dim dati, hdat As NetworkStream
    'Dim ip As String = Nothing




    Private Sub RESTORAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim sql9 As String



        ReadyConnectionF()
        cmd1 = conn.CreateCommand

        cmd1.CommandText = "select * from unionTotal"
        da1.SelectCommand = cmd1
        da1.Fill(ds, "unionTotal")

        DataGridView5.DataSource = ds
        DataGridView5.DataMember = "unionTotal"

        TextBox1.DataBindings.Add("Text", ds, "unionTotal.customerId")

        TextBox3.DataBindings.Add("Text", ds, "unionTotal.FirstName")
        TextBox4.DataBindings.Add("Text", ds, "unionTotal.LastName")
        TextBox6.DataBindings.Add("Text", ds, "unionTotal.TOTAL")
        TextBox5.DataBindings.Add("Text", ds, "unionTotal.RESTORAN")
        TextBox8.DataBindings.Add("Text", ds, "unionTotal.SPA")
        'ReadyConnectionF()
        'cmd1 = conn.CreateCommand

        'da1.SelectCommand = cmd1
        'da1.Fill(ds, "ourRestSum")

        'dgvOutPaymentSum.DataSource = ds
        'dgvOutPaymentSum.DataMember = "ourRestSum"
        'TextBox1.DataBindings.Add("Text", ds, "ourRestSum.customerId")

        'TextBox3.DataBindings.Add("Text", ds, "ourRestSum.FirstName")
        'TextBox4.DataBindings.Add("Text", ds, "ourRestSum.LastName")
        'TextBox5.DataBindings.Add("Text", ds, "ourRestSum.bePaid")

        sql9 = "Select * from PaymentType"

        adapter = New SqlDataAdapter(sql9, Connection)
        adapter.Fill(ds, "PaymentType")

        With ComboBox1
            .DisplayMember = "PaymentType.PaymentType"
            .ValueMember = "PaymentType"
            .DataSource = ds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With
        Label3.Text = ComboBox1.Text
        Dim sqlEmpl As String
        sqlEmpl = "Select * from Emp"



        Dim dacust As New SqlDataAdapter

        dacust = New SqlDataAdapter(sqlEmpl, Connection)
        dacust.Fill(ds, "Emp")


        With cmbAdmin
            .DisplayMember = "Emp.Name"
            .ValueMember = "ID"
            .DataSource = ds
            .SelectedIndex = -1
        End With


        Dim cmdHdm As New SqlCommand
        Dim daHdm As New SqlDataAdapter

        '  Dim ds1 As New DataSet
        ReadyConnectionF()
        cmdHdm = conn.CreateCommand
        cmdHdm.CommandText = "select * from HdmSettings"
        daHdm.SelectCommand = cmdHdm
        daHdm.Fill(ds1, "HdmSettings")
        With ComboBox2
            .DisplayMember = "HdmSettings.hdmId"
            .ValueMember = "hdmId"
            .DataSource = ds1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With
        LoadAll()
        refProduct()
    End Sub
    Sub outPayment()
        TextBox2.DataBindings.Clear()

        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet

        Dim dt As New DataTable

        ReadyConnectionF()
        If TextBox1.Text <> "" Then
            If dgvOutPaymentSum.RowCount >= 0 Then
                Dim custID As Integer = Int(TextBox1.Text)





                cmd1 = conn.CreateCommand

                cmd1.CommandText = "Select * from outRestoran where customerid='" & custID & " ' "
                da1.SelectCommand = cmd1
                da1.Fill(ds, "outRestoran")

                dgvOutPayment.DataSource = ds
                dgvOutPayment.DataMember = "outRestoran"
                TextBox2.DataBindings.Clear()
                TextBox2.DataBindings.Add("Text", ds, "outRestoran.zakazid")
                'Else
                '    MsgBox("No Record selected!")


                Dim cmd2 As New SqlCommand

                cmd2 = conn.CreateCommand

                cmd2.CommandText = "select * from RestoranProduct where customerid='" & custID & "' and zakazid ='" & TextBox2.Text & " ' "
                da1.SelectCommand = cmd2
                da1.Fill(ds, "RestoranProduct")

                DataGridView1.DataSource = ds
                DataGridView1.DataMember = "RestoranProduct"

            End If
        End If
    End Sub

    Sub LoadAll()
        TextBox2.DataBindings.Clear()

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da1 As New SqlDataAdapter
        Dim da2 As New SqlDataAdapter
        Dim ds As New DataSet

        Dim dt As New DataTable

        ReadyConnectionF()

        If DataGridView5.RowCount >= 0 Then
            Dim custID As Integer = Int(TextBox1.Text)





            cmd1 = conn.CreateCommand

            cmd1.CommandText = "select * from outRestoran where customerid='" & custID & " ' "
            da1.SelectCommand = cmd1
            da1.Fill(ds, "outRestoran")

            dgvOutPayment.DataSource = ds
            dgvOutPayment.DataMember = "outRestoran"
            TextBox2.DataBindings.Add("Text", ds, "outRestoran.zakazid")
            'Else
            '    MsgBox("No Record selected!")








            cmd2 = conn.CreateCommand

            cmd2.CommandText = "select * from outReception where customerid='" & custID & " ' "
            da2.SelectCommand = cmd2
            da2.Fill(ds, "outReception")

            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "outReception"




        End If
    End Sub
    Sub SPA()

        Dim cmd2 As New SqlCommand

        Dim da2 As New SqlDataAdapter
        Dim ds As New DataSet

        Dim dt As New DataTable

        ReadyConnectionF()

        If DataGridView5.RowCount >= 0 Then
            Dim custID As Integer = Int(TextBox1.Text)
            cmd2 = conn.CreateCommand

            cmd2.CommandText = "select * from outReception where customerid='" & custID & " ' "
            da2.SelectCommand = cmd2
            da2.Fill(ds, "outReception")

            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "outReception"




        End If
    End Sub
    Sub refProduct()
        If TextBox1.Text <> "" Then
            If dgvOutPaymentSum.RowCount >= 0 Then
                Dim custID As Integer = Int(TextBox1.Text)
                Dim cmd2 As New SqlCommand


                Dim da1 As New SqlDataAdapter

                Dim ds As New DataSet
                cmd2 = conn.CreateCommand
                ReadyConnectionF()
                cmd2.CommandText = "select * from RestoranProduct where customerid='" & custID & "' and zakazid ='" & TextBox2.Text & " ' "
                da1.SelectCommand = cmd2
                da1.Fill(ds, "RestoranProduct")

                DataGridView1.DataSource = ds
                DataGridView1.DataMember = "RestoranProduct"
            End If
        End If
    End Sub
    Sub sum()
        'TextBox1.DataBindings.Clear()

        'TextBox3.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        If TextBox1.Text <> "" Then
            Dim custID As Integer = Int(TextBox1.Text)

            Dim cmd1 As New SqlCommand

            Dim da1 As New SqlDataAdapter

            Dim ds As New DataSet


            ReadyConnectionF()
            cmd1 = conn.CreateCommand
            cmd1.CommandText = "select * from unionTotal  where customerid='" & custID & " ' "
            ' cmd1.CommandText = "select * from ourRestSum  where customerid='" & custID & " ' "
            da1.SelectCommand = cmd1
            da1.Fill(ds, "unionTotal")

            dgvOutPaymentSum.DataSource = ds
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    dgvOutPaymentSum.DataMember = "unionTotal"
                    TextBox6.DataBindings.Add("Text", ds, "unionTotal.TOTAL")
                    TextBox5.DataBindings.Add("Text", ds, "unionTotal.RESTORAN")
                    TextBox8.DataBindings.Add("Text", ds, "unionTotal.SPA")
                End If
            End If
            ' TextBox1.DataBindings.Add("Text", ds, "ourRestSum.customerId")

            '  TextBox3.DataBindings.Add("Text", ds, "ourRestSum.FirstName")
            ' TextBox4.DataBindings.Add("Text", ds, "ourRestSum.LastName")
            '   TextBox5.DataBindings.Add("Text", ds, "unionPart3.RESTORAN")
            '   TextBox8.DataBindings.Add("Text", ds, "unionPart3.SPA")
            'Status()
        End If
    End Sub
    Sub Total()
        TextBox1.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet


        ReadyConnectionF()
        cmd1 = conn.CreateCommand

        cmd1.CommandText = "select * from unionTotal"
        da1.SelectCommand = cmd1
        da1.Fill(ds, "unionTotal")

        DataGridView5.DataSource = ds
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                DataGridView5.DataMember = "unionTotal"

                TextBox1.DataBindings.Add("Text", ds, "unionTotal.customerId")

                TextBox3.DataBindings.Add("Text", ds, "unionTotal.FirstName")
                TextBox4.DataBindings.Add("Text", ds, "unionTotal.LastName")
                TextBox6.DataBindings.Add("Text", ds, "unionTotal.TOTAL")
                TextBox5.DataBindings.Add("Text", ds, "unionTotal.RESTORAN")
                TextBox8.DataBindings.Add("Text", ds, "unionTotal.SPA")
            End If
        End If


        '  Status()
    End Sub
    Sub pay()

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        Dim custID As Integer = Int(TextBox1.Text)

        If TextBox5.Text = "" Then
            Exit Sub
        Else


            Dim payment As Integer = Int(TextBox5.Text) 'amount to be pay

            ' Dim toPay As Integer


            If MsgBox("Are you sure to paid ? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
                Exit Sub
            Else
                ' hdm()
                Dim CMDout As New SqlCommand("UpdateOutRestoran")
                CMDout.Parameters.Clear()
                CMDout.Parameters.Add("@ID", Data.SqlDbType.Int).Value = custID 'TextBox2.Text

                CMDout.Parameters.Add("@payMethode", Data.SqlDbType.NChar).Value = ComboBox1.Text
                CMDout.Parameters.Add("@Deposit", Data.SqlDbType.NChar).Value = 0
                ' CMDout.Parameters.Add("@Status", Data.SqlDbType.NChar).Value = 2
                ExecuteProcedur.ExecuteCMD(CMDout)



                MsgBox("OK!")
            End If
        End If
    End Sub
    Sub pay_print()

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        Dim custID As Integer = Int(TextBox1.Text)

        If TextBox5.Text = "" Then
            Exit Sub
        Else


            Dim payment As Integer = Int(TextBox5.Text) 'amount to be pay

            ' Dim toPay As Integer


            If MsgBox("Are you sure to paid ? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
                Exit Sub
            Else
                hdm()
                Dim CMDout As New SqlCommand("UpdateOutRestoran")
                CMDout.Parameters.Clear()
                CMDout.Parameters.Add("@ID", Data.SqlDbType.Int).Value = custID 'TextBox2.Text

                CMDout.Parameters.Add("@payMethode", Data.SqlDbType.NChar).Value = ComboBox1.Text
                CMDout.Parameters.Add("@Deposit", Data.SqlDbType.NChar).Value = 0
                ' CMDout.Parameters.Add("@Status", Data.SqlDbType.NChar).Value = 2
                ExecuteProcedur.ExecuteCMD(CMDout)



                MsgBox("OK!")
            End If
        End If
    End Sub
    Sub ref()

        ' If dgvOutPaymentSum.RowCount > 0 Then
        ' Status()
        sum()

        depositSPA()
        depositRest()
        SPA()
        outPayment()
        refProduct()
        ComboBox1.SelectedIndex = 0
        Label9.Text = Int(TextBox8.Text) - Int(Label11.Text) 'to paid spa
        Label12.Text = Int(TextBox5.Text) - Int(Label2.Text) 'to paid rest
        txtDeposit.Text = ""
        TextBox9.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        pay()
        find()
        Total()
        sum()
        refProduct()
        ref()
    End Sub
    Public Sub GetDataRest(ByVal selectCommand As String)
        Try

            '   Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))

            Dim dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            Dim bindingSource As New BindingSource
            bindingSource.DataSource = table
            dgvOutPaymentSum.DataSource = bindingSource

            BindingNavigator1.BindingSource = bindingSource


            bindingSource.Filter = String.Format("LastName + FirstName Like '%{0}%'", txtFind.Text)
            'dgvOutPaymentSum.AutoResizeColumns(
            '    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("To run , replace the value of the " +
                "connectionString variable with a connection string that is " +
                "valid for your system.")
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        find()
        ref()
        sum()
        Total()
    End Sub
    Sub findOld()

        Dim cm As CurrencyManager = CType(Me.BindingContext(dgvOutPaymentSum.DataSource, dgvOutPaymentSum.DataMember), CurrencyManager)
        Dim dv As DataView = CType(cm.List, DataView)

        dv.RowFilter = String.Format("LastName + FirstName + bePaid Like '%{0}%'", txtFind.Text)
        ' DataGridView3.DefaultCellStyle.BackColor = Color.FromArgb(236, 236, 255)

        cm.Refresh()
        If cm.List.Count = 0 Then
            MessageBox.Show("No any data!")
            ' dgvOutPaymentSum.Rows(0).Selected = True
            Exit Sub
        Else
            'DataGridView3.DataSource = Nothing
            'DataGridView3.Refresh()
            'DataGridView3.DataSource = cm.List


            ' ref()

        End If





    End Sub
    Sub find()

        Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView5.DataSource, DataGridView5.DataMember), CurrencyManager)
        Dim dv As DataView = CType(cm.List, DataView)

        dv.RowFilter = String.Format("LastName + FirstName  Like '%{0}%'", txtFind.Text)
        ' DataGridView3.DefaultCellStyle.BackColor = Color.FromArgb(236, 236, 255)

        cm.Refresh()
        If cm.List.Count = 0 Then
            MessageBox.Show("No any data!")
            ' dgvOutPaymentSum.Rows(0).Selected = True
            Exit Sub
        Else



            ref()

        End If





    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        find()
        sum()
        ref()
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then

            find()
            sum()
        End If
    End Sub

    Private Sub dgvOutPaymentSum_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ref()
    End Sub



    Private Sub dgvOutPaymentSum_DoubleClick(sender As Object, e As EventArgs)
        ref()
    End Sub







    Private Sub dgvOutPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        refProduct()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ref()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        ref()
    End Sub



    Sub depositRest()
        Dim check1 As Integer

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        If TextBox1.Text <> "" Then
            Dim custID As Integer = Int(TextBox1.Text)

            '   sum()

            cmd1 = conn.CreateCommand
            cmd1.CommandText = "select DepositAmount from Deposit  " &
            "where CustomerID = '" & custID & "'"
            Dim sqlResult1 As Object = ExecuteScalar(cmd1)
            If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
                check1 = 0
                Label2.Text = check1
                'MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
                'Exit Sub
            Else
                sqlResult1.ToString()

                check1 = ExecuteScalar(cmd1) 'deposit sum 

                Label2.Text = check1
            End If
        End If
    End Sub
    Sub depositSPA()
        Dim check1 As Integer

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        If TextBox1.Text <> "" Then
            Dim custID As Integer = Int(TextBox1.Text)

            '   sum()

            cmd1 = conn.CreateCommand
            cmd1.CommandText = "select DepositAmount from DepositSPA  " &
            "where CustomerID = '" & custID & "'"
            Dim sqlResult1 As Object = ExecuteScalar(cmd1)
            If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
                check1 = 0
                Label11.Text = check1
                'MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
                'Exit Sub
            Else
                sqlResult1.ToString()

                check1 = ExecuteScalar(cmd1) 'deposit sum 

                Label11.Text = check1
            End If
        End If
    End Sub
    'Sub Status()
    '    On Error Resume Next
    '    Dim countRow As Integer = dgvOutPaymentSum.RowCount
    '    '   If Not IsDBNull(StatusCardId(ComboBox7.SelectedValue)) Then
    '    Dim custID As Integer = Int(TextBox1.Text)

    '    If Not IsDBNull(dgvOutPaymentSum.CurrentRow.Index + 1) Or Not IsNothing(dgvOutPaymentSum.CurrentRow.Index + 1) Then
    '        If (dgvOutPaymentSum.CurrentRow.Index + 1) >= countRow Then
    '            Label4.Text = String.Empty





    '        Else

    '            Label4.Text = GetBirthDay(custID)


    '        End If
    '    End If



    '    '  Return
    'End Sub





    Private Sub hdm()
        '  Dim PRName As String
        Dim totalSum As Decimal
        Dim Hdmbajin As String
        Dim strPos As String = Label3.Text
        totalSum = TextBox5.Text
        Dim custID As Integer = Int(TextBox1.Text)



        ReadyConnectionF()

        Dim cmdBajin As SqlCommand
        cmdBajin = conn.CreateCommand()
        If strPos = "POS" Then
            ' Hdmbajin = "2"

            cmdBajin.CommandText = "select * from HdmBajin"
        Else
            cmdBajin.CommandText = "select * from HDMvariable"
        End If
        Dim sqlResult1 As Object = ExecuteScalar(cmdBajin)



        Hdmbajin = sqlResult1.ToString




        Console.Write(strPos)




        Dim fileName As String
        Dim TimeStamp = DateDiff("s", "01/1/1970 12:00:00 AM", DateTime.Now)
        fileName = "\\FITNESSERVER\Kitchen\OmegaProMultiLng\hdm\" & TimeStamp & ".txt"
        '   fileName = "\\192.168.1.1\Kitchen\OmegaProMultiLng\hdm\TestHDM.txt"
        ' fileName = "C:\AAA\" & TimeStamp & ".txt"
        Dim outputStream As StreamWriter = New StreamWriter(fileName, True, Encoding.Default)


        '  Dim Hdmbajin As String = "3"
        Dim myCMDhead As SqlCommand = New SqlCommand("SELECT * FROM HDM_Total where customerid='" & custID & "' ", Connection)
        Dim myReaderhead As SqlDataReader = myCMDhead.ExecuteReader
        Do While myReaderhead.Read
            Dim summa As String = myReaderhead.GetString(0)
            '   Dim discount As String = "0" 'myReaderhead.GetString(2)
            Dim bePaid As String = myReaderhead.GetString(1)
            Dim obsl As String = myReaderhead.GetString(2)
            outputStream.WriteLine("2" & "    " & Hdmbajin)   'nomer kassira

            outputStream.WriteLine(summa & "    " & Hdmbajin)
            outputStream.WriteLine("0" & "    " & Hdmbajin) 'discount
            outputStream.WriteLine(obsl & "    " & Hdmbajin)

            outputStream.WriteLine(bePaid & "    " & Hdmbajin)
            outputStream.WriteLine("0" & "    " & Hdmbajin)
        Loop
        myReaderhead.Close()

        Dim myCMD As SqlCommand = New SqlCommand("Select * FROM HDM where customerid='" & custID & "' ", Connection)
        Dim myReader As SqlDataReader = myCMD.ExecuteReader()
        Do While myReader.Read


            Dim values(myReader.FieldCount - 1) As Object

            myReader.GetValues(values).ToString()
            outputStream.WriteLine(Hdmbajin) 'bajin
            outputStream.WriteLine(myReader.GetDecimal(2)) 'quantity
            '  outputStream.WriteLine("²Ù»ñÇÏ³Ýá") 'productname
            outputStream.WriteLine(Replace(myReader.GetString(0), ",", ".")) 'productname
            outputStream.WriteLine(myReader.GetString(1)) 'price
            outputStream.WriteLine(myReader.GetString(4)) 'ed izm
            outputStream.WriteLine(myReader.GetString(10)) 'hdmcode
            ' Convert.ToInt32(myReader.GetInt32(0).ToString())
            'Console.WriteLine(Convert.ToInt32(myReader.GetInt32(1).ToString()))

        Loop

        myReader.Close()
        outputStream.Close()






    End Sub


    Sub payDepositRest(PaymentMethode As String)
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()
        cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
        Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
        Dim idDetID As Integer
        If IsDBNull(sqlResult1) Then
            idDetID = 1
        Else
            sqlResult1.ToString()
            idDetID = ExecuteScalar(cmdPoDetID)
            idDetID = idDetID + 1
        End If

        Dim custID As Integer = Int(TextBox1.Text)
        Dim cashier As String = cmbAdmin.Text
        If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
            Dim amount As Integer = Int(txtDeposit.Text)

            Dim CMD As New SqlCommand("InsertPayment")
            ' CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID

            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = amount
            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = PaymentMethode
            CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = "DepositRest" 'cmbBasic.Text
            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "DepositRest"
            CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = 0
            CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = cmbAdmin.Text
            CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0 'coach
            CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID
            CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTime.Now ' na forme naoborot recieveddate t.k. sort 
            CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTime.Now
            CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTime.Now
            CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = amount
            CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = 1
            CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = 0
            CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"
            CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = 0
            ExecuteProcedur.ExecuteCMD(CMD)
            Dim depos As Integer = Int(txtDeposit.Text)
            createDepositAccount(custID)
            addDeposit(custID, depos)
            depositHistory(customerID:=custID, amount:=depos, Reason:="REST")

        End If

        ref()
    End Sub
    Sub payDepositSPA(PaymentMethode As String)
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()
        cmdPoDetID.CommandText = "select max(ID)  from [Purchase Order Details]"
        Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
        Dim idDetID As Integer
        If IsDBNull(sqlResult1) Then
            idDetID = 1
        Else
            sqlResult1.ToString()
            idDetID = ExecuteScalar(cmdPoDetID)
            idDetID = idDetID + 1
        End If

        Dim custID As Integer = Int(TextBox1.Text)
        Dim cashier As String = cmbAdmin.Text
        If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
            Dim amount As Integer = Int(txtDeposit.Text)

            Dim CMD As New SqlCommand("InsertPayment")
            ' CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID

            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = amount
            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = PaymentMethode
            CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = "DepositSPA" 'cmbBasic.Text
            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "DepositSPA"
            CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = 0
            CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = cmbAdmin.Text
            CMD.Parameters.Add("@EmployeeID", Data.SqlDbType.Int).Value = 0 'coach
            CMD.Parameters.Add("@ProductID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID
            CMD.Parameters.Add("@PurchaseOrderID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@EmplID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@RegistrationDate", Data.SqlDbType.DateTime).Value = DateTime.Now ' na forme naoborot recieveddate t.k. sort 
            CMD.Parameters.Add("@ActivationDate", Data.SqlDbType.DateTime).Value = DateTime.Now
            CMD.Parameters.Add("@Deadline", Data.SqlDbType.DateTime).Value = DateTime.Now
            CMD.Parameters.Add("@UnitPrice ", Data.SqlDbType.Decimal).Value = amount
            CMD.Parameters.Add("@Quantity ", Data.SqlDbType.Decimal).Value = 1
            CMD.Parameters.Add("@Discount ", Data.SqlDbType.Float).Value = 0
            CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "PAID"
            CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = 0
            ExecuteProcedur.ExecuteCMD(CMD)
            Dim depos As Integer = Int(txtDeposit.Text)
            createDepositSPA(custID)
            addDepositSPA(custID, depos)
            depositHistory(customerID:=custID, amount:=depos, Reason:="SPA")

        End If

        ref()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = ComboBox1.Text

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        Label3.Text = ComboBox1.Text
    End Sub

    Private Sub dgvOutPaymentSum_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPaymentSum.CellContentClick
        'Status()
    End Sub

    Private Sub dgvOutPaymentSum_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOutPaymentSum.KeyDown
        ref()

    End Sub

    Private Sub dgvOutPaymentSum_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvOutPaymentSum.KeyUp
        ref()
    End Sub
    Private Sub dgvOutPayment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        refProduct()
    End Sub




    Private Sub dgvOutPaymentSum_Click(sender As Object, e As EventArgs) Handles dgvOutPaymentSum.Click
        ref()
    End Sub

    Private Sub dgvOutPayment_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPayment.CellContentClick
        refProduct()
    End Sub

    Private Sub dgvOutPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPayment.CellClick
        refProduct()
    End Sub

    Private Sub dgvOutPayment_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvOutPayment.KeyUp
        refProduct()
    End Sub

    Private Sub dgvOutPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOutPayment.KeyDown
        refProduct()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        ref()
    End Sub

    Private Sub DataGridView5_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView5.KeyUp
        ref()
    End Sub

    Private Sub DataGridView5_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView5.KeyDown
        ref()
    End Sub

    Private Sub DataGridView5_Click(sender As Object, e As EventArgs) Handles DataGridView5.Click
        ref()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        ref()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        ref()
    End Sub
    Public Function hdmPrCheckCash(PaidAmount As Decimal, paymentmethode As String, nameProd As String) As Boolean



        HDMfr.OpenSaleDocument(3)
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Ok Then

            If HDMfr.PrintDocument(PaidAmount, 0) = True Then
                Return True


            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                Return False
            End If
        Else
            Return False
            Exit Function
        End If

    End Function
    Public Function hdmPrCheckPOS(PaidAmount As Decimal, paymentmethode As String, nameProd As String) As Boolean



        HDMfr.OpenSaleDocument(3)
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Ok Then

            If HDMfr.PrintDocument(0, PaidAmount) = True Then
                Return True


            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                Return False
            End If
        Else
            Return False
            Exit Function
        End If

    End Function


    Private Sub hdmRestCash()
        Dim id As Integer = CInt(TextBox1.Text)
        Dim oper As String = ""
        Dim st As String = ""
        oper = "Hdm restoran Cash " & id
        st = lblUser.Text
        nameProd = "DepositRestoran" 'GetHdmItemsByID(idProd).ProductName
        PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))

        Dim PayMethode As String = "Cash"
        If hdmPrCheckCash(PaidAmount, PayMethode, nameProd) = True Then
            payDepositRest(PayMethode)
            insertHdmCheckNew(PaidAmount:=PaidAmount, prodName:=nameProd, PaymentMethode:=PayMethode, hdmId:=1, dep:=id)

            LogFunc(st, oper)
        Else

            Exit Sub
        End If

    End Sub
    Private Sub hdmRestPOS()
        Dim id As Integer = CInt(TextBox1.Text)
        Dim oper As String = ""
        Dim st As String = ""
        oper = "Hdm restoran POS " & id
        st = lblUser.Text

        nameProd = "DepositRestoran" 'GetHdmItemsByID(idProd).ProductName
        PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))
        Dim PayMethode As String = "POS"
        If hdmPrCheckPOS(PaidAmount, PayMethode, nameProd) = True Then
            payDepositRest(PayMethode)
            insertHdmCheckNew(PaidAmount:=PaidAmount, prodName:=nameProd, PaymentMethode:=PayMethode, hdmId:=1, dep:=id)
            LogFunc(st, oper)
        Else

            Exit Sub
        End If

    End Sub


    Private Sub hdmSPAPOS()
        Dim id As Integer = CInt(TextBox1.Text)
        Dim oper As String = ""
        Dim st As String = ""
        oper = "Hdm spa POS " & id
        st = lblUser.Text

        nameProd = "DepositSPA" 'GetHdmItemsByID(idProd).ProductName
        PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))
        Dim PayMethode As String = "POS"
        If hdmPrCheckPOS(PaidAmount, PayMethode, nameProd) = True Then
            payDepositSPA(PayMethode)
            insertHdmCheckNew(PaidAmount:=PaidAmount, prodName:=nameProd, PaymentMethode:=PayMethode, hdmId:=1, dep:=id)
            LogFunc(st, oper)
        Else

            Exit Sub
        End If

    End Sub
    Private Sub hdmSPACash()
        Dim id As Integer = CInt(TextBox1.Text)
        Dim oper As String = ""
        Dim st As String = ""
        oper = "Hdm spa Cash " & id
        st = lblUser.Text

        nameProd = "DepositSPA" 'GetHdmItemsByID(idProd).ProductName
        PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))
        Dim PayMethode As String = "Cash"
        If hdmPrCheckCash(PaidAmount, PayMethode, nameProd) = True Then
            payDepositSPA(PayMethode)
            insertHdmCheckNew(PaidAmount:=PaidAmount, prodName:=nameProd, PaymentMethode:=PayMethode, hdmId:=1, dep:=id)
            LogFunc(st, oper)
        Else

            Exit Sub
        End If

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'pay_print()
        updateStatus()
    End Sub
    Sub updateStatus()
        ' Dim customerid As Integer = CInt(ComboBox7.SelectedValue)
        Dim j As Integer
        Dim id As Integer = CInt(TextBox1.Text)
        Dim oper As String = ""
        Dim st As String = ""
        oper = "Hdm wrong check " & id
        st = lblUser.Text
        If dgvOutPayment IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

            If dgvOutPayment.CurrentRow.Index >= 0 Then
                j = dgvOutPayment.CurrentRow.Index


                Dim zakazId As Integer

                zakazId = Int(dgvOutPayment.Item("zakazId", j).Value.ToString) 'id customer as  guest-not owner
                If MsgBox("Mark check as wrong? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
                    Exit Sub
                Else
                    updRestStatus(zakazId)
                    LogFunc(st, oper)

                End If

            End If
        End If

        ref()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        hdmRestCash()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        hdmRestPOS()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        hdmSPACash()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        hdmSPAPOS()
    End Sub

    Private Sub PaidDeposit_Click(sender As Object, e As EventArgs) Handles PaidDeposit.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim custID As Integer = Int(TextBox1.Text)
        Dim st As String
        Dim oper As String
        oper = "paid now rest " & custID
        PaidAmount = Math.Round(CDec(Val(Label12.Text)))
        ' PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))
        If CashManualyRest(custID) = True Then
            depositHistory(customerID:=custID, amount:=PaidAmount, Reason:="Paid Rest")
            MsgBox("OK RESTORAN", MsgBoxStyle.OkOnly, "RESTORAN")

            st = lblUser.Text
            LogFunc(st, oper)
        End If
    End Sub

    Private Sub hdmNEW()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles connect.Click
        Dim hdmId As Integer = CInt(ComboBox2.SelectedValue)
        connectToHDM(hdmId)
        Dim con As Boolean
        con = HDMfr.ConnectionCheck()
        If con = True Then
            MsgBox("Connected!", MsgBoxStyle.OkOnly, "Message :")
            connect.Text = "Connected!"
        Else
            ' MsgBox("No connection!", MsgBoxStyle.OkOnly, "Message :")
            MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
            connect.Text = "No Connection!"
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim custID As Integer = Int(TextBox1.Text)


        PaidAmount = Math.Round(CDec(Val(txtDeposit.Text)))
        If CashManualySPA(custID) = True Then
            MsgBox("OK SPA", MsgBoxStyle.OkOnly, "SPA")
            depositHistory(customerID:=custID, amount:=PaidAmount, Reason:="Paid  SPA")
            Dim st As String
            st = lblUser.Text
            Dim oper As String
            oper = "paid now spa " & custID
            LogFunc(st, oper)
        End If
    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Globalization
Public Class RestoranPrint

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy "
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy "
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture



        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim sql9 As String
        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value
        ReadyConnectionF()

        'cmd1 = conn.CreateCommand

        'cmd1.CommandText = "select * from restPaidSum where  PurDate between  '" & startDate.AddDays(-1) & " 'and '" & startDate & " ' "
        'da1.SelectCommand = cmd1
        'da1.Fill(ds, "restPaidSum")

        'dgvOutPaymentSum.DataSource = ds
        'dgvOutPaymentSum.DataMember = "restPaidSum"
        'TextBox1.DataBindings.Add("Text", ds, "restPaidSum.customerId")

        'TextBox3.DataBindings.Add("Text", ds, "restPaidSum.FirstName")
        'TextBox4.DataBindings.Add("Text", ds, "restPaidSum.LastName")
        'TextBox5.DataBindings.Add("Text", ds, "restPaidSum.bePaid")

        sql9 = "select * from PaymentType"

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
        sum()
        LoadAll()
        refProduct()
    End Sub
    Sub outPayment()
        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value

        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet

        Dim dt As New DataTable

        ReadyConnectionF()

        If dgvOutPaymentSum.RowCount > 0 Then
            Dim custID As Integer = Int(TextBox1.Text)


            TextBox2.DataBindings.Clear()


            cmd1 = conn.CreateCommand

            cmd1.CommandText = "select * from outRestoranPaid where customerid='" & custID & " ' and purDate between  Convert(date, '" & startDate & " ', 103)  and Convert(date, '" & endDate & " ', 103) "
            da1.SelectCommand = cmd1
            da1.Fill(ds, "outRestoranPaid")

            dgvOutPayment.DataSource = ds
            dgvOutPayment.DataMember = "outRestoranPaid"
            TextBox2.DataBindings.Add("Text", ds, "outRestoranPaid.zakazid")
            'Else
            '    MsgBox("No Record selected!")


            Dim cmd2 As New SqlCommand

            cmd2 = conn.CreateCommand

            cmd2.CommandText = "Select * from restProductPaid where zakazid ='" & TextBox2.Text & " ' "
            da1.SelectCommand = cmd2
            da1.Fill(ds, "RestoranProduct")

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "RestoranProduct"
        End If

    End Sub

    Sub LoadAll()


        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet

        Dim dt As New DataTable
        Dim custID As Integer = 0
        ReadyConnectionF()

        If dgvOutPaymentSum.RowCount > 0 Then
            custID = TextBox1.Text
            Dim startDate As DateTime = DateTimePicker1.Value
            Dim endDate As DateTime = DateTimePicker2.Value
            ' Dim startDate As DateTime = Format(DateTimePicker1.Value, "yyyy.MM.dd")
            '   Dim endDate As DateTime = Format(DateTimePicker2.Value, "yyyy.MM.dd")


            cmd1 = conn.CreateCommand
            cmd1.CommandText = "select * from outRestoranPaid where customerid='" & custID & " ' and purDate between  Convert(date, '" & startDate & " ', 103)  and Convert(date, '" & endDate & " ', 103) "
            '     cmd1.CommandText = "select * from outRestoranPaid where customerid='" & custID & " ' and purDate between  '" & startDate.AddDays(-1) & " 'and '" & startDate & " ' "
            da1.SelectCommand = cmd1
            da1.Fill(ds, "outRestoranPaid")

            dgvOutPayment.DataSource = ds
            dgvOutPayment.DataMember = "outRestoranPaid"
            TextBox2.DataBindings.Add("Text", ds, "outRestoranPaid.zakazid")
            'Else
            '    MsgBox("No Record selected!")



        End If

    End Sub
    Sub refProduct()
        Dim cmd2 As New SqlCommand


        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet
        cmd2 = conn.CreateCommand
        ReadyConnectionF()
        cmd2.CommandText = "select * from restProductPaid where zakazid ='" & TextBox2.Text & " ' "
        da1.SelectCommand = cmd2
        da1.Fill(ds, "restProductPaid")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "restProductPaid"
    End Sub
    Sub sum()
        TextBox1.DataBindings.Clear()

        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet
        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value
        ' Dim startDate As DateTime = Format(DateTimePicker1.Value, "yyyy.MM.dd")
        ' Dim endDate As DateTime = Format(DateTimePicker2.Value, "yyyy.MM.dd")
        ReadyConnectionF()
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select * from restPaidSum where  PurDate between   Convert(date, '" & startDate & " ', 103)  and Convert(date, '" & endDate & " ', 103) "
        ' cmd1.CommandText = "select * from restPaidSum where  PurDate between  '" & startDate.AddDays(-1) & " 'and '" & startDate & " ' "
        da1.SelectCommand = cmd1
        da1.Fill(ds, "restPaidSum")

        dgvOutPaymentSum.DataSource = ds
        dgvOutPaymentSum.DataMember = "restPaidSum"

        TextBox1.DataBindings.Add("Text", ds, "restPaidSum.customerId")

        TextBox3.DataBindings.Add("Text", ds, "restPaidSum.FirstName")
        TextBox4.DataBindings.Add("Text", ds, "restPaidSum.LastName")
        TextBox5.DataBindings.Add("Text", ds, "restPaidSum.bePaid")
    End Sub
    Sub pay()

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        Dim custID As Integer = Int(TextBox1.Text)





        Dim payment As Integer = Int(TextBox5.Text) 'amount to be pay

        ' Dim toPay As Integer


        If MsgBox("Are you sure to paid ? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
            Exit Sub
        Else

            Dim CMDout As New SqlCommand("UpdateOutRestoran")
            CMDout.Parameters.Clear()
            CMDout.Parameters.Add("@ID", Data.SqlDbType.Int).Value = custID 'TextBox2.Text

            CMDout.Parameters.Add("@payMethode", Data.SqlDbType.NChar).Value = ComboBox1.Text
            CMDout.Parameters.Add("@Deposit", Data.SqlDbType.NChar).Value = 0
            ' CMDout.Parameters.Add("@Status", Data.SqlDbType.NChar).Value = 1
            ExecuteProcedur.ExecuteCMD(CMDout)



            MsgBox("OK!")
        End If

    End Sub
    Sub ref()

        ' If dgvOutPaymentSum.RowCount > 0 Then

        'Dim custID As Integer = Int(TextBox1.Text)
        '   sum()
        outPayment()
        ' deposit()
        '  ComboBox1.SelectedIndex = 0
        ' End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pay()
        find()

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


            bindingSource.Filter = String.Format("LastName + FirstName+bePaid Like '%{0}%'", txtFind.Text)
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
    End Sub
    Sub find()
        If dgvOutPaymentSum.RowCount >= 0 Then
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
        End If


        'Dim str As String = "select * from ourRestSum"
        'GetDataRest(str)


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        find()
        ' sum()
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then

            find()

        End If
    End Sub

    Private Sub dgvOutPaymentSum_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPaymentSum.CellContentClick
        ref()
    End Sub

    Private Sub dgvOutPaymentSum_Click(sender As Object, e As EventArgs) Handles dgvOutPaymentSum.Click
        ref()
    End Sub

    Private Sub dgvOutPaymentSum_DoubleClick(sender As Object, e As EventArgs) Handles dgvOutPaymentSum.DoubleClick
        ref()
    End Sub

    Private Sub dgvOutPaymentSum_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOutPaymentSum.KeyDown
        ref()
    End Sub



    Private Sub dgvOutPaymentSum_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvOutPaymentSum.KeyUp
        ref()
    End Sub

    Private Sub dgvOutPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPayment.CellContentClick
        refProduct()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ref()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        ref()
    End Sub

    Private Sub dgvOutPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOutPayment.KeyDown
        refProduct()
    End Sub

    Sub deposit()
        Dim check1 As Integer

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim custID As Integer = Int(TextBox1.Text)

        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select DepositAmount from Deposit  " &
        "where CustomerID = '" & custID & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
            check1 = 0
            Label1.Text = check1
            'MsgBox("No Money in deposit!", MsgBoxStyle.OkOnly, "Info Save Payment")
            'Exit Sub
        Else
            sqlResult1.ToString()

            check1 = ExecuteScalar(cmd1) 'deposit sum 

            Label1.Text = check1
        End If
    End Sub

    Private Sub dgvOutPayment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPayment.CellDoubleClick
        refProduct()
    End Sub

    Private Sub dgvOutPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutPayment.CellClick
        refProduct()
    End Sub

    Private Sub dgvOutPayment_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvOutPayment.KeyUp
        refProduct()
    End Sub






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        payDepositReturn("return")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        Label3.Text = ComboBox1.Text
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        sum()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        sum()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        updateStatus()
    End Sub
    Sub payDepositReturn(PaymentMethode As String)
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

        Dim custID As Integer = Int(TextBox1.Text)
        '   Dim cashier As String = cmbAdmin.Text
        '  If txtDeposit.Text <> "" And txtDeposit.Text <> 0 Then
        Dim amount As Integer
        Dim j As Integer

        If dgvOutPayment IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

            If dgvOutPayment.CurrentRow.Index >= 0 Then
                j = dgvOutPayment.CurrentRow.Index


                Dim zakazId As Integer

                zakazId = Int(dgvOutPayment.Item("zakazId", j).Value.ToString) 'id customer as  guest-not owner
                amount = Int(dgvOutPayment.Item("to paid", j).Value.ToString)
                '  updRestStatus(zakazId)



                'If MsgBox("Are you sure to save Payment? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                '    Exit Sub
                'Else


                Dim CMD As New SqlCommand("InsertPayment")
            ' CMD.Parameters.Clear()
            CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID

            CMD.Parameters.Add("@Amount", Data.SqlDbType.NChar).Value = amount
            CMD.Parameters.Add("@DateReceived", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
            CMD.Parameters.Add("@PaymentMethode", Data.SqlDbType.NChar).Value = PaymentMethode



            CMD.Parameters.Add("@PaymentBasic", Data.SqlDbType.NChar).Value = "Deposit" 'cmbBasic.Text
            ' If cmbBasic.Text = "Deposit" Then
            CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Deposit"
                ' Else
                ' CMD.Parameters.Add("@PaymentPurpose", Data.SqlDbType.NChar).Value = "Additional"
                '  End If
                CMD.Parameters.Add("@ChekNumber", Data.SqlDbType.NVarChar).Value = zakazId
                CMD.Parameters.Add("@Notes", Data.SqlDbType.NText).Value = "deposit return" & zakazId
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
        CMD.Parameters.Add("@POstatus ", Data.SqlDbType.NChar).Value = "return"

        'If ComboBox20.Text <> "" Then
        '    CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = Val(ComboBox20.Text)
        'Else
        CMD.Parameters.Add("@OrderID", Data.SqlDbType.Int).Value = 0
            'End If
            CMD.Parameters.Add("@EmpPercent", Data.SqlDbType.Int).Value = 0

            ExecuteProcedur.ExecuteCMD(CMD)




                ' If cmbBasic.Text = "Deposit" Then

                createDepositAccount(custID)
                addDeposit(custID, amount)
                depositHistory(customerID:=custID, amount:=amount, Reason:="return deposit" & zakazId)

            End If
        End If
        'End If
        '        MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
        '    End If
        'Else
        '    MsgBox("No amount entered!")
        '  End If

        ref()
    End Sub
    Sub updateStatus()
        ' Dim customerid As Integer = CInt(ComboBox7.SelectedValue)
        Dim j As Integer

        If dgvOutPayment IsNot Nothing Then ' AndAlso Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 5)) Then

            If dgvOutPayment.CurrentRow.Index >= 0 Then
                j = dgvOutPayment.CurrentRow.Index


                Dim zakazId As Integer
                Dim amount As Integer
                zakazId = Int(dgvOutPayment.Item("zakazId", j).Value.ToString) 'id customer as  guest-not owner
                amount = Int(dgvOutPayment.Item("To paid", j).Value.ToString)
                updRestStatus(zakazId)


            End If
        End If

        ref()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class
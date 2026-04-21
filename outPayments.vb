Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Public Class frmOutPayment
    Public HDM As Object
    Public dep As Integer
    Public qty1 As Double
    Public discount As Double
    Public price As Double
    Public nameProd As String
    Public codeProd As String
    Public unit As String
    Public adgCode As String
    Public Totalprice As Double
    Public cash As Double
    Public pos As Double
    Public additionalDiscount As Integer
    Public additionalDiscountType As Integer


    Public PaidAmount As Double
    Public PaidAmountCard As Double
    Public prePaymentAmount As Double
    Public partialAmount As Double
    'Dim connetionString As String
    'Dim connection As SqlConnection
    'Dim dt As DataTable
    ' Dim ds As New DataSet
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
    Public Sub hdmProduct()

        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        ReadyConnectionF()

        cmd = conn.CreateCommand
        cmd.CommandText = "select * from ProductHdm where Category1 = '" & TextBox1.Text & " ' "
        da.SelectCommand = cmd
        da.Fill(ds, "ProductHdm")
        With ComboBox1
            .DisplayMember = "ProductHdm.ProductName"
            .ValueMember = "Id"
            .DataSource = ds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With
        prodId.DataBindings.Clear()
        prodId.DataBindings.Add("Text", ds, "ProductHdm.ID")
        txtQuantity.DataBindings.Clear()
        txtQuantity.DataBindings.Add("Text", ds, "ProductHdm.Quantity")
        TextBox5.DataBindings.Clear()
        TextBox5.DataBindings.Add("Text", ds, "ProductHdm.NDS")
        TextBox6.DataBindings.Clear()
        TextBox6.DataBindings.Add("Text", ds, "ProductHdm.UniType")
        '  TextBox2.DataBindings.Clear()
        '  TextBox2.DataBindings.Add("Text", ds, "ProductHdm.Category1")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadyConnectionF()
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()

        cmdPoDetID.CommandText = "select max(ID)  from OutBePaid"
        ' conn.Open()

        Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
        Dim idDetID As Integer
        '  If IsDBNull(sqlResult1) Or no Then
        If sqlResult1 Is Nothing Then
            idDetID = 1

        Else
            sqlResult1.ToString()
            idDetID = ExecuteScalar(cmdPoDetID)
            '  conn.Close()
            idDetID = idDetID + 1
        End If
        If DataGridView3.SelectedCells.Count > 0 Then
            Dim cid As Integer = Int(custID.Text)





            If MsgBox("Are you sure to save Payment ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else

                Dim CMD As New SqlCommand("InsertOutPay")
                ' CMD.Parameters.Clear()
                CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID
                CMD.Parameters.Add("@bePaid", Data.SqlDbType.NChar).Value = amountDisc.Text 'TextBox2.Text
                CMD.Parameters.Add("@purDate", Data.SqlDbType.DateTime).Value = DateTime.Now
                CMD.Parameters.Add("@productID", Data.SqlDbType.Int).Value = prodId.Text
                CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID.Text
                CMD.Parameters.Add("@deposit", Data.SqlDbType.NChar).Value = 0 ' GetDeposit(cid)
                CMD.Parameters.Add("@uid", Data.SqlDbType.NChar).Value = txtUID.Text
                CMD.Parameters.Add("@status", Data.SqlDbType.Int).Value = 0
                ExecuteProcedur.ExecuteCMD(CMD)

                insertCommentmaster()

                MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
            End If
            '  TesthdmPrepaymentUsage()
            hdmPrepaymentUsage()
            outPaid()
            Dim oper As String = ""
            Dim st As String = ""
            oper = "spa with check " & cid
            st = lblUser.Text
            LogFunc(st, oper)
        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If
    End Sub

    Private Sub frmOutPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitCardReader()
        ReadyConnectionF()

        Dim cmd1 As New SqlCommand
        Dim da1 As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select * from HdmSettings where hdmid=3"
        da1.SelectCommand = cmd1
        da1.Fill(ds, "HdmSettings")
        With ComboBox4
            .DisplayMember = "HdmSettings.hdmId"
            .ValueMember = "hdmId"
            .DataSource = ds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        Dim daMaster As New SqlDataAdapter
        Dim stringSqlMaster As String
        stringSqlMaster = "Select * from SPA_Masters"
        daMaster = New SqlDataAdapter(stringSqlMaster, conn)
        daMaster.Fill(ds, "Masters")


        With ComboBox2
            .DisplayMember = "Masters.FirstName"
            .ValueMember = "ID"
            .DataSource = ds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        idMaster.DataBindings.Add("Text", ds, "Masters.id")
        '   TextBox1.DataBindings.Add("Text", ds, "Product.id")
        'TextBox2.DataBindings.Add("Text", ds, "Product.StandardCost")

        Dim cmd2 As New SqlCommand
        Dim da2 As New SqlDataAdapter
        Dim ds1 As New DataSet
        cmd2 = conn.CreateCommand
        '  cmd2.CommandText = "select  DISTINCT ADG,Category,CAST(Description AS NVARCHAR(MAX)) as Description    from ProductHdm where ADG = '96.02'" 'SPA
        cmd2.CommandText = "select  DISTINCT ADG,CAST(Description AS NVARCHAR(MAX)) as Description,Category1    from ProductHdm where ADG = '96.02'"
        da2.SelectCommand = cmd2
        da2.Fill(ds1, "ProductHdm")
        With ComboBox3

            .DisplayMember = "ProductHdm.Description"
            .ValueMember = "Category1"
            .DataSource = ds1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            ' .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        TextBox1.DataBindings.Add("Text", ds1, "ProductHdm.Category1")
    End Sub
    Sub hdmPrepaymentUsage()
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            If DataGridView3.SelectedCells.Count > 0 Then
                Dim cid As Integer = Int(custID.Text)
                Dim hdmId As Integer
                hdmId = 3 'CInt(ComboBox4.SelectedValue)
                Dim item As Boolean
                Dim idProd As Integer
                idProd = Int(prodId.Text)
                dep = GetHdmItemsByID(idProd).dep
                nameProd = GetHdmItemsByID(idProd).ProductName
                codeProd = GetHdmItemsByID(idProd).ProductCode
                unit = GetHdmItemsByID(idProd).UnitType
                adgCode = GetHdmItemsByID(idProd).ADG
                '  pos = CDec(Val(amountPOS.Text))
                qty1 = CDec(Val(txtQuantity.Text))
                price = Math.Round(CDec(Val(txtPrice.Text)))
                cash = Math.Round(price * qty1, 2)
                discount = CDec(Val(txtDiscount.Text))
                Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
                Dim PaymentMethode As String
                PaymentMethode = "PrepUsage"
                HDMfr.OpenSaleDocument(2)
                item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, cash, 1)
                check = HDMfr.PrintDocument(0, 0, 0, Totalprice) 'prePaymentAmount

                If check = True Then

                    MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                    insertHdmCheck(Totalprice, nameProd, PaymentMethode, hdmId, dep)              'OK
                    '  insertHdmCheckNew(Totalprice, nameProd, PaymentMethode, hdmId, cid)
                    insertHdmCheckNew(PaidAmount:=Totalprice, prodName:=nameProd, PaymentMethode:=PaymentMethode, hdmId:=hdmId, dep:=cid)

                Else
                    MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                    MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")

                End If
            Else
                MsgBox("Please select any record!")
                Exit Sub
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim strUID As String = txtUID.Text
        Try
            If Not IsDBNull(GetCustomerByUID(strUID).Uid) Then
                ' Cust = GetCustomerByUID(strUID).Uid
                ' If cust = strUID Then
                Label2.Text = GetCustomerByUID(strUID).LastName + "  " + GetCustomerByUID(strUID).FirstName
                custID.Text = GetCustomerByUID(strUID).Id
                outPaid()
            Else
                MsgBox("Wrong data!", MsgBoxStyle.OkOnly, "Message :")
                'custID.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub outPaid()
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "yyyy/MM/dd HH:mm"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd HH:mm"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        TextBox4.DataBindings.Clear()

        If custID.Text <> "" Then
            Dim id As Integer = CInt(custID.Text)
            Dim cmd1 As New SqlCommand

            Dim da1 As New SqlDataAdapter

            Dim ds As New DataSet
            Dim dt As New DataTable
            ReadyConnectionF()
            cmd1 = conn.CreateCommand

            cmd1.CommandText = "select * from OutReceptionAll where  CustomerID = '" & custID.Text & " ' "
            da1.SelectCommand = cmd1
            da1.Fill(ds, "OutReception")
            TextBox4.DataBindings.Add("Text", ds, "OutReception.Cardid")
            ListView1.Clear()
            For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
                ListView1.Columns.Add(ds.Tables(0).Columns(i).ToString())
                With ListView1
                    .Items.Clear()
                    .View = View.Details
                    .GridLines = True
                    .FullRowSelect = True
                    .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    .MultiSelect = False
                    '.CheckBoxes = True
                End With
            Next
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim listRow As New ListViewItem
                listRow.Text = ds.Tables(0).Rows(i)(0).ToString()
                For j As Integer = 1 To ds.Tables(0).Columns.Count - 1
                    listRow.SubItems.Add(ds.Tables(0).Rows(i)(j).ToString())
                    'If ListView1.Items(i).SubItems(8).Text IsNot Nothing And ListView1.Items(i).SubItems(6).Text = 2 Then
                    '    ListView1.Items(i).BackColor = Drawing.Color.Red
                    'End If
                Next
                ListView1.Items.Add(listRow)
            Next
        Else
        End If
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).BackColor = Color.White
            If ListView1.Items(i).SubItems(8).Text = 2 Then
                ListView1.Items(i).BackColor = Drawing.Color.Red
            End If
            If ListView1.Items(i).SubItems(8).Text = 1 Then
                ListView1.Items(i).BackColor = Drawing.Color.Yellow
            End If
        Next i
        Refresh_Form()
    End Sub
    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick

        Dim iSortOrder As SortOrder = CType(ListView1.Columns(e.Column).Tag, SortOrder)

        Dim lvcs As New ListViewColumnSorter

        If iSortOrder = SortOrder.Ascending Then

            ListView1.Columns(e.Column).Tag = SortOrder.Descending
            lvcs.Order = SortOrder.Descending
            ' lvcs.SortingOrder = SortOrder.Descending

        Else

            ListView1.Columns(e.Column).Tag = SortOrder.Ascending

            lvcs.Order = SortOrder.Ascending

        End If
        lvcs.SortColumn = e.Column
        ' lvcs.ColumnIndex = e.Column

        ListView1.ListViewItemSorter = lvcs

    End Sub
    Sub delete()
        ReadyConnectionF()
        Dim recordID As Integer
        If ListView1.SelectedItems.Count > 0 Then
            recordID = ListView1.SelectedItems(0).SubItems(7).Text
        Else
            MsgBox("Please select any record!")
        End If
        Dim cmd1 As New SqlCommand
        cmd1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = recordID
        cmd1.Parameters.Add("@Status", Data.SqlDbType.Int).Value = 2
        cmd1.CommandText = "Update outBePaid set Status = @Status    where ID = @ID and Status<>1"
        ExecuteNonQuery(cmd1)

        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).BackColor = Color.White
            If ListView1.Items(i).SubItems(8).Text = 2 Then

                ListView1.Items(i).BackColor = Drawing.Color.Red '
                ' ListView1.Items(i).SubItems(0).BackColor = Drawing.Color.Red
            End If
        Next i
        Dim st As String
        Dim oper As String
        If custID.Text <> "" Then
            Dim id As Integer = CInt(custID.Text)
            oper = "delete spa " & id
            st = lblUser.Text
            LogFunc(st, oper)
        End If
        updateDisplay()

    End Sub
    Sub Undodelete()
        ReadyConnectionF()
        Dim recordID As Integer
        If ListView1.SelectedItems.Count > 0 Then
            recordID = ListView1.SelectedItems(0).SubItems(7).Text
        Else
            MsgBox("Please select any record!")
        End If

        Dim cmd1 As New SqlCommand
        cmd1.Parameters.Add("@ID", Data.SqlDbType.Int).Value = recordID
        cmd1.Parameters.Add("@Status", Data.SqlDbType.Int).Value = 0
        cmd1.CommandText = "Update outBePaid set Status = @Status  where ID = @ID"
        ExecuteNonQuery(cmd1)

        For i = 0 To ListView1.Items.Count - 1

            If ListView1.Items(i).SubItems(8).Text = 2 Then

                ListView1.Items(i).BackColor = Drawing.Color.Red
                ' ListView1.Items(i).Checked = True
            Else
                ListView1.Items(i).BackColor = Color.White
            End If
        Next i
        Dim st As String
        Dim oper As String
        If custID.Text <> "" Then
            Dim id As Integer = CInt(custID.Text)
            oper = "undo delete SPA " & id
            st = lblUser.Text
            LogFunc(st, oper)
        End If
        updateDisplay()

    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        outPaid()
    End Sub

    Sub GetDataCust(ByVal selectCommand As String)
        Try

            '    Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))

            Dim dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            Dim bindingSource As New BindingSource
            bindingSource.DataSource = table

            DataGridView3.DataSource = bindingSource 'table.DefaultView

            BindingNavigator2.BindingSource = bindingSource


            bindingSource.Filter = String.Format("LastName + FirstName + CardID+ UID + MobilePhone Like '%{0}%'", txtFind.Text)

            custID.DataBindings.Add("Text", DataGridView3.DataSource, "ID")
            DataGridView3.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("To run , replace the value of the " +
                "connectionString variable with a connection string that is " +
                "valid for your system.")
        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Find()
    End Sub
    Private Sub Find()
        custID.DataBindings.Clear()
        GetDataCust("select CardID,LastName,FirstName,MobilePhone,UID,Id from Customers order by CardID ASC ")
        If custID.Text <> "" Then
            Dim id As Integer = CInt(custID.Text)
            Try
                If Not IsDBNull(GetCustomerByID(id).Id) Then
                    ' Cust = GetCustomerByUID(strUID).Uid
                    ' If cust = strUID Then
                    '  Label2.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
                    ' txtUID.Text = GetCustomerByID(id).Uid
                    outPaid()
                Else
                    MsgBox("Wrong data!", MsgBoxStyle.OkOnly, "Message :")
                    custID.Focus()
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub FindDebt()
        custID.DataBindings.Clear()
        GetDataCust("select * from SpaDebt order by purdate ASC ")
        If custID.Text <> "" Then
            Dim id As Integer = CInt(custID.Text)
            Try
                If Not IsDBNull(GetCustomerByID(id).Id) Then
                    ' Cust = GetCustomerByUID(strUID).Uid
                    ' If cust = strUID Then
                    '  Label2.Text = GetCustomerByID(id).LastName + "  " + GetCustomerByID(id).FirstName
                    ' txtUID.Text = GetCustomerByID(id).Uid
                    outPaid()
                Else
                    MsgBox("Wrong data!", MsgBoxStyle.OkOnly, "Message :")
                    custID.Focus()
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub updateDisplay()

        outPaid()

    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        updateDisplay()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        updateDisplay()
    End Sub

    Private Sub DataGridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView3.KeyDown
        updateDisplay()
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then

            Find()
        End If
    End Sub


    Private Sub DataGridView3_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView3.KeyUp
        updateDisplay()
    End Sub

    Private Sub maxid()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "SPA_Masters"
        ExecuteProcedur.ExecuteCMD(CMDout)
        Dim sqlResult As Object = ExecuteScalar(CMDout)
        If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
            retval = 1
        Else
            retval = Int(sqlResult.ToString()) + 1 'result found
        End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        delete()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Undodelete()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim frm As New frmSpaProducts()
        frm.Show()
    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    ReadyConnectionF()
    '    Dim dacust As New SqlDataAdapter
    '    Dim stringSql As String
    '    Dim ds As New DataSet
    '    stringSql = "Select * from productSpa"
    '    dacust = New SqlDataAdapter(stringSql, conn)
    '    dacust.Fill(ds, "Product")


    '    With ComboBox1
    '        .DisplayMember = "Product.ProductName"
    '        .ValueMember = "ID"
    '        .DataSource = ds

    '    End With
    '    'TextBox2.DataBindings.Clear()
    '    'TextBox2.DataBindings.Add("Text", ds, "Product.StandardCost")
    'End Sub
    Sub insertCommentmaster()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "SPA_Notes"
        ExecuteProcedur.ExecuteCMD(CMDout)
        Dim sqlResult As Object = ExecuteScalar(CMDout)
        If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
            retval = 1
        Else
            retval = Int(sqlResult.ToString()) + 1 'result found
        End If
        Dim cmd As New SqlCommand("Insert into SPA_Notes(ID, idMaster,Comment) VALUES(@ID, @idMaster,@comment)", conn)

        cmd.Parameters.Add(New SqlParameter("@ID", retval))

        cmd.Parameters.Add(New SqlParameter("@idMaster", idMaster.Text))
        cmd.Parameters.Add(New SqlParameter("@comment", txtNotes.Text))

        ExecuteNonQuery(cmd)

    End Sub



    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click
        hdmProduct()
    End Sub

    Private Sub ComboBox3_RightToLeftChanged(sender As Object, e As EventArgs) Handles ComboBox3.RightToLeftChanged
        hdmProduct()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        hdmProduct()
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        hdmProduct()
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ComboBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyUp
        hdmProduct()
    End Sub

    Private Sub ComboBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox3.MouseClick
        hdmProduct()
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        qty1 = CDec(Val(txtQuantity.Text))

        discount = CDec(Val(txtDiscount.Text))
        cash = amountCash.Text
        amountDisc.Text = cash - cash * discount / 100
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        qty1 = CDec(Val(txtQuantity.Text))
        cash = Math.Round(CDec(Val(txtPrice.Text)) * qty1, 2)

        discount = CDec(Val(txtDiscount.Text))

        amountCash.Text = cash - cash * discount / 100
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        qty1 = CDec(Val(txtQuantity.Text))
        txtPrice.Text = Math.Round(CDec(Val(amountCash.Text)) / qty1, 2)

        discount = CDec(Val(txtDiscount.Text))
        cash = amountCash.Text
        amountDisc.Text = cash - cash * discount / 100
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        hdmProduct()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        qty1 = CDec(Val(txtQuantity.Text))
        txtPrice.Text = Math.Round(CDec(Val(amountCash.Text)) / qty1, 2)

        discount = CDec(Val(txtDiscount.Text))
        cash = amountCash.Text
        amountDisc.Text = cash - cash * discount / 100
    End Sub

    Private Sub amountCash_TextChanged(sender As Object, e As EventArgs) Handles amountCash.TextChanged
        qty1 = CDec(Val(txtQuantity.Text))

        txtPrice.Text = Math.Round(CDec(Val(amountCash.Text)) / qty1, 2)
        ' cash = Math.Round(CDec(Val(txtPrice.Text)) * qty1, 2)
        discount = CDec(Val(txtDiscount.Text))
        cash = amountCash.Text
        amountDisc.Text = cash - cash * discount / 100
    End Sub

    Private Sub ComboBox3_TabIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.TabIndexChanged
        hdmProduct()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles connect.Click

        Dim hdmId As Integer = CInt(ComboBox4.SelectedValue)
        connectToHDM(hdmId)
        Dim con As Boolean
        con = HDMfr.ConnectionCheck()
        If con = True Then
            MsgBox("Connected!", MsgBoxStyle.OkOnly, "Message :")
            connect.Text = "Connected!"
        Else
            'MsgBox("No connection!", MsgBoxStyle.OkOnly, "Message :")
            MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
            connect.Text = "No Connection!"
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FindDebt()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        SpaBonusBalance()
    End Sub
    Sub SpaBonusBalance()

        Dim customerID As Integer = CInt(custID.Text)

        Dim check1 As Decimal

        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select DepositAmount from DepositSPABonus  " &
        "where CustomerID = '" & customerID & "'"
        Dim sqlResult1 As Object = ExecuteScalar(cmd1)
        If IsDBNull(sqlResult1) Or sqlResult1 Is Nothing Or sqlResult1 = 0 Then
            check1 = 0
            '  LinkLabel1.Text = check1
            MsgBox("Balanc is 0!", MsgBoxStyle.OkOnly, "Info BONUS")
            'Exit Sub
        Else
            sqlResult1.ToString()

            check1 = ExecuteScalar(cmd1) 'deposit sum 
            MsgBox("Balanc is " & check1 & " !", MsgBoxStyle.OkOnly, "Info BONUS")
            '  LinkLabel1.Text = check1
        End If

    End Sub
    Sub paymSPA()


        ReadyConnectionF()
        Dim cmdPoDetID As SqlCommand
        cmdPoDetID = conn.CreateCommand()

        cmdPoDetID.CommandText = "select max(ID)  from OutBePaid"
        ' conn.Open()

        Dim sqlResult1 As Object = ExecuteScalar(cmdPoDetID)
        Dim idDetID As Integer
        '  If IsDBNull(sqlResult1) Or no Then
        If sqlResult1 Is Nothing Then
            idDetID = 1

        Else
            sqlResult1.ToString()
            idDetID = ExecuteScalar(cmdPoDetID)
            '  conn.Close()
            idDetID = idDetID + 1
        End If
        If DataGridView3.SelectedCells.Count > 0 Then
            Dim cid As Integer = Int(custID.Text)





            If MsgBox("Are you sure to save Payment ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else

                Dim CMD As New SqlCommand("InsertOutPay")
                ' CMD.Parameters.Clear()
                CMD.Parameters.Add("@ID", Data.SqlDbType.Int).Value = idDetID
                CMD.Parameters.Add("@bePaid", Data.SqlDbType.NChar).Value = amountDisc.Text 'TextBox2.Text
                CMD.Parameters.Add("@purDate", Data.SqlDbType.DateTime).Value = DateTime.Now
                CMD.Parameters.Add("@productID", Data.SqlDbType.Int).Value = prodId.Text
                CMD.Parameters.Add("@CustomerID", Data.SqlDbType.Int).Value = custID.Text
                CMD.Parameters.Add("@deposit", Data.SqlDbType.NChar).Value = 0 ' GetDeposit(cid)
                CMD.Parameters.Add("@uid", Data.SqlDbType.NChar).Value = txtUID.Text
                CMD.Parameters.Add("@status", Data.SqlDbType.Int).Value = 0
                ExecuteProcedur.ExecuteCMD(CMD)

                insertCommentmaster()

                MsgBox("Payment complete", MsgBoxStyle.OkOnly, "Message :")
                Dim oper As String = ""
                Dim st As String = ""
                oper = "spa without check " & cid
                st = lblUser.Text
                LogFunc(st, oper)
            End If
            '  TesthdmPrepaymentUsage()
            '  hdmPrepaymentUsage()
            'SpaBonusUsage(cid)
            outPaid()
        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If
    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        paymSPA()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cid As Integer = Int(custID.Text)
        Dim used As Decimal = CDec(txtQuantity.Text)
        ' SpaBonusUsage(cid)
        '  outPaid()
        GetCreateDepositSPABonus(cid)
        useDepositSPABonus(cid, used)
        SpaBonusBalance()
        Dim oper As String = ""
        Dim st As String = ""
        oper = "spa use bonus " & cid
        st = lblUser.Text
        LogFunc(st, oper)
    End Sub
    Sub Refresh_Form()


        pView.Update()


        Dim str As String = Trim(TextBox4.Text)
        Dim path As String = imagePath & str & ".jpg"
        If File.Exists(path) Then
            pView.Image = Image.FromFile(path)
        Else
            pView.Image = Nothing
            pView.Update()
        End If

        pView.SizeMode = PictureBoxSizeMode.StretchImage
        pView.Refresh()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub frmOutPayment_Load_1(sender As Object, e As EventArgs)
        InitCardReader()
    End Sub
End Class
Public Class ListViewColumnSorter
    Implements System.Collections.IComparer
    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer
    Public Sub New()
        ' Initialize the column to '0'.
        ColumnToSort = 0
        ' Initialize the sort order to 'none'.
        OrderOfSort = SortOrder.Unspecified
        ' Initialize the CaseInsensitiveComparer object.
        ObjectCompare = New CaseInsensitiveComparer()
    End Sub
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim compareResult As Integer
        Dim listviewX As ListViewItem
        Dim listviewY As ListViewItem
        ' Cast the objects to be compared to ListViewItem objects.
        listviewX = CType(x, ListViewItem)
        listviewY = CType(y, ListViewItem)
        ' Compare the two items.
        compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text, listviewY.SubItems(ColumnToSort).Text)
        ' Calculate the correct return value based on the object 
        ' comparison.
        If (OrderOfSort = SortOrder.Ascending) Then
            ' Ascending sort is selected, return typical result of 
            ' compare operation.
            Return compareResult
        ElseIf (OrderOfSort = SortOrder.Descending) Then
            ' Descending sort is selected, return negative result of 
            ' compare operation.
            Return (-compareResult)
        Else
            ' Return '0' to indicate that they are equal.
            Return 0
        End If
    End Function
    Public Property SortColumn() As Integer
        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set
        Get
            Return ColumnToSort
        End Get
    End Property
    Public Property Order() As SortOrder
        Set(ByVal Value As SortOrder)
            OrderOfSort = Value
        End Set
        Get
            Return OrderOfSort
        End Get
    End Property
End Class
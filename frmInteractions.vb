Imports System.Data.SqlClient
Public Class frmInteractions
    Public Sub GetDataInter(ByVal selectCommand As String)
        Try

            '   Dim connectionString As String = (BuildSqlNativeConnStr(server, database, username, password))
            Dim dataAdapter As SqlDataAdapter
            dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            Dim bindingSource As New BindingSource
            bindingSource.DataSource = table
            ' DataGridView3.DataSource = table.DefaultView
            DataGridView1.DataSource = bindingSource 'table.DefaultView
            BindingNavigator1.BindingSource = bindingSource


            bindingSource.Filter = String.Format("Name + SurName + ContactPhone Like '%{0}%'", txtFind.Text)
          
            DataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("Connection error!")
        End Try

    End Sub

    Private Sub frmInteractions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' GetDataInter("Select * from Interactions")
        GetDataInter("Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions")

        '  loadNew()
        Dim countRow = DataGridView1.RowCount
        Dim j As Integer
        If countRow > 1 Then
            j = DataGridView1.CurrentRow.Index
        Else
            j = 1
        End If
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Regular)
        End With

        '  If j <= countRow And j >= 0 Then
        TextBox1.DataBindings.Add("Text", DataGridView1.DataSource, "ID")
        txtName.DataBindings.Add("Text", DataGridView1.DataSource, "Name")
        txtLastName.DataBindings.Add("Text", DataGridView1.DataSource, "SurName")
        TextBox7.DataBindings.Add("Text", DataGridView1.DataSource, "InfoSource")
        txtPhone.DataBindings.Add("Text", DataGridView1.DataSource, "ContactPhone")
        TextBox2.DataBindings.Add("Text", DataGridView1.DataSource, "AdditionalPhone")
        TextBox4.DataBindings.Add("Text", DataGridView1.DataSource, "FirstContactType")
        '   TextBox5.DataBindings.Add("Text", DataGridView1.DataSource, "InteractionType")

        TextBox6.DataBindings.Add("Text", DataGridView1.DataSource, "Comment")

      
        '   End If
        ReadyConnectionF()
        Dim sqlEmpl As String
        sqlEmpl = "Select * from Emp"


        Dim ds As New DataSet
        Dim dacust As New SqlDataAdapter

            dacust = New SqlDataAdapter(sqlEmpl, Connection)
            dacust.Fill(ds, "Emp")


        With txtManager
            .DisplayMember = "Emp.Name"
            .ValueMember = "ID"
            .DataSource = ds
            .SelectedIndex = -1
        End With
        TextBox3.DataBindings.Add("Text", ds, "Emp.ID")
        loadInterGraffik()
        loadInterOffer()

        'DataGridView5.Columns(4).DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss"
        'DataGridView1.Columns(3).DefaultCellStyle.Format = "dd.MM.yyyy"
    End Sub
    Sub find()
       
        GetDataInter("Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions")
        If BindingNavigator1.BindingSource.Count = 0 Then
            '

            MessageBox.Show("No any data!")

            Exit Sub


        Else
            TextBox1.DataBindings.Clear()
            TextBox1.DataBindings.Add("Text", DataGridView1.DataSource, "ID")
            DataGridView1.Refresh()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        find()
        ' GetDataInter("Select * from interTasks")
        '  GetDataInter("Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions")
    End Sub
    Private Sub txtFind_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' ref()

            'ref()
            find()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ref()
    End Sub
    Sub ref()

        '    GetDataInter("Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions")
        loadInterGraffik()
        loadInterOffer()



        Dim custId As Integer

        ' If TextBox1.Text <> "" Then
        If DataGridView1.CurrentRow.Index + 1 >= DataGridView1.RowCount() Then

        Else
            custId = Int(TextBox1.Text)
            txtName.Text = GetInter(custId).Name
            txtLastName.Text = GetInter(custId).SurName
            txtPhone.Text = GetInter(custId).ContactPhone


        End If
        '  loadNew()
        '' loadRefused()
        '' loadSold()
        '
    End Sub
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        ref()
    End Sub
    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        ref()
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        ref()
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        ref()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub


    Sub loadNew()

        ReadyConnectionF()
        Dim ds As New DataSet
        Dim cmdAdd As SqlCommand
        cmdAdd = conn.CreateCommand()
        cmdAdd.CommandText = "Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions" ' where ClientStatus=0" ''new'"

        Dim daAdd As New SqlDataAdapter
        daAdd.SelectCommand = cmdAdd
        daAdd.Fill(ds, "Inter")
        DataGridView1.DataSource = ds.Tables("Inter")
        '  TextBox1.DataBindings.Clear()

    End Sub
    Sub loadSold()

        ReadyConnectionF()
        Dim ds As New DataSet
        Dim cmdAdd As SqlCommand
        cmdAdd = conn.CreateCommand()
        cmdAdd.CommandText = "Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions where ClientStatus=1"
        ' cmdAdd.CommandText = "Select * from AddBalance where CustomerID = '" & ComboBox7.SelectedValue & " ' "
        Dim daAdd As New SqlDataAdapter
        daAdd.SelectCommand = cmdAdd
        daAdd.Fill(ds, "Inter")
        DataGridView1.DataSource = ds.Tables("Inter")
    End Sub
    Sub loadRefused()

        ReadyConnectionF()
        Dim ds As New DataSet
        Dim cmdAdd As SqlCommand
        cmdAdd = conn.CreateCommand()
        cmdAdd.CommandText = "Select InfoSource,FirstContactType,FirstContactDate,Name,SurName,ContactPhone,AdditionalPhone,Comment,ClientType,ClientStatus,ID from Interactions where ClientStatus= 2"
        ' cmdAdd.CommandText = "Select * from AddBalance where CustomerID = '" & ComboBox7.SelectedValue & " ' "
        Dim daAdd As New SqlDataAdapter
        daAdd.SelectCommand = cmdAdd
        daAdd.Fill(ds, "Inter")
        DataGridView1.DataSource = ds.Tables("Inter")
    End Sub
    Sub loadInterGraffik()

        ReadyConnectionF()
        Dim ds As New DataSet
        Dim cmdAdd As SqlCommand
        cmdAdd = conn.CreateCommand()
        cmdAdd.CommandText = "Select * from interGraffik   where interid = '" & TextBox1.Text & " ' "
        ' cmdAdd.CommandText = "Select * from AddBalance where CustomerID = '" & ComboBox7.SelectedValue & " ' "
        Dim daAdd As New SqlDataAdapter
        daAdd.SelectCommand = cmdAdd
        daAdd.Fill(ds, "Inter")
        DataGridView6.DataSource = ds.Tables("Inter")
    End Sub
    Sub loadInterOffer()
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy HH:mm"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        ReadyConnectionF()
        Dim ds As New DataSet
        Dim cmdAdd As SqlCommand
        cmdAdd = conn.CreateCommand()
        cmdAdd.CommandText = "Select * from interOffer   where interid = '" & TextBox1.Text & " ' "
        ' cmdAdd.CommandText = "Select * from AddBalance where CustomerID = '" & ComboBox7.SelectedValue & " ' "
        Dim daAdd As New SqlDataAdapter
        daAdd.SelectCommand = cmdAdd
        daAdd.Fill(ds, "Inter")
        DataGridView5.DataSource = ds.Tables("Inter")
    End Sub

   
    Sub NewInteractions()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        'Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView1.DataSource, DataGridView1.DataMember), CurrencyManager)
        'Dim dv As DataView = CType(cm.List, DataView)

        'Dim dr As DataRow
        'dr = dv.Item(cm.Position).Row
        If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else

            CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "Interactions"
            ExecuteProcedur.ExecuteCMD(CMDout)
            Dim sqlResult As Object = ExecuteScalar(CMDout)
            If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
                retval = 1
            Else
                retval = Int(sqlResult.ToString()) + 1 'result found
            End If
         

            Dim cmd As New SqlCommand("InsertInteractions", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", retval))
            'cmd.Parameters.Add(New SqlParameter("@InfoSource", dr(1)))
            'cmd.Parameters.Add(New SqlParameter("@FirstContactType", dr(2)))
            'cmd.Parameters.Add(New SqlParameter("@FirstContactDate", DateTime.Now))
            'cmd.Parameters.Add(New SqlParameter("@Name", dr(4)))
            'cmd.Parameters.Add(New SqlParameter("@SurName", dr(5)))
            'cmd.Parameters.Add(New SqlParameter("@ContactPhone", dr(6)))
            'cmd.Parameters.Add(New SqlParameter("@AdditionalPhone", dr(7)))
            'cmd.Parameters.Add(New SqlParameter("@InteractionType", dr(8)))
            'cmd.Parameters.Add(New SqlParameter("@Comment", dr(9)))
            'cmd.Parameters.Add(New SqlParameter("@EmpoleeID", TextBox3.Text))
            'cmd.Parameters.Add(New SqlParameter("@ClientStatus", 0))
            'cmd.Parameters.Add(New SqlParameter("@ClientType", 1))

            cmd.Parameters.Add(New SqlParameter("@InfoSource", TextBox7.Text))
            cmd.Parameters.Add(New SqlParameter("@FirstContactType", TextBox4.Text))
            cmd.Parameters.Add(New SqlParameter("@FirstContactDate", DateTime.Now))
            cmd.Parameters.Add(New SqlParameter("@Name", txtName.Text))
            cmd.Parameters.Add(New SqlParameter("@SurName", txtLastName.Text))
            cmd.Parameters.Add(New SqlParameter("@ContactPhone", txtPhone.Text))
            cmd.Parameters.Add(New SqlParameter("@AdditionalPhone", TextBox2.Text))
            cmd.Parameters.Add(New SqlParameter("@InteractionType", TextBox5.Text))
            cmd.Parameters.Add(New SqlParameter("@Comment", TextBox6.Text))
            cmd.Parameters.Add(New SqlParameter("@EmpoleeID", TextBox3.Text))
            cmd.Parameters.Add(New SqlParameter("@ClientStatus", 0))
            cmd.Parameters.Add(New SqlParameter("@ClientType", 1))

            ExecuteNonQuery(cmd)


            MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")

        End If




    End Sub
    Sub NewOffer()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "interOffer"
            ExecuteProcedur.ExecuteCMD(CMDout)
            Dim sqlResult As Object = ExecuteScalar(CMDout)
            If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
                retval = 1
            Else
                retval = Int(sqlResult.ToString()) + 1 'result found
            End If
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView5.DataSource, DataGridView5.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)

            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row



            Dim cmd As New SqlCommand("InsertInterOffer", conn)
            cmd.CommandType = CommandType.StoredProcedure
            'Dim startDate As Date = dr(3)
            'Dim endDate As Date = dr(4)

            cmd.Parameters.Add(New SqlParameter("@CardQuantity", dr(0).ToString))
            cmd.Parameters.Add(New SqlParameter("@PlannedAmount", dr(1).ToString))
            cmd.Parameters.Add(New SqlParameter("@PrefferedOffer", dr(2).ToString))
            cmd.Parameters.Add(New SqlParameter("@StartDate", dr(3)))
            cmd.Parameters.Add(New SqlParameter("@EndDate", dr(4)))
            cmd.Parameters.Add(New SqlParameter("@employeeID", TextBox3.Text))
            cmd.Parameters.Add(New SqlParameter("@ID", retval))
            cmd.Parameters.Add(New SqlParameter("@interID", TextBox1.Text))
            ExecuteNonQuery(cmd)

            MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")


       
        End If






    End Sub
    Sub NewGraffik()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "interGraffik"
            ExecuteProcedur.ExecuteCMD(CMDout)
            Dim sqlResult As Object = ExecuteScalar(CMDout)
            If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
                retval = 1
            Else
                retval = Int(sqlResult.ToString()) + 1 'result found
            End If
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView6.DataSource, DataGridView6.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)

            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row



            Dim cmd As New SqlCommand("InsertinterGraffik", conn)
            cmd.CommandType = CommandType.StoredProcedure





            'Dim startDate As Date = dr(0)
            'Dim endDate As Date = dr(4)
            cmd.Parameters.Add(New SqlParameter("@InterDate", dr(0)))
            cmd.Parameters.Add(New SqlParameter("@InterType", dr(1).ToString))
            cmd.Parameters.Add(New SqlParameter("@NextInter", dr(2).ToString))
            cmd.Parameters.Add(New SqlParameter("@NextInterDate", dr(3)))
            cmd.Parameters.Add(New SqlParameter("@NextInterTime", dr(4)))
            cmd.Parameters.Add(New SqlParameter("@Comment", dr(5).ToString))
            cmd.Parameters.Add(New SqlParameter("@interStatus", dr(6).ToString))



            cmd.Parameters.Add(New SqlParameter("@employeeID", TextBox3.Text))
            cmd.Parameters.Add(New SqlParameter("@ID", retval))
            cmd.Parameters.Add(New SqlParameter("@interID", TextBox1.Text))
            ExecuteNonQuery(cmd)

            MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            
        End If

       





    End Sub
    Sub SetStatusSold()
        ReadyConnectionF()
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim retval As Integer = Int(TextBox1.Text)


            If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                Dim cmd As New SqlCommand("Update Interactions set ClientStatus=@ClientStatus where ID = '" & retval & " ' ", conn)

                cmd.Parameters.Add(New SqlParameter("@ID", retval))

               
                cmd.Parameters.Add(New SqlParameter("@ClientStatus", 1))


                ExecuteNonQuery(cmd)
                MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            End If

        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If


    End Sub
    Sub SetStatusRefused()
        ReadyConnectionF()
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim retval As Integer = Int(TextBox1.Text)


            If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                Dim cmd As New SqlCommand("Update Interactions set ClientStatus=@ClientStatus where ID = '" & retval & " ' ", conn)

                cmd.Parameters.Add(New SqlParameter("@ID", retval))


                cmd.Parameters.Add(New SqlParameter("@ClientStatus", 2))


                ExecuteNonQuery(cmd)
                MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            End If

        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If


    End Sub
    Sub UpdateInteractions()
        ReadyConnectionF()
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim retval As Integer = Int(TextBox1.Text)


            If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                Dim cmd As New SqlCommand("UpdateInteractions", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@ID", retval))

                cmd.Parameters.Add(New SqlParameter("@InfoSource", TextBox7.Text))
                cmd.Parameters.Add(New SqlParameter("@FirstContactType", TextBox4.Text))
                cmd.Parameters.Add(New SqlParameter("@FirstContactDate", DateTime.Now))
                cmd.Parameters.Add(New SqlParameter("@Name", txtName.Text))
                cmd.Parameters.Add(New SqlParameter("@SurName", txtLastName.Text))
                cmd.Parameters.Add(New SqlParameter("@ContactPhone", txtPhone.Text))
                cmd.Parameters.Add(New SqlParameter("@AdditionalPhone", TextBox2.Text))
                cmd.Parameters.Add(New SqlParameter("@InteractionType", TextBox5.Text))
                cmd.Parameters.Add(New SqlParameter("@Comment", TextBox6.Text))
                cmd.Parameters.Add(New SqlParameter("@EmpoleeID", TextBox3.Text))
                cmd.Parameters.Add(New SqlParameter("@ClientStatus", 1))
                cmd.Parameters.Add(New SqlParameter("@ClientType", 1))

                ExecuteNonQuery(cmd)
                MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            End If

        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If


    End Sub
    Sub UpdateInterOffer()
        ReadyConnectionF()
        If DataGridView5.SelectedCells.Count > 0 Then


            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView5.DataSource, DataGridView5.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)

            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row

            If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                Dim cmd As New SqlCommand("UpdateInterOffer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@CardQuantity", dr(0).ToString))
                cmd.Parameters.Add(New SqlParameter("@PlannedAmount", dr(1).ToString))
                cmd.Parameters.Add(New SqlParameter("@PrefferedOffer", dr(2).ToString))
                cmd.Parameters.Add(New SqlParameter("@StartDate", dr(3)))
                cmd.Parameters.Add(New SqlParameter("@EndDate", dr(4)))
                cmd.Parameters.Add(New SqlParameter("@employeeID", dr(5)))
                cmd.Parameters.Add(New SqlParameter("@ID", dr(6)))
                cmd.Parameters.Add(New SqlParameter("@interID", TextBox1.Text))

                ExecuteNonQuery(cmd)
                MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            End If

        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If
    End Sub
    Sub UpdateInterGraffik()
        ReadyConnectionF()
        If DataGridView6.SelectedCells.Count > 0 Then


            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridView6.DataSource, DataGridView6.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)

            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row

            If MsgBox("Are you sure to save changes? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

                Exit Sub
            Else
                Dim cmd As New SqlCommand("UpdateInterGraffik", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@InterDate", dr(0)))
                cmd.Parameters.Add(New SqlParameter("@InterType", dr(1).ToString))
                cmd.Parameters.Add(New SqlParameter("@NextInter", dr(2).ToString))
                cmd.Parameters.Add(New SqlParameter("@NextInterDate", dr(3)))
                cmd.Parameters.Add(New SqlParameter("@NextInterTime", dr(4)))
                cmd.Parameters.Add(New SqlParameter("@Comment", dr(5).ToString))
                cmd.Parameters.Add(New SqlParameter("@interStatus", dr(6).ToString))
                cmd.Parameters.Add(New SqlParameter("@employeeID", TextBox3.Text))
                cmd.Parameters.Add(New SqlParameter("@ID", dr(8)))
                cmd.Parameters.Add(New SqlParameter("@interID", TextBox1.Text))

                ExecuteNonQuery(cmd)
                MsgBox("Update complete", MsgBoxStyle.OkOnly, "Message :")
            End If

        Else
            MsgBox("Please select any record!")
            Exit Sub
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewInteractions()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SetStatusSold()
        find()
    End Sub
   
    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub DataGridView5_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView5.DataError
        MsgBox("An  error occurred while processing the value ! " & e.Exception.Message)

    End Sub
    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MsgBox("An  error occurred while processing the value ! " & e.Exception.Message)

    End Sub
    Private Sub DataGridView6_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView6.DataError
        MsgBox("An  error occurred while processing the value ! " & e.Exception.Message)

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NewOffer()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NewGraffik()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UpdateInteractions()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UpdateInterOffer()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UpdateInterGraffik()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetStatusRefused()
        find()
    End Sub
End Class
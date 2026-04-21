Imports System.Data.SqlClient
Imports DataGridViewAutoFilter

Public Class frmProfile
    Dim custid As Integer

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()

    End Sub
    Sub Getdata()
        Try
            ReadyConnectionF()
            Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
           "from customers", conn)
            Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ReadUID()
        txtFind.Text = ""
        Dim openSuccess As Boolean
        Dim AxCardReader1 As New GAT_Writer_5250.CardReader
        REM You need to set a valid key to read Segments / cash
        REM THIS KEY IS ONLY VALID FOR FID="9999"
        AxCardReader1.CryptKey = "E6147DD79B589816B733BE7B4D52EE32"
        AxCardReader1.FID = "9999"
        AxCardReader1.FID_SUB = "00"
        ' Label2.Caption = "FID: " + AxCardReader2.FID
        openSuccess = AxCardReader1.OpenDevice
        If (openSuccess) = True Then 'Button2.Enabled = True

            Dim txtUID As String = AxCardReader1.GetUniqueNumber
            txtFind.Text = txtUID

        End If
    End Sub
    Sub FindName()

        Try
            ReadyConnectionF()
            Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
   "from customers where FirstName Like '%" & txtFirst.Text & "%' and LastName like '%" & txtLast.Text & "%'  order by cardid", conn)
            '  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
            Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12))
            End While

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
                If Not IsDBNull(dgw.Item("Status", j).Value) Then
                    If dgw.Item("Status", j).Value = "disabled" Then
                        Disabled.Checked = True
                    Else
                        Disabled.Checked = False

                    End If
                    If dgw.Item("Status", j).Value = "allow" Then
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
    Sub FindByCardid()
        Try
            ReadyConnectionF()
            Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID,status,Cardtype,Attachments,EMail,Notes,BornOn,ContactPerson " &
     "From customers Where Cardid Like '%" & txtFind.Text & "%' or MobilePhone like '%" & txtFind.Text & "%' or UID like '%" & txtFind.Text & "%' or Status like '%" & txtFind.Text & "%' or FirstName like '%" & txtFind.Text & "%' order by cardid", conn)
            '  Dim cmd = New SqlCommand("SELECT id,Cardid,FirstName,LastName,MobilePhone,UID from customers where LastName + FirstName + CardID + UID+MobilePhone Like '%{0}%'" & txtFind.Text & "%' ", conn)
            Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'search()
        FindByCardid()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnFindLF.Click
        FindName()
    End Sub



    Private Sub GetDetails()
        Dim j As Integer = 0

        Dim countRow = dgw.RowCount
        j = dgw.CurrentRow.Index

        If j <= countRow And j >= 0 Then

            txtCardid.Text = dgw.Item("Cardid", j).Value.ToString
            txtCustid.Text = dgw.Item("id", j).Value.ToString
            ' txtLastName.Text = DataGridView3.Item("LastName", j).Value.ToString
            txtPhone2.Text = dgw.Item("MobilePhone", j).Value.ToString
            txtBorn.Text = dgw.Item("BornOn", j).Value.ToString
            RichTextBox1.Text = dgw.Item("Notes", j).Value.ToString 'notes
            txtGroup.Text = dgw.Item("Attachments", j).Value.ToString 'gr
            txtUID.Text = dgw.Item("UID", j).Value.ToString 'UID

            txtMail.Text = dgw.Item("Email", j).Value.ToString 'email
        End If
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        GetStatus()
        GetDetails()
        refTab()
    End Sub

    Private Sub dgw_KeyDown(sender As Object, e As KeyEventArgs) Handles dgw.KeyDown
        GetStatus()
        GetDetails()
        refTab()

    End Sub

    Private Sub dgw_KeyUp(sender As Object, e As KeyEventArgs) Handles dgw.KeyUp
        GetStatus()
        GetDetails()
        refTab()
    End Sub
    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub
    Sub refTab()
        AllOrders()
        tabPayments()
        tabFreez()
    End Sub
    Sub AllOrders()
        Button36.Enabled = False
        custid = Int(txtCustid.Text)
        Dim ds As New DataSet
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        Try
            ReadyConnectionF()

            Dim cmdord As New SqlCommand
            cmdord = conn.CreateCommand
            Dim da As New SqlDataAdapter
            Dim LateDate = DateTime.Now

            cmdord.CommandText = "select * from OrdersFullLast where CustomerID = '" & custid & " '  "

            da.SelectCommand = cmdord            ' 

            da.Fill(ds, "OrdersFullLast")
            dgvOrders.DataSource = ds


            dgvOrders.DataMember = "OrdersFullLast"

        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            '  MessageBox.Show("No any data!")
        End Try
    End Sub
    Sub tabPayments()
        custid = Int(txtCustid.Text)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        Try
            ReadyConnectionF()

            cmd = conn.CreateCommand
            cmd.CommandText = "select * from profilePO where CustomerID = '" & custid & " ' "

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
        custid = Int(txtCustid.Text)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        tmpCurrentCulture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy"
        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        Try
            ReadyConnectionF()

            cmd = conn.CreateCommand

            cmd.CommandText = "select * from FreezBalance where CustomerID = '" & custid & " ' "
            Dim da6 As New SqlDataAdapter
            da6.SelectCommand = cmd
            da6.Fill(ds, "FreezingUsage")
            DataGrid6.DataSource = ds
            DataGrid6.DataMember = "FreezingUsage"
            DataGrid6.CaptionText = "Freezing History"

            Dim cmd7 As New SqlCommand
            cmd7 = conn.CreateCommand

            cmd7.CommandText = "select * from FreezBalUsed where CustomerID = '" & custid & " ' "
            Dim da7 As New SqlDataAdapter
            da7.SelectCommand = cmd7
            da7.Fill(ds, "FreezPaidFree")
            DataGrid8.DataSource = ds
            DataGrid8.DataMember = "FreezPaidFree"
            DataGrid8.CaptionText = "Freezing Balance"
            If DataGrid8.CurrentRowIndex + 1 > 0 Then
                TextBox15.Text = DataGrid8(DataGrid8.CurrentRowIndex, 4) '
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            '  MessageBox.Show("No any data!")
        End Try

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) _
     Handles TabControl1.SelectedIndexChanged
        refTab()
        'suppose your *finance tab* instance is TabPageFinance 
        'If TabControl1.SelectedTab Is orders Then
        '    AllOrders()
        'End If

        ''or suppose *finance tab* index is 0 
        'If TabControl1.SelectedIndex = 0 Then
        '    'do stuff
        'End If

    End Sub
    Private WithEvents pd As New Printing.PrintDocument
    Private ppd As PrintPreviewDialog

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPhone2.Text = "TextBox1 contents"
        txtPhone2.Text = "TextBox2 contents"
        TextBox3.Text = "TextBox3 contents"
        TextBox4.Text = "This is an example of printing a multiline textbox contents. It's more complicated than printing a single line textbox contents, but they are similar in that you need to keep track of the space used on the printed page..."
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This brings up a PrintPreviewDialog
        'To bypass the dialog and just print, use:
        'pd.Print 

        ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
        ppd.ShowDialog()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        'Single line textboxes. 
        'The locations used are just the location on the form in this case.
        e.Graphics.DrawString(txtPhone2.Text, txtPhone2.Font, Brushes.Black, txtPhone2.Left, txtPhone2.Top)
        e.Graphics.DrawString(cmbAdmin.Text, cmbAdmin.Font, Brushes.Black, cmbAdmin.Left, cmbAdmin.Top)
        e.Graphics.DrawString(TextBox3.Text, TextBox3.Font, Brushes.Black, TextBox3.Left, TextBox3.Top)
        e.Graphics.DrawString(Now, TextBox3.Font, Brushes.Azure, TextBox3.Left, TextBox3.Top)
        'Multiline textbox
        'Here i used the textbox bounds as the layout rectangle
        e.Graphics.DrawString(TextBox4.Text, TextBox4.Font, Brushes.Black, TextBox4.Bounds, Drawing.StringFormat.GenericTypographic)
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click

    End Sub
End Class
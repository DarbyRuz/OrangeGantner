Imports System.Data.SqlClient
Imports System.IO
Imports DataGridViewAutoFilter

Public Class Monitoring

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10000
        Timer1.Enabled = False
        upd()
        'Dim f As Integer
        'For f = 0 To dgvOutPayment.RowCount
        '    dgvOutPayment.DataSource = ds
        '    dgvOutPayment.DataMember = "OutReception"
        '    If dgvOutPayment.Rows(f).Cells(3).Value > dgvOutPayment.Rows(f).Cells(4).Value Then

        '        dgvOutPayment.Rows(f).DefaultCellStyle.BackColor = Color.Red
        '    End If
        'Next
    End Sub


    Sub upd()
        Dim cmd1 As New SqlCommand

        Dim da1 As New SqlDataAdapter

        Dim ds As New DataSet
        Dim dt As New DataTable
        ReadyConnectionF()
        TextBox1.DataBindings.Clear()
        cmd1 = conn.CreateCommand

        cmd1.CommandText = "select * from Monitoring order by DateCheckIn DESC"
        da1.SelectCommand = cmd1
        da1.Fill(ds, "Monitoring")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Monitoring"
        TextBox1.DataBindings.Add("Text", ds, "Monitoring.CardId")






        'Dim cmd1 As New SqlCommand

        'Dim da1 As New SqlDataAdapter

        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'ReadyConnectionF()
        'TextBox1.DataBindings.Clear()
        ''cmd1 = conn.CreateCommand

        ''cmd1.CommandText = "select * from Monitoring order by DateCheckIn DESC"
        ''da1.SelectCommand = cmd1
        ''da1.Fill(ds, "Monitoring")
        ''DataGridView1.DataSource = ds
        ''DataGridView1.DataMember = "Monitoring"
        ''TextBox1.DataBindings.Add("Text", ds, "Monitoring.CardId")
        'Dim strBal As String = "select * from Monitoring order by DateCheckIn DESC"

        'Dim bs = New BindingSource()
        'DataGridView1.DataSource = bs
        'Dim cmdbal As New SqlCommand(strBal, conn)


        'Dim da As New SqlDataAdapter(cmdbal)

        'Dim table = New DataTable()
        'table.Locale = System.Globalization.CultureInfo.InvariantCulture
        'da.Fill(table)
        'bs.DataSource = table
        'If bs Is Nothing Then
        '    Return
        'End If
        'If table.Columns("CardId") IsNot Nothing Then
        '    TextBox1.DataBindings.Add("Text", table, "CardId")

        'End If



        ''For Each col As DataGridViewColumn In DataGridView1.Columns
        ''    col.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell)
        ''    ' AdvancedDataGridViewSearchToolBar.
        ''Next







        ''    ListView1.Clear()

        ''    For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
        ''        ListView1.Columns.Add(ds.Tables(0).Columns(i).ToString())

        ''        With ListView1
        ''            .Items.Clear()
        ''            .View = View.Details
        ''            .GridLines = True
        ''            .FullRowSelect = True

        ''            ' .Columns(i).Width = -2

        ''        End With
        ''    Next

        ''    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        ''        Dim listRow As New ListViewItem
        ''        listRow.Text = ds.Tables(0).Rows(i)(0).ToString()
        ''        For j As Integer = 1 To ds.Tables(0).Columns.Count - 1
        ''            listRow.SubItems.Add(ds.Tables(0).Rows(i)(j).ToString())
        ''        Next
        ''        ListView1.Items.Add(listRow)
        ''    Next
        ''    For i As Integer = 0 To ListView1.Columns.Count - 1
        ''        ListView1.Columns(i).Width = -2
        ''    Next i

        ''    'Dim item_rect As Rectangle = _
        ''    '  ListView1.GetItemRect(ListView1.Columns.Count - 1)
        ''    'Me.SetClientSizeCore( _
        ''    '    item_rect.Left + item_rect.Width + 10, _
        ''    '    item_rect.Top + item_rect.Height + 25)
        ''End Sub
        ''Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ''    Timer1.Interval = 10000
        ''    Timer1.Enabled = True
        ''    ListView1.Refresh()

        ''ListView1.Items.Add(DateTime.Now.ToLongTimeString() + "," + _
        ''                   DateTime.Now.ToLongDateString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        ' Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
    End Sub
    Sub Refresh_Form()
        Dim str As String = Trim(TextBox1.Text)
        Dim path As String = imagePath & str & ".jpg"
        Dim fs As System.IO.FileStream
        ' Specify a valid picture file path on your computer.

        If File.Exists(path) Then
            fs = New System.IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
            pView.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()

            'If File.Exists(Path) Then
            '    pView.Image = Image.FromFile(Path)

        Else
            pView.Image = Nothing
        End If

        pView.SizeMode = PictureBoxSizeMode.StretchImage
        pView.Refresh()
        'Dim str As String = Trim(TextBox1.Text)
        'Dim path As String = imagePath & str & ".jpg"
        'If File.Exists(path) Then
        '    pView.Image = Image.FromFile(path)
        'Else
        '    pView.Image = Nothing
        'End If

        'pView.SizeMode = PictureBoxSizeMode.StretchImage
        'pView.Refresh()


    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Refresh_Form()
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        Refresh_Form()
    End Sub

    Private Sub DataGridView1_Layout(sender As Object, e As LayoutEventArgs) Handles DataGridView1.Layout
        Refresh_Form()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Refresh_Form()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Refresh_Form()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Controls
Public Class Coach
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCoachId As System.Windows.Forms.TextBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCoachId = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"

        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(24, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(24, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 26)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID"
        '
        'txtCoachId
        '
        Me.txtCoachId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtCoachId.Location = New System.Drawing.Point(24, 64)
        Me.txtCoachId.Name = "txtCoachId"
        Me.txtCoachId.Size = New System.Drawing.Size(56, 26)
        Me.txtCoachId.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(197, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Delete"
        '
        'dgw
        '
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.Location = New System.Drawing.Point(219, 46)
        Me.dgw.Name = "dgw"
        Me.dgw.RowTemplate.Height = 24
        Me.dgw.Size = New System.Drawing.Size(630, 395)
        Me.dgw.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(294, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Undo Delete"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(24, 315)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(152, 26)
        Me.TextBox3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Phome"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(96, 466)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 32)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "UPDATE"

        '
        'Coach
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1042, 643)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCoachId)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Coach"
        Me.Text = "New Coach"
        AddHandler Load, AddressOf Me.Coach_Load
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim ds As New DataSet()
    Dim changes As DataSet
    Dim sql As String
    Dim i As Int32
    Private Sub TariffNameCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '  ref()
        Getdata()
    End Sub
    'Sub FillCoach1()
    '    ReadyConnectionF()




    '    Try

    '        '  cmd.CommandText = "Select id,firstname,lastname, MobilePhone, Notes   from Employees"


    '        Dim cb As String = "Select id,lastname +' '+ firstname as fullname from Employees where notes NOT LIKE '%deleted%'and notes  LIKE '' or notes IS NULL ORDER BY FirstName ASC" 'coach
    '        Dim cmd = New SqlCommand(cb)
    '        cmd.Connection = conn
    '        Dim dr As SqlDataReader = cmd.ExecuteReader()

    '        ' Fill a combo box with the datareader
    '        Do While dr.Read = True
    '            '       Profile.cmbCoach.Items.Add(dr.GetString(0))
    '            Profile.cmbCoach.Items.Add(dr.GetString(1))
    '        Loop



    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub
    Private Sub ref()
        ReadyConnectionF()
        Dim daEmp As New SqlDataAdapter
        Dim cmdEmp As New SqlCommand
        cmdEmp = conn.CreateCommand
        '  dgw.DataSource = Nothing
        cmdEmp.CommandText = "Select id,firstname,lastname, MobilePhone, Notes   from Employees" 'coach
        daEmp.SelectCommand = cmdEmp
        daEmp.Fill(ds, "Employees")

        ' dgw.DataSource = ds.Tables(0)

        txtCoachId.DataBindings.Clear()
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        '  TextBox3.DataBindings.Clear()
        ' daEmp.Fill(ds, "Employees")
        'dgw.DataSource = ds.Tables(0)
        txtCoachId.DataBindings.Add("Text", ds, "Employees.ID")
        TextBox1.DataBindings.Add("Text", ds, "Employees.firstname")
        TextBox2.DataBindings.Add("Text", ds, "Employees.lastname")
        ' TextBox3.DataBindings.Add("Text", ds, "Employees.MobilePhone")

    End Sub
    Public Sub Getdata()

        ' Dim custID As Integer = CInt(txtCustid.Text)
        Try
            ReadyConnectionF()

            ' Dim cmd = New SqlCommand("Select RTRIM(Coach),free,used,regdate,id from ClipStX  where Customerid = '" & custID & "'", conn)
            '   Dim cmd = New SqlCommand("Select id,firstname,lastname, MobilePhone, Notes   from Employees", conn)
            'Dim rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            '' dgw.Rows.Clear()
            'While (rdr.Read() = True)
            '    dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
            'End While
            'rdr.Close()
            '  dgw.DataSource = Nothing
            Dim ds As New DataSet
            Dim cmdord As New SqlCommand
            cmdord = conn.CreateCommand
            Dim da As New SqlDataAdapter
            cmdord.CommandText = "Select id,firstname,lastname, MobilePhone, Notes   from Employees  "

            da.SelectCommand = cmdord            ' 

            da.Fill(ds, "Employees")
            dgw.DataSource = ds


            dgw.DataMember = "Employees"
            'Dim countRow = dgw.RowCount
            'i = dgw.CurrentRow.Index

            'If i <= countRow And i >= 0 Then



            '    'If dgw.Rows.Count > 0 Then
            '    'i = dgw.CurrentRow.Index
            '    Dim dr As DataGridViewRow = dgw.SelectedRows(i)



            '    txtCoachId.Text = dr.Cells(0).Value.ToString()

            '    TextBox1.Text = dr.Cells(1).Value.ToString()
            '    TextBox2.Text = dr.Cells(2).Value.ToString()
            '    TextBox3.Text = dr.Cells(3).Value.ToString()


            'Else
            '    Exit Sub
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub refresh_form()
        ' ref()
        ' Getdata()
        Dim j As Integer

        Dim countRow = dgw.RowCount
        j = dgw.CurrentRow.Index

        If j <= countRow And j >= 0 Then
            txtCoachId.Text = dgw.Item("id", j).Value.ToString
            TextBox1.Text = dgw.Item("Firstname", j).Value.ToString
            TextBox2.Text = dgw.Item("Lastname", j).Value.ToString
            TextBox3.Text = dgw.Item("MobilePhone", j).Value.ToString

        Else
            Exit Sub
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = True
        Dim prodID As Integer

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        ReadyConnectionF()

        Dim cmdID As New SqlCommand
        cmdID = conn.CreateCommand
        cmdID.CommandText = "Select max(id)  from Employees"

        Dim sqlResult As Object = cmdID.ExecuteScalar()
        If sqlResult Is Nothing OrElse IsDBNull(sqlResult) Then

            txtCoachId.Text = 1

        Else

            sqlResult.ToString() 'result found

            prodID = cmdID.ExecuteScalar
            txtCoachId.Text = prodID + 1
            prodID = prodID + 1

        End If


        Dim cb As String = "insert into Employees(id,FirstName,LastName,MobilePhone) VALUES (@d1,@d2,@d3,@d4)"
        Dim cmd = New SqlCommand(cb)
        cmd.Connection = conn
        cmd.Parameters.Add("@d1", Data.SqlDbType.Int).Value = prodID

        cmd.Parameters.AddWithValue("@d2", Data.SqlDbType.NVarChar).Value = TextBox1.Text
        cmd.Parameters.AddWithValue("@d3", Data.SqlDbType.NVarChar).Value = TextBox2.Text
        cmd.Parameters.AddWithValue("@d4", Data.SqlDbType.NVarChar).Value = TextBox3.Text
        cmd.ExecuteNonQuery()


        ' ref()
        Profile.cmbCoach.DataSource = Nothing
        Profile.FillCoach()

        ' ref()
        Getdata()
        MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        refresh_form()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ReadyConnectionF()
            Dim coachID As Integer = CInt(txtCoachId.Text)


            'If adminByReason("clip mark del") = True Then
            Dim cb As String = "update Employees Set notes='deleted' where Id=@d1 "
            Dim cmd = New SqlCommand(cb)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@d1", coachID)

            cmd.ExecuteReader()
            Getdata()
            '   Dim st As String = "updated clip '"
            Profile.FillCoach()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' btnSave.Enabled = False
            ' 
            '  refresh_form()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        refresh_form()
    End Sub





    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        refresh_form()
        'FillCoach()
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        refresh_form()
    End Sub

    Private Sub dgw_KeyDown(sender As Object, e As KeyEventArgs) Handles dgw.KeyDown
        refresh_form()
    End Sub

    Private Sub dgw_KeyUp(sender As Object, e As KeyEventArgs) Handles dgw.KeyUp
        refresh_form()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ReadyConnectionF()
            Dim coachID As Integer = CInt(txtCoachId.Text)


            'If adminByReason("clip mark del") = True Then
            Dim cb As String = "update Employees set notes='' where Id=@d1 "
            Dim cmd = New SqlCommand(cb)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@d1", coachID)

            cmd.ExecuteReader()
            '
            '   Dim st As String = "updated clip '"

            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' btnSave.Enabled = False
            Getdata()
            Profile.FillCoach()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        refresh_form()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmdDatabase As New SqlClient.SqlCommand
        Dim custID As Integer = CInt(txtCoachId.Text)
        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@fname", Data.SqlDbType.NVarChar).Value = TextBox1.Text
        cmdDatabase.Parameters.Add("@lname", Data.SqlDbType.NVarChar).SqlValue = TextBox2.Text
        cmdDatabase.Parameters.Add("@phone", Data.SqlDbType.VarChar).SqlValue = TextBox3.Text
        cmdDatabase.CommandText = "Update Employees set FirstName = @fname, LastName=@lname,MobilePhone=@phone   where id = '" & custID & "' "

        ExecuteNonQuery(cmdDatabase)

        Getdata()
        'dgw.Refresh()
        Profile.FillCoach()
        ' refresh_form()
        '        GetDetails()
        MsgBox("Done", MsgBoxStyle.Information, "OK")
        refresh_form()
    End Sub

    Private Sub Coach_Load(sender As Object, e As EventArgs)
        Getdata()
    End Sub


End Class

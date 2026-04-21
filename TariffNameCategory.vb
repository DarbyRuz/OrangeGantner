Imports System.Data.SqlClient
Public Class TariffNameCategory
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(216, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(464, 328)
        Me.DataGrid1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(24, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Category"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(24, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 26)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
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
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(24, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 26)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = ""
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(104, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Delete"
        '
        'TariffNameCategory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 324)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TariffNameCategory"
        Me.Text = "TariffNameCategory"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    '  Public strCon As String = frmSqlConn.BuildSqlNativeConnStr(server, database, username, password)
    ' Dim connection As New SqlClient.SqlConnection(strCon)
    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim ds As New DataSet()
    Dim changes As DataSet
    Dim sql As String
    Dim i As Int32
    Private Sub TariffNameCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        sql = "select * from Tariffs"

        Try
            ReadyConnectionF()
            adapter = New SqlDataAdapter(sql, conn)
            adapter.Fill(ds)

            DataGrid1.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub refresh_form()

        sql = "select * from Tariffs"
        Dim ds As New DataSet()
        Try
            conn.Open()
            adapter = New SqlDataAdapter(sql, connection)

            adapter.Fill(ds)
            conn.Close()
            DataGrid1.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = True
        Dim prodID As Integer

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        conn.Open()

        Dim cmdID As New SqlCommand
        cmdID = conn.CreateCommand
        cmdID.CommandText = "select max(TariffID)  from Tariffs"

        Dim sqlResult As Object = cmdID.ExecuteScalar()
        If IsDBNull(sqlResult) Then

            TextBox3.Text = 1

        Else

            sqlResult.ToString() 'result found

            prodID = cmdID.ExecuteScalar
            TextBox3.Text = prodID + 1


        End If
        conn.Close()
        Dim strInsert As String = "INSERT INTO Tariffs VALUES('" & TextBox3.Text & _
                                    "', " & "'" & TextBox1.Text & "'," & " '" & TextBox2.Text & "')"

        Dim cmdDatabase As SqlCommand = New SqlCommand(strInsert, connection)

        conn.Open()

        cmdDatabase.ExecuteNonQuery()



        conn.Close()
        refresh_form()
        If TextBox3.Text <> "" Then
            TextBox3.Text = TextBox3.Text + 1
        Else

        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 0)) Then
            TextBox3.Text = DataGrid1(DataGrid1.CurrentRowIndex, 0)

        End If
        Dim strDelete As String = "Delete from Tariffs where TariffID =  '" & TextBox3.Text & "'"

        Dim cmdDatabase As SqlCommand = New SqlCommand(strDelete, connection)

        conn.Open()

        cmdDatabase.ExecuteNonQuery()



        conn.Close()
        refresh_form()

        TextBox3.Focus()

    End Sub
End Class

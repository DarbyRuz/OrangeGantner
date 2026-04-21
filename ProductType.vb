Imports System.Data.SqlClient
Public Class Form8
    Inherits System.Windows.Forms.Form
    Dim connetionString As String
    ' Dim connection As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder
    Dim dt As DataTable
    Dim ds As New DataSet
    Dim changes As DataSet
    Dim sql As String

    Dim i As Int32
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ID"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ProductType"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(48, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 26)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(48, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 26)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = ""
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(120, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 32)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Delete"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(40, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Add"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(256, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(392, 328)
        Me.DataGrid1.TabIndex = 22
        '
        'Form8
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 350)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form8"
        Me.Text = "Product Type"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' Public strCon As String = frmSqlConn.BuildSqlNativeConnStr(server, database, username, password)
    ' Dim connection As New SqlClient.SqlConnection(strCon)
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from ProductCategory"
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

        sql = "select * from ProductCategory"
        Dim ds As New DataSet
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not IsDBNull(DataGrid1(DataGrid1.CurrentRowIndex, 0)) Then
            TextBox3.Text = DataGrid1(DataGrid1.CurrentRowIndex, 0)

        End If
        Dim strDelete As String = "Delete from ProductCategory where ID =  '" & TextBox3.Text & "'"

        Dim cmdDatabase As SqlCommand = New SqlCommand(strDelete, connection)

        conn.Open()

        cmdDatabase.ExecuteNonQuery()



        conn.Close()
        refresh_form()

        TextBox3.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim prodID As Integer

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        conn.Open()

        Dim cmdID As New SqlCommand
        cmdID = conn.CreateCommand
        cmdID.CommandText = "select max(ID)  from ProductCategory"

        Dim sqlResult As Object = cmdID.ExecuteScalar()
        If IsDBNull(sqlResult) Then

            TextBox3.Text = 1

        Else

            sqlResult.ToString() 'result found

            prodID = cmdID.ExecuteScalar
            TextBox3.Text = prodID + 1


        End If
        conn.Close()
        Dim strInsert As String = "INSERT INTO ProductCategory VALUES('" & _
                                              TextBox3.Text & "', " & "'" & TextBox1.Text & "')"


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

        TextBox1.Focus()
    End Sub

End Class

Imports System.Data.SqlClient

Public Class frmSpaProducts
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        InsertNew()
    End Sub
    Private Sub InsertNew()
        ReadyConnectionF()
        Dim CMDout As New SqlCommand("MaxIdFromTable")
        CMDout.CommandType = CommandType.StoredProcedure
        Dim retval
        CMDout.Parameters.Add("@TableName", SqlDbType.VarChar).Value = "productSPA"
        ExecuteProcedur.ExecuteCMD(CMDout)
        Dim sqlResult As Object = ExecuteScalar(CMDout)
        If IsDBNull(sqlResult) Or sqlResult Is Nothing Then
            retval = 1
        Else
            retval = Int(sqlResult.ToString()) + 1 'result found
        End If
        Dim cmd As New SqlCommand("Insert into productSPA(ID, ProductName,StandardCost,Category) VALUES(@ID, @ProductName,@StandardCost,@Category)", conn)

        cmd.Parameters.Add(New SqlParameter("@ID", retval))

        cmd.Parameters.Add(New SqlParameter("@ProductName", txtName.Text))
        cmd.Parameters.Add(New SqlParameter("@StandardCost", txtCostNew.Text))
        cmd.Parameters.Add(New SqlParameter("@Category", "SPA"))
        ExecuteNonQuery(cmd)
        refreshDisplay()
    End Sub


    Private Sub frmSpaProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyConnectionF()
        Dim dacust As New SqlDataAdapter
        Dim stringSql As String
        Dim ds As New DataSet
        stringSql = "Select * from productSpa"
        dacust = New SqlDataAdapter(stringSql, conn)
        dacust.Fill(ds, "Product")


        With ComboBox1
            .DisplayMember = "Product.ProductName"
            .ValueMember = "ID"
            .DataSource = ds

        End With

        txtID.DataBindings.Add("Text", ds, "Product.id")
        txtCost.DataBindings.Add("Text", ds, "Product.StandardCost")
    End Sub

    Sub refreshDisplay()
        ReadyConnectionF()
        Dim dacust As New SqlDataAdapter
        Dim stringSql As String
        Dim ds As New DataSet
        stringSql = "Select * from productSpa"
        dacust = New SqlDataAdapter(stringSql, conn)
        dacust.Fill(ds, "Product")


        With ComboBox1
            .DisplayMember = "Product.ProductName"
            .ValueMember = "ID"
            .DataSource = ds

        End With

        '  txtID.DataBindings.Add("Text", ds, "Product.id")
        ' txtCost.DataBindings.Add("Text", ds, "Product.StandardCost")
    End Sub
    Sub upd()
        Dim id As Integer = txtID.Text
        Dim cmd As New SqlClient.SqlCommand
        cmd = conn.CreateCommand
        cmd.Parameters.Add("@ID", Data.SqlDbType.Int).Value = id
        cmd.Parameters.Add("@ProductName", Data.SqlDbType.VarChar).Value = ComboBox1.Text
        cmd.Parameters.Add("@StandardCost", Data.SqlDbType.Decimal).Value = Int(txtCost.Text)
        cmd.CommandText = "Update productSpa set ProductName =  @ProductName,StandardCost=@StandardCost  where id = '" & id & "' "
        ReadyConnectionF()
        ExecuteNonQuery(cmd)
        refreshDisplay()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        upd()
    End Sub
End Class
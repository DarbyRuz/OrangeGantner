Imports System.Data.SqlClient
Public Class frmHDMsettings
    Private Sub frmHDMsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd1 As New SqlCommand
        Dim da1 As New SqlDataAdapter
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        ReadyConnectionF()
        cmd1 = conn.CreateCommand
        cmd1.CommandText = "select * from HdmSettings"
        da1.SelectCommand = cmd1
        da1.Fill(ds, "HdmSettings")
        With cmbHDM
            .DisplayMember = "HdmSettings.hdmUser"
            .ValueMember = "hdmUser"
            .DataSource = ds
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With
        hdmIp.DataBindings.Add("Text", ds, "HdmSettings.hdmIp")
        hdmPort.DataBindings.Add("Text", ds, "HdmSettings.hdmPort")
        hdmPassword.DataBindings.Add("Text", ds, "HdmSettings.hdmPassword")

        hdmOperatorID.DataBindings.Add("Text", ds, "HdmSettings.hdmOperatorID")
        hdmOperatorPass.DataBindings.Add("Text", ds, "HdmSettings.hdmOperatorPass")
    End Sub

    Private Sub updPort_Click(sender As Object, e As EventArgs) Handles updPort.Click
        Dim Hdm = cmbHDM.Text
        Dim cmdDatabase As New SqlClient.SqlCommand

        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@Var", Data.SqlDbType.VarChar).Value = hdmPort.Text 'keynumber

        cmdDatabase.CommandText = "Update HdmSettings set hdmPort =  @Var  where hdmUser =  '" & Hdm & " '"

        ExecuteNonQuery(cmdDatabase)


        MsgBox("Done", MsgBoxStyle.Information, "OK")
    End Sub

    Private Sub UpdIP_Click(sender As Object, e As EventArgs) Handles UpdIP.Click
        Dim Hdm = cmbHDM.Text
        Dim cmdDatabase As New SqlClient.SqlCommand

        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@Var", Data.SqlDbType.VarChar).Value = hdmIp.Text 'keynumber

        cmdDatabase.CommandText = "Update HdmSettings set hdmIP =  @Var  where hdmUser =  '" & Hdm & " '"

        ExecuteNonQuery(cmdDatabase)


        MsgBox("Done", MsgBoxStyle.Information, "OK")
    End Sub

    Private Sub UpdPas_Click(sender As Object, e As EventArgs) Handles UpdPas.Click
        Dim Hdm = cmbHDM.Text
        Dim cmdDatabase As New SqlClient.SqlCommand

        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@Var", Data.SqlDbType.VarChar).Value = hdmPassword.Text 'keynumber

        cmdDatabase.CommandText = "Update HdmSettings set hdmPassword =  @Var  where hdmUser =  '" & Hdm & " '"

        ExecuteNonQuery(cmdDatabase)


        MsgBox("Done", MsgBoxStyle.Information, "OK")
    End Sub

    Private Sub updOperatorID_Click(sender As Object, e As EventArgs) Handles updOperatorID.Click
        Dim Hdm = cmbHDM.Text
        Dim cmdDatabase As New SqlClient.SqlCommand

        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@Var", Data.SqlDbType.VarChar).Value = hdmOperatorID.Text 'keynumber

        cmdDatabase.CommandText = "Update HdmSettings set hdmOperatorID =  @Var  where hdmUser =  '" & Hdm & " '"

        ExecuteNonQuery(cmdDatabase)


        MsgBox("Done", MsgBoxStyle.Information, "OK")
    End Sub

    Private Sub updOperatorPass_Click(sender As Object, e As EventArgs) Handles updOperatorPass.Click
        Dim Hdm = cmbHDM.Text
        Dim cmdDatabase As New SqlClient.SqlCommand

        cmdDatabase = conn.CreateCommand

        cmdDatabase.Parameters.Add("@Var", Data.SqlDbType.VarChar).Value = hdmOperatorPass.Text 'keynumber

        cmdDatabase.CommandText = "Update HdmSettings set hdmOperatorPass =  @Var  where hdmUser =  '" & Hdm & " '"

        ExecuteNonQuery(cmdDatabase)


        MsgBox("Done", MsgBoxStyle.Information, "OK")
    End Sub
End Class
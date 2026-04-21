Imports System.Data.SqlClient


Public Module HdmClass
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
    Public PaymentBase As String

    Public PaidAmount As Double
    Public PaidAmountCard As Double
    Public prePaymentAmount As Double
    Public partialAmount As Double
    Public mode As Integer
    Public OpenSaleDocument(mode) As Boolean
    Public NewItem As Boolean
    Public HDMfr As Object

    Public Function GetHdmItemsByID(id As Integer) As HDMitems
        Dim res As HDMitems = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select id,ProductCode,ProductName,ADG,Unitype,NDS,dep,Category1  From ProductHDM where Id= '") & id) + " ' ", conn)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New HDMitems()
            r.Read()
            res.Id = Convert.ToInt32(r.GetInt32(0).ToString())
            res.ProductCode = r.GetString(1)
            res.ProductName = r.GetString(2)
            res.ADG = r.GetString(3)
            res.UnitType = r.GetString(4)
            res.NDS = r.GetString(5)
            res.dep = Convert.ToInt32(r.GetInt32(6).ToString())
            res.Category1 = r.GetString(7)
        End If
        r.Close()
        '  End Using
        Return res
    End Function
    Public Function GetHdmsettingsByID(id As Integer) As HDMSettings
        Dim res As HDMSettings = Nothing

        ReadyConnectionF()
        Dim cmd As New SqlCommand((Convert.ToString("Select *  From hdmSettings where hdmId= '") & id) + " ' ", conn)
        Dim r = cmd.ExecuteReader()

        If r.HasRows Then
            res = New HDMSettings()
            r.Read()
            res.hdmId = Convert.ToInt32(r.GetInt32(0).ToString())
            res.hdmIP = r.GetString(1)
            res.hdmPort = Convert.ToInt32(r.GetInt32(2).ToString())
            res.hdmPassword = r.GetString(3)
            res.hdmOperatorId = Convert.ToInt32(r.GetInt32(4).ToString())
            res.hdmOperatorPass = r.GetString(5)
        End If
        r.Close()
        '  End Using
        Return res
    End Function
    Public Sub insertHdmCheckNew(PaidAmount As Decimal, prodName As String, PaymentMethode As String, hdmId As Integer, dep As Integer)
        Dim CMD As New SqlCommand("InsertHdmNew")

        CMD.Parameters.Add("@paidDate", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
        CMD.Parameters.Add("@PaidAmount ", Data.SqlDbType.Decimal).Value = PaidAmount
        CMD.Parameters.Add("@prodName", Data.SqlDbType.NVarChar).Value = prodName
        CMD.Parameters.Add("@payMethode", Data.SqlDbType.NChar).Value = PaymentMethode
        CMD.Parameters.Add("@hdmId", Data.SqlDbType.Int).Value = hdmId
        CMD.Parameters.Add("@dep", Data.SqlDbType.Int).Value = dep
        ExecuteProcedur.ExecuteCMD(CMD)

    End Sub
    Public Sub insertHdmCheck(PaidAmount As Decimal, prodName As String, PaymentMethode As String, hdmId As Integer, dep As Integer)
        Dim CMD As New SqlCommand("InsertHdm")

        CMD.Parameters.Add("@paidDate", Data.SqlDbType.DateTime).Value = DateTime.Now 'na forme
        CMD.Parameters.Add("@PaidAmount ", Data.SqlDbType.Decimal).Value = PaidAmount
        CMD.Parameters.Add("@prodName", Data.SqlDbType.NVarChar).Value = prodName
        CMD.Parameters.Add("@payMethode", Data.SqlDbType.NChar).Value = PaymentMethode
        CMD.Parameters.Add("@hdmId", Data.SqlDbType.Int).Value = hdmId
        CMD.Parameters.Add("@dep", Data.SqlDbType.Int).Value = dep
        ExecuteProcedur.ExecuteCMD(CMD)

    End Sub
    Public Sub connectToHDM(id As Integer)
        Dim con As Boolean
        HDMfr = CreateObject("HDMPrint.FR")
        Dim hdmId As Integer = id
        HDMfr.IP = GetHdmsettingsByID(hdmId).hdmIP
        HDMfr.Port = GetHdmsettingsByID(hdmId).hdmPort
        HDMfr.OperatorID = GetHdmsettingsByID(hdmId).hdmOperatorId
        HDMfr.OperatorPassword = GetHdmsettingsByID(hdmId).hdmOperatorPass
        HDMfr.FRPassword = GetHdmsettingsByID(hdmId).hdmPassword
        HDMfr.ArmenianEncoding = 1
        con = HDMfr.ConnectionCheck()

        'If con = True Then
        '    MsgBox("Connected!", MsgBoxStyle.OkOnly, "Message :")
        '    ' Label6.Text = "Connected!"
        'Else
        '    MsgBox("No connection!", MsgBoxStyle.OkOnly, "Message :")
        '    ' MsgBox(HDM.ErrCode & HDM.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
        '    ' Label6.Text = "No Connection!"
        'End If

    End Sub


    Public Sub hdmPOSDepositGat(id As Integer, nameProd As String, Paidamount As Decimal)


        HDMfr.OpenSaleDocument(3)
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            check = HDMfr.PrintDocument(0, Paidamount)
            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(Paidamount, nameProd, PaymentMethode:="POS", hdmId:=0, dep:=16)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
            End If
        End If
    End Sub
    Public Sub hdmCashDepositGat(id As Integer, nameProd As String, Paidamount As Decimal)


        HDMfr.OpenSaleDocument(3)
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            check = HDMfr.PrintDocument(Paidamount, 0)
            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(Paidamount, nameProd, PaymentMethode:="Cash", hdmId:=0, dep:=16)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
            End If
        End If
    End Sub

    Public Sub hdmPrintCheckByProd(idProd As Integer, cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double)

        ' hdmId = CInt(ComboBox2.SelectedValue)
        Dim item As Boolean
        dep = GetHdmItemsByID(idProd).dep
        nameProd = GetHdmItemsByID(idProd).ProductName
        codeProd = GetHdmItemsByID(idProd).ProductCode
        unit = GetHdmItemsByID(idProd).UnitType
        adgCode = GetHdmItemsByID(idProd).ADG
        discount = 0
        Totalprice = price
        qty1 = 1

        HDMfr.OpenSaleDocument(2)
        item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
        Dim PaymentMethode As String

        PaymentMethode = paymethode


        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(PaidAmount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")

            End If
        End If
    End Sub

    Public Sub hdmPrintCheckFreezCash(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double)

        ' hdmId = CInt(ComboBox2.SelectedValue)
        Dim item As Boolean
        Dim idProd As Integer
        '  hdmSettings()
        idProd = 235
        dep = GetHdmItemsByID(idProd).dep
        nameProd = GetHdmItemsByID(idProd).ProductName
        codeProd = GetHdmItemsByID(idProd).ProductCode
        unit = GetHdmItemsByID(idProd).UnitType
        adgCode = GetHdmItemsByID(idProd).ADG
        '  dep = 9
        discount = 0
        Totalprice = price
        '  nameProd = "Քարտի սառեցում"
        qty1 = 1
        'unit = "15 օր"
        'adgCode = "93.13" ' amountCash.Text = cash - cash * discount / 100
        ' Totalpric93.13e = Math.Round(CDec(Val(amountCash.Text)))
        ' Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
        HDMfr.OpenSaleDocument(2)
        item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
        Dim PaymentMethode As String
        '  HDM.PrintDocument(cashAmount, posamount)
        PaymentMethode = paymethode

        'HDM.PrintDocument(0, Totalprice)
        '    PaymentMethode = "POS"
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(cashAmount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                ' Console.Write("Not")
            End If
        End If






    End Sub
    Public Sub hdmPrintCheckFreezPOS(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double)

        ' hdmId = CInt(ComboBox2.SelectedValue)
        Dim item As Boolean
        Dim idProd As Integer
        '  hdmSettings()
        idProd = 235
        dep = 14
        ' dep = GetHdmItemsByID(idProd).dep
        nameProd = GetHdmItemsByID(idProd).ProductName
        codeProd = GetHdmItemsByID(idProd).ProductCode
        unit = GetHdmItemsByID(idProd).UnitType
        adgCode = GetHdmItemsByID(idProd).ADG
        '  dep = 9
        discount = 0
        Totalprice = price
        '  nameProd = "Քարտի սառեցում"
        qty1 = 1
        'unit = "15 օր"
        'adgCode = "93.13" ' amountCash.Text = cash - cash * discount / 100
        ' Totalpric93.13e = Math.Round(CDec(Val(amountCash.Text)))
        ' Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
        HDMfr.OpenSaleDocument(2)
        item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
        Dim PaymentMethode As String
        '  HDM.PrintDocument(cashAmount, posamount)
        PaymentMethode = paymethode

        'HDM.PrintDocument(0, Totalprice)
        '    PaymentMethode = "POS"
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(posamount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                ' Console.Write("Not")
            End If
        End If






    End Sub
    Public Sub hdmPrintCheckFreezFromDeposit(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double)
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            ' hdmId = CInt(ComboBox2.SelectedValue)
            Dim item As Boolean
            Dim idProd As Integer
            '  hdmSettings()
            idProd = 235
            dep = GetHdmItemsByID(idProd).dep
            nameProd = GetHdmItemsByID(idProd).ProductName
            codeProd = GetHdmItemsByID(idProd).ProductCode
            unit = GetHdmItemsByID(idProd).UnitType
            adgCode = GetHdmItemsByID(idProd).ADG
            '  dep = 9
            discount = 0
            Totalprice = price
            '  nameProd = "Քարտի սառեցում"
            qty1 = 1
            'unit = "15 օր"
            'adgCode = "93.13" ' amountCash.Text = cash - cash * discount / 100
            ' Totalpric93.13e = Math.Round(CDec(Val(amountCash.Text)))
            ' Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
            HDMfr.OpenSaleDocument(2)
            item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
            Dim PaymentMethode As String
            '  HDM.PrintDocument(cashAmount, posamount)
            PaymentMethode = paymethode

            'HDM.PrintDocument(0, Totalprice)
            '    PaymentMethode = "POS"
            Dim check As Boolean

            ' check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash
            check = HDMfr.PrintDocument(0, 0, 0, cashAmount) 'prePaymentAmount
            PaymentMethode = "PrepUsage"
            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(cashAmount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                ' Console.Write("Not")
            End If
        End If






    End Sub
    Public Sub hdmPrintCheckClipCash(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double, clipProduct As Integer)

        ' hdmId = CInt(ComboBox2.SelectedValue)
        Dim item As Boolean
        Dim idProd As Integer
        '  hdmSettings()
        If clipProduct = 1 Then
            idProd = 210
        Else
            idProd = 216
        End If
        'producthdm
        Dim HDMitems = GetHdmItemsByID(idProd)
        dep = HDMitems.dep
        nameProd = HDMitems.ProductName
        codeProd = HDMitems.ProductCode
        unit = HDMitems.UnitType
        adgCode = HDMitems.ADG
        '  dep = 9
        discount = 0
        Totalprice = price
        '  nameProd = "Քարտի սառեցում"
        qty1 = 1
        'unit = "15 օր"
        'adgCode = "93.13" ' amountCash.Text = cash - cash * discount / 100
        ' Totalpric93.13e = Math.Round(CDec(Val(amountCash.Text)))
        ' Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
        HDMfr.OpenSaleDocument(2)
        item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
        Dim PaymentMethode As String
        '  HDM.PrintDocument(cashAmount, posamount)
        PaymentMethode = paymethode

        'HDM.PrintDocument(0, Totalprice)
        '    PaymentMethode = "POS"
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(cashAmount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                ' Console.Write("Not")
            End If
        End If






    End Sub
    Public Sub hdmPrintCheckClipPOS(cashAmount As Decimal, posamount As Decimal, paymethode As String, hdmId As Integer, price As Double, clipProduct As Integer)

        ' hdmId = CInt(ComboBox2.SelectedValue)
        Dim item As Boolean
        Dim idProd As Integer
        '  hdmSettings()
        If clipProduct = 1 Then
            idProd = 210
        Else
            idProd = 216
        End If
        dep = 14
        Dim HDMitems = GetHdmItemsByID(idProd)
        ' dep = GetHdmItemsByID(idProd).dep
        nameProd = HDMitems.ProductName
        codeProd = HDMitems.ProductCode
        unit = HDMitems.UnitType
        adgCode = HDMitems.ADG
        '  dep = 9
        discount = 0
        Totalprice = price
        '  nameProd = "Քարտի սառեցում"
        qty1 = 1
        'unit = "15 օր"
        'adgCode = "93.13" ' amountCash.Text = cash - cash * discount / 100
        ' Totalpric93.13e = Math.Round(CDec(Val(amountCash.Text)))
        ' Totalprice = Math.Round(CDec(Val(amountDisc.Text)))
        HDMfr.OpenSaleDocument(2)
        item = HDMfr.NewItem(dep, qty1, discount, price, nameProd, codeProd, unit, adgCode, Totalprice, 1) 'OK
        Dim PaymentMethode As String
        '  HDM.PrintDocument(cashAmount, posamount)
        PaymentMethode = paymethode

        'HDM.PrintDocument(0, Totalprice)
        '    PaymentMethode = "POS"
        Dim check As Boolean
        If MsgBox("Are you sure to print check? ", MsgBoxStyle.OkCancel, "Input confirm") = MsgBoxResult.Cancel Then

            Exit Sub
        Else
            check = HDMfr.PrintDocument(cashAmount, posamount) 'ok cash

            If check = True Then
                MsgBox("ok print", MsgBoxStyle.OkOnly, "Message :")
                insertHdmCheck(posamount, nameProd, PaymentMethode, hdmId, dep)
            Else
                MsgBox("print error", MsgBoxStyle.OkOnly, "Message :")
                MsgBox(HDMfr.ErrCode & HDMfr.ErrDescription, MsgBoxStyle.OkOnly, "Message :")
                ' Console.Write("Not")
            End If
        End If






    End Sub
    Public Sub connectToHDM(combo As ComboBox)
        Dim cmdHdm As New SqlCommand
        Dim daHdm As New SqlDataAdapter

        Dim ds1 As New DataSet
        ReadyConnectionF()
        cmdHdm = conn.CreateCommand
        cmdHdm.CommandText = "select * from HdmSettings"
        daHdm.SelectCommand = cmdHdm
        daHdm.Fill(ds1, "HdmSettings")
        With combo
            .DisplayMember = "HdmSettings.hdmId"
            .ValueMember = "hdmId"
            .DataSource = ds1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems

        End With

        Dim hdmId As Integer = combo.SelectedValue
        connectToHDM(hdmId)

    End Sub
End Module

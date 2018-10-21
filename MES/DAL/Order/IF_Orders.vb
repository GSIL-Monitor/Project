
Imports Common.ConvertData
Imports Common.DataBase

Namespace Order

    ''' <summary>
    ''' IF_ORDERS 数据层
    ''' </summary>
    ''' <remarks></remarks>

    Public Class IF_ORDERS
        Dim str As String
        Public Shared Function Create() As IF_ORDERS
            Return New IF_ORDERS
        End Function

        Public Sub ClearData(Optional ByVal cmd As System.Data.Common.DbCommand = Nothing)
            str = " delete from IF_ORDERS "
            ExecCmd(str, cmd)
        End Sub

        Public Sub Delete(ByVal IF_ID As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing)

            str = " Delete From IF_ORDERS Where IF_ID= '" & IF_ID & "'"
            ExecCmd(str, cmd)

        End Sub

        Public Sub Insert(ByVal mdl As Model.Order.IF_ORDERS, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing)

            str = "Select count(*) from IF_ORDERS where IF_ID= '" & mdl.Nuke.A01_IF_ID & "'"
            If todbl(ExecCmd(str, cmd)) <> 0 Then
                Throw New Exception(mdl.Nuke.A01_IF_ID & " 已经存在!")
            End If

            str = "Insert INTO IF_ORDERS"
            str &= " 　(IF_FROMSYSTEM,IF_TOSYSTEM,IF_FLAG,IF_WRITEDATE,IF_READDATE,IF_ERRORLOG,IF_INTERFACELOGID,MOCODE,MOTYPE,ITEMCODE,ITEMNAME,PLANQTY,UNIT,SDATE,EDATE,SALEORDER,THICK,WIDTH,LENGTH,DIAMETER,MTYPE,SWEIGHT,SWEIGHT_UNIT,STEPCODE,THICK_U,THICK_D,WIDTH_U,WIDTH_D,LENGTH_U,LENGTH_D,DIAMETER_D,DIAMETER_U,MODELCODE,LOSSTYPE,IS_HT,IS_CT,HARDNESS,ANGLE,CUSNAME,SALEPERSON,MAKER,DWEIGHT_TYPE,HWEIGHT_TYPE,SIP,MEMO,RECEIPTPERSON,RECEIPTTIME,CITYNAME,IROWS,MI_ID,cWORKCondition,cWorkCode,CINVCODE)"
            str &= " VALUES( "
            str &= "'" & mdl.Nuke.A02_IF_FROMSYSTEM & "',"
            str &= "'" & mdl.Nuke.A03_IF_TOSYSTEM & "',"
            str &= "'" & mdl.Nuke.A04_IF_FLAG & "',"
            str &= GetDate(mdl.Nuke.A05_IF_WRITEDATE) & ","
            str &= GetDate(mdl.Nuke.A06_IF_READDATE) & ","
            str &= "'" & mdl.Nuke.A07_IF_ERRORLOG & "',"
            str &= "'" & mdl.Nuke.A08_IF_INTERFACELOGID & "',"
            str &= "'" & mdl.Nuke.A09_MOCODE & "',"
            str &= "'" & mdl.Nuke.A10_MOTYPE & "',"
            str &= "'" & mdl.Nuke.A11_ITEMCODE & "',"
            str &= "'" & mdl.Nuke.A12_ITEMNAME & "',"
            str &= "'" & mdl.Nuke.A13_PLANQTY & "',"
            str &= "'" & mdl.Nuke.A14_UNIT & "',"
            str &= GetDate(mdl.Nuke.A15_SDATE) & ","
            str &= GetDate(mdl.Nuke.A16_EDATE) & ","
            str &= "'" & mdl.Nuke.A17_SALEORDER & "',"
            str &= "'" & mdl.Nuke.A18_THICK & "',"
            str &= "'" & mdl.Nuke.A19_WIDTH & "',"
            str &= "'" & mdl.Nuke.A20_LENGTH & "',"
            str &= "'" & mdl.Nuke.A21_DIAMETER & "',"
            str &= "'" & mdl.Nuke.A22_MTYPE & "',"
            str &= "'" & mdl.Nuke.A23_SWEIGHT & "',"
            str &= "'" & mdl.Nuke.A24_SWEIGHT_UNIT & "',"
            str &= "'" & mdl.Nuke.A25_STEPCODE & "',"
            str &= "'" & mdl.Nuke.A26_THICK_U & "',"
            str &= "'" & mdl.Nuke.A27_THICK_D & "',"
            str &= "'" & mdl.Nuke.A28_WIDTH_U & "',"
            str &= "'" & mdl.Nuke.A29_WIDTH_D & "',"
            str &= "'" & mdl.Nuke.A30_LENGTH_U & "',"
            str &= "'" & mdl.Nuke.A31_LENGTH_D & "',"
            str &= "'" & mdl.Nuke.A32_DIAMETER_D & "',"
            str &= "'" & mdl.Nuke.A33_DIAMETER_U & "',"
            str &= "'" & mdl.Nuke.A34_MODELCODE & "',"
            str &= "'" & mdl.Nuke.A35_LOSSTYPE & "',"
            str &= GetBoolean(mdl.Nuke.A36_IS_HT) & ","
            str &= GetBoolean(mdl.Nuke.A37_IS_CT) & ","
            str &= "'" & mdl.Nuke.A38_HARDNESS & "',"
            str &= "'" & mdl.Nuke.A39_ANGLE & "',"
            str &= "'" & mdl.Nuke.A40_CUSNAME & "',"
            str &= "'" & mdl.Nuke.A41_SALEPERSON & "',"
            str &= "'" & mdl.Nuke.A42_MAKER & "',"
            str &= "'" & mdl.Nuke.A43_DWEIGHT_TYPE & "',"
            str &= "'" & mdl.Nuke.A44_HWEIGHT_TYPE & "',"
            str &= "'" & mdl.Nuke.A45_SIP & "',"
            str &= "'" & mdl.Nuke.A46_MEMO & "',"
            str &= "'" & mdl.Nuke.A47_RECEIPTPERSON & "',"
            str &= GetDate(mdl.Nuke.A48_RECEIPTTIME) & ","
            str &= "'" & mdl.Nuke.A49_CITYNAME & "',"
            str &= "'" & mdl.Nuke.A50_IROWS & "',"
            str &= "'" & mdl.Nuke.A51_MI_ID & "',"
            str &= "'" & mdl.Nuke.A52_cWORKCondition & "',"
            str &= "'" & mdl.Nuke.A53_cWorkCode & "',"
            str &= "'" & mdl.Nuke.A54_CINVCODE & "'"
            str &= " )"
            ExecCmd(str, cmd)
        End Sub

        Public Sub Update(ByVal mdl As Model.Order.IF_ORDERS, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing)

            str = "Update IF_ORDERS"
            str &= " SET  "
            str &= " IF_FROMSYSTEM=  '" & mdl.Nuke.A02_IF_FROMSYSTEM & "',"
            str &= " IF_TOSYSTEM=  '" & mdl.Nuke.A03_IF_TOSYSTEM & "',"
            str &= " IF_FLAG=  '" & mdl.Nuke.A04_IF_FLAG & "',"
            str &= " IF_WRITEDATE=  '" & mdl.Nuke.A05_IF_WRITEDATE & "',"
            str &= " IF_READDATE=  '" & mdl.Nuke.A06_IF_READDATE & "',"
            str &= " IF_ERRORLOG=  '" & mdl.Nuke.A07_IF_ERRORLOG & "',"
            str &= " IF_INTERFACELOGID=  '" & mdl.Nuke.A08_IF_INTERFACELOGID & "',"
            str &= " MOCODE=  '" & mdl.Nuke.A09_MOCODE & "',"
            str &= " MOTYPE=  '" & mdl.Nuke.A10_MOTYPE & "',"
            str &= " ITEMCODE=  '" & mdl.Nuke.A11_ITEMCODE & "',"
            str &= " ITEMNAME=  '" & mdl.Nuke.A12_ITEMNAME & "',"
            str &= " PLANQTY=  '" & mdl.Nuke.A13_PLANQTY & "',"
            str &= " UNIT=  '" & mdl.Nuke.A14_UNIT & "',"
            str &= " SDATE=  '" & mdl.Nuke.A15_SDATE & "',"
            str &= " EDATE=  '" & mdl.Nuke.A16_EDATE & "',"
            str &= " SALEORDER=  '" & mdl.Nuke.A17_SALEORDER & "',"
            str &= " THICK=  '" & mdl.Nuke.A18_THICK & "',"
            str &= " WIDTH=  '" & mdl.Nuke.A19_WIDTH & "',"
            str &= " LENGTH=  '" & mdl.Nuke.A20_LENGTH & "',"
            str &= " DIAMETER=  '" & mdl.Nuke.A21_DIAMETER & "',"
            str &= " MTYPE=  '" & mdl.Nuke.A22_MTYPE & "',"
            str &= " SWEIGHT=  '" & mdl.Nuke.A23_SWEIGHT & "',"
            str &= " SWEIGHT_UNIT=  '" & mdl.Nuke.A24_SWEIGHT_UNIT & "',"
            str &= " STEPCODE=  '" & mdl.Nuke.A25_STEPCODE & "',"
            str &= " THICK_U=  '" & mdl.Nuke.A26_THICK_U & "',"
            str &= " THICK_D=  '" & mdl.Nuke.A27_THICK_D & "',"
            str &= " WIDTH_U=  '" & mdl.Nuke.A28_WIDTH_U & "',"
            str &= " WIDTH_D=  '" & mdl.Nuke.A29_WIDTH_D & "',"
            str &= " LENGTH_U=  '" & mdl.Nuke.A30_LENGTH_U & "',"
            str &= " LENGTH_D=  '" & mdl.Nuke.A31_LENGTH_D & "',"
            str &= " DIAMETER_D=  '" & mdl.Nuke.A32_DIAMETER_D & "',"
            str &= " DIAMETER_U=  '" & mdl.Nuke.A33_DIAMETER_U & "',"
            str &= " MODELCODE=  '" & mdl.Nuke.A34_MODELCODE & "',"
            str &= " LOSSTYPE=  '" & mdl.Nuke.A35_LOSSTYPE & "',"
            str &= " IS_HT=  '" & mdl.Nuke.A36_IS_HT & "',"
            str &= " IS_CT=  '" & mdl.Nuke.A37_IS_CT & "',"
            str &= " HARDNESS=  '" & mdl.Nuke.A38_HARDNESS & "',"
            str &= " ANGLE=  '" & mdl.Nuke.A39_ANGLE & "',"
            str &= " CUSNAME=  '" & mdl.Nuke.A40_CUSNAME & "',"
            str &= " SALEPERSON=  '" & mdl.Nuke.A41_SALEPERSON & "',"
            str &= " MAKER=  '" & mdl.Nuke.A42_MAKER & "',"
            str &= " DWEIGHT_TYPE=  '" & mdl.Nuke.A43_DWEIGHT_TYPE & "',"
            str &= " HWEIGHT_TYPE=  '" & mdl.Nuke.A44_HWEIGHT_TYPE & "',"
            str &= " SIP=  '" & mdl.Nuke.A45_SIP & "',"
            str &= " MEMO=  '" & mdl.Nuke.A46_MEMO & "',"
            str &= " RECEIPTPERSON=  '" & mdl.Nuke.A47_RECEIPTPERSON & "',"
            str &= " RECEIPTTIME=  '" & mdl.Nuke.A48_RECEIPTTIME & "',"
            str &= " CITYNAME=  '" & mdl.Nuke.A49_CITYNAME & "',"
            str &= " IROWS=  '" & mdl.Nuke.A50_IROWS & "',"
            str &= " MI_ID=  '" & mdl.Nuke.A51_MI_ID & "',"
            str &= " cWORKCondition=  '" & mdl.Nuke.A52_cWORKCondition & "',"
            str &= " cWorkCode=  '" & mdl.Nuke.A53_cWorkCode & "',"
            str &= " CINVCODE=  '" & mdl.Nuke.A54_CINVCODE & "'"
            str &= " where IF_ID=  '" & mdl.Nuke.A01_IF_ID & "'"
            ExecCmd(str, cmd)
        End Sub

        Public Function Query(Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection
            Return myQuery(, cmd)
        End Function

        Public Function Query_byFiliter(ByVal Filiter As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection
            Return myQuery(Filiter, cmd)
        End Function

        Public Function Query(ByVal IF_ID As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERS
            Dim Filiter As String = " AND IF_ID='" & IF_ID & "'"
            Dim mdls As Model.Order.IF_ORDERSCollection = myQuery(Filiter, cmd)
            If mdls.Count <> 0 Then
                Return mdls(0)
            End If
        End Function

        Public Function Query_byIF_ID(ByVal IF_ID As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection
            Return myQuery(" AND IF_ID='" & IF_ID & "'", cmd)
        End Function


        Public Function Querylimit(ByVal nCount As Integer, ByVal Filiter As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection
            Return myQuerylimit(nCount, Filiter, cmd)
        End Function

        Public Function Query_BySingle(ByVal Filiter As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERS
            Dim mdls As Model.Order.IF_ORDERSCollection = myQuery(Filiter, cmd)
            If mdls.Count <> 0 Then
                Return mdls(0)
            End If
        End Function

        Private Function myQuery(Optional ByVal Filiter As String = "", Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection

            str = "SELECT IF_ID,IF_FROMSYSTEM,IF_TOSYSTEM,IF_FLAG,IF_WRITEDATE,IF_READDATE,IF_ERRORLOG,IF_INTERFACELOGID,MOCODE,MOTYPE,ITEMCODE,ITEMNAME,PLANQTY,UNIT,SDATE,EDATE,SALEORDER,THICK,WIDTH,LENGTH,DIAMETER,MTYPE,SWEIGHT,SWEIGHT_UNIT,STEPCODE,THICK_U,THICK_D,WIDTH_U,WIDTH_D,LENGTH_U,LENGTH_D,DIAMETER_D,DIAMETER_U,MODELCODE,LOSSTYPE,IS_HT,IS_CT,HARDNESS,ANGLE,CUSNAME,SALEPERSON,MAKER,DWEIGHT_TYPE,HWEIGHT_TYPE,SIP,MEMO,RECEIPTPERSON,RECEIPTTIME,CITYNAME,IROWS,MI_ID,cWORKCondition,cWorkCode,CINVCODE"
            str &= "  FROM  IF_ORDERS"
            str &= " WHERE 1=1 "
            If Filiter <> "" Then
                str &= Filiter
            End If
            str &= " ORDER BY IF_ID  "
            Dim dt As DataTable = GetDataTable(str, cmd)
            Dim mdls As New Model.Order.IF_ORDERSCollection
            For Each dr As DataRow In dt.Rows
                Dim mdl As New Model.Order.IF_ORDERS
                mdl.A01_IF_ID = todbl(dr.Item("IF_ID"))
                mdl.A02_IF_FROMSYSTEM = toStr(dr.Item("IF_FROMSYSTEM"))
                mdl.A03_IF_TOSYSTEM = toStr(dr.Item("IF_TOSYSTEM"))
                mdl.A04_IF_FLAG = toStr(dr.Item("IF_FLAG"))
                mdl.A05_IF_WRITEDATE = IIf(toStr(dr.Item("IF_WRITEDATE")) = "", Nothing, dr.Item("IF_WRITEDATE"))
                mdl.A06_IF_READDATE = IIf(toStr(dr.Item("IF_READDATE")) = "", Nothing, dr.Item("IF_READDATE"))
                mdl.A07_IF_ERRORLOG = toStr(dr.Item("IF_ERRORLOG"))
                mdl.A08_IF_INTERFACELOGID = toStr(dr.Item("IF_INTERFACELOGID"))
                mdl.A09_MOCODE = toStr(dr.Item("MOCODE"))
                mdl.A10_MOTYPE = toStr(dr.Item("MOTYPE"))
                mdl.A11_ITEMCODE = toStr(dr.Item("ITEMCODE"))
                mdl.A12_ITEMNAME = toStr(dr.Item("ITEMNAME"))
                mdl.A13_PLANQTY = todbl(dr.Item("PLANQTY"))
                mdl.A14_UNIT = toStr(dr.Item("UNIT"))
                mdl.A15_SDATE = IIf(toStr(dr.Item("SDATE")) = "", Nothing, dr.Item("SDATE"))
                mdl.A16_EDATE = IIf(toStr(dr.Item("EDATE")) = "", Nothing, dr.Item("EDATE"))
                mdl.A17_SALEORDER = toStr(dr.Item("SALEORDER"))
                mdl.A18_THICK = toStr(dr.Item("THICK"))
                mdl.A19_WIDTH = toStr(dr.Item("WIDTH"))
                mdl.A20_LENGTH = toStr(dr.Item("LENGTH"))
                mdl.A21_DIAMETER = toStr(dr.Item("DIAMETER"))
                mdl.A22_MTYPE = toStr(dr.Item("MTYPE"))
                mdl.A23_SWEIGHT = todbl(dr.Item("SWEIGHT"))
                mdl.A24_SWEIGHT_UNIT = toStr(dr.Item("SWEIGHT_UNIT"))
                mdl.A25_STEPCODE = toStr(dr.Item("STEPCODE"))
                mdl.A26_THICK_U = toStr(dr.Item("THICK_U"))
                mdl.A27_THICK_D = toStr(dr.Item("THICK_D"))
                mdl.A28_WIDTH_U = toStr(dr.Item("WIDTH_U"))
                mdl.A29_WIDTH_D = toStr(dr.Item("WIDTH_D"))
                mdl.A30_LENGTH_U = toStr(dr.Item("LENGTH_U"))
                mdl.A31_LENGTH_D = toStr(dr.Item("LENGTH_D"))
                mdl.A32_DIAMETER_D = toStr(dr.Item("DIAMETER_D"))
                mdl.A33_DIAMETER_U = toStr(dr.Item("DIAMETER_U"))
                mdl.A34_MODELCODE = toStr(dr.Item("MODELCODE"))
                mdl.A35_LOSSTYPE = toStr(dr.Item("LOSSTYPE"))
                mdl.A36_IS_HT = IIf(toStr(dr.Item("IS_HT")).ToLower = "true".ToLower, True, False)
                mdl.A37_IS_CT = IIf(toStr(dr.Item("IS_CT")).ToLower = "true".ToLower, True, False)
                mdl.A38_HARDNESS = toStr(dr.Item("HARDNESS"))
                mdl.A39_ANGLE = toStr(dr.Item("ANGLE"))
                mdl.A40_CUSNAME = toStr(dr.Item("CUSNAME"))
                mdl.A41_SALEPERSON = toStr(dr.Item("SALEPERSON"))
                mdl.A42_MAKER = toStr(dr.Item("MAKER"))
                mdl.A43_DWEIGHT_TYPE = todbl(dr.Item("DWEIGHT_TYPE"))
                mdl.A44_HWEIGHT_TYPE = todbl(dr.Item("HWEIGHT_TYPE"))
                mdl.A45_SIP = toStr(dr.Item("SIP"))
                mdl.A46_MEMO = toStr(dr.Item("MEMO"))
                mdl.A47_RECEIPTPERSON = toStr(dr.Item("RECEIPTPERSON"))
                mdl.A48_RECEIPTTIME = IIf(toStr(dr.Item("RECEIPTTIME")) = "", Nothing, dr.Item("RECEIPTTIME"))
                mdl.A49_CITYNAME = toStr(dr.Item("CITYNAME"))
                mdl.A50_IROWS = todbl(dr.Item("IROWS"))
                mdl.A51_MI_ID = todbl(dr.Item("MI_ID"))
                mdl.A52_cWORKCondition = toStr(dr.Item("cWORKCondition"))
                mdl.A53_cWorkCode = toStr(dr.Item("cWorkCode"))
                mdl.A54_CINVCODE = toStr(dr.Item("CINVCODE"))
                mdls.Add(mdl)
            Next
            Return mdls
        End Function

        Private Function myQuerylimit(ByVal nCount As Integer, ByVal Filiter As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Model.Order.IF_ORDERSCollection

            str = "SELECT IF_ID,IF_FROMSYSTEM,IF_TOSYSTEM,IF_FLAG,IF_WRITEDATE,IF_READDATE,IF_ERRORLOG,IF_INTERFACELOGID,MOCODE,MOTYPE,ITEMCODE,ITEMNAME,PLANQTY,UNIT,SDATE,EDATE,SALEORDER,THICK,WIDTH,LENGTH,DIAMETER,MTYPE,SWEIGHT,SWEIGHT_UNIT,STEPCODE,THICK_U,THICK_D,WIDTH_U,WIDTH_D,LENGTH_U,LENGTH_D,DIAMETER_D,DIAMETER_U,MODELCODE,LOSSTYPE,IS_HT,IS_CT,HARDNESS,ANGLE,CUSNAME,SALEPERSON,MAKER,DWEIGHT_TYPE,HWEIGHT_TYPE,SIP,MEMO,RECEIPTPERSON,RECEIPTTIME,CITYNAME,IROWS,MI_ID,cWORKCondition,cWorkCode,CINVCODE"
            str &= "  FROM  IF_ORDERS"
            str &= " WHERE 1=1 "
            If Filiter <> "" Then
                str &= Filiter
            End If
            str &= " ORDER BY IF_ID DESC  "
            Dim dt As DataTable = GetDataTable(str, cmd)
            Dim mdls As New Model.Order.IF_ORDERSCollection

            Dim SaleOrder As String = ""
            Dim iCount As Integer = 0
            For Each dr As DataRow In dt.Rows

                If SaleOrder <> dr!SaleOrder Then
                    SaleOrder = dr!SaleOrder
                    iCount += 1
                    If iCount > nCount Then
                        Exit For
                    End If
                    Dim mdl As New Model.Order.IF_ORDERS
                    mdl.A01_IF_ID = todbl(dr.Item("IF_ID"))
                    mdl.A02_IF_FROMSYSTEM = toStr(dr.Item("IF_FROMSYSTEM"))
                    mdl.A03_IF_TOSYSTEM = toStr(dr.Item("IF_TOSYSTEM"))
                    mdl.A04_IF_FLAG = toStr(dr.Item("IF_FLAG"))
                    mdl.A05_IF_WRITEDATE = IIf(toStr(dr.Item("IF_WRITEDATE")) = "", Nothing, dr.Item("IF_WRITEDATE"))
                    mdl.A06_IF_READDATE = IIf(toStr(dr.Item("IF_READDATE")) = "", Nothing, dr.Item("IF_READDATE"))
                    mdl.A07_IF_ERRORLOG = toStr(dr.Item("IF_ERRORLOG"))
                    mdl.A08_IF_INTERFACELOGID = toStr(dr.Item("IF_INTERFACELOGID"))
                    mdl.A09_MOCODE = toStr(dr.Item("MOCODE"))
                    mdl.A10_MOTYPE = toStr(dr.Item("MOTYPE"))
                    mdl.A11_ITEMCODE = toStr(dr.Item("ITEMCODE"))
                    mdl.A12_ITEMNAME = toStr(dr.Item("ITEMNAME"))
                    mdl.A13_PLANQTY = todbl(dr.Item("PLANQTY"))
                    mdl.A14_UNIT = toStr(dr.Item("UNIT"))
                    mdl.A15_SDATE = IIf(toStr(dr.Item("SDATE")) = "", Nothing, dr.Item("SDATE"))
                    mdl.A16_EDATE = IIf(toStr(dr.Item("EDATE")) = "", Nothing, dr.Item("EDATE"))
                    mdl.A17_SALEORDER = toStr(dr.Item("SALEORDER"))
                    mdl.A18_THICK = toStr(dr.Item("THICK"))
                    mdl.A19_WIDTH = toStr(dr.Item("WIDTH"))
                    mdl.A20_LENGTH = toStr(dr.Item("LENGTH"))
                    mdl.A21_DIAMETER = toStr(dr.Item("DIAMETER"))
                    mdl.A22_MTYPE = toStr(dr.Item("MTYPE"))
                    mdl.A23_SWEIGHT = todbl(dr.Item("SWEIGHT"))
                    mdl.A24_SWEIGHT_UNIT = toStr(dr.Item("SWEIGHT_UNIT"))
                    mdl.A25_STEPCODE = toStr(dr.Item("STEPCODE"))
                    mdl.A26_THICK_U = toStr(dr.Item("THICK_U"))
                    mdl.A27_THICK_D = toStr(dr.Item("THICK_D"))
                    mdl.A28_WIDTH_U = toStr(dr.Item("WIDTH_U"))
                    mdl.A29_WIDTH_D = toStr(dr.Item("WIDTH_D"))
                    mdl.A30_LENGTH_U = toStr(dr.Item("LENGTH_U"))
                    mdl.A31_LENGTH_D = toStr(dr.Item("LENGTH_D"))
                    mdl.A32_DIAMETER_D = toStr(dr.Item("DIAMETER_D"))
                    mdl.A33_DIAMETER_U = toStr(dr.Item("DIAMETER_U"))
                    mdl.A34_MODELCODE = toStr(dr.Item("MODELCODE"))
                    mdl.A35_LOSSTYPE = toStr(dr.Item("LOSSTYPE"))
                    mdl.A36_IS_HT = IIf(toStr(dr.Item("IS_HT")).ToLower = "true".ToLower, True, False)
                    mdl.A37_IS_CT = IIf(toStr(dr.Item("IS_CT")).ToLower = "true".ToLower, True, False)
                    mdl.A38_HARDNESS = toStr(dr.Item("HARDNESS"))
                    mdl.A39_ANGLE = toStr(dr.Item("ANGLE"))
                    mdl.A40_CUSNAME = toStr(dr.Item("CUSNAME"))
                    mdl.A41_SALEPERSON = toStr(dr.Item("SALEPERSON"))
                    mdl.A42_MAKER = toStr(dr.Item("MAKER"))
                    mdl.A43_DWEIGHT_TYPE = todbl(dr.Item("DWEIGHT_TYPE"))
                    mdl.A44_HWEIGHT_TYPE = todbl(dr.Item("HWEIGHT_TYPE"))
                    mdl.A45_SIP = toStr(dr.Item("SIP"))
                    mdl.A46_MEMO = toStr(dr.Item("MEMO"))
                    mdl.A47_RECEIPTPERSON = toStr(dr.Item("RECEIPTPERSON"))
                    mdl.A48_RECEIPTTIME = IIf(toStr(dr.Item("RECEIPTTIME")) = "", Nothing, dr.Item("RECEIPTTIME"))
                    mdl.A49_CITYNAME = toStr(dr.Item("CITYNAME"))
                    mdl.A50_IROWS = todbl(dr.Item("IROWS"))
                    mdl.A51_MI_ID = todbl(dr.Item("MI_ID"))
                    mdl.A52_cWORKCondition = toStr(dr.Item("cWORKCondition"))
                    mdl.A53_cWorkCode = toStr(dr.Item("cWorkCode"))
                    mdl.A54_CINVCODE = toStr(dr.Item("CINVCODE"))
                    mdls.Add(mdl)
                End If
            Next

            Return mdls
        End Function

    End Class


End Namespace


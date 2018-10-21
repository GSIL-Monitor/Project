Imports System.IO
Imports System.Xml
Imports System.Text

''' <summary>
''' 数据转变函数
''' </summary>
''' <remarks></remarks>
Public Class ConvertData

    ''' <summary>
    ''' 返回是否含有SQL注入式攻击代码
    ''' </summary>
    ''' <param name="Str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckSqlCode(ByVal Str As String) As Boolean

        Dim ReturnValue As Boolean = False
        Try
            If Str.Trim() <> "" Then
                Dim SqlStr As String = "'|and|exec|insert|select|delete|update|count|'|chr|mid|master|truncate|char|declare"
                Dim anySqlStr() As String = SqlStr.Split("|"c)
                Dim ss As String
                For Each ss In anySqlStr
                    If Str.IndexOf(ss) >= 0 Then
                        ReturnValue = True
                    End If
                Next
            End If
        Catch
            ReturnValue = True
        End Try

        Return ReturnValue
    End Function

    ''' <summary>
    ''' DataTable 转 XML
    ''' </summary>
    ''' <param name="xmlDS"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ConvertDataTableToXML(ByVal xmlDS As DataTable) As String
        Dim stream As MemoryStream = Nothing
        Dim writer As XmlTextWriter = Nothing
        Try
            stream = New MemoryStream()
            writer = New XmlTextWriter(stream, Encoding.Default)
            xmlDS.WriteXml(writer)
            Dim count As Integer = CType(stream.Length, Integer)
            Dim arr() As Byte = New Byte(count) {}
            stream.Seek(0, SeekOrigin.Begin)
            stream.Read(arr, 0, count)
            Dim utf As UTF8Encoding = New UTF8Encoding()
            Return utf.GetString(arr).Trim()
        Catch
            Return String.Empty
        Finally
            If Not writer Is Nothing Then
                writer.Close()
            End If
        End Try
    End Function

  


    ''' <summary>
    ''' DataTable 转 HTML 
    ''' </summary>
    ''' <param name="ExportFileName">标题</param>
    ''' <param name="isPrint">false</param>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetHtmlString(ByVal ExportFileName As String, ByVal isPrint As Boolean, ByVal dt As DataTable) As String

        Dim sb As StringBuilder = New StringBuilder()
        sb.Append("<HTML><HEAD>")
        sb.Append("<title>" + ExportFileName + "</title>")
        sb.Append("<META HTTP-EQUIV='content-type' CONTENT='text/html; charset=GB2312'> ")
        sb.Append("<script language=javascript>")
        sb.Append("self.resizeBy(0,0);")
        sb.Append("self.resizeTo(screen.availWidth,screen.availHeight);")
        sb.Append("</script>")
        sb.Append("<style type=text/css>")
        sb.Append("td{font-size: 9pt;border:solid 1 #000000;}")
        sb.Append("table{padding:3 0 3 0;border:solid 1 #000000;margin:0 0 0 0;BORDER-COLLAPSE: collapse;}")
        sb.Append("</style>")
        sb.Append("</HEAD>")
        If Not isPrint Then
            sb.Append("<BODY  >")
        Else
            sb.Append("<BODY   onload = 'window.print()'>")
        End If
        sb.Append("<table cellSpacing='0' cellPadding='0' width ='100%' border='1'")
        sb.Append(">")
        sb.Append("<tr valign='middle'>")
        sb.Append("<td>序</td>")
        Dim column As DataColumn
        For Each column In dt.Columns
            sb.Append("<td><b><span>" + column.ColumnName + "</span></b></td>")
        Next
        sb.Append("</tr>")
        Dim iColsCount As Integer = dt.Columns.Count
        Dim rowsCount As Integer = dt.Rows.Count - 1
        Dim j As Integer
        For j = 0 To rowsCount Step j + 1
            sb.Append("<tr>")
            sb.Append("<td>" + (CType((j + 1), Integer)).ToString() + "</td>")
            Dim k As Integer
            For k = 0 To iColsCount - 1 Step k + 1
                sb.Append("<td")
                sb.Append(">")
                Dim obj As Object = dt.Rows(j)(k)
                'If ConvertData.toStr(obj) = "" Then
                '    ' 如果是NULL则在HTML里面使用一个空格替换之
                '    obj = "&nbsp;"
                'End If
                Dim strCellContent As String = ConvertData.toStr(obj)
                sb.Append("<span>" + strCellContent + "</span>")
                sb.Append("</td>")
            Next
            sb.Append("</tr>")
        Next
        sb.Append("</TABLE></BODY></HTML>")
        Return sb.ToString()
    End Function

    '见分近角 公式
    ''' <summary>
    ''' 见分近角公式
    ''' </summary>
    ''' <param name="B">缴费基数</param>
    ''' <param name="Rate">社保比例</param>
    ''' <returns></returns>
    ''' <remarks>社保金</remarks>
    Public Shared Function HRRound(ByVal Value As Decimal, ByVal iRate As Decimal) As Decimal
        Return Int(Value * iRate * 10 + 0.9) / 10
    End Function

    ''' <summary>
    ''' 时间戳转为C#格式时间
    ''' </summary>
    ''' <param name=”timeStamp”></param>
    ''' <returns></returns>
    Public Shared Function timetostr(ByVal timeStamp As String) As DateTime
        Dim dtStart As DateTime = TimeZone.CurrentTimeZone.ToLocalTime(New DateTime(1970, 1, 1))
        Dim lTime As Long = Long.Parse(timeStamp & Convert.ToString("0000000"))
        Dim toNow As New TimeSpan(lTime)
        Return dtStart.Add(toNow)
    End Function

    ''' <summary>
    ''' DateTime时间格式转换为Unix时间戳格式
    ''' </summary>
    ''' <param name=”time”></param>
    ''' <returns></returns>
    Public Shared Function strtotime(ByVal time As System.DateTime) As Integer
        Dim startTime As System.DateTime = TimeZone.CurrentTimeZone.ToLocalTime(New System.DateTime(1970, 1, 1))
        Return CInt((time - startTime).TotalSeconds)
    End Function

    ''' <summary>
    ''' 将数据转换为字符串
    ''' </summary>
    ''' <param name="Obj"></param>
    ''' <param name="bTrim">是否去掉前后空格</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toStr(ByVal Obj As Object, Optional ByVal bTrim As Boolean = True) As String
        If Obj Is DBNull.Value Then
            Return ""
        Else
            If bTrim = True Then
                Return Trim(Obj)
            Else
                Return Obj
            End If
        End If
    End Function

    ''' <summary>
    ''' 将数据转换为Double数字
    ''' </summary>
    ''' <param name="Obj"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function todbl(ByVal Obj As Object) As Double
        If Obj Is DBNull.Value Then
            Return 0
        ElseIf IsNumeric(Obj) = False Then
            Return 0
        Else
            Return Obj
        End If
    End Function

    ''' <summary>
    ''' 格式化数字
    ''' </summary>
    ''' <param name="Num"></param>
    ''' <param name="Definition">精确小数位 默认小数位数4 </param>
    ''' <param name="Format">格式化</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FormatNumber(ByVal Num As Double, Optional ByVal Definition As Integer = 4, _
    Optional ByVal Format As String = "") As String

        If Definition = 0 Then
            Num = Num.ToString("0")
        Else
            Dim cFormat As String = "0." & New String("0", Definition)
            Num = Num.ToString(cFormat)
        End If

        Dim str As String = Num
        If Format <> "" Then
            str = Num.ToString(Format)
        End If

        Return str
    End Function


    ''' <summary>
    ''' 获取一个Model中指字名的PropertyInfo
    ''' </summary>
    ''' <param name="Field"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function getPropertyInfo(ByVal mdl As Object, ByVal Field As String) As System.Reflection.PropertyInfo
        For Each Pro As System.Reflection.PropertyInfo In mdl.GetProperties
            If Pro.Name.ToLower.Trim = Field.ToLower.Trim Then
                Return Pro
            End If
        Next
    End Function

    ''' <summary>
    ''' 将对象类型转换为一张空DataTable 通过反射与实体类直接关系
    ''' </summary>
    ''' <param name="ItemType">对象类型</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toTable(ByVal ItemType As Type) As DataTable

        Dim dt As New DataTable
        For Each Pro As System.Reflection.PropertyInfo In ItemType.GetProperties()
            Dim col As New DataColumn(Pro.Name, Pro.PropertyType) '取通过反射与实体的GetType相绑定
            dt.Columns.Add(col) '添加列
        Next
        Return dt
    End Function

    ''' <summary>
    ''' 将一个实体转换成DataTable
    ''' </summary>
    ''' <param name="mdl">实体类</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toTable_byModel(ByVal mdl As Object) As DataTable
        ' MsgBox(GetType(Integer).ToString())  String.Int32
        Dim ItemType As Type = mdl.GetType
        Dim dt As DataTable = toTable(ItemType) '定义DataTable表结构
        Dim dr As DataRow = dt.NewRow
        toDataRow(mdl, dr) '将实例转为行数据
        dt.Rows.Add(dr) '只添加1行
        Return dt
    End Function

    ''' <summary>
    ''' 将数组转换成DataTable
    ''' </summary>
    ''' <param name="Array">数组</param>
    ''' <param name="ItemType">对象类型</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toTable(ByVal Array As Array, ByVal ItemType As Type) As DataTable

        Dim dt As DataTable = toTable(ItemType)

        '---------添加多行---------
        Dim Pros() As System.Reflection.PropertyInfo = ItemType.GetProperties
        For Each obj As Object In Array
            Dim dr As DataRow = dt.NewRow
            ConvertData.toDataRow(obj, dr, Pros)
            dt.Rows.Add(dr)
        Next

        Return dt
    End Function

    Public Shared Function toTable(ByVal dg As DataGridView) As DataTable

        Dim dt As New DataTable()
        '添加列
        For i As Integer = 0 To dg.Columns.Count - 1
            dt.Columns.Add(dg.Columns(i).HeaderText, GetType(String))
        Next
        '添加行
        For j As Integer = 0 To dg.Rows.Count - 1
            Dim gDr As DataRow
            gDr = dt.NewRow
            For i As Integer = 0 To dg.Columns.Count - 1
                gDr.Item(i) = dg.Item(i, j).Value
            Next
            dt.Rows.Add(gDr)
        Next

        Return dt

    End Function

    ''' <summary>
    ''' 将集合转换成DataTable
    ''' </summary>
    ''' <param name="List">集合</param>
    ''' <param name="ItemType">对象类型</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toTable(ByVal List As IList, ByVal ItemType As Type) As DataTable
        Dim Arr(List.Count - 1) As Object
        List.CopyTo(Arr, 0)
        Return toTable(Arr, ItemType)
    End Function

    ''' <summary>
    ''' 将表格列转换成DataTable
    ''' </summary>
    ''' <param name="cols"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function toTable(ByVal cols As DataGridViewColumnCollection) As DataTable

        Dim dt As New DataTable
        For Each col As DataGridViewColumn In cols
            Dim cl As New DataColumn
            cl.ColumnName = col.Name
            cl.Caption = col.HeaderText
            If col.ValueType IsNot Nothing Then
                cl.DataType = col.ValueType
            End If
            dt.Columns.Add(cl)
        Next
        Return dt

    End Function

    ''' <summary>
    ''' 将一个DataRow的内容复制到一个Model
    ''' </summary>
    ''' <param name="drSource">源DataRow</param>
    ''' <param name="mdlTarget">目标Model</param>
    ''' <remarks></remarks>
    Public Shared Sub toModel(ByVal drSource As DataRow, ByRef mdlTarget As Object)

        For Each Pro As System.Reflection.PropertyInfo In mdlTarget.GetType.GetProperties() '取1个实例的每个元素
            Dim columnName As String = Pro.Name
            Try
                If Pro.PropertyType Is GetType(String) Then 'String 
                    Dim Value As String = toStr(drSource.Item(columnName)) '取行的值
                    Pro.SetValue(mdlTarget, Value, Nothing) '

                ElseIf Pro.PropertyType Is GetType(Date) Then 'Date

                    Dim Value As String = toStr(drSource.Item(columnName))
                    Value = IIf(Value = "", Nothing, Value)
                    Pro.SetValue(mdlTarget, Value, Nothing)

                ElseIf Pro.PropertyType Is GetType(Boolean) Then 'Boolen

                    Dim Value As Boolean
                    If toStr(drSource.Item(columnName)).ToLower.Trim = "true".ToLower.Trim Then
                        Value = True
                    Else
                        Value = False
                    End If
                    Pro.SetValue(mdlTarget, Value, Nothing)

                ElseIf Pro.PropertyType Is GetType(Double) Or Pro.PropertyType Is GetType(Int32) Then 'Double
                    Dim Value As Double = todbl(drSource.Item(columnName))
                    Pro.SetValue(mdlTarget, Value, Nothing)
                Else
                    Dim Value As Object = drSource.Item(columnName)
                    Pro.SetValue(mdlTarget, Value, Nothing)
                End If
            Catch ex As Exception

            End Try
        Next

    End Sub


    ''' <summary>
    ''' 将一个Model的内容复制到别一个Model
    ''' </summary>
    ''' <param name="mdlSource"></param>
    ''' <param name="mdlTarget"></param>
    ''' <remarks></remarks>
    Public Shared Sub CopyModel(ByVal mdlSource As Object, ByVal mdlTarget As Object)

        Dim Pros As System.Reflection.PropertyInfo() = mdlTarget.GetType.GetProperties  '取目标实例
        For Each Pro As System.Reflection.PropertyInfo In mdlSource.GetType.GetProperties '取源实例
            Try
                Dim Value As Object = Pro.GetValue(mdlSource, Nothing) '取源实例第1个元素
                For Each Pro2 As System.Reflection.PropertyInfo In Pros '
                    If Pro.Name = Pro2.Name Then
                        Pro2.SetValue(mdlTarget, Value, Nothing) '给目标元素赋值
                    End If
                Next
            Catch ex As Exception
            End Try
        Next

    End Sub


    ''' <summary>
    ''' 将一个Model的内容复制到一个DataRow
    ''' </summary>
    ''' <param name="mdlSource"></param>
    ''' <param name="drTarget"></param>
    ''' <remarks></remarks>
    Public Shared Sub toDataRow(ByVal mdlSource As Object, ByVal drTarget As DataRow)

        Dim Pros() As System.Reflection.PropertyInfo = mdlSource.GetType.GetProperties '取实体类元属性
        toDataRow(mdlSource, drTarget, Pros) '添加至DataRow

    End Sub

    ''' <summary>
    ''' 将一个Model的内容复制到一个DataRow
    ''' </summary>
    ''' <param name="mdlSource"> 实体 </param>
    ''' <param name="drTarget"> 目标行 </param>
    ''' <param name="Pros"> 反射元属性 </param>
    ''' <remarks></remarks>
    Public Shared Sub toDataRow(ByVal mdlSource As Object, ByVal drTarget As DataRow, ByVal Pros() As System.Reflection.PropertyInfo)

        For Each p As System.Reflection.PropertyInfo In Pros

            Try
                If drTarget.Table.Columns.Contains(p.Name) Then '行数据中的每1列字段
                    Dim Value As Object = p.GetValue(mdlSource, Nothing) '取反射中数据实体类
                    If Value = Nothing And p.PropertyType Is GetType(Date) Then
                        drTarget.Item(p.Name) = DBNull.Value
                    Else
                        drTarget.Item(p.Name) = Value '将实例赋值给行信息
                    End If
                End If

            Catch ex As Exception

            End Try

        Next

    End Sub

    ''' <summary>
    ''' 将一个DataRow的内容复制到另一个DataRow
    ''' </summary>
    ''' <param name="drSource">源DataRow</param>
    ''' <param name="drTarget">目标DataRow</param>
    ''' <remarks></remarks>
    Public Shared Sub CopyDataRow(ByVal drSource As DataRow, ByRef drTarget As DataRow)

        For Each col As DataColumn In drSource.Table.Columns
            Try
                If drTarget.Table.Columns.Contains(col.ColumnName) Then
                    drTarget.Item(col.ColumnName) = drSource.Item(col.ColumnName)
                End If
            Catch ex As Exception

            End Try
        Next

    End Sub

    ''' <summary>
    ''' 四舍五入-中国用法
    ''' </summary>
    ''' <param name="value">数值</param>
    ''' <param name="decimals">保留位数</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ChinaRound(ByVal value As Double, ByVal decimals As Integer) As Double
        If value < 0 Then
            Return Math.Round(value + 5 / Math.Pow(10, decimals + 1), decimals, MidpointRounding.AwayFromZero)
        Else
            Return Math.Round(value, decimals, MidpointRounding.AwayFromZero)
        End If
    End Function


    ''' <summary>
    ''' 将金额转换成大写
    ''' </summary>
    ''' <param name="Money">金额</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function UpperMoney(ByVal Money As String) As String

        Money = todbl(Money).ToString("0.00")
        Dim strFuShu As String = IIf(Money.StartsWith("-"), "负", "")
        Money = Money.Replace("-", "").Replace(".", "")
        Dim Number As String = "零壹贰叁肆伍陆柒捌玖"
        Dim Unit As String = "分角元拾佰仟万拾佰仟亿拾佰仟万"
        Dim str As String

        For i As Integer = 0 To Money.Length - 1
            Dim c As String = Money.Chars(i)
            Dim Index As Integer = Money.Length - 1 - i
            str &= Number(c) & Unit(Index)
        Next
        str = strFuShu & str & "正"
        Return str

    End Function

    ''' <summary>
    ''' 分组
    ''' </summary>
    ''' <param name="GroupFields"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Group(ByVal dt As DataTable, ByVal ParamArray GroupFields() As String) As DataTable

        Dim dtGrp As DataTable = dt.Copy

        Dim Index As Integer = 0
l:      For i As Integer = Index To dtGrp.Rows.Count - 1
            Index = i
            Dim dr As DataRow = dtGrp.Rows(i)
            Dim Filter As String = ""
            For Each Field As String In GroupFields
                Dim Value As String = toStr(dr.Item(Field))
                Filter &= IIf(Filter <> "", " and ", "") & "Convert(" & Field & ",System.String)='" & Value & "'"
            Next
            If dtGrp.Compute("count(" & dtGrp.Columns(0).ColumnName & ")", Filter) > 1 Then
                dtGrp.Rows.Remove(dr)
                GoTo l
            End If
        Next

        Return dt

    End Function

    Public Shared Function GetShortDate(ByVal gDate As Date) As String

        Return gDate.Month & "/" & gDate.Day

    End Function



    ''' <summary>
    ''' 转换中国星期格式
    ''' </summary>
    ''' <param name="_datetime">日期</param>
    ''' <param name="bShort">显示长短 长 星期日 短 日 </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DayOfWeek(ByVal _datetime As DateTime, ByVal bShort As Boolean) As String

        Dim time As String = " "
        Select Case _datetime.DayOfWeek
            Case System.DayOfWeek.Sunday
                time = "星期日"
                Exit Select
            Case System.DayOfWeek.Monday
                time = "星期一"
                Exit Select
            Case System.DayOfWeek.Tuesday
                time = "星期二"
                Exit Select
            Case System.DayOfWeek.Wednesday
                time = "星期三"
                Exit Select
            Case System.DayOfWeek.Thursday
                time = "星期四"
                Exit Select
            Case System.DayOfWeek.Friday
                time = "星期五"
                Exit Select
            Case System.DayOfWeek.Saturday
                time = "星期六"
                Exit Select
            Case Else
                time = ""
                Exit Select
        End Select

        If (time.Trim.Length > 0) Then
            If bShort = True Then
                time = Mid(time, 3, 1)
            End If
        End If
        Return time

    End Function



    Public Shared Function GetWeekOfDay(startDate As DateTime, endDate As DateTime) As Integer
        '总周数
        Dim weekCount = Math.Ceiling(Convert.ToDouble((endDate - startDate).Days / 7))
        '用于存储日期
        Dim weekDic = New Dictionary(Of DateTime, Integer)()

        Dim today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))

        For i As Integer = 0 To weekCount - 1
            For j As Integer = 0 To 6
                weekDic.Add(startDate.AddDays(i * 7 + j), i + 1)
            Next
        Next

        Return If(weekDic.ContainsKey(today), weekDic(today), 1)
    End Function






    ''' <summary>
    ''' 日期在当月的第几周内
    ''' </summary>
    ''' <param name="daytime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getWeekNumInMonth(daytime As DateTime) As Integer



        Dim dayInMonth As Integer = daytime.Day
        '本月第一天  
        Dim firstDay As DateTime = daytime.AddDays(1 - daytime.Day)
        '本月第一天是周几  
        Dim weekday As Integer = If(CInt(firstDay.DayOfWeek) = 0, 7, CInt(firstDay.DayOfWeek))
        '本月第一周有几天  
        Dim firstWeekEndDay As Integer = 7 - (weekday - 1)
        '当前日期和第一周之差  
        Dim diffday As Integer = dayInMonth - firstWeekEndDay
        diffday = If(diffday > 0, diffday, 1)
        '当前是第几周,如果整除7就减一天  
        Dim WeekNumInMonth As Integer = Int(If((diffday Mod 7) = 0, (diffday / 7 - 1), (diffday / 7))) + 1 + Int(If(dayInMonth > firstWeekEndDay, 1, 0))
        Return WeekNumInMonth

    End Function




    ''' <summary>
    ''' 星期天为第一天 
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetWeekFirstDaySun(ByVal datetime As DateTime) As DateTime
        '星期天为第一天  
        Dim weeknow As Integer = Convert.ToInt32(datetime.DayOfWeek)
        Dim daydiff As Integer = (-1) * weeknow

        '本周第一天  
        Dim FirstDay As String = datetime.AddDays(daydiff).ToString("yyyy-MM-dd")
        Return Convert.ToDateTime(FirstDay)
    End Function

    ''' <summary>
    ''' 星期一为第一天
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetWeekFirstDayMon(ByVal datetime As DateTime) As DateTime
        '星期一为第一天  
        Dim weeknow As Integer = Convert.ToInt32(datetime.DayOfWeek)

        '因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。  
        If weeknow = 0 Then
            weeknow = 7 - 1
        Else
            weeknow = weeknow - 1
        End If
        Dim daydiff As Integer = (-1) * weeknow

        '本周第一天  
        Dim FirstDay As String = datetime.AddDays(daydiff).ToString("yyyy-MM-dd")
        Return Convert.ToDateTime(FirstDay)

    End Function

    ''' <summary>
    ''' 星期天为最后一天
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetWeekLastDaySun(ByVal datetime As DateTime) As DateTime
        '星期天为最后一天  
        Dim weeknow As Integer = Convert.ToInt32(datetime.DayOfWeek)
        weeknow = (weeknow = IIf(0, 7, weeknow))
        Dim daydiff As Integer = (7 - weeknow)

        '本周最后一天  
        Dim LastDay As String = datetime.AddDays(daydiff).ToString("yyyy-MM-dd")
        Return Convert.ToDateTime(LastDay)
    End Function

    ''' <summary>
    ''' 星期六为最后一天
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetWeekLastDaySat(ByVal datetime As DateTime) As DateTime
        '星期六为最后一天  
        Dim weeknow As Integer = Convert.ToInt32(datetime.DayOfWeek)
        Dim daydiff As Integer = (7 - weeknow) - 1

        '本周最后一天  
        Dim LastDay As String = datetime.AddDays(daydiff).ToString("yyyy-MM-dd")
        Return Convert.ToDateTime(LastDay)
    End Function


    ''' <summary>
    ''' 取得某月的第一天
    ''' </summary>
    ''' <param name="datetime">要取得月份第一天的时间</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFirstDayOfMonth(ByVal datetime As DateTime) As DateTime
        Return datetime.AddDays(1 - datetime.Day)
    End Function

    ''' <summary>
    ''' 取得某月的最后一天
    ''' </summary>
    ''' <param name="datetime">要取得月份最后一天的时间</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetLastDayOfMonth(ByVal datetime As DateTime) As DateTime
        Return datetime.AddDays(1 - datetime.Day).AddMonths(1).AddDays(-1)
    End Function


    Public Shared Function getData(ByVal dt As DataTable, ByVal keys As String, ByVal value As String) As DataTable

        Dim _dt As DataTable = New DataTable()
        For Each item As DataColumn In dt.Columns
            _dt.Columns.Add(item.ColumnName, GetType(String))
        Next

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim aa As String = dt.Rows(i)(keys).ToString()

            If aa = value Then
                _dt.Rows.Add(dt.Rows(i).ItemArray)
            End If
        Next

        Return _dt

    End Function













End Class

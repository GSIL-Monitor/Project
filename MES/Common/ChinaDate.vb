

Imports System.Globalization
Imports System.Collections

''' <summary>
''' 中国农历节日
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ChinaDate
    Private Sub New()
    End Sub
    Private Shared china As New ChineseLunisolarCalendar()
    Private Shared gHoliday As New Hashtable()
    Private Shared nHoliday As New Hashtable()
    Private Shared JQ As String() = {"小寒", "大寒", "立春", "雨水", "惊蛰", "春分", _
     "清明", "谷雨", "立夏", "小满", "芒种", "夏至", _
     "小暑", "大暑", "立秋", "处暑", "白露", "秋分", _
     "寒露", "霜降", "立冬", "小雪", "大雪", "冬至"}
    Private Shared JQData As Integer() = {0, 21208, 42467, 63836, 85337, 107014, _
     128867, 150921, 173149, 195551, 218072, 240693, _
     263343, 285989, 308563, 331033, 353350, 375494, _
     397447, 419210, 440795, 462224, 483532, 504758}
    Shared Sub New()
        '公历节日
        gHoliday.Add("0101", "元旦")
        gHoliday.Add("0214", "情人节")
        gHoliday.Add("0305", "雷锋日")
        gHoliday.Add("0308", "妇女节")
        gHoliday.Add("0312", "植树节")
        gHoliday.Add("0315", "消权日")
        gHoliday.Add("0401", "愚人节")
        gHoliday.Add("0501", "劳动节")
        gHoliday.Add("0504", "青年节")
        gHoliday.Add("0601", "儿童节")
        gHoliday.Add("0701", "建党节")
        gHoliday.Add("0801", "建军节")
        gHoliday.Add("0910", "教师节")
        gHoliday.Add("1001", "国庆节")
        gHoliday.Add("1224", "平安夜")
        gHoliday.Add("1225", "圣诞节")

        '农历节日
        nHoliday.Add("0101", "春节")
        nHoliday.Add("0115", "元宵节")
        nHoliday.Add("0505", "端午节")
        nHoliday.Add("0815", "中秋节")
        nHoliday.Add("0909", "重阳节")
        nHoliday.Add("1208", "腊八节")
    End Sub

    ''' <summary>
    ''' 获取农历
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetChinaDate(ByVal dt As DateTime) As String
        If dt > china.MaxSupportedDateTime OrElse dt < china.MinSupportedDateTime Then
            '日期范围：1901 年 2 月 19 日 - 2101 年 1 月 28 日
            Throw New Exception(String.Format("日期超出范围！必须在{0}到{1}之间！", china.MinSupportedDateTime.ToString("yyyy-MM-dd"), china.MaxSupportedDateTime.ToString("yyyy-MM-dd")))
        End If
        Dim str As String = String.Format("{0} {1}{2}", GetYear(dt), GetMonth(dt), GetDay(dt))
        Dim strJQ As String = GetSolarTerm(dt)
        If strJQ <> "" Then
            str += (Convert.ToString(" (") & strJQ) + ")"
        End If
        Dim strHoliday As String = GetHoliday(dt)
        If strHoliday <> "" Then
            str += Convert.ToString(" ") & strHoliday
        End If
        Dim strChinaHoliday As String = GetChinaHoliday(dt)
        If strChinaHoliday <> "" Then
            str += Convert.ToString(" ") & strChinaHoliday
        End If

        Return str
    End Function

    ''' <summary>
    ''' 获取农历年份
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetYear(ByVal dt As DateTime) As String
        Dim yearIndex As Integer = china.GetSexagenaryYear(dt)
        Dim yearTG As String = " 甲乙丙丁戊己庚辛壬癸"
        Dim yearDZ As String = " 子丑寅卯辰巳午未申酉戌亥"
        Dim yearSX As String = " 鼠牛虎兔龙蛇马羊猴鸡狗猪"
        Dim year As Integer = china.GetYear(dt)
        Dim yTG As Integer = china.GetCelestialStem(yearIndex)
        Dim yDZ As Integer = china.GetTerrestrialBranch(yearIndex)

        Dim str As String = String.Format("[{1}]{2}{3}{0}", year, yearSX(yDZ), yearTG(yTG), yearDZ(yDZ))
        Return str
    End Function

    ''' <summary>
    ''' 获取农历月份
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetMonth(ByVal dt As DateTime) As String
        Dim year As Integer = china.GetYear(dt)
        Dim iMonth As Integer = china.GetMonth(dt)
        Dim leapMonth As Integer = china.GetLeapMonth(year)
        Dim isLeapMonth As Boolean = iMonth = leapMonth
        If leapMonth <> 0 AndAlso iMonth >= leapMonth Then
            iMonth -= 1
        End If

        Dim szText As String = "正二三四五六七八九十"
        Dim strMonth As String = If(isLeapMonth, "闰", "")
        If iMonth <= 10 Then
            strMonth += szText.Substring(iMonth - 1, 1)
        ElseIf iMonth = 11 Then
            strMonth += "十一"
        Else
            strMonth += "腊"
        End If
        Return strMonth & Convert.ToString("月")
    End Function

    ''' <summary>
    ''' 获取农历日期
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetDay(ByVal dt As DateTime) As String

        Dim iDay As Integer = china.GetDayOfMonth(dt)
        Dim szText1 As String = "初十廿三"
        Dim szText2 As String = "一二三四五六七八九十"
        Dim strDay As String
        If iDay = 10 Then
            strDay = "初十"
        ElseIf iDay = 20 Then
            strDay = "二十"
        ElseIf iDay = 30 Then
            strDay = "三十"
        Else
            strDay = szText1.Substring(Int(iDay / 10), 1)
            strDay = strDay & szText2.Substring((iDay - 1) Mod 10, 1)
        End If

        'strDay = szText1.Substring((iDay - 1) / 10, 1)
        'strDay = strDay & szText2.Substring((iDay - 1) Mod 10, 1)
        'strDay = strDay & szText2.Substring((iDay - 1) Mod 10, 1)

        Return strDay

    End Function

    ''' <summary>
    ''' 获取节气
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetSolarTerm(ByVal dt As DateTime) As String

        Dim dtBase As New DateTime(1900, 1, 6, 2, 5, 0)
        Dim dtNew As DateTime
        Dim num As Double
        Dim y As Integer
        Dim strReturn As String = ""

        y = dt.Year
        For i As Integer = 1 To 24
            num = 525948.76 * (y - 1900) + JQData(i - 1)
            dtNew = dtBase.AddMinutes(num)
            If dtNew.DayOfYear = dt.DayOfYear Then
                strReturn = JQ(i - 1)
            End If
        Next
        Return strReturn

    End Function

    ''' <summary>
    ''' 获取公历节日
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetHoliday(ByVal dt As DateTime) As String
        Dim strReturn As String = ""
        Dim g As Object = gHoliday(dt.Month.ToString("00") + dt.Day.ToString("00"))
        If g IsNot Nothing Then
            strReturn = g.ToString()
        End If
        Return strReturn
    End Function

    ''' <summary>
    ''' 获取农历节日
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Shared Function GetChinaHoliday(ByVal dt As DateTime) As String
        Dim strReturn As String = ""
        Dim year As Integer = china.GetYear(dt)
        Dim iMonth As Integer = china.GetMonth(dt)
        Dim leapMonth As Integer = china.GetLeapMonth(year)
        Dim iDay As Integer = china.GetDayOfMonth(dt)
        If china.GetDayOfYear(dt) = china.GetDaysInYear(year) Then
            strReturn = "除夕"
        ElseIf leapMonth <> iMonth Then
            If leapMonth <> 0 AndAlso iMonth >= leapMonth Then
                iMonth -= 1
            End If
            Dim n As Object = nHoliday(iMonth.ToString("00") + iDay.ToString("00"))
            If n IsNot Nothing Then
                If strReturn = "" Then
                    strReturn = n.ToString()
                Else
                    strReturn += " " + n.ToString()
                End If
            End If
        End If

        Return strReturn
    End Function


End Class



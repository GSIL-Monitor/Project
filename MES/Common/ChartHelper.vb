

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports dotnetCHARTING
Imports System.Drawing

Public Delegate Function SetXColumnHandler(ByVal ora_Str As String) As String

Public Class ChartHelper

    Public OnSetXColumn As SetXColumnHandler

    Public Function SetXColumn(ByVal ora_str As String) As String
        If OnSetXColumn <> Nothing Then
            Return OnSetXColumn(ora_str)
        End If
        Return ora_str
    End Function

    Public Sub Create(ByVal chart As Chart, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, ByVal yColumn As String, ByVal style As String, _
     ByVal user3D As Boolean)

        chart.Palette = New Color() {Color.FromArgb(49, 255, 49), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 99, 49), Color.FromArgb(0, 156, 255), Color.FromArgb(255, 125, 49), Color.FromArgb(125, 255, 49), _
         Color.FromArgb(0, 255, 49)}
        chart.Use3D = user3D
        Dim mySC As SeriesCollection = getRandomData(table, xColumn, yColumn)
        If String.IsNullOrEmpty(style) OrElse style = "线形" Then
            chart.Type = ChartType.Combo
            mySC = getRandomData2(table, xColumn, yColumn)
        ElseIf style = "柱形" Then
            chart.Type = ChartType.Combo
        ElseIf style = "金字塔" Then
            chart.Type = ChartType.MultipleGrouped
            chart.DefaultSeries.Type = SeriesTypeMultiple.Pyramid
        ElseIf style = "圆锥" Then
            chart.Type = ChartType.MultipleGrouped
            chart.DefaultSeries.Type = SeriesTypeMultiple.Cone
        End If
        chart.Title = title
        If String.IsNullOrEmpty(style) OrElse style = "线形" Then
            chart.DefaultSeries.Type = SeriesType.Line
        End If

        chart.DefaultElement.ShowValue = True
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(mySC)

    End Sub

    Public Sub Create(ByVal chart As Chart, ByVal title As String, ByVal tables As List(Of DataTable), ByVal dates As List(Of DateTime), ByVal xColumn As String, ByVal yColumn As String, _
     ByVal style As String, ByVal user3D As Boolean, ByVal targetUrl As String)
        chart.Palette = New Color() {Color.FromArgb(49, 255, 49), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 99, 49), Color.FromArgb(0, 156, 255), Color.FromArgb(255, 125, 49), Color.FromArgb(125, 255, 49), _
         Color.FromArgb(0, 255, 49)}
        chart.Use3D = user3D
        chart.Type = ChartType.Combo
        chart.Title = title
        chart.DefaultSeries.Type = SeriesTypeMultiple.Pyramid
        Dim SC As New SeriesCollection()

        Dim i As Integer = 0
        While i < dates.Count
            Dim dtStr As String = dates(i).ToString("yyyy-MM-dd")
            Dim s As New Series(dtStr)
            For Each r As DataRow In tables(i).Rows
                Dim e As New Element(r(xColumn).ToString())
                e.URLTarget = "_self"
                e.LegendEntry.URL = String.Concat(targetUrl, dtStr)
                e.LegendEntry.URLTarget = "_self"
                e.URL = String.Concat(targetUrl, dtStr)
                e.YValue = Convert.ToDouble(r(yColumn))
                s.Elements.Add(e)
                SC.Add(s)
            Next
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        chart.DefaultElement.ShowValue = True
        If String.IsNullOrEmpty(style) OrElse style = "线形" Then
            chart.DefaultSeries.Type = SeriesType.Line
        End If
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)

    End Sub


    Function getRandomData(ByVal table As DataTable, ByVal x As String, ByVal y As String) As SeriesCollection
        Dim SC As New SeriesCollection()
        For Each r As DataRow In table.Rows
            Dim s As New Series(r(x).ToString())
            Dim e As New Element(r(x).ToString())
            e.YValue = Convert.ToDouble(r(y))
            s.Elements.Add(e)
            SC.Add(s)
        Next
        Return SC
    End Function


    Function getRandomData2(ByVal table As DataTable, ByVal x As String, ByVal y As String) As SeriesCollection
        Dim SC As New SeriesCollection()
        Dim s As New Series()
        For Each r As DataRow In table.Rows
            Dim e As New Element(r(x).ToString())
            e.YValue = Convert.ToDouble(r(y))
            s.Elements.Add(e)
        Next
        SC.Add(s)
        Return SC
    End Function

    Public Sub Pie(ByVal chart As dotnetCHARTING.Chart, ByVal width As Integer, ByVal height As Integer, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, _
     ByVal yColumn As String)
        Dim SC As New SeriesCollection()
        Dim s As New Series("")
        Dim view As New DataView(table)
        view.Sort = yColumn + "  desc"
        Dim index As Integer = 0
        Dim table2 As DataTable = view.ToTable()
        Dim otherE As New Element("其他")

        Dim other As Boolean = False
        Dim otherSum As Double = 0
        For Each row As DataRow In table2.Rows
            If index > 9 Then
                otherSum += Convert.ToDouble(row(yColumn).ToString())
                otherE.LabelTemplate = "%PercentOfTotal"
                other = True
                Continue For
            End If
            Dim telType As String = row(xColumn).ToString()
            telType = SetXColumn(telType)
            Dim e As New Element(telType)
            e.LabelTemplate = "%PercentOfTotal"

            e.YValue = Convert.ToDouble(row(yColumn).ToString())
            s.Elements.Add(e)
            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
        Next
        If other Then
            s.Elements.Add(otherE)
        End If
        chart.TitleBox.Position = TitleBoxPosition.FullWithLegend
        otherE.YValue = otherSum
        SC.Add(s)
        chart.TempDirectory = "temp"
        chart.Use3D = False
        chart.DefaultAxis.FormatString = "N"
        chart.DefaultAxis.CultureName = "zh-CN"
        chart.Palette = New Color() {Color.FromArgb(49, 255, 49), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 99, 49), Color.FromArgb(0, 156, 255), Color.FromArgb(255, 156, 255), Color.FromArgb(0, 156, 0), _
         Color.FromArgb(0, 156, 99), Color.FromArgb(0, 99, 255), Color.FromArgb(99, 156, 255), Color.FromArgb(0, 0, 99), Color.FromArgb(0, 156, 126)}
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.Type = ChartType.Pies
        chart.Size = width + "x" + height
        chart.DefaultElement.SmartLabel.Text = ""
        chart.Title = title
        chart.DefaultElement.ShowValue = True
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)
    End Sub

    Public Sub Create(ByVal chart As dotnetCHARTING.Chart, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, ByVal yColumn As String, ByVal style As String, _
     ByVal displayNum As Integer)
        Dim SC As New SeriesCollection()
        Dim view As New DataView(table)
        view.Sort = yColumn + "  desc"
        Dim index As Integer = 0
        Dim table2 As DataTable = view.ToTable()
        Dim otherE As New Element("其他")
        Dim other As Boolean = False
        Dim otherSum As Double = 0
        Dim c As Color = Color.FromArgb(49, 255, 49)
        Dim r As New Random(255)
        Dim c1 As Color = Color.FromArgb(255, 49, 255)
        Dim list As New List(Of Color)()
        list.Add(c)
        list.Add(c1)
        Dim i As Integer = 0
        While i < displayNum
            Dim cc As Color = Color.FromArgb((c.A + r.[Next](10000)) Mod 255, (c.B + r.[Next](456)) Mod 255, (c.G + r.[Next](1027)) Mod 100)
            list.Add(cc)
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        For Each row As DataRow In table2.Rows
            Dim s As New Series("")
            If index > displayNum - 2 Then
                otherSum += Convert.ToDouble(row(yColumn).ToString())
                otherE.LabelTemplate = "%PercentOfTotal"
                other = True
                Continue For
            End If

            Dim telType As String = row(xColumn).ToString()
            telType = SetXColumn(telType)
            s.Name = telType
            Dim e As New Element(telType)
            e.LabelTemplate = "%PercentOfTotal"
            e.SmartLabel.Text = telType


            e.YValue = Convert.ToDouble(row(yColumn).ToString())
            s.Elements.Add(e)
            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
            SC.Add(s)
        Next
        If other Then
            Dim s As New Series("其他")
            s.Elements.Add(otherE)
            SC.Add(s)
        End If
        otherE.YValue = otherSum
        otherE.SmartLabel.Text = "其他"

        chart.TempDirectory = "temp"
        chart.Use3D = False
        chart.DefaultAxis.FormatString = "N"
        chart.DefaultAxis.CultureName = "zh-CN"
        chart.Palette = list.ToArray()
        chart.DefaultElement.SmartLabel.AutoWrap = True
        If String.IsNullOrEmpty(style) OrElse style = "线形" Then
            chart.Type = ChartType.Combo
            chart.DefaultSeries.Type = SeriesType.Line
        ElseIf style = "柱形" Then
            chart.Type = ChartType.Combo
        ElseIf style = "横柱形" Then
            chart.Type = ChartType.ComboHorizontal
        ElseIf style = "图片柱形" Then
            chart.Type = ChartType.Combo
            chart.DefaultSeries.ImageBarTemplate = "ethernetcable"
        ElseIf style = "雷达" Then
            chart.Type = ChartType.Radar
        ElseIf style = "圆锥" Then
            chart.Type = ChartType.MultipleGrouped
            chart.DefaultSeries.Type = SeriesTypeMultiple.Cone
        End If
        chart.DefaultElement.SmartLabel.Text = ""
        chart.Title = title
        chart.DefaultElement.ShowValue = True
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)
    End Sub

    Public Sub Pie2(ByVal chart As dotnetCHARTING.Chart, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, ByVal yColumn As String, ByVal style As String, _
     ByVal displayNum As Integer)
        Dim SC As New SeriesCollection()
        Dim s As New Series("")
        Dim view As New DataView(table)
        view.Sort = yColumn + "  desc"
        Dim index As Integer = 0
        Dim table2 As DataTable = view.ToTable()
        Dim otherE As New Element("其他")
        Dim other As Boolean = False
        Dim otherSum As Double = 0
        Dim c As Color = Color.FromArgb(49, 255, 49)
        Dim r As New Random(255)
        Dim c1 As Color = Color.FromArgb(255, 49, 255)
        Dim list As New List(Of Color)()
        list.Add(c)
        list.Add(c1)
        Dim i As Integer = 0
        While i < displayNum
            Dim cc As Color = Color.FromArgb((c.A + r.[Next](10000)) Mod 255, (c.B + r.[Next](456)) Mod 255, (c.G + r.[Next](1027)) Mod 100)
            list.Add(cc)
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        For Each row As DataRow In table2.Rows
            If index > displayNum - 2 Then
                otherSum += Convert.ToDouble(row(yColumn).ToString())
                otherE.LabelTemplate = "%PercentOfTotal"
                other = True
                Continue For
            End If
            Dim telType As String = row(xColumn).ToString()
            telType = SetXColumn(telType)
            Dim e As New Element(telType)
            e.LabelTemplate = "%PercentOfTotal"
            e.SmartLabel.Text = telType


            e.YValue = Convert.ToDouble(row(yColumn).ToString())
            s.Elements.Add(e)
            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
        Next
        If other Then
            s.Elements.Add(otherE)
        End If
        otherE.YValue = otherSum
        otherE.SmartLabel.Text = "其他"
        SC.Add(s)
        chart.TempDirectory = "temp"
        chart.Use3D = False
        chart.DefaultAxis.FormatString = "N"
        chart.DefaultAxis.CultureName = "zh-CN"
        chart.Palette = list.ToArray()
        chart.DefaultElement.SmartLabel.AutoWrap = True
        If style = "饼形" Then
            chart.Type = ChartType.Pies
        ElseIf style = "柱形" Then
            chart.Type = ChartType.Combo
        ElseIf style = "横柱形" Then
            chart.Type = ChartType.ComboHorizontal
        ElseIf style = "图片柱形" Then
            chart.Type = ChartType.Combo
            chart.DefaultSeries.ImageBarTemplate = "ethernetcable"
        ElseIf style = "雷达" Then
            chart.Type = ChartType.Radar
        ElseIf style = "圆锥" Then
            chart.Type = ChartType.MultipleGrouped
            chart.DefaultSeries.Type = SeriesTypeMultiple.Cone
        End If
        chart.DefaultElement.SmartLabel.Text = ""
        chart.Title = title
        chart.DefaultElement.ShowValue = True
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)
    End Sub
    Public Sub Pie2(ByVal chart As dotnetCHARTING.Chart, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, ByVal yColumn As String, ByVal style As String, _
     ByVal displayNum As Integer, ByVal targetUrl As String)
        Pie2(chart, title, table, xColumn, yColumn, style, _
         displayNum, targetUrl, "Jpg", "", False)
    End Sub
    Public Sub Pie2(ByVal chart As dotnetCHARTING.Chart, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, ByVal yColumn As String, ByVal style As String, _
     ByVal displayNum As Integer, ByVal targetUrl As String, ByVal format As String, ByVal legendBoxPos As String, ByVal user3d As Boolean)
        Dim SC As New SeriesCollection()
        Dim s As New Series("")
        Dim view As New DataView(table)
        view.Sort = yColumn + "  desc"
        Dim index As Integer = 0
        Dim table2 As DataTable = view.ToTable()
        Dim otherE As New Element("其他")
        Dim other As Boolean = False
        Dim otherSum As Double = 0
        Dim c As Color = Color.FromArgb(49, 255, 49)
        Dim r As New Random(255)
        Dim c1 As Color = Color.FromArgb(255, 49, 255)
        Dim list As New List(Of Color)()
        list.Add(c)
        list.Add(c1)
        Dim i As Integer = 0
        While i < displayNum
            Dim cc As Color = Color.FromArgb((c.A + r.[Next](50000)) Mod 255, (c.B + r.[Next](456)) Mod 255, (c.G + r.[Next](1207)) Mod 100)
            list.Add(cc)
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        If legendBoxPos.ToLower() = "title" Then
            chart.TitleBox.Position = TitleBoxPosition.FullWithLegend
        End If
        For Each row As DataRow In table2.Rows
            If index > displayNum Then
                otherSum += Convert.ToDouble(row(yColumn).ToString())
                otherE.LabelTemplate = "%Name: %PercentOfTotal"
                other = True
                Continue For
            End If
            Dim telType As String = row(xColumn).ToString()
            telType = SetXColumn(telType)
            Dim e As New Element(telType)
            e.ToolTip = telType
            e.LabelTemplate = "%PercentOfTotal"
            e.LegendEntry.HeaderMode = LegendEntryHeaderMode.RepeatOnEachColumn
            e.LegendEntry.SortOrder = 0
            If Not String.IsNullOrEmpty(targetUrl) Then
                e.LegendEntry.URL = targetUrl + telType
                e.LegendEntry.URLTarget = "_self"
                e.URL = targetUrl + telType
                e.URLTarget = "_self"
            End If
            e.YValue = Convert.ToDouble(row(yColumn).ToString())
            s.Elements.Add(e)
            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
        Next
        If other Then
            s.Elements.Add(otherE)
        End If
        otherE.YValue = otherSum
        otherE.SmartLabel.Text = "其他"
        SC.Add(s)
        chart.TempDirectory = "temp"
        chart.Use3D = user3d
        chart.DefaultAxis.FormatString = "N"
        chart.DefaultAxis.CultureName = "zh-CN"
        chart.Palette = list.ToArray()
        chart.DefaultElement.SmartLabel.AutoWrap = True
        If style = "饼形" Then
            chart.Type = ChartType.Pies
        ElseIf style = "柱形" Then
            chart.Type = ChartType.Combo
        ElseIf style = "横柱形" Then
            chart.Type = ChartType.ComboHorizontal
        ElseIf style = "图片柱形" Then
            chart.Type = ChartType.Combo
            chart.DefaultSeries.ImageBarTemplate = "ethernetcable"
        ElseIf style = "雷达" Then
            chart.Type = ChartType.Radar
        ElseIf style = "圆锥" Then
            chart.Type = ChartType.MultipleGrouped
            chart.DefaultSeries.Type = SeriesTypeMultiple.Cone
        End If
        chart.Title = title
        chart.PieLabelMode = PieLabelMode.Automatic
        chart.DefaultElement.ShowValue = True
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.LegendBox.DefaultEntry.PaddingTop = 5
        Select Case format
            Case "Jpg"
                If True Then
                    chart.ImageFormat = ImageFormat.Jpg
                    Exit Select
                End If
            Case "Png"
                If True Then
                    chart.ImageFormat = ImageFormat.Png
                    Exit Select
                End If
            Case "Swf"
                If True Then
                    chart.ImageFormat = ImageFormat.Swf
                    Exit Select
                End If
        End Select
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)
    End Sub


    Public Shared Sub ComboHorizontal(ByVal chart As dotnetCHARTING.Chart, ByVal width As Integer, ByVal height As Integer, ByVal title As String, ByVal table As DataTable, ByVal xColumn As String, _
     ByVal yColumn As String)
        Dim SC As New SeriesCollection()
        Dim s As New Series()
        For Each row As DataRow In table.Rows
            Dim telType As String = row(xColumn).ToString()
            Dim e As New Element()
            e.Name = telType
            e.LabelTemplate = "%PercentOfTotal"
            e.YValue = Convert.ToDouble(row(yColumn).ToString())
            s.Elements.Add(e)
        Next
        SC.Add(s)
        chart.TempDirectory = "temp"
        chart.Use3D = False
        chart.DefaultAxis.Interval = 10
        chart.DefaultAxis.CultureName = "zh-CN"
        chart.Palette = New Color() {Color.FromArgb(49, 255, 49), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 99, 49), Color.FromArgb(0, 156, 255)}
        chart.DefaultElement.SmartLabel.AutoWrap = True
        chart.Type = ChartType.ComboHorizontal
        chart.Size = width + "x" + height
        chart.DefaultElement.SmartLabel.Text = ""
        chart.Title = title
        chart.DefaultElement.ShowValue = True
        chart.PieLabelMode = PieLabelMode.Outside
        chart.ShadingEffectMode = ShadingEffectMode.Three
        chart.NoDataLabel.Text = "没有数据显示"
        chart.SeriesCollection.Add(SC)
    End Sub
End Class




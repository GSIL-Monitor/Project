
Imports System
Imports System.Collections.Generic
Imports System.Text


Public Class StringPlus

    Public Shared Function GetStrArray(ByVal str As String, ByVal speater As Char, ByVal toLower As Boolean) As List(Of String)
        Dim list As New List(Of String)()
        Dim ss As String() = str.Split(speater)
        For Each s As String In ss
            If Not String.IsNullOrEmpty(s) AndAlso s <> speater.ToString() Then
                Dim strVal As String = s
                If toLower Then
                    strVal = s.ToLower()
                End If
                list.Add(strVal)
            End If
        Next
        Return list
    End Function

    Public Shared Function GetStrArray(ByVal str As String) As String()
        Return str.Split(New Char(",") {})
    End Function

    Public Shared Function GetArrayStr(ByVal list As List(Of String), ByVal speater As String) As String

        Dim sb As New StringBuilder()
        Dim i As Integer = 0
        While i < list.Count
            If i = list.Count - 1 Then
                sb.Append(list(i))
            Else
                sb.Append(list(i))
                sb.Append(speater)
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return sb.ToString()

    End Function

#Region "删除最后一个字符之后的字符"

    ''' <summary>
    ''' 删除最后结尾的一个逗号
    ''' </summary>
    Public Shared Function DelLastComma(ByVal str As String) As String

        Return str.Substring(0, str.LastIndexOf(","))

    End Function

    ''' <summary>
    ''' 删除最后结尾的指定字符后的字符
    ''' </summary>
    Public Shared Function DelLastChar(ByVal str As String, ByVal strchar As String) As String
        Return str.Substring(0, str.LastIndexOf(strchar))
    End Function
#End Region

    ''' <summary>
    ''' 转全角的函数(SBC case)
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Public Shared Function ToSBC(ByVal input As String) As String
        '半角转全角：
        Dim c As Char() = input.ToCharArray()
        Dim i As Integer = 0
        While i < c.Length
            If c(i) = Chr(32) Then
                c(i) = Chr(1288)
                Continue While
            End If
            If c(i) < Chr(127) Then
                c(i) = c(i + 65248)
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return New String(c)
    End Function

    ''' <summary>
    '''  转半角的函数(SBC case)
    ''' </summary>
    ''' <param name="input">输入</param>
    ''' <returns></returns>
    Public Shared Function ToDBC(ByVal input As String) As String
        Dim c As Char() = input.ToCharArray()
        Dim i As Integer = 0
        While i < c.Length
            If c(i) = Chr(12288) Then
                c(i) = Chr(32)
                Continue While
            End If
            If c(i) > Chr(65280) AndAlso c(i) < Chr(65375) Then
                c(i) = c(i - 65248)
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return New String(c)
    End Function

    Public Shared Function GetSubStringList(ByVal o_str As String, ByVal sepeater As Char) As List(Of String)
        Dim list As New List(Of String)()
        Dim ss As String() = o_str.Split(sepeater)
        For Each s As String In ss
            If Not String.IsNullOrEmpty(s) AndAlso s <> sepeater.ToString() Then
                list.Add(s)
            End If
        Next
        Return list
    End Function


#Region "将字符串样式转换为纯字符串"
    Public Shared Function GetCleanStyle(ByVal StrList As String, ByVal SplitString As String) As String
        Dim RetrunValue As String = ""
        '如果为空，返回空值
        If StrList = Nothing Then
            RetrunValue = ""
        Else
            '返回去掉分隔符
            Dim NewString As String = ""
            NewString = StrList.Replace(SplitString, "")
            RetrunValue = NewString
        End If
        Return RetrunValue
    End Function
#End Region

#Region "将字符串转换为新样式"
    Public Shared Function GetNewStyle(ByVal StrList As String, ByVal NewStyle As String, ByVal SplitString As String, ByRef [Error] As String) As String
        Dim ReturnValue As String = ""
        '如果输入空值，返回空，并给出错误提示
        If StrList = Nothing Then
            ReturnValue = ""
            [Error] = "请输入需要划分格式的字符串"
        Else
            '检查传入的字符串长度和样式是否匹配,如果不匹配，则说明使用错误。给出错误信息并返回空值
            Dim strListLength As Integer = StrList.Length
            Dim NewStyleLength As Integer = GetCleanStyle(NewStyle, SplitString).Length
            If strListLength <> NewStyleLength Then
                ReturnValue = ""
                [Error] = "样式格式的长度与输入的字符长度不符，请重新输入"
            Else
                '检查新样式中分隔符的位置
                Dim Lengstr As String = ""
                Dim i As Integer = 0
                While i < NewStyle.Length
                    If NewStyle.Substring(i, 1) = SplitString Then
                        Lengstr = Lengstr + "," + i
                    End If
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While
                If Lengstr <> "" Then
                    Lengstr = Lengstr.Substring(1)
                End If
                '将分隔符放在新样式中的位置
                Dim str As String() = Lengstr.Split(","c)
                For Each bb As String In str
                    StrList = StrList.Insert(Integer.Parse(bb), SplitString)
                Next
                '给出最后的结果
                ReturnValue = StrList
                '因为是正常的输出，没有错误
                [Error] = ""
            End If
        End If
        Return ReturnValue
    End Function

#End Region


    Public Shared Function CreateDateTimeString() As String
        Dim now As DateTime = DateTime.Now
        Dim dtString As String = now.Year.ToString() + now.Month.ToString().PadLeft(2, "0"c) + now.Day.ToString().PadLeft(2, "0"c) + now.Hour.ToString().PadLeft(2, "0"c) + now.Minute.ToString().PadLeft(2, "0"c) + now.Second.ToString().PadLeft(2, "0"c) + now.Millisecond.ToString().PadLeft(3, "0"c)
        Return (dtString)
    End Function







End Class

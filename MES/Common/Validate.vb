
Imports System.Text.RegularExpressions

''' <summary>
''' 验证函数
''' </summary>
''' <remarks></remarks>
Public Class Validate

    Private Const C_REGULAR_EMAIL = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Private Const C_REGULAR_PASSWORD = "^(?=^.{8,}$)((?=.*\d)|(?=[\x21-\x7e]+)(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"

    Private Shared RegEmail As New Regex(C_REGULAR_EMAIL)

    Public Shared Function IsTime(ByVal StrSource As String) As Boolean

        If StrSource.Trim() <> "" Then
            Return Regex.IsMatch(StrSource, "^((20|21|22|23|[0-1]?\d):[0-5]?\d)$") '09:30
        Else
            Return True
        End If

    End Function

    Public Shared Function IsPassWord(ByVal StrSource As String) As Boolean
        If StrSource.Trim() <> "" Then
            Return Regex.IsMatch(StrSource, C_REGULAR_PASSWORD)
        Else
            Return True
        End If

    End Function

    'Public Shared Function IsPassWord(ByVal StrSource As String) As Boolean

    '    Dim str As String = ""
    '    Dim gOk As Boolean = False
    '    If StrSource.Trim() <> "" Then
    '        If StrSource.Trim.Length > 7 Then
    '            gOk = True
    '        End If
    '        str = "01234567890"
    '        str = "abcdefghijklmnopqrstuvwxyz"
    '        If StrSource.Contains(str) Then
    '            gOk = True
    '        End If
    '        str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    '        If StrSource.Contains(str) Then
    '            gOk = True
    '        End If
    '        str = "~!@#$%^&*()`-=[]\;',./{}|_+:<>?"""
    '        If StrSource.Contains(str) Then
    '            gOk = True
    '        End If
    '    End If
    '    Return gOk

    'End Function

    '判断Str1是否是在Str2这个长的字符串中
    Public Shared Function StrIFIn(ByVal Str1 As String, ByVal Str2 As String) As Boolean
        If Str2.IndexOf(Str1) < 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    ''' <summary>
    ''' 验证电子邮件
    ''' </summary>
    ''' <param name="inputData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsEmail(ByVal inputData As String) As Boolean
        Dim m As Match = RegEmail.Match(inputData)
        Return m.Success
    End Function

    ''' <summary>
    ''' 验证是不是身份证号码
    ''' </summary>
    ''' <param name="_Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsCardNo(ByVal strID As String) As Boolean
        Dim flag As Boolean = False
        Dim newId As Char() = strID.ToCharArray()
        If (newId(newId.Length - 1) >= "0"c AndAlso newId(newId.Length - 1) <= "9"c) OrElse (newId(newId.Length - 1) = "X"c OrElse newId(newId.Length - 1) = "x"c) Then
            flag = True
        Else
            Return flag
        End If
        Dim i As Integer = 0
        While i < newId.Length - 1
            If newId(i) >= "0"c AndAlso newId(i) <= "9"c Then
                flag = True
            Else
                flag = False
                Exit While
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return flag
    End Function

    ''' <summary>
    ''' 验证校验位是否正确
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckSumDigit(ByVal strID As String) As Boolean

        Dim W As Integer() = {7, 9, 10, 5, 8, 4, _
         2, 1, 6, 3, 7, 9, _
         10, 5, 8, 4, 2, 1}
        Dim A As String() = {"1", "0", "X", "9", "8", "7", _
         "6", "5", "4", "3", "2"}
        Dim j As Integer = 0
        Dim s As Integer = 0
        Dim newid As String = Nothing
        Dim code As String = Nothing
        newid = strID
        '计算校验位    
        Dim i As Integer = 0
        While i < newid.Length - 1
            j = Convert.ToInt32(newid.Substring(i, 1)) * W(i)
            s = s + j
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        s = s Mod 11
        code = A(s)
        If code = newid.Substring(17, 1) Then
            Return True
        Else
            Return False
        End If

    End Function


    ''' <summary>
    ''' 取身份证上的出生日期
    ''' </summary>
    ''' <param name="stID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetBirhDate(ByVal stID As String) As String

        Dim flag As Integer = 0
        Dim temTime As String = ""
        Dim year As String = stID.Substring(6, 4)
        Dim month As String = stID.Substring(10, 2)
        Dim day As String = stID.Substring(12, 2)
        Try
            Dim ye As Integer = Integer.Parse(year)
            Dim mon As Integer = Integer.Parse(month)
            Dim da As Integer = Integer.Parse(day)
            If DateTime.Now.Year.CompareTo(ye) <> -1 Then
                System.Math.Max(System.Threading.Interlocked.Increment(flag), flag - 1)
            End If
            If mon >= 1 AndAlso mon <= 12 Then
                System.Math.Max(System.Threading.Interlocked.Increment(flag), flag - 1)
                Dim daty As Integer = DateTime.DaysInMonth(ye, mon)
                If daty >= da Then
                    System.Math.Max(System.Threading.Interlocked.Increment(flag), flag - 1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            flag = 0
        End Try
        If flag = 3 Then
            temTime = year + "-" + month + "-" + day
        End If
        Return temTime

    End Function


    ''' <summary>
    ''' 取性别
    ''' </summary>
    ''' <param name="_Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSex(ByVal _Id As String) As String

        Dim flag As String = "女"
        Dim Iid As Integer = Convert.ToInt32(_Id.Substring(14, 3))
        If Iid Mod 2 <> 0 Then
            flag = "男"
        End If
        Return flag

    End Function


End Class

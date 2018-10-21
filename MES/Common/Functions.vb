''' <summary>
''' 公共函数
''' </summary>
''' <remarks></remarks>
Public Class Functions


    ''' <summary>
    ''' 取得括号内的字符串
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCode(ByVal str As String) As String

        If str.Contains("(") = False Or str.Contains(")") = False Then
            Return ""
        End If
        Dim Code As String
        Dim strArr() As String = str.Split("(")
        Code = strArr(1)
        strArr = Code.Split(")")
        Code = strArr(0)
        Return Code

    End Function

    ''' <summary>
    ''' 询问
    ''' </summary>
    ''' <param name="msg">询问内容</param>
    ''' <param name="title">标题</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Speer(ByVal msg As String, Optional ByVal title As String = "提示") As MsgBoxResult
        Return MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, title)
    End Function

    ''' <summary>
    ''' 指定的列类型是否为数字
    ''' </summary>
    ''' <param name="col"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsNumberColumn(ByVal col As DataColumn) As Boolean
        If col.DataType Is GetType(Double) Or _
        col.DataType Is GetType(Decimal) Or _
                        col.DataType Is GetType(Integer) Or _
                        col.DataType Is GetType(Int16) Or _
                        col.DataType Is GetType(Int32) Or _
                       col.DataType Is GetType(Int64) Then
            Return True
        Else
            Return False
        End If
    End Function






End Class

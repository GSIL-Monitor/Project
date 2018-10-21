''' <summary>
''' 查询类
''' </summary>
''' <remarks></remarks>
Public Class Queryer
    Protected _Filter As String

    ''' <summary>
    ''' 获取或设置查询条件
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Filter() As String
        Get
            Return _Filter
        End Get
        Set(ByVal value As String)
            _Filter = value
        End Set
    End Property

    ''' <summary>
    ''' 追加查询条件
    ''' </summary>
    ''' <param name="Field">字段</param>
    ''' <param name="Operate">操作符</param>
    ''' <param name="Value">值</param>
    ''' <param name="bMark">是否用单引号包含Value</param>
    ''' <remarks></remarks>
    Public Sub Append(ByVal Field As String, ByVal Operate As String, ByVal Value As String, Optional ByVal bMark As Boolean = True)
        If Value <> "" Then
            Dim cMark As String = IIf(bMark, "'", "")
            _Filter &= IIf(_Filter <> "", " and ", "") & Field & Operate & cMark & Value & cMark
        End If
    End Sub

    Public Sub AppendLike(ByVal Field As String, ByVal Operate As String, ByVal Value As String, ByVal cLike As String, Optional ByVal bMark As Boolean = True)
        If Value <> "" Then
            Dim cMark As String = IIf(bMark, "'", "")
            _Filter &= IIf(_Filter <> "", " and ", "") & Field & Operate & Value & cLike
        End If
    End Sub


    ''' <summary>
    ''' 追加查询条件
    ''' </summary>
    ''' <param name="bRelation">关系:false_And,true_Or</param>
    ''' <param name="Field">字段</param>
    ''' <param name="Operate">操作符</param>
    ''' <param name="Value">值</param>
    ''' <param name="bMark">是否用单引号包含Value</param>
    ''' <param name="bIgnoreNull">是否忽略空值</param>
    ''' <remarks></remarks>
    Public Sub Append(ByVal bRelation As Boolean, ByVal Field As String, ByVal Operate As String, ByVal Value As String, Optional ByVal bMark As Boolean = True, Optional ByVal bIgnoreNull As Boolean = True)

        If bIgnoreNull And Value = "" Then
            Exit Sub
        End If
        Dim cMark As String = IIf(bMark, "'", "")
        Dim Relation As String = IIf(bRelation, " Or ", " And ")
        _Filter &= IIf(_Filter <> "", Relation, "") & Field & Operate & cMark & Value & cMark

    End Sub

End Class


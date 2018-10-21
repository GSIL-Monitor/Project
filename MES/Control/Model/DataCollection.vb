''' <summary>
''' 数据集合
''' </summary>
''' <remarks></remarks>
Public Class DataCollection
    Private Datas As New ArrayList
    ''' <summary>
    ''' 按名称获取或设置值
    ''' </summary>
    ''' <param name="Name">名称</param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Default Public Property Item(ByVal Name As String) As Object
        Get
            For Each m As Data In Datas
                If Trim(m.Name).ToLower = Trim(Name).ToLower Then
                    Return m.Value
                End If
            Next
        End Get
        Set(ByVal value As Object)
l:          For Each m As Data In Datas
                If Trim(m.Name).ToLower = Trim(Name).ToLower Then
                    Datas.Remove(m)
                    GoTo l
                End If
            Next
            Dim mdl As New Data
            mdl.Name = Name
            mdl.Value = value
            Datas.Add(mdl)
        End Set
    End Property

End Class

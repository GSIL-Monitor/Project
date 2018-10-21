''' <summary>
''' 数据
''' </summary>
''' <remarks></remarks>
Friend Class Data
    Private _Name As String
    Private _Value As Object
    ''' <summary>
    ''' 名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    ''' <summary>
    ''' 值
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Value() As Object
        Get
            Return _Value
        End Get
        Set(ByVal value As Object)
            _Value = value
        End Set
    End Property
End Class

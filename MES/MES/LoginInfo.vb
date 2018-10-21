''' <summary>
''' 登录信息
''' </summary>
''' <remarks></remarks>
Public Class LoginInfo

    Private Shared _UserName As String
    Private Shared _bAdm As Boolean
    Private Shared _LoginDate As Date = Now.Date
    Private Shared _ConnString As String
    Private Shared _cPsnCode As String
    Private Shared _cDataBase As String

    ''' <summary>
    ''' 用户名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    ''' <summary>
    ''' 是否管理员
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property bAdm() As Boolean
        Get
            Return _bAdm
        End Get
        Set(ByVal value As Boolean)
            _bAdm = value
        End Set
    End Property

    ''' <summary>
    ''' 登录日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property LoginDate() As Date
        Get
            Return _LoginDate
        End Get
        Set(ByVal value As Date)
            _LoginDate = value
        End Set
    End Property

    ''' <summary>
    ''' 数据库连接字符串
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
        End Set
    End Property


    Public Shared Property cPsnCode() As String
        Get
            Return _cPsnCode
        End Get
        Set(ByVal value As String)
            _cPsnCode = value
        End Set
    End Property

    Public Shared Property cDataBase() As String
        Get
            Return _cDataBase
        End Get
        Set(ByVal value As String)
            _cDataBase = value
        End Set
    End Property

End Class

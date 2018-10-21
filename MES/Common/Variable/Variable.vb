Imports Common.Debug
''' <summary>
''' 变量
''' </summary>
''' <remarks></remarks>
Public Class Variable
    ''' <summary>
    ''' 写入值
    ''' </summary>
    ''' <param name="VarName"></param>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Private Shared Sub Write(ByVal VarName As String, ByVal Value As String)
        Dim FileName As String = VarName & ".txt"
        File.Write(FileName, Value)
    End Sub
    ''' <summary>
    ''' 读取值
    ''' </summary>
    ''' <param name="VarName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function Read(ByVal VarName As String) As String
        Dim FileName As String = VarName & ".txt"
        Dim Value As String = File.Read(FileName)
        Return Value
    End Function
    ''' <summary>
    ''' 加密
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function Encrypt(ByVal Value As String) As String
        Try
            Value = Trim(Value)
            If Value = "" Then
                Return Value
            End If
            Dim str As String
            For i As Integer = 0 To Value.Length - 1
                Dim iAsc As Integer = Asc(Value.Chars(i))
                str &= iAsc.ToString.PadLeft(3, "0")
            Next
            Return str
        Catch ex As Exception
            myMsg(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 解密
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function UnEncrypt(ByVal Value As String) As String
        Try
            Value = Trim(Value)
            If Value = "" Then
                Return Value
            End If
            Dim str As String
            For i As Integer = 0 To Value.Length - 1 Step 3
                Dim iAsc As Integer = Value(i) & Value(i + 1) & Value(i + 2)
                str &= Chr(iAsc)
            Next
            Return str
        Catch ex As Exception
            myMsg(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 默认登录用户
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property DefaultUser() As String
        Get
            Return Read("DefaultUser")
        End Get
        Set(ByVal value As String)
            Write("DefaultUser", value)
        End Set
    End Property

    Public Shared Property RemenberPassword() As String
        Get
            Return Read("RemenberPassword")
        End Get
        Set(ByVal value As String)
            Write("RemenberPassword", value)
        End Set
    End Property


    Public Shared Property DefaultPassword() As String
        Get
            Return Read("DefaultPassword")
        End Get
        Set(ByVal value As String)
            Write("DefaultPassword", value)
        End Set
    End Property

    Public Shared Property DefaultDataBase() As String
        Get
            Return Read("DefaultDataBase")
        End Get
        Set(ByVal value As String)
            Write("DefaultDataBase", value)
        End Set
    End Property

    ''' <summary>
    ''' 登录方式
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property LoginType() As String
        Get
            Return Read("LoginType")
        End Get
        Set(ByVal value As String)
            Write("LoginType", value)
        End Set
    End Property

    ''' <summary>
    ''' 数据库类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property DataBaseType() As String
        Get
            Return Read("DataBaseType")
        End Get
        Set(ByVal value As String)
            Write("DataBaseType", value)
        End Set
    End Property

    ''' <summary>
    ''' SQL服务器名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property SQLServerName() As String
        Get
            Return Read("SQLServerName")
        End Get
        Set(ByVal value As String)
            Write("SQLServerName", value)
        End Set
    End Property
    ''' <summary>
    ''' SQL数据库名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property SQLDataBase() As String
        Get
            Return Read("SQLDataBase")
        End Get
        Set(ByVal value As String)
            Write("SQLDataBase", value)
        End Set
    End Property
    ''' <summary>
    ''' SQl连接密码
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property SQLPW() As String
        Get
            Dim Value As String = Read("SQLPW")
            Return UnEncrypt(Value)
        End Get
        Set(ByVal value As String)
            value = Encrypt(value)
            Write("SQLPW", value)
        End Set
    End Property

    ''' <summary>
    ''' SQl连接用户
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property SQLSA() As String
        Get
            Dim Value As String = Read("SQLSA")
            Return UnEncrypt(Value)
        End Get
        Set(ByVal value As String)
            value = Encrypt(value)
            Write("SQLSA", value)
        End Set
    End Property

    ''' <summary>
    ''' Access路径
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property AccessPath() As String
        Get
            Return Read("AccessPath")
        End Get
        Set(ByVal value As String)
            Write("AccessPath", value)
        End Set
    End Property
    ''' <summary>
    ''' Access密码
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property AccessPW() As String
        Get
            Dim Value As String = Read("AccessPW")
            Return UnEncrypt(Value)
        End Get
        Set(ByVal value As String)
            value = Encrypt(value)
            Write("AccessPW", value)
        End Set
    End Property

End Class

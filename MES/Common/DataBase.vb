
Imports Common.Debug
Imports Common.ConvertData

''' <summary>
''' 数据库操作
''' </summary>
''' <remarks></remarks>
Public Class DataBase

    ''' <summary>
    ''' 数据库提供程序
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DataProvider
        AccessClient
        OracleClient
        SqlClient
    End Enum

    Public Structure ProcFields
        Public FieldName As String
        Public FieldValue As String
    End Structure

    Private Shared _Provider As DataProvider = DataProvider.SqlClient
    Private Shared _DbProviderFactory As Data.Common.DbProviderFactory
    Private Shared _Conn As Data.Common.DbConnection  '数据连接

    ''' <summary>
    ''' 获取或设置数据库提供程序
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property Provider() As DataProvider
        Get
            Return _Provider
        End Get
        Set(ByVal value As DataProvider)
            _Provider = value
            Dim ProviderName As String = GetProviderName(_Provider)
            _DbProviderFactory = Data.Common.DbProviderFactories.GetFactory(ProviderName)
        End Set
    End Property

    ''' <summary>
    ''' 提供创建数据库实现类的方法
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property DBProviderFactory() As Data.Common.DbProviderFactory
        Get
            If _DbProviderFactory Is Nothing Then
                Dim ProviderName As String = GetProviderName(_Provider)
                _DbProviderFactory = Data.Common.DbProviderFactories.GetFactory(ProviderName)
            End If
            Return _DbProviderFactory
        End Get
    End Property

    ''' <summary>
    ''' 获取或设置数据库连接
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property Conn() As Data.Common.DbConnection
        Get
            Return _Conn
        End Get
        Set(ByVal value As Data.Common.DbConnection)
            _Conn = value
        End Set
    End Property



    ''' <summary>
    ''' 获取数据库提供程序名
    ''' </summary>
    ''' <param name="Provider"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Shared Function GetProviderName(ByVal Provider As DataProvider) As String
        If Provider = DataProvider.AccessClient Then
            Return "System.Data.OleDb"
        ElseIf Provider = DataProvider.OracleClient Then
            Return "System.Data.OracleClient"
        ElseIf Provider = DataProvider.SqlClient Then
            Return "System.Data.SqlClient"
        End If
    End Function

    ''' <summary>
    ''' 获取数据库所在服务器名
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetServerName() As String
        Dim ServerName As String
        Select Case Common.DataBase.Provider
            Case Common.DataBase.DataProvider.AccessClient
                If Common.DataBase.Conn.Database.StartsWith("\\") Then
                    ServerName = Common.DataBase.Conn.Database.Replace("\\", "")
                    ServerName = ServerName.Split("\")(0)
                Else
                    ServerName = My.Computer.Name
                End If
            Case Common.DataBase.DataProvider.SqlClient
                ServerName = Common.DataBase.Conn.DataSource
        End Select
        Return ServerName
    End Function

    ''' <summary>
    ''' 执行查询,并返回DataTable
    ''' </summary>
    ''' <param name="sql">查询语句</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal sql As String) As DataTable

        Dim da As Data.Common.DbDataAdapter = _DbProviderFactory.CreateDataAdapter
        Dim cmd As Data.Common.DbCommand = _DbProviderFactory.CreateCommand
        cmd.Connection = Conn
        da.SelectCommand = cmd
        cmd.CommandTimeout = 0
        cmd.CommandText = sql
        Dim dt As New DataTable
        da.Fill(dt)

        Return dt

    End Function

    ''' <summary>
    ''' 执行查询,并返回DataTable
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="cmd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTable(ByVal sql As String, ByVal cmd As Data.Common.DbCommand) As DataTable

        If cmd IsNot Nothing Then
            cmd.CommandTimeout = 0
            Dim da As Data.Common.DbDataAdapter = _DbProviderFactory.CreateDataAdapter
            cmd.CommandText = sql
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Else
            Return GetDataTable(sql)
        End If

    End Function

    Public Shared Function GetDataTable(ByVal SqlConn As SqlClient.SqlConnection, sql As String) As DataTable

        Try

            Dim da As Data.Common.DbDataAdapter = _DbProviderFactory.CreateDataAdapter
            Dim cmd As Data.Common.DbCommand = _DbProviderFactory.CreateCommand
            cmd.Connection = SqlConn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw
        Finally
            SqlConn.Close()
        End Try
        

    End Function


    ''' <summary>
    ''' 执行查询，并返回结果集的第一行第一列内容
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ExecCmd(ByVal sql As String) As Object

        Try
            Dim cmd As Data.Common.DbCommand = _DbProviderFactory.CreateCommand
            cmd.CommandText = sql
            cmd.Connection = Conn
            cmd.CommandTimeout = 0
            Dim Result As Object
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            Result = cmd.ExecuteScalar()
            Return Result
        Catch ex As Exception
            Throw
        Finally
            Conn.Close()
        End Try

    End Function

    ''' <summary>
    ''' 执行查询，并返回结果集的第一行第一列内容
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="cmd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Shared Function ExecCmd(ByVal sql As String, ByVal cmd As Data.Common.DbCommand) As Object

        Try
            If Not cmd Is Nothing Then
                Dim Result As Object
                cmd.CommandTimeout = 0
                cmd.CommandText = sql
                Result = cmd.ExecuteScalar()
                Return Result
            Else
                Return ExecCmd(sql)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Function


    ''' <summary>
    ''' 数字字段
    ''' </summary>
    ''' <param name="cField"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecPro(ByVal Sql As String, ByVal size As Integer, ByVal values As Object)

        'Select Case Common.DataBase.Provider
        'End Select
        Try
            Dim cmd As New SqlClient.SqlCommand
            'Dim cmd As Data.Common.DbCommand = _DbProviderFactory.CreateCommand
            cmd.Connection = Conn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "insert into xia (name) values (@UpdateImage)"
            cmd.Parameters.Add("@UpdateImage", SqlDbType.Image, size)
            cmd.Parameters("@UpdateImage").Value = values
            Dim Result As Object
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            Result = cmd.ExecuteNonQuery
            Return Result
        Catch ex As Exception
            Throw
        Finally
            Conn.Close()
        End Try


    End Function



    ''' <summary>
    ''' 是否存在表
    ''' </summary>
    ''' <param name="tbName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExistTable(ByVal tbName As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Boolean
        Try
            Dim str As String = "select top 1 * from " & tbName
            ExecCmd(str, cmd)
            Return True
        Catch ex As Exception

        End Try
    End Function


    ''' <summary>
    ''' 是否存在字段
    ''' </summary>
    ''' <param name="tbName"></param>
    ''' <param name="Field"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExistField(ByVal tbName As String, ByVal Field As String, Optional ByVal cmd As System.Data.Common.DbCommand = Nothing) As Boolean
        Try
            Dim str As String = "select top 1 " & Field & " from " & tbName
            ExecCmd(str, cmd)
            Return True
        Catch ex As Exception

        End Try
    End Function

    ''' <summary>
    ''' 获取日期字符串
    ''' </summary>
    ''' <param name="dDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDate(ByVal dDate As Date) As String
        Dim str As String
        If dDate = Nothing Then
            Return "Null"
        End If
        If IsDate(dDate) = False Then
            Return "Null"
        End If
        Select Case Common.DataBase.Provider
            Case DataProvider.AccessClient
                str = "#" & dDate & "#"
            Case DataProvider.OracleClient
                str = "#" & dDate & "#"
            Case DataProvider.SqlClient
                str = "'" & dDate & "'"
        End Select
        Return str
    End Function

    ''' <summary>
    ''' 获取布尔值字符串
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetBoolean(ByVal Value As Boolean) As String
        Dim str As String
        Select Case Common.DataBase.Provider
            Case DataProvider.AccessClient
                str = IIf(Value, "true", "false")
            Case DataProvider.OracleClient
                str = IIf(Value, "1", "0")
            Case DataProvider.SqlClient
                str = IIf(Value, "1", "0")
        End Select
        Return str
    End Function

    ''' <summary>
    ''' 获取字符串
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetString(ByVal Value As String) As String
        Dim str As String
        Select Case Common.DataBase.Provider
            Case DataProvider.AccessClient
                If Trim(Value) = "" Then
                    str = "Null"
                Else
                    str = "'" & Value & "'"
                End If
            Case DataProvider.OracleClient
                str = "'" & Value & "'"
            Case DataProvider.SqlClient
                str = "'" & Value & "'"
        End Select
        Return str
    End Function


    Public Shared Function GetNum(ByVal Value As String) As String

        Dim str As String
        Select Case Common.DataBase.Provider

            Case DataProvider.AccessClient
                If Trim(Value) = "" Then
                    str = "Null"
                Else
                    str = "'" & Value & "'"
                End If

            Case DataProvider.OracleClient
                str = "" & Value & ""

            Case DataProvider.SqlClient
                If Trim(Value) = "" Then
                    str = "Null"
                Else
                    str = "" & Value & ""
                End If
        End Select
        Return str
    End Function

    ''' <summary>
    ''' 字符串字段
    ''' </summary>
    ''' <param name="cField"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StringField(ByVal cField As String) As String
        Select Case Common.DataBase.Provider
            Case DataProvider.AccessClient
                Return "iif(isNull(" & cField & "),''," & cField & ")"
            Case DataProvider.OracleClient
                Return "isNull(" & cField & ",'')"
            Case DataProvider.SqlClient
                Return "isNull(" & cField & ",'')"
        End Select
    End Function

    ''' <summary>
    ''' 数字字段
    ''' </summary>
    ''' <param name="cField"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function NumberField(ByVal cField As String) As String
        Select Case Common.DataBase.Provider
            Case DataProvider.AccessClient
                Return "iif(isNull(" & cField & "),0," & cField & ")"
            Case DataProvider.OracleClient
                Return "isNull(" & cField & ",0)"
            Case DataProvider.SqlClient
                Return "isNull(" & cField & ",0)"
        End Select
    End Function

    Public Overloads Shared Function ExecNonQuery(ByVal sql As String) As Object

        Try
            Dim cmd As Data.Common.DbCommand = _DbProviderFactory.CreateCommand
            cmd.CommandText = sql
            cmd.Connection = Conn
            cmd.CommandTimeout = 0
            Dim Result As Object
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            Result = cmd.ExecuteNonQuery
            Return Result
        Catch ex As Exception
            Throw
        Finally
            Conn.Close()
        End Try

    End Function


    Public Overloads Shared Function ExecNonQuery(ByVal sql As String, ByVal cmd As Data.Common.DbCommand) As Object

        Try
            If Not cmd Is Nothing Then
                Dim Result As Object
                cmd.CommandTimeout = 0
                cmd.CommandText = sql
                Result = cmd.ExecuteNonQuery()
                Return Result
            Else
                Return ExecNonQuery(sql)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Function


    '考勤钟服务器
    Public Shared ConnString As String = "Data Source=192.168.100.6;Initial Catalog=ZKTime;User ID=sa;Password=9898"

    '
    Public Shared ConnMRPString As String = "Data Source=192.168.100.6;Initial Catalog=wxdfproj;User ID=sh;Password=sh"

    'U8
    Public Shared ConnU8String As String = "Data Source=192.168.100.19;Initial Catalog=UFDATA_004_2016;Persist Security Info=True;User ID=UFSALE;Password=UFSALE;"


    Public Shared Function getNewConn() As SqlClient.SqlConnection
        Dim conn As New SqlClient.SqlConnection(ConnString)
        Return conn
    End Function

End Class



Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class SQLModel

    '数据库连接
    'Public Shared Function SQLCONN(ByVal Conn As SqlConnection) As Boolean
    '    Dim fOK As Boolean = False
    '    '判断是否可以连接 
    '    Try
    '        'XML文件配置方式 
    '        'SQLSERVER = GetKeyValue("ServerName") 
    '        'SQLDATABASE = GetKeyValue("Database") 
    '        'SQLNAME = GetKeyValue("UserID") 
    '        'SQLPASS = GetKeyValue("PassWord") 

    '        ''SQL SERVER 2000 
    '        If Conn.State = ConnectionState.Closed Then
    '            Conn.ConnectionString = ""
    '            Conn.Open()
    '        End If

    '        'SQL SERVER EXPRESS 2005 
    '        'If Conn.State = ConnectionState.Closed Then 
    '        ' Conn.ConnectionString = "Data Source=.\SQLEXPRESS;" 
    '        ' Conn.ConnectionString &= " AttachDbFilename=|DataDirectory|\PLAN_Data.MDF;" 
    '        ' Conn.ConnectionString &= " Integrated Security=True;" 
    '        ' Conn.ConnectionString &= " Connect Timeout=30;" 
    '        ' Conn.ConnectionString &= " User Instance=True" 
    '        ' Conn.Open() 
    '        'End If 

    '        fOK = True
    '    Catch ex As Exception

    '        fOK = False
    '    End Try

    '    Return fOK

    'End Function

    '数据关闭
    'Public Shared Function SQLCLOSE(ByVal Conn As SqlConnection) As Boolean

    '    Dim fOK As Boolean = False
    '    Try
    '        If Conn.State = ConnectionState.Open Then
    '            Conn.Close()
    '        End If
    '        fOK = True
    '    Catch
    '        fOK = False
    '    End Try
    '    Return fOK

    'End Function




    '用于SELECT 查询中存放新的临时表 
    Public Shared Function SQLFILL(ByVal Conn As SqlConnection, ByVal Adap As SqlDataAdapter, ByVal DS As DataSet, ByVal SqlStr As String, ByVal TBName As String) As Boolean

        Dim fOK As Boolean = False
        Try
            Dim SqlCommand As New SqlCommand(SqlStr, Conn)
            SqlCommand.CommandTimeout = 0
            Adap.SelectCommand = SqlCommand
            If DS.Tables.Contains(TBName) = True Then
                DS.Tables.Remove(TBName)
            End If
            Adap.Fill(DS, TBName)
            fOK = True
        Catch ex As Exception
            Throw ex
            fOK = False
        End Try
        Return fOK

    End Function

    '用户UTEPDA
    '用于INSERT UPDATE，DELETE 
    Public Shared Function SQLNonQuery(ByVal Conn As SqlConnection, ByVal SqlStr As String) As Boolean

        Dim SqlCommand As New SqlCommand(SqlStr, Common.DataBase.Conn)
        Dim fOK As Boolean = False
        Try
            SqlCommand.CommandTimeout = 0
            SqlCommand.ExecuteNonQuery()
            fOK = True
        Catch ex As Exception
            Throw ex
            '写入EventLog 
            fOK = False
        End Try
        Return fOK

    End Function

    '用于读纪录 
    Public Shared Function SQLREAD(ByVal Conn As SqlConnection, ByVal Sqlstr As String, ByRef iRead As SqlDataReader) As Boolean

        Dim SqlCommand As New SqlCommand(Sqlstr, Conn)
        Dim fOK As Boolean = False
        Try
            SqlCommand.CommandTimeout = 60
            iRead = SqlCommand.ExecuteReader()
            fOK = True
        Catch ex As Exception
            Throw ex
            fOK = False
        End Try
        Return fOK

    End Function

End Class

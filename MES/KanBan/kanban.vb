
Imports Common.Debug
Imports Common


Public Class kanban

    Private Sub New()

    End Sub

    Public Shared Function Create() As kanban
        Return New kanban
    End Function

    Public Shared Sub IniDataConnection()

        '取配置文件
        Dim SQLServerName As String = Variable.SQLServerName
        Dim SQLDataBase As String = Variable.SQLDataBase
        Dim SQLPW As String = Variable.SQLPW
        Dim SQLSA As String = Variable.SQLSA

        Dim str As String = "user id=" & SQLSA & ";password=" & SQLPW & ";initial catalog=" & _
        SQLDataBase & ";data source=" & SQLServerName
        Global.Common.DataBase.Provider = Global.Common.DataBase.DataProvider.SqlClient
        Global.Common.DataBase.Conn = Global.Common.DataBase.DBProviderFactory.CreateConnection
        Global.Common.DataBase.Conn.ConnectionString = str


    End Sub





End Class

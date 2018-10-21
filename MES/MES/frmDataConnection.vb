Imports Common
Imports Common.Debug
Imports System.Windows.Forms

''' <summary>
''' 数据库连接
''' </summary>
''' <remarks></remarks>
Friend Class frmDataConnection
    ''' <summary>
    ''' 初始化数据连接语句
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub IniDataConnection()

        Dim value As String = Variable.DataBaseType
        If value.ToLower = "SQL".ToLower Then
            Dim SQLServerName As String = Variable.SQLServerName
            Dim SQLDataBase As String = Variable.SQLDataBase
            Dim SQLPW As String = Variable.SQLPW
            Dim SQLSA As String = Variable.SQLSA
            Dim str As String = "user id=" & SQLSA & ";password=" & SQLPW & ";initial catalog=" & _
            SQLDataBase & ";data source=" & SQLServerName
            Global.Common.DataBase.Provider = Global.Common.DataBase.DataProvider.SqlClient
            Global.Common.DataBase.Conn = Global.Common.DataBase.DBProviderFactory.CreateConnection
            Global.Common.DataBase.Conn.ConnectionString = str
            LoginInfo.ConnString = str
        ElseIf value.ToLower = "Access".ToLower Then
            Dim AccessPath As String = Variable.AccessPath
            Dim AccessPW As String = Variable.AccessPW
            Dim str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AccessPath & _
              ";User id=Admin;PassWord=" & AccessPW
            Global.Common.DataBase.Provider = Global.Common.DataBase.DataProvider.AccessClient
            Global.Common.DataBase.Conn = Global.Common.DataBase.DBProviderFactory.CreateConnection
            Global.Common.DataBase.Conn.ConnectionString = str
            LoginInfo.ConnString = str
        End If

    End Sub

    ''' <summary>
    ''' 测试连接
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TestDataConnection() As Common.ExecResult

        Try
            Common.DataBase.Conn.Open()
            Common.DataBase.Conn.Close()
        Catch ex As Exception
            Return Common.ExecResult.Fail
        End Try

    End Function

    ''' <summary>
    ''' 显示设置
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowSetting()

        Dim value As String = Variable.DataBaseType
        If value.ToLower = "SQL".ToLower Then
            Me.Tab.SelectedTab = Me.TPSQL
        ElseIf value.ToLower = "Access".ToLower Then
            Me.Tab.SelectedTab = Me.TPAccess
        End If
        Me.txtSQLServerName.Text = Variable.SQLServerName
        If Me.txtSQLServerName.Text = "" Then
            Me.txtSQLServerName.Text = "Localhost"
        End If
        Me.txtSQLDataBase.Text = Variable.SQLDataBase
        Me.txtSQLPW.Text = Variable.SQLPW
        Me.txtSQLSA.Text = Variable.SQLSA
        Me.txtAccessPath.Text = Variable.AccessPath
        Me.txtAccessPW.Text = Variable.AccessPW

    End Sub

    Private Sub frmDataConnection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowSetting()
    End Sub

    ''' <summary>
    ''' 保存设置
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveSetting()
        If Tab.SelectedTab Is Me.TPSQL Then
            Variable.DataBaseType = "SQL"
        ElseIf Tab.SelectedTab Is Me.TPAccess Then
            Variable.DataBaseType = "Access"
        End If
        Variable.SQLServerName = Me.txtSQLServerName.Text
        Variable.SQLDataBase = Me.txtSQLDataBase.Text
        Variable.SQLPW = Me.txtSQLPW.Text
        Variable.SQLSA = Me.txtSQLSA.Text
        Variable.AccessPath = Me.txtAccessPath.Text
        Variable.AccessPW = Me.txtAccessPW.Text


    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
        Dim Value As String = Variable.DataBaseType
        If Value.ToLower = "SQL".ToLower Then
            If Trim(Me.txtSQLServerName.Text) = "" Then
                myMsg("[" & Me.txtSQLServerName.Caption & "]必填")
                Return False
            End If
            If Trim(Me.txtSQLDataBase.Text) = "" Then
                myMsg("[" & Me.txtSQLDataBase.Caption & "]必填")
                Return False
            End If
            If Trim(Me.txtSQLSA.Text) = "" Then
                myMsg("[" & Me.txtSQLSA.Caption & "]必填")
                Return False
            End If
        ElseIf Value.ToLower = "Access".ToLower Then
            If Trim(Me.txtAccessPath.Text) = "" Then
                myMsg("[" & Me.txtAccessPath.Caption & "]必填")
                Return False
            End If
        End If
    End Function

    Private Sub btnSQLOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnSQLOK.Click, btnSQLCancel.Click, btnAccessOK.Click, btnAccessCancel.Click

        Select Case sender.name
            Case Me.btnSQLOK.Name, Me.btnAccessOK.Name
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Me.SaveSetting()
                    If CheckData() = False Then Exit Sub
                    IniDataConnection()
                    If TestDataConnection() = Common.ExecResult.Succeed Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        myMsg("数据库连接失败,请修改连接")
                    End If
                Catch ex As Exception
                Finally
                    Me.Cursor = Cursors.Default
                End Try

            Case Me.btnSQLCancel.Name, Me.btnAccessCancel.Name
                Me.Close()

        End Select

    End Sub

    Private Sub btnAccessPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccessPath.Click

        Dim fd As New OpenFileDialog
        fd.Filter = "*.mdb|*.mdb"
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtAccessPath.Text = fd.FileName
        End If

    End Sub

End Class
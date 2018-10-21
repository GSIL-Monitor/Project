Friend Class frmDataGridSetting

    Private ColumnInfos As New ColumnInfoCollection

    Sub New(ByVal DataGridView As DataGridView)

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ColumnInfos = Me.toColumnInfoCollection(DataGridView.Columns)
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoGenerateColumns = False
        Me.dg.DataSource = ColumnInfos

    End Sub

    ''' <summary>
    ''' 获取列信息
    ''' </summary>
    ''' <param name="Columns"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function toColumnInfoCollection(ByVal Columns As DataGridViewColumnCollection) As ColumnInfoCollection

        Dim ColumnInfos As New ColumnInfoCollection
        For Each col As DataGridViewColumn In Columns
            Dim ColumnInfo As New ColumnInfo
            ColumnInfo.Column = col
            ColumnInfo.Alignment = Num2Word(col.DefaultCellStyle.Alignment)
            ColumnInfos.Add(ColumnInfo)
        Next
        Global.Common.ListHelper.Sort(ColumnInfos, "iDisplayIndex")
        Return ColumnInfos

    End Function

    Private Sub frmDataGridSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ColAlignment.Items.Add("靠左")  '靠左 Left
        ColAlignment.Items.Add("居中")  '居中 Center
        ColAlignment.Items.Add("靠右")  '靠右 Right

    End Sub

    Public Shared Function Word2Num(ByVal cAlignment As String) As Integer

        Select Case cAlignment
            Case "靠左"
                Return 16
            Case "居中"
                Return 32
            Case "靠右"
                Return 64
        End Select

    End Function

    Public Function Num2Word(ByVal iAlignment As Integer) As String

        Select Case iAlignment
            Case "16"
                Return "靠左"
            Case "32"
                Return "居中"
            Case "64"
                Return "靠右"
        End Select

    End Function

    ''' <summary>
    ''' 列信息
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ColumnInfo

        Private _cColumnName As String
        Private _cColumnByName As String
        Private _iWidth As Integer
        Private _bShow As Boolean
        Private _iDisplayIndex As Integer
        Private _iAlignment As String
        Private _Column As DataGridViewColumn

        ''' <summary>
        ''' 原列名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cColumnName() As String
            Get
                Return _cColumnName
            End Get
            Set(ByVal value As String)
                _cColumnName = value
            End Set
        End Property
        ''' <summary>
        ''' 别名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cColumnByName() As String
            Get
                Return _cColumnByName
            End Get
            Set(ByVal value As String)
                _cColumnByName = value
                _Column.HeaderText = value
            End Set
        End Property
        ''' <summary>
        ''' 宽度
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property iWidth() As Integer
            Get
                Return _iWidth
            End Get
            Set(ByVal value As Integer)
                _iWidth = value
                _Column.Width = value
            End Set
        End Property
        ''' <summary>
        ''' 是否显示
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property bShow() As Boolean
            Get
                Return _bShow
            End Get
            Set(ByVal value As Boolean)
                _bShow = value
                _Column.Visible = value
            End Set
        End Property

        ''' <summary>
        ''' 显示位置
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property iDisplayIndex() As Integer

            Get
                Return _iDisplayIndex
            End Get
            Set(ByVal value As Integer)
                _iDisplayIndex = value
                _Column.DisplayIndex = value
            End Set

        End Property

        '对齐方式
        Public Property Alignment() As String

            Get
                Return _iAlignment
            End Get
            Set(ByVal value As String)
                _iAlignment = value
                _Column.DefaultCellStyle.Alignment = Word2Num(value)
            End Set

        End Property


        ''' <summary>
        ''' 表格列
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Column() As DataGridViewColumn
            Get
                Return _Column
            End Get
            Set(ByVal value As DataGridViewColumn)
                _Column = value
                _cColumnName = value.Name
                _cColumnByName = value.HeaderText
                _iWidth = value.Width
                _bShow = value.Visible
                _iDisplayIndex = value.DisplayIndex
                _iAlignment = value.DefaultCellStyle.Alignment
            End Set
        End Property
    End Class

    ''' <summary>
    ''' ColumnInfo的集合
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ColumnInfoCollection
        Inherits Collections.ObjectModel.Collection(Of ColumnInfo)

    End Class

    ''' <summary>
    ''' 定位
    ''' </summary>
    ''' <param name="mdl"></param>
    ''' <remarks></remarks>
    Private Sub Place(ByVal mdl As ColumnInfo)
        For Each dr As DataGridViewRow In dg.Rows
            If dr.DataBoundItem Is mdl Then
                dg.CurrentCell = dr.Cells(dg.CurrentCell.ColumnIndex)
            End If
        Next
    End Sub

    Private Sub btnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop.Click, _
     btnPrevious.Click, btnNext.Click, btnBottom.Click, btnSelectAll.Click, btnSelectNo.Click, btnClose.Click
        Select Case sender.Name
            Case btnTop.Name

                Dim dr As DataGridViewRow = dg.CurrentRow
                If dr IsNot Nothing Then
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    Dim index As Integer = ColumnInfos.IndexOf(ColumnInfo)
                    If index <> 0 Then
                        ColumnInfos.Remove(ColumnInfo)
                        ColumnInfos.Insert(0, ColumnInfo)
                        ColumnInfo.Column.DisplayIndex = 0
                        dg.DataSource = Nothing
                        dg.DataSource = ColumnInfos
                        Me.Place(ColumnInfo)
                    End If
                End If

            Case btnPrevious.Name

                Dim dr As DataGridViewRow = dg.CurrentRow
                If dr IsNot Nothing Then
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    Dim index As Integer = ColumnInfos.IndexOf(ColumnInfo)
                    If index <> 0 Then
                        ColumnInfos.Remove(ColumnInfo)
                        ColumnInfos.Insert(index - 1, ColumnInfo)
                        ColumnInfo.Column.DisplayIndex = index - 1
                        dg.DataSource = Nothing
                        dg.DataSource = ColumnInfos
                        Me.Place(ColumnInfo)
                    End If
                End If

            Case btnNext.Name

                Dim dr As DataGridViewRow = dg.CurrentRow
                If dr IsNot Nothing Then
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    Dim index As Integer = ColumnInfos.IndexOf(ColumnInfo)
                    If index <> ColumnInfos.Count - 1 Then
                        ColumnInfos.Remove(ColumnInfo)
                        ColumnInfos.Insert(index + 1, ColumnInfo)
                        ColumnInfo.Column.DisplayIndex = index + 1
                        dg.DataSource = Nothing
                        dg.DataSource = ColumnInfos
                        Me.Place(ColumnInfo)
                    End If
                End If

            Case btnBottom.Name

                Dim dr As DataGridViewRow = dg.CurrentRow
                If dr IsNot Nothing Then
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    Dim index As Integer = ColumnInfos.IndexOf(ColumnInfo)
                    If index <> ColumnInfos.Count - 1 Then
                        ColumnInfos.Remove(ColumnInfo)
                        ColumnInfos.Add(ColumnInfo)
                        ColumnInfo.Column.DisplayIndex = ColumnInfos.Count - 1
                        dg.DataSource = Nothing
                        dg.DataSource = ColumnInfos
                        Me.Place(ColumnInfo)
                    End If
                End If

            Case btnSelectAll.Name
                For Each dr As DataGridViewRow In dg.Rows
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    ColumnInfo.bShow = True
                Next
                dg.DataSource = Nothing
                dg.DataSource = ColumnInfos

            Case btnSelectNo.Name

                For Each dr As DataGridViewRow In dg.Rows
                    Dim ColumnInfo As ColumnInfo = dr.DataBoundItem
                    ColumnInfo.bShow = False
                Next
                dg.DataSource = Nothing
                dg.DataSource = ColumnInfos

            Case btnClose.Name
                Me.Close()

        End Select
    End Sub

    Private Sub dg_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellEnter
        If dg.CurrentRow IsNot Nothing Then
            dg.CurrentRow.Selected = True
        End If
    End Sub

    Private Sub dg_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dg.DataError
        Global.Common.Debug.myMsg(e.Exception.Message)
    End Sub


End Class
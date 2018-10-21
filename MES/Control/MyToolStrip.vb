''' <summary>
''' 工具栏
''' </summary>
''' <remarks></remarks>
Public Class MyToolStrip
    Inherits ToolStrip
    ''' <summary>
    ''' 点击工具栏按钮时触发
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Shared Event myItemClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    ''' <summary>
    ''' 工具栏对象点击事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Shadows Event ItemClicked As ToolStripItemClickedEventHandler
    ''' <summary>
    ''' 状态改变事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Event StateChanged As EventHandler

#Region "ToolStripItems"
    ''' <summary>
    ''' 打印
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T01_PrintPreview() As ToolStripItem
        Get
            Return Me.TbtnPrintPreview
        End Get
    End Property
    ''' <summary>
    '''  导出
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T02_Export() As ToolStripItem
        Get
            Return Me.TbtnExport
        End Get
    End Property
    ''' <summary>
    ''' 增加
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T03_Add() As ToolStripItem
        Get
            Return Me.TbtnAdd
        End Get
    End Property
    ''' <summary>
    ''' 修改
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T04_Change() As ToolStripItem
        Get
            Return Me.TbtnChange
        End Get
    End Property
    ''' <summary>
    ''' 删除
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T05_Delete() As ToolStripItem
        Get
            Return Me.TbtnDelete
        End Get
    End Property
    ''' <summary>
    ''' 保存
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T06_Save() As ToolStripItem
        Get
            Return Me.TbtnSave
        End Get
    End Property
    ''' <summary>
    ''' 放弃
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T07_Cancel() As ToolStripItem
        Get
            Return Me.TbtnCancel
        End Get
    End Property
    ''' <summary>
    ''' 首张
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T08_First() As ToolStripItem
        Get
            Return Me.TbtnFirst
        End Get
    End Property
    ''' <summary>
    ''' 上张
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T09_Previous() As ToolStripItem
        Get
            Return Me.TbtnPrevious
        End Get
    End Property
    ''' <summary>
    ''' 下张
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T10_Next() As ToolStripItem
        Get
            Return Me.TbtnNext
        End Get
    End Property
    ''' <summary>
    ''' 末张
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T11_Last() As ToolStripItem
        Get
            Return Me.TbtnLast
        End Get
    End Property
    ''' <summary>
    ''' 定位
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T12_Place() As ToolStripItem
        Get
            Return Me.TbtnPlace
        End Get
    End Property
    ''' <summary>
    ''' 过滤
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T13_Filter() As ToolStripItem
        Get
            Return Me.TbtnFilter
        End Get
    End Property
    ''' <summary>
    ''' 增行
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T14_AddRow() As ToolStripItem
        Get
            Return Me.TbtnAddRow
        End Get
    End Property
    ''' <summary>
    ''' 插行
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T15_InsertRow() As ToolStripItem
        Get
            Return Me.TbtnInsertRow
        End Get
    End Property
    ''' <summary>
    ''' 删行
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T16_DeleteRow() As ToolStripItem
        Get
            Return Me.TbtnDeleteRow
        End Get
    End Property
    ''' <summary>
    ''' 审核
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T17_Check() As ToolStripItem
        Get
            Return Me.TbtnCheck
        End Get
    End Property
    ''' <summary>
    ''' 变更
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T18_BianGeng() As ToolStripItem
        Get
            Return Me.TbtnBianGeng
        End Get
    End Property
    ''' <summary>
    ''' 关闭
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T19_Close() As ToolStripItem
        Get
            Return Me.TbtnClose
        End Get
    End Property
    ''' <summary>
    ''' 刷新
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T20_Refresh() As ToolStripItem
        Get
            Return Me.TbtnRefresh
        End Get
    End Property
    ''' <summary>
    ''' 退出
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property T21_Exit() As ToolStripItem
        Get
            Return Me.TbtnExit
        End Get
    End Property
    ''' <summary>
    ''' 自定义项1
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine1() As ToolStripItem
        Get
            Return Me.TbtnDefine1
        End Get
    End Property
    ''' <summary>
    ''' 自定义项2
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine2() As ToolStripItem
        Get
            Return Me.TbtnDefine2
        End Get
    End Property
    ''' <summary>
    ''' 自定义项3
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine3() As ToolStripItem
        Get
            Return Me.TbtnDefine3
        End Get
    End Property
    ''' <summary>
    ''' 自定义项4
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine4() As ToolStripItem
        Get
            Return Me.TbtnDefine4
        End Get
    End Property
    ''' <summary>
    ''' 自定义项5
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine5() As ToolStripItem
        Get
            Return Me.TbtnDefine5
        End Get
    End Property
    ''' <summary>
    ''' 自定义项6
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine6() As ToolStripItem
        Get
            Return Me.TbtnDefine6
        End Get
    End Property
    ''' <summary>
    ''' 自定义项7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine7() As ToolStripItem
        Get
            Return Me.TbtnDefine7
        End Get
    End Property
    ''' <summary>
    ''' 自定义项8
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine8() As ToolStripItem
        Get
            Return Me.TbtnDefine8
        End Get
    End Property
    ''' <summary>
    ''' 自定义项9
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine9() As ToolStripItem
        Get
            Return Me.TbtnDefine9
        End Get
    End Property
    ''' <summary>
    ''' 自定义项10
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TDefine10() As ToolStripItem
        Get
            Return Me.TbtnDefine10
        End Get
    End Property
#End Region
    ''' <summary>
    ''' 显示所有项
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowAllItem()
        For Each Item As ToolStripItem In Me.Items
            Item.Visible = True
        Next
    End Sub
    ''' <summary>
    ''' 隐藏所有项
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HideAllItem()
        For Each Item As ToolStripItem In Me.Items
            Item.Visible = False
        Next
    End Sub

    Private _State As ToolStripState = ToolStripState.None
    ''' <summary>
    ''' 状态
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property State() As ToolStripState
        Get
            Return _State
        End Get
        Set(ByVal value As ToolStripState)
            Dim Temp As ToolStripState = _State
            _State = value
            Select Case _State
                Case ToolStripState.Adding
                    Me.T03_Add.Enabled = True
                    Me.T04_Change.Enabled = False
                    Me.T05_Delete.Enabled = False

                    Me.T01_PrintPreview.Enabled = False
                    Me.T02_Export.Enabled = False
                    Me.T08_First.Enabled = False
                    Me.T09_Previous.Enabled = False
                    Me.T10_Next.Enabled = False
                    Me.T11_Last.Enabled = False
                    Me.T12_Place.Enabled = False
                    Me.T13_Filter.Enabled = False
                    Me.T14_AddRow.Enabled = True
                    Me.T15_InsertRow.Enabled = True
                    Me.T16_DeleteRow.Enabled = True
                    Me.T17_Check.Enabled = False
                    Me.T18_BianGeng.Enabled = False
                    Me.T19_Close.Enabled = False
                    Me.T20_Refresh.Enabled = False
                    Me.T21_Exit.Enabled = False
                Case ToolStripState.None
                    Me.T03_Add.Enabled = True
                    Me.T04_Change.Enabled = True
                    Me.T05_Delete.Enabled = True

                    Me.T01_PrintPreview.Enabled = True
                    Me.T02_Export.Enabled = True
                    Me.T08_First.Enabled = True
                    Me.T09_Previous.Enabled = True
                    Me.T10_Next.Enabled = True
                    Me.T11_Last.Enabled = True
                    Me.T12_Place.Enabled = True
                    Me.T13_Filter.Enabled = True
                    Me.T14_AddRow.Enabled = False
                    Me.T15_InsertRow.Enabled = False
                    Me.T16_DeleteRow.Enabled = False
                    Me.T17_Check.Enabled = True
                    Me.T18_BianGeng.Enabled = True
                    Me.T19_Close.Enabled = True
                    Me.T20_Refresh.Enabled = True
                    Me.T21_Exit.Enabled = True
                Case ToolStripState.Changing
                    Me.T03_Add.Enabled = False
                    Me.T04_Change.Enabled = True
                    Me.T05_Delete.Enabled = False

                    Me.T01_PrintPreview.Enabled = False
                    Me.T02_Export.Enabled = False
                    Me.T08_First.Enabled = False
                    Me.T09_Previous.Enabled = False
                    Me.T10_Next.Enabled = False
                    Me.T11_Last.Enabled = False
                    Me.T12_Place.Enabled = False
                    Me.T13_Filter.Enabled = False
                    Me.T14_AddRow.Enabled = True
                    Me.T15_InsertRow.Enabled = True
                    Me.T16_DeleteRow.Enabled = True
                    Me.T17_Check.Enabled = False
                    Me.T18_BianGeng.Enabled = False
                    Me.T19_Close.Enabled = False
                    Me.T20_Refresh.Enabled = False
                    Me.T21_Exit.Enabled = False
            End Select
            If Temp <> value Then
                RaiseEvent StateChanged(Me, New EventArgs)
            End If
        End Set
    End Property

    ''' <summary>
    ''' 工具栏状态
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ToolStripState
        ''' <summary>
        ''' 正常
        ''' </summary>
        ''' <remarks></remarks>
        None
        ''' <summary>
        ''' 正在新增
        ''' </summary>
        ''' <remarks></remarks>
        Adding
        ''' <summary>
        ''' 正在修改
        ''' </summary>
        ''' <remarks></remarks>
        Changing
    End Enum

    ''' <summary>
    ''' 获取或设置是否审核
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Checked() As Boolean
        Get
            If Me.T17_Check.Text = "审核" Then
                Return False
            ElseIf Me.T17_Check.Text = "弃审" Then
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = False Then
                Me.T17_Check.Text = "审核"
            ElseIf value = True Then
                Me.T17_Check.Text = "充审"
            End If
        End Set
    End Property

    ''' <summary>
    ''' 获取或设置是否关闭
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Closed() As Boolean
        Get
            If Me.T19_Close.Text = "关闭" Then
                Return False
            ElseIf Me.T19_Close.Text = "打开" Then
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = False Then
                Me.T19_Close.Text = "关闭"
            ElseIf value = True Then
                Me.T19_Close.Text = "打开"
            End If
        End Set
    End Property

    ''' <summary>
    ''' 引发ItemClicked事件
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Shadows Sub OnItemClicked(ByVal e As ToolStripItemClickedEventArgs)
        RaiseEvent ItemClicked(Me, e)
    End Sub

    Private Sub MyToolStrip_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MyBase.ItemClicked
        Me.Focus()
        RaiseEvent myItemClick(sender, e)
        Select Case e.ClickedItem.Name
            Case Me.T03_Add.Name
                If Me.State <> ToolStripState.None Then
                    Exit Sub
                Else
                    Me.State = ToolStripState.Adding
                End If
            Case Me.T04_Change.Name
                If Me.State <> ToolStripState.None Then
                    Exit Sub
                Else
                    Me.State = ToolStripState.Changing
                End If
            Case Me.T06_Save.Name
                If Me.State = ToolStripState.None Then
                    Exit Sub
                End If
            Case Me.T07_Cancel.Name
                If Me.State = ToolStripState.None Then
                    Exit Sub
                End If
        End Select
        Me.OnItemClicked(e)
    End Sub

End Class


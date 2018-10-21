Partial Class MyToolStrip
    Inherits System.Windows.Forms.ToolStrip

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        '组件设计器需要此调用。
        InitializeComponent()

    End Sub

    'Component 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '组件设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是组件设计器所必需的
    '可使用组件设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyToolStrip))
        Me.TbtnAdd = New System.Windows.Forms.ToolStripButton
        Me.TbtnChange = New System.Windows.Forms.ToolStripButton
        Me.TbtnDelete = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine1 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine2 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine3 = New System.Windows.Forms.ToolStripButton
        Me.TbtnSave = New System.Windows.Forms.ToolStripButton
        Me.TbtnCancel = New System.Windows.Forms.ToolStripButton
        Me.TbtnFirst = New System.Windows.Forms.ToolStripButton
        Me.TbtnPrevious = New System.Windows.Forms.ToolStripButton
        Me.TbtnNext = New System.Windows.Forms.ToolStripButton
        Me.TbtnLast = New System.Windows.Forms.ToolStripButton
        Me.TbtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.TbtnExit = New System.Windows.Forms.ToolStripButton
        Me.TbtnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.TbtnExport = New System.Windows.Forms.ToolStripButton
        Me.TbtnPlace = New System.Windows.Forms.ToolStripButton
        Me.TbtnFilter = New System.Windows.Forms.ToolStripButton
        Me.TbtnAddRow = New System.Windows.Forms.ToolStripButton
        Me.TbtnInsertRow = New System.Windows.Forms.ToolStripButton
        Me.TbtnDeleteRow = New System.Windows.Forms.ToolStripButton
        Me.TbtnCheck = New System.Windows.Forms.ToolStripButton
        Me.TbtnBianGeng = New System.Windows.Forms.ToolStripButton
        Me.TbtnClose = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine4 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine5 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine6 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine7 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine8 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine9 = New System.Windows.Forms.ToolStripButton
        Me.TbtnDefine10 = New System.Windows.Forms.ToolStripButton
        Me.SuspendLayout()
        '
        'TbtnAdd
        '
        Me.TbtnAdd.Image = CType(resources.GetObject("TbtnAdd.Image"), System.Drawing.Image)
        Me.TbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnAdd.Name = "TbtnAdd"
        Me.TbtnAdd.Size = New System.Drawing.Size(67, 20)
        Me.TbtnAdd.Text = "增加(&A)"
        Me.TbtnAdd.Visible = False
        '
        'TbtnChange
        '
        Me.TbtnChange.Image = CType(resources.GetObject("TbtnChange.Image"), System.Drawing.Image)
        Me.TbtnChange.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnChange.Name = "TbtnChange"
        Me.TbtnChange.Size = New System.Drawing.Size(67, 20)
        Me.TbtnChange.Text = "修改(&M)"
        Me.TbtnChange.Visible = False
        '
        'TbtnDelete
        '
        Me.TbtnDelete.Image = CType(resources.GetObject("TbtnDelete.Image"), System.Drawing.Image)
        Me.TbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDelete.Name = "TbtnDelete"
        Me.TbtnDelete.Size = New System.Drawing.Size(67, 20)
        Me.TbtnDelete.Text = "删除(&D)"
        Me.TbtnDelete.Visible = False
        '
        'TbtnDefine1
        '
        Me.TbtnDefine1.Image = CType(resources.GetObject("TbtnDefine1.Image"), System.Drawing.Image)
        Me.TbtnDefine1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine1.Name = "TbtnDefine1"
        Me.TbtnDefine1.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine1.Text = "自定义项1"
        Me.TbtnDefine1.Visible = False
        '
        'TbtnDefine2
        '
        Me.TbtnDefine2.Image = CType(resources.GetObject("TbtnDefine2.Image"), System.Drawing.Image)
        Me.TbtnDefine2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine2.Name = "TbtnDefine2"
        Me.TbtnDefine2.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine2.Text = "自定义项2"
        Me.TbtnDefine2.Visible = False
        '
        'TbtnDefine3
        '
        Me.TbtnDefine3.Image = CType(resources.GetObject("TbtnDefine3.Image"), System.Drawing.Image)
        Me.TbtnDefine3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine3.Name = "TbtnDefine3"
        Me.TbtnDefine3.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine3.Text = "自定义项3"
        Me.TbtnDefine3.Visible = False
        '
        'TbtnSave
        '
        Me.TbtnSave.Image = CType(resources.GetObject("TbtnSave.Image"), System.Drawing.Image)
        Me.TbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnSave.Name = "TbtnSave"
        Me.TbtnSave.Size = New System.Drawing.Size(67, 20)
        Me.TbtnSave.Text = "保存(&S)"
        Me.TbtnSave.Visible = False
        '
        'TbtnCancel
        '
        Me.TbtnCancel.Image = CType(resources.GetObject("TbtnCancel.Image"), System.Drawing.Image)
        Me.TbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnCancel.Name = "TbtnCancel"
        Me.TbtnCancel.Size = New System.Drawing.Size(67, 20)
        Me.TbtnCancel.Text = "放弃(&C)"
        Me.TbtnCancel.Visible = False
        '
        'TbtnFirst
        '
        Me.TbtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbtnFirst.Image = CType(resources.GetObject("TbtnFirst.Image"), System.Drawing.Image)
        Me.TbtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnFirst.Name = "TbtnFirst"
        Me.TbtnFirst.Size = New System.Drawing.Size(23, 20)
        Me.TbtnFirst.Text = "首张"
        Me.TbtnFirst.Visible = False
        '
        'TbtnPrevious
        '
        Me.TbtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbtnPrevious.Image = CType(resources.GetObject("TbtnPrevious.Image"), System.Drawing.Image)
        Me.TbtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnPrevious.Name = "TbtnPrevious"
        Me.TbtnPrevious.Size = New System.Drawing.Size(23, 20)
        Me.TbtnPrevious.Text = "上张"
        Me.TbtnPrevious.Visible = False
        '
        'TbtnNext
        '
        Me.TbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbtnNext.Image = CType(resources.GetObject("TbtnNext.Image"), System.Drawing.Image)
        Me.TbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnNext.Name = "TbtnNext"
        Me.TbtnNext.Size = New System.Drawing.Size(23, 20)
        Me.TbtnNext.Text = "下张"
        Me.TbtnNext.Visible = False
        '
        'TbtnLast
        '
        Me.TbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbtnLast.Image = CType(resources.GetObject("TbtnLast.Image"), System.Drawing.Image)
        Me.TbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnLast.Name = "TbtnLast"
        Me.TbtnLast.Size = New System.Drawing.Size(23, 20)
        Me.TbtnLast.Text = "末张"
        Me.TbtnLast.Visible = False
        '
        'TbtnRefresh
        '
        Me.TbtnRefresh.Image = CType(resources.GetObject("TbtnRefresh.Image"), System.Drawing.Image)
        Me.TbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnRefresh.Name = "TbtnRefresh"
        Me.TbtnRefresh.Size = New System.Drawing.Size(67, 20)
        Me.TbtnRefresh.Text = "刷新(&R)"
        Me.TbtnRefresh.Visible = False
        '
        'TbtnExit
        '
        Me.TbtnExit.Image = CType(resources.GetObject("TbtnExit.Image"), System.Drawing.Image)
        Me.TbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnExit.Name = "TbtnExit"
        Me.TbtnExit.Size = New System.Drawing.Size(67, 20)
        Me.TbtnExit.Text = "退出(&Q)"
        Me.TbtnExit.Visible = False
        '
        'TbtnPrintPreview
        '
        Me.TbtnPrintPreview.Image = CType(resources.GetObject("TbtnPrintPreview.Image"), System.Drawing.Image)
        Me.TbtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnPrintPreview.Name = "TbtnPrintPreview"
        Me.TbtnPrintPreview.Size = New System.Drawing.Size(67, 22)
        Me.TbtnPrintPreview.Text = "打印(&P)"
        Me.TbtnPrintPreview.Visible = False
        '
        'TbtnExport
        '
        Me.TbtnExport.Image = CType(resources.GetObject("TbtnExport.Image"), System.Drawing.Image)
        Me.TbtnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnExport.Name = "TbtnExport"
        Me.TbtnExport.Size = New System.Drawing.Size(67, 20)
        Me.TbtnExport.Text = "导出(&E)"
        Me.TbtnExport.Visible = False
        '
        'TbtnPlace
        '
        Me.TbtnPlace.Image = CType(resources.GetObject("TbtnPlace.Image"), System.Drawing.Image)
        Me.TbtnPlace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnPlace.Name = "TbtnPlace"
        Me.TbtnPlace.Size = New System.Drawing.Size(67, 20)
        Me.TbtnPlace.Text = "定位(&G)"
        Me.TbtnPlace.Visible = False
        '
        'TbtnFilter
        '
        Me.TbtnFilter.Image = CType(resources.GetObject("TbtnFilter.Image"), System.Drawing.Image)
        Me.TbtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnFilter.Name = "TbtnFilter"
        Me.TbtnFilter.Size = New System.Drawing.Size(67, 20)
        Me.TbtnFilter.Text = "过滤(&F)"
        Me.TbtnFilter.Visible = False
        '
        'TbtnAddRow
        '
        Me.TbtnAddRow.Image = CType(resources.GetObject("TbtnAddRow.Image"), System.Drawing.Image)
        Me.TbtnAddRow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnAddRow.Name = "TbtnAddRow"
        Me.TbtnAddRow.Size = New System.Drawing.Size(67, 20)
        Me.TbtnAddRow.Text = "增行(&N)"
        Me.TbtnAddRow.Visible = False
        '
        'TbtnInsertRow
        '
        Me.TbtnInsertRow.Image = CType(resources.GetObject("TbtnInsertRow.Image"), System.Drawing.Image)
        Me.TbtnInsertRow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnInsertRow.Name = "TbtnInsertRow"
        Me.TbtnInsertRow.Size = New System.Drawing.Size(67, 20)
        Me.TbtnInsertRow.Text = "插行(&I)"
        Me.TbtnInsertRow.Visible = False
        '
        'TbtnDeleteRow
        '
        Me.TbtnDeleteRow.Image = CType(resources.GetObject("TbtnDeleteRow.Image"), System.Drawing.Image)
        Me.TbtnDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDeleteRow.Name = "TbtnDeleteRow"
        Me.TbtnDeleteRow.Size = New System.Drawing.Size(67, 20)
        Me.TbtnDeleteRow.Text = "删行(&O)"
        Me.TbtnDeleteRow.Visible = False
        '
        'TbtnCheck
        '
        Me.TbtnCheck.Image = CType(resources.GetObject("TbtnCheck.Image"), System.Drawing.Image)
        Me.TbtnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnCheck.Name = "TbtnCheck"
        Me.TbtnCheck.Size = New System.Drawing.Size(49, 20)
        Me.TbtnCheck.Text = "审核"
        Me.TbtnCheck.Visible = False
        '
        'TbtnBianGeng
        '
        Me.TbtnBianGeng.Image = CType(resources.GetObject("TbtnBianGeng.Image"), System.Drawing.Image)
        Me.TbtnBianGeng.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnBianGeng.Name = "TbtnBianGeng"
        Me.TbtnBianGeng.Size = New System.Drawing.Size(49, 20)
        Me.TbtnBianGeng.Text = "变更"
        Me.TbtnBianGeng.Visible = False
        '
        'TbtnClose
        '
        Me.TbtnClose.Image = CType(resources.GetObject("TbtnClose.Image"), System.Drawing.Image)
        Me.TbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnClose.Name = "TbtnClose"
        Me.TbtnClose.Size = New System.Drawing.Size(49, 20)
        Me.TbtnClose.Text = "关闭"
        Me.TbtnClose.Visible = False
        '
        'TbtnDefine4
        '
        Me.TbtnDefine4.Image = CType(resources.GetObject("TbtnDefine4.Image"), System.Drawing.Image)
        Me.TbtnDefine4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine4.Name = "TbtnDefine4"
        Me.TbtnDefine4.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine4.Text = "自定义项4"
        Me.TbtnDefine4.Visible = False
        '
        'TbtnDefine5
        '
        Me.TbtnDefine5.Image = CType(resources.GetObject("TbtnDefine5.Image"), System.Drawing.Image)
        Me.TbtnDefine5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine5.Name = "TbtnDefine5"
        Me.TbtnDefine5.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine5.Text = "自定义项5"
        Me.TbtnDefine5.Visible = False
        '
        'TbtnDefine6
        '
        Me.TbtnDefine6.Image = CType(resources.GetObject("TbtnDefine6.Image"), System.Drawing.Image)
        Me.TbtnDefine6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine6.Name = "TbtnDefine6"
        Me.TbtnDefine6.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine6.Text = "自定义项6"
        Me.TbtnDefine6.Visible = False
        '
        'TbtnDefine7
        '
        Me.TbtnDefine7.Image = CType(resources.GetObject("TbtnDefine7.Image"), System.Drawing.Image)
        Me.TbtnDefine7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine7.Name = "TbtnDefine7"
        Me.TbtnDefine7.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine7.Text = "自定义项7"
        Me.TbtnDefine7.Visible = False
        '
        'TbtnDefine8
        '
        Me.TbtnDefine8.Image = CType(resources.GetObject("TbtnDefine8.Image"), System.Drawing.Image)
        Me.TbtnDefine8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine8.Name = "TbtnDefine8"
        Me.TbtnDefine8.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine8.Text = "自定义项8"
        Me.TbtnDefine8.Visible = False
        '
        'TbtnDefine9
        '
        Me.TbtnDefine9.Image = CType(resources.GetObject("TbtnDefine9.Image"), System.Drawing.Image)
        Me.TbtnDefine9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine9.Name = "TbtnDefine9"
        Me.TbtnDefine9.Size = New System.Drawing.Size(79, 20)
        Me.TbtnDefine9.Text = "自定义项9"
        Me.TbtnDefine9.Visible = False
        '
        'TbtnDefine10
        '
        Me.TbtnDefine10.Image = CType(resources.GetObject("TbtnDefine10.Image"), System.Drawing.Image)
        Me.TbtnDefine10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnDefine10.Name = "TbtnDefine10"
        Me.TbtnDefine10.Size = New System.Drawing.Size(85, 20)
        Me.TbtnDefine10.Text = "自定义项10"
        Me.TbtnDefine10.Visible = False
        '
        'MyToolStrip
        '
        Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TbtnPrintPreview, Me.TbtnExport, Me.TbtnAdd, Me.TbtnChange, Me.TbtnDelete, Me.TbtnSave, Me.TbtnCancel, Me.TbtnFirst, Me.TbtnPrevious, Me.TbtnNext, Me.TbtnLast, Me.TbtnPlace, Me.TbtnFilter, Me.TbtnAddRow, Me.TbtnInsertRow, Me.TbtnDeleteRow, Me.TbtnCheck, Me.TbtnBianGeng, Me.TbtnClose, Me.TbtnDefine1, Me.TbtnDefine2, Me.TbtnDefine3, Me.TbtnDefine4, Me.TbtnDefine5, Me.TbtnDefine6, Me.TbtnDefine7, Me.TbtnDefine8, Me.TbtnDefine9, Me.TbtnDefine10, Me.TbtnRefresh, Me.TbtnExit})
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents TbtnAdd As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnChange As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDelete As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine1 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine2 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine3 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnSave As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnCancel As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnFirst As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnPrevious As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnNext As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnLast As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnRefresh As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnExit As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnPrintPreview As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnExport As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnPlace As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnFilter As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnAddRow As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnInsertRow As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDeleteRow As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnCheck As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnBianGeng As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnClose As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine4 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine5 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine6 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine7 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine8 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine9 As System.Windows.Forms.ToolStripButton
    Protected WithEvents TbtnDefine10 As System.Windows.Forms.ToolStripButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("用户档案")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("功能权限")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("数据权限")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("操作日志")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("帐表管理")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("查询语法")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("备份数据库")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("清空数据库")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("数据库设置")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("系统管理", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Me.sLblShow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.pnlCallHide = New System.Windows.Forms.Panel()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.TV = New Control.MyTreeView()
        Me.SS.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'sLblShow
        '
        Me.sLblShow.Image = CType(resources.GetObject("sLblShow.Image"), System.Drawing.Image)
        Me.sLblShow.Name = "sLblShow"
        Me.sLblShow.Size = New System.Drawing.Size(51, 17)
        Me.sLblShow.Text = "显示:"
        '
        'SS
        '
        Me.SS.BackColor = System.Drawing.Color.Snow
        Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sLblShow})
        Me.SS.Location = New System.Drawing.Point(0, 288)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(746, 22)
        Me.SS.TabIndex = 46
        Me.SS.Text = "StatusStrip1"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Splitter1.Location = New System.Drawing.Point(175, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 288)
        Me.Splitter1.TabIndex = 49
        Me.Splitter1.TabStop = False
        '
        'pnlCallHide
        '
        Me.pnlCallHide.BackColor = System.Drawing.Color.White
        Me.pnlCallHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCallHide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCallHide.Location = New System.Drawing.Point(171, 0)
        Me.pnlCallHide.Name = "pnlCallHide"
        Me.pnlCallHide.Size = New System.Drawing.Size(4, 288)
        Me.pnlCallHide.TabIndex = 48
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnl.Controls.Add(Me.TV)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(171, 288)
        Me.pnl.TabIndex = 47
        '
        'TV
        '
        Me.TV.BackColor = System.Drawing.Color.White
        Me.TV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV.ForeColor = System.Drawing.Color.Black
        Me.TV.Indent = 19
        Me.TV.Location = New System.Drawing.Point(0, 0)
        Me.TV.Name = "TV"
        TreeNode1.Name = ""
        TreeNode1.Text = "用户档案"
        TreeNode2.Name = ""
        TreeNode2.Text = "功能权限"
        TreeNode3.Name = "节点0"
        TreeNode3.Text = "数据权限"
        TreeNode4.Name = "节点0"
        TreeNode4.Text = "操作日志"
        TreeNode5.Name = "节点0"
        TreeNode5.Text = "帐表管理"
        TreeNode6.Name = "节点0"
        TreeNode6.Text = "查询语法"
        TreeNode7.Name = "节点0"
        TreeNode7.Text = "备份数据库"
        TreeNode8.Name = "节点1"
        TreeNode8.Text = "清空数据库"
        TreeNode9.Name = ""
        TreeNode9.Text = "数据库设置"
        TreeNode10.Name = ""
        TreeNode10.Text = "系统管理"
        Me.TV.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10})
        Me.TV.Size = New System.Drawing.Size(171, 288)
        Me.TV.TabIndex = 29
        Me.TV.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 310)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlCallHide)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.SS)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MES查询报表"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SS.ResumeLayout(False)
        Me.SS.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sLblShow As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnlCallHide As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents TV As Control.MyTreeView
  
  
End Class

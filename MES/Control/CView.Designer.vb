<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CView
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()

        Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.sPanPageBGN = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.sPanPageEnd = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.pCtrlView = New System.Windows.Forms.PrintPreviewControl
        Me.toolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnExit = New System.Windows.Forms.Button
        Me.sBarTitle = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnPrint = New System.Windows.Forms.Button
        Me.panMain = New System.Windows.Forms.Panel
        Me.btnSetUp = New System.Windows.Forms.Button
        Me.btnZoom = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.sBar = New System.Windows.Forms.StatusStrip
        Me.panMain.SuspendLayout()
        Me.sBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripStatusLabel2
        '
        Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
        Me.toolStripStatusLabel2.Size = New System.Drawing.Size(19, 17)
        Me.toolStripStatusLabel2.Text = "第"
        '
        'toolStripStatusLabel5
        '
        Me.toolStripStatusLabel5.Name = "toolStripStatusLabel5"
        Me.toolStripStatusLabel5.Size = New System.Drawing.Size(19, 17)
        Me.toolStripStatusLabel5.Text = "页"
        '
        'sPanPageBGN
        '
        Me.sPanPageBGN.Name = "sPanPageBGN"
        Me.sPanPageBGN.Size = New System.Drawing.Size(13, 17)
        Me.sPanPageBGN.Text = "1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(67, 17)
        Me.toolStripStatusLabel1.Text = "打印预览："
        '
        'sPanPageEnd
        '
        Me.sPanPageEnd.Name = "sPanPageEnd"
        Me.sPanPageEnd.Size = New System.Drawing.Size(13, 17)
        Me.sPanPageEnd.Text = "1"
        '
        'toolStripStatusLabel3
        '
        Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
        Me.toolStripStatusLabel3.Size = New System.Drawing.Size(19, 17)
        Me.toolStripStatusLabel3.Text = "页"
        '
        'pCtrlView
        '
        Me.pCtrlView.AutoZoom = False
        Me.pCtrlView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCtrlView.Location = New System.Drawing.Point(0, 40)
        Me.pCtrlView.Name = "pCtrlView"
        Me.pCtrlView.Size = New System.Drawing.Size(1024, 706)
        Me.pCtrlView.TabIndex = 5
        Me.pCtrlView.Zoom = 1
        '
        'toolStripStatusLabel4
        '
        Me.toolStripStatusLabel4.Name = "toolStripStatusLabel4"
        Me.toolStripStatusLabel4.Size = New System.Drawing.Size(19, 17)
        Me.toolStripStatusLabel4.Text = "共"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Location = New System.Drawing.Point(414, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "关闭"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'sBarTitle
        '
        Me.sBarTitle.Name = "sBarTitle"
        Me.sBarTitle.Size = New System.Drawing.Size(840, 17)
        Me.sBarTitle.Spring = True
        Me.sBarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrint.Location = New System.Drawing.Point(333, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "列印"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'panMain
        '
        Me.panMain.Controls.Add(Me.btnExit)
        Me.panMain.Controls.Add(Me.btnPrint)
        Me.panMain.Controls.Add(Me.btnSetUp)
        Me.panMain.Controls.Add(Me.btnZoom)
        Me.panMain.Controls.Add(Me.btnPrevious)
        Me.panMain.Controls.Add(Me.btnNext)
        Me.panMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.panMain.Location = New System.Drawing.Point(0, 0)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(1024, 40)
        Me.panMain.TabIndex = 3
        '
        'btnSetUp
        '
        Me.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSetUp.Location = New System.Drawing.Point(252, 9)
        Me.btnSetUp.Name = "btnSetUp"
        Me.btnSetUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSetUp.TabIndex = 0
        Me.btnSetUp.Text = "设置"
        Me.btnSetUp.UseVisualStyleBackColor = True
        '
        'btnZoom
        '
        Me.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnZoom.Location = New System.Drawing.Point(171, 9)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(75, 23)
        Me.btnZoom.TabIndex = 0
        Me.btnZoom.Text = "缩放"
        Me.btnZoom.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrevious.Location = New System.Drawing.Point(90, 9)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "上一页"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNext.Location = New System.Drawing.Point(9, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "下一页"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'sBar
        '
        Me.sBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.sPanPageBGN, Me.toolStripStatusLabel3, Me.toolStripStatusLabel4, Me.sPanPageEnd, Me.toolStripStatusLabel5, Me.sBarTitle})
        Me.sBar.Location = New System.Drawing.Point(0, 746)
        Me.sBar.Name = "sBar"
        Me.sBar.Size = New System.Drawing.Size(1024, 22)
        Me.sBar.TabIndex = 4
        Me.sBar.Text = "statusStrip1"
        '
        'CView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pCtrlView)
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.sBar)
        Me.Name = "CView"
        Me.Size = New System.Drawing.Size(1024, 768)
        Me.panMain.ResumeLayout(False)
        Me.sBar.ResumeLayout(False)
        Me.sBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents sPanPageBGN As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents sPanPageEnd As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents pCtrlView As System.Windows.Forms.PrintPreviewControl
    Private WithEvents toolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents sBarTitle As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents panMain As System.Windows.Forms.Panel
    Private WithEvents btnSetUp As System.Windows.Forms.Button
    Private WithEvents btnZoom As System.Windows.Forms.Button
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents sBar As System.Windows.Forms.StatusStrip

End Class

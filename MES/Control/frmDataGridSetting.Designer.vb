<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataGridSetting
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBottom = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnSelectNo = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_显示 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cl_原名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_别名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_宽度 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_排序 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAlignment = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBottom
        '
        Me.btnBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBottom.Location = New System.Drawing.Point(443, 90)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(76, 23)
        Me.btnBottom.TabIndex = 3
        Me.btnBottom.Text = "置底(&B)"
        Me.btnBottom.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.Location = New System.Drawing.Point(443, 38)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(76, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "上移(&P)"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(443, 168)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "关闭(&C)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(443, 64)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "下移(&N)"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTop.Location = New System.Drawing.Point(443, 12)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(76, 23)
        Me.btnTop.TabIndex = 0
        Me.btnTop.Text = "置顶(&T)"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_显示, Me.cl_原名, Me.cl_别名, Me.cl_宽度, Me.cl_排序, Me.ColAlignment})
        Me.dg.Location = New System.Drawing.Point(1, 1)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.RowTemplate.Height = 20
        Me.dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.Size = New System.Drawing.Size(436, 369)
        Me.dg.TabIndex = 0
        '
        'btnSelectNo
        '
        Me.btnSelectNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectNo.Location = New System.Drawing.Point(443, 141)
        Me.btnSelectNo.Name = "btnSelectNo"
        Me.btnSelectNo.Size = New System.Drawing.Size(76, 23)
        Me.btnSelectNo.TabIndex = 5
        Me.btnSelectNo.Text = "全清(&D)"
        Me.btnSelectNo.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.Location = New System.Drawing.Point(443, 115)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(76, 23)
        Me.btnSelectAll.TabIndex = 4
        Me.btnSelectAll.Text = "全选(&A)"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DataPropertyName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HeaderText"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Width"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "iDisplayIndex"
        Me.DataGridViewTextBoxColumn4.HeaderText = "排序"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 41
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Alignment"
        Me.DataGridViewComboBoxColumn1.HeaderText = "对齐"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "iAlignment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "对齐"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'cl_显示
        '
        Me.cl_显示.DataPropertyName = "bShow"
        Me.cl_显示.HeaderText = "显示"
        Me.cl_显示.Name = "cl_显示"
        Me.cl_显示.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cl_显示.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cl_显示.Width = 55
        '
        'cl_原名
        '
        Me.cl_原名.DataPropertyName = "cColumnName"
        Me.cl_原名.HeaderText = "原名"
        Me.cl_原名.Name = "cl_原名"
        Me.cl_原名.ReadOnly = True
        '
        'cl_别名
        '
        Me.cl_别名.DataPropertyName = "cColumnByName"
        Me.cl_别名.HeaderText = "别名"
        Me.cl_别名.Name = "cl_别名"
        '
        'cl_宽度
        '
        Me.cl_宽度.DataPropertyName = "iWidth"
        Me.cl_宽度.HeaderText = "宽度"
        Me.cl_宽度.Name = "cl_宽度"
        Me.cl_宽度.Width = 60
        '
        'cl_排序
        '
        Me.cl_排序.DataPropertyName = "iDisplayIndex"
        Me.cl_排序.HeaderText = "排序"
        Me.cl_排序.Name = "cl_排序"
        Me.cl_排序.Width = 41
        '
        'ColAlignment
        '
        Me.ColAlignment.DataPropertyName = "Alignment"
        Me.ColAlignment.HeaderText = "对齐"
        Me.ColAlignment.Name = "ColAlignment"
        Me.ColAlignment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColAlignment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColAlignment.Width = 70
        '
        'frmDataGridSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 371)
        Me.Controls.Add(Me.btnSelectNo)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnBottom)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnTop)
        Me.Name = "frmDataGridSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "表格设置"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBottom As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSelectNo As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cl_显示 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cl_原名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl_别名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl_宽度 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl_排序 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAlignment As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

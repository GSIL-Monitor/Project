<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateBig
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(31, 9)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(50, 50, 50, 50)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnToday
        '
        Me.btnToday.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.btnToday.Location = New System.Drawing.Point(138, 389)
        Me.btnToday.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(137, 40)
        Me.btnToday.TabIndex = 1
        Me.btnToday.Text = "今天(&O)"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.btnCancel.Location = New System.Drawing.Point(285, 389)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(137, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消(&C)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmDateBig
        '
        Me.AcceptButton = Me.btnToday
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(591, 449)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDateBig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "日历"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Protected WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class

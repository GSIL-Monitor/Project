<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDateTime
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Clock1 = New Control.Clock()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(254, 204)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消(&C)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(135, 205)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(75, 23)
        Me.btnToday.TabIndex = 4
        Me.btnToday.Text = "确定(&O)"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.MonthCalendar1.Location = New System.Drawing.Point(7, 8)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(232, 162)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 24)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Clock1
        '
        Me.Clock1.Draw1MinuteTicks = True
        Me.Clock1.Draw5MinuteTicks = True
        Me.Clock1.HourHandColor = System.Drawing.Color.Black
        Me.Clock1.Location = New System.Drawing.Point(232, 13)
        Me.Clock1.MinuteHandColor = System.Drawing.Color.Black
        Me.Clock1.Name = "Clock1"
        Me.Clock1.SecondHandColor = System.Drawing.Color.Red
        Me.Clock1.Size = New System.Drawing.Size(126, 126)
        Me.Clock1.TabIndex = 6
        Me.Clock1.TicksColor = System.Drawing.Color.Black
        '
        'FrmDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 235)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDateTime"
        Me.Text = "日期时间"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Protected WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Clock1 As Control.Clock
End Class

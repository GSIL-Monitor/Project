<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyTextTime
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
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(2, 4)
        Me.txtHour.MaxLength = 2
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(41, 21)
        Me.txtHour.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(58, 5)
        Me.txtMin.MaxLength = 2
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(41, 21)
        Me.txtMin.TabIndex = 1
        '
        'MyTextTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHour)
        Me.Name = "MyTextTime"
        Me.Size = New System.Drawing.Size(103, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHour As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox

End Class

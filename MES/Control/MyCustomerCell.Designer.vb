<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyCustomerCell
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
        Me.combo = New System.Windows.Forms.ComboBox
        Me.lblHeatText = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'combo
        '
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(5, 35)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(85, 20)
        Me.combo.TabIndex = 0
        '
        'lblHeatText
        '
        Me.lblHeatText.AutoSize = True
        Me.lblHeatText.Font = New System.Drawing.Font("宋体", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeatText.Location = New System.Drawing.Point(16, 8)
        Me.lblHeatText.Name = "lblHeatText"
        Me.lblHeatText.Size = New System.Drawing.Size(61, 15)
        Me.lblHeatText.TabIndex = 1
        Me.lblHeatText.Text = "Label1"
        '
        'MyCustomerCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblHeatText)
        Me.Controls.Add(Me.combo)
        Me.Name = "MyCustomerCell"
        Me.Size = New System.Drawing.Size(95, 63)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo As System.Windows.Forms.ComboBox
    Friend WithEvents lblHeatText As System.Windows.Forms.Label

End Class

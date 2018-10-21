<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyCellHeadCaption
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
        Me.lblHeatText = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblHeatText
        '
        Me.lblHeatText.AutoSize = True
        Me.lblHeatText.Font = New System.Drawing.Font("MingLiU", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeatText.Location = New System.Drawing.Point(9, 10)
        Me.lblHeatText.Name = "lblHeatText"
        Me.lblHeatText.Size = New System.Drawing.Size(106, 15)
        Me.lblHeatText.TabIndex = 0
        Me.lblHeatText.Text = "lblHeatText"
        Me.lblHeatText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyCellHeadCaption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHeatText)
        Me.Name = "MyCellHeadCaption"
        Me.Size = New System.Drawing.Size(121, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeatText As System.Windows.Forms.Label

End Class

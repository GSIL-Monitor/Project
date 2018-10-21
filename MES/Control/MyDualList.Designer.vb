<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyDualList
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.cmdLeftAll = New System.Windows.Forms.Button()
        Me.cmdLeftOne = New System.Windows.Forms.Button()
        Me.cmdRightAll = New System.Windows.Forms.Button()
        Me.cmdRightOne = New System.Windows.Forms.Button()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.lstAll = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.Location = New System.Drawing.Point(235, 11)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(100, 16)
        Me.lblSelected.TabIndex = 15
        Me.lblSelected.Text = "选择的资料:"
        '
        'lstSelected
        '
        Me.lstSelected.ItemHeight = 12
        Me.lstSelected.Location = New System.Drawing.Point(235, 27)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(150, 196)
        Me.lstSelected.Sorted = True
        Me.lstSelected.TabIndex = 14
        '
        'cmdLeftAll
        '
        Me.cmdLeftAll.Location = New System.Drawing.Point(178, 157)
        Me.cmdLeftAll.Name = "cmdLeftAll"
        Me.cmdLeftAll.Size = New System.Drawing.Size(40, 23)
        Me.cmdLeftAll.TabIndex = 13
        Me.cmdLeftAll.Text = "<<"
        '
        'cmdLeftOne
        '
        Me.cmdLeftOne.Location = New System.Drawing.Point(178, 125)
        Me.cmdLeftOne.Name = "cmdLeftOne"
        Me.cmdLeftOne.Size = New System.Drawing.Size(40, 23)
        Me.cmdLeftOne.TabIndex = 12
        Me.cmdLeftOne.Text = "<"
        '
        'cmdRightAll
        '
        Me.cmdRightAll.Location = New System.Drawing.Point(178, 93)
        Me.cmdRightAll.Name = "cmdRightAll"
        Me.cmdRightAll.Size = New System.Drawing.Size(40, 23)
        Me.cmdRightAll.TabIndex = 11
        Me.cmdRightAll.Text = ">>"
        '
        'cmdRightOne
        '
        Me.cmdRightOne.Location = New System.Drawing.Point(178, 61)
        Me.cmdRightOne.Name = "cmdRightOne"
        Me.cmdRightOne.Size = New System.Drawing.Size(40, 23)
        Me.cmdRightOne.TabIndex = 10
        Me.cmdRightOne.Text = ">"
        '
        'lblAll
        '
        Me.lblAll.Location = New System.Drawing.Point(16, 11)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(100, 16)
        Me.lblAll.TabIndex = 9
        Me.lblAll.Text = "所有资料:"
        '
        'lstAll
        '
        Me.lstAll.ItemHeight = 12
        Me.lstAll.Location = New System.Drawing.Point(16, 27)
        Me.lstAll.Name = "lstAll"
        Me.lstAll.Size = New System.Drawing.Size(150, 196)
        Me.lstAll.Sorted = True
        Me.lstAll.TabIndex = 8
        '
        'MyDualList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.cmdLeftAll)
        Me.Controls.Add(Me.cmdLeftOne)
        Me.Controls.Add(Me.cmdRightAll)
        Me.Controls.Add(Me.cmdRightOne)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lstAll)
        Me.Name = "MyDualList"
        Me.Size = New System.Drawing.Size(404, 241)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents cmdLeftAll As System.Windows.Forms.Button
    Friend WithEvents cmdLeftOne As System.Windows.Forms.Button
    Friend WithEvents cmdRightAll As System.Windows.Forms.Button
    Friend WithEvents cmdRightOne As System.Windows.Forms.Button
    Friend WithEvents lblAll As System.Windows.Forms.Label
    Public WithEvents lstAll As System.Windows.Forms.ListBox
    Public WithEvents lstSelected As System.Windows.Forms.ListBox

End Class

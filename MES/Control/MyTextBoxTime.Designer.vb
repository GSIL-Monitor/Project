<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyTextBoxTime
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyTextBoxTime))
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.PicDate = New System.Windows.Forms.PictureBox()
        Me.picZoom = New System.Windows.Forms.PictureBox()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(19, 40)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(35, 12)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Label"
        '
        'txt
        '
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt.Location = New System.Drawing.Point(66, 40)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 14)
        Me.txt.TabIndex = 1
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.Black
        Me.lblLine.Location = New System.Drawing.Point(64, 69)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(100, 1)
        Me.lblLine.TabIndex = 2
        '
        'Pic
        '
        Me.Pic.Location = New System.Drawing.Point(182, 40)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(33, 25)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pic.TabIndex = 3
        Me.Pic.TabStop = False
        Me.Pic.Visible = False
        '
        'PicDate
        '
        Me.PicDate.Image = CType(resources.GetObject("PicDate.Image"), System.Drawing.Image)
        Me.PicDate.Location = New System.Drawing.Point(180, 96)
        Me.PicDate.Name = "PicDate"
        Me.PicDate.Size = New System.Drawing.Size(39, 23)
        Me.PicDate.TabIndex = 5
        Me.PicDate.TabStop = False
        Me.PicDate.Visible = False
        '
        'picZoom
        '
        Me.picZoom.Image = CType(resources.GetObject("picZoom.Image"), System.Drawing.Image)
        Me.picZoom.Location = New System.Drawing.Point(101, 96)
        Me.picZoom.Name = "picZoom"
        Me.picZoom.Size = New System.Drawing.Size(39, 23)
        Me.picZoom.TabIndex = 4
        Me.picZoom.TabStop = False
        Me.picZoom.Visible = False
        '
        'MyTextBoxTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PicDate)
        Me.Controls.Add(Me.picZoom)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "MyTextBoxTime"
        Me.Size = New System.Drawing.Size(290, 150)
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents lblCaption As System.Windows.Forms.Label
    Protected WithEvents txt As System.Windows.Forms.TextBox
    Protected WithEvents lblLine As System.Windows.Forms.Label
    Protected WithEvents Pic As System.Windows.Forms.PictureBox
    Protected WithEvents PicDate As System.Windows.Forms.PictureBox
    Protected WithEvents picZoom As System.Windows.Forms.PictureBox

End Class

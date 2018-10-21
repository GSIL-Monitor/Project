<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataConnection
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
        Me.Tab = New System.Windows.Forms.TabControl
        Me.TPSQL = New System.Windows.Forms.TabPage
        Me.btnSQLCancel = New System.Windows.Forms.Button
        Me.btnSQLOK = New System.Windows.Forms.Button
        Me.txtSQLPW = New Control.MyTextBox
        Me.txtSQLDataBase = New Control.MyTextBox
        Me.txtSQLServerName = New Control.MyTextBox
        Me.TPAccess = New System.Windows.Forms.TabPage
        Me.btnAccessPath = New System.Windows.Forms.Button
        Me.btnAccessCancel = New System.Windows.Forms.Button
        Me.btnAccessOK = New System.Windows.Forms.Button
        Me.txtAccessPW = New Control.MyTextBox
        Me.txtAccessPath = New Control.MyTextBox
        Me.txtSQLSA = New Control.MyTextBox
        Me.Tab.SuspendLayout()
        Me.TPSQL.SuspendLayout()
        Me.TPAccess.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TPSQL)
        Me.Tab.Controls.Add(Me.TPAccess)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(311, 142)
        Me.Tab.TabIndex = 10
        '
        'TPSQL
        '
        Me.TPSQL.Controls.Add(Me.btnSQLCancel)
        Me.TPSQL.Controls.Add(Me.btnSQLOK)
        Me.TPSQL.Controls.Add(Me.txtSQLPW)
        Me.TPSQL.Controls.Add(Me.txtSQLSA)
        Me.TPSQL.Controls.Add(Me.txtSQLDataBase)
        Me.TPSQL.Controls.Add(Me.txtSQLServerName)
        Me.TPSQL.Location = New System.Drawing.Point(4, 21)
        Me.TPSQL.Name = "TPSQL"
        Me.TPSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSQL.Size = New System.Drawing.Size(303, 117)
        Me.TPSQL.TabIndex = 0
        Me.TPSQL.Text = "SQL"
        Me.TPSQL.UseVisualStyleBackColor = True
        '
        'btnSQLCancel
        '
        Me.btnSQLCancel.Location = New System.Drawing.Point(193, 33)
        Me.btnSQLCancel.Name = "btnSQLCancel"
        Me.btnSQLCancel.Size = New System.Drawing.Size(81, 23)
        Me.btnSQLCancel.TabIndex = 14
        Me.btnSQLCancel.Text = "取消(&C)"
        Me.btnSQLCancel.UseVisualStyleBackColor = True
        '
        'btnSQLOK
        '
        Me.btnSQLOK.Location = New System.Drawing.Point(193, 6)
        Me.btnSQLOK.Name = "btnSQLOK"
        Me.btnSQLOK.Size = New System.Drawing.Size(81, 23)
        Me.btnSQLOK.TabIndex = 13
        Me.btnSQLOK.Text = "确定(&O)"
        Me.btnSQLOK.UseVisualStyleBackColor = True
        '
        'txtSQLPW
        '
        Me.txtSQLPW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSQLPW.Caption = "密    码"
        Me.txtSQLPW.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtSQLPW.Location = New System.Drawing.Point(5, 88)
        Me.txtSQLPW.Name = "txtSQLPW"
        Me.txtSQLPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQLPW.SelectionStart = 0
        Me.txtSQLPW.Size = New System.Drawing.Size(168, 21)
        Me.txtSQLPW.TabIndex = 12
        Me.txtSQLPW.TextBoxType = Control.TextBoxType.txt
        Me.txtSQLPW.Value = Nothing
        '
        'txtSQLDataBase
        '
        Me.txtSQLDataBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSQLDataBase.Caption = "数 据 库"
        Me.txtSQLDataBase.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtSQLDataBase.Location = New System.Drawing.Point(6, 33)
        Me.txtSQLDataBase.Name = "txtSQLDataBase"
        Me.txtSQLDataBase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSQLDataBase.SelectionStart = 0
        Me.txtSQLDataBase.Size = New System.Drawing.Size(167, 21)
        Me.txtSQLDataBase.TabIndex = 11
        Me.txtSQLDataBase.TextBoxType = Control.TextBoxType.txt
        Me.txtSQLDataBase.Value = Nothing
        '
        'txtSQLServerName
        '
        Me.txtSQLServerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSQLServerName.Caption = "服 务 器"
        Me.txtSQLServerName.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtSQLServerName.Location = New System.Drawing.Point(6, 6)
        Me.txtSQLServerName.Name = "txtSQLServerName"
        Me.txtSQLServerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSQLServerName.SelectionStart = 0
        Me.txtSQLServerName.Size = New System.Drawing.Size(167, 21)
        Me.txtSQLServerName.TabIndex = 10
        Me.txtSQLServerName.TextBoxType = Control.TextBoxType.txt
        Me.txtSQLServerName.Value = Nothing
        '
        'TPAccess
        '
        Me.TPAccess.Controls.Add(Me.btnAccessPath)
        Me.TPAccess.Controls.Add(Me.btnAccessCancel)
        Me.TPAccess.Controls.Add(Me.btnAccessOK)
        Me.TPAccess.Controls.Add(Me.txtAccessPW)
        Me.TPAccess.Controls.Add(Me.txtAccessPath)
        Me.TPAccess.Location = New System.Drawing.Point(4, 21)
        Me.TPAccess.Name = "TPAccess"
        Me.TPAccess.Padding = New System.Windows.Forms.Padding(3)
        Me.TPAccess.Size = New System.Drawing.Size(303, 117)
        Me.TPAccess.TabIndex = 1
        Me.TPAccess.Text = "Access"
        Me.TPAccess.UseVisualStyleBackColor = True
        '
        'btnAccessPath
        '
        Me.btnAccessPath.Location = New System.Drawing.Point(179, 7)
        Me.btnAccessPath.Name = "btnAccessPath"
        Me.btnAccessPath.Size = New System.Drawing.Size(25, 21)
        Me.btnAccessPath.TabIndex = 20
        Me.btnAccessPath.Text = "..."
        Me.btnAccessPath.UseVisualStyleBackColor = True
        '
        'btnAccessCancel
        '
        Me.btnAccessCancel.Location = New System.Drawing.Point(215, 34)
        Me.btnAccessCancel.Name = "btnAccessCancel"
        Me.btnAccessCancel.Size = New System.Drawing.Size(81, 23)
        Me.btnAccessCancel.TabIndex = 19
        Me.btnAccessCancel.Text = "取消(&C)"
        Me.btnAccessCancel.UseVisualStyleBackColor = True
        '
        'btnAccessOK
        '
        Me.btnAccessOK.Location = New System.Drawing.Point(215, 7)
        Me.btnAccessOK.Name = "btnAccessOK"
        Me.btnAccessOK.Size = New System.Drawing.Size(81, 23)
        Me.btnAccessOK.TabIndex = 18
        Me.btnAccessOK.Text = "确定(&O)"
        Me.btnAccessOK.UseVisualStyleBackColor = True
        '
        'txtAccessPW
        '
        Me.txtAccessPW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAccessPW.Caption = "密    码"
        Me.txtAccessPW.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtAccessPW.Location = New System.Drawing.Point(8, 34)
        Me.txtAccessPW.Name = "txtAccessPW"
        Me.txtAccessPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAccessPW.SelectionStart = 0
        Me.txtAccessPW.Size = New System.Drawing.Size(167, 21)
        Me.txtAccessPW.TabIndex = 16
        Me.txtAccessPW.TextBoxType = Control.TextBoxType.txt
        Me.txtAccessPW.Value = Nothing
        '
        'txtAccessPath
        '
        Me.txtAccessPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAccessPath.Caption = "路    径"
        Me.txtAccessPath.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtAccessPath.Enabled = False
        Me.txtAccessPath.Location = New System.Drawing.Point(8, 7)
        Me.txtAccessPath.Name = "txtAccessPath"
        Me.txtAccessPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccessPath.SelectionStart = 0
        Me.txtAccessPath.Size = New System.Drawing.Size(167, 21)
        Me.txtAccessPath.TabIndex = 15
        Me.txtAccessPath.TextBoxType = Control.TextBoxType.txt
        Me.txtAccessPath.Value = Nothing
        '
        'txtSQLSA
        '
        Me.txtSQLSA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSQLSA.Caption = "用    户"
        Me.txtSQLSA.CaptionColor = System.Drawing.SystemColors.ControlText
        Me.txtSQLSA.Location = New System.Drawing.Point(6, 60)
        Me.txtSQLSA.Name = "txtSQLSA"
        Me.txtSQLSA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSQLSA.SelectionStart = 0
        Me.txtSQLSA.Size = New System.Drawing.Size(167, 21)
        Me.txtSQLSA.TabIndex = 11
        Me.txtSQLSA.TextBoxType = Control.TextBoxType.txt
        Me.txtSQLSA.Value = Nothing
        '
        'frmDataConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 142)
        Me.Controls.Add(Me.Tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDataConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数据库连接"
        Me.TopMost = True
        Me.Tab.ResumeLayout(False)
        Me.TPSQL.ResumeLayout(False)
        Me.TPAccess.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents TPSQL As System.Windows.Forms.TabPage
    Friend WithEvents btnSQLCancel As System.Windows.Forms.Button
    Friend WithEvents btnSQLOK As System.Windows.Forms.Button
    Friend WithEvents txtSQLPW As Control.MyTextBox
    Friend WithEvents txtSQLDataBase As Control.MyTextBox
    Friend WithEvents txtSQLServerName As Control.MyTextBox
    Friend WithEvents TPAccess As System.Windows.Forms.TabPage
    Friend WithEvents btnAccessCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccessOK As System.Windows.Forms.Button
    Friend WithEvents txtAccessPW As Control.MyTextBox
    Friend WithEvents txtAccessPath As Control.MyTextBox
    Friend WithEvents btnAccessPath As System.Windows.Forms.Button
    Friend WithEvents txtSQLSA As Control.MyTextBox
End Class

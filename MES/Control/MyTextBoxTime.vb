''' <summary>
''' 文本框控件
''' </summary>
''' <remarks></remarks>
Public Class MyTextBoxTime

    Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Dim txtTemp As New TextBox
        Me.Width = 100
        Me.Height = txtTemp.Height
        Me.Pic.Width = txtTemp.Height
        Me.Pic.Height = txtTemp.Height
    End Sub
    ''' <summary>
    ''' 结束编辑事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Event EndEdit As System.EventHandler
    ''' <summary>
    ''' 点击放大镜事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Event ZoomClick As System.EventHandler
    ''' <summary>
    ''' 文本内容改变事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Shadows Event TextChanged As System.EventHandler
    ''' <summary>
    ''' 值改变事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Event ValueChanged As System.EventHandler
    ''' <summary>
    ''' 触发点击放大镜事件
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub OnZoomClick(ByVal e As EventArgs)
        RaiseEvent ZoomClick(Me, e)
    End Sub

    ''' <summary>
    ''' 触发文本内容改变事件
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Protected Overloads Sub OnTextChanged(ByVal e As EventArgs)
        RaiseEvent TextChanged(Me, e)
    End Sub

#Region "Propertys"
    Private _BorderStyle As BorderStyle
    ''' <summary>
    ''' 文本框边框样式
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Property BorderStyle() As System.Windows.Forms.BorderStyle
        Get
            Return _BorderStyle
        End Get
        Set(ByVal value As System.Windows.Forms.BorderStyle)
            _BorderStyle = value
            Me.LayoutControl()
        End Set
    End Property
    ''' <summary>
    ''' 获取或设置字符,该字符用于屏蔽文本框中的内容
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PasswordChar() As Char
        Get
            Return Me.txt.PasswordChar
        End Get
        Set(ByVal value As Char)
            Me.txt.PasswordChar = value
        End Set
    End Property
    ''' <summary>
    ''' 文本框标题
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Caption() As String
        Get
            Return Me.lblCaption.Text
        End Get
        Set(ByVal value As String)
            Me.lblCaption.Text = value
        End Set
    End Property
    ''' <summary>
    ''' 文本框标题颜色
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CaptionColor() As System.Drawing.Color
        Get
            Return Me.lblCaption.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.lblCaption.ForeColor = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    ''' <summary>
    ''' 是否可用
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Property Enabled() As Boolean
        Get
            Return _Enabled
        End Get
        Set(ByVal value As Boolean)
            _Enabled = value
            Me.LayoutControl()
        End Set
    End Property
    ''' <summary>
    ''' 文本框内容
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Property Text() As String
        Get
            Return Me.txt.Text
        End Get
        Set(ByVal value As String)
            If Me.TextBoxType = Control.TextBoxType.txtDateTime Then
                If IsDate(value) Then
                    Me.txt.Text = CDate(value).ToString("yyyy-MM-dd HH:mm:ss")
                ElseIf value = "" Then
                    Me.txt.Text = ""
                End If
            Else
                Me.txt.Text = value
            End If
        End Set
    End Property

    Private _TextBoxType As TextBoxType = Control.TextBoxType.txt
    ''' <summary>
    ''' 文本框类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TextBoxType() As TextBoxType
        Get
            Return Me._TextBoxType
        End Get
        Set(ByVal value As TextBoxType)
            Me._TextBoxType = value
            If value = Control.TextBoxType.txtDateTime Then
                Pic.Image = Me.PicDate.Image
            ElseIf value = Control.TextBoxType.txtZoom Then
                Pic.Image = Me.picZoom.Image
            End If
        End Set
    End Property
    ''' <summary>
    ''' 文本对齐方式
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return txt.TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            txt.TextAlign = value
        End Set
    End Property

    Private _Value As String
    ''' <summary>
    ''' 文本框值
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Value() As String
        Get
            Return Me._Value
        End Get
        Set(ByVal value As String)
            Dim Temp As String = Me._Value
            Me._Value = value
            If Temp <> Me._Value Then
                RaiseEvent ValueChanged(Me, New System.EventArgs)
            End If
        End Set
    End Property

    Private Datas As New DataCollection
    ''' <summary>
    ''' 按名称获取或设置与控件关联的数据
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads ReadOnly Property Tag() As DataCollection
        Get
            Return Datas
        End Get
    End Property
    ''' <summary>
    ''' 获取或设置文本框选定文本的起始位置
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SelectionStart() As Integer
        Get
            Return txt.SelectionStart
        End Get
        Set(ByVal value As Integer)
            txt.SelectionStart = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' 设置控件
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LayoutControl()
        '--Set Left And Width-------
        lblCaption.Left = 0
        txt.Left = lblCaption.Width
        If Pic.Visible = False Then
            txt.Width = Me.Width - lblCaption.Width
        Else
            txt.Width = Me.Width - lblCaption.Width - Pic.Width
            Pic.Left = Me.Width - Pic.Width
        End If
        Pic.Top = (Me.Height - Pic.Height) / 2
        '--------
        If Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle Then
            txt.BorderStyle = Windows.Forms.BorderStyle.None
            lblLine.Visible = True
            txt.ReadOnly = Not Me.Enabled
            txt.BackColor = Me.BackColor
            lblLine.BackColor = IIf(Me.Enabled, Color.Black, Color.Gray)
            txt.Top = (Me.Height - txt.Height) / 2
            lblLine.Top = txt.Top + txt.Height
            lblCaption.Top = txt.Top
        ElseIf Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D Then
            txt.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            lblLine.Visible = False
            txt.ReadOnly = Not Me.Enabled
            txt.BackColor = IIf(Me.Enabled, Color.White, Color.FromArgb(224, 224, 224))
            txt.Top = (Me.Height - txt.Height) / 2
            lblLine.Top = txt.Top + txt.Height
            lblCaption.Top = (Me.Height - lblCaption.Height) / 2
        ElseIf Me.BorderStyle = Windows.Forms.BorderStyle.None Then
            txt.BorderStyle = Windows.Forms.BorderStyle.None
            lblLine.Visible = False
            txt.ReadOnly = Not Me.Enabled
            txt.BackColor = IIf(Me.Enabled, Color.White, Color.FromArgb(224, 224, 224))
            txt.Top = (Me.Height - txt.Height) / 2
            lblLine.Top = txt.Top + txt.Height
            lblCaption.Top = txt.Top
        End If
        '------
        lblCaption.BackColor = Me.BackColor
        Pic.BackColor = Me.BackColor
        lblLine.Left = txt.Left
        lblLine.Width = txt.Width
    End Sub

    Private Sub MyTextBox_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ForeColorChanged
        txt.ForeColor = Me.ForeColor
    End Sub

    Private Sub MyTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        If Me.TextBoxType = Control.TextBoxType.txtDate And Me.Text.Trim <> "" Then
            If IsDate(Me.Text) = False Then
                MsgBox("日期格式不正确", MsgBoxStyle.Information, "提示")
                Me.Focus()
                Exit Sub
            Else
                txt.Text = CDate(txt.Text).ToString("yyyy-MM-dd HH:mm")
            End If
        End If
        Pic.Visible = False
        If Me.Enabled = True Then
            RaiseEvent EndEdit(Me, New EventArgs)
        End If
    End Sub

    Private Sub MyTextBox_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    Me.BackColorChanged, lblCaption.SizeChanged, Pic.VisibleChanged
        Me.LayoutControl()
    End Sub

    Private Sub MyTextBox_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Me.LayoutControl()
    End Sub

    Private Sub Pic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pic.Click
        If Me.TextBoxType = Control.TextBoxType.txtDateTime Then
            Dim frm As New FrmDateTime
            frm.Left = Windows.Forms.Control.MousePosition.X
            frm.Top = Windows.Forms.Control.MousePosition.Y
            If IsDate(Me.Text.Trim) Then
                frm.SelectedDate = Me.Text.Trim
            End If
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Text = frm.SelectedDate
            End If
        ElseIf Me.TextBoxType = Control.TextBoxType.txtZoom Then
            RaiseEvent ZoomClick(Me, e)
        End If
    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt.GotFocus
        If Me.TextBoxType <> Control.TextBoxType.txt And Me.Enabled = True Then
            Pic.Visible = True
        End If
        Me.OnGotFocus(e)
    End Sub

    Private Sub txt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt.TextChanged
        RaiseEvent TextChanged(Me, e)
        Me.OnTextChanged(e)
    End Sub

#Region "MouseEvent"
    Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
  lblCaption.MouseDown, lblLine.MouseDown, txt.MouseDown, Pic.MouseDown
        Dim e1 As New MouseEventArgs(e.Button, e.Clicks, e.X + sender.Left, e.Y + sender.top, e.Delta)
        Me.OnMouseDown(e1)
    End Sub

    Private Sub lblCaption_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    lblCaption.MouseEnter, lblLine.MouseEnter, txt.MouseEnter, Pic.MouseEnter
        Me.OnMouseEnter(e)
    End Sub

    Private Sub lblCaption_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    lblCaption.MouseLeave, lblLine.MouseLeave, txt.MouseLeave, Pic.MouseLeave
        Me.OnMouseLeave(e)
    End Sub

    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    lblCaption.MouseMove, lblLine.MouseMove, Pic.MouseMove, txt.MouseMove
        Dim e1 As New MouseEventArgs(e.Button, e.Clicks, e.X + sender.Left, e.Y + sender.top, e.Delta)
        Me.OnMouseMove(e1)
    End Sub

    Private Sub lblCaption_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    lblCaption.MouseUp, lblLine.MouseUp, Pic.MouseUp, txt.MouseUp
        Dim e1 As New MouseEventArgs(e.Button, e.Clicks, e.X + sender.Left, e.Y + sender.top, e.Delta)
        Me.OnMouseUp(e1)
    End Sub
#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt.KeyDown
        If e.KeyCode = Keys.F2 And Me.TextBoxType = Control.TextBoxType.txtZoom And Me.Enabled = True Then
            Me.OnZoomClick(New EventArgs)
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.SendWait("{Tab}")
        End If
        Me.OnKeyDown(e)
    End Sub

    Private KeyPressSender As Object = Me
    Private Sub MyTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If KeyPressSender Is Me Then
            txt.Text = e.KeyChar
            txt.SelectionStart = txt.Text.Length
        End If
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt.KeyPress
        KeyPressSender = txt
        Me.OnKeyPress(e)
        KeyPressSender = Me
    End Sub




End Class


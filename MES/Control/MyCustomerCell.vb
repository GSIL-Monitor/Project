Public Class MyCustomerCell

    Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Dim txtTemp As New ComboBox
        Me.Width = 100
        Me.Height = txtTemp.Height + Me.lblHeatText.Height

    End Sub

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

    Public Property Caption() As String
        Get
            Return Me.lblHeatText.Text
        End Get
        Set(ByVal value As String)
            Me.lblHeatText.Text = value
        End Set
    End Property

    Public Property CaptionColor() As System.Drawing.Color
        Get
            Return Me.lblHeatText.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.lblHeatText.ForeColor = value
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
            LayoutControl()
        End Set
    End Property

    Private _Visabled As Boolean = True
    ''' <summary>
    ''' 是否显示
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Property Visabled() As Boolean
        Get
            Return _Visabled
        End Get
        Set(ByVal value As Boolean)
            _Visabled = value
            Me.LayoutControl()
        End Set
    End Property


    Public Overloads Property Text() As String
        Get
            Return Me.combo.Text
        End Get
        Set(ByVal value As String)
            Me.combo.Text = ""
        End Set
    End Property


    Private Sub MyTextBox_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ForeColorChanged
        combo.ForeColor = Me.ForeColor
    End Sub

    Private Sub LayoutControl()

        '--Set Left And Width-------
        Me.lblHeatText.Left = 15
        Me.combo.Left = 5

        '--------
        If Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle Then
           
            Me.combo.Enabled = Me.Enabled
            combo.BackColor = Me.BackColor
            Me.combo.Visible = Me.Visabled
            Me.lblHeatText.Visible = Me.Visabled
            Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

        End If
        '------
        lblHeatText.BackColor = Me.BackColor
       
    End Sub


End Class

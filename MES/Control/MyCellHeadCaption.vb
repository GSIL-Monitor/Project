
Public Class MyCellHeadCaption


    Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub


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



End Class

''' <summary>
''' 表格镜列
''' </summary>
''' <remarks></remarks>
Public MustInherit Class MyDataGridViewColumn
    Inherits DataGridViewColumn
    Sub New()
        MyBase.New(New MyDataGridViewCell)
    End Sub

    Private _TextBoxType As TextBoxType = Control.TextBoxType.txt
    ''' <summary>
    ''' 文本框类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property TextBoxType() As TextBoxType
        Get
            Return Me._TextBoxType
        End Get
        Set(ByVal value As TextBoxType)
            Me._TextBoxType = value
        End Set
    End Property
    ''' <summary>
    ''' 点击放大镜事件
    ''' </summary>
    ''' <remarks></remarks>
    Protected Event ZoomClick As System.EventHandler
    ''' <summary>
    ''' 结束编辑事件
    ''' </summary>
    ''' <remarks></remarks>
    Protected Event EndEdit As System.EventHandler
    ''' <summary>
    ''' 触发点击放大镜事件
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Friend Sub OnZoomClick(ByVal e As EventArgs)
        RaiseEvent ZoomClick(Me, e)
    End Sub
    ''' <summary>
    ''' 触发结束编辑事件
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Friend Sub OnEndEdit(ByVal e As EventArgs)
        RaiseEvent EndEdit(Me, e)
    End Sub
End Class


''' <summary>
''' 日期列
''' </summary>
''' <remarks></remarks>
Public Class DataGridViewDateColumn
    Inherits MyDataGridViewColumn
    Sub New()
        MyBase.New()
        Me.TextBoxType = Control.TextBoxType.txtDate
    End Sub
End Class



''' <summary>
''' 放大镜列
''' </summary>
''' <remarks></remarks>
Public Class DataGridViewZoomColumn
    Inherits MyDataGridViewColumn
    Sub New()
        MyBase.New()
        Me.TextBoxType = Control.TextBoxType.txtZoom
    End Sub
    ''' <summary>
    ''' 点击放大镜事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Shadows Event ZoomClick As System.EventHandler
    ''' <summary>
    ''' 结束编辑事件
    ''' </summary>
    ''' <remarks></remarks>
    Public Shadows Event EndEdit As System.EventHandler

#Region "Propertys"
    Private _Text As String
    ''' <summary>
    ''' 文本内容
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
        End Set
    End Property
    Private _Value As String
    ''' <summary>
    ''' 值
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Value() As String
        Get
            Return Me._Value
        End Get
        Set(ByVal value As String)
            Me._Value = value
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
#End Region

    Private Sub DataGridViewZoomColumn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EndEdit
        RaiseEvent EndEdit(Me, e)
    End Sub

    Private Sub DataGridViewZoomColumn_ZoomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ZoomClick
        RaiseEvent ZoomClick(Me, e)
    End Sub

End Class
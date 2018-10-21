''' <summary>
''' 调试函数
''' </summary>
''' <remarks></remarks>
Public Class Debug

    ''' <summary>
    ''' 测试数据
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <remarks></remarks>
    Public Shared Sub TestData(ByVal Source As Object)

        Dim dg As New DataGridView
        dg.DataSource = Source
        Dim frm As New Form
        frm.Controls.Add(dg)
        dg.Dock = DockStyle.Fill
        dg.DataSource = Source
        frm.ShowDialog()

    End Sub

    ''' <summary>
    ''' 显示消息
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="title"></param>
    ''' <remarks></remarks>
    Public Shared Sub myMsg(ByVal str As String, Optional ByVal title As String = "提示")
        If title = "" Then
            MsgBox(str, MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            MsgBox(str, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, title)
        End If
    End Sub

End Class

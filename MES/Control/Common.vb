''' <summary>
''' 公共函数
''' </summary>
''' <remarks></remarks>
Public Class Common
    ''' <summary>
    ''' 获取指定TabIndex的控件
    ''' </summary>
    ''' <param name="Parent">父控件</param>
    ''' <param name="TabIndex">Tab顺序</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getControl(ByVal Parent As System.Windows.Forms.Control, ByVal TabIndex As Integer) As System.Windows.Forms.Control
        For Each con As System.Windows.Forms.Control In Parent.Controls
            If con.TabIndex = TabIndex Then
                Return con
            End If
        Next
    End Function

End Class

''' <summary>
''' 表格控件
''' </summary>
''' <remarks></remarks>
Public Class MyDataGridView
    Inherits DataGridView

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            Select Case keyData
                Case Keys.Enter
                    If Me.RowCount <> 0 Then
                        SendKeys.SendWait("{tab}")
                        Return True
                    End If
            End Select
            Return MyBase.ProcessCmdKey(msg, keyData)
        Catch ex As Exception

        End Try
    End Function

    ''' <summary>
    ''' 刷新行
    ''' </summary>
    ''' <param name="RowIndex">行索引</param>
    ''' <remarks></remarks>
    Public Sub RefreshRow(ByVal RowIndex As Integer)

        Try
            Dim dr As DataGridViewRow = Me.Rows(RowIndex)
            If dr IsNot Nothing Then
                If dr.Selected = False Then
                    dr.Selected = True
                    dr.Selected = False
                ElseIf dr.Selected = True Then
                    dr.Selected = False
                    dr.Selected = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' 刷新行
    ''' </summary>
    ''' <param name="Row">行</param>
    ''' <remarks></remarks>
    Public Sub RefreshRow(ByVal Row As DataGridViewRow)
        Me.RefreshRow(Row.Index)
    End Sub

    Private Sub MyDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CellEndEdit
        Me.RefreshRow(e.RowIndex)
    End Sub

    Private Sub myDg_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Me.DataError
        MsgBox(e.Exception.Message, MsgBoxStyle.Information, "提示")
    End Sub

    ''' <summary>
    ''' 重新邦定数据源
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RebindDataSource()
        Dim obj As Object = Me.DataSource
        Me.DataSource = Nothing
        Me.DataSource = obj
    End Sub

    ''' <summary>
    ''' 设置列
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SettingColumns()

        Dim frm As New frmDataGridSetting(Me)
        frm.ShowDialog()

    End Sub
    ''' <summary>
    ''' 将列名改为标题名
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ChangeColumnNameAsHeader()
        For Each col As DataGridViewColumn In Me.Columns
            col.Name = col.HeaderText
        Next
    End Sub
























End Class

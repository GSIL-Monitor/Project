Imports System.Data

Public Class NewOrders

    Private Sub NewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kanban.IniDataConnection()
        RefashData()
    End Sub

    '推送新订单提醒
    Private Sub NewOrder()

        Dim Str As String = ""
        Str = "Select  Count(*)  from OperateRecord "
        Str &= " where cOperate like '%点击【确认】 报价单号%' "
        Str &= " AND cTime BETWEEN '" & Now.AddSeconds(-90) & "' AND '" & Now.AddSeconds(60) & "' "
        Dim iCount As Integer = Common.ConvertData.todbl(Common.DataBase.ExecCmd(Str))
        If iCount > 0 Then
            System.Media.SystemSounds.Exclamation.Play()
            Speech.Speech.Create.PlayVoice("您有新订单，请及时处理")
        End If

    End Sub

    Private Sub RefashData()

        Dim bll As New BLL.Order.IF_ORDERS
        Dim dt As DataTable = bll.getNewOrdersCollectionLimit(10)
        dg1.DataSource = dt

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        RefashData()
        NewOrder()

    End Sub

End Class
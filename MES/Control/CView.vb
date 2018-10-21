
Imports System.Drawing
Imports System.Drawing.Printing

Public Class CView

    Public pBGN As Integer '指定页开始页
    Public pEND As Integer '指定页结束页
    Dim bFirst As Boolean '是否缩放
    Public pMax As Integer '获取最大页
    Public pMin As Integer '获取最小页
    Public nPrint As Integer = 0 '真正打印时


    Public Sub Init()

        Me.pCtrlView.Zoom = 1.0
        Me.pCtrlView.StartPage = 0
        Me.sPanPageBGN.Text = pMin.ToString()
        Me.sPanPageEnd.Text = pMax.ToString()
        Me.pCtrlView.BackColor = Color.Gray

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        pCtrlView.Dispose()
        Me.Visible = False

    End Sub

    Private Sub btnPrint_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnPrint.KeyDown

        Print()

    End Sub

    Private Sub Print()

        Dim pDialog As New PrintDialog
        pDialog.Document = pCtrlView.Document

        pDialog.AllowPrintToFile = False
        pDialog.ShowHelp = False
        pDialog.AllowSomePages = False

        pDialog.PrinterSettings.FromPage = pMin
        pDialog.PrinterSettings.ToPage = pMax

        pDialog.PrinterSettings.MaximumPage = pMax
        pDialog.PrinterSettings.MinimumPage = pMin

        pDialog.PrinterSettings.PrintRange = PrintRange.SomePages
        pDialog.Document.PrinterSettings.Collate = True
        pDialog.ShowNetwork = True

        If pDialog.ShowDialog = DialogResult.OK Then

            Me.pCtrlView.InvalidatePreview()
            Me.Refresh()

            Me.pBGN = pDialog.PrinterSettings.FromPage
            Me.pEND = pDialog.PrinterSettings.ToPage
            Me.nPrint = 1
            Me.pCtrlView.Document.Print()

        End If

    End Sub

    Private Sub btnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoom.Click

        If bFirst = True Then
            Me.pCtrlView.Zoom = 0.75
            bFirst = False
        Else
            Me.pCtrlView.Zoom = 1.0
            bFirst = True
        End If

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        '//下一页
        Dim pPage As Integer
        pPage = pCtrlView.StartPage
        If pPage <= 0 Then pPage = 0
        pPage = pPage + 1
        If pPage > pMax - 1 Then pPage = Val(Me.sPanPageEnd.Text)
        pCtrlView.StartPage = pPage
        Me.sPanPageBGN.Text = Me.pCtrlView.StartPage + 1

    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        '//上一页
        Dim pPage As Integer
        pPage = Me.pCtrlView.StartPage
        If pPage > pMax - 1 Then pPage = pMax
        pPage = pPage - 1
        If pPage <= 0 Then pPage = 0
        Me.pCtrlView.StartPage = pPage
        Me.sPanPageBGN.Text = Me.pCtrlView.StartPage + 1

    End Sub

    Private Sub btnSetUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetUp.Click

        Dim pPageSetup As New PageSetupDialog
        pPageSetup.Document = pCtrlView.Document
        If pPageSetup.ShowDialog = DialogResult.OK Then
            Me.pCtrlView.InvalidatePreview()
            Me.Refresh()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Print()

    End Sub

End Class

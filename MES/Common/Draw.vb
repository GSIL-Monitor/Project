Imports System.Drawing
Imports System.Drawing.Drawing2D

''' <summary>
''' 制图
''' </summary>
''' <remarks></remarks>
Public Class Draw

    ''' <summary>
    ''' 画圆边框四边形
    ''' </summary>
    ''' <param name="rc">Rectangle </param>
    ''' <param name="r">角度</param>
    ''' <returns>GraphicsPath</returns>
    ''' <remarks></remarks>
    Public Shared Function DrawPath(ByVal rc As Rectangle, ByVal r As Integer) As GraphicsPath

        Dim x As Integer = rc.X, y As Integer = rc.Y, w As Integer = rc.Width, h As Integer = rc.Height
        Dim path As New GraphicsPath()
        path.AddArc(x, y, r, r, 180, 90)
        '
        path.AddArc(x + w - r, y, r, r, 270, 90)
        '
        path.AddArc(x + w - r, y + h - r, r, r, 0, 90)
        '
        path.AddArc(x, y + h - r, r, r, 90, 90)
        '
        path.CloseFigure()
        Return path

    End Function

    '实体调用时 

    'e.Graphics.DrawPath(blackPen2, DrawPath(New Rectangle(200, 465, 170, 120), 20))
    'Dim bmp As System.Drawing.Bitmap = New Ean13("690", "1645", "1234").CreateBitmap()
    'e.Graphics.DrawImage(bmp, (X1 + 5.5F) * Cm, (Y1 + NY1) * Cm)





End Class


''' <summary>
''' 条形码39类
''' </summary>
''' <remarks></remarks>
''' 
Public Class Code39

    Public Shared Function Create() As Code39
        Return New Code39()
    End Function

    ''' <summary>
    ''' 将字符串转为图像文件Bitmap
    ''' </summary>
    ''' <param name="strSource"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCode39(ByVal strSource As String) As Bitmap
        Dim x As Integer = 5
        '左邊界
        Dim y As Integer = 0
        '上邊界
        Dim WidLength As Integer = 2
        '粗BarCode長度
        Dim NarrowLength As Integer = 1
        '細BarCode長度
        Dim BarCodeHeight As Integer = 28
        'BarCode高度
        Dim intSourceLength As Integer = strSource.Length
        Dim strEncode As String = "010010100"
        '編碼字串 初值為 起始符號 *
        Dim AlphaBet As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*"
        'Code39的字母
        'Code39的各字母對應碼
        ' 0 
        ' 1 
        ' 2 
        ' 3 
        ' 4 
        ' 5 
        ' 6 
        ' 7 
        ' 8 
        ' 9 
        ' A 
        ' B 
        ' C 
        ' D 
        ' E 
        ' F 
        ' G 
        ' H 
        ' I 
        ' J 
        ' K 
        ' L 
        ' M 
        ' N 
        ' O 
        ' P 
        ' Q 
        ' R 
        ' S 
        ' T 
        ' U 
        ' V 
        ' W 
        ' X 
        ' Y 
        ' Z 
        ' - 
        ' . 
        '' '
        ' $ 
        ' / 
        ' + 
        ' % 
        ' * 
        Dim Code39 As String() = {"000110100", "100100001", "001100001", "101100000", "000110001", "100110000", _
         "001110000", "000100101", "100100100", "001100100", "100001001", "001001001", _
         "101001000", "000011001", "100011000", "001011000", "000001101", "100001100", _
         "001001100", "000011100", "100000011", "001000011", "101000010", "000010011", _
         "100010010", "001010010", "000000111", "100000110", "001000110", "000010110", _
         "110000001", "011000001", "111000000", "010010001", "110010000", "011010000", _
         "010000101", "110000100", "011000100", "010101000", "010100010", "010001010", _
         "000101010", "010010100"}

        strSource = strSource.ToUpper()

        '實作圖片
        Dim objBitmap As New Bitmap(((WidLength * 3 + NarrowLength * 7) * (intSourceLength + 2)) + (x * 2), BarCodeHeight + (y * 2))
        Dim objGraphics As Graphics = Graphics.FromImage(objBitmap)
        '宣告GDI+繪圖介面
        '填上底色
        objGraphics.FillRectangle(Brushes.White, 0, 0, objBitmap.Width, objBitmap.Height)

        For i As Integer = 0 To intSourceLength - 1
            If AlphaBet.IndexOf(strSource(i)) = -1 OrElse strSource(i) = "*"c Then
                '檢查是否有非法字元
                objGraphics.DrawString("含有非法字元", SystemFonts.DefaultFont, Brushes.Red, x, y)
                Return objBitmap
            End If
            '查表編碼
            strEncode = String.Format("{0}0{1}", strEncode, Code39(AlphaBet.IndexOf(strSource(i))))
        Next

        strEncode = String.Format("{0}0010010100", strEncode)
        '補上結束符號 *
        Dim intEncodeLength As Integer = strEncode.Length
        '編碼後長度
        Dim intBarWidth As Integer

        For i As Integer = 0 To intEncodeLength - 1
            '依碼畫出Code39 BarCode
            intBarWidth = If(strEncode(i) = "1"c, WidLength, NarrowLength)
            objGraphics.FillRectangle(If(i Mod 2 = 0, Brushes.Black, Brushes.White), x, y, intBarWidth, BarCodeHeight)
            x += intBarWidth
        Next
        Return objBitmap

    End Function

End Class

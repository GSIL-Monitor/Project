
''' <summary>
''' 中文人民币大小写转换函数
''' </summary>
''' <remarks></remarks>
Public Class Currency

    Inherits Object

    Private Const CST_CAPSTR_TAIL As String = "整"

    Private Const CST_CAPSSTR_ZERO As String = "零"

    Private Const CST_CAPSSTR As String = CST_CAPSSTR_ZERO & "壹贰叁肆伍陆柒捌玖"

    Private Const CST_POSSTR_YUAN As String = "圆"

    Private Const CST_POSSTR As String = "万仟佰拾亿仟佰拾万仟佰拾" & CST_POSSTR_YUAN & "角分"

    Private Const CST_CHNNUM_ZERO As String = CST_CAPSSTR_ZERO & CST_POSSTR_YUAN & CST_CAPSTR_TAIL



    Private Shared ReadOnly CST_MAXLENGTH As Integer = CST_POSSTR.Length



    Public Shared Function ConvertToCapsString(ByVal dec As Decimal) As String

        Dim i, j, nZero As Integer

        Dim strDec, strPos, ch1, ch2 As String

        Dim chnNum, chnPos As String

        Dim strOnePosValue As String

        Dim intOnePosValue As Integer



        '将num取绝对值并四舍五入取2位小数 

        dec = Math.Round(Math.Abs(dec), 2)

        '将num乘100并转换成字符串形式 

        strDec = Convert.ToInt64(dec * 100).ToString

        '找出最高位 

        j = strDec.Length

        If i > CST_MAXLENGTH Then

            Throw New OverflowException

        ElseIf dec = 0 Then

            '零圆的时候，直接输出“零圆整” 

            chnNum = CST_CHNNUM_ZERO

        Else

            '取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾圆角分 

            strPos = CST_POSSTR.Substring(CST_MAXLENGTH - j)

            '循环取出每一位需要转换的值 

            For i = 0 To j - 1

                '取出需转换的某一位的值 
                strOnePosValue = strDec.Substring(i, 1)

                '转换为数字 

                intOnePosValue = Convert.ToInt32(strOnePosValue)

                If i <> j - 3 AndAlso i <> j - 7 AndAlso i <> j - 15 Then

                    '当所取位数不为圆、万、亿、万亿上的数字时 

                    If strOnePosValue = "0" Then

                        '此位为零，只计入零的个数。不转换。 

                        ch1 = ""

                        ch2 = ""

                        nZero = nZero + 1

                    Else

                        '此位非零 

                        If nZero = 0 Then

                            '前面没有零，追加此位的中文 

                            ch1 = CST_CAPSSTR.Substring(intOnePosValue * 1, 1)

                            ch2 = strPos.Substring(i, 1)

                            nZero = 0

                        Else

                            '前面已经有零，无论有多少只加一个零，然后追加此位的中文 

                            ch1 = CST_CAPSSTR_ZERO & CST_CAPSSTR.Substring(intOnePosValue * 1, 1)

                            ch2 = strPos.Substring(i, 1)

                            nZero = 0

                        End If

                    End If

                Else

                    '该位是万亿，亿，万，圆位等关键位 

                    If strOnePosValue <> "0" AndAlso nZero <> 0 Then

                        ch1 = CST_CAPSSTR_ZERO & CST_CAPSSTR.Substring(intOnePosValue * 1, 1)

                        ch2 = strPos.Substring(i, 1)

                        nZero = 0

                    Else

                        If strOnePosValue <> "0" AndAlso nZero = 0 Then

                            ch1 = CST_CAPSSTR.Substring(intOnePosValue * 1, 1)

                            ch2 = strPos.Substring(i, 1)

                            nZero = 0

                        Else

                            If strOnePosValue = "0" AndAlso nZero >= 3 Then

                                ch1 = ""

                                ch2 = ""

                                nZero = nZero + 1

                            Else

                                If j > 11 Then

                                    '亿以上 

                                    ch1 = ""

                                    nZero = nZero + 1

                                Else

                                    '亿以下 

                                    ch1 = ""

                                    ch2 = strPos.Substring(i, 1)

                                    nZero = nZero + 1

                                End If

                            End If

                        End If

                    End If

                End If

                If i = j - 11 OrElse i = j - 3 Then

                    '如果该位是亿位或圆位，则必须写上 

                    ch2 = strPos.Substring(i, 1)

                End If

                chnNum = chnNum & ch1 & ch2

                If i = j - 1 AndAlso strOnePosValue = "0" Then

                    '最后一位（分）为0时，加上“整” 

                    chnNum = chnNum & CST_CAPSTR_TAIL

                End If

            Next

        End If

        Return chnNum

    End Function



    Public Shared Function ConvertToCapsString(ByVal dec As String) As String

        Dim num As Decimal = 0

        Try

            num = Convert.ToDecimal(dec)

        Catch ex As Exception

            Throw New InvalidateDecimalFormatException(dec)

        End Try

        Return ConvertToCapsString(num)

    End Function



    Public Class OverflowException

        Inherits Exception

        Public Sub New()

            MyBase.New("Overflow in parameter. To string length must less than " & CST_MAXLENGTH & ".")

        End Sub



    End Class



    Public Class InvalidateDecimalFormatException

        Inherits Exception



        Private m_val As String



        Public ReadOnly Property Value() As String

            Get

                Return m_val

            End Get

        End Property



        Public Sub New(ByVal val As String)

            MyBase.New("The string value cannot be converted to decimal.")

            m_val = val

        End Sub



    End Class



End Class


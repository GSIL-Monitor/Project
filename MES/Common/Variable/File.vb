Imports System.Windows.Forms

''' <summary>
''' 文件
''' </summary>
''' <remarks></remarks>
Friend Class File

    Private Shared Path As String = Application.StartupPath & "\LoginSetting\"
    Private Shared Encode As System.Text.Encoding = System.Text.Encoding.GetEncoding("gb2312")

    ''' <summary>
    ''' 创建文件
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <remarks></remarks>
    Private Shared Sub Create(ByVal FileName As String)
        Dim cPath As String = Path & FileName
        If IO.Directory.Exists(Path) = False Then
            IO.Directory.CreateDirectory(Path)
        End If
        If IO.File.Exists(cPath) = False Then
            IO.File.Create(Path & FileName).Close()
        End If
    End Sub
    ''' <summary>
    ''' 写入值
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Shared Sub Write(ByVal FileName As String, ByVal Value As String)
        Dim cPath As String = Path & FileName
        Create(FileName)
        IO.File.WriteAllText(cPath, Value, Encode)
    End Sub

    ''' <summary>
    ''' 读取值
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <remarks></remarks>
    Public Shared Function Read(ByVal FileName As String) As String
        Dim cPath As String = Path & FileName
        Create(FileName)
        Dim Value As String = IO.File.ReadAllText(cPath, Encode)
        Return Value
    End Function
End Class

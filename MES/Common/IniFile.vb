

Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Public Class IniFile

    Shared Path As String = Application.StartupPath & "\LoginSetting\"
    ' Private Shared Encode As System.Text.Encoding = System.Text.Encoding.GetEncoding("gb2312")

    'ini 文件
    '    [Section1] 
    'KeyWord1 = Valuel 
    'KeyWord2 = Value


    '参数说明：section：
    'INI文件中的段落名称；
    'key：INI文件中的关键字；
    'def：无法读取时候时候的缺省数值；
    'retVal：读取数值；size：数值的大小；filePath：INI文件的完整路径和名称。
    ' Public path As String

    Public Sub New(ByVal INIPath As String)
        path = INIPath
    End Sub

    <DllImport("kernel32")> _
    Private Shared Function WritePrivateProfileString(ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    End Function

    <DllImport("kernel32")> _
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function


    <DllImport("kernel32")> _
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal defVal As String, ByVal retVal As [Byte](), ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    ''' <summary>
    ''' 写INI文件
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Key"></param>
    ''' <param name="Value"></param>
    Public Sub IniWriteValue(ByVal Section As String, ByVal Key As String, ByVal Value As String, ByVal FileName As String)
        WritePrivateProfileString(Section, Key, Value, Path & FileName & ".ini")
    End Sub

    ''' <summary>
    ''' 读取INI文件
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Key"></param>
    ''' <returns></returns>
    Public Function IniReadValue(ByVal Section As String, ByVal Key As String, ByVal FileName As String) As String
        Dim temp As New StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Section, Key, "", temp, 255, Path & FileName & ".ini")
        Return temp.ToString()
    End Function


    Public Function IniReadValues(ByVal section As String, ByVal key As String, ByVal FileName As String) As Byte()
        Dim temp As Byte() = New Byte(254) {}
        Dim i As Integer = GetPrivateProfileString(section, key, "", temp, 255, Path & FileName & ".ini")
        Return temp

    End Function


    ''' <summary>
    ''' 删除ini文件下所有段落
    ''' </summary>
    Public Sub ClearAllSection()
        IniWriteValue(Nothing, Nothing, Nothing, Nothing)
    End Sub
    ''' <summary>
    ''' 删除ini文件下personal段落下的所有键
    ''' </summary>
    ''' <param name="Section"></param>
    Public Sub ClearSection(ByVal Section As String)
        IniWriteValue(Section, Nothing, Nothing, Nothing)
    End Sub


    Public Function ExistINIFile() As Boolean
        Return System.IO.File.Exists(Path)
    End Function






End Class



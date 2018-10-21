Imports System.IO
Imports System.Text


Public Class Files

    Private Const KBCount As Double = 1024
    Private Const MBCount As Double = KBCount * 1024
    Private Const GBCount As Double = MBCount * 1024
    Private Const TBCount As Double = GBCount * 1024

    ''' <summary>
    ''' 取文件大小
    ''' </summary>
    ''' <param name="size"></param>
    ''' <param name="roundCount"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getSize(ByVal size As Double, ByVal roundCount As Integer) As String

        If KBCount > size Then
            Return Math.Round(size, roundCount) & "B"
        ElseIf MBCount > size Then
            Return Math.Round(size / KBCount, roundCount) & "KB"
        ElseIf GBCount > size Then
            Return Math.Round(size / MBCount, roundCount) & "MB"
        ElseIf TBCount > size Then
            Return Math.Round(size / GBCount, roundCount) & "GB"
        Else
            Return Math.Round(size / TBCount, roundCount) & "TB"
        End If

    End Function

    ''' <summary>
    ''' 取文件大小
    ''' </summary>
    ''' <param name="sFullName">文件名</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFileSizes(ByVal sFullName As String) As String

        Dim FileSize As String = "0KB"
        Dim lSize As Double = 0
        If System.IO.File.Exists(sFullName) Then
            lSize = New System.IO.FileInfo(sFullName).Length
        End If
        FileSize = getSize(lSize, 2)
        Return FileSize

    End Function

    Public Shared Sub DelectDir(ByVal srcPath As String)

        Try
            Dim dir As DirectoryInfo = New DirectoryInfo(srcPath)
            Dim fileinfo() As FileSystemInfo = dir.GetFileSystemInfos()  '返回目录中所有文件和子目录
            Dim i As FileSystemInfo
            For Each i In fileinfo
                If TypeOf i Is DirectoryInfo Then
                    Dim subdir As DirectoryInfo = New DirectoryInfo(i.FullName)
                    subdir.Delete(True)
                    '删除子目录和文件 
                Else
                    '删除指定文件
                    System.IO.File.Delete(i.FullName)
                End If
            Next
        Catch e As Exception
            Throw
        End Try

    End Sub

    Public Shared Function IsExistDirectory(ByVal directoryPath As String) As Boolean
        Return Directory.Exists(directoryPath)
    End Function

    Public Shared Function IsExistFile(ByVal filePath As String) As Boolean
        Return System.IO.File.Exists(filePath)
    End Function

    Public Shared Function IsEmptyDirectory(ByVal directoryPath As String) As Boolean
        Try
            Dim fileNames As String() = GetFileNames(directoryPath)
            If fileNames.Length > 0 Then
                Return False
            End If

            Dim directoryNames As String() = GetDirectories(directoryPath)
            Return directoryNames.Length <= 0
        Catch
            Return False
        End Try
    End Function

    Public Shared Function Contains(ByVal directoryPath As String, ByVal searchPattern As String) As Boolean
        Try
            Dim fileNames As String() = GetFileNames(directoryPath, searchPattern, False)
            Return fileNames.Length <> 0
        Catch
            Return False
        End Try
    End Function

    Public Shared Function Contains(ByVal directoryPath As String, ByVal searchPattern As String, ByVal isSearchChild As Boolean) As Boolean
        Try
            Dim fileNames As String() = GetFileNames(directoryPath, searchPattern, True)
            Return fileNames.Length <> 0
        Catch
            Return False
        End Try
    End Function

    Public Shared Sub CreateDirectory(ByVal directoryPath As String)
        If Not IsExistDirectory(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
    End Sub

    Public Shared Function CreateFilePath(ByVal filePath As String) As Boolean
        Try
            If Not IsExistFile(filePath) Then
                Dim file As FileInfo = New FileInfo(filePath)
                Dim fs As FileStream = file.Create()
                fs.Close()
            End If
        Catch
            Return False
        End Try

        Return True
    End Function

    Public Shared Function CreateFile(ByVal filePath As String, ByVal buffer As Byte()) As Boolean
        Try
            If Not IsExistFile(filePath) Then
                Dim file As FileInfo = New FileInfo(filePath)
                Dim fs As FileStream = file.Create()
                fs.Write(buffer, 0, buffer.Length)
                fs.Close()
            End If
        Catch
            Return False
        End Try

        Return True
    End Function

    Public Shared Function GetLineCount(ByVal filePath As String) As Integer
        Dim rows As String() = System.IO.File.ReadAllLines(filePath)
        Return rows.Length
    End Function

    Public Shared Function GetFileSize(ByVal filePath As String) As Integer
        Dim fi As FileInfo = New FileInfo(filePath)
        Return CInt(fi.Length)
    End Function

    Public Shared Function GetFileSizeByKB(ByVal filePath As String) As Double
        Dim fi As FileInfo = New FileInfo(filePath)
        Dim size As Long = fi.Length / 1024
        Return Double.Parse(size.ToString())
    End Function

    Public Shared Function GetFileSizeByMB(ByVal filePath As String) As Double
        Dim fi As FileInfo = New FileInfo(filePath)
        Dim size As Long = fi.Length / 1024 / 1024
        Return Double.Parse(size.ToString())
    End Function

    Public Shared Function GetFileNames(ByVal directoryPath As String) As String()
        If Not IsExistDirectory(directoryPath) Then
            Throw New FileNotFoundException()
        End If

        Return Directory.GetFiles(directoryPath)
    End Function

    Public Shared Function GetFileNames(ByVal directoryPath As String, ByVal searchPattern As String, ByVal isSearchChild As Boolean) As String()
        If Not IsExistDirectory(directoryPath) Then
            Throw New FileNotFoundException()
        End If

        Try
            Return Directory.GetFiles(directoryPath, searchPattern, If(isSearchChild, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Function GetDirectories(ByVal directoryPath As String) As String()
        Try
            Return Directory.GetDirectories(directoryPath)
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Function GetDirectories(ByVal directoryPath As String, ByVal searchPattern As String, ByVal isSearchChild As Boolean) As String()
        Try
            Return Directory.GetDirectories(directoryPath, searchPattern, If(isSearchChild, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Sub WriteText(ByVal filePath As String, ByVal content As String)
        System.IO.File.WriteAllText(filePath, content)
    End Sub

    Public Shared Sub AppendText(ByVal filePath As String, ByVal content As String)
        System.IO.File.AppendAllText(filePath, content)
    End Sub

    Public Shared Sub CopyFile(ByVal sourceFilePath As String, ByVal destFilePath As String)
        System.IO.File.Copy(sourceFilePath, destFilePath, True)
    End Sub

    Public Shared Sub Move(ByVal sourceFilePath As String, ByVal descDirectoryPath As String)
        Dim sourceFileName As String = GetFileName(sourceFilePath)
        If IsExistDirectory(descDirectoryPath) Then
            If IsExistFile(descDirectoryPath & "\" & sourceFileName) Then
                DeleteFile(descDirectoryPath & "\" & sourceFileName)
            End If

            System.IO.File.Move(sourceFilePath, descDirectoryPath & "\" & sourceFileName)
        End If
    End Sub

    Public Shared Function StreamToBytes(ByVal stream As Stream) As Byte()
        Try
            Dim buffer As Byte() = New Byte(stream.Length - 1) {}
            stream.Read(buffer, 0, Integer.Parse(stream.Length.ToString()))
            Return buffer
        Catch
            Return Nothing
        Finally
            stream.Close()
        End Try
    End Function

    Public Shared Function FileToBytes(ByVal filePath As String) As Byte()
        Dim fileSize As Integer = GetFileSize(filePath)
        Dim buffer As Byte() = New Byte(fileSize - 1) {}
        Dim fi As FileInfo = New FileInfo(filePath)
        Dim fs As FileStream = fi.Open(FileMode.Open)
        Try
            fs.Read(buffer, 0, fileSize)
            Return buffer
        Catch
            Return Nothing
        Finally
            fs.Close()
        End Try
    End Function

    Public Shared Function FileToString(ByVal filePath As String) As String
        Return FileToString(filePath, Encoding.[Default])
    End Function

    Public Shared Function FileToString(ByVal filePath As String, ByVal encoding As Encoding) As String
        Dim reader As StreamReader = New StreamReader(filePath, encoding)
        Try
            Return reader.ReadToEnd()
        Catch
            Return String.Empty
        Finally
            reader.Close()
        End Try
    End Function

    Public Shared Function GetFileName(ByVal filePath As String) As String
        Dim fi As FileInfo = New FileInfo(filePath)
        Return fi.Name
    End Function

    Public Shared Function GetFileNameNoExtension(ByVal filePath As String) As String
        Dim fi As FileInfo = New FileInfo(filePath)
        Return fi.Name.Split("."c)(0)
    End Function

    Public Shared Function GetExtension(ByVal filePath As String) As String
        Dim fi As FileInfo = New FileInfo(filePath)
        Return fi.Extension
    End Function

    Public Shared Sub ClearDirectory(ByVal directoryPath As String)
        If IsExistDirectory(directoryPath) Then
            Dim fileNames As String() = GetFileNames(directoryPath)
            For Each t As String In fileNames
                DeleteFile(t)
            Next

            Dim directoryNames As String() = GetDirectories(directoryPath)
            For Each t As String In directoryNames
                DeleteDirectory(t)
            Next
        End If
    End Sub

    Public Shared Sub ClearFile(ByVal filePath As String)
        System.IO.File.Delete(filePath)
        CreateFile(filePath)
    End Sub

    Public Shared Sub DeleteFilePath(ByVal filePath As String)
        If IsExistFile(filePath) Then
            System.IO.File.Delete(filePath)
        End If
    End Sub

    Public Shared Sub DeleteDirectory(ByVal directoryPath As String)
        If IsExistDirectory(directoryPath) Then
            Directory.Delete(directoryPath, True)
        End If
    End Sub

    Public Shared Sub ErrorLog(ByVal exMessage As String, ByVal exMethod As String, ByVal userID As Integer)
        Try
            Dim errVir As String = "/Log/Error/" & DateTime.Now.ToShortDateString() & ".txt"
            Dim errPath As String = System.Web.HttpContext.Current.Server.MapPath(errVir)
            System.IO.File.AppendAllText(errPath, "{userID:" & userID & ",exMedthod:" & exMethod & ",exMessage:" & exMessage & "}")
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' 复制文件
    ''' </summary>
    ''' <param name="sourceFolderName"></param>
    ''' <param name="destFolderName"></param>
    ''' <remarks></remarks>
    Public Shared Sub Copy(ByVal sourceFolderName As String, ByVal destFolderName As String)
        Copy(sourceFolderName, destFolderName, False)
    End Sub

    ''' <summary>
    ''' 复制文件
    ''' </summary>
    ''' <param name="sourceFolderName"></param>
    ''' <param name="destFolderName"></param>
    ''' <param name="overwrite"></param>
    ''' <remarks></remarks>
    Public Shared Sub Copy(ByVal sourceFolderName As String, ByVal destFolderName As String, ByVal overwrite As Boolean)
        Dim sourceFilesPath = Directory.GetFileSystemEntries(sourceFolderName)
        For i As Integer = 0 To sourceFilesPath.Length - 1
            Dim sourceFilePath = sourceFilesPath(i)
            Dim directoryName = Path.GetDirectoryName(sourceFilePath)
            Dim forlders = directoryName.Split("\"c)
            Dim lastDirectory = forlders(forlders.Length - 1)
            Dim dest = Path.Combine(destFolderName, lastDirectory)
            If System.IO.File.Exists(sourceFilePath) Then
                Dim sourceFileName = Path.GetFileName(sourceFilePath)
                If Not Directory.Exists(dest) Then
                    Directory.CreateDirectory(dest)
                End If

                System.IO.File.Copy(sourceFilePath, Path.Combine(dest, sourceFileName), overwrite)
            Else
                Copy(sourceFilePath, dest, overwrite)
            End If
        Next
    End Sub

    Public Shared Function Exists(ByVal filePath As String) As Boolean
        If filePath Is Nothing OrElse filePath.Trim() = "" Then
            Return False
        End If

        If System.IO.File.Exists(filePath) Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function CreateDir(ByVal dirPath As String) As Boolean
        If Not Directory.Exists(dirPath) Then
            Directory.CreateDirectory(dirPath)
        End If

        Return True
    End Function

    Public Shared Function CreateFile(ByVal filePath As String) As Boolean
        If Not System.IO.File.Exists(filePath) Then
            Dim fs As FileStream = System.IO.File.Create(filePath)
            fs.Close()
            fs.Dispose()
        End If

        Return True
    End Function

    Public Shared Function Read(ByVal filePath As String, ByVal encoding As Encoding) As String
        If Not Exists(filePath) Then
            Return Nothing
        End If

        Using fs As FileStream = New FileStream(filePath, FileMode.Open)
            Return New StreamReader(fs, encoding).ReadToEnd()
        End Using
    End Function

    Public Shared Function ReadLine(ByVal filePath As String, ByVal encoding As Encoding) As String
        If Not Exists(filePath) Then
            Return Nothing
        End If

        Using fs As FileStream = New FileStream(filePath, FileMode.Open)
            Return New StreamReader(fs, encoding).ReadLine()
        End Using
    End Function

    Public Shared Function Write(ByVal filePath As String, ByVal content As String) As Boolean
        If Not Exists(filePath) OrElse content Is Nothing Then
            Return False
        End If

        Using fs As FileStream = New FileStream(filePath, FileMode.OpenOrCreate)
            SyncLock fs
                If Not fs.CanWrite Then
                    Throw New System.Security.SecurityException("文件filePath=" & filePath & "是只读文件不能写入!")
                End If

                Dim buffer As Byte() = Encoding.[Default].GetBytes(content)
                fs.Write(buffer, 0, buffer.Length)
                Return True
            End SyncLock
        End Using
    End Function

    Public Shared Function WriteLine(ByVal filePath As String, ByVal content As String) As Boolean
        Using fs As FileStream = New FileStream(filePath, FileMode.OpenOrCreate Or FileMode.Append)
            SyncLock fs
                If Not fs.CanWrite Then
                    Throw New System.Security.SecurityException("文件filePath=" & filePath & "是只读文件不能写入!")
                End If

                Dim sw As StreamWriter = New StreamWriter(fs)
                sw.WriteLine(content)
                sw.Dispose()
                sw.Close()
                Return True
            End SyncLock
        End Using
    End Function

    Public Shared Function CopyDir(ByVal fromDir As DirectoryInfo, ByVal toDir As String) As Boolean
        Return CopyDir(fromDir, toDir, fromDir.FullName)
    End Function

    Public Shared Function CopyDir(ByVal fromDir As String, ByVal toDir As String) As Boolean
        If fromDir Is Nothing OrElse toDir Is Nothing Then
            Throw New NullReferenceException("参数为空")
        End If

        If fromDir = toDir Then
            Throw New Exception("两个目录都是" & fromDir)
        End If

        If Not Directory.Exists(fromDir) Then
            Throw New IOException("目录fromDir=" & fromDir & "不存在")
        End If

        Dim dir As DirectoryInfo = New DirectoryInfo(fromDir)
        Return CopyDir(dir, toDir, dir.FullName)
    End Function

    Private Shared Function CopyDir(ByVal fromDir As DirectoryInfo, ByVal toDir As String, ByVal rootDir As String) As Boolean
        Dim filePath As String = String.Empty
        For Each f As FileInfo In fromDir.GetFiles()
            filePath = toDir & f.FullName.Substring(rootDir.Length)
            Dim newDir As String = filePath.Substring(0, filePath.LastIndexOf("\"))
            CreateDir(newDir)
            System.IO.File.Copy(f.FullName, filePath, True)
        Next

        For Each dir As DirectoryInfo In fromDir.GetDirectories()
            CopyDir(dir, toDir, rootDir)
        Next

        Return True
    End Function

    Public Shared Function DeleteFile(ByVal filePath As String) As Boolean
        If Exists(filePath) Then
            System.IO.File.Delete(filePath)
            Return True
        End If

        Return False
    End Function

    Public Shared Sub DeleteDir(ByVal dir As DirectoryInfo)
        If dir Is Nothing Then
            Throw New NullReferenceException("目录不存在")
        End If

        For Each d As DirectoryInfo In dir.GetDirectories()
            DeleteDir(d)
        Next

        For Each f As FileInfo In dir.GetFiles()
            DeleteFile(f.FullName)
        Next

        dir.Delete()
    End Sub

    Public Shared Function DeleteDir(ByVal dir As String, ByVal onlyDir As Boolean) As Boolean
        If dir Is Nothing OrElse dir.Trim() = "" Then
            Throw New NullReferenceException("目录dir=" & dir & "不存在")
        End If

        If Not Directory.Exists(dir) Then
            Return False
        End If

        Dim dirInfo As DirectoryInfo = New DirectoryInfo(dir)
        If dirInfo.GetFiles().Length = 0 AndAlso dirInfo.GetDirectories().Length = 0 Then
            Directory.Delete(dir)
            Return True
        End If

        If Not onlyDir Then
            Return False
        Else
            DeleteDir(dirInfo)
            Return True
        End If
    End Function

    Public Shared Function FindFile(ByVal dir As String, ByVal fileName As String) As Boolean
        If dir Is Nothing OrElse dir.Trim() = "" OrElse fileName Is Nothing OrElse fileName.Trim() = "" OrElse Not Directory.Exists(dir) Then
            Return False
        End If

        Dim dirInfo As DirectoryInfo = New DirectoryInfo(dir)
        Return FindFile(dirInfo, fileName)
    End Function

    Public Shared Function FindFile(ByVal dir As DirectoryInfo, ByVal fileName As String) As Boolean
        For Each d As DirectoryInfo In dir.GetDirectories()
            If System.IO.File.Exists(d.FullName & "\" & fileName) Then
                Return True
            End If

            FindFile(d, fileName)
        Next

        Return False
    End Function

End Class

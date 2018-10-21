Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Configuration
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Net.Mail


    Public Class MailSender

        Public Shared Sub Send(ByVal server As String, ByVal sender As String, ByVal recipient As String, ByVal subject As String, ByVal body As String, ByVal CC As String, _
         ByVal isBodyHtml As Boolean, ByVal encoding As Encoding, ByVal isAuthentication As Boolean, ByVal ParamArray files As String())
            Try
                Dim smtpClient As New SmtpClient(server)
            Dim message As New MailMessage(sender, recipient)
                message.IsBodyHtml = isBodyHtml
                message.SubjectEncoding = encoding
                message.BodyEncoding = encoding
                message.Subject = subject
                message.Body = body
            Dim list As String() = CC.Split(";")

            For Each item As Object In list
                If item <> "" And Validate.IsEmail(item) Then
                    message.CC.Add(item)
                End If
            Next
            message.Attachments.Clear()
            If Not files Is Nothing AndAlso files.Length <> 0 Then
                Dim i As Integer = 0
                While i < files.Length - 1
                    Dim attach As New Attachment(files(i))
                    message.Attachments.Add(attach)
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While
            End If

            If isAuthentication = True Then
                smtpClient.Credentials = New NetworkCredential(SmtpConfig.Create().SmtpSetting.User, SmtpConfig.Create().SmtpSetting.Password)
            End If

            smtpClient.Send(message)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="recipient"></param>
    ''' <param name="subject"></param>
    ''' <param name="body"></param>
    ''' <param name="CC"></param>
    ''' <remarks></remarks>
        Public Shared Sub Send(ByVal recipient As String, ByVal subject As String, ByVal body As String, ByVal CC As String)
            Send(SmtpConfig.Create().SmtpSetting.Server, SmtpConfig.Create().SmtpSetting.Sender, recipient, subject, body, CC, _
             True, Encoding.[Default], True, Nothing)

        End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Recipient"></param>
    ''' <param name="Sender"></param>
    ''' <param name="Subject"></param>
    ''' <param name="Body"></param>
    ''' <param name="CC"></param>
    ''' <remarks></remarks>
        Public Shared Sub Send(ByVal Recipient As String, ByVal Sender As String, ByVal Subject As String, ByVal Body As String, ByVal CC As String)
            Send(SmtpConfig.Create().SmtpSetting.Server, Sender, Recipient, Subject, Body, CC, _
             True, Encoding.UTF8, True, Nothing)
        End Sub

    Shared ReadOnly smtpServer As String = "admin@nikka-metal.com"
    Shared ReadOnly userName As String = "admin@nikka-metal.com"
    Shared ReadOnly pwd As String = "FCsmp1.1369"
    Shared ReadOnly smtpPort As Integer = 25
    Shared ReadOnly authorName As String = ""
    Shared ReadOnly sTo As String = "admin@nikka-metal.com"

    Public Sub Send(ByVal subject As String, ByVal body As String)

        'Dim toList As List(Of String) = StringPlus.GetSubStringList(StringPlus.ToDBC([to]), ","c)
        'Dim dinosaurs As New List(Of String)

        Dim toList As New List(Of String)
        For i As Integer = 0 To sTo.Split(",").Length - 1
            toList.Add(sTo(i))
        Next

        Dim smtp As New OpenSmtp.Mail.Smtp(smtpServer, userName, pwd, smtpPort)
        For Each s As String In toList
            Dim msg As New OpenSmtp.Mail.MailMessage()
            msg.From = New OpenSmtp.Mail.EmailAddress(userName, authorName)
            msg.AddRecipient(s, OpenSmtp.Mail.AddressType.To)
            '设置邮件正文,并指定格式为 html 格式
            msg.HtmlBody = body
            '设置邮件标题
            msg.Subject = subject
            '指定邮件正文的编码
            msg.Charset = "gb2312"
            '发送邮件
            smtp.SendMail(msg)
        Next

    End Sub

    End Class

    Public Class SmtpSetting

        Private _server As String

        Public Property Server() As String
            Get
                Return _server
            End Get
            Set(ByVal value As String)
                _server = value
            End Set
        End Property
        Private _authentication As Boolean

        Public Property Authentication() As Boolean
            Get
                Return _authentication
            End Get
            Set(ByVal value As Boolean)
                _authentication = value
            End Set
        End Property
        Private _user As String

        Public Property User() As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property

        Private _sender As String

        Public Property Sender() As String
            Get
                Return _sender
            End Get
            Set(ByVal value As String)
                _sender = value
            End Set
        End Property

        Private _password As String


        Public Property Password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property
    End Class

    Public Class SmtpConfig

        Private Shared _smtpConfig As SmtpConfig

        Private ReadOnly Property ConfigFile() As String
            Get
                Dim configPath As String = ""
                Return configPath
            End Get
        End Property

        Public ReadOnly Property SmtpSetting() As SmtpSetting

            Get
            Dim Smtp As New SmtpSetting()
            Smtp.Server = "smtp.qiye.163.com"
            Smtp.Authentication = False
            Smtp.User = "admin@nikka-metal.com"
            Smtp.Password = "FCsmp1.1369"
            Smtp.Sender = "admin@nikka-metal.com"
            Return Smtp
        End Get

        End Property

        Private Sub New()

        End Sub

        Public Shared Function Create() As SmtpConfig

            If _smtpConfig Is Nothing Then
                _smtpConfig = New SmtpConfig()
            End If

            Return _smtpConfig
        End Function


    End Class

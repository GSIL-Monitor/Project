
Imports Common.Debug
Imports System.Windows.Forms

Friend Class SubMain

    Public Shared Sub Main()

        Try
            Dim app As New frmDataConnection()
            Application.Run(app)

        Catch ex As Exception
            myMsg(ex.Message)
        End Try

    End Sub


End Class

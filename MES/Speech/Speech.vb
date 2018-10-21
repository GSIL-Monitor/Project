
Imports System.Speech.Synthesis
Public Class Speech

    Private Sub New()

    End Sub

    Public Shared Function Create() As Speech
        Return New Speech
    End Function

    Public Function PlayVoice(ByVal Msg As String) As Boolean

        Try
            Dim synth As SpeechSynthesizer = New SpeechSynthesizer()
            synth.Speak(Msg)
        Catch ex As Exception

        End Try

    End Function


End Class

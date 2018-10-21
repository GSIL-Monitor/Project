
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Public Class Clock
    Inherits System.Windows.Forms.UserControl
    Const PI As Single = 3.141593F

    Private dateTime As DateTime

    Private fRadius As Single
    Private fCenterX As Single
    Private fCenterY As Single
    Private fCenterCircleRadius As Single

    Private fHourLength As Single
    Private fMinLength As Single
    Private fSecLength As Single

    Private fHourThickness As Single
    Private fMinThickness As Single
    Private fSecThickness As Single

    Private bDraw5MinuteTicks As Boolean = True
    Private bDraw1MinuteTicks As Boolean = True
    Private fTicksThickness As Single = 1

    Private hrColor As Color = Color.DarkMagenta
    Private minColor As Color = Color.Green
    Private secColor As Color = Color.Red
    Private circleColor As Color = Color.Red
    Private m_ticksColor As Color = Color.Black

    Private timer1 As System.Windows.Forms.Timer


    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.

        ' TODO: Add any initialization after the InitializeComponent call
        InitializeComponent()
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"
    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        ' 
        ' timer1
        ' 
        Me.timer1.Enabled = True
        Me.timer1.Interval = 1000
        AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.timer1_Tick)
        ' 
        ' AnalogClock
        ' 
        Me.Name = "AnalogClock"
        AddHandler Me.Resize, New System.EventHandler(AddressOf Me.AnalogClock_Resize)
        AddHandler Me.Load, New System.EventHandler(AddressOf Me.AnalogClock_Load)
        AddHandler Me.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.AnalogClock_Paint)

    End Sub
#End Region

    Private Sub AnalogClock_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        dateTime = Now
        Me.AnalogClock_Resize(sender, e)
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dateTime = Now
        Me.Refresh()
    End Sub

    Public Sub Start()
        timer1.Enabled = True
        Me.Refresh()
    End Sub

    Public Sub [Stop]()
        timer1.Enabled = False
    End Sub

    Private Sub DrawLine(ByVal fThickness As Single, ByVal fLength As Single, ByVal color As Color, ByVal fRadians As Single, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawLine(New Pen(color, fThickness), fCenterX - CSng(fLength / 9 * System.Math.Sin(fRadians)), fCenterY + CSng(fLength / 9 * System.Math.Cos(fRadians)), fCenterX + CSng(fLength * System.Math.Sin(fRadians)), fCenterY - CSng(fLength * System.Math.Cos(fRadians)))
    End Sub

    Private Sub DrawPolygon(ByVal fThickness As Single, ByVal fLength As Single, ByVal color As Color, ByVal fRadians As Single, ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim A As New PointF(CSng(fCenterX + fThickness * 2 * System.Math.Sin(fRadians + PI / 2)), CSng(fCenterY - fThickness * 2 * System.Math.Cos(fRadians + PI / 2)))
        Dim B As New PointF(CSng(fCenterX + fThickness * 2 * System.Math.Sin(fRadians - PI / 2)), CSng(fCenterY - fThickness * 2 * System.Math.Cos(fRadians - PI / 2)))
        Dim C As New PointF(CSng(fCenterX + fLength * System.Math.Sin(fRadians)), CSng(fCenterY - fLength * System.Math.Cos(fRadians)))
        Dim D As New PointF(CSng(fCenterX - fThickness * 4 * System.Math.Sin(fRadians)), CSng(fCenterY + fThickness * 4 * System.Math.Cos(fRadians)))
        Dim points As PointF() = {A, D, B, C}
        e.Graphics.FillPolygon(New SolidBrush(color), points)
    End Sub

    Private Sub AnalogClock_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim fRadHr As Single = (dateTime.Hour Mod 12 + dateTime.Minute / 60.0F) * 30 * PI / 180
        Dim fRadMin As Single = (dateTime.Minute) * 6 * PI / 180
        Dim fRadSec As Single = (dateTime.Second) * 6 * PI / 180

        DrawPolygon(Me.fHourThickness, Me.fHourLength, hrColor, fRadHr, e)
        DrawPolygon(Me.fMinThickness, Me.fMinLength, minColor, fRadMin, e)
        DrawLine(Me.fSecThickness, Me.fSecLength, secColor, fRadSec, e)


        For i As Integer = 0 To 59
            If Me.bDraw5MinuteTicks = True AndAlso i Mod 5 = 0 Then
                ' Draw 5 minute ticks
                e.Graphics.DrawLine(New Pen(m_ticksColor, fTicksThickness), fCenterX + CSng(Me.fRadius / 1.5F * System.Math.Sin(i * 6 * PI / 180)), fCenterY - CSng(Me.fRadius / 1.5F * System.Math.Cos(i * 6 * PI / 180)), fCenterX + CSng(Me.fRadius / 1.65F * System.Math.Sin(i * 6 * PI / 180)), fCenterY - CSng(Me.fRadius / 1.65F * System.Math.Cos(i * 6 * PI / 180)))
            ElseIf Me.bDraw1MinuteTicks = True Then
                ' draw 1 minute ticks
                e.Graphics.DrawLine(New Pen(m_ticksColor, fTicksThickness), fCenterX + CSng(Me.fRadius / 1.5F * System.Math.Sin(i * 6 * PI / 180)), fCenterY - CSng(Me.fRadius / 1.5F * System.Math.Cos(i * 6 * PI / 180)), fCenterX + CSng(Me.fRadius / 1.55F * System.Math.Sin(i * 6 * PI / 180)), fCenterY - CSng(Me.fRadius / 1.55F * System.Math.Cos(i * 6 * PI / 180)))
            End If
        Next

        'draw circle at center
        e.Graphics.FillEllipse(New SolidBrush(circleColor), fCenterX - fCenterCircleRadius / 2, fCenterY - fCenterCircleRadius / 2, fCenterCircleRadius, fCenterCircleRadius)
    End Sub

    Private Sub AnalogClock_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Width = Me.Height
        Me.fRadius = Me.Height \ 2
        Me.fCenterX = Me.ClientSize.Width \ 2
        Me.fCenterY = Me.ClientSize.Height \ 2
        Me.fHourLength = CSng(Me.Height) / 3 / 1.65F
        Me.fMinLength = CSng(Me.Height) / 3 / 1.2F
        Me.fSecLength = CSng(Me.Height) / 3 / 1.15F
        Me.fHourThickness = CSng(Me.Height) / 100
        Me.fMinThickness = CSng(Me.Height) / 150
        Me.fSecThickness = CSng(Me.Height) / 200
        Me.fCenterCircleRadius = Me.Height \ 50
        Me.Refresh()
    End Sub

    Public Property HourHandColor() As Color
        Get
            Return Me.hrColor
        End Get
        Set(ByVal value As Color)
            Me.hrColor = value
        End Set
    End Property

    Public Property MinuteHandColor() As Color
        Get
            Return Me.minColor
        End Get
        Set(ByVal value As Color)
            Me.minColor = value
        End Set
    End Property

    Public Property SecondHandColor() As Color
        Get
            Return Me.secColor
        End Get
        Set(ByVal value As Color)
            Me.secColor = value
            Me.circleColor = value
        End Set
    End Property

    Public Property TicksColor() As Color
        Get
            Return Me.m_ticksColor
        End Get
        Set(ByVal value As Color)
            Me.m_ticksColor = value
        End Set
    End Property

    Public Property Draw1MinuteTicks() As Boolean
        Get
            Return Me.bDraw1MinuteTicks
        End Get
        Set(ByVal value As Boolean)
            Me.bDraw1MinuteTicks = value
        End Set
    End Property

    Public Property Draw5MinuteTicks() As Boolean
        Get
            Return Me.bDraw5MinuteTicks
        End Get
        Set(ByVal value As Boolean)
            Me.bDraw5MinuteTicks = value
        End Set
    End Property

End Class


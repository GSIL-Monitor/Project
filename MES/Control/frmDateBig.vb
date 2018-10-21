Friend Class frmDateBig
    ''' <summary>
    ''' Ñ¡ÔñÈÕÆÚ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SelectedDate() As Date
        Get
            Return Me.MonthCalendar1.SelectionStart
        End Get
        Set(ByVal value As Date)
            Try
                Me.MonthCalendar1.SelectionStart = value
                Me.MonthCalendar1.SelectionEnd = value
            Catch ex As Exception
                Me.MonthCalendar1.SelectionStart = Now
                Me.MonthCalendar1.SelectionEnd = Now
            End Try
        End Set
    End Property

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click

        Me.SelectedDate = Now.Date
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Me.SelectedDate = e.Start
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

  
End Class
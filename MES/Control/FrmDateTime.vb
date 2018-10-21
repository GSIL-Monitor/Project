
Friend Class FrmDateTime
    ''' <summary>
    ''' 选择日期
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
                'Me.DateTimePicker1.Value = value
                Me.DateTimePicker1.Value = New DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second)
            Catch ex As Exception
                Me.MonthCalendar1.SelectionStart = Now
                Me.MonthCalendar1.SelectionEnd = Now
                Me.DateTimePicker1.Value = Now
            End Try
        End Set

    End Property

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        Me.SelectedDate = Me.MonthCalendar1.SelectionStart.ToShortDateString & Space(1) & Me.DateTimePicker1.Value.ToShortTimeString
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        'Me.SelectedDate = e.Start & Space(1) & Me.DateTimePicker1.Value.ToShortTimeString

    End Sub


End Class
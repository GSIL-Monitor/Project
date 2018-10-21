''' <summary>
''' 单元格
''' </summary>
''' <remarks></remarks>
Friend Class MyDataGridViewCell
    Inherits DataGridViewTextBoxCell

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
        ByVal initialFormattedValue As Object, _
        ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, _
            dataGridViewCellStyle)

        Dim ctl As MyDataGridViewEditingControl = CType(DataGridView.EditingControl, MyDataGridViewEditingControl)
        If Me.Value Is DBNull.Value Then
            ctl.Text = ""
        Else
            ctl.Text = Me.Value
        End If

    End Sub

    Public Overrides ReadOnly Property EditType() As Type

        Get
            ' Return the type of the editing contol that CalendarCell uses.
            Return GetType(MyDataGridViewEditingControl)
        End Get

    End Property

End Class
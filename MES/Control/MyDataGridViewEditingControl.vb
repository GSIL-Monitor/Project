''' <summary>
''' 单元格编辑控件
''' </summary>
''' <remarks></remarks>
Public Class MyDataGridViewEditingControl
    Inherits MyTextBox
    Implements IDataGridViewEditingControl

    Private WithEvents _dataGridView As DataGridView
    Private _valueIsChanged As Boolean = False
    Private _rowIndexNum As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        Select Case keyData
            Case Keys.Up
                EditingControlDataGridView.EndEdit()
                SendKeys.SendWait("{Up}")
                Return True
            Case Keys.Down
                EditingControlDataGridView.EndEdit()
                SendKeys.SendWait("{Down}")
                Return True
            Case Keys.Left
                If Me.txt.SelectionStart = 0 Then
                    SendKeys.SendWait("+{tab}")
                    Return True
                End If
            Case Keys.Right
                If Me.txt.SelectionStart = Me.Text.Length Then
                    SendKeys.SendWait("{tab}")
                    Return True
                End If
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Text
        End Get
        Set(ByVal value As Object)
            Me.Text = value
        End Set
    End Property



    Public Function GetEditingControlFormattedValue(ByVal context _
        As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Text

    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return _rowIndexNum
        End Get
        Set(ByVal value As Integer)
            _rowIndexNum = value
        End Set

    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        Return True
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() _
        As Boolean Implements _
        IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return _dataGridView
        End Get
        Set(ByVal value As DataGridView)
            _dataGridView = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return _valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            _valueIsChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Private Sub MyDataGridViewEditingControl_EndEdit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EndEdit

        Dim dgCol As MyDataGridViewColumn = Me._dataGridView.Columns(Me._dataGridView.CurrentCell.ColumnIndex)
        Me._dataGridView.CurrentCell.Value = Me.Text
        dgCol.OnEndEdit(e)

    End Sub

    Private Sub MyDataGridViewEditingControl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged

        _valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)

    End Sub

    Private Sub MyDataGridViewEditingControl_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        Try
            Dim dgCol As MyDataGridViewColumn = Me._dataGridView.Columns(Me._dataGridView.CurrentCell.ColumnIndex)
            Me.TextBoxType = dgCol.TextBoxType
            Me.Dock = DockStyle.Fill
            Me.BorderStyle = Windows.Forms.BorderStyle.None
            Me.BackColor = Color.White
            Me.Caption = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MyDataGridViewEditingControl_ZoomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ZoomClick

        Dim dgCol As MyDataGridViewColumn = Me._dataGridView.Columns(Me._dataGridView.CurrentCell.ColumnIndex)
        Me._dataGridView.CurrentCell.Value = Me.Text
        dgCol.OnZoomClick(e)

    End Sub

    'Private Sub _dataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles _dataGridView.CellEndEdit

    '    Try
    '        Dim dgCol As MyDataGridViewColumn = Me._dataGridView.Columns(e.ColumnIndex)
    '        dgCol.OnEndEdit(e)
    '    Catch ex As Exception

    '    End Try

    'End Sub

End Class

Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

'设计一个继承自ComboBox的下拉框编辑列组件
Public Class DataGridViewComboBoxExEditingControl
    Inherits ComboBox
    Implements IDataGridViewEditingControl
    Protected rowIndex As Integer
    Protected dataGridView As DataGridView
    Protected valueChanged As Boolean = False


    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        NotifyDataGridViewOfValueChange()
    End Sub

    Private Sub NotifyDataGridViewOfValueChange()
        valueChanged = True
        dataGridView.NotifyCurrentCellDirty(True)
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        NotifyDataGridViewOfValueChange()
    End Sub

    Public ReadOnly Property EditingPanelCursor() As Cursor
        Get
            Return Cursors.IBeam
        End Get
    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridView
        End Get
        Set(ByVal value As DataGridView)
            dataGridView = value
        End Set
    End Property

    Public Property EditingControlFormattedValue() As Object _
     Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Text
        End Get
        Set(ByVal value As Object)
            Me.Text = value
            NotifyDataGridViewOfValueChange()
        End Set
    End Property


    Public Function GetEditingControlFormattedValue(ByVal context _
    As DataGridViewDataErrorContexts) As Object _
    Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Text

    End Function

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
    ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
    Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.[End], _
             Keys.Escape, Keys.Enter, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function



    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
    Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        If selectAll Then
            Me.SelectAll()
        Else
            Me.SelectionStart = Me.ToString().Length
        End If
    End Sub



    Public ReadOnly Property RepositionEditingControlOnValueChange() _
     As Boolean Implements _
     IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    '
    Public Property EditingControlRowIndex() As Integer _
     Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndex
        End Get
        Set(ByVal value As Integer)
            rowIndex = value
        End Set

    End Property

    '
    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As  _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

    End Sub

    '
    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueChanged
        End Get
        Set(ByVal value As Boolean)
            valueChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

End Class

'定制该扩展列的单元格
Public Class DataGridViewComboBoxExCell
    Inherits DataGridViewTextBoxCell

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim clt As DataGridViewComboBoxExEditingControl = TryCast(DataGridView.EditingControl, DataGridViewComboBoxExEditingControl)

        Dim col As DataGridViewComboBoxExColumn = DirectCast(OwningColumn, DataGridViewComboBoxExColumn)

        clt.DataSource = col.DataSource
        clt.DisplayMember = col.DisplayMember
        clt.ValueMember = col.ValueMember

        clt.Text = Convert.ToString(Me.Value)
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(DataGridViewComboBoxExEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(String)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            Return ""
        End Get
    End Property
End Class

'定制该扩展列
Public Class DataGridViewComboBoxExColumn
    Inherits DataGridViewColumn

    Private dataSoruce As Object = Nothing

    Public Property DataSource() As Object
        Get
            Return dataSoruce
        End Get
        Set(ByVal value As Object)
            dataSoruce = value
        End Set
    End Property

    Private m_valueMember As String

    Public Property ValueMember() As String
        Get
            Return m_valueMember
        End Get
        Set(ByVal value As String)
            m_valueMember = value
        End Set
    End Property

    Private m_displayMember As String

    Public Property DisplayMember() As String
        Get
            Return m_displayMember
        End Get
        Set(ByVal value As String)
            m_displayMember = value
        End Set
    End Property

    Public Sub New()

        MyBase.New(New DataGridViewComboBoxExCell())
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            If value IsNot Nothing AndAlso Not value.[GetType]().IsAssignableFrom(GetType(DataGridViewComboBoxExCell)) Then
                Throw New InvalidCastException("is not DataGridViewComboxExCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property

    Private ReadOnly Property ComboBoxCellTemplate() As DataGridViewComboBoxExCell
        Get
            Return DirectCast(Me.CellTemplate, DataGridViewComboBoxExCell)
        End Get
    End Property

End Class

Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class MyDataGridViewComboEditBoxCell
    Inherits DataGridViewComboBoxCell

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim comboBox As ComboBox = TryCast(MyBase.DataGridView.EditingControl, ComboBox)
        If comboBox IsNot Nothing Then
            comboBox.DropDownStyle = ComboBoxStyle.DropDown
            AddHandler comboBox.Validating, AddressOf comboBox_Validating
        End If

    End Sub

    Protected Overrides Function GetFormattedValue(ByVal value As Object, ByVal rowIndex As Integer, ByRef cellStyle As DataGridViewCellStyle, ByVal valueTypeConverter As TypeConverter, ByVal formattedValueTypeConverter As TypeConverter, ByVal context As DataGridViewDataErrorContexts) As Object

        If value IsNot Nothing AndAlso DataSource Is Nothing Then
            If value.ToString().Trim() <> String.Empty Then
                If Items.IndexOf(value) = -1 Then
                    Items.Add(value)
                    Dim col As DataGridViewComboBoxColumn = OwningColumn
                    col.Items.Add(value)
                End If
            End If
        End If

        Return MyBase.GetFormattedValue(value, rowIndex, cellStyle, valueTypeConverter, formattedValueTypeConverter, context)
    End Function

    Private Sub comboBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Dim cbo As DataGridViewComboBoxEditingControl = sender
        If cbo.Text.Trim() = String.Empty Then
            Return
        End If

        Dim grid As DataGridView = cbo.EditingControlDataGridView
        Dim value As Object = cbo.Text
        ' Add value to list if not there

        If cbo.Items.IndexOf(value) = -1 Then
            Dim cboCol As DataGridViewComboBoxColumn = grid.Columns(grid.CurrentCell.ColumnIndex)
            ' Must add to both the current combobox as well as the template, to avoid duplicate entries
            If DataSource Is Nothing Then
                cbo.Items.Add(value)
                cboCol.Items.Add(value)
                grid.CurrentCell.Value = value
            End If
        End If

    End Sub

End Class


Public Class DataGridViewComboEditBoxColumn
    Inherits DataGridViewComboBoxColumn

    Public Sub New()
        Dim obj As New MyDataGridViewComboEditBoxCell()
        Me.CellTemplate = obj
    End Sub

End Class




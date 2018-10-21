Imports Common.ConvertData
''' <summary>
''' 列表辅助
''' </summary>
''' <remarks></remarks>
Public Class ListHelper

    ''' <summary>
    ''' 排序列表
    ''' </summary>
    ''' <param name="List"></param>
    ''' <param name="cSort"></param>
    ''' <remarks></remarks>
    Public Shared Sub Sort(ByVal List As IList, ByVal cSort As String)

        If List.Count = 0 Then
            Exit Sub
        End If

        Dim ItemType As Type = List(0).GetType
        Dim Arr(List.Count - 1) As Object
        List.CopyTo(Arr, 0)
        List.Clear()

        Dim dt As DataTable = toTable(Arr, ItemType)
        dt.DefaultView.Sort = cSort '依关键字排序
        For i As Integer = 0 To dt.DefaultView.Count - 1
            Dim dr As DataRow = dt.DefaultView.Item(i).Row
            Dim Index As Integer = dt.Rows.IndexOf(dr)
            List.Add(Arr(Index))
        Next

    End Sub

    ''' <summary>
    ''' 过渡列表
    ''' </summary>
    ''' <param name="List"></param>
    ''' <param name="cFilter"></param>
    ''' <remarks></remarks>
    Public Shared Sub Filter(ByVal List As IList, ByVal cFilter As String)

        If List.Count = 0 Then
            Exit Sub
        End If
        Dim ItemType As Type = List(0).GetType
        Dim Arr(List.Count - 1) As Object
        List.CopyTo(Arr, 0)
        List.Clear()
        Dim dt As DataTable = toTable(Arr, ItemType)
        dt.DefaultView.RowFilter = cFilter
        For i As Integer = 0 To dt.DefaultView.Count - 1
            Dim dr As DataRow = dt.DefaultView.Item(i).Row
            Dim Index As Integer = dt.Rows.IndexOf(dr)
            List.Add(Arr(Index))
        Next

    End Sub

    Public Shared Function Selected(ByVal List As IList, ByVal cFilter As String) As IList

        If List.Count = 0 Then
            Exit Function
        End If
        Dim ItemType As Type = List(0).GetType
        Dim Arr(List.Count - 1) As Object
        List.CopyTo(Arr, 0)
        List.Clear()
        Dim dt As DataTable = toTable(Arr, ItemType)
        dt.DefaultView.RowFilter = cFilter
        For i As Integer = 0 To dt.DefaultView.Count - 1
            Dim dr As DataRow = dt.DefaultView.Item(i).Row
            Dim Index As Integer = dt.Rows.IndexOf(dr)
            List.Add(Arr(Index))
        Next
        Return List
    End Function



    ''' <summary>
    ''' 分组列表
    ''' </summary>
    ''' <param name="List"></param>
    ''' <param name="Fields"></param>
    ''' <remarks></remarks>
    Public Shared Sub Group(ByVal List As IList, ByVal ParamArray Fields() As String)

        If List.Count = 0 Then
            Exit Sub
        End If
        Dim ItemType As Type = List(0).GetType
        Dim dt As DataTable = toTable(List, ItemType)
        Dim Index As Integer

l:      For i As Integer = Index To dt.Rows.Count - 1
            Index = i
            Dim mdl As Object = List(i)
            Dim dr As DataRow = dt.Rows(i)
            Dim Filter As String = ""
            For Each Field As String In Fields
                Dim Value As String = toStr(dr.Item(Field))
                Filter &= IIf(Filter <> "", " and ", "") & "Convert(" & Field & ",System.String)='" & Value & "'"
            Next
            If todbl(dt.Compute("count(" & dt.Columns(0).ColumnName & ")", Filter)) > 1 Then
                dt.Rows.Remove(dr)
                List.Remove(mdl)
                GoTo l
            End If
        Next

    End Sub

End Class

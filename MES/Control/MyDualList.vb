Imports System.ComponentModel

Public Class MyDualList


    ''' <summary>
    ''' 移动后事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="nLeft"></param>
    ''' <param name="nRight"></param>
    ''' <param name="nDirection"></param>
    ''' <remarks></remarks>
    Public Event ItemMoved(ByVal sender As Object, ByVal nLeft As Integer, _
         ByVal nRight As Integer, ByVal nDirection As Integer)

    ''' <summary>
    ''' 移动时事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="nLeft"></param>
    ''' <param name="nRight"></param>
    ''' <param name="nDirection"></param>
    ''' <param name="Cancel"></param>
    ''' <remarks></remarks>
    Public Event ItemMoving(ByVal sender As Object, ByVal nLeft As Integer, _
            ByVal nRight As Integer, ByVal nDirection As Integer, _
            ByRef Cancel As Boolean)

    Private Sub cmdRightOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRightOne.Click

        '向右单个移动
        Dim i As Integer
        If lstAll.Items.Count = 0 Or lstAll.SelectedIndex = -1 Then Exit Sub

        Dim bCancel As Boolean
        bCancel = False

        RaiseEvent ItemMoving(Me, lstAll.SelectedIndex, -1, -1, bCancel)

        If bCancel Then Exit Sub

        Try
            lstSelected.SelectedIndex = lstSelected.Items.Add(lstAll.Text)
            i = lstAll.SelectedIndex
            lstAll.Items.RemoveAt(lstAll.SelectedIndex)
            If lstAll.Items.Count > 0 Then
                If i > lstAll.Items.Count - 1 Then
                    lstAll.SelectedIndex = i - 1
                Else
                    lstAll.SelectedIndex = i
                End If
            End If
            RaiseEvent ItemMoved(Me, i, lstSelected.SelectedIndex, -1)
        Catch
        End Try


    End Sub

    Public Sub RightOne()

        '向右单个移动
        Dim i As Integer
        If lstAll.Items.Count = 0 Or lstAll.SelectedIndex = -1 Then Exit Sub

        Dim bCancel As Boolean
        bCancel = False

        RaiseEvent ItemMoving(Me, lstAll.SelectedIndex, -1, -1, bCancel)

        If bCancel Then Exit Sub

        Try
            lstSelected.SelectedIndex = lstSelected.Items.Add(lstAll.Text)
            i = lstAll.SelectedIndex
            lstAll.Items.RemoveAt(lstAll.SelectedIndex)
            If lstAll.Items.Count > 0 Then
                If i > lstAll.Items.Count - 1 Then
                    lstAll.SelectedIndex = i - 1
                Else
                    lstAll.SelectedIndex = i
                End If
            End If
            RaiseEvent ItemMoved(Me, i, lstSelected.SelectedIndex, -1)
        Catch
        End Try

    End Sub




    Private Sub cmdRightAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRightAll.Click

        '全部向右移动
        Dim i As Integer, nNewIndex As Integer
        Dim bCancel As Boolean
        For i = 0 To lstAll.Items.Count - 1
            bCancel = False
            RaiseEvent ItemMoving(Me, i, -1, -1, bCancel)
            If bCancel Then Exit Sub

            nNewIndex = lstSelected.Items.Add(lstAll.Items(i))
            RaiseEvent ItemMoved(Me, i, nNewIndex, -1)
        Next
        lstAll.Items.Clear()
        lstSelected.SelectedIndex = 0

    End Sub

    Private Sub cmdLeftOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeftOne.Click

        Dim i As Integer
        If lstSelected.Items.Count = 0 Or lstSelected.SelectedIndex = -1 Then Exit Sub
        Dim bCancel As Boolean
        bCancel = False
        RaiseEvent ItemMoving(Me, -1, lstSelected.SelectedIndex, 1, bCancel)
        If bCancel Then Exit Sub

        lstAll.SelectedIndex = lstAll.Items.Add(lstSelected.Text)
        i = lstSelected.SelectedIndex
        lstSelected.Items.RemoveAt(i)
        If lstSelected.Items.Count > 0 Then
            If i > lstSelected.Items.Count - 1 Then
                lstSelected.SelectedIndex = i - 1
            Else
                lstSelected.SelectedIndex = i
            End If
        End If
        RaiseEvent ItemMoved(Me, lstAll.SelectedIndex, i, 1)

    End Sub

    Private Sub cmdLeftAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeftAll.Click

        Dim i As Integer, nNewIndex As Integer
        Dim bCancel As Boolean
        For i = 0 To lstSelected.Items.Count - 1
            bCancel = False
            RaiseEvent ItemMoving(Me, -1, i, 1, bCancel)
            If bCancel Then Exit Sub

            nNewIndex = lstAll.Items.Add(lstSelected.Items(i))
            RaiseEvent ItemMoved(Me, nNewIndex, i, 1)
        Next
        lstSelected.Items.Clear()
        lstAll.SelectedIndex = lstAll.Items.Count - 1

    End Sub

    ''' <summary>
    ''' 全部向左移动
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LeftAll()
        Dim e As System.EventArgs
        cmdLeftAll_Click(cmdLeftAll, e)
    End Sub

    ''' <summary>
    ''' 全部向右移动
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RightAll()
        Dim e As System.EventArgs
        cmdRightAll_Click(cmdRightAll, e)
    End Sub

    ''' <summary>
    '''  所有资料标题
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Appearance")> _
    Public Property lblAllText() As String
        Get
            Return lblAll.Text
        End Get
        Set(ByVal Value As String)
            lblAll.Text = Value
        End Set
    End Property

    ''' <summary>
    ''' 选择目的资料标题
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Appearance")> _
    Public Property lblSelectedText() As String
        Get
            Return lblSelected.Text
        End Get
        Set(ByVal Value As String)
            lblSelected.Text = Value
        End Set
    End Property

    ''' <summary>
    '''  所有资料的中SelectIndxe
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)> _
    Public Property lstAllSelectedIndex() As Integer
        Get
            Return lstAll.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            lstAll.SelectedIndex = Value
        End Set
    End Property

    ''' <summary>
    '''  目的资料的中SelectIndxe 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)> _
    Public Property lstSelectedSelectedIndex() As Integer
        Get
            Return lstSelected.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            lstSelected.SelectedIndex = Value
        End Set
    End Property

    ''' <summary>
    ''' 所有资料集合
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)> _
    Public ReadOnly Property lstAllItems() As ListBox.ObjectCollection
        Get
            Return lstAll.Items
        End Get
    End Property

    ''' <summary>
    ''' 目的资料集合
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)> _
    Public ReadOnly Property lstSelectedItems() As ListBox.ObjectCollection
        Get
            Return lstSelected.Items
        End Get
    End Property

    Private Sub MyDualList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstAll_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAll.DoubleClick
        cmdRightOne_Click(cmdRightOne, e)
    End Sub

    Private Sub lstSelected_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSelected.DoubleClick
        cmdLeftOne_Click(cmdLeftOne, e)
    End Sub

    Private Sub lstAll_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstAll.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdRightOne_Click(Nothing, Nothing)
        End If
    End Sub
End Class

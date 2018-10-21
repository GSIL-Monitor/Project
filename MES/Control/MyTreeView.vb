Imports Common.ConvertData
Imports Common.Debug
''' <summary>
''' 树控件
''' </summary>
''' <remarks></remarks>
Public Class MyTreeView
    Inherits TreeView

    ''' <summary>
    ''' 获取第一级的节点
    ''' </summary>
    ''' <param name="text">节点文本</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNode_byLevelOne(ByVal text As String) As TreeNode

        For Each node As TreeNode In Me.Nodes
            If Trim(node.Text).ToLower = Trim(text).ToLower Then
                Return node
            End If
        Next

    End Function

    ''' <summary>
    ''' 获取所有子节点
    ''' </summary>
    ''' <param name="ParentNode">父节点</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodes(ByVal ParentNode As TreeNode) As MyTreeNodeCollection

        Dim Nodes As New MyTreeNodeCollection
        AppendNodes(Nodes, ParentNode)
        Return Nodes

    End Function

    ''' <summary>
    ''' 获取所有节点
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodes() As MyTreeNodeCollection

        Dim Nodes As New MyTreeNodeCollection
        For Each node As TreeNode In Me.Nodes
            Nodes.Add(node)
            AppendNodes(Nodes, node)
        Next
        Return Nodes

    End Function

    ''' <summary>
    ''' 追加节点
    ''' </summary>
    ''' <param name="Nodes"></param>
    ''' <param name="ParentNode"></param>
    ''' <remarks></remarks>
    Protected Sub AppendNodes(ByVal Nodes As MyTreeNodeCollection, ByVal ParentNode As TreeNode)
        For Each n As TreeNode In ParentNode.Nodes
            Nodes.Add(n)
            AppendNodes(Nodes, n)
        Next
    End Sub

    ''' <summary>
    ''' 显示分级信息
    ''' </summary>
    ''' <param name="GradeInfos">分级信息</param>
    ''' <param name="bShowCode">是否显示编码</param>
    ''' <remarks></remarks>
    Public Sub FillGradeInfo(ByVal GradeInfos As GradeInfoCollection, Optional ByVal bShowCode As Boolean = True)

        Dim Code As String
        If Me.SelectedNode IsNot Nothing Then
            Code = Global.Common.Functions.getCode(Me.SelectedNode.Text)
        End If
        Me.Nodes.Clear()
        Dim node As New TreeNode
        node.Text = "所有分类"
        Me.Nodes.Add(node)
        AddNode(node, GradeInfos, 1, bShowCode) '添加节点
        For Each node In getNodes()
            If Code = Global.Common.Functions.GetCode(node.Text) Then
                Me.SelectedNode = node
            End If
        Next
        If Me.SelectedNode Is Nothing Then
            Me.SelectedNode = Me.Nodes(0)
        End If

    End Sub

    ''' <summary>
    ''' 添加节点
    ''' </summary>
    ''' <param name="node"></param>
    ''' <param name="iGrade"></param>
    ''' <remarks></remarks>
    Protected Sub AddNode(ByVal node As TreeNode, ByVal GradeInfos As GradeInfoCollection, ByVal iGrade As Integer, ByVal bShowCode As Boolean)

        Dim mdls As GradeInfoCollection = GradeInfos.get_byGrade(iGrade).get_byCodeLike(0, node.Tag)
        For Each mdl As GradeInfo In mdls
            Dim n As New TreeNode
            n.Tag = mdl.cCode '记录着节点编码
            n.Text = IIf(bShowCode, "(" & mdl.cCode & ")", "") & mdl.cName '节点编码+名称
            node.Nodes.Add(n)
            AddNode(n, GradeInfos, mdl.iGrade + 1, bShowCode)
        Next
    End Sub

    ''' <summary>
    ''' TreeNode的集合
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MyTreeNodeCollection
        Inherits Collections.ObjectModel.Collection(Of TreeNode)
        ''' <summary>
        ''' 按是否末级获取节点信息
        ''' </summary>
        ''' <param name="bEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function get_byEnd(ByVal bEnd As Boolean) As MyTreeNodeCollection
            Dim mdls As New MyTreeNodeCollection
            For Each mdl As TreeNode In Me
                If mdl.Nodes.Count = 0 And bEnd = True Or _
                mdl.Nodes.Count <> 0 And bEnd = False Then
                    mdls.Add(mdl)
                End If
            Next
            Return mdls
        End Function
    End Class

    ''' <summary>
    ''' 分级信息
    ''' </summary>
    ''' <remarks></remarks>
    Public Class GradeInfo

        Private _cCode As String
        Private _cName As String
        Private _iGrade As Integer
        ''' <summary>
        ''' 编码
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cCode() As String
            Get
                Return _cCode
            End Get
            Set(ByVal value As String)
                _cCode = value
            End Set
        End Property

        ''' <summary>
        ''' 名称
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cName() As String
            Get
                Return _cName
            End Get
            Set(ByVal value As String)
                _cName = value
            End Set
        End Property

        ''' <summary>
        ''' 级次
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property iGrade() As Integer
            Get
                Return _iGrade
            End Get
            Set(ByVal value As Integer)
                _iGrade = value
            End Set
        End Property
    End Class

    ''' <summary>
    ''' GradeInfo的集合
    ''' </summary>
    ''' <remarks></remarks>
    Public Class GradeInfoCollection
        Inherits Collections.ObjectModel.Collection(Of GradeInfo)
       
        Public Function get_byGrade(ByVal iGrade As Integer) As GradeInfoCollection
            Dim mdls As New GradeInfoCollection
            For Each mdl As GradeInfo In Me
                If mdl.iGrade = iGrade Then
                    mdls.Add(mdl)
                End If
            Next
            Return mdls
        End Function

        ''' <summary>
        ''' 按编码匹配
        ''' </summary>
        ''' <param name="iType">类型:0_左,1_右,2_包含</param>
        ''' <param name="cPart"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function get_byCodeLike(ByVal iType As Integer, ByVal cPart As String) As GradeInfoCollection

            Dim str As String

            If iType = 0 Then
                str = Trim(cPart).ToLower & "*"
            ElseIf iType = 1 Then
                str = "*" & Trim(cPart).ToLower
            ElseIf iType = 2 Then
                str = "*" & Trim(cPart).ToLower & "*"
            End If

            Dim mdls As New GradeInfoCollection
            For Each mdl As GradeInfo In Me
                If Trim(mdl.cCode).ToLower Like str Then
                    mdls.Add(mdl)
                End If
            Next
            Return mdls
        End Function

    End Class

End Class

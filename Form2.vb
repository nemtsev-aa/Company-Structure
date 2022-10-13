Public Class frm_CreatNode
    Private Sub frm_CreatNode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cb_NodeType.SelectedItem = "Выберите значение"
    End Sub
    Private Sub cb_NodeType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_NodeType.SelectedValueChanged
        Me.txt_NodeName.Focus()
    End Sub
    Private Sub txt_NodeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NodeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            b_Ok.PerformClick()
        End If
    End Sub
    Private Sub b_Ok_Click(sender As Object, e As EventArgs) Handles b_Ok.Click
        Select Case frm_Home.Operation
            Case "Add"
                NewNodeAdd()
            Case "Edit"
                EditNode()
                'Case "Del"
                '    DeleteNode()
        End Select
    End Sub
    Private Sub NewNodeAdd()
        If Me.cb_NodeType.SelectedItem.ToString() = "[Выберите значение]" Then
            'Сообщаем об ошибке
            MsgBox("Значение не выбрано!", vbCritical, "Ошибка")
            Exit Sub
        Else
            If Me.txt_NodeName.Text = "" Then
                'Сообщаем об ошибке
                MsgBox("Название не введено!", vbCritical, "Ошибка")
                Exit Sub
            End If
            'Создаём новую ветвь
            Dim NewNode As New TreeNode(Me.txt_NodeName.Text)
            'Присваиваем тип ветви в тэг
            NewNode.Tag = Me.cb_NodeType.SelectedItem.ToString()
            'Добавляем ветвь к выделенному узлу
            frm_Home.SelectionNode.Nodes.Add(NewNode)
            'Выделяем добавленный узел
            frm_Home.tv_Structure.SelectedNode = NewNode
            'Скрываем форму выбора
            Me.Hide()
        End If
    End Sub
    Public Sub EditNode()
        If Me.txt_NodeName.Text = "" Then
            'Сообщаем об ошибке
            MsgBox("Название не введено!", vbCritical, "Ошибка")
            Exit Sub
        End If
        'Редактируем узел/ветвь
        frm_Home.SelectionNode.Text = Me.txt_NodeName.Text
        'Скрываем форму редактирования
        Me.Hide()
    End Sub
    'Private Sub DeleteNode()
    '    If frm_Home.SelectionNode.Tag = "General" Then Exit Sub
    '    'Удаляем узел/ветвь
    '    frm_Home.tv_Structure.SelectedNode.Remove()
    '    'Скрываем форму редактирования
    '    Me.Hide()
    'End Sub
    Private Sub b_Cancel_Click(sender As Object, e As EventArgs) Handles b_Cancel.Click
        Me.Hide()
    End Sub
End Class
Public Class StructureNode
    Inherits TreeNode

    Public Node As TreeNode

    Public Sub New(sNodeName As String, sNodeType As String)
        'Объект - новая ветвь
        Me.Node = New TreeNode(sNodeName)
        'Название ветви
        Me.Node.Text = sNodeName
        'Тип ветви 
        Me.Node.Tag = sNodeType
    End Sub

End Class
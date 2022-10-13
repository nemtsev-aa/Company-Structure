Public Class frm_Home
    Public SelectionNode As TreeNode
    Public Operation As String
    Dim Граф_для_кнопки As Graphics

    Private Sub tsb_AddNode_Click(sender As Object, e As EventArgs) Handles tsb_AddNode.Click
        SelectionNode = Me.tv_Structure.SelectedNode
        Operation = "Add"
        Select Case tv_Structure.SelectedNode.Tag
            Case "General", "Подразделение" 'Добавление ветвления возможно
                frm_CreatNode.cb_NodeType.Enabled = True
                'Добавляем ветку одного из типов
                'Представляем пользователю выбор типа
                frm_CreatNode.cb_NodeType.DataSource = {"[Выберите значение]", "Подразделение", "Должность"}
                frm_CreatNode.txt_NodeName.Text = ""
                frm_CreatNode.Show()
            Case "Должность" 'Добавление ветвления невозможно
                Exit Sub
        End Select
    End Sub

    Private Sub tbs_CreateNode_Click(sender As Object, e As EventArgs) Handles tbs_CreateNode.Click
        SelectionNode = Me.tv_Structure.SelectedNode
        Operation = "Edit"
        Select Case tv_Structure.SelectedNode.Tag
            Case "General"
                'Изменить корневой участок дерева невозможно
                Exit Sub
            Case "Подразделение", "Должность"
                frm_CreatNode.cb_NodeType.Text = SelectionNode.Tag
                frm_CreatNode.cb_NodeType.Enabled = False
                frm_CreatNode.Show()
        End Select
    End Sub

    Private Sub tsb_DelNode_Click(sender As Object, e As EventArgs) Handles tsb_DelNode.Click
        SelectionNode = Me.tv_Structure.SelectedNode
        Operation = "Del"
        Select Case tv_Structure.SelectedNode.Tag
            Case "General"
                'Изменить корневой участок дерева невозможно
                Exit Sub
            Case "Подразделение", "Должность"
                'Удаляем узел/ветвь
                Me.tv_Structure.SelectedNode.Remove()
        End Select
    End Sub

    Private Sub tv_Structure_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv_Structure.AfterSelect
        SelectionNode = Me.tv_Structure.SelectedNode
        Select Case SelectionNode.Tag
            Case "General", "Подразделение" 'Добавление ветвления возможно
                InputControl(False)
            Case "Должность" 'Добавление ветвления невозможно
                InputControl(True)
        End Select
    End Sub
    Private Sub InputControl(iValue As Boolean)
        For Each iControls In Me.Controls.OfType(Of TextBox)
            'Разблокируем возможность ввода данных
            iControls.Enabled = iValue
        Next
        Me.dtp_AddData.Enabled = iValue
        Me.b_Select.Enabled = iValue
        Me.b_Clear.Enabled = iValue
    End Sub

    Private Sub b_Clear_Click(sender As Object, e As EventArgs) Handles b_Clear.Click
        For Each iControls In Me.Controls.OfType(Of TextBox)
            'Разблокируем возможность ввода данных
            iControls.Text = ""
        Next
        Me.dtp_AddData.Value = Now()
    End Sub

    Private Sub tsb_PersonInfo_Click(sender As Object, e As EventArgs) Handles tsb_PersonInfo.Click
        Me.Hide()
        frm_GuidePerson.Show()
    End Sub

    Private Sub b_Select_Click(sender As Object, e As EventArgs) Handles b_Select.Click
        Me.Hide()
        frm_SelectPerson.Show()
    End Sub

End Class


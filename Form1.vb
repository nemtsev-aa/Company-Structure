Public Class frm_Home
    Public SelectionNode As TreeNode
    Public Operation As String

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
                MsgBox("Добавление ветвления невозможно", vbCritical, "Ошибка")
                Exit Sub
        End Select
    End Sub

    Private Sub tbs_CreateNode_Click(sender As Object, e As EventArgs) Handles tbs_CreateNode.Click
        SelectionNode = Me.tv_Structure.SelectedNode
        Operation = "Edit"
        Select Case tv_Structure.SelectedNode.Tag
            Case "General"
                MsgBox("Корневой участок не доступен для изменений", vbCritical, "Ошибка")
                'Изменить корневой участок дерева невозможно
                Exit Sub
            Case "Подразделение", "Должность"
                'Подготавливаем форму для перехода
                frm_CreatNode.cb_NodeType.Text = SelectionNode.Tag
                frm_CreatNode.cb_NodeType.Enabled = False
                'Переходим на форму корректировки узла
                frm_CreatNode.Show()
        End Select
    End Sub

    Private Sub tsb_DelNode_Click(sender As Object, e As EventArgs) Handles tsb_DelNode.Click
        SelectionNode = Me.tv_Structure.SelectedNode
        Operation = "Del"
        Select Case tv_Structure.SelectedNode.Tag
            Case "General"
                'Удалить корневой участок дерева невозможно
                MsgBox("Корневой участок не доступен для удаления", vbCritical, "Ошибка")
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
        'Активируем кнопки
        Me.dtp_AddData.Enabled = iValue
        Me.b_Select.Enabled = iValue
        Me.b_Clear.Enabled = iValue
    End Sub
    Private Sub b_Clear_Click(sender As Object, e As EventArgs) Handles b_Clear.Click
        For Each iControls In Me.Controls.OfType(Of TextBox)
            'Очищаем поля
            iControls.Text = ""
        Next
        'Очищаем выбор даты
        Me.dtp_AddData.Value = Now()
    End Sub

    Private Sub tsb_PersonInfo_Click(sender As Object, e As EventArgs) Handles tsb_PersonInfo.Click
        'Скрываем форму
        Me.Hide()
        'Переходим к списку физических лиц
        frm_GuidePerson.Show()
    End Sub

    Private Sub b_Select_Click(sender As Object, e As EventArgs) Handles b_Select.Click
        'Скрываем форму
        Me.Hide()
        'Переходим к выбору физических лиц
        frm_SelectPerson.Show()
    End Sub

End Class


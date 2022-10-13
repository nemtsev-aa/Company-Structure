﻿Imports System.ComponentModel

Public Class frm_GuidePerson

    Public sRow As DataGridViewRow
    Public EditStatus As Boolean

    Private Sub frm_GuidePerson_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ManagementDataSet.Person". При необходимости она может быть перемещена или удалена.
        Me.PersonTableAdapter.Fill(Me.ManagementDataSet.Person)

        'Dim RequestParameters() As String = {"*"}
        ''Загружаем данные из MS SQL в таблицу
        'Dim dt As DataTable = LoadGridFromDB(RequestParameters)
        'If dt Is Nothing Or dt.Rows.Count = 0 Then
        '    MsgBox("Поиск не дал результатов!", vbInformation, "Результат")
        '    Exit Sub
        'Else
        '    Dim NewTable = CreateNewDataTable(dt)
        '    If NewTable IsNot Nothing Then
        '        'Подключаем источних данных
        '        Me.dgv_Person.DataSource = NewTable
        '    End If
        'End If
    End Sub
    Private Sub tsb_AddPerson_Click(sender As Object, e As EventArgs) Handles tsb_AddPerson.Click
        'Переменная для работы с DataGridView
        Dim dgv As DataGridView = Me.dgv_Person
        'Cнимаем текущее выделение
        dgv.ClearSelection()
        Dim dtPerson As DataTable = ManagementDataSet.Person
        'Dim NewRow As DataRow = dtPerson.NewRow()
        'Добавляем новую строку в конец таблицы(источник данных для DGV)
        Me.ManagementDataSet.Person.AddPersonRow(dtPerson.Rows.Count + 1, "", "", "")
        'Обновляем источник данных для DGV
        Me.PersonTableAdapter.Update(Me.ManagementDataSet.Person)
        'Перемещаем курсор на новую строку в первую ячейку
        dgv.CurrentCell = dgv.Item(1, dgv.Rows.Count - 1)
        'Активируем режим редактирования
        tbs_EditPerson.Checked = True
    End Sub

    Private Sub tbs_EditPerson_Click(sender As Object, e As EventArgs) Handles tbs_EditPerson.Click
        'Если таблица не содержить записей - выходим из процедуры
        If dgv_Person.Rows.Count = 0 Then
            Exit Sub
        Else
            'Управляем возможностью редактирования для выделенной строки
            Dim cCell As DataGridViewCell = dgv_Person.SelectedCells(0)
            If tbs_EditPerson.Checked = False Then
                'Закрываем возможность редактирования
                cCell.ReadOnly = True
            Else
                'Открываем возможность редактирования
                cCell.ReadOnly = False
            End If
        End If
    End Sub
    Private Sub tsb_DelPerson_Click(sender As Object, e As EventArgs) Handles tsb_DelPerson.Click
        'Определем строку для удаления по выбранной ячейке
        Dim sRow As DataGridViewRow = dgv_Person.Rows.Item(dgv_Person.CurrentCell.RowIndex)
        'Удаляем выбранную строку
        dgv_Person.Rows.Remove(sRow)
        'Обновляем данные через адаптер
        Me.PersonTableAdapter.Update(Me.ManagementDataSet.Person)
    End Sub
    Private Sub dgv_Person_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Person.CellClick
        Try
            Dim cCell As DataGridViewCell = dgv_Person.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If tbs_EditPerson.Checked = False Then
                cCell.ReadOnly = True
            Else
                cCell.ReadOnly = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_GuidePerson_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Обновляем данные в БД
            Me.PersonTableAdapter.Update(Me.ManagementDataSet.Person)
            'Сообщаем пользователю об успешном добавлении
            MsgBox("Данные физических лиц успешно сохранены!", vbInformation, "Успех")
            'Возвращаемся на начальный экран
            frm_Home.Show()
        Catch ex As Exception
            'Сообщаем пользователю об ошибке
            MsgBox("Ошибка в процедуре сохранения данных физических лиц!" & vbCrLf & ex.Message, vbCritical, "Ошибка")
        End Try

    End Sub

    'Private Sub frm_GuidePerson_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Dim ds As DataSet()

    '    'Список физических лиц
    '    Dim NewTeam As New Team
    '    'Новые записи
    '    Dim NewRows As DataGridViewRowCollection = Me.dgv_Person.Rows
    '    'Добавляем записи в коллекцию физических лиц
    '    For Each iRow As DataGridViewRow In NewRows
    '        Dim NewPerson As New Person(iRow.Cells(0).Value, iRow.Cells(1).Value, iRow.Cells(2).Value)
    '        NewTeam.Items.Add(NewPerson)
    '    Next
    '    'Загружаем данные из таблицы в MS SQL
    '    If SQLNewRecord(NewTeam) = "True" Then
    '        MsgBox("Физические лица добавлены в БД", vbInformation, "Успех!")
    '    Else
    '        MsgBox("Ошибка в процедуре обновления БД", vbCritical, "Ошибка!")
    '    End If
    '    'Открываем стартовую страницу
    '    frm_Home.Show()
    'End Sub
End Class
Public Class Person
    Public Property Family As String
    Public Property Name As String
    Public Property Patronymic As String
    Public Property AddDate As Date
    Public Sub New(sFamily As String, sName As String, sPatronymic As String)
        Me.Family = sFamily
        Me.Name = sName
        Me.Patronymic = sPatronymic
    End Sub
End Class

Public Class Team
    Public Property Items As New Collection
    Public Sub Add(aPerson As Person)
        Items.Add(aPerson, aPerson.Family & "." & aPerson.Name & "." & aPerson.Patronymic)
    End Sub
End Class
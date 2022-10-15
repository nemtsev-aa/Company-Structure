Imports System.ComponentModel

Public Class frm_SelectPerson
    Dim RequestParameters(2, 1) As String
    Dim DS As New DataSet
    Dim DT As New DataTable

    Private Sub frm_SelectPerson_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Очищаем форму
        ''Текст боксы
        For Each itxt As TextBox In Me.Controls.OfType(Of TextBox)
            itxt.Text = ""
        Next
        'Таблицу данных
        Me.dgv_Person.DataSource = ""

        'Создаём таблицу данных
        DT = CreateNewDataTable(New DataTable)
        'Добавляем таблицу в структуру данных
        DS.Tables.Add(DT)
        'Отображаем таблицу
        Me.dgv_Person.DataSource = DS.Tables(0)

    End Sub

    Private Sub b_FindPerson_Click(sender As Object, e As EventArgs) Handles b_FindPerson.Click

        'Анализиуем наполненность текстбоксов
        If CheckTextBox() Is Nothing Then
            'Текстбоксы пусты - завершаем процедуру
            Exit Sub
        Else
            'Создаём запрос и помещаем его результаты в новую таблицу
            Dim NewTable = CreateNewDataTable(LoadGridFromDB(RequestParameters))

            If NewTable IsNot Nothing Then
                'Подключаем источних данных
                Me.dgv_Person.DataSource = NewTable
            Else
                MsgBox("Поиск не дал результатов!", vbInformation, "Результат")
                Exit Sub
            End If

        End If
    End Sub
    Public Function CreateNewDataTable(SQLDataTable As DataTable) As DataTable
        Try
            'Создаём таблицу данных
            Dim NewTable As New DataTable
            ''Названия столбцов
            Dim HeaderText() As String = {"№ п/п", "Фамилия", "Имя", "Отчество"}
            'Заменяем названия
            For Each iColumn As String In HeaderText
                NewTable.Columns.Add(iColumn)
            Next

            'Загружаем данные из MS SQL в таблицу
            'Заполняем таблицу данными
            For iRow = 0 To SQLDataTable.Rows.Count - 1
                NewTable.Rows.Add()
                NewTable.Rows.Item(iRow).ItemArray = SQLDataTable.Rows.Item(iRow).ItemArray
            Next

            'Удаляем столбец Id
            NewTable.Columns.Remove("№ п/п")

            Return NewTable
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Function CheckTextBox() As Array
        Try
            Dim NullParametr As Integer = 0
            Dim FullParametr As Integer = 0
            Dim ParametrNumber As Integer = 0
            'Считаем пустые текстбоксы
            For Each itxt As TextBox In Me.Controls.OfType(Of TextBox)
                If itxt.Text = "" Then
                    'Коллекция заполненных параметров
                    ''Название параметра
                    RequestParameters(ParametrNumber, 1) = Replace(itxt.Name, "txt_", "")
                    ''Значение параметра
                    ''Если пользователь оставил значение параметра без заполнения,
                    ''Испольщуем для запроса любое значение
                    RequestParameters(ParametrNumber, 0) = "'%'"
                    'Счётчик пустых параметров
                    NullParametr += 1
                Else
                    'Коллекция заполненных параметров
                    ''Название параметра
                    RequestParameters(ParametrNumber, 1) = Replace(itxt.Name, "txt_", "")
                    ''Значение параметра
                    RequestParameters(ParametrNumber, 0) = itxt.Text
                    'Счётчик заполненных параметров
                    FullParametr += 1
                End If
                ParametrNumber += 1
            Next

            'Если все текстбоксы пусты
            If NullParametr = 3 Then
                MsgBox("Отсутствуют данные для поиска", vbCritical, "Ошибка")
                Return Nothing
            Else
                'Возвращаем массив значений
                Return RequestParameters
            End If
        Catch ex As Exception
            MsgBox("Ошибка в процедуре проверки запроса", vbCritical, "Ошибка")
            Return Nothing
        End Try

    End Function

    Private Sub b_Cancel_Click(sender As Object, e As EventArgs) Handles b_Cancel.Click
        'Закрываем форму
        Me.Hide()
        'Переходим на начальную форму
        frm_Home.Show()
    End Sub

    Private Sub b_Ok_Click(sender As Object, e As EventArgs) Handles b_Ok.Click
        'Заполняем значения параметров
        'Фамилия
        frm_Home.txt_FamilyName.Text = Me.dgv_Person.SelectedRows(0).Cells(0).Value
        'Имя
        frm_Home.txt_Name.Text = Me.dgv_Person.SelectedRows(0).Cells(1).Value
        'Отчество
        frm_Home.txt_Patronymic.Text = Me.dgv_Person.SelectedRows(0).Cells(2).Value

        'Закрываем форму
        Me.Hide()
        'Переходим на начальную форму
        frm_Home.Show()
    End Sub

    Private Sub frm_SelectPerson_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Переходим на начальную форму
        frm_Home.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading

Module SqlConnectionMod
    Public conn As SqlConnection

    Public Server As String
    Public Port As String
    Public DataBase1 As String
    Public UserName As String
    Public Password As String
    Public UserType As String

    Public Function GetConnect() As Boolean
        'Настройка сервера для дальнейшего подключения
        Server = "ARTEM\SQLEXPRESS"
        DataBase1 = "Management"
        UserName = "test"
        Password = "123"

        Try

            conn = New SqlConnection("Data Source=" & Server & ";Initial Catalog=" & DataBase1 & ";Integrated Security=True;User ID=" & UserName & ";password=" & Password)
            conn.Open()
            Return 1

        Catch ex As Exception
            MsgBox("Ошибка подключения к MSSQL серверу. " & ex.Message)
            Return 0
        End Try
    End Function
    Public Function LoadGridFromDB(RequestParameters As Array) As DataTable
        Try
            'Подключение
            Dim ContactMgmt As SqlConnection
            'Команда с параметрами
            Dim cmd As SqlCommand
            'Адаптер для подключения в БД
            Dim da As New SqlDataAdapter
            'Набор данных
            Dim ds As DataSet
            'Таблица с результатами запроса
            Dim dt As New DataTable
            'Строка запроса
            Dim sql As String
            'Корректировщик
            Dim builder As SqlCommandBuilder

            'Производим подключение к SQL серверу
            'Если подключение неудачное - завершаем процедуру
            If GetConnect() = 0 Then Return Nothing : Exit Function
            ContactMgmt = conn
            dt.Rows.Clear()
            If RequestParameters.Length = 1 Then
                'Строка запроса
                Sql = "Select * From Person"
                'Инициализируем запрос
                cmd = New SqlCommand(Sql, ContactMgmt)

            Else
                'Строка запроса
                Sql = "Select * From Person Where Family Like @Family Or Name LIKE @Name Or Patronymic LIKE @Patronymic"
                'Инициализируем запрос
                cmd = New SqlCommand(Sql, ContactMgmt)
                For i As Integer = 0 To UBound(RequestParameters)
                    'Название параметра
                    Dim ParametrName As String = "@" & RequestParameters(i, 1)
                    'Значение параметра
                    Dim ParametrValue As String = "%" + RequestParameters(i, 0) + "%"
                    'Добавляем параметр к запросу
                    'cmd.Parameters.Add(ParametrName, SqlDbType.VarChar, 50).Value = ParametrValue
                    cmd.Parameters.AddWithValue(ParametrName, ParametrValue)
                Next
            End If

            'Выполняем запрос
            da.SelectCommand = cmd
            'Увеличиваем врем запроса для обхода ошибки TimeOut
            da.SelectCommand.CommandTimeout = 5000
            'Сохранем результат запроса в таблицу
            da.Fill(dt)
            'Корректировщик
            builder = New SqlCommandBuilder(da)
            'Закрываем соединение с БД
            conn.Close()
            'Возвращаем результат
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, vbCritical, "Ошибка")
        End Try

    End Function

End Module

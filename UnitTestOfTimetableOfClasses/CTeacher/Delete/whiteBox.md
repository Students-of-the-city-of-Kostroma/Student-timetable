# Тестирование метода Delete класса CTeacher
![alt text](code.png "Тестирование метода Delete класса CTeacher")
# Управляющий граф
![alt text](graph.png "Управляющий граф")

# Маршруты на основании управляющего графа
R1 = 1 - 2 - 7 - 8

R2 = 1 - 2 - 3 - 2 - 7 - 8

R3 = 1 - 2 - 3 - 4 - 2 - 7 - 8

R4 = 1 - 2 - 3 - 4 - 5 - 6 - 8

# Тестовые сценарии

| Регион | Test ID | Идея | Предварительное условие | Входные параметры | Ожидаемый результат | 
| --- | --- | --- | --- | --- | --- |
| R1 | issue-1281-1 | Удаление сведений в пустой таблице преподавателей | Таблица преподавателей пуста | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | false |
| R2 | issue-1281-2 | Попытка удалить преподавателя при несовпадающих значениях фамилии | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | FirstName = "Прядкина", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье"  | false |
| R3 | issue-1281-3 | Попытка удалить преподавателя при несовпадающих значениях института |  FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ИГНИСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | false |
| R4 | issue-1281-4 | Попытка удалить данные при всех совпадающих значениях |  FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | true |                     
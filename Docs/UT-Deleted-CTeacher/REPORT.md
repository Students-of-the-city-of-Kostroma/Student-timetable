# Тестируемый метод
![alt text](CODE.jpg "Тестируемый метод")
# Управляющий граф
![alt text](GRAPH.jpg "Управляющий граф")

# Маршруты на основании управляющего графа
R1 = 1 - 2 - 7 - 8

R2 = 1 - 2 - 3 - 2 - 7 - 8

R3 = 1 - 2 - 3 - 4 - 2 - 7 - 8

R4 = 1 - 2 - 3 - 4 - 5 - 6 - 8

# Тестовые сценарии

| Регион | Test ID | Идея | Предварительное условие | Входные параметры | Ожидаемый результат | 
| --- | --- | --- | --- | --- | --- |
| R1 | task-1281-1 | Удаление сведений в пустой таблице преподавателей | Таблица преподавателей пуста | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | false |
| R2 | task-1281-2 | Удаление несуществующего преподавателя | FirstName = "Чередникова", SecondName = "Алла",  Patronymic = "Викторовна", FullName = "Чередникова Алла Викторовна" | FirstName = "Чередникова", SecondName = "Алла",  Patronymic = "Викторовна", FullName = "Садовская Ольга Борисовна"  | false |
| R3 | task-1281-3 | Попытка удалить преподавателя при несовпадающих значениях института |  FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ИДТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | false |
| R4 | task-1281-4 | Попытка удалить данные при всех совпадающих значениях |  FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | FirstName = "Садовская", SecondName = "Ольга", Patronymic = "Борисовна", academicDegree = "Кандидат наук", academicTitle = "Профессор", departament = "ФАСТ", metodicalDays = "Пн, Вт", windows = "Ср, Чт, Пт", weekends = "Воскресенье" | true |                     

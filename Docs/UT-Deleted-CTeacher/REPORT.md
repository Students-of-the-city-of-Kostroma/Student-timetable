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
| R1 | task-1281-1 | Удаление сведений в пустой таблице | Таблица преподавателей пуста | FirstName = "Чередникова", SecondName = "Алла",  Patronymic = "Викторовна" | false |
| R2 | task-1281-2 | Удаление несуществующего преподавателя | FirstName = "Чередникова", SecondName = "Алла",  Patronymic = "Викторовна", FullName = "Чередникова А.В" | FirstName = "Чередникова", SecondName = "Алла",  Patronymic = "Викторовна", FullName = "Садовская О.Б"  | false |
| R3 | task-1281-3 | Удаление существующей строки |  "Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье" | "Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье" | true |
| R4 | task-1281-4 | Удаление несуществующей строки |  "Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье" | "Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье" | false |                     
Метод Update.

![](RackMultipart20200706-4-1uxb72p_html_1d3af8fb7b3e43cf.png)

Управляющий граф.

![](RackMultipart20200706-4-1uxb72p_html_c49b84cf76d030c2.png)

Возможные маршруты на основании графа.
 R1 = 0 - 1 - 18
 R2 = 0 - 2 - 3 - 17 - 18

R3=0 - 2 - 3 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 10 - 11 - 12 - 13 -18

R4=0 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 10 - 11 - 12 - 13 -18

R5=0 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 10 - 11 - 12 - 14 - 15 - 16 - 18

R6=0 - 2 - 3 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 10 - 11 - 12 - 14 - 15 - 16 - 18

|
 | Test ID | Test title | Input value | Expected result | Actual result | Test status |
| --- | --- | --- | --- | --- | --- | --- |
| R4 | 1245\_2 | Ввод некорректных данных в атрибут Дисциплина | Discipline = &quot;1&#39; | false | false | Passed |

#  Основные термины 

| Номер | Понятие | Определение |
| --- | --- | ---|
| 1 | Пользовательская история | Способ описания требований к разрабатываемой системе, сформулированных как одно или более предложений на повседневном или деловом языке пользователя. |
| 2 | Критерии приемки | Конкретные требования к истории, которые должны быть выполнены, чтобы история была завершена.  |
| 3 | Жизненный цикл программного обеспечения | Период времени, который начинается с момента принятия решения о необходимости создания программного продукта и заканчивается в момент его полного изъятия из эксплуатации. |

# Перечень условных обозначений и сокращений 

| Аббревиатура | Пояснение |
| --- | --- |
| User Story | Пользовательская история |
| ПО | Программное обеспечение |

# Общая информация к составлению пользовательских историй 

Настоящие методические рекомендации определяют порядок составления `пользовательских историй {1}`. 

**Цель документа:** создать наиболее эффективные, рациональные варианты написания User Story *. 

# Требования к заголовкам

**1) Заголовок должен описывать действие;**

Для примера возьмем операцию снятия наличных с банкомата. 

Заголовок истории описывает действие, которое хочет осуществить владелец карты: "Владелец карточки снимает наличку".

Пока мы не реализовали это функцию - владелец карты не может снять наличку в банкомате. А когда мы её реализуем - он сможет. Это даёт нам представление о том, что значит "Готово" для данной пользовательской истории - то есть как будет выглядеть ***конечный результат***.

**2) Заголовок истории должен всегда описать реальное взаимодействие человека с системой;**

Также возьмем эту же ситуацию, когда владелец карты снимает наличные с банкомата, но назовем ее по-другому: "Поведение банкомата".
В данном случае нам сложно понять о чем наша история, так как границы очень расплывчаты.

"Поведение банкомата" должно описывать не только процесс снятия наличных, но и , к примеру, смену пин-кода на карточке.

**3) Заголовок сценария должен фокусироваться на отличиях в ситуациях;**

Если вы расположите сценарии горизонтально рядом друг с другом - вы должны будете чётко объяснить, в чём их различие, причём глядя только на заголовок. Но не нужно писать: "Владелец карты снимает с неё деньги при этом на карточке недостаточно средств и ему сообщают о том, что невозможно выполнить транзакцию". 

***Из заголовка должно быть понятно, чем этот конкретный сценарий отличается от других.*** 

# Требования к атрибутам

**INVEST — аббревиатура из первых букв предлагаемых к рассмотрению атрибутов качества пользовательских историй.**

**I** - Independent (независимая)

* Пользовательская история может быть реализована, протестирована и доставлена независимо от других пользовательских историй. Реализуемая часть функционала удовлетворяет какую-то потребность и является ценным для бизнеса.

**N** - Negotiable (обсуждаемая)

* Одно из отличий других видов требований от пользовательских историй заключается в том, что пользовательская история на начальном этапе не является конечным требованием или договоренностью, а тем — что необходимо обсудить и реализовать. Пользовательская история отражает суть, а не детали. Со временем карточка пользовательской истории может быть расширена, но все дополнения — это всего лишь детали, которые улучшают понимание сути пользовательской истории или обеспечивают процесс ее тестирования.

**V** - Valuable (полезная)

* Один из самых важных атрибутов модели.
***Главная цель проекта по разработке продукта или системы*** — обеспечение ценности продукта/системы посредством предоставления решений проблем или удовлетворения потребностей.
В процессе написания историй думайте о них как о частях продукта/системы, которые в совокупности обеспечивают достижение главной цели проекта.

**E** - Estimable (оцениваемая)

* Хорошую пользовательскую историю можно оценить по критериям сложности и трудозатрат для ее реализации. Здесь речь идет не о точной оценке, а о приблизительной.
Если историю невозможно оценить, то это значит, что она либо большая, либо неопределенная. В обоих случаях пользовательскую историю следует пересмотреть.

**S** - Small (маленькая, компактная)

* Хорошая пользовательская история — компактная и реализуемая в рамках одной итерации. В противном случае она не будет представлять ценности по окончании итерации.

**T** - Testable (тестируемая)

* Хорошая пользовательская история может быть протестирована, то есть для нее можно написать критерии приемки.

# Пункты, из которых должен состоять документ

**1) Заголовок (описание истории в одну строку)**
 
**2) Формулировка истории:**

- Я как [роль]

- Хочу [функционал]

- Для того чтобы [выгода]
 

 











 

# Критерии приемлемости каждого пункта.



`Критерии приёмки{2}` могут быть полезны для расширения и проработки пользовательских историй. Однако не стоит рассматривать их как замену беседы. Они не должны скатиться до длинной документации и чрезвычайно детализированных спецификаций. 

Обычно тестировщики начинают свою работу с уже существующими критериями приёмки. Они могут давать владельцу продукта обратную связь, как улучшить эти критерии, но их главная задача - взять критерии готовыми и создать на их основе тесты. В идеале эти тесты автоматизированы, но если нет, должно быть описание как эти тесты выполнять на понятном языке.


1)  









# Роль документа в жизненном цикле ПО


# Документы,которые должны быть изменены и созданы на основании пользовательской истории. 
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Попытка удалить корпус из пустой таблицы корпусов
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
            Assert.AreEqual(refData.CEnclosures.Rows.Count == 0, true, "При проверке отсутствия записей в таблице корпусов, она оказалась не пустой");
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "При попытке добавить университет в таблицу с университетами, он не был добавлен");
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr), false, "Корпус был удалён, не смотря на то, что таблица с корпусами пуста");
        }
        /// <summary>
        /// Попытка удалить корпус из таблицы корпусов при не совпадающих значениях названий
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "При попытке добавить университет в таблицу с университетами, он не был добавлен");
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "При попытке добавить корпус в таблицу с корпусами, он не был добавлен");
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("М", grUni2.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false, "Корпус был удалён, не смотря на то, что названия корпусов не совпадают");
        }
        /// <summary>
        /// Попытка удалить корпус из таблицы корпусов при не совпадающих значениях названий университетов
        /// </summary>
        [TestMethod]
        public void Task_395_3()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "При попытке добавить университет в таблицу с университетами, он не был добавлен");
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "При попытке добавить корпус в таблицу с корпусами, он не был добавлен");
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false, "Корпус был удалён, не смотря на то, что названия университетов не совпадают");
        }
        /// <summary>
        /// Попытка удалить корпус из таблицы корпусов при всех совпадающих значениях
        /// </summary>
        [TestMethod]
        public void Task_395_4()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true, "При попытке добавить университет в таблицу с университетами, он не был добавлен");
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true, "При попытке добавить корпус в таблицу с корпусами, он не был добавлен");
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костромской Государственный Университет", "159005, Костромская область, р. Кострома, пл. Дзержинского, 27", "158005, Костромская область, р. Кострома, пл. Дзержинского, 47", "Александр", "Наумов", "Рудольфович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзержинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), true, "Корпус не был удалён, не смотря на то, что все поля совпадают");
        }
    }
}

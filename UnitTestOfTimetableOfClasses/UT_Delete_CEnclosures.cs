using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Удаление данных из пустой таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {            
            Assert.IsTrue(refData.CEnclosures.Rows.Count == 0, "Таблица не пуста");
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.IsTrue(refData.CUniversity.Insert(grUni), "Не была добавлена запись");
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            Assert.IsFalse(refData.CEnclosures.Delete(gr), "Запись была удалена");
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля Name
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.IsTrue(refData.CUniversity.Insert(grUni2), "Не была добавлена запись");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.IsTrue(refData.CUniversity.Insert(gr2), "Не была добавлена запись");
            MUniversity grUni22 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr22 = new MEnclosures("М", grUni22.FullName, "Дзббжинского", "112111", "8");
            Assert.IsFalse(refData.CEnclosures.Delete(gr22), "Запись была удалена");
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля University
        /// </summary>
        [TestMethod]
        public void Task_395_3()
        {
            MUniversity grUni3 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.IsTrue(refData.CUniversity.Insert(grUni3), "Не была добавлена запись");
            MEnclosures gr3 = new MEnclosures("Я", grUni3.FullName, "Дзббжинского", "112111", "8");
            Assert.IsTrue(refData.CUniversity.Insert(gr3), "Не была добавлена запись");
            MUniversity grUni33 = new MUniversity("4401906286", "ВТБ", "Цостьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr33 = new MEnclosures("Я", grUni33.FullName, "Дзббжинского", "112111", "8");
            Assert.IsFalse(refData.CEnclosures.Delete(gr33), "Запись была удалена");
        }
        /// <summary>
        /// удаление данных при совпадении всех ключевых полей
        /// </summary>
        [TestMethod]
        public void Task_395_4()
        {
            MUniversity grUni4 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.IsTrue(refData.CUniversity.Insert(grUni4), "Не была добавлена запись");
            MEnclosures gr4 = new MEnclosures("Я", grUni4.FullName, "Дзббжинского", "112111", "8");
            Assert.IsTrue(refData.CUniversity.Insert(gr4), "Не была добавлена запись");
            MUniversity grUni44 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr44 = new MEnclosures("Я", grUni44.FullName, "Дзббжинского", "112111", "8");
            Assert.IsTrue(refData.CEnclosures.Delete(gr44), "Запись не была удалена");
        }
    }
}

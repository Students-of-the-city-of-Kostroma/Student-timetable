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
            Assert.AreEqual(refData.CEnclosures.Rows.Count == 0, true);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false);
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля Name
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("М", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false);
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля University
        /// </summary>
        [TestMethod]
        public void Task_395_3()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Цостьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), false);
        }
        /// <summary>
        /// удаление данных при совпадении всех ключевых полей
        /// </summary>
        [TestMethod]
        public void Task_395_4()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            Assert.AreEqual(refData.CUniversity.Insert(grUni), true);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Insert(gr), true);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(refData.CEnclosures.Delete(gr2), true);
        }
    }
}

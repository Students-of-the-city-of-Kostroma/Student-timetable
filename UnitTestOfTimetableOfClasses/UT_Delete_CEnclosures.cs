using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            RefData.CUniversity.Insert(grUni);
            // arrange 
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            bool expected = true;
            //act 
            RefData.CEnclosures.Insert(gr);
            bool actual = RefData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Удаление данных из пустой таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            //arrange 
            MEnclosures gr = new MEnclosures("О", "Костьомской Госудаьственный Универьитет", "Дзиржинского", "111311", "5");
            bool expected = false;
            //act 
            bool actual = RefData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

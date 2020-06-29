using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
            MUniversity grUni = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool actualUni = refData.CUniversity.Insert(grUni);
            Assert.AreEqual(true, actualUni);
            // arrange 
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            bool expected = true;
            //act 
            refData.CEnclosures.Insert(gr);
            bool actual = refData.CEnclosures.Delete(gr);
            //assert 
            bool check_gr = RefData.CEnclosures.Delete(gr);
            Assert.AreEqual(true, check_gr);
            bool check_grUni = RefData.CUniversity.Delete(grUni);
            Assert.AreEqual(true, check_grUni);
        }

        /// <summary>
        /// Удаление данных из пустой таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            //arrange 
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            //act 
            bool actual = refData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

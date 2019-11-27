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
            // arrange 
            MEnclosures gr = new MEnclosures("ч", "Котромской Государственный Университет", "Дзержиского", "111112", "2");
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
            MEnclosures gr = new MEnclosures("р", "Косстромской Государственный Университет", "Дзержиннского", "111121", "2");
            bool expected = false;
            //act 
            bool actual = RefData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

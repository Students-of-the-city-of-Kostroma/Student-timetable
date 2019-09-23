using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
        public void task_395_1()
        {
            // arrange 
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
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
        public void task_395_2() 
        {
            //arrange 
            MEnclosures gr = new MEnclosures("Я", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            //act 
            bool actual = RefData.CEnclosures.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
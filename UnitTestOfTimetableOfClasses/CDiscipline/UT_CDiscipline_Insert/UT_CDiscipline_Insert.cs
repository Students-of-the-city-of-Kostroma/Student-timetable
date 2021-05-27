using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_CDiscipline
{
    [TestClass]
    public class UT_CDiscipline_Insert
    {
        RefData refData = new RefData();

        /// <summary>
        /// Добавление записи в таблицу.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Insert_Emtpy()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
            bool expected = true;

            // act
            bool actual = refData.CDiscipline.Insert(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Добавление записи в таблицу, в которой уже есть дисциплина.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Insert_Existing()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
            bool expected = false;

            // act
            refData.CDiscipline.Insert(gr);
            bool actual = refData.CDiscipline.Insert(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

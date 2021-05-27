using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.CDiscipline.UT_CDiscipline_Update
{
    [TestClass]
    public class UT_CDiscipline_Update
    {
        RefData refData = new RefData();

        /// <summary>
        /// Обновление существующей записи.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Update_Existing()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КПК", "1");
            bool expected = true;

            // act
            refData.CDiscipline.Insert(new MDiscipline("Клеопатра", "КП", "1"));
            bool actual = refData.CDiscipline.Update(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Обновление не существующей записи.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Update_NonExisting()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КПК", "1");
            bool expected = false;

            // act
            bool actual = refData.CDiscipline.Update(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

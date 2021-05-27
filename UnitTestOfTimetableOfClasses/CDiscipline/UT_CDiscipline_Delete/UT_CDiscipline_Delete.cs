using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestOfTimetableOfClasses.CDiscipline.UT_CDiscipline_Delete
{
    [TestClass]
    public class UT_CDiscipline_Delete
    {
        RefData refData = new RefData();

        /// <summary>
        /// Удаление существующей записи.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Delete_Existing()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КПК", "1");
            bool expected = true;

            // act
            refData.CDiscipline.Insert(gr);
            bool actual = refData.CDiscipline.Delete(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Удаление существующей записи.
        /// </summary>
        [TestMethod]
        public void CDiscipline_Delete_NonExisting()
        {
            // arrange
            MDiscipline gr = new MDiscipline("Клеопатра", "КПК", "1");
            bool expected = false;

            // act
            bool actual = refData.CDiscipline.Delete(gr);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

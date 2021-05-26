using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MTypesOfOccupation
{
    [TestClass]
    public class UT_MTypesOfOccupation
    {
        RefData refData = new RefData();
        /// <summary>
        /// Проверка поля fullName объекта класса MTypesOfOccupation
        /// </summary>
        [TestMethod]
        public void MTypesOfOccupation_1()
        {
            try
            {
                MTypesOfOccupations T = new MTypesOfOccupations("Лекция", "л");
                Assert.AreEqual(typeof(string), T.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Проверка поля shortName объекта класса MTypesOfOccupation
        /// </summary>
        [TestMethod]
        public void MTypesOfOccupation_2()
        {
            try
            {
                MTypesOfOccupations T = new MTypesOfOccupations("Лекция", "л");
                Assert.AreEqual(typeof(string), T.ShortName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

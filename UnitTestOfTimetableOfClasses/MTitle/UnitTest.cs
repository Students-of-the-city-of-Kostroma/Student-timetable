using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestOfTimetableOfClasses.UT_MTitle
{
    /// <summary>
    ///  класс для тестирования Уч. звания 
    /// </summary>
    [TestClass]
    public class UT_MTitle
    {
        RefData refData = new RefData();
        /// <summary>
        /// Метод проверяет ввёдённое название учёного звания на соответствие типу поля string
        /// </summary>
        [TestMethod]
        public void MTitle_1()
        {
            try
            {
                MTitle T_Title = new MTitle("Др", "Доктор");
                Assert.AreEqual(typeof(string), T_Title.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Метод проверяет ввёдённое название учёного звания на соответствие типу поля string
        /// </summary>
        [TestMethod]
        public void MTitle_2()
        {
            try
            {
                MTitle T_Title = new MTitle("Др", "Доктор");
                Assert.AreEqual(typeof(string), T_Title.Reduction.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

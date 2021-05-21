using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    /// <summary>
    /// Класс для тестирования полей класса MDirectionOfPreparation (направление подготовки - Model)
    /// </summary>
    [TestClass]
    public class UT_MDirectionOfPreparation
    {
        RefData refData = new RefData();
        /// <summary>
        /// Проверка поля CodeOfDP экземпляра класса MDirectionOfPreparation
        /// </summary>
        [TestMethod]
        public void Task_554_1()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1, "КГУ");
                Assert.AreEqual(typeof(string), mDirectionOfPreparation.CodeOfDP.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Проверка поля NameOfDP экземпляра класса MDirectionOfPreparation
        /// </summary>
        [TestMethod]
        public void Task_554_2()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1, "КГУ");
                Assert.AreEqual(typeof(string), mDirectionOfPreparation.NameOfDP.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Проверка поля PeriodOfStudy экземпляра класса MDirectionOfPreparation
        /// </summary>
        [TestMethod]
        public void Task_554_3()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1, "КГУ");
                Assert.AreEqual(typeof(ushort), mDirectionOfPreparation.PeriodOfStudy.GetType(), "Ожидался тип поля ushort");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

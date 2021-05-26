using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MDirectionOfPreparation
{
    /// <summary>
    /// Класс для тестирования полей класса MDirectionOfPreparation ("Направление подготовки") (Model)
    /// </summary>
    [TestClass]
    public class UT_MDirectionOfPreparation
    {
        RefData refData = new RefData();
        /// <summary>
        /// Проверка поля CodeOfDP экземпляра класса MDirectionOfPreparation на соответствие типу string
        /// </summary>
        [TestMethod]
        public void MDirectionOfPreparation_1()
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
        /// Проверка поля NameOfDP экземпляра класса MDirectionOfPreparation на соответствие типу string
        /// </summary>
        [TestMethod]
        public void MDirectionOfPreparation_2()
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
        /// Проверка поля PeriodOfStudy экземпляра класса MDirectionOfPreparation на соответствие типу ushort
        /// </summary>
        [TestMethod]
        public void MDirectionOfPreparation_3()
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

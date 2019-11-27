using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MDirectionOfPreparation
    {
        [TestMethod]
        public void Task_554_1()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1);
                Assert.AreEqual(typeof(string), mDirectionOfPreparation.CodeOfDP.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Task_554_2()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1);
                Assert.AreEqual(typeof(string), mDirectionOfPreparation.NameOfDP.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Task_554_3()
        {
            try
            {
                MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "", 1);
                Assert.AreEqual(typeof(ushort), mDirectionOfPreparation.PeriodOfStudy.GetType(), "Ожидался тип поля ushort");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

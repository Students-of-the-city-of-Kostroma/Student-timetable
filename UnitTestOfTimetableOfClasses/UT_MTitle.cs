using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MTitle
    {
        RefData refData = new RefData();
        [TestMethod]
        public void Issue_646_1()
        {
            try
            {
                MTitle T_Title = new MTitle("Др", "Доктор");
                Assert.AreEqual(typeof(String), T_Title.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_646_2()
        {
            try
            {
                MTitle T_Title = new MTitle("Др", "Доктор");
                Assert.AreEqual(typeof(String), T_Title.Reduction.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MInstitute
    {
        [TestMethod]
        public void Issue_645_1()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("", "", "", "");
                Assert.AreEqual(typeof(String), T_Institute.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_645_2()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("", "", "", "");
                Assert.AreEqual(typeof(String), T_Institute.ShortName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_645_3()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("", "", "", "");
                Assert.AreEqual(typeof(String), T_Institute.Director.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_645_4()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("", "", "", "");
                Assert.AreEqual(typeof(String), T_Institute.VUS.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

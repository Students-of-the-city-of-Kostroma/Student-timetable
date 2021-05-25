using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.MInstitute_
{
    [TestClass]
    public class UT_MInstitute
    {
        RefData refData = new RefData();
        [TestMethod]
        public void MInstitute_1()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("Ии", "Ии", "Ии ", "Ии ");
                Assert.AreEqual(typeof(string), T_Institute.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MInstitute_2()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("Ии", "Ии", "Ии ", "Ии");
                Assert.AreEqual(typeof(string), T_Institute.ShortName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MInstitute_3()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("Ии ", "Ии", "Ии ", "Ии ");
                Assert.AreEqual(typeof(string), T_Institute.Director.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MInstitute_4()
        {
            try
            {
                MInstitute T_Institute = new MInstitute("Ии ", "Ии", "Ии ", "Ии ");
                Assert.AreEqual(typeof(string), T_Institute.VUS.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

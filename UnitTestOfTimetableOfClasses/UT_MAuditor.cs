using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MAuditor
    {
        [TestMethod]
        public void Issue_98_1_()
        {
            try
            {
                MAuditor A = new MAuditor("", 0, "", 0);
                Assert.AreEqual(typeof(Guid), A.Id.GetType(), "Ожидался тип поля Guid");
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_98_2()
        {
            try
            {
                MAuditor A = new MAuditor("", 0, "", 0);
                Assert.AreEqual(typeof(String), A.Number.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_98_3()
        {
            try
            {
                MAuditor A = new MAuditor("", 0, "", 0);
                Assert.AreEqual(typeof(Byte), A.Floor.GetType(), "Ожидался тип поля byte");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_98_4()
        {
            try
            {
                MAuditor A = new MAuditor("", 0, "", 0);
                Assert.AreEqual(typeof(String), A.Building.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_98_5()
        {
            try
            {
                MAuditor A = new MAuditor("", 0, "", 0);
                Assert.AreEqual(typeof(int), A.Spacious.GetType(), "Ожидался тип поля int");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

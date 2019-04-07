using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MDiscipline
    {
        /*[TestMethod]
        public void Issue_136_1()
        {
            try
            {
                MDiscipline D = new MDiscipline("", "");
                Assert.AreEqual(typeof(Guid), D.Id.GetType(), "Ожидался тип поля Guid");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }*/

        [TestMethod]
        public void Issue_136_2()
        {
            try
            {
                MDiscipline D = new MDiscipline(null, "");
                Assert.AreEqual(typeof(string), D.Code.GetType(), "Ожидался тип поля string");
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
                MDiscipline D = new MDiscipline("", "");
                Assert.AreEqual(typeof(string), D.Name.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

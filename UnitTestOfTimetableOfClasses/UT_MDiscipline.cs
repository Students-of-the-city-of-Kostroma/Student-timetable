using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MDiscipline
    {
        //[TestMethod]
        //public void Issue_275_1()
        //{
        //    try
        //    {
        //        MDiscipline T_Discipline = new MDiscipline("", "", "");
        //        Assert.AreEqual(typeof(Guid), T_Discipline.Id.GetType(), "Ожидался тип поля Guid");
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail(ex.Message);
        //    }
        //}
        [TestMethod]
        public void Issue_275_2()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(String), T_Discipline.Fullname.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_275_3()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(String), T_Discipline.Shortname.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_275_4()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(String), T_Discipline.CycleofDiscipline.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

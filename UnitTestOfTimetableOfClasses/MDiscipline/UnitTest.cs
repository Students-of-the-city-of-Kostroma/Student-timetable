using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MDiscipline
{
    [TestClass]
    public class UT_MDiscipline
    {
        RefData refData = new RefData();
        //[TestMethod]
        //public void MDiscipline_1()
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
        public void MDiscipline_2()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(string), T_Discipline.Fullname.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MDiscipline_3()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(string), T_Discipline.Shortname.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MDiscipline_4()
        {
            try
            {
                MDiscipline T_Discipline = new MDiscipline("", "", "");
                Assert.AreEqual(typeof(string), T_Discipline.CycleofDiscipline.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

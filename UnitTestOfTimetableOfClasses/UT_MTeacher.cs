using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MTeacher
    {
        [TestMethod]
        public void Issue_30_1()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(Guid), T.Id.GetType(), "Ожидался тип поля Guid");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_2()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(String), T.Surname.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_3()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(String), T.Name.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_4()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(String), T.MiddleName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_5()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(String), T.AcademicDegree.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_6()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(String), T.AcademicRank.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_30_7()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", 0);
                Assert.AreEqual(typeof(Byte), T.SizeOfTeachingExperience.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

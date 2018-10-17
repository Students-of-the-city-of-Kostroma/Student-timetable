using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MTeacher
    {
        private static MTeacher T;
        [TestInitialize]
        public void ClassInitialize()
        {
            T = new MTeacher("", "", "", "", "", 0);
        }
        [TestMethod]
        public void Issue_30_1()
        {
            Assert.AreEqual(typeof(Guid), T.Id.GetType(), "Ожидался тип поля Guid");
        }
        [TestMethod]
        public void Issue_30_2()
        {
            Assert.AreEqual(typeof(String), T.Surname.GetType(), "Ожидался тип поля String");
        }
        [TestMethod]
        public void Issue_30_3()
        {
            Assert.AreEqual(typeof(String), T.Name.GetType(), "Ожидался тип поля String");
        }
        [TestMethod]
        public void Issue_30_4()
        {
            Assert.AreEqual(typeof(String), T.MiddleName.GetType(), "Ожидался тип поля String");
        }
        [TestMethod]
        public void Issue_30_5()
        {
            Assert.AreEqual(typeof(String), T.AcademicDegree.GetType(), "Ожидался тип поля String");
        }
        [TestMethod]
        public void Issue_30_6()
        {
            Assert.AreEqual(typeof(String), T.AcademicRank.GetType(), "Ожидался тип поля String");
        }
        [TestMethod]
        public void Issue_30_7()
        {
            Assert.AreEqual(typeof(Byte), T.SizeOfTeachingExperience.GetType(), "Ожидался тип поля String");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    class TestsOfLib
    {
        private static MTeacher mT;
        [TestInitialize]
        public void ClassInitialize()
        {
            mT = new MTeacher();
        }
        [TestMethod]
        public void MTeacherTest_1()
        {
                Assert.AreEqual(typeof(Guid), mT.Id.GetType());
                Assert.AreEqual(typeof(String), mT.Surname.GetType());
                Assert.AreEqual(typeof(String), mT.Name.GetType());
                Assert.AreEqual(typeof(String), mT.MiddleName.GetType());
                Assert.AreEqual(typeof(String), mT.AcademicDegree.GetType());
                Assert.AreEqual(typeof(String), mT.AcademicRank.GetType());
                Assert.AreEqual(typeof(Byte), mT.SizeOfTeachingExperience.GetType());
        }
    }
}

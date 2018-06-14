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
            mT.Name = "";
            mT.Surname = "";
            mT.MiddleName = "";
            mT.SizeOfTeachingExperience = 0;
            mT.AcademicDegree = "";
            mT.AcademicRank = "";
            
        }
        [TestMethod]
        public void MTeacherTest_1()
        {
                Assert.AreEqual(typeof(Guid), mT.Id.GetType(),"Тип поля ID не совпадает с диаграммой");
                Assert.AreEqual(typeof(String), mT.Surname.GetType(), "Тип поля Surname не совпадает с диаграммой");
                Assert.AreEqual(typeof(String), mT.Name.GetType(), "Тип поля Name не совпадает с диаграммой");
                Assert.AreEqual(typeof(String), mT.MiddleName.GetType(), "Тип поля MiddleName не совпадает с диаграммой");
                Assert.AreEqual(typeof(String), mT.AcademicDegree.GetType(), "Тип поля AcademicDegree не совпадает с диаграммой");
                Assert.AreEqual(typeof(String), mT.AcademicRank.GetType(), "Тип поля AcademicRank не совпадает с диаграммой");
                Assert.AreEqual(typeof(Byte), mT.SizeOfTeachingExperience.GetType(), "Тип поля SizeOfTeachingExperience не совпадает с диаграммой");
        }
    }
}

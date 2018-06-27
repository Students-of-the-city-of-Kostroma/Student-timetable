using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MAuditor
    {
        private static MAuditor A;
        [TestInitialize]
        public void ClassInitialize()
        {
            A = new MAuditor();
            A.Number = "";
            A.Floor = 0;
            A.Building = "";
            A.Spacious = 0;
        }

        [TestMethod]
        public void MAudior_ID()
        {
            Assert.AreEqual(typeof(Guid), A.Id.GetType(), "Тип поля ID не совпадает с диаграммой");
        }

        public void MAudior_Number()
        {
            Assert.AreEqual(typeof(String), A.Number.GetType(), "Тип поля Number не совпадает с диаграммой");
        }

        public void MAudior_Floor()
        {
            Assert.AreEqual(typeof(Byte), A.Floor.GetType(), "Тип поля Floor не совпадает с диаграммой");
        }

        public void MAudior_Building()
        {
            Assert.AreEqual(typeof(String), A.Building.GetType(), "Тип поля Building не совпадает с диаграммой");
        }

        public void MAudior_Spacious()
        {
            Assert.AreEqual(typeof(int), A.Spacious.GetType(), "Тип поля Spacious не совпадает с диаграммой");
        }
    }
}

using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MGroup
    {
        RefData refData = new RefData();
        [TestMethod]
        public void Task_245_1()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(string), G.Group.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_2()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(ushort), G.Semester.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_3()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(string), G.Specialty.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_4()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(ushort), G.Shift.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_5()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(ushort), G.Students.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_6()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(ushort), G.MinNumberOfClass.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_7()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(ushort), G.MaxNumberOfClass.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void Task_245_8()
        {
            try
            {
                MGroup G = new MGroup("17-ИСбо-2б", 0, "ИАСТ", 0, 0, 0, 0, "Воскресенье");
                Assert.AreEqual(typeof(string), G.Weekends.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

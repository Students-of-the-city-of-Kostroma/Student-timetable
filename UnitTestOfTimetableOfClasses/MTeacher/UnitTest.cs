using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MTeacher
{
    [TestClass]
    public class UT_MTeacher
    {
        RefData refData = new RefData();
        [TestMethod]
        public void MTeacher_1()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Доцент", "Студент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.FirstName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_2()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.SecondName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_3()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.Patronymic.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_4()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.AcademicDegree.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_5()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.AcademicTitle.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_6()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.Departament.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_7()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.MetodicalDays.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_8()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.Windows.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTeacher_9()
        {
            try
            {
                MTeacher T = new MTeacher("Куделин", "Роман", "Олегович", "Студент", "Доцент", "ИАСТ", "Пн", "Вт", "Воскресенье");
                Assert.AreEqual(typeof(String), T.Weekends.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

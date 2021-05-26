using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MAcademicDegree
    {
        RefData refData = new RefData();
        /// <summary>
        /// Проверка корректного ввода в поле Полная запись уч. степени
        /// </summary>
        [TestMethod]
        public void Issue_1052_1()
        {
            try
            {
                MAcademicDegree MAcademic = new MAcademicDegree("Кандидат", "Кндт");
                Assert.AreEqual(typeof(String), MAcademic.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// /// Проверка корректного ввода в поле Сокращённая запись уч. степени
        /// </summary>
        [TestMethod]
        public void Issue_1052_2()
        {
            try
            {
                MAcademicDegree MAcademic = new MAcademicDegree("Кандидат", "Кндт");
                Assert.AreEqual(typeof(String), MAcademic.Reduction.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Проверка того что при попытке добавления пустой строки отловится исключение
        /// </summary>
        [TestMethod]
        public void Issue_1052_3()
        {
            string act = "";
            try
            {
                MAcademicDegree MAcademic = new MAcademicDegree(null, null);
            }
            catch (Exception e)
            {
                act = e.Message;
            }
            string ex = "Строка не может быть пустой";
            StringAssert.Contains(ex, act);
        }
    }
}
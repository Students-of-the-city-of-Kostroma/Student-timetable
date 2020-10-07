using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_ICAcademicDegree
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод корректных данных в пустую таблицу
        /// </summary>
        [TestMethod]
        public void ICAcademicDegree_1()
        {
            //arrange 
            MAcademicDegree ma = new MAcademicDegree("Магистр", "Маг.");
            bool ex = true;
            //act
            bool act = refData.CAcademicDegree.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// учёная степень с такой сокращённой записью уже есть в таблице
        /// </summary>
        [TestMethod]
        public void ICAcademicDegree_2()
        {
            //arrange
            Task_486_1();
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            bool expected = false;
            //act
            bool actual = refData.CAcademicDegree.Insert(MAcademic);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}

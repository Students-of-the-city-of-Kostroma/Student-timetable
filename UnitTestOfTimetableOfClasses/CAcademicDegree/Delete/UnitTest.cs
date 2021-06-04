using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CAcademicDegree.UT_Delete
{
    [TestClass]
    public class UT_DCAcademicDegree
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Удаление существующих данных таблицы
        /// </summary>
        [TestMethod]
        public void DCAcademicDegree_1()
        {
            
            //arrange
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            bool ex = true;


            //act
            refData.CAcademicDegree.Insert(MAcademic);
            bool act = refData.CAcademicDegree.Delete(MAcademic);

            //assert 
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// Удаление несуществующих данных из таблицы
        /// </summary>
        [TestMethod]
        public void DCAcademicDegree_2()
        {
            //arrange 
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            bool ex = false;

            //act
            bool act = refData.CAcademicDegree.Delete(MAcademic);

            //assert
            Assert.AreEqual(ex, act);
        }
    }
}

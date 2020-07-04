using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CAcademicDegree
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Удаление существующих данных таблицы
        /// </summary>
        [TestMethod]
        public void Task_485_1()
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
        public void Task_485_2()
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

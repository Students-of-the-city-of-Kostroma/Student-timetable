using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Deleted_CTeacher
    {
        readonly RefData refData = new RefData();
        [TestMethod]
        public void Task_248_1() //Удаление существующей строки 
        {

            //arrange 
            MTeacher tcher = new MTeacher("Лустгартен", "Юрий", "Леонидович", "", "", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Суббота, Воскресенье");
            bool expected = true;
            bool expectedInsert = true;
            //act 
            refData.CTeacher.Insert(tcher);
            bool actual = refData.CTeacher.Delete(tcher);
            //assert 

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
		[TestMethod]
        public void Task_248_2() //Удаление не существующей строки 
        {
            //arrange 
            MTeacher tcher = new MTeacher("Лустгартен", "Юрий", "Леонидович", "", "", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Суббота, Воскресенье");

            bool expected = false;
            //act 
            bool actual = refData.CTeacher.Delete(tcher);
            //assert 

            Assert.AreEqual(expected, actual);
        }
    }
}

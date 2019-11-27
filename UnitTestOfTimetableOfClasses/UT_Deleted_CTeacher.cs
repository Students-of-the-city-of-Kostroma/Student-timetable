using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Deleted_CTeacher
    {

        /// <summary>
        /// Удаление существующей строки
        /// </summary>
		[TestMethod]
        public void Task_248_1()
        {

            //arrange 
            MTeacher tcher = new MTeacher("Лустгартен", "Юрий", "Леонидович", "", "", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Суббота, Воскресенье");
            bool expected = true;
            bool expectedInsert = true;
            //act 
            bool actualInsert = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expectedInsert, actualInsert);
            bool actual = RefData.CTeacher.Delete(tcher);
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
            bool actual = RefData.CTeacher.Delete(tcher);
            //assert 

            Assert.AreEqual(expected, actual);
        }
    }
}

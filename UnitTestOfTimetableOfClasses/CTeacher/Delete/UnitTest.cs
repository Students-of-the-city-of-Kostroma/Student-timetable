using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.CTeacher.Delete
{
    [TestClass]
    public class UT_DCTeacher
    {
        readonly RefData refData = new RefData();
        [TestMethod]
        public void DCTeacher_1() //Удаление существующей строки 
        {
            //arrange 
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act 
            refData.CTeacher.Insert(tcher);
            bool actual = refData.CTeacher.Delete(tcher);
            //assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DCTeacher_2() //Удаление не существующей строки 
        {
            //arrange 
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act 
            bool actual = refData.CTeacher.Delete(tcher);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

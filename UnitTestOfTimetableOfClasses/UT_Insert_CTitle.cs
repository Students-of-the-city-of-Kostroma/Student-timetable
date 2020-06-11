using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{

    [TestClass]
    public class UT_Insert_CTitle
    {
        RefData refData = new RefData();
        [TestMethod]
        public void Task_361_1() //пустая таблица
        {
            //arrange
            MTitle ma = new MTitle("Профессор", "Проф.");
            bool expected = true;
            //act
            bool actual = refData.CTitle.Insert(ma);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task_361_2() //учёное звание с такой сокращённой записью уже есть в таблице
        {
            //arrange
            Task_361_1();
            MTitle ma = new MTitle("Доцент", "Проф.");
            bool expected = false;
            //act
            bool actual = refData.CTitle.Insert(ma);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task_361_3() //учёное звание с такой полной записью уже есть в таблице
        {
            //arrange
            Task_361_1();
            MTitle ma = new MTitle("Профессор", "Доц.");
            bool expected = false;
            //act
            bool actual = refData.CTitle.Insert(ma);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
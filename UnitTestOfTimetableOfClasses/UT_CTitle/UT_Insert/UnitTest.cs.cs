using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CTitle.UT_Insert
{

    [TestClass]
    public class UT_ICTitle
    {
        readonly RefData refData = new RefData();

        /// <summary>
        ///  Вставляем в refData ноыве данные
        /// </summary>
        [TestMethod]
        public void CTitle_1() 
        {
            //arrange
            MTitle ma = new MTitle("НЕПрофессор", "Проф.");
            bool expected = true;
            //act
            bool actual = refData.CTitle.Insert(ma);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Добавляем учёное звание с такой сокращённой записью, которая уже есть в таблице
        /// </summary>
        [TestMethod]
        public void CTitle_2() 
        {
            CTitle_1();
            //arrange
            MTitle ma = new MTitle("НЕДоцент", "Проф.");
            bool expected = false;
            //act
            bool actual = refData.CTitle.Insert(ma);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Добавляем учёное звание с такой полной записью, которая уже есть в таблице
        /// </summary>
        [TestMethod]
        public void CTitle_3() 
        {
            CTitle_1();
            //arrange
            MTitle ma = new MTitle("НЕПрофессор", "Доц.");
            bool expected = false;
            //act
            bool actual = refData.CTitle.Insert(ma);
            //assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
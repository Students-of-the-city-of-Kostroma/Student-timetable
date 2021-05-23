using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{

    [TestClass]
    public class UT_Insert_CTitle
    {
        readonly CTitle refData = new CTitle();

        /// <summary>
        /// Добавление записи в таблицу
        /// </summary>
        [TestMethod]
        public void Task_361_1()
        {
            //arrange
            MTitle ma = new MTitle("Профессор", "Проф.");
            bool expected = true;

            //act
            bool actual = refData.Insert(ma);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Учёное звание с такой сокращённой записью уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_361_2()
        {
            //arrange
            Task_361_1();
            MTitle ma = new MTitle("Профессор", "Проф.");
            bool expected = false;

            //act
            bool actual = refData.Insert(ma);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Учёное звание с такой полной записью уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_361_3()
        {
            //arrange
            Task_361_1();
            MTitle ma = new MTitle("Доцент", "Проф.");
            bool expected = false;

            //act
            bool actual = refData.Insert(ma);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
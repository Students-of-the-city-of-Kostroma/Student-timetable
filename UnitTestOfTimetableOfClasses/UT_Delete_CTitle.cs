using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Deleted_CTitle
    {
        RefData refData = new RefData();
        /// <summary>
        /// Удалить запись при совпадении  атрибутов
        /// </summary>
        [TestMethod]
        public void Task_362_1()
        {
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = true;
            //act
            refData.CTitle.Insert(T_Title);
            bool act = refData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }
         /// <summary>
        /// Удалить несуществующие данные 
        /// </summary>
        [TestMethod]
        public void Task_362_2()
        {
            //act
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = false;
            bool act = refData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }
    }
}

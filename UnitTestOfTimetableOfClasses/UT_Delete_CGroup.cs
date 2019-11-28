using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CGroup
    {
        /// <summary>
        /// Удаление существующей строки 
        /// </summary>
        [TestMethod]
 task-1065
        public void Task_249_1()
        public void Task_248_1()
 Elite
        {
            //arrange 
            MDirectionOfPreparation dp = new MDirectionOfPreparation("11.11.11", "й", 1);
            MTrainingProfile tp = new MTrainingProfile("ИСиТa", "ИСиТ", "11.11.11");
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool expected = true;
 task-1065
            //act
            bool actual;
            actual = RefData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual);
            actual = RefData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = RefData.CGroup.Insert(gr);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = RefData.CGroup.Delete(gr);
            Assert.AreEqual(expected, actual);

            //act 
            bool actual = RefData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual);
            actual = RefData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual);
            actual = RefData.CGroup.Insert(gr);
            Assert.AreEqual(expected, actual);
            actual = RefData.CGroup.Delete(gr);
            Assert.AreEqual(expected, actual);
 Elite
        }
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
        [TestMethod]
 task-1065
        public void Task_249_2()
        {
            //arrange 
            bool expected = false;
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
           
        public void Task_248_2()
        {
            //arrange 
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool expected = false;
 Elite
            //act 
            bool actual = RefData.CGroup.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
 task-1065
}

}
 Elite

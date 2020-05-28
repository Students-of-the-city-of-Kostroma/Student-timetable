using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;
namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CGroup
    {
        /// <summary>
        /// Удаление существующей строки 
        /// </summary>
        [TestMethod]
        public void Task_249_1()
        {
            RefData.InitRefData();
            int countRows = RefData.CGroup.Rows.Count;// countRows == 0
            MGroup mGroup = new MGroup("17-ИСбо-1в", 2, "ИС", 2, 13, 1, 4, "Воскресенье");//countRows == 0
            Assert.IsTrue(RefData.CGroup.Insert(mGroup)); //countRows == 0,RefData.CGroup.Rows.Count == 1 
            Assert.AreEqual(countRows+1, RefData.CGroup.Rows.Count);//(n-1)   
            Assert.AreEqual(RefData.CGroup.Rows[countRows]);//
            Assert.IsTrue(RefData.CGroup.Delete(mGroup));
        }
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
        [TestMethod]
        public void Task_249_2()
        {
            //arrange 
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4);
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool expected = false;
            //act 
            bool actual = RefData.CGroup.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}


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
            //arrange 
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4);
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            MGroup mGroup = new MGroup("17-ИСбо-2б", 2, "ИС", 2, 13, 1, 4, "Воскресенье");
            
            bool expected = RefData.CDirectionOfPreparation.Insert(mDirectionOfPreparation);
              Assert.IsTrue(expected);
                 expected = RefData.CTrainingProfile.Insert(mTrainingProfile);
                   Assert.IsTrue(expected); 
                 expected = RefData.CDirectionOfPreparation.Insert(mGroup);
            //act 
            bool actual = RefData.CGroup.Delete(mGroup);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
        [TestMethod]
        public void Task_249_2()
        {
            //arrange 
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool expected = false;
            //act 
            bool actual = RefData.CGroup.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}


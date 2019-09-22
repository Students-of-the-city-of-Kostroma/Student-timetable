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
        public void Task_248_1()
        {
            //arrange 
            var dp = new MDirectionOfPreparation("11.11.11", "й", 1);
            MTrainingProfile tp = new MTrainingProfile("ИСиТa", "ИСиТ", "11.11.11");
            bool expected = NewMethod();
            //act 
            bool actual = RefData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual);
            actual = RefData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual);
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            actual = RefData.CGroup.Insert(gr);
            Assert.AreEqual(expected, actual=true);
            actual = RefData.CGroup.Delete(gr);
            Assert.AreEqual(expected, actual);
        }

        private static bool NewMethod()
        {
            return true;
        }

        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
        [TestMethod]
		 public void Task_248_2()
		{
			//arrange 
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool expected = true;
			//act 
			bool actual = RefData.CGroup.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual = true );
		}
	}
}

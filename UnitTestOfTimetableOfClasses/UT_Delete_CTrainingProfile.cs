using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CTrainingProfile
	{
		[TestMethod]
		public void Task_422_1()
		{
			bool ex = true;
			bool act;
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Проф", "ПРО",
				RefData.CDirectionOfPreparation.Rows[0].ItemArray[0].ToString());
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			act = RefData.CTrainingProfile.Delete(mTrainingProfile);
			Assert.AreEqual(ex, act);
		}
		[TestMethod]
		public void Task_422_2()
		{
			RefData.CTrainingProfile.Clear();
			bool ex = false;
			bool act;
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Проф", "ПРО",
				RefData.CDirectionOfPreparation.Rows[0].ItemArray[0].ToString());
			act = RefData.CTrainingProfile.Delete(mTrainingProfile);
			Assert.AreEqual(ex, act);
		}
	}
}

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
			RefData.CGroup.Rows.Clear();
			MDirectionOfPreparation dp = new MDirectionOfPreparation("11.11.11", "й", 1);
			MTrainingProfile tp = new MTrainingProfile("ИСиТa", "ИСиТ", "11.11.11");
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool expected = true;
			//act 
			RefData.CDirectionOfPreparation.Insert(dp);
			RefData.CTrainingProfile.Insert(tp);
			bool actual = RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// Удаление не существующей строки 
		/// </summary>
		[TestMethod]
		public void Task_248_2()
		{
			//arrange 
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool expected = false;
			//act 
			bool actual = RefData.CGroup.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CEnclosures
	{
		[TestMethod]
		public void task_395_1()
		{
			// arrange
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = true;
			//act 
			RefData.СEnclosures.Insert(gr);
			bool actual = RefData.СEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void task_395_2() //Удаление не существующей строки 
		{
			//arrange 
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			//act 
			bool actual = RefData.СEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

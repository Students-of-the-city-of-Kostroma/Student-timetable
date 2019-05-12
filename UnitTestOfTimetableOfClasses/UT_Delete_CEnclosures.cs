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
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			bool expected = true;
			//act 
			Controllers.СEnclosures.Insert(gr);
			bool actual = Controllers.СEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void task_395_2() //Удаление не существующей строки 
		{
			//arrange 
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			bool expected = false;
			//act 
			bool actual = Controllers.СEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

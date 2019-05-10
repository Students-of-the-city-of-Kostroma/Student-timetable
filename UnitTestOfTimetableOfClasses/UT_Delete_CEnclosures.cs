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
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			bool expected = true;
			//act 
			СEnclosures cg = new СEnclosures();
			cg.Insert(gr);
			bool actual = cg.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void task_395_2() //Удаление не существующей строки 
		{
			//arrange 
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			bool expected = false;
			//act 
			СEnclosures cg = new СEnclosures();
			bool actual = cg.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CGroup
	{
		[TestMethod]
		public void Task_248_1() //Удаление существующей строки 
		{
			//arrange 
			CTeacher.DataSet.Tables.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool expected = true;
			//act 
			CGroup cg = new CGroup();
			cg.Insert(gr);
			bool actual = cg.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Task_248_2() //Удаление не существующей строки 
		{
			//arrange 
			CTeacher.DataSet.Tables.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool expected = false;
			//act 
			CGroup cg = new CGroup();
			bool actual = cg.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

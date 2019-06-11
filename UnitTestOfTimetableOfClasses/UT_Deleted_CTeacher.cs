using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Deleted_CTeacher
	{
		[TestMethod]
		public void Task_248_1() //Удаление существующей строки 
		{
			//arrange 
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act 
			RefData.CTeacher.Insert(tcher);
			bool actual = RefData.CTeacher.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Task_248_2() //Удаление не существующей строки 
		{
			//arrange 
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = false;
			//act 
			bool actual = RefData.CTeacher.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

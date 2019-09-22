using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Deleted_CTeacher
	{
        /// <summary>
        /// Удаление существующей строки
        /// </summary>
		[TestMethod]
		public void Task_248_1()
		{
			//arrange 
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Проф", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act 
			RefData.CTeacher.Insert(tcher);
			bool actual = RefData.CTeacher.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);
		}
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
		[TestMethod]
		public void Task_248_2()
		{
			//arrange 
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Проф", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = false;
			//act 
			bool actual = RefData.CTeacher.Delete(tcher);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

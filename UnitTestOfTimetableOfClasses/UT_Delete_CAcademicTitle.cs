using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Deleted_CTitle
	{
		[TestMethod]
		public void task_362_1()
		{
			//arrange
			//////Controllers.CTitle.Select().Clear();
			MAcademicTitle T_Title = new MAcademicTitle("Проф.", "Профессор");
			bool ex = true;
			CAcademicTitle T_T = new CAcademicTitle();
			T_T.Insert(T_Title);
			bool act = T_T.Delete(T_Title);
			//assert
			Assert.AreEqual(ex, act);
			//Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void task_362_2()
		{
			//arrange
			MAcademicTitle T_Title = new MAcademicTitle("Проф.", "Профессор");
			bool ex = false;
			CAcademicTitle T_T = new CAcademicTitle();
			bool act = T_T.Delete(T_Title);
			//assert
			Assert.AreEqual(ex, act);
		}
	}
}
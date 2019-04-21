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
			Controllers.CTitle.Select().Clear();
			bool ex = true;
			//act
			bool act;
			MTitle T_Title = new MTitle("Профессор", "Проф.");
			//int C1 = Controllers.CTitle.Rows.Count;
			act = Controllers.CTitle.Insert(T_Title);
			//int C2 = Controllers.CTitle.Rows.Count;
			//assert
			Assert.AreEqual(ex, act);
			//Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void task_362_2()
		{
			//arrange
			bool ex = false;
			bool act;
			//act
			MTitle T_Title = new MTitle("Профессор", "Проф.");
			//int C1 = Controllers.CTitle.Rows.Count;
			act = Controllers.CTitle.Insert(T_Title);
			//int C2 = Controllers.CTitle.Rows.Count;
			//assert
			Assert.AreEqual(ex, act);
			//Assert.AreEqual(C1, C2);

		}
	}
}

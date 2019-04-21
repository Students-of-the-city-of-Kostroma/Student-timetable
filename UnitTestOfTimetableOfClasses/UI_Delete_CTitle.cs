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
			MTitle T_Title = new MTitle("Проф.", "Профессор", 83);
			bool ex = true;
			CTitle T_T = new CTitle();
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
			MTitle T_Title = new MTitle("Проф.", "Профессор", 83);
			bool ex = false;
			CTitle T_T = new CTitle();
			bool act = T_T.Delete(T_Title);
			//assert
			Assert.AreEqual(ex, act);
		}
	}
}
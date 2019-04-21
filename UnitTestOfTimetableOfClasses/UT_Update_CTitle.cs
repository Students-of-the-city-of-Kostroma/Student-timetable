using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CTitle
	{
		[TestMethod]
		public void Task_363_1()
		{
			//arrange
			MTitle t = new MTitle("Профессор", "Проф.");
			MTitle t1 = new MTitle("Доцент", "Доц.");
			CTitle T = new CTitle();
			T.Insert(t);
			T.Insert(t1);
			bool expected = true;
			//act
			t1.FullName = "Звание";
			t1.Reduction = "Зв.";
			bool actual = T.Update(t1);
			//assert
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Task_363_2()
		{
			//arrange
			MTitle t = new MTitle("Профессор", "Проф.");
			MTitle t1 = new MTitle("Доцент", "Проф.");
			CTitle T = new CTitle();
			T.Insert(t);
			T.Insert(t1);
			bool expected = false;
			//act
			t1.FullName = "Звание";
			t1.Reduction = "Зв.";
			bool actual = T.Update(t1);
			//assert
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Task_363_3()
		{
			//arrange
			MTitle t = new MTitle("Профессор", "Проф.");
			MTitle t1 = new MTitle("Профессор", "Доц.");
			CTitle T = new CTitle();
			T.Insert(t);
			T.Insert(t1);
			bool expected = false;
			//act
			t1.FullName = "Профессор";
			t1.Reduction = "Проф.";
			bool actual = T.Update(t1);
			//assert
			Assert.AreEqual(expected, actual);

		}
	}
}

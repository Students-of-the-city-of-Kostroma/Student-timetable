using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CAcademicTitle
	{
		[TestMethod]
		public void Task_363_1()//изменение когда атрибуты не повторяются и код учебного звания изменить нельзя
		{
			//arrange
			MAcademicTitle t = new MAcademicTitle("Проф.", "Профессор");
			MAcademicTitle t1 = new MAcademicTitle("Доц.", "Доцент");
			CAcademicTitle T = new CAcademicTitle();
			T.Insert(t);
			T.Insert(t1);
			bool ex = true;
			//act
			t1.Reduction = "Проф.";
			t1.FullName = "Профессор";
			bool act = T.Update(t1);
			//assert
			Assert.AreEqual(ex, act);

		}
	}
}
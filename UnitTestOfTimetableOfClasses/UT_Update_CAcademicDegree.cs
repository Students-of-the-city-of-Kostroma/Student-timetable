using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CAcademicDegree
	{
		[TestMethod]
		public void Task_484_1()//Замена корректными данными всех полей таблицы не дублируя существующие
		{
			//arrange
			MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
			MAcademicDegree MAcademic1 = new MAcademicDegree("Бакалавр", "");
			CAcademicDegree CAcademic = new CAcademicDegree();
			CAcademic.Insert(MAcademic);
			CAcademic.Insert(MAcademic1);
			bool ex = true;
			//act
			MAcademic1.FullName = "Аспирант";
			bool act = CAcademic.Update(MAcademic1);
			//assert
			Assert.AreEqual(ex, act);
		}

	}
}

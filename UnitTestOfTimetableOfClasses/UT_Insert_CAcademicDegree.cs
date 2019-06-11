using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CAcademicDegree
	{
		/// <summary>
		/// Ввод корректных данных в пустую таблицу
		/// </summary>
		[TestMethod]
		public void Task_486_1()
		{
			//arrange 
			RefData.CAcademicDegree.Clear();
			MAcademicDegree ma = new MAcademicDegree("Магистр", "Маг.");
			bool ex = true;
			//act
			bool act = RefData.CAcademicDegree.Insert(ma);
			//assert
			Assert.AreEqual(ex, act);
		}

		/// <summary>
		/// учёная степень с такой сокращённой записью уже есть в таблице
		/// </summary>
		[TestMethod]
		public void Task_486_2()
		{
			//arrange
			RefData.CAcademicDegree.Clear();
			Task_486_1();
			MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
			bool expected = false;
			//act
			bool actual = RefData.CAcademicDegree.Insert(MAcademic);
			//assert
			Assert.AreEqual(expected, actual);
		}

	}
}

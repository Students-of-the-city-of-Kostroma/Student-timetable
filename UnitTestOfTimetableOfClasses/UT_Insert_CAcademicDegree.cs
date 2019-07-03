using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CAcademicDegree
	{
		[TestMethod]
		public void Task_486_1()//Ввод корректных данных в пустую таблицу
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


		[TestMethod]
		public void Task_486_2()////учёная степень с такой сокращённой записью уже есть в таблице
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

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
			Controllers.CAcademicDegree.Select().Clear();
			MAcademicDegree ma = new MAcademicDegree("Магистр", "Маг.");
			bool ex = true;
			//act
			bool act = Controllers.CAcademicDegree.Insert(ma);
			//assert
			Assert.AreEqual(ex, act);
		}


		[TestMethod]
		public void Task_486_2()////учёная степень с такой сокращённой записью уже есть в таблице
		{
			//arrange
			Controllers.CAcademicDegree.Select().Clear();
			Task_486_1();
			MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
			bool expected = false;
			//act
			bool actual = Controllers.CAcademicDegree.Insert(MAcademic);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{

	[TestClass]
	public class UT_Insert_CAcademicTitle
	{

		[TestMethod]
		public void Task_361_1() //пустая таблица
		{
			//arrange
			Controllers.CAcademicTitle.Select().Clear();
			MAcademicTitle ma = new MAcademicTitle("Профессор", "Проф.");
			bool expected = true;
			//act
			bool actual = Controllers.CAcademicTitle.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_361_2() //учёное звание с такой сокращённой записью уже есть в таблице
		{
			//arrange
			Controllers.CAcademicTitle.Select().Clear();
			Task_361_1();
			MAcademicTitle ma = new MAcademicTitle("Доцент", "Проф.");
			bool expected = false;
			//act
			bool actual = Controllers.CAcademicTitle.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_361_3() //учёное звание с такой полной записью уже есть в таблице
		{
			//arrange
			Controllers.CAcademicTitle.Select().Clear();
			Task_361_1();
			MAcademicTitle ma = new MAcademicTitle("Профессор", "Доц.");
			bool expected = false;
			//act
			bool actual = Controllers.CAcademicTitle.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_361_4() //учёное звание с таким кодом звания уже есть в таблице
		{
			//arrange
			Controllers.CAcademicTitle.Select().Clear();
			Task_361_1();
			MAcademicTitle ma = new MAcademicTitle("Профессор", "Доц.");
			bool expected = false;
			//act
			bool actual = Controllers.CAcademicTitle.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
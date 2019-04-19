using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	
	[TestClass]
	public class UT_Insert_AcademicTitle
	{

		[TestMethod]
		public void Task_361_1() //пустая таблица
		{
			//arrange
			bool expected = true;
			//act
			MTitle ma = new MTitle("Проф.", "Профессор");
			CTitle ca = new CTitle();
			bool actual = ca.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_361_2() //учёное звание с такой сокращённой записью уже есть в таблице
		{
			//arrange
			MTitle ma = new MTitle("Проф.", "Профессор");
			MTitle ma1 = new MTitle("Проф.", "Доцент");
			bool expected = false;
			//act
			CTitle ca = new CTitle();
			bool t = ca.Insert(ma1);
			bool actual = ca.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_361_3() //учёное звание с такой полной записью уже есть в таблице
		{
			//arrange
			MTitle ma = new MTitle("Проф.", "Профессор");
			MTitle ma1 = new MTitle("Доц.", "Профессор");
			bool expected = false;
			//act
			CTitle ca = new CTitle();
			bool t = ca.Insert(ma1);
			bool actual = ca.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
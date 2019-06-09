using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CTeacher
	{
		[TestMethod]
		public void Task_247_1()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = "Доктор наук";
			tcher1.AcademicTitle = "Доцент";
			tcher1.MetodicalDays = "Чт, Сб";
			tcher1.Windows = "Сб, Пн";
			tcher1.Weekends = "Пятница";
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_5()//дублируется уч. степень и уч. звание
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = "Кандидат наук";
			tcher1.AcademicTitle = "Доцент";
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_6()//дублируется кафедра 
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.Departament = "ФАСТ";
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_7()//дублируется график
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.MetodicalDays = "Пн, Вт";
			tcher1.Windows = "Ср, Чт, Пт";
			tcher1.Weekends = "Воскресенье";
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_8()//дублируется всё кроме ФИО
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = "Кандидат наук";
			tcher1.AcademicTitle = "Доцент";
			tcher1.Departament = "ФАСТ";
			tcher1.MetodicalDays = "Пн, Вт";
			tcher1.Windows = "Ср, Чт, Пт";
			tcher1.Weekends = "Воскресенье";
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CTeacher
	{
		[TestMethod]
		public void Task_247_1()//изменение когда атрибуды не повторяются (ФИО и Кафедра изменить не возможно)
		{
			//arrange
			MTeacher tcher = new MTeacher("Садовская Ольга Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна Людмила Юрьевна", "Доктор наук", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			CTeacher T = new CTeacher();
			T.Insert(tcher);
			T.Insert(tcher1);
			bool expected = true;
			//act
			tcher1.Note = "Ученый";
			tcher1.MetodicalDays = "Чт, Сб";
			tcher1.Windows = "Сб, Пн";
			tcher1.Weekends = "Пятница";
			bool actual = T.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_5and7()//изменение при условии что примечание, кафедра и график работы дублируется
		{
			//arrange
			MTeacher tcher = new MTeacher("Садовская Ольга Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна Людмила Юрьевна", "Доктор наук", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			CTeacher T = new CTeacher();
			T.Insert(tcher);
			T.Insert(tcher1);
			bool expected = true;
			//act
			tcher1.Note = "Кандидат наук";
			tcher1.Departament = "ФАСТ";
			tcher1.MetodicalDays = "Пн, Вт";
			tcher1.Windows = "Ср, Чт, Пт";
			tcher1.Weekends = "Воскресенье";
			bool actual = T.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

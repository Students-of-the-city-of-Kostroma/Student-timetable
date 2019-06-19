using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CTeacher
	{
		public string degree(string a, string b)
		{
			RefData.CAcademicDegree.Clear();
			MAcademicDegree ma = new MAcademicDegree(a, b); //Кандидат наук, канд.
			bool ex = true;
			//act
			bool act = RefData.CAcademicDegree.Insert(ma);
			//assert
			Assert.AreEqual(ex, act);
			return ma.FullName;
		}
		public string Title(string a, string b)
		{
			RefData.CTitle.Clear();
			MTitle ma = new MTitle(a, b);//Профессор, проф.
			bool expected = true;
			//act
			bool actual = RefData.CTitle.Insert(ma);
			//assert
			Assert.AreEqual(expected, actual);
			return ma.FullName;
		}
		[TestMethod]
		public void Task_247_1()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Кандидат наук", "Канд"), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = degree("Доктор наук", "Док.");
			tcher1.AcademicTitle = Title("Доцент", "Доц.");
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
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Доцент", "Доц."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = degree("Кандидат наук", "Канд");
			tcher1.AcademicTitle = Title("Доцент", "Доц.");
			bool actual = RefData.CTeacher.Update(tcher1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_247_6()//дублируется кафедра 
		{
			//arrange
			RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
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
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
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
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			RefData.CTeacher.Insert(tcher);
			RefData.CTeacher.Insert(tcher1);
			bool expected = false;
			//act
			tcher1.AcademicDegree = degree("Кандидат наук", "Канд");
			tcher1.AcademicTitle = Title("Доцент", "Доц.");
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

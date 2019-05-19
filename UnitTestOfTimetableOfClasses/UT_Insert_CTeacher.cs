using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CTeacher
	{
		[TestMethod]
		public void Task_246_1() //Добавление в пустую таблицу
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_2() //Полностью отличные атрибуты
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			bool expected = true;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_3() //Повторяющийся атрибут "ФИО"
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			bool expected = false;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_4() //Повторяющиеся атрибуты Уч. степень и Уч. звание
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Профессор", "ФСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_5() //Повторяющиеся атрибут Кафедра
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ФАСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_6() //Повторяющиеся атрибуты график работы
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ФСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_7() //Все атрибуты повторяются
		{
			//arrange 
			Controllers.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = false;
			//act
			Controllers.CTeacher.Insert(tcher1);
			bool actual = Controllers.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

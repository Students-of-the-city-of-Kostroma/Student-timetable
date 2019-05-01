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
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			CTeacher T = new CTeacher();
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_2() //Полностью отличные атрибуты
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна",  "Людмила",  "Юрьевна", "Доктор наук", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			bool expected = true;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_3() //Повторяющийся атрибут "ФИО"
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			bool expected = false;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_4() //Повторяющиеся атрибут Примечание
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "ФСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_5() //Повторяющиеся атрибут Кафедра
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Ученый", "ФАСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_6() //Повторяющиеся атрибуты гравик работы
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Ученый", "ФСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_7() //Все атрибуты повторяются
		{
			//arrange 
			MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = false;
			//act
			CTeacher T = new CTeacher();
			bool f = T.Insert(tcher1);
			bool actual = T.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

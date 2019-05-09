using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CUniversity
	{
		[TestMethod]
		public void Task_496_1() // Ввод в пустую таблицу
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool expected = true;
			//act 
			CUniversity cg = new CUniversity();
			bool actual = cg.Insert(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_2to8() //Дублирование всего кроме ИНН
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			CUniversity cg = new CUniversity();
			cg.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actual = cg.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_9() //дублирование ИНН
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			CUniversity cg = new CUniversity();
			cg.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			bool actual = cg.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_10() //дублирование всех атрибутов
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			CUniversity cg = new CUniversity();
			cg.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actual = cg.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

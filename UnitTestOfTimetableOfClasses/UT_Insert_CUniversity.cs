using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CUniversity
	{
		[TestMethod]
		public void Task_166_1()// ввод в пустую таблицу 
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool expected = true;
			//act 
			bool actual = Controllers.CUniversity.Insert(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		
		[TestMethod]
		public void Task_166_2_1() //Дублирование краткого названия
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Технологический Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = Controllers.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		// названия этих методов (которые выше и ниже) они так названы потому что в сценариях task-166-2 "дублирование названия"
		// здесь же есть полное и краткое название поэтому task-166-2 разделен на два task-166-2-1 и task-166-2-2
		[TestMethod]
		public void Task_166_2_2() //Дублирование полного названия
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = Controllers.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_166_3() //Дублирование руководителя
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Александр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = Controllers.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_166_4() //Дублирование Телефона
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317960");
			bool actual = Controllers.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_166_5() //Дублирование Почты
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Дмитрий", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317860");
			bool actual = Controllers.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}


	}
}

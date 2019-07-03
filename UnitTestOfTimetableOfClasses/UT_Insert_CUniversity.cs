﻿using System;
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
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool expected = true;
			//act 
			bool actual = RefData.CUniversity.Insert(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_2() //Дублирование краткого названия
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Технологический Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_3() //Дублирование полного названия
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_4() //Дублирование фактич. адреса
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_5() //Дублирование юр. адреса
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_6() //Дублирование ФИО
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = true;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Александр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_7() //Дублирование Почты
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Дмитрий", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317860");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_8() //Дублирование Телефона
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317960");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_9() //дублирование ИНН
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_496_10() //дублирование всех атрибутов
		{
			// arrange
			RefData.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(gr);
			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actual = RefData.CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

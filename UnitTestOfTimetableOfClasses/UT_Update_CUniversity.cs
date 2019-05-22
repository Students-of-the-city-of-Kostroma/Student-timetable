using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CUniversity
	{
		[TestMethod]
		public void Task_497_1() 
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.ShortName = "КГТУ";
			gr1.FullName = "Костромской Государственный Технологический Университет";
			gr1.ActualAddress = "156205, Костромская область, г. Кострома, ул. Дзержинского, 37";
			gr1.LegalAddress= "156205, Костромская область, г. Кострома, ул. Дзержинского, 37";
			gr1.NameRector = "Леонид";
			gr1.SurnameRector = "Леонидов";
			gr1.MiddleNameRector = "Леонидович";
			gr1.Email = "kgtu@mail.ru";
			gr1.Phone = "89995119864";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_2()//дублирование краткого названия
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.ShortName = "КГУ";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_3()//дублирование полного названия
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.FullName = "Костромкой Государственный Университет";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_4()//дублирование факт. адреса
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.ActualAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_5()//дублирование юр. адреса
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.LegalAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_6()//дублирование ФИО ректора
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.NameRector = "Александр";
			gr1.SurnameRector = "Наумов";
			gr1.MiddleNameRector = "Рудольфович";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_497_7()//дублирование Почты
		{
			// arrange
			Controllers.CUniversity.Rows.Clear();
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			Controllers.CUniversity.Insert(gr);
			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			Controllers.CUniversity.Insert(gr1);
			bool expected = true;
			//act 
			gr1.Email = "kgu@mail.ru";
			bool actual = Controllers.CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
public void Task_496_10() //дублирование всех атрибутов
		{
		// arrange
		Controllers.CUniversity.Rows.Clear();
		MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
		Controllers.CUniversity.Insert(gr);
		bool expected = false;
		//act 
		MUniversity gr1 = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
		bool actual = Controllers.CUniversity.Insert(gr1);
		//assert 
		Assert.AreEqual(expected, actual);
		}
	}
}

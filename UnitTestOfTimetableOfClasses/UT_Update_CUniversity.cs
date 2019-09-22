using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CUniversity
	{
		private CUniversity CUniversity = new CUniversity();


		[TestCleanup()]
		public void TearDown()
		{
			for (int i = 0; i < CUniversity.Rows.Count; i++)
			{				CUniversity.Rows[i].Delete();			}
		}

		/// <summary>
		/// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров 
		/// </summary>
		[TestMethod]
		public void Task_497_1() 
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома.", "156005, Костромская область, г. Кострома.", "Александр", "Наумов", "Рудольфович", "infor@ksu.edu.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006211", "КГТУ", "Костромской Государственный Технический Университет", "156005, Костромская область, г. Костромушка.", "156005, Костромская область, г. Костромушка.", "Александр", "Наумов", "Сергеевич", "informacia@ksu.edu.ru", "84942317911");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = true;
			//act 
			gr.INN = "4401006211";
			gr.ShortName = "КГТУ";
			gr.FullName = "Костромской Государственный Технологический Университет";
			gr.ActualAddress = "156005, Костромская область, г. Костромушка.";
			gr.LegalAddress= "156005, Костромская область, г. Костромушка.";
			gr.NameRector = "Александр";
			gr.SurnameRector = "Наумов";
			gr.MiddleNameRector = "Сергеевич";
			gr.Email = "informacia@ksu.edu.ru";
			gr.Phone = "84942317911";
			bool actual = CUniversity.Update(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Краткое название дублирует Краткое название существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_2()//дублирование краткого названия
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = true;
			//act 
			gr1.ShortName = "КГУ";
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Полное название дублирует Полное название существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_3()//дублирование полного названия
		{
			string fullName = "Костромкой Государственный Университет";
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", fullName, "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = false;
			//act 
			gr1.FullName = fullName;
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Фактический адрес дублирует Фактический адрес существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_4()//дублирование факт. адреса
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = true;
			//act 
			gr1.ActualAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Юридический адрес дублирует Юридический адрес адрес существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_5()//дублирование юр. адреса
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = true;
			//act 
			gr1.LegalAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}

		/// <summary>
		/// Ввод корректных данных, при условии, что ФИО ректора дублирует ФИО ректора адрес существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_6()//дублирование ФИО ректора
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);

			bool expected = true;
			//act 
			gr1.NameRector = "Александр";
			gr1.SurnameRector = "Наумов";
			gr1.MiddleNameRector = "Рудольфович";
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}

		/// <summary>
		/// Ввод корректных данных, при условии, что Почта дублирует Почта адрес существующего экземпляра(не учитывая основные атрибуты)
		/// </summary>
		[TestMethod]
		public void Task_497_7()//дублирование Почты
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
			result = CUniversity.Insert(gr1);
			Assert.IsTrue(result);

			bool expected = false;
			//act 
			gr1.Email = "kgu@mail.ru";
			bool actual = CUniversity.Update(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}

		/// <summary>
		/// Ввод данных аналогичных уже существующим
		/// </summary>
		[TestMethod]
		public void Task_496_10() //дублирование всех атрибутов
		{
			// arrange
			MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool result = CUniversity.Insert(gr);
			Assert.IsTrue(result);

			bool expected = false;
			//act 
			MUniversity gr1 = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actual = CUniversity.Insert(gr1);
			//assert 
			Assert.AreEqual(expected, actual);		}
	}
}

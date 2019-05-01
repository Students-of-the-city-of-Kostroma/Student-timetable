using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CEnclosurse
	{
		[TestMethod]
		public void Task_397_1() //Ввод в пустую таблицу
		{
			//arrange
			MEnclosures gr = new MEnclosures ("А", "КГУ", "Дзержинского", "111111", "1" );
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			//act
			bool actual = cg.Insert(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_2() //Дублирование адреса
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГТУ", "Дзержинского", "111121", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_3() //Дублирование телефона
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГТУ", "Ивановская", "111111", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_4() //Дублирование примечания
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГТУ", "Ивановская", "111121", "1");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_6() //Дублирование корпуса и ВУЗа
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = false;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("А", "КГУ", "Дзержинск", "222222", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_5() //Полностью отличные атрибуты
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГТУ", "Дзержинск", "222222", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_7() //Дублирование Корпуса
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("А", "КГТУ", "Дзержинск", "222222", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_397_8() //Дублирование ВУЗа
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			bool expected = true;
			bool g = cg.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Дзержинск", "222222", "2");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

	}
}

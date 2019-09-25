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
            MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            //act
            bool actual = RefData.CEnclosures.Insert(gr);
            //assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
        }

		[TestMethod]
		public void Task_397_2() //Дублирование адреса
		{
			//arrange
			MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинского", "111121", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_3() //Дублирование телефона
		{
			//arrange
			MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111111", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_4() //Дублирование примечания
		{
			//arrange
			MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = true;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111121", "1");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_6() //Дублирование корпуса и ВУЗа
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинск", "222222", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_5() //Полностью отличные атрибуты
		{
			//arrange
			MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = true;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_7() //Дублирование Корпуса
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинск", "222222", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

		[TestMethod]
		public void Task_397_8() //Дублирование ВУЗа
		{
			//arrange
			MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = true;
			RefData.CEnclosures.Insert(gr);
			//act
			MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
			bool actual = RefData.CEnclosures.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }

	}
}

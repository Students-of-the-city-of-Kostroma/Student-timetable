using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CGroup
	{

		[TestMethod]
		public void Task_251_1() //пустая таблица
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			bool expected = true;
			//act
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool actual = RefData.CGroup.Insert(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_2() //дуюлирование атрибута "Группа" остальные атрибуты различаются
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = false;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2а", 2, "ИСиТД", 2, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_251_10() //добавление записи ктороая не дублирует ни один атрибут уже имеющейся записи 
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ЮФбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ЮФбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_11() //полное дублирование всех атрибутов
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = false;
			//act
			MGroup gr1 = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_3() // дублирование Семестра
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 1, "ИСТ", 2, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_4() // дублирование напр. подготоаки
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСиТ", 2, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_5() // дублирование смены
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСТ", 1, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_6() // дублирование студентов
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСТ", 2, 1, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_7() // дублирование пар мин
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСТ", 2, 2, 0, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_8() // дублирование пар макс
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 1, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСТ", 2, 2, 1, 1, "Суббота");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_251_9() // дублирование выходной
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 2, "ИСТ", 2, 2, 1, 1, "Воскресенье");
			bool actual = RefData.CGroup.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

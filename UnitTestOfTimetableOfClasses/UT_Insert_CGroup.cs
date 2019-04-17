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
			bool expected = true;
			//act
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			bool actual = cg.Insert(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_2() //дуюлирование атрибута "Группа" остальные атрибуты раздичаются
		{
			//arrange
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			bool g = cg.Insert(gr);
			bool expected = false;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2а", 2, "ИСиТД", 2, 2, 1, 1, "Суббота");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_251_10() //добавление записи ктороая не дублирует ни один атрибут уже имеющейся записи 
		{
			//arrange
			MGroup gr = new MGroup("17-ЮФбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			bool g = cg.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ЮФбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Суббота");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_11() //полное дублирование всех атрибутов
		{
			//arrange
			MGroup gr = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			bool g = cg.Insert(gr);
			bool expected = false;
			//act
			MGroup gr1 = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_251_from_3_or_9() // дублирование всех атрибутов, кроме атрибута "Группа"
		{
			//arrange
			MGroup gr = new MGroup("17-ИДбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			bool g = cg.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИДбо-2б", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			bool actual = cg.Insert(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CAuditor
	{
		[TestMethod]
		public void Task_270_1() //пустая таблица
		{
			//arrange
			bool expected = true;
			//act
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool actual = ca.Insert(aud);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_270_6() //добавление записи ктороая не дублирует ни один атрибут уже имеющейся записи 
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = true;
			//act
			MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 30, "4");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_270_7() //полное дублирование всех атрибутов
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = false;
			//act
			MAuditor aud1 = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void Task_270_2() // дбавление записи, которая не дублирует ни один атрибут кроме корпуса
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = true;
			//act
			MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 30, "5");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_270_3() // дбавление записи, которая не дублирует ни один атрибут кроме кафедры
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = true;
			//act
			MAuditor aud1 = new MAuditor("302", "каф.  Иностранных языков", 30, "4");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_270_4() // дбавление записи, которая не дублирует ни один атрибут кроме числа мест
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = true;
			//act
			MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 20, "4");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_270_5() // дбавление записи, которая не дублирует ни один атрибут кроме названия
		{
			//arrange
			MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			CAuditor ca = new CAuditor();
			bool a = ca.Insert(aud);
			bool expected = false;
			//act
			MAuditor aud1 = new MAuditor("502", "каф. Дизайна", 20, "5");
			bool actual = ca.Insert(aud1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
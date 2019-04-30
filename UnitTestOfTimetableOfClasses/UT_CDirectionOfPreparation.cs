using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CDirectionOfPreparation
	{
		// Insert
		[TestMethod]
		public void Task_552_1()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_552_2()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			
			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Философия", 40);

			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 2, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_552_3()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Туризм", 40);

			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void Task_552_4()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Туризм", 20);

			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 2, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_552_5()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Туризм", 40);

			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 2, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_552_6()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);

			bool result = Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);
			int tableRows = Controllers.CDirectionOfPreparation.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, false);
		}


		// Update
		[TestMethod]
		public void Task_553_1()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Туризм", 40);

			bool result = Controllers.CDirectionOfPreparation.Update(directionOfPreparation);

			Assert.AreEqual(result, false, "не ожидаем обновления данных в таблице");
		}

		[TestMethod]
		public void Task_553_2()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Туризм", 40);

			bool result = Controllers.CDirectionOfPreparation.Update(directionOfPreparation);

			Assert.AreEqual(result, true, "ожидаем обновления данных в таблице");
		}

		[TestMethod]
		public void Task_553_3()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Филология", 40);

			bool result = Controllers.CDirectionOfPreparation.Update(directionOfPreparation);

			Assert.AreEqual(result, false, "не ожидаем обновления данных в таблице");
		}

		[TestMethod]
		public void Task_553_4()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("30.30.30", "Филология", 20);

			bool result = Controllers.CDirectionOfPreparation.Update(directionOfPreparation);

			Assert.AreEqual(result, false, "не ожидаем обновления данных в таблице");
		}

		[TestMethod]
		public void Task_553_5()
		{
			Controllers.CDirectionOfPreparation.Clear();

			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			Controllers.CDirectionOfPreparation.Insert(directionOfPreparation);

			directionOfPreparation = new MDirectionOfPreparation("24.24.24", "Филология", 20);
			bool result = Controllers.CDirectionOfPreparation.Update(directionOfPreparation);

			Assert.AreEqual(result, true, "ожидаем обновления данных в таблице");
		}
	}
}

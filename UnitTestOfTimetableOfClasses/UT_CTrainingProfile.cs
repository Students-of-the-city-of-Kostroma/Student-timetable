using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CTrainingProfile
	{
		//INSERT
		[TestMethod]
		public void Task_420_1()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");

			bool result = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int tableRows = Controllers.CTrainingProfile.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_420_2()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИВТ");
			bool result = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int tableRows = Controllers.CTrainingProfile.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void Task_420_3()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Информатика и вычислительная техника", "ИАСТ");
			bool result = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int tableRows = Controllers.CTrainingProfile.Rows.Count;

			Assert.AreEqual(tableRows, 2, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_420_4()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Информатика и вычислительная техника", "ИВТ");
			bool result = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int tableRows = Controllers.CTrainingProfile.Rows.Count;

			Assert.AreEqual(tableRows, 2, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void Task_420_5()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			bool result = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int tableRows = Controllers.CTrainingProfile.Rows.Count;

			Assert.AreEqual(tableRows, 1, "ожидается добавление данных в таблицу");
			Assert.AreEqual(result, false);
		}



		//UPDATE
		[TestMethod]
		public void Task_421_1()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");

			T_TrainingProfile = new MTrainingProfile("Информатика и вычислительная техника", "ИВТ");
			bool result = Controllers.CTrainingProfile.Update(T_TrainingProfile);

			Assert.AreEqual(result, false, "не ожидаются изменения данных в таблице");
		}

		[TestMethod]
		public void Task_421_2()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИВТ");
			bool result = Controllers.CTrainingProfile.Update(T_TrainingProfile);

			Assert.AreEqual(result, true, "ожидаются изменения данных в таблице");
		}

		[TestMethod]
		public void Task_421_3()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Информатика и вычислительная техника", "ИАСТ");
			bool result = Controllers.CTrainingProfile.Update(T_TrainingProfile);

			Assert.AreEqual(result, false, "не ожидаются изменения данных в таблице");
		}

		[TestMethod]
		public void Task_421_4()
		{
			Controllers.CTrainingProfile.Clear();
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			Controllers.CTrainingProfile.Insert(T_TrainingProfile);

			T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			bool result = Controllers.CTrainingProfile.Update(T_TrainingProfile);

			Assert.AreEqual(result, true, "ожидаются изменения данных в таблице");
		}
	}
}

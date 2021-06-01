using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CTrainingProfile.UT_Delete
{
	[TestClass]
	public class UT_DCTrainingProfile
	{
        readonly RefData refData = new RefData();

		/// <summary>
		/// загрузка тестовых данных
		/// </summary>
		[TestInitialize]
		public void RefDataInit()
		{
			refData.InitData();
		}

		/// <summary>
		/// Удаление существующих данных выбранной строки из таблицы
		/// </summary>
		[TestMethod]
		public void DCTrainingProfile_1()
		{
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
			int C1 = refData.CTrainingProfile.Rows.Count;
			Assert.IsTrue(C1 > 0, "Таблица должна быть не пустой");
			Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить существующую запись");
			int C2 = refData.CTrainingProfile.Rows.Count;
			Assert.IsTrue(C1 - 1 == C2, "Количество записьей не изменилось");
		}
		/// <summary>
		/// Удаление данных из пустой таблицы
		/// </summary>
		[TestMethod]
		public void DCTrainingProfile_2()
		{
			refData.CCourseSchedule.Clear();
			refData.CAcademicLoad.Clear();
			refData.CGroup.Clear();
			refData.CTrainingProfile.Clear();
			Assert.IsTrue(refData.CTrainingProfile.Rows.Count == 0, "Таблица должна быть пустой");
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
			Assert.IsFalse(refData.CTrainingProfile.Delete(mTrainingProfile), "Данные из пустой таблицы удалились, чудо");
			Assert.IsTrue(refData.CTrainingProfile.Rows.Count == 0, "Таблица должна быть пустой");
		}
	}
}

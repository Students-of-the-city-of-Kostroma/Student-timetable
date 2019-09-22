using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CTrainingProfile
	{
		/// <summary>
		/// Начальные условия для метода Delete
		/// </summary>
		public void Pre_condition_Del()
		{
			bool exPrep = true;
			bool actPrep;
			MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "ИАСТ", 20);
			int DoP1 = RefData.CDirectionOfPreparation.Rows.Count;
			actPrep = RefData.CDirectionOfPreparation.Insert(T_DirectionOfPreparation);
			int DoP2 = RefData.CDirectionOfPreparation.Rows.Count;
			Assert.AreEqual(exPrep, actPrep);
			Assert.AreEqual(DoP1 + 1, DoP2);

			bool ex = true;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ", "01.02.03");
			int C1 = RefData.CTrainingProfile.Rows.Count;
			act = RefData.CTrainingProfile.Insert(T_TrainingProfile);
			int C2 = RefData.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		/// <summary>
		/// Удаление существующих данных выбранной строки из таблицы
		/// </summary>
		[TestMethod]
		public void Task_422_1()
		{
			Pre_condition_Del();
			bool ex = true;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ", "01.02.03");
			int C1 = RefData.CTrainingProfile.Rows.Count;
			act = RefData.CTrainingProfile.Delete(T_TrainingProfile);
			int C2 = RefData.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		/// <summary>
		/// Удаление данных из пустой таблицы
		/// </summary>
		[TestMethod]
		public void Task_422_2()
		{
			bool ex = false;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ", "01.02.03");
			int C1 = RefData.CTrainingProfile.Rows.Count;
			act = RefData.CTrainingProfile.Delete(T_TrainingProfile);
			int C2 = RefData.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}
}

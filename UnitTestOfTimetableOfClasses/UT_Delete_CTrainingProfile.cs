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
			Controllers.CTrainingProfile.Clear();
			bool ex = true;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			int C1 = Controllers.CTrainingProfile.Rows.Count;
			act = Controllers.CTrainingProfile.Insert(T_TrainingProfile);
			int C2 = Controllers.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_422_1()
		{
			Pre_condition_Del();
			bool ex = true;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			int C1 = Controllers.CTrainingProfile.Rows.Count;
			act = Controllers.CTrainingProfile.Delete(T_TrainingProfile);
			int C2 = Controllers.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		[TestMethod]
		public void Task_422_2()
		{
			bool ex = false;
			bool act;
			MTrainingProfile T_TrainingProfile = new MTrainingProfile("Институт автоматизированных систем и технологий", "ИАСТ");
			int C1 = Controllers.CTrainingProfile.Rows.Count;
			act = Controllers.CTrainingProfile.Delete(T_TrainingProfile);
			int C2 = Controllers.CTrainingProfile.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}
}

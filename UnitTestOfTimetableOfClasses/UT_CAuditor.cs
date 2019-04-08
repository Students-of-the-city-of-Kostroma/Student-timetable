using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CAuditor
	{
		[TestMethod]
		public void Task_271_1()
		{
			Pre_condition();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, 5);
			int C1 = Controllers.CAuditor.Select().Rows.Count;
			act = Controllers.CAuditor.Delete(T_Auditor);
			int C2 = Controllers.CAuditor.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		/// <summary>
		/// Начальные условия для метода Delete
		/// </summary>
		public void Pre_condition()
		{
			Controllers.CAuditor.Select().Clear();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, 5);
			int C1 = Controllers.CAuditor.Select().Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_271_2()
		{
			bool ex = false;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, 5);
			int C1 = Controllers.CAuditor.Select().Rows.Count;
			act = Controllers.CAuditor.Delete(T_Auditor);
			int C2 = Controllers.CAuditor.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}
}

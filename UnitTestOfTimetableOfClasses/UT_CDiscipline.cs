using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CDiscipline
	{
		[TestMethod]
		public void Task_273_1()
		{
			Pre_condition();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Select().Rows.Count;
			act = Controllers.CDiscipline.Delete(T_Discipline);
			int C2 = Controllers.CDiscipline.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		/// <summary>
		/// Начальные условия для тестирования метода Delete в task-273-1
		/// </summary>
		public void Pre_condition()
		{
			Controllers.CDiscipline.Select().Clear();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Select().Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_273_2()
		{
			bool ex = false;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Select().Rows.Count;
			act = Controllers.CDiscipline.Delete(T_Discipline);
			int C2 = Controllers.CDiscipline.Select().Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
	}
}

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
			Pre_condition_Del();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Delete(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}

		/// <summary>
		/// Начальные условия для метода Delete
		/// </summary>
		public void Pre_condition_Del()
		{
			Controllers.CAuditor.Clear();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_271_2()
		{
			bool ex = false;
			bool act;
			MAuditor T_Auditor = new MAuditor("208", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Delete(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}

		public void Pre_condition_Insert()
		{
			Controllers.CAuditor.Clear();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_334_1()
		{
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_2()
		{
			Pre_condition_Insert();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("302", "каф. Дизайна", 30, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_3()
		{
			Pre_condition_Insert();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("302", "каф. Иностранных языков", 30, "4");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_4()
		{
			Pre_condition_Insert();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("302", "каф. Дизайна", 20, "4");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_5()
		{
			Pre_condition_Insert();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("502", "каф. Дизайна", 30, "4");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_6()
		{
			Pre_condition_Insert();
			bool ex = true;
			bool act;
			MAuditor T_Auditor = new MAuditor("302", "каф. Дизайна", 30, "4");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}

		[TestMethod]
		public void Task_334_7()
		{
			Pre_condition_Insert();
			bool ex = false;
			bool act;
			MAuditor T_Auditor = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}

		[TestMethod]
		public void Task_334_8()
		{
			Pre_condition_Insert();
			bool ex = false;
			bool act;
			MAuditor T_Auditor = new MAuditor("502", "каф. Дизайна", 30, "5");
			int C1 = Controllers.CAuditor.Rows.Count;
			act = Controllers.CAuditor.Insert(T_Auditor);
			int C2 = Controllers.CAuditor.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
		public MAuditor Pre_condition_Update()
		{
			Controllers.CAuditor.Clear();
			MAuditor T_Auditor = new MAuditor("502", "каф. Иностранных языков", 20, "5");
			Controllers.CAuditor.Insert(T_Auditor);
			return T_Auditor;
		}

		[TestMethod]
		public void Task_336_1()
		{
			MAuditor T_Auditor = Pre_condition_Update();
			T_Auditor = new MAuditor("502", "каф. Дизайна", 30, "5");
			bool result = Controllers.CAuditor.Update(T_Auditor);

			Assert.IsTrue(result, "Ожидаем, что Модель изменится");
		}

		[TestMethod]
		public void Task_336_2()
		{
			MAuditor T_Auditor = Pre_condition_Update();
			T_Auditor = new MAuditor("502", "каф. Дизайна", 30, "4");
			bool result = Controllers.CAuditor.Update(T_Auditor);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}

		[TestMethod]
		public void Task_336_3()
		{
			MAuditor T_Auditor = Pre_condition_Update();
			T_Auditor = new MAuditor("302", "каф. Дизайна", 20, "4");
			bool result = Controllers.CAuditor.Update(T_Auditor);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}

		[TestMethod]
		public void Task_336_4()
		{
			MAuditor T_Auditor = Pre_condition_Update();
			T_Auditor = new MAuditor("302", "каф. Иностранных языков", 30, "4");
			bool result = Controllers.CAuditor.Update(T_Auditor);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}

		[TestMethod]
		public void Task_336_5()
		{
			MAuditor T_Auditor = Pre_condition_Update();
			T_Auditor = new MAuditor("302", "каф. Дизайна", 30, "5");
			bool result = Controllers.CAuditor.Update(T_Auditor);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}
	}
}

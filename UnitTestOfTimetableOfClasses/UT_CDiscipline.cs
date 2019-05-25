using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_CDiscipline
	{
		[TestMethod]
		public void Task_339_1()
		{
			CDiscipline y = new CDiscipline();
			Pre_condition_Del();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = y.Rows.Count;
			act = y.Delete(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		/// <summary>
		/// Начальные условия для тестирования метода Delete в task-339
		/// </summary>
		public void Pre_condition_Del()
		{
			CDiscipline y = new CDiscipline();
			y.Clear();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = y.Rows.Count;
			act = y.Insert(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_339_2()
		{
			CDiscipline y = new CDiscipline();
			y.Clear();
			bool ex = false;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = y.Rows.Count;
			act = y.Delete(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}

		[TestMethod]
		public void Task_337_1()
		{
			CDiscipline y = new CDiscipline();
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			y.Clear();
			y.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Физика", "Физ.", "33");
			bool result = y.Update(T_Discipline);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}

		[TestMethod]
		public void Task_337_2()
		{
			CDiscipline y = new CDiscipline();
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			y.Clear();
			y.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Математика", "Физ.", "33");
			bool result = y.Update(T_Discipline);

			Assert.IsTrue(result, "Ожидаем, что Модель изменится");
		}

		[TestMethod]
		public void Task_337_3()
		{
			CDiscipline y = new CDiscipline();
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			y.Clear();
			y.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Физика", "Мат.", "33");
			bool result = y.Update(T_Discipline);


			Assert.IsFalse(result, "Ожидаем, что Модель не изменится");
		}

		[TestMethod]
		public void Task_337_4()
		{
			CDiscipline y = new CDiscipline();
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			y.Clear();
			y.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			bool result = y.Update(T_Discipline);


			Assert.IsTrue(result, "Ожидаем, что Модель изменится");
		}
		[TestMethod]
		public void Task_335_1()
		{
			CDiscipline y = new CDiscipline();
			y.Clear();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = y.Rows.Count;
			act = y.Insert(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_335_2()
		{
			Task_335_1();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Физика", "Физ.", "33");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_335_3()
		{
			Task_335_1();
			bool ex = false;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Физ.", "33");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}
		[TestMethod]
		public void Task_335_4()
		{
			CDiscipline y = new CDiscipline();
			Task_335_1();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Физика", "Физ.", "42");
			int C1 = y.Rows.Count;
			act = y.Insert(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_335_5()
		{
			CDiscipline y = new CDiscipline();
			Task_335_1();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Физика", "Мат.", "33");
			int C1 = y.Rows.Count;
			act = y.Insert(T_Discipline);
			int C2 = y.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_271_5()
		{
			Task_335_1();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Физика", "Мат.", "33");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
	}
}

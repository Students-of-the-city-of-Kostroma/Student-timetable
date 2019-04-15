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
			Pre_condition_Del();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Delete(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 - 1, C2);
		}
		/// <summary>
		/// Начальные условия для тестирования метода Delete в task-273-1
		/// </summary>
		public void Pre_condition_Del()
		{
			Controllers.CDiscipline.Clear();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_273_2()
		{
			bool ex = false;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Delete(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1, C2);
		}

		/*[TestMethod]
		public void Task_269_1()
		[TestMethod]
		public void Task_337_1()
		{
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			Controllers.CDiscipline.Clear();
			Controllers.CDiscipline.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Физика", "Физ.", "33");
			bool result = Controllers.CDiscipline.Update(T_Discipline);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}

		[TestMethod]
		public void Task_337_2()
		{
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			Controllers.CDiscipline.Clear();
			Controllers.CDiscipline.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Математика", "Физ.", "33");
			bool result = Controllers.CDiscipline.Update(T_Discipline);

			Assert.IsTrue(result, "Ожидаем, что Модель изменится");
		}

		[TestMethod]
		public void Task_337_3()
		{
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			Controllers.CDiscipline.Clear();
			Controllers.CDiscipline.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Физика", "Мат.", "33");
			bool result = Controllers.CDiscipline.Update(T_Discipline);


			Assert.IsFalse(result, "Ожидаем, что Модель не изменится");
		}

		[TestMethod]
		public void Task_337_4()
		{
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");

			Controllers.CDiscipline.Clear();
			Controllers.CDiscipline.Insert(T_Discipline);

			T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			bool result = Controllers.CDiscipline.Update(T_Discipline);


			Assert.IsTrue(result, "Ожидаем, что Модель изменится");
		}
		[TestMethod]
		public void Task_335_1()
		{
			Controllers.CDiscipline.Clear();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Математика", "Мат.", "42");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
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
			Task_335_1();
			bool ex = true;
			bool act;
			MDiscipline T_Discipline = new MDiscipline("Физика", "Физ.", "42");
			int C1 = Controllers.CDiscipline.Rows.Count;
			act = Controllers.CDiscipline.Insert(T_Discipline);
			int C2 = Controllers.CDiscipline.Rows.Count;
			Assert.AreEqual(ex, act);
			Assert.AreEqual(C1 + 1, C2);
		}
		[TestMethod]
		public void Task_335_5()
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
		*/
	}
}

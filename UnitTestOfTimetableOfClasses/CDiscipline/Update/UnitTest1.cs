using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.CDiscipline.Update
{
	[TestClass]
	public class UT_ICDiscipline
	{
		RefData refData = new RefData();

		/// <summary>
		/// Обновление дисциплины, у котрой название не задано.
		/// </summary>
		[TestMethod]
		public void ICDiscipline_1()
		{
			// arrange
			MDiscipline gr = new MDiscipline(null, "КПК", "1");
			bool expected = false;

			// act
			bool actual = refData.CDiscipline.Update(gr);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Обновление дисциплины, у котрой коротокое название не задано.
		/// </summary>
		[TestMethod]
		public void ICDiscipline_2()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", null, "1");
			bool expected = false;

			// act
			bool actual = refData.CDiscipline.Update(gr);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Обновление дисциплины , у котрой цикл дисциплины не задан.
		/// </summary>
		[TestMethod]
		public void ICDiscipline_3()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", "КП", null);
			bool expected = false;

			// act
			bool actual = refData.CDiscipline.Update(gr);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Изменить дисциплину, в условии отсутсвия других дисциплин.
		/// </summary>
		[TestMethod]
		public void ICDiscipline_4()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
			bool expected = false;

			// act
			bool actual = refData.CDiscipline.Update(gr);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Изменить не существующую дисциплину
		/// </summary>
		[TestMethod]
		public void ICDiscipline_5()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
			MDiscipline gr2 = new MDiscipline("Афродита", "КП", "1");
			bool expected = false;

			// act
			refData.CDiscipline.Insert(gr);
			bool actual = refData.CDiscipline.Update(gr2);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Изменить существующей дисциплины
		/// </summary>
		[TestMethod]
		public void ICDiscipline_6()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
			bool expected = true;

			// act
			refData.CDiscipline.Insert(gr);
			bool actual = refData.CDiscipline.Update(gr);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Нет связи с другими таблицами, срабатывание expetion невозможно
		/// </summary>
		[TestMethod]
		[Ignore]
		public void ICDiscipline_7()
		{
		}
	}
}

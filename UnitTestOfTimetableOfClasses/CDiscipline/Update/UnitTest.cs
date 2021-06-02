using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_CDiscipline.UT_Update
{
	[TestClass]
	public class UT_UCDiscipline
	{
        readonly RefData refData = new RefData();

		/// <summary>
		/// Обновление дисциплины, у котрой название не задано.
		/// </summary>
		[TestMethod]
		public void UCDiscipline_1()
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
		public void UCDiscipline_2()
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
		public void UCDiscipline_3()
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
		/// Изменить дисциплину в пустой таблице.
		/// </summary>
		[TestMethod]
		public void UCDiscipline_4()
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
		public void UCDiscipline_5()
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
		/// Изменить существующую дисциплину
		/// </summary>
		[TestMethod]
		public void UCDiscipline_6()
		{
			// arrange
			MDiscipline gr = new MDiscipline("Клеопатра", "КП", "1");
			MDiscipline gr1 = new MDiscipline("Клеопатра", "АФ", "1");
			bool expected = true;

			// act
			refData.CDiscipline.Insert(gr);
			bool actual = refData.CDiscipline.Update(gr1);

			// assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Нет связи с другими таблицами, срабатывание expetion невозможно
		/// </summary>
		[TestMethod]
		[Ignore]
		public void UCDiscipline_7()
		{
		}
	}
}

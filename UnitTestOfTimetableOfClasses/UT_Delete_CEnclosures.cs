using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CEnclosures
	{
		/// <summary>
		/// Удаление существующих данных выбранной строки из таблицы
		/// </summary>
		[TestMethod]
		public void task_395_1()
		{
			RefData.CUniversity.Rows.Clear();
			MUniversity grUni = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			bool actualUni = RefData.CUniversity.Insert(grUni);
			Assert.AreEqual(true, actualUni);
			// arrange 
			RefData.CEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", grUni.FullName, "Дзержинского", "111111", "1");
			bool expected = true;
			//act 
			RefData.CEnclosures.Insert(gr);
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Удаление данных из пустой таблицы
		/// </summary>
		[TestMethod]
		public void task_395_2() 
		{
			//arrange 
			RefData.CEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			//act 
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
	}
}

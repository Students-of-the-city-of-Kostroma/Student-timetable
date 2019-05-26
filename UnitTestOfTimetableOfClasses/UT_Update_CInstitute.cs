using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CInstitute
	{
		[TestMethod]
		public void Task_513_1() //замена всех атрибутов
		{

			MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");


			RefData.CInstitute.Clear();
			RefData.CInstitute.Insert(T_Institute);


			T_Institute = new MInstitute("Факультет Автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "КГТУ");
			bool result = RefData.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		[TestMethod]
		public void Task_513_2() //замена атрибутов Полное название
		{

			MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");


			RefData.CInstitute.Clear();
			RefData.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "КГУ");
			bool result = RefData.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}
	}
}
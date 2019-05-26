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

			MInstitute T_Institute = new MInstitute("Институт автоматизированных", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");


            Controllers.CInstitute.Clear();
            Controllers.CInstitute.Insert(T_Institute);


			T_Institute = new MInstitute("Факультет автоматизированных", "ФАСТ", "Голубева Ю.А.", "КГТУ");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		[TestMethod]
		public void Task_513_2() //замена атрибутов Полное название
		{

			MInstitute T_Institute = new MInstitute("Институт автоматизированных", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");


            Controllers.CInstitute.Clear();
            Controllers.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт автоматизированны", "ФАСТ", "Лустгартен Ю.Л.", "КГУ");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}
	}
}
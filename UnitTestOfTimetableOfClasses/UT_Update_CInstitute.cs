using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CInstitute
	{
		[TestMethod]
		public void Task_615_1() //замена всех атрибутов
		{

			MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            Controllers.CInstitute.Clear();
            Controllers.CInstitute.Insert(T_Institute);


			T_Institute = new MInstitute("Факультет автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Политехнический колледж");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		[TestMethod]
		public void Task_615_2() //замена атрибутов Полное название
		{

			MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");


            Controllers.CInstitute.Clear();
            Controllers.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		[TestMethod]
		public void Task_615_3() //краткая запись института уже есть в таблице
		{

			MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");


			Controllers.CInstitute.Clear();
			Controllers.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт Дизайна", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		
		[TestMethod]
		public void Task_615_4() //директор уже есть в таблице
		{

			MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");


			Controllers.CInstitute.Clear();
			Controllers.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт Дизайна", "ФАСТ", "Лустгартен Ю.Л.", "Политехнический колледж");
			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}

		[TestMethod]
		public void Task_615_5() //наименование ВУЗа уже есть в таблице
		{

			MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");


			Controllers.CInstitute.Clear();
			Controllers.CInstitute.Insert(T_Institute);

			T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Киприна Ю.Л.", "Костромской Государственный Университет");

			bool result = Controllers.CInstitute.Update(T_Institute);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

		}
	}
}
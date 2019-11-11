using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CInstitute
    {
		private CInstitute cInstitute;

		[TestInitialize()]
		public void SetUp()
		{
			cInstitute = new CInstitute();
		}

		[TestCleanup()]
		public void TearDown()
		{
			cInstitute = null;
		}

		/// <summary>
		/// Замена корректными данными всех  полей таблицы, не дублируя существующие
		/// </summary>
	   [TestMethod]
        public void Task_615_1()
        {
			MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", 
				"Костромской Государственный Университет");

			bool result = cInstitute.Insert(T_Institute);
			Assert.IsTrue(result);

            T_Institute = new MInstitute("Факультет автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Политехнический колледж");
            result = cInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

		/// <summary>
		/// Замена корректными данными всех  полей таблицы, при условии, что полная запись института уже есть в таблице
		/// </summary>
		[TestMethod]
        public void Task_615_2()
        {

            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.",
				"Костромской Государственный Университет");

			bool result = cInstitute.Insert(T_Institute);
			Assert.IsTrue(result);


			T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
            result = cInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

		/// <summary>
		/// Замена корректными данными всех полей таблицы, при условии, что краткая запись института уже есть в таблице
		/// </summary>
		[TestMethod]
        public void Task_615_3()
        {

            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.",
				"Костромской Государственный Университет");
			bool result = cInstitute.Insert(T_Institute);
			Assert.IsTrue(result);

			T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
            result = cInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }


		/// <summary>
		///Замена корректными данными всех полей таблицы, при условии, что директор уже есть в таблице
		/// </summary>
		[TestMethod]
        public void Task_615_4()
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.",
				"Костромской Государственный Университет");
			bool result = cInstitute.Insert(T_Institute);
			Assert.IsTrue(result);

			T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Лустгартен Ю.Л.", "Политехнический колледж");
            result = cInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

		/// <summary>
		/// Замена корректными данными всех полей таблицы, при условии, что наименование ВУЗа уже есть в таблице
		/// </summary>
		[TestMethod]
        public void Task_615_5()
        {

            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.",
				"Костромской Государственный Университет");

			bool result = cInstitute.Insert(T_Institute);
			Assert.IsTrue(result);

			T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Киприна Ю.Л.", "Костромской Государственный Университет");

            result = cInstitute.Update(T_Institute);
            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }
    }
}
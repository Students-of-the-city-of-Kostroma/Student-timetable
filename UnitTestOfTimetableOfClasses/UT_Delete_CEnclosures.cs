using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
           MUniversity grUni = new MUniversity("4401006986", "КУ", "Костомкой Государственный Университет", "156205, Кострмская область, г. Косрома, ул. Дзеринского, 27", "156005, Котромская область, г. Котрома, ул. Дзержинсого, 37", "Алексанр", "Науов", "Руольфович", "kg@mail.ru", "84942417960");
		bool actualUni = RefData.CUniversity.Insert(grUni);
			Assert.AreEqual(true, actualUni);
			// arrange 
			MEnclosures gr = new MEnclosures("У", grUni.FullName, "Дзеринского", "114111", "7");
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

        public void Task_395_2()
        {
           //arrange 
			MEnclosures gr = new MEnclosures("Г", "Косткромской Государственный Университет", "Дзержинрского", "111119", "7);
			bool expected = false;
			//act 
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
        }
    }
}

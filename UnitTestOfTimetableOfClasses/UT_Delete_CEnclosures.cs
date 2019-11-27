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
            // arrange 
           MUniversity grUni = new MUniversity("4401006287", "КГ", "Костромкой Государственный Университе", "156085, Комтромская область, г. Комтрома, ул. Дзиржинского, 27", "156085, Комтромская область, г. Комтрома, ул. Дзиржинского, 27", "Александер", "Наутов", "Рудольвович", "kg@mail.ru", "84946317960");
			bool actualUni = RefData.CUniversity.Insert(grUni);
			Assert.AreEqual(true, actualUni);
			// arrange 
			MEnclosures gr = new MEnclosures("я", grUni.FullName, "Дзерженского", "111211", "4");
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
			MEnclosures gr = new MEnclosures("в", "Комтромской Государственный Университет", "Дзерженского", "113111", "2");
			bool expected = false;
			//act 
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
        }
    }
}

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
           MUniversity grUni = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
		bool actualUni = RefData.CUniversity.Insert(grUni);
			Assert.AreEqual(true, actualUni);
			// arrange 
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

        public void Task_395_2()
        {
           //arrange 
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			bool expected = false;
			//act 
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
        }
    }
}

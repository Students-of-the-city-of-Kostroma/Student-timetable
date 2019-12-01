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
			MUniversity grUni = new MUniversity("4551006286", "НДВ", "Кострумкой Госудьрственный Унивеьситет", "176005, Кострьмская облаьть, р. Костьома, пл. Дзебжинского, 27", "156505, Кострьмская оьласть, р. Коьтрома, пл. Дзержьнского, 47", "Альксандр", "Наьмов", "Руьольфович", "ktu@mail.ru", "84992317960");
			bool actualUni = RefData.CUniversity.Insert(grUni);
			Assert.AreEqual(true, actualUni);
			// arrange 
			MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзербинского", "111121", "8");
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
			MEnclosures gr = new MEnclosures("М", "Костбомской Госбдарственный Университет", "Дзержбнского", "115111", "4");
			bool expected = false;
			//act 
			bool actual = RefData.CEnclosures.Delete(gr);
			//assert 
			Assert.AreEqual(expected, actual);
		}
    }
}

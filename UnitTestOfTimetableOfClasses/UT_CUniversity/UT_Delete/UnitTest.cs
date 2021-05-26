using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CUniversity.UT_Delete
{
    [TestClass]
    public class UT_DCUniversity
    {
        RefData refData = new RefData();
        [TestMethod]
        public void DCUniversity_1() //удаление существующего вуза
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool expected = true;
            //act 
            refData.CUniversity.Insert(gr);
            bool actual = refData.CUniversity.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DCUniversity_2() //удаление не существующего вуза
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool expected = false;
            //act 
            bool actual = refData.CUniversity.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

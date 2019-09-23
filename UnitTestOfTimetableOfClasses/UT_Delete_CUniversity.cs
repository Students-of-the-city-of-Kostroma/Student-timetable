using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CUniversity
    {
        [TestMethod]
        public void Task_498_1() //удаление существующего вуза
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ" , "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool expected = true;
            //act 
            RefData.CUniversity.Insert(gr);
            bool actual = RefData.CUniversity.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task_498_2() //удаление не существующего вуза
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool expected = false;
            //act 
            bool actual = RefData.CUniversity.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CInstitute
    {
        [TestMethod]
        public void Task_513_1()
        {
            //arrange
            MInstitute i = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.");
            MInstitute i1 = new MInstitute("Факультет Автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.");
            CInstitute I = new CInstitute();
            I.Insert(i);
            I.Insert(i1);
            bool ex = true;
            //act
            i1.fullname = "Институт Автоматизированных систем и технологий";
            i1.shortname = "ИАСТ";
            i1.director = "Лустгартен Ю.Л.";
            bool act = I.Update(i1);
            //assert
            Assert.AreEqual(ex, act);

        }
    }
}

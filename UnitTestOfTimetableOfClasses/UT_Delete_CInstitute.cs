using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CInstitute
    {
        [TestMethod]
        public void Task_513_1()
        {
            //arrange
            Controllers.CInstitute.Select().Clear();
            MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.");
            bool ex = true;
            //act
            Controllers.CInstitute.Insert(I_IInstitute);
            bool act = Controllers.CInstitute.Delete(I_IInstitute);
            //assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void task_513_2()
        {
            //arrange
            Controllers.CTitle.Select().Clear();
            //act
            MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.");
            bool ex = false;
            bool act = Controllers.CInstitute.Delete(I_IInstitute);
            //assert
            Assert.AreEqual(ex, act);
        }
    }
}

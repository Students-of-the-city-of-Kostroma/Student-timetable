//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using LibOfTimetableOfClasses;

//namespace UnitTestOfTimetableOfClasses
//{
//    [TestClass]
//    public class UT_Delete_CInstitute
//    {
//        [TestMethod]
//        public void Task_513_1()
//        {
//            //arrange
//            Controllers.CInstitute.Select().Clear();
//            MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.");
//            bool ex = true;
//            CInstitute I_I = new CInstitute();
//            I_I.Insert(I_IInstitute);
//            bool act = I_I.Delete(I_IInstitute);
//            //assert
//            Assert.AreEqual(ex, act);
//        }

//        [TestMethod]
//        public void task_513_2()
//        {
//            //arrange
//            MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.");
//            bool ex = false;
//            CInstitute I_I = new CInstitute();
//            bool act = I_I.Delete(I_IInstitute);
//            //assert
//            Assert.AreEqual(ex, act);
//        }
//    }
//}

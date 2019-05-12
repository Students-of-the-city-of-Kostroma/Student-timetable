using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;



namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CInstitute
	{
		[TestMethod]
		public void Task_483_1() //Добавление в пустую таблицу	
		{
			//arrange 	
			Controllers.CInstitute.Select().Clear();
			MInstitute inst = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.", "КГУ");
			bool expected = true;
			//act	
			bool actual = Controllers.CInstitute.Insert(inst);
			//assert	
			Assert.AreEqual(expected, actual);
		}

        [TestMethod]
        public void Task_483_2()
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("ИАСТ", "Институт Неавтоматизированных систем и технологий", "Голубева Ю.А.", "КГУ");
            int C1 = Controllers.CInstitute.Select().Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_483_3()
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("ФАСТ", "Институт Автоматизированных систем и технологий", "Голубева Ю.А.", "КГУ");
            int C1 = Controllers.CInstitute.Select().Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_483_4()
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("ФАСТ", "Институт Неавтоматизированных систем и технологий", "Лустгартен Ю.Л.", "КГУ");
            int C1 = Controllers.CInstitute.Select().Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }
}




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
			Controllers.CInstitute.Clear();
			MInstitute inst = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");
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
            MInstitute T_Institute = new MInstitute("Институт Неавтоматизированных систем и технологий", "ИАСТ", "Голубева Ю.А.", "КГУ");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_483_3()
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт Автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "КГУ");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_483_4()
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт Неавтоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "КГУ");
            int C1 = Controllers.CInstitute.Rows.Count;
            act = Controllers.CInstitute.Delete(T_Institute);
            int C2 = Controllers.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }

}




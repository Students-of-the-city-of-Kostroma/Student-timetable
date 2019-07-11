using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;



namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CInstitute
	{
		[TestMethod]
		public void Task_616_1() //Добавление в пустую таблицу	
		{
			//arrange 	
			RefData.CInstitute.Clear();
			MInstitute inst = new MInstitute("Институт автоматизирован", "ИАСТ", RefData.CTeacher.Rows[0].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[0].ItemArray[2].ToString());
			bool expected = true;
			//act	
			bool actual = RefData.CInstitute.Insert(inst);
			//assert	
			Assert.AreEqual(expected, actual);
		}

        [TestMethod]
        public void Task_616_2() //краткое название дублируется
		{
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматиз", "ИАСТ", RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
            act = RefData.CInstitute.Delete(T_Institute);
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_616_3() // полное название дублируется
		{
			bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт автоматизирован", "ФАСТ",
				RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
            act = RefData.CInstitute.Delete(T_Institute);
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_616_4() // директор дублируется
        {
			bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ",
				RefData.CTeacher.Rows[0].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
            act = RefData.CInstitute.Delete(T_Institute);
            Assert.AreEqual(ex, act);
        }

		[TestMethod]
		public void Task_616_5() // наименование ВУЗа дублируется
		{
			bool ex = false;
			bool act;
			MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", 
				RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[0].ItemArray[2].ToString());
			act = RefData.CInstitute.Delete(T_Institute);
			Assert.AreEqual(ex, act);
		}
	}

}




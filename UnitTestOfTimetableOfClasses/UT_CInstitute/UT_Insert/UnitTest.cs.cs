using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_ICInstitute
    {
        RefData refData = new RefData();
        [TestMethod]
        public void CInstitute_1() //Добавление в пустую таблицу    
        {
            //arrange     
            MInstitute inst = new MInstitute("Институт автоматизирован", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");
            bool expected = true;
            //act    
            bool actual = refData.CInstitute.Insert(inst);
            //assert    
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CInstitute_2() //краткое название дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматиз", "ИАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void CInstitute_3() // полное название дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт автоматизирован", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void CInstitute_4() // директор дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "Тюменский Государственный Университет");
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void CInstitute_5() // наименование ВУЗа дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }

}




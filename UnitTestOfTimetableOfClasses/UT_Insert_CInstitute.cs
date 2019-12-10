﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CInstitute
    {
        [TestMethod]
        public void Task_616_1() //Добавление в пустую таблицу    
        {
            //arrange     
            MInstitute inst = new MInstitute("Институт автоматизирован", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");
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
            MInstitute T_Institute = new MInstitute("Институт неавтоматиз", "ИАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = RefData.CInstitute.Rows.Count;
            act = RefData.CInstitute.Insert(T_Institute);
            int C2 = RefData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_616_3() // полное название дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт автоматизирован", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = RefData.CInstitute.Rows.Count;
            act = RefData.CInstitute.Insert(T_Institute);
            int C2 = RefData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_616_4() // директор дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "Тюменский Государственный Университет");
            int C1 = RefData.CInstitute.Rows.Count;
            act = RefData.CInstitute.Insert(T_Institute);
            int C2 = RefData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        [TestMethod]
        public void Task_616_5() // наименование ВУЗа дублируется
        {
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");
            int C1 = RefData.CInstitute.Rows.Count;
            act = RefData.CInstitute.Insert(T_Institute);
            int C2 = RefData.CInstitute.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }

}




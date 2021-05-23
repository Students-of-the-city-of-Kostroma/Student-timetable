using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CInstitute
    {
        RefData refData = new RefData();

        /// <summary>
        /// Добавление в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_616_1()
        {
            //arrange     
            MInstitute inst = new MInstitute("Институт автоматизирован", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");
            bool expected = true;

            //act    
            bool actual = refData.CInstitute.Insert(inst);

            //assert    
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Краткое название дублируется
        /// </summary>
        [TestMethod]
        public void Task_616_2()
        {
            //arrange 
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматиз", "ИАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");

            //act
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;

            //assert
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        /// <summary>
        /// Полное название дублируется
        /// </summary>
        [TestMethod]
        public void Task_616_3()
        {
            //arrange 
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт автоматизирован", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");

            //act
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;

            //assert
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        /// <summary>
        /// Директор дублируется
        /// </summary>
        [TestMethod]
        public void Task_616_4()
        {
            //arrange
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Лустгартен Ю.Л.", "Тюменский Государственный Университет");

            //act
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;

            //assert
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }

        /// <summary>
        /// Наименование ВУЗа дублируется
        /// </summary>
        [TestMethod]
        public void Task_616_5()
        {
            //arrange
            bool ex = false;
            bool act;
            MInstitute T_Institute = new MInstitute("Институт неавтоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Костромской Государственный Университет");

            //act
            int C1 = refData.CInstitute.Rows.Count;
            act = refData.CInstitute.Insert(T_Institute);
            int C2 = refData.CInstitute.Rows.Count;

            //assert
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }

}




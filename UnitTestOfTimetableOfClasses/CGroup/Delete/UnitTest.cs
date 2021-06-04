using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;
namespace UnitTestOfTimetableOfClasses.UT_CGroup.UT_Delete
{
    [TestClass]
    public class UT_DCGroup
    {
        readonly RefData refData = new RefData();

        /// <summary>
        /// загрузка тестовых данных
        /// </summary>
        [TestInitialize]
        public void RefDataInit()
        {
            refData.InitData();
        }

        /// <summary>
        /// Удаление существующей строки 
        /// </summary>
        [TestMethod]
        public void DCGroup_1()
        {
            int countRows = refData.CGroup.Rows.Count;
            int i = 0;
            MGroup mGroup = new MGroup("17-ИСбо-1в", 2, "ИС", 2, 13, 1, 4, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(mGroup));  
            Assert.AreEqual(countRows+1, refData.CGroup.Rows.Count);
            do
            {
                Console.WriteLine(i++);
            }
            while ((refData.CGroup.Rows[countRows]) !=(refData.CGroup.Rows[i]));
            Assert.AreEqual(refData.CGroup.Rows[countRows], refData.CGroup.Rows[i]);
            Assert.IsTrue(refData.CGroup.Delete(mGroup));
        }
        /// <summary>
        /// Удаление не существующей строки 
        /// </summary>
        [TestMethod]
        public void DCGroup_2()
        {
            //arrange 
            MGroup gr = new MGroup("17-ИСбо-1в", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool expected = false;
            //act 
            bool actual = refData.CGroup.Delete(gr);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}


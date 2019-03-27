using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_CGroup
    {
        [TestMethod]
        public void task_16_1()
        {
            Controllers.CGroup.Select().Clear();
            bool ex = true;
            bool act;
            MGroup T_Group = new MGroup("17-ИСбо-2а",9);
            int C1=Controllers.CGroup.Select().Rows.Count;
            act=Controllers.CGroup.Insert(T_Group);
            int C2 = Controllers.CGroup.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1 + 1, C2);
        }
        [TestMethod]
        public void task_16_2()
        {

            task_16_1();
            bool ex = false;
            bool act;
            MGroup T_Group = new MGroup("17-ИСбо-2а", 12);
            int C1 = Controllers.CGroup.Select().Rows.Count;
            act = Controllers.CGroup.Insert(T_Group);
            int C2 = Controllers.CGroup.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
        [TestMethod]
        public void task_16_3()
        {
            task_16_1();
           

            bool ex = true;
            bool act;
            MGroup T_Group = new MGroup("18-ИДбо-3б", 9);
            int C1 = Controllers.CGroup.Select().Rows.Count;
            act = Controllers.CGroup.Insert(T_Group);
            int C2 = Controllers.CGroup.Select().Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1 + 1, C2);
        }
    }
}

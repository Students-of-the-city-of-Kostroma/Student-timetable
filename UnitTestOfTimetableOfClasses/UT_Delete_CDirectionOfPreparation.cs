using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CDirectionOfPreparation
    {
        public void Pre_condition_Del()
        {
            bool ex = true;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология",20);
            int C1 = RefData.CDirectionOfPreparation.Rows.Count;
            act = RefData.CDirectionOfPreparation.Insert(T_DirectionOfPreparation);
            int C2 = RefData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1 + 1, C2);
        }
        [TestMethod]
        public void Task_555_1()
        {
            Pre_condition_Del();
            bool ex = true;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология", 20);

            int C1 = RefData.CDirectionOfPreparation.Rows.Count;
            act = RefData.CDirectionOfPreparation.Delete(T_DirectionOfPreparation);
            int C2 = RefData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1 - 1, C2);
        }
        [TestMethod]
        public void Task_555_2()
        {
            bool ex = false;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология", 20);
            int C1 = RefData.CDirectionOfPreparation.Rows.Count;
            act = RefData.CDirectionOfPreparation.Delete(T_DirectionOfPreparation);
            int C2 = RefData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }
}

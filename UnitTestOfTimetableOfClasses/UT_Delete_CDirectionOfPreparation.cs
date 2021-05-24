using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CDirectionOfPreparation
    {
        readonly RefData refData = new RefData();
        public void Pre_condition_Del()
        {
            bool ex = false;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология", 20, "КГУ");
            int C1 = refData.CDirectionOfPreparation.Rows.Count;
            act = refData.CDirectionOfPreparation.Insert(T_DirectionOfPreparation);
            int C2 = refData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
        [TestMethod]
        public void Task_555_1()
        {
            Pre_condition_Del();
            bool ex = false;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология", 20, "КГУ");

            int C1 = refData.CDirectionOfPreparation.Rows.Count;
            act = refData.CDirectionOfPreparation.Delete(T_DirectionOfPreparation);
            int C2 = refData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
        [TestMethod]
        public void Task_555_2()
        {
            bool ex = false;
            bool act;
            MDirectionOfPreparation T_DirectionOfPreparation = new MDirectionOfPreparation("01.02.03", "Филология", 20, "КГУ");
            int C1 = refData.CDirectionOfPreparation.Rows.Count;
            act = refData.CDirectionOfPreparation.Delete(T_DirectionOfPreparation);
            int C2 = refData.CDirectionOfPreparation.Rows.Count;
            Assert.AreEqual(ex, act);
            Assert.AreEqual(C1, C2);
        }
    }
}

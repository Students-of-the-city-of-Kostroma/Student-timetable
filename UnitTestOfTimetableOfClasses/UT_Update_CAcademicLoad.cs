using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CAcademicLoad
    {
        /// <summary>
        /// Ввод коректных данных
        /// </summary>
        [TestMethod]
        public void Task_1245_1()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //bool expected = true;
            //act
            //PreMa.Discipline = "Операционные системы";
            //bool actual = RefData.CAcademicLoad.Update(PreMa);
            //assert
            //Assert.AreEqual(expected, actual);
        }
    }
}

using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CAcademicDegree.UT_Update
{
    [TestClass]
    public class UT_UCAcademicDegree
    {
        RefData refData = new RefData();
        /// <summary>
        /// Замена корректными данными только в поле атрибута "Сокращённая запись учёной степени"
        /// </summary>
        [TestMethod]
        public void UCAcademicDegree_1()
        {
            //arrange 
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            refData.CAcademicDegree.Insert(MAcademic);
            bool ex = false;

            //act
            MAcademic.Reduction = "Бак.";
            bool act = refData.CAcademicDegree.Update(MAcademic);

            //assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// Замена корректными данными всех полей таблицы
        /// </summary>
        [TestMethod]
        public void UCAcademicDegree_2()
        {
            //arrange
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            refData.CAcademicDegree.Insert(MAcademic);
            bool ex = true;

            //act
            MAcademic.FullName = "Бакалавр";
            MAcademic.Reduction = "Маг.";
            bool act = refData.CAcademicDegree.Update(MAcademic);

            //assert
            Assert.AreEqual(ex, act);
        }
        /// <summary>
        /// Замена всех полей пустыми строками
        /// </summary>
        [TestMethod]
        public void UCAcademicDegree_3()
        {
            //arrange
            MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            refData.CAcademicDegree.Insert(MAcademic);
            bool ex = false;

            //act
            MAcademic.FullName = null;
            MAcademic.Reduction = null;
            bool act = refData.CAcademicDegree.Update(MAcademic);

            //assert
            Assert.AreEqual(ex, act);
        }
    }
}

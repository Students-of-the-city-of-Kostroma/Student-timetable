using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.TypesOfOccupations.Delete
{
    [TestClass]
    public class UT_DCTypesOfOccupations
    {
        RefData refData = new RefData();
        [TestMethod]
        public void DCTypesOfOccupations_1() //Удаление существующей строки 
        {
            //arrange 
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            bool expected = true;
            //act 
            CTypesOfOccupations ct = new CTypesOfOccupations();
            ct.Insert(tp);
            bool actual = ct.Delete(tp);
            //assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DCTypesOfOccupations_2() //Удаление не существующей строки 
        {
            //arrange 
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            bool expected = false;
            //act 
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool actual = ct.Delete(tp);
            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

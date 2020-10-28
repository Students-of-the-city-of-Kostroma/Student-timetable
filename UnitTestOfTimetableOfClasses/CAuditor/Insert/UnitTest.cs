using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses.Auditor.Insert
{
    [TestClass]
    public class UT_ICAuditor
    {
        RefData refData = new RefData();
        [TestMethod]
        public void ICAuditor_1() //пустая таблица
        {
            //arrange
            bool expected = true;
            //act
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool actual = ca.Insert(aud);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ICAuditor_6() //добавление записи ктороая не дублирует ни один атрибут уже имеющейся записи 
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = true;
            //act
            MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 30, "4");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ICAuditor_7() //полное дублирование всех атрибутов
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = false;
            //act
            MAuditor aud1 = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ICAuditor_2() // дбавление записи, которая не дублирует ни один атрибут кроме корпуса
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = true;
            //act
            MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 30, "5");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ICAuditor_3() // дбавление записи, которая не дублирует ни один атрибут кроме кафедры
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = true;
            //act
            MAuditor aud1 = new MAuditor("302", "каф.  Иностранных языков", 30, "4");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ICAuditor_4() // дбавление записи, которая не дублирует ни один атрибут кроме числа мест
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = true;
            //act
            MAuditor aud1 = new MAuditor("302", "каф. Дизайна", 20, "4");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ICAuditor_5() // дбавление записи, которая не дублирует ни один атрибут кроме названия
        {
            //arrange
            MAuditor aud = new MAuditor("502", "каф. Иностранных языков", 20, "5");
            CAuditor ca = new CAuditor();
            bool a = ca.Insert(aud);
            bool expected = false;
            //act
            MAuditor aud1 = new MAuditor("502", "каф. Дизайна", 20, "5");
            bool actual = ca.Insert(aud1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
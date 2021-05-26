using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_ICTypesOfOccupations
    {

        [TestMethod]
        public void CTypesOfOccupations_1() //пустая таблица
        {
            //arrange
            bool expected = true;
            //act
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool actual = ct.Insert(tp);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CTypesOfOccupations_2() //Ввод корректных данных, при условии, что полное название вида занятия совпадает с полным названием уже существующего вида занятия
        {
            //arrange
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool t = ct.Insert(tp);
            bool expected = false;
            //act
            MTypesOfOccupations tp1 = new MTypesOfOccupations("Лекция", "Лаб");
            bool actual = ct.Insert(tp1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CTypesOfOccupations_3() //Ввод корректных данных, при условии, что краткое название вида занятия дублирует краткое название уже существующего вида занятия
        {
            //arrange
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool t = ct.Insert(tp);
            bool expected = true;
            //act
            MTypesOfOccupations tp1 = new MTypesOfOccupations("Лабораторная ", "Л");
            bool actual = ct.Insert(tp1);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CTypesOfOccupations_4() //Ввод корректных данных в таблицу, при условии, что в новой записи ни один атрибут не повторяет атрибуты записей, содержащихся в таблице
        {
            //arrange
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool t = ct.Insert(tp);
            bool expected = true;
            //act
            MTypesOfOccupations tp1 = new MTypesOfOccupations("Лабораторная ", "Лаб");
            bool actual = ct.Insert(tp1);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CTypesOfOccupations_5() // Ввод корректных данных в таблицу, при условии, что в новой записи все атрибуты повторяют атрибуты записей, содержащихся в таблице
        {
            //arrange
            MTypesOfOccupations tp = new MTypesOfOccupations("Лекция", "Л");
            CTypesOfOccupations ct = new CTypesOfOccupations();
            bool t = ct.Insert(tp);
            bool expected = false;
            //act
            MTypesOfOccupations tp1 = new MTypesOfOccupations("Лекция", "Л");
            bool actual = ct.Insert(tp1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

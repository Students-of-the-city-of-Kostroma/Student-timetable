﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CTypesOfOccupation.UT_Update
{
    [TestClass]
    public class UT_UCTypesOfOccupation
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что они не дублируют других атрибутов
        /// </summary>
        [TestMethod]
        public void UCTypesOfOccupation_1()
        {
            MTypesOfOccupations t = new MTypesOfOccupations("Лекция", "л");
            MTypesOfOccupations t1 = new MTypesOfOccupations("Лабораторная", "Лаб");
            CTypesOfOccupations T = new CTypesOfOccupations();
            T.Insert(t);
            T.Insert(t1);
            bool expected = true;
            bool actual = T.Update(t1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что полное название вида занятия совпадает с уже существующим полным названием
        /// </summary>
        [TestMethod]
        public void UCTypesOfOccupation_2()
        {
            MTypesOfOccupations t = new MTypesOfOccupations("Лекция", "л");
            MTypesOfOccupations t1 = new MTypesOfOccupations("Лекция", "Лаб");
            CTypesOfOccupations T = new CTypesOfOccupations();
            T.Insert(t);
            T.Insert(t1);
            bool expected = true;
            bool actual = T.Update(t1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что краткое название вида занятия совпадает с уже существующим кратким названием вида занятия
        /// </summary>
        [TestMethod]
        public void UCTypesOfOccupation_3()
        {
            MTypesOfOccupations t = new MTypesOfOccupations("Лекция", "л");
            MTypesOfOccupations t1 = new MTypesOfOccupations("Лабораторная", "л");
            CTypesOfOccupations T = new CTypesOfOccupations();
            T.Insert(t);
            T.Insert(t1);
            bool expected = true;
            bool actual = T.Update(t1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что в изменяемой записи все атрибуты повторяют атрибуты записей, содержащихся в таблице
        /// </summary>
        [TestMethod]
        public void UCTypesOfOccupation_4()
        {
            MTypesOfOccupations t = new MTypesOfOccupations("Лекция", "л");
            MTypesOfOccupations t1 = new MTypesOfOccupations("Лекция", "л");
            CTypesOfOccupations T = new CTypesOfOccupations();
            T.Insert(t);
            T.Insert(t1);
            bool expected = true;
            bool actual = T.Update(t1);
            Assert.AreEqual(expected, actual);
        }
    }
}

﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CEnclosures.UT_Insert
{
    [TestClass]
    public class UT_ICEnclosures
    {
        readonly RefData refData = new RefData();
        
        /// <summary>
        /// Подгружает тестовые данные
        /// </summary>
        [TestInitialize]
        public void RefDataInit()
        {
            refData.InitData();
        }
        
        /// <summary>
        /// Ввод в пустую таблицу
        /// </summary>
        [TestMethod]
        public void ICEnclosures_1()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            //act
            bool actual = refData.CEnclosures.Insert(gr);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
        }
        /// <summary>
        /// Дублирование адреса
        /// </summary>
		[TestMethod]
        public void ICEnclosures_2()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Малышковская", "111111", "1");
            bool expected = false;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Малышковская", "111121", "2");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование телефона
        /// </summary>
        [TestMethod]
        public void ICEnclosures_3()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111111", "2");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование примечания
        /// </summary>
        [TestMethod]
        public void ICEnclosures_4()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111121", "1");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование корпуса и ВУЗа
        /// </summary>
        [TestMethod]
        public void ICEnclosures_6()
        {
            //arrange
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Полностью отличные атрибуты
        /// </summary>
        [TestMethod]
        public void ICEnclosures_5()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование Корпуса
        /// </summary>
        [TestMethod]
        public void ICEnclosures_7()
        {
            //arrange
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование ВУЗа
        /// </summary>
        [TestMethod]
        public void ICEnclosures_8()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            refData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = refData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            refData.CEnclosures.Delete(gr);
            refData.CEnclosures.Delete(gr1);
        }
    }
}
            

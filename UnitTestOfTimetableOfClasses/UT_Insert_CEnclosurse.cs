using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CEnclosurse
    {
        /// <summary>
        /// Ввод в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_397_1()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            //act
            bool actual = RefData.CEnclosures.Insert(gr);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
        }
        /// <summary>
        /// Дублирование адреса
        /// </summary>
		[TestMethod]
        public void Task_397_2()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Малышковская", "111111", "1");
            bool expected = false;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Малышковская", "111121", "2");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование телефона
        /// </summary>
        [TestMethod]
        public void Task_397_3()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111111", "2");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование примечания
        /// </summary>
        [TestMethod]
        public void Task_397_4()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Ивановская", "111121", "1");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование корпуса и ВУЗа
        /// </summary>
        [TestMethod]
        public void Task_397_6()
        {
            //arrange
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Полностью отличные атрибуты
        /// </summary>
        [TestMethod]
        public void Task_397_5()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование Корпуса
        /// </summary>
        [TestMethod]
        public void Task_397_7()
        {
            //arrange
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = false;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Дублирование ВУЗа
        /// </summary>
        [TestMethod]
        public void Task_397_8()
        {
            //arrange
            MEnclosures gr = new MEnclosures("В", "Ярославский Государственный Университет", "Дзержинского", "111111", "1");
            bool expected = true;
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("Г", "Ярославский Государственный Университет", "Дзержинск", "222222", "2");
            bool actual = RefData.CEnclosures.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
        /// <summary>
        /// Ввод в поле телефон букв
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_397_9()
        {
            //arrange
            MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "аааааа", "1");
            RefData.CEnclosures.Insert(gr);
            //act
            MEnclosures gr1 = new MEnclosures("А", "Ярославский Государственный Университет", "Дзержинского", "аааааа", "1");
            //assert
            RefData.CEnclosures.Delete(gr);
            RefData.CEnclosures.Delete(gr1);
        }
    }
}
            

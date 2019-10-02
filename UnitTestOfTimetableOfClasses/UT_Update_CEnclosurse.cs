using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CEnclosurse
    {
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров (кроме основных полей)
        /// </summary>
        [TestMethod]
        public void Task_396_1()
        {
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool result = RefData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act
            gr.Address = "Ивановская";
            gr.Phone = "222222";
            gr.Comment = "2";
            bool actual = RefData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = RefData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Адрес дублирует Адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_2()
        {
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool result = RefData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act
            MEnclosures gr1 = new MEnclosures("И", "Костромской Государственный Университет", "Ивановская", "222222", "2");
            result = RefData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);

            gr.Address = "Ивановская";
            bool actual = RefData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            result = RefData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Телефон дублирует Телефон существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_3()
        {
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool result = RefData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act
            MEnclosures gr1 = new MEnclosures("И", "Костромской Государственный Университет", "Ивановская", "222222", "2");
            result = RefData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);

            gr.Phone = "222222";
            bool actual = RefData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = RefData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Примечание дублирует Примечание существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_4()
        {
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
            bool result = RefData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);

            bool expected = true;
            //act
            MEnclosures gr1 = new MEnclosures("И", "Костромской Государственный Университет", "Ивановская", "222222", "2");
            result = RefData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);
            gr.Comment = "2";
            bool actual = RefData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = RefData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
        }
    }
}

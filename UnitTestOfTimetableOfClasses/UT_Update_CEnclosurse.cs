﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CEnclosurse
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров (кроме основных полей)
        /// </summary>
        [TestMethod]
        public void Task_396_1()
        {
            MUniversity university = new MUniversity("4401026216", "МГУ", "Московский Государственный Университет", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "mgu@mail.ru", "84942217960");
            bool actualUni = refData.CUniversity.Insert(university);
            Assert.AreEqual(true, actualUni);

            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Московский Государственный Университет", "Дзержинского", "111111", "1");
            bool result = refData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act
            gr.Address = "Ивановская";
            gr.Phone = "222222";
            gr.Comment = "2";
            bool actual = refData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = refData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);
            result = refData.CUniversity.Delete(university);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Адрес дублирует Адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_2()
        {
            MUniversity university = new MUniversity("4401026216", "МГУ", "Московский Государственный Университет", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "mgu@mail.ru", "84942217960");
            bool actualUni = refData.CUniversity.Insert(university);
            Assert.AreEqual(true, actualUni);
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Московский Государственный Университет", "Дзержинского", "111111", "1");
            bool result = refData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act
            MEnclosures gr1 = new MEnclosures("И", "Московский Государственный Университет", "Ивановская", "222222", "2");
            result = refData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);

            gr.Address = "Ивановская";
            bool actual = refData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            result = refData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
            result = refData.CUniversity.Delete(university);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Телефон дублирует Телефон существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_3()
        {
            MUniversity university = new MUniversity("4401026216", "МГУ", "Московский Государственный Университет", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "mgu@mail.ru", "84942217960");
            bool actualUni = refData.CUniversity.Insert(university);
            Assert.AreEqual(true, actualUni);
            //arrange
            MEnclosures gr = new MEnclosures("Ж", "Московский Государственный Университет", "Дзержинского", "111111", "1");
            bool result = refData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act
            MEnclosures gr1 = new MEnclosures("И", "Московский Государственный Университет", "Ивановская", "222222", "2");
            result = refData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);

            gr.Phone = "222222";
            bool actual = refData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = refData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
            result = refData.CUniversity.Delete(university);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Примечание дублирует Примечание существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_396_4()
        {
            MUniversity university = new MUniversity("4401026216", "МГУ", "Московский Государственный Университет", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "156005, Московская область, г. Москва, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "mgu@mail.ru", "84942217960");
            bool actualUni = refData.CUniversity.Insert(university);
            Assert.AreEqual(true, actualUni);
            //arrange
            MEnclosures gr = new MEnclosures("Э", "Московский Государственный Университет", "Дзержинского", "111111", "1");
            bool result = refData.CEnclosures.Insert(gr);
            Assert.IsTrue(result);

            bool expected = true;
            //act
            MEnclosures gr1 = new MEnclosures("Ю", "Московский Государственный Университет", "Ивановская", "222222", "2");
            result = refData.CEnclosures.Insert(gr1);
            Assert.IsTrue(result);
            gr.Comment = "2";
            bool actual = refData.CEnclosures.Update(gr);
            //assert
            Assert.AreEqual(expected, actual);
            //cleare data
            result = refData.CEnclosures.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CEnclosures.Delete(gr1);
            Assert.IsTrue(result);
            result = refData.CUniversity.Delete(university);
            Assert.IsTrue(result);
        }
    }
}

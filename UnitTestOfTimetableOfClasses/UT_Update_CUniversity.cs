using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CUniversity
    {
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров 
        /// </summary>
        [TestMethod]
        public void Task_497_1()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006285", "МГУ", "Московский Государственный Университет", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "Виктор", "Садовничий", "Антонович", "infor@msu.edu.ru", "84942317961");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006211", "КГТУ", "Костромской Государственный Технический Университет", "156005, Костромская область, г. Костромушка.", "156005, Костромская область, г. Костромушка.", "Александр", "Наумов", "Сергеевич", "informacia@ksu.edu.ru", "84959391244");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = true;

            //act 
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Краткое название дублирует Краткое название существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_2()//дублирование краткого названия
        {
            // arrange
            MUniversity gr = new MUniversity("4401006285", "МГУ", "Московский Государственный Университет", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "Виктор", "Садовничий", "Антонович", "infor@msu.edu.ru", "84942317961");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401156256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "wkgtu@mail.ru", "84942327960");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = true;
            //act 
            gr1.ShortName = "КГУ";
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);

        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Полное название дублирует Полное название существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_3()//дублирование полного названия
        {
            string fullName = "Костромкой Государственный Университет";
            // arrange
            MUniversity gr = new MUniversity("4401022286", "КГУ", fullName, "156002, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgb@mail.ru", "84942312960");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = false;
            //act 
            gr1.FullName = fullName;
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Фактический адрес дублирует Фактический адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_4()//дублирование факт. адреса
        {
            // arrange
            MUniversity gr = new MUniversity("4401006282", "КГУ", "Костромкойй Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "84942312960");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = true;
            //act 
            gr1.ActualAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Юридический адрес дублирует Юридический адрес адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_5()//дублирование юр. адреса
        {
            // arrange
            MUniversity gr = new MUniversity("4401006285", "МГУ", "Московский Государственный Университет", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "Виктор", "Садовничий", "Антонович", "infor@msu.edu.ru", "84942317961");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006251", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "wkgtu@mail.ru", "84942317962");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = true;
            //act 
            gr.LegalAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
            bool actual = RefData.CUniversity.Update(gr);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что ФИО ректора дублирует ФИО ректора адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_6()//дублирование ФИО ректора
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = RefData.CUniversity.Insert(gr);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = RefData.CUniversity.Insert(gr1);

            bool expected = true;
            //act 
            gr1.NameRector = "Александр";
            gr1.SurnameRector = "Наумов";
            gr1.MiddleNameRector = "Рудольфович";
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);


            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Почта дублирует Почта адрес существующего экземпляра(не учитывая основные атрибуты)
        /// </summary>
        [TestMethod]
        public void Task_497_7()//дублирование Почты
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = RefData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = false;
            //act 
            gr1.Email = "kgu@mail.ru";
            bool actual = RefData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);


            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = RefData.CUniversity.Delete(gr1);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Ввод данных аналогичных уже существующим
        /// </summary>
        [TestMethod]
        public void Task_496_10() //дублирование всех атрибутов
        {
            // arrange
            MUniversity gr = new MUniversity("4401006282", "КГУ", "Канадский Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "82942317960");
            bool result = RefData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401006282", "КГУ", "Канадский Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "82942317960");
            bool actual = RefData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = RefData.CUniversity.Delete(gr);
            Assert.IsTrue(result);
        }
    }
}

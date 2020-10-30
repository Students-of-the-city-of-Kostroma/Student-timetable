using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CUniversity
    {
        RefData refData = new RefData();
        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void UCUniversity_1()
        {
            refData.CUniversity.Clear();
            Assert.IsTrue(refData.CUniversity.Rows.Count == 0, "Не удалось очистить таблицу Университет");

            // arrange
            MUniversity gr = new MUniversity("4401006285", "МГУ", "Московский Государственный Университет", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "Виктор", "Садовничий", "Антонович", "infor@msu.edu.ru", "84942317961");

            //act 
            bool actual = refData.CUniversity.Update(gr);
            Assert.IsFalse(actual,"Удалось очистить таблицу Университета");
        }

        /// <summary>
        /// Изменить несуществующий университет
        /// </summary>
        [TestMethod]
        public void UCUniversity_2()
        {
            //arrange    
            MUniversity gr = new MUniversity("4401006285", "МГУ", "Московский Государственный Университет", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "119991, Москва, ГСП-1, Ленинские горы, д. 1", "Виктор", "Садовничий", "Антонович", "infor@msu.edu.ru", "84942317961");
            bool actual1 = refData.CUniversity.Insert(gr);
            Assert.AreEqual(true, actual1, "Не удалось вставить университет" + gr.FullName);
            MUniversity gr1 = new MUniversity("4401156256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "wkgtu@mail.ru", "84942327960");
            //act
            bool actual = refData.CUniversity.Update(gr1);
            //assert
            Assert.IsFalse(actual, "Удалось Изменить несуществующего преподавателя");
        }

        /// <summary>
        /// Обновление корректной строки
        /// </summary>
        [TestMethod]
        public void UCUniversity_3()//дублирование полного названия
        {
            string fullName = "Костромкой Государственный Университет";
            // arrange
            MUniversity gr = new MUniversity("4401022286", "КГУ", fullName, "156002, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgb@mail.ru", "84942312960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result, "Вставка университета "+gr.FullName+" не удалалсь.");

            //act 
            gr.Phone = "89999641203";
            bool actual = refData.CUniversity.Update(gr);

            //assert 
            Assert.IsTrue(actual, "Обновленние корректной строки не удалось.");

            result = refData.CUniversity.Delete(gr);
            Assert.IsTrue(result);
        }

        /// <summary>
        ///Обновление данных при условии, что ИНН дублирует ИНН существующего университета
        /// </summary>
        [TestMethod]
        public void UCUniversity_4()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006282", "КГУ", "Костромкойй Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "84942312960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result, "Вставка университета " + gr.FullName + " не удалалсь.");

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = refData.CUniversity.Insert(gr1);
            Assert.IsTrue(result, "Вставка университета " + gr.FullName + " не удалалсь.");

            //act 
            gr1.INN = "4401006282";
            bool actual = refData.CUniversity.Update(gr1);
            //assert 
            Assert.IsFalse(actual, "Обновление данных при условии, что ИНН дублирует ИНН существующего университета удалось.");

            result = refData.CUniversity.Delete(gr);
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
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006251", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "wkgtu@mail.ru", "84942317962");
            result = refData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = true;
            //act 
            gr.LegalAddress = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
            bool actual = refData.CUniversity.Update(gr);
            //assert 
            Assert.AreEqual(expected, actual);

            result = refData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CUniversity.Delete(gr1);
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
            bool result = refData.CUniversity.Insert(gr);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = refData.CUniversity.Insert(gr1);

            bool expected = true;
            //act 
            gr1.NameRector = "Александр";
            gr1.SurnameRector = "Наумов";
            gr1.MiddleNameRector = "Рудольфович";
            bool actual = refData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);


            result = refData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CUniversity.Delete(gr1);
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
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            MUniversity gr1 = new MUniversity("4401006256", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            result = refData.CUniversity.Insert(gr1);
            Assert.IsTrue(result);

            bool expected = false;
            //act 
            gr1.Email = "kgu@mail.ru";
            bool actual = refData.CUniversity.Update(gr1);
            //assert 
            Assert.AreEqual(expected, actual);


            result = refData.CUniversity.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CUniversity.Delete(gr1);
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
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);

            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401006282", "КГУ", "Канадский Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "82942317960");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

            result = refData.CUniversity.Delete(gr);
            Assert.IsTrue(result);
        }
    }
}

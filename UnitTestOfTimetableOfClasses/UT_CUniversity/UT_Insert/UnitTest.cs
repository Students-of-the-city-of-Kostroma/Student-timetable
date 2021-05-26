using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_ICUniversity
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод корректных данных в пустую таблицу
        /// </summary>
        [TestMethod]
        public void CUniversity_1()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool expected = true;
            //act 

            bool actual = refData.CUniversity.Insert(gr);
            //assert 
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Краткое название добавляемой группы дублирует Краткое название уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_2()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГУ", "Костромкой Государственный Технологический Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            Assert.AreEqual(true, refData.CUniversity.Delete(gr1));
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Полное название добавляемой группы дублирует Полное название уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_3()
        {
            // arrange
            MUniversity gr = new MUniversity("4401022286", "КГУ","Костромкой Государственный Технический Университет", "156002, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgb@mail.ru", "84942312960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401006256", "КГТУ","Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Фактический адрес добавляемой группы дублирует Фактический адрес уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_4()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

          
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            Assert.AreEqual(true, refData.CUniversity.Delete(gr1));
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Юридический адрес добавляемой группы дублирует Фактический адрес уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_5()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "151005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            Assert.AreEqual(true, refData.CUniversity.Delete(gr1));
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что ФИО ректора добавляемой группы дублирует ФИО ректора уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_6()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Александр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317860");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            Assert.AreEqual(true, refData.CUniversity.Delete(gr1));
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Почта добавляемой группы дублирует Почта уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_7()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Дмитрий", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317860");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);

           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
           }

        /// <summary>
        /// Ввод корректных данных, при условии, что Телефон добавляемой группы дублирует Телефон уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_8()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401015275", "КГТУ", "Костромкой Государственный Тех Университет", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "156005, Костромская область, г. Кострома, ул. Ивановская, 17", "Петр", "Наумов", "Рудольфович", "kgtu@mail.ru", "84942317960");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);
            
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что ИНН добавляемой группы дублирует ИНН уже существующей группы
        /// </summary>
        [TestMethod]
        public void CUniversity_9()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act 
            MUniversity gr1 = new MUniversity("4401006286", "КГТУ", "Костромкой Государственный Технический Университет", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "156505, Костромская область, г. Кострома, ул. Дзержинского, 35", "Леонид", "Лионидов", "Леонидович", "kgtu@mail.ru", "84942317961");
            bool actual = refData.CUniversity.Insert(gr1);
            //assert 
            Assert.AreEqual(expected, actual);
            
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            

        }

        /// <summary>
        /// Ввод данных аналогичных уже существующим
        /// </summary>
        [TestMethod]
        public void CUniversity_10()
        {
            // arrange
            MUniversity gr = new MUniversity("4401006282", "КГУ", "Канадский Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "wkgu@mail.ru", "82942317960");
            bool result = refData.CUniversity.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act 
           
            bool actual = refData.CUniversity.Insert(gr);
            //assert 
            Assert.AreEqual(expected, actual);
           
            Assert.AreEqual(true, refData.CUniversity.Delete(gr));
            

        }
    }
}

using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CTeacher
    {
        RefData refData = new RefData();
        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void Task_247_1()
        {
            //arrange    
            refData.CInstitute.Clear();
            Assert.IsTrue(refData.CInstitute.Rows.Count == 0, "Не удалось Очистить таблицу Институт");
            refData.CTeacher.Clear();
              Assert.IsTrue(refData.CTeacher.Rows.Count == 0, "Не удалось Очистить таблицу Преподаватель");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = false;
            //act
         
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual, " Удалось Изменить сведения в пустой таблице");

      
            
        }
        /// <summary>
        /// Изменить несуществующего преподавателя
        /// </summary>
        [TestMethod]
        public void Task_247_2()
        {
            Assert.IsTrue(refData.CInstitute.Rows.Count != 0, "Таблица институт пуста");
            //arrange    
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(true, actual1, "Не удалось вставить преподавателя" + tcher.FirstName);
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = false;

            //act
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual, "Удалось Изменить несуществующего преподавателя");

           
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_247_3()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
        {
            Assert.IsTrue(refData.CInstitute.Rows.Count != 0, "Таблица институт пуста");
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1, "Не удалось вставить преподавателя" + tcher.FirstName);
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2, "Не удалось вставить преподавателя" + tcher1.FirstName);
            //act
            tcher1.AcademicDegree = "ДН";
            tcher1.AcademicTitle = "Проф";
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пт";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод коректных данных, при условии, что они не дублируют данные других экземпляров не произошел");

            //cleare data
           
            Assert.IsTrue(refData.CTeacher.Delete(tcher), "Не удалось удалить преподавателя"+ tcher.FirstName);
            Assert.IsTrue(refData.CTeacher.Delete(tcher1), "Не удалось удалить преподавателя" + tcher1.FirstName);
        }
       
       
        /// <summary>
        /// Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись
        /// </summary>
        [TestMethod]
        public void Task_247_4()//дублируется всё кроме ФИО
        {
            Assert.IsTrue(refData.CInstitute.Rows.Count != 0, "Таблица институт пуста");
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1, "Не удалось вставить преподавателя" + tcher.FirstName);
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2, "Не удалось вставить преподавателя" + tcher1.FirstName);
            //act
            tcher1.AcademicDegree = "КН";
            tcher1.AcademicTitle = "Доц";
            tcher1.Departament = "ИАСТ";
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись не произошел");

            //cleare data
            Assert.IsTrue(refData.CTeacher.Delete(tcher), "Не удалось удалить преподавателя" + tcher.FirstName);
            Assert.IsTrue(refData.CTeacher.Delete(tcher1), "Не удалось удалить преподавателя" + tcher1.FirstName);
        }
    }
}

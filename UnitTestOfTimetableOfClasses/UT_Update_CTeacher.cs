using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CTeacher
    {
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_247_1()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
        {
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = "ДН";
            tcher1.AcademicTitle = "Проф";
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пт";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = RefData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = RefData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что примечание дублирует примечание существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_247_5()//дублируется уч. степень и уч. звание
        {
            //arrange
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = "КН";
            tcher1.AcademicTitle = "Доц";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = RefData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = RefData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Кафедра дублирует Кафедра существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_247_6()//дублируется кафедра 
        {
            //arrange
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.Departament = "ИАСТ";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = RefData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = RefData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_247_7()//дублируется график
        {
            //arrange
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = RefData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = RefData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись
        /// </summary>
        [TestMethod]
        public void Task_247_8()//дублируется всё кроме ФИО
        {
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = "КН";
            tcher1.AcademicTitle = "Доц";
            tcher1.Departament = "ИАСТ";
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = RefData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = RefData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
    }
}

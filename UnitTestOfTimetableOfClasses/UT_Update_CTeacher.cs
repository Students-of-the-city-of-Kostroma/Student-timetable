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
            refData.CTeacher.Clear();
            Assert.IsTrue((refData.CInstitute.Rows.Count == 0) && (refData.CTeacher.Rows.Count == 0));
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = false;
            //act
         
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

      
            
        }
        /// <summary>
        /// Изменить несуществующего преподавателя
        /// </summary>
        [TestMethod]
        public void Task_247_2()
        {
            //arrange            
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = false;

            //act
            tcher1.AcademicDegree = "ДН";
            tcher1.AcademicTitle = "Проф";
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пт";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

           
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_247_3()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
        {
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = "ДН";
            tcher1.AcademicTitle = "Проф";
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пт";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = refData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = refData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
       
       
        /// <summary>
        /// Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись
        /// </summary>
        [TestMethod]
        public void Task_247_4()//дублируется всё кроме ФИО
        {
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = "КН";
            tcher1.AcademicTitle = "Доц";
            tcher1.Departament = "ИАСТ";
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);

            //cleare data
            bool result = refData.CTeacher.Delete(tcher);
            Assert.IsTrue(result);

            result = refData.CTeacher.Delete(tcher1);
            Assert.IsTrue(result);
        }
    }
}

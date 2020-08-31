using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CTeacher
    {
        RefData refData = new RefData();
        public void setupData()
        {
            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            bool actual1 = refData.CAcademicDegree.Insert(mAcademicDegree);
            MAcademicDegree mAcademicDegree2 = new MAcademicDegree("Доктор наук", "ДН");
            bool actual2 = refData.CAcademicDegree.Insert(mAcademicDegree2);
            MTitle mTitle = new MTitle("Доцент", "Доц");
            bool actual3 = refData.CTitle.Insert(mTitle);
            MTitle mTitle2 = new MTitle("Профессор", "Проф");
            bool actual4 = refData.CTitle.Insert(mTitle2);
        }
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
            Assert.IsFalse( actual, " Удалось Изменить сведения в пустой таблице");

      
            
        }
        /// <summary>
        /// Изменить несуществующего преподавателя
        /// </summary>
        [TestMethod]
        public void Task_247_2()
        {
            setupData();
            refData.CInstitute.Clear();
            Assert.IsTrue(refData.CInstitute.Rows.Count == 0, "Не удалось Очистить таблицу Институт");
            //arrange    
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(true, actual1, "Не удалось вставить преподавателя" + tcher.FirstName);
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            //act
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.IsFalse(actual, "Удалось Изменить несуществующего преподавателя");

           
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_247_3()
        {
            setupData();
            refData.CInstitute.Clear();
            Assert.IsTrue(refData.CInstitute.Rows.Count == 0, "Не удалось Очистить таблицу Институт");
            //arrange            
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "Доц", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
      
            bool expected = true;
            bool actual1 = refData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1, "Не удалось вставить преподавателя" + tcher.FirstName);

            //act
            tcher.AcademicDegree = "ДН";
            tcher.AcademicTitle = "Проф";
            tcher.Departament = "ИФМЕН";
            tcher.MetodicalDays = "Вс";
            tcher.Windows = "Ср, Чт";
            tcher.Weekends = "Пт";
            bool actual = refData.CTeacher.Update(tcher);
            //assert
            Assert.AreEqual(expected, actual, "Ввод коректных данных, при условии, что они не дублируют данные других экземпляров не произошел");
            //clear data
            Assert.IsTrue(refData.CTeacher.Delete(tcher), "Не удалось удалить преподавателя"+ tcher.FirstName);
    
        }


        /// <summary>
        /// Ввод корректных данных, при условии, что вводимая ученая степень преподавателя не существует
        /// </summary>
        [TestMethod]
        public void Task_247_4()
        {
            setupData();
            //arrange            
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2, "Не удалось вставить преподавателя" + tcher1.FirstName);
            //act
            tcher1.AcademicDegree = "П";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.IsFalse(actual, "Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись не произошел");
            //clear data
            Assert.IsTrue(refData.CTeacher.Delete(tcher1), "Не удалось удалить преподавателя" + tcher1.FirstName);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что вводимое ученое звание преподавателя не существует
        /// </summary>
        [TestMethod]
        public void Task_247_5()
        {
            setupData();
            //arrange            
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "КН", "Доц", "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual2 = refData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2, "Не удалось вставить преподавателя" + tcher1.FirstName);
            //act
            tcher1.AcademicTitle = "П";
            bool actual = refData.CTeacher.Update(tcher1);
            //assert
            Assert.IsFalse(actual, "Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись не произошел");
            //clear data
            Assert.IsTrue(refData.CTeacher.Delete(tcher1), "Не удалось удалить преподавателя" + tcher1.FirstName);
        }
    }
}

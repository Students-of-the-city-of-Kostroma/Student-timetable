    /// <summary>
    /// Тестирование метода Delete сущности Преподаватель
    /// </summary>
    /// <param name="">текст</param>
    /// <returns>текст</returns>
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_DСTeacher                    
    /// <summary>
    /// Тестирование метода Delete сущности Преподаватель
    /// </summary>
    /// <param name="">текст</param>
    /// <returns>текст</returns>
    {                   
        readonly RefData refData = new RefData();
        [TestMethod]    
        public void DCTeacher_1() /// Удаление сведений в пустой таблице преподавателей
        {               
            Assert.AreEqual(refData.CTeacher.Rows.Count == 0, true, "При проверке отсутствия записей в таблице преподавателей, она оказалась не пустой"); 
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Delete(tcher), false, "Преподаватель был удалён, не смотря на то, что таблица преподавателей пуста");
        } 

        [TestMethod]         
        public void DCTeacher_2() /// Попытка удалить преподавателя при несовпадающих значениях фамилии
        {            

            MAcademicDegree mad = new MAcademicDegree ("Кандидат наук","КН");
            Assert.AreEqual(refData.CAcademicDegree.Insert(mad), true, "При попытке добавить учёную степень в таблицу с учёными степенями она не была добавлена");
            MTitle mt = new MTitle("Профессор", "ПР");
            Assert.AreEqual(refData.CTitle.Insert(mt), true, "При попытке добавить должность в таблицу должностей она не была добавлена");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "ПР", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Insert(tcher), true, "При попытке добавить преподавателя в таблицу с преподавателями он не был добавлен");
            MTeacher tcher2 = new MTeacher("Прядкина", "Ольга", "Борисовна", "КН", "ПР", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Delete(tcher2), false, "Преподаватель был удалён, не смотря на то, что фамилии не совпадают");
        }

        [TestMethod]            
        public void DCTeacher_3() /// Попытка удалить преподавателя при несовпадающих значениях института
        {                     
            MAcademicDegree mad = new MAcademicDegree("Кандидат наук", "КН");
            Assert.AreEqual(refData.CAcademicDegree.Insert(mad), true, "При попытке добавить учёную степень в таблицу с учёными степенями она не была добавлена");
            MTitle mt = new MTitle("Профессор", "ПР");
            Assert.AreEqual(refData.CTitle.Insert(mt), true, "При попытке добавить должность в таблицу должностей она не была добавлена");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "ПР", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Insert(tcher), true, "При попытке добавить преподавателя в таблицу с преподавателями он не был добавлен");
            MTeacher tcher2 = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "ПР", "ИГНИСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Delete(tcher2), false, "Преподаватель был удалён, не смотря на то, что название институтов не совпадают");
        }

        [TestMethod]
        public void DCTeacher_4() /// Попытка удалить данные при всех совпадающих значениях
        {                      

            MAcademicDegree mad = new MAcademicDegree("Кандидат наук", "КН");
            Assert.AreEqual(refData.CAcademicDegree.Insert(mad), true, "При попытке добавить учёную степень в таблицу с учёными степенями она не была добавлена");
            MTitle mt = new MTitle("Профессор", "ПР");
            Assert.AreEqual(refData.CTitle.Insert(mt), true, "При попытке добавить должность в таблицу должностей она не была добавлена");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "ПР", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Insert(tcher), true, "При попытке добавить преподавателя в таблицу с преподавателями он не был добавлен");
            MTeacher tcher2 = new MTeacher("Садовская", "Ольга", "Борисовна", "КН", "ПР", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            Assert.AreEqual(refData.CTeacher.Delete(tcher2), true, "Преподаватель не был удалён, не смотря на то, что все поля совпадают");
        }
    }
}

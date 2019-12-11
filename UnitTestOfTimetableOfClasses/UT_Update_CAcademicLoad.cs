using System.Threading;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CAcademicLoad
    {
        /// <summary>
        /// Ввод коректных данных
        /// </summary>
        [TestMethod]
        public void Task_1245_1()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            bool expected = true;
            //act
            PreMa.Discipline = "Операционные системы";
            PreMa.Distributed = "30";
            PreMa.Occupation = "Практическая работа";
            PreMa.Teacher = "Аристархов Валерий Аристархович";
            PreMa.TotalHours = "120";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Дисциплина
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_2()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-НОбо-1а", "110", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //act
            PreMa.Discipline = "1";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Распределено
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_3()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Нбо-1а", "110", "Web-программирование", "Иванов Иван Иванович", "Лр", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //act
            PreMa.Distributed = "двадцать";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Вид занятия
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_4()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ПИбо-4а", "110", "Управление данными", "Прядкина Нина Олеговна", "Контрольная работа", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //act
            PreMa.Occupation = "1";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Учитель
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_5()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Ебо-4а", "110", "3D-моделирование", "Дорохова Жанна Викторовна", "Лабараторная работа", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //act
            PreMa.Teacher = "1";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Всего часов
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_6()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ЕДбо-4а", "110", "Инструменты графического дизайна", "Барило Илья Иванович", "Кр", "20");
            bool actualPreMa = RefData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa);
            //act
            PreMa.TotalHours = "Сто";
            bool actual = RefData.CAcademicLoad.Update(PreMa);
        }
    }
}
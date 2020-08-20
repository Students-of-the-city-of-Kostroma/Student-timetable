using System.Threading;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CAcademicLoad
    {
        RefData refData = new RefData();

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void Task_1245_1()
        {
            //arrange
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count == 0, "Не удалось Очистить таблицу нагрузка");
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool expected = false;
            //act

            bool actual = refData.CAcademicLoad.Update(PreMa);
            //assert
            Assert.AreEqual(expected, actual, "Удалось изменить сведения в пустой таблице");
        }
        /// <summary>
        /// Изменить несуществующую группу в заполненной таблице
        /// </summary>
        [TestMethod]
        public void Task_1245_2()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);
            MAcademicLoad PreMa1 = new MAcademicLoad("17-Нбо-1а", "110", "Программирование", "Иванов Иван Иванович", "Лр", "20");
            bool expected = false;
            //act
            
            bool actual = refData.CAcademicLoad.Update(PreMa1);
            //assert
            Assert.AreEqual(expected, actual, " Удалось изменить несуществующую группу в заполненной таблице");
        }
        /// <summary>
        /// Ввод коректных данных
        /// </summary>
        [TestMethod]
        public void Task_1245_3()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для "+PreMa.Group);
            bool expected = true;
            //act
            bool actual = refData.CAcademicLoad.Update(PreMa);
            //assert
            Assert.AreEqual(expected, actual, " Ввод коректных данных не произошел");
        }

        /// <summary>
        /// Атрибут "Группа" дублирует уже существующий атрибут "Группа" 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_4()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Ебо-4а", "110", "3D-моделирование", "Дорохова Жанна Викторовна", "Лабараторная работа", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " +PreMa.Group);
            bool expected = false;
            //act
            PreMa.Group = "17-Ебо-4а";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод группы, дублирующей другую группу");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут Дисциплина
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_5()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Ебо-4а", "110", "3D-моделирование", "Дорохова Жанна Викторовна", "Лабараторная работа", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);
            bool expected = false;
            //act
            PreMa.Discipline = "Цукенгшщзх";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод не коректных данных в атрибут Дисциплина");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут преподаватель
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_6()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Ебо-4а", "110", "3D-моделирование", "Дорохова Жанна Викторовна", "Лабараторная работа", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);
            bool expected = false;
            //act
            PreMa.Teacher = "Цукеке Укее Уке";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод не коректных данных в атрибут преподаватель");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут тип занятия
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Task_1245_7()
        {
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-Ебо-4а", "110", "3D-моделирование", "Дорохова Жанна Викторовна", "Лабараторная работа", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa,  "Не удалось вставить нагрузку для " + PreMa.Group);
            bool expected = false;
            //act
            PreMa.Occupation = "Фуаываываыв";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, " Произошел ввод не коректных данных в атрибут тип занятия ");
        }

    }
}
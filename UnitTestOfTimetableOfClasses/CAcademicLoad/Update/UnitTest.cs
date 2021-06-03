using System.Threading;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CAcademicLoad.UT_Update
{
    [TestClass]
    public class UT_UCAcademicLoad
    {
        readonly RefData refData = new RefData();

        /// <summary>
        /// Загрузка тестовых данных
        /// </summary>
        [TestInitialize]
        public void RefDataInit()
        {
            refData.InitData();
        }

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_1()
        {
            refData.CCourseSchedule.Clear();
            refData.CAcademicLoad.Clear();
            //arrange
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count == 0, "Таблица нагрузки не пуста!");
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "20", "Правоведение", "Иванов Иван Иванович", "Лекция", "1");
            bool expected = false;
            //act

            bool actual = refData.CAcademicLoad.Update(PreMa);
            //assert
            Assert.AreEqual(expected, actual, "Удалось изменить сведения в пустой таблице");
        }
        /// <summary>
        /// Изменить несуществующую нагрузку в заполненной таблице
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_2()
        {
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa1 = new MAcademicLoad(110,"17-Нбо-1а", "20", "Программирование", "Иванов Иван Иванович", "Лр", "1");
            bool expected = false;
            //act
            
            bool actual = refData.CAcademicLoad.Update(PreMa1);
            //assert
            Assert.AreEqual(expected, actual, " Удалось изменить несуществующую нагрузку в заполненной таблице");
        }
        /// <summary>
        /// Ввод коректных данных
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_3()
        {
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            refData.CGroup.Insert(new MGroup("17-ИСбо-2б", 3, "ИС", 1, 10, 1, 6, "Суббота"));
            MAcademicLoad PreMa = new MAcademicLoad(100, "17-ИСбо-2б", "20", "Правоведение", "Иванов Иван Иванович", "Лекция", "1");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);
            bool expected = true;
            //act
            bool actual = refData.CAcademicLoad.Update(PreMa);
            //assert
            Assert.AreEqual(expected, actual, " Ввод коректных данных не произошел");
        }
        /// <summary>
        /// Ввод не коректных данных в атрибут Дисциплина
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_4()
        {
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "20", "История", "Иванова Ивана Ивановича", "Лекция", "1");
            bool expected = false;
            //act
            PreMa.Discipline = "Цукенгшщзх";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод некорректных данных в атрибут Дисциплина");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут преподаватель
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_5()
        {
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "20", "Правоведение", "Иванова Ивана Ивановича", "Лекция","1");
            bool expected = false;
            //act
            PreMa.Teacher = "Цукеке Укее Уке";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод некорректных данных в атрибут преподаватель");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут тип занятия
        /// </summary>
        [TestMethod]
        public void UCAcademicLoad_6()
        {
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "20", "Правоведение", "Иванов Иван Иванович", "Лекция","1");
            bool expected = false;
            //act
            PreMa.Occupation = "Фуаываываыв";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, " Произошел ввод некорректных данных в атрибут тип занятия ");
        }
    }
}

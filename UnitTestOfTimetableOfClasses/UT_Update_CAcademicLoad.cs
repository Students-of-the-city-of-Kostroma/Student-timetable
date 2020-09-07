using System.Threading;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CAcademicLoad
    {
        public void setupData()
        {
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4);
            bool actualmDirectionOfPreparation = refData.CDirectionOfPreparation.Insert(mDirectionOfPreparation);
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            bool actualmTrainingProfile = refData.CTrainingProfile.Insert(mTrainingProfile);
            MGroup mGroup = new MGroup("17-ИСбо-2а", 4, "ИС", 1, 20, 2, 5, "Суббота");
            bool actualmGroup = refData.CGroup.Insert(mGroup);
            MGroup mGroup2 = new MGroup("17-ИСбо-2б", 3, "ИС", 1, 10, 1, 6, "Суббота");
            bool actualmGroup2 = refData.CGroup.Insert(mGroup2);

            MDiscipline mDiscipline1 = new MDiscipline("Правоведение", "Право", "Сентябрь-Декабрь");
            bool actuamDiscipline1 = refData.CDiscipline.Insert(mDiscipline1);

            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            bool actuamAcademicDegree = refData.CAcademicDegree.Insert(mAcademicDegree);
            MTitle mTitle = new MTitle("Доцент", "Доц");
            bool actualmTitle = refData.CTitle.Insert(mTitle);
            MTeacher mTeacher = new MTeacher("Иван", "Иванов", "Иванович", "КН", "Доц", "ИАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            bool actualamTeacher = refData.CTeacher.Insert(mTeacher);

            MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations("Лекция", "Лек");
            bool actualmTypesOfOccupations = refData.CTypesOfOccupations.Insert(mTypesOfOccupations);

            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);

        }
        RefData refData = new RefData();

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]public void Task_1245_1()
        {
            //arrange
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count == 0, "Таблица нагрузки не пуста!");
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
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
        public void Task_1245_2()
        {
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2б", "100", "Правоведение", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);
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
        public void Task_1245_4()
        {
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ПИбо-4а", "100", "История", "Иванова Ивана Ивановича", "Лекция", "20");
            bool expected = false;
            //act
            PreMa.Group = "17-ИСбо-2а";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, "Произошел ввод группы, дублирующей другую группу");
        }

        /// <summary>
        /// Ввод не коректных данных в атрибут Дисциплина
        /// </summary>
        [TestMethod]
        public void Task_1245_5()
        {
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "История", "Иванова Ивана Ивановича", "Лекция", "20");
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
        public void Task_1245_6()
        {
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "История", "Иванова Ивана Ивановича", "Лекция", "20");
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
        public void Task_1245_7()
        {
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "История", "Иванова Ивана Ивановича", "Лекция", "20");
            bool expected = false;
            //act
            PreMa.Occupation = "Фуаываываыв";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, " Произошел ввод некорректных данных в атрибут тип занятия ");
        }

    }
}
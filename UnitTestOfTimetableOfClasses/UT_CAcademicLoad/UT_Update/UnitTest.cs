using System.Threading;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CAcademicLoad.UT_Update
{
    [TestClass]
    public class UT_UCAcademicLoad
    {
        public void setupData()
        {
            MDirectionOfPreparation mDirectionOfPreparation = new MDirectionOfPreparation("09.03.02", "Информационные системы и технологии", 4, "КГУ");
            bool actualmDirectionOfPreparation = refData.CDirectionOfPreparation.Insert(mDirectionOfPreparation);
                Assert.IsTrue(actualmDirectionOfPreparation, "Не удалось вставить направление подготовки");
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Информационные системы", "ИС", "09.03.02");
            bool actualmTrainingProfile = refData.CTrainingProfile.Insert(mTrainingProfile);
                Assert.IsTrue(actualmTrainingProfile, "Не удалось вставить профиль подготовки");
            MGroup mGroup = new MGroup("17-ИСбо-2а", 4, "ИС", 1, 20, 2, 5, "Суббота");
            bool actualmGroup = refData.CGroup.Insert(mGroup);
                Assert.IsTrue(actualmGroup, "Не удалось вставить группу 1");
            MGroup mGroup2 = new MGroup("17-ИСбо-2б", 3, "ИС", 1, 10, 1, 6, "Суббота");
            bool actualmGroup2 = refData.CGroup.Insert(mGroup2);
                Assert.IsTrue(actualmGroup2, "Не удалось вставить группу 2");

            MDiscipline mDiscipline1 = new MDiscipline("Правоведение", "Право", "Сентябрь-Декабрь");
            bool actuamDiscipline1 = refData.CDiscipline.Insert(mDiscipline1);
                Assert.IsTrue(actuamDiscipline1, "Не удалось вставить дисциплину");

            MAcademicDegree mAcademicDegree = new MAcademicDegree("Кандидат наук", "КН");
            bool actuamAcademicDegree = refData.CAcademicDegree.Insert(mAcademicDegree);
                Assert.IsTrue(actuamAcademicDegree, "Не удалось вставить ученую степень");
            MTitle mTitle = new MTitle("Доцент", "Доц");
            bool actualmTitle = refData.CTitle.Insert(mTitle);
                Assert.IsTrue(actualmTitle, "Не удалось вставить ученое звание"); 
            MTeacher mTeacher = new MTeacher("Иван", "Иванов", "Иванович", "КН", "Доц", "ИАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            bool actualamTeacher = refData.CTeacher.Insert(mTeacher);
                Assert.IsTrue(actualamTeacher, "Не удалось вставить преподавателя");

            MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations("Лекция", "Лек");
            bool actualmTypesOfOccupations = refData.CTypesOfOccupations.Insert(mTypesOfOccupations);
                Assert.IsTrue(actualmTypesOfOccupations, "Не удалось вставить тип занятия");

            MAcademicLoad PreMa = new MAcademicLoad(100, "17-ИСбо-2а", "Правоведение", "Иванов Иван Иванович", "Лекция", "20","к");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            Assert.AreEqual(true, actualPreMa, "Не удалось вставить нагрузку для " + PreMa.Group);

        }
        RefData refData = new RefData();

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]public void UCAcademicLoad_1()
        {
            //arrange
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count == 0, "Таблица нагрузки не пуста!");
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а","Правоведение", "Иванов Иван Иванович", "Лекция", "20", "к");
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa1 = new MAcademicLoad(110,"17-Нбо-1а", "Программирование", "Иванов Иван Иванович", "Лр", "20", "к");
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2б", "Правоведение", "Иванов Иван Иванович", "Лекция", "20", "к");
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "История", "Иванова Ивана Ивановича", "Лекция", "20", "к");
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "Правоведение", "Иванова Ивана Ивановича", "Лекция", "20","к");
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
            setupData();
            Assert.IsTrue(refData.CAcademicLoad.Rows.Count != 0, "Таблица нагрузки пуста!");
            //arrange
            MAcademicLoad PreMa = new MAcademicLoad(100,"17-ИСбо-2а", "Правоведение", "Иванов Иван Иванович", "Лекция", "20","к");
            bool expected = false;
            //act
            PreMa.Occupation = "Фуаываываыв";
            bool actual = refData.CAcademicLoad.Update(PreMa);
            Assert.AreEqual(expected, actual, " Произошел ввод некорректных данных в атрибут тип занятия ");
        }

    }
}
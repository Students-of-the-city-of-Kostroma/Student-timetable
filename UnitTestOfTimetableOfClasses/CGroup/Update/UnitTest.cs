using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CGroup.UT_Update
{
    [TestClass]
    public class UT_UCGroup
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// загрузка тестовых данных
        /// </summary>
        [TestInitialize]
        public void RefDataInit()
        {
            refData.InitData();
        }
        /// <summary>
        /// Инициализация данных
        /// </summary>
        MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "ИАСТ");
        MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
        MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
        MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void UCGroup_1()
        {
            //arrange
            refData.CCourseSchedule.Clear();
            refData.CAcademicLoad.Clear();
            refData.CGroup.Clear();
            Assert.IsTrue(refData.CGroup.Rows.Count == 0, "Не удалось очистить таблицу группа");
            Assert.IsFalse(refData.CGroup.Update(gr), "Произошли изменения сведений в пустой таблице");
        }
        /// <summary>
        /// Изменить несуществующую группу в заполненной таблице
        /// </summary>
        [TestMethod]
        public void UCGroup_2()
        { 
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            //arrange
            refData.CCourseSchedule.Clear();
            refData.CAcademicLoad.Clear();
            refData.CGroup.Clear();
            Assert.IsTrue(refData.CGroup.Rows.Count == 0, "Не удалось очистить таблицу группа");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу " +gr.Group );
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Понедельник");
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу " + gr1.Group);
            MGroup gr2 = new MGroup("17-ММЭбо-2в", 2, "ММЭ", 1, 2, 1, 1, "Вторник");
            //act
            bool actual = refData.CGroup.Update(gr2);
            //assert
            Assert.IsFalse(actual, "Удалось изменить несуществующую группу в заполненной таблице");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Delete(gr1), "Не удалось удалить группу" + gr1.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
        /// </summary>
        /// Ввод корректных данных, при условии, что Семестр дублирует Семестр группы  существующего экземпляра
        /// </summary>
        [TestMethod]
        public void UCGroup_3() 
        {
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);
            gr1.Semester = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.IsTrue(actual, "Ввод корректных данных с дублирующим семестром не произошел");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Delete(gr1), "Не удалось удалить группу" + gr1.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Смена дублирует Смена существующего экземпляра
        /// </summary>
        [TestMethod]
        public void UCGroup_4() 
        {
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);
            gr1.Shift = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.IsTrue(actual, "Ввод корректных данных с дублирующим семестром не произошел");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Delete(gr1), "Не удалось удалить группу" + gr1.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Студентов дублирует Студентов существующего экземпляра
        /// </summary>
        [TestMethod]
        public void UCGroup_5()
        {
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);
            gr1.Students = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.IsTrue(actual, "Ввод корректных данных с дублирующим семестром не произошел");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Delete(gr1), "Не удалось удалить группу" + gr1.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра
        /// </summary>
        [TestMethod]
        public void UCGroup_6() 
        {
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);
            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.IsTrue(actual, "Ввод корректных данных с дублирующим семестром не произошел");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CGroup.Delete(gr1), "Не удалось удалить группу" + gr1.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
        /// <summary>
        /// Ввод  данных при условии что указанная специальность не существует
        /// </summary>
        [TestMethod]
        public void UCGroup_7() 
        {
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);
            //act
            gr.Specialty = "Т";
            bool actual = refData.CGroup.Update(gr);
            //assert
            Assert.IsFalse(actual, "Произошло обновление некорректной специальности");
            Assert.IsTrue(refData.CGroup.Delete(gr), "Не удалось удалить группу" + gr.Group);
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile), "Не удалось удалить профиль обучения");
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection), "Не удалось удалить направление подготовки");
        }
    }
}

using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses.CGroup.Update
{
    [TestClass]
    public class UT_UCGroup
    {
        readonly RefData refData = new RefData();

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void UCGroup_1()
        {
            //arrange
            refData.CGroup.Clear();
            Assert.IsTrue(refData.CGroup.Rows.Count == 0, "Не удалось очистить таблицу группа");

            bool expected = true;
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            expected = false;

            //act
            bool actual = refData.CGroup.Update(gr);

            //assert
            Assert.AreEqual(expected, actual, "Произошли изменения сведений в пустой таблице");
        }

        /// <summary>
        /// Изменить несуществующую группу в заполненной таблице
        /// </summary>
        [TestMethod]
        public void UCGroup_2()
        { 
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");

            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");

            //arrange
            refData.CGroup.Clear();
            Assert.IsTrue(refData.CGroup.Rows.Count == 0, "Не удалось очистить таблицу группа");

            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
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


        /// <summary>
        /// Ввод корректных данных, при условии, что Семестр дублирует Семестр группы  существующего экземпляра
        /// </summary>
       [TestMethod]
        public void UCGroup_3() 
        {
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");

            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");

            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);

            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);

            gr1.Semester = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод корректных данных с дублирующим семестром не произошел");

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
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");

            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);

            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);

            gr1.Shift = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод корректных данных с дублирующей сменой не произошел");

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
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");

            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);

            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);

            gr1.Students = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод корректных данных с дублирующимися студентами не произошел");

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
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить профиль обучения");

            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile), "Не удалось вставить направление подготовки");
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr), "Не удалось вставить группу" + gr.Group);

            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            Assert.IsTrue(refData.CGroup.Insert(gr1), "Не удалось вставить группу" + gr1.Group);

            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual, "Ввод корректных данных с дублирующим графиком не произошел");

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
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4, "КГУ");
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection), "Не удалось вставить профиль обучения");

            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
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

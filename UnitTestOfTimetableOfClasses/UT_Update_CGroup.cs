using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CGroup
    {
        readonly RefData refData = new RefData();
        private void SetupData()
        {
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4);
            Assert.IsTrue(refData.CDirectionOfPreparation.Insert(mDirection));
 
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile));
 
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Insert(mTrainingProfile));
        }
 
        private void DeleteData()
        {
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile));
           
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(refData.CTrainingProfile.Delete(mTrainingProfile));
 
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4);
            Assert.IsTrue(refData.CDirectionOfPreparation.Delete(mDirection));
        }

        /// <summary>
        /// Изменить сведения в пустой таблице
        /// </summary>
        [TestMethod]
        public void Task_250_11()
        {
            SetupData();
            //arrange
            bool expected = true;

            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
            expected = false;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);

            gr1.Shift = 2;
            gr1.Students = 3;
            gr1.MaxNumberOfClass = 3;
            gr1.MinNumberOfClass = 4;
            gr1.Weekends = "Суббота";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);

            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);

            DeleteData();
        }

        /// <summary>
        /// Изменить несуществующую группу в заполненной таблице
        /// </summary>
        [TestMethod]
        public void Task_250_12()
        {
            SetupData();
            //arrange
         

            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
            bool expected = false;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Понедельник");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);

            MGroup gr2 = new MGroup("17-ММЭбо-2в", 2, "ММЭ", 1, 2, 1, 1, "Вторник");
            result = refData.CGroup.Insert(gr2);
            Assert.IsTrue(result);
            MGroup gr3 = new MGroup("17-ММЭбо-2г", 2, "ММЭ", 2, 1, 1, 1, "Среда");
            result = refData.CGroup.Insert(gr3);
            Assert.IsTrue(result);
            MGroup gr4 = new MGroup("17-ММЭбо-2е", 2, "ММЭ", 2, 1, 1, 2, "Четверг");
            result = refData.CGroup.Insert(gr4);
            Assert.IsTrue(result);

            gr4.Group = "17-МЭбо-3г";
            gr4.Shift = 2;
            gr4.Students = 3;
            gr4.MaxNumberOfClass = 3;
            gr4.MinNumberOfClass = 4;
            gr4.Weekends = "Суббота";
            bool actual = refData.CGroup.Update(gr4);
            //assert
            Assert.AreEqual(expected, actual);

            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);

            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);

            result = refData.CGroup.Delete(gr2);
            Assert.IsTrue(result);

            result = refData.CGroup.Delete(gr3);
            Assert.IsTrue(result);

            result = refData.CGroup.Delete(gr4);
            Assert.IsTrue(result);

            DeleteData();
        }


        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_250_1() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Shift = 2;
            gr1.Students = 3;
            gr1.MaxNumberOfClass = 3;
            gr1.MinNumberOfClass = 4;
            gr1.Weekends = "Суббота";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Семестр дублирует Семестр группы  существующего экземпляра
        /// </summary>
       [TestMethod]
        public void Task_250_3() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Semester = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Направление подготовки дублирует Направление подготовки существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_4() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Specialty = "ММЭТ";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Смена дублирует Смена существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_5() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Shift = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Студентов дублирует Студентов существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_6() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Students = 1;
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_7() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных при условии что она будет дублировать другую записть(невозможно изменение)
        /// </summary>
        [TestMethod]
        public void Task_250_8() 
        {
            SetupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = refData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = refData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Semester = 1;
            gr1.Specialty = "ММЭТ";
            gr1.Shift = 1;
            gr1.Students = 1;
            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = refData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = refData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = refData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            DeleteData();
        }
    }
}

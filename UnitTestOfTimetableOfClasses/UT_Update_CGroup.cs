using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;
 
 
namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CGroup
    {
        private void setupData()
        {
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4);
            Assert.IsTrue(RefData.CDirectionOfPreparation.Insert(mDirection));
 
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(RefData.CTrainingProfile.Insert(mTrainingProfile));
 
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(RefData.CTrainingProfile.Insert(mTrainingProfile));
        }
 
        private void deleteData()
        {
            MTrainingProfile mTrainingProfile = new MTrainingProfile("Математическое моделирование в экономике и технике", "ММЭТ", "01.03.04");
            Assert.IsTrue(RefData.CTrainingProfile.Delete(mTrainingProfile));
           
            mTrainingProfile = new MTrainingProfile("Математические методы в экономике", "ММЭ", "01.03.04");
            Assert.IsTrue(RefData.CTrainingProfile.Insert(mTrainingProfile));
 
            MDirectionOfPreparation mDirection = new MDirectionOfPreparation("01.03.04", "Прикладная математика", 4);
            Assert.IsTrue(RefData.CDirectionOfPreparation.Delete(mDirection));
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_250_1_1() // Изменение когда все поля отличаются
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Shift = 2;
            gr1.Students = 3;
            gr1.MaxNumberOfClass = 3;
            gr1.MinNumberOfClass = 4;
            gr1.Weekends = "Суббота";
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Семестр дублирует Семестр группы  существующего экземпляра
        /// </summary>
       [TestMethod]
        public void Task_250_1_3() // повтор Семестра
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Semester = 1;
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Направление подготовки дублирует Направление подготовки существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_1_4() // повтор направления подготовки
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Specialty = "ММЭТ";
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Смена дублирует Смена существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_1_5() // смены
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Shift = 1;
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что Студентов дублирует Студентов существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_1_6() // повтор студентов
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Students = 1;
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_250_1_7() // повтор графика
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
 
        /// <summary>
        /// Ввод корректных данных при условии что она будет дублировать другую записть(невозможно изменение)
        /// </summary>
        [TestMethod]
        public void Task_250_1_8() // повтор всего(кроме группы)
        {
            setupData();
            //arrange
            MGroup gr = new MGroup("17-ММбо-2а", 1, "ММЭТ", 1, 1, 0, 0, "Воскресенье");
            bool result = RefData.CGroup.Insert(gr);
            Assert.IsTrue(result);
 
            bool expected = true;
            //act
            MGroup gr1 = new MGroup("17-ММЭбо-2б", 2, "ММЭ", 2, 2, 1, 1, "Воскресенье");
            result = RefData.CGroup.Insert(gr1);
            Assert.IsTrue(result);
 
            gr1.Semester = 1;
            gr1.Specialty = "ММЭТ";
            gr1.Shift = 1;
            gr1.Students = 1;
            gr1.MaxNumberOfClass = 0;
            gr1.MinNumberOfClass = 0;
            gr1.Weekends = "Воскресенье";
            bool actual = RefData.CGroup.Update(gr1);
            //assert
            Assert.AreEqual(expected, actual);
 
            result = RefData.CGroup.Delete(gr);
            Assert.IsTrue(result);
 
            result = RefData.CGroup.Delete(gr1);
            Assert.IsTrue(result);
 
            deleteData();
        }
    }
}
﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CGroup
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод корректных данных в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_251_1()
        {
            //arrange
            bool expected = true;
            //act        
            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12а12", "Напр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профиль", "ПРОФ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MGroup gr = new MGroup("17-ИСбо-2а", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            bool actual = refData.CGroup.Insert(gr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Группа добавляемой группы дублирует Группа уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_2()
        {
            //arrange
            MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            bool expected = false;
            //act
            MGroup gr1 = new MGroup("17-ИСбо-2а", 2, "ИСиТД", 2, 2, 1, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что они не дублируют атрибуты уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_10()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12б12", "Нбпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профель", "ПРЕФ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофиль", "НЕПРОФ", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ЮФбо-2в", 1, tp.ShortName, 1, 1, 0, 0, "Васкресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ЮФбо-2г", 2, tp1.ShortName, 2, 2, 1, 1, "Суббата");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что они полностью дублируют атрибуты уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_11() //полное дублирование всех атрибутов
        {
            //arrange
            MGroup gr = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            bool expected = false;
            //act
            MGroup gr1 = new MGroup("17-ТМбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Семестр добавляемой группы дублирует Семестр уже существующей группы.
        /// </summary>
        [TestMethod]
        public void Task_251_3()
        {
            //arrange        
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12в12", "Нвпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профвль", "ПРОФВ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофвль", "НЕПРОФВ", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2г", 1, tp.ShortName, 1, 1, 0, 0, "Воскресеньее");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2в", 1, tp1.ShortName, 2, 2, 1, 1, "Субботаа");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Направление подготовки добавляемой группы дублирует Направление подготовки уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_4()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12г12", "Нгпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профаль", "ПРОФА", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);

            MGroup gr = new MGroup("17-ИДбо-2а", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2б", 2, tp.ShortName, 2, 2, 1, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Смена добавляемой группы дублирует Смена уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_5()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12д12", "Ндпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профбль", "ПРОФБ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофдль", "НЕПРОФД", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2т", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2д", 2, tp1.ShortName, 1, 2, 1, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Студентов добавляемой группы дублирует Студентов уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_6()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12е12", "Непр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профяль", "ПРОФЯ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофёль", "НЕПРОФЁ", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2е", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2ю", 2, tp1.ShortName, 2, 1, 1, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Пар/день min добавляемой группы дублирует Пар/день min уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_7()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12ё12", "Нёпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профгль", "ПРОФГ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофкль", "НЕПРОФК", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2ж", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2з", 2, tp1.ShortName, 2, 2, 0, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что Пар/день max добавляемой группы дублирует Пар/день max уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_8()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12ж12", "Нжпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профдль", "ПРОФД", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофтль", "НЕПРОФТ", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2и", 1, tp.ShortName, 1, 1, 0, 1, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2к", 2, tp1.ShortName, 2, 2, 1, 1, "Суббота");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ввод корректных данных, при условии, что  Выходные добавляемой группы дублирует Выходные уже существующей группы
        /// </summary>
        [TestMethod]
        public void Task_251_9()
        {
            //arrange
            bool expected = true;

            MDirectionOfPreparation dp = new MDirectionOfPreparation("12а12з12", "Нзпр", 1);
            bool actual1 = refData.CDirectionOfPreparation.Insert(dp);
            Assert.AreEqual(expected, actual1);
            MTrainingProfile tp = new MTrainingProfile("Профёль", "ПРОФЁ", dp.CodeOfDP);
            bool actual2 = refData.CTrainingProfile.Insert(tp);
            Assert.AreEqual(expected, actual2);
            MTrainingProfile tp1 = new MTrainingProfile("Непрофмль", "НЕПРОФМ", dp.CodeOfDP);
            bool actual3 = refData.CTrainingProfile.Insert(tp1);
            Assert.AreEqual(expected, actual3);

            MGroup gr = new MGroup("17-ИДбо-2л", 1, tp.ShortName, 1, 1, 0, 0, "Воскресенье");
            refData.CGroup.Insert(gr);
            //act
            MGroup gr1 = new MGroup("17-ИДбо-2м", 2, tp1.ShortName, 2, 2, 1, 1, "Воскресенье");
            bool actual = refData.CGroup.Insert(gr1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

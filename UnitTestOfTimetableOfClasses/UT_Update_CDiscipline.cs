using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CDiscipline
    {
        readonly RefData refData = new RefData();
        /// <summary>
        /// Инициализация данных для тестирования
        /// </summary>
        /// <returns></returns>
        private bool SetData()
        {
            MAcademicLoad PreMa = new MAcademicLoad("17-ИСбо-2а", "100", "Математика", "Иванов Иван Иванович", "Лекция", "20");
            bool actualPreMa = refData.CAcademicLoad.Insert(PreMa);
            MDiscipline md = new MDiscipline("Математика", "Мат.", "64");
            return refData.CDiscipline.Insert(md);
        }
        /// <summary>
        /// Ввод корректных данных в таблицу
        /// </summary>
        [TestMethod]
        public void Task_337_1()
        {
            bool act = SetData();
            bool ex = true;
            Assert.AreEqual(ex, act);
            MDiscipline md = new MDiscipline("Математика", "Физ.", "33");
            bool expected = true;
            bool actual = refData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Попытка изменения одного из свойств на null-значение
        /// </summary>
        [TestMethod]
        public void Task_337_2()
        {
            bool act = SetData();
            bool ex = true;
            Assert.AreEqual(ex, act);
            MDiscipline md = new MDiscipline(null, null, null);
            bool expected = false;
            bool actual = refData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Попытка обновления данных, которых не существует
        /// </summary>
        [TestMethod]
        public void Task_337_3()
        {
            bool act = SetData();
            bool ex = true;
            Assert.AreEqual(ex, act);
            MDiscipline md = new MDiscipline("Абвг", "Физ.", "33");
            bool expected = false;
            bool actual = refData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);

        }
    }
}

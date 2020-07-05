using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CDiscipline
    { 
        /// <summary>
        /// Ввод корректных данных в таблицу
        /// </summary>
        [TestMethod]
        public void Task_337_1()
        {
            MDiscipline md = new MDiscipline("Математика", "Физ.", "33");
            bool expected = true;
            bool actual = RefData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);
           
        }
        /// <summary>
        /// Попытка изменения одного из свойств на null-значение
        /// </summary>
        [TestMethod]
        public void Task_337_2()
        {
            MDiscipline md = new MDiscipline(null, null, null);
            bool expected = false;
            bool actual = RefData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Попытка обновления данных, которых не существует
        /// </summary>
        [TestMethod]
        public void Task_337_3()
        {
            MDiscipline md = new MDiscipline("Абвг", "Физ.", "33");
            bool expected = false;
            bool actual = RefData.CDiscipline.Update(md);
            Assert.AreEqual(expected, actual);

        }
    }
}

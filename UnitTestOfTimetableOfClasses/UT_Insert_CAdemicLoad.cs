using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CAcademicLoad
    {
        RefData refData = new RefData();
        /// <summary>
        /// Ввод корректных данных в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_1240_1()
        {
            bool expected = true;
            MAcademicLoad mal = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Лекция", "20");
            CAcademicLoad CaL = new CAcademicLoad();
            bool actual = CaL.Insert(mal);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// учёная степень с такой сокращённой записью уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_2()
        {
            //arrange
            Task_1240_1();
            MAcademicLoad MAcademicL = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Лекция", "20");
            bool expected = false;
            //act
            bool actual = refData.CAcademicLoad.Insert(MAcademicL);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
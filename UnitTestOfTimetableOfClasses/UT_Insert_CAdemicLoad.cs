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
            MAcademicLoad mal = new MAcademicLoad("17-ВТбо-1", "24", "Математика", "Садовская Ольга Борисовна", "Лекция", "5");
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
            MAcademicLoad MAcademicL = new MAcademicLoad("17-ВТбо-1", "24", "Математика", "Садовская Ольга Борисовна", "Лекция", "5");
            bool expected = false;
            //act
            bool actual = refData.CAcademicLoad.Insert(MAcademicL);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
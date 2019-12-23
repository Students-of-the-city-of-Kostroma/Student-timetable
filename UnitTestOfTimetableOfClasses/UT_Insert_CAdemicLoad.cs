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
        /// <summary>
        /// Ввод корректных данных в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_1240_1()
        {
            //act
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            bool ex = true;
            bool act = RefData.CAcademicLoad.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }
        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что подобный тип занятия уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_2()
        {
            //arrange 
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            bool ex = true;
            //act
            bool act = RefData.CAcademicLoad.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что преподаватель с такой фамилией уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_3()
        {
            //arrange 
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            bool ex = true;
            //act
            bool act = RefData.CAcademicLoad.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }
        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что дисциплина уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_4()
        {
            //arrange 
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            bool ex = true;
            //act
            bool act = RefData.CAcademicLoad.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }
        /// <summary>
        /// Ввод корректных данных в таблицу, при условии, что группа уже есть в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_5()
        {
            //arrange 
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            bool ex = true;
            //act
            bool act = RefData.CAcademicLoad.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }
    }

}

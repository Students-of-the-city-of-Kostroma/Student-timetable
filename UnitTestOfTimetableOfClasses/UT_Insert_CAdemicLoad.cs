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
            //arrange 
            bool ex = true;
            //act
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            CAcademicLoad ca = new CAcademicLoad();
            bool act = ca.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
        }
        /// <summary>
        ///Ввод корректных данных в таблицу, при условии, что добавляемая запись не имеет аналогов в таблице
        /// </summary>
        [TestMethod]
        public void Task_1240_2()
        {
            //arrange
            MAcademicLoad ma = new MAcademicLoad("ВТ", "48", "Физкультура", "Иванов", "Леция", "20");
            CAcademicLoad ca = new CAcademicLoad();
            bool m = ca.Insert(ma);
            bool expected = true;
            //act
            MAcademicLoad ma1 = new MAcademicLoad("ВТ", "36", "Физика", "Иванова", "Практика", "40");
            bool actual = ca.Insert(ma1);
            //assert
            Assert.AreEqual(expected, actual);
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

using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CTeacher
    {
        /// <summary>
        /// Выбор данных из таблицы "Учёная степень."
        /// </summary>
        /// <returns></returns>
        private DataRow[] Degree()
        {
            DataTable table = RefData.DataSet.Tables["Учёная степень"];
            DataRow[] rows = table.Select();
            return rows;
        }

        /// <summary>
        /// Выбор данных из таблицы "Учёное звание."
        /// </summary>
        /// <returns></returns>
        private DataRow[] Title()
        {
            DataTable table = RefData.DataSet.Tables["Уч.Звание"];
            DataRow[] rows = table.Select();
            return rows;
        }

        /// <summary>
        /// Добавление в пустую таблицу
        /// </summary>
        [TestMethod]
        public void Task_246_1()
        {
            DataRow[] maTi = Title();
            DataRow[] ma = Degree();
            //arrange 
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", ma[0]["Reduction"].ToString(), maTi[1]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Полностью отличные атрибуты
        /// </summary>
        [TestMethod]
        public void Task_246_2()
        {
            DataRow[] maTi = Title();
            DataRow[] ma = Degree();
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma[0]["Reduction"].ToString(), maTi[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma[1]["Reduction"].ToString(), maTi[1]["Reduction"].ToString(), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
            bool expected = true;
            //act
            RefData.CTeacher.Insert(tcher1);
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CTeacher.Delete(tcher);
            RefData.CTeacher.Delete(tcher1);
        }

        /// <summary>
        /// Повторяющийся атрибут "ФИО"
        /// </summary>
        [TestMethod]
        public void Task_246_3()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
            bool expected = false;
            //act
            RefData.CTeacher.Insert(tcher1);
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Повторяющиеся атрибуты Уч. степень и Уч. звание
        /// </summary>
        [TestMethod]
        public void Task_246_4()
        {
            DataRow[] maTi = Title();
            DataRow[] ma = Degree();
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma[0]["Reduction"].ToString(), maTi[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma[0]["Reduction"].ToString(), maTi[0]["Reduction"].ToString(), "ФСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
            bool expected = true;
            //act
            bool actual = RefData.CTeacher.Insert(tcher1);
            RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CTeacher.Delete(tcher);
            RefData.CTeacher.Delete(tcher1);
        }

        /// <summary>
        /// Повторяющиеся атрибут Кафедра
        /// </summary>
        [TestMethod]
        public void Task_246_5()
        {
            DataRow[] maTi = Title();
            DataRow[] ma = Degree();
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma[0]["Reduction"].ToString(), maTi[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma[1]["Reduction"].ToString(), maTi[1]["Reduction"].ToString(), "ФАСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
            bool expected = true;
            //act
            RefData.CTeacher.Insert(tcher1);
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CTeacher.Delete(tcher);
            RefData.CTeacher.Delete(tcher1);
        }

        /// <summary>
        /// Повторяющиеся атрибуты график работы
        /// </summary>
        [TestMethod]
        public void Task_246_6()
        {
            DataRow[] maTi = Title();
            DataRow[] ma = Degree();
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma[0]["Reduction"].ToString(), maTi[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma[1]["Reduction"].ToString(), maTi[1]["Reduction"].ToString(), "ФСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act
            RefData.CTeacher.Insert(tcher1);
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            RefData.CTeacher.Delete(tcher);
            RefData.CTeacher.Delete(tcher1);
        }

        /// <summary>
        /// Все атрибуты повторяются
        /// </summary>
        [TestMethod]
        public void Task_246_7()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act
            RefData.CTeacher.Insert(tcher1);
            bool actual = RefData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

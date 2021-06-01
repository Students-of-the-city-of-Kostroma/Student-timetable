using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestOfTimetableOfClasses.UT_CTeacher.UT_Insert
{
    [TestClass]
    public class UT_ICTeacher
    {
        readonly RefData refData = new RefData();

        /// <summary>
        /// загрузка тестовых данных
        /// </summary>
        [TestInitialize]
        public void RefDataInit()
        {
            refData.InitData();
        }

        /// <summary>
        /// Добавление в пустую таблицу
        /// </summary>
        [TestMethod]
        public void ICTeacher_1()
        {
            //arrange 
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[1]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(refData.CTeacher.Delete(tcher));
        }

        /// <summary>
        /// Полностью отличные атрибуты
        /// </summary>
        [TestMethod]
        public void ICTeacher_2()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна",refData.CAcademicDegree.Rows[1]["Reduction"].ToString(), refData.CTitle.Rows[1]["Reduction"].ToString(), "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
            bool expected = true;
            //act
            refData.CTeacher.Insert(tcher1);
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(refData.CTeacher.Delete(tcher));
            Assert.IsTrue(refData.CTeacher.Delete(tcher1));
        }

        /// <summary>
        /// Повторяющийся атрибут "ФИО"
        /// </summary>
        [TestMethod]
        public void ICTeacher_3()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Доктор наук", "Профессор", "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
            bool expected = false;
            //act
            refData.CTeacher.Insert(tcher1);
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Повторяющиеся атрибуты Уч. степень и Уч. звание
        /// </summary>
        [TestMethod]
        public void ICTeacher_4()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[0]["Reduction"].ToString(), "ФСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
            bool expected = true;
            //act
            bool actual = refData.CTeacher.Insert(tcher1);
            refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(refData.CTeacher.Delete(tcher));
            Assert.IsTrue(refData.CTeacher.Delete(tcher1));
        }

        /// <summary>
        /// Повторяющиеся атрибут Кафедра
        /// </summary>
        [TestMethod]
        public void ICTeacher_5()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна",refData.CAcademicDegree.Rows[1]["Reduction"].ToString(), refData.CTitle.Rows[1]["Reduction"].ToString(), "ФАСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
            bool expected = true;
            //act
            refData.CTeacher.Insert(tcher1);
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(refData.CTeacher.Delete(tcher));
            Assert.IsTrue(refData.CTeacher.Delete(tcher1));
        }

        /// <summary>
        /// Повторяющиеся атрибуты график работы
        /// </summary>
        [TestMethod]
        public void ICTeacher_6()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна",refData.CAcademicDegree.Rows[0]["Reduction"].ToString(), refData.CTitle.Rows[0]["Reduction"].ToString(), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна",refData.CAcademicDegree.Rows[1]["Reduction"].ToString(), refData.CTitle.Rows[1]["Reduction"].ToString(), "ФСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act
            refData.CTeacher.Insert(tcher1);
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(refData.CTeacher.Delete(tcher));
            Assert.IsTrue(refData.CTeacher.Delete(tcher1));
        }

        /// <summary>
        /// Все атрибуты повторяются
        /// </summary>
        [TestMethod]
        public void ICTeacher_7()
        {
            //arrange 
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", "Кандидат наук", "Доцент", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act
            refData.CTeacher.Insert(tcher1);
            bool actual = refData.CTeacher.Insert(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

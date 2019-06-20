using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Update_CTeacher
    {
        /// <summary>
        /// Добавление в таблицу учённая степень
        /// </summary>
        /// <param name="a">Полное название учённой степени</param>
        /// <param name="b">Сокращённое название учённой степени</param>
        /// <returns>Сокращённое название учённой степени</returns>
		public string degree(string a, string b)
        {
            MAcademicDegree ma = new MAcademicDegree(a, b);
            RefData.CAcademicDegree.Insert(ma);
            return ma.Reduction;
        }
        /// <summary>
        /// Добавление в таблицу учённое звание
        /// </summary>
        /// <param name="a">Полное название учённого звания</param>
        /// <param name="b">Сокращённое название учённого звания</param>
        /// <returns>Сокращённое название учённого звания</returns>
		public string Title(string a, string b)
        {
            //RefData.CTitle.Clear();
            MTitle ma = new MTitle(a, b);
            RefData.CTitle.Insert(ma);
            return ma.Reduction;
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
		[TestMethod]
        public void Task_247_1()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
        {
            //arrange
            RefData.CTeacher.Rows.Clear();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидатнаук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Кандидатнаук", "Канд"), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            RefData.CTeacher.Insert(tcher);
            RefData.CTeacher.Insert(tcher1);
            bool expected = true;
            //act
            tcher1.AcademicDegree = degree("Докторнаук", "Док.");
            tcher1.AcademicTitle = Title("Доцент", "Доц.");
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пятница";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что примечание дублирует примечание существующего экземпляра
        /// </summary>
		[TestMethod]
        public void Task_247_5()//дублируется уч. степень и уч. звание
        {
            //arrange
            RefData.CTeacher.Rows.Clear();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидатнаук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Докторнаук", "Док."), Title("Доцент", "Доц."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            RefData.CTeacher.Insert(tcher);
            RefData.CTeacher.Insert(tcher1);
            bool expected = true;
            //act
            tcher1.AcademicDegree = degree("Кандидатнаук", "Канд");
            tcher1.AcademicTitle = Title("Доцент", "Доц.");
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что Кафедра дублирует Кафедра существующего экземпляра
        /// </summary>
		[TestMethod]
        public void Task_247_6()//дублируется кафедра 
        {
            //arrange
            RefData.CTeacher.Rows.Clear();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидатнаук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Докторнаук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            RefData.CTeacher.Insert(tcher);
            RefData.CTeacher.Insert(tcher1);
            bool expected = true;
            //act
            tcher1.Departament = "ФАСТ";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра
        /// </summary>
        [TestMethod]
        public void Task_247_7()//дублируется график
        {
            //arrange
            RefData.CTeacher.Rows.Clear();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидатнаук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Докторнаук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            RefData.CTeacher.Insert(tcher);
            RefData.CTeacher.Insert(tcher1);
            bool expected = true;
            //act
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод корректных данных, при условии, что данная запись полность. дублирует другую запись
        /// </summary>
		[TestMethod]
        public void Task_247_8()//дублируется всё кроме ФИО
        {
            //arrange
            RefData.CTeacher.Rows.Clear();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидатнаук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Докторнаук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            RefData.CTeacher.Insert(tcher);
            RefData.CTeacher.Insert(tcher1);
            bool expected = true;
            //act
            tcher1.AcademicDegree = degree("Кандидат наук", "Канд");
            tcher1.AcademicTitle = Title("Доцент", "Доц.");
            tcher1.Departament = "ФАСТ";
            tcher1.MetodicalDays = "Пн, Вт";
            tcher1.Windows = "Ср, Чт, Пт";
            tcher1.Weekends = "Вс";
            bool actual = RefData.CTeacher.Update(tcher1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

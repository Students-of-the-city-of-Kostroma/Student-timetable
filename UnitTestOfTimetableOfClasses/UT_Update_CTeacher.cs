using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
            //arrange 
            MAcademicDegree ma = new MAcademicDegree(a, b);
            bool ex = true;
            //act
            bool act = RefData.CAcademicDegree.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
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
            //arrange

            MTitle ma = new MTitle(a, b);
            bool exTi = true;
            //act
            bool aclTi = RefData.CTitle.Insert(ma);
            //assert
            Assert.AreEqual(exTi, aclTi);
            return ma.Reduction;
        }
        /// <summary>
        /// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
        /// </summary>
        [TestMethod]
        public void Task_247_1()//изменение когда атрибуты не повторяются (ФИО изменить не возможно)
        {
            //arrange
            string ma = degree("Кандидат наук", "Канд.");
            string maTi = Title("Доцент", "Доц.");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", ma, maTi, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", ma, maTi, "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = degree("Доктор наук", "Док.");
            tcher1.AcademicTitle = Title("Профессор", "Проф.");
            tcher1.MetodicalDays = "Чт, Сб";
            tcher1.Windows = "Сб, Пн";
            tcher1.Weekends = "Пт";
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
            string ma = degree("Кандидат наук", "Канд.");
            string maTi = Title("Доцент", "Доц.");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", ma, maTi, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = ma;
            tcher1.AcademicTitle = maTi;
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
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
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
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", degree("Кандидат наук", "Канд"), Title("Доцент", "Доц."), "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
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
            string ma = degree("Кандидат наук", "Канд.");
            string maTi = Title("Доцент", "Доц.");
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", ma, maTi, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Вс");
            MTeacher tcher1 = new MTeacher("Киприна", "Людмила", "Юрьевна", degree("Доктор наук", "Док."), Title("Профессор", "Проф."), "ИАСТ", "Пт, Ср", "Пн, Вт", "Сб");
            bool expected = true;
            bool actual1 = RefData.CTeacher.Insert(tcher);
            Assert.AreEqual(expected, actual1);
            bool actual2 = RefData.CTeacher.Insert(tcher1);
            Assert.AreEqual(expected, actual2);
            //act
            tcher1.AcademicDegree = ma;
            tcher1.AcademicTitle = maTi;
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

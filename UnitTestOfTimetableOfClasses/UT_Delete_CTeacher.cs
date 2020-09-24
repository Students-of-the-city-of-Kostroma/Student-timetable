using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CTeacher
    {
        [TestMethod]
        public void Task_1187_1()//Удаление из пустой таблицы
        {
            //arrage
            RefData refData = new RefData();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act
            bool actual = refData.CTeacher.Delete(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task_1187_2()//Удаление из заполненной таблицы
        {
            //arrage
            RefData refData = new RefData();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher1 = new MTeacher("Садовская", "Елена", "Григорьевна", "К. псих. н.", "Доцент", "РАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher2 = new MTeacher("Садовская", "Ирина", "Борисовна", "К. технич. н.", "Нет", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act
            refData.CTeacher.Insert(tcher1);
            refData.CTeacher.Insert(tcher2);
            bool actual = refData.CTeacher.Delete(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task_1187_3()//Удаление не существующей строки из таблицы
        {
            //arrage
            RefData refData = new RefData();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher1 = new MTeacher("Садовская", "Елена", "Григорьевна", "К. псих. н.", "Доцент", "РАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher2 = new MTeacher("Садовская", "Ирина", "Борисовна", "К. технич. н.", "Нет", "ИАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = false;
            //act
            refData.CTeacher.Insert(tcher1);
            refData.CTeacher.Insert(tcher2);
            bool actual = refData.CTeacher.Delete(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task_1187_4()//Удаление существующей строки из таблицы
        {//тут ошибка
            //arrage
            RefData refData = new RefData();
            MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher1 = new MTeacher("Садовская", "Елена", "Григорьевна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            MTeacher tcher2 = new MTeacher("Садовская", "Ирина", "Борисовна", "Кандидат наук", "Профессор", "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
            bool expected = true;
            //act
            refData.CTeacher.Insert(tcher);
            refData.CTeacher.Insert(tcher1);
            refData.CTeacher.Insert(tcher2);
            bool actual = refData.CTeacher.Delete(tcher);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

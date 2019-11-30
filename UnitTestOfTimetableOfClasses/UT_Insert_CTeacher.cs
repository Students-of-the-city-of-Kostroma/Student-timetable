using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Insert_CTeacher
    {
		private DataRow[] Degree()
		{
			DataTable table = RefData.DataSet.Tables["Учёная степень"];
			DataRow[] rows = table.Select();
			return rows;
		}

		private DataRow[] Title()
		{
			DataTable table = RefData.DataSet.Tables["Уч.Звание"];
			DataRow[] rows = table.Select();
			return rows;
		}

        [TestMethod]
        public void Task_246_1() //Добавление в пустую таблицу
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

        [TestMethod]
        public void Task_246_2() //Полностью отличные атрибуты
        {
			DataRow[] maTi = Title();
			DataRow[] ma = Degree();
			//string ma1 = AddDegree("Кандидат наук", "Канд.");
            //string maTi1 = addTitle("Доцент", "Доц.");
            //string ma = AddDegree("Доктор наук", "Док.");
            //string maTi = addTitle("Профессор", "Проф.");
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

        [TestMethod]
        public void Task_246_3() //Повторяющийся атрибут "ФИО"
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

        [TestMethod]
        public void Task_246_4() //Повторяющиеся атрибуты Уч. степень и Уч. звание
        {
			DataRow[] maTi = Title();
			DataRow[] ma = Degree();
			//string ma = AddDegree("Кандидат наук", "Канд.");
            //string maTi = addTitle("Профессор", "Проф.");

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
        [TestMethod]
        public void Task_246_5() //Повторяющиеся атрибут Кафедра
        {
			DataRow[] maTi = Title();
			DataRow[] ma = Degree();
			//string ma1 = AddDegree("Кандидат наук", "Канд.");
   //         string maTi1 = addTitle("Доцент", "Доц.");
   //         string ma = AddDegree("Доктор наук", "Док.");
   //         string maTi = addTitle("Профессор", "Проф.");

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
        [TestMethod]
        public void Task_246_6() //Повторяющиеся атрибуты график работы
        {
			DataRow[] maTi = Title();
			DataRow[] ma = Degree();
			//string ma1 = AddDegree("Кандидат наук", "Канд.");
   //         string maTi1 = addTitle("Доцент", "Доц.");
   //         string ma = AddDegree("Доктор наук", "Док.");
   //         string maTi = addTitle("Профессор", "Проф.");
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

        [TestMethod]
        public void Task_246_7() //Все атрибуты повторяются
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

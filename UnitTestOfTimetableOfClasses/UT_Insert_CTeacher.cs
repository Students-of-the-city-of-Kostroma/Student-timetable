using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CTeacher
	{
        public string addDegree(string a, string b)
        {
            //arrange 
            RefData.CAcademicDegree.Clear();
            MAcademicDegree ma = new MAcademicDegree(a, b);
            bool ex = true;
            //act
            bool act = RefData.CAcademicDegree.Insert(ma);
            //assert
            Assert.AreEqual(ex, act);
            return ma.Reduction;
        }
        public string addTitle(string a, string b)
        {
            //arrange
            RefData.CTitle.Clear();
            MTitle maTi = new MTitle(a, b);
            bool expectedTi = true;
            //act
            bool actualTi = RefData.CTitle.Insert(maTi);
            //assert
            Assert.AreEqual(expectedTi, actualTi);
            return maTi.Reduction;
        }

        [TestMethod]
		public void Task_246_1() //Добавление в пустую таблицу
		{
            string ma = addDegree("Магистр", "Маг.");
            string maTi = addTitle("Профессор", "Проф.");
            //arrange 
            RefData.CTeacher.Rows.Clear();
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна", ma, maTi, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_2() //Полностью отличные атрибуты
		{
            string ma1 = addDegree("Кандидат наук", "Канд.");
            string maTi1 = addTitle("Доцент", "Доц.");
            string ma = addDegree("Доктор наук", "Док.");
            string maTi = addTitle("Профессор", "Проф.");
            //arrange 
            RefData.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma1, maTi1, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma, maTi, "ИАСТ", "Пт, Ср", "Пн, Вт", "Суббота");
			bool expected = true;
			//act
			RefData.CTeacher.Insert(tcher1);
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_3() //Повторяющийся атрибут "ФИО"
		{
			//arrange 
			RefData.CTeacher.Rows.Clear();
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
            string ma = addDegree("Кандидат наук", "Канд.");
            string maTi = addTitle("Профессор", "Проф.");
          
            //arrange 
            RefData.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma, maTi, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma, maTi, "ФСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			RefData.CTeacher.Insert(tcher1);
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_5() //Повторяющиеся атрибут Кафедра
		{
            string ma1 = addDegree("Кандидат наук", "Канд.");
            string maTi1 = addTitle("Доцент", "Доц.");
            string ma = addDegree("Доктор наук", "Док.");
            string maTi = addTitle("Профессор", "Проф.");

            //arrange 
            RefData.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma1, maTi1, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma, maTi, "ФАСТ", "Пн, Вт, Ср", "Чт, Пт", "Суббота");
			bool expected = true;
			//act
			RefData.CTeacher.Insert(tcher1);
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_246_6() //Повторяющиеся атрибуты график работы
		{
            string ma1 = addDegree("Кандидат наук", "Канд.");
            string maTi1 = addTitle("Доцент", "Доц.");
            string ma = addDegree("Доктор наук", "Док.");
            string maTi = addTitle("Профессор", "Проф.");
            //arrange 
            RefData.CTeacher.Rows.Clear();
			MTeacher tcher1 = new MTeacher("Садовская", "Ольга", "Борисовна", ma1, maTi1, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			MTeacher tcher = new MTeacher("Киприна", "Людмила", "Юрьевна", ma, maTi, "ФСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			RefData.CTeacher.Insert(tcher1);
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_246_7() //Все атрибуты повторяются
		{
			//arrange 
			RefData.CTeacher.Rows.Clear();
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

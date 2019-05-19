﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CGroup
	{

		[TestMethod]
		public void task_250_1_1() // Изменение когда все поля отличаются
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Shift = 2;
			gr1.Students = 3;
			gr1.MaxNumberOfClass = 3;
			gr1.MinNumberOfClass = 4;
			gr1.Weekends = "Суббота";
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void task_250_1_3() // повтор Семестра
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Semester = 1;
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_4() // повтор направления подготовки
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Specialty = "ИСиТ";
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_5() // смены
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Shift = 1;
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_6() // повтор студентов
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Students = 1;
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_7() // повтор графика
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_8() // повтор всего(кроме группы)
		{
			//arrange
			Controllers.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			Controllers.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			Controllers.CGroup.Insert(gr1);
			gr1.Semester = 1;
			gr1.Specialty = "ИСиТ";
			gr1.Shift = 1;
			gr1.Students = 1;
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			bool actual = Controllers.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

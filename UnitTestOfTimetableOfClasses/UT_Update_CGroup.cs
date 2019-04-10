using System;
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
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			cg.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			cg.Insert(gr1);
			//gr1.Group = "17-ИДбо-2б";
			//gr1.Semester = 3;
			//gr1.Specialty = "ТМ";
			gr1.Shift = 2;
			gr1.Students = 3;
			gr1.MaxNumberOfClass = 3;
			gr1.MinNumberOfClass = 4;
			gr1.Weekends = "Суббота";
			bool actual = cg.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		// task-250-2 to task-250-4 невозможно реализовать так как поля Группа Семестр и Направление подготовки являются не изменяемыми

		[TestMethod]
		public void task_250_1_4_to_7() // повтор всех атрибутов кроме неизменяемых
		{
			//arrange
			MGroup gr = new MGroup("17-ИСбо-2а", 1, "ИСиТ", 1, 1, 0, 0, "Воскресенье");
			CGroup cg = new CGroup();
			cg.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, "ИСиТД", 2, 2, 1, 1, "Воскресенье");
			cg.Insert(gr1);
			//gr1.Group = "17-ИДбо-2б";
			//gr1.Semester = 3;
			//gr1.Specialty = "ТМ";
			gr1.Shift = 1;
			gr1.Students = 1;
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			bool actual = cg.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		
	}
}

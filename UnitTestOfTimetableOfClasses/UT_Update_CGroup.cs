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
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Shift = 2;
			gr1.Students = 3;
			gr1.MaxNumberOfClass = 3;
			gr1.MinNumberOfClass = 4;
			gr1.Weekends = "Суббота";
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void task_250_1_3() // повтор Семестра
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Semester = 1;
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_4() // повтор направления подготовки
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Specialty = mTrainingProfile.ShortName;
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_5() // смены
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Shift = 1;
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_6() // повтор студентов
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Students = 1;
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_7() // повтор графика
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_250_1_8() // повтор всего(кроме группы)
		{
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			RefData.CTrainingProfile.Insert(mTrainingProfile1);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			RefData.CGroup.Insert(gr);
			bool expected = true;
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			RefData.CGroup.Insert(gr1);
			gr1.Semester = 1;
			gr1.Specialty = mTrainingProfile.ShortName;
			gr1.Shift = 1;
			gr1.Students = 1;
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			bool actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

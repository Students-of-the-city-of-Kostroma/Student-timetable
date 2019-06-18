using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CGroup
	{
		/// <summary>
		/// Ввод коректных данных, при условии, что они не дублируют данные других экземпляров
		/// </summary>
		[TestMethod]
		public void task_250_1()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Shift = 2;
			gr1.Students = 3;
			gr1.MaxNumberOfClass = 3;
			gr1.MinNumberOfClass = 4;
			gr1.Weekends = "Суббота";
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// "Ввод корректных данных, при условии, что Семестр дублирует Семестр группы существующего экземпляра"
		/// </summary>
		[TestMethod]
		public void task_250_3()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Semester = 1;
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// "Ввод корректных данных, при условии, что Направление подготовки дублирует Направление подготовки существующего экземпляра"
		/// </summary>
		[TestMethod]
		public void task_250_4()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);

			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Specialty = mTrainingProfile.ShortName;
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// "Ввод корректных данных, при условии, что Смена дублирует Смена существующего экземпляра"
		/// </summary>
		[TestMethod]
		public void task_250_5()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Shift = 1;
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// "Ввод корректных данных, при условии, что Студентов дублирует Студентов существующего экземпляра"
		/// </summary>
		[TestMethod]
		public void task_250_6()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Students = 1;
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// "Ввод корректных данных, при условии, что График работы дублирует График работы существующего экземпляра"
		/// </summary>
		[TestMethod]
		public void task_250_7()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
		/// <summary>
		/// Ввод корректных данных при условии что она будет дублировать другую записть (невозможно изменение)
		/// </summary>
		[TestMethod]
		public void task_250_8()
		{
			bool actual;
			bool expected = true;
			MDirectionOfPreparation directionOfPreparation = new MDirectionOfPreparation("22.22.22", "Парабола", 1);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile = new MTrainingProfile("Системы и Технологии", "СИТ", directionOfPreparation.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile);
			Assert.AreEqual(expected, actual);
			MDirectionOfPreparation directionOfPreparation1 = new MDirectionOfPreparation("22.33.22", "Гипербола", 2);
			actual=RefData.CDirectionOfPreparation.Insert(directionOfPreparation1);
			Assert.AreEqual(expected, actual);
			MTrainingProfile mTrainingProfile1 = new MTrainingProfile("Курсач и Технологии", "КИТ", directionOfPreparation1.CodeOfDP);
			actual=RefData.CTrainingProfile.Insert(mTrainingProfile1);
			Assert.AreEqual(expected, actual);
			//arrange
			RefData.CGroup.Rows.Clear();
			MGroup gr = new MGroup("17-ИСбо-2а", 1, mTrainingProfile.ShortName, 1, 1, 0, 0, "Воскресенье");
			actual=RefData.CGroup.Insert(gr);
			Assert.AreEqual(expected, actual);
			//act
			MGroup gr1 = new MGroup("17-ИСбо-2б", 2, mTrainingProfile1.ShortName, 2, 2, 1, 1, "Воскресенье");
			actual=RefData.CGroup.Insert(gr1);
			Assert.AreEqual(expected, actual);
			gr1.Semester = 1;
			gr1.Specialty = mTrainingProfile.ShortName;
			gr1.Shift = 1;
			gr1.Students = 1;
			gr1.MaxNumberOfClass = 0;
			gr1.MinNumberOfClass = 0;
			gr1.Weekends = "Воскресенье";
			actual = RefData.CGroup.Update(gr1);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

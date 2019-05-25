using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Selection
	{
		[TestMethod]
		public void Task_835_1()
		{
			//arrange
			RefData.CGroup.Rows.Clear();
			bool expected = true;
			RefData.CTrainingProfile.Clear();
			MTrainingProfile gh = new MTrainingProfile("Вычислительная Техника", "ВТ");
			RefData.CTrainingProfile.Insert(gh);
			//act
			MGroup gr = new MGroup("17-ИСбо-2а", 1, gh.ShortName, 1, 1, 0, 0, "Воскресенье");
			bool actual = RefData.CGroup.Insert(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_835_3()
		{
			//arrange 
			RefData.CTeacher.Rows.Clear();
			MTitle ti = new MTitle("Профессор", "ПР");
			RefData.CTitle.Insert(ti);
			MAcademicDegree ad = new MAcademicDegree("Кондидат Наук");
			RefData.CAcademicDegree.Insert(ad);
			MTeacher tcher = new MTeacher("Садовская", "Ольга", "Борисовна",ad.AcademicDegree, ti.FullName, "ФАСТ", "Пн, Вт", "Ср, Чт, Пт", "Воскресенье");
			bool expected = true;
			//act
			bool actual = RefData.CTeacher.Insert(tcher);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_835_4()
		{
			//arrange
			RefData.СEnclosures.Rows.Clear();
			MUniversity un = new MUniversity("4401006286", "КГУ", "Костромкой Государственный Университет", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "156005, Костромская область, г. Кострома, ул. Дзержинского, 17", "Александр", "Наумов", "Рудольфович", "kgu@mail.ru", "84942317960");
			RefData.CUniversity.Insert(un);
			MEnclosures gr = new MEnclosures("А", un.FullName, "Дзержинского", "111111", "1");
			bool expected = true;
			//act
			bool actual = RefData.СEnclosures.Insert(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

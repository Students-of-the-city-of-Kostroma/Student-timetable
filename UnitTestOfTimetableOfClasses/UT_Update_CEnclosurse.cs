using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CEnclosurse
	{
		[TestMethod]
		public void task_396_1()
		{
			//arrange
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			RefData.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			gr.Address = "Ивановская";
			gr.Phone = "222222";
			gr.Comment = "2";
			bool actual = RefData.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_2()// повтор адреса
		{
			//arrange
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			RefData.СEnclosures.Insert(gr);
			bool expected = false;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "Костромской Государственный Университет", "Ивановская", "222222", "2");
			RefData.СEnclosures.Insert(gr1);
			gr.Address = "Ивановская";
			bool actual = RefData.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_3()// повтор телефона
		{
			//arrange
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			RefData.СEnclosures.Insert(gr);
			bool expected = false;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "Костромской Государственный Университет", "Ивановская", "222222", "2");
			RefData.СEnclosures.Insert(gr1);
			gr.Phone = "222222";
			bool actual = RefData.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_4()// повтор примечания
		{
			//arrange
			RefData.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "Костромской Государственный Университет", "Дзержинского", "111111", "1");
			RefData.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "Костромской Государственный Университет", "Ивановская", "222222", "2");
			RefData.СEnclosures.Insert(gr1);
			gr.Comment = "2";
			bool actual = RefData.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

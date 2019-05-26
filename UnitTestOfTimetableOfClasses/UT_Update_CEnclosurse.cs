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
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			Controllers.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			gr.Address = "Ивановская";
			gr.Phone = "222222";
			gr.Comment = "2";
			bool actual = Controllers.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_2()// повтор адреса
		{
			//arrange
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			Controllers.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			Controllers.СEnclosures.Insert(gr1);
			gr.Address = "Ивановская";
			bool actual = Controllers.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_3()// повтор телефона
		{
			//arrange
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			Controllers.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			Controllers.СEnclosures.Insert(gr1);
			gr.Phone = "222222";
			bool actual = Controllers.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_4()// повтор примечания
		{
			//arrange
			Controllers.СEnclosures.Rows.Clear();
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			Controllers.СEnclosures.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			Controllers.СEnclosures.Insert(gr1);
			gr.Comment = "2";
			bool actual = Controllers.СEnclosures.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

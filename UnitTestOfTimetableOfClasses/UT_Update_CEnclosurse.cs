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
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			cg.Insert(gr);
			bool expected = true;
			//act
			gr.Address = "Ивановская";
			gr.Phone = "222222";
			gr.Comment = "2";
			bool actual = cg.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_2()// повтор адреса
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			cg.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			cg.Insert(gr1);
			gr.Address = "Ивановская";
			bool actual = cg.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_3()// повтор телефона
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			cg.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			cg.Insert(gr1);
			gr.Phone = "222222";
			bool actual = cg.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void task_396_4()// повтор примечания
		{
			//arrange
			MEnclosures gr = new MEnclosures("А", "КГУ", "Дзержинского", "111111", "1");
			СEnclosures cg = new СEnclosures();
			cg.Insert(gr);
			bool expected = true;
			//act
			MEnclosures gr1 = new MEnclosures("Б", "КГУ", "Ивановская", "222222", "2");
			cg.Insert(gr1);
			gr.Comment = "2";
			bool actual = cg.Update(gr);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Insert_CInstitute
	{
		[TestMethod]
		public void Task_515_1() //Добавление в пустую таблицу
		{
            //arrange 
            Controllers.CInstitute.Select().Clear();
            MInstitute inst = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.");
			bool expected = true;
            //act
            bool actual = Controllers.CInstitute.Insert(inst);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_515_2() //Повторяющийся атрибут "Краткое название"
		{
			//arrange 
			MInstitute inst1 = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.");
			MInstitute inst = new MInstitute("ИАСТ", "Факультет финансов", "Голубева Ю.А.");
			bool expected = false;
			//act
			CInstitute I = new CInstitute();
			bool f = I.Insert(inst1);
			bool actual = I.Insert(inst);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Task_515_3() //Повторяющийся атрибут "Полное название"
		{
			//arrange 
			MInstitute inst1 = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.");
			MInstitute inst = new MInstitute("ФАСТ", "Институт Автоматизированных систем и технологий", "Голубева Ю.А.");
			bool expected = false;
			//act
			CInstitute I = new CInstitute();
			bool f = I.Insert(inst1);
			bool actual = I.Insert(inst);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Task_515_4() //Повторяющийся атрибут "Директор"
		{
			//arrange 
			MInstitute inst1 = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.");
			MInstitute inst = new MInstitute("ФАСТ", "Факультет финансов", "Лустгартен Ю.Л.");
			bool expected = false;
			//act
			CInstitute I = new CInstitute();
			bool f = I.Insert(inst1);
			bool actual = I.Insert(inst);
			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
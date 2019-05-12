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
			MInstitute inst = new MInstitute("ИАСТ", "Институт Автоматизированных систем и технологий", "Лустгартен Ю.Л.", "КГУ");
			bool expected = true;
			//act	
			bool actual = Controllers.CInstitute.Insert(inst);
			//assert	
			Assert.AreEqual(expected, actual);
		}
	}
}




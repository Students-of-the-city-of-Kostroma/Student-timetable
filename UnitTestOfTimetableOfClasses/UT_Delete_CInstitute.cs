using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;



namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CInstitute
	{
		[TestMethod]
		public void Task_513_1()
		{

			RefData.CInstitute.Clear();
		 MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");
			bool ex = true;
			RefData.CInstitute.Insert(I_IInstitute);
			bool act = RefData.CInstitute.Delete(I_IInstitute);

			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_513_2()
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Институт Автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "КГУ");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}
	}
}
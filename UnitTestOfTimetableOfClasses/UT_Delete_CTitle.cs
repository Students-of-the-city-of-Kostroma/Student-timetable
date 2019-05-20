using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Deleted_CTitle
	{
		[TestMethod]
		public void task_362_1()
		{
			//arrange
			Controllers.CTitle.Select().Clear();
			MTitle T_Title = new MTitle("Проф.", "Профессор");
			bool ex = true;
			//act
			Controllers.CTitle.Insert(T_Title);
			bool act = Controllers.CTitle.Delete(T_Title);
			//assert
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_362_2()
		{
			//arrange
			Controllers.CTitle.Select().Clear();
			//act
			MTitle T_Title = new MTitle("Проф.", "Профессор");
			bool ex = false;
			bool act = Controllers.CTitle.Delete(T_Title);
			//assert
			Assert.AreEqual(ex, act);
		}
	}
}

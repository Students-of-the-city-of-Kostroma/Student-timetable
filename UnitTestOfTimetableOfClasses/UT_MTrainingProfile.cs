using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_MTrainingProfile
	{
		//[TestMethod]
		//public void Task_427_1()
		//{
		//	try
		//	{
		//		MTrainingProfile mTrainingProfile = new MTrainingProfile("", "");
		//		Assert.AreEqual(typeof(Guid), mTrainingProfile.ID.GetType(), "Ожидался тип поля Guid");
		//	}
		//	catch (Exception ex)
		//	{
		//		Assert.Fail(ex.Message);
		//	}
		//}
		[TestMethod]
		public void Task_427_2()
		{
			try
			{
				MTrainingProfile mTrainingProfile = new MTrainingProfile("", "");
				Assert.AreEqual(typeof(string), mTrainingProfile.FullName.GetType(), "Ожидался тип поля String");
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}
		[TestMethod]
		public void Task_427_3()
		{
			try
			{
				MTrainingProfile mTrainingProfile = new MTrainingProfile("", "");
				Assert.AreEqual(typeof(string), mTrainingProfile.ShortName.GetType(), "Ожидался тип поля String");
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}
	}
}

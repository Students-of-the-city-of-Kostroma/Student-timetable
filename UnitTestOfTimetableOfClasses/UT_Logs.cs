using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Logs
	{
		[TestMethod]
		public void Task_1018_1()//Нажали кнопку Удалить в форме Преподаватель
		{
			//arrange
			Logs.GetInfo("Click button Delete in Teacher");
			string ex = ("");
			ex = Read();
			
			//act
			string act = "Click button Delete in Teacher";

			//assert
			StringAssert.Contains(ex, act);
		}

		private string Read()
		{
			StreamReader file = new StreamReader("Logs.txt");

			string ex = File.ReadLines(@"Logs.txt").Last();
			file.Close();
			return ex;

		}

		[TestMethod]
		public void Task_1018_2()//Нажали кнопку Удалить в форме Преподаватель
		{
			//arrange

			try
			{
				throw new Exception ("Error");
			}
			catch (Exception error)
			{
				Logs.GetError(error);
			}

			string ex = ("");
			ex = Read();

			////act
			string act = "Error";

			//assert
			StringAssert.Contains(ex, act);

		}
	}
}
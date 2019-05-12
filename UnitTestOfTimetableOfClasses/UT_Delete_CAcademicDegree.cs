using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CAcademicDegree
	{
		//CAcademicDegree CAcademic = new CAcademicDegree();

		[TestMethod]
		public void Task_485_1()//Удаление существующих данных таблицы
		{
			//arrange
			Controllers.CAcademicDegree.Select().Clear();
			MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
			bool ex = true;


			//act
			Controllers.CAcademicDegree.Insert(MAcademic);
			bool act = Controllers.CAcademicDegree.Delete(MAcademic);

			//assert 
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void Task_485_2()//Удаление несуществующих данных из таблицы
		{
			//arrange 
			Controllers.CAcademicDegree.Select().Clear();
			MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
			bool ex = false;

			//act
			bool act = Controllers.CAcademicDegree.Delete(MAcademic);

			//assert
			Assert.AreEqual(ex, act);
		}
	}
}
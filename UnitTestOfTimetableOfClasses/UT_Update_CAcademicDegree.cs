using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CAcademicDegree
	{
		[TestMethod]
        	public void Task_484_1()//Замена корректными данными только в поле атрибута "Сокращённая запись учёной степени"
        	{
            		//arrange 
            		Controllers.CAcademicDegree.Clear();
            		MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            		Controllers.CAcademicDegree.Insert(MAcademic);
            		bool ex = false;

            		//act
            		MAcademic.Reduction = "Бак.";
            		bool act = Controllers.CAcademicDegree.Update(MAcademic);

            		//assert
            		Assert.AreEqual(ex, act);
        	}

		[TestMethod]
			public void Task_484_2()//Замена корректными данными всех полей таблицы
			{
					//arrange
					Controllers.CAcademicDegree.Clear();
					MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
					Controllers.CAcademicDegree.Insert(MAcademic);
					bool ex = true;

					//act
					MAcademic.FullName = "Бакалавр";
					MAcademic.Reduction = "Маг.";
					bool act = Controllers.CAcademicDegree.Update(MAcademic);

					//assert
					Assert.AreEqual(ex, act);
		
			}

	}
}
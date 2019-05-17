using System;
using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CAcademicDegree
	{
		[TestMethod]
        	public void Task_484_1()//Ввод иных корректных данных в поле атрибута "Полная запись учёной степени"
        	{
            		//arrange
            		Controllers.CAcademicDegree.Clear();
            		MAcademicDegree MAcademic = new MAcademicDegree("Магистр", "Маг.");
            		Controllers.CAcademicDegree.Insert(MAcademic);
            		bool ex = true;

            		//act
            		MAcademic.FullName = "Аспирант";
            		bool act = Controllers.CAcademicDegree.Update(MAcademic);

            		//assert
            		Assert.AreEqual(ex, act);
        	}

	}
}

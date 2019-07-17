using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Update_CTitle
	{
		[TestMethod]
		public void Task_363_1()//изменение когда атрибуты не повторяются и код учебного звания изменить нельзя
		{

			MTitle T_Title = new MTitle("Проф.", "Профессор");

			RefData.CTitle.Insert(T_Title);

			T_Title = new MTitle("Доц.", "Доцент");

			bool result = RefData.CTitle.Update(T_Title);
			//assert
			Assert.IsFalse(result, "Ожидаем, что Модель изменится");

		}

		[TestMethod]
		public void Task_363_2()
		{
			MTitle T_Title = new MTitle("Проф.", "Профессор");

			RefData.CInstitute.Insert(T_Title);

			T_Title = new MTitle("Проф.", "Доцент");

			bool result = RefData.CTitle.Update(T_Title);

			Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");
		}
	}
}
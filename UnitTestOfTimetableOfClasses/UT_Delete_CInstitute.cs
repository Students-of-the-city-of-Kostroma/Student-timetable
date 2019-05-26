using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibOfTimetableOfClasses;



namespace UnitTestOfTimetableOfClasses
{
	[TestClass]
	public class UT_Delete_CInstitute
	{
		[TestMethod]
		public void Task_617_1() //Удалить запись при совпадении всех атрибутов
		{

			RefData.CInstitute.Clear();
			MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");	
			bool ex = true;
			RefData.CInstitute.Insert(I_IInstitute);
			bool act = RefData.CInstitute.Delete(I_IInstitute);

			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_2() //Удалить запись при совпадении атрибута Краткое название
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ИАСТ", "Иванов Ю.Л.", "Политехнический колледж");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_3() //при совпадении атрибута Полное название
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_4() //при совпадении атрибута  Директор
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_5() //при совпадении атрибута Наименование ВУЗа
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Костромской Государственный Университет");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_6() //Удаление несуществующих данных из таблицы
		{
			//arrange	
			RefData.CTitle.Clear();
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}
	}
}
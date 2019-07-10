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
			MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ",
				RefData.CTeacher.Rows[0].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[0].ItemArray[2].ToString());
			bool ex = true;
			RefData.CInstitute.Insert(I_IInstitute);
			bool act = RefData.CInstitute.Delete(I_IInstitute);

			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_2() //Удалить запись при совпадении атрибута Краткое название
		{
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ИАСТ",
				RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_3() //при совпадении атрибута Полное название
		{
			//act	
			MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ",
				RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_4() //при совпадении атрибута  Директор
		{
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ",
				RefData.CTeacher.Rows[0].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_5() //при совпадении атрибута Наименование ВУЗа
		{
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ",
				RefData.CTeacher.Rows[1].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[0].ItemArray[2].ToString());
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}

		[TestMethod]
		public void task_617_6() //Удаление несуществующих данных из таблицы
		{
			//act	
			MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ",
				RefData.CTeacher.Rows[0].ItemArray[0].ToString(),
				RefData.CUniversity.Rows[1].ItemArray[2].ToString());
			bool ex = false;
			bool act = RefData.CInstitute.Delete(I_IInstitute);
			//assert	
			Assert.AreEqual(ex, act);
		}
	}
}
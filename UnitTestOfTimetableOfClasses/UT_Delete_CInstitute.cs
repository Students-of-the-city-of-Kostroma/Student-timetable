using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CInstitute
    {
	/// <summary>
	/// Удалить запись при совпадении всех атрибутов
	/// </summary>
	[TestMethod]
        public void Task_617_1()
        {
		MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ТЕСТ", "Иванов Иван Иванович", "Костромской Государственный Университет");
		Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
		Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
	/// <summary>
	/// Удалить запись при совпадении атрибута Краткое название
	/// </summary>
	[TestMethod]
        public void Task_617_2() 
        {
		MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Политехнический колледж");
		Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
		MInstitute I_IInstitute2 = new MInstitute("1", "ФАСТ", "1", "1");
		Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
		Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
	/// <summary>
	/// При совпадении атрибута Полное название
	/// </summary>
	[TestMethod]
        public void Task_617_3() 
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ", "Иванов Юрий Иванович", "Политехнический колледж");
            bool ex = false;
            bool act = RefData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }
		/// <summary>
		/// При совпадении атрибута  Директор
		/// </summary>
		[TestMethod]
        public void Task_617_4() 
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Политехнический колледж");
            bool ex = false;
            bool act = RefData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }
		/// <summary>
		/// При совпадении атрибута Наименование ВУЗа
		/// </summary>
		[TestMethod]
        public void Task_617_5() 
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Юрий Иванович", "Костромской Государственный Университет");
            bool ex = false;
            bool act = RefData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }
		/// <summary>
		/// Удаление несуществующих данных из таблицы
		/// </summary>
		[TestMethod]
        public void Task_617_6() 
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Юрий Иванович", "Политехнический колледж");
            bool ex = false;
            bool act = RefData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }
    }
}

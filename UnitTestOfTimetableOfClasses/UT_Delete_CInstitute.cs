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
			MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Иванов Иван Иванович", "Костромской Государственный Университет");
            bool ex = true;
            bool act = RefData.CInstitute.Delete(I_IInstitute);

            Assert.AreEqual(ex, act);
        }
		/// <summary>
		/// Удалить запись при совпадении атрибута Краткое название
		/// </summary>
		[TestMethod]
        public void Task_617_2() 
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ИАСТ", "Иванов Юрий Иванович", "Политехнический колледж");
            bool ex = false;
            bool act = RefData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
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
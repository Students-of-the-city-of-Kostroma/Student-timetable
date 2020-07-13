using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CInstitute
    {
        readonly RefData refData = new RefData();
        [TestMethod]
        public void Task_617_1() //Удалить запись при совпадении всех атрибутов
        {
            // arrange
            MTeacher mTeacher = new MTeacher("Юрий", "Лустгартен", "Леонидович", "КН", "Доц", "ФАСТ", "Пн, Чт", "ПТ", "СБ, ВС");
            refData.CTeacher.Insert(mTeacher);
            MInstitute I_IInstitute = new MInstitute("Какой то левый институт не наш", "ФАСТ", "Лустгартен Юрий Леонидович", "Костромской Государственный Университет");
            bool ex = true;
            refData.CInstitute.Insert(I_IInstitute);
            //act
            bool act = refData.CInstitute.Delete(I_IInstitute);       
            // assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_617_2() //Удалить запись при совпадении атрибута Краткое название
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ИАСТ", "Иванов Ю.Л.", "Политехнический колледж");
            bool ex = false;
            bool act = refData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_617_3() //при совпадении атрибута Полное название
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
            bool ex = false;
            bool act = refData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_617_4() //при совпадении атрибута  Директор
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
            bool ex = false;
            bool act = refData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_617_5() //при совпадении атрибута Наименование ВУЗа
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Костромской Государственный Университет");
            bool ex = false;
            bool act = refData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_617_6() //Удаление несуществующих данных из таблицы
        {
            //act    
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Ю.Л.", "Политехнический колледж");
            bool ex = false;
            bool act = refData.CInstitute.Delete(I_IInstitute);
            //assert    
            Assert.AreEqual(ex, act);
        }
    }
}
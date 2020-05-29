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

            MInstitute I_IInstitute = new MInstitute("Институт автоматизированных систем и технологий", "ТЕСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
        /// <summary>
        /// Удалить запись при совпадении атрибута Краткое название
        /// </summary>
        [TestMethod]
        public void Task_617_2() //Удалить запись при совпадении атрибута Краткое название
        {  
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            MInstitute I_IInstitute2 = new MInstitute("Ффффф", "ФАСТ", "Фффф Фффф Фффф", "Фффф Фффф Фффф");
            Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
        /// <summary>
        /// При совпадении атрибута Полное название
        /// </summary>
        [TestMethod]
        public void Task_617_3()
        {
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            MInstitute I_IInstitute2 = new MInstitute("Любой институт", "ФФФФФ", "Фффф Фффф Фффф", "Фффф Фффф Фффф");
            Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
        /// <summary>
        /// При совпадении атрибута  Директор
        /// </summary>
        [TestMethod]
        public void Task_617_4()
        {
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            MInstitute I_IInstitute2 = new MInstitute("Ффффф", "ФФФФФ", "Иванов Иван Иванович", "Фффф Фффф Фффф");
            Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
        /// <summary>
        /// При совпадении атрибута Наименование ВУЗа
        /// </summary>
        [TestMethod]
        public void Task_617_5()
        {

           MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            MInstitute I_IInstitute2 = new MInstitute("Ффффф", "ФФФФФ", "Фффф Фффф Фффф", "Ярославский Государственный Университет");
            Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
        /// <summary>
        /// Удаление несуществующих данных из таблицы
        /// </summary>
        [TestMethod]
        public void Task_617_6()
        {
            MInstitute I_IInstitute = new MInstitute("Любой институт", "ФАСТ", "Иванов Иван Иванович", "Ярославский Государственный Университет");
            Assert.IsTrue(RefData.CInstitute.Insert(I_IInstitute));
            MInstitute I_IInstitute2 = new MInstitute("Ффффф", "ФФФФФ", "Фффф Фффф Фффф", "Фффф Фффф Фффф");
            Assert.IsFalse(RefData.CInstitute.Delete(I_IInstitute2));
            Assert.IsTrue(RefData.CInstitute.Delete(I_IInstitute));
        }
    }
}

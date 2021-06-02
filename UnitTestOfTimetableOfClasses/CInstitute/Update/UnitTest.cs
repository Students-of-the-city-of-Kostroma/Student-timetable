using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses.UT_CInstitute.UT_Update
{
    [TestClass]
    public class UT_UCInstitute
    {
        RefData refData = new RefData();
        [TestMethod]
        public void UCInstitute_1() //замена всех атрибутов
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            refData.CInstitute.Insert(T_Institute);

            T_Institute = new MInstitute("Факультет автоматизированных систем и технологий", "ФАСТ", "Голубева Ю.А.", "Политехнический колледж");
            bool result = refData.CInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

        [TestMethod]
        public void UCInstitute_2() //замена атрибутов Полное название
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            refData.CInstitute.Insert(T_Institute);

            T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
            bool result = refData.CInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

        [TestMethod]
        public void UCInstitute_3() //краткая запись института уже есть в таблице
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            refData.CInstitute.Insert(T_Institute);

            T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Киприна Ю.Л.", "Политехнический колледж");
            bool result = refData.CInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

        [TestMethod]
        public void UCInstitute_4() //директор уже есть в таблице
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            refData.CInstitute.Insert(T_Institute);

            T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Лустгартен Ю.Л.", "Политехнический колледж");
            bool result = refData.CInstitute.Update(T_Institute);

            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }

        [TestMethod]
        public void UCInstitute_5() //наименование ВУЗа уже есть в таблице
        {
            MInstitute T_Institute = new MInstitute("Институт автоматизированных систем и технологий", "ИАСТ", "Лустгартен Ю.Л.", "Костромской Государственный Университет");

            refData.CInstitute.Insert(T_Institute);

            T_Institute = new MInstitute("Институт дизайна", "ФАСТ", "Киприна Ю.Л.", "Костромской Государственный Университет");

            bool result = refData.CInstitute.Update(T_Institute);
            Assert.IsFalse(result, "Ожидаем, что Модель не изменяется");

        }
    }
}

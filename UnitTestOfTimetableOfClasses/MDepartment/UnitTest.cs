using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MDepartment
{
    [TestClass]
    public class UT_MDepartment
    {
        RefData refData = new RefData();
        [TestMethod]
        public void MDepartment_1()
        {
            try
            {
                MDepartment D = new MDepartment("ИД", "Информационные технологии в дизайне", "Киприна Людмила Юрьевна", "Институт автоматизированных систем и техногий");
                Assert.AreEqual(typeof(string), D.ShortTitle.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void MDepartment_2()
        {
            try
            {
                MDepartment D = new MDepartment("ИД", "Информационные технологии в дизайне", "Киприна Людмила Юрьевна", "Институт автоматизированных систем и техногий");
                Assert.AreEqual(typeof(string), D.FullTitle.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public void MDepartment_3()
        {
            try
            {
                MDepartment D = new MDepartment("ИД", "Информационные технологии в дизайне", "Киприна Людмила Юрьевна", "Институт автоматизированных систем и техногий");
                Assert.AreEqual(typeof(string), D.DepartmentHead.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public void MDepartment_4()
        {
            try
            {
                MDepartment D = new MDepartment("ИД", "Информационные технологии в дизайне", "Киприна Людмила Юрьевна", "Институт автоматизированных систем и техногий");
                Assert.AreEqual(typeof(string), D.Institute.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

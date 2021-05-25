using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MUniversity
    {
        RefData refData = new RefData();
        [TestMethod]
        public void MUniversity_1()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.INN.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_2()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.ShortName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_3()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_4()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.ActualAddress.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_5()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.LegalAddress.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_6()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.NameRector.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_7()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.SurnameRector.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_8()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.MiddleNameRector.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MUniversity_9()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.Email.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public void MUniversity_10()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru", "89995119864");
                Assert.AreEqual(typeof(String), T.Phone.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}


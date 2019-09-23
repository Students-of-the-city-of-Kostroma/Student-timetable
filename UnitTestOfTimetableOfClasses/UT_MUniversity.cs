using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MUniversity
    {
        [TestMethod]
        public void Issue_506_1()
        {
            try
            {
                MUniversity T = new MUniversity("1111111111", "КГУ", "Костромской Гос Универ", "Дзержинского", "Дзержинского", "Куделин ", "Роман", "Олегович", "kgu@mail.ru","89995119864");
                Assert.AreEqual(typeof(String), T.INN.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_506_2()
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
        public void Issue_506_3()
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
        public void Issue_506_4()
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
        public void Issue_506_5()
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
        public void Issue_506_6()
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
        public void Issue_506_7()
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
        public void Issue_506_8()
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
        public void Issue_506_9()
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
        public void Issue_506_10()
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


﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses.UT_MAuditor
{
    [TestClass]
    public class UT_MAuditor
    {
        RefData refData = new RefData();

        [TestMethod]
        public void MAuditor_1()
        {
            try
            {
                MAuditor T_Auditor = new MAuditor("", "", 0, "");
                Assert.AreEqual(typeof(String), T_Auditor.NameOfAuditor.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void MAuditor_2()
        {
            try
            {
                MAuditor T_Auditor = new MAuditor("", "", 0, "");
                Assert.AreEqual(typeof(String), T_Auditor.Cafedra.GetType(), "Ожидался тип поля string");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MAuditor_3()
        {
            try
            {
                MAuditor T_Auditor = new MAuditor("", "", 0, "");
                Assert.AreEqual(typeof(ushort), T_Auditor.Spacious.GetType(), "Ожидался тип поля ushort");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void MAuditor_4()
        {
            try
            {
                MAuditor T_Auditor = new MAuditor("", "", 0, "");
                Assert.AreEqual(typeof(String), T_Auditor.Building.GetType(), "Ожидался тип поля ushort");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

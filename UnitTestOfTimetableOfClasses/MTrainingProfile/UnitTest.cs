using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MTrainingProfile
    {
        RefData refData = new RefData();
        //[TestMethod]
        //public void MTrainingProfile_1()
        //{
        //    try
        //    {
        //        MTrainingProfile mTrainingProfile = new MTrainingProfile("", "");
        //        Assert.AreEqual(typeof(Guid), mTrainingProfile.ID.GetType(), "Ожидался тип поля Guid");
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail(ex.Message);
        //    }
        //}
        [TestMethod]
        public void MTrainingProfile_2()
        {
            try
            {
                MTrainingProfile mTrainingProfile = new MTrainingProfile("Информациооные системы и технологии", "ИС", "40454");
                Assert.AreEqual(typeof(string), mTrainingProfile.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTrainingProfile_3()
        {
            try
            {
                MTrainingProfile mTrainingProfile = new MTrainingProfile("Информациооные системы и технологии", "ИС", "40454");
                Assert.AreEqual(typeof(string), mTrainingProfile.ShortName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void MTrainingProfile_4()
        {
            try
            {
                MTrainingProfile mTrainingProfile = new MTrainingProfile("Информациооные системы и технологии", "ИС", "40454");
                Assert.AreEqual(typeof(string), mTrainingProfile.Shiphr.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

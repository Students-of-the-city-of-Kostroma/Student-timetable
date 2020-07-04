using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Logs
    {
        RefData refData = new RefData();
        /// <summary>
        /// Проверка корректного вывода метода GetInfo в Logs.txt
        /// </summary>
        [TestMethod]
        public void Task_1018_1()
        {
            //arrange
            Logs.GetInfo("Click button Delete in Teacher");
            string ex = ("");
            ex = Read();

            //act
            string act = "Click button Delete in Teacher";

            //assert
            StringAssert.Contains(ex, act);
        }

        private string Read()
        {
            StreamReader file = new StreamReader("Logs.txt");

            string ex = File.ReadLines(@"Logs.txt").Last();
            file.Close();
            return ex;

        }

        /// <summary>
        /// Проверка корректного вывода метода GetError в Logs.txt
        /// </summary>
        [TestMethod]
        public void Task_1018_2()
        {
            //arrange

            try
            {
                throw new Exception("Error");
            }
            catch (Exception error)
            {
                Logs.GetError(error);
            }

            string ex = ("");
            ex = Read();

            //act
            string act = "Error";

            //assert
            StringAssert.Contains(ex, act);

        }
    }
}
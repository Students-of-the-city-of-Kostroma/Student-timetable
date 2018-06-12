using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using System.Windows.Forms;
using System.Threading;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UTofStory_2
    {
        static Start start;
        [TestMethod]
        public void issue_2_1()
        {
            ThreadStart threadStart = new ThreadStart(StartApplication);
            Thread thread = new Thread(threadStart);

        }

        public void StartApplication()
        {
            start = new Start();
            Application.Run(start);
        }
    }
}

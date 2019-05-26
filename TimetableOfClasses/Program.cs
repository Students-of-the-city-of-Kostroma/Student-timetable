using System;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {		
            Application.EnableVisualStyles();
			new RefData();

			Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}

using System;
using System.Windows.Forms;

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
			new RefData();
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}

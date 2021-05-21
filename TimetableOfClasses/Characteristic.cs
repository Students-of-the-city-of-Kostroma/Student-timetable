using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            sml.Visible = !sml.Visible;
            int i = 0;
            if (sml.ForeColor == Color.Black)
            {
                i = 1;
            }
            switch (i)
            {

                case 0:
                    if (sml.Visible == true)
                        sml.ForeColor = Color.Black;
                    break;

                case 1:
                    if (sml.Visible == true)
                        sml.ForeColor = Color.Red;
                    break;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Students-of-the-city-of-Kostroma/Student-timetable");
        }
    }
}

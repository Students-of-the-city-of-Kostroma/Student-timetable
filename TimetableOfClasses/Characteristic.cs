using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void Help_Click(object sender, System.EventArgs e)
        {
            Sprav sprav = new Sprav();
            sprav.ShowDialog();

        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown1.Maximum = 7;
                numericUpDown1.Minimum = 0;

            }
            else
            {
                numericUpDown1.Maximum = 8;
                numericUpDown1.Minimum = 1;
            }
        }
    }
}

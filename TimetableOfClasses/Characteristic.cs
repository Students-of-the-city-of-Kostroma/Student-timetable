using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();
        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			numericUpDown1.Maximum = 12;
			numericUpDown1.Minimum = 1;
			numericUpDown1.ReadOnly = true;
			numericUpDown1.Increment = 1;
		}
    }
}

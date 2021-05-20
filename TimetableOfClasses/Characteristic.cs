using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void Most_SelectedItemChanged(object sender, System.EventArgs e)
        {
            
        }

        private void First_SelectedItemChanged(object sender, System.EventArgs e)
        {

        }

        private void Most_KeyUp(object sender, KeyEventArgs e)
        {
            int i = int.Parse(Most.Text);

        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}

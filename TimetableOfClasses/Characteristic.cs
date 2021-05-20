using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void Most_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if(int.TryParse(Most.Text, out int a))
            {
                if (a <= 8 && a >= 0)
                    Most.Text = a.ToString();
                else Most.Text = "";
            }
            else Most.Text = "";
        }

        private void First_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (int.TryParse(First.Text, out int a))
            {
                if (a <= 3 && a >= 1)
                    First.Text = a.ToString();
                else First.Text = "";
            }
            else First.Text = "";
        }

        private void Second_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (int.TryParse(Second.Text, out int a))
            {
                if (a <= 5 && a >= 4)
                    Second.Text = a.ToString();
                else Second.Text = "";
            }
            else Second.Text = "";
        }

        private void Third_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (int.TryParse(Third.Text, out int a))
            {
                if (a <= 8 && a >= 6)
                    Third.Text = a.ToString();
                else Third.Text = "";
            }
            else Third.Text = "";
        }
    }
}

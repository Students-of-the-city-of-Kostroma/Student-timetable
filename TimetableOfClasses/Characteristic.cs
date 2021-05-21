using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void radioButton1_Click(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            else radioButton2.Checked = true;

        }

        private void Most_SelectedItemChanged(object sender, System.EventArgs e)
        {
            
                if (int.TryParse(Most.Text, out int a))
                {
                    if (radioButton1.Checked)
                    {
                        if (a <= 7 && a >= 0)
                            Most.Text = a.ToString();
                        else Most.Text = "";
                    }
                    if (radioButton1.Checked == false)
                    {
                        if (a <= 8 && a >= 1)
                            Most.Text = a.ToString();
                        else Most.Text = "";
                    }
                }
                else Most.Text = "";
        }
    }
}

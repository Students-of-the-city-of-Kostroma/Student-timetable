using LibOfTimetableOfClasses;
using System.Windows.Forms;
using System;
using System.Data;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic()
        {

            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Program.refData.CRing;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Reference sprav = new Reference();
            sprav.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

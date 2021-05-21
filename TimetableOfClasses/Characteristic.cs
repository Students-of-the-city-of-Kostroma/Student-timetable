using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        List<int> semestr = new List<int>() { 8,7,6,5,4,3,2,1 }; //Номер семестра
        public Characteristic() => InitializeComponent();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Sprav sprav = new Sprav();
            sprav.ShowDialog();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 8) ;
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

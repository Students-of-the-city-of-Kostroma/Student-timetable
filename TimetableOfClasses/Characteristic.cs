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

       
    }
}

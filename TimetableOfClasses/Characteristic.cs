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
    }
}

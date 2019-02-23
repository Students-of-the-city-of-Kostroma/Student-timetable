using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;


namespace TimetableOfClasses
{
    public partial class Auditor : Form
    {
        public Auditor()
        {
            InitializeComponent();
            DataGridAuditor.AutoGenerateColumns = false;
            DataGridAuditor.DataSource = Controllers.CAuditor.Select();
        }

        private void DataGridAuditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // кнопка "Добавить"
        {
            AddAuditor k = new AddAuditor();
            k.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher t = new AddTeacher();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
        }
     

       

        private void DG_SelectionChanged(object sender, EventArgs e)
        {

            if ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}

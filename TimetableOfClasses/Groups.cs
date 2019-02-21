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
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            DG_Group.DataSource = Controllers.CGroup.Select();
        }

        private void DG_Group_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

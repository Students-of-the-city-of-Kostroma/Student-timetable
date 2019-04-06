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
    public partial class Discipline : Form
    {
		public Discipline()
		{
			InitializeComponent();
			DG_Disc.AutoGenerateColumns = false;
			DG_Disc.DataSource = Controllers.CDiscipline.Select();
		}


        private void DG_Disc_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_Disc.SelectedCells.Count > 0)
            {
                Delete.Enabled = true;
            }
            else
            {
                Delete.Enabled = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DG_Disc.Rows.Count == 0)
            {}
            else
            { DG_Disc.Rows.RemoveAt(DG_Disc.SelectedCells[0].RowIndex); }
           

        }

		private void btCreateDiscipline_Click(object sender, EventArgs e)
		{
			AddDiscipline addDiscipline = new AddDiscipline();
			addDiscipline.ShowDialog();
		}

		private void DG_Disc_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridView grid = sender as DataGridView;
			for (int i = 0; i < grid.Rows.Count; i++)
				grid.Rows[i].Cells[0].Value = (i + 1).ToString();
		}
	}
}


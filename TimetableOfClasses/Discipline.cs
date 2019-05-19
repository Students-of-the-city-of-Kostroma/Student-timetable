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
            try { DG_Disc.Rows.RemoveAt(DG_Disc.SelectedCells[0].RowIndex); }
            catch{}

        }

		private void btCreateDiscipline_Click(object sender, EventArgs e)
		{
			AddDiscipline addDiscipline = new AddDiscipline();
			addDiscipline.ShowDialog();
		}

		private void btChange_Click(object sender, EventArgs e)
		{
			if (DG_Disc.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_Disc.SelectedRows[0].DataBoundItem).Row;
				MDiscipline mDiscipline = new MDiscipline((string)Row["Fullname"], (string)Row["Shortname"], (string)Row["CycleofDiscipline"]);
				AddDiscipline add = new AddDiscipline(mDiscipline);
				add.Owner = this;
				add.ShowDialog();
			}
			else if (DG_Disc.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
			else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
		}

		private void DG_Disc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG_Disc.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG_Disc.Rows[index].HeaderCell.Value = indexStr;
		}
	}
}


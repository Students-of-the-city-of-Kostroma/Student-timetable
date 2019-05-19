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
			DG_Disc.DataSource = Controllers.CDiscipline;
		}


        private void DG_Disc_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_Disc.SelectedCells.Count > 0)
            {
                Delete.Enabled = true;
				btChange.Enabled = true;
			}
            else
            {
                Delete.Enabled = false;
				btChange.Enabled = false;
			}
        }

        private void Delete_Click(object sender, EventArgs e)
        {
			string SelectedName = "";
			foreach (DataGridViewRow row in DG_Disc.SelectedRows)
			{
				DataRow Row = ((DataRowView)row.DataBoundItem).Row;
				SelectedName += (string)Row["Fullname"] + ", ";
			}
			if (SelectedName.Length > 2)
				SelectedName = SelectedName.Remove(SelectedName.Length - 2);
			DialogResult dr = MessageBox.Show("Удалить дисциплину - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (DG_Disc.SelectedRows.Count > 0 && dr == DialogResult.OK)
			{
				int countSelected = DG_Disc.SelectedRows.Count;

				MDiscipline mDiscipline;
				foreach (DataGridViewRow row in DG_Disc.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mDiscipline = new MDiscipline((string)Row["Fullname"], (string)Row["Shortname"], (string)Row["CycleofDiscipline"]);
					Controllers.CDiscipline.Delete(mDiscipline);
				}
			}

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


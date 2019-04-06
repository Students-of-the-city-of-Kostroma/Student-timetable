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
			string SelectedName = "";
			foreach (DataGridViewRow row in DG_Disc.SelectedRows)
			{
				DataRow Row = ((DataRowView)row.DataBoundItem).Row;
				SelectedName += (string)Row["NameOfAuditor"] + ", ";
			}
			if (SelectedName.Length > 2)
				SelectedName = SelectedName.Remove(SelectedName.Length - 2);
			DialogResult dr = MessageBox.Show("Удалить аудиторию - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (DG_Disc.SelectedRows.Count > 0 && dr == DialogResult.OK)
			{
				int countSelected = DG_Disc.SelectedRows.Count;

				for (int i = 0; i < countSelected; i++)
				{
					DG_Disc.Rows.RemoveAt(DG_Disc.SelectedCells[0].RowIndex);
				}
			}

		}

		private void btCreateDiscipline_Click(object sender, EventArgs e)
		{
			AddDiscipline addDiscipline = new AddDiscipline();
			addDiscipline.ShowDialog();
		}
	}
}


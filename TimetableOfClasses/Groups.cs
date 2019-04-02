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
			DG_Group.DataSource = Controllers.CGroup.Select();
			var dt = Controllers.CGroup.Select();
			for (int i = 1; i < dt.Columns.Count; i++)
			{
				DG_Group.Columns[i].HeaderText = dt.Columns[i].Caption;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (DG_Group.SelectedRows.Count > 0)
			{
				DG_Group.Rows.RemoveAt(DG_Group.SelectedCells[0].RowIndex);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddGroup addDiscipline = new AddGroup();
			addDiscipline.ShowDialog();
		}
	}
}

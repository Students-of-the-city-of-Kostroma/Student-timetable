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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
			DG.AutoGenerateColumns = false;
			DG.DataSource = Controllers.CTeacher.Select();
		}

        private void AddTeacher(object sender, EventArgs e)
        {
			AddTeacher t = new AddTeacher();
             t.ShowDialog();
        }

        private void RemoveTeacher(object sender, EventArgs e)
        {
			//DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
			DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DG.SelectedRows.Count>0 && dr == DialogResult.Yes)
			{
				MTeacher mTeacher;
				foreach(DataGridViewRow row in DG.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mTeacher = new MTeacher((string)Row["FullName"], (string)Row["Departament"]);
					Controllers.CTeacher.Delete(mTeacher);
				}
			}
        }

		private void Update(object sender, EventArgs e)
		{
			if (DG.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
				MTeacher mTeacher = new MTeacher((Guid)Row.ItemArray[0], (string)Row["FullName"],(string)Row["Note"], (string)Row["Departament"],  (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"], (ushort)Row.ItemArray[1]);
				AddTeacher add = new AddTeacher(mTeacher);
				add.Owner = this;
				add.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void DG_SelectionChanged(object sender, EventArgs e)
        {
            //button2.Enabled = ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1));
        }

    }
}

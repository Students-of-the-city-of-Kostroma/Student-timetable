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
				MTeacher mTeacher = new MTeacher((ushort)Row.ItemArray[0], (string)Row["FullName"],(string)Row["Note"], (string)Row["Departament"],  (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
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

		private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = DG.Columns[e.ColumnIndex];
			DataGridViewColumn oldColumn = DG.SortedColumn;
			ListSortDirection direction;
			if (DG.Rows == null)
			{
				DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;

				if (oldColumn != null)
				{
					if (oldColumn == newColumn &&
						DG.SortOrder == SortOrder.Ascending)
					{
						direction = ListSortDirection.Descending;
					}
					else
					{
						direction = ListSortDirection.Ascending;
						oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
					}
				}
				else
				{
					direction = ListSortDirection.Ascending;
				}
				//сохраняем номер выделенной строки
				List<ushort> arraySelectedRows = new List<ushort>();
				foreach (DataGridViewRow item in DG.SelectedRows)
				{
					arraySelectedRows.Add((ushort)(item.DataBoundItem as DataRowView).Row.ItemArray[0]);
				}

				DG.Sort(newColumn, direction);

				foreach (DataGridViewRow item in DG.Rows)
				{
					ushort index = (ushort)(item.DataBoundItem as DataRowView).Row.ItemArray[0];
					if (arraySelectedRows.Contains(index))
					{
						item.Selected = true;
					}
				}

				Recount();
			}
		}

		private void Recount()
		{
			for (int i = 0; i < DG.RowCount; i++)
			{
				DG[0, i].Value = i + 1;
			}
		}

		private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}
	}
}

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
			DG.DataSource = Controllers.CTeacher;
		}

        private void AddTeacher(object sender, EventArgs e)
        {
			AddTeacher t = new AddTeacher();
            t.ShowDialog();
        }

		private void RemoveTeacher(object sender, EventArgs e)
		{
			//DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
			if (DG.SelectedRows.Count == 0) return;

			DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			MTeacher mTeacher;
			if (dr == DialogResult.Yes)
			{
				foreach (DataGridViewRow row in DG.SelectedRows)
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
				MTeacher mTeacher = new MTeacher((string)Row["FullName"],(string)Row["Note"], (string)Row["Departament"],  (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
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

			if (DG.SelectedRows.Count == 0) return;
			DataRow Row = ((DataRowView)DG.SelectedRows[0]?.DataBoundItem)?.Row;
			if (Row == null) return;

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
			List<object> arraySelectedRows = new List<object>();
			foreach (DataGridViewRow item in DG.SelectedRows)
			{
				arraySelectedRows.Add(item.DataBoundItem);
			}

			DG.Sort(newColumn, direction);

			foreach (DataGridViewRow item in DG.Rows)
			{
				if (arraySelectedRows.Contains(item.DataBoundItem))
				{
					item.Selected = true;
				}
			} 
		}

		private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}

		private void DG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG.Rows[index].HeaderCell.Value = indexStr;
		}
	}
}

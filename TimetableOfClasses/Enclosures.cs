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
	public partial class Enclosures : Form
	{
		public Enclosures()
		{
			InitializeComponent();
			DG.AutoGenerateColumns = false;
			DG.DataSource = LibOfTimetableOfClasses.RefData.СEnclosures;
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

		private void DG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG.Rows[index].HeaderCell.Value = indexStr;
		}

		private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}

		}

		private void Deletet(object sender, EventArgs e)
		{
			if (DG.SelectedRows.Count == 0) return;
			DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				MEnclosures mEnclosures;
				foreach (DataGridViewRow row in DG.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mEnclosures = new MEnclosures((string)Row["Name"], (string)Row["University"]);
					LibOfTimetableOfClasses.RefData.СEnclosures.Delete(mEnclosures);
				}
			}
		}

		private void Updatet(object sender, EventArgs e)
		{
			if (DG.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
				MEnclosures mEnclosures = new MEnclosures((string)Row[0], (string)Row[1], (string)Row[2], (string)Row[3], (string)Row[4]);
				AddEnclosures addEnclosures = new AddEnclosures(mEnclosures);
				addEnclosures.Owner = this;
				addEnclosures.ShowDialog();
			}
			else if (DG.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
			else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
		}

		private void Added(object sender, EventArgs e)
		{
			AddEnclosures addEnclosures = new AddEnclosures();
			addEnclosures.Owner = this;
			addEnclosures.ShowDialog();
		}
	}
}

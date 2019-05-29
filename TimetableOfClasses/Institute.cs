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
	public partial class Institute : Form
	{
		public Institute()
		{
			InitializeComponent();
			DG_Institute.AutoGenerateColumns = false;
			DG_Institute.DataSource = RefData.CInstitute;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddInstitute addInstitute = new AddInstitute();
			addInstitute.Show();
		}

		private void DG_Institute_SelectionChanged(object sender, EventArgs e)
		{
			if (DG_Institute.SelectedCells.Count > 0)
			{
				btnDelete.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = false;
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (DG_Institute.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_Institute.SelectedRows[0].DataBoundItem).Row;
				MInstitute mInstitute = new MInstitute((string)Row["FullName"], (string)Row["ShortName"], (string)Row["Director"], (string)Row["University"]);
				AddInstitute add = new AddInstitute(mInstitute);
				add.Owner = this;
				add.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}
		private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = DG_Institute.Columns[e.ColumnIndex];
			DataGridViewColumn oldColumn = DG_Institute.SortedColumn;
			ListSortDirection direction;

			if (DG_Institute.SelectedRows.Count == 0) return;
			DataRow Row = ((DataRowView)DG_Institute.SelectedRows[0]?.DataBoundItem)?.Row;
			if (Row == null) return;

			if (oldColumn != null)
			{
				if (oldColumn == newColumn &&
					DG_Institute.SortOrder == SortOrder.Ascending)
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
			foreach (DataGridViewRow item in DG_Institute.SelectedRows)
			{
				arraySelectedRows.Add(item.DataBoundItem);
			}

			DG_Institute.Sort(newColumn, direction);

			foreach (DataGridViewRow item in DG_Institute.Rows)
			{
				if (arraySelectedRows.Contains(item.DataBoundItem))
				{
					item.Selected = true;
				}
			}
		}

		private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG_Institute.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}

		private void DG_Institute_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG_Institute.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG_Institute.Rows[index].HeaderCell.Value = indexStr;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (DG_Institute.Rows.Count == 0)
			{
				MessageBox.Show("Таблица пуста", "Предупреждение");
			}
			else
			{
				string message = "Вы уверны что хотите удалить институт?";
				string caption = "Подтверждение удаления";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result;

				result = MessageBox.Show(message, caption, buttons);
				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					DG_Institute.Rows.RemoveAt(DG_Institute.SelectedCells[0].RowIndex);

				}

			}
		}
	}
}

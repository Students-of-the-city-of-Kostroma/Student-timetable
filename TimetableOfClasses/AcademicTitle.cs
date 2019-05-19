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
	public partial class AcademicTitle : Form
	{
		public AcademicTitle()
		{
			InitializeComponent();
			DG_AcademicTitle.DataSource = Controllers.CTitle;
		}

		private void DG_AcademicTitle_SelectionChanged(object sender, EventArgs e)
		{
			if (DG_AcademicTitle.SelectedCells.Count > 0)
			{
				Delete.Enabled = true;
			}
			else
			{
				Delete.Enabled = false;
			}
		}

		private void Add_Click(object sender, System.EventArgs e)
		{
			AddAcademicTitle addAcademicTitle = new AddAcademicTitle();
			addAcademicTitle.ShowDialog();
		}

		private void Delete_Click(object sender, System.EventArgs e)
		{
			if (DG_AcademicTitle.Rows.Count == 0)
			{
				MessageBox.Show("Таблица пуста", "Предупреждение");
			}
			else
			{
				string message = "Вы уверны что хотите удалить уч. звание?";
				string caption = "Подтверждение удаления";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result;

				result = MessageBox.Show(message, caption, buttons);
				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					try
					{
						DG_AcademicTitle.Rows.RemoveAt(DG_AcademicTitle.SelectedCells[0].RowIndex);
					}
					catch
					{
						MessageBox.Show("Выберите строку для удаления", "Предупреждение");
					}
				}
			}
		}

		private void Change_Click(object sender, EventArgs e)
		{
			if (DG_AcademicTitle.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_AcademicTitle.SelectedRows[0].DataBoundItem).Row;
				MTitle mTitle = new MTitle((string)Row["FullName"], (string)Row["Reduction"]);
				AddAcademicTitle add = new AddAcademicTitle(mTitle);
				add.Owner = this;
				add.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = DG_AcademicTitle.Columns[e.ColumnIndex];
			DataGridViewColumn oldColumn = DG_AcademicTitle.SortedColumn;
			ListSortDirection direction;

			if (DG_AcademicTitle.SelectedRows.Count == 0) return;
			DataRow Row = ((DataRowView)DG_AcademicTitle.SelectedRows[0]?.DataBoundItem)?.Row;
			if (Row == null) return;

			if (oldColumn != null)
			{
				if (oldColumn == newColumn &&
					DG_AcademicTitle.SortOrder == SortOrder.Ascending)
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
			foreach (DataGridViewRow item in DG_AcademicTitle.SelectedRows)
			{
				arraySelectedRows.Add(item.DataBoundItem);
			}

			DG_AcademicTitle.Sort(newColumn, direction);

			foreach (DataGridViewRow item in DG_AcademicTitle.Rows)
			{
				if (arraySelectedRows.Contains(item.DataBoundItem))
				{
					item.Selected = true;
				}
			}
		}

		private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG_AcademicTitle.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}

		private void DG_AcademicTitle_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG_AcademicTitle.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG_AcademicTitle.Rows[index].HeaderCell.Value = indexStr;
		}
	}
}
	





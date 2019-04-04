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
			DG_Group.AutoGenerateColumns = false;
			DG_Group.DataSource = Controllers.CGroup.Select();
		}

		private void DeleteRow(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				if (DG_Group.SelectedRows.Count > 0)
				{
					MGroup mGroup;
					foreach (DataGridViewRow row in DG_Group.SelectedRows)
					{
						DataRow Row = ((DataRowView)row.DataBoundItem).Row;
						mGroup = new MGroup((string)Row["Group"]);
						Controllers.CGroup.Delete(mGroup);
					}
				}
			}
		}

		private void AddRow(object sender, EventArgs e)
		{
			AddGroup addDiscipline = new AddGroup();
			addDiscipline.Owner = this;
			addDiscipline.ShowDialog();
		}

		private void Update(object sender, EventArgs e)
		{
			if (DG_Group.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_Group.SelectedRows[0].DataBoundItem).Row;
				MGroup mGroup = new MGroup((Guid)Row.ItemArray[0], (string)Row["Group"], (ushort)Row["Semestr"], (string)Row["Specialty"], (ushort)Row["Shift"], (ushort)Row["Students"], (ushort)Row["MinNumberOfClass"], (ushort)Row["MaxNumberOfClass"], (string)Row["Weekends"], (ushort)Row.ItemArray[1]);
				AddGroup addDiscipline = new AddGroup(mGroup);
				addDiscipline.Owner = this;
				addDiscipline.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void DG_Group_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = DG_Group.Columns[e.ColumnIndex];


			DataGridViewColumn oldColumn = DG_Group.SortedColumn;
			ListSortDirection direction;

			if (oldColumn != null)
			{
				// Sort the same column again, reversing the SortOrder.
				if (oldColumn == newColumn &&
					DG_Group.SortOrder == SortOrder.Ascending)
				{
					direction = ListSortDirection.Descending;
				}
				else
				{
					// Sort a new column and remove the old SortGlyph.
					direction = ListSortDirection.Ascending;
					oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
				}
			}
			else
			{
				direction = ListSortDirection.Ascending;
			}

			DG_Group.Sort(newColumn, direction);
			for (int i = 0; i < DG_Group.RowCount; i++)
			{
				DG_Group[0, i].Value = i+1;
			}
		}

		private void DG_Group_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG_Group.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}
	}
}

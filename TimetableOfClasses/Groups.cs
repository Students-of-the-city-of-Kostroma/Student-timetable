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
		static CGroup cGroupTmp = new CGroup();
		public Groups()
		{
			InitializeComponent();
			DG_Group.AutoGenerateColumns = false;
			DG_Group.DataSource = cGroupTmp.Select();
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
						cGroupTmp.Delete(mGroup);
					}
				}
			}
		}

		private void AddRow(object sender, EventArgs e)
		{
			AddGroup addDiscipline = new AddGroup(cGroupTmp);
			addDiscipline.Owner = this;
			addDiscipline.ShowDialog();
		}

		private void Update(object sender, EventArgs e)
		{
			if (DG_Group.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_Group.SelectedRows[0].DataBoundItem).Row;
				MGroup mGroup = new MGroup((Guid)Row.ItemArray[0], (string)Row["Group"], (ushort)Row["Semestr"], (string)Row["Specialty"], (ushort)Row["Shift"], (ushort)Row["Students"], (ushort)Row["MinNumberOfClass"], (ushort)Row["MaxNumberOfClass"], (string)Row["Weekends"], (ushort)Row.ItemArray[1]);
				AddGroup addDiscipline = new AddGroup(mGroup,cGroupTmp);
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

			DataRow Row = ((DataRowView)DG_Group.SelectedRows[0].DataBoundItem).Row;

			if (oldColumn != null)
			{
				if (oldColumn == newColumn &&
					DG_Group.SortOrder == SortOrder.Ascending)
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

			DG_Group.Sort(newColumn, direction);
			Recount();

			for(int i=0;i<DG_Group.RowCount;i++)
			{

				DataRow tmpRow = ((DataRowView)DG_Group.Rows[i].DataBoundItem).Row;
				if ((Guid)Row.ItemArray[0] == (Guid)tmpRow.ItemArray[0])
				{
					DG_Group.Rows[i].Selected = true;
				}
			}
		}

		private void Recount()
		{
			for (int i = 0; i < DG_Group.RowCount; i++)
			{
				DG_Group[0, i].Value = i + 1;
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

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
	public partial class University : Form
	{
		public University()
		{
			InitializeComponent();
			DG.AutoGenerateColumns = false;
			DG.DataSource = Controllers.CUniversity;
		}

		private void Add(object sender, EventArgs e)
		{
			AddUniversity t = new AddUniversity();
			t.ShowDialog();
		}

		private void Update(object sender, EventArgs e)
		{
			if (DG.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
				String[] fullName = ((string)Row["FullNameRector"]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				MUniversity mUniversity;
				if (fullName.Length == 3)
				{
					mUniversity = new MUniversity(	(string)Row["INN"], 
													(string)Row["ShortName"], 
													(string)Row["FullName"], 
													(string)Row["ActualAddress"], 
													(string)Row["LegalAddress"], 
													fullName[1], fullName[0], fullName[2], 
													(string)Row["Email"], 
													(string)Row["Phone"]);
				}
				else
				{
					mUniversity = new MUniversity(	(string)Row["INN"], 
													(string)Row["ShortName"], 
													(string)Row["FullName"], 
													(string)Row["ActualAddress"], 
													(string)Row["LegalAddress"], 
													fullName[1], fullName[0], fullName[2], 
													(string)Row["Email"], 
													(string)Row["Phone"]);
				}
				AddUniversity add = new AddUniversity(mUniversity);
				add.Owner = this;
				add.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void Delete(object sender, EventArgs e)
		{
			if (DG.SelectedRows.Count == 0) return;

			DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			MUniversity mUniversity;
			if (dr == DialogResult.Yes)
			{
				foreach (DataGridViewRow row in DG.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mUniversity = new MUniversity((string)Row["INN"]);
					Controllers.CTeacher.Delete(mUniversity);
				}
			}
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

		private void button2_Click(object sender, EventArgs e)
		{
			AddUniversity a = new AddUniversity();
			a.Show();
		}
	}
}

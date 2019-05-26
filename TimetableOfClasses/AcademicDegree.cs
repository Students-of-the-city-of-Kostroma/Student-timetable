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
	public partial class AcademicDegree : Form
	{
		public AcademicDegree()
		{
			InitializeComponent();
			DG_AcademicDegree.AutoGenerateColumns = false;
			DG_AcademicDegree.DataSource = Controllers.CAcademicDegree;
		}


		/// <summary>
		/// Кнопка изменения ученой степени
		/// </summary>
		private void ChangeButton_Click(object sender, EventArgs e)
		{
			if (DG_AcademicDegree.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DG_AcademicDegree.SelectedRows[0].DataBoundItem).Row;
				MAcademicDegree mAcademicDegree = new MAcademicDegree((string)Row["FullName"], (string)Row["Reduction"]);

				AddAcademicDegree addAcademicDegree = new AddAcademicDegree(mAcademicDegree);
				addAcademicDegree.Owner = this;
				addAcademicDegree.Show();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку"); }
		}

		/// <summary>
		/// Кнопка удаления ученой степени
		/// </summary>
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (DG_AcademicDegree.SelectedRows.Count == 0)
			{
				MessageBox.Show("Выделите строчку", "Предупреждение");
				return;
			}
			else
			{
					string message = "Вы уверны что хотите удалить ученую степень?";
					string caption = "Подтверждение удаления";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result;
					result = MessageBox.Show(message, caption, buttons);

					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						MAcademicDegree mAcademicDegree;
						foreach (DataGridViewRow row in DG_AcademicDegree.SelectedRows)
						{
							DataRow Row = ((DataRowView)row.DataBoundItem).Row;
							mAcademicDegree = new MAcademicDegree((string)Row["FullName"]);
							Controllers.CAcademicDegree.Delete(mAcademicDegree);
						}
						DG_AcademicDegree.Rows.RemoveAt(DG_AcademicDegree.SelectedCells[0].RowIndex);
					}
			}
		}

		/// <summary>
		/// Кнопка добавления ученой степени
		/// </summary>
		private void AddButton_Click(object sender, EventArgs e)
		{

		 	AddAcademicDegree addAcademicGegree = new AddAcademicDegree();
			addAcademicGegree.Owner = this;
			addAcademicGegree.Show();
		}

		private void DG_AcademicDegree_SelectionChanged(object sender, EventArgs e)
		{
			if (DG_AcademicDegree.SelectedCells.Count > 0)
			{
				DeleteButton.Enabled = true;
			}
			else
			{
				DeleteButton.Enabled = false;
			}
		}

		private void DG_AcademicDegree_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = DG_AcademicDegree.Columns[e.ColumnIndex];
			DataGridViewColumn oldColumn = DG_AcademicDegree.SortedColumn;
			ListSortDirection direction;

			if (DG_AcademicDegree.SelectedRows.Count == 0) return;
			DataRow Row = ((DataRowView)DG_AcademicDegree.SelectedRows[0]?.DataBoundItem)?.Row;
			if (Row == null) return;

			if (oldColumn != null)
			{
				if (oldColumn == newColumn &&
					 DG_AcademicDegree.SortOrder == SortOrder.Ascending)
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


			List<object> arraySelectedRows = new List<object>();
			foreach (DataGridViewRow item in DG_AcademicDegree.SelectedRows)
			{
				arraySelectedRows.Add(item.DataBoundItem);
			}

			DG_AcademicDegree.Sort(newColumn, direction);

			foreach (DataGridViewRow item in DG_AcademicDegree.Rows)
			{
				if (arraySelectedRows.Contains(item.DataBoundItem))
				{
					item.Selected = true;
				}
			}
		}

		private void DG_AcademicDegree_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn column in DG_AcademicDegree.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
		}

		private void DG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DG_AcademicDegree.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DG_AcademicDegree.Rows[index].HeaderCell.Value = indexStr;
		}


	}
}

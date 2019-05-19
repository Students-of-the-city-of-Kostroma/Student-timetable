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
	public partial class DirectionOfPreparation : Form
	{
		public DirectionOfPreparation(bool forChoice = false)
		{
			InitializeComponent();
			dgDirectionOfPreparation.AutoGenerateColumns = false;
			dgDirectionOfPreparation.DataSource = Controllers.CDirectionOfPreparation;
			btDeleteDirection.Enabled = false;
			btChangeDirection.Enabled = false;
			if (forChoice)
			{
				Name = "Выбор кода";
			}
		}

		private void btAddDirection_Click(object sender, EventArgs e)
		{
			AddDirectionOfPreparation d = new AddDirectionOfPreparation();
			d.ShowDialog();
		}

		private void btDeleteDirection_Click(object sender, EventArgs e)
		{			
			string SelectedName = "";
			foreach (DataGridViewRow row in dgDirectionOfPreparation.SelectedRows)
			{
				DataRow Row = ((DataRowView)row.DataBoundItem).Row;
				SelectedName += (string)Row["NameOfDP"] + ", ";
			}
			if (SelectedName.Length > 2)
				SelectedName = SelectedName.Remove(SelectedName.Length - 2);			
			if (SelectedName != "")
			{
				DialogResult dr = MessageBox.Show("Удалить направление - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (dgDirectionOfPreparation.SelectedRows.Count > 0 && dr == DialogResult.OK)
				{
					int countSelected = dgDirectionOfPreparation.SelectedRows.Count;
					
					MDirectionOfPreparation Direction;
					foreach (DataGridViewRow row in dgDirectionOfPreparation.SelectedRows)
					{
						DataRow Row = ((DataRowView)row.DataBoundItem).Row;
						Direction = new MDirectionOfPreparation((string)Row["CodeOfDP"], (string)Row["NameOfDP"], (ushort)Row["PeriodOfStudy"]);
						Controllers.CDirectionOfPreparation.Delete(Direction);
					}
				}
			}
		}

		private void dgDirectionOfPreparation_SelectionChanged(object sender, EventArgs e)
		{
			if (dgDirectionOfPreparation.SelectedCells.Count > 0)
			{
				btDeleteDirection.Enabled = true;
				btChangeDirection.Enabled = true;
			}
			else
			{
				btDeleteDirection.Enabled = false;
				btChangeDirection.Enabled = false;
			}
		}

		private void btChangeDirection_Click(object sender, EventArgs e)
		{
			if (dgDirectionOfPreparation.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)dgDirectionOfPreparation.SelectedRows[0].DataBoundItem).Row;
				MDirectionOfPreparation Direction = new MDirectionOfPreparation((string)Row["CodeOfDP"], (string)Row["NameOfDP"], (ushort)Row["PeriodOfStudy"]);
				AddDirectionOfPreparation add = new AddDirectionOfPreparation(Direction);
				add.Owner = this;
				add.ShowDialog();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void dgDirectionOfPreparation_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = dgDirectionOfPreparation.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				dgDirectionOfPreparation.Rows[index].HeaderCell.Value = indexStr;
		}

		private void dgDirectionOfPreparation_DoubleClick(object sender, EventArgs e)
		{
			if (Name == "Выбор кода")
			{
				DataRow Row = ((DataRowView)dgDirectionOfPreparation.SelectedRows[0].DataBoundItem).Row;
				(Owner as AddProfile).codeSpec = (string)Row["CodeOfDP"];
				Close();
			}
		}
	}
}

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

    public partial class Auditor : Form
    {
     public Auditor()
     {
      InitializeComponent();
			DataGridAuditor.AutoGenerateColumns = false;
			DataGridAuditor.DataSource = Controllers.CAuditor;
		 }

		private void btAddAuditor_Click(object sender, EventArgs e)
		{
			AddAuditor a = new AddAuditor();
			a.Show();
		}

		private void btDelAuditor_Click(object sender, EventArgs e)
		{
			string SelectedName = "";
			foreach (DataGridViewRow row in DataGridAuditor.SelectedRows)
			{
				DataRow Row = ((DataRowView)row.DataBoundItem).Row;
				SelectedName += (string)Row["NameOfAuditor"] + ", ";
			}
			if (SelectedName.Length > 2)
				SelectedName = SelectedName.Remove(SelectedName.Length - 2);
			DialogResult dr = MessageBox.Show("Удалить аудиторию - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (DataGridAuditor.SelectedRows.Count > 0 && dr == DialogResult.OK)
			{
				int countSelected = DataGridAuditor.SelectedRows.Count;

				MAuditor mAuditor;
				foreach (DataGridViewRow row in DataGridAuditor.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mAuditor = new MAuditor((string)Row["NameOfAuditor"], (string)Row["Cafedra"], (ushort)Row["Spacious"], (string)Row["Building"]);
					Controllers.CAuditor.Delete(mAuditor);
				}
			}
			
		}
		private void DataGridAuditor_SelectionChanged(object sender, EventArgs e)
		{
			if (DataGridAuditor.SelectedCells.Count > 0)
			{
				btDelAuditor.Enabled = true;
				btChange.Enabled = true;
			}
			else
			{
				btDelAuditor.Enabled = false;
				btChange.Enabled = false;
			}
		}

		private void btChange_Click(object sender, EventArgs e)
		{
			if (DataGridAuditor.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)DataGridAuditor.SelectedRows[0].DataBoundItem).Row;
				MAuditor mAuditor = new MAuditor((string)Row["NameOfAuditor"], (string)Row["Cafedra"], (ushort)Row["Spacious"], (string)Row["Building"]);
				AddAuditor add = new AddAuditor(mAuditor);
				add.Owner = this;
				add.Show();
			}
			else { MessageBox.Show("Для изменения выделите только одну строку!"); }
		}

		private void DataGridAuditor_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			int index = e.RowIndex;
			string indexStr = (index + 1).ToString();
			object header = this.DataGridAuditor.Rows[index].HeaderCell.Value;
			if (header == null || !header.Equals(indexStr))
				this.DataGridAuditor.Rows[index].HeaderCell.Value = indexStr;
		}
	}
}

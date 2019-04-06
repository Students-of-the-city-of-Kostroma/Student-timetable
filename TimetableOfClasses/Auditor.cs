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
			DataGridAuditor.DataSource = Controllers.CAuditor.Select();
		 }

		private void btAddAuditor_Click(object sender, EventArgs e)
		{
			AddAuditor a = new AddAuditor();
			a.ShowDialog();
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
					mAuditor = new MAuditor((string)Row["NameOfAuditor"], (string)Row["Cafedra"], (ushort)Row["Spacious"], (byte)Row["Building"]);
					Controllers.CAuditor.Delete(mAuditor);
				}
			}
			
		}

		private void DataGridAuditor_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridView grid = sender as DataGridView;
			for (int i = 0; i < grid.Rows.Count; i++)
				grid.Rows[i].Cells[0].Value = (i + 1).ToString();
		}
	}
}

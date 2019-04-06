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

		private void DataGridAuditor_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridView grid = sender as DataGridView;
			for (int i = 0; i < grid.Rows.Count; i++)
				grid.Rows[i].Cells[0].Value = (i+1).ToString();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
	public partial class Characteristic : Form
	{
		public Characteristic() => InitializeComponent();
		private void setRowNumber(DataGridView dgv)
		{
			foreach (DataGridViewRow row in dgv.Rows)
			{
				row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
			}
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

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
	public partial class Directory : Form
	{
		public Directory()
		{
			InitializeComponent();
		}

		public void UploadTable(DataTable table)
		{
			dataGridView1.DataSource = table;
			this.Text = table.TableName;
		}
	}
}
